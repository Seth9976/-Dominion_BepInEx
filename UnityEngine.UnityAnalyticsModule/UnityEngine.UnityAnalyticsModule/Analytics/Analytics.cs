using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Analytics
{
	// Token: 0x02000008 RID: 8
	public static class Analytics : Object
	{
		// Token: 0x0600008F RID: 143 RVA: 0x00003A90 File Offset: 0x00001C90
		// Note: this type is marked as 'beforefieldinit'.
		static Analytics()
		{
			Il2CppClassPointerStore<Analytics>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsModule.dll", "UnityEngine.Analytics", "Analytics");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Analytics>.NativeClassPtr);
			Analytics.NativeMethodInfoPtr_IsInitialized_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Analytics>.NativeClassPtr, 100663309);
			Analytics.NativeMethodInfoPtr_Transaction_Private_Static_AnalyticsResult_String_Double_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Analytics>.NativeClassPtr, 100663310);
			Analytics.NativeMethodInfoPtr_SendCustomEventName_Private_Static_AnalyticsResult_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Analytics>.NativeClassPtr, 100663311);
			Analytics.NativeMethodInfoPtr_SendCustomEvent_Private_Static_AnalyticsResult_CustomEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Analytics>.NativeClassPtr, 100663312);
			Analytics.NativeMethodInfoPtr_Transaction_Public_Static_AnalyticsResult_String_Decimal_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Analytics>.NativeClassPtr, 100663313);
			Analytics.NativeMethodInfoPtr_CustomEvent_Public_Static_AnalyticsResult_String_IDictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Analytics>.NativeClassPtr, 100663314);
			Analytics.ResumeInitializationInternalDelegateField = IL2CPP.ResolveICall<Analytics.ResumeInitializationInternalDelegate>("UnityEngine.Analytics.Analytics::ResumeInitializationInternal");
			Analytics.get_initializeOnStartupInternalDelegateField = IL2CPP.ResolveICall<Analytics.get_initializeOnStartupInternalDelegate>("UnityEngine.Analytics.Analytics::get_initializeOnStartupInternal");
			Analytics.set_initializeOnStartupInternalDelegateField = IL2CPP.ResolveICall<Analytics.set_initializeOnStartupInternalDelegate>("UnityEngine.Analytics.Analytics::set_initializeOnStartupInternal");
			Analytics.get_enabledInternalDelegateField = IL2CPP.ResolveICall<Analytics.get_enabledInternalDelegate>("UnityEngine.Analytics.Analytics::get_enabledInternal");
			Analytics.set_enabledInternalDelegateField = IL2CPP.ResolveICall<Analytics.set_enabledInternalDelegate>("UnityEngine.Analytics.Analytics::set_enabledInternal");
			Analytics.get_playerOptedOutInternalDelegateField = IL2CPP.ResolveICall<Analytics.get_playerOptedOutInternalDelegate>("UnityEngine.Analytics.Analytics::get_playerOptedOutInternal");
			Analytics.get_eventUrlInternalDelegateField = IL2CPP.ResolveICall<Analytics.get_eventUrlInternalDelegate>("UnityEngine.Analytics.Analytics::get_eventUrlInternal");
			Analytics.get_configUrlInternalDelegateField = IL2CPP.ResolveICall<Analytics.get_configUrlInternalDelegate>("UnityEngine.Analytics.Analytics::get_configUrlInternal");
			Analytics.get_dashboardUrlInternalDelegateField = IL2CPP.ResolveICall<Analytics.get_dashboardUrlInternalDelegate>("UnityEngine.Analytics.Analytics::get_dashboardUrlInternal");
			Analytics.get_limitUserTrackingInternalDelegateField = IL2CPP.ResolveICall<Analytics.get_limitUserTrackingInternalDelegate>("UnityEngine.Analytics.Analytics::get_limitUserTrackingInternal");
			Analytics.set_limitUserTrackingInternalDelegateField = IL2CPP.ResolveICall<Analytics.set_limitUserTrackingInternalDelegate>("UnityEngine.Analytics.Analytics::set_limitUserTrackingInternal");
			Analytics.get_deviceStatsEnabledInternalDelegateField = IL2CPP.ResolveICall<Analytics.get_deviceStatsEnabledInternalDelegate>("UnityEngine.Analytics.Analytics::get_deviceStatsEnabledInternal");
			Analytics.set_deviceStatsEnabledInternalDelegateField = IL2CPP.ResolveICall<Analytics.set_deviceStatsEnabledInternalDelegate>("UnityEngine.Analytics.Analytics::set_deviceStatsEnabledInternal");
			Analytics.FlushArchivedEventsDelegateField = IL2CPP.ResolveICall<Analytics.FlushArchivedEventsDelegate>("UnityEngine.Analytics.Analytics::FlushArchivedEvents");
			Analytics.IsCustomEventWithLimitEnabledDelegateField = IL2CPP.ResolveICall<Analytics.IsCustomEventWithLimitEnabledDelegate>("UnityEngine.Analytics.Analytics::IsCustomEventWithLimitEnabled");
			Analytics.EnableCustomEventWithLimitDelegateField = IL2CPP.ResolveICall<Analytics.EnableCustomEventWithLimitDelegate>("UnityEngine.Analytics.Analytics::EnableCustomEventWithLimit");
			Analytics.IsEventWithLimitEnabledDelegateField = IL2CPP.ResolveICall<Analytics.IsEventWithLimitEnabledDelegate>("UnityEngine.Analytics.Analytics::IsEventWithLimitEnabled");
			Analytics.EnableEventWithLimitDelegateField = IL2CPP.ResolveICall<Analytics.EnableEventWithLimitDelegate>("UnityEngine.Analytics.Analytics::EnableEventWithLimit");
			Analytics.RegisterEventWithLimitDelegateField = IL2CPP.ResolveICall<Analytics.RegisterEventWithLimitDelegate>("UnityEngine.Analytics.Analytics::RegisterEventWithLimit");
			Analytics.RegisterEventsWithLimitDelegateField = IL2CPP.ResolveICall<Analytics.RegisterEventsWithLimitDelegate>("UnityEngine.Analytics.Analytics::RegisterEventsWithLimit");
			Analytics.SendEventWithLimitDelegateField = IL2CPP.ResolveICall<Analytics.SendEventWithLimitDelegate>("UnityEngine.Analytics.Analytics::SendEventWithLimit");
			Analytics.SetEventWithLimitEndPointDelegateField = IL2CPP.ResolveICall<Analytics.SetEventWithLimitEndPointDelegate>("UnityEngine.Analytics.Analytics::SetEventWithLimitEndPoint");
			Analytics.SetEventWithLimitPriorityDelegateField = IL2CPP.ResolveICall<Analytics.SetEventWithLimitPriorityDelegate>("UnityEngine.Analytics.Analytics::SetEventWithLimitPriority");
			Analytics.QueueEventDelegateField = IL2CPP.ResolveICall<Analytics.QueueEventDelegate>("UnityEngine.Analytics.Analytics::QueueEvent");
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003CA0 File Offset: 0x00001EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123592, XrefRangeEnd = 123594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInitialized()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Analytics.NativeMethodInfoPtr_IsInitialized_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00003CD0 File Offset: 0x00001ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123594, XrefRangeEnd = 123596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AnalyticsResult Transaction(string productId, double amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(currency);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(receiptPurchaseData);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usingIAPService;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Analytics.NativeMethodInfoPtr_Transaction_Private_Static_AnalyticsResult_String_Double_String_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00003D64 File Offset: 0x00001F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123596, XrefRangeEnd = 123598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AnalyticsResult SendCustomEventName(string customEventName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(customEventName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Analytics.NativeMethodInfoPtr_SendCustomEventName_Private_Static_AnalyticsResult_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00003DA8 File Offset: 0x00001FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123598, XrefRangeEnd = 123600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AnalyticsResult SendCustomEvent(CustomEventData eventData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Analytics.NativeMethodInfoPtr_SendCustomEvent_Private_Static_AnalyticsResult_CustomEventData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003DEC File Offset: 0x00001FEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123612, RefRangeEnd = 123613, XrefRangeStart = 123600, XrefRangeEnd = 123612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AnalyticsResult Transaction(string productId, Decimal amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(currency);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(receiptPurchaseData);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usingIAPService;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Analytics.NativeMethodInfoPtr_Transaction_Public_Static_AnalyticsResult_String_Decimal_String_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003E80 File Offset: 0x00002080
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123634, RefRangeEnd = 123635, XrefRangeStart = 123613, XrefRangeEnd = 123634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AnalyticsResult CustomEvent(string customEventName, IDictionary<string, Object> eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(customEventName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Analytics.NativeMethodInfoPtr_CustomEvent_Public_Static_AnalyticsResult_String_IDictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002577 File Offset: 0x00000777
		public Analytics(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00003ED4 File Offset: 0x000020D4
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00003EFC File Offset: 0x000020FC
		public static bool initializeOnStartup
		{
			get
			{
				bool flag = !Analytics.IsInitialized();
				return !flag && Analytics.initializeOnStartupInternal;
			}
			set
			{
				bool flag = Analytics.IsInitialized();
				if (flag)
				{
					Analytics.initializeOnStartupInternal = value;
				}
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003F1C File Offset: 0x0000211C
		public static AnalyticsResult ResumeInitialization()
		{
			bool flag = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = Analytics.ResumeInitializationInternal();
			}
			return analyticsResult;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002580 File Offset: 0x00000780
		public static AnalyticsResult ResumeInitializationInternal()
		{
			return Analytics.ResumeInitializationInternalDelegateField();
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0000258C File Offset: 0x0000078C
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00002598 File Offset: 0x00000798
		public static bool initializeOnStartupInternal
		{
			get
			{
				return Analytics.get_initializeOnStartupInternalDelegateField();
			}
			set
			{
				Analytics.set_initializeOnStartupInternalDelegateField(value);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600009D RID: 157 RVA: 0x000025A5 File Offset: 0x000007A5
		// (set) Token: 0x0600009E RID: 158 RVA: 0x000025B1 File Offset: 0x000007B1
		public static bool enabledInternal
		{
			get
			{
				return Analytics.get_enabledInternalDelegateField();
			}
			set
			{
				Analytics.set_enabledInternalDelegateField(value);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600009F RID: 159 RVA: 0x000025BE File Offset: 0x000007BE
		public static bool playerOptedOutInternal
		{
			get
			{
				return Analytics.get_playerOptedOutInternalDelegateField();
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00003F44 File Offset: 0x00002144
		public static string eventUrlInternal
		{
			get
			{
				IntPtr intPtr = Analytics.get_eventUrlInternalDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00003F64 File Offset: 0x00002164
		public static string configUrlInternal
		{
			get
			{
				IntPtr intPtr = Analytics.get_configUrlInternalDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00003F84 File Offset: 0x00002184
		public static string dashboardUrlInternal
		{
			get
			{
				IntPtr intPtr = Analytics.get_dashboardUrlInternalDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x000025CA File Offset: 0x000007CA
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x000025D6 File Offset: 0x000007D6
		public static bool limitUserTrackingInternal
		{
			get
			{
				return Analytics.get_limitUserTrackingInternalDelegateField();
			}
			set
			{
				Analytics.set_limitUserTrackingInternalDelegateField(value);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x000025E3 File Offset: 0x000007E3
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x000025EF File Offset: 0x000007EF
		public static bool deviceStatsEnabledInternal
		{
			get
			{
				return Analytics.get_deviceStatsEnabledInternalDelegateField();
			}
			set
			{
				Analytics.set_deviceStatsEnabledInternalDelegateField(value);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000025FC File Offset: 0x000007FC
		public static bool FlushArchivedEvents()
		{
			return Analytics.FlushArchivedEventsDelegateField();
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002608 File Offset: 0x00000808
		public static AnalyticsResult IsCustomEventWithLimitEnabled(string customEventName)
		{
			return Analytics.IsCustomEventWithLimitEnabledDelegateField(IL2CPP.ManagedStringToIl2Cpp(customEventName));
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000261A File Offset: 0x0000081A
		public static AnalyticsResult EnableCustomEventWithLimit(string customEventName, bool enable)
		{
			return Analytics.EnableCustomEventWithLimitDelegateField(IL2CPP.ManagedStringToIl2Cpp(customEventName), enable);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000262D File Offset: 0x0000082D
		public static AnalyticsResult IsEventWithLimitEnabled(string eventName, int ver, string prefix)
		{
			return Analytics.IsEventWithLimitEnabledDelegateField(IL2CPP.ManagedStringToIl2Cpp(eventName), ver, IL2CPP.ManagedStringToIl2Cpp(prefix));
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002646 File Offset: 0x00000846
		public static AnalyticsResult EnableEventWithLimit(string eventName, bool enable, int ver, string prefix)
		{
			return Analytics.EnableEventWithLimitDelegateField(IL2CPP.ManagedStringToIl2Cpp(eventName), enable, ver, IL2CPP.ManagedStringToIl2Cpp(prefix));
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00003FA4 File Offset: 0x000021A4
		public static AnalyticsResult RegisterEventWithLimit(string eventName, int maxEventPerHour, int maxItems, string vendorKey, int ver, string prefix, string assemblyInfo, bool notifyServer)
		{
			return Analytics.RegisterEventWithLimitDelegateField(IL2CPP.ManagedStringToIl2Cpp(eventName), maxEventPerHour, maxItems, IL2CPP.ManagedStringToIl2Cpp(vendorKey), ver, IL2CPP.ManagedStringToIl2Cpp(prefix), IL2CPP.ManagedStringToIl2Cpp(assemblyInfo), notifyServer);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00003FDC File Offset: 0x000021DC
		public static AnalyticsResult RegisterEventsWithLimit(Il2CppStringArray eventName, int maxEventPerHour, int maxItems, string vendorKey, int ver, string prefix, string assemblyInfo, bool notifyServer)
		{
			return Analytics.RegisterEventsWithLimitDelegateField(IL2CPP.Il2CppObjectBaseToPtr(eventName), maxEventPerHour, maxItems, IL2CPP.ManagedStringToIl2Cpp(vendorKey), ver, IL2CPP.ManagedStringToIl2Cpp(prefix), IL2CPP.ManagedStringToIl2Cpp(assemblyInfo), notifyServer);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002660 File Offset: 0x00000860
		public static AnalyticsResult SendEventWithLimit(string eventName, Object parameters, int ver, string prefix)
		{
			return Analytics.SendEventWithLimitDelegateField(IL2CPP.ManagedStringToIl2Cpp(eventName), IL2CPP.Il2CppObjectBaseToPtr(parameters), ver, IL2CPP.ManagedStringToIl2Cpp(prefix));
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000267F File Offset: 0x0000087F
		public static AnalyticsResult SetEventWithLimitEndPoint(string eventName, string endPoint, int ver, string prefix)
		{
			return Analytics.SetEventWithLimitEndPointDelegateField(IL2CPP.ManagedStringToIl2Cpp(eventName), IL2CPP.ManagedStringToIl2Cpp(endPoint), ver, IL2CPP.ManagedStringToIl2Cpp(prefix));
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000269E File Offset: 0x0000089E
		public static AnalyticsResult SetEventWithLimitPriority(string eventName, AnalyticsEventPriority eventPriority, int ver, string prefix)
		{
			return Analytics.SetEventWithLimitPriorityDelegateField(IL2CPP.ManagedStringToIl2Cpp(eventName), eventPriority, ver, IL2CPP.ManagedStringToIl2Cpp(prefix));
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000026B8 File Offset: 0x000008B8
		public static bool QueueEvent(string eventName, Object parameters, int ver, string prefix)
		{
			return Analytics.QueueEventDelegateField(IL2CPP.ManagedStringToIl2Cpp(eventName), IL2CPP.Il2CppObjectBaseToPtr(parameters), ver, IL2CPP.ManagedStringToIl2Cpp(prefix));
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00004014 File Offset: 0x00002214
		public static bool playerOptedOut
		{
			get
			{
				bool flag = !Analytics.IsInitialized();
				return !flag && Analytics.playerOptedOutInternal;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000403C File Offset: 0x0000223C
		public static string eventUrl
		{
			get
			{
				bool flag = !Analytics.IsInitialized();
				string text;
				if (flag)
				{
					text = String.Empty;
				}
				else
				{
					text = Analytics.eventUrlInternal;
				}
				return text;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00004068 File Offset: 0x00002268
		public static string dashboardUrl
		{
			get
			{
				bool flag = !Analytics.IsInitialized();
				string text;
				if (flag)
				{
					text = String.Empty;
				}
				else
				{
					text = Analytics.dashboardUrlInternal;
				}
				return text;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00004094 File Offset: 0x00002294
		public static string configUrl
		{
			get
			{
				bool flag = !Analytics.IsInitialized();
				string text;
				if (flag)
				{
					text = String.Empty;
				}
				else
				{
					text = Analytics.configUrlInternal;
				}
				return text;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x000040C0 File Offset: 0x000022C0
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x000040E8 File Offset: 0x000022E8
		public static bool limitUserTracking
		{
			get
			{
				bool flag = !Analytics.IsInitialized();
				return !flag && Analytics.limitUserTrackingInternal;
			}
			set
			{
				bool flag = Analytics.IsInitialized();
				if (flag)
				{
					Analytics.limitUserTrackingInternal = value;
				}
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00004108 File Offset: 0x00002308
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00004130 File Offset: 0x00002330
		public static bool deviceStatsEnabled
		{
			get
			{
				bool flag = !Analytics.IsInitialized();
				return !flag && Analytics.deviceStatsEnabledInternal;
			}
			set
			{
				bool flag = Analytics.IsInitialized();
				if (flag)
				{
					Analytics.deviceStatsEnabledInternal = value;
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00004150 File Offset: 0x00002350
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00004178 File Offset: 0x00002378
		public static bool enabled
		{
			get
			{
				bool flag = !Analytics.IsInitialized();
				return !flag && Analytics.enabledInternal;
			}
			set
			{
				bool flag = Analytics.IsInitialized();
				if (flag)
				{
					Analytics.enabledInternal = value;
				}
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00004198 File Offset: 0x00002398
		public static AnalyticsResult FlushEvents()
		{
			bool flag = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = (Analytics.FlushArchivedEvents() ? AnalyticsResult.Ok : AnalyticsResult.NotInitialized);
			}
			return analyticsResult;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000026D7 File Offset: 0x000008D7
		public static AnalyticsResult SetUserId(string userId)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000026E4 File Offset: 0x000008E4
		public static AnalyticsResult SetUserGender(Gender gender)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000026F1 File Offset: 0x000008F1
		public static AnalyticsResult SetUserBirthYear(int birthYear)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000041C8 File Offset: 0x000023C8
		public static AnalyticsResult SendUserInfoEvent(Object param)
		{
			bool flag = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				Analytics.QueueEvent("userInfo", param, 1, String.Empty);
				analyticsResult = AnalyticsResult.Ok;
			}
			return analyticsResult;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00004200 File Offset: 0x00002400
		public static AnalyticsResult Transaction(string productId, Decimal amount, string currency)
		{
			return Analytics.Transaction(productId, amount, currency, null, null, false);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00004220 File Offset: 0x00002420
		public static AnalyticsResult Transaction(string productId, Decimal amount, string currency, string receiptPurchaseData, string signature)
		{
			return Analytics.Transaction(productId, amount, currency, receiptPurchaseData, signature, false);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00004240 File Offset: 0x00002440
		public static AnalyticsResult CustomEvent(string customEventName)
		{
			bool flag = String.IsNullOrEmpty(customEventName);
			if (flag)
			{
				throw new ArgumentException("Cannot set custom event name to an empty or null string");
			}
			bool flag2 = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag2)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = Analytics.SendCustomEventName(customEventName);
			}
			return analyticsResult;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00004280 File Offset: 0x00002480
		public static AnalyticsResult CustomEvent(string customEventName, Vector3 position)
		{
			bool flag = String.IsNullOrEmpty(customEventName);
			if (flag)
			{
				throw new ArgumentException("Cannot set custom event name to an empty or null string");
			}
			bool flag2 = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag2)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				CustomEventData customEventData = new CustomEventData(customEventName);
				customEventData.AddDouble("x", (double)Convert.ToDecimal(position.x));
				customEventData.AddDouble("y", (double)Convert.ToDecimal(position.y));
				customEventData.AddDouble("z", (double)Convert.ToDecimal(position.z));
				AnalyticsResult analyticsResult2 = Analytics.SendCustomEvent(customEventData);
				customEventData.Dispose();
				analyticsResult = analyticsResult2;
			}
			return analyticsResult;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00004328 File Offset: 0x00002528
		public static AnalyticsResult EnableCustomEvent(string customEventName, bool enabled)
		{
			bool flag = String.IsNullOrEmpty(customEventName);
			if (flag)
			{
				throw new ArgumentException("Cannot set event name to an empty or null string");
			}
			bool flag2 = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag2)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = Analytics.EnableCustomEventWithLimit(customEventName, enabled);
			}
			return analyticsResult;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00004368 File Offset: 0x00002568
		public static AnalyticsResult IsCustomEventEnabled(string customEventName)
		{
			bool flag = String.IsNullOrEmpty(customEventName);
			if (flag)
			{
				throw new ArgumentException("Cannot set event name to an empty or null string");
			}
			bool flag2 = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag2)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = Analytics.IsCustomEventWithLimitEnabled(customEventName);
			}
			return analyticsResult;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000043A8 File Offset: 0x000025A8
		public static AnalyticsResult RegisterEvent(string eventName, int maxEventPerHour, int maxItems, [Optional] string vendorKey, [Optional] string prefix)
		{
			string text = String.Empty;
			text = Assembly.GetCallingAssembly().FullName;
			return Analytics.RegisterEvent(eventName, maxEventPerHour, maxItems, vendorKey, 1, prefix, text);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000043D8 File Offset: 0x000025D8
		public static AnalyticsResult RegisterEvent(string eventName, int maxEventPerHour, int maxItems, string vendorKey, int ver, [Optional] string prefix)
		{
			string text = String.Empty;
			text = Assembly.GetCallingAssembly().FullName;
			return Analytics.RegisterEvent(eventName, maxEventPerHour, maxItems, vendorKey, ver, prefix, text);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000440C File Offset: 0x0000260C
		public static AnalyticsResult RegisterEvent(string eventName, int maxEventPerHour, int maxItems, string vendorKey, int ver, string prefix, string assemblyInfo)
		{
			bool flag = String.IsNullOrEmpty(eventName);
			if (flag)
			{
				throw new ArgumentException("Cannot set event name to an empty or null string");
			}
			bool flag2 = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag2)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = Analytics.RegisterEventWithLimit(eventName, maxEventPerHour, maxItems, vendorKey, ver, prefix, assemblyInfo, true);
			}
			return analyticsResult;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00004454 File Offset: 0x00002654
		public static AnalyticsResult SendEvent(string eventName, Object parameters, [Optional] int ver, [Optional] string prefix)
		{
			bool flag = String.IsNullOrEmpty(eventName);
			if (flag)
			{
				throw new ArgumentException("Cannot set event name to an empty or null string");
			}
			bool flag2 = parameters == null;
			if (flag2)
			{
				throw new ArgumentException("Cannot set parameters to null");
			}
			bool flag3 = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag3)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = Analytics.SendEventWithLimit(eventName, parameters, ver, prefix);
			}
			return analyticsResult;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000044A8 File Offset: 0x000026A8
		public static AnalyticsResult SetEventEndPoint(string eventName, string endPoint, [Optional] int ver, [Optional] string prefix)
		{
			bool flag = String.IsNullOrEmpty(eventName);
			if (flag)
			{
				throw new ArgumentException("Cannot set event name to an empty or null string");
			}
			bool flag2 = endPoint == null;
			if (flag2)
			{
				throw new ArgumentException("Cannot set parameters to null");
			}
			bool flag3 = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag3)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = Analytics.SetEventWithLimitEndPoint(eventName, endPoint, ver, prefix);
			}
			return analyticsResult;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000044FC File Offset: 0x000026FC
		public static AnalyticsResult SetEventPriority(string eventName, AnalyticsEventPriority eventPriority, [Optional] int ver, [Optional] string prefix)
		{
			bool flag = String.IsNullOrEmpty(eventName);
			if (flag)
			{
				throw new ArgumentException("Cannot set event name to an empty or null string");
			}
			bool flag2 = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag2)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = Analytics.SetEventWithLimitPriority(eventName, eventPriority, ver, prefix);
			}
			return analyticsResult;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000453C File Offset: 0x0000273C
		public static AnalyticsResult EnableEvent(string eventName, bool enabled, [Optional] int ver, [Optional] string prefix)
		{
			bool flag = String.IsNullOrEmpty(eventName);
			if (flag)
			{
				throw new ArgumentException("Cannot set event name to an empty or null string");
			}
			bool flag2 = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag2)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = Analytics.EnableEventWithLimit(eventName, enabled, ver, prefix);
			}
			return analyticsResult;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000457C File Offset: 0x0000277C
		public static AnalyticsResult IsEventEnabled(string eventName, [Optional] int ver, [Optional] string prefix)
		{
			bool flag = String.IsNullOrEmpty(eventName);
			if (flag)
			{
				throw new ArgumentException("Cannot set event name to an empty or null string");
			}
			bool flag2 = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag2)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = Analytics.IsEventWithLimitEnabled(eventName, ver, prefix);
			}
			return analyticsResult;
		}

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_IsInitialized_Internal_Static_Boolean_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_Transaction_Private_Static_AnalyticsResult_String_Double_String_String_String_Boolean_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_SendCustomEventName_Private_Static_AnalyticsResult_String_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_SendCustomEvent_Private_Static_AnalyticsResult_CustomEventData_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_Transaction_Public_Static_AnalyticsResult_String_Decimal_String_String_String_Boolean_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_CustomEvent_Public_Static_AnalyticsResult_String_IDictionary_2_String_Object_0;

		// Token: 0x0400005A RID: 90
		private static readonly Analytics.ResumeInitializationInternalDelegate ResumeInitializationInternalDelegateField;

		// Token: 0x0400005B RID: 91
		private static readonly Analytics.get_initializeOnStartupInternalDelegate get_initializeOnStartupInternalDelegateField;

		// Token: 0x0400005C RID: 92
		private static readonly Analytics.set_initializeOnStartupInternalDelegate set_initializeOnStartupInternalDelegateField;

		// Token: 0x0400005D RID: 93
		private static readonly Analytics.get_enabledInternalDelegate get_enabledInternalDelegateField;

		// Token: 0x0400005E RID: 94
		private static readonly Analytics.set_enabledInternalDelegate set_enabledInternalDelegateField;

		// Token: 0x0400005F RID: 95
		private static readonly Analytics.get_playerOptedOutInternalDelegate get_playerOptedOutInternalDelegateField;

		// Token: 0x04000060 RID: 96
		private static readonly Analytics.get_eventUrlInternalDelegate get_eventUrlInternalDelegateField;

		// Token: 0x04000061 RID: 97
		private static readonly Analytics.get_configUrlInternalDelegate get_configUrlInternalDelegateField;

		// Token: 0x04000062 RID: 98
		private static readonly Analytics.get_dashboardUrlInternalDelegate get_dashboardUrlInternalDelegateField;

		// Token: 0x04000063 RID: 99
		private static readonly Analytics.get_limitUserTrackingInternalDelegate get_limitUserTrackingInternalDelegateField;

		// Token: 0x04000064 RID: 100
		private static readonly Analytics.set_limitUserTrackingInternalDelegate set_limitUserTrackingInternalDelegateField;

		// Token: 0x04000065 RID: 101
		private static readonly Analytics.get_deviceStatsEnabledInternalDelegate get_deviceStatsEnabledInternalDelegateField;

		// Token: 0x04000066 RID: 102
		private static readonly Analytics.set_deviceStatsEnabledInternalDelegate set_deviceStatsEnabledInternalDelegateField;

		// Token: 0x04000067 RID: 103
		private static readonly Analytics.FlushArchivedEventsDelegate FlushArchivedEventsDelegateField;

		// Token: 0x04000068 RID: 104
		private static readonly Analytics.IsCustomEventWithLimitEnabledDelegate IsCustomEventWithLimitEnabledDelegateField;

		// Token: 0x04000069 RID: 105
		private static readonly Analytics.EnableCustomEventWithLimitDelegate EnableCustomEventWithLimitDelegateField;

		// Token: 0x0400006A RID: 106
		private static readonly Analytics.IsEventWithLimitEnabledDelegate IsEventWithLimitEnabledDelegateField;

		// Token: 0x0400006B RID: 107
		private static readonly Analytics.EnableEventWithLimitDelegate EnableEventWithLimitDelegateField;

		// Token: 0x0400006C RID: 108
		private static readonly Analytics.RegisterEventWithLimitDelegate RegisterEventWithLimitDelegateField;

		// Token: 0x0400006D RID: 109
		private static readonly Analytics.RegisterEventsWithLimitDelegate RegisterEventsWithLimitDelegateField;

		// Token: 0x0400006E RID: 110
		private static readonly Analytics.SendEventWithLimitDelegate SendEventWithLimitDelegateField;

		// Token: 0x0400006F RID: 111
		private static readonly Analytics.SetEventWithLimitEndPointDelegate SetEventWithLimitEndPointDelegateField;

		// Token: 0x04000070 RID: 112
		private static readonly Analytics.SetEventWithLimitPriorityDelegate SetEventWithLimitPriorityDelegateField;

		// Token: 0x04000071 RID: 113
		private static readonly Analytics.QueueEventDelegate QueueEventDelegateField;

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x06000179 RID: 377
		private delegate AnalyticsResult ResumeInitializationInternalDelegate();

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x0600017B RID: 379
		private delegate bool get_initializeOnStartupInternalDelegate();

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x0600017D RID: 381
		private delegate void set_initializeOnStartupInternalDelegate(bool value);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x0600017F RID: 383
		private delegate bool get_enabledInternalDelegate();

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x06000181 RID: 385
		private delegate void set_enabledInternalDelegate(bool value);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x06000183 RID: 387
		private delegate bool get_playerOptedOutInternalDelegate();

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x06000185 RID: 389
		private delegate IntPtr get_eventUrlInternalDelegate();

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x06000187 RID: 391
		private delegate IntPtr get_configUrlInternalDelegate();

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x06000189 RID: 393
		private delegate IntPtr get_dashboardUrlInternalDelegate();

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x0600018B RID: 395
		private delegate bool get_limitUserTrackingInternalDelegate();

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x0600018D RID: 397
		private delegate void set_limitUserTrackingInternalDelegate(bool value);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x0600018F RID: 399
		private delegate bool get_deviceStatsEnabledInternalDelegate();

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x06000191 RID: 401
		private delegate void set_deviceStatsEnabledInternalDelegate(bool value);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x06000193 RID: 403
		private delegate bool FlushArchivedEventsDelegate();

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x06000195 RID: 405
		private delegate AnalyticsResult IsCustomEventWithLimitEnabledDelegate(IntPtr customEventName);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x06000197 RID: 407
		private delegate AnalyticsResult EnableCustomEventWithLimitDelegate(IntPtr customEventName, bool enable);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x06000199 RID: 409
		private delegate AnalyticsResult IsEventWithLimitEnabledDelegate(IntPtr eventName, int ver, IntPtr prefix);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x0600019B RID: 411
		private delegate AnalyticsResult EnableEventWithLimitDelegate(IntPtr eventName, bool enable, int ver, IntPtr prefix);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x0600019D RID: 413
		private delegate AnalyticsResult RegisterEventWithLimitDelegate(IntPtr eventName, int maxEventPerHour, int maxItems, IntPtr vendorKey, int ver, IntPtr prefix, IntPtr assemblyInfo, bool notifyServer);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x0600019F RID: 415
		private delegate AnalyticsResult RegisterEventsWithLimitDelegate(IntPtr eventName, int maxEventPerHour, int maxItems, IntPtr vendorKey, int ver, IntPtr prefix, IntPtr assemblyInfo, bool notifyServer);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x060001A1 RID: 417
		private delegate AnalyticsResult SendEventWithLimitDelegate(IntPtr eventName, IntPtr parameters, int ver, IntPtr prefix);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x060001A3 RID: 419
		private delegate AnalyticsResult SetEventWithLimitEndPointDelegate(IntPtr eventName, IntPtr endPoint, int ver, IntPtr prefix);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x060001A5 RID: 421
		private delegate AnalyticsResult SetEventWithLimitPriorityDelegate(IntPtr eventName, AnalyticsEventPriority eventPriority, int ver, IntPtr prefix);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x060001A7 RID: 423
		private delegate bool QueueEventDelegate(IntPtr eventName, IntPtr parameters, int ver, IntPtr prefix);
	}
}
