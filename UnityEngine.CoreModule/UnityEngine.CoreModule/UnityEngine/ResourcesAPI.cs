using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200009B RID: 155
	public class ResourcesAPI : Object
	{
		// Token: 0x06000F84 RID: 3972 RVA: 0x00040728 File Offset: 0x0003E928
		// Note: this type is marked as 'beforefieldinit'.
		static ResourcesAPI()
		{
			Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ResourcesAPI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr);
			ResourcesAPI.NativeFieldInfoPtr_s_DefaultAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, "s_DefaultAPI");
			ResourcesAPI.NativeFieldInfoPtr__overrideAPI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, "<overrideAPI>k__BackingField");
			ResourcesAPI.NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_ResourcesAPI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100664287);
			ResourcesAPI.NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_ResourcesAPI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100664288);
			ResourcesAPI.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100664289);
			ResourcesAPI.NativeMethodInfoPtr_FindShaderByName_FamOrAssem_Virtual_New_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100664290);
			ResourcesAPI.NativeMethodInfoPtr_Load_FamOrAssem_Virtual_New_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100664291);
			ResourcesAPI.NativeMethodInfoPtr_LoadAsync_FamOrAssem_Virtual_New_ResourceRequest_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100664292);
			ResourcesAPI.NativeMethodInfoPtr_UnloadAsset_FamOrAssem_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100664293);
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x0004080C File Offset: 0x0003EA0C
		public unsafe static ResourcesAPI ActiveAPI
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 68039, RefRangeEnd = 68044, XrefRangeStart = 68029, XrefRangeEnd = 68039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesAPI.NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_ResourcesAPI_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourcesAPI>(intPtr3) : null;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000F86 RID: 3974 RVA: 0x00040840 File Offset: 0x0003EA40
		// (set) Token: 0x06000F91 RID: 3985 RVA: 0x00009C26 File Offset: 0x00007E26
		public unsafe static ResourcesAPI overrideAPI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68044, XrefRangeEnd = 68048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesAPI.NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_ResourcesAPI_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourcesAPI>(intPtr3) : null;
			}
			set
			{
				ResourcesAPI._overrideAPI_k__BackingField = value;
			}
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00040874 File Offset: 0x0003EA74
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourcesAPI()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesAPI.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x000408B0 File Offset: 0x0003EAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68048, XrefRangeEnd = 68050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Shader FindShaderByName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourcesAPI.NativeMethodInfoPtr_FindShaderByName_FamOrAssem_Virtual_New_Shader_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x0004090C File Offset: 0x0003EB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68050, XrefRangeEnd = 68052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Load(string path, Type systemTypeInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(systemTypeInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourcesAPI.NativeMethodInfoPtr_Load_FamOrAssem_Virtual_New_Object_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x0004097C File Offset: 0x0003EB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68052, XrefRangeEnd = 68054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ResourceRequest LoadAsync(string path, Type systemTypeInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(systemTypeInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourcesAPI.NativeMethodInfoPtr_LoadAsync_FamOrAssem_Virtual_New_ResourceRequest_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceRequest>(intPtr3) : null;
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x000409EC File Offset: 0x0003EBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68054, XrefRangeEnd = 68061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnloadAsset(Object assetToUnload)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assetToUnload);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourcesAPI.NativeMethodInfoPtr_UnloadAsset_FamOrAssem_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x00009BF9 File Offset: 0x00007DF9
		public ResourcesAPI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x00040A3C File Offset: 0x0003EC3C
		// (set) Token: 0x06000F8E RID: 3982 RVA: 0x00009C02 File Offset: 0x00007E02
		public unsafe static ResourcesAPI s_DefaultAPI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResourcesAPI.NativeFieldInfoPtr_s_DefaultAPI, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourcesAPI>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourcesAPI.NativeFieldInfoPtr_s_DefaultAPI, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x00040A64 File Offset: 0x0003EC64
		// (set) Token: 0x06000F90 RID: 3984 RVA: 0x00009C14 File Offset: 0x00007E14
		public unsafe static ResourcesAPI _overrideAPI_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResourcesAPI.NativeFieldInfoPtr__overrideAPI_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourcesAPI>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourcesAPI.NativeFieldInfoPtr__overrideAPI_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00009C2E File Offset: 0x00007E2E
		public virtual Il2CppReferenceArray<Object> FindObjectsOfTypeAll(Type systemTypeInstance)
		{
			return ResourcesAPIInternal.FindObjectsOfTypeAll(systemTypeInstance);
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00009C36 File Offset: 0x00007E36
		public virtual Il2CppReferenceArray<Object> LoadAll(string path, Type systemTypeInstance)
		{
			return ResourcesAPIInternal.LoadAll(path, systemTypeInstance);
		}

		// Token: 0x04000BE5 RID: 3045
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultAPI;

		// Token: 0x04000BE6 RID: 3046
		private static readonly IntPtr NativeFieldInfoPtr__overrideAPI_k__BackingField;

		// Token: 0x04000BE7 RID: 3047
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_ResourcesAPI_0;

		// Token: 0x04000BE8 RID: 3048
		private static readonly IntPtr NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_ResourcesAPI_0;

		// Token: 0x04000BE9 RID: 3049
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_0;

		// Token: 0x04000BEA RID: 3050
		private static readonly IntPtr NativeMethodInfoPtr_FindShaderByName_FamOrAssem_Virtual_New_Shader_String_0;

		// Token: 0x04000BEB RID: 3051
		private static readonly IntPtr NativeMethodInfoPtr_Load_FamOrAssem_Virtual_New_Object_String_Type_0;

		// Token: 0x04000BEC RID: 3052
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsync_FamOrAssem_Virtual_New_ResourceRequest_String_Type_0;

		// Token: 0x04000BED RID: 3053
		private static readonly IntPtr NativeMethodInfoPtr_UnloadAsset_FamOrAssem_Virtual_New_Void_Object_0;
	}
}
