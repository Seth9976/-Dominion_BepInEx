using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200015A RID: 346
	public static class SteamInput : Object
	{
		// Token: 0x06001AB1 RID: 6833 RVA: 0x00078DB0 File Offset: 0x00076FB0
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInput()
		{
			Il2CppClassPointerStore<SteamInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInput>.NativeClassPtr);
			SteamInput.NativeMethodInfoPtr_Init_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666841);
			SteamInput.NativeMethodInfoPtr_Shutdown_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666842);
			SteamInput.NativeMethodInfoPtr_RunFrame_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666843);
			SteamInput.NativeMethodInfoPtr_GetConnectedControllers_Public_Static_Int32_Il2CppStructArray_1_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666844);
			SteamInput.NativeMethodInfoPtr_GetActionSetHandle_Public_Static_InputActionSetHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666845);
			SteamInput.NativeMethodInfoPtr_ActivateActionSet_Public_Static_Void_InputHandle_t_InputActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666846);
			SteamInput.NativeMethodInfoPtr_GetCurrentActionSet_Public_Static_InputActionSetHandle_t_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666847);
			SteamInput.NativeMethodInfoPtr_ActivateActionSetLayer_Public_Static_Void_InputHandle_t_InputActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666848);
			SteamInput.NativeMethodInfoPtr_DeactivateActionSetLayer_Public_Static_Void_InputHandle_t_InputActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666849);
			SteamInput.NativeMethodInfoPtr_DeactivateAllActionSetLayers_Public_Static_Void_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666850);
			SteamInput.NativeMethodInfoPtr_GetActiveActionSetLayers_Public_Static_Int32_InputHandle_t_Il2CppStructArray_1_InputActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666851);
			SteamInput.NativeMethodInfoPtr_GetDigitalActionHandle_Public_Static_InputDigitalActionHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666852);
			SteamInput.NativeMethodInfoPtr_GetDigitalActionData_Public_Static_InputDigitalActionData_t_InputHandle_t_InputDigitalActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666853);
			SteamInput.NativeMethodInfoPtr_GetDigitalActionOrigins_Public_Static_Int32_InputHandle_t_InputActionSetHandle_t_InputDigitalActionHandle_t_Il2CppStructArray_1_EInputActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666854);
			SteamInput.NativeMethodInfoPtr_GetAnalogActionHandle_Public_Static_InputAnalogActionHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666855);
			SteamInput.NativeMethodInfoPtr_GetAnalogActionData_Public_Static_InputAnalogActionData_t_InputHandle_t_InputAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666856);
			SteamInput.NativeMethodInfoPtr_GetAnalogActionOrigins_Public_Static_Int32_InputHandle_t_InputActionSetHandle_t_InputAnalogActionHandle_t_Il2CppStructArray_1_EInputActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666857);
			SteamInput.NativeMethodInfoPtr_GetGlyphForActionOrigin_Public_Static_String_EInputActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666858);
			SteamInput.NativeMethodInfoPtr_GetStringForActionOrigin_Public_Static_String_EInputActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666859);
			SteamInput.NativeMethodInfoPtr_StopAnalogActionMomentum_Public_Static_Void_InputHandle_t_InputAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666860);
			SteamInput.NativeMethodInfoPtr_GetMotionData_Public_Static_InputMotionData_t_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666861);
			SteamInput.NativeMethodInfoPtr_TriggerVibration_Public_Static_Void_InputHandle_t_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666862);
			SteamInput.NativeMethodInfoPtr_SetLEDColor_Public_Static_Void_InputHandle_t_Byte_Byte_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666863);
			SteamInput.NativeMethodInfoPtr_TriggerHapticPulse_Public_Static_Void_InputHandle_t_ESteamControllerPad_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666864);
			SteamInput.NativeMethodInfoPtr_TriggerRepeatedHapticPulse_Public_Static_Void_InputHandle_t_ESteamControllerPad_UInt16_UInt16_UInt16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666865);
			SteamInput.NativeMethodInfoPtr_ShowBindingPanel_Public_Static_Boolean_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666866);
			SteamInput.NativeMethodInfoPtr_GetInputTypeForHandle_Public_Static_ESteamInputType_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666867);
			SteamInput.NativeMethodInfoPtr_GetControllerForGamepadIndex_Public_Static_InputHandle_t_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666868);
			SteamInput.NativeMethodInfoPtr_GetGamepadIndexForController_Public_Static_Int32_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666869);
			SteamInput.NativeMethodInfoPtr_GetStringForXboxOrigin_Public_Static_String_EXboxOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666870);
			SteamInput.NativeMethodInfoPtr_GetGlyphForXboxOrigin_Public_Static_String_EXboxOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666871);
			SteamInput.NativeMethodInfoPtr_GetActionOriginFromXboxOrigin_Public_Static_EInputActionOrigin_InputHandle_t_EXboxOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666872);
			SteamInput.NativeMethodInfoPtr_TranslateActionOrigin_Public_Static_EInputActionOrigin_ESteamInputType_EInputActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666873);
			SteamInput.NativeMethodInfoPtr_GetDeviceBindingRevision_Public_Static_Boolean_InputHandle_t_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666874);
			SteamInput.NativeMethodInfoPtr_GetRemotePlaySessionID_Public_Static_UInt32_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInput>.NativeClassPtr, 100666875);
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x0007909C File Offset: 0x0007729C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199313, XrefRangeEnd = 199317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_Init_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x000790CC File Offset: 0x000772CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199317, XrefRangeEnd = 199321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Shutdown()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_Shutdown_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x000790FC File Offset: 0x000772FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199321, XrefRangeEnd = 199325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RunFrame()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_RunFrame_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x00079124 File Offset: 0x00077324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199325, XrefRangeEnd = 199335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetConnectedControllers(Il2CppStructArray<InputHandle_t> handlesOut)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handlesOut);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetConnectedControllers_Public_Static_Int32_Il2CppStructArray_1_InputHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x00079168 File Offset: 0x00077368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199335, XrefRangeEnd = 199348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputActionSetHandle_t GetActionSetHandle(string pszActionSetName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszActionSetName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetActionSetHandle_Public_Static_InputActionSetHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x000791AC File Offset: 0x000773AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199348, XrefRangeEnd = 199352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ActivateActionSet(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_ActivateActionSet_Public_Static_Void_InputHandle_t_InputActionSetHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x000791EC File Offset: 0x000773EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199352, XrefRangeEnd = 199357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputActionSetHandle_t GetCurrentActionSet(InputHandle_t inputHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetCurrentActionSet_Public_Static_InputActionSetHandle_t_InputHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x0007922C File Offset: 0x0007742C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199357, XrefRangeEnd = 199361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ActivateActionSetLayer(InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetLayerHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_ActivateActionSetLayer_Public_Static_Void_InputHandle_t_InputActionSetHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x0007926C File Offset: 0x0007746C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199361, XrefRangeEnd = 199365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeactivateActionSetLayer(InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetLayerHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_DeactivateActionSetLayer_Public_Static_Void_InputHandle_t_InputActionSetHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x000792AC File Offset: 0x000774AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199365, XrefRangeEnd = 199369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeactivateAllActionSetLayers(InputHandle_t inputHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_DeactivateAllActionSetLayers_Public_Static_Void_InputHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x000792E0 File Offset: 0x000774E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199369, XrefRangeEnd = 199379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetActiveActionSetLayers(InputHandle_t inputHandle, Il2CppStructArray<InputActionSetHandle_t> handlesOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handlesOut);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetActiveActionSetLayers_Public_Static_Int32_InputHandle_t_Il2CppStructArray_1_InputActionSetHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x00079330 File Offset: 0x00077530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199379, XrefRangeEnd = 199392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputDigitalActionHandle_t GetDigitalActionHandle(string pszActionName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszActionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetDigitalActionHandle_Public_Static_InputDigitalActionHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x00079374 File Offset: 0x00077574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199392, XrefRangeEnd = 199396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputDigitalActionData_t GetDigitalActionData(InputHandle_t inputHandle, InputDigitalActionHandle_t digitalActionHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitalActionHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetDigitalActionData_Public_Static_InputDigitalActionData_t_InputHandle_t_InputDigitalActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x000793C0 File Offset: 0x000775C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199396, XrefRangeEnd = 199400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetDigitalActionOrigins(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputDigitalActionHandle_t digitalActionHandle, Il2CppStructArray<EInputActionOrigin> originsOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitalActionHandle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(originsOut);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetDigitalActionOrigins_Public_Static_Int32_InputHandle_t_InputActionSetHandle_t_InputDigitalActionHandle_t_Il2CppStructArray_1_EInputActionOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x0007942C File Offset: 0x0007762C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199400, XrefRangeEnd = 199413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputAnalogActionHandle_t GetAnalogActionHandle(string pszActionName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszActionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetAnalogActionHandle_Public_Static_InputAnalogActionHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x00079470 File Offset: 0x00077670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199413, XrefRangeEnd = 199417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputAnalogActionData_t GetAnalogActionData(InputHandle_t inputHandle, InputAnalogActionHandle_t analogActionHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref analogActionHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetAnalogActionData_Public_Static_InputAnalogActionData_t_InputHandle_t_InputAnalogActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x000794BC File Offset: 0x000776BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199417, XrefRangeEnd = 199421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAnalogActionOrigins(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputAnalogActionHandle_t analogActionHandle, Il2CppStructArray<EInputActionOrigin> originsOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref analogActionHandle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(originsOut);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetAnalogActionOrigins_Public_Static_Int32_InputHandle_t_InputActionSetHandle_t_InputAnalogActionHandle_t_Il2CppStructArray_1_EInputActionOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x00079528 File Offset: 0x00077728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199421, XrefRangeEnd = 199426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetGlyphForActionOrigin(EInputActionOrigin eOrigin)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eOrigin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetGlyphForActionOrigin_Public_Static_String_EInputActionOrigin_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x00079560 File Offset: 0x00077760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199426, XrefRangeEnd = 199431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStringForActionOrigin(EInputActionOrigin eOrigin)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eOrigin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetStringForActionOrigin_Public_Static_String_EInputActionOrigin_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x00079598 File Offset: 0x00077798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199431, XrefRangeEnd = 199435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StopAnalogActionMomentum(InputHandle_t inputHandle, InputAnalogActionHandle_t eAction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_StopAnalogActionMomentum_Public_Static_Void_InputHandle_t_InputAnalogActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x000795D8 File Offset: 0x000777D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199435, XrefRangeEnd = 199439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputMotionData_t GetMotionData(InputHandle_t inputHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetMotionData_Public_Static_InputMotionData_t_InputHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x00079618 File Offset: 0x00077818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199439, XrefRangeEnd = 199443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TriggerVibration(InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usLeftSpeed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usRightSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_TriggerVibration_Public_Static_Void_InputHandle_t_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x00079668 File Offset: 0x00077868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199443, XrefRangeEnd = 199447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLEDColor(InputHandle_t inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nColorR;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nColorG;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nColorB;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_SetLEDColor_Public_Static_Void_InputHandle_t_Byte_Byte_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x000796D4 File Offset: 0x000778D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199447, XrefRangeEnd = 199451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TriggerHapticPulse(InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eTargetPad;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usDurationMicroSec;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_TriggerHapticPulse_Public_Static_Void_InputHandle_t_ESteamControllerPad_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x00079724 File Offset: 0x00077924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199451, XrefRangeEnd = 199455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TriggerRepeatedHapticPulse(InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eTargetPad;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usDurationMicroSec;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usOffMicroSec;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unRepeat;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_TriggerRepeatedHapticPulse_Public_Static_Void_InputHandle_t_ESteamControllerPad_UInt16_UInt16_UInt16_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x0007979C File Offset: 0x0007799C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199455, XrefRangeEnd = 199459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShowBindingPanel(InputHandle_t inputHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_ShowBindingPanel_Public_Static_Boolean_InputHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x000797DC File Offset: 0x000779DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199459, XrefRangeEnd = 199463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ESteamInputType GetInputTypeForHandle(InputHandle_t inputHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetInputTypeForHandle_Public_Static_ESteamInputType_InputHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x0007981C File Offset: 0x00077A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199463, XrefRangeEnd = 199468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputHandle_t GetControllerForGamepadIndex(int nIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetControllerForGamepadIndex_Public_Static_InputHandle_t_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x0007985C File Offset: 0x00077A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199468, XrefRangeEnd = 199472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGamepadIndexForController(InputHandle_t ulinputHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ulinputHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetGamepadIndexForController_Public_Static_Int32_InputHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x0007989C File Offset: 0x00077A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199472, XrefRangeEnd = 199477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStringForXboxOrigin(EXboxOrigin eOrigin)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eOrigin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetStringForXboxOrigin_Public_Static_String_EXboxOrigin_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x000798D4 File Offset: 0x00077AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199477, XrefRangeEnd = 199482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetGlyphForXboxOrigin(EXboxOrigin eOrigin)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eOrigin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetGlyphForXboxOrigin_Public_Static_String_EXboxOrigin_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x0007990C File Offset: 0x00077B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199482, XrefRangeEnd = 199486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EInputActionOrigin GetActionOriginFromXboxOrigin(InputHandle_t inputHandle, EXboxOrigin eOrigin)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eOrigin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetActionOriginFromXboxOrigin_Public_Static_EInputActionOrigin_InputHandle_t_EXboxOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x00079958 File Offset: 0x00077B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199486, XrefRangeEnd = 199490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EInputActionOrigin TranslateActionOrigin(ESteamInputType eDestinationInputType, EInputActionOrigin eSourceOrigin)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eDestinationInputType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eSourceOrigin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_TranslateActionOrigin_Public_Static_EInputActionOrigin_ESteamInputType_EInputActionOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x000799A4 File Offset: 0x00077BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199490, XrefRangeEnd = 199494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDeviceBindingRevision(InputHandle_t inputHandle, out int pMajor, out int pMinor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pMajor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pMinor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetDeviceBindingRevision_Public_Static_Boolean_InputHandle_t_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x00079A00 File Offset: 0x00077C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199494, XrefRangeEnd = 199498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetRemotePlaySessionID(InputHandle_t inputHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInput.NativeMethodInfoPtr_GetRemotePlaySessionID_Public_Static_UInt32_InputHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x0000BA8A File Offset: 0x00009C8A
		public SteamInput(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014A5 RID: 5285
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Boolean_0;

		// Token: 0x040014A6 RID: 5286
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Public_Static_Boolean_0;

		// Token: 0x040014A7 RID: 5287
		private static readonly IntPtr NativeMethodInfoPtr_RunFrame_Public_Static_Void_0;

		// Token: 0x040014A8 RID: 5288
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectedControllers_Public_Static_Int32_Il2CppStructArray_1_InputHandle_t_0;

		// Token: 0x040014A9 RID: 5289
		private static readonly IntPtr NativeMethodInfoPtr_GetActionSetHandle_Public_Static_InputActionSetHandle_t_String_0;

		// Token: 0x040014AA RID: 5290
		private static readonly IntPtr NativeMethodInfoPtr_ActivateActionSet_Public_Static_Void_InputHandle_t_InputActionSetHandle_t_0;

		// Token: 0x040014AB RID: 5291
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentActionSet_Public_Static_InputActionSetHandle_t_InputHandle_t_0;

		// Token: 0x040014AC RID: 5292
		private static readonly IntPtr NativeMethodInfoPtr_ActivateActionSetLayer_Public_Static_Void_InputHandle_t_InputActionSetHandle_t_0;

		// Token: 0x040014AD RID: 5293
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateActionSetLayer_Public_Static_Void_InputHandle_t_InputActionSetHandle_t_0;

		// Token: 0x040014AE RID: 5294
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateAllActionSetLayers_Public_Static_Void_InputHandle_t_0;

		// Token: 0x040014AF RID: 5295
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveActionSetLayers_Public_Static_Int32_InputHandle_t_Il2CppStructArray_1_InputActionSetHandle_t_0;

		// Token: 0x040014B0 RID: 5296
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionHandle_Public_Static_InputDigitalActionHandle_t_String_0;

		// Token: 0x040014B1 RID: 5297
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionData_Public_Static_InputDigitalActionData_t_InputHandle_t_InputDigitalActionHandle_t_0;

		// Token: 0x040014B2 RID: 5298
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionOrigins_Public_Static_Int32_InputHandle_t_InputActionSetHandle_t_InputDigitalActionHandle_t_Il2CppStructArray_1_EInputActionOrigin_0;

		// Token: 0x040014B3 RID: 5299
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionHandle_Public_Static_InputAnalogActionHandle_t_String_0;

		// Token: 0x040014B4 RID: 5300
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionData_Public_Static_InputAnalogActionData_t_InputHandle_t_InputAnalogActionHandle_t_0;

		// Token: 0x040014B5 RID: 5301
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionOrigins_Public_Static_Int32_InputHandle_t_InputActionSetHandle_t_InputAnalogActionHandle_t_Il2CppStructArray_1_EInputActionOrigin_0;

		// Token: 0x040014B6 RID: 5302
		private static readonly IntPtr NativeMethodInfoPtr_GetGlyphForActionOrigin_Public_Static_String_EInputActionOrigin_0;

		// Token: 0x040014B7 RID: 5303
		private static readonly IntPtr NativeMethodInfoPtr_GetStringForActionOrigin_Public_Static_String_EInputActionOrigin_0;

		// Token: 0x040014B8 RID: 5304
		private static readonly IntPtr NativeMethodInfoPtr_StopAnalogActionMomentum_Public_Static_Void_InputHandle_t_InputAnalogActionHandle_t_0;

		// Token: 0x040014B9 RID: 5305
		private static readonly IntPtr NativeMethodInfoPtr_GetMotionData_Public_Static_InputMotionData_t_InputHandle_t_0;

		// Token: 0x040014BA RID: 5306
		private static readonly IntPtr NativeMethodInfoPtr_TriggerVibration_Public_Static_Void_InputHandle_t_UInt16_UInt16_0;

		// Token: 0x040014BB RID: 5307
		private static readonly IntPtr NativeMethodInfoPtr_SetLEDColor_Public_Static_Void_InputHandle_t_Byte_Byte_Byte_UInt32_0;

		// Token: 0x040014BC RID: 5308
		private static readonly IntPtr NativeMethodInfoPtr_TriggerHapticPulse_Public_Static_Void_InputHandle_t_ESteamControllerPad_UInt16_0;

		// Token: 0x040014BD RID: 5309
		private static readonly IntPtr NativeMethodInfoPtr_TriggerRepeatedHapticPulse_Public_Static_Void_InputHandle_t_ESteamControllerPad_UInt16_UInt16_UInt16_UInt32_0;

		// Token: 0x040014BE RID: 5310
		private static readonly IntPtr NativeMethodInfoPtr_ShowBindingPanel_Public_Static_Boolean_InputHandle_t_0;

		// Token: 0x040014BF RID: 5311
		private static readonly IntPtr NativeMethodInfoPtr_GetInputTypeForHandle_Public_Static_ESteamInputType_InputHandle_t_0;

		// Token: 0x040014C0 RID: 5312
		private static readonly IntPtr NativeMethodInfoPtr_GetControllerForGamepadIndex_Public_Static_InputHandle_t_Int32_0;

		// Token: 0x040014C1 RID: 5313
		private static readonly IntPtr NativeMethodInfoPtr_GetGamepadIndexForController_Public_Static_Int32_InputHandle_t_0;

		// Token: 0x040014C2 RID: 5314
		private static readonly IntPtr NativeMethodInfoPtr_GetStringForXboxOrigin_Public_Static_String_EXboxOrigin_0;

		// Token: 0x040014C3 RID: 5315
		private static readonly IntPtr NativeMethodInfoPtr_GetGlyphForXboxOrigin_Public_Static_String_EXboxOrigin_0;

		// Token: 0x040014C4 RID: 5316
		private static readonly IntPtr NativeMethodInfoPtr_GetActionOriginFromXboxOrigin_Public_Static_EInputActionOrigin_InputHandle_t_EXboxOrigin_0;

		// Token: 0x040014C5 RID: 5317
		private static readonly IntPtr NativeMethodInfoPtr_TranslateActionOrigin_Public_Static_EInputActionOrigin_ESteamInputType_EInputActionOrigin_0;

		// Token: 0x040014C6 RID: 5318
		private static readonly IntPtr NativeMethodInfoPtr_GetDeviceBindingRevision_Public_Static_Boolean_InputHandle_t_byref_Int32_byref_Int32_0;

		// Token: 0x040014C7 RID: 5319
		private static readonly IntPtr NativeMethodInfoPtr_GetRemotePlaySessionID_Public_Static_UInt32_InputHandle_t_0;
	}
}
