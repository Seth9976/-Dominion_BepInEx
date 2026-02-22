using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000395 RID: 917
	public static class RemotingConfiguration : Object
	{
		// Token: 0x06003B92 RID: 15250 RVA: 0x00119250 File Offset: 0x00117450
		// Note: this type is marked as 'beforefieldinit'.
		static RemotingConfiguration()
		{
			Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "RemotingConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr);
			RemotingConfiguration.NativeFieldInfoPtr_applicationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "applicationID");
			RemotingConfiguration.NativeFieldInfoPtr_applicationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "applicationName");
			RemotingConfiguration.NativeFieldInfoPtr_processGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "processGuid");
			RemotingConfiguration.NativeFieldInfoPtr_defaultConfigRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "defaultConfigRead");
			RemotingConfiguration.NativeFieldInfoPtr_defaultDelayedConfigRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "defaultDelayedConfigRead");
			RemotingConfiguration.NativeFieldInfoPtr__errorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "_errorMode");
			RemotingConfiguration.NativeFieldInfoPtr_wellKnownClientEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "wellKnownClientEntries");
			RemotingConfiguration.NativeFieldInfoPtr_activatedClientEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "activatedClientEntries");
			RemotingConfiguration.NativeFieldInfoPtr_wellKnownServiceEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "wellKnownServiceEntries");
			RemotingConfiguration.NativeFieldInfoPtr_activatedServiceEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "activatedServiceEntries");
			RemotingConfiguration.NativeFieldInfoPtr_channelTemplates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "channelTemplates");
			RemotingConfiguration.NativeFieldInfoPtr_clientProviderTemplates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "clientProviderTemplates");
			RemotingConfiguration.NativeFieldInfoPtr_serverProviderTemplates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, "serverProviderTemplates");
			RemotingConfiguration.NativeMethodInfoPtr_get_ApplicationName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672099);
			RemotingConfiguration.NativeMethodInfoPtr_set_ApplicationName_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672100);
			RemotingConfiguration.NativeMethodInfoPtr_get_ProcessId_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672101);
			RemotingConfiguration.NativeMethodInfoPtr_LoadDefaultDelayedChannels_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672102);
			RemotingConfiguration.NativeMethodInfoPtr_IsActivationAllowed_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672103);
			RemotingConfiguration.NativeMethodInfoPtr_IsRemotelyActivatedClientType_Public_Static_ActivatedClientTypeEntry_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672104);
			RemotingConfiguration.NativeMethodInfoPtr_IsWellKnownClientType_Public_Static_WellKnownClientTypeEntry_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672105);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterActivatedClientType_Public_Static_Void_ActivatedClientTypeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672106);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterActivatedServiceType_Public_Static_Void_ActivatedServiceTypeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672107);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterWellKnownClientType_Public_Static_Void_WellKnownClientTypeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672108);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterWellKnownServiceType_Public_Static_Void_WellKnownServiceTypeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672109);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterChannelTemplate_Internal_Static_Void_ChannelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672110);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterClientProviderTemplate_Internal_Static_Void_ProviderData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672111);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterServerProviderTemplate_Internal_Static_Void_ProviderData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672112);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterChannels_Internal_Static_Void_ArrayList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672113);
			RemotingConfiguration.NativeMethodInfoPtr_RegisterTypes_Internal_Static_Void_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672114);
			RemotingConfiguration.NativeMethodInfoPtr_CustomErrorsEnabled_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672115);
			RemotingConfiguration.NativeMethodInfoPtr_SetCustomErrorsMode_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingConfiguration>.NativeClassPtr, 100672116);
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x06003B93 RID: 15251 RVA: 0x001194EC File Offset: 0x001176EC
		// (set) Token: 0x06003B94 RID: 15252 RVA: 0x00119518 File Offset: 0x00117718
		public unsafe static string ApplicationName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349035, XrefRangeEnd = 349039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_get_ApplicationName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349039, XrefRangeEnd = 349043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_set_ApplicationName_Public_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x06003B95 RID: 15253 RVA: 0x00119550 File Offset: 0x00117750
		public unsafe static string ProcessId
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 349054, RefRangeEnd = 349057, XrefRangeStart = 349043, XrefRangeEnd = 349054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_get_ProcessId_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003B96 RID: 15254 RVA: 0x0011957C File Offset: 0x0011777C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349091, RefRangeEnd = 349092, XrefRangeStart = 349057, XrefRangeEnd = 349091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadDefaultDelayedChannels()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_LoadDefaultDelayedChannels_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B97 RID: 15255 RVA: 0x001195A4 File Offset: 0x001177A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349102, RefRangeEnd = 349103, XrefRangeStart = 349092, XrefRangeEnd = 349102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsActivationAllowed(Type svrType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(svrType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_IsActivationAllowed_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003B98 RID: 15256 RVA: 0x001195E8 File Offset: 0x001177E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349117, RefRangeEnd = 349118, XrefRangeStart = 349103, XrefRangeEnd = 349117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(svrType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_IsRemotelyActivatedClientType_Public_Static_ActivatedClientTypeEntry_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActivatedClientTypeEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06003B99 RID: 15257 RVA: 0x0011962C File Offset: 0x0011782C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349132, RefRangeEnd = 349133, XrefRangeStart = 349118, XrefRangeEnd = 349132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(svrType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_IsWellKnownClientType_Public_Static_WellKnownClientTypeEntry_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WellKnownClientTypeEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06003B9A RID: 15258 RVA: 0x00119670 File Offset: 0x00117870
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349150, RefRangeEnd = 349151, XrefRangeStart = 349133, XrefRangeEnd = 349150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterActivatedClientType(ActivatedClientTypeEntry entry)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterActivatedClientType_Public_Static_Void_ActivatedClientTypeEntry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B9B RID: 15259 RVA: 0x001196A8 File Offset: 0x001178A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349161, RefRangeEnd = 349162, XrefRangeStart = 349151, XrefRangeEnd = 349161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterActivatedServiceType_Public_Static_Void_ActivatedServiceTypeEntry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B9C RID: 15260 RVA: 0x001196E0 File Offset: 0x001178E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349179, RefRangeEnd = 349180, XrefRangeStart = 349162, XrefRangeEnd = 349179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterWellKnownClientType_Public_Static_Void_WellKnownClientTypeEntry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B9D RID: 15261 RVA: 0x00119718 File Offset: 0x00117918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349194, RefRangeEnd = 349195, XrefRangeStart = 349180, XrefRangeEnd = 349194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterWellKnownServiceType_Public_Static_Void_WellKnownServiceTypeEntry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B9E RID: 15262 RVA: 0x00119750 File Offset: 0x00117950
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349200, RefRangeEnd = 349201, XrefRangeStart = 349195, XrefRangeEnd = 349200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterChannelTemplate(ChannelData channel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(channel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterChannelTemplate_Internal_Static_Void_ChannelData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B9F RID: 15263 RVA: 0x00119788 File Offset: 0x00117988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349206, RefRangeEnd = 349207, XrefRangeStart = 349201, XrefRangeEnd = 349206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterClientProviderTemplate(ProviderData prov)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prov);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterClientProviderTemplate_Internal_Static_Void_ProviderData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BA0 RID: 15264 RVA: 0x001197C0 File Offset: 0x001179C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349212, RefRangeEnd = 349213, XrefRangeStart = 349207, XrefRangeEnd = 349212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterServerProviderTemplate(ProviderData prov)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prov);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterServerProviderTemplate_Internal_Static_Void_ProviderData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BA1 RID: 15265 RVA: 0x001197F8 File Offset: 0x001179F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349281, RefRangeEnd = 349282, XrefRangeStart = 349213, XrefRangeEnd = 349281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterChannels(ArrayList channels, bool onlyDelayed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(channels);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref onlyDelayed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterChannels_Internal_Static_Void_ArrayList_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BA2 RID: 15266 RVA: 0x0011983C File Offset: 0x00117A3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349324, RefRangeEnd = 349325, XrefRangeStart = 349282, XrefRangeEnd = 349324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterTypes(ArrayList types)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(types);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_RegisterTypes_Internal_Static_Void_ArrayList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BA3 RID: 15267 RVA: 0x00119874 File Offset: 0x00117A74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349338, RefRangeEnd = 349339, XrefRangeStart = 349325, XrefRangeEnd = 349338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CustomErrorsEnabled(bool isLocalRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isLocalRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_CustomErrorsEnabled_Public_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003BA4 RID: 15268 RVA: 0x001198B4 File Offset: 0x00117AB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349353, RefRangeEnd = 349354, XrefRangeStart = 349339, XrefRangeEnd = 349353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCustomErrorsMode(string mode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(mode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingConfiguration.NativeMethodInfoPtr_SetCustomErrorsMode_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BA5 RID: 15269 RVA: 0x000166FD File Offset: 0x000148FD
		public RemotingConfiguration(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x06003BA6 RID: 15270 RVA: 0x001198EC File Offset: 0x00117AEC
		// (set) Token: 0x06003BA7 RID: 15271 RVA: 0x00016706 File Offset: 0x00014906
		public unsafe static string applicationID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_applicationID, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_applicationID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x06003BA8 RID: 15272 RVA: 0x0011990C File Offset: 0x00117B0C
		// (set) Token: 0x06003BA9 RID: 15273 RVA: 0x00016718 File Offset: 0x00014918
		public unsafe static string applicationName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_applicationName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_applicationName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x06003BAA RID: 15274 RVA: 0x0011992C File Offset: 0x00117B2C
		// (set) Token: 0x06003BAB RID: 15275 RVA: 0x0001672A File Offset: 0x0001492A
		public unsafe static string processGuid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_processGuid, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_processGuid, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06003BAC RID: 15276 RVA: 0x0011994C File Offset: 0x00117B4C
		// (set) Token: 0x06003BAD RID: 15277 RVA: 0x0001673C File Offset: 0x0001493C
		public unsafe static bool defaultConfigRead
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_defaultConfigRead, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_defaultConfigRead, (void*)(&value));
			}
		}

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06003BAE RID: 15278 RVA: 0x00119968 File Offset: 0x00117B68
		// (set) Token: 0x06003BAF RID: 15279 RVA: 0x0001674A File Offset: 0x0001494A
		public unsafe static bool defaultDelayedConfigRead
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_defaultDelayedConfigRead, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_defaultDelayedConfigRead, (void*)(&value));
			}
		}

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06003BB0 RID: 15280 RVA: 0x00119984 File Offset: 0x00117B84
		// (set) Token: 0x06003BB1 RID: 15281 RVA: 0x00016758 File Offset: 0x00014958
		public unsafe static string _errorMode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr__errorMode, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr__errorMode, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x06003BB2 RID: 15282 RVA: 0x001199A4 File Offset: 0x00117BA4
		// (set) Token: 0x06003BB3 RID: 15283 RVA: 0x0001676A File Offset: 0x0001496A
		public unsafe static Hashtable wellKnownClientEntries
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_wellKnownClientEntries, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_wellKnownClientEntries, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06003BB4 RID: 15284 RVA: 0x001199CC File Offset: 0x00117BCC
		// (set) Token: 0x06003BB5 RID: 15285 RVA: 0x0001677C File Offset: 0x0001497C
		public unsafe static Hashtable activatedClientEntries
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_activatedClientEntries, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_activatedClientEntries, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x06003BB6 RID: 15286 RVA: 0x001199F4 File Offset: 0x00117BF4
		// (set) Token: 0x06003BB7 RID: 15287 RVA: 0x0001678E File Offset: 0x0001498E
		public unsafe static Hashtable wellKnownServiceEntries
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_wellKnownServiceEntries, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_wellKnownServiceEntries, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x06003BB8 RID: 15288 RVA: 0x00119A1C File Offset: 0x00117C1C
		// (set) Token: 0x06003BB9 RID: 15289 RVA: 0x000167A0 File Offset: 0x000149A0
		public unsafe static Hashtable activatedServiceEntries
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_activatedServiceEntries, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_activatedServiceEntries, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06003BBA RID: 15290 RVA: 0x00119A44 File Offset: 0x00117C44
		// (set) Token: 0x06003BBB RID: 15291 RVA: 0x000167B2 File Offset: 0x000149B2
		public unsafe static Hashtable channelTemplates
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_channelTemplates, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_channelTemplates, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x06003BBC RID: 15292 RVA: 0x00119A6C File Offset: 0x00117C6C
		// (set) Token: 0x06003BBD RID: 15293 RVA: 0x000167C4 File Offset: 0x000149C4
		public unsafe static Hashtable clientProviderTemplates
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_clientProviderTemplates, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_clientProviderTemplates, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x06003BBE RID: 15294 RVA: 0x00119A94 File Offset: 0x00117C94
		// (set) Token: 0x06003BBF RID: 15295 RVA: 0x000167D6 File Offset: 0x000149D6
		public unsafe static Hashtable serverProviderTemplates
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingConfiguration.NativeFieldInfoPtr_serverProviderTemplates, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingConfiguration.NativeFieldInfoPtr_serverProviderTemplates, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400318C RID: 12684
		private static readonly IntPtr NativeFieldInfoPtr_applicationID;

		// Token: 0x0400318D RID: 12685
		private static readonly IntPtr NativeFieldInfoPtr_applicationName;

		// Token: 0x0400318E RID: 12686
		private static readonly IntPtr NativeFieldInfoPtr_processGuid;

		// Token: 0x0400318F RID: 12687
		private static readonly IntPtr NativeFieldInfoPtr_defaultConfigRead;

		// Token: 0x04003190 RID: 12688
		private static readonly IntPtr NativeFieldInfoPtr_defaultDelayedConfigRead;

		// Token: 0x04003191 RID: 12689
		private static readonly IntPtr NativeFieldInfoPtr__errorMode;

		// Token: 0x04003192 RID: 12690
		private static readonly IntPtr NativeFieldInfoPtr_wellKnownClientEntries;

		// Token: 0x04003193 RID: 12691
		private static readonly IntPtr NativeFieldInfoPtr_activatedClientEntries;

		// Token: 0x04003194 RID: 12692
		private static readonly IntPtr NativeFieldInfoPtr_wellKnownServiceEntries;

		// Token: 0x04003195 RID: 12693
		private static readonly IntPtr NativeFieldInfoPtr_activatedServiceEntries;

		// Token: 0x04003196 RID: 12694
		private static readonly IntPtr NativeFieldInfoPtr_channelTemplates;

		// Token: 0x04003197 RID: 12695
		private static readonly IntPtr NativeFieldInfoPtr_clientProviderTemplates;

		// Token: 0x04003198 RID: 12696
		private static readonly IntPtr NativeFieldInfoPtr_serverProviderTemplates;

		// Token: 0x04003199 RID: 12697
		private static readonly IntPtr NativeMethodInfoPtr_get_ApplicationName_Public_Static_get_String_0;

		// Token: 0x0400319A RID: 12698
		private static readonly IntPtr NativeMethodInfoPtr_set_ApplicationName_Public_Static_set_Void_String_0;

		// Token: 0x0400319B RID: 12699
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessId_Public_Static_get_String_0;

		// Token: 0x0400319C RID: 12700
		private static readonly IntPtr NativeMethodInfoPtr_LoadDefaultDelayedChannels_Internal_Static_Void_0;

		// Token: 0x0400319D RID: 12701
		private static readonly IntPtr NativeMethodInfoPtr_IsActivationAllowed_Public_Static_Boolean_Type_0;

		// Token: 0x0400319E RID: 12702
		private static readonly IntPtr NativeMethodInfoPtr_IsRemotelyActivatedClientType_Public_Static_ActivatedClientTypeEntry_Type_0;

		// Token: 0x0400319F RID: 12703
		private static readonly IntPtr NativeMethodInfoPtr_IsWellKnownClientType_Public_Static_WellKnownClientTypeEntry_Type_0;

		// Token: 0x040031A0 RID: 12704
		private static readonly IntPtr NativeMethodInfoPtr_RegisterActivatedClientType_Public_Static_Void_ActivatedClientTypeEntry_0;

		// Token: 0x040031A1 RID: 12705
		private static readonly IntPtr NativeMethodInfoPtr_RegisterActivatedServiceType_Public_Static_Void_ActivatedServiceTypeEntry_0;

		// Token: 0x040031A2 RID: 12706
		private static readonly IntPtr NativeMethodInfoPtr_RegisterWellKnownClientType_Public_Static_Void_WellKnownClientTypeEntry_0;

		// Token: 0x040031A3 RID: 12707
		private static readonly IntPtr NativeMethodInfoPtr_RegisterWellKnownServiceType_Public_Static_Void_WellKnownServiceTypeEntry_0;

		// Token: 0x040031A4 RID: 12708
		private static readonly IntPtr NativeMethodInfoPtr_RegisterChannelTemplate_Internal_Static_Void_ChannelData_0;

		// Token: 0x040031A5 RID: 12709
		private static readonly IntPtr NativeMethodInfoPtr_RegisterClientProviderTemplate_Internal_Static_Void_ProviderData_0;

		// Token: 0x040031A6 RID: 12710
		private static readonly IntPtr NativeMethodInfoPtr_RegisterServerProviderTemplate_Internal_Static_Void_ProviderData_0;

		// Token: 0x040031A7 RID: 12711
		private static readonly IntPtr NativeMethodInfoPtr_RegisterChannels_Internal_Static_Void_ArrayList_Boolean_0;

		// Token: 0x040031A8 RID: 12712
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTypes_Internal_Static_Void_ArrayList_0;

		// Token: 0x040031A9 RID: 12713
		private static readonly IntPtr NativeMethodInfoPtr_CustomErrorsEnabled_Public_Static_Boolean_Boolean_0;

		// Token: 0x040031AA RID: 12714
		private static readonly IntPtr NativeMethodInfoPtr_SetCustomErrorsMode_Internal_Static_Void_String_0;
	}
}
