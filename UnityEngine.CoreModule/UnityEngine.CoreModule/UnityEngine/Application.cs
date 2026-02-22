using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Globalization;
using Il2CppSystem.Text;
using UnityEngine.Diagnostics;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace UnityEngine
{
	// Token: 0x02000037 RID: 55
	public class Application : Object
	{
		// Token: 0x0600019A RID: 410 RVA: 0x0001A960 File Offset: 0x00018B60
		// Note: this type is marked as 'beforefieldinit'.
		static Application()
		{
			Il2CppClassPointerStore<Application>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Application");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Application>.NativeClassPtr);
			Application.NativeFieldInfoPtr_lowMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "lowMemory");
			Application.NativeFieldInfoPtr_s_LogCallbackHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "s_LogCallbackHandler");
			Application.NativeFieldInfoPtr_s_LogCallbackHandlerThreaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "s_LogCallbackHandlerThreaded");
			Application.NativeFieldInfoPtr_focusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "focusChanged");
			Application.NativeFieldInfoPtr_deepLinkActivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "deepLinkActivated");
			Application.NativeFieldInfoPtr_wantsToQuit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "wantsToQuit");
			Application.NativeFieldInfoPtr_quitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "quitting");
			Application.NativeFieldInfoPtr_unloading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Application>.NativeClassPtr, "unloading");
			Application.NativeMethodInfoPtr_Quit_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663374);
			Application.NativeMethodInfoPtr_Quit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663375);
			Application.NativeMethodInfoPtr_get_isPlaying_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663376);
			Application.NativeMethodInfoPtr_get_dataPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663377);
			Application.NativeMethodInfoPtr_get_streamingAssetsPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663378);
			Application.NativeMethodInfoPtr_get_persistentDataPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663379);
			Application.NativeMethodInfoPtr_get_unityVersion_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663380);
			Application.NativeMethodInfoPtr_get_version_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663381);
			Application.NativeMethodInfoPtr_get_cloudProjectId_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663382);
			Application.NativeMethodInfoPtr_OpenURL_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663383);
			Application.NativeMethodInfoPtr_set_targetFrameRate_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663384);
			Application.NativeMethodInfoPtr_get_platform_Public_Static_get_RuntimePlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663385);
			Application.NativeMethodInfoPtr_CallLowMemory_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663386);
			Application.NativeMethodInfoPtr_CallLogCallback_Private_Static_Void_String_String_LogType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663387);
			Application.NativeMethodInfoPtr_Internal_ApplicationWantsToQuit_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663388);
			Application.NativeMethodInfoPtr_Internal_ApplicationQuit_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663389);
			Application.NativeMethodInfoPtr_Internal_ApplicationUnload_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663390);
			Application.NativeMethodInfoPtr_InvokeOnBeforeRender_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663391);
			Application.NativeMethodInfoPtr_InvokeFocusChanged_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663392);
			Application.NativeMethodInfoPtr_InvokeDeepLinkActivated_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663393);
			Application.NativeMethodInfoPtr_get_isEditor_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application>.NativeClassPtr, 100663394);
			Application.CancelQuitDelegateField = IL2CPP.ResolveICall<Application.CancelQuitDelegate>("UnityEngine.Application::CancelQuit");
			Application.UnloadDelegateField = IL2CPP.ResolveICall<Application.UnloadDelegate>("UnityEngine.Application::Unload");
			Application.get_isLoadingLevelDelegateField = IL2CPP.ResolveICall<Application.get_isLoadingLevelDelegate>("UnityEngine.Application::get_isLoadingLevel");
			Application.CanStreamedLevelBeLoadedDelegateField = IL2CPP.ResolveICall<Application.CanStreamedLevelBeLoadedDelegate>("UnityEngine.Application::CanStreamedLevelBeLoaded");
			Application.IsPlayingDelegateField = IL2CPP.ResolveICall<Application.IsPlayingDelegate>("UnityEngine.Application::IsPlaying");
			Application.get_isFocusedDelegateField = IL2CPP.ResolveICall<Application.get_isFocusedDelegate>("UnityEngine.Application::get_isFocused");
			Application.GetBuildTagsDelegateField = IL2CPP.ResolveICall<Application.GetBuildTagsDelegate>("UnityEngine.Application::GetBuildTags");
			Application.SetBuildTagsDelegateField = IL2CPP.ResolveICall<Application.SetBuildTagsDelegate>("UnityEngine.Application::SetBuildTags");
			Application.get_buildGUIDDelegateField = IL2CPP.ResolveICall<Application.get_buildGUIDDelegate>("UnityEngine.Application::get_buildGUID");
			Application.get_runInBackgroundDelegateField = IL2CPP.ResolveICall<Application.get_runInBackgroundDelegate>("UnityEngine.Application::get_runInBackground");
			Application.set_runInBackgroundDelegateField = IL2CPP.ResolveICall<Application.set_runInBackgroundDelegate>("UnityEngine.Application::set_runInBackground");
			Application.HasProLicenseDelegateField = IL2CPP.ResolveICall<Application.HasProLicenseDelegate>("UnityEngine.Application::HasProLicense");
			Application.get_isBatchModeDelegateField = IL2CPP.ResolveICall<Application.get_isBatchModeDelegate>("UnityEngine.Application::get_isBatchMode");
			Application.get_isTestRunDelegateField = IL2CPP.ResolveICall<Application.get_isTestRunDelegate>("UnityEngine.Application::get_isTestRun");
			Application.get_isHumanControllingUsDelegateField = IL2CPP.ResolveICall<Application.get_isHumanControllingUsDelegate>("UnityEngine.Application::get_isHumanControllingUs");
			Application.HasARGVDelegateField = IL2CPP.ResolveICall<Application.HasARGVDelegate>("UnityEngine.Application::HasARGV");
			Application.GetValueForARGVDelegateField = IL2CPP.ResolveICall<Application.GetValueForARGVDelegate>("UnityEngine.Application::GetValueForARGV");
			Application.get_temporaryCachePathDelegateField = IL2CPP.ResolveICall<Application.get_temporaryCachePathDelegate>("UnityEngine.Application::get_temporaryCachePath");
			Application.get_absoluteURLDelegateField = IL2CPP.ResolveICall<Application.get_absoluteURLDelegate>("UnityEngine.Application::get_absoluteURL");
			Application.Internal_ExternalCallDelegateField = IL2CPP.ResolveICall<Application.Internal_ExternalCallDelegate>("UnityEngine.Application::Internal_ExternalCall");
			Application.get_unityVersionVerDelegateField = IL2CPP.ResolveICall<Application.get_unityVersionVerDelegate>("UnityEngine.Application::get_unityVersionVer");
			Application.get_unityVersionMajDelegateField = IL2CPP.ResolveICall<Application.get_unityVersionMajDelegate>("UnityEngine.Application::get_unityVersionMaj");
			Application.get_unityVersionMinDelegateField = IL2CPP.ResolveICall<Application.get_unityVersionMinDelegate>("UnityEngine.Application::get_unityVersionMin");
			Application.get_installerNameDelegateField = IL2CPP.ResolveICall<Application.get_installerNameDelegate>("UnityEngine.Application::get_installerName");
			Application.get_identifierDelegateField = IL2CPP.ResolveICall<Application.get_identifierDelegate>("UnityEngine.Application::get_identifier");
			Application.get_installModeDelegateField = IL2CPP.ResolveICall<Application.get_installModeDelegate>("UnityEngine.Application::get_installMode");
			Application.get_sandboxTypeDelegateField = IL2CPP.ResolveICall<Application.get_sandboxTypeDelegate>("UnityEngine.Application::get_sandboxType");
			Application.get_productNameDelegateField = IL2CPP.ResolveICall<Application.get_productNameDelegate>("UnityEngine.Application::get_productName");
			Application.get_companyNameDelegateField = IL2CPP.ResolveICall<Application.get_companyNameDelegate>("UnityEngine.Application::get_companyName");
			Application.get_targetFrameRateDelegateField = IL2CPP.ResolveICall<Application.get_targetFrameRateDelegate>("UnityEngine.Application::get_targetFrameRate");
			Application.SetLogCallbackDefinedDelegateField = IL2CPP.ResolveICall<Application.SetLogCallbackDefinedDelegate>("UnityEngine.Application::SetLogCallbackDefined");
			Application.get_stackTraceLogTypeDelegateField = IL2CPP.ResolveICall<Application.get_stackTraceLogTypeDelegate>("UnityEngine.Application::get_stackTraceLogType");
			Application.set_stackTraceLogTypeDelegateField = IL2CPP.ResolveICall<Application.set_stackTraceLogTypeDelegate>("UnityEngine.Application::set_stackTraceLogType");
			Application.GetStackTraceLogTypeDelegateField = IL2CPP.ResolveICall<Application.GetStackTraceLogTypeDelegate>("UnityEngine.Application::GetStackTraceLogType");
			Application.SetStackTraceLogTypeDelegateField = IL2CPP.ResolveICall<Application.SetStackTraceLogTypeDelegate>("UnityEngine.Application::SetStackTraceLogType");
			Application.get_consoleLogPathDelegateField = IL2CPP.ResolveICall<Application.get_consoleLogPathDelegate>("UnityEngine.Application::get_consoleLogPath");
			Application.get_backgroundLoadingPriorityDelegateField = IL2CPP.ResolveICall<Application.get_backgroundLoadingPriorityDelegate>("UnityEngine.Application::get_backgroundLoadingPriority");
			Application.set_backgroundLoadingPriorityDelegateField = IL2CPP.ResolveICall<Application.set_backgroundLoadingPriorityDelegate>("UnityEngine.Application::set_backgroundLoadingPriority");
			Application.get_genuineDelegateField = IL2CPP.ResolveICall<Application.get_genuineDelegate>("UnityEngine.Application::get_genuine");
			Application.get_genuineCheckAvailableDelegateField = IL2CPP.ResolveICall<Application.get_genuineCheckAvailableDelegate>("UnityEngine.Application::get_genuineCheckAvailable");
			Application.RequestUserAuthorizationDelegateField = IL2CPP.ResolveICall<Application.RequestUserAuthorizationDelegate>("UnityEngine.Application::RequestUserAuthorization");
			Application.HasUserAuthorizationDelegateField = IL2CPP.ResolveICall<Application.HasUserAuthorizationDelegate>("UnityEngine.Application::HasUserAuthorization");
			Application.get_submitAnalyticsDelegateField = IL2CPP.ResolveICall<Application.get_submitAnalyticsDelegate>("UnityEngine.Application::get_submitAnalytics");
			Application.get_systemLanguageDelegateField = IL2CPP.ResolveICall<Application.get_systemLanguageDelegate>("UnityEngine.Application::get_systemLanguage");
			Application.get_internetReachabilityDelegateField = IL2CPP.ResolveICall<Application.get_internetReachabilityDelegate>("UnityEngine.Application::get_internetReachability");
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0001AE78 File Offset: 0x00019078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59463, XrefRangeEnd = 59465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Quit(int exitCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref exitCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Quit_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0001AEAC File Offset: 0x000190AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 59467, RefRangeEnd = 59470, XrefRangeStart = 59465, XrefRangeEnd = 59467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Quit()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Quit_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600019D RID: 413 RVA: 0x0001AED4 File Offset: 0x000190D4
		public unsafe static bool isPlaying
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 59472, RefRangeEnd = 59490, XrefRangeStart = 59470, XrefRangeEnd = 59472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_isPlaying_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0001AF04 File Offset: 0x00019104
		public unsafe static string dataPath
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 59492, RefRangeEnd = 59494, XrefRangeStart = 59490, XrefRangeEnd = 59492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_dataPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0001AF30 File Offset: 0x00019130
		public unsafe static string streamingAssetsPath
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 59496, RefRangeEnd = 59498, XrefRangeStart = 59494, XrefRangeEnd = 59496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_streamingAssetsPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0001AF5C File Offset: 0x0001915C
		public unsafe static string persistentDataPath
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 59500, RefRangeEnd = 59510, XrefRangeStart = 59498, XrefRangeEnd = 59500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_persistentDataPath_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0001AF88 File Offset: 0x00019188
		public unsafe static string unityVersion
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59512, RefRangeEnd = 59513, XrefRangeStart = 59510, XrefRangeEnd = 59512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_unityVersion_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0001AFB4 File Offset: 0x000191B4
		public unsafe static string version
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59515, RefRangeEnd = 59516, XrefRangeStart = 59513, XrefRangeEnd = 59515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_version_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x0001AFE0 File Offset: 0x000191E0
		public unsafe static string cloudProjectId
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 59518, RefRangeEnd = 59521, XrefRangeStart = 59516, XrefRangeEnd = 59518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_cloudProjectId_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0001B00C File Offset: 0x0001920C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 59523, RefRangeEnd = 59531, XrefRangeStart = 59521, XrefRangeEnd = 59523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenURL(string url)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_OpenURL_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00003250 File Offset: 0x00001450
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x0001B044 File Offset: 0x00019244
		public unsafe static int targetFrameRate
		{
			get
			{
				return Application.get_targetFrameRateDelegateField();
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 59533, RefRangeEnd = 59536, XrefRangeStart = 59531, XrefRangeEnd = 59533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_set_targetFrameRate_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0001B078 File Offset: 0x00019278
		public unsafe static RuntimePlatform platform
		{
			[CallerCount(32)]
			[CachedScanResults(RefRangeStart = 59538, RefRangeEnd = 59570, XrefRangeStart = 59536, XrefRangeEnd = 59538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_platform_Public_Static_get_RuntimePlatform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0001B0A8 File Offset: 0x000192A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59570, XrefRangeEnd = 59573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallLowMemory()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_CallLowMemory_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0001B0D0 File Offset: 0x000192D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59573, XrefRangeEnd = 59578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(logString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invokedOnMainThread;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_CallLogCallback_Private_Static_Void_String_String_LogType_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0001B134 File Offset: 0x00019334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59578, XrefRangeEnd = 59593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_ApplicationWantsToQuit()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Internal_ApplicationWantsToQuit_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0001B164 File Offset: 0x00019364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59593, XrefRangeEnd = 59596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ApplicationQuit()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Internal_ApplicationQuit_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0001B18C File Offset: 0x0001938C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59596, XrefRangeEnd = 59599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ApplicationUnload()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_Internal_ApplicationUnload_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0001B1B4 File Offset: 0x000193B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59599, XrefRangeEnd = 59603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnBeforeRender()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_InvokeOnBeforeRender_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0001B1DC File Offset: 0x000193DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59603, XrefRangeEnd = 59608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeFocusChanged(bool focus)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref focus;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_InvokeFocusChanged_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0001B210 File Offset: 0x00019410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59608, XrefRangeEnd = 59613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeDeepLinkActivated(string url)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_InvokeDeepLinkActivated_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0001B248 File Offset: 0x00019448
		public unsafe static bool isEditor
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 59613, RefRangeEnd = 59618, XrefRangeStart = 59613, XrefRangeEnd = 59613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.NativeMethodInfoPtr_get_isEditor_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000309E File Offset: 0x0000129E
		public Application(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0001B278 File Offset: 0x00019478
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x000030A7 File Offset: 0x000012A7
		public unsafe static Application.LowMemoryCallback lowMemory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_lowMemory, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Application.LowMemoryCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_lowMemory, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0001B2A0 File Offset: 0x000194A0
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x000030B9 File Offset: 0x000012B9
		public unsafe static Application.LogCallback s_LogCallbackHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_s_LogCallbackHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Application.LogCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_s_LogCallbackHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0001B2C8 File Offset: 0x000194C8
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x000030CB File Offset: 0x000012CB
		public unsafe static Application.LogCallback s_LogCallbackHandlerThreaded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_s_LogCallbackHandlerThreaded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Application.LogCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_s_LogCallbackHandlerThreaded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0001B2F0 File Offset: 0x000194F0
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x000030DD File Offset: 0x000012DD
		public unsafe static Action<bool> focusChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_focusChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_focusChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x0001B318 File Offset: 0x00019518
		// (set) Token: 0x060001BA RID: 442 RVA: 0x000030EF File Offset: 0x000012EF
		public unsafe static Action<string> deepLinkActivated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_deepLinkActivated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_deepLinkActivated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0001B340 File Offset: 0x00019540
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00003101 File Offset: 0x00001301
		public unsafe static Func<bool> wantsToQuit
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_wantsToQuit, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_wantsToQuit, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0001B368 File Offset: 0x00019568
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00003113 File Offset: 0x00001313
		public unsafe static Action quitting
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_quitting, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_quitting, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0001B390 File Offset: 0x00019590
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00003125 File Offset: 0x00001325
		public unsafe static Action unloading
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Application.NativeFieldInfoPtr_unloading, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Application.NativeFieldInfoPtr_unloading, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00003137 File Offset: 0x00001337
		public static void CancelQuit()
		{
			Application.CancelQuitDelegateField();
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00003143 File Offset: 0x00001343
		public static void Unload()
		{
			Application.UnloadDelegateField();
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x0000314F File Offset: 0x0000134F
		public static bool isLoadingLevel
		{
			get
			{
				return Application.get_isLoadingLevelDelegateField();
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0001B3B8 File Offset: 0x000195B8
		public static float GetStreamProgressForLevel(int levelIndex)
		{
			bool flag = levelIndex >= 0 && levelIndex < UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
			float num;
			if (flag)
			{
				num = 1f;
			}
			else
			{
				num = 0f;
			}
			return num;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0001B3EC File Offset: 0x000195EC
		public static float GetStreamProgressForLevel(string levelName)
		{
			return 1f;
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0001B404 File Offset: 0x00019604
		public static int streamedBytes
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x0001B418 File Offset: 0x00019618
		public static bool webSecurityEnabled
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0001B42C File Offset: 0x0001962C
		public static bool CanStreamedLevelBeLoaded(int levelIndex)
		{
			return levelIndex >= 0 && levelIndex < UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000315B File Offset: 0x0000135B
		public static bool CanStreamedLevelBeLoaded(string levelName)
		{
			return Application.CanStreamedLevelBeLoadedDelegateField(IL2CPP.ManagedStringToIl2Cpp(levelName));
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000316D File Offset: 0x0000136D
		public static bool IsPlaying(Object obj)
		{
			return Application.IsPlayingDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj));
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001CB RID: 459 RVA: 0x0000317F File Offset: 0x0000137F
		public static bool isFocused
		{
			get
			{
				return Application.get_isFocusedDelegateField();
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0001B450 File Offset: 0x00019650
		public static Il2CppStringArray GetBuildTags()
		{
			IntPtr intPtr = Application.GetBuildTagsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000318B File Offset: 0x0000138B
		public static void SetBuildTags(Il2CppStringArray buildTags)
		{
			Application.SetBuildTagsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(buildTags));
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001CE RID: 462 RVA: 0x0001B478 File Offset: 0x00019678
		public static string buildGUID
		{
			get
			{
				IntPtr intPtr = Application.get_buildGUIDDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0000319D File Offset: 0x0000139D
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x000031A9 File Offset: 0x000013A9
		public static bool runInBackground
		{
			get
			{
				return Application.get_runInBackgroundDelegateField();
			}
			set
			{
				Application.set_runInBackgroundDelegateField(value);
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000031B6 File Offset: 0x000013B6
		public static bool HasProLicense()
		{
			return Application.HasProLicenseDelegateField();
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x000031C2 File Offset: 0x000013C2
		public static bool isBatchMode
		{
			get
			{
				return Application.get_isBatchModeDelegateField();
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000031CE File Offset: 0x000013CE
		public static bool isTestRun
		{
			get
			{
				return Application.get_isTestRunDelegateField();
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x000031DA File Offset: 0x000013DA
		public static bool isHumanControllingUs
		{
			get
			{
				return Application.get_isHumanControllingUsDelegateField();
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000031E6 File Offset: 0x000013E6
		public static bool HasARGV(string name)
		{
			return Application.HasARGVDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0001B498 File Offset: 0x00019698
		public static string GetValueForARGV(string name)
		{
			IntPtr intPtr = Application.GetValueForARGVDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0001B4BC File Offset: 0x000196BC
		public static string temporaryCachePath
		{
			get
			{
				IntPtr intPtr = Application.get_temporaryCachePathDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0001B4DC File Offset: 0x000196DC
		public static string absoluteURL
		{
			get
			{
				IntPtr intPtr = Application.get_absoluteURLDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0001B4FC File Offset: 0x000196FC
		public static void ExternalEval(string script)
		{
			bool flag = script.Length > 0 && script.get_Chars(script.Length - 1) != ';';
			if (flag)
			{
				script = String.Concat(script, ";");
			}
			Application.Internal_ExternalCall(script);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000031F8 File Offset: 0x000013F8
		public static void Internal_ExternalCall(string script)
		{
			Application.Internal_ExternalCallDelegateField(IL2CPP.ManagedStringToIl2Cpp(script));
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0000320A File Offset: 0x0000140A
		public static int unityVersionVer
		{
			get
			{
				return Application.get_unityVersionVerDelegateField();
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00003216 File Offset: 0x00001416
		public static int unityVersionMaj
		{
			get
			{
				return Application.get_unityVersionMajDelegateField();
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00003222 File Offset: 0x00001422
		public static int unityVersionMin
		{
			get
			{
				return Application.get_unityVersionMinDelegateField();
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001DE RID: 478 RVA: 0x0001B544 File Offset: 0x00019744
		public static string installerName
		{
			get
			{
				IntPtr intPtr = Application.get_installerNameDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001DF RID: 479 RVA: 0x0001B564 File Offset: 0x00019764
		public static string identifier
		{
			get
			{
				IntPtr intPtr = Application.get_identifierDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000322E File Offset: 0x0000142E
		public static ApplicationInstallMode installMode
		{
			get
			{
				return Application.get_installModeDelegateField();
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x0000323A File Offset: 0x0000143A
		public static ApplicationSandboxType sandboxType
		{
			get
			{
				return Application.get_sandboxTypeDelegateField();
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0001B584 File Offset: 0x00019784
		public static string productName
		{
			get
			{
				IntPtr intPtr = Application.get_productNameDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0001B5A4 File Offset: 0x000197A4
		public static string companyName
		{
			get
			{
				IntPtr intPtr = Application.get_companyNameDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00003246 File Offset: 0x00001446
		public static void ForceCrash(int mode)
		{
			UnityEngine.Diagnostics.Utils.ForceCrash((UnityEngine.Diagnostics.ForcedCrashCategory)mode);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000325C File Offset: 0x0000145C
		public static void SetLogCallbackDefined(bool defined)
		{
			Application.SetLogCallbackDefinedDelegateField(defined);
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00003269 File Offset: 0x00001469
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x00003275 File Offset: 0x00001475
		public static StackTraceLogType stackTraceLogType
		{
			get
			{
				return Application.get_stackTraceLogTypeDelegateField();
			}
			set
			{
				Application.set_stackTraceLogTypeDelegateField(value);
			}
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00003282 File Offset: 0x00001482
		public static StackTraceLogType GetStackTraceLogType(LogType logType)
		{
			return Application.GetStackTraceLogTypeDelegateField(logType);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000328F File Offset: 0x0000148F
		public static void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType)
		{
			Application.SetStackTraceLogTypeDelegateField(logType, stackTraceType);
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001EB RID: 491 RVA: 0x0001B5C4 File Offset: 0x000197C4
		public static string consoleLogPath
		{
			get
			{
				IntPtr intPtr = Application.get_consoleLogPathDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0000329D File Offset: 0x0000149D
		// (set) Token: 0x060001ED RID: 493 RVA: 0x000032A9 File Offset: 0x000014A9
		public static ThreadPriority backgroundLoadingPriority
		{
			get
			{
				return Application.get_backgroundLoadingPriorityDelegateField();
			}
			set
			{
				Application.set_backgroundLoadingPriorityDelegateField(value);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001EE RID: 494 RVA: 0x000032B6 File Offset: 0x000014B6
		public static bool genuine
		{
			get
			{
				return Application.get_genuineDelegateField();
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001EF RID: 495 RVA: 0x000032C2 File Offset: 0x000014C2
		public static bool genuineCheckAvailable
		{
			get
			{
				return Application.get_genuineCheckAvailableDelegateField();
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0001B5E4 File Offset: 0x000197E4
		public static AsyncOperation RequestUserAuthorization(UserAuthorization mode)
		{
			IntPtr intPtr = Application.RequestUserAuthorizationDelegateField(mode);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000032CE File Offset: 0x000014CE
		public static bool HasUserAuthorization(UserAuthorization mode)
		{
			return Application.HasUserAuthorizationDelegateField(mode);
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x000032DB File Offset: 0x000014DB
		public static bool submitAnalytics
		{
			get
			{
				return Application.get_submitAnalyticsDelegateField();
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x0001B60C File Offset: 0x0001980C
		public static bool isShowingSplashScreen
		{
			get
			{
				return !UnityEngine.Rendering.SplashScreen.isFinished;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0001B628 File Offset: 0x00019828
		public static bool isMobilePlatform
		{
			get
			{
				RuntimePlatform platform = Application.platform;
				RuntimePlatform runtimePlatform = platform;
				return runtimePlatform == RuntimePlatform.IPhonePlayer || runtimePlatform == RuntimePlatform.Android || (runtimePlatform - RuntimePlatform.MetroPlayerX86 <= 2 && SystemInfo.deviceType == DeviceType.Handheld);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x0001B668 File Offset: 0x00019868
		public static bool isConsolePlatform
		{
			get
			{
				RuntimePlatform platform = Application.platform;
				return platform == RuntimePlatform.PS4 || platform == RuntimePlatform.XboxOne;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x000032E7 File Offset: 0x000014E7
		public static SystemLanguage systemLanguage
		{
			get
			{
				return Application.get_systemLanguageDelegateField();
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x000032F3 File Offset: 0x000014F3
		public static NetworkReachability internetReachability
		{
			get
			{
				return Application.get_internetReachabilityDelegateField();
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x000032FF File Offset: 0x000014FF
		public static void add_lowMemory(Application.LowMemoryCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000330C File Offset: 0x0000150C
		public static void remove_lowMemory(Application.LowMemoryCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00003319 File Offset: 0x00001519
		public static void add_logMessageReceived(Application.LogCallback value)
		{
			Application.s_LogCallbackHandler = Delegate.Combine(Application.s_LogCallbackHandler, value).Cast<Application.LogCallback>();
			Application.SetLogCallbackDefined(true);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00003338 File Offset: 0x00001538
		public static void remove_logMessageReceived(Application.LogCallback value)
		{
			Application.s_LogCallbackHandler = Delegate.Remove(Application.s_LogCallbackHandler, value).Cast<Application.LogCallback>();
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00003350 File Offset: 0x00001550
		public static void add_logMessageReceivedThreaded(Application.LogCallback value)
		{
			Application.s_LogCallbackHandlerThreaded = Delegate.Combine(Application.s_LogCallbackHandlerThreaded, value).Cast<Application.LogCallback>();
			Application.SetLogCallbackDefined(true);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000336F File Offset: 0x0000156F
		public static void remove_logMessageReceivedThreaded(Application.LogCallback value)
		{
			Application.s_LogCallbackHandlerThreaded = Delegate.Remove(Application.s_LogCallbackHandlerThreaded, value).Cast<Application.LogCallback>();
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00003387 File Offset: 0x00001587
		public static void InvokeOnAdvertisingIdentifierCallback(string advertisingId, bool trackingEnabled)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0001B690 File Offset: 0x00019890
		public static string ObjectToJSString(Object o)
		{
			bool flag = o == null;
			string text;
			if (flag)
			{
				text = "null";
			}
			else
			{
				bool flag2 = o.TryCast<string>() != null;
				if (flag2)
				{
					string text2 = o.ToString().Replace("\\", "\\\\");
					text2 = text2.Replace("\"", "\\\"");
					text2 = text2.Replace("\n", "\\n");
					text2 = text2.Replace("\r", "\\r");
					text2 = text2.Replace("\0", "");
					text2 = text2.Replace("\u2028", "");
					text2 = text2.Replace("\u2029", "");
					text = String.Concat("\"", text2, "\"");
				}
				else
				{
					bool flag3 = o is int || o is short || o is uint || o is ushort || o is byte;
					if (flag3)
					{
						text = o.ToString();
					}
					else
					{
						bool flag4 = o is float;
						if (flag4)
						{
							NumberFormatInfo numberFormat = CultureInfo.InvariantCulture.NumberFormat;
							text = ((float)o).ToString(numberFormat);
						}
						else
						{
							bool flag5 = o is double;
							if (flag5)
							{
								NumberFormatInfo numberFormat2 = CultureInfo.InvariantCulture.NumberFormat;
								text = ((double)o).ToString(numberFormat2);
							}
							else
							{
								bool flag6 = o is char;
								if (flag6)
								{
									bool flag7 = (char)o == '"';
									if (flag7)
									{
										text = "\"\\\"\"";
									}
									else
									{
										text = String.Concat("\"", o.ToString(), "\"");
									}
								}
								else
								{
									bool flag8 = o.TryCast<IList>() != null;
									if (flag8)
									{
										IList list = o.Cast<IList>();
										StringBuilder stringBuilder = new StringBuilder();
										stringBuilder.Append("new Array(");
										int count = list.Count;
										for (int i = 0; i < count; i++)
										{
											bool flag9 = i != 0;
											if (flag9)
											{
												stringBuilder.Append(", ");
											}
											stringBuilder.Append(Application.ObjectToJSString(list[i]));
										}
										stringBuilder.Append(")");
										text = stringBuilder.ToString();
									}
									else
									{
										text = Application.ObjectToJSString(o.ToString());
									}
								}
							}
						}
					}
				}
			}
			return text;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00003394 File Offset: 0x00001594
		public static void ExternalCall(string functionName, Il2CppReferenceArray<Object> args)
		{
			Application.Internal_ExternalCall(Application.BuildInvocationForArguments(functionName, args));
		}

		// Token: 0x06000201 RID: 513 RVA: 0x000033A4 File Offset: 0x000015A4
		public static void ExternalCall(string functionName, params Object[] args)
		{
			Application.ExternalCall(functionName, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000033B2 File Offset: 0x000015B2
		public static string BuildInvocationForArguments(string functionName, Il2CppReferenceArray<Object> args)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000203 RID: 515 RVA: 0x000033BF File Offset: 0x000015BF
		public static string BuildInvocationForArguments(string functionName, params Object[] args)
		{
			return Application.BuildInvocationForArguments(functionName, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0001B8E8 File Offset: 0x00019AE8
		public static bool isPlayer
		{
			get
			{
				return !Application.isEditor;
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0001B904 File Offset: 0x00019B04
		public static void DontDestroyOnLoad(Object o)
		{
			bool flag = o != null;
			if (flag)
			{
				Object.DontDestroyOnLoad(o);
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000033CD File Offset: 0x000015CD
		public static void CaptureScreenshot(string filename, int superSize)
		{
			throw new NotSupportedException("Application.CaptureScreenshot is obsolete. Use ScreenCapture.CaptureScreenshot instead.");
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000033DA File Offset: 0x000015DA
		public static void CaptureScreenshot(string filename)
		{
			throw new NotSupportedException("Application.CaptureScreenshot is obsolete. Use ScreenCapture.CaptureScreenshot instead.");
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000033E7 File Offset: 0x000015E7
		public static void add_onBeforeRender(UnityEngine.Events.UnityAction value)
		{
			BeforeRenderHelper.RegisterCallback(value);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x000033F1 File Offset: 0x000015F1
		public static void remove_onBeforeRender(UnityEngine.Events.UnityAction value)
		{
			BeforeRenderHelper.UnregisterCallback(value);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000033FB File Offset: 0x000015FB
		public static void add_focusChanged(Action<bool> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00003408 File Offset: 0x00001608
		public static void remove_focusChanged(Action<bool> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00003415 File Offset: 0x00001615
		public static void add_deepLinkActivated(Action<string> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00003422 File Offset: 0x00001622
		public static void remove_deepLinkActivated(Action<string> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000342F File Offset: 0x0000162F
		public static void RegisterLogCallback(Application.LogCallback handler)
		{
			Application.RegisterLogCallback(handler, false);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000343A File Offset: 0x0000163A
		public static void RegisterLogCallbackThreaded(Application.LogCallback handler)
		{
			Application.RegisterLogCallback(handler, true);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00003445 File Offset: 0x00001645
		public static void RegisterLogCallback(Application.LogCallback handler, bool threaded)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0001B924 File Offset: 0x00019B24
		public static int levelCount
		{
			get
			{
				return UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0001B93C File Offset: 0x00019B3C
		public static int loadedLevel
		{
			get
			{
				return UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0001B95C File Offset: 0x00019B5C
		public static string loadedLevelName
		{
			get
			{
				return UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00003452 File Offset: 0x00001652
		public static void LoadLevel(int index)
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(index, UnityEngine.SceneManagement.LoadSceneMode.Single);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000345D File Offset: 0x0000165D
		public static void LoadLevel(string name)
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(name, UnityEngine.SceneManagement.LoadSceneMode.Single);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00003468 File Offset: 0x00001668
		public static void LoadLevelAdditive(int index)
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(index, UnityEngine.SceneManagement.LoadSceneMode.Additive);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00003473 File Offset: 0x00001673
		public static void LoadLevelAdditive(string name)
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(name, UnityEngine.SceneManagement.LoadSceneMode.Additive);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0001B97C File Offset: 0x00019B7C
		public static AsyncOperation LoadLevelAsync(int index)
		{
			return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(index, UnityEngine.SceneManagement.LoadSceneMode.Single);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0001B998 File Offset: 0x00019B98
		public static AsyncOperation LoadLevelAsync(string levelName)
		{
			return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(levelName, UnityEngine.SceneManagement.LoadSceneMode.Single);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0001B9B4 File Offset: 0x00019BB4
		public static AsyncOperation LoadLevelAdditiveAsync(int index)
		{
			return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(index, UnityEngine.SceneManagement.LoadSceneMode.Additive);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0001B9D0 File Offset: 0x00019BD0
		public static AsyncOperation LoadLevelAdditiveAsync(string levelName)
		{
			return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(levelName, UnityEngine.SceneManagement.LoadSceneMode.Additive);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0001B9EC File Offset: 0x00019BEC
		public static bool UnloadLevel(int index)
		{
			return UnityEngine.SceneManagement.SceneManager.UnloadScene(index);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0001BA04 File Offset: 0x00019C04
		public static bool UnloadLevel(string scenePath)
		{
			return UnityEngine.SceneManagement.SceneManager.UnloadScene(scenePath);
		}

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeFieldInfoPtr_lowMemory;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeFieldInfoPtr_s_LogCallbackHandler;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeFieldInfoPtr_s_LogCallbackHandlerThreaded;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeFieldInfoPtr_focusChanged;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeFieldInfoPtr_deepLinkActivated;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeFieldInfoPtr_wantsToQuit;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeFieldInfoPtr_quitting;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeFieldInfoPtr_unloading;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_Quit_Public_Static_Void_Int32_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_Quit_Public_Static_Void_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_get_isPlaying_Public_Static_get_Boolean_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_get_dataPath_Public_Static_get_String_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_get_streamingAssetsPath_Public_Static_get_String_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_get_persistentDataPath_Public_Static_get_String_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_get_unityVersion_Public_Static_get_String_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_get_version_Public_Static_get_String_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_get_cloudProjectId_Public_Static_get_String_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_OpenURL_Public_Static_Void_String_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_set_targetFrameRate_Public_Static_set_Void_Int32_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_get_platform_Public_Static_get_RuntimePlatform_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_CallLowMemory_Internal_Static_Void_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_CallLogCallback_Private_Static_Void_String_String_LogType_Boolean_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ApplicationWantsToQuit_Private_Static_Boolean_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ApplicationQuit_Private_Static_Void_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ApplicationUnload_Private_Static_Void_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnBeforeRender_Internal_Static_Void_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_InvokeFocusChanged_Internal_Static_Void_Boolean_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_InvokeDeepLinkActivated_Internal_Static_Void_String_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_get_isEditor_Public_Static_get_Boolean_0;

		// Token: 0x0400014F RID: 335
		private static readonly Application.CancelQuitDelegate CancelQuitDelegateField;

		// Token: 0x04000150 RID: 336
		private static readonly Application.UnloadDelegate UnloadDelegateField;

		// Token: 0x04000151 RID: 337
		private static readonly Application.get_isLoadingLevelDelegate get_isLoadingLevelDelegateField;

		// Token: 0x04000152 RID: 338
		private static readonly Application.CanStreamedLevelBeLoadedDelegate CanStreamedLevelBeLoadedDelegateField;

		// Token: 0x04000153 RID: 339
		private static readonly Application.IsPlayingDelegate IsPlayingDelegateField;

		// Token: 0x04000154 RID: 340
		private static readonly Application.get_isFocusedDelegate get_isFocusedDelegateField;

		// Token: 0x04000155 RID: 341
		private static readonly Application.GetBuildTagsDelegate GetBuildTagsDelegateField;

		// Token: 0x04000156 RID: 342
		private static readonly Application.SetBuildTagsDelegate SetBuildTagsDelegateField;

		// Token: 0x04000157 RID: 343
		private static readonly Application.get_buildGUIDDelegate get_buildGUIDDelegateField;

		// Token: 0x04000158 RID: 344
		private static readonly Application.get_runInBackgroundDelegate get_runInBackgroundDelegateField;

		// Token: 0x04000159 RID: 345
		private static readonly Application.set_runInBackgroundDelegate set_runInBackgroundDelegateField;

		// Token: 0x0400015A RID: 346
		private static readonly Application.HasProLicenseDelegate HasProLicenseDelegateField;

		// Token: 0x0400015B RID: 347
		private static readonly Application.get_isBatchModeDelegate get_isBatchModeDelegateField;

		// Token: 0x0400015C RID: 348
		private static readonly Application.get_isTestRunDelegate get_isTestRunDelegateField;

		// Token: 0x0400015D RID: 349
		private static readonly Application.get_isHumanControllingUsDelegate get_isHumanControllingUsDelegateField;

		// Token: 0x0400015E RID: 350
		private static readonly Application.HasARGVDelegate HasARGVDelegateField;

		// Token: 0x0400015F RID: 351
		private static readonly Application.GetValueForARGVDelegate GetValueForARGVDelegateField;

		// Token: 0x04000160 RID: 352
		private static readonly Application.get_temporaryCachePathDelegate get_temporaryCachePathDelegateField;

		// Token: 0x04000161 RID: 353
		private static readonly Application.get_absoluteURLDelegate get_absoluteURLDelegateField;

		// Token: 0x04000162 RID: 354
		private static readonly Application.Internal_ExternalCallDelegate Internal_ExternalCallDelegateField;

		// Token: 0x04000163 RID: 355
		private static readonly Application.get_unityVersionVerDelegate get_unityVersionVerDelegateField;

		// Token: 0x04000164 RID: 356
		private static readonly Application.get_unityVersionMajDelegate get_unityVersionMajDelegateField;

		// Token: 0x04000165 RID: 357
		private static readonly Application.get_unityVersionMinDelegate get_unityVersionMinDelegateField;

		// Token: 0x04000166 RID: 358
		private static readonly Application.get_installerNameDelegate get_installerNameDelegateField;

		// Token: 0x04000167 RID: 359
		private static readonly Application.get_identifierDelegate get_identifierDelegateField;

		// Token: 0x04000168 RID: 360
		private static readonly Application.get_installModeDelegate get_installModeDelegateField;

		// Token: 0x04000169 RID: 361
		private static readonly Application.get_sandboxTypeDelegate get_sandboxTypeDelegateField;

		// Token: 0x0400016A RID: 362
		private static readonly Application.get_productNameDelegate get_productNameDelegateField;

		// Token: 0x0400016B RID: 363
		private static readonly Application.get_companyNameDelegate get_companyNameDelegateField;

		// Token: 0x0400016C RID: 364
		private static readonly Application.get_targetFrameRateDelegate get_targetFrameRateDelegateField;

		// Token: 0x0400016D RID: 365
		private static readonly Application.SetLogCallbackDefinedDelegate SetLogCallbackDefinedDelegateField;

		// Token: 0x0400016E RID: 366
		private static readonly Application.get_stackTraceLogTypeDelegate get_stackTraceLogTypeDelegateField;

		// Token: 0x0400016F RID: 367
		private static readonly Application.set_stackTraceLogTypeDelegate set_stackTraceLogTypeDelegateField;

		// Token: 0x04000170 RID: 368
		private static readonly Application.GetStackTraceLogTypeDelegate GetStackTraceLogTypeDelegateField;

		// Token: 0x04000171 RID: 369
		private static readonly Application.SetStackTraceLogTypeDelegate SetStackTraceLogTypeDelegateField;

		// Token: 0x04000172 RID: 370
		private static readonly Application.get_consoleLogPathDelegate get_consoleLogPathDelegateField;

		// Token: 0x04000173 RID: 371
		private static readonly Application.get_backgroundLoadingPriorityDelegate get_backgroundLoadingPriorityDelegateField;

		// Token: 0x04000174 RID: 372
		private static readonly Application.set_backgroundLoadingPriorityDelegate set_backgroundLoadingPriorityDelegateField;

		// Token: 0x04000175 RID: 373
		private static readonly Application.get_genuineDelegate get_genuineDelegateField;

		// Token: 0x04000176 RID: 374
		private static readonly Application.get_genuineCheckAvailableDelegate get_genuineCheckAvailableDelegateField;

		// Token: 0x04000177 RID: 375
		private static readonly Application.RequestUserAuthorizationDelegate RequestUserAuthorizationDelegateField;

		// Token: 0x04000178 RID: 376
		private static readonly Application.HasUserAuthorizationDelegate HasUserAuthorizationDelegateField;

		// Token: 0x04000179 RID: 377
		private static readonly Application.get_submitAnalyticsDelegate get_submitAnalyticsDelegateField;

		// Token: 0x0400017A RID: 378
		private static readonly Application.get_systemLanguageDelegate get_systemLanguageDelegateField;

		// Token: 0x0400017B RID: 379
		private static readonly Application.get_internetReachabilityDelegate get_internetReachabilityDelegateField;

		// Token: 0x02000320 RID: 800
		public sealed class LowMemoryCallback : MulticastDelegate
		{
			// Token: 0x060023FB RID: 9211 RVA: 0x00015043 File Offset: 0x00013243
			// Note: this type is marked as 'beforefieldinit'.
			static LowMemoryCallback()
			{
				Il2CppClassPointerStore<Application.LowMemoryCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Application>.NativeClassPtr, "LowMemoryCallback");
				Application.LowMemoryCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.LowMemoryCallback>.NativeClassPtr, 100663395);
				Application.LowMemoryCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.LowMemoryCallback>.NativeClassPtr, 100663396);
			}

			// Token: 0x060023FC RID: 9212 RVA: 0x0006B494 File Offset: 0x00069694
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LowMemoryCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Application.LowMemoryCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.LowMemoryCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023FD RID: 9213 RVA: 0x0006B4F0 File Offset: 0x000696F0
			[CallerCount(149)]
			[CachedScanResults(RefRangeStart = 59293, RefRangeEnd = 59442, XrefRangeStart = 59289, XrefRangeEnd = 59293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.LowMemoryCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023FE RID: 9214 RVA: 0x00015081 File Offset: 0x00013281
			public LowMemoryCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060023FF RID: 9215 RVA: 0x0001508A File Offset: 0x0001328A
			public static implicit operator Application.LowMemoryCallback(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<Application.LowMemoryCallback>(A_0);
			}

			// Token: 0x06002400 RID: 9216 RVA: 0x00015092 File Offset: 0x00013292
			public static Application.LowMemoryCallback operator +(Application.LowMemoryCallback A_0, Application.LowMemoryCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Application.LowMemoryCallback>();
			}

			// Token: 0x06002401 RID: 9217 RVA: 0x000150A0 File Offset: 0x000132A0
			public static Application.LowMemoryCallback operator -(Application.LowMemoryCallback A_0, Application.LowMemoryCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Application.LowMemoryCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001C26 RID: 7206
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001C27 RID: 7207
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
		}

		// Token: 0x02000321 RID: 801
		public sealed class LogCallback : MulticastDelegate
		{
			// Token: 0x06002402 RID: 9218 RVA: 0x000150B1 File Offset: 0x000132B1
			// Note: this type is marked as 'beforefieldinit'.
			static LogCallback()
			{
				Il2CppClassPointerStore<Application.LogCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Application>.NativeClassPtr, "LogCallback");
				Application.LogCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.LogCallback>.NativeClassPtr, 100663397);
				Application.LogCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Application.LogCallback>.NativeClassPtr, 100663398);
			}

			// Token: 0x06002403 RID: 9219 RVA: 0x0006B524 File Offset: 0x00069724
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LogCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Application.LogCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.LogCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002404 RID: 9220 RVA: 0x0006B580 File Offset: 0x00069780
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 59461, RefRangeEnd = 59463, XrefRangeStart = 59442, XrefRangeEnd = 59461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(string condition, string stackTrace, LogType type)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(condition);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Application.LogCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002405 RID: 9221 RVA: 0x000150EF File Offset: 0x000132EF
			public LogCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002406 RID: 9222 RVA: 0x000150F8 File Offset: 0x000132F8
			public static implicit operator Application.LogCallback(Action<string, string, LogType> A_0)
			{
				return DelegateSupport.ConvertDelegate<Application.LogCallback>(A_0);
			}

			// Token: 0x06002407 RID: 9223 RVA: 0x00015100 File Offset: 0x00013300
			public static Application.LogCallback operator +(Application.LogCallback A_0, Application.LogCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Application.LogCallback>();
			}

			// Token: 0x06002408 RID: 9224 RVA: 0x0001510E File Offset: 0x0001330E
			public static Application.LogCallback operator -(Application.LogCallback A_0, Application.LogCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Application.LogCallback>();
				}
				return delegate2;
			}

			// Token: 0x04001C28 RID: 7208
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001C29 RID: 7209
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_LogType_0;
		}

		// Token: 0x02000322 RID: 802
		// (Invoke) Token: 0x0600240A RID: 9226
		private delegate void CancelQuitDelegate();

		// Token: 0x02000323 RID: 803
		// (Invoke) Token: 0x0600240C RID: 9228
		private delegate void UnloadDelegate();

		// Token: 0x02000324 RID: 804
		// (Invoke) Token: 0x0600240E RID: 9230
		private delegate bool get_isLoadingLevelDelegate();

		// Token: 0x02000325 RID: 805
		// (Invoke) Token: 0x06002410 RID: 9232
		private delegate bool CanStreamedLevelBeLoadedDelegate(IntPtr levelName);

		// Token: 0x02000326 RID: 806
		// (Invoke) Token: 0x06002412 RID: 9234
		private delegate bool IsPlayingDelegate(IntPtr obj);

		// Token: 0x02000327 RID: 807
		// (Invoke) Token: 0x06002414 RID: 9236
		private delegate bool get_isFocusedDelegate();

		// Token: 0x02000328 RID: 808
		// (Invoke) Token: 0x06002416 RID: 9238
		private delegate IntPtr GetBuildTagsDelegate();

		// Token: 0x02000329 RID: 809
		// (Invoke) Token: 0x06002418 RID: 9240
		private delegate void SetBuildTagsDelegate(IntPtr buildTags);

		// Token: 0x0200032A RID: 810
		// (Invoke) Token: 0x0600241A RID: 9242
		private delegate IntPtr get_buildGUIDDelegate();

		// Token: 0x0200032B RID: 811
		// (Invoke) Token: 0x0600241C RID: 9244
		private delegate bool get_runInBackgroundDelegate();

		// Token: 0x0200032C RID: 812
		// (Invoke) Token: 0x0600241E RID: 9246
		private delegate void set_runInBackgroundDelegate(bool value);

		// Token: 0x0200032D RID: 813
		// (Invoke) Token: 0x06002420 RID: 9248
		private delegate bool HasProLicenseDelegate();

		// Token: 0x0200032E RID: 814
		// (Invoke) Token: 0x06002422 RID: 9250
		private delegate bool get_isBatchModeDelegate();

		// Token: 0x0200032F RID: 815
		// (Invoke) Token: 0x06002424 RID: 9252
		private delegate bool get_isTestRunDelegate();

		// Token: 0x02000330 RID: 816
		// (Invoke) Token: 0x06002426 RID: 9254
		private delegate bool get_isHumanControllingUsDelegate();

		// Token: 0x02000331 RID: 817
		// (Invoke) Token: 0x06002428 RID: 9256
		private delegate bool HasARGVDelegate(IntPtr name);

		// Token: 0x02000332 RID: 818
		// (Invoke) Token: 0x0600242A RID: 9258
		private delegate IntPtr GetValueForARGVDelegate(IntPtr name);

		// Token: 0x02000333 RID: 819
		// (Invoke) Token: 0x0600242C RID: 9260
		private delegate IntPtr get_temporaryCachePathDelegate();

		// Token: 0x02000334 RID: 820
		// (Invoke) Token: 0x0600242E RID: 9262
		private delegate IntPtr get_absoluteURLDelegate();

		// Token: 0x02000335 RID: 821
		// (Invoke) Token: 0x06002430 RID: 9264
		private delegate void Internal_ExternalCallDelegate(IntPtr script);

		// Token: 0x02000336 RID: 822
		// (Invoke) Token: 0x06002432 RID: 9266
		private delegate int get_unityVersionVerDelegate();

		// Token: 0x02000337 RID: 823
		// (Invoke) Token: 0x06002434 RID: 9268
		private delegate int get_unityVersionMajDelegate();

		// Token: 0x02000338 RID: 824
		// (Invoke) Token: 0x06002436 RID: 9270
		private delegate int get_unityVersionMinDelegate();

		// Token: 0x02000339 RID: 825
		// (Invoke) Token: 0x06002438 RID: 9272
		private delegate IntPtr get_installerNameDelegate();

		// Token: 0x0200033A RID: 826
		// (Invoke) Token: 0x0600243A RID: 9274
		private delegate IntPtr get_identifierDelegate();

		// Token: 0x0200033B RID: 827
		// (Invoke) Token: 0x0600243C RID: 9276
		private delegate ApplicationInstallMode get_installModeDelegate();

		// Token: 0x0200033C RID: 828
		// (Invoke) Token: 0x0600243E RID: 9278
		private delegate ApplicationSandboxType get_sandboxTypeDelegate();

		// Token: 0x0200033D RID: 829
		// (Invoke) Token: 0x06002440 RID: 9280
		private delegate IntPtr get_productNameDelegate();

		// Token: 0x0200033E RID: 830
		// (Invoke) Token: 0x06002442 RID: 9282
		private delegate IntPtr get_companyNameDelegate();

		// Token: 0x0200033F RID: 831
		// (Invoke) Token: 0x06002444 RID: 9284
		private delegate int get_targetFrameRateDelegate();

		// Token: 0x02000340 RID: 832
		// (Invoke) Token: 0x06002446 RID: 9286
		private delegate void SetLogCallbackDefinedDelegate(bool defined);

		// Token: 0x02000341 RID: 833
		// (Invoke) Token: 0x06002448 RID: 9288
		private delegate StackTraceLogType get_stackTraceLogTypeDelegate();

		// Token: 0x02000342 RID: 834
		// (Invoke) Token: 0x0600244A RID: 9290
		private delegate void set_stackTraceLogTypeDelegate(StackTraceLogType value);

		// Token: 0x02000343 RID: 835
		// (Invoke) Token: 0x0600244C RID: 9292
		private delegate StackTraceLogType GetStackTraceLogTypeDelegate(LogType logType);

		// Token: 0x02000344 RID: 836
		// (Invoke) Token: 0x0600244E RID: 9294
		private delegate void SetStackTraceLogTypeDelegate(LogType logType, StackTraceLogType stackTraceType);

		// Token: 0x02000345 RID: 837
		// (Invoke) Token: 0x06002450 RID: 9296
		private delegate IntPtr get_consoleLogPathDelegate();

		// Token: 0x02000346 RID: 838
		// (Invoke) Token: 0x06002452 RID: 9298
		private delegate ThreadPriority get_backgroundLoadingPriorityDelegate();

		// Token: 0x02000347 RID: 839
		// (Invoke) Token: 0x06002454 RID: 9300
		private delegate void set_backgroundLoadingPriorityDelegate(ThreadPriority value);

		// Token: 0x02000348 RID: 840
		// (Invoke) Token: 0x06002456 RID: 9302
		private delegate bool get_genuineDelegate();

		// Token: 0x02000349 RID: 841
		// (Invoke) Token: 0x06002458 RID: 9304
		private delegate bool get_genuineCheckAvailableDelegate();

		// Token: 0x0200034A RID: 842
		// (Invoke) Token: 0x0600245A RID: 9306
		private delegate IntPtr RequestUserAuthorizationDelegate(UserAuthorization mode);

		// Token: 0x0200034B RID: 843
		// (Invoke) Token: 0x0600245C RID: 9308
		private delegate bool HasUserAuthorizationDelegate(UserAuthorization mode);

		// Token: 0x0200034C RID: 844
		// (Invoke) Token: 0x0600245E RID: 9310
		private delegate bool get_submitAnalyticsDelegate();

		// Token: 0x0200034D RID: 845
		// (Invoke) Token: 0x06002460 RID: 9312
		private delegate SystemLanguage get_systemLanguageDelegate();

		// Token: 0x0200034E RID: 846
		// (Invoke) Token: 0x06002462 RID: 9314
		private delegate NetworkReachability get_internetReachabilityDelegate();
	}
}
