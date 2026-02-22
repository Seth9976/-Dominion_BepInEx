using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x0200000B RID: 11
public static class SA_Extensions_Transform : global::Il2CppSystem.Object
{
	// Token: 0x0600003D RID: 61 RVA: 0x00004860 File Offset: 0x00002A60
	// Note: this type is marked as 'beforefieldinit'.
	static SA_Extensions_Transform()
	{
		Il2CppClassPointerStore<SA_Extensions_Transform>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "", "SA_Extensions_Transform");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Extensions_Transform>.NativeClassPtr);
		SA_Extensions_Transform.NativeMethodInfoPtr_SetGlobalScale_Public_Static_Void_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_Transform>.NativeClassPtr, 100663337);
		SA_Extensions_Transform.NativeMethodInfoPtr_Reset_Public_Static_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_Transform>.NativeClassPtr, 100663338);
		SA_Extensions_Transform.NativeMethodInfoPtr_Clear_Public_Static_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_Transform>.NativeClassPtr, 100663339);
		SA_Extensions_Transform.NativeMethodInfoPtr_FindOrCreateChild_Public_Static_Transform_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_Transform>.NativeClassPtr, 100663340);
		SA_Extensions_Transform.NativeMethodInfoPtr_GetRendererBounds_Public_Static_Bounds_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_Transform>.NativeClassPtr, 100663341);
		SA_Extensions_Transform.NativeMethodInfoPtr_GetVertex_Public_Static_Vector3_Transform_SA_VertexX_SA_VertexY_SA_VertexZ_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_Transform>.NativeClassPtr, 100663342);
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00004908 File Offset: 0x00002B08
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98400, XrefRangeEnd = 98404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGlobalScale(this Transform transform, Vector3 globalScale)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref globalScale;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_Transform.NativeMethodInfoPtr_SetGlobalScale_Public_Static_Void_Transform_Vector3_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600003F RID: 63 RVA: 0x0000494C File Offset: 0x00002B4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98404, XrefRangeEnd = 98410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Reset(this Transform t)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_Transform.NativeMethodInfoPtr_Reset_Public_Static_Void_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00004984 File Offset: 0x00002B84
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98410, XrefRangeEnd = 98426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Transform Clear(this Transform transform)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_Transform.NativeMethodInfoPtr_Clear_Public_Static_Transform_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}
	}

	// Token: 0x06000041 RID: 65 RVA: 0x000049C8 File Offset: 0x00002BC8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98426, XrefRangeEnd = 98443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Transform FindOrCreateChild(this Transform target, string name)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_Transform.NativeMethodInfoPtr_FindOrCreateChild_Public_Static_Transform_Transform_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00004A20 File Offset: 0x00002C20
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98443, XrefRangeEnd = 98445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Bounds GetRendererBounds(this Transform t)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_Transform.NativeMethodInfoPtr_GetRendererBounds_Public_Static_Bounds_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00004A64 File Offset: 0x00002C64
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98445, XrefRangeEnd = 98457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 GetVertex(this Transform t, SA_VertexX x, SA_VertexY y, SA_VertexZ z)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_Transform.NativeMethodInfoPtr_GetVertex_Public_Static_Vector3_Transform_SA_VertexX_SA_VertexY_SA_VertexZ_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000044 RID: 68 RVA: 0x0000216C File Offset: 0x0000036C
	public SA_Extensions_Transform(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000029 RID: 41
	private static readonly IntPtr NativeMethodInfoPtr_SetGlobalScale_Public_Static_Void_Transform_Vector3_0;

	// Token: 0x0400002A RID: 42
	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Static_Void_Transform_0;

	// Token: 0x0400002B RID: 43
	private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Static_Transform_Transform_0;

	// Token: 0x0400002C RID: 44
	private static readonly IntPtr NativeMethodInfoPtr_FindOrCreateChild_Public_Static_Transform_Transform_String_0;

	// Token: 0x0400002D RID: 45
	private static readonly IntPtr NativeMethodInfoPtr_GetRendererBounds_Public_Static_Bounds_Transform_0;

	// Token: 0x0400002E RID: 46
	private static readonly IntPtr NativeMethodInfoPtr_GetVertex_Public_Static_Vector3_Transform_SA_VertexX_SA_VertexY_SA_VertexZ_0;
}
