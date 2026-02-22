using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200009A RID: 154
	public static class ResourcesAPIInternal : Object
	{
		// Token: 0x06000F7C RID: 3964 RVA: 0x000404FC File Offset: 0x0003E6FC
		// Note: this type is marked as 'beforefieldinit'.
		static ResourcesAPIInternal()
		{
			Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ResourcesAPIInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr);
			ResourcesAPIInternal.NativeMethodInfoPtr_FindShaderByName_Public_Static_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr, 100664283);
			ResourcesAPIInternal.NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr, 100664284);
			ResourcesAPIInternal.NativeMethodInfoPtr_LoadAsyncInternal_Internal_Static_ResourceRequest_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr, 100664285);
			ResourcesAPIInternal.NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr, 100664286);
			ResourcesAPIInternal.FindObjectsOfTypeAllDelegateField = IL2CPP.ResolveICall<ResourcesAPIInternal.FindObjectsOfTypeAllDelegate>("UnityEngine.ResourcesAPIInternal::FindObjectsOfTypeAll");
			ResourcesAPIInternal.LoadAllDelegateField = IL2CPP.ResolveICall<ResourcesAPIInternal.LoadAllDelegate>("UnityEngine.ResourcesAPIInternal::LoadAll");
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x0004059C File Offset: 0x0003E79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68021, XrefRangeEnd = 68023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Shader FindShaderByName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesAPIInternal.NativeMethodInfoPtr_FindShaderByName_Public_Static_Shader_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x000405E0 File Offset: 0x0003E7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68023, XrefRangeEnd = 68025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Load(string path, Type systemTypeInstance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(systemTypeInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesAPIInternal.NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00040638 File Offset: 0x0003E838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68025, XrefRangeEnd = 68027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ResourceRequest LoadAsyncInternal(string path, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesAPIInternal.NativeMethodInfoPtr_LoadAsyncInternal_Internal_Static_ResourceRequest_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceRequest>(intPtr3) : null;
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00040690 File Offset: 0x0003E890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68027, XrefRangeEnd = 68029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnloadAsset(Object assetToUnload)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assetToUnload);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourcesAPIInternal.NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00009BF0 File Offset: 0x00007DF0
		public ResourcesAPIInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x000406C8 File Offset: 0x0003E8C8
		public static Il2CppReferenceArray<Object> FindObjectsOfTypeAll(Type type)
		{
			IntPtr intPtr = ResourcesAPIInternal.FindObjectsOfTypeAllDelegateField(IL2CPP.Il2CppObjectBaseToPtr(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x000406F4 File Offset: 0x0003E8F4
		public static Il2CppReferenceArray<Object> LoadAll(string path, Type systemTypeInstance)
		{
			IntPtr intPtr = ResourcesAPIInternal.LoadAllDelegateField(IL2CPP.ManagedStringToIl2Cpp(path), IL2CPP.Il2CppObjectBaseToPtr(systemTypeInstance));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
		}

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeMethodInfoPtr_FindShaderByName_Public_Static_Shader_String_0;

		// Token: 0x04000BE0 RID: 3040
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0;

		// Token: 0x04000BE1 RID: 3041
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsyncInternal_Internal_Static_ResourceRequest_String_Type_0;

		// Token: 0x04000BE2 RID: 3042
		private static readonly IntPtr NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_0;

		// Token: 0x04000BE3 RID: 3043
		private static readonly ResourcesAPIInternal.FindObjectsOfTypeAllDelegate FindObjectsOfTypeAllDelegateField;

		// Token: 0x04000BE4 RID: 3044
		private static readonly ResourcesAPIInternal.LoadAllDelegate LoadAllDelegateField;

		// Token: 0x02000762 RID: 1890
		// (Invoke) Token: 0x06002C85 RID: 11397
		private delegate IntPtr FindObjectsOfTypeAllDelegate(IntPtr type);

		// Token: 0x02000763 RID: 1891
		// (Invoke) Token: 0x06002C87 RID: 11399
		private delegate IntPtr LoadAllDelegate(IntPtr path, IntPtr systemTypeInstance);
	}
}
