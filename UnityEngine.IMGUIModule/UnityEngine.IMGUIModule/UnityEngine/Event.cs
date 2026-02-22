using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	public sealed class Event : Object
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00004C50 File Offset: 0x00002E50
		// Note: this type is marked as 'beforefieldinit'.
		static Event()
		{
			Il2CppClassPointerStore<Event>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "Event");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Event>.NativeClassPtr);
			Event.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Event>.NativeClassPtr, "m_Ptr");
			Event.NativeFieldInfoPtr_s_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Event>.NativeClassPtr, "s_Current");
			Event.NativeFieldInfoPtr_s_MasterEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Event>.NativeClassPtr, "s_MasterEvent");
			Event.NativeMethodInfoPtr_get_rawType_Public_get_EventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663299);
			Event.NativeMethodInfoPtr_get_mousePosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663300);
			Event.NativeMethodInfoPtr_set_mousePosition_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663301);
			Event.NativeMethodInfoPtr_get_delta_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663302);
			Event.NativeMethodInfoPtr_get_pointerType_Public_get_PointerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663303);
			Event.NativeMethodInfoPtr_get_button_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663304);
			Event.NativeMethodInfoPtr_get_modifiers_Public_get_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663305);
			Event.NativeMethodInfoPtr_get_pressure_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663306);
			Event.NativeMethodInfoPtr_get_clickCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663307);
			Event.NativeMethodInfoPtr_get_character_Public_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663308);
			Event.NativeMethodInfoPtr_get_keyCode_Public_get_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663309);
			Event.NativeMethodInfoPtr_get_displayIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663310);
			Event.NativeMethodInfoPtr_set_displayIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663311);
			Event.NativeMethodInfoPtr_get_type_Public_get_EventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663312);
			Event.NativeMethodInfoPtr_set_type_Public_set_Void_EventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663313);
			Event.NativeMethodInfoPtr_get_commandName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663314);
			Event.NativeMethodInfoPtr_set_commandName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663315);
			Event.NativeMethodInfoPtr_Internal_Use_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663316);
			Event.NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663317);
			Event.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663318);
			Event.NativeMethodInfoPtr_GetTypeForControl_Public_EventType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663319);
			Event.NativeMethodInfoPtr_CopyFromPtr_Internal_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663320);
			Event.NativeMethodInfoPtr_PopEvent_Public_Static_Boolean_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663321);
			Event.NativeMethodInfoPtr_Internal_SetNativeEvent_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663322);
			Event.NativeMethodInfoPtr_Internal_MakeMasterEventCurrent_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663323);
			Event.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663324);
			Event.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663325);
			Event.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663326);
			Event.NativeMethodInfoPtr_CopyFrom_Internal_Void_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663327);
			Event.NativeMethodInfoPtr_get_shift_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663328);
			Event.NativeMethodInfoPtr_get_control_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663329);
			Event.NativeMethodInfoPtr_get_alt_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663330);
			Event.NativeMethodInfoPtr_get_command_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663331);
			Event.NativeMethodInfoPtr_get_current_Public_Static_get_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663332);
			Event.NativeMethodInfoPtr_set_current_Public_Static_set_Void_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663333);
			Event.NativeMethodInfoPtr_get_isKey_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663334);
			Event.NativeMethodInfoPtr_get_isMouse_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663335);
			Event.NativeMethodInfoPtr_get_isDirectManipulationDevice_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663336);
			Event.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663337);
			Event.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663338);
			Event.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663339);
			Event.NativeMethodInfoPtr_Use_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663340);
			Event.NativeMethodInfoPtr_get_mousePosition_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663341);
			Event.NativeMethodInfoPtr_set_mousePosition_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663342);
			Event.NativeMethodInfoPtr_get_delta_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663343);
			Event.set_pointerTypeDelegateField = IL2CPP.ResolveICall<Event.set_pointerTypeDelegate>("UnityEngine.Event::set_pointerType");
			Event.set_buttonDelegateField = IL2CPP.ResolveICall<Event.set_buttonDelegate>("UnityEngine.Event::set_button");
			Event.set_modifiersDelegateField = IL2CPP.ResolveICall<Event.set_modifiersDelegate>("UnityEngine.Event::set_modifiers");
			Event.set_pressureDelegateField = IL2CPP.ResolveICall<Event.set_pressureDelegate>("UnityEngine.Event::set_pressure");
			Event.set_clickCountDelegateField = IL2CPP.ResolveICall<Event.set_clickCountDelegate>("UnityEngine.Event::set_clickCount");
			Event.set_characterDelegateField = IL2CPP.ResolveICall<Event.set_characterDelegate>("UnityEngine.Event::set_character");
			Event.set_keyCodeDelegateField = IL2CPP.ResolveICall<Event.set_keyCodeDelegate>("UnityEngine.Event::set_keyCode");
			Event.Internal_CopyDelegateField = IL2CPP.ResolveICall<Event.Internal_CopyDelegate>("UnityEngine.Event::Internal_Copy");
			Event.GetEventCountDelegateField = IL2CPP.ResolveICall<Event.GetEventCountDelegate>("UnityEngine.Event::GetEventCount");
			Event.GetDoubleClickTimeDelegateField = IL2CPP.ResolveICall<Event.GetDoubleClickTimeDelegate>("UnityEngine.Event::GetDoubleClickTime");
			Event.set_delta_InjectedDelegateField = IL2CPP.ResolveICall<Event.set_delta_InjectedDelegate>("UnityEngine.Event::set_delta_Injected");
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000050E8 File Offset: 0x000032E8
		public unsafe EventType rawType
		{
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 84179, RefRangeEnd = 84212, XrefRangeStart = 84177, XrefRangeEnd = 84179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_rawType_Public_get_EventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00005124 File Offset: 0x00003324
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00005160 File Offset: 0x00003360
		public unsafe Vector2 mousePosition
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 84214, RefRangeEnd = 84221, XrefRangeStart = 84212, XrefRangeEnd = 84214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_mousePosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 84223, RefRangeEnd = 84224, XrefRangeStart = 84221, XrefRangeEnd = 84223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_set_mousePosition_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000051A0 File Offset: 0x000033A0
		// (set) Token: 0x0600003C RID: 60 RVA: 0x0000211C File Offset: 0x0000031C
		public unsafe Vector2 delta
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 84226, RefRangeEnd = 84230, XrefRangeStart = 84224, XrefRangeEnd = 84226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_delta_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.set_delta_Injected(ref value);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000051DC File Offset: 0x000033DC
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002126 File Offset: 0x00000326
		public unsafe PointerType pointerType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 84232, RefRangeEnd = 84234, XrefRangeStart = 84230, XrefRangeEnd = 84232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_pointerType_Public_get_PointerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Event.set_pointerTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00005218 File Offset: 0x00003418
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002139 File Offset: 0x00000339
		public unsafe int button
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 84236, RefRangeEnd = 84242, XrefRangeStart = 84234, XrefRangeEnd = 84236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_button_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Event.set_buttonDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00005254 File Offset: 0x00003454
		// (set) Token: 0x0600003F RID: 63 RVA: 0x0000214C File Offset: 0x0000034C
		public unsafe EventModifiers modifiers
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 84244, RefRangeEnd = 84253, XrefRangeStart = 84242, XrefRangeEnd = 84244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_modifiers_Public_get_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Event.set_modifiersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00005290 File Offset: 0x00003490
		// (set) Token: 0x06000040 RID: 64 RVA: 0x0000215F File Offset: 0x0000035F
		public unsafe float pressure
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 84255, RefRangeEnd = 84256, XrefRangeStart = 84253, XrefRangeEnd = 84255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_pressure_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Event.set_pressureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000052CC File Offset: 0x000034CC
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00002172 File Offset: 0x00000372
		public unsafe int clickCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 84258, RefRangeEnd = 84260, XrefRangeStart = 84256, XrefRangeEnd = 84258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_clickCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Event.set_clickCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00005308 File Offset: 0x00003508
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002185 File Offset: 0x00000385
		public unsafe char character
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 84262, RefRangeEnd = 84268, XrefRangeStart = 84260, XrefRangeEnd = 84262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_character_Public_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Event.set_characterDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00005344 File Offset: 0x00003544
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00002198 File Offset: 0x00000398
		public unsafe KeyCode keyCode
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 84270, RefRangeEnd = 84273, XrefRangeStart = 84268, XrefRangeEnd = 84270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_keyCode_Public_get_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Event.set_keyCodeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00005380 File Offset: 0x00003580
		// (set) Token: 0x06000014 RID: 20 RVA: 0x000053BC File Offset: 0x000035BC
		public unsafe int displayIndex
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 84275, RefRangeEnd = 84277, XrefRangeStart = 84273, XrefRangeEnd = 84275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_displayIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 84279, RefRangeEnd = 84281, XrefRangeStart = 84277, XrefRangeEnd = 84279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_set_displayIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000053FC File Offset: 0x000035FC
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00005438 File Offset: 0x00003638
		public unsafe EventType type
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 84283, RefRangeEnd = 84306, XrefRangeStart = 84281, XrefRangeEnd = 84283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_type_Public_get_EventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 84308, RefRangeEnd = 84313, XrefRangeStart = 84306, XrefRangeEnd = 84308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_set_type_Public_set_Void_EventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00005478 File Offset: 0x00003678
		// (set) Token: 0x06000018 RID: 24 RVA: 0x000054B0 File Offset: 0x000036B0
		public unsafe string commandName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 84315, RefRangeEnd = 84317, XrefRangeStart = 84313, XrefRangeEnd = 84315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_commandName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 84319, RefRangeEnd = 84320, XrefRangeStart = 84317, XrefRangeEnd = 84319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_set_commandName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000054F4 File Offset: 0x000036F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84320, XrefRangeEnd = 84322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_Use()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_Internal_Use_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00005528 File Offset: 0x00003728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84322, XrefRangeEnd = 84324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Internal_Create(int displayIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00005568 File Offset: 0x00003768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84324, XrefRangeEnd = 84326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Destroy(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000559C File Offset: 0x0000379C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84326, XrefRangeEnd = 84328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventType GetTypeForControl(int controlID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controlID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_GetTypeForControl_Public_EventType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000055E8 File Offset: 0x000037E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84330, RefRangeEnd = 84331, XrefRangeStart = 84328, XrefRangeEnd = 84330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFromPtr(IntPtr ptr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_CopyFromPtr_Internal_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00005628 File Offset: 0x00003828
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 84333, RefRangeEnd = 84339, XrefRangeStart = 84331, XrefRangeEnd = 84333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PopEvent(Event outEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_PopEvent_Public_Static_Boolean_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000566C File Offset: 0x0000386C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84339, XrefRangeEnd = 84341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SetNativeEvent(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_Internal_SetNativeEvent_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000056A0 File Offset: 0x000038A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84341, XrefRangeEnd = 84356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_MakeMasterEventCurrent(int displayIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_Internal_MakeMasterEventCurrent_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000056D4 File Offset: 0x000038D4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 84359, RefRangeEnd = 84365, XrefRangeStart = 84356, XrefRangeEnd = 84359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Event()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Event>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00005710 File Offset: 0x00003910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84365, XrefRangeEnd = 84368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Event(int displayIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Event>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00005758 File Offset: 0x00003958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84368, XrefRangeEnd = 84375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000578C File Offset: 0x0000398C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84378, RefRangeEnd = 84380, XrefRangeStart = 84375, XrefRangeEnd = 84378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(Event e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_CopyFrom_Internal_Void_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000057D0 File Offset: 0x000039D0
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00005C34 File Offset: 0x00003E34
		public unsafe bool shift
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 84382, RefRangeEnd = 84384, XrefRangeStart = 84380, XrefRangeEnd = 84382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_shift_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = !value;
				if (flag)
				{
					this.modifiers &= ~EventModifiers.Shift;
				}
				else
				{
					this.modifiers |= EventModifiers.Shift;
				}
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000026 RID: 38 RVA: 0x0000580C File Offset: 0x00003A0C
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00005C6C File Offset: 0x00003E6C
		public unsafe bool control
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84384, XrefRangeEnd = 84386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_control_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = !value;
				if (flag)
				{
					this.modifiers &= ~EventModifiers.Control;
				}
				else
				{
					this.modifiers |= EventModifiers.Control;
				}
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00005848 File Offset: 0x00003A48
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00005CA4 File Offset: 0x00003EA4
		public unsafe bool alt
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84386, XrefRangeEnd = 84388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_alt_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = !value;
				if (flag)
				{
					this.modifiers &= ~EventModifiers.Alt;
				}
				else
				{
					this.modifiers |= EventModifiers.Alt;
				}
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00005884 File Offset: 0x00003A84
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00005CDC File Offset: 0x00003EDC
		public unsafe bool command
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84388, XrefRangeEnd = 84390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_command_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = !value;
				if (flag)
				{
					this.modifiers &= ~EventModifiers.Command;
				}
				else
				{
					this.modifiers |= EventModifiers.Command;
				}
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000058C0 File Offset: 0x00003AC0
		// (set) Token: 0x0600002A RID: 42 RVA: 0x000058F4 File Offset: 0x00003AF4
		public unsafe static Event current
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 84392, RefRangeEnd = 84410, XrefRangeStart = 84390, XrefRangeEnd = 84392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_current_Public_Static_get_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Event>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 84416, RefRangeEnd = 84417, XrefRangeStart = 84410, XrefRangeEnd = 84416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_set_current_Public_Static_set_Void_Event_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600002B RID: 43 RVA: 0x0000592C File Offset: 0x00003B2C
		public unsafe bool isKey
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 84419, RefRangeEnd = 84420, XrefRangeStart = 84417, XrefRangeEnd = 84419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_isKey_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00005968 File Offset: 0x00003B68
		public unsafe bool isMouse
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 84422, RefRangeEnd = 84423, XrefRangeStart = 84420, XrefRangeEnd = 84422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_isMouse_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000059A4 File Offset: 0x00003BA4
		public unsafe bool isDirectManipulationDevice
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 84425, RefRangeEnd = 84426, XrefRangeStart = 84423, XrefRangeEnd = 84425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_isDirectManipulationDevice_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000059E0 File Offset: 0x00003BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84426, XrefRangeEnd = 84437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00005A1C File Offset: 0x00003C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84437, XrefRangeEnd = 84453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00005A6C File Offset: 0x00003C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84453, XrefRangeEnd = 84481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00005AA4 File Offset: 0x00003CA4
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 84503, RefRangeEnd = 84518, XrefRangeStart = 84481, XrefRangeEnd = 84503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Use()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_Use_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00005AD8 File Offset: 0x00003CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84518, XrefRangeEnd = 84520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_mousePosition_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_mousePosition_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00005B18 File Offset: 0x00003D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84520, XrefRangeEnd = 84522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_mousePosition_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_set_mousePosition_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00005B58 File Offset: 0x00003D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84522, XrefRangeEnd = 84524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_delta_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_delta_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000020D4 File Offset: 0x000002D4
		public Event(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00005B98 File Offset: 0x00003D98
		// (set) Token: 0x06000037 RID: 55 RVA: 0x000020DD File Offset: 0x000002DD
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Event.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Event.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00005BC0 File Offset: 0x00003DC0
		// (set) Token: 0x06000039 RID: 57 RVA: 0x000020F8 File Offset: 0x000002F8
		public unsafe static Event s_Current
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Event.NativeFieldInfoPtr_s_Current, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Event.NativeFieldInfoPtr_s_Current, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00005BE8 File Offset: 0x00003DE8
		// (set) Token: 0x0600003B RID: 59 RVA: 0x0000210A File Offset: 0x0000030A
		public unsafe static Event s_MasterEvent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Event.NativeFieldInfoPtr_s_MasterEvent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Event.NativeFieldInfoPtr_s_MasterEvent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000021AB File Offset: 0x000003AB
		public static IntPtr Internal_Copy(IntPtr otherPtr)
		{
			return Event.Internal_CopyDelegateField(otherPtr);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000021B8 File Offset: 0x000003B8
		public static int GetEventCount()
		{
			return Event.GetEventCountDelegateField();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000021C4 File Offset: 0x000003C4
		public static int GetDoubleClickTime()
		{
			return Event.GetDoubleClickTimeDelegateField();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000021D0 File Offset: 0x000003D0
		public static void CleanupRoots()
		{
			Event.s_Current = null;
			Event.s_MasterEvent = null;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00005C10 File Offset: 0x00003E10
		// (set) Token: 0x06000049 RID: 73 RVA: 0x000021DF File Offset: 0x000003DF
		public Ray mouseRay
		{
			get
			{
				return new Ray(Vector3.up, Vector3.up);
			}
			set
			{
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00005D14 File Offset: 0x00003F14
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00005D34 File Offset: 0x00003F34
		public bool capsLock
		{
			get
			{
				return (this.modifiers & EventModifiers.CapsLock) > EventModifiers.None;
			}
			set
			{
				bool flag = !value;
				if (flag)
				{
					this.modifiers &= ~EventModifiers.CapsLock;
				}
				else
				{
					this.modifiers |= EventModifiers.CapsLock;
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00005D6C File Offset: 0x00003F6C
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00005D8C File Offset: 0x00003F8C
		public bool numeric
		{
			get
			{
				return (this.modifiers & EventModifiers.Numeric) > EventModifiers.None;
			}
			set
			{
				bool flag = !value;
				if (flag)
				{
					this.modifiers &= ~EventModifiers.Numeric;
				}
				else
				{
					this.modifiers |= EventModifiers.Numeric;
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000052 RID: 82 RVA: 0x000021E2 File Offset: 0x000003E2
		public bool functionKey
		{
			get
			{
				return (this.modifiers & EventModifiers.FunctionKey) > EventModifiers.None;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00005DC4 File Offset: 0x00003FC4
		public bool isScrollWheel
		{
			get
			{
				EventType type = this.type;
				return type == EventType.ScrollWheel;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000021F0 File Offset: 0x000003F0
		public static Event KeyboardEvent(string key)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000021FD File Offset: 0x000003FD
		public void set_delta_Injected(ref Vector2 value)
		{
			Event.set_delta_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_s_Current;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_s_MasterEvent;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_get_rawType_Public_get_EventType_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_get_mousePosition_Public_get_Vector2_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_set_mousePosition_Public_set_Void_Vector2_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_get_delta_Public_get_Vector2_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerType_Public_get_PointerType_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_get_button_Public_get_Int32_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_get_modifiers_Public_get_EventModifiers_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_get_pressure_Public_get_Single_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_get_clickCount_Public_get_Int32_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_get_character_Public_get_Char_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_get_keyCode_Public_get_KeyCode_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_get_displayIndex_Public_get_Int32_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_set_displayIndex_Public_set_Void_Int32_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_EventType_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_set_type_Public_set_Void_EventType_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_get_commandName_Public_get_String_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_set_commandName_Public_set_Void_String_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Use_Private_Void_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_Int32_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeForControl_Public_EventType_Int32_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_CopyFromPtr_Internal_Void_IntPtr_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_PopEvent_Public_Static_Boolean_Event_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SetNativeEvent_Private_Static_Void_IntPtr_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_Internal_MakeMasterEventCurrent_Internal_Static_Void_Int32_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Internal_Void_Event_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_get_shift_Public_get_Boolean_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_get_control_Public_get_Boolean_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_get_alt_Public_get_Boolean_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_get_command_Public_get_Boolean_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_get_current_Public_Static_get_Event_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_set_current_Public_Static_set_Void_Event_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_get_isKey_Public_get_Boolean_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_get_isMouse_Public_get_Boolean_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_get_isDirectManipulationDevice_Internal_get_Boolean_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_Use_Public_Void_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_get_mousePosition_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_set_mousePosition_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_get_delta_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000033 RID: 51
		private static readonly Event.set_pointerTypeDelegate set_pointerTypeDelegateField;

		// Token: 0x04000034 RID: 52
		private static readonly Event.set_buttonDelegate set_buttonDelegateField;

		// Token: 0x04000035 RID: 53
		private static readonly Event.set_modifiersDelegate set_modifiersDelegateField;

		// Token: 0x04000036 RID: 54
		private static readonly Event.set_pressureDelegate set_pressureDelegateField;

		// Token: 0x04000037 RID: 55
		private static readonly Event.set_clickCountDelegate set_clickCountDelegateField;

		// Token: 0x04000038 RID: 56
		private static readonly Event.set_characterDelegate set_characterDelegateField;

		// Token: 0x04000039 RID: 57
		private static readonly Event.set_keyCodeDelegate set_keyCodeDelegateField;

		// Token: 0x0400003A RID: 58
		private static readonly Event.Internal_CopyDelegate Internal_CopyDelegateField;

		// Token: 0x0400003B RID: 59
		private static readonly Event.GetEventCountDelegate GetEventCountDelegateField;

		// Token: 0x0400003C RID: 60
		private static readonly Event.GetDoubleClickTimeDelegate GetDoubleClickTimeDelegateField;

		// Token: 0x0400003D RID: 61
		private static readonly Event.set_delta_InjectedDelegate set_delta_InjectedDelegateField;

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x06000628 RID: 1576
		private delegate void set_pointerTypeDelegate(IntPtr @this, PointerType value);

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x0600062A RID: 1578
		private delegate void set_buttonDelegate(IntPtr @this, int value);

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x0600062C RID: 1580
		private delegate void set_modifiersDelegate(IntPtr @this, EventModifiers value);

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x0600062E RID: 1582
		private delegate void set_pressureDelegate(IntPtr @this, float value);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x06000630 RID: 1584
		private delegate void set_clickCountDelegate(IntPtr @this, int value);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x06000632 RID: 1586
		private delegate void set_characterDelegate(IntPtr @this, char value);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x06000634 RID: 1588
		private delegate void set_keyCodeDelegate(IntPtr @this, KeyCode value);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x06000636 RID: 1590
		private delegate IntPtr Internal_CopyDelegate(IntPtr otherPtr);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x06000638 RID: 1592
		private delegate int GetEventCountDelegate();

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x0600063A RID: 1594
		private delegate int GetDoubleClickTimeDelegate();

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x0600063C RID: 1596
		private delegate void set_delta_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
