using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine
{
	// Token: 0x0200009C RID: 156
	public sealed class Resources : Object
	{
		// Token: 0x06000F94 RID: 3988 RVA: 0x00040A8C File Offset: 0x0003EC8C
		// Note: this type is marked as 'beforefieldinit'.
		static Resources()
		{
			Il2CppClassPointerStore<Resources>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Resources");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Resources>.NativeClassPtr);
			Resources.NativeMethodInfoPtr_Load_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100664295);
			Resources.NativeMethodInfoPtr_Load_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100664296);
			Resources.NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100664297);
			Resources.NativeMethodInfoPtr_LoadAsync_Public_Static_ResourceRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100664298);
			Resources.NativeMethodInfoPtr_LoadAsync_Public_Static_ResourceRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100664299);
			Resources.NativeMethodInfoPtr_LoadAsync_Public_Static_ResourceRequest_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100664300);
			Resources.NativeMethodInfoPtr_GetBuiltinResource_Public_Static_Object_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100664301);
			Resources.NativeMethodInfoPtr_GetBuiltinResource_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100664302);
			Resources.NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100664303);
			Resources.NativeMethodInfoPtr_UnloadUnusedAssets_Public_Static_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100664304);
			Resources.UnloadAssetImplResourceManagerDelegateField = IL2CPP.ResolveICall<Resources.UnloadAssetImplResourceManagerDelegate>("UnityEngine.Resources::UnloadAssetImplResourceManager");
			Resources.InstanceIDToObjectDelegateField = IL2CPP.ResolveICall<Resources.InstanceIDToObjectDelegate>("UnityEngine.Resources::InstanceIDToObject");
			Resources.InstanceIDToObjectListDelegateField = IL2CPP.ResolveICall<Resources.InstanceIDToObjectListDelegate>("UnityEngine.Resources::InstanceIDToObjectList");
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x00040BB4 File Offset: 0x0003EDB4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 68068, RefRangeEnd = 68081, XrefRangeStart = 68061, XrefRangeEnd = 68068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Load(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_Load_Public_Static_Object_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x00040BF8 File Offset: 0x0003EDF8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 68087, RefRangeEnd = 68099, XrefRangeStart = 68081, XrefRangeEnd = 68087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Load<T>(string path) where T : Object
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.MethodInfoStoreGeneric_Load_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00040C38 File Offset: 0x0003EE38
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 68104, RefRangeEnd = 68116, XrefRangeStart = 68099, XrefRangeEnd = 68104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00040C90 File Offset: 0x0003EE90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68127, RefRangeEnd = 68128, XrefRangeStart = 68116, XrefRangeEnd = 68127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ResourceRequest LoadAsync(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_LoadAsync_Public_Static_ResourceRequest_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00040CD4 File Offset: 0x0003EED4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 68133, RefRangeEnd = 68136, XrefRangeStart = 68128, XrefRangeEnd = 68133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ResourceRequest LoadAsync<T>(string path) where T : Object
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.MethodInfoStoreGeneric_LoadAsync_Public_Static_ResourceRequest_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00040D18 File Offset: 0x0003EF18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68141, RefRangeEnd = 68142, XrefRangeStart = 68136, XrefRangeEnd = 68141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ResourceRequest LoadAsync(string path, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_LoadAsync_Public_Static_ResourceRequest_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceRequest>(intPtr3) : null;
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00040D70 File Offset: 0x0003EF70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68144, RefRangeEnd = 68145, XrefRangeStart = 68142, XrefRangeEnd = 68144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetBuiltinResource(Type type, string path)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_GetBuiltinResource_Public_Static_Object_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x00040DC8 File Offset: 0x0003EFC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68151, RefRangeEnd = 68152, XrefRangeStart = 68145, XrefRangeEnd = 68151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetBuiltinResource<T>(string path) where T : Object
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.MethodInfoStoreGeneric_GetBuiltinResource_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x00040E08 File Offset: 0x0003F008
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 68157, RefRangeEnd = 68164, XrefRangeStart = 68152, XrefRangeEnd = 68157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnloadAsset(Object assetToUnload)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assetToUnload);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x00040E40 File Offset: 0x0003F040
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 68166, RefRangeEnd = 68170, XrefRangeStart = 68164, XrefRangeEnd = 68166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation UnloadUnusedAssets()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_UnloadUnusedAssets_Public_Static_AsyncOperation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00009C3F File Offset: 0x00007E3F
		public Resources(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00009C48 File Offset: 0x00007E48
		public static Il2CppArrayBase<T> ConvertObjects<T>(Il2CppReferenceArray<Object> rawObjects) where T : Object
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00040E74 File Offset: 0x0003F074
		public static Il2CppReferenceArray<Object> FindObjectsOfTypeAll(Type type)
		{
			return ResourcesAPI.ActiveAPI.FindObjectsOfTypeAll(type);
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00040E94 File Offset: 0x0003F094
		public static Il2CppArrayBase<T> FindObjectsOfTypeAll<T>() where T : Object
		{
			return Resources.ConvertObjects<T>(Resources.FindObjectsOfTypeAll(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x00040EBC File Offset: 0x0003F0BC
		public static Il2CppReferenceArray<Object> LoadAll(string path, Type systemTypeInstance)
		{
			return ResourcesAPI.ActiveAPI.LoadAll(path, systemTypeInstance);
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x00040EDC File Offset: 0x0003F0DC
		public static Il2CppReferenceArray<Object> LoadAll(string path)
		{
			return Resources.LoadAll(path, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x00040F00 File Offset: 0x0003F100
		public static Il2CppArrayBase<T> LoadAll<T>(string path) where T : Object
		{
			return Resources.ConvertObjects<T>(Resources.LoadAll(path, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00009C55 File Offset: 0x00007E55
		public static void UnloadAssetImplResourceManager(Object assetToUnload)
		{
			Resources.UnloadAssetImplResourceManagerDelegateField(IL2CPP.Il2CppObjectBaseToPtr(assetToUnload));
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x00040F28 File Offset: 0x0003F128
		public static Object InstanceIDToObject(int instanceID)
		{
			IntPtr intPtr = Resources.InstanceIDToObjectDelegateField(instanceID);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x00009C67 File Offset: 0x00007E67
		public static void InstanceIDToObjectList(IntPtr instanceIDs, int instanceCount, List<Object> objects)
		{
			Resources.InstanceIDToObjectListDelegateField(instanceIDs, instanceCount, IL2CPP.Il2CppObjectBaseToPtr(objects));
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x00040F50 File Offset: 0x0003F150
		public static void InstanceIDToObjectList(Unity.Collections.NativeArray<int> instanceIDs, List<Object> objects)
		{
			bool flag = !instanceIDs.IsCreated;
			if (flag)
			{
				throw new ArgumentException("NativeArray is uninitialized", "instanceIDs");
			}
			bool flag2 = objects == null;
			if (flag2)
			{
				throw new ArgumentNullException("objects");
			}
			bool flag3 = instanceIDs.Length == 0;
			if (flag3)
			{
				objects.Clear();
			}
			else
			{
				Resources.InstanceIDToObjectList((IntPtr)instanceIDs.GetUnsafeReadOnlyPtr<int>(), instanceIDs.Length, objects);
			}
		}

		// Token: 0x04000BEE RID: 3054
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_Object_String_0;

		// Token: 0x04000BEF RID: 3055
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_T_String_0;

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0;

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsync_Public_Static_ResourceRequest_String_0;

		// Token: 0x04000BF2 RID: 3058
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsync_Public_Static_ResourceRequest_String_0;

		// Token: 0x04000BF3 RID: 3059
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsync_Public_Static_ResourceRequest_String_Type_0;

		// Token: 0x04000BF4 RID: 3060
		private static readonly IntPtr NativeMethodInfoPtr_GetBuiltinResource_Public_Static_Object_Type_String_0;

		// Token: 0x04000BF5 RID: 3061
		private static readonly IntPtr NativeMethodInfoPtr_GetBuiltinResource_Public_Static_T_String_0;

		// Token: 0x04000BF6 RID: 3062
		private static readonly IntPtr NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_0;

		// Token: 0x04000BF7 RID: 3063
		private static readonly IntPtr NativeMethodInfoPtr_UnloadUnusedAssets_Public_Static_AsyncOperation_0;

		// Token: 0x04000BF8 RID: 3064
		private static readonly Resources.UnloadAssetImplResourceManagerDelegate UnloadAssetImplResourceManagerDelegateField;

		// Token: 0x04000BF9 RID: 3065
		private static readonly Resources.InstanceIDToObjectDelegate InstanceIDToObjectDelegateField;

		// Token: 0x04000BFA RID: 3066
		private static readonly Resources.InstanceIDToObjectListDelegate InstanceIDToObjectListDelegateField;

		// Token: 0x02000764 RID: 1892
		private sealed class MethodInfoStoreGeneric_Load_Public_Static_T_String_0<T>
		{
			// Token: 0x04001C7D RID: 7293
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Resources.NativeMethodInfoPtr_Load_Public_Static_T_String_0, Il2CppClassPointerStore<Resources>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000765 RID: 1893
		private sealed class MethodInfoStoreGeneric_LoadAsync_Public_Static_ResourceRequest_String_0<T>
		{
			// Token: 0x04001C7E RID: 7294
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Resources.NativeMethodInfoPtr_LoadAsync_Public_Static_ResourceRequest_String_0, Il2CppClassPointerStore<Resources>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000766 RID: 1894
		private sealed class MethodInfoStoreGeneric_GetBuiltinResource_Public_Static_T_String_0<T>
		{
			// Token: 0x04001C7F RID: 7295
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Resources.NativeMethodInfoPtr_GetBuiltinResource_Public_Static_T_String_0, Il2CppClassPointerStore<Resources>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000767 RID: 1895
		// (Invoke) Token: 0x06002C8C RID: 11404
		private delegate void UnloadAssetImplResourceManagerDelegate(IntPtr assetToUnload);

		// Token: 0x02000768 RID: 1896
		// (Invoke) Token: 0x06002C8E RID: 11406
		private delegate IntPtr InstanceIDToObjectDelegate(int instanceID);

		// Token: 0x02000769 RID: 1897
		// (Invoke) Token: 0x06002C90 RID: 11408
		private delegate void InstanceIDToObjectListDelegate(IntPtr instanceIDs, int instanceCount, IntPtr objects);
	}
}
