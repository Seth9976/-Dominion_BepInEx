using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.SceneManagement;

namespace UnityEngine
{
	// Token: 0x020000B4 RID: 180
	public sealed class GameObject : Object
	{
		// Token: 0x0600105B RID: 4187 RVA: 0x00042E2C File Offset: 0x0004102C
		// Note: this type is marked as 'beforefieldinit'.
		static GameObject()
		{
			Il2CppClassPointerStore<GameObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "GameObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameObject>.NativeClassPtr);
			GameObject.NativeMethodInfoPtr_GetComponent_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664370);
			GameObject.NativeMethodInfoPtr_GetComponent_Public_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664371);
			GameObject.NativeMethodInfoPtr_GetComponentFastPath_Internal_Void_Type_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664372);
			GameObject.NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664373);
			GameObject.NativeMethodInfoPtr_GetComponentInChildren_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664374);
			GameObject.NativeMethodInfoPtr_GetComponentInChildren_Public_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664375);
			GameObject.NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664376);
			GameObject.NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664377);
			GameObject.NativeMethodInfoPtr_GetComponentInParent_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664378);
			GameObject.NativeMethodInfoPtr_GetComponentInParent_Public_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664379);
			GameObject.NativeMethodInfoPtr_GetComponentsInternal_Private_Array_Type_Boolean_Boolean_Boolean_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664380);
			GameObject.NativeMethodInfoPtr_GetComponents_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664381);
			GameObject.NativeMethodInfoPtr_GetComponents_Public_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664382);
			GameObject.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664383);
			GameObject.NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664384);
			GameObject.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664385);
			GameObject.NativeMethodInfoPtr_GetComponentsInParent_Public_Void_Boolean_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664386);
			GameObject.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664387);
			GameObject.NativeMethodInfoPtr_SendMessage_Public_Void_String_SendMessageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664388);
			GameObject.NativeMethodInfoPtr_Internal_AddComponentWithType_Private_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664389);
			GameObject.NativeMethodInfoPtr_AddComponent_Public_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664390);
			GameObject.NativeMethodInfoPtr_AddComponent_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664391);
			GameObject.NativeMethodInfoPtr_get_transform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664392);
			GameObject.NativeMethodInfoPtr_get_layer_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664393);
			GameObject.NativeMethodInfoPtr_set_layer_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664394);
			GameObject.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664395);
			GameObject.NativeMethodInfoPtr_get_activeSelf_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664396);
			GameObject.NativeMethodInfoPtr_get_activeInHierarchy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664397);
			GameObject.NativeMethodInfoPtr_FindGameObjectWithTag_Public_Static_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664398);
			GameObject.NativeMethodInfoPtr_SendMessage_Public_Void_String_Object_SendMessageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664399);
			GameObject.NativeMethodInfoPtr_SendMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664400);
			GameObject.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664401);
			GameObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664402);
			GameObject.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664403);
			GameObject.NativeMethodInfoPtr_Internal_CreateGameObject_Private_Static_Void_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664404);
			GameObject.NativeMethodInfoPtr_Find_Public_Static_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664405);
			GameObject.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100664406);
			GameObject.CreatePrimitiveDelegateField = IL2CPP.ResolveICall<GameObject.CreatePrimitiveDelegate>("UnityEngine.GameObject::CreatePrimitive");
			GameObject.GetComponentByNameDelegateField = IL2CPP.ResolveICall<GameObject.GetComponentByNameDelegate>("UnityEngine.GameObject::GetComponentByName");
			GameObject.TryGetComponentInternalDelegateField = IL2CPP.ResolveICall<GameObject.TryGetComponentInternalDelegate>("UnityEngine.GameObject::TryGetComponentInternal");
			GameObject.TryGetComponentFastPathDelegateField = IL2CPP.ResolveICall<GameObject.TryGetComponentFastPathDelegate>("UnityEngine.GameObject::TryGetComponentFastPath");
			GameObject.AddComponentInternalDelegateField = IL2CPP.ResolveICall<GameObject.AddComponentInternalDelegate>("UnityEngine.GameObject::AddComponentInternal");
			GameObject.get_activeDelegateField = IL2CPP.ResolveICall<GameObject.get_activeDelegate>("UnityEngine.GameObject::get_active");
			GameObject.set_activeDelegateField = IL2CPP.ResolveICall<GameObject.set_activeDelegate>("UnityEngine.GameObject::set_active");
			GameObject.SetActiveRecursivelyDelegateField = IL2CPP.ResolveICall<GameObject.SetActiveRecursivelyDelegate>("UnityEngine.GameObject::SetActiveRecursively");
			GameObject.get_isStaticDelegateField = IL2CPP.ResolveICall<GameObject.get_isStaticDelegate>("UnityEngine.GameObject::get_isStatic");
			GameObject.set_isStaticDelegateField = IL2CPP.ResolveICall<GameObject.set_isStaticDelegate>("UnityEngine.GameObject::set_isStatic");
			GameObject.get_isStaticBatchableDelegateField = IL2CPP.ResolveICall<GameObject.get_isStaticBatchableDelegate>("UnityEngine.GameObject::get_isStaticBatchable");
			GameObject.get_tagDelegateField = IL2CPP.ResolveICall<GameObject.get_tagDelegate>("UnityEngine.GameObject::get_tag");
			GameObject.set_tagDelegateField = IL2CPP.ResolveICall<GameObject.set_tagDelegate>("UnityEngine.GameObject::set_tag");
			GameObject.CompareTagDelegateField = IL2CPP.ResolveICall<GameObject.CompareTagDelegate>("UnityEngine.GameObject::CompareTag");
			GameObject.FindGameObjectsWithTagDelegateField = IL2CPP.ResolveICall<GameObject.FindGameObjectsWithTagDelegate>("UnityEngine.GameObject::FindGameObjectsWithTag");
			GameObject.SendMessageUpwardsDelegateField = IL2CPP.ResolveICall<GameObject.SendMessageUpwardsDelegate>("UnityEngine.GameObject::SendMessageUpwards");
			GameObject.BroadcastMessageDelegateField = IL2CPP.ResolveICall<GameObject.BroadcastMessageDelegate>("UnityEngine.GameObject::BroadcastMessage");
			GameObject.get_sceneCullingMaskDelegateField = IL2CPP.ResolveICall<GameObject.get_sceneCullingMaskDelegate>("UnityEngine.GameObject::get_sceneCullingMask");
			GameObject.get_scene_InjectedDelegateField = IL2CPP.ResolveICall<GameObject.get_scene_InjectedDelegate>("UnityEngine.GameObject::get_scene_Injected");
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00043260 File Offset: 0x00041460
		[CallerCount(445)]
		[CachedScanResults(RefRangeStart = 69916, RefRangeEnd = 70361, XrefRangeStart = 69911, XrefRangeEnd = 69916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponent<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponent_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x0004329C File Offset: 0x0004149C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70361, XrefRangeEnd = 70363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component GetComponent(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponent_Public_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
			}
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x000432EC File Offset: 0x000414EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70365, RefRangeEnd = 70366, XrefRangeStart = 70363, XrefRangeEnd = 70365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oneFurtherThanResultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponentFastPath_Internal_Void_Type_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x0004333C File Offset: 0x0004153C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70368, RefRangeEnd = 70369, XrefRangeStart = 70366, XrefRangeEnd = 70368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component GetComponentInChildren(Type type, bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x0004339C File Offset: 0x0004159C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 69818, RefRangeEnd = 69839, XrefRangeStart = 69818, XrefRangeEnd = 69839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponentInChildren<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentInChildren_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x000433D8 File Offset: 0x000415D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70369, XrefRangeEnd = 70375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponentInChildren<T>(bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeInactive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentInChildren_Public_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00043420 File Offset: 0x00041620
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70377, RefRangeEnd = 70378, XrefRangeStart = 70375, XrefRangeEnd = 70377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component GetComponentInParent(Type type, bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00043480 File Offset: 0x00041680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70378, XrefRangeEnd = 70380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component GetComponentInParent(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
			}
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x000434D0 File Offset: 0x000416D0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 69818, RefRangeEnd = 69839, XrefRangeStart = 69818, XrefRangeEnd = 69839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponentInParent<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentInParent_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x0004350C File Offset: 0x0004170C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70380, XrefRangeEnd = 70386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponentInParent<T>(bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeInactive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentInParent_Public_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x00043554 File Offset: 0x00041754
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 70388, RefRangeEnd = 70395, XrefRangeStart = 70386, XrefRangeEnd = 70388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, Object resultList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useSearchTypeAsArrayReturnType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recursive;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reverse;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponentsInternal_Private_Array_Type_Boolean_Boolean_Boolean_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x000435F0 File Offset: 0x000417F0
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 70402, RefRangeEnd = 70430, XrefRangeStart = 70395, XrefRangeEnd = 70402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponents<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponents_Public_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x00043628 File Offset: 0x00041828
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70435, RefRangeEnd = 70436, XrefRangeStart = 70430, XrefRangeEnd = 70435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponents<T>(List<T> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(results);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponents_Public_Void_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x0004366C File Offset: 0x0004186C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 70443, RefRangeEnd = 70446, XrefRangeStart = 70436, XrefRangeEnd = 70443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponentsInChildren<T>(bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeInactive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x000436B0 File Offset: 0x000418B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70446, XrefRangeEnd = 70451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponentsInChildren<T>(bool includeInactive, List<T> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeInactive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x00043700 File Offset: 0x00041900
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 69818, RefRangeEnd = 69839, XrefRangeStart = 69818, XrefRangeEnd = 69839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponentsInChildren<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x00043738 File Offset: 0x00041938
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 70456, RefRangeEnd = 70464, XrefRangeStart = 70451, XrefRangeEnd = 70456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponentsInParent<T>(bool includeInactive, List<T> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeInactive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentsInParent_Public_Void_Boolean_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x00043788 File Offset: 0x00041988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70464, XrefRangeEnd = 70471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponentsInParent<T>(bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeInactive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x000437CC File Offset: 0x000419CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70473, RefRangeEnd = 70474, XrefRangeStart = 70471, XrefRangeEnd = 70473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessage(string methodName, SendMessageOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_SendMessage_Public_Void_String_SendMessageOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x0004381C File Offset: 0x00041A1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70476, RefRangeEnd = 70477, XrefRangeStart = 70474, XrefRangeEnd = 70476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component Internal_AddComponentWithType(Type componentType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(componentType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_Internal_AddComponentWithType_Private_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
			}
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x0004386C File Offset: 0x00041A6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70476, RefRangeEnd = 70477, XrefRangeStart = 70476, XrefRangeEnd = 70477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component AddComponent(Type componentType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(componentType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_AddComponent_Public_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
			}
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x000438BC File Offset: 0x00041ABC
		[CallerCount(149)]
		[CachedScanResults(RefRangeStart = 70485, RefRangeEnd = 70634, XrefRangeStart = 70477, XrefRangeEnd = 70485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T AddComponent<T>() where T : Component
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_AddComponent_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06001072 RID: 4210 RVA: 0x000438F8 File Offset: 0x00041AF8
		public unsafe Transform transform
		{
			[CallerCount(382)]
			[CachedScanResults(RefRangeStart = 70636, RefRangeEnd = 71018, XrefRangeStart = 70634, XrefRangeEnd = 70636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_transform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x00043938 File Offset: 0x00041B38
		// (set) Token: 0x06001074 RID: 4212 RVA: 0x00043974 File Offset: 0x00041B74
		public unsafe int layer
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 71020, RefRangeEnd = 71026, XrefRangeStart = 71018, XrefRangeEnd = 71020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_layer_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 71028, RefRangeEnd = 71035, XrefRangeStart = 71026, XrefRangeEnd = 71028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_set_layer_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x000439B4 File Offset: 0x00041BB4
		[CallerCount(685)]
		[CachedScanResults(RefRangeStart = 71037, RefRangeEnd = 71722, XrefRangeStart = 71035, XrefRangeEnd = 71037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActive(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x000439F4 File Offset: 0x00041BF4
		public unsafe bool activeSelf
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 71724, RefRangeEnd = 71769, XrefRangeStart = 71722, XrefRangeEnd = 71724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_activeSelf_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001077 RID: 4215 RVA: 0x00043A30 File Offset: 0x00041C30
		public unsafe bool activeInHierarchy
		{
			[CallerCount(49)]
			[CachedScanResults(RefRangeStart = 71771, RefRangeEnd = 71820, XrefRangeStart = 71769, XrefRangeEnd = 71771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_activeInHierarchy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x00043A6C File Offset: 0x00041C6C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 71822, RefRangeEnd = 71838, XrefRangeStart = 71820, XrefRangeEnd = 71822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject FindGameObjectWithTag(string tag)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_FindGameObjectWithTag_Public_Static_GameObject_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x00043AB0 File Offset: 0x00041CB0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 71840, RefRangeEnd = 71847, XrefRangeStart = 71838, XrefRangeEnd = 71840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessage(string methodName, Object value, SendMessageOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_SendMessage_Public_Void_String_Object_SendMessageOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x00043B14 File Offset: 0x00041D14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 71849, RefRangeEnd = 71852, XrefRangeStart = 71847, XrefRangeEnd = 71849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessage(string methodName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_SendMessage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x00043B58 File Offset: 0x00041D58
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 71858, RefRangeEnd = 71919, XrefRangeStart = 71852, XrefRangeEnd = 71858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameObject>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x00043BA4 File Offset: 0x00041DA4
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 71925, RefRangeEnd = 71945, XrefRangeStart = 71919, XrefRangeEnd = 71925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x00043BE0 File Offset: 0x00041DE0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 71954, RefRangeEnd = 71965, XrefRangeStart = 71945, XrefRangeEnd = 71954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject(string name, [Optional] Il2CppReferenceArray<Type> components)
		{
			if (components == null)
			{
				components = new Il2CppReferenceArray<Type>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameObject>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(components);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x00043C4C File Offset: 0x00041E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71965, XrefRangeEnd = 71967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_CreateGameObject(GameObject self, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_Internal_CreateGameObject_Private_Static_Void_GameObject_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x00043C94 File Offset: 0x00041E94
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 71969, RefRangeEnd = 71983, XrefRangeStart = 71967, XrefRangeEnd = 71969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject Find(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_Find_Public_Static_GameObject_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001080 RID: 4224 RVA: 0x00043CD8 File Offset: 0x00041ED8
		public unsafe GameObject gameObject
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 71983, RefRangeEnd = 72005, XrefRangeStart = 71983, XrefRangeEnd = 71983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x0000A272 File Offset: 0x00008472
		public GameObject(string name, params Type[] components)
			: this(name, new Il2CppReferenceArray<Type>(components))
		{
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x0000A281 File Offset: 0x00008481
		public GameObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00043D18 File Offset: 0x00041F18
		public static GameObject CreatePrimitive(PrimitiveType type)
		{
			IntPtr intPtr = GameObject.CreatePrimitiveDelegateField(type);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x00043D40 File Offset: 0x00041F40
		public Component GetComponentByName(string type)
		{
			IntPtr intPtr = GameObject.GetComponentByNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00043D74 File Offset: 0x00041F74
		public Component GetComponent(string type)
		{
			return this.GetComponentByName(type);
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x00043D90 File Offset: 0x00041F90
		public Component GetComponentInChildren(Type type)
		{
			return this.GetComponentInChildren(type, false);
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x00043DAC File Offset: 0x00041FAC
		public Il2CppReferenceArray<Component> GetComponents(Type type)
		{
			return this.GetComponentsInternal(type, false, false, true, false, null).Cast<Il2CppReferenceArray<Component>>();
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x0000A28A File Offset: 0x0000848A
		public void GetComponents(Type type, List<Component> results)
		{
			this.GetComponentsInternal(type, false, false, true, false, results);
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x00043DD0 File Offset: 0x00041FD0
		public Il2CppReferenceArray<Component> GetComponentsInChildren(Type type)
		{
			bool flag = false;
			return this.GetComponentsInChildren(type, flag);
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00043DEC File Offset: 0x00041FEC
		public Il2CppReferenceArray<Component> GetComponentsInChildren(Type type, bool includeInactive)
		{
			return this.GetComponentsInternal(type, false, true, includeInactive, false, null).Cast<Il2CppReferenceArray<Component>>();
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x0000A29A File Offset: 0x0000849A
		public void GetComponentsInChildren<T>(List<T> results)
		{
			this.GetComponentsInChildren<T>(false, results);
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x00043E10 File Offset: 0x00042010
		public Il2CppReferenceArray<Component> GetComponentsInParent(Type type)
		{
			bool flag = false;
			return this.GetComponentsInParent(type, flag);
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x00043E2C File Offset: 0x0004202C
		public Il2CppReferenceArray<Component> GetComponentsInParent(Type type, bool includeInactive)
		{
			return this.GetComponentsInternal(type, false, true, includeInactive, true, null).Cast<Il2CppReferenceArray<Component>>();
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x00043E50 File Offset: 0x00042050
		public Il2CppArrayBase<T> GetComponentsInParent<T>()
		{
			return this.GetComponentsInParent<T>(false);
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x0000A2A6 File Offset: 0x000084A6
		public bool TryGetComponent<T>(out T component)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x00043E6C File Offset: 0x0004206C
		public bool TryGetComponent(Type type, out Component component)
		{
			component = this.TryGetComponentInternal(type);
			return component != null;
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00043E90 File Offset: 0x00042090
		public Component TryGetComponentInternal(Type type)
		{
			IntPtr intPtr = GameObject.TryGetComponentInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x0000A2B3 File Offset: 0x000084B3
		public void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue)
		{
			GameObject.TryGetComponentFastPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(type), oneFurtherThanResultValue);
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x00043EC4 File Offset: 0x000420C4
		public static GameObject FindWithTag(string tag)
		{
			return GameObject.FindGameObjectWithTag(tag);
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x0000A2CC File Offset: 0x000084CC
		public void SendMessageUpwards(string methodName, SendMessageOptions options)
		{
			this.SendMessageUpwards(methodName, null, options);
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x0000A2D9 File Offset: 0x000084D9
		public void BroadcastMessage(string methodName, SendMessageOptions options)
		{
			this.BroadcastMessage(methodName, null, options);
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x00043EDC File Offset: 0x000420DC
		public Component AddComponentInternal(string className)
		{
			IntPtr intPtr = GameObject.AddComponentInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(className));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x0000A2E6 File Offset: 0x000084E6
		// (set) Token: 0x06001098 RID: 4248 RVA: 0x0000A2F8 File Offset: 0x000084F8
		public bool active
		{
			get
			{
				return GameObject.get_activeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				GameObject.set_activeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x0000A30B File Offset: 0x0000850B
		public void SetActiveRecursively(bool state)
		{
			GameObject.SetActiveRecursivelyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), state);
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x0000A31E File Offset: 0x0000851E
		// (set) Token: 0x0600109B RID: 4251 RVA: 0x0000A330 File Offset: 0x00008530
		public bool isStatic
		{
			get
			{
				return GameObject.get_isStaticDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				GameObject.set_isStaticDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x0000A343 File Offset: 0x00008543
		public bool isStaticBatchable
		{
			get
			{
				return GameObject.get_isStaticBatchableDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x00043F10 File Offset: 0x00042110
		// (set) Token: 0x0600109E RID: 4254 RVA: 0x0000A355 File Offset: 0x00008555
		public string tag
		{
			get
			{
				IntPtr intPtr = GameObject.get_tagDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				GameObject.set_tagDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x0000A36D File Offset: 0x0000856D
		public bool CompareTag(string tag)
		{
			return GameObject.CompareTagDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(tag));
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x00043F34 File Offset: 0x00042134
		public static Il2CppReferenceArray<GameObject> FindGameObjectsWithTag(string tag)
		{
			IntPtr intPtr = GameObject.FindGameObjectsWithTagDelegateField(IL2CPP.ManagedStringToIl2Cpp(tag));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x0000A385 File Offset: 0x00008585
		public void SendMessageUpwards(string methodName, Object value, SendMessageOptions options)
		{
			GameObject.SendMessageUpwardsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(methodName), IL2CPP.Il2CppObjectBaseToPtr(value), options);
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x00043F60 File Offset: 0x00042160
		public void SendMessageUpwards(string methodName, Object value)
		{
			SendMessageOptions sendMessageOptions = SendMessageOptions.RequireReceiver;
			this.SendMessageUpwards(methodName, value, sendMessageOptions);
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x00043F7C File Offset: 0x0004217C
		public void SendMessageUpwards(string methodName)
		{
			SendMessageOptions sendMessageOptions = SendMessageOptions.RequireReceiver;
			Object @object = null;
			this.SendMessageUpwards(methodName, @object, sendMessageOptions);
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x00043F98 File Offset: 0x00042198
		public void SendMessage(string methodName, Object value)
		{
			SendMessageOptions sendMessageOptions = SendMessageOptions.RequireReceiver;
			this.SendMessage(methodName, value, sendMessageOptions);
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x0000A3A4 File Offset: 0x000085A4
		public void BroadcastMessage(string methodName, Object parameter, SendMessageOptions options)
		{
			GameObject.BroadcastMessageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(methodName), IL2CPP.Il2CppObjectBaseToPtr(parameter), options);
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x00043FB4 File Offset: 0x000421B4
		public void BroadcastMessage(string methodName, Object parameter)
		{
			SendMessageOptions sendMessageOptions = SendMessageOptions.RequireReceiver;
			this.BroadcastMessage(methodName, parameter, sendMessageOptions);
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x00043FD0 File Offset: 0x000421D0
		public void BroadcastMessage(string methodName)
		{
			SendMessageOptions sendMessageOptions = SendMessageOptions.RequireReceiver;
			Object @object = null;
			this.BroadcastMessage(methodName, @object, sendMessageOptions);
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x060010A8 RID: 4264 RVA: 0x00043FEC File Offset: 0x000421EC
		public UnityEngine.SceneManagement.Scene scene
		{
			get
			{
				UnityEngine.SceneManagement.Scene scene;
				this.get_scene_Injected(out scene);
				return scene;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x060010A9 RID: 4265 RVA: 0x0000A3C3 File Offset: 0x000085C3
		public ulong sceneCullingMask
		{
			get
			{
				return GameObject.get_sceneCullingMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x0000A3D5 File Offset: 0x000085D5
		public void get_scene_Injected(out UnityEngine.SceneManagement.Scene ret)
		{
			GameObject.get_scene_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x04000C53 RID: 3155
		private static readonly IntPtr NativeMethodInfoPtr_GetComponent_Public_T_0;

		// Token: 0x04000C54 RID: 3156
		private static readonly IntPtr NativeMethodInfoPtr_GetComponent_Public_Component_Type_0;

		// Token: 0x04000C55 RID: 3157
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentFastPath_Internal_Void_Type_IntPtr_0;

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_Boolean_0;

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_T_0;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_T_Boolean_0;

		// Token: 0x04000C59 RID: 3161
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_Boolean_0;

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_0;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInParent_Public_T_0;

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInParent_Public_T_Boolean_0;

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInternal_Private_Array_Type_Boolean_Boolean_Boolean_Boolean_Object_0;

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeMethodInfoPtr_GetComponents_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeMethodInfoPtr_GetComponents_Public_Void_List_1_T_0;

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0;

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0;

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInParent_Public_Void_Boolean_List_1_T_0;

		// Token: 0x04000C64 RID: 3172
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0;

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Void_String_SendMessageOptions_0;

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeMethodInfoPtr_Internal_AddComponentWithType_Private_Component_Type_0;

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeMethodInfoPtr_AddComponent_Public_Component_Type_0;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeMethodInfoPtr_AddComponent_Public_T_0;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeMethodInfoPtr_get_transform_Public_get_Transform_0;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeMethodInfoPtr_get_layer_Public_get_Int32_0;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeMethodInfoPtr_set_layer_Public_set_Void_Int32_0;

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeMethodInfoPtr_get_activeSelf_Public_get_Boolean_0;

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeMethodInfoPtr_get_activeInHierarchy_Public_get_Boolean_0;

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeMethodInfoPtr_FindGameObjectWithTag_Public_Static_GameObject_String_0;

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Void_String_Object_SendMessageOptions_0;

		// Token: 0x04000C71 RID: 3185
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Void_String_0;

		// Token: 0x04000C72 RID: 3186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreateGameObject_Private_Static_Void_GameObject_String_0;

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_GameObject_String_0;

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0;

		// Token: 0x04000C78 RID: 3192
		private static readonly GameObject.CreatePrimitiveDelegate CreatePrimitiveDelegateField;

		// Token: 0x04000C79 RID: 3193
		private static readonly GameObject.GetComponentByNameDelegate GetComponentByNameDelegateField;

		// Token: 0x04000C7A RID: 3194
		private static readonly GameObject.TryGetComponentInternalDelegate TryGetComponentInternalDelegateField;

		// Token: 0x04000C7B RID: 3195
		private static readonly GameObject.TryGetComponentFastPathDelegate TryGetComponentFastPathDelegateField;

		// Token: 0x04000C7C RID: 3196
		private static readonly GameObject.AddComponentInternalDelegate AddComponentInternalDelegateField;

		// Token: 0x04000C7D RID: 3197
		private static readonly GameObject.get_activeDelegate get_activeDelegateField;

		// Token: 0x04000C7E RID: 3198
		private static readonly GameObject.set_activeDelegate set_activeDelegateField;

		// Token: 0x04000C7F RID: 3199
		private static readonly GameObject.SetActiveRecursivelyDelegate SetActiveRecursivelyDelegateField;

		// Token: 0x04000C80 RID: 3200
		private static readonly GameObject.get_isStaticDelegate get_isStaticDelegateField;

		// Token: 0x04000C81 RID: 3201
		private static readonly GameObject.set_isStaticDelegate set_isStaticDelegateField;

		// Token: 0x04000C82 RID: 3202
		private static readonly GameObject.get_isStaticBatchableDelegate get_isStaticBatchableDelegateField;

		// Token: 0x04000C83 RID: 3203
		private static readonly GameObject.get_tagDelegate get_tagDelegateField;

		// Token: 0x04000C84 RID: 3204
		private static readonly GameObject.set_tagDelegate set_tagDelegateField;

		// Token: 0x04000C85 RID: 3205
		private static readonly GameObject.CompareTagDelegate CompareTagDelegateField;

		// Token: 0x04000C86 RID: 3206
		private static readonly GameObject.FindGameObjectsWithTagDelegate FindGameObjectsWithTagDelegateField;

		// Token: 0x04000C87 RID: 3207
		private static readonly GameObject.SendMessageUpwardsDelegate SendMessageUpwardsDelegateField;

		// Token: 0x04000C88 RID: 3208
		private static readonly GameObject.BroadcastMessageDelegate BroadcastMessageDelegateField;

		// Token: 0x04000C89 RID: 3209
		private static readonly GameObject.get_sceneCullingMaskDelegate get_sceneCullingMaskDelegateField;

		// Token: 0x04000C8A RID: 3210
		private static readonly GameObject.get_scene_InjectedDelegate get_scene_InjectedDelegateField;

		// Token: 0x0200077E RID: 1918
		private sealed class MethodInfoStoreGeneric_GetComponent_Public_T_0<T>
		{
			// Token: 0x04001C8D RID: 7309
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponent_Public_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200077F RID: 1919
		private sealed class MethodInfoStoreGeneric_GetComponentInChildren_Public_T_0<T>
		{
			// Token: 0x04001C8E RID: 7310
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentInChildren_Public_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000780 RID: 1920
		private sealed class MethodInfoStoreGeneric_GetComponentInChildren_Public_T_Boolean_0<T>
		{
			// Token: 0x04001C8F RID: 7311
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentInChildren_Public_T_Boolean_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000781 RID: 1921
		private sealed class MethodInfoStoreGeneric_GetComponentInParent_Public_T_0<T>
		{
			// Token: 0x04001C90 RID: 7312
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentInParent_Public_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000782 RID: 1922
		private sealed class MethodInfoStoreGeneric_GetComponentInParent_Public_T_Boolean_0<T>
		{
			// Token: 0x04001C91 RID: 7313
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentInParent_Public_T_Boolean_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000783 RID: 1923
		private sealed class MethodInfoStoreGeneric_GetComponents_Public_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04001C92 RID: 7314
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponents_Public_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000784 RID: 1924
		private sealed class MethodInfoStoreGeneric_GetComponents_Public_Void_List_1_T_0<T>
		{
			// Token: 0x04001C93 RID: 7315
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponents_Public_Void_List_1_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000785 RID: 1925
		private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0<T>
		{
			// Token: 0x04001C94 RID: 7316
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000786 RID: 1926
		private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0<T>
		{
			// Token: 0x04001C95 RID: 7317
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000787 RID: 1927
		private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04001C96 RID: 7318
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000788 RID: 1928
		private sealed class MethodInfoStoreGeneric_GetComponentsInParent_Public_Void_Boolean_List_1_T_0<T>
		{
			// Token: 0x04001C97 RID: 7319
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentsInParent_Public_Void_Boolean_List_1_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000789 RID: 1929
		private sealed class MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0<T>
		{
			// Token: 0x04001C98 RID: 7320
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200078A RID: 1930
		private sealed class MethodInfoStoreGeneric_AddComponent_Public_T_0<T>
		{
			// Token: 0x04001C99 RID: 7321
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_AddComponent_Public_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200078B RID: 1931
		// (Invoke) Token: 0x06002CBA RID: 11450
		private delegate IntPtr CreatePrimitiveDelegate(PrimitiveType type);

		// Token: 0x0200078C RID: 1932
		// (Invoke) Token: 0x06002CBC RID: 11452
		private delegate IntPtr GetComponentByNameDelegate(IntPtr @this, IntPtr type);

		// Token: 0x0200078D RID: 1933
		// (Invoke) Token: 0x06002CBE RID: 11454
		private delegate IntPtr TryGetComponentInternalDelegate(IntPtr @this, IntPtr type);

		// Token: 0x0200078E RID: 1934
		// (Invoke) Token: 0x06002CC0 RID: 11456
		private delegate void TryGetComponentFastPathDelegate(IntPtr @this, IntPtr type, IntPtr oneFurtherThanResultValue);

		// Token: 0x0200078F RID: 1935
		// (Invoke) Token: 0x06002CC2 RID: 11458
		private delegate IntPtr AddComponentInternalDelegate(IntPtr @this, IntPtr className);

		// Token: 0x02000790 RID: 1936
		// (Invoke) Token: 0x06002CC4 RID: 11460
		private delegate bool get_activeDelegate(IntPtr @this);

		// Token: 0x02000791 RID: 1937
		// (Invoke) Token: 0x06002CC6 RID: 11462
		private delegate void set_activeDelegate(IntPtr @this, bool value);

		// Token: 0x02000792 RID: 1938
		// (Invoke) Token: 0x06002CC8 RID: 11464
		private delegate void SetActiveRecursivelyDelegate(IntPtr @this, bool state);

		// Token: 0x02000793 RID: 1939
		// (Invoke) Token: 0x06002CCA RID: 11466
		private delegate bool get_isStaticDelegate(IntPtr @this);

		// Token: 0x02000794 RID: 1940
		// (Invoke) Token: 0x06002CCC RID: 11468
		private delegate void set_isStaticDelegate(IntPtr @this, bool value);

		// Token: 0x02000795 RID: 1941
		// (Invoke) Token: 0x06002CCE RID: 11470
		private delegate bool get_isStaticBatchableDelegate(IntPtr @this);

		// Token: 0x02000796 RID: 1942
		// (Invoke) Token: 0x06002CD0 RID: 11472
		private delegate IntPtr get_tagDelegate(IntPtr @this);

		// Token: 0x02000797 RID: 1943
		// (Invoke) Token: 0x06002CD2 RID: 11474
		private delegate void set_tagDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000798 RID: 1944
		// (Invoke) Token: 0x06002CD4 RID: 11476
		private delegate bool CompareTagDelegate(IntPtr @this, IntPtr tag);

		// Token: 0x02000799 RID: 1945
		// (Invoke) Token: 0x06002CD6 RID: 11478
		private delegate IntPtr FindGameObjectsWithTagDelegate(IntPtr tag);

		// Token: 0x0200079A RID: 1946
		// (Invoke) Token: 0x06002CD8 RID: 11480
		private delegate void SendMessageUpwardsDelegate(IntPtr @this, IntPtr methodName, IntPtr value, SendMessageOptions options);

		// Token: 0x0200079B RID: 1947
		// (Invoke) Token: 0x06002CDA RID: 11482
		private delegate void BroadcastMessageDelegate(IntPtr @this, IntPtr methodName, IntPtr parameter, SendMessageOptions options);

		// Token: 0x0200079C RID: 1948
		// (Invoke) Token: 0x06002CDC RID: 11484
		private delegate ulong get_sceneCullingMaskDelegate(IntPtr @this);

		// Token: 0x0200079D RID: 1949
		// (Invoke) Token: 0x06002CDE RID: 11486
		private delegate void get_scene_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
