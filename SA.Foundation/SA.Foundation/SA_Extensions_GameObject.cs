using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using SA.Foundation.Animation;
using UnityEngine;

// Token: 0x02000005 RID: 5
public static class SA_Extensions_GameObject : global::Il2CppSystem.Object
{
	// Token: 0x06000018 RID: 24 RVA: 0x00003D1C File Offset: 0x00001F1C
	// Note: this type is marked as 'beforefieldinit'.
	static SA_Extensions_GameObject()
	{
		Il2CppClassPointerStore<SA_Extensions_GameObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "", "SA_Extensions_GameObject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Extensions_GameObject>.NativeClassPtr);
		SA_Extensions_GameObject.NativeMethodInfoPtr_Reset_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_GameObject>.NativeClassPtr, 100663312);
		SA_Extensions_GameObject.NativeMethodInfoPtr_Clear_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_GameObject>.NativeClassPtr, 100663313);
		SA_Extensions_GameObject.NativeMethodInfoPtr_RotateTo_Public_Static_Void_GameObject_Vector3_Single_SA_EaseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_GameObject>.NativeClassPtr, 100663314);
		SA_Extensions_GameObject.NativeMethodInfoPtr_RotateTo_Public_Static_Void_GameObject_Object_Vector3_Single_SA_EaseType_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_GameObject>.NativeClassPtr, 100663315);
		SA_Extensions_GameObject.NativeMethodInfoPtr_RotateGameObjectTo_Public_Static_Void_GameObject_Object_Vector3_Single_SA_EaseType_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_GameObject>.NativeClassPtr, 100663316);
		SA_Extensions_GameObject.NativeMethodInfoPtr_MoveTo_Public_Static_Void_GameObject_Vector3_Single_SA_EaseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_GameObject>.NativeClassPtr, 100663317);
		SA_Extensions_GameObject.NativeMethodInfoPtr_MoveTo_Public_Static_Void_GameObject_Object_Vector3_Single_SA_EaseType_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_GameObject>.NativeClassPtr, 100663318);
		SA_Extensions_GameObject.NativeMethodInfoPtr_MoveGameObjectTo_Public_Static_Void_GameObject_Object_Vector3_Single_SA_EaseType_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_GameObject>.NativeClassPtr, 100663319);
		SA_Extensions_GameObject.NativeMethodInfoPtr_ScaleTo_Public_Static_Void_GameObject_Vector3_Single_SA_EaseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_GameObject>.NativeClassPtr, 100663320);
		SA_Extensions_GameObject.NativeMethodInfoPtr_ScaleTo_Public_Static_Void_GameObject_Object_Vector3_Single_SA_EaseType_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_GameObject>.NativeClassPtr, 100663321);
		SA_Extensions_GameObject.NativeMethodInfoPtr_ScaleGameObjectTo_Public_Static_Void_GameObject_Object_Vector3_Single_SA_EaseType_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_GameObject>.NativeClassPtr, 100663322);
		SA_Extensions_GameObject.NativeMethodInfoPtr_GetRendererBounds_Public_Static_Bounds_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_GameObject>.NativeClassPtr, 100663323);
		SA_Extensions_GameObject.NativeMethodInfoPtr_GetVertex_Public_Static_Vector3_GameObject_SA_VertexX_SA_VertexY_SA_VertexZ_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_GameObject>.NativeClassPtr, 100663324);
		SA_Extensions_GameObject.NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Extensions_GameObject>.NativeClassPtr, 100663325);
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00003E64 File Offset: 0x00002064
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98210, XrefRangeEnd = 98217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Reset(this GameObject go)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_GameObject.NativeMethodInfoPtr_Reset_Public_Static_Void_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00003E9C File Offset: 0x0000209C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98217, XrefRangeEnd = 98234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Clear(this GameObject go)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_GameObject.NativeMethodInfoPtr_Clear_Public_Static_Void_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00003ED4 File Offset: 0x000020D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98234, XrefRangeEnd = 98235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RotateTo(this GameObject go, Vector3 eulerRotation, float time, SA_EaseType easeType = SA_EaseType.linear)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eulerRotation;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeType;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_GameObject.NativeMethodInfoPtr_RotateTo_Public_Static_Void_GameObject_Vector3_Single_SA_EaseType_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00003F34 File Offset: 0x00002134
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98235, XrefRangeEnd = 98236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RotateTo(this GameObject go, global::Il2CppSystem.Object callbackTarget, Vector3 eulerRotation, float time, SA_EaseType easeType, Action OnCompleteAction)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callbackTarget);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eulerRotation;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeType;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(OnCompleteAction);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_GameObject.NativeMethodInfoPtr_RotateTo_Public_Static_Void_GameObject_Object_Vector3_Single_SA_EaseType_Action_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00003FBC File Offset: 0x000021BC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 98246, RefRangeEnd = 98248, XrefRangeStart = 98236, XrefRangeEnd = 98246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RotateGameObjectTo(this GameObject go, global::Il2CppSystem.Object callbackTarget, Vector3 eulerRotation, float time, SA_EaseType easeType, Action OnCompleteAction)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callbackTarget);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eulerRotation;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeType;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(OnCompleteAction);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_GameObject.NativeMethodInfoPtr_RotateGameObjectTo_Public_Static_Void_GameObject_Object_Vector3_Single_SA_EaseType_Action_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00004044 File Offset: 0x00002244
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98248, XrefRangeEnd = 98249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MoveTo(this GameObject go, Vector3 position, float time, SA_EaseType easeType = SA_EaseType.linear)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeType;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_GameObject.NativeMethodInfoPtr_MoveTo_Public_Static_Void_GameObject_Vector3_Single_SA_EaseType_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600001F RID: 31 RVA: 0x000040A4 File Offset: 0x000022A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98249, XrefRangeEnd = 98250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MoveTo(this GameObject go, global::Il2CppSystem.Object callbackTarget, Vector3 position, float time, SA_EaseType easeType, Action OnCompleteAction)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callbackTarget);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeType;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(OnCompleteAction);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_GameObject.NativeMethodInfoPtr_MoveTo_Public_Static_Void_GameObject_Object_Vector3_Single_SA_EaseType_Action_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000020 RID: 32 RVA: 0x0000412C File Offset: 0x0000232C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 98260, RefRangeEnd = 98262, XrefRangeStart = 98250, XrefRangeEnd = 98260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MoveGameObjectTo(GameObject go, global::Il2CppSystem.Object callbackTarget, Vector3 position, float time, SA_EaseType easeType, Action OnCompleteAction)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callbackTarget);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeType;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(OnCompleteAction);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_GameObject.NativeMethodInfoPtr_MoveGameObjectTo_Public_Static_Void_GameObject_Object_Vector3_Single_SA_EaseType_Action_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000021 RID: 33 RVA: 0x000041B4 File Offset: 0x000023B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98262, XrefRangeEnd = 98263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScaleTo(this GameObject go, Vector3 scale, float time, SA_EaseType easeType = SA_EaseType.linear)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeType;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_GameObject.NativeMethodInfoPtr_ScaleTo_Public_Static_Void_GameObject_Vector3_Single_SA_EaseType_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00004214 File Offset: 0x00002414
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98263, XrefRangeEnd = 98264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScaleTo(this GameObject go, global::Il2CppSystem.Object callbackTarget, Vector3 scale, float time, SA_EaseType easeType, Action OnCompleteAction)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callbackTarget);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeType;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(OnCompleteAction);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_GameObject.NativeMethodInfoPtr_ScaleTo_Public_Static_Void_GameObject_Object_Vector3_Single_SA_EaseType_Action_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000023 RID: 35 RVA: 0x0000429C File Offset: 0x0000249C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 98274, RefRangeEnd = 98276, XrefRangeStart = 98264, XrefRangeEnd = 98274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScaleGameObjectTo(GameObject go, global::Il2CppSystem.Object callbackTarget, Vector3 scale, float time, SA_EaseType easeType, Action OnCompleteAction)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callbackTarget);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeType;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(OnCompleteAction);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_GameObject.NativeMethodInfoPtr_ScaleGameObjectTo_Public_Static_Void_GameObject_Object_Vector3_Single_SA_EaseType_Action_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00004324 File Offset: 0x00002524
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98276, XrefRangeEnd = 98277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Bounds GetRendererBounds(this GameObject go)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_GameObject.NativeMethodInfoPtr_GetRendererBounds_Public_Static_Bounds_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00004368 File Offset: 0x00002568
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98277, XrefRangeEnd = 98288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 GetVertex(this GameObject go, SA_VertexX x, SA_VertexY y, SA_VertexZ z)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_GameObject.NativeMethodInfoPtr_GetVertex_Public_Static_Vector3_GameObject_SA_VertexX_SA_VertexY_SA_VertexZ_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000026 RID: 38 RVA: 0x000043D4 File Offset: 0x000025D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98288, XrefRangeEnd = 98294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLayerRecursively(this GameObject go, int layerNumber)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerNumber;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Extensions_GameObject.NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000027 RID: 39 RVA: 0x0000208B File Offset: 0x0000028B
	public SA_Extensions_GameObject(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000010 RID: 16
	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Static_Void_GameObject_0;

	// Token: 0x04000011 RID: 17
	private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_GameObject_0;

	// Token: 0x04000012 RID: 18
	private static readonly IntPtr NativeMethodInfoPtr_RotateTo_Public_Static_Void_GameObject_Vector3_Single_SA_EaseType_0;

	// Token: 0x04000013 RID: 19
	private static readonly IntPtr NativeMethodInfoPtr_RotateTo_Public_Static_Void_GameObject_Object_Vector3_Single_SA_EaseType_Action_0;

	// Token: 0x04000014 RID: 20
	private static readonly IntPtr NativeMethodInfoPtr_RotateGameObjectTo_Public_Static_Void_GameObject_Object_Vector3_Single_SA_EaseType_Action_0;

	// Token: 0x04000015 RID: 21
	private static readonly IntPtr NativeMethodInfoPtr_MoveTo_Public_Static_Void_GameObject_Vector3_Single_SA_EaseType_0;

	// Token: 0x04000016 RID: 22
	private static readonly IntPtr NativeMethodInfoPtr_MoveTo_Public_Static_Void_GameObject_Object_Vector3_Single_SA_EaseType_Action_0;

	// Token: 0x04000017 RID: 23
	private static readonly IntPtr NativeMethodInfoPtr_MoveGameObjectTo_Public_Static_Void_GameObject_Object_Vector3_Single_SA_EaseType_Action_0;

	// Token: 0x04000018 RID: 24
	private static readonly IntPtr NativeMethodInfoPtr_ScaleTo_Public_Static_Void_GameObject_Vector3_Single_SA_EaseType_0;

	// Token: 0x04000019 RID: 25
	private static readonly IntPtr NativeMethodInfoPtr_ScaleTo_Public_Static_Void_GameObject_Object_Vector3_Single_SA_EaseType_Action_0;

	// Token: 0x0400001A RID: 26
	private static readonly IntPtr NativeMethodInfoPtr_ScaleGameObjectTo_Public_Static_Void_GameObject_Object_Vector3_Single_SA_EaseType_Action_0;

	// Token: 0x0400001B RID: 27
	private static readonly IntPtr NativeMethodInfoPtr_GetRendererBounds_Public_Static_Bounds_GameObject_0;

	// Token: 0x0400001C RID: 28
	private static readonly IntPtr NativeMethodInfoPtr_GetVertex_Public_Static_Vector3_GameObject_SA_VertexX_SA_VertexY_SA_VertexZ_0;

	// Token: 0x0400001D RID: 29
	private static readonly IntPtr NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0;
}
