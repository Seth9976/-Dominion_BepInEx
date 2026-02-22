using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	public sealed class RectTransformUtility : Object
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00003744 File Offset: 0x00001944
		// Note: this type is marked as 'beforefieldinit'.
		static RectTransformUtility()
		{
			Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIModule.dll", "UnityEngine", "RectTransformUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr);
			RectTransformUtility.NativeFieldInfoPtr_s_Corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, "s_Corners");
			RectTransformUtility.NativeMethodInfoPtr_PixelAdjustPoint_Public_Static_Vector2_Vector2_Transform_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663341);
			RectTransformUtility.NativeMethodInfoPtr_PixelAdjustRect_Public_Static_Rect_RectTransform_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663342);
			RectTransformUtility.NativeMethodInfoPtr_PointInRectangle_Private_Static_Boolean_Vector2_RectTransform_Camera_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663343);
			RectTransformUtility.NativeMethodInfoPtr_RectangleContainsScreenPoint_Public_Static_Boolean_RectTransform_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663344);
			RectTransformUtility.NativeMethodInfoPtr_RectangleContainsScreenPoint_Public_Static_Boolean_RectTransform_Vector2_Camera_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663345);
			RectTransformUtility.NativeMethodInfoPtr_ScreenPointToWorldPointInRectangle_Public_Static_Boolean_RectTransform_Vector2_Camera_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663346);
			RectTransformUtility.NativeMethodInfoPtr_ScreenPointToLocalPointInRectangle_Public_Static_Boolean_RectTransform_Vector2_Camera_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663347);
			RectTransformUtility.NativeMethodInfoPtr_ScreenPointToRay_Public_Static_Ray_Camera_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663348);
			RectTransformUtility.NativeMethodInfoPtr_WorldToScreenPoint_Public_Static_Vector2_Camera_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663349);
			RectTransformUtility.NativeMethodInfoPtr_FlipLayoutOnAxis_Public_Static_Void_RectTransform_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663350);
			RectTransformUtility.NativeMethodInfoPtr_FlipLayoutAxes_Public_Static_Void_RectTransform_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663351);
			RectTransformUtility.NativeMethodInfoPtr_GetTransposed_Private_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663352);
			RectTransformUtility.NativeMethodInfoPtr_PixelAdjustPoint_Injected_Private_Static_Void_byref_Vector2_Transform_Canvas_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663354);
			RectTransformUtility.NativeMethodInfoPtr_PixelAdjustRect_Injected_Private_Static_Void_RectTransform_Canvas_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663355);
			RectTransformUtility.NativeMethodInfoPtr_PointInRectangle_Injected_Private_Static_Boolean_byref_Vector2_RectTransform_Camera_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformUtility>.NativeClassPtr, 100663356);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000038B4 File Offset: 0x00001AB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97556, RefRangeEnd = 97557, XrefRangeStart = 97551, XrefRangeEnd = 97556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementTransform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_PixelAdjustPoint_Public_Static_Vector2_Vector2_Transform_Canvas_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003918 File Offset: 0x00001B18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97562, RefRangeEnd = 97563, XrefRangeStart = 97557, XrefRangeEnd = 97562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_PixelAdjustRect_Public_Static_Rect_RectTransform_Canvas_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000396C File Offset: 0x00001B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97563, XrefRangeEnd = 97568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenPoint;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rect);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_PointInRectangle_Private_Static_Boolean_Vector2_RectTransform_Camera_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000039DC File Offset: 0x00001BDC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 97582, RefRangeEnd = 97588, XrefRangeStart = 97568, XrefRangeEnd = 97582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_RectangleContainsScreenPoint_Public_Static_Boolean_RectTransform_Vector2_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003A40 File Offset: 0x00001C40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 97597, RefRangeEnd = 97599, XrefRangeStart = 97588, XrefRangeEnd = 97597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_RectangleContainsScreenPoint_Public_Static_Boolean_RectTransform_Vector2_Camera_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 97618, RefRangeEnd = 97621, XrefRangeStart = 97599, XrefRangeEnd = 97618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &worldPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_ScreenPointToWorldPointInRectangle_Public_Static_Boolean_RectTransform_Vector2_Camera_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003B20 File Offset: 0x00001D20
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 97626, RefRangeEnd = 97638, XrefRangeStart = 97621, XrefRangeEnd = 97626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &localPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_ScreenPointToLocalPointInRectangle_Public_Static_Boolean_RectTransform_Vector2_Camera_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003B90 File Offset: 0x00001D90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97646, RefRangeEnd = 97647, XrefRangeStart = 97638, XrefRangeEnd = 97646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Ray ScreenPointToRay(Camera cam, Vector2 screenPos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_ScreenPointToRay_Public_Static_Ray_Camera_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003BE0 File Offset: 0x00001DE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 97652, RefRangeEnd = 97655, XrefRangeStart = 97647, XrefRangeEnd = 97652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_WorldToScreenPoint_Public_Static_Vector2_Camera_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003C30 File Offset: 0x00001E30
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 97687, RefRangeEnd = 97692, XrefRangeStart = 97655, XrefRangeEnd = 97687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keepPositioning;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recursive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_FlipLayoutOnAxis_Public_Static_Void_RectTransform_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003C90 File Offset: 0x00001E90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 97722, RefRangeEnd = 97725, XrefRangeStart = 97692, XrefRangeEnd = 97722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keepPositioning;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recursive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_FlipLayoutAxes_Public_Static_Void_RectTransform_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003CE4 File Offset: 0x00001EE4
		[CallerCount(0)]
		public unsafe static Vector2 GetTransposed(Vector2 input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_GetTransposed_Private_Static_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003D24 File Offset: 0x00001F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97725, XrefRangeEnd = 97727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PixelAdjustPoint_Injected(ref Vector2 point, Transform elementTransform, Canvas canvas, out Vector2 ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementTransform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_PixelAdjustPoint_Injected_Private_Static_Void_byref_Vector2_Transform_Canvas_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003D88 File Offset: 0x00001F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97727, XrefRangeEnd = 97729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, out Rect ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_PixelAdjustRect_Injected_Private_Static_Void_RectTransform_Canvas_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003DE0 File Offset: 0x00001FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97729, XrefRangeEnd = 97731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PointInRectangle_Injected(ref Vector2 screenPoint, RectTransform rect, Camera cam, ref Vector4 offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &screenPoint;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rect);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformUtility.NativeMethodInfoPtr_PointInRectangle_Injected_Private_Static_Boolean_byref_Vector2_RectTransform_Camera_byref_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002156 File Offset: 0x00000356
		public RectTransformUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00003E50 File Offset: 0x00002050
		// (set) Token: 0x06000058 RID: 88 RVA: 0x0000215F File Offset: 0x0000035F
		public unsafe static Il2CppStructArray<Vector3> s_Corners
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RectTransformUtility.NativeFieldInfoPtr_s_Corners, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RectTransformUtility.NativeFieldInfoPtr_s_Corners, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003E78 File Offset: 0x00002078
		public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint)
		{
			return RectTransformUtility.RectangleContainsScreenPoint(rect, screenPoint, null);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002171 File Offset: 0x00000371
		public static Bounds CalculateRelativeRectTransformBounds(Transform root, Transform child)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003E94 File Offset: 0x00002094
		public static Bounds CalculateRelativeRectTransformBounds(Transform trans)
		{
			return RectTransformUtility.CalculateRelativeRectTransformBounds(trans, trans);
		}

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_s_Corners;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_PixelAdjustPoint_Public_Static_Vector2_Vector2_Transform_Canvas_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_PixelAdjustRect_Public_Static_Rect_RectTransform_Canvas_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_PointInRectangle_Private_Static_Boolean_Vector2_RectTransform_Camera_Vector4_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_RectangleContainsScreenPoint_Public_Static_Boolean_RectTransform_Vector2_Camera_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_RectangleContainsScreenPoint_Public_Static_Boolean_RectTransform_Vector2_Camera_Vector4_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToWorldPointInRectangle_Public_Static_Boolean_RectTransform_Vector2_Camera_byref_Vector3_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToLocalPointInRectangle_Public_Static_Boolean_RectTransform_Vector2_Camera_byref_Vector2_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToRay_Public_Static_Ray_Camera_Vector2_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_WorldToScreenPoint_Public_Static_Vector2_Camera_Vector3_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_FlipLayoutOnAxis_Public_Static_Void_RectTransform_Int32_Boolean_Boolean_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_FlipLayoutAxes_Public_Static_Void_RectTransform_Boolean_Boolean_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_GetTransposed_Private_Static_Vector2_Vector2_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_PixelAdjustPoint_Injected_Private_Static_Void_byref_Vector2_Transform_Canvas_byref_Vector2_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_PixelAdjustRect_Injected_Private_Static_Void_RectTransform_Canvas_byref_Rect_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_PointInRectangle_Injected_Private_Static_Boolean_byref_Vector2_RectTransform_Camera_byref_Vector4_0;
	}
}
