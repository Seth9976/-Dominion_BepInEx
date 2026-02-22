using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Token: 0x020000BF RID: 191
public class UI_DropTarget : MonoBehaviour
{
	// Token: 0x06001731 RID: 5937 RVA: 0x00060130 File Offset: 0x0005E330
	// Note: this type is marked as 'beforefieldinit'.
	static UI_DropTarget()
	{
		Il2CppClassPointerStore<UI_DropTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_DropTarget");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_DropTarget>.NativeClassPtr);
		UI_DropTarget.NativeFieldInfoPtr_targetObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DropTarget>.NativeClassPtr, "targetObject");
		UI_DropTarget.NativeFieldInfoPtr_normalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DropTarget>.NativeClassPtr, "normalColor");
		UI_DropTarget.NativeFieldInfoPtr_highlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DropTarget>.NativeClassPtr, "highlightColor");
		UI_DropTarget.NativeFieldInfoPtr_currentTargetColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DropTarget>.NativeClassPtr, "currentTargetColor");
		UI_DropTarget.NativeFieldInfoPtr_reparentTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DropTarget>.NativeClassPtr, "reparentTarget");
		UI_DropTarget.NativeFieldInfoPtr_m_OnDropEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DropTarget>.NativeClassPtr, "m_OnDropEvent");
		UI_DropTarget.NativeFieldInfoPtr_m_OnColorChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DropTarget>.NativeClassPtr, "m_OnColorChangeEvent");
		UI_DropTarget.NativeFieldInfoPtr_m_OnPointerEnterEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DropTarget>.NativeClassPtr, "m_OnPointerEnterEvent");
		UI_DropTarget.NativeFieldInfoPtr_m_OnPointerExitEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DropTarget>.NativeClassPtr, "m_OnPointerExitEvent");
		UI_DropTarget.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DropTarget>.NativeClassPtr, 100665146);
		UI_DropTarget.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DropTarget>.NativeClassPtr, 100665147);
		UI_DropTarget.NativeMethodInfoPtr_OnDrop_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DropTarget>.NativeClassPtr, 100665148);
		UI_DropTarget.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DropTarget>.NativeClassPtr, 100665149);
		UI_DropTarget.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DropTarget>.NativeClassPtr, 100665150);
		UI_DropTarget.NativeMethodInfoPtr_GetDroppedObject_Private_UI_DragSource_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DropTarget>.NativeClassPtr, 100665151);
		UI_DropTarget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DropTarget>.NativeClassPtr, 100665152);
	}

	// Token: 0x06001732 RID: 5938 RVA: 0x000602A0 File Offset: 0x0005E4A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248136, XrefRangeEnd = 248141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_DropTarget.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001733 RID: 5939 RVA: 0x000602DC File Offset: 0x0005E4DC
	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DropTarget.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001734 RID: 5940 RVA: 0x00060310 File Offset: 0x0005E510
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248141, XrefRangeEnd = 248155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnDrop(PointerEventData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DropTarget.NativeMethodInfoPtr_OnDrop_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001735 RID: 5941 RVA: 0x00060354 File Offset: 0x0005E554
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248155, XrefRangeEnd = 248166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnPointerEnter(PointerEventData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DropTarget.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001736 RID: 5942 RVA: 0x00060398 File Offset: 0x0005E598
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248166, XrefRangeEnd = 248173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnPointerExit(PointerEventData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DropTarget.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001737 RID: 5943 RVA: 0x000603DC File Offset: 0x0005E5DC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 248183, RefRangeEnd = 248185, XrefRangeStart = 248173, XrefRangeEnd = 248183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_DragSource GetDroppedObject(PointerEventData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DropTarget.NativeMethodInfoPtr_GetDroppedObject_Private_UI_DragSource_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UI_DragSource>(intPtr3) : null;
		}
	}

	// Token: 0x06001738 RID: 5944 RVA: 0x0006042C File Offset: 0x0005E62C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248185, XrefRangeEnd = 248204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_DropTarget()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_DropTarget>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DropTarget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001739 RID: 5945 RVA: 0x0000EFCD File Offset: 0x0000D1CD
	public UI_DropTarget(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000763 RID: 1891
	// (get) Token: 0x0600173A RID: 5946 RVA: 0x00060468 File Offset: 0x0005E668
	// (set) Token: 0x0600173B RID: 5947 RVA: 0x0000EFD6 File Offset: 0x0000D1D6
	public unsafe GameObject targetObject
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DropTarget.NativeFieldInfoPtr_targetObject);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DropTarget.NativeFieldInfoPtr_targetObject), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000764 RID: 1892
	// (get) Token: 0x0600173C RID: 5948 RVA: 0x00060498 File Offset: 0x0005E698
	// (set) Token: 0x0600173D RID: 5949 RVA: 0x0000EFF5 File Offset: 0x0000D1F5
	public unsafe Color normalColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DropTarget.NativeFieldInfoPtr_normalColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DropTarget.NativeFieldInfoPtr_normalColor)) = value;
		}
	}

	// Token: 0x17000765 RID: 1893
	// (get) Token: 0x0600173E RID: 5950 RVA: 0x000604C0 File Offset: 0x0005E6C0
	// (set) Token: 0x0600173F RID: 5951 RVA: 0x0000F010 File Offset: 0x0000D210
	public unsafe Color highlightColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DropTarget.NativeFieldInfoPtr_highlightColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DropTarget.NativeFieldInfoPtr_highlightColor)) = value;
		}
	}

	// Token: 0x17000766 RID: 1894
	// (get) Token: 0x06001740 RID: 5952 RVA: 0x000604E8 File Offset: 0x0005E6E8
	// (set) Token: 0x06001741 RID: 5953 RVA: 0x0000F02B File Offset: 0x0000D22B
	public unsafe Color currentTargetColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DropTarget.NativeFieldInfoPtr_currentTargetColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DropTarget.NativeFieldInfoPtr_currentTargetColor)) = value;
		}
	}

	// Token: 0x17000767 RID: 1895
	// (get) Token: 0x06001742 RID: 5954 RVA: 0x00060510 File Offset: 0x0005E710
	// (set) Token: 0x06001743 RID: 5955 RVA: 0x0000F046 File Offset: 0x0000D246
	public unsafe Transform reparentTarget
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DropTarget.NativeFieldInfoPtr_reparentTarget);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DropTarget.NativeFieldInfoPtr_reparentTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000768 RID: 1896
	// (get) Token: 0x06001744 RID: 5956 RVA: 0x00060540 File Offset: 0x0005E740
	// (set) Token: 0x06001745 RID: 5957 RVA: 0x0000F065 File Offset: 0x0000D265
	public unsafe UI_DropTarget.DropObjectEvent m_OnDropEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DropTarget.NativeFieldInfoPtr_m_OnDropEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_DropTarget.DropObjectEvent>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DropTarget.NativeFieldInfoPtr_m_OnDropEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000769 RID: 1897
	// (get) Token: 0x06001746 RID: 5958 RVA: 0x00060570 File Offset: 0x0005E770
	// (set) Token: 0x06001747 RID: 5959 RVA: 0x0000F084 File Offset: 0x0000D284
	public unsafe UI_DropTarget.TargetColorChangeEvent m_OnColorChangeEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DropTarget.NativeFieldInfoPtr_m_OnColorChangeEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_DropTarget.TargetColorChangeEvent>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DropTarget.NativeFieldInfoPtr_m_OnColorChangeEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700076A RID: 1898
	// (get) Token: 0x06001748 RID: 5960 RVA: 0x000605A0 File Offset: 0x0005E7A0
	// (set) Token: 0x06001749 RID: 5961 RVA: 0x0000F0A3 File Offset: 0x0000D2A3
	public unsafe UI_DropTarget.PointerEnterEvent m_OnPointerEnterEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DropTarget.NativeFieldInfoPtr_m_OnPointerEnterEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_DropTarget.PointerEnterEvent>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DropTarget.NativeFieldInfoPtr_m_OnPointerEnterEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700076B RID: 1899
	// (get) Token: 0x0600174A RID: 5962 RVA: 0x000605D0 File Offset: 0x0005E7D0
	// (set) Token: 0x0600174B RID: 5963 RVA: 0x0000F0C2 File Offset: 0x0000D2C2
	public unsafe UI_DropTarget.PointerExitEvent m_OnPointerExitEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DropTarget.NativeFieldInfoPtr_m_OnPointerExitEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_DropTarget.PointerExitEvent>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DropTarget.NativeFieldInfoPtr_m_OnPointerExitEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000FF2 RID: 4082
	private static readonly IntPtr NativeFieldInfoPtr_targetObject;

	// Token: 0x04000FF3 RID: 4083
	private static readonly IntPtr NativeFieldInfoPtr_normalColor;

	// Token: 0x04000FF4 RID: 4084
	private static readonly IntPtr NativeFieldInfoPtr_highlightColor;

	// Token: 0x04000FF5 RID: 4085
	private static readonly IntPtr NativeFieldInfoPtr_currentTargetColor;

	// Token: 0x04000FF6 RID: 4086
	private static readonly IntPtr NativeFieldInfoPtr_reparentTarget;

	// Token: 0x04000FF7 RID: 4087
	private static readonly IntPtr NativeFieldInfoPtr_m_OnDropEvent;

	// Token: 0x04000FF8 RID: 4088
	private static readonly IntPtr NativeFieldInfoPtr_m_OnColorChangeEvent;

	// Token: 0x04000FF9 RID: 4089
	private static readonly IntPtr NativeFieldInfoPtr_m_OnPointerEnterEvent;

	// Token: 0x04000FFA RID: 4090
	private static readonly IntPtr NativeFieldInfoPtr_m_OnPointerExitEvent;

	// Token: 0x04000FFB RID: 4091
	private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

	// Token: 0x04000FFC RID: 4092
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

	// Token: 0x04000FFD RID: 4093
	private static readonly IntPtr NativeMethodInfoPtr_OnDrop_Public_Virtual_Final_New_Void_PointerEventData_0;

	// Token: 0x04000FFE RID: 4094
	private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;

	// Token: 0x04000FFF RID: 4095
	private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;

	// Token: 0x04001000 RID: 4096
	private static readonly IntPtr NativeMethodInfoPtr_GetDroppedObject_Private_UI_DragSource_PointerEventData_0;

	// Token: 0x04001001 RID: 4097
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001DB RID: 475
	[Serializable]
	public class DropObjectEvent : UnityEvent<UI_DragSource, UI_DropTarget>
	{
		// Token: 0x060026EF RID: 9967 RVA: 0x0001801B File Offset: 0x0001621B
		// Note: this type is marked as 'beforefieldinit'.
		static DropObjectEvent()
		{
			Il2CppClassPointerStore<UI_DropTarget.DropObjectEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_DropTarget>.NativeClassPtr, "DropObjectEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_DropTarget.DropObjectEvent>.NativeClassPtr);
			UI_DropTarget.DropObjectEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DropTarget.DropObjectEvent>.NativeClassPtr, 100666382);
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x0008E920 File Offset: 0x0008CB20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248123, RefRangeEnd = 248124, XrefRangeStart = 248120, XrefRangeEnd = 248123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DropObjectEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_DropTarget.DropObjectEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DropTarget.DropObjectEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x0001804F File Offset: 0x0001624F
		public DropObjectEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001AE6 RID: 6886
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}

	// Token: 0x020001DC RID: 476
	[Serializable]
	public class TargetColorChangeEvent : UnityEvent<UI_DropTarget, Color>
	{
		// Token: 0x060026F2 RID: 9970 RVA: 0x00018058 File Offset: 0x00016258
		// Note: this type is marked as 'beforefieldinit'.
		static TargetColorChangeEvent()
		{
			Il2CppClassPointerStore<UI_DropTarget.TargetColorChangeEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_DropTarget>.NativeClassPtr, "TargetColorChangeEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_DropTarget.TargetColorChangeEvent>.NativeClassPtr);
			UI_DropTarget.TargetColorChangeEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DropTarget.TargetColorChangeEvent>.NativeClassPtr, 100666383);
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x0008E95C File Offset: 0x0008CB5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248127, RefRangeEnd = 248128, XrefRangeStart = 248124, XrefRangeEnd = 248127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetColorChangeEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_DropTarget.TargetColorChangeEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DropTarget.TargetColorChangeEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x0001808C File Offset: 0x0001628C
		public TargetColorChangeEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001AE7 RID: 6887
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}

	// Token: 0x020001DD RID: 477
	[Serializable]
	public class PointerEnterEvent : UnityEvent<UI_DropTarget>
	{
		// Token: 0x060026F5 RID: 9973 RVA: 0x00018095 File Offset: 0x00016295
		// Note: this type is marked as 'beforefieldinit'.
		static PointerEnterEvent()
		{
			Il2CppClassPointerStore<UI_DropTarget.PointerEnterEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_DropTarget>.NativeClassPtr, "PointerEnterEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_DropTarget.PointerEnterEvent>.NativeClassPtr);
			UI_DropTarget.PointerEnterEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DropTarget.PointerEnterEvent>.NativeClassPtr, 100666384);
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x0008E998 File Offset: 0x0008CB98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248131, RefRangeEnd = 248132, XrefRangeStart = 248128, XrefRangeEnd = 248131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEnterEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_DropTarget.PointerEnterEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DropTarget.PointerEnterEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026F7 RID: 9975 RVA: 0x000180C9 File Offset: 0x000162C9
		public PointerEnterEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001AE8 RID: 6888
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}

	// Token: 0x020001DE RID: 478
	[Serializable]
	public class PointerExitEvent : UnityEvent<UI_DropTarget>
	{
		// Token: 0x060026F8 RID: 9976 RVA: 0x000180D2 File Offset: 0x000162D2
		// Note: this type is marked as 'beforefieldinit'.
		static PointerExitEvent()
		{
			Il2CppClassPointerStore<UI_DropTarget.PointerExitEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_DropTarget>.NativeClassPtr, "PointerExitEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_DropTarget.PointerExitEvent>.NativeClassPtr);
			UI_DropTarget.PointerExitEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DropTarget.PointerExitEvent>.NativeClassPtr, 100666385);
		}

		// Token: 0x060026F9 RID: 9977 RVA: 0x0008E9D4 File Offset: 0x0008CBD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248135, RefRangeEnd = 248136, XrefRangeStart = 248132, XrefRangeEnd = 248135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerExitEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_DropTarget.PointerExitEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DropTarget.PointerExitEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026FA RID: 9978 RVA: 0x00018106 File Offset: 0x00016306
		public PointerExitEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001AE9 RID: 6889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
