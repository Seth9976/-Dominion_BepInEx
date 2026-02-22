using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.SceneManagement
{
	// Token: 0x02000115 RID: 277
	[Serializable]
	[StructLayout(2)]
	public struct Scene
	{
		// Token: 0x0600167E RID: 5758 RVA: 0x0005584C File Offset: 0x00053A4C
		// Note: this type is marked as 'beforefieldinit'.
		static Scene()
		{
			Il2CppClassPointerStore<Scene>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "Scene");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scene>.NativeClassPtr);
			Scene.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scene>.NativeClassPtr, "m_Handle");
			Scene.NativeMethodInfoPtr_IsValidInternal_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100664974);
			Scene.NativeMethodInfoPtr_GetNameInternal_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100664975);
			Scene.NativeMethodInfoPtr_GetIsLoadedInternal_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100664976);
			Scene.NativeMethodInfoPtr_GetRootCountInternal_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100664977);
			Scene.NativeMethodInfoPtr_GetRootGameObjectsInternal_Private_Static_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100664978);
			Scene.NativeMethodInfoPtr_get_handle_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100664979);
			Scene.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100664980);
			Scene.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100664981);
			Scene.NativeMethodInfoPtr_get_isLoaded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100664982);
			Scene.NativeMethodInfoPtr_get_rootCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100664983);
			Scene.NativeMethodInfoPtr_GetRootGameObjects_Public_Il2CppReferenceArray_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100664984);
			Scene.NativeMethodInfoPtr_GetRootGameObjects_Public_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100664985);
			Scene.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100664986);
			Scene.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100664987);
			Scene.GetPathInternalDelegateField = IL2CPP.ResolveICall<Scene.GetPathInternalDelegate>("UnityEngine.SceneManagement.Scene::GetPathInternal");
			Scene.SetNameInternalDelegateField = IL2CPP.ResolveICall<Scene.SetNameInternalDelegate>("UnityEngine.SceneManagement.Scene::SetNameInternal");
			Scene.GetGUIDInternalDelegateField = IL2CPP.ResolveICall<Scene.GetGUIDInternalDelegate>("UnityEngine.SceneManagement.Scene::GetGUIDInternal");
			Scene.IsSubSceneDelegateField = IL2CPP.ResolveICall<Scene.IsSubSceneDelegate>("UnityEngine.SceneManagement.Scene::IsSubScene");
			Scene.SetIsSubSceneDelegateField = IL2CPP.ResolveICall<Scene.SetIsSubSceneDelegate>("UnityEngine.SceneManagement.Scene::SetIsSubScene");
			Scene.GetLoadingStateInternalDelegateField = IL2CPP.ResolveICall<Scene.GetLoadingStateInternalDelegate>("UnityEngine.SceneManagement.Scene::GetLoadingStateInternal");
			Scene.GetIsDirtyInternalDelegateField = IL2CPP.ResolveICall<Scene.GetIsDirtyInternalDelegate>("UnityEngine.SceneManagement.Scene::GetIsDirtyInternal");
			Scene.GetDirtyIDDelegateField = IL2CPP.ResolveICall<Scene.GetDirtyIDDelegate>("UnityEngine.SceneManagement.Scene::GetDirtyID");
			Scene.GetBuildIndexInternalDelegateField = IL2CPP.ResolveICall<Scene.GetBuildIndexInternalDelegate>("UnityEngine.SceneManagement.Scene::GetBuildIndexInternal");
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x00055A30 File Offset: 0x00053C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81236, XrefRangeEnd = 81238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidInternal(int sceneHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sceneHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_IsValidInternal_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x00055A70 File Offset: 0x00053C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81238, XrefRangeEnd = 81240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNameInternal(int sceneHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sceneHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetNameInternal_Private_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x00055AA8 File Offset: 0x00053CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81240, XrefRangeEnd = 81242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetIsLoadedInternal(int sceneHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sceneHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetIsLoadedInternal_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00055AE8 File Offset: 0x00053CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81242, XrefRangeEnd = 81244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRootCountInternal(int sceneHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sceneHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetRootCountInternal_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x00055B28 File Offset: 0x00053D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81244, XrefRangeEnd = 81246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRootGameObjectsInternal(int sceneHandle, Object resultRootList)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sceneHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultRootList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetRootGameObjectsInternal_Private_Static_Void_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001684 RID: 5764 RVA: 0x00055B6C File Offset: 0x00053D6C
		public unsafe int handle
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 62259, RefRangeEnd = 62285, XrefRangeStart = 62259, XrefRangeEnd = 62285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_get_handle_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x00055B9C File Offset: 0x00053D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81246, XrefRangeEnd = 81248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_IsValid_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001686 RID: 5766 RVA: 0x00055BCC File Offset: 0x00053DCC
		// (set) Token: 0x0600169A RID: 5786 RVA: 0x0000CBC7 File Offset: 0x0000ADC7
		public unsafe string name
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 81250, RefRangeEnd = 81265, XrefRangeStart = 81248, XrefRangeEnd = 81250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_get_name_Public_get_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				Scene.SetNameInternal(this.handle, value);
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001687 RID: 5767 RVA: 0x00055BF8 File Offset: 0x00053DF8
		public unsafe bool isLoaded
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81265, XrefRangeEnd = 81267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_get_isLoaded_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001688 RID: 5768 RVA: 0x00055C28 File Offset: 0x00053E28
		public unsafe int rootCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81267, XrefRangeEnd = 81269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_get_rootCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x00055C58 File Offset: 0x00053E58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81282, RefRangeEnd = 81283, XrefRangeStart = 81269, XrefRangeEnd = 81282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<GameObject> GetRootGameObjects()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetRootGameObjects_Public_Il2CppReferenceArray_1_GameObject_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr3) : null;
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x00055C8C File Offset: 0x00053E8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81305, RefRangeEnd = 81306, XrefRangeStart = 81283, XrefRangeEnd = 81305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetRootGameObjects(List<GameObject> rootGameObjects)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootGameObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetRootGameObjects_Public_Void_List_1_GameObject_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x00055CC4 File Offset: 0x00053EC4
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 62259, RefRangeEnd = 62285, XrefRangeStart = 62259, XrefRangeEnd = 62285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x00055CF4 File Offset: 0x00053EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81306, XrefRangeEnd = 81309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x0000CB53 File Offset: 0x0000AD53
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Scene>.NativeClassPtr, ref this));
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00055D38 File Offset: 0x00053F38
		public static string GetPathInternal(int sceneHandle)
		{
			IntPtr intPtr = Scene.GetPathInternalDelegateField(sceneHandle);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x0000CB65 File Offset: 0x0000AD65
		public static void SetNameInternal(int sceneHandle, string name)
		{
			Scene.SetNameInternalDelegateField(sceneHandle, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x00055D58 File Offset: 0x00053F58
		public static string GetGUIDInternal(int sceneHandle)
		{
			IntPtr intPtr = Scene.GetGUIDInternalDelegateField(sceneHandle);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x0000CB78 File Offset: 0x0000AD78
		public static bool IsSubScene(int sceneHandle)
		{
			return Scene.IsSubSceneDelegateField(sceneHandle);
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x0000CB85 File Offset: 0x0000AD85
		public static void SetIsSubScene(int sceneHandle, bool value)
		{
			Scene.SetIsSubSceneDelegateField(sceneHandle, value);
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x0000CB93 File Offset: 0x0000AD93
		public static Scene.LoadingState GetLoadingStateInternal(int sceneHandle)
		{
			return Scene.GetLoadingStateInternalDelegateField(sceneHandle);
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x0000CBA0 File Offset: 0x0000ADA0
		public static bool GetIsDirtyInternal(int sceneHandle)
		{
			return Scene.GetIsDirtyInternalDelegateField(sceneHandle);
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x0000CBAD File Offset: 0x0000ADAD
		public static int GetDirtyID(int sceneHandle)
		{
			return Scene.GetDirtyIDDelegateField(sceneHandle);
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x0000CBBA File Offset: 0x0000ADBA
		public static int GetBuildIndexInternal(int sceneHandle)
		{
			return Scene.GetBuildIndexInternalDelegateField(sceneHandle);
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001697 RID: 5783 RVA: 0x00055D78 File Offset: 0x00053F78
		public Scene.LoadingState loadingState
		{
			get
			{
				return Scene.GetLoadingStateInternal(this.handle);
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001698 RID: 5784 RVA: 0x00055D98 File Offset: 0x00053F98
		public string guid
		{
			get
			{
				return Scene.GetGUIDInternal(this.handle);
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001699 RID: 5785 RVA: 0x00055DB8 File Offset: 0x00053FB8
		public string path
		{
			get
			{
				return Scene.GetPathInternal(this.handle);
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x0600169B RID: 5787 RVA: 0x00055DD8 File Offset: 0x00053FD8
		public int buildIndex
		{
			get
			{
				return Scene.GetBuildIndexInternal(this.handle);
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x0600169C RID: 5788 RVA: 0x00055DF8 File Offset: 0x00053FF8
		public bool isDirty
		{
			get
			{
				return Scene.GetIsDirtyInternal(this.handle);
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x0600169D RID: 5789 RVA: 0x00055E18 File Offset: 0x00054018
		public int dirtyID
		{
			get
			{
				return Scene.GetDirtyID(this.handle);
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x0600169E RID: 5790 RVA: 0x00055E38 File Offset: 0x00054038
		// (set) Token: 0x0600169F RID: 5791 RVA: 0x0000CBD7 File Offset: 0x0000ADD7
		public bool isSubScene
		{
			get
			{
				return Scene.IsSubScene(this.handle);
			}
			set
			{
				Scene.SetIsSubScene(this.handle, value);
			}
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x00055E58 File Offset: 0x00054058
		public static bool operator ==(Scene lhs, Scene rhs)
		{
			return lhs.handle == rhs.handle;
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x00055E7C File Offset: 0x0005407C
		public static bool operator !=(Scene lhs, Scene rhs)
		{
			return lhs.handle != rhs.handle;
		}

		// Token: 0x04001078 RID: 4216
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04001079 RID: 4217
		private static readonly IntPtr NativeMethodInfoPtr_IsValidInternal_Private_Static_Boolean_Int32_0;

		// Token: 0x0400107A RID: 4218
		private static readonly IntPtr NativeMethodInfoPtr_GetNameInternal_Private_Static_String_Int32_0;

		// Token: 0x0400107B RID: 4219
		private static readonly IntPtr NativeMethodInfoPtr_GetIsLoadedInternal_Private_Static_Boolean_Int32_0;

		// Token: 0x0400107C RID: 4220
		private static readonly IntPtr NativeMethodInfoPtr_GetRootCountInternal_Private_Static_Int32_Int32_0;

		// Token: 0x0400107D RID: 4221
		private static readonly IntPtr NativeMethodInfoPtr_GetRootGameObjectsInternal_Private_Static_Void_Int32_Object_0;

		// Token: 0x0400107E RID: 4222
		private static readonly IntPtr NativeMethodInfoPtr_get_handle_Public_get_Int32_0;

		// Token: 0x0400107F RID: 4223
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x04001080 RID: 4224
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x04001081 RID: 4225
		private static readonly IntPtr NativeMethodInfoPtr_get_isLoaded_Public_get_Boolean_0;

		// Token: 0x04001082 RID: 4226
		private static readonly IntPtr NativeMethodInfoPtr_get_rootCount_Public_get_Int32_0;

		// Token: 0x04001083 RID: 4227
		private static readonly IntPtr NativeMethodInfoPtr_GetRootGameObjects_Public_Il2CppReferenceArray_1_GameObject_0;

		// Token: 0x04001084 RID: 4228
		private static readonly IntPtr NativeMethodInfoPtr_GetRootGameObjects_Public_Void_List_1_GameObject_0;

		// Token: 0x04001085 RID: 4229
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001086 RID: 4230
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001087 RID: 4231
		[FieldOffset(0)]
		public int m_Handle;

		// Token: 0x04001088 RID: 4232
		private static readonly Scene.GetPathInternalDelegate GetPathInternalDelegateField;

		// Token: 0x04001089 RID: 4233
		private static readonly Scene.SetNameInternalDelegate SetNameInternalDelegateField;

		// Token: 0x0400108A RID: 4234
		private static readonly Scene.GetGUIDInternalDelegate GetGUIDInternalDelegateField;

		// Token: 0x0400108B RID: 4235
		private static readonly Scene.IsSubSceneDelegate IsSubSceneDelegateField;

		// Token: 0x0400108C RID: 4236
		private static readonly Scene.SetIsSubSceneDelegate SetIsSubSceneDelegateField;

		// Token: 0x0400108D RID: 4237
		private static readonly Scene.GetLoadingStateInternalDelegate GetLoadingStateInternalDelegateField;

		// Token: 0x0400108E RID: 4238
		private static readonly Scene.GetIsDirtyInternalDelegate GetIsDirtyInternalDelegateField;

		// Token: 0x0400108F RID: 4239
		private static readonly Scene.GetDirtyIDDelegate GetDirtyIDDelegateField;

		// Token: 0x04001090 RID: 4240
		private static readonly Scene.GetBuildIndexInternalDelegate GetBuildIndexInternalDelegateField;

		// Token: 0x020008C6 RID: 2246
		public enum LoadingState
		{
			// Token: 0x04001CFD RID: 7421
			NotLoaded,
			// Token: 0x04001CFE RID: 7422
			Loading,
			// Token: 0x04001CFF RID: 7423
			Loaded,
			// Token: 0x04001D00 RID: 7424
			Unloading
		}

		// Token: 0x020008C7 RID: 2247
		// (Invoke) Token: 0x06002F8D RID: 12173
		private delegate IntPtr GetPathInternalDelegate(int sceneHandle);

		// Token: 0x020008C8 RID: 2248
		// (Invoke) Token: 0x06002F8F RID: 12175
		private delegate void SetNameInternalDelegate(int sceneHandle, IntPtr name);

		// Token: 0x020008C9 RID: 2249
		// (Invoke) Token: 0x06002F91 RID: 12177
		private delegate IntPtr GetGUIDInternalDelegate(int sceneHandle);

		// Token: 0x020008CA RID: 2250
		// (Invoke) Token: 0x06002F93 RID: 12179
		private delegate bool IsSubSceneDelegate(int sceneHandle);

		// Token: 0x020008CB RID: 2251
		// (Invoke) Token: 0x06002F95 RID: 12181
		private delegate void SetIsSubSceneDelegate(int sceneHandle, bool value);

		// Token: 0x020008CC RID: 2252
		// (Invoke) Token: 0x06002F97 RID: 12183
		private delegate Scene.LoadingState GetLoadingStateInternalDelegate(int sceneHandle);

		// Token: 0x020008CD RID: 2253
		// (Invoke) Token: 0x06002F99 RID: 12185
		private delegate bool GetIsDirtyInternalDelegate(int sceneHandle);

		// Token: 0x020008CE RID: 2254
		// (Invoke) Token: 0x06002F9B RID: 12187
		private delegate int GetDirtyIDDelegate(int sceneHandle);

		// Token: 0x020008CF RID: 2255
		// (Invoke) Token: 0x06002F9D RID: 12189
		private delegate int GetBuildIndexInternalDelegate(int sceneHandle);
	}
}
