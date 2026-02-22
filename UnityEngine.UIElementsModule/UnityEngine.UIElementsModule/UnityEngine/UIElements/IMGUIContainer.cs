using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000011 RID: 17
	public class IMGUIContainer : VisualElement
	{
		// Token: 0x060000C1 RID: 193 RVA: 0x0000F10C File Offset: 0x0000D30C
		// Note: this type is marked as 'beforefieldinit'.
		static IMGUIContainer()
		{
			Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IMGUIContainer");
			IMGUIContainer.NativeFieldInfoPtr_m_OnGUIHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "m_OnGUIHandler");
			IMGUIContainer.NativeFieldInfoPtr_m_ObjectGUIState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "m_ObjectGUIState");
			IMGUIContainer.NativeFieldInfoPtr_useOwnerObjectGUIState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "useOwnerObjectGUIState");
			IMGUIContainer.NativeFieldInfoPtr__lastWorldClip_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "<lastWorldClip>k__BackingField");
			IMGUIContainer.NativeFieldInfoPtr_m_CullingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "m_CullingEnabled");
			IMGUIContainer.NativeFieldInfoPtr_m_IsFocusDelegated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "m_IsFocusDelegated");
			IMGUIContainer.NativeFieldInfoPtr_m_RefreshCachedLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "m_RefreshCachedLayout");
			IMGUIContainer.NativeFieldInfoPtr_m_Cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "m_Cache");
			IMGUIContainer.NativeFieldInfoPtr_m_CachedClippingRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "m_CachedClippingRect");
			IMGUIContainer.NativeFieldInfoPtr_m_CachedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "m_CachedTransform");
			IMGUIContainer.NativeFieldInfoPtr__contextType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "<contextType>k__BackingField");
			IMGUIContainer.NativeFieldInfoPtr_lostFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "lostFocus");
			IMGUIContainer.NativeFieldInfoPtr_receivedFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "receivedFocus");
			IMGUIContainer.NativeFieldInfoPtr_focusChangeDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "focusChangeDirection");
			IMGUIContainer.NativeFieldInfoPtr_hasFocusableControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "hasFocusableControls");
			IMGUIContainer.NativeFieldInfoPtr_newKeyboardFocusControlID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "newKeyboardFocusControlID");
			IMGUIContainer.NativeFieldInfoPtr__focusOnlyIfHasFocusableControls_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "<focusOnlyIfHasFocusableControls>k__BackingField");
			IMGUIContainer.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "ussClassName");
			IMGUIContainer.NativeFieldInfoPtr_ussFoldoutChildDepthClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "ussFoldoutChildDepthClassName");
			IMGUIContainer.NativeFieldInfoPtr_ussFoldoutChildDepthClassNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "ussFoldoutChildDepthClassNames");
			IMGUIContainer.NativeFieldInfoPtr_m_GUIGlobals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "m_GUIGlobals");
			IMGUIContainer.NativeMethodInfoPtr_get_onGUIHandler_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663364);
			IMGUIContainer.NativeMethodInfoPtr_get_guiState_Internal_get_ObjectGUIState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663365);
			IMGUIContainer.NativeMethodInfoPtr_get_lastWorldClip_Internal_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663366);
			IMGUIContainer.NativeMethodInfoPtr_get_cache_Private_get_LayoutCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663367);
			IMGUIContainer.NativeMethodInfoPtr_get_layoutMeasuredWidth_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663368);
			IMGUIContainer.NativeMethodInfoPtr_get_layoutMeasuredHeight_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663369);
			IMGUIContainer.NativeMethodInfoPtr_get_contextType_Public_get_ContextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663370);
			IMGUIContainer.NativeMethodInfoPtr_get_focusOnlyIfHasFocusableControls_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663371);
			IMGUIContainer.NativeMethodInfoPtr_SaveGlobals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663373);
			IMGUIContainer.NativeMethodInfoPtr_RestoreGlobals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663374);
			IMGUIContainer.NativeMethodInfoPtr_DoOnGUI_Private_Void_Event_Matrix4x4_Rect_Boolean_Rect_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663375);
			IMGUIContainer.NativeMethodInfoPtr_MarkDirtyLayout_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663376);
			IMGUIContainer.NativeMethodInfoPtr_SendEventToIMGUI_Internal_Boolean_EventBase_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663377);
			IMGUIContainer.NativeMethodInfoPtr_SendEventToIMGUIRaw_Private_Boolean_EventBase_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663378);
			IMGUIContainer.NativeMethodInfoPtr_VerifyBounds_Private_Boolean_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663379);
			IMGUIContainer.NativeMethodInfoPtr_IsContainerCapturingTheMouse_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663380);
			IMGUIContainer.NativeMethodInfoPtr_IsLocalEvent_Private_Boolean_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663381);
			IMGUIContainer.NativeMethodInfoPtr_IsEventInsideLocalWindow_Private_Boolean_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663382);
			IMGUIContainer.NativeMethodInfoPtr_HandleIMGUIEvent_Private_Boolean_Event_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663383);
			IMGUIContainer.NativeMethodInfoPtr_HandleIMGUIEvent_Internal_Boolean_Event_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663384);
			IMGUIContainer.NativeMethodInfoPtr_HandleIMGUIEvent_Private_Boolean_Event_Matrix4x4_Rect_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663385);
			IMGUIContainer.NativeMethodInfoPtr_GetCurrentClipRect_Private_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663386);
			IMGUIContainer.NativeMethodInfoPtr_GetCurrentTransformAndClip_Private_Static_Void_IMGUIContainer_Event_byref_Matrix4x4_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663387);
			IMGUIContainer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663388);
			IMGUIContainer.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663389);
			IMGUIContainer.NativeMethodInfoPtr__DoOnGUI_b__55_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, 100663390);
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000F4E0 File Offset: 0x0000D6E0
		public unsafe Action onGUIHandler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_get_onGUIHandler_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000F520 File Offset: 0x0000D720
		public unsafe ObjectGUIState guiState
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 91370, RefRangeEnd = 91371, XrefRangeStart = 91362, XrefRangeEnd = 91370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_get_guiState_Internal_get_ObjectGUIState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectGUIState>(intPtr3) : null;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000F560 File Offset: 0x0000D760
		// (set) Token: 0x06000107 RID: 263 RVA: 0x0000284C File Offset: 0x00000A4C
		public unsafe Rect lastWorldClip
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_get_lastWorldClip_Internal_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._lastWorldClip_k__BackingField = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x0000F59C File Offset: 0x0000D79C
		public unsafe GUILayoutUtility.LayoutCache cache
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 91375, RefRangeEnd = 91377, XrefRangeStart = 91371, XrefRangeEnd = 91375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_get_cache_Private_get_LayoutCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUILayoutUtility.LayoutCache>(intPtr3) : null;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0000F5DC File Offset: 0x0000D7DC
		public unsafe float layoutMeasuredWidth
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 91383, RefRangeEnd = 91385, XrefRangeStart = 91377, XrefRangeEnd = 91383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_get_layoutMeasuredWidth_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x0000F618 File Offset: 0x0000D818
		public unsafe float layoutMeasuredHeight
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 91391, RefRangeEnd = 91393, XrefRangeStart = 91385, XrefRangeEnd = 91391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_get_layoutMeasuredHeight_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0000F654 File Offset: 0x0000D854
		// (set) Token: 0x0600010A RID: 266 RVA: 0x0000286B File Offset: 0x00000A6B
		public unsafe ContextType contextType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_get_contextType_Public_get_ContextType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._contextType_k__BackingField = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000F690 File Offset: 0x0000D890
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00002874 File Offset: 0x00000A74
		public unsafe bool focusOnlyIfHasFocusableControls
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_get_focusOnlyIfHasFocusableControls_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._focusOnlyIfHasFocusableControls_k__BackingField = value;
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000F6CC File Offset: 0x0000D8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91393, XrefRangeEnd = 91405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveGlobals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_SaveGlobals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000F700 File Offset: 0x0000D900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91405, XrefRangeEnd = 91417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreGlobals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_RestoreGlobals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000F734 File Offset: 0x0000D934
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91594, RefRangeEnd = 91596, XrefRangeStart = 91417, XrefRangeEnd = 91594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoOnGUI(Event evt, Matrix4x4 parentTransform, Rect clippingRect, bool isComputingLayout, Rect layoutSize, Action onGUIHandler, bool canAffectFocus = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parentTransform;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clippingRect;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isComputingLayout;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layoutSize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onGUIHandler);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canAffectFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_DoOnGUI_Private_Void_Event_Matrix4x4_Rect_Boolean_Rect_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000F7D0 File Offset: 0x0000D9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91596, XrefRangeEnd = 91597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkDirtyLayout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_MarkDirtyLayout_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000F804 File Offset: 0x0000DA04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91620, RefRangeEnd = 91622, XrefRangeStart = 91597, XrefRangeEnd = 91620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendEventToIMGUI(EventBase evt, bool canAffectFocus = true, bool verifyBounds = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canAffectFocus;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref verifyBounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_SendEventToIMGUI_Internal_Boolean_EventBase_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000F870 File Offset: 0x0000DA70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91636, RefRangeEnd = 91638, XrefRangeStart = 91622, XrefRangeEnd = 91636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendEventToIMGUIRaw(EventBase evt, bool canAffectFocus, bool verifyBounds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canAffectFocus;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref verifyBounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_SendEventToIMGUIRaw_Private_Boolean_EventBase_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000F8DC File Offset: 0x0000DADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91638, XrefRangeEnd = 91649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool VerifyBounds(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_VerifyBounds_Private_Boolean_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000F92C File Offset: 0x0000DB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91649, XrefRangeEnd = 91657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsContainerCapturingTheMouse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_IsContainerCapturingTheMouse_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000F968 File Offset: 0x0000DB68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91693, RefRangeEnd = 91695, XrefRangeStart = 91657, XrefRangeEnd = 91693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLocalEvent(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_IsLocalEvent_Private_Boolean_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000F9B8 File Offset: 0x0000DBB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91716, RefRangeEnd = 91718, XrefRangeStart = 91695, XrefRangeEnd = 91716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEventInsideLocalWindow(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_IsEventInsideLocalWindow_Private_Boolean_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000FA08 File Offset: 0x0000DC08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91730, RefRangeEnd = 91731, XrefRangeStart = 91718, XrefRangeEnd = 91730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleIMGUIEvent(Event e, bool canAffectFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canAffectFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_HandleIMGUIEvent_Private_Boolean_Event_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000FA64 File Offset: 0x0000DC64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91743, RefRangeEnd = 91744, XrefRangeStart = 91731, XrefRangeEnd = 91743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleIMGUIEvent(Event e, Action onGUIHandler, bool canAffectFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onGUIHandler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canAffectFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_HandleIMGUIEvent_Internal_Boolean_Event_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000FAD4 File Offset: 0x0000DCD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91788, RefRangeEnd = 91790, XrefRangeStart = 91744, XrefRangeEnd = 91788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleIMGUIEvent(Event e, Matrix4x4 worldTransform, Rect clippingRect, Action onGUIHandler, bool canAffectFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldTransform;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clippingRect;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onGUIHandler);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canAffectFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_HandleIMGUIEvent_Private_Boolean_Event_Matrix4x4_Rect_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000FB60 File Offset: 0x0000DD60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91790, XrefRangeEnd = 91794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect GetCurrentClipRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_GetCurrentClipRect_Private_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000FB9C File Offset: 0x0000DD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91794, XrefRangeEnd = 91802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetCurrentTransformAndClip(IMGUIContainer container, Event evt, out Matrix4x4 transform, out Rect clipRect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &transform;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &clipRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_GetCurrentTransformAndClip_Private_Static_Void_IMGUIContainer_Event_byref_Matrix4x4_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000FC00 File Offset: 0x0000DE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91802, XrefRangeEnd = 91806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000FC34 File Offset: 0x0000DE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91806, XrefRangeEnd = 91807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposeManaged)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposeManaged;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMGUIContainer.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000FC80 File Offset: 0x0000DE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91807, XrefRangeEnd = 91808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _DoOnGUI_b__55_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IMGUIContainer.NativeMethodInfoPtr__DoOnGUI_b__55_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002617 File Offset: 0x00000817
		public IMGUIContainer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000DD RID: 221 RVA: 0x0000FCB4 File Offset: 0x0000DEB4
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00002620 File Offset: 0x00000820
		public unsafe Action m_OnGUIHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_OnGUIHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_OnGUIHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0000FCE4 File Offset: 0x0000DEE4
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x0000263F File Offset: 0x0000083F
		public unsafe ObjectGUIState m_ObjectGUIState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_ObjectGUIState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectGUIState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_ObjectGUIState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000FD14 File Offset: 0x0000DF14
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x0000265E File Offset: 0x0000085E
		public unsafe bool useOwnerObjectGUIState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_useOwnerObjectGUIState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_useOwnerObjectGUIState)) = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000FD3C File Offset: 0x0000DF3C
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00002679 File Offset: 0x00000879
		public unsafe Rect _lastWorldClip_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr__lastWorldClip_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr__lastWorldClip_k__BackingField)) = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000FD64 File Offset: 0x0000DF64
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00002694 File Offset: 0x00000894
		public unsafe bool m_CullingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_CullingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_CullingEnabled)) = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000FD8C File Offset: 0x0000DF8C
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x000026AF File Offset: 0x000008AF
		public unsafe bool m_IsFocusDelegated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_IsFocusDelegated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_IsFocusDelegated)) = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000FDB4 File Offset: 0x0000DFB4
		// (set) Token: 0x060000EA RID: 234 RVA: 0x000026CA File Offset: 0x000008CA
		public unsafe bool m_RefreshCachedLayout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_RefreshCachedLayout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_RefreshCachedLayout)) = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0000FDDC File Offset: 0x0000DFDC
		// (set) Token: 0x060000EC RID: 236 RVA: 0x000026E5 File Offset: 0x000008E5
		public unsafe GUILayoutUtility.LayoutCache m_Cache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_Cache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUILayoutUtility.LayoutCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_Cache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000FE0C File Offset: 0x0000E00C
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00002704 File Offset: 0x00000904
		public unsafe Rect m_CachedClippingRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_CachedClippingRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_CachedClippingRect)) = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000FE34 File Offset: 0x0000E034
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000271F File Offset: 0x0000091F
		public unsafe Matrix4x4 m_CachedTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_CachedTransform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_CachedTransform)) = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000FE5C File Offset: 0x0000E05C
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000273A File Offset: 0x0000093A
		public unsafe ContextType _contextType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr__contextType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr__contextType_k__BackingField)) = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000FE84 File Offset: 0x0000E084
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00002755 File Offset: 0x00000955
		public unsafe bool lostFocus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_lostFocus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_lostFocus)) = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000FEAC File Offset: 0x0000E0AC
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00002770 File Offset: 0x00000970
		public unsafe bool receivedFocus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_receivedFocus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_receivedFocus)) = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000FED4 File Offset: 0x0000E0D4
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0000278B File Offset: 0x0000098B
		public unsafe FocusChangeDirection focusChangeDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_focusChangeDirection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FocusChangeDirection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_focusChangeDirection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000FF04 File Offset: 0x0000E104
		// (set) Token: 0x060000FA RID: 250 RVA: 0x000027AA File Offset: 0x000009AA
		public unsafe bool hasFocusableControls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_hasFocusableControls);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_hasFocusableControls)) = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0000FF2C File Offset: 0x0000E12C
		// (set) Token: 0x060000FC RID: 252 RVA: 0x000027C5 File Offset: 0x000009C5
		public unsafe int newKeyboardFocusControlID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_newKeyboardFocusControlID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_newKeyboardFocusControlID)) = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000FF54 File Offset: 0x0000E154
		// (set) Token: 0x060000FE RID: 254 RVA: 0x000027E0 File Offset: 0x000009E0
		public unsafe bool _focusOnlyIfHasFocusableControls_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr__focusOnlyIfHasFocusableControls_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr__focusOnlyIfHasFocusableControls_k__BackingField)) = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0000FF7C File Offset: 0x0000E17C
		// (set) Token: 0x06000100 RID: 256 RVA: 0x000027FB File Offset: 0x000009FB
		public unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IMGUIContainer.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IMGUIContainer.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0000FF9C File Offset: 0x0000E19C
		// (set) Token: 0x06000102 RID: 258 RVA: 0x0000280D File Offset: 0x00000A0D
		public unsafe static string ussFoldoutChildDepthClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IMGUIContainer.NativeFieldInfoPtr_ussFoldoutChildDepthClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IMGUIContainer.NativeFieldInfoPtr_ussFoldoutChildDepthClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0000FFBC File Offset: 0x0000E1BC
		// (set) Token: 0x06000104 RID: 260 RVA: 0x0000281F File Offset: 0x00000A1F
		public unsafe static List<string> ussFoldoutChildDepthClassNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IMGUIContainer.NativeFieldInfoPtr_ussFoldoutChildDepthClassNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IMGUIContainer.NativeFieldInfoPtr_ussFoldoutChildDepthClassNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0000FFE4 File Offset: 0x0000E1E4
		// (set) Token: 0x06000106 RID: 262 RVA: 0x00002831 File Offset: 0x00000A31
		public unsafe IMGUIContainer.GUIGlobals m_GUIGlobals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_GUIGlobals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IMGUIContainer.NativeFieldInfoPtr_m_GUIGlobals)) = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000108 RID: 264 RVA: 0x0001000C File Offset: 0x0000E20C
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00002855 File Offset: 0x00000A55
		public bool cullingEnabled
		{
			get
			{
				return this.m_CullingEnabled;
			}
			set
			{
				this.m_CullingEnabled = value;
				base.IncrementVersion(VersionChangeType.Repaint);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600010C RID: 268 RVA: 0x0000287D File Offset: 0x00000A7D
		public override bool canGrabFocus
		{
			get
			{
				return this.focusOnlyIfHasFocusableControls ? (this.hasFocusableControls && base.canGrabFocus) : base.canGrabFocus;
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000028A0 File Offset: 0x00000AA0
		public void OnGenerateVisualContent(MeshGenerationContext mgc)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00010024 File Offset: 0x0000E224
		public override void HandleEvent(EventBase evt)
		{
			base.HandleEvent(evt);
			bool flag = evt == null;
			if (!flag)
			{
				bool flag2 = evt.propagationPhase != PropagationPhase.TrickleDown && evt.propagationPhase != PropagationPhase.AtTarget && evt.propagationPhase != PropagationPhase.BubbleUp;
				if (!flag2)
				{
					bool flag3 = evt.imguiEvent == null;
					if (!flag3)
					{
						bool isPropagationStopped = evt.isPropagationStopped;
						if (!isPropagationStopped)
						{
							bool flag4 = this.SendEventToIMGUI(evt, true, true);
							if (flag4)
							{
								evt.StopPropagation();
								evt.PreventDefault();
							}
						}
					}
				}
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000028AD File Offset: 0x00000AAD
		public void DoIMGUIRepaint()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000100AC File Offset: 0x0000E2AC
		public override void ExecuteDefaultAction(EventBase evt)
		{
			bool flag = evt == null;
			if (!flag)
			{
				bool flag2 = evt.eventTypeId == EventBase<BlurEvent>.TypeId();
				if (flag2)
				{
					this.lostFocus = true;
					base.IncrementVersion(VersionChangeType.Repaint);
				}
				else
				{
					bool flag3 = evt.eventTypeId == EventBase<FocusEvent>.TypeId();
					if (flag3)
					{
						FocusEvent focusEvent = evt.TryCast<FocusEvent>();
						this.receivedFocus = true;
						this.focusChangeDirection = focusEvent.direction;
						this.m_IsFocusDelegated = focusEvent.IsFocusDelegated;
					}
					else
					{
						bool flag4 = evt.eventTypeId == EventBase<DetachFromPanelEvent>.TypeId();
						if (flag4)
						{
							bool flag5 = base.elementPanel != null;
							if (flag5)
							{
								BaseVisualElementPanel elementPanel = base.elementPanel;
								int num = elementPanel.IMGUIContainersCount;
								elementPanel.IMGUIContainersCount = num - 1;
							}
						}
						else
						{
							bool flag6 = evt.eventTypeId == EventBase<AttachToPanelEvent>.TypeId();
							if (flag6)
							{
								bool flag7 = base.elementPanel != null;
								if (flag7)
								{
									BaseVisualElementPanel elementPanel2 = base.elementPanel;
									int num = elementPanel2.IMGUIContainersCount;
									elementPanel2.IMGUIContainersCount = num + 1;
									this.SetFoldoutDepthClass();
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000101B8 File Offset: 0x0000E3B8
		public void SetFoldoutDepthClass()
		{
			for (int i = 0; i < IMGUIContainer.ussFoldoutChildDepthClassNames.Count; i++)
			{
				base.RemoveFromClassList(IMGUIContainer.ussFoldoutChildDepthClassNames[i]);
			}
			int num = VisualElementUtils.GetFoldoutDepth(this);
			bool flag = num == 0;
			if (!flag)
			{
				num = Mathf.Min(num, IMGUIContainer.ussFoldoutChildDepthClassNames.Count - 1);
				base.AddToClassList(IMGUIContainer.ussFoldoutChildDepthClassNames[num]);
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000028BA File Offset: 0x00000ABA
		public override Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_m_OnGUIHandler;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_m_ObjectGUIState;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr_useOwnerObjectGUIState;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr__lastWorldClip_k__BackingField;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingEnabled;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr_m_IsFocusDelegated;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr_m_RefreshCachedLayout;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr_m_Cache;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedClippingRect;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedTransform;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr__contextType_k__BackingField;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_lostFocus;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_receivedFocus;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_focusChangeDirection;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_hasFocusableControls;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_newKeyboardFocusControlID;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr__focusOnlyIfHasFocusableControls_k__BackingField;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_ussFoldoutChildDepthClassName;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_ussFoldoutChildDepthClassNames;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_m_GUIGlobals;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_get_onGUIHandler_Public_get_Action_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_get_guiState_Internal_get_ObjectGUIState_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_get_lastWorldClip_Internal_get_Rect_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_get_cache_Private_get_LayoutCache_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutMeasuredWidth_Private_get_Single_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutMeasuredHeight_Private_get_Single_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_get_contextType_Public_get_ContextType_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_get_focusOnlyIfHasFocusableControls_Internal_get_Boolean_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_SaveGlobals_Private_Void_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_RestoreGlobals_Private_Void_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_DoOnGUI_Private_Void_Event_Matrix4x4_Rect_Boolean_Rect_Action_Boolean_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_MarkDirtyLayout_Public_Void_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_SendEventToIMGUI_Internal_Boolean_EventBase_Boolean_Boolean_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_SendEventToIMGUIRaw_Private_Boolean_EventBase_Boolean_Boolean_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_VerifyBounds_Private_Boolean_EventBase_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_IsContainerCapturingTheMouse_Private_Boolean_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_IsLocalEvent_Private_Boolean_EventBase_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_IsEventInsideLocalWindow_Private_Boolean_EventBase_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_HandleIMGUIEvent_Private_Boolean_Event_Boolean_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_HandleIMGUIEvent_Internal_Boolean_Event_Action_Boolean_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_HandleIMGUIEvent_Private_Boolean_Event_Matrix4x4_Rect_Action_Boolean_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentClipRect_Private_Rect_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentTransformAndClip_Private_Static_Void_IMGUIContainer_Event_byref_Matrix4x4_byref_Rect_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr__DoOnGUI_b__55_0_Private_Void_0;

		// Token: 0x020001EC RID: 492
		[StructLayout(2)]
		public struct GUIGlobals
		{
			// Token: 0x0600134D RID: 4941 RVA: 0x0003AFFC File Offset: 0x000391FC
			// Note: this type is marked as 'beforefieldinit'.
			static GUIGlobals()
			{
				Il2CppClassPointerStore<IMGUIContainer.GUIGlobals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IMGUIContainer>.NativeClassPtr, "GUIGlobals");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IMGUIContainer.GUIGlobals>.NativeClassPtr);
				IMGUIContainer.GUIGlobals.NativeFieldInfoPtr_matrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer.GUIGlobals>.NativeClassPtr, "matrix");
				IMGUIContainer.GUIGlobals.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer.GUIGlobals>.NativeClassPtr, "color");
				IMGUIContainer.GUIGlobals.NativeFieldInfoPtr_contentColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer.GUIGlobals>.NativeClassPtr, "contentColor");
				IMGUIContainer.GUIGlobals.NativeFieldInfoPtr_backgroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer.GUIGlobals>.NativeClassPtr, "backgroundColor");
				IMGUIContainer.GUIGlobals.NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer.GUIGlobals>.NativeClassPtr, "enabled");
				IMGUIContainer.GUIGlobals.NativeFieldInfoPtr_changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer.GUIGlobals>.NativeClassPtr, "changed");
				IMGUIContainer.GUIGlobals.NativeFieldInfoPtr_displayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMGUIContainer.GUIGlobals>.NativeClassPtr, "displayIndex");
			}

			// Token: 0x0600134E RID: 4942 RVA: 0x0000C73B File Offset: 0x0000A93B
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IMGUIContainer.GUIGlobals>.NativeClassPtr, ref this));
			}

			// Token: 0x0400085A RID: 2138
			private static readonly IntPtr NativeFieldInfoPtr_matrix;

			// Token: 0x0400085B RID: 2139
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x0400085C RID: 2140
			private static readonly IntPtr NativeFieldInfoPtr_contentColor;

			// Token: 0x0400085D RID: 2141
			private static readonly IntPtr NativeFieldInfoPtr_backgroundColor;

			// Token: 0x0400085E RID: 2142
			private static readonly IntPtr NativeFieldInfoPtr_enabled;

			// Token: 0x0400085F RID: 2143
			private static readonly IntPtr NativeFieldInfoPtr_changed;

			// Token: 0x04000860 RID: 2144
			private static readonly IntPtr NativeFieldInfoPtr_displayIndex;

			// Token: 0x04000861 RID: 2145
			[FieldOffset(0)]
			public Matrix4x4 matrix;

			// Token: 0x04000862 RID: 2146
			[FieldOffset(64)]
			public Color color;

			// Token: 0x04000863 RID: 2147
			[FieldOffset(80)]
			public Color contentColor;

			// Token: 0x04000864 RID: 2148
			[FieldOffset(96)]
			public Color backgroundColor;

			// Token: 0x04000865 RID: 2149
			[FieldOffset(112)]
			[MarshalAs(4)]
			public bool enabled;

			// Token: 0x04000866 RID: 2150
			[FieldOffset(113)]
			[MarshalAs(4)]
			public bool changed;

			// Token: 0x04000867 RID: 2151
			[FieldOffset(116)]
			public int displayIndex;
		}

		// Token: 0x020001ED RID: 493
		public new class UxmlFactory : UxmlFactory<IMGUIContainer, IMGUIContainer.UxmlTraits>
		{
		}

		// Token: 0x020001EE RID: 494
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x0200029E RID: 670
			public sealed class <get_uxmlChildElementsDescription>d__2
			{
			}
		}
	}
}
