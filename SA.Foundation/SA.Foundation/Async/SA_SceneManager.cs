using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.SceneManagement;

namespace SA.Foundation.Async
{
	// Token: 0x02000041 RID: 65
	public class SA_SceneManager : Object
	{
		// Token: 0x0600038D RID: 909 RVA: 0x00012190 File Offset: 0x00010390
		// Note: this type is marked as 'beforefieldinit'.
		static SA_SceneManager()
		{
			Il2CppClassPointerStore<SA_SceneManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Async", "SA_SceneManager");
			SA_SceneManager.NativeFieldInfoPtr_SceneLoadCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_SceneManager>.NativeClassPtr, "SceneLoadCompleted");
			SA_SceneManager.NativeFieldInfoPtr_SceneUnloadCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_SceneManager>.NativeClassPtr, "SceneUnloadCompleted");
			SA_SceneManager.NativeFieldInfoPtr_s_additiveScenes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_SceneManager>.NativeClassPtr, "s_additiveScenes");
			SA_SceneManager.NativeFieldInfoPtr_s_loadSceneRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_SceneManager>.NativeClassPtr, "s_loadSceneRequests");
			SA_SceneManager.NativeFieldInfoPtr_s_unloadSceneCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_SceneManager>.NativeClassPtr, "s_unloadSceneCallbacks");
			SA_SceneManager.NativeMethodInfoPtr_add_SceneLoadCompleted_Public_Static_add_Void_Action_2_String_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_SceneManager>.NativeClassPtr, 100663851);
			SA_SceneManager.NativeMethodInfoPtr_remove_SceneLoadCompleted_Public_Static_rem_Void_Action_2_String_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_SceneManager>.NativeClassPtr, 100663852);
			SA_SceneManager.NativeMethodInfoPtr_add_SceneUnloadCompleted_Public_Static_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_SceneManager>.NativeClassPtr, 100663853);
			SA_SceneManager.NativeMethodInfoPtr_remove_SceneUnloadCompleted_Public_Static_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_SceneManager>.NativeClassPtr, 100663854);
			SA_SceneManager.NativeMethodInfoPtr_LoadAdditively_Public_Static_Void_String_Action_1_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_SceneManager>.NativeClassPtr, 100663856);
			SA_SceneManager.NativeMethodInfoPtr_Unload_Public_Static_Void_Scene_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_SceneManager>.NativeClassPtr, 100663857);
			SA_SceneManager.NativeMethodInfoPtr_UnloadLastScene_Public_Static_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_SceneManager>.NativeClassPtr, 100663858);
			SA_SceneManager.NativeMethodInfoPtr_Unload_Public_Static_Void_String_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_SceneManager>.NativeClassPtr, 100663859);
			SA_SceneManager.NativeMethodInfoPtr_AdditiveSceneLoaded_Private_Static_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_SceneManager>.NativeClassPtr, 100663860);
			SA_SceneManager.NativeMethodInfoPtr_SceneUnloadComplete_Private_Static_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_SceneManager>.NativeClassPtr, 100663861);
			SA_SceneManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_SceneManager>.NativeClassPtr, 100663862);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x000122F8 File Offset: 0x000104F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107773, XrefRangeEnd = 107784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_SceneLoadCompleted(Action<string, LoadSceneMode> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_SceneManager.NativeMethodInfoPtr_add_SceneLoadCompleted_Public_Static_add_Void_Action_2_String_LoadSceneMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00012330 File Offset: 0x00010530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107784, XrefRangeEnd = 107795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_SceneLoadCompleted(Action<string, LoadSceneMode> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_SceneManager.NativeMethodInfoPtr_remove_SceneLoadCompleted_Public_Static_rem_Void_Action_2_String_LoadSceneMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00012368 File Offset: 0x00010568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107795, XrefRangeEnd = 107806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_SceneUnloadCompleted(Action<string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_SceneManager.NativeMethodInfoPtr_add_SceneUnloadCompleted_Public_Static_add_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x000123A0 File Offset: 0x000105A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107806, XrefRangeEnd = 107817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_SceneUnloadCompleted(Action<string> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_SceneManager.NativeMethodInfoPtr_remove_SceneUnloadCompleted_Public_Static_rem_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000123D8 File Offset: 0x000105D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107817, XrefRangeEnd = 107863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadAdditively(string sceneName, Action<Scene> callback = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_SceneManager.NativeMethodInfoPtr_LoadAdditively_Public_Static_Void_String_Action_1_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00012420 File Offset: 0x00010620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107863, XrefRangeEnd = 107868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Unload(Scene scene, Action callback = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_SceneManager.NativeMethodInfoPtr_Unload_Public_Static_Void_Scene_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00012464 File Offset: 0x00010664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107868, XrefRangeEnd = 107879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnloadLastScene(Action callback = null)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_SceneManager.NativeMethodInfoPtr_UnloadLastScene_Public_Static_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0001249C File Offset: 0x0001069C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107906, RefRangeEnd = 107908, XrefRangeStart = 107879, XrefRangeEnd = 107906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Unload(string sceneName, Action callback = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_SceneManager.NativeMethodInfoPtr_Unload_Public_Static_Void_String_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x000124E4 File Offset: 0x000106E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107908, XrefRangeEnd = 107949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AdditiveSceneLoaded(Scene scene, LoadSceneMode mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_SceneManager.NativeMethodInfoPtr_AdditiveSceneLoaded_Private_Static_Void_Scene_LoadSceneMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00012524 File Offset: 0x00010724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107949, XrefRangeEnd = 107991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SceneUnloadComplete(Scene scene)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_SceneManager.NativeMethodInfoPtr_SceneUnloadComplete_Private_Static_Void_Scene_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00012558 File Offset: 0x00010758
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_SceneManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_SceneManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_SceneManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00002EB4 File Offset: 0x000010B4
		public SA_SceneManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00012594 File Offset: 0x00010794
		// (set) Token: 0x0600039B RID: 923 RVA: 0x00002EBD File Offset: 0x000010BD
		public unsafe static Action<string, LoadSceneMode> SceneLoadCompleted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_SceneManager.NativeFieldInfoPtr_SceneLoadCompleted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, LoadSceneMode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_SceneManager.NativeFieldInfoPtr_SceneLoadCompleted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600039C RID: 924 RVA: 0x000125BC File Offset: 0x000107BC
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00002ECF File Offset: 0x000010CF
		public unsafe static Action<string> SceneUnloadCompleted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_SceneManager.NativeFieldInfoPtr_SceneUnloadCompleted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_SceneManager.NativeFieldInfoPtr_SceneUnloadCompleted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600039E RID: 926 RVA: 0x000125E4 File Offset: 0x000107E4
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00002EE1 File Offset: 0x000010E1
		public unsafe static List<Scene> s_additiveScenes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_SceneManager.NativeFieldInfoPtr_s_additiveScenes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Scene>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_SceneManager.NativeFieldInfoPtr_s_additiveScenes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x0001260C File Offset: 0x0001080C
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x00002EF3 File Offset: 0x000010F3
		public unsafe static Dictionary<string, List<Action<Scene>>> s_loadSceneRequests
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_SceneManager.NativeFieldInfoPtr_s_loadSceneRequests, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<Action<Scene>>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_SceneManager.NativeFieldInfoPtr_s_loadSceneRequests, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00012634 File Offset: 0x00010834
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x00002F05 File Offset: 0x00001105
		public unsafe static Dictionary<string, List<Action>> s_unloadSceneCallbacks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_SceneManager.NativeFieldInfoPtr_s_unloadSceneCallbacks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<Action>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_SceneManager.NativeFieldInfoPtr_s_unloadSceneCallbacks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeFieldInfoPtr_SceneLoadCompleted;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeFieldInfoPtr_SceneUnloadCompleted;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeFieldInfoPtr_s_additiveScenes;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeFieldInfoPtr_s_loadSceneRequests;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeFieldInfoPtr_s_unloadSceneCallbacks;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_add_SceneLoadCompleted_Public_Static_add_Void_Action_2_String_LoadSceneMode_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_remove_SceneLoadCompleted_Public_Static_rem_Void_Action_2_String_LoadSceneMode_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr_add_SceneUnloadCompleted_Public_Static_add_Void_Action_1_String_0;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr_remove_SceneUnloadCompleted_Public_Static_rem_Void_Action_1_String_0;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeMethodInfoPtr_LoadAdditively_Public_Static_Void_String_Action_1_Scene_0;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeMethodInfoPtr_Unload_Public_Static_Void_Scene_Action_0;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeMethodInfoPtr_UnloadLastScene_Public_Static_Void_Action_0;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr_Unload_Public_Static_Void_String_Action_0;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr_AdditiveSceneLoaded_Private_Static_Void_Scene_LoadSceneMode_0;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeMethodInfoPtr_SceneUnloadComplete_Private_Static_Void_Scene_0;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000063 RID: 99
		[ObfuscatedName("SA.Foundation.Async.SA_SceneManager+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060004A5 RID: 1189 RVA: 0x0001579C File Offset: 0x0001399C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SA_SceneManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_SceneManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_SceneManager.__c>.NativeClassPtr);
				SA_SceneManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_SceneManager.__c>.NativeClassPtr, "<>9");
				SA_SceneManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_SceneManager.__c>.NativeClassPtr, 100663950);
				SA_SceneManager.__c.NativeMethodInfoPtr___cctor_b__9_0_Internal_Void_String_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_SceneManager.__c>.NativeClassPtr, 100663951);
				SA_SceneManager.__c.NativeMethodInfoPtr___cctor_b__9_1_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_SceneManager.__c>.NativeClassPtr, 100663952);
			}

			// Token: 0x060004A6 RID: 1190 RVA: 0x00015818 File Offset: 0x00013A18
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_SceneManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_SceneManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004A7 RID: 1191 RVA: 0x00015854 File Offset: 0x00013A54
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__9_0(string <p0>, LoadSceneMode <p1>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref <p1>;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_SceneManager.__c.NativeMethodInfoPtr___cctor_b__9_0_Internal_Void_String_LoadSceneMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004A8 RID: 1192 RVA: 0x000158A4 File Offset: 0x00013AA4
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__9_1(string <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_SceneManager.__c.NativeMethodInfoPtr___cctor_b__9_1_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060004A9 RID: 1193 RVA: 0x00003614 File Offset: 0x00001814
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x060004AA RID: 1194 RVA: 0x000158E8 File Offset: 0x00013AE8
			// (set) Token: 0x060004AB RID: 1195 RVA: 0x0000361D File Offset: 0x0000181D
			public unsafe static SA_SceneManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SA_SceneManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_SceneManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SA_SceneManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000378 RID: 888
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000379 RID: 889
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400037A RID: 890
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__9_0_Internal_Void_String_LoadSceneMode_0;

			// Token: 0x0400037B RID: 891
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__9_1_Internal_Void_String_0;
		}
	}
}
