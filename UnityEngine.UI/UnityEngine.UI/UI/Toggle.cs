using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200003A RID: 58
	public class Toggle : Selectable
	{
		// Token: 0x06000783 RID: 1923 RVA: 0x000244A8 File Offset: 0x000226A8
		// Note: this type is marked as 'beforefieldinit'.
		static Toggle()
		{
			Il2CppClassPointerStore<Toggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Toggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Toggle>.NativeClassPtr);
			Toggle.NativeFieldInfoPtr_toggleTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toggle>.NativeClassPtr, "toggleTransition");
			Toggle.NativeFieldInfoPtr_graphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toggle>.NativeClassPtr, "graphic");
			Toggle.NativeFieldInfoPtr_m_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toggle>.NativeClassPtr, "m_Group");
			Toggle.NativeFieldInfoPtr_onValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toggle>.NativeClassPtr, "onValueChanged");
			Toggle.NativeFieldInfoPtr_m_IsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toggle>.NativeClassPtr, "m_IsOn");
			Toggle.NativeMethodInfoPtr_get_group_Public_get_ToggleGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664410);
			Toggle.NativeMethodInfoPtr_set_group_Public_set_Void_ToggleGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664411);
			Toggle.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664412);
			Toggle.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664413);
			Toggle.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664414);
			Toggle.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664415);
			Toggle.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664416);
			Toggle.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664417);
			Toggle.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664418);
			Toggle.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664419);
			Toggle.NativeMethodInfoPtr_SetToggleGroup_Private_Void_ToggleGroup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664420);
			Toggle.NativeMethodInfoPtr_get_isOn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664421);
			Toggle.NativeMethodInfoPtr_set_isOn_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664422);
			Toggle.NativeMethodInfoPtr_SetIsOnWithoutNotify_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664423);
			Toggle.NativeMethodInfoPtr_Set_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664424);
			Toggle.NativeMethodInfoPtr_PlayEffect_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664425);
			Toggle.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664426);
			Toggle.NativeMethodInfoPtr_InternalToggle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664427);
			Toggle.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664428);
			Toggle.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664429);
			Toggle.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle>.NativeClassPtr, 100664430);
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x000246E0 File Offset: 0x000228E0
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x00024720 File Offset: 0x00022920
		public unsafe ToggleGroup group
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.NativeMethodInfoPtr_get_group_Public_get_ToggleGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ToggleGroup>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119049, XrefRangeEnd = 119051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.NativeMethodInfoPtr_set_group_Public_set_Void_ToggleGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00024764 File Offset: 0x00022964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119051, XrefRangeEnd = 119061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Toggle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Toggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x000247A0 File Offset: 0x000229A0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Rebuild(CanvasUpdate executing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref executing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toggle.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x000247EC File Offset: 0x000229EC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LayoutComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toggle.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00024828 File Offset: 0x00022A28
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GraphicUpdateComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toggle.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00024864 File Offset: 0x00022A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119061, XrefRangeEnd = 119066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toggle.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x000248A0 File Offset: 0x00022AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119066, XrefRangeEnd = 119069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toggle.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x000248DC File Offset: 0x00022ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119069, XrefRangeEnd = 119071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toggle.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00024918 File Offset: 0x00022B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119071, XrefRangeEnd = 119081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toggle.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00024954 File Offset: 0x00022B54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 119104, RefRangeEnd = 119107, XrefRangeStart = 119081, XrefRangeEnd = 119104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newGroup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setMemberValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.NativeMethodInfoPtr_SetToggleGroup_Private_Void_ToggleGroup_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x000249A4 File Offset: 0x00022BA4
		// (set) Token: 0x06000790 RID: 1936 RVA: 0x000249E0 File Offset: 0x00022BE0
		public unsafe bool isOn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.NativeMethodInfoPtr_get_isOn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(108)]
			[CachedScanResults(RefRangeStart = 119108, RefRangeEnd = 119216, XrefRangeStart = 119107, XrefRangeEnd = 119108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.NativeMethodInfoPtr_set_isOn_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00024A20 File Offset: 0x00022C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119216, XrefRangeEnd = 119217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOnWithoutNotify(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.NativeMethodInfoPtr_SetIsOnWithoutNotify_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00024A60 File Offset: 0x00022C60
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 119231, RefRangeEnd = 119242, XrefRangeStart = 119217, XrefRangeEnd = 119231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(bool value, bool sendCallback = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendCallback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.NativeMethodInfoPtr_Set_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00024AAC File Offset: 0x00022CAC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 119247, RefRangeEnd = 119251, XrefRangeStart = 119242, XrefRangeEnd = 119247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayEffect(bool instant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instant;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.NativeMethodInfoPtr_PlayEffect_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00024AEC File Offset: 0x00022CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119251, XrefRangeEnd = 119252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toggle.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00024B28 File Offset: 0x00022D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119252, XrefRangeEnd = 119253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalToggle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.NativeMethodInfoPtr_InternalToggle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00024B5C File Offset: 0x00022D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119253, XrefRangeEnd = 119254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toggle.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00024BAC File Offset: 0x00022DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSubmit(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toggle.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00024BFC File Offset: 0x00022DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform UnityEngine_UI_ICanvasElement_get_transform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00004956 File Offset: 0x00002B56
		public Toggle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00024C3C File Offset: 0x00022E3C
		// (set) Token: 0x0600079B RID: 1947 RVA: 0x0000495F File Offset: 0x00002B5F
		public unsafe Toggle.ToggleTransition toggleTransition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toggle.NativeFieldInfoPtr_toggleTransition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toggle.NativeFieldInfoPtr_toggleTransition)) = value;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x00024C64 File Offset: 0x00022E64
		// (set) Token: 0x0600079D RID: 1949 RVA: 0x0000497A File Offset: 0x00002B7A
		public unsafe Graphic graphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toggle.NativeFieldInfoPtr_graphic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toggle.NativeFieldInfoPtr_graphic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x00024C94 File Offset: 0x00022E94
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x00004999 File Offset: 0x00002B99
		public unsafe ToggleGroup m_Group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toggle.NativeFieldInfoPtr_m_Group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toggle.NativeFieldInfoPtr_m_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x00024CC4 File Offset: 0x00022EC4
		// (set) Token: 0x060007A1 RID: 1953 RVA: 0x000049B8 File Offset: 0x00002BB8
		public unsafe Toggle.ToggleEvent onValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toggle.NativeFieldInfoPtr_onValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle.ToggleEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toggle.NativeFieldInfoPtr_onValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x00024CF4 File Offset: 0x00022EF4
		// (set) Token: 0x060007A3 RID: 1955 RVA: 0x000049D7 File Offset: 0x00002BD7
		public unsafe bool m_IsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toggle.NativeFieldInfoPtr_m_IsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toggle.NativeFieldInfoPtr_m_IsOn)) = value;
			}
		}

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeFieldInfoPtr_toggleTransition;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeFieldInfoPtr_graphic;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeFieldInfoPtr_m_Group;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeFieldInfoPtr_onValueChanged;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeFieldInfoPtr_m_IsOn;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeMethodInfoPtr_get_group_Public_get_ToggleGroup_0;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeMethodInfoPtr_set_group_Public_set_Void_ToggleGroup_0;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeMethodInfoPtr_SetToggleGroup_Private_Void_ToggleGroup_Boolean_0;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeMethodInfoPtr_get_isOn_Public_get_Boolean_0;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeMethodInfoPtr_set_isOn_Public_set_Void_Boolean_0;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOnWithoutNotify_Public_Void_Boolean_0;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeMethodInfoPtr_Set_Private_Void_Boolean_Boolean_0;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeMethodInfoPtr_PlayEffect_Private_Void_Boolean_0;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeMethodInfoPtr_InternalToggle_Private_Void_0;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0;

		// Token: 0x020000B2 RID: 178
		public enum ToggleTransition
		{
			// Token: 0x040009D0 RID: 2512
			None,
			// Token: 0x040009D1 RID: 2513
			Fade
		}

		// Token: 0x020000B3 RID: 179
		[Serializable]
		public class ToggleEvent : UnityEvent<bool>
		{
			// Token: 0x06000C80 RID: 3200 RVA: 0x00006B2A File Offset: 0x00004D2A
			// Note: this type is marked as 'beforefieldinit'.
			static ToggleEvent()
			{
				Il2CppClassPointerStore<Toggle.ToggleEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Toggle>.NativeClassPtr, "ToggleEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Toggle.ToggleEvent>.NativeClassPtr);
				Toggle.ToggleEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toggle.ToggleEvent>.NativeClassPtr, 100665046);
			}

			// Token: 0x06000C81 RID: 3201 RVA: 0x0003614C File Offset: 0x0003434C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119046, XrefRangeEnd = 119049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ToggleEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Toggle.ToggleEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toggle.ToggleEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C82 RID: 3202 RVA: 0x00006B5E File Offset: 0x00004D5E
			public ToggleEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040009D2 RID: 2514
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
