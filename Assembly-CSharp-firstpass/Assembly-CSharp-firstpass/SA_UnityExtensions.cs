using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text.RegularExpressions;
using SA.Common.Animation;
using UnityEngine;

// Token: 0x02000139 RID: 313
public static class SA_UnityExtensions : global::Il2CppSystem.Object
{
	// Token: 0x06001726 RID: 5926 RVA: 0x000668DC File Offset: 0x00064ADC
	// Note: this type is marked as 'beforefieldinit'.
	static SA_UnityExtensions()
	{
		Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SA_UnityExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr);
		SA_UnityExtensions.NativeFieldInfoPtr__regex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, "_regex");
		SA_UnityExtensions.NativeMethodInfoPtr_MoveTo_Public_Static_Void_GameObject_Vector3_Single_EaseType_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666092);
		SA_UnityExtensions.NativeMethodInfoPtr_ScaleTo_Public_Static_Void_GameObject_Vector3_Single_EaseType_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666093);
		SA_UnityExtensions.NativeMethodInfoPtr_GetRealBounds_Public_Static_Bounds_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666094);
		SA_UnityExtensions.NativeMethodInfoPtr_GetRealBounds_Public_Static_Bounds_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666095);
		SA_UnityExtensions.NativeMethodInfoPtr_GetRendererBounds_Public_Static_Bounds_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666096);
		SA_UnityExtensions.NativeMethodInfoPtr_GetVertex_Public_Static_Vector3_GameObject_VertexX_VertexY_VertexZ_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666097);
		SA_UnityExtensions.NativeMethodInfoPtr_Reset0_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666098);
		SA_UnityExtensions.NativeMethodInfoPtr_IsVisibleFrom_Public_Static_Boolean_Renderer_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666099);
		SA_UnityExtensions.NativeMethodInfoPtr_Reset_Public_Static_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666100);
		SA_UnityExtensions.NativeMethodInfoPtr_GetVertex_Public_Static_Vector3_Transform_VertexX_VertexY_VertexZ_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666101);
		SA_UnityExtensions.NativeMethodInfoPtr_Clear_Public_Static_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666102);
		SA_UnityExtensions.NativeMethodInfoPtr_GetVertex_Public_Static_Vector3_Bounds_VertexX_VertexY_VertexZ_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666103);
		SA_UnityExtensions.NativeMethodInfoPtr_SetAlpha_Public_Static_Void_Material_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666104);
		SA_UnityExtensions.NativeMethodInfoPtr_ToSprite_Public_Static_Sprite_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666105);
		SA_UnityExtensions.NativeMethodInfoPtr_Rotate_Public_Static_Texture2D_Texture2D_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666106);
		SA_UnityExtensions.NativeMethodInfoPtr_Reset_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666107);
		SA_UnityExtensions.NativeMethodInfoPtr_ResetXCoord_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666108);
		SA_UnityExtensions.NativeMethodInfoPtr_ResetYCoord_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666109);
		SA_UnityExtensions.NativeMethodInfoPtr_ResetZCoord_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666110);
		SA_UnityExtensions.NativeMethodInfoPtr_Average_Public_Static_Vector3_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666111);
		SA_UnityExtensions.NativeMethodInfoPtr_GetLast_Public_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666112);
		SA_UnityExtensions.NativeMethodInfoPtr_GetFirst_Public_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666113);
		SA_UnityExtensions.NativeMethodInfoPtr_CopyToClipboard_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666114);
		SA_UnityExtensions.NativeMethodInfoPtr_CovertToURI_Public_Static_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666115);
		SA_UnityExtensions.NativeMethodInfoPtr_ParseQueryString_Public_Static_Dictionary_2_String_String_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666116);
		SA_UnityExtensions.NativeMethodInfoPtr_CalculateBounds_Public_Static_Bounds_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_UnityExtensions>.NativeClassPtr, 100666117);
	}

	// Token: 0x06001727 RID: 5927 RVA: 0x00066B28 File Offset: 0x00064D28
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193949, XrefRangeEnd = 193957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MoveTo(this GameObject go, Vector3 position, float time, EaseType easeType = EaseType.linear, Action OnCompleteAction = null)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeType;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(OnCompleteAction);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_MoveTo_Public_Static_Void_GameObject_Vector3_Single_EaseType_Action_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001728 RID: 5928 RVA: 0x00066B9C File Offset: 0x00064D9C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193957, XrefRangeEnd = 193965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScaleTo(this GameObject go, Vector3 scale, float time, EaseType easeType = EaseType.linear, Action OnCompleteAction = null)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref easeType;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(OnCompleteAction);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_ScaleTo_Public_Static_Void_GameObject_Vector3_Single_EaseType_Action_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001729 RID: 5929 RVA: 0x00066C10 File Offset: 0x00064E10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193965, XrefRangeEnd = 193979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Bounds GetRealBounds(this GameObject go)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_GetRealBounds_Public_Static_Bounds_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600172A RID: 5930 RVA: 0x00066C54 File Offset: 0x00064E54
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193979, XrefRangeEnd = 193993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Bounds GetRealBounds(this Component go)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_GetRealBounds_Public_Static_Bounds_Component_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600172B RID: 5931 RVA: 0x00066C98 File Offset: 0x00064E98
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193993, XrefRangeEnd = 193997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Bounds GetRendererBounds(this GameObject go)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_GetRendererBounds_Public_Static_Bounds_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600172C RID: 5932 RVA: 0x00066CDC File Offset: 0x00064EDC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193997, XrefRangeEnd = 194015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 GetVertex(this GameObject go, VertexX x, VertexY y, VertexZ z)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_GetVertex_Public_Static_Vector3_GameObject_VertexX_VertexY_VertexZ_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600172D RID: 5933 RVA: 0x00066D48 File Offset: 0x00064F48
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194015, XrefRangeEnd = 194025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Reset0(this GameObject go)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_Reset0_Public_Static_Void_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600172E RID: 5934 RVA: 0x00066D80 File Offset: 0x00064F80
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_IsVisibleFrom_Public_Static_Boolean_Renderer_Camera_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600172F RID: 5935 RVA: 0x00066DD4 File Offset: 0x00064FD4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Reset(this Transform t)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_Reset_Public_Static_Void_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001730 RID: 5936 RVA: 0x00066E0C File Offset: 0x0006500C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194025, XrefRangeEnd = 194048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 GetVertex(this Transform t, VertexX x, VertexY y, VertexZ z)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_GetVertex_Public_Static_Vector3_Transform_VertexX_VertexY_VertexZ_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001731 RID: 5937 RVA: 0x00066E78 File Offset: 0x00065078
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194048, XrefRangeEnd = 194064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Transform Clear(this Transform transform)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_Clear_Public_Static_Transform_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}
	}

	// Token: 0x06001732 RID: 5938 RVA: 0x00066EBC File Offset: 0x000650BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 GetVertex(this Bounds bounds, VertexX x, VertexY y, VertexZ z)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_GetVertex_Public_Static_Vector3_Bounds_VertexX_VertexY_VertexZ_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001733 RID: 5939 RVA: 0x00066F24 File Offset: 0x00065124
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194064, XrefRangeEnd = 194069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetAlpha(this Material material, float value)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_SetAlpha_Public_Static_Void_Material_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001734 RID: 5940 RVA: 0x00066F68 File Offset: 0x00065168
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite ToSprite(this Texture2D texture)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_ToSprite_Public_Static_Sprite_Texture2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}
	}

	// Token: 0x06001735 RID: 5941 RVA: 0x00066FAC File Offset: 0x000651AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194069, XrefRangeEnd = 194073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D Rotate(this Texture2D texture, float angle)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_Rotate_Public_Static_Texture2D_Texture2D_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
	}

	// Token: 0x06001736 RID: 5942 RVA: 0x00067000 File Offset: 0x00065200
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 Reset(this Vector3 vec)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref vec;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_Reset_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06001737 RID: 5943 RVA: 0x00067040 File Offset: 0x00065240
	[CallerCount(0)]
	public unsafe static Vector3 ResetXCoord(this Vector3 vec)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref vec;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_ResetXCoord_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06001738 RID: 5944 RVA: 0x00067080 File Offset: 0x00065280
	[CallerCount(0)]
	public unsafe static Vector3 ResetYCoord(this Vector3 vec)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref vec;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_ResetYCoord_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06001739 RID: 5945 RVA: 0x000670C0 File Offset: 0x000652C0
	[CallerCount(0)]
	public unsafe static Vector3 ResetZCoord(this Vector3 vec)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref vec;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_ResetZCoord_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600173A RID: 5946 RVA: 0x00067100 File Offset: 0x00065300
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 Average(this Il2CppStructArray<Vector3> f)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_Average_Public_Static_Vector3_Il2CppStructArray_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600173B RID: 5947 RVA: 0x00067144 File Offset: 0x00065344
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetLast(this string source, int count)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_GetLast_Public_Static_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x0600173C RID: 5948 RVA: 0x00067190 File Offset: 0x00065390
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetFirst(this string source, int count)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_GetFirst_Public_Static_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x0600173D RID: 5949 RVA: 0x000671DC File Offset: 0x000653DC
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyToClipboard(this string source)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_CopyToClipboard_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600173E RID: 5950 RVA: 0x00067214 File Offset: 0x00065414
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194073, XrefRangeEnd = 194077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Uri CovertToURI(this string source)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_CovertToURI_Public_Static_Uri_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
		}
	}

	// Token: 0x0600173F RID: 5951 RVA: 0x00067258 File Offset: 0x00065458
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194077, XrefRangeEnd = 194099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<string, string> ParseQueryString(this Uri uri)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_ParseQueryString_Public_Static_Dictionary_2_String_String_Uri_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
		}
	}

	// Token: 0x06001740 RID: 5952 RVA: 0x0006729C File Offset: 0x0006549C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 194117, RefRangeEnd = 194120, XrefRangeStart = 194099, XrefRangeEnd = 194117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Bounds CalculateBounds(GameObject obj)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_UnityExtensions.NativeMethodInfoPtr_CalculateBounds_Public_Static_Bounds_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06001741 RID: 5953 RVA: 0x0000B415 File Offset: 0x00009615
	public SA_UnityExtensions(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700068B RID: 1675
	// (get) Token: 0x06001742 RID: 5954 RVA: 0x000672E0 File Offset: 0x000654E0
	// (set) Token: 0x06001743 RID: 5955 RVA: 0x0000B41E File Offset: 0x0000961E
	public unsafe static Regex _regex
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SA_UnityExtensions.NativeFieldInfoPtr__regex, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SA_UnityExtensions.NativeFieldInfoPtr__regex, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04001177 RID: 4471
	private static readonly IntPtr NativeFieldInfoPtr__regex;

	// Token: 0x04001178 RID: 4472
	private static readonly IntPtr NativeMethodInfoPtr_MoveTo_Public_Static_Void_GameObject_Vector3_Single_EaseType_Action_0;

	// Token: 0x04001179 RID: 4473
	private static readonly IntPtr NativeMethodInfoPtr_ScaleTo_Public_Static_Void_GameObject_Vector3_Single_EaseType_Action_0;

	// Token: 0x0400117A RID: 4474
	private static readonly IntPtr NativeMethodInfoPtr_GetRealBounds_Public_Static_Bounds_GameObject_0;

	// Token: 0x0400117B RID: 4475
	private static readonly IntPtr NativeMethodInfoPtr_GetRealBounds_Public_Static_Bounds_Component_0;

	// Token: 0x0400117C RID: 4476
	private static readonly IntPtr NativeMethodInfoPtr_GetRendererBounds_Public_Static_Bounds_GameObject_0;

	// Token: 0x0400117D RID: 4477
	private static readonly IntPtr NativeMethodInfoPtr_GetVertex_Public_Static_Vector3_GameObject_VertexX_VertexY_VertexZ_0;

	// Token: 0x0400117E RID: 4478
	private static readonly IntPtr NativeMethodInfoPtr_Reset0_Public_Static_Void_GameObject_0;

	// Token: 0x0400117F RID: 4479
	private static readonly IntPtr NativeMethodInfoPtr_IsVisibleFrom_Public_Static_Boolean_Renderer_Camera_0;

	// Token: 0x04001180 RID: 4480
	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Static_Void_Transform_0;

	// Token: 0x04001181 RID: 4481
	private static readonly IntPtr NativeMethodInfoPtr_GetVertex_Public_Static_Vector3_Transform_VertexX_VertexY_VertexZ_0;

	// Token: 0x04001182 RID: 4482
	private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Static_Transform_Transform_0;

	// Token: 0x04001183 RID: 4483
	private static readonly IntPtr NativeMethodInfoPtr_GetVertex_Public_Static_Vector3_Bounds_VertexX_VertexY_VertexZ_0;

	// Token: 0x04001184 RID: 4484
	private static readonly IntPtr NativeMethodInfoPtr_SetAlpha_Public_Static_Void_Material_Single_0;

	// Token: 0x04001185 RID: 4485
	private static readonly IntPtr NativeMethodInfoPtr_ToSprite_Public_Static_Sprite_Texture2D_0;

	// Token: 0x04001186 RID: 4486
	private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Static_Texture2D_Texture2D_Single_0;

	// Token: 0x04001187 RID: 4487
	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Static_Vector3_Vector3_0;

	// Token: 0x04001188 RID: 4488
	private static readonly IntPtr NativeMethodInfoPtr_ResetXCoord_Public_Static_Vector3_Vector3_0;

	// Token: 0x04001189 RID: 4489
	private static readonly IntPtr NativeMethodInfoPtr_ResetYCoord_Public_Static_Vector3_Vector3_0;

	// Token: 0x0400118A RID: 4490
	private static readonly IntPtr NativeMethodInfoPtr_ResetZCoord_Public_Static_Vector3_Vector3_0;

	// Token: 0x0400118B RID: 4491
	private static readonly IntPtr NativeMethodInfoPtr_Average_Public_Static_Vector3_Il2CppStructArray_1_Vector3_0;

	// Token: 0x0400118C RID: 4492
	private static readonly IntPtr NativeMethodInfoPtr_GetLast_Public_Static_String_String_Int32_0;

	// Token: 0x0400118D RID: 4493
	private static readonly IntPtr NativeMethodInfoPtr_GetFirst_Public_Static_String_String_Int32_0;

	// Token: 0x0400118E RID: 4494
	private static readonly IntPtr NativeMethodInfoPtr_CopyToClipboard_Public_Static_Void_String_0;

	// Token: 0x0400118F RID: 4495
	private static readonly IntPtr NativeMethodInfoPtr_CovertToURI_Public_Static_Uri_String_0;

	// Token: 0x04001190 RID: 4496
	private static readonly IntPtr NativeMethodInfoPtr_ParseQueryString_Public_Static_Dictionary_2_String_String_Uri_0;

	// Token: 0x04001191 RID: 4497
	private static readonly IntPtr NativeMethodInfoPtr_CalculateBounds_Public_Static_Bounds_GameObject_0;
}
