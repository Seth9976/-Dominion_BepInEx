using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000004 RID: 4
public static class SA_Extensions_Bounds : global::Il2CppSystem.Object
{
	// Token: 0x06000014 RID: 20 RVA: 0x00003C18 File Offset: 0x00001E18
	// Note: this type is marked as 'beforefieldinit'.
	static SA_Extensions_Bounds()
	{
		Il2CppClassPointerStore<SA_Extensions_Bounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "", "SA_Extensions_Bounds");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Extensions_Bounds>.NativeClassPtr);
		SA_Extensions_Bounds.NativeMethodInfoPtr_GetVertex_Public_Static_Vector3_Bounds_SA_VertexX_SA_VertexY_SA_VertexZ_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_Bounds>.NativeClassPtr, 100663310);
		SA_Extensions_Bounds.NativeMethodInfoPtr_CalculateBounds_Public_Static_Bounds_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_Bounds>.NativeClassPtr, 100663311);
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00003C70 File Offset: 0x00001E70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98180, XrefRangeEnd = 98188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 GetVertex(this Bounds bounds, SA_VertexX x, SA_VertexY y, SA_VertexZ z)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bounds;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_Bounds.NativeMethodInfoPtr_GetVertex_Public_Static_Vector3_Bounds_SA_VertexX_SA_VertexY_SA_VertexZ_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00003CD8 File Offset: 0x00001ED8
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 98206, RefRangeEnd = 98210, XrefRangeStart = 98188, XrefRangeEnd = 98206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Bounds CalculateBounds(GameObject obj)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_Bounds.NativeMethodInfoPtr_CalculateBounds_Public_Static_Bounds_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002082 File Offset: 0x00000282
	public SA_Extensions_Bounds(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x0400000E RID: 14
	private static readonly IntPtr NativeMethodInfoPtr_GetVertex_Public_Static_Vector3_Bounds_SA_VertexX_SA_VertexY_SA_VertexZ_0;

	// Token: 0x0400000F RID: 15
	private static readonly IntPtr NativeMethodInfoPtr_CalculateBounds_Public_Static_Bounds_GameObject_0;
}
