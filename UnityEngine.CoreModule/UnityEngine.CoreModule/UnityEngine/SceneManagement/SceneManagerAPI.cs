using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.SceneManagement
{
	// Token: 0x02000117 RID: 279
	public class SceneManagerAPI : Object
	{
		// Token: 0x060016AA RID: 5802 RVA: 0x000560A8 File Offset: 0x000542A8
		// Note: this type is marked as 'beforefieldinit'.
		static SceneManagerAPI()
		{
			Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "SceneManagerAPI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr);
			SceneManagerAPI.NativeFieldInfoPtr_s_DefaultAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, "s_DefaultAPI");
			SceneManagerAPI.NativeFieldInfoPtr__overrideAPI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, "<overrideAPI>k__BackingField");
			SceneManagerAPI.NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_SceneManagerAPI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100664991);
			SceneManagerAPI.NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_SceneManagerAPI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100664992);
			SceneManagerAPI.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100664993);
			SceneManagerAPI.NativeMethodInfoPtr_LoadSceneAsyncByNameOrIndex_FamOrAssem_Virtual_New_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100664994);
			SceneManagerAPI.NativeMethodInfoPtr_UnloadSceneAsyncByNameOrIndex_FamOrAssem_Virtual_New_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100664995);
			SceneManagerAPI.NativeMethodInfoPtr_LoadFirstScene_FamOrAssem_Virtual_New_AsyncOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100664996);
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060016AB RID: 5803 RVA: 0x00056178 File Offset: 0x00054378
		public unsafe static SceneManagerAPI ActiveAPI
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 81325, RefRangeEnd = 81329, XrefRangeStart = 81315, XrefRangeEnd = 81325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPI.NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_SceneManagerAPI_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SceneManagerAPI>(intPtr3) : null;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060016AC RID: 5804 RVA: 0x000561AC File Offset: 0x000543AC
		// (set) Token: 0x060016B6 RID: 5814 RVA: 0x0000CC37 File Offset: 0x0000AE37
		public unsafe static SceneManagerAPI overrideAPI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81329, XrefRangeEnd = 81333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPI.NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_SceneManagerAPI_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SceneManagerAPI>(intPtr3) : null;
			}
			set
			{
				SceneManagerAPI._overrideAPI_k__BackingField = value;
			}
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x000561E0 File Offset: 0x000543E0
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneManagerAPI()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPI.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x0005621C File Offset: 0x0005441C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81333, XrefRangeEnd = 81335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneManagerAPI.NativeMethodInfoPtr_LoadSceneAsyncByNameOrIndex_FamOrAssem_Virtual_New_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x000562A4 File Offset: 0x000544A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81335, XrefRangeEnd = 81342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperation UnloadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneManagerAPI.NativeMethodInfoPtr_UnloadSceneAsyncByNameOrIndex_FamOrAssem_Virtual_New_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00056338 File Offset: 0x00054538
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperation LoadFirstScene(bool mustLoadAsync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mustLoadAsync;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneManagerAPI.NativeMethodInfoPtr_LoadFirstScene_FamOrAssem_Virtual_New_AsyncOperation_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
			}
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x0000CC0A File Offset: 0x0000AE0A
		public SceneManagerAPI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060016B2 RID: 5810 RVA: 0x00056390 File Offset: 0x00054590
		// (set) Token: 0x060016B3 RID: 5811 RVA: 0x0000CC13 File Offset: 0x0000AE13
		public unsafe static SceneManagerAPI s_DefaultAPI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManagerAPI.NativeFieldInfoPtr_s_DefaultAPI, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManagerAPI>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManagerAPI.NativeFieldInfoPtr_s_DefaultAPI, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060016B4 RID: 5812 RVA: 0x000563B8 File Offset: 0x000545B8
		// (set) Token: 0x060016B5 RID: 5813 RVA: 0x0000CC25 File Offset: 0x0000AE25
		public unsafe static SceneManagerAPI _overrideAPI_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManagerAPI.NativeFieldInfoPtr__overrideAPI_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManagerAPI>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManagerAPI.NativeFieldInfoPtr__overrideAPI_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x0000CC3F File Offset: 0x0000AE3F
		public virtual int GetNumScenesInBuildSettings()
		{
			return SceneManagerAPIInternal.GetNumScenesInBuildSettings();
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x0000CC46 File Offset: 0x0000AE46
		public virtual Scene GetSceneByBuildIndex(int buildIndex)
		{
			return SceneManagerAPIInternal.GetSceneByBuildIndex(buildIndex);
		}

		// Token: 0x04001096 RID: 4246
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultAPI;

		// Token: 0x04001097 RID: 4247
		private static readonly IntPtr NativeFieldInfoPtr__overrideAPI_k__BackingField;

		// Token: 0x04001098 RID: 4248
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_SceneManagerAPI_0;

		// Token: 0x04001099 RID: 4249
		private static readonly IntPtr NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_SceneManagerAPI_0;

		// Token: 0x0400109A RID: 4250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_0;

		// Token: 0x0400109B RID: 4251
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsyncByNameOrIndex_FamOrAssem_Virtual_New_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0;

		// Token: 0x0400109C RID: 4252
		private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneAsyncByNameOrIndex_FamOrAssem_Virtual_New_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0;

		// Token: 0x0400109D RID: 4253
		private static readonly IntPtr NativeMethodInfoPtr_LoadFirstScene_FamOrAssem_Virtual_New_AsyncOperation_Boolean_0;
	}
}
