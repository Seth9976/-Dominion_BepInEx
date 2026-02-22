using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;
using UnityEngine;

// Token: 0x02000094 RID: 148
public class ResourceEntry : global::Il2CppSystem.Object
{
	// Token: 0x060011F6 RID: 4598 RVA: 0x00050000 File Offset: 0x0004E200
	// Note: this type is marked as 'beforefieldinit'.
	static ResourceEntry()
	{
		Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ResourceEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr);
		ResourceEntry.NativeFieldInfoPtr_k_DelayLoadCompletion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr, "k_DelayLoadCompletion");
		ResourceEntry.NativeFieldInfoPtr_m_ResourceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr, "m_ResourceManager");
		ResourceEntry.NativeFieldInfoPtr_m_ResourceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr, "m_ResourceName");
		ResourceEntry.NativeFieldInfoPtr_m_bLoadCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr, "m_bLoadCompleted");
		ResourceEntry.NativeFieldInfoPtr_m_ResourceRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr, "m_ResourceRequest");
		ResourceEntry.NativeFieldInfoPtr_m_ResourceObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr, "m_ResourceObject");
		ResourceEntry.NativeFieldInfoPtr_m_ReferenceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr, "m_ReferenceCount");
		ResourceEntry.NativeFieldInfoPtr_m_OnLoadCompletedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr, "m_OnLoadCompletedCallback");
		ResourceEntry.NativeMethodInfoPtr__ctor_Public_Void_ResourceManager_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr, 100664683);
		ResourceEntry.NativeMethodInfoPtr__ctor_Public_Void_ResourceManager_String_ResourceRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr, 100664684);
		ResourceEntry.NativeMethodInfoPtr_DelayResourceRequest_Private_IEnumerator_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr, 100664685);
		ResourceEntry.NativeMethodInfoPtr_DelayResourceRequestCompleted_Private_Void_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr, 100664686);
		ResourceEntry.NativeMethodInfoPtr_HandleResourceRequestCompleted_Private_Void_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr, 100664687);
		ResourceEntry.NativeMethodInfoPtr_AddOnLoadCompletedCallback_Public_Void_ResourceLoadCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr, 100664688);
		ResourceEntry.NativeMethodInfoPtr_GetResourceName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr, 100664689);
		ResourceEntry.NativeMethodInfoPtr_HasLoadCompleted_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr, 100664690);
		ResourceEntry.NativeMethodInfoPtr_GetCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr, 100664691);
		ResourceEntry.NativeMethodInfoPtr_IncrementCount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr, 100664692);
		ResourceEntry.NativeMethodInfoPtr_DecrementCount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr, 100664693);
		ResourceEntry.NativeMethodInfoPtr_ReleaseResourceEntry_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr, 100664694);
		ResourceEntry.NativeMethodInfoPtr_GetResourceObject_Public_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr, 100664695);
		ResourceEntry.NativeMethodInfoPtr_GetResource_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr, 100664696);
	}

	// Token: 0x060011F7 RID: 4599 RVA: 0x000501E8 File Offset: 0x0004E3E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243054, XrefRangeEnd = 243055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ResourceEntry(ResourceManager resourceManager, string resourceName, global::UnityEngine.Object resourceObject)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourceManager);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(resourceName);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resourceObject);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceEntry.NativeMethodInfoPtr__ctor_Public_Void_ResourceManager_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011F8 RID: 4600 RVA: 0x00050258 File Offset: 0x0004E458
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 243065, RefRangeEnd = 243066, XrefRangeStart = 243055, XrefRangeEnd = 243065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ResourceEntry(ResourceManager resourceManager, string resourceName, ResourceRequest resourceRequest)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourceManager);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(resourceName);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resourceRequest);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceEntry.NativeMethodInfoPtr__ctor_Public_Void_ResourceManager_String_ResourceRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011F9 RID: 4601 RVA: 0x000502C8 File Offset: 0x0004E4C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243066, XrefRangeEnd = 243070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator DelayResourceRequest(AsyncOperation completedRequest)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(completedRequest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceEntry.NativeMethodInfoPtr_DelayResourceRequest_Private_IEnumerator_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}
	}

	// Token: 0x060011FA RID: 4602 RVA: 0x00050318 File Offset: 0x0004E518
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243070, XrefRangeEnd = 243075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DelayResourceRequestCompleted(AsyncOperation completedRequest)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(completedRequest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceEntry.NativeMethodInfoPtr_DelayResourceRequestCompleted_Private_Void_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060011FB RID: 4603 RVA: 0x0005035C File Offset: 0x0004E55C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243075, XrefRangeEnd = 243088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleResourceRequestCompleted(AsyncOperation completedRequest)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(completedRequest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceEntry.NativeMethodInfoPtr_HandleResourceRequestCompleted_Private_Void_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060011FC RID: 4604 RVA: 0x000503A0 File Offset: 0x0004E5A0
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 243091, RefRangeEnd = 243097, XrefRangeStart = 243088, XrefRangeEnd = 243091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOnLoadCompletedCallback(ResourceEntry.ResourceLoadCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceEntry.NativeMethodInfoPtr_AddOnLoadCompletedCallback_Public_Void_ResourceLoadCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060011FD RID: 4605 RVA: 0x000503E4 File Offset: 0x0004E5E4
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetResourceName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceEntry.NativeMethodInfoPtr_GetResourceName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x060011FE RID: 4606 RVA: 0x0005041C File Offset: 0x0004E61C
	[CallerCount(0)]
	public unsafe bool HasLoadCompleted()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceEntry.NativeMethodInfoPtr_HasLoadCompleted_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060011FF RID: 4607 RVA: 0x00050458 File Offset: 0x0004E658
	[CallerCount(0)]
	public unsafe int GetCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceEntry.NativeMethodInfoPtr_GetCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001200 RID: 4608 RVA: 0x00050494 File Offset: 0x0004E694
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 39334, RefRangeEnd = 39339, XrefRangeStart = 39334, XrefRangeEnd = 39339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IncrementCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceEntry.NativeMethodInfoPtr_IncrementCount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001201 RID: 4609 RVA: 0x000504C8 File Offset: 0x0004E6C8
	[CallerCount(0)]
	public unsafe void DecrementCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceEntry.NativeMethodInfoPtr_DecrementCount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001202 RID: 4610 RVA: 0x000504FC File Offset: 0x0004E6FC
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 243108, RefRangeEnd = 243112, XrefRangeStart = 243097, XrefRangeEnd = 243108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReleaseResourceEntry()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceEntry.NativeMethodInfoPtr_ReleaseResourceEntry_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001203 RID: 4611 RVA: 0x00050530 File Offset: 0x0004E730
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe global::UnityEngine.Object GetResourceObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceEntry.NativeMethodInfoPtr_GetResourceObject_Public_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::UnityEngine.Object>(intPtr3) : null;
	}

	// Token: 0x06001204 RID: 4612 RVA: 0x00050570 File Offset: 0x0004E770
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 243116, RefRangeEnd = 243122, XrefRangeStart = 243112, XrefRangeEnd = 243116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe T GetResource<T>() where T : global::UnityEngine.Object
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceEntry.MethodInfoStoreGeneric_GetResource_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	// Token: 0x06001205 RID: 4613 RVA: 0x0000C0FB File Offset: 0x0000A2FB
	public ResourceEntry(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005CD RID: 1485
	// (get) Token: 0x06001206 RID: 4614 RVA: 0x000505AC File Offset: 0x0004E7AC
	// (set) Token: 0x06001207 RID: 4615 RVA: 0x0000C104 File Offset: 0x0000A304
	public unsafe static float k_DelayLoadCompletion
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(ResourceEntry.NativeFieldInfoPtr_k_DelayLoadCompletion, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ResourceEntry.NativeFieldInfoPtr_k_DelayLoadCompletion, (void*)(&value));
		}
	}

	// Token: 0x170005CE RID: 1486
	// (get) Token: 0x06001208 RID: 4616 RVA: 0x000505C8 File Offset: 0x0004E7C8
	// (set) Token: 0x06001209 RID: 4617 RVA: 0x0000C112 File Offset: 0x0000A312
	public unsafe ResourceManager m_ResourceManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceEntry.NativeFieldInfoPtr_m_ResourceManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceEntry.NativeFieldInfoPtr_m_ResourceManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005CF RID: 1487
	// (get) Token: 0x0600120A RID: 4618 RVA: 0x000505F8 File Offset: 0x0004E7F8
	// (set) Token: 0x0600120B RID: 4619 RVA: 0x0000C131 File Offset: 0x0000A331
	public unsafe string m_ResourceName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceEntry.NativeFieldInfoPtr_m_ResourceName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceEntry.NativeFieldInfoPtr_m_ResourceName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170005D0 RID: 1488
	// (get) Token: 0x0600120C RID: 4620 RVA: 0x00050620 File Offset: 0x0004E820
	// (set) Token: 0x0600120D RID: 4621 RVA: 0x0000C150 File Offset: 0x0000A350
	public unsafe bool m_bLoadCompleted
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceEntry.NativeFieldInfoPtr_m_bLoadCompleted);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceEntry.NativeFieldInfoPtr_m_bLoadCompleted)) = value;
		}
	}

	// Token: 0x170005D1 RID: 1489
	// (get) Token: 0x0600120E RID: 4622 RVA: 0x00050648 File Offset: 0x0004E848
	// (set) Token: 0x0600120F RID: 4623 RVA: 0x0000C16B File Offset: 0x0000A36B
	public unsafe ResourceRequest m_ResourceRequest
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceEntry.NativeFieldInfoPtr_m_ResourceRequest);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceRequest>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceEntry.NativeFieldInfoPtr_m_ResourceRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005D2 RID: 1490
	// (get) Token: 0x06001210 RID: 4624 RVA: 0x00050678 File Offset: 0x0004E878
	// (set) Token: 0x06001211 RID: 4625 RVA: 0x0000C18A File Offset: 0x0000A38A
	public unsafe global::UnityEngine.Object m_ResourceObject
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceEntry.NativeFieldInfoPtr_m_ResourceObject);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::UnityEngine.Object>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceEntry.NativeFieldInfoPtr_m_ResourceObject), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005D3 RID: 1491
	// (get) Token: 0x06001212 RID: 4626 RVA: 0x000506A8 File Offset: 0x0004E8A8
	// (set) Token: 0x06001213 RID: 4627 RVA: 0x0000C1A9 File Offset: 0x0000A3A9
	public unsafe int m_ReferenceCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceEntry.NativeFieldInfoPtr_m_ReferenceCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceEntry.NativeFieldInfoPtr_m_ReferenceCount)) = value;
		}
	}

	// Token: 0x170005D4 RID: 1492
	// (get) Token: 0x06001214 RID: 4628 RVA: 0x000506D0 File Offset: 0x0004E8D0
	// (set) Token: 0x06001215 RID: 4629 RVA: 0x0000C1C4 File Offset: 0x0000A3C4
	public unsafe ResourceEntry.ResourceLoadCallback m_OnLoadCompletedCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceEntry.NativeFieldInfoPtr_m_OnLoadCompletedCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceEntry.ResourceLoadCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceEntry.NativeFieldInfoPtr_m_OnLoadCompletedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000C96 RID: 3222
	private static readonly IntPtr NativeFieldInfoPtr_k_DelayLoadCompletion;

	// Token: 0x04000C97 RID: 3223
	private static readonly IntPtr NativeFieldInfoPtr_m_ResourceManager;

	// Token: 0x04000C98 RID: 3224
	private static readonly IntPtr NativeFieldInfoPtr_m_ResourceName;

	// Token: 0x04000C99 RID: 3225
	private static readonly IntPtr NativeFieldInfoPtr_m_bLoadCompleted;

	// Token: 0x04000C9A RID: 3226
	private static readonly IntPtr NativeFieldInfoPtr_m_ResourceRequest;

	// Token: 0x04000C9B RID: 3227
	private static readonly IntPtr NativeFieldInfoPtr_m_ResourceObject;

	// Token: 0x04000C9C RID: 3228
	private static readonly IntPtr NativeFieldInfoPtr_m_ReferenceCount;

	// Token: 0x04000C9D RID: 3229
	private static readonly IntPtr NativeFieldInfoPtr_m_OnLoadCompletedCallback;

	// Token: 0x04000C9E RID: 3230
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ResourceManager_String_Object_0;

	// Token: 0x04000C9F RID: 3231
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ResourceManager_String_ResourceRequest_0;

	// Token: 0x04000CA0 RID: 3232
	private static readonly IntPtr NativeMethodInfoPtr_DelayResourceRequest_Private_IEnumerator_AsyncOperation_0;

	// Token: 0x04000CA1 RID: 3233
	private static readonly IntPtr NativeMethodInfoPtr_DelayResourceRequestCompleted_Private_Void_AsyncOperation_0;

	// Token: 0x04000CA2 RID: 3234
	private static readonly IntPtr NativeMethodInfoPtr_HandleResourceRequestCompleted_Private_Void_AsyncOperation_0;

	// Token: 0x04000CA3 RID: 3235
	private static readonly IntPtr NativeMethodInfoPtr_AddOnLoadCompletedCallback_Public_Void_ResourceLoadCallback_0;

	// Token: 0x04000CA4 RID: 3236
	private static readonly IntPtr NativeMethodInfoPtr_GetResourceName_Public_String_0;

	// Token: 0x04000CA5 RID: 3237
	private static readonly IntPtr NativeMethodInfoPtr_HasLoadCompleted_Public_Boolean_0;

	// Token: 0x04000CA6 RID: 3238
	private static readonly IntPtr NativeMethodInfoPtr_GetCount_Public_Int32_0;

	// Token: 0x04000CA7 RID: 3239
	private static readonly IntPtr NativeMethodInfoPtr_IncrementCount_Public_Void_0;

	// Token: 0x04000CA8 RID: 3240
	private static readonly IntPtr NativeMethodInfoPtr_DecrementCount_Public_Void_0;

	// Token: 0x04000CA9 RID: 3241
	private static readonly IntPtr NativeMethodInfoPtr_ReleaseResourceEntry_Public_Void_0;

	// Token: 0x04000CAA RID: 3242
	private static readonly IntPtr NativeMethodInfoPtr_GetResourceObject_Public_Object_0;

	// Token: 0x04000CAB RID: 3243
	private static readonly IntPtr NativeMethodInfoPtr_GetResource_Public_T_0;

	// Token: 0x0200019A RID: 410
	public sealed class ResourceLoadCallback : MulticastDelegate
	{
		// Token: 0x060024B0 RID: 9392 RVA: 0x000884D4 File Offset: 0x000866D4
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceLoadCallback()
		{
			Il2CppClassPointerStore<ResourceEntry.ResourceLoadCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr, "ResourceLoadCallback");
			ResourceEntry.ResourceLoadCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceEntry.ResourceLoadCallback>.NativeClassPtr, 100666216);
			ResourceEntry.ResourceLoadCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ResourceEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceEntry.ResourceLoadCallback>.NativeClassPtr, 100666217);
			ResourceEntry.ResourceLoadCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ResourceEntry_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceEntry.ResourceLoadCallback>.NativeClassPtr, 100666218);
			ResourceEntry.ResourceLoadCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceEntry.ResourceLoadCallback>.NativeClassPtr, 100666219);
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x00088548 File Offset: 0x00086748
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceLoadCallback(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceEntry.ResourceLoadCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceEntry.ResourceLoadCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x000885A4 File Offset: 0x000867A4
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 59640, RefRangeEnd = 59663, XrefRangeStart = 59640, XrefRangeEnd = 59663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(ResourceEntry resourceEntry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourceEntry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceEntry.ResourceLoadCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ResourceEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x000885E8 File Offset: 0x000867E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163501, RefRangeEnd = 163503, XrefRangeStart = 163501, XrefRangeEnd = 163503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(ResourceEntry resourceEntry, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourceEntry);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceEntry.ResourceLoadCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ResourceEntry_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x0008865C File Offset: 0x0008685C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceEntry.ResourceLoadCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x00016C61 File Offset: 0x00014E61
		public ResourceLoadCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x00016C6A File Offset: 0x00014E6A
		public static implicit operator ResourceEntry.ResourceLoadCallback(Action<ResourceEntry> A_0)
		{
			return DelegateSupport.ConvertDelegate<ResourceEntry.ResourceLoadCallback>(A_0);
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x00016C72 File Offset: 0x00014E72
		public static ResourceEntry.ResourceLoadCallback operator +(ResourceEntry.ResourceLoadCallback A_0, ResourceEntry.ResourceLoadCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ResourceEntry.ResourceLoadCallback>();
		}

		// Token: 0x060024B8 RID: 9400 RVA: 0x00016C80 File Offset: 0x00014E80
		public static ResourceEntry.ResourceLoadCallback operator -(ResourceEntry.ResourceLoadCallback A_0, ResourceEntry.ResourceLoadCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ResourceEntry.ResourceLoadCallback>();
			}
			return delegate2;
		}

		// Token: 0x0400196A RID: 6506
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400196B RID: 6507
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ResourceEntry_0;

		// Token: 0x0400196C RID: 6508
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ResourceEntry_AsyncCallback_Object_0;

		// Token: 0x0400196D RID: 6509
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x0200019B RID: 411
	[ObfuscatedName("ResourceEntry+<DelayResourceRequest>d__11")]
	public sealed class _DelayResourceRequest_d__11 : global::Il2CppSystem.Object
	{
		// Token: 0x060024B9 RID: 9401 RVA: 0x000886A0 File Offset: 0x000868A0
		// Note: this type is marked as 'beforefieldinit'.
		static _DelayResourceRequest_d__11()
		{
			Il2CppClassPointerStore<ResourceEntry._DelayResourceRequest_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr, "<DelayResourceRequest>d__11");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceEntry._DelayResourceRequest_d__11>.NativeClassPtr);
			ResourceEntry._DelayResourceRequest_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceEntry._DelayResourceRequest_d__11>.NativeClassPtr, "<>1__state");
			ResourceEntry._DelayResourceRequest_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceEntry._DelayResourceRequest_d__11>.NativeClassPtr, "<>2__current");
			ResourceEntry._DelayResourceRequest_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceEntry._DelayResourceRequest_d__11>.NativeClassPtr, "<>4__this");
			ResourceEntry._DelayResourceRequest_d__11.NativeFieldInfoPtr_completedRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceEntry._DelayResourceRequest_d__11>.NativeClassPtr, "completedRequest");
			ResourceEntry._DelayResourceRequest_d__11.NativeFieldInfoPtr__accumulatedTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceEntry._DelayResourceRequest_d__11>.NativeClassPtr, "<accumulatedTime>5__2");
			ResourceEntry._DelayResourceRequest_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceEntry._DelayResourceRequest_d__11>.NativeClassPtr, 100666220);
			ResourceEntry._DelayResourceRequest_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceEntry._DelayResourceRequest_d__11>.NativeClassPtr, 100666221);
			ResourceEntry._DelayResourceRequest_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceEntry._DelayResourceRequest_d__11>.NativeClassPtr, 100666222);
			ResourceEntry._DelayResourceRequest_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceEntry._DelayResourceRequest_d__11>.NativeClassPtr, 100666223);
			ResourceEntry._DelayResourceRequest_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceEntry._DelayResourceRequest_d__11>.NativeClassPtr, 100666224);
			ResourceEntry._DelayResourceRequest_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceEntry._DelayResourceRequest_d__11>.NativeClassPtr, 100666225);
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x000887A8 File Offset: 0x000869A8
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _DelayResourceRequest_d__11(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceEntry._DelayResourceRequest_d__11>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceEntry._DelayResourceRequest_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x000887F0 File Offset: 0x000869F0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceEntry._DelayResourceRequest_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x00088824 File Offset: 0x00086A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243043, XrefRangeEnd = 243049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceEntry._DelayResourceRequest_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x060024BD RID: 9405 RVA: 0x00088860 File Offset: 0x00086A60
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceEntry._DelayResourceRequest_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060024BE RID: 9406 RVA: 0x000888A0 File Offset: 0x00086AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243049, XrefRangeEnd = 243054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceEntry._DelayResourceRequest_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x060024BF RID: 9407 RVA: 0x000888D4 File Offset: 0x00086AD4
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceEntry._DelayResourceRequest_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x00016C91 File Offset: 0x00014E91
		public _DelayResourceRequest_d__11(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x060024C1 RID: 9409 RVA: 0x00088914 File Offset: 0x00086B14
		// (set) Token: 0x060024C2 RID: 9410 RVA: 0x00016C9A File Offset: 0x00014E9A
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceEntry._DelayResourceRequest_d__11.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceEntry._DelayResourceRequest_d__11.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x060024C3 RID: 9411 RVA: 0x0008893C File Offset: 0x00086B3C
		// (set) Token: 0x060024C4 RID: 9412 RVA: 0x00016CB5 File Offset: 0x00014EB5
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceEntry._DelayResourceRequest_d__11.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceEntry._DelayResourceRequest_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x060024C5 RID: 9413 RVA: 0x0008896C File Offset: 0x00086B6C
		// (set) Token: 0x060024C6 RID: 9414 RVA: 0x00016CD4 File Offset: 0x00014ED4
		public unsafe ResourceEntry __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceEntry._DelayResourceRequest_d__11.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceEntry._DelayResourceRequest_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x060024C7 RID: 9415 RVA: 0x0008899C File Offset: 0x00086B9C
		// (set) Token: 0x060024C8 RID: 9416 RVA: 0x00016CF3 File Offset: 0x00014EF3
		public unsafe AsyncOperation completedRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceEntry._DelayResourceRequest_d__11.NativeFieldInfoPtr_completedRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceEntry._DelayResourceRequest_d__11.NativeFieldInfoPtr_completedRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x060024C9 RID: 9417 RVA: 0x000889CC File Offset: 0x00086BCC
		// (set) Token: 0x060024CA RID: 9418 RVA: 0x00016D12 File Offset: 0x00014F12
		public unsafe float _accumulatedTime_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceEntry._DelayResourceRequest_d__11.NativeFieldInfoPtr__accumulatedTime_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceEntry._DelayResourceRequest_d__11.NativeFieldInfoPtr__accumulatedTime_5__2)) = value;
			}
		}

		// Token: 0x0400196E RID: 6510
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400196F RID: 6511
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001970 RID: 6512
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001971 RID: 6513
		private static readonly IntPtr NativeFieldInfoPtr_completedRequest;

		// Token: 0x04001972 RID: 6514
		private static readonly IntPtr NativeFieldInfoPtr__accumulatedTime_5__2;

		// Token: 0x04001973 RID: 6515
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001974 RID: 6516
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001975 RID: 6517
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001976 RID: 6518
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001977 RID: 6519
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001978 RID: 6520
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x0200019C RID: 412
	private sealed class MethodInfoStoreGeneric_GetResource_Public_T_0<T>
	{
		// Token: 0x04001979 RID: 6521
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourceEntry.NativeMethodInfoPtr_GetResource_Public_T_0, Il2CppClassPointerStore<ResourceEntry>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}
}
