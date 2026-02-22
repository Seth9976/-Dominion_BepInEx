using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;

namespace UnityEngine.SceneManagement
{
	// Token: 0x02000118 RID: 280
	public class SceneManager : Object
	{
		// Token: 0x060016B9 RID: 5817 RVA: 0x000563E0 File Offset: 0x000545E0
		// Note: this type is marked as 'beforefieldinit'.
		static SceneManager()
		{
			Il2CppClassPointerStore<SceneManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "SceneManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager>.NativeClassPtr);
			SceneManager.NativeFieldInfoPtr_s_AllowLoadScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "s_AllowLoadScene");
			SceneManager.NativeFieldInfoPtr_sceneLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "sceneLoaded");
			SceneManager.NativeFieldInfoPtr_sceneUnloaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "sceneUnloaded");
			SceneManager.NativeFieldInfoPtr_activeSceneChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "activeSceneChanged");
			SceneManager.NativeMethodInfoPtr_get_sceneCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664998);
			SceneManager.NativeMethodInfoPtr_GetActiveScene_Public_Static_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664999);
			SceneManager.NativeMethodInfoPtr_GetSceneAt_Public_Static_Scene_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665000);
			SceneManager.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Private_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665001);
			SceneManager.NativeMethodInfoPtr_UnloadSceneNameIndexInternal_Private_Static_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665002);
			SceneManager.NativeMethodInfoPtr_LoadFirstScene_Internal_Internal_Static_AsyncOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665003);
			SceneManager.NativeMethodInfoPtr_add_sceneLoaded_Public_Static_add_Void_UnityAction_2_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665004);
			SceneManager.NativeMethodInfoPtr_remove_sceneLoaded_Public_Static_rem_Void_UnityAction_2_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665005);
			SceneManager.NativeMethodInfoPtr_add_sceneUnloaded_Public_Static_add_Void_UnityAction_1_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665006);
			SceneManager.NativeMethodInfoPtr_remove_sceneUnloaded_Public_Static_rem_Void_UnityAction_1_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665007);
			SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665008);
			SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Scene_String_LoadSceneParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665009);
			SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665010);
			SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665011);
			SceneManager.NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665012);
			SceneManager.NativeMethodInfoPtr_Internal_SceneLoaded_Private_Static_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665013);
			SceneManager.NativeMethodInfoPtr_Internal_SceneUnloaded_Private_Static_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665014);
			SceneManager.NativeMethodInfoPtr_Internal_ActiveSceneChanged_Private_Static_Void_Scene_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665015);
			SceneManager.NativeMethodInfoPtr_GetActiveScene_Injected_Private_Static_Void_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665017);
			SceneManager.NativeMethodInfoPtr_GetSceneAt_Injected_Private_Static_Void_Int32_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100665018);
			SceneManager.SetActiveScene_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.SetActiveScene_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::SetActiveScene_Injected");
			SceneManager.GetSceneByPath_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.GetSceneByPath_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::GetSceneByPath_Injected");
			SceneManager.GetSceneByName_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.GetSceneByName_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::GetSceneByName_Injected");
			SceneManager.CreateScene_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.CreateScene_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::CreateScene_Injected");
			SceneManager.UnloadSceneInternal_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.UnloadSceneInternal_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::UnloadSceneInternal_Injected");
			SceneManager.UnloadSceneAsyncInternal_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.UnloadSceneAsyncInternal_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::UnloadSceneAsyncInternal_Injected");
			SceneManager.MergeScenes_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.MergeScenes_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::MergeScenes_Injected");
			SceneManager.MoveGameObjectToScene_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.MoveGameObjectToScene_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::MoveGameObjectToScene_Injected");
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x00056668 File Offset: 0x00054868
		public unsafe static int sceneCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81342, XrefRangeEnd = 81344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_sceneCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x00056698 File Offset: 0x00054898
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 81349, RefRangeEnd = 81355, XrefRangeStart = 81344, XrefRangeEnd = 81349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Scene GetActiveScene()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetActiveScene_Public_Static_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x000566C8 File Offset: 0x000548C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81355, XrefRangeEnd = 81360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Scene GetSceneAt(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetSceneAt_Public_Static_Scene_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x00056708 File Offset: 0x00054908
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 81369, RefRangeEnd = 81373, XrefRangeStart = 81360, XrefRangeEnd = 81369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sceneBuildIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parameters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mustCompleteNextFrame;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Private_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x00056778 File Offset: 0x00054978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81373, XrefRangeEnd = 81382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sceneBuildIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref immediately;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outSuccess;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_UnloadSceneNameIndexInternal_Private_Static_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x000567F8 File Offset: 0x000549F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81382, XrefRangeEnd = 81387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation LoadFirstScene_Internal(bool async)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref async;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadFirstScene_Internal_Internal_Static_AsyncOperation_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
			}
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x00056838 File Offset: 0x00054A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81387, XrefRangeEnd = 81398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_sceneLoaded(UnityEngine.Events.UnityAction<Scene, LoadSceneMode> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_add_sceneLoaded_Public_Static_add_Void_UnityAction_2_Scene_LoadSceneMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x00056870 File Offset: 0x00054A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81398, XrefRangeEnd = 81409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_sceneLoaded(UnityEngine.Events.UnityAction<Scene, LoadSceneMode> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_remove_sceneLoaded_Public_Static_rem_Void_UnityAction_2_Scene_LoadSceneMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x000568A8 File Offset: 0x00054AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81409, XrefRangeEnd = 81420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_sceneUnloaded(UnityEngine.Events.UnityAction<Scene> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_add_sceneUnloaded_Public_Static_add_Void_UnityAction_1_Scene_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x000568E0 File Offset: 0x00054AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81420, XrefRangeEnd = 81431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_sceneUnloaded(UnityEngine.Events.UnityAction<Scene> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_remove_sceneUnloaded_Public_Static_rem_Void_UnityAction_1_Scene_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x00056918 File Offset: 0x00054B18
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 81447, RefRangeEnd = 81456, XrefRangeStart = 81431, XrefRangeEnd = 81447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadScene(string sceneName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x00056950 File Offset: 0x00054B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81456, XrefRangeEnd = 81467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Scene LoadScene(string sceneName, LoadSceneParameters parameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Scene_String_LoadSceneParameters_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x000569A0 File Offset: 0x00054BA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81476, RefRangeEnd = 81478, XrefRangeStart = 81467, XrefRangeEnd = 81476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x000569F4 File Offset: 0x00054BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81478, XrefRangeEnd = 81482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneParameters_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x00056A48 File Offset: 0x00054C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81482, XrefRangeEnd = 81494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation UnloadSceneAsync(string sceneName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
			}
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x00056A8C File Offset: 0x00054C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81494, XrefRangeEnd = 81503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Internal_SceneLoaded_Private_Static_Void_Scene_LoadSceneMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x00056ACC File Offset: 0x00054CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81503, XrefRangeEnd = 81512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SceneUnloaded(Scene scene)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Internal_SceneUnloaded_Private_Static_Void_Scene_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x00056B00 File Offset: 0x00054D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81512, XrefRangeEnd = 81521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref previousActiveScene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newActiveScene;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Internal_ActiveSceneChanged_Private_Static_Void_Scene_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x00056B40 File Offset: 0x00054D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81521, XrefRangeEnd = 81523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetActiveScene_Injected(out Scene ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetActiveScene_Injected_Private_Static_Void_byref_Scene_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x00056B74 File Offset: 0x00054D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81523, XrefRangeEnd = 81525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSceneAt_Injected(int index, out Scene ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetSceneAt_Injected_Private_Static_Void_Int32_byref_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x0000CC4E File Offset: 0x0000AE4E
		public SceneManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060016CF RID: 5839 RVA: 0x00056BB4 File Offset: 0x00054DB4
		// (set) Token: 0x060016D0 RID: 5840 RVA: 0x0000CC57 File Offset: 0x0000AE57
		public unsafe static bool s_AllowLoadScene
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_s_AllowLoadScene, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_s_AllowLoadScene, (void*)(&value));
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060016D1 RID: 5841 RVA: 0x00056BD0 File Offset: 0x00054DD0
		// (set) Token: 0x060016D2 RID: 5842 RVA: 0x0000CC65 File Offset: 0x0000AE65
		public unsafe static UnityEngine.Events.UnityAction<Scene, LoadSceneMode> sceneLoaded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_sceneLoaded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.Events.UnityAction<Scene, LoadSceneMode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_sceneLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060016D3 RID: 5843 RVA: 0x00056BF8 File Offset: 0x00054DF8
		// (set) Token: 0x060016D4 RID: 5844 RVA: 0x0000CC77 File Offset: 0x0000AE77
		public unsafe static UnityEngine.Events.UnityAction<Scene> sceneUnloaded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_sceneUnloaded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.Events.UnityAction<Scene>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_sceneUnloaded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060016D5 RID: 5845 RVA: 0x00056C20 File Offset: 0x00054E20
		// (set) Token: 0x060016D6 RID: 5846 RVA: 0x0000CC89 File Offset: 0x0000AE89
		public unsafe static UnityEngine.Events.UnityAction<Scene, Scene> activeSceneChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_activeSceneChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.Events.UnityAction<Scene, Scene>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_activeSceneChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060016D7 RID: 5847 RVA: 0x00056C48 File Offset: 0x00054E48
		public static int sceneCountInBuildSettings
		{
			get
			{
				return SceneManagerAPI.ActiveAPI.GetNumScenesInBuildSettings();
			}
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x0000CC9B File Offset: 0x0000AE9B
		public static bool SetActiveScene(Scene scene)
		{
			return SceneManager.SetActiveScene_Injected(ref scene);
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x00056C64 File Offset: 0x00054E64
		public static Scene GetSceneByPath(string scenePath)
		{
			Scene scene;
			SceneManager.GetSceneByPath_Injected(scenePath, out scene);
			return scene;
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x00056C7C File Offset: 0x00054E7C
		public static Scene GetSceneByName(string name)
		{
			Scene scene;
			SceneManager.GetSceneByName_Injected(name, out scene);
			return scene;
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x00056C94 File Offset: 0x00054E94
		public static Scene GetSceneByBuildIndex(int buildIndex)
		{
			return SceneManagerAPI.ActiveAPI.GetSceneByBuildIndex(buildIndex);
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x00056CB4 File Offset: 0x00054EB4
		public static Scene CreateScene(string sceneName, CreateSceneParameters parameters)
		{
			Scene scene;
			SceneManager.CreateScene_Injected(sceneName, ref parameters, out scene);
			return scene;
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x0000CCA4 File Offset: 0x0000AEA4
		public static bool UnloadSceneInternal(Scene scene, UnloadSceneOptions options)
		{
			return SceneManager.UnloadSceneInternal_Injected(ref scene, options);
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x0000CCAE File Offset: 0x0000AEAE
		public static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options)
		{
			return SceneManager.UnloadSceneAsyncInternal_Injected(ref scene, options);
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x0000CCB8 File Offset: 0x0000AEB8
		public static void MergeScenes(Scene sourceScene, Scene destinationScene)
		{
			SceneManager.MergeScenes_Injected(ref sourceScene, ref destinationScene);
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x0000CCC3 File Offset: 0x0000AEC3
		public static void MoveGameObjectToScene(GameObject go, Scene scene)
		{
			SceneManager.MoveGameObjectToScene_Injected(go, ref scene);
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x0000CCCD File Offset: 0x0000AECD
		public static void add_activeSceneChanged(UnityEngine.Events.UnityAction<Scene, Scene> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x0000CCDA File Offset: 0x0000AEDA
		public static void remove_activeSceneChanged(UnityEngine.Events.UnityAction<Scene, Scene> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x0000CCE7 File Offset: 0x0000AEE7
		public static Il2CppStructArray<Scene> GetAllScenes()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x00056CCC File Offset: 0x00054ECC
		public static Scene CreateScene(string sceneName)
		{
			CreateSceneParameters createSceneParameters = new CreateSceneParameters(LocalPhysicsMode.None);
			return SceneManager.CreateScene(sceneName, createSceneParameters);
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x00056CF0 File Offset: 0x00054EF0
		public static void LoadScene(string sceneName, LoadSceneMode mode)
		{
			LoadSceneParameters loadSceneParameters = new LoadSceneParameters(mode);
			SceneManager.LoadScene(sceneName, loadSceneParameters);
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x00056D10 File Offset: 0x00054F10
		public static void LoadScene(int sceneBuildIndex, LoadSceneMode mode)
		{
			LoadSceneParameters loadSceneParameters = new LoadSceneParameters(mode);
			SceneManager.LoadScene(sceneBuildIndex, loadSceneParameters);
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x00056D30 File Offset: 0x00054F30
		public static void LoadScene(int sceneBuildIndex)
		{
			LoadSceneParameters loadSceneParameters = new LoadSceneParameters(LoadSceneMode.Single);
			SceneManager.LoadScene(sceneBuildIndex, loadSceneParameters);
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x00056D50 File Offset: 0x00054F50
		public static Scene LoadScene(int sceneBuildIndex, LoadSceneParameters parameters)
		{
			SceneManager.LoadSceneAsyncNameIndexInternal(null, sceneBuildIndex, parameters, true);
			return SceneManager.GetSceneAt(SceneManager.sceneCount - 1);
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x00056D78 File Offset: 0x00054F78
		public static AsyncOperation LoadSceneAsync(int sceneBuildIndex, LoadSceneMode mode)
		{
			LoadSceneParameters loadSceneParameters = new LoadSceneParameters(mode);
			return SceneManager.LoadSceneAsync(sceneBuildIndex, loadSceneParameters);
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x00056D9C File Offset: 0x00054F9C
		public static AsyncOperation LoadSceneAsync(int sceneBuildIndex)
		{
			LoadSceneParameters loadSceneParameters = new LoadSceneParameters(LoadSceneMode.Single);
			return SceneManager.LoadSceneAsync(sceneBuildIndex, loadSceneParameters);
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x00056DC0 File Offset: 0x00054FC0
		public static AsyncOperation LoadSceneAsync(int sceneBuildIndex, LoadSceneParameters parameters)
		{
			return SceneManager.LoadSceneAsyncNameIndexInternal(null, sceneBuildIndex, parameters, false);
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x00056DDC File Offset: 0x00054FDC
		public static AsyncOperation LoadSceneAsync(string sceneName)
		{
			LoadSceneParameters loadSceneParameters = new LoadSceneParameters(LoadSceneMode.Single);
			return SceneManager.LoadSceneAsync(sceneName, loadSceneParameters);
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x00056E00 File Offset: 0x00055000
		public static bool UnloadScene(Scene scene)
		{
			return SceneManager.UnloadSceneInternal(scene, UnloadSceneOptions.None);
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x00056E1C File Offset: 0x0005501C
		public static bool UnloadScene(int sceneBuildIndex)
		{
			bool flag;
			SceneManager.UnloadSceneNameIndexInternal("", sceneBuildIndex, true, UnloadSceneOptions.None, out flag);
			return flag;
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00056E40 File Offset: 0x00055040
		public static bool UnloadScene(string sceneName)
		{
			bool flag;
			SceneManager.UnloadSceneNameIndexInternal(sceneName, -1, true, UnloadSceneOptions.None, out flag);
			return flag;
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x00056E60 File Offset: 0x00055060
		public static AsyncOperation UnloadSceneAsync(int sceneBuildIndex)
		{
			bool flag;
			return SceneManager.UnloadSceneNameIndexInternal("", sceneBuildIndex, false, UnloadSceneOptions.None, out flag);
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x00056E84 File Offset: 0x00055084
		public static AsyncOperation UnloadSceneAsync(Scene scene)
		{
			return SceneManager.UnloadSceneAsyncInternal(scene, UnloadSceneOptions.None);
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x00056EA0 File Offset: 0x000550A0
		public static AsyncOperation UnloadSceneAsync(int sceneBuildIndex, UnloadSceneOptions options)
		{
			bool flag;
			return SceneManager.UnloadSceneNameIndexInternal("", sceneBuildIndex, false, options, out flag);
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x00056EC4 File Offset: 0x000550C4
		public static AsyncOperation UnloadSceneAsync(string sceneName, UnloadSceneOptions options)
		{
			bool flag;
			return SceneManager.UnloadSceneNameIndexInternal(sceneName, -1, false, options, out flag);
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x00056EE4 File Offset: 0x000550E4
		public static AsyncOperation UnloadSceneAsync(Scene scene, UnloadSceneOptions options)
		{
			return SceneManager.UnloadSceneAsyncInternal(scene, options);
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x0000CCF4 File Offset: 0x0000AEF4
		public static bool SetActiveScene_Injected(ref Scene scene)
		{
			return SceneManager.SetActiveScene_InjectedDelegateField(ref scene);
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x0000CD01 File Offset: 0x0000AF01
		public static void GetSceneByPath_Injected(string scenePath, out Scene ret)
		{
			SceneManager.GetSceneByPath_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(scenePath), out ret);
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x0000CD14 File Offset: 0x0000AF14
		public static void GetSceneByName_Injected(string name, out Scene ret)
		{
			SceneManager.GetSceneByName_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(name), out ret);
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x0000CD27 File Offset: 0x0000AF27
		public static void CreateScene_Injected(string sceneName, ref CreateSceneParameters parameters, out Scene ret)
		{
			SceneManager.CreateScene_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(sceneName), ref parameters, out ret);
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x0000CD3B File Offset: 0x0000AF3B
		public static bool UnloadSceneInternal_Injected(ref Scene scene, UnloadSceneOptions options)
		{
			return SceneManager.UnloadSceneInternal_InjectedDelegateField(ref scene, options);
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x00056F00 File Offset: 0x00055100
		public static AsyncOperation UnloadSceneAsyncInternal_Injected(ref Scene scene, UnloadSceneOptions options)
		{
			IntPtr intPtr = SceneManager.UnloadSceneAsyncInternal_InjectedDelegateField(ref scene, options);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x0000CD49 File Offset: 0x0000AF49
		public static void MergeScenes_Injected(ref Scene sourceScene, ref Scene destinationScene)
		{
			SceneManager.MergeScenes_InjectedDelegateField(ref sourceScene, ref destinationScene);
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x0000CD57 File Offset: 0x0000AF57
		public static void MoveGameObjectToScene_Injected(GameObject go, ref Scene scene)
		{
			SceneManager.MoveGameObjectToScene_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(go), ref scene);
		}

		// Token: 0x0400109E RID: 4254
		private static readonly IntPtr NativeFieldInfoPtr_s_AllowLoadScene;

		// Token: 0x0400109F RID: 4255
		private static readonly IntPtr NativeFieldInfoPtr_sceneLoaded;

		// Token: 0x040010A0 RID: 4256
		private static readonly IntPtr NativeFieldInfoPtr_sceneUnloaded;

		// Token: 0x040010A1 RID: 4257
		private static readonly IntPtr NativeFieldInfoPtr_activeSceneChanged;

		// Token: 0x040010A2 RID: 4258
		private static readonly IntPtr NativeMethodInfoPtr_get_sceneCount_Public_Static_get_Int32_0;

		// Token: 0x040010A3 RID: 4259
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveScene_Public_Static_Scene_0;

		// Token: 0x040010A4 RID: 4260
		private static readonly IntPtr NativeMethodInfoPtr_GetSceneAt_Public_Static_Scene_Int32_0;

		// Token: 0x040010A5 RID: 4261
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Private_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0;

		// Token: 0x040010A6 RID: 4262
		private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneNameIndexInternal_Private_Static_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0;

		// Token: 0x040010A7 RID: 4263
		private static readonly IntPtr NativeMethodInfoPtr_LoadFirstScene_Internal_Internal_Static_AsyncOperation_Boolean_0;

		// Token: 0x040010A8 RID: 4264
		private static readonly IntPtr NativeMethodInfoPtr_add_sceneLoaded_Public_Static_add_Void_UnityAction_2_Scene_LoadSceneMode_0;

		// Token: 0x040010A9 RID: 4265
		private static readonly IntPtr NativeMethodInfoPtr_remove_sceneLoaded_Public_Static_rem_Void_UnityAction_2_Scene_LoadSceneMode_0;

		// Token: 0x040010AA RID: 4266
		private static readonly IntPtr NativeMethodInfoPtr_add_sceneUnloaded_Public_Static_add_Void_UnityAction_1_Scene_0;

		// Token: 0x040010AB RID: 4267
		private static readonly IntPtr NativeMethodInfoPtr_remove_sceneUnloaded_Public_Static_rem_Void_UnityAction_1_Scene_0;

		// Token: 0x040010AC RID: 4268
		private static readonly IntPtr NativeMethodInfoPtr_LoadScene_Public_Static_Void_String_0;

		// Token: 0x040010AD RID: 4269
		private static readonly IntPtr NativeMethodInfoPtr_LoadScene_Public_Static_Scene_String_LoadSceneParameters_0;

		// Token: 0x040010AE RID: 4270
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneMode_0;

		// Token: 0x040010AF RID: 4271
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneParameters_0;

		// Token: 0x040010B0 RID: 4272
		private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_String_0;

		// Token: 0x040010B1 RID: 4273
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SceneLoaded_Private_Static_Void_Scene_LoadSceneMode_0;

		// Token: 0x040010B2 RID: 4274
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SceneUnloaded_Private_Static_Void_Scene_0;

		// Token: 0x040010B3 RID: 4275
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ActiveSceneChanged_Private_Static_Void_Scene_Scene_0;

		// Token: 0x040010B4 RID: 4276
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveScene_Injected_Private_Static_Void_byref_Scene_0;

		// Token: 0x040010B5 RID: 4277
		private static readonly IntPtr NativeMethodInfoPtr_GetSceneAt_Injected_Private_Static_Void_Int32_byref_Scene_0;

		// Token: 0x040010B6 RID: 4278
		private static readonly SceneManager.SetActiveScene_InjectedDelegate SetActiveScene_InjectedDelegateField;

		// Token: 0x040010B7 RID: 4279
		private static readonly SceneManager.GetSceneByPath_InjectedDelegate GetSceneByPath_InjectedDelegateField;

		// Token: 0x040010B8 RID: 4280
		private static readonly SceneManager.GetSceneByName_InjectedDelegate GetSceneByName_InjectedDelegateField;

		// Token: 0x040010B9 RID: 4281
		private static readonly SceneManager.CreateScene_InjectedDelegate CreateScene_InjectedDelegateField;

		// Token: 0x040010BA RID: 4282
		private static readonly SceneManager.UnloadSceneInternal_InjectedDelegate UnloadSceneInternal_InjectedDelegateField;

		// Token: 0x040010BB RID: 4283
		private static readonly SceneManager.UnloadSceneAsyncInternal_InjectedDelegate UnloadSceneAsyncInternal_InjectedDelegateField;

		// Token: 0x040010BC RID: 4284
		private static readonly SceneManager.MergeScenes_InjectedDelegate MergeScenes_InjectedDelegateField;

		// Token: 0x040010BD RID: 4285
		private static readonly SceneManager.MoveGameObjectToScene_InjectedDelegate MoveGameObjectToScene_InjectedDelegateField;

		// Token: 0x020008D2 RID: 2258
		// (Invoke) Token: 0x06002FA3 RID: 12195
		private delegate bool SetActiveScene_InjectedDelegate(IntPtr scene);

		// Token: 0x020008D3 RID: 2259
		// (Invoke) Token: 0x06002FA5 RID: 12197
		private delegate void GetSceneByPath_InjectedDelegate(IntPtr scenePath, [Out] IntPtr ret);

		// Token: 0x020008D4 RID: 2260
		// (Invoke) Token: 0x06002FA7 RID: 12199
		private delegate void GetSceneByName_InjectedDelegate(IntPtr name, [Out] IntPtr ret);

		// Token: 0x020008D5 RID: 2261
		// (Invoke) Token: 0x06002FA9 RID: 12201
		private delegate void CreateScene_InjectedDelegate(IntPtr sceneName, IntPtr parameters, [Out] IntPtr ret);

		// Token: 0x020008D6 RID: 2262
		// (Invoke) Token: 0x06002FAB RID: 12203
		private delegate bool UnloadSceneInternal_InjectedDelegate(IntPtr scene, UnloadSceneOptions options);

		// Token: 0x020008D7 RID: 2263
		// (Invoke) Token: 0x06002FAD RID: 12205
		private delegate IntPtr UnloadSceneAsyncInternal_InjectedDelegate(IntPtr scene, UnloadSceneOptions options);

		// Token: 0x020008D8 RID: 2264
		// (Invoke) Token: 0x06002FAF RID: 12207
		private delegate void MergeScenes_InjectedDelegate(IntPtr sourceScene, IntPtr destinationScene);

		// Token: 0x020008D9 RID: 2265
		// (Invoke) Token: 0x06002FB1 RID: 12209
		private delegate void MoveGameObjectToScene_InjectedDelegate(IntPtr go, IntPtr scene);
	}
}
