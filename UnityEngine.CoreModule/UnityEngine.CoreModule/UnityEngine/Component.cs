using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x020000AD RID: 173
	public class Component : Object
	{
		// Token: 0x06001010 RID: 4112 RVA: 0x00042030 File Offset: 0x00040230
		// Note: this type is marked as 'beforefieldinit'.
		static Component()
		{
			Il2CppClassPointerStore<Component>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Component");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Component>.NativeClassPtr);
			Component.NativeMethodInfoPtr_get_transform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100664337);
			Component.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100664338);
			Component.NativeMethodInfoPtr_GetComponent_Public_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100664339);
			Component.NativeMethodInfoPtr_GetComponentFastPath_Internal_Void_Type_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100664340);
			Component.NativeMethodInfoPtr_GetComponent_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100664341);
			Component.NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100664342);
			Component.NativeMethodInfoPtr_GetComponentInChildren_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100664343);
			Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100664344);
			Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100664345);
			Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100664346);
			Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100664347);
			Component.NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100664348);
			Component.NativeMethodInfoPtr_GetComponentInParent_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100664349);
			Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100664350);
			Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Void_Boolean_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100664351);
			Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100664352);
			Component.NativeMethodInfoPtr_GetComponentsForListInternal_Private_Void_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100664353);
			Component.NativeMethodInfoPtr_GetComponents_Public_Void_Type_List_1_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100664354);
			Component.NativeMethodInfoPtr_GetComponents_Public_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100664355);
			Component.NativeMethodInfoPtr_GetComponents_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100664356);
			Component.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100664357);
			Component.GetComponentDelegateField = IL2CPP.ResolveICall<Component.GetComponentDelegate>("UnityEngine.Component::GetComponent");
			Component.SendMessageUpwardsDelegateField = IL2CPP.ResolveICall<Component.SendMessageUpwardsDelegate>("UnityEngine.Component::SendMessageUpwards");
			Component.SendMessageDelegateField = IL2CPP.ResolveICall<Component.SendMessageDelegate>("UnityEngine.Component::SendMessage");
			Component.BroadcastMessageDelegateField = IL2CPP.ResolveICall<Component.BroadcastMessageDelegate>("UnityEngine.Component::BroadcastMessage");
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06001011 RID: 4113 RVA: 0x00042240 File Offset: 0x00040440
		public unsafe Transform transform
		{
			[CallerCount(446)]
			[CachedScanResults(RefRangeStart = 68434, RefRangeEnd = 68880, XrefRangeStart = 68432, XrefRangeEnd = 68434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_get_transform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x00042280 File Offset: 0x00040480
		public unsafe GameObject gameObject
		{
			[CallerCount(560)]
			[CachedScanResults(RefRangeStart = 68882, RefRangeEnd = 69442, XrefRangeStart = 68880, XrefRangeEnd = 68882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x000422C0 File Offset: 0x000404C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 69447, RefRangeEnd = 69450, XrefRangeStart = 69442, XrefRangeEnd = 69447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component GetComponent(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponent_Public_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
			}
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x00042310 File Offset: 0x00040510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69452, RefRangeEnd = 69453, XrefRangeStart = 69450, XrefRangeEnd = 69452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponentFastPath_Internal_Void_Type_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x00042360 File Offset: 0x00040560
		[CallerCount(331)]
		[CachedScanResults(RefRangeStart = 69458, RefRangeEnd = 69789, XrefRangeStart = 69453, XrefRangeEnd = 69458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponent<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponent_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x0004239C File Offset: 0x0004059C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69794, RefRangeEnd = 69795, XrefRangeStart = 69789, XrefRangeEnd = 69794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component GetComponentInChildren(Type t, bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x000423FC File Offset: 0x000405FC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 69801, RefRangeEnd = 69807, XrefRangeStart = 69795, XrefRangeEnd = 69801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponentInChildren<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentInChildren_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00042438 File Offset: 0x00040638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69809, RefRangeEnd = 69810, XrefRangeStart = 69807, XrefRangeEnd = 69809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponentsInChildren<T>(bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeInactive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x0004247C File Offset: 0x0004067C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 69812, RefRangeEnd = 69817, XrefRangeStart = 69810, XrefRangeEnd = 69812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponentsInChildren<T>(bool includeInactive, List<T> result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeInactive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x000424CC File Offset: 0x000406CC
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 69818, RefRangeEnd = 69839, XrefRangeStart = 69817, XrefRangeEnd = 69818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponentsInChildren<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x00042504 File Offset: 0x00040704
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 69840, RefRangeEnd = 69842, XrefRangeStart = 69839, XrefRangeEnd = 69840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponentsInChildren<T>(List<T> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(results);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00042548 File Offset: 0x00040748
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69847, RefRangeEnd = 69848, XrefRangeStart = 69842, XrefRangeEnd = 69847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component GetComponentInParent(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
			}
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x00042598 File Offset: 0x00040798
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 69854, RefRangeEnd = 69863, XrefRangeStart = 69848, XrefRangeEnd = 69854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponentInParent<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentInParent_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x000425D4 File Offset: 0x000407D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69809, RefRangeEnd = 69810, XrefRangeStart = 69809, XrefRangeEnd = 69810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponentsInParent<T>(bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeInactive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x00042618 File Offset: 0x00040818
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 69812, RefRangeEnd = 69817, XrefRangeStart = 69812, XrefRangeEnd = 69817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInParent_Public_Void_Boolean_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00042668 File Offset: 0x00040868
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 69818, RefRangeEnd = 69839, XrefRangeStart = 69818, XrefRangeEnd = 69839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponentsInParent<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x000426A0 File Offset: 0x000408A0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 69865, RefRangeEnd = 69875, XrefRangeStart = 69863, XrefRangeEnd = 69865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponentsForListInternal(Type searchType, Object resultList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(searchType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponentsForListInternal_Private_Void_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x000426F4 File Offset: 0x000408F4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 69865, RefRangeEnd = 69875, XrefRangeStart = 69865, XrefRangeEnd = 69875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponents(Type type, List<Component> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponents_Public_Void_Type_List_1_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00042748 File Offset: 0x00040948
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 69881, RefRangeEnd = 69887, XrefRangeStart = 69875, XrefRangeEnd = 69881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponents<T>(List<T> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(results);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponents_Public_Void_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x0004278C File Offset: 0x0004098C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 69889, RefRangeEnd = 69893, XrefRangeStart = 69887, XrefRangeEnd = 69889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponents<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponents_Public_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x000427C4 File Offset: 0x000409C4
		[CallerCount(279)]
		[CachedScanResults(RefRangeStart = 59667, RefRangeEnd = 59946, XrefRangeStart = 59667, XrefRangeEnd = 59946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Component>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x0000A092 File Offset: 0x00008292
		public Component(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x00042800 File Offset: 0x00040A00
		public bool TryGetComponent(Type type, out Component component)
		{
			return this.gameObject.TryGetComponent(type, out component);
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x00042820 File Offset: 0x00040A20
		public bool TryGetComponent<T>(out T component)
		{
			return this.gameObject.TryGetComponent<T>(out component);
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x00042840 File Offset: 0x00040A40
		public Component GetComponent(string type)
		{
			IntPtr intPtr = Component.GetComponentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x00042874 File Offset: 0x00040A74
		public Component GetComponentInChildren(Type t)
		{
			return this.GetComponentInChildren(t, false);
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x00042890 File Offset: 0x00040A90
		public T GetComponentInChildren<T>(bool includeInactive)
		{
			return this.GetComponentInChildren(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), includeInactive).Cast<T>();
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x000428B8 File Offset: 0x00040AB8
		public Il2CppReferenceArray<Component> GetComponentsInChildren(Type t, bool includeInactive)
		{
			return this.gameObject.GetComponentsInChildren(t, includeInactive);
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x000428D8 File Offset: 0x00040AD8
		public Il2CppReferenceArray<Component> GetComponentsInChildren(Type t)
		{
			return this.gameObject.GetComponentsInChildren(t, false);
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x000428F8 File Offset: 0x00040AF8
		public Il2CppReferenceArray<Component> GetComponentsInParent(Type t, bool includeInactive)
		{
			return this.gameObject.GetComponentsInParent(t, includeInactive);
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x00042918 File Offset: 0x00040B18
		public Il2CppReferenceArray<Component> GetComponentsInParent(Type t)
		{
			return this.GetComponentsInParent(t, false);
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x00042934 File Offset: 0x00040B34
		public Il2CppReferenceArray<Component> GetComponents(Type type)
		{
			return this.gameObject.GetComponents(type);
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x00042954 File Offset: 0x00040B54
		// (set) Token: 0x06001032 RID: 4146 RVA: 0x0000A09B File Offset: 0x0000829B
		public string tag
		{
			get
			{
				return this.gameObject.tag;
			}
			set
			{
				this.gameObject.tag = value;
			}
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00042974 File Offset: 0x00040B74
		public bool CompareTag(string tag)
		{
			return this.gameObject.CompareTag(tag);
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x0000A0AB File Offset: 0x000082AB
		public void SendMessageUpwards(string methodName, Object value, SendMessageOptions options)
		{
			Component.SendMessageUpwardsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(methodName), IL2CPP.Il2CppObjectBaseToPtr(value), options);
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x0000A0CA File Offset: 0x000082CA
		public void SendMessageUpwards(string methodName, Object value)
		{
			this.SendMessageUpwards(methodName, value, SendMessageOptions.RequireReceiver);
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x0000A0D7 File Offset: 0x000082D7
		public void SendMessageUpwards(string methodName)
		{
			this.SendMessageUpwards(methodName, null, SendMessageOptions.RequireReceiver);
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x0000A0E4 File Offset: 0x000082E4
		public void SendMessageUpwards(string methodName, SendMessageOptions options)
		{
			this.SendMessageUpwards(methodName, null, options);
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x0000A0F1 File Offset: 0x000082F1
		public void SendMessage(string methodName, Object value)
		{
			this.SendMessage(methodName, value, SendMessageOptions.RequireReceiver);
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x0000A0FE File Offset: 0x000082FE
		public void SendMessage(string methodName)
		{
			this.SendMessage(methodName, null, SendMessageOptions.RequireReceiver);
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x0000A10B File Offset: 0x0000830B
		public void SendMessage(string methodName, Object value, SendMessageOptions options)
		{
			Component.SendMessageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(methodName), IL2CPP.Il2CppObjectBaseToPtr(value), options);
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x0000A12A File Offset: 0x0000832A
		public void SendMessage(string methodName, SendMessageOptions options)
		{
			this.SendMessage(methodName, null, options);
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x0000A137 File Offset: 0x00008337
		public void BroadcastMessage(string methodName, Object parameter, SendMessageOptions options)
		{
			Component.BroadcastMessageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(methodName), IL2CPP.Il2CppObjectBaseToPtr(parameter), options);
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x0000A156 File Offset: 0x00008356
		public void BroadcastMessage(string methodName, Object parameter)
		{
			this.BroadcastMessage(methodName, parameter, SendMessageOptions.RequireReceiver);
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x0000A163 File Offset: 0x00008363
		public void BroadcastMessage(string methodName)
		{
			this.BroadcastMessage(methodName, null, SendMessageOptions.RequireReceiver);
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x0000A170 File Offset: 0x00008370
		public void BroadcastMessage(string methodName, SendMessageOptions options)
		{
			this.BroadcastMessage(methodName, null, options);
		}

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeMethodInfoPtr_get_transform_Public_get_Transform_0;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeMethodInfoPtr_GetComponent_Public_Component_Type_0;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentFastPath_Internal_Void_Type_IntPtr_0;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeMethodInfoPtr_GetComponent_Public_T_0;

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_Boolean_0;

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_T_0;

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0;

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0;

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_List_1_T_0;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_0;

		// Token: 0x04000C39 RID: 3129
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInParent_Public_T_0;

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0;

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInParent_Public_Void_Boolean_List_1_T_0;

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsForListInternal_Private_Void_Type_Object_0;

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeMethodInfoPtr_GetComponents_Public_Void_Type_List_1_Component_0;

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeMethodInfoPtr_GetComponents_Public_Void_List_1_T_0;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeMethodInfoPtr_GetComponents_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C42 RID: 3138
		private static readonly Component.GetComponentDelegate GetComponentDelegateField;

		// Token: 0x04000C43 RID: 3139
		private static readonly Component.SendMessageUpwardsDelegate SendMessageUpwardsDelegateField;

		// Token: 0x04000C44 RID: 3140
		private static readonly Component.SendMessageDelegate SendMessageDelegateField;

		// Token: 0x04000C45 RID: 3141
		private static readonly Component.BroadcastMessageDelegate BroadcastMessageDelegateField;

		// Token: 0x0200076E RID: 1902
		private sealed class MethodInfoStoreGeneric_GetComponent_Public_T_0<T>
		{
			// Token: 0x04001C81 RID: 7297
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponent_Public_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200076F RID: 1903
		private sealed class MethodInfoStoreGeneric_GetComponentInChildren_Public_T_0<T>
		{
			// Token: 0x04001C82 RID: 7298
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentInChildren_Public_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000770 RID: 1904
		private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0<T>
		{
			// Token: 0x04001C83 RID: 7299
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000771 RID: 1905
		private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0<T>
		{
			// Token: 0x04001C84 RID: 7300
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000772 RID: 1906
		private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04001C85 RID: 7301
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000773 RID: 1907
		private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_List_1_T_0<T>
		{
			// Token: 0x04001C86 RID: 7302
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_List_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000774 RID: 1908
		private sealed class MethodInfoStoreGeneric_GetComponentInParent_Public_T_0<T>
		{
			// Token: 0x04001C87 RID: 7303
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentInParent_Public_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000775 RID: 1909
		private sealed class MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0<T>
		{
			// Token: 0x04001C88 RID: 7304
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000776 RID: 1910
		private sealed class MethodInfoStoreGeneric_GetComponentsInParent_Public_Void_Boolean_List_1_T_0<T>
		{
			// Token: 0x04001C89 RID: 7305
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Void_Boolean_List_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000777 RID: 1911
		private sealed class MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04001C8A RID: 7306
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000778 RID: 1912
		private sealed class MethodInfoStoreGeneric_GetComponents_Public_Void_List_1_T_0<T>
		{
			// Token: 0x04001C8B RID: 7307
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponents_Public_Void_List_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000779 RID: 1913
		private sealed class MethodInfoStoreGeneric_GetComponents_Public_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04001C8C RID: 7308
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponents_Public_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200077A RID: 1914
		// (Invoke) Token: 0x06002CA5 RID: 11429
		private delegate IntPtr GetComponentDelegate(IntPtr @this, IntPtr type);

		// Token: 0x0200077B RID: 1915
		// (Invoke) Token: 0x06002CA7 RID: 11431
		private delegate void SendMessageUpwardsDelegate(IntPtr @this, IntPtr methodName, IntPtr value, SendMessageOptions options);

		// Token: 0x0200077C RID: 1916
		// (Invoke) Token: 0x06002CA9 RID: 11433
		private delegate void SendMessageDelegate(IntPtr @this, IntPtr methodName, IntPtr value, SendMessageOptions options);

		// Token: 0x0200077D RID: 1917
		// (Invoke) Token: 0x06002CAB RID: 11435
		private delegate void BroadcastMessageDelegate(IntPtr @this, IntPtr methodName, IntPtr parameter, SendMessageOptions options);
	}
}
