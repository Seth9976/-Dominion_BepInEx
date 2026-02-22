using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.SceneManagement
{
	// Token: 0x02000116 RID: 278
	public static class SceneManagerAPIInternal : Object
	{
		// Token: 0x060016A2 RID: 5794 RVA: 0x00055EA4 File Offset: 0x000540A4
		// Note: this type is marked as 'beforefieldinit'.
		static SceneManagerAPIInternal()
		{
			Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "SceneManagerAPIInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr);
			SceneManagerAPIInternal.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Public_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr, 100664988);
			SceneManagerAPIInternal.NativeMethodInfoPtr_UnloadSceneNameIndexInternal_Public_Static_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr, 100664989);
			SceneManagerAPIInternal.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Injected_Private_Static_AsyncOperation_String_Int32_byref_LoadSceneParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr, 100664990);
			SceneManagerAPIInternal.GetNumScenesInBuildSettingsDelegateField = IL2CPP.ResolveICall<SceneManagerAPIInternal.GetNumScenesInBuildSettingsDelegate>("UnityEngine.SceneManagement.SceneManagerAPIInternal::GetNumScenesInBuildSettings");
			SceneManagerAPIInternal.GetSceneByBuildIndex_InjectedDelegateField = IL2CPP.ResolveICall<SceneManagerAPIInternal.GetSceneByBuildIndex_InjectedDelegate>("UnityEngine.SceneManagement.SceneManagerAPIInternal::GetSceneByBuildIndex_Injected");
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x00055F30 File Offset: 0x00054130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81309, XrefRangeEnd = 81311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPIInternal.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Public_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00055FA0 File Offset: 0x000541A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81311, XrefRangeEnd = 81313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPIInternal.NativeMethodInfoPtr_UnloadSceneNameIndexInternal_Public_Static_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x00056020 File Offset: 0x00054220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81313, XrefRangeEnd = 81315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sceneBuildIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &parameters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mustCompleteNextFrame;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPIInternal.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Injected_Private_Static_AsyncOperation_String_Int32_byref_LoadSceneParameters_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x0000CBE7 File Offset: 0x0000ADE7
		public SceneManagerAPIInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x0000CBF0 File Offset: 0x0000ADF0
		public static int GetNumScenesInBuildSettings()
		{
			return SceneManagerAPIInternal.GetNumScenesInBuildSettingsDelegateField();
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00056090 File Offset: 0x00054290
		public static Scene GetSceneByBuildIndex(int buildIndex)
		{
			Scene scene;
			SceneManagerAPIInternal.GetSceneByBuildIndex_Injected(buildIndex, out scene);
			return scene;
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x0000CBFC File Offset: 0x0000ADFC
		public static void GetSceneByBuildIndex_Injected(int buildIndex, out Scene ret)
		{
			SceneManagerAPIInternal.GetSceneByBuildIndex_InjectedDelegateField(buildIndex, out ret);
		}

		// Token: 0x04001091 RID: 4241
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Public_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0;

		// Token: 0x04001092 RID: 4242
		private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneNameIndexInternal_Public_Static_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0;

		// Token: 0x04001093 RID: 4243
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Injected_Private_Static_AsyncOperation_String_Int32_byref_LoadSceneParameters_Boolean_0;

		// Token: 0x04001094 RID: 4244
		private static readonly SceneManagerAPIInternal.GetNumScenesInBuildSettingsDelegate GetNumScenesInBuildSettingsDelegateField;

		// Token: 0x04001095 RID: 4245
		private static readonly SceneManagerAPIInternal.GetSceneByBuildIndex_InjectedDelegate GetSceneByBuildIndex_InjectedDelegateField;

		// Token: 0x020008D0 RID: 2256
		// (Invoke) Token: 0x06002F9F RID: 12191
		private delegate int GetNumScenesInBuildSettingsDelegate();

		// Token: 0x020008D1 RID: 2257
		// (Invoke) Token: 0x06002FA1 RID: 12193
		private delegate void GetSceneByBuildIndex_InjectedDelegate(int buildIndex, [Out] IntPtr ret);
	}
}
