using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200014B RID: 331
	public static class SteamController : Object
	{
		// Token: 0x0600186F RID: 6255 RVA: 0x0006BB98 File Offset: 0x00069D98
		// Note: this type is marked as 'beforefieldinit'.
		static SteamController()
		{
			Il2CppClassPointerStore<SteamController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamController>.NativeClassPtr);
			SteamController.NativeMethodInfoPtr_Init_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666293);
			SteamController.NativeMethodInfoPtr_Shutdown_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666294);
			SteamController.NativeMethodInfoPtr_RunFrame_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666295);
			SteamController.NativeMethodInfoPtr_GetConnectedControllers_Public_Static_Int32_Il2CppStructArray_1_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666296);
			SteamController.NativeMethodInfoPtr_GetActionSetHandle_Public_Static_ControllerActionSetHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666297);
			SteamController.NativeMethodInfoPtr_ActivateActionSet_Public_Static_Void_ControllerHandle_t_ControllerActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666298);
			SteamController.NativeMethodInfoPtr_GetCurrentActionSet_Public_Static_ControllerActionSetHandle_t_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666299);
			SteamController.NativeMethodInfoPtr_ActivateActionSetLayer_Public_Static_Void_ControllerHandle_t_ControllerActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666300);
			SteamController.NativeMethodInfoPtr_DeactivateActionSetLayer_Public_Static_Void_ControllerHandle_t_ControllerActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666301);
			SteamController.NativeMethodInfoPtr_DeactivateAllActionSetLayers_Public_Static_Void_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666302);
			SteamController.NativeMethodInfoPtr_GetActiveActionSetLayers_Public_Static_Int32_ControllerHandle_t_Il2CppStructArray_1_ControllerActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666303);
			SteamController.NativeMethodInfoPtr_GetDigitalActionHandle_Public_Static_ControllerDigitalActionHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666304);
			SteamController.NativeMethodInfoPtr_GetDigitalActionData_Public_Static_InputDigitalActionData_t_ControllerHandle_t_ControllerDigitalActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666305);
			SteamController.NativeMethodInfoPtr_GetDigitalActionOrigins_Public_Static_Int32_ControllerHandle_t_ControllerActionSetHandle_t_ControllerDigitalActionHandle_t_Il2CppStructArray_1_EControllerActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666306);
			SteamController.NativeMethodInfoPtr_GetAnalogActionHandle_Public_Static_ControllerAnalogActionHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666307);
			SteamController.NativeMethodInfoPtr_GetAnalogActionData_Public_Static_InputAnalogActionData_t_ControllerHandle_t_ControllerAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666308);
			SteamController.NativeMethodInfoPtr_GetAnalogActionOrigins_Public_Static_Int32_ControllerHandle_t_ControllerActionSetHandle_t_ControllerAnalogActionHandle_t_Il2CppStructArray_1_EControllerActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666309);
			SteamController.NativeMethodInfoPtr_GetGlyphForActionOrigin_Public_Static_String_EControllerActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666310);
			SteamController.NativeMethodInfoPtr_GetStringForActionOrigin_Public_Static_String_EControllerActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666311);
			SteamController.NativeMethodInfoPtr_StopAnalogActionMomentum_Public_Static_Void_ControllerHandle_t_ControllerAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666312);
			SteamController.NativeMethodInfoPtr_GetMotionData_Public_Static_InputMotionData_t_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666313);
			SteamController.NativeMethodInfoPtr_TriggerHapticPulse_Public_Static_Void_ControllerHandle_t_ESteamControllerPad_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666314);
			SteamController.NativeMethodInfoPtr_TriggerRepeatedHapticPulse_Public_Static_Void_ControllerHandle_t_ESteamControllerPad_UInt16_UInt16_UInt16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666315);
			SteamController.NativeMethodInfoPtr_TriggerVibration_Public_Static_Void_ControllerHandle_t_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666316);
			SteamController.NativeMethodInfoPtr_SetLEDColor_Public_Static_Void_ControllerHandle_t_Byte_Byte_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666317);
			SteamController.NativeMethodInfoPtr_ShowBindingPanel_Public_Static_Boolean_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666318);
			SteamController.NativeMethodInfoPtr_GetInputTypeForHandle_Public_Static_ESteamInputType_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666319);
			SteamController.NativeMethodInfoPtr_GetControllerForGamepadIndex_Public_Static_ControllerHandle_t_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666320);
			SteamController.NativeMethodInfoPtr_GetGamepadIndexForController_Public_Static_Int32_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666321);
			SteamController.NativeMethodInfoPtr_GetStringForXboxOrigin_Public_Static_String_EXboxOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666322);
			SteamController.NativeMethodInfoPtr_GetGlyphForXboxOrigin_Public_Static_String_EXboxOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666323);
			SteamController.NativeMethodInfoPtr_GetActionOriginFromXboxOrigin_Public_Static_EControllerActionOrigin_ControllerHandle_t_EXboxOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666324);
			SteamController.NativeMethodInfoPtr_TranslateActionOrigin_Public_Static_EControllerActionOrigin_ESteamInputType_EControllerActionOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666325);
			SteamController.NativeMethodInfoPtr_GetControllerBindingRevision_Public_Static_Boolean_ControllerHandle_t_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamController>.NativeClassPtr, 100666326);
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x0006BE70 File Offset: 0x0006A070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195498, XrefRangeEnd = 195502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_Init_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x0006BEA0 File Offset: 0x0006A0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195502, XrefRangeEnd = 195506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Shutdown()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_Shutdown_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x0006BED0 File Offset: 0x0006A0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195506, XrefRangeEnd = 195510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RunFrame()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_RunFrame_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x0006BEF8 File Offset: 0x0006A0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195510, XrefRangeEnd = 195520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetConnectedControllers(Il2CppStructArray<ControllerHandle_t> handlesOut)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handlesOut);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetConnectedControllers_Public_Static_Int32_Il2CppStructArray_1_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x0006BF3C File Offset: 0x0006A13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195520, XrefRangeEnd = 195533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerActionSetHandle_t GetActionSetHandle(string pszActionSetName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszActionSetName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetActionSetHandle_Public_Static_ControllerActionSetHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x0006BF80 File Offset: 0x0006A180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195533, XrefRangeEnd = 195537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ActivateActionSet(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_ActivateActionSet_Public_Static_Void_ControllerHandle_t_ControllerActionSetHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x0006BFC0 File Offset: 0x0006A1C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195537, XrefRangeEnd = 195542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerActionSetHandle_t GetCurrentActionSet(ControllerHandle_t controllerHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetCurrentActionSet_Public_Static_ControllerActionSetHandle_t_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x0006C000 File Offset: 0x0006A200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195542, XrefRangeEnd = 195546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ActivateActionSetLayer(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetLayerHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetLayerHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_ActivateActionSetLayer_Public_Static_Void_ControllerHandle_t_ControllerActionSetHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x0006C040 File Offset: 0x0006A240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195546, XrefRangeEnd = 195550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeactivateActionSetLayer(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetLayerHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetLayerHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_DeactivateActionSetLayer_Public_Static_Void_ControllerHandle_t_ControllerActionSetHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x0006C080 File Offset: 0x0006A280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195550, XrefRangeEnd = 195554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeactivateAllActionSetLayers(ControllerHandle_t controllerHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_DeactivateAllActionSetLayers_Public_Static_Void_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x0006C0B4 File Offset: 0x0006A2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195554, XrefRangeEnd = 195564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetActiveActionSetLayers(ControllerHandle_t controllerHandle, Il2CppStructArray<ControllerActionSetHandle_t> handlesOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handlesOut);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetActiveActionSetLayers_Public_Static_Int32_ControllerHandle_t_Il2CppStructArray_1_ControllerActionSetHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x0006C104 File Offset: 0x0006A304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195564, XrefRangeEnd = 195577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerDigitalActionHandle_t GetDigitalActionHandle(string pszActionName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszActionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetDigitalActionHandle_Public_Static_ControllerDigitalActionHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x0006C148 File Offset: 0x0006A348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195577, XrefRangeEnd = 195581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputDigitalActionData_t GetDigitalActionData(ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitalActionHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetDigitalActionData_Public_Static_InputDigitalActionData_t_ControllerHandle_t_ControllerDigitalActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x0006C194 File Offset: 0x0006A394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195581, XrefRangeEnd = 195585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetDigitalActionOrigins(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerDigitalActionHandle_t digitalActionHandle, Il2CppStructArray<EControllerActionOrigin> originsOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digitalActionHandle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(originsOut);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetDigitalActionOrigins_Public_Static_Int32_ControllerHandle_t_ControllerActionSetHandle_t_ControllerDigitalActionHandle_t_Il2CppStructArray_1_EControllerActionOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x0006C200 File Offset: 0x0006A400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195585, XrefRangeEnd = 195598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerAnalogActionHandle_t GetAnalogActionHandle(string pszActionName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszActionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetAnalogActionHandle_Public_Static_ControllerAnalogActionHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x0006C244 File Offset: 0x0006A444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195598, XrefRangeEnd = 195602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputAnalogActionData_t GetAnalogActionData(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref analogActionHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetAnalogActionData_Public_Static_InputAnalogActionData_t_ControllerHandle_t_ControllerAnalogActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x0006C290 File Offset: 0x0006A490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195602, XrefRangeEnd = 195606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAnalogActionOrigins(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerAnalogActionHandle_t analogActionHandle, Il2CppStructArray<EControllerActionOrigin> originsOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionSetHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref analogActionHandle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(originsOut);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetAnalogActionOrigins_Public_Static_Int32_ControllerHandle_t_ControllerActionSetHandle_t_ControllerAnalogActionHandle_t_Il2CppStructArray_1_EControllerActionOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x0006C2FC File Offset: 0x0006A4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195606, XrefRangeEnd = 195611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetGlyphForActionOrigin(EControllerActionOrigin eOrigin)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eOrigin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetGlyphForActionOrigin_Public_Static_String_EControllerActionOrigin_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x0006C334 File Offset: 0x0006A534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195611, XrefRangeEnd = 195616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStringForActionOrigin(EControllerActionOrigin eOrigin)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eOrigin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetStringForActionOrigin_Public_Static_String_EControllerActionOrigin_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x0006C36C File Offset: 0x0006A56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195616, XrefRangeEnd = 195620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StopAnalogActionMomentum(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t eAction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_StopAnalogActionMomentum_Public_Static_Void_ControllerHandle_t_ControllerAnalogActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x0006C3AC File Offset: 0x0006A5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195620, XrefRangeEnd = 195624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputMotionData_t GetMotionData(ControllerHandle_t controllerHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetMotionData_Public_Static_InputMotionData_t_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x0006C3EC File Offset: 0x0006A5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195624, XrefRangeEnd = 195628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TriggerHapticPulse(ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eTargetPad;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usDurationMicroSec;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_TriggerHapticPulse_Public_Static_Void_ControllerHandle_t_ESteamControllerPad_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x0006C43C File Offset: 0x0006A63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195628, XrefRangeEnd = 195632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TriggerRepeatedHapticPulse(ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eTargetPad;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usDurationMicroSec;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usOffMicroSec;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unRepeat;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_TriggerRepeatedHapticPulse_Public_Static_Void_ControllerHandle_t_ESteamControllerPad_UInt16_UInt16_UInt16_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x0006C4B4 File Offset: 0x0006A6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195632, XrefRangeEnd = 195636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TriggerVibration(ControllerHandle_t controllerHandle, ushort usLeftSpeed, ushort usRightSpeed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usLeftSpeed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usRightSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_TriggerVibration_Public_Static_Void_ControllerHandle_t_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x0006C504 File Offset: 0x0006A704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195636, XrefRangeEnd = 195640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLEDColor(ControllerHandle_t controllerHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nColorR;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nColorG;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nColorB;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_SetLEDColor_Public_Static_Void_ControllerHandle_t_Byte_Byte_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x0006C570 File Offset: 0x0006A770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195640, XrefRangeEnd = 195644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShowBindingPanel(ControllerHandle_t controllerHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_ShowBindingPanel_Public_Static_Boolean_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x0006C5B0 File Offset: 0x0006A7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195644, XrefRangeEnd = 195648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ESteamInputType GetInputTypeForHandle(ControllerHandle_t controllerHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetInputTypeForHandle_Public_Static_ESteamInputType_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x0006C5F0 File Offset: 0x0006A7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195648, XrefRangeEnd = 195653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerHandle_t GetControllerForGamepadIndex(int nIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetControllerForGamepadIndex_Public_Static_ControllerHandle_t_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x0006C630 File Offset: 0x0006A830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195653, XrefRangeEnd = 195657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGamepadIndexForController(ControllerHandle_t ulControllerHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ulControllerHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetGamepadIndexForController_Public_Static_Int32_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x0006C670 File Offset: 0x0006A870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195657, XrefRangeEnd = 195662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStringForXboxOrigin(EXboxOrigin eOrigin)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eOrigin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetStringForXboxOrigin_Public_Static_String_EXboxOrigin_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x0006C6A8 File Offset: 0x0006A8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195662, XrefRangeEnd = 195667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetGlyphForXboxOrigin(EXboxOrigin eOrigin)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eOrigin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetGlyphForXboxOrigin_Public_Static_String_EXboxOrigin_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x0006C6E0 File Offset: 0x0006A8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195667, XrefRangeEnd = 195671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EControllerActionOrigin GetActionOriginFromXboxOrigin(ControllerHandle_t controllerHandle, EXboxOrigin eOrigin)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eOrigin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetActionOriginFromXboxOrigin_Public_Static_EControllerActionOrigin_ControllerHandle_t_EXboxOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x0006C72C File Offset: 0x0006A92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195671, XrefRangeEnd = 195675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EControllerActionOrigin TranslateActionOrigin(ESteamInputType eDestinationInputType, EControllerActionOrigin eSourceOrigin)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eDestinationInputType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eSourceOrigin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_TranslateActionOrigin_Public_Static_EControllerActionOrigin_ESteamInputType_EControllerActionOrigin_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x0006C778 File Offset: 0x0006A978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195675, XrefRangeEnd = 195679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetControllerBindingRevision(ControllerHandle_t controllerHandle, out int pMajor, out int pMinor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pMajor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pMinor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamController.NativeMethodInfoPtr_GetControllerBindingRevision_Public_Static_Boolean_ControllerHandle_t_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x0000BA03 File Offset: 0x00009C03
		public SteamController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001281 RID: 4737
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Boolean_0;

		// Token: 0x04001282 RID: 4738
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Public_Static_Boolean_0;

		// Token: 0x04001283 RID: 4739
		private static readonly IntPtr NativeMethodInfoPtr_RunFrame_Public_Static_Void_0;

		// Token: 0x04001284 RID: 4740
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectedControllers_Public_Static_Int32_Il2CppStructArray_1_ControllerHandle_t_0;

		// Token: 0x04001285 RID: 4741
		private static readonly IntPtr NativeMethodInfoPtr_GetActionSetHandle_Public_Static_ControllerActionSetHandle_t_String_0;

		// Token: 0x04001286 RID: 4742
		private static readonly IntPtr NativeMethodInfoPtr_ActivateActionSet_Public_Static_Void_ControllerHandle_t_ControllerActionSetHandle_t_0;

		// Token: 0x04001287 RID: 4743
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentActionSet_Public_Static_ControllerActionSetHandle_t_ControllerHandle_t_0;

		// Token: 0x04001288 RID: 4744
		private static readonly IntPtr NativeMethodInfoPtr_ActivateActionSetLayer_Public_Static_Void_ControllerHandle_t_ControllerActionSetHandle_t_0;

		// Token: 0x04001289 RID: 4745
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateActionSetLayer_Public_Static_Void_ControllerHandle_t_ControllerActionSetHandle_t_0;

		// Token: 0x0400128A RID: 4746
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateAllActionSetLayers_Public_Static_Void_ControllerHandle_t_0;

		// Token: 0x0400128B RID: 4747
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveActionSetLayers_Public_Static_Int32_ControllerHandle_t_Il2CppStructArray_1_ControllerActionSetHandle_t_0;

		// Token: 0x0400128C RID: 4748
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionHandle_Public_Static_ControllerDigitalActionHandle_t_String_0;

		// Token: 0x0400128D RID: 4749
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionData_Public_Static_InputDigitalActionData_t_ControllerHandle_t_ControllerDigitalActionHandle_t_0;

		// Token: 0x0400128E RID: 4750
		private static readonly IntPtr NativeMethodInfoPtr_GetDigitalActionOrigins_Public_Static_Int32_ControllerHandle_t_ControllerActionSetHandle_t_ControllerDigitalActionHandle_t_Il2CppStructArray_1_EControllerActionOrigin_0;

		// Token: 0x0400128F RID: 4751
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionHandle_Public_Static_ControllerAnalogActionHandle_t_String_0;

		// Token: 0x04001290 RID: 4752
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionData_Public_Static_InputAnalogActionData_t_ControllerHandle_t_ControllerAnalogActionHandle_t_0;

		// Token: 0x04001291 RID: 4753
		private static readonly IntPtr NativeMethodInfoPtr_GetAnalogActionOrigins_Public_Static_Int32_ControllerHandle_t_ControllerActionSetHandle_t_ControllerAnalogActionHandle_t_Il2CppStructArray_1_EControllerActionOrigin_0;

		// Token: 0x04001292 RID: 4754
		private static readonly IntPtr NativeMethodInfoPtr_GetGlyphForActionOrigin_Public_Static_String_EControllerActionOrigin_0;

		// Token: 0x04001293 RID: 4755
		private static readonly IntPtr NativeMethodInfoPtr_GetStringForActionOrigin_Public_Static_String_EControllerActionOrigin_0;

		// Token: 0x04001294 RID: 4756
		private static readonly IntPtr NativeMethodInfoPtr_StopAnalogActionMomentum_Public_Static_Void_ControllerHandle_t_ControllerAnalogActionHandle_t_0;

		// Token: 0x04001295 RID: 4757
		private static readonly IntPtr NativeMethodInfoPtr_GetMotionData_Public_Static_InputMotionData_t_ControllerHandle_t_0;

		// Token: 0x04001296 RID: 4758
		private static readonly IntPtr NativeMethodInfoPtr_TriggerHapticPulse_Public_Static_Void_ControllerHandle_t_ESteamControllerPad_UInt16_0;

		// Token: 0x04001297 RID: 4759
		private static readonly IntPtr NativeMethodInfoPtr_TriggerRepeatedHapticPulse_Public_Static_Void_ControllerHandle_t_ESteamControllerPad_UInt16_UInt16_UInt16_UInt32_0;

		// Token: 0x04001298 RID: 4760
		private static readonly IntPtr NativeMethodInfoPtr_TriggerVibration_Public_Static_Void_ControllerHandle_t_UInt16_UInt16_0;

		// Token: 0x04001299 RID: 4761
		private static readonly IntPtr NativeMethodInfoPtr_SetLEDColor_Public_Static_Void_ControllerHandle_t_Byte_Byte_Byte_UInt32_0;

		// Token: 0x0400129A RID: 4762
		private static readonly IntPtr NativeMethodInfoPtr_ShowBindingPanel_Public_Static_Boolean_ControllerHandle_t_0;

		// Token: 0x0400129B RID: 4763
		private static readonly IntPtr NativeMethodInfoPtr_GetInputTypeForHandle_Public_Static_ESteamInputType_ControllerHandle_t_0;

		// Token: 0x0400129C RID: 4764
		private static readonly IntPtr NativeMethodInfoPtr_GetControllerForGamepadIndex_Public_Static_ControllerHandle_t_Int32_0;

		// Token: 0x0400129D RID: 4765
		private static readonly IntPtr NativeMethodInfoPtr_GetGamepadIndexForController_Public_Static_Int32_ControllerHandle_t_0;

		// Token: 0x0400129E RID: 4766
		private static readonly IntPtr NativeMethodInfoPtr_GetStringForXboxOrigin_Public_Static_String_EXboxOrigin_0;

		// Token: 0x0400129F RID: 4767
		private static readonly IntPtr NativeMethodInfoPtr_GetGlyphForXboxOrigin_Public_Static_String_EXboxOrigin_0;

		// Token: 0x040012A0 RID: 4768
		private static readonly IntPtr NativeMethodInfoPtr_GetActionOriginFromXboxOrigin_Public_Static_EControllerActionOrigin_ControllerHandle_t_EXboxOrigin_0;

		// Token: 0x040012A1 RID: 4769
		private static readonly IntPtr NativeMethodInfoPtr_TranslateActionOrigin_Public_Static_EControllerActionOrigin_ESteamInputType_EControllerActionOrigin_0;

		// Token: 0x040012A2 RID: 4770
		private static readonly IntPtr NativeMethodInfoPtr_GetControllerBindingRevision_Public_Static_Boolean_ControllerHandle_t_byref_Int32_byref_Int32_0;
	}
}
