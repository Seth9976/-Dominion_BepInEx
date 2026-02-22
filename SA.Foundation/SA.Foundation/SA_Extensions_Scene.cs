using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.SceneManagement;

// Token: 0x02000009 RID: 9
public static class SA_Extensions_Scene : Object
{
	// Token: 0x06000033 RID: 51 RVA: 0x00002121 File Offset: 0x00000321
	// Note: this type is marked as 'beforefieldinit'.
	static SA_Extensions_Scene()
	{
		Il2CppClassPointerStore<SA_Extensions_Scene>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "", "SA_Extensions_Scene");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Extensions_Scene>.NativeClassPtr);
		SA_Extensions_Scene.NativeMethodInfoPtr_GetComponentInScene_Public_Static_T_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_Scene>.NativeClassPtr, 100663331);
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00004620 File Offset: 0x00002820
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98381, XrefRangeEnd = 98383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetComponentInScene<T>(this Scene scene)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref scene;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_Scene.MethodInfoStoreGeneric_GetComponentInScene_Public_Static_T_Scene_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x06000035 RID: 53 RVA: 0x0000215A File Offset: 0x0000035A
	public SA_Extensions_Scene(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000023 RID: 35
	private static readonly IntPtr NativeMethodInfoPtr_GetComponentInScene_Public_Static_T_Scene_0;

	// Token: 0x02000044 RID: 68
	private sealed class MethodInfoStoreGeneric_GetComponentInScene_Public_Static_T_Scene_0<T>
	{
		// Token: 0x040002D9 RID: 729
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SA_Extensions_Scene.NativeMethodInfoPtr_GetComponentInScene_Public_Static_T_Scene_0, Il2CppClassPointerStore<SA_Extensions_Scene>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}
}
