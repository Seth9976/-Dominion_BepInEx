using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000021 RID: 33
	public sealed class SliderHandler : ValueType
	{
		// Token: 0x06000547 RID: 1351 RVA: 0x00013B54 File Offset: 0x00011D54
		// Note: this type is marked as 'beforefieldinit'.
		static SliderHandler()
		{
			Il2CppClassPointerStore<SliderHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "SliderHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr);
			SliderHandler.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, "position");
			SliderHandler.NativeFieldInfoPtr_currentValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, "currentValue");
			SliderHandler.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, "size");
			SliderHandler.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, "start");
			SliderHandler.NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, "end");
			SliderHandler.NativeFieldInfoPtr_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, "slider");
			SliderHandler.NativeFieldInfoPtr_thumb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, "thumb");
			SliderHandler.NativeFieldInfoPtr_thumbExtent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, "thumbExtent");
			SliderHandler.NativeFieldInfoPtr_horiz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, "horiz");
			SliderHandler.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, "id");
			SliderHandler.NativeMethodInfoPtr__ctor_Public_Void_Rect_Single_Single_Single_Single_GUIStyle_GUIStyle_Boolean_Int32_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663707);
			SliderHandler.NativeMethodInfoPtr_Handle_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663708);
			SliderHandler.NativeMethodInfoPtr_OnMouseDown_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663709);
			SliderHandler.NativeMethodInfoPtr_OnMouseDrag_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663710);
			SliderHandler.NativeMethodInfoPtr_OnMouseUp_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663711);
			SliderHandler.NativeMethodInfoPtr_OnRepaint_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663712);
			SliderHandler.NativeMethodInfoPtr_CurrentEventType_Private_EventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663713);
			SliderHandler.NativeMethodInfoPtr_CurrentScrollTroughSide_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663714);
			SliderHandler.NativeMethodInfoPtr_IsEmptySlider_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663715);
			SliderHandler.NativeMethodInfoPtr_SupportsPageMovements_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663716);
			SliderHandler.NativeMethodInfoPtr_PageMovementValue_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663717);
			SliderHandler.NativeMethodInfoPtr_PageUpMovementBound_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663718);
			SliderHandler.NativeMethodInfoPtr_CurrentEvent_Private_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663719);
			SliderHandler.NativeMethodInfoPtr_ValueForCurrentMousePosition_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663720);
			SliderHandler.NativeMethodInfoPtr_Clamp_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663721);
			SliderHandler.NativeMethodInfoPtr_ThumbSelectionRect_Private_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663722);
			SliderHandler.NativeMethodInfoPtr_StartDraggingWithValue_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663723);
			SliderHandler.NativeMethodInfoPtr_SliderState_Private_SliderState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663724);
			SliderHandler.NativeMethodInfoPtr_ThumbExtRect_Private_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663725);
			SliderHandler.NativeMethodInfoPtr_ThumbRect_Private_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663726);
			SliderHandler.NativeMethodInfoPtr_VerticalThumbRect_Private_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663727);
			SliderHandler.NativeMethodInfoPtr_HorizontalThumbRect_Private_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663728);
			SliderHandler.NativeMethodInfoPtr_ClampedCurrentValue_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663729);
			SliderHandler.NativeMethodInfoPtr_MousePosition_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663730);
			SliderHandler.NativeMethodInfoPtr_ValuesPerPixel_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663731);
			SliderHandler.NativeMethodInfoPtr_ThumbSize_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663732);
			SliderHandler.NativeMethodInfoPtr_MaxValue_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663733);
			SliderHandler.NativeMethodInfoPtr_MinValue_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr, 100663734);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00013E7C File Offset: 0x0001207C
		[CallerCount(0)]
		public unsafe SliderHandler(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(slider);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thumb);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref horiz;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thumbExtent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr__ctor_Public_Void_Rect_Single_Single_Single_Single_GUIStyle_GUIStyle_Boolean_Int32_GUIStyle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00013F58 File Offset: 0x00012158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88287, XrefRangeEnd = 88290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Handle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_Handle_Public_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00013F9C File Offset: 0x0001219C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88341, RefRangeEnd = 88342, XrefRangeStart = 88290, XrefRangeEnd = 88341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float OnMouseDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_OnMouseDown_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00013FE0 File Offset: 0x000121E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 88356, RefRangeEnd = 88358, XrefRangeStart = 88342, XrefRangeEnd = 88356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float OnMouseDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_OnMouseDrag_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00014024 File Offset: 0x00012224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88365, RefRangeEnd = 88366, XrefRangeStart = 88358, XrefRangeEnd = 88365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float OnMouseUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_OnMouseUp_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00014068 File Offset: 0x00012268
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 88423, RefRangeEnd = 88426, XrefRangeStart = 88366, XrefRangeEnd = 88423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float OnRepaint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_OnRepaint_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x000140AC File Offset: 0x000122AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88431, RefRangeEnd = 88432, XrefRangeStart = 88426, XrefRangeEnd = 88431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventType CurrentEventType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_CurrentEventType_Private_EventType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x000140F0 File Offset: 0x000122F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88446, RefRangeEnd = 88447, XrefRangeStart = 88432, XrefRangeEnd = 88446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CurrentScrollTroughSide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_CurrentScrollTroughSide_Private_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00014134 File Offset: 0x00012334
		[CallerCount(0)]
		public unsafe bool IsEmptySlider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_IsEmptySlider_Private_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00014178 File Offset: 0x00012378
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 88448, RefRangeEnd = 88450, XrefRangeStart = 88447, XrefRangeEnd = 88448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SupportsPageMovements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_SupportsPageMovements_Private_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x000141BC File Offset: 0x000123BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88450, XrefRangeEnd = 88456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float PageMovementValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_PageMovementValue_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00014200 File Offset: 0x00012400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88459, RefRangeEnd = 88460, XrefRangeStart = 88456, XrefRangeEnd = 88459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float PageUpMovementBound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_PageUpMovementBound_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00014244 File Offset: 0x00012444
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 84392, RefRangeEnd = 84410, XrefRangeStart = 84392, XrefRangeEnd = 84410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Event CurrentEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_CurrentEvent_Private_Event_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Event>(intPtr3) : null;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00014288 File Offset: 0x00012488
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88472, RefRangeEnd = 88473, XrefRangeStart = 88460, XrefRangeEnd = 88472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ValueForCurrentMousePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_ValueForCurrentMousePosition_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x000142CC File Offset: 0x000124CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 88476, RefRangeEnd = 88478, XrefRangeStart = 88473, XrefRangeEnd = 88476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Clamp(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_Clamp_Private_Single_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0001431C File Offset: 0x0001251C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88478, XrefRangeEnd = 88479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect ThumbSelectionRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_ThumbSelectionRect_Private_Rect_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00014360 File Offset: 0x00012560
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88481, RefRangeEnd = 88482, XrefRangeStart = 88479, XrefRangeEnd = 88481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDraggingWithValue(float dragStartValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dragStartValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_StartDraggingWithValue_Private_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x000143A4 File Offset: 0x000125A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 88491, RefRangeEnd = 88493, XrefRangeStart = 88482, XrefRangeEnd = 88491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SliderState SliderState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_SliderState_Private_SliderState_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SliderState>(intPtr3) : null;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x000143E8 File Offset: 0x000125E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88503, RefRangeEnd = 88504, XrefRangeStart = 88493, XrefRangeEnd = 88503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect ThumbExtRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_ThumbExtRect_Private_Rect_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0001442C File Offset: 0x0001262C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88504, XrefRangeEnd = 88505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect ThumbRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_ThumbRect_Private_Rect_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00014470 File Offset: 0x00012670
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 88530, RefRangeEnd = 88538, XrefRangeStart = 88505, XrefRangeEnd = 88530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect VerticalThumbRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_VerticalThumbRect_Private_Rect_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x000144B4 File Offset: 0x000126B4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 88563, RefRangeEnd = 88572, XrefRangeStart = 88538, XrefRangeEnd = 88563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect HorizontalThumbRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_HorizontalThumbRect_Private_Rect_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x000144F8 File Offset: 0x000126F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88575, RefRangeEnd = 88576, XrefRangeStart = 88572, XrefRangeEnd = 88575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ClampedCurrentValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_ClampedCurrentValue_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0001453C File Offset: 0x0001273C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 88581, RefRangeEnd = 88586, XrefRangeStart = 88576, XrefRangeEnd = 88581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float MousePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_MousePosition_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00014580 File Offset: 0x00012780
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 88590, RefRangeEnd = 88594, XrefRangeStart = 88586, XrefRangeEnd = 88590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ValuesPerPixel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_ValuesPerPixel_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x000145C4 File Offset: 0x000127C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 88598, RefRangeEnd = 88601, XrefRangeStart = 88594, XrefRangeEnd = 88598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ThumbSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_ThumbSize_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00014608 File Offset: 0x00012808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88601, XrefRangeEnd = 88602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float MaxValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_MaxValue_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0001464C File Offset: 0x0001284C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88602, XrefRangeEnd = 88603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float MinValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderHandler.NativeMethodInfoPtr_MinValue_Private_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00004465 File Offset: 0x00002665
		public SliderHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0000446E File Offset: 0x0000266E
		public SliderHandler()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SliderHandler>.NativeClassPtr))
		{
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x00014690 File Offset: 0x00012890
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x00004480 File Offset: 0x00002680
		public unsafe Rect position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x000146B8 File Offset: 0x000128B8
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x0000449B File Offset: 0x0000269B
		public unsafe float currentValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_currentValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_currentValue)) = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x000146E0 File Offset: 0x000128E0
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x000044B6 File Offset: 0x000026B6
		public unsafe float size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_size)) = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x00014708 File Offset: 0x00012908
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x000044D1 File Offset: 0x000026D1
		public unsafe float start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_start)) = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x00014730 File Offset: 0x00012930
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x000044EC File Offset: 0x000026EC
		public unsafe float end
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_end);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_end)) = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x00014758 File Offset: 0x00012958
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x00004507 File Offset: 0x00002707
		public unsafe GUIStyle slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x00014788 File Offset: 0x00012988
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x00004526 File Offset: 0x00002726
		public unsafe GUIStyle thumb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_thumb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_thumb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x000147B8 File Offset: 0x000129B8
		// (set) Token: 0x06000575 RID: 1397 RVA: 0x00004545 File Offset: 0x00002745
		public unsafe GUIStyle thumbExtent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_thumbExtent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_thumbExtent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x000147E8 File Offset: 0x000129E8
		// (set) Token: 0x06000577 RID: 1399 RVA: 0x00004564 File Offset: 0x00002764
		public unsafe bool horiz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_horiz);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_horiz)) = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x00014810 File Offset: 0x00012A10
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x0000457F File Offset: 0x0000277F
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderHandler.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeFieldInfoPtr_currentValue;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeFieldInfoPtr_start;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeFieldInfoPtr_end;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeFieldInfoPtr_slider;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeFieldInfoPtr_thumb;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeFieldInfoPtr_thumbExtent;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeFieldInfoPtr_horiz;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Rect_Single_Single_Single_Single_GUIStyle_GUIStyle_Boolean_Int32_GUIStyle_0;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr_Handle_Public_Single_0;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseDown_Private_Single_0;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseDrag_Private_Single_0;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseUp_Private_Single_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr_OnRepaint_Private_Single_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_CurrentEventType_Private_EventType_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_CurrentScrollTroughSide_Private_Int32_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_IsEmptySlider_Private_Boolean_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_SupportsPageMovements_Private_Boolean_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr_PageMovementValue_Private_Single_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr_PageUpMovementBound_Private_Single_0;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_CurrentEvent_Private_Event_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_ValueForCurrentMousePosition_Private_Single_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Private_Single_Single_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_ThumbSelectionRect_Private_Rect_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_StartDraggingWithValue_Private_Void_Single_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_SliderState_Private_SliderState_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_ThumbExtRect_Private_Rect_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_ThumbRect_Private_Rect_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_VerticalThumbRect_Private_Rect_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_HorizontalThumbRect_Private_Rect_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_ClampedCurrentValue_Private_Single_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_MousePosition_Private_Single_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr_ValuesPerPixel_Private_Single_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_ThumbSize_Private_Single_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_MaxValue_Private_Single_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_MinValue_Private_Single_0;
	}
}
