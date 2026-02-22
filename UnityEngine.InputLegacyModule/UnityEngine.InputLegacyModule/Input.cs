using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	public class Input : Object
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00002BCC File Offset: 0x00000DCC
		// Note: this type is marked as 'beforefieldinit'.
		static Input()
		{
			Il2CppClassPointerStore<Input>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputLegacyModule.dll", "UnityEngine", "Input");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Input>.NativeClassPtr);
			Input.NativeMethodInfoPtr_GetKeyInt_Private_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663311);
			Input.NativeMethodInfoPtr_GetKeyUpInt_Private_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663312);
			Input.NativeMethodInfoPtr_GetKeyDownInt_Private_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663313);
			Input.NativeMethodInfoPtr_GetAxis_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663314);
			Input.NativeMethodInfoPtr_GetAxisRaw_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663315);
			Input.NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663316);
			Input.NativeMethodInfoPtr_GetMouseButton_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663317);
			Input.NativeMethodInfoPtr_GetMouseButtonDown_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663318);
			Input.NativeMethodInfoPtr_GetMouseButtonUp_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663319);
			Input.NativeMethodInfoPtr_GetTouch_Public_Static_Touch_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663320);
			Input.NativeMethodInfoPtr_GetKey_Public_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663321);
			Input.NativeMethodInfoPtr_GetKeyUp_Public_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663322);
			Input.NativeMethodInfoPtr_GetKeyDown_Public_Static_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663323);
			Input.NativeMethodInfoPtr_set_simulateMouseWithTouches_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663324);
			Input.NativeMethodInfoPtr_get_mousePosition_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663325);
			Input.NativeMethodInfoPtr_get_mouseScrollDelta_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663326);
			Input.NativeMethodInfoPtr_get_imeCompositionMode_Public_Static_get_IMECompositionMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663327);
			Input.NativeMethodInfoPtr_set_imeCompositionMode_Public_Static_set_Void_IMECompositionMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663328);
			Input.NativeMethodInfoPtr_get_compositionString_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663329);
			Input.NativeMethodInfoPtr_get_compositionCursorPos_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663330);
			Input.NativeMethodInfoPtr_set_compositionCursorPos_Public_Static_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663331);
			Input.NativeMethodInfoPtr_get_mousePresent_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663332);
			Input.NativeMethodInfoPtr_get_touchCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663333);
			Input.NativeMethodInfoPtr_get_touchSupported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663334);
			Input.NativeMethodInfoPtr_GetTouch_Injected_Private_Static_Void_Int32_byref_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663335);
			Input.NativeMethodInfoPtr_get_mousePosition_Injected_Private_Static_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663336);
			Input.NativeMethodInfoPtr_get_mouseScrollDelta_Injected_Private_Static_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663337);
			Input.NativeMethodInfoPtr_get_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663338);
			Input.NativeMethodInfoPtr_set_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100663339);
			Input.GetKeyStringDelegateField = IL2CPP.ResolveICall<Input.GetKeyStringDelegate>("UnityEngine.Input::GetKeyString");
			Input.GetKeyUpStringDelegateField = IL2CPP.ResolveICall<Input.GetKeyUpStringDelegate>("UnityEngine.Input::GetKeyUpString");
			Input.GetKeyDownStringDelegateField = IL2CPP.ResolveICall<Input.GetKeyDownStringDelegate>("UnityEngine.Input::GetKeyDownString");
			Input.GetButtonDelegateField = IL2CPP.ResolveICall<Input.GetButtonDelegate>("UnityEngine.Input::GetButton");
			Input.GetButtonUpDelegateField = IL2CPP.ResolveICall<Input.GetButtonUpDelegate>("UnityEngine.Input::GetButtonUp");
			Input.ResetInputAxesDelegateField = IL2CPP.ResolveICall<Input.ResetInputAxesDelegate>("UnityEngine.Input::ResetInputAxes");
			Input.GetJoystickNamesDelegateField = IL2CPP.ResolveICall<Input.GetJoystickNamesDelegate>("UnityEngine.Input::GetJoystickNames");
			Input.get_simulateMouseWithTouchesDelegateField = IL2CPP.ResolveICall<Input.get_simulateMouseWithTouchesDelegate>("UnityEngine.Input::get_simulateMouseWithTouches");
			Input.get_anyKeyDelegateField = IL2CPP.ResolveICall<Input.get_anyKeyDelegate>("UnityEngine.Input::get_anyKey");
			Input.get_anyKeyDownDelegateField = IL2CPP.ResolveICall<Input.get_anyKeyDownDelegate>("UnityEngine.Input::get_anyKeyDown");
			Input.get_inputStringDelegateField = IL2CPP.ResolveICall<Input.get_inputStringDelegate>("UnityEngine.Input::get_inputString");
			Input.get_imeIsSelectedDelegateField = IL2CPP.ResolveICall<Input.get_imeIsSelectedDelegate>("UnityEngine.Input::get_imeIsSelected");
			Input.get_eatKeyPressOnTextFieldFocusDelegateField = IL2CPP.ResolveICall<Input.get_eatKeyPressOnTextFieldFocusDelegate>("UnityEngine.Input::get_eatKeyPressOnTextFieldFocus");
			Input.set_eatKeyPressOnTextFieldFocusDelegateField = IL2CPP.ResolveICall<Input.set_eatKeyPressOnTextFieldFocusDelegate>("UnityEngine.Input::set_eatKeyPressOnTextFieldFocus");
			Input.get_touchPressureSupportedDelegateField = IL2CPP.ResolveICall<Input.get_touchPressureSupportedDelegate>("UnityEngine.Input::get_touchPressureSupported");
			Input.get_stylusTouchSupportedDelegateField = IL2CPP.ResolveICall<Input.get_stylusTouchSupportedDelegate>("UnityEngine.Input::get_stylusTouchSupported");
			Input.get_multiTouchEnabledDelegateField = IL2CPP.ResolveICall<Input.get_multiTouchEnabledDelegate>("UnityEngine.Input::get_multiTouchEnabled");
			Input.set_multiTouchEnabledDelegateField = IL2CPP.ResolveICall<Input.set_multiTouchEnabledDelegate>("UnityEngine.Input::set_multiTouchEnabled");
			Input.get_isGyroAvailableDelegateField = IL2CPP.ResolveICall<Input.get_isGyroAvailableDelegate>("UnityEngine.Input::get_isGyroAvailable");
			Input.get_deviceOrientationDelegateField = IL2CPP.ResolveICall<Input.get_deviceOrientationDelegate>("UnityEngine.Input::get_deviceOrientation");
			Input.get_compensateSensorsDelegateField = IL2CPP.ResolveICall<Input.get_compensateSensorsDelegate>("UnityEngine.Input::get_compensateSensors");
			Input.set_compensateSensorsDelegateField = IL2CPP.ResolveICall<Input.set_compensateSensorsDelegate>("UnityEngine.Input::set_compensateSensors");
			Input.get_accelerationEventCountDelegateField = IL2CPP.ResolveICall<Input.get_accelerationEventCountDelegate>("UnityEngine.Input::get_accelerationEventCount");
			Input.get_backButtonLeavesAppDelegateField = IL2CPP.ResolveICall<Input.get_backButtonLeavesAppDelegate>("UnityEngine.Input::get_backButtonLeavesApp");
			Input.set_backButtonLeavesAppDelegateField = IL2CPP.ResolveICall<Input.set_backButtonLeavesAppDelegate>("UnityEngine.Input::set_backButtonLeavesApp");
			Input.GetGyroInternalDelegateField = IL2CPP.ResolveICall<Input.GetGyroInternalDelegate>("UnityEngine.Input::GetGyroInternal");
			Input.SimulateTouchInternal_InjectedDelegateField = IL2CPP.ResolveICall<Input.SimulateTouchInternal_InjectedDelegate>("UnityEngine.Input::SimulateTouchInternal_Injected");
			Input.get_acceleration_InjectedDelegateField = IL2CPP.ResolveICall<Input.get_acceleration_InjectedDelegate>("UnityEngine.Input::get_acceleration_Injected");
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002FE4 File Offset: 0x000011E4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 83422, RefRangeEnd = 83434, XrefRangeStart = 83420, XrefRangeEnd = 83422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKeyInt(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetKeyInt_Private_Static_Boolean_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003024 File Offset: 0x00001224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83436, RefRangeEnd = 83437, XrefRangeStart = 83434, XrefRangeEnd = 83436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKeyUpInt(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetKeyUpInt_Private_Static_Boolean_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003064 File Offset: 0x00001264
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 83439, RefRangeEnd = 83446, XrefRangeStart = 83437, XrefRangeEnd = 83439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKeyDownInt(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetKeyDownInt_Private_Static_Boolean_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000030A4 File Offset: 0x000012A4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 83448, RefRangeEnd = 83453, XrefRangeStart = 83446, XrefRangeEnd = 83448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetAxis(string axisName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetAxis_Public_Static_Single_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000030E8 File Offset: 0x000012E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83455, RefRangeEnd = 83456, XrefRangeStart = 83453, XrefRangeEnd = 83455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetAxisRaw(string axisName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetAxisRaw_Public_Static_Single_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000312C File Offset: 0x0000132C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83458, RefRangeEnd = 83459, XrefRangeStart = 83456, XrefRangeEnd = 83458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButtonDown(string buttonName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003170 File Offset: 0x00001370
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 83461, RefRangeEnd = 83465, XrefRangeStart = 83459, XrefRangeEnd = 83461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetMouseButton(int button)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref button;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetMouseButton_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000031B0 File Offset: 0x000013B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 83467, RefRangeEnd = 83469, XrefRangeStart = 83465, XrefRangeEnd = 83467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetMouseButtonDown(int button)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref button;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetMouseButtonDown_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000031F0 File Offset: 0x000013F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83471, RefRangeEnd = 83472, XrefRangeStart = 83469, XrefRangeEnd = 83471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetMouseButtonUp(int button)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref button;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetMouseButtonUp_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003230 File Offset: 0x00001430
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 83474, RefRangeEnd = 83479, XrefRangeStart = 83472, XrefRangeEnd = 83474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Touch GetTouch(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetTouch_Public_Static_Touch_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003270 File Offset: 0x00001470
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 83422, RefRangeEnd = 83434, XrefRangeStart = 83422, XrefRangeEnd = 83434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKey(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetKey_Public_Static_Boolean_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000032B0 File Offset: 0x000014B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83436, RefRangeEnd = 83437, XrefRangeStart = 83436, XrefRangeEnd = 83437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKeyUp(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetKeyUp_Public_Static_Boolean_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000032F0 File Offset: 0x000014F0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 83439, RefRangeEnd = 83446, XrefRangeStart = 83439, XrefRangeEnd = 83446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetKeyDown(KeyCode key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetKeyDown_Public_Static_Boolean_KeyCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00002173 File Offset: 0x00000373
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00003330 File Offset: 0x00001530
		public unsafe static bool simulateMouseWithTouches
		{
			get
			{
				return Input.get_simulateMouseWithTouchesDelegateField();
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83481, RefRangeEnd = 83482, XrefRangeStart = 83479, XrefRangeEnd = 83481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_set_simulateMouseWithTouches_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00003364 File Offset: 0x00001564
		public unsafe static Vector3 mousePosition
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 83484, RefRangeEnd = 83498, XrefRangeStart = 83482, XrefRangeEnd = 83484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_mousePosition_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00003394 File Offset: 0x00001594
		public unsafe static Vector2 mouseScrollDelta
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83500, RefRangeEnd = 83501, XrefRangeStart = 83498, XrefRangeEnd = 83500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_mouseScrollDelta_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000033C4 File Offset: 0x000015C4
		// (set) Token: 0x06000037 RID: 55 RVA: 0x000033F4 File Offset: 0x000015F4
		public unsafe static IMECompositionMode imeCompositionMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83503, RefRangeEnd = 83504, XrefRangeStart = 83501, XrefRangeEnd = 83503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_imeCompositionMode_Public_Static_get_IMECompositionMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83506, RefRangeEnd = 83507, XrefRangeStart = 83504, XrefRangeEnd = 83506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_set_imeCompositionMode_Public_Static_set_Void_IMECompositionMode_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00003428 File Offset: 0x00001628
		public unsafe static string compositionString
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 83509, RefRangeEnd = 83512, XrefRangeStart = 83507, XrefRangeEnd = 83509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_compositionString_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00003454 File Offset: 0x00001654
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00003484 File Offset: 0x00001684
		public unsafe static Vector2 compositionCursorPos
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83514, RefRangeEnd = 83515, XrefRangeStart = 83512, XrefRangeEnd = 83514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_compositionCursorPos_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83517, RefRangeEnd = 83518, XrefRangeStart = 83515, XrefRangeEnd = 83517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_set_compositionCursorPos_Public_Static_set_Void_Vector2_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000034B8 File Offset: 0x000016B8
		public unsafe static bool mousePresent
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83520, RefRangeEnd = 83521, XrefRangeStart = 83518, XrefRangeEnd = 83520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_mousePresent_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000034E8 File Offset: 0x000016E8
		public unsafe static int touchCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 83523, RefRangeEnd = 83525, XrefRangeStart = 83521, XrefRangeEnd = 83523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_touchCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00003518 File Offset: 0x00001718
		public unsafe static bool touchSupported
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83527, RefRangeEnd = 83528, XrefRangeStart = 83525, XrefRangeEnd = 83527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_touchSupported_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003548 File Offset: 0x00001748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83528, XrefRangeEnd = 83530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetTouch_Injected(int index, out Touch ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_GetTouch_Injected_Private_Static_Void_Int32_byref_Touch_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003588 File Offset: 0x00001788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83530, XrefRangeEnd = 83532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_mousePosition_Injected(out Vector3 ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_mousePosition_Injected_Private_Static_Void_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000035BC File Offset: 0x000017BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83532, XrefRangeEnd = 83534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_mouseScrollDelta_Injected(out Vector2 ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_mouseScrollDelta_Injected_Private_Static_Void_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000035F0 File Offset: 0x000017F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83534, XrefRangeEnd = 83536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_compositionCursorPos_Injected(out Vector2 ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_get_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003624 File Offset: 0x00001824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83536, XrefRangeEnd = 83538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_compositionCursorPos_Injected(ref Vector2 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_set_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000020F7 File Offset: 0x000002F7
		public Input(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002100 File Offset: 0x00000300
		public static bool GetKeyString(string name)
		{
			return Input.GetKeyStringDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002112 File Offset: 0x00000312
		public static bool GetKeyUpString(string name)
		{
			return Input.GetKeyUpStringDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002124 File Offset: 0x00000324
		public static bool GetKeyDownString(string name)
		{
			return Input.GetKeyDownStringDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002136 File Offset: 0x00000336
		public static bool GetButton(string buttonName)
		{
			return Input.GetButtonDelegateField(IL2CPP.ManagedStringToIl2Cpp(buttonName));
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002148 File Offset: 0x00000348
		public static bool GetButtonUp(string buttonName)
		{
			return Input.GetButtonUpDelegateField(IL2CPP.ManagedStringToIl2Cpp(buttonName));
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000215A File Offset: 0x0000035A
		public static void ResetInputAxes()
		{
			Input.ResetInputAxesDelegateField();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003658 File Offset: 0x00001858
		public static Il2CppStringArray GetJoystickNames()
		{
			IntPtr intPtr = Input.GetJoystickNamesDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003680 File Offset: 0x00001880
		public static bool GetKey(string name)
		{
			return Input.GetKeyString(name);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003698 File Offset: 0x00001898
		public static bool GetKeyUp(string name)
		{
			return Input.GetKeyUpString(name);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000036B0 File Offset: 0x000018B0
		public static bool GetKeyDown(string name)
		{
			return Input.GetKeyDownString(name);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002166 File Offset: 0x00000366
		public static void SimulateTouch(Touch touch)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002169 File Offset: 0x00000369
		public static void SimulateTouchInternal(Touch touch, long timestamp)
		{
			Input.SimulateTouchInternal_Injected(ref touch, timestamp);
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000051 RID: 81 RVA: 0x0000217F File Offset: 0x0000037F
		public static bool anyKey
		{
			get
			{
				return Input.get_anyKeyDelegateField();
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0000218B File Offset: 0x0000038B
		public static bool anyKeyDown
		{
			get
			{
				return Input.get_anyKeyDownDelegateField();
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000036C8 File Offset: 0x000018C8
		public static string inputString
		{
			get
			{
				IntPtr intPtr = Input.get_inputStringDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002197 File Offset: 0x00000397
		public static bool imeIsSelected
		{
			get
			{
				return Input.get_imeIsSelectedDelegateField();
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000021A3 File Offset: 0x000003A3
		// (set) Token: 0x06000056 RID: 86 RVA: 0x000021AF File Offset: 0x000003AF
		public static bool eatKeyPressOnTextFieldFocus
		{
			get
			{
				return Input.get_eatKeyPressOnTextFieldFocusDelegateField();
			}
			set
			{
				Input.set_eatKeyPressOnTextFieldFocusDelegateField(value);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000021BC File Offset: 0x000003BC
		public static bool touchPressureSupported
		{
			get
			{
				return Input.get_touchPressureSupportedDelegateField();
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000021C8 File Offset: 0x000003C8
		public static bool stylusTouchSupported
		{
			get
			{
				return Input.get_stylusTouchSupportedDelegateField();
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000021D4 File Offset: 0x000003D4
		// (set) Token: 0x0600005A RID: 90 RVA: 0x000021E0 File Offset: 0x000003E0
		public static bool multiTouchEnabled
		{
			get
			{
				return Input.get_multiTouchEnabledDelegateField();
			}
			set
			{
				Input.set_multiTouchEnabledDelegateField(value);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000021ED File Offset: 0x000003ED
		public static bool isGyroAvailable
		{
			get
			{
				return Input.get_isGyroAvailableDelegateField();
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005C RID: 92 RVA: 0x000021F9 File Offset: 0x000003F9
		public static DeviceOrientation deviceOrientation
		{
			get
			{
				return Input.get_deviceOrientationDelegateField();
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600005D RID: 93 RVA: 0x000036E8 File Offset: 0x000018E8
		public static Vector3 acceleration
		{
			get
			{
				Vector3 vector;
				Input.get_acceleration_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002205 File Offset: 0x00000405
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00002211 File Offset: 0x00000411
		public static bool compensateSensors
		{
			get
			{
				return Input.get_compensateSensorsDelegateField();
			}
			set
			{
				Input.set_compensateSensorsDelegateField(value);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0000221E File Offset: 0x0000041E
		public static int accelerationEventCount
		{
			get
			{
				return Input.get_accelerationEventCountDelegateField();
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0000222A File Offset: 0x0000042A
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002236 File Offset: 0x00000436
		public static bool backButtonLeavesApp
		{
			get
			{
				return Input.get_backButtonLeavesAppDelegateField();
			}
			set
			{
				Input.set_backButtonLeavesAppDelegateField(value);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002243 File Offset: 0x00000443
		public static LocationService location
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002250 File Offset: 0x00000450
		public static Compass compass
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000225D File Offset: 0x0000045D
		public static int GetGyroInternal()
		{
			return Input.GetGyroInternalDelegateField();
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00002269 File Offset: 0x00000469
		public static Gyroscope gyro
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00002276 File Offset: 0x00000476
		public static Il2CppStructArray<Touch> touches
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002283 File Offset: 0x00000483
		public static void SimulateTouchInternal_Injected(ref Touch touch, long timestamp)
		{
			Input.SimulateTouchInternal_InjectedDelegateField(ref touch, timestamp);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002291 File Offset: 0x00000491
		public static void get_acceleration_Injected(out Vector3 ret)
		{
			Input.get_acceleration_InjectedDelegateField(out ret);
		}

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyInt_Private_Static_Boolean_KeyCode_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyUpInt_Private_Static_Boolean_KeyCode_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyDownInt_Private_Static_Boolean_KeyCode_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_GetAxis_Public_Static_Single_String_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRaw_Public_Static_Single_String_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_String_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseButton_Public_Static_Boolean_Int32_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseButtonDown_Public_Static_Boolean_Int32_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseButtonUp_Public_Static_Boolean_Int32_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_GetTouch_Public_Static_Touch_Int32_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Public_Static_Boolean_KeyCode_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyUp_Public_Static_Boolean_KeyCode_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyDown_Public_Static_Boolean_KeyCode_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_set_simulateMouseWithTouches_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_get_mousePosition_Public_Static_get_Vector3_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_get_mouseScrollDelta_Public_Static_get_Vector2_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_get_imeCompositionMode_Public_Static_get_IMECompositionMode_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_set_imeCompositionMode_Public_Static_set_Void_IMECompositionMode_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_get_compositionString_Public_Static_get_String_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_get_compositionCursorPos_Public_Static_get_Vector2_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_set_compositionCursorPos_Public_Static_set_Void_Vector2_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_get_mousePresent_Public_Static_get_Boolean_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_get_touchCount_Public_Static_get_Int32_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_get_touchSupported_Public_Static_get_Boolean_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_GetTouch_Injected_Private_Static_Void_Int32_byref_Touch_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_get_mousePosition_Injected_Private_Static_Void_byref_Vector3_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_get_mouseScrollDelta_Injected_Private_Static_Void_byref_Vector2_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_get_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_set_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0;

		// Token: 0x04000056 RID: 86
		private static readonly Input.GetKeyStringDelegate GetKeyStringDelegateField;

		// Token: 0x04000057 RID: 87
		private static readonly Input.GetKeyUpStringDelegate GetKeyUpStringDelegateField;

		// Token: 0x04000058 RID: 88
		private static readonly Input.GetKeyDownStringDelegate GetKeyDownStringDelegateField;

		// Token: 0x04000059 RID: 89
		private static readonly Input.GetButtonDelegate GetButtonDelegateField;

		// Token: 0x0400005A RID: 90
		private static readonly Input.GetButtonUpDelegate GetButtonUpDelegateField;

		// Token: 0x0400005B RID: 91
		private static readonly Input.ResetInputAxesDelegate ResetInputAxesDelegateField;

		// Token: 0x0400005C RID: 92
		private static readonly Input.GetJoystickNamesDelegate GetJoystickNamesDelegateField;

		// Token: 0x0400005D RID: 93
		private static readonly Input.get_simulateMouseWithTouchesDelegate get_simulateMouseWithTouchesDelegateField;

		// Token: 0x0400005E RID: 94
		private static readonly Input.get_anyKeyDelegate get_anyKeyDelegateField;

		// Token: 0x0400005F RID: 95
		private static readonly Input.get_anyKeyDownDelegate get_anyKeyDownDelegateField;

		// Token: 0x04000060 RID: 96
		private static readonly Input.get_inputStringDelegate get_inputStringDelegateField;

		// Token: 0x04000061 RID: 97
		private static readonly Input.get_imeIsSelectedDelegate get_imeIsSelectedDelegateField;

		// Token: 0x04000062 RID: 98
		private static readonly Input.get_eatKeyPressOnTextFieldFocusDelegate get_eatKeyPressOnTextFieldFocusDelegateField;

		// Token: 0x04000063 RID: 99
		private static readonly Input.set_eatKeyPressOnTextFieldFocusDelegate set_eatKeyPressOnTextFieldFocusDelegateField;

		// Token: 0x04000064 RID: 100
		private static readonly Input.get_touchPressureSupportedDelegate get_touchPressureSupportedDelegateField;

		// Token: 0x04000065 RID: 101
		private static readonly Input.get_stylusTouchSupportedDelegate get_stylusTouchSupportedDelegateField;

		// Token: 0x04000066 RID: 102
		private static readonly Input.get_multiTouchEnabledDelegate get_multiTouchEnabledDelegateField;

		// Token: 0x04000067 RID: 103
		private static readonly Input.set_multiTouchEnabledDelegate set_multiTouchEnabledDelegateField;

		// Token: 0x04000068 RID: 104
		private static readonly Input.get_isGyroAvailableDelegate get_isGyroAvailableDelegateField;

		// Token: 0x04000069 RID: 105
		private static readonly Input.get_deviceOrientationDelegate get_deviceOrientationDelegateField;

		// Token: 0x0400006A RID: 106
		private static readonly Input.get_compensateSensorsDelegate get_compensateSensorsDelegateField;

		// Token: 0x0400006B RID: 107
		private static readonly Input.set_compensateSensorsDelegate set_compensateSensorsDelegateField;

		// Token: 0x0400006C RID: 108
		private static readonly Input.get_accelerationEventCountDelegate get_accelerationEventCountDelegateField;

		// Token: 0x0400006D RID: 109
		private static readonly Input.get_backButtonLeavesAppDelegate get_backButtonLeavesAppDelegateField;

		// Token: 0x0400006E RID: 110
		private static readonly Input.set_backButtonLeavesAppDelegate set_backButtonLeavesAppDelegateField;

		// Token: 0x0400006F RID: 111
		private static readonly Input.GetGyroInternalDelegate GetGyroInternalDelegateField;

		// Token: 0x04000070 RID: 112
		private static readonly Input.SimulateTouchInternal_InjectedDelegate SimulateTouchInternal_InjectedDelegateField;

		// Token: 0x04000071 RID: 113
		private static readonly Input.get_acceleration_InjectedDelegate get_acceleration_InjectedDelegateField;

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x060000A8 RID: 168
		private delegate bool GetKeyStringDelegate(IntPtr name);

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x060000AA RID: 170
		private delegate bool GetKeyUpStringDelegate(IntPtr name);

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x060000AC RID: 172
		private delegate bool GetKeyDownStringDelegate(IntPtr name);

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x060000AE RID: 174
		private delegate bool GetButtonDelegate(IntPtr buttonName);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x060000B0 RID: 176
		private delegate bool GetButtonUpDelegate(IntPtr buttonName);

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x060000B2 RID: 178
		private delegate void ResetInputAxesDelegate();

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x060000B4 RID: 180
		private delegate IntPtr GetJoystickNamesDelegate();

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x060000B6 RID: 182
		private delegate bool get_simulateMouseWithTouchesDelegate();

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x060000B8 RID: 184
		private delegate bool get_anyKeyDelegate();

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x060000BA RID: 186
		private delegate bool get_anyKeyDownDelegate();

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x060000BC RID: 188
		private delegate IntPtr get_inputStringDelegate();

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x060000BE RID: 190
		private delegate bool get_imeIsSelectedDelegate();

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x060000C0 RID: 192
		private delegate bool get_eatKeyPressOnTextFieldFocusDelegate();

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x060000C2 RID: 194
		private delegate void set_eatKeyPressOnTextFieldFocusDelegate(bool value);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x060000C4 RID: 196
		private delegate bool get_touchPressureSupportedDelegate();

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x060000C6 RID: 198
		private delegate bool get_stylusTouchSupportedDelegate();

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x060000C8 RID: 200
		private delegate bool get_multiTouchEnabledDelegate();

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x060000CA RID: 202
		private delegate void set_multiTouchEnabledDelegate(bool value);

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x060000CC RID: 204
		private delegate bool get_isGyroAvailableDelegate();

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x060000CE RID: 206
		private delegate DeviceOrientation get_deviceOrientationDelegate();

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x060000D0 RID: 208
		private delegate bool get_compensateSensorsDelegate();

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x060000D2 RID: 210
		private delegate void set_compensateSensorsDelegate(bool value);

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x060000D4 RID: 212
		private delegate int get_accelerationEventCountDelegate();

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x060000D6 RID: 214
		private delegate bool get_backButtonLeavesAppDelegate();

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x060000D8 RID: 216
		private delegate void set_backButtonLeavesAppDelegate(bool value);

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x060000DA RID: 218
		private delegate int GetGyroInternalDelegate();

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x060000DC RID: 220
		private delegate void SimulateTouchInternal_InjectedDelegate(IntPtr touch, long timestamp);

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x060000DE RID: 222
		private delegate void get_acceleration_InjectedDelegate([Out] IntPtr ret);
	}
}
