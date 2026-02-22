using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200006A RID: 106
	public class PointerInputModule : BaseInputModule
	{
		// Token: 0x06000A78 RID: 2680 RVA: 0x0002F934 File Offset: 0x0002DB34
		// Note: this type is marked as 'beforefieldinit'.
		static PointerInputModule()
		{
			Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "PointerInputModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr);
			PointerInputModule.NativeFieldInfoPtr_kMouseLeftId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "kMouseLeftId");
			PointerInputModule.NativeFieldInfoPtr_kMouseRightId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "kMouseRightId");
			PointerInputModule.NativeFieldInfoPtr_kMouseMiddleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "kMouseMiddleId");
			PointerInputModule.NativeFieldInfoPtr_kFakeTouchesId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "kFakeTouchesId");
			PointerInputModule.NativeFieldInfoPtr_m_PointerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "m_PointerData");
			PointerInputModule.NativeFieldInfoPtr_m_MouseState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "m_MouseState");
			PointerInputModule.NativeMethodInfoPtr_GetPointerData_Protected_Boolean_Int32_byref_PointerEventData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664832);
			PointerInputModule.NativeMethodInfoPtr_RemovePointerData_Protected_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664833);
			PointerInputModule.NativeMethodInfoPtr_GetTouchPointerEventData_Protected_PointerEventData_Touch_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664834);
			PointerInputModule.NativeMethodInfoPtr_CopyFromTo_Protected_Void_PointerEventData_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664835);
			PointerInputModule.NativeMethodInfoPtr_StateForMouseButton_Protected_FramePressState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664836);
			PointerInputModule.NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664837);
			PointerInputModule.NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664838);
			PointerInputModule.NativeMethodInfoPtr_GetLastPointerEventData_Protected_PointerEventData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664839);
			PointerInputModule.NativeMethodInfoPtr_ShouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664840);
			PointerInputModule.NativeMethodInfoPtr_ProcessMove_Protected_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664841);
			PointerInputModule.NativeMethodInfoPtr_ProcessDrag_Protected_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664842);
			PointerInputModule.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664843);
			PointerInputModule.NativeMethodInfoPtr_ClearSelection_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664844);
			PointerInputModule.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664845);
			PointerInputModule.NativeMethodInfoPtr_DeselectIfSelectionChanged_Protected_Void_GameObject_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664846);
			PointerInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100664847);
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0002FB1C File Offset: 0x0002DD1C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 122341, RefRangeEnd = 122347, XrefRangeStart = 122336, XrefRangeEnd = 122341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetPointerData(int id, out PointerEventData data, bool create)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref create;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_GetPointerData_Protected_Boolean_Int32_byref_PointerEventData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : new PointerEventData(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0002FB98 File Offset: 0x0002DD98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 122351, RefRangeEnd = 122353, XrefRangeStart = 122347, XrefRangeEnd = 122351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePointerData(PointerEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_RemovePointerData_Protected_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x0002FBDC File Offset: 0x0002DDDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 122378, RefRangeEnd = 122380, XrefRangeStart = 122353, XrefRangeEnd = 122378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pressed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &released;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_GetTouchPointerEventData_Protected_PointerEventData_Touch_byref_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr3) : null;
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x0002FC44 File Offset: 0x0002DE44
		[CallerCount(0)]
		public unsafe void CopyFromTo(PointerEventData from, PointerEventData to)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_CopyFromTo_Protected_Void_PointerEventData_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x0002FC98 File Offset: 0x0002DE98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 122382, RefRangeEnd = 122385, XrefRangeStart = 122380, XrefRangeEnd = 122382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventData.FramePressState StateForMouseButton(int buttonId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_StateForMouseButton_Protected_FramePressState_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x0002FCE4 File Offset: 0x0002DEE4
		[CallerCount(0)]
		public unsafe virtual PointerInputModule.MouseState GetMousePointerEventData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerInputModule.NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerInputModule.MouseState>(intPtr3) : null;
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0002FD30 File Offset: 0x0002DF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122385, XrefRangeEnd = 122405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PointerInputModule.MouseState GetMousePointerEventData(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerInputModule.NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerInputModule.MouseState>(intPtr3) : null;
			}
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x0002FD88 File Offset: 0x0002DF88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122406, RefRangeEnd = 122407, XrefRangeStart = 122405, XrefRangeEnd = 122406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventData GetLastPointerEventData(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_GetLastPointerEventData_Protected_PointerEventData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr3) : null;
			}
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x0002FDD4 File Offset: 0x0002DFD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122407, XrefRangeEnd = 122408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pressPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threshold;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDragThreshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_ShouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x0002FE3C File Offset: 0x0002E03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122408, XrefRangeEnd = 122412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessMove(PointerEventData pointerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerInputModule.NativeMethodInfoPtr_ProcessMove_Protected_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x0002FE8C File Offset: 0x0002E08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122412, XrefRangeEnd = 122457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessDrag(PointerEventData pointerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerInputModule.NativeMethodInfoPtr_ProcessDrag_Protected_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x0002FEDC File Offset: 0x0002E0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122457, XrefRangeEnd = 122459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsPointerOverGameObject(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerInputModule.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x0002FF30 File Offset: 0x0002E130
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 122481, RefRangeEnd = 122483, XrefRangeStart = 122459, XrefRangeEnd = 122481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_ClearSelection_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x0002FF64 File Offset: 0x0002E164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122483, XrefRangeEnd = 122515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerInputModule.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x0002FFA8 File Offset: 0x0002E1A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 122526, RefRangeEnd = 122531, XrefRangeStart = 122515, XrefRangeEnd = 122526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentOverGo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_DeselectIfSelectionChanged_Protected_Void_GameObject_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x0002FFFC File Offset: 0x0002E1FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 122542, RefRangeEnd = 122544, XrefRangeStart = 122531, XrefRangeEnd = 122542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerInputModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00005B99 File Offset: 0x00003D99
		public PointerInputModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x00030038 File Offset: 0x0002E238
		// (set) Token: 0x06000A8B RID: 2699 RVA: 0x00005BA2 File Offset: 0x00003DA2
		public unsafe static int kMouseLeftId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerInputModule.NativeFieldInfoPtr_kMouseLeftId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerInputModule.NativeFieldInfoPtr_kMouseLeftId, (void*)(&value));
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x00030054 File Offset: 0x0002E254
		// (set) Token: 0x06000A8D RID: 2701 RVA: 0x00005BB0 File Offset: 0x00003DB0
		public unsafe static int kMouseRightId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerInputModule.NativeFieldInfoPtr_kMouseRightId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerInputModule.NativeFieldInfoPtr_kMouseRightId, (void*)(&value));
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x00030070 File Offset: 0x0002E270
		// (set) Token: 0x06000A8F RID: 2703 RVA: 0x00005BBE File Offset: 0x00003DBE
		public unsafe static int kMouseMiddleId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerInputModule.NativeFieldInfoPtr_kMouseMiddleId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerInputModule.NativeFieldInfoPtr_kMouseMiddleId, (void*)(&value));
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x0003008C File Offset: 0x0002E28C
		// (set) Token: 0x06000A91 RID: 2705 RVA: 0x00005BCC File Offset: 0x00003DCC
		public unsafe static int kFakeTouchesId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerInputModule.NativeFieldInfoPtr_kFakeTouchesId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerInputModule.NativeFieldInfoPtr_kFakeTouchesId, (void*)(&value));
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x000300A8 File Offset: 0x0002E2A8
		// (set) Token: 0x06000A93 RID: 2707 RVA: 0x00005BDA File Offset: 0x00003DDA
		public unsafe Dictionary<int, PointerEventData> m_PointerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.NativeFieldInfoPtr_m_PointerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, PointerEventData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.NativeFieldInfoPtr_m_PointerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x000300D8 File Offset: 0x0002E2D8
		// (set) Token: 0x06000A95 RID: 2709 RVA: 0x00005BF9 File Offset: 0x00003DF9
		public unsafe PointerInputModule.MouseState m_MouseState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.NativeFieldInfoPtr_m_MouseState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerInputModule.MouseState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.NativeFieldInfoPtr_m_MouseState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeFieldInfoPtr_kMouseLeftId;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeFieldInfoPtr_kMouseRightId;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeFieldInfoPtr_kMouseMiddleId;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeFieldInfoPtr_kFakeTouchesId;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeFieldInfoPtr_m_PointerData;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeFieldInfoPtr_m_MouseState;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr_GetPointerData_Protected_Boolean_Int32_byref_PointerEventData_Boolean_0;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeMethodInfoPtr_RemovePointerData_Protected_Void_PointerEventData_0;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPointerEventData_Protected_PointerEventData_Touch_byref_Boolean_byref_Boolean_0;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeMethodInfoPtr_CopyFromTo_Protected_Void_PointerEventData_PointerEventData_0;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeMethodInfoPtr_StateForMouseButton_Protected_FramePressState_Int32_0;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_0;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_Int32_0;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr_GetLastPointerEventData_Protected_PointerEventData_Int32_0;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeMethodInfoPtr_ShouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMove_Protected_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeMethodInfoPtr_ProcessDrag_Protected_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_Boolean_Int32_0;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeMethodInfoPtr_ClearSelection_Protected_Void_0;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeMethodInfoPtr_DeselectIfSelectionChanged_Protected_Void_GameObject_BaseEventData_0;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020000CF RID: 207
		public class ButtonState : Object
		{
			// Token: 0x06000D55 RID: 3413 RVA: 0x00039064 File Offset: 0x00037264
			// Note: this type is marked as 'beforefieldinit'.
			static ButtonState()
			{
				Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "ButtonState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr);
				PointerInputModule.ButtonState.NativeFieldInfoPtr_m_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr, "m_Button");
				PointerInputModule.ButtonState.NativeFieldInfoPtr_m_EventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr, "m_EventData");
				PointerInputModule.ButtonState.NativeMethodInfoPtr_get_eventData_Public_get_MouseButtonEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr, 100665136);
				PointerInputModule.ButtonState.NativeMethodInfoPtr_set_eventData_Public_set_Void_MouseButtonEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr, 100665137);
				PointerInputModule.ButtonState.NativeMethodInfoPtr_get_button_Public_get_InputButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr, 100665138);
				PointerInputModule.ButtonState.NativeMethodInfoPtr_set_button_Public_set_Void_InputButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr, 100665139);
				PointerInputModule.ButtonState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr, 100665140);
			}

			// Token: 0x1700045C RID: 1116
			// (get) Token: 0x06000D56 RID: 3414 RVA: 0x0003911C File Offset: 0x0003731C
			// (set) Token: 0x06000D57 RID: 3415 RVA: 0x0003915C File Offset: 0x0003735C
			public unsafe PointerInputModule.MouseButtonEventData eventData
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.ButtonState.NativeMethodInfoPtr_get_eventData_Public_get_MouseButtonEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerInputModule.MouseButtonEventData>(intPtr3) : null;
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.ButtonState.NativeMethodInfoPtr_set_eventData_Public_set_Void_MouseButtonEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700045D RID: 1117
			// (get) Token: 0x06000D58 RID: 3416 RVA: 0x000391A0 File Offset: 0x000373A0
			// (set) Token: 0x06000D59 RID: 3417 RVA: 0x000391DC File Offset: 0x000373DC
			public unsafe PointerEventData.InputButton button
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.ButtonState.NativeMethodInfoPtr_get_button_Public_get_InputButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 21534, RefRangeEnd = 21538, XrefRangeStart = 21534, XrefRangeEnd = 21538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.ButtonState.NativeMethodInfoPtr_set_button_Public_set_Void_InputButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000D5A RID: 3418 RVA: 0x0003921C File Offset: 0x0003741C
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ButtonState()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.ButtonState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D5B RID: 3419 RVA: 0x000070C4 File Offset: 0x000052C4
			public ButtonState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700045A RID: 1114
			// (get) Token: 0x06000D5C RID: 3420 RVA: 0x00039258 File Offset: 0x00037458
			// (set) Token: 0x06000D5D RID: 3421 RVA: 0x000070CD File Offset: 0x000052CD
			public unsafe PointerEventData.InputButton m_Button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.ButtonState.NativeFieldInfoPtr_m_Button);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.ButtonState.NativeFieldInfoPtr_m_Button)) = value;
				}
			}

			// Token: 0x1700045B RID: 1115
			// (get) Token: 0x06000D5E RID: 3422 RVA: 0x00039280 File Offset: 0x00037480
			// (set) Token: 0x06000D5F RID: 3423 RVA: 0x000070E8 File Offset: 0x000052E8
			public unsafe PointerInputModule.MouseButtonEventData m_EventData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.ButtonState.NativeFieldInfoPtr_m_EventData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerInputModule.MouseButtonEventData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.ButtonState.NativeFieldInfoPtr_m_EventData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000A62 RID: 2658
			private static readonly IntPtr NativeFieldInfoPtr_m_Button;

			// Token: 0x04000A63 RID: 2659
			private static readonly IntPtr NativeFieldInfoPtr_m_EventData;

			// Token: 0x04000A64 RID: 2660
			private static readonly IntPtr NativeMethodInfoPtr_get_eventData_Public_get_MouseButtonEventData_0;

			// Token: 0x04000A65 RID: 2661
			private static readonly IntPtr NativeMethodInfoPtr_set_eventData_Public_set_Void_MouseButtonEventData_0;

			// Token: 0x04000A66 RID: 2662
			private static readonly IntPtr NativeMethodInfoPtr_get_button_Public_get_InputButton_0;

			// Token: 0x04000A67 RID: 2663
			private static readonly IntPtr NativeMethodInfoPtr_set_button_Public_set_Void_InputButton_0;

			// Token: 0x04000A68 RID: 2664
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000D0 RID: 208
		public class MouseState : Object
		{
			// Token: 0x06000D60 RID: 3424 RVA: 0x000392B0 File Offset: 0x000374B0
			// Note: this type is marked as 'beforefieldinit'.
			static MouseState()
			{
				Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "MouseState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr);
				PointerInputModule.MouseState.NativeFieldInfoPtr_m_TrackedButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr, "m_TrackedButtons");
				PointerInputModule.MouseState.NativeMethodInfoPtr_AnyPressesThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr, 100665141);
				PointerInputModule.MouseState.NativeMethodInfoPtr_AnyReleasesThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr, 100665142);
				PointerInputModule.MouseState.NativeMethodInfoPtr_GetButtonState_Public_ButtonState_InputButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr, 100665143);
				PointerInputModule.MouseState.NativeMethodInfoPtr_SetButtonState_Public_Void_InputButton_FramePressState_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr, 100665144);
				PointerInputModule.MouseState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr, 100665145);
			}

			// Token: 0x06000D61 RID: 3425 RVA: 0x00039354 File Offset: 0x00037554
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122294, XrefRangeEnd = 122297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool AnyPressesThisFrame()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.MouseState.NativeMethodInfoPtr_AnyPressesThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D62 RID: 3426 RVA: 0x00039390 File Offset: 0x00037590
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122297, XrefRangeEnd = 122300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool AnyReleasesThisFrame()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.MouseState.NativeMethodInfoPtr_AnyReleasesThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D63 RID: 3427 RVA: 0x000393CC File Offset: 0x000375CC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 122317, RefRangeEnd = 122324, XrefRangeStart = 122300, XrefRangeEnd = 122317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PointerInputModule.ButtonState GetButtonState(PointerEventData.InputButton button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref button;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.MouseState.NativeMethodInfoPtr_GetButtonState_Public_ButtonState_InputButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerInputModule.ButtonState>(intPtr3) : null;
				}
			}

			// Token: 0x06000D64 RID: 3428 RVA: 0x00039418 File Offset: 0x00037618
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 122325, RefRangeEnd = 122328, XrefRangeStart = 122324, XrefRangeEnd = 122325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetButtonState(PointerEventData.InputButton button, PointerEventData.FramePressState stateForMouseButton, PointerEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref button;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stateForMouseButton;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.MouseState.NativeMethodInfoPtr_SetButtonState_Public_Void_InputButton_FramePressState_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D65 RID: 3429 RVA: 0x00039478 File Offset: 0x00037678
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122335, RefRangeEnd = 122336, XrefRangeStart = 122328, XrefRangeEnd = 122335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MouseState()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.MouseState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D66 RID: 3430 RVA: 0x00007107 File Offset: 0x00005307
			public MouseState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700045E RID: 1118
			// (get) Token: 0x06000D67 RID: 3431 RVA: 0x000394B4 File Offset: 0x000376B4
			// (set) Token: 0x06000D68 RID: 3432 RVA: 0x00007110 File Offset: 0x00005310
			public unsafe List<PointerInputModule.ButtonState> m_TrackedButtons
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.MouseState.NativeFieldInfoPtr_m_TrackedButtons);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PointerInputModule.ButtonState>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.MouseState.NativeFieldInfoPtr_m_TrackedButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000A69 RID: 2665
			private static readonly IntPtr NativeFieldInfoPtr_m_TrackedButtons;

			// Token: 0x04000A6A RID: 2666
			private static readonly IntPtr NativeMethodInfoPtr_AnyPressesThisFrame_Public_Boolean_0;

			// Token: 0x04000A6B RID: 2667
			private static readonly IntPtr NativeMethodInfoPtr_AnyReleasesThisFrame_Public_Boolean_0;

			// Token: 0x04000A6C RID: 2668
			private static readonly IntPtr NativeMethodInfoPtr_GetButtonState_Public_ButtonState_InputButton_0;

			// Token: 0x04000A6D RID: 2669
			private static readonly IntPtr NativeMethodInfoPtr_SetButtonState_Public_Void_InputButton_FramePressState_PointerEventData_0;

			// Token: 0x04000A6E RID: 2670
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000D1 RID: 209
		public class MouseButtonEventData : Object
		{
			// Token: 0x06000D69 RID: 3433 RVA: 0x000394E4 File Offset: 0x000376E4
			// Note: this type is marked as 'beforefieldinit'.
			static MouseButtonEventData()
			{
				Il2CppClassPointerStore<PointerInputModule.MouseButtonEventData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "MouseButtonEventData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerInputModule.MouseButtonEventData>.NativeClassPtr);
				PointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule.MouseButtonEventData>.NativeClassPtr, "buttonState");
				PointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule.MouseButtonEventData>.NativeClassPtr, "buttonData");
				PointerInputModule.MouseButtonEventData.NativeMethodInfoPtr_PressedThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.MouseButtonEventData>.NativeClassPtr, 100665146);
				PointerInputModule.MouseButtonEventData.NativeMethodInfoPtr_ReleasedThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.MouseButtonEventData>.NativeClassPtr, 100665147);
				PointerInputModule.MouseButtonEventData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.MouseButtonEventData>.NativeClassPtr, 100665148);
			}

			// Token: 0x06000D6A RID: 3434 RVA: 0x00039574 File Offset: 0x00037774
			[CallerCount(0)]
			public unsafe bool PressedThisFrame()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.MouseButtonEventData.NativeMethodInfoPtr_PressedThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D6B RID: 3435 RVA: 0x000395B0 File Offset: 0x000377B0
			[CallerCount(0)]
			public unsafe bool ReleasedThisFrame()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.MouseButtonEventData.NativeMethodInfoPtr_ReleasedThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D6C RID: 3436 RVA: 0x000395EC File Offset: 0x000377EC
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MouseButtonEventData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerInputModule.MouseButtonEventData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.MouseButtonEventData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D6D RID: 3437 RVA: 0x0000712F File Offset: 0x0000532F
			public MouseButtonEventData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700045F RID: 1119
			// (get) Token: 0x06000D6E RID: 3438 RVA: 0x00039628 File Offset: 0x00037828
			// (set) Token: 0x06000D6F RID: 3439 RVA: 0x00007138 File Offset: 0x00005338
			public unsafe PointerEventData.FramePressState buttonState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonState);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonState)) = value;
				}
			}

			// Token: 0x17000460 RID: 1120
			// (get) Token: 0x06000D70 RID: 3440 RVA: 0x00039650 File Offset: 0x00037850
			// (set) Token: 0x06000D71 RID: 3441 RVA: 0x00007153 File Offset: 0x00005353
			public unsafe PointerEventData buttonData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000A6F RID: 2671
			private static readonly IntPtr NativeFieldInfoPtr_buttonState;

			// Token: 0x04000A70 RID: 2672
			private static readonly IntPtr NativeFieldInfoPtr_buttonData;

			// Token: 0x04000A71 RID: 2673
			private static readonly IntPtr NativeMethodInfoPtr_PressedThisFrame_Public_Boolean_0;

			// Token: 0x04000A72 RID: 2674
			private static readonly IntPtr NativeMethodInfoPtr_ReleasedThisFrame_Public_Boolean_0;

			// Token: 0x04000A73 RID: 2675
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
