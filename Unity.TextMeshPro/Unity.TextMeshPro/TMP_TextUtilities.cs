using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000070 RID: 112
	public static class TMP_TextUtilities : global::Il2CppSystem.Object
	{
		// Token: 0x06000E12 RID: 3602 RVA: 0x00039070 File Offset: 0x00037270
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_TextUtilities()
		{
			Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_TextUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr);
			TMP_TextUtilities.NativeFieldInfoPtr_m_rectWorldCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, "m_rectWorldCorners");
			TMP_TextUtilities.NativeFieldInfoPtr_k_lookupStringL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, "k_lookupStringL");
			TMP_TextUtilities.NativeFieldInfoPtr_k_lookupStringU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, "k_lookupStringU");
			TMP_TextUtilities.NativeMethodInfoPtr_GetCursorIndexFromPosition_Public_Static_Int32_TMP_Text_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664730);
			TMP_TextUtilities.NativeMethodInfoPtr_GetCursorIndexFromPosition_Public_Static_Int32_TMP_Text_Vector3_Camera_byref_CaretPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664731);
			TMP_TextUtilities.NativeMethodInfoPtr_FindNearestLine_Public_Static_Int32_TMP_Text_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664732);
			TMP_TextUtilities.NativeMethodInfoPtr_FindNearestCharacterOnLine_Public_Static_Int32_TMP_Text_Vector3_Int32_Camera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664733);
			TMP_TextUtilities.NativeMethodInfoPtr_IsIntersectingRectTransform_Public_Static_Boolean_RectTransform_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664734);
			TMP_TextUtilities.NativeMethodInfoPtr_FindIntersectingCharacter_Public_Static_Int32_TMP_Text_Vector3_Camera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664735);
			TMP_TextUtilities.NativeMethodInfoPtr_FindNearestCharacter_Public_Static_Int32_TMP_Text_Vector3_Camera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664736);
			TMP_TextUtilities.NativeMethodInfoPtr_FindIntersectingWord_Public_Static_Int32_TMP_Text_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664737);
			TMP_TextUtilities.NativeMethodInfoPtr_FindNearestWord_Public_Static_Int32_TMP_Text_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664738);
			TMP_TextUtilities.NativeMethodInfoPtr_FindIntersectingLine_Public_Static_Int32_TMP_Text_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664739);
			TMP_TextUtilities.NativeMethodInfoPtr_FindIntersectingLink_Public_Static_Int32_TMP_Text_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664740);
			TMP_TextUtilities.NativeMethodInfoPtr_FindNearestLink_Public_Static_Int32_TMP_Text_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664741);
			TMP_TextUtilities.NativeMethodInfoPtr_PointIntersectRectangle_Private_Static_Boolean_Vector3_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664742);
			TMP_TextUtilities.NativeMethodInfoPtr_ScreenPointToWorldPointInRectangle_Public_Static_Boolean_Transform_Vector2_Camera_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664743);
			TMP_TextUtilities.NativeMethodInfoPtr_IntersectLinePlane_Private_Static_Boolean_LineSegment_Vector3_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664744);
			TMP_TextUtilities.NativeMethodInfoPtr_DistanceToLine_Public_Static_Single_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664745);
			TMP_TextUtilities.NativeMethodInfoPtr_ToLowerFast_Public_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664746);
			TMP_TextUtilities.NativeMethodInfoPtr_ToUpperFast_Public_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664747);
			TMP_TextUtilities.NativeMethodInfoPtr_ToUpperASCIIFast_Internal_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664748);
			TMP_TextUtilities.NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664749);
			TMP_TextUtilities.NativeMethodInfoPtr_GetSimpleHashCode_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664750);
			TMP_TextUtilities.NativeMethodInfoPtr_GetSimpleHashCodeLowercase_Public_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664751);
			TMP_TextUtilities.NativeMethodInfoPtr_HexToInt_Public_Static_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664752);
			TMP_TextUtilities.NativeMethodInfoPtr_StringHexToInt_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, 100664753);
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x000392BC File Offset: 0x000374BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149002, XrefRangeEnd = 149011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textComponent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_GetCursorIndexFromPosition_Public_Static_Int32_TMP_Text_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x00039320 File Offset: 0x00037520
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149023, RefRangeEnd = 149024, XrefRangeStart = 149011, XrefRangeEnd = 149023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textComponent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cursor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_GetCursorIndexFromPosition_Public_Static_Int32_TMP_Text_Vector3_Camera_byref_CaretPosition_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00039390 File Offset: 0x00037590
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149033, RefRangeEnd = 149034, XrefRangeStart = 149024, XrefRangeEnd = 149033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindNearestLine_Public_Static_Int32_TMP_Text_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x000393F4 File Offset: 0x000375F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149054, RefRangeEnd = 149055, XrefRangeStart = 149034, XrefRangeEnd = 149054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref visibleOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindNearestCharacterOnLine_Public_Static_Int32_TMP_Text_Vector3_Int32_Camera_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00039474 File Offset: 0x00037674
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149063, RefRangeEnd = 149065, XrefRangeStart = 149055, XrefRangeEnd = 149063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_IsIntersectingRectTransform_Public_Static_Boolean_RectTransform_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x000394D8 File Offset: 0x000376D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149079, RefRangeEnd = 149081, XrefRangeStart = 149065, XrefRangeEnd = 149079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref visibleOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindIntersectingCharacter_Public_Static_Int32_TMP_Text_Vector3_Camera_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00039548 File Offset: 0x00037748
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149102, RefRangeEnd = 149103, XrefRangeStart = 149081, XrefRangeEnd = 149102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref visibleOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindNearestCharacter_Public_Static_Int32_TMP_Text_Vector3_Camera_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x000395B8 File Offset: 0x000377B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149137, RefRangeEnd = 149139, XrefRangeStart = 149103, XrefRangeEnd = 149137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindIntersectingWord_Public_Static_Int32_TMP_Text_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x0003961C File Offset: 0x0003781C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149139, XrefRangeEnd = 149189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindNearestWord_Public_Static_Int32_TMP_Text_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00039680 File Offset: 0x00037880
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149197, RefRangeEnd = 149198, XrefRangeStart = 149189, XrefRangeEnd = 149197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindIntersectingLine_Public_Static_Int32_TMP_Text_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x000396E4 File Offset: 0x000378E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149215, RefRangeEnd = 149217, XrefRangeStart = 149198, XrefRangeEnd = 149215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindIntersectingLink_Public_Static_Int32_TMP_Text_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00039748 File Offset: 0x00037948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149217, XrefRangeEnd = 149265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_FindNearestLink_Public_Static_Int32_TMP_Text_Vector3_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x000397AC File Offset: 0x000379AC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 149266, RefRangeEnd = 149278, XrefRangeStart = 149265, XrefRangeEnd = 149266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_PointIntersectRectangle_Private_Static_Boolean_Vector3_Vector3_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00039824 File Offset: 0x00037A24
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 149290, RefRangeEnd = 149302, XrefRangeStart = 149278, XrefRangeEnd = 149290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &worldPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_ScreenPointToWorldPointInRectangle_Public_Static_Boolean_Transform_Vector2_Camera_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00039894 File Offset: 0x00037A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149302, XrefRangeEnd = 149307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IntersectLinePlane(TMP_TextUtilities.LineSegment line, Vector3 point, Vector3 normal, out Vector3 intersectingPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref line;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normal;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &intersectingPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_IntersectLinePlane_Private_Static_Boolean_LineSegment_Vector3_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x000398FC File Offset: 0x00037AFC
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 149307, RefRangeEnd = 149338, XrefRangeStart = 149307, XrefRangeEnd = 149307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_DistanceToLine_Public_Static_Single_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x00039958 File Offset: 0x00037B58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149341, RefRangeEnd = 149342, XrefRangeStart = 149338, XrefRangeEnd = 149341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToLowerFast(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_ToLowerFast_Public_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x00039998 File Offset: 0x00037B98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149345, RefRangeEnd = 149346, XrefRangeStart = 149342, XrefRangeEnd = 149345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToUpperFast(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_ToUpperFast_Public_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x000399D8 File Offset: 0x00037BD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149349, RefRangeEnd = 149351, XrefRangeStart = 149346, XrefRangeEnd = 149349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUpperASCIIFast(uint c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_ToUpperASCIIFast_Internal_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x00039A18 File Offset: 0x00037C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149351, XrefRangeEnd = 149357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHashCode(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x00039A5C File Offset: 0x00037C5C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 148932, RefRangeEnd = 148936, XrefRangeStart = 148932, XrefRangeEnd = 148936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSimpleHashCode(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_GetSimpleHashCode_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x00039AA0 File Offset: 0x00037CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149357, XrefRangeEnd = 149363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetSimpleHashCodeLowercase(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_GetSimpleHashCodeLowercase_Public_Static_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x00039AE4 File Offset: 0x00037CE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149363, RefRangeEnd = 149364, XrefRangeStart = 149363, XrefRangeEnd = 149363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int HexToInt(char hex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_HexToInt_Public_Static_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x00039B24 File Offset: 0x00037D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149364, XrefRangeEnd = 149371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int StringHexToInt(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.NativeMethodInfoPtr_StringHexToInt_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x00008A8E File Offset: 0x00006C8E
		public TMP_TextUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000E2C RID: 3628 RVA: 0x00039B68 File Offset: 0x00037D68
		// (set) Token: 0x06000E2D RID: 3629 RVA: 0x00008A97 File Offset: 0x00006C97
		public unsafe static Il2CppStructArray<Vector3> m_rectWorldCorners
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_TextUtilities.NativeFieldInfoPtr_m_rectWorldCorners, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_TextUtilities.NativeFieldInfoPtr_m_rectWorldCorners, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x00039B90 File Offset: 0x00037D90
		// (set) Token: 0x06000E2F RID: 3631 RVA: 0x00008AA9 File Offset: 0x00006CA9
		public unsafe static string k_lookupStringL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_TextUtilities.NativeFieldInfoPtr_k_lookupStringL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_TextUtilities.NativeFieldInfoPtr_k_lookupStringL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x00039BB0 File Offset: 0x00037DB0
		// (set) Token: 0x06000E31 RID: 3633 RVA: 0x00008ABB File Offset: 0x00006CBB
		public unsafe static string k_lookupStringU
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_TextUtilities.NativeFieldInfoPtr_k_lookupStringU, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_TextUtilities.NativeFieldInfoPtr_k_lookupStringU, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeFieldInfoPtr_m_rectWorldCorners;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeFieldInfoPtr_k_lookupStringL;

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeFieldInfoPtr_k_lookupStringU;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeMethodInfoPtr_GetCursorIndexFromPosition_Public_Static_Int32_TMP_Text_Vector3_Camera_0;

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeMethodInfoPtr_GetCursorIndexFromPosition_Public_Static_Int32_TMP_Text_Vector3_Camera_byref_CaretPosition_0;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeMethodInfoPtr_FindNearestLine_Public_Static_Int32_TMP_Text_Vector3_Camera_0;

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeMethodInfoPtr_FindNearestCharacterOnLine_Public_Static_Int32_TMP_Text_Vector3_Int32_Camera_Boolean_0;

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeMethodInfoPtr_IsIntersectingRectTransform_Public_Static_Boolean_RectTransform_Vector3_Camera_0;

		// Token: 0x04000B35 RID: 2869
		private static readonly IntPtr NativeMethodInfoPtr_FindIntersectingCharacter_Public_Static_Int32_TMP_Text_Vector3_Camera_Boolean_0;

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeMethodInfoPtr_FindNearestCharacter_Public_Static_Int32_TMP_Text_Vector3_Camera_Boolean_0;

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeMethodInfoPtr_FindIntersectingWord_Public_Static_Int32_TMP_Text_Vector3_Camera_0;

		// Token: 0x04000B38 RID: 2872
		private static readonly IntPtr NativeMethodInfoPtr_FindNearestWord_Public_Static_Int32_TMP_Text_Vector3_Camera_0;

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeMethodInfoPtr_FindIntersectingLine_Public_Static_Int32_TMP_Text_Vector3_Camera_0;

		// Token: 0x04000B3A RID: 2874
		private static readonly IntPtr NativeMethodInfoPtr_FindIntersectingLink_Public_Static_Int32_TMP_Text_Vector3_Camera_0;

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeMethodInfoPtr_FindNearestLink_Public_Static_Int32_TMP_Text_Vector3_Camera_0;

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeMethodInfoPtr_PointIntersectRectangle_Private_Static_Boolean_Vector3_Vector3_Vector3_Vector3_Vector3_0;

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToWorldPointInRectangle_Public_Static_Boolean_Transform_Vector2_Camera_byref_Vector3_0;

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeMethodInfoPtr_IntersectLinePlane_Private_Static_Boolean_LineSegment_Vector3_Vector3_byref_Vector3_0;

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeMethodInfoPtr_DistanceToLine_Public_Static_Single_Vector3_Vector3_Vector3_0;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeMethodInfoPtr_ToLowerFast_Public_Static_Char_Char_0;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperFast_Public_Static_Char_Char_0;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperASCIIFast_Internal_Static_UInt32_UInt32_0;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_String_0;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeMethodInfoPtr_GetSimpleHashCode_Public_Static_Int32_String_0;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeMethodInfoPtr_GetSimpleHashCodeLowercase_Public_Static_UInt32_String_0;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeMethodInfoPtr_HexToInt_Public_Static_Int32_Char_0;

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeMethodInfoPtr_StringHexToInt_Public_Static_Int32_String_0;

		// Token: 0x020000B1 RID: 177
		[StructLayout(2)]
		public struct LineSegment
		{
			// Token: 0x06001017 RID: 4119 RVA: 0x0003F454 File Offset: 0x0003D654
			// Note: this type is marked as 'beforefieldinit'.
			static LineSegment()
			{
				Il2CppClassPointerStore<TMP_TextUtilities.LineSegment>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_TextUtilities>.NativeClassPtr, "LineSegment");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_TextUtilities.LineSegment>.NativeClassPtr);
				TMP_TextUtilities.LineSegment.NativeFieldInfoPtr_Point1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextUtilities.LineSegment>.NativeClassPtr, "Point1");
				TMP_TextUtilities.LineSegment.NativeFieldInfoPtr_Point2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextUtilities.LineSegment>.NativeClassPtr, "Point2");
				TMP_TextUtilities.LineSegment.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextUtilities.LineSegment>.NativeClassPtr, 100664911);
			}

			// Token: 0x06001018 RID: 4120 RVA: 0x0003F4BC File Offset: 0x0003D6BC
			[CallerCount(0)]
			public unsafe LineSegment(Vector3 p1, Vector3 p2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref p1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextUtilities.LineSegment.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001019 RID: 4121 RVA: 0x00009B02 File Offset: 0x00007D02
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextUtilities.LineSegment>.NativeClassPtr, ref this));
			}

			// Token: 0x04000C9C RID: 3228
			private static readonly IntPtr NativeFieldInfoPtr_Point1;

			// Token: 0x04000C9D RID: 3229
			private static readonly IntPtr NativeFieldInfoPtr_Point2;

			// Token: 0x04000C9E RID: 3230
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0;

			// Token: 0x04000C9F RID: 3231
			[FieldOffset(0)]
			public Vector3 Point1;

			// Token: 0x04000CA0 RID: 3232
			[FieldOffset(12)]
			public Vector3 Point2;
		}
	}
}
