using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000008 RID: 8
public static class SA_Extensions_Renderer : global::Il2CppSystem.Object
{
	// Token: 0x06000030 RID: 48 RVA: 0x000020DF File Offset: 0x000002DF
	// Note: this type is marked as 'beforefieldinit'.
	static SA_Extensions_Renderer()
	{
		Il2CppClassPointerStore<SA_Extensions_Renderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "", "SA_Extensions_Renderer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Extensions_Renderer>.NativeClassPtr);
		SA_Extensions_Renderer.NativeMethodInfoPtr_IsVisibleFrom_Public_Static_Boolean_Renderer_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_Renderer>.NativeClassPtr, 100663330);
	}

	// Token: 0x06000031 RID: 49 RVA: 0x000045CC File Offset: 0x000027CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98378, XrefRangeEnd = 98381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsVisibleFrom(this Renderer renderer, Camera camera)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_Renderer.NativeMethodInfoPtr_IsVisibleFrom_Public_Static_Boolean_Renderer_Camera_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002118 File Offset: 0x00000318
	public SA_Extensions_Renderer(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000022 RID: 34
	private static readonly IntPtr NativeMethodInfoPtr_IsVisibleFrom_Public_Static_Boolean_Renderer_Camera_0;
}
