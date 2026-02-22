using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Uniject;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000070 RID: 112
	public class StandardPurchasingModule : AbstractPurchasingModule
	{
		// Token: 0x06000466 RID: 1126 RVA: 0x000144D0 File Offset: 0x000126D0
		// Note: this type is marked as 'beforefieldinit'.
		static StandardPurchasingModule()
		{
			Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "StandardPurchasingModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr);
			StandardPurchasingModule.NativeFieldInfoPtr_k_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, "k_Version");
			StandardPurchasingModule.NativeFieldInfoPtr_m_AppStorePlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, "m_AppStorePlatform");
			StandardPurchasingModule.NativeFieldInfoPtr_m_NativeStoreProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, "m_NativeStoreProvider");
			StandardPurchasingModule.NativeFieldInfoPtr_m_RuntimePlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, "m_RuntimePlatform");
			StandardPurchasingModule.NativeFieldInfoPtr_m_UseCloudCatalog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, "m_UseCloudCatalog");
			StandardPurchasingModule.NativeFieldInfoPtr__m_persistentDataPath_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, "<m_persistentDataPath>k__BackingField");
			StandardPurchasingModule.NativeFieldInfoPtr_ModuleInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, "ModuleInstance");
			StandardPurchasingModule.NativeFieldInfoPtr__util_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, "<util>k__BackingField");
			StandardPurchasingModule.NativeFieldInfoPtr__logger_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, "<logger>k__BackingField");
			StandardPurchasingModule.NativeFieldInfoPtr__webUtil_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, "<webUtil>k__BackingField");
			StandardPurchasingModule.NativeFieldInfoPtr__storeInstance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, "<storeInstance>k__BackingField");
			StandardPurchasingModule.NativeFieldInfoPtr_AndroidStoreNameMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, "AndroidStoreNameMap");
			StandardPurchasingModule.NativeFieldInfoPtr_m_CloudCatalog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, "m_CloudCatalog");
			StandardPurchasingModule.NativeFieldInfoPtr__useFakeStoreUIMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, "<useFakeStoreUIMode>k__BackingField");
			StandardPurchasingModule.NativeFieldInfoPtr__useFakeStoreAlways_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, "<useFakeStoreAlways>k__BackingField");
			StandardPurchasingModule.NativeFieldInfoPtr_windowsStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, "windowsStore");
			StandardPurchasingModule.NativeMethodInfoPtr_get_Version_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663831);
			StandardPurchasingModule.NativeMethodInfoPtr_get_m_persistentDataPath_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663832);
			StandardPurchasingModule.NativeMethodInfoPtr_set_m_persistentDataPath_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663833);
			StandardPurchasingModule.NativeMethodInfoPtr_get_util_Internal_get_IUtil_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663834);
			StandardPurchasingModule.NativeMethodInfoPtr_set_util_Private_set_Void_IUtil_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663835);
			StandardPurchasingModule.NativeMethodInfoPtr_get_logger_Internal_get_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663836);
			StandardPurchasingModule.NativeMethodInfoPtr_set_logger_Private_set_Void_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663837);
			StandardPurchasingModule.NativeMethodInfoPtr_get_webUtil_Internal_get_IAsyncWebUtil_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663838);
			StandardPurchasingModule.NativeMethodInfoPtr_set_webUtil_Private_set_Void_IAsyncWebUtil_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663839);
			StandardPurchasingModule.NativeMethodInfoPtr_get_storeInstance_Internal_get_StoreInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663840);
			StandardPurchasingModule.NativeMethodInfoPtr_set_storeInstance_Private_set_Void_StoreInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663841);
			StandardPurchasingModule.NativeMethodInfoPtr__ctor_Internal_Void_IUtil_IAsyncWebUtil_ILogger_INativeStoreProvider_RuntimePlatform_AppStore_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663842);
			StandardPurchasingModule.NativeMethodInfoPtr_get_useFakeStoreUIMode_Public_get_FakeStoreUIMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663843);
			StandardPurchasingModule.NativeMethodInfoPtr_set_useFakeStoreUIMode_Public_set_Void_FakeStoreUIMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663844);
			StandardPurchasingModule.NativeMethodInfoPtr_get_useFakeStoreAlways_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663845);
			StandardPurchasingModule.NativeMethodInfoPtr_set_useFakeStoreAlways_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663846);
			StandardPurchasingModule.NativeMethodInfoPtr_Instance_Public_Static_StandardPurchasingModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663847);
			StandardPurchasingModule.NativeMethodInfoPtr_Instance_Public_Static_StandardPurchasingModule_AppStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663848);
			StandardPurchasingModule.NativeMethodInfoPtr_Configure_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663849);
			StandardPurchasingModule.NativeMethodInfoPtr_InstantiateStore_Private_StoreInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663850);
			StandardPurchasingModule.NativeMethodInfoPtr_InstantiateAndroid_Private_IStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663851);
			StandardPurchasingModule.NativeMethodInfoPtr_InstantiateGoogleStore_Private_IStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663852);
			StandardPurchasingModule.NativeMethodInfoPtr_BindGoogleConfiguration_Private_Void_IGooglePlayConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663853);
			StandardPurchasingModule.NativeMethodInfoPtr_BindGoogleExtension_Private_Void_GooglePlayStoreExtensions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663854);
			StandardPurchasingModule.NativeMethodInfoPtr_BuildGooglePlayStoreExtensions_Private_Static_GooglePlayStoreExtensions_IGooglePlayStoreService_IGooglePlayStoreFinishTransactionService_IGooglePurchaseCallback_GooglePlayStoreExtensionsInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663855);
			StandardPurchasingModule.NativeMethodInfoPtr_BuildGooglePlayStoreServiceAar_Private_Static_IGooglePlayStoreService_IGooglePurchaseCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663856);
			StandardPurchasingModule.NativeMethodInfoPtr_InstantiateUDP_Private_IStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663857);
			StandardPurchasingModule.NativeMethodInfoPtr_InstantiateAndroidHelper_Private_IStore_JSONStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663858);
			StandardPurchasingModule.NativeMethodInfoPtr_GetAndroidNativeStore_Private_INativeStore_JSONStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663859);
			StandardPurchasingModule.NativeMethodInfoPtr_InstantiateApple_Private_IStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663860);
			StandardPurchasingModule.NativeMethodInfoPtr_instantiateWindowsStore_Private_IStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663861);
			StandardPurchasingModule.NativeMethodInfoPtr_InstantiateFakeStore_Private_IStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663862);
			StandardPurchasingModule.NativeMethodInfoPtr__Configure_b__52_0_Private_Void_Action_1_HashSet_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, 100663864);
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x000148D4 File Offset: 0x00012AD4
		public unsafe string Version
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_get_Version_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0001490C File Offset: 0x00012B0C
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x00014944 File Offset: 0x00012B44
		public unsafe string m_persistentDataPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_get_m_persistentDataPath_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_set_m_persistentDataPath_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x00014988 File Offset: 0x00012B88
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x000149C8 File Offset: 0x00012BC8
		public unsafe IUtil util
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_get_util_Internal_get_IUtil_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IUtil>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_set_util_Private_set_Void_IUtil_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00014A0C File Offset: 0x00012C0C
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x00014A4C File Offset: 0x00012C4C
		public unsafe ILogger logger
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_get_logger_Internal_get_ILogger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_set_logger_Private_set_Void_ILogger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x00014A90 File Offset: 0x00012C90
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x00014AD0 File Offset: 0x00012CD0
		public unsafe IAsyncWebUtil webUtil
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_get_webUtil_Internal_get_IAsyncWebUtil_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncWebUtil>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_set_webUtil_Private_set_Void_IAsyncWebUtil_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x00014B14 File Offset: 0x00012D14
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x00014B54 File Offset: 0x00012D54
		public unsafe StandardPurchasingModule.StoreInstance storeInstance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_get_storeInstance_Internal_get_StoreInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StandardPurchasingModule.StoreInstance>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_set_storeInstance_Private_set_Void_StoreInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00014B98 File Offset: 0x00012D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155596, XrefRangeEnd = 155605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StandardPurchasingModule(IUtil util, IAsyncWebUtil webUtil, ILogger logger, INativeStoreProvider nativeStoreProvider, RuntimePlatform platform, AppStore android, bool useCloudCatalog, string persistentDataPath)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(util);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(webUtil);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(logger);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nativeStoreProvider);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref platform;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref android;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useCloudCatalog;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(persistentDataPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr__ctor_Internal_Void_IUtil_IAsyncWebUtil_ILogger_INativeStoreProvider_RuntimePlatform_AppStore_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00014C58 File Offset: 0x00012E58
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x00014C94 File Offset: 0x00012E94
		public unsafe FakeStoreUIMode useFakeStoreUIMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12786, RefRangeEnd = 12787, XrefRangeStart = 12786, XrefRangeEnd = 12787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_get_useFakeStoreUIMode_Public_get_FakeStoreUIMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_set_useFakeStoreUIMode_Public_set_Void_FakeStoreUIMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00014CD4 File Offset: 0x00012ED4
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x00014D10 File Offset: 0x00012F10
		public unsafe bool useFakeStoreAlways
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_get_useFakeStoreAlways_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_set_useFakeStoreAlways_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00014D50 File Offset: 0x00012F50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155609, RefRangeEnd = 155610, XrefRangeStart = 155605, XrefRangeEnd = 155609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StandardPurchasingModule Instance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_Instance_Public_Static_StandardPurchasingModule_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StandardPurchasingModule>(intPtr3) : null;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00014D84 File Offset: 0x00012F84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155672, RefRangeEnd = 155673, XrefRangeStart = 155610, XrefRangeEnd = 155672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StandardPurchasingModule Instance(AppStore androidStore)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref androidStore;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_Instance_Public_Static_StandardPurchasingModule_AppStore_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StandardPurchasingModule>(intPtr3) : null;
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00014DC4 File Offset: 0x00012FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155673, XrefRangeEnd = 155817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Configure()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandardPurchasingModule.NativeMethodInfoPtr_Configure_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00014E00 File Offset: 0x00013000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155896, RefRangeEnd = 155897, XrefRangeStart = 155817, XrefRangeEnd = 155896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StandardPurchasingModule.StoreInstance InstantiateStore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_InstantiateStore_Private_StoreInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StandardPurchasingModule.StoreInstance>(intPtr3) : null;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00014E40 File Offset: 0x00013040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155897, XrefRangeEnd = 155922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IStore InstantiateAndroid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_InstantiateAndroid_Private_IStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IStore>(intPtr3) : null;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00014E80 File Offset: 0x00013080
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155995, RefRangeEnd = 155996, XrefRangeStart = 155922, XrefRangeEnd = 155995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IStore InstantiateGoogleStore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_InstantiateGoogleStore_Private_IStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IStore>(intPtr3) : null;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00014EC0 File Offset: 0x000130C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155996, XrefRangeEnd = 155999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BindGoogleConfiguration(IGooglePlayConfiguration googlePlayConfiguration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(googlePlayConfiguration);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_BindGoogleConfiguration_Private_Void_IGooglePlayConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00014F04 File Offset: 0x00013104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155999, XrefRangeEnd = 156002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BindGoogleExtension(GooglePlayStoreExtensions googlePlayStoreExtensions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(googlePlayStoreExtensions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_BindGoogleExtension_Private_Void_GooglePlayStoreExtensions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00014F48 File Offset: 0x00013148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156002, XrefRangeEnd = 156009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GooglePlayStoreExtensions BuildGooglePlayStoreExtensions(IGooglePlayStoreService googlePlayStoreService, IGooglePlayStoreFinishTransactionService googlePlayStoreFinishTransactionService, IGooglePurchaseCallback googlePurchaseCallback, GooglePlayStoreExtensionsInternal googlePlayStoreExtensionsInternal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(googlePlayStoreService);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(googlePlayStoreFinishTransactionService);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(googlePurchaseCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(googlePlayStoreExtensionsInternal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_BuildGooglePlayStoreExtensions_Private_Static_GooglePlayStoreExtensions_IGooglePlayStoreService_IGooglePlayStoreFinishTransactionService_IGooglePurchaseCallback_GooglePlayStoreExtensionsInternal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GooglePlayStoreExtensions>(intPtr3) : null;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00014FC4 File Offset: 0x000131C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156077, RefRangeEnd = 156078, XrefRangeStart = 156009, XrefRangeEnd = 156077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IGooglePlayStoreService BuildGooglePlayStoreServiceAar(IGooglePurchaseCallback googlePurchaseCallback)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(googlePurchaseCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_BuildGooglePlayStoreServiceAar_Private_Static_IGooglePlayStoreService_IGooglePurchaseCallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGooglePlayStoreService>(intPtr3) : null;
			}
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00015008 File Offset: 0x00013208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156078, XrefRangeEnd = 156089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IStore InstantiateUDP()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_InstantiateUDP_Private_IStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IStore>(intPtr3) : null;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00015048 File Offset: 0x00013248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156089, XrefRangeEnd = 156090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IStore InstantiateAndroidHelper(JSONStore store)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(store);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_InstantiateAndroidHelper_Private_IStore_JSONStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IStore>(intPtr3) : null;
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00015098 File Offset: 0x00013298
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 156093, RefRangeEnd = 156098, XrefRangeStart = 156090, XrefRangeEnd = 156093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe INativeStore GetAndroidNativeStore(JSONStore store)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(store);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_GetAndroidNativeStore_Private_INativeStore_JSONStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<INativeStore>(intPtr3) : null;
			}
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x000150E8 File Offset: 0x000132E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156098, XrefRangeEnd = 156120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IStore InstantiateApple()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_InstantiateApple_Private_IStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IStore>(intPtr3) : null;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00015128 File Offset: 0x00013328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156120, XrefRangeEnd = 156136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IStore instantiateWindowsStore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_instantiateWindowsStore_Private_IStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IStore>(intPtr3) : null;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00015168 File Offset: 0x00013368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156136, XrefRangeEnd = 156147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IStore InstantiateFakeStore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr_InstantiateFakeStore_Private_IStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IStore>(intPtr3) : null;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x000151A8 File Offset: 0x000133A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156147, XrefRangeEnd = 156167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Configure_b__52_0(Action<HashSet<ProductDefinition>> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.NativeMethodInfoPtr__Configure_b__52_0_Private_Void_Action_1_HashSet_1_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00004387 File Offset: 0x00002587
		public StandardPurchasingModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x000151EC File Offset: 0x000133EC
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x00004390 File Offset: 0x00002590
		public unsafe string k_Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr_k_Version);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr_k_Version), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00015214 File Offset: 0x00013414
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x000043AF File Offset: 0x000025AF
		public unsafe AppStore m_AppStorePlatform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr_m_AppStorePlatform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr_m_AppStorePlatform)) = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x0001523C File Offset: 0x0001343C
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x000043CA File Offset: 0x000025CA
		public unsafe INativeStoreProvider m_NativeStoreProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr_m_NativeStoreProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<INativeStoreProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr_m_NativeStoreProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x0001526C File Offset: 0x0001346C
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x000043E9 File Offset: 0x000025E9
		public unsafe RuntimePlatform m_RuntimePlatform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr_m_RuntimePlatform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr_m_RuntimePlatform)) = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00015294 File Offset: 0x00013494
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x00004404 File Offset: 0x00002604
		public unsafe bool m_UseCloudCatalog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr_m_UseCloudCatalog);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr_m_UseCloudCatalog)) = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x000152BC File Offset: 0x000134BC
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x0000441F File Offset: 0x0000261F
		public unsafe string _m_persistentDataPath_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr__m_persistentDataPath_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr__m_persistentDataPath_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x000152E4 File Offset: 0x000134E4
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x0000443E File Offset: 0x0000263E
		public unsafe static StandardPurchasingModule ModuleInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StandardPurchasingModule.NativeFieldInfoPtr_ModuleInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StandardPurchasingModule>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StandardPurchasingModule.NativeFieldInfoPtr_ModuleInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x0001530C File Offset: 0x0001350C
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x00004450 File Offset: 0x00002650
		public unsafe IUtil _util_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr__util_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IUtil>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr__util_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x0001533C File Offset: 0x0001353C
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x0000446F File Offset: 0x0000266F
		public unsafe ILogger _logger_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr__logger_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr__logger_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x0001536C File Offset: 0x0001356C
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x0000448E File Offset: 0x0000268E
		public unsafe IAsyncWebUtil _webUtil_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr__webUtil_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAsyncWebUtil>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr__webUtil_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x0001539C File Offset: 0x0001359C
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x000044AD File Offset: 0x000026AD
		public unsafe StandardPurchasingModule.StoreInstance _storeInstance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr__storeInstance_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StandardPurchasingModule.StoreInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr__storeInstance_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x000153CC File Offset: 0x000135CC
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x000044CC File Offset: 0x000026CC
		public unsafe static Dictionary<AppStore, string> AndroidStoreNameMap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StandardPurchasingModule.NativeFieldInfoPtr_AndroidStoreNameMap, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AppStore, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StandardPurchasingModule.NativeFieldInfoPtr_AndroidStoreNameMap, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x000153F4 File Offset: 0x000135F4
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x000044DE File Offset: 0x000026DE
		public unsafe CloudCatalogImpl m_CloudCatalog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr_m_CloudCatalog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CloudCatalogImpl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr_m_CloudCatalog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00015424 File Offset: 0x00013624
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x000044FD File Offset: 0x000026FD
		public unsafe FakeStoreUIMode _useFakeStoreUIMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr__useFakeStoreUIMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr__useFakeStoreUIMode_k__BackingField)) = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x0001544C File Offset: 0x0001364C
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00004518 File Offset: 0x00002718
		public unsafe bool _useFakeStoreAlways_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr__useFakeStoreAlways_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr__useFakeStoreAlways_k__BackingField)) = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00015474 File Offset: 0x00013674
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x00004533 File Offset: 0x00002733
		public unsafe WinRTStore windowsStore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr_windowsStore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WinRTStore>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.NativeFieldInfoPtr_windowsStore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeFieldInfoPtr_k_Version;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeFieldInfoPtr_m_AppStorePlatform;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeFieldInfoPtr_m_NativeStoreProvider;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeFieldInfoPtr_m_RuntimePlatform;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeFieldInfoPtr_m_UseCloudCatalog;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeFieldInfoPtr__m_persistentDataPath_k__BackingField;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeFieldInfoPtr_ModuleInstance;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeFieldInfoPtr__util_k__BackingField;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeFieldInfoPtr__logger_k__BackingField;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeFieldInfoPtr__webUtil_k__BackingField;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeFieldInfoPtr__storeInstance_k__BackingField;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeFieldInfoPtr_AndroidStoreNameMap;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeFieldInfoPtr_m_CloudCatalog;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeFieldInfoPtr__useFakeStoreUIMode_k__BackingField;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeFieldInfoPtr__useFakeStoreAlways_k__BackingField;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeFieldInfoPtr_windowsStore;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_String_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_get_m_persistentDataPath_Private_get_String_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_set_m_persistentDataPath_Private_set_Void_String_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_get_util_Internal_get_IUtil_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr_set_util_Private_set_Void_IUtil_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr_get_logger_Internal_get_ILogger_0;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_set_logger_Private_set_Void_ILogger_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_get_webUtil_Internal_get_IAsyncWebUtil_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_set_webUtil_Private_set_Void_IAsyncWebUtil_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_get_storeInstance_Internal_get_StoreInstance_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_set_storeInstance_Private_set_Void_StoreInstance_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IUtil_IAsyncWebUtil_ILogger_INativeStoreProvider_RuntimePlatform_AppStore_Boolean_String_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_get_useFakeStoreUIMode_Public_get_FakeStoreUIMode_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_set_useFakeStoreUIMode_Public_set_Void_FakeStoreUIMode_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_get_useFakeStoreAlways_Public_get_Boolean_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_set_useFakeStoreAlways_Public_set_Void_Boolean_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_Instance_Public_Static_StandardPurchasingModule_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_Instance_Public_Static_StandardPurchasingModule_AppStore_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Virtual_Void_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateStore_Private_StoreInstance_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAndroid_Private_IStore_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateGoogleStore_Private_IStore_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_BindGoogleConfiguration_Private_Void_IGooglePlayConfiguration_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_BindGoogleExtension_Private_Void_GooglePlayStoreExtensions_0;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr_BuildGooglePlayStoreExtensions_Private_Static_GooglePlayStoreExtensions_IGooglePlayStoreService_IGooglePlayStoreFinishTransactionService_IGooglePurchaseCallback_GooglePlayStoreExtensionsInternal_0;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeMethodInfoPtr_BuildGooglePlayStoreServiceAar_Private_Static_IGooglePlayStoreService_IGooglePurchaseCallback_0;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateUDP_Private_IStore_0;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAndroidHelper_Private_IStore_JSONStore_0;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr_GetAndroidNativeStore_Private_INativeStore_JSONStore_0;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateApple_Private_IStore_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_instantiateWindowsStore_Private_IStore_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateFakeStore_Private_IStore_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr__Configure_b__52_0_Private_Void_Action_1_HashSet_1_ProductDefinition_0;

		// Token: 0x020000C2 RID: 194
		public class StoreInstance : Object
		{
			// Token: 0x0600070C RID: 1804 RVA: 0x0001C924 File Offset: 0x0001AB24
			// Note: this type is marked as 'beforefieldinit'.
			static StoreInstance()
			{
				Il2CppClassPointerStore<StandardPurchasingModule.StoreInstance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, "StoreInstance");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandardPurchasingModule.StoreInstance>.NativeClassPtr);
				StandardPurchasingModule.StoreInstance.NativeFieldInfoPtr__storeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardPurchasingModule.StoreInstance>.NativeClassPtr, "<storeName>k__BackingField");
				StandardPurchasingModule.StoreInstance.NativeFieldInfoPtr__instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardPurchasingModule.StoreInstance>.NativeClassPtr, "<instance>k__BackingField");
				StandardPurchasingModule.StoreInstance.NativeMethodInfoPtr_get_storeName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule.StoreInstance>.NativeClassPtr, 100663865);
				StandardPurchasingModule.StoreInstance.NativeMethodInfoPtr_get_instance_Internal_get_IStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule.StoreInstance>.NativeClassPtr, 100663866);
				StandardPurchasingModule.StoreInstance.NativeMethodInfoPtr__ctor_Internal_Void_String_IStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule.StoreInstance>.NativeClassPtr, 100663867);
			}

			// Token: 0x170001CB RID: 459
			// (get) Token: 0x0600070D RID: 1805 RVA: 0x0001C9B4 File Offset: 0x0001ABB4
			public unsafe string storeName
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.StoreInstance.NativeMethodInfoPtr_get_storeName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170001CC RID: 460
			// (get) Token: 0x0600070E RID: 1806 RVA: 0x0001C9EC File Offset: 0x0001ABEC
			public unsafe IStore instance
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.StoreInstance.NativeMethodInfoPtr_get_instance_Internal_get_IStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IStore>(intPtr3) : null;
				}
			}

			// Token: 0x0600070F RID: 1807 RVA: 0x0001CA2C File Offset: 0x0001AC2C
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StoreInstance(string name, IStore instance)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandardPurchasingModule.StoreInstance>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.StoreInstance.NativeMethodInfoPtr__ctor_Internal_Void_String_IStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000710 RID: 1808 RVA: 0x000058E8 File Offset: 0x00003AE8
			public StoreInstance(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001C9 RID: 457
			// (get) Token: 0x06000711 RID: 1809 RVA: 0x0001CA8C File Offset: 0x0001AC8C
			// (set) Token: 0x06000712 RID: 1810 RVA: 0x000058F1 File Offset: 0x00003AF1
			public unsafe string _storeName_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.StoreInstance.NativeFieldInfoPtr__storeName_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.StoreInstance.NativeFieldInfoPtr__storeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170001CA RID: 458
			// (get) Token: 0x06000713 RID: 1811 RVA: 0x0001CAB4 File Offset: 0x0001ACB4
			// (set) Token: 0x06000714 RID: 1812 RVA: 0x00005910 File Offset: 0x00003B10
			public unsafe IStore _instance_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.StoreInstance.NativeFieldInfoPtr__instance_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStore>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.StoreInstance.NativeFieldInfoPtr__instance_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000495 RID: 1173
			private static readonly IntPtr NativeFieldInfoPtr__storeName_k__BackingField;

			// Token: 0x04000496 RID: 1174
			private static readonly IntPtr NativeFieldInfoPtr__instance_k__BackingField;

			// Token: 0x04000497 RID: 1175
			private static readonly IntPtr NativeMethodInfoPtr_get_storeName_Internal_get_String_0;

			// Token: 0x04000498 RID: 1176
			private static readonly IntPtr NativeMethodInfoPtr_get_instance_Internal_get_IStore_0;

			// Token: 0x04000499 RID: 1177
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_IStore_0;
		}

		// Token: 0x020000C3 RID: 195
		public class MicrosoftConfiguration : Object
		{
			// Token: 0x06000715 RID: 1813 RVA: 0x0001CAE4 File Offset: 0x0001ACE4
			// Note: this type is marked as 'beforefieldinit'.
			static MicrosoftConfiguration()
			{
				Il2CppClassPointerStore<StandardPurchasingModule.MicrosoftConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StandardPurchasingModule>.NativeClassPtr, "MicrosoftConfiguration");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandardPurchasingModule.MicrosoftConfiguration>.NativeClassPtr);
				StandardPurchasingModule.MicrosoftConfiguration.NativeFieldInfoPtr_module = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardPurchasingModule.MicrosoftConfiguration>.NativeClassPtr, "module");
				StandardPurchasingModule.MicrosoftConfiguration.NativeMethodInfoPtr__ctor_Public_Void_StandardPurchasingModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardPurchasingModule.MicrosoftConfiguration>.NativeClassPtr, 100663868);
			}

			// Token: 0x06000716 RID: 1814 RVA: 0x0001CB38 File Offset: 0x0001AD38
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MicrosoftConfiguration(StandardPurchasingModule module)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandardPurchasingModule.MicrosoftConfiguration>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(module);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardPurchasingModule.MicrosoftConfiguration.NativeMethodInfoPtr__ctor_Public_Void_StandardPurchasingModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000717 RID: 1815 RVA: 0x0000592F File Offset: 0x00003B2F
			public MicrosoftConfiguration(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001CD RID: 461
			// (get) Token: 0x06000718 RID: 1816 RVA: 0x0001CB84 File Offset: 0x0001AD84
			// (set) Token: 0x06000719 RID: 1817 RVA: 0x00005938 File Offset: 0x00003B38
			public unsafe StandardPurchasingModule module
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.MicrosoftConfiguration.NativeFieldInfoPtr_module);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StandardPurchasingModule>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardPurchasingModule.MicrosoftConfiguration.NativeFieldInfoPtr_module), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400049A RID: 1178
			private static readonly IntPtr NativeFieldInfoPtr_module;

			// Token: 0x0400049B RID: 1179
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StandardPurchasingModule_0;
		}
	}
}
