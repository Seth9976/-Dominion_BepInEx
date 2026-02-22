using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

// Token: 0x02000095 RID: 149
public class ResourceManager : MonoBehaviour
{
	// Token: 0x06001216 RID: 4630 RVA: 0x00050700 File Offset: 0x0004E900
	// Note: this type is marked as 'beforefieldinit'.
	static ResourceManager()
	{
		Il2CppClassPointerStore<ResourceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ResourceManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr);
		ResourceManager.NativeFieldInfoPtr_m_DictionaryResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "m_DictionaryResources");
		ResourceManager.NativeFieldInfoPtr_m_LoadingResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, "m_LoadingResources");
		ResourceManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100664697);
		ResourceManager.NativeMethodInfoPtr_HasLoadCompleted_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100664698);
		ResourceManager.NativeMethodInfoPtr_LoadResource_Public_ResourceEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100664699);
		ResourceManager.NativeMethodInfoPtr_LoadResourceAsync_Public_ResourceEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100664700);
		ResourceManager.NativeMethodInfoPtr_OnResourceEntryLoadComplete_Private_Void_ResourceEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100664701);
		ResourceManager.NativeMethodInfoPtr_ReleaseResourceEntry_Public_Void_ResourceEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100664702);
		ResourceManager.NativeMethodInfoPtr_ValidateLoadedResources_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100664703);
		ResourceManager.NativeMethodInfoPtr_Verbose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100664704);
		ResourceManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr, 100664705);
	}

	// Token: 0x06001217 RID: 4631 RVA: 0x0005080C File Offset: 0x0004EA0C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243122, XrefRangeEnd = 243134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001218 RID: 4632 RVA: 0x00050840 File Offset: 0x0004EA40
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 243135, RefRangeEnd = 243136, XrefRangeStart = 243134, XrefRangeEnd = 243135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasLoadCompleted()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_HasLoadCompleted_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001219 RID: 4633 RVA: 0x0005087C File Offset: 0x0004EA7C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 243147, RefRangeEnd = 243150, XrefRangeStart = 243136, XrefRangeEnd = 243147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ResourceEntry LoadResource<T>(string filename) where T : global::UnityEngine.Object
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.MethodInfoStoreGeneric_LoadResource_Public_ResourceEntry_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceEntry>(intPtr3) : null;
		}
	}

	// Token: 0x0600121A RID: 4634 RVA: 0x000508CC File Offset: 0x0004EACC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 243172, RefRangeEnd = 243174, XrefRangeStart = 243150, XrefRangeEnd = 243172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ResourceEntry LoadResourceAsync<T>(string filename) where T : global::UnityEngine.Object
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.MethodInfoStoreGeneric_LoadResourceAsync_Public_ResourceEntry_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceEntry>(intPtr3) : null;
		}
	}

	// Token: 0x0600121B RID: 4635 RVA: 0x0005091C File Offset: 0x0004EB1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243174, XrefRangeEnd = 243178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnResourceEntryLoadComplete(ResourceEntry resource_entry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(resource_entry);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_OnResourceEntryLoadComplete_Private_Void_ResourceEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600121C RID: 4636 RVA: 0x00050960 File Offset: 0x0004EB60
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243178, XrefRangeEnd = 243185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReleaseResourceEntry(ResourceEntry resource_entry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(resource_entry);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_ReleaseResourceEntry_Public_Void_ResourceEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600121D RID: 4637 RVA: 0x000509A4 File Offset: 0x0004EBA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243185, XrefRangeEnd = 243223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ValidateLoadedResources()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_ValidateLoadedResources_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600121E RID: 4638 RVA: 0x000509D8 File Offset: 0x0004EBD8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243223, XrefRangeEnd = 243271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Verbose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr_Verbose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600121F RID: 4639 RVA: 0x00050A0C File Offset: 0x0004EC0C
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ResourceManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001220 RID: 4640 RVA: 0x0000C1E3 File Offset: 0x0000A3E3
	public ResourceManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005D5 RID: 1493
	// (get) Token: 0x06001221 RID: 4641 RVA: 0x00050A48 File Offset: 0x0004EC48
	// (set) Token: 0x06001222 RID: 4642 RVA: 0x0000C1EC File Offset: 0x0000A3EC
	public unsafe Dictionary<string, ResourceEntry> m_DictionaryResources
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_DictionaryResources);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ResourceEntry>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_DictionaryResources), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005D6 RID: 1494
	// (get) Token: 0x06001223 RID: 4643 RVA: 0x00050A78 File Offset: 0x0004EC78
	// (set) Token: 0x06001224 RID: 4644 RVA: 0x0000C20B File Offset: 0x0000A40B
	public unsafe List<ResourceEntry> m_LoadingResources
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_LoadingResources);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ResourceEntry>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManager.NativeFieldInfoPtr_m_LoadingResources), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000CAC RID: 3244
	private static readonly IntPtr NativeFieldInfoPtr_m_DictionaryResources;

	// Token: 0x04000CAD RID: 3245
	private static readonly IntPtr NativeFieldInfoPtr_m_LoadingResources;

	// Token: 0x04000CAE RID: 3246
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000CAF RID: 3247
	private static readonly IntPtr NativeMethodInfoPtr_HasLoadCompleted_Public_Boolean_0;

	// Token: 0x04000CB0 RID: 3248
	private static readonly IntPtr NativeMethodInfoPtr_LoadResource_Public_ResourceEntry_String_0;

	// Token: 0x04000CB1 RID: 3249
	private static readonly IntPtr NativeMethodInfoPtr_LoadResourceAsync_Public_ResourceEntry_String_0;

	// Token: 0x04000CB2 RID: 3250
	private static readonly IntPtr NativeMethodInfoPtr_OnResourceEntryLoadComplete_Private_Void_ResourceEntry_0;

	// Token: 0x04000CB3 RID: 3251
	private static readonly IntPtr NativeMethodInfoPtr_ReleaseResourceEntry_Public_Void_ResourceEntry_0;

	// Token: 0x04000CB4 RID: 3252
	private static readonly IntPtr NativeMethodInfoPtr_ValidateLoadedResources_Public_Void_0;

	// Token: 0x04000CB5 RID: 3253
	private static readonly IntPtr NativeMethodInfoPtr_Verbose_Public_Void_0;

	// Token: 0x04000CB6 RID: 3254
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200019D RID: 413
	private sealed class MethodInfoStoreGeneric_LoadResource_Public_ResourceEntry_String_0<T>
	{
		// Token: 0x0400197A RID: 6522
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourceManager.NativeMethodInfoPtr_LoadResource_Public_ResourceEntry_String_0, Il2CppClassPointerStore<ResourceManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x0200019E RID: 414
	private sealed class MethodInfoStoreGeneric_LoadResourceAsync_Public_ResourceEntry_String_0<T>
	{
		// Token: 0x0400197B RID: 6523
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ResourceManager.NativeMethodInfoPtr_LoadResourceAsync_Public_ResourceEntry_String_0, Il2CppClassPointerStore<ResourceManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}
}
