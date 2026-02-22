using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using TMPro;
using UnityEngine;

// Token: 0x020000CB RID: 203
public class UI_Connecting : UI_NetworkBase
{
	// Token: 0x06001867 RID: 6247 RVA: 0x00063858 File Offset: 0x00061A58
	// Note: this type is marked as 'beforefieldinit'.
	static UI_Connecting()
	{
		Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_Connecting");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr);
		UI_Connecting.NativeFieldInfoPtr_m_connectingMessageNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, "m_connectingMessageNode");
		UI_Connecting.NativeFieldInfoPtr_m_connectingMessageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, "m_connectingMessageText");
		UI_Connecting.NativeFieldInfoPtr_m_connectionTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, "m_connectionTimeout");
		UI_Connecting.NativeFieldInfoPtr_m_connectionRetryTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, "m_connectionRetryTime");
		UI_Connecting.NativeFieldInfoPtr_m_minDisplayAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, "m_minDisplayAmount");
		UI_Connecting.NativeFieldInfoPtr_m_delayCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, "m_delayCoroutine");
		UI_Connecting.NativeFieldInfoPtr_m_connectCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, "m_connectCoroutine");
		UI_Connecting.NativeFieldInfoPtr_m_serverError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, "m_serverError");
		UI_Connecting.NativeFieldInfoPtr_m_bMinDisplayAmountReached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, "m_bMinDisplayAmountReached");
		UI_Connecting.NativeFieldInfoPtr_m_bGoToOnlineLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, "m_bGoToOnlineLobby");
		UI_Connecting.NativeFieldInfoPtr_m_bCreatingAccount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, "m_bCreatingAccount");
		UI_Connecting.NativeFieldInfoPtr_m_bServerConnectionWasLost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, "m_bServerConnectionWasLost");
		UI_Connecting.NativeFieldInfoPtr_m_bGoBackToLogin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, "m_bGoBackToLogin");
		UI_Connecting.NativeFieldInfoPtr_m_bDisplayingServerMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, "m_bDisplayingServerMessage");
		UI_Connecting.NativeFieldInfoPtr_m_bHandlePopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, "m_bHandlePopup");
		UI_Connecting.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, 100665234);
		UI_Connecting.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, 100665235);
		UI_Connecting.NativeMethodInfoPtr_NetworkStart_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, 100665236);
		UI_Connecting.NativeMethodInfoPtr_NetworkOnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, 100665237);
		UI_Connecting.NativeMethodInfoPtr_OnSelect_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, 100665238);
		UI_Connecting.NativeMethodInfoPtr_HandleBackFromPopup_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, 100665239);
		UI_Connecting.NativeMethodInfoPtr_ProcessDelayTime_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, 100665240);
		UI_Connecting.NativeMethodInfoPtr_ProcessConnection_Private_IEnumerator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, 100665241);
		UI_Connecting.NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_Void_EventType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, 100665242);
		UI_Connecting.NativeMethodInfoPtr_DisplayServerMessages_Private_Void_EServerError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, 100665243);
		UI_Connecting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, 100665244);
	}

	// Token: 0x06001868 RID: 6248 RVA: 0x00063A90 File Offset: 0x00061C90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249407, XrefRangeEnd = 249441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnterMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001869 RID: 6249 RVA: 0x00063AC4 File Offset: 0x00061CC4
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnExitMenu(bool bUnderPopup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bUnderPopup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600186A RID: 6250 RVA: 0x00063B04 File Offset: 0x00061D04
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void NetworkStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_Connecting.NativeMethodInfoPtr_NetworkStart_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600186B RID: 6251 RVA: 0x00063B40 File Offset: 0x00061D40
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249441, XrefRangeEnd = 249443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void NetworkOnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_Connecting.NativeMethodInfoPtr_NetworkOnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600186C RID: 6252 RVA: 0x00063B7C File Offset: 0x00061D7C
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSelect(bool bConfirm)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bConfirm;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting.NativeMethodInfoPtr_OnSelect_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600186D RID: 6253 RVA: 0x00063BBC File Offset: 0x00061DBC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249443, XrefRangeEnd = 249447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator HandleBackFromPopup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting.NativeMethodInfoPtr_HandleBackFromPopup_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600186E RID: 6254 RVA: 0x00063BFC File Offset: 0x00061DFC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249447, XrefRangeEnd = 249451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator ProcessDelayTime(float totalDelayTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref totalDelayTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting.NativeMethodInfoPtr_ProcessDelayTime_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}
	}

	// Token: 0x0600186F RID: 6255 RVA: 0x00063C48 File Offset: 0x00061E48
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249451, XrefRangeEnd = 249455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator ProcessConnection(float connectTimeout, float connectRetryTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref connectTimeout;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref connectRetryTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting.NativeMethodInfoPtr_ProcessConnection_Private_IEnumerator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06001870 RID: 6256 RVA: 0x00063CA4 File Offset: 0x00061EA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249455, XrefRangeEnd = 249471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void NetworkEventCallback(NetworkEvent.EventType eventType, int eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventType;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventData;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_Connecting.NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_Void_EventType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001871 RID: 6257 RVA: 0x00063CFC File Offset: 0x00061EFC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249471, XrefRangeEnd = 249543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisplayServerMessages(EServerError serverError)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref serverError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting.NativeMethodInfoPtr_DisplayServerMessages_Private_Void_EServerError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001872 RID: 6258 RVA: 0x00063D3C File Offset: 0x00061F3C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249543, XrefRangeEnd = 249551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_Connecting()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001873 RID: 6259 RVA: 0x0000FB9A File Offset: 0x0000DD9A
	public UI_Connecting(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170007C8 RID: 1992
	// (get) Token: 0x06001874 RID: 6260 RVA: 0x00063D78 File Offset: 0x00061F78
	// (set) Token: 0x06001875 RID: 6261 RVA: 0x0000FBA3 File Offset: 0x0000DDA3
	public unsafe GameObject m_connectingMessageNode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_connectingMessageNode);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_connectingMessageNode), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007C9 RID: 1993
	// (get) Token: 0x06001876 RID: 6262 RVA: 0x00063DA8 File Offset: 0x00061FA8
	// (set) Token: 0x06001877 RID: 6263 RVA: 0x0000FBC2 File Offset: 0x0000DDC2
	public unsafe TextMeshProUGUI m_connectingMessageText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_connectingMessageText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_connectingMessageText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007CA RID: 1994
	// (get) Token: 0x06001878 RID: 6264 RVA: 0x00063DD8 File Offset: 0x00061FD8
	// (set) Token: 0x06001879 RID: 6265 RVA: 0x0000FBE1 File Offset: 0x0000DDE1
	public unsafe float m_connectionTimeout
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_connectionTimeout);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_connectionTimeout)) = value;
		}
	}

	// Token: 0x170007CB RID: 1995
	// (get) Token: 0x0600187A RID: 6266 RVA: 0x00063E00 File Offset: 0x00062000
	// (set) Token: 0x0600187B RID: 6267 RVA: 0x0000FBFC File Offset: 0x0000DDFC
	public unsafe float m_connectionRetryTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_connectionRetryTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_connectionRetryTime)) = value;
		}
	}

	// Token: 0x170007CC RID: 1996
	// (get) Token: 0x0600187C RID: 6268 RVA: 0x00063E28 File Offset: 0x00062028
	// (set) Token: 0x0600187D RID: 6269 RVA: 0x0000FC17 File Offset: 0x0000DE17
	public unsafe float m_minDisplayAmount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_minDisplayAmount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_minDisplayAmount)) = value;
		}
	}

	// Token: 0x170007CD RID: 1997
	// (get) Token: 0x0600187E RID: 6270 RVA: 0x00063E50 File Offset: 0x00062050
	// (set) Token: 0x0600187F RID: 6271 RVA: 0x0000FC32 File Offset: 0x0000DE32
	public unsafe Coroutine m_delayCoroutine
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_delayCoroutine);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_delayCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007CE RID: 1998
	// (get) Token: 0x06001880 RID: 6272 RVA: 0x00063E80 File Offset: 0x00062080
	// (set) Token: 0x06001881 RID: 6273 RVA: 0x0000FC51 File Offset: 0x0000DE51
	public unsafe Coroutine m_connectCoroutine
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_connectCoroutine);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_connectCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007CF RID: 1999
	// (get) Token: 0x06001882 RID: 6274 RVA: 0x00063EB0 File Offset: 0x000620B0
	// (set) Token: 0x06001883 RID: 6275 RVA: 0x0000FC70 File Offset: 0x0000DE70
	public unsafe EServerError m_serverError
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_serverError);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_serverError)) = value;
		}
	}

	// Token: 0x170007D0 RID: 2000
	// (get) Token: 0x06001884 RID: 6276 RVA: 0x00063ED8 File Offset: 0x000620D8
	// (set) Token: 0x06001885 RID: 6277 RVA: 0x0000FC8B File Offset: 0x0000DE8B
	public unsafe bool m_bMinDisplayAmountReached
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_bMinDisplayAmountReached);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_bMinDisplayAmountReached)) = value;
		}
	}

	// Token: 0x170007D1 RID: 2001
	// (get) Token: 0x06001886 RID: 6278 RVA: 0x00063F00 File Offset: 0x00062100
	// (set) Token: 0x06001887 RID: 6279 RVA: 0x0000FCA6 File Offset: 0x0000DEA6
	public unsafe bool m_bGoToOnlineLobby
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_bGoToOnlineLobby);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_bGoToOnlineLobby)) = value;
		}
	}

	// Token: 0x170007D2 RID: 2002
	// (get) Token: 0x06001888 RID: 6280 RVA: 0x00063F28 File Offset: 0x00062128
	// (set) Token: 0x06001889 RID: 6281 RVA: 0x0000FCC1 File Offset: 0x0000DEC1
	public unsafe bool m_bCreatingAccount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_bCreatingAccount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_bCreatingAccount)) = value;
		}
	}

	// Token: 0x170007D3 RID: 2003
	// (get) Token: 0x0600188A RID: 6282 RVA: 0x00063F50 File Offset: 0x00062150
	// (set) Token: 0x0600188B RID: 6283 RVA: 0x0000FCDC File Offset: 0x0000DEDC
	public unsafe bool m_bServerConnectionWasLost
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_bServerConnectionWasLost);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_bServerConnectionWasLost)) = value;
		}
	}

	// Token: 0x170007D4 RID: 2004
	// (get) Token: 0x0600188C RID: 6284 RVA: 0x00063F78 File Offset: 0x00062178
	// (set) Token: 0x0600188D RID: 6285 RVA: 0x0000FCF7 File Offset: 0x0000DEF7
	public unsafe bool m_bGoBackToLogin
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_bGoBackToLogin);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_bGoBackToLogin)) = value;
		}
	}

	// Token: 0x170007D5 RID: 2005
	// (get) Token: 0x0600188E RID: 6286 RVA: 0x00063FA0 File Offset: 0x000621A0
	// (set) Token: 0x0600188F RID: 6287 RVA: 0x0000FD12 File Offset: 0x0000DF12
	public unsafe bool m_bDisplayingServerMessage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_bDisplayingServerMessage);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_bDisplayingServerMessage)) = value;
		}
	}

	// Token: 0x170007D6 RID: 2006
	// (get) Token: 0x06001890 RID: 6288 RVA: 0x00063FC8 File Offset: 0x000621C8
	// (set) Token: 0x06001891 RID: 6289 RVA: 0x0000FD2D File Offset: 0x0000DF2D
	public unsafe bool m_bHandlePopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_bHandlePopup);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting.NativeFieldInfoPtr_m_bHandlePopup)) = value;
		}
	}

	// Token: 0x040010AC RID: 4268
	private static readonly IntPtr NativeFieldInfoPtr_m_connectingMessageNode;

	// Token: 0x040010AD RID: 4269
	private static readonly IntPtr NativeFieldInfoPtr_m_connectingMessageText;

	// Token: 0x040010AE RID: 4270
	private static readonly IntPtr NativeFieldInfoPtr_m_connectionTimeout;

	// Token: 0x040010AF RID: 4271
	private static readonly IntPtr NativeFieldInfoPtr_m_connectionRetryTime;

	// Token: 0x040010B0 RID: 4272
	private static readonly IntPtr NativeFieldInfoPtr_m_minDisplayAmount;

	// Token: 0x040010B1 RID: 4273
	private static readonly IntPtr NativeFieldInfoPtr_m_delayCoroutine;

	// Token: 0x040010B2 RID: 4274
	private static readonly IntPtr NativeFieldInfoPtr_m_connectCoroutine;

	// Token: 0x040010B3 RID: 4275
	private static readonly IntPtr NativeFieldInfoPtr_m_serverError;

	// Token: 0x040010B4 RID: 4276
	private static readonly IntPtr NativeFieldInfoPtr_m_bMinDisplayAmountReached;

	// Token: 0x040010B5 RID: 4277
	private static readonly IntPtr NativeFieldInfoPtr_m_bGoToOnlineLobby;

	// Token: 0x040010B6 RID: 4278
	private static readonly IntPtr NativeFieldInfoPtr_m_bCreatingAccount;

	// Token: 0x040010B7 RID: 4279
	private static readonly IntPtr NativeFieldInfoPtr_m_bServerConnectionWasLost;

	// Token: 0x040010B8 RID: 4280
	private static readonly IntPtr NativeFieldInfoPtr_m_bGoBackToLogin;

	// Token: 0x040010B9 RID: 4281
	private static readonly IntPtr NativeFieldInfoPtr_m_bDisplayingServerMessage;

	// Token: 0x040010BA RID: 4282
	private static readonly IntPtr NativeFieldInfoPtr_m_bHandlePopup;

	// Token: 0x040010BB RID: 4283
	private static readonly IntPtr NativeMethodInfoPtr_OnEnterMenu_Public_Void_0;

	// Token: 0x040010BC RID: 4284
	private static readonly IntPtr NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0;

	// Token: 0x040010BD RID: 4285
	private static readonly IntPtr NativeMethodInfoPtr_NetworkStart_Protected_Virtual_Void_0;

	// Token: 0x040010BE RID: 4286
	private static readonly IntPtr NativeMethodInfoPtr_NetworkOnDestroy_Protected_Virtual_Void_0;

	// Token: 0x040010BF RID: 4287
	private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Void_Boolean_0;

	// Token: 0x040010C0 RID: 4288
	private static readonly IntPtr NativeMethodInfoPtr_HandleBackFromPopup_Private_IEnumerator_0;

	// Token: 0x040010C1 RID: 4289
	private static readonly IntPtr NativeMethodInfoPtr_ProcessDelayTime_Private_IEnumerator_Single_0;

	// Token: 0x040010C2 RID: 4290
	private static readonly IntPtr NativeMethodInfoPtr_ProcessConnection_Private_IEnumerator_Single_Single_0;

	// Token: 0x040010C3 RID: 4291
	private static readonly IntPtr NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_Void_EventType_Int32_0;

	// Token: 0x040010C4 RID: 4292
	private static readonly IntPtr NativeMethodInfoPtr_DisplayServerMessages_Private_Void_EServerError_0;

	// Token: 0x040010C5 RID: 4293
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001EF RID: 495
	[ObfuscatedName("UI_Connecting+<HandleBackFromPopup>d__20")]
	public sealed class _HandleBackFromPopup_d__20 : global::Il2CppSystem.Object
	{
		// Token: 0x060027AC RID: 10156 RVA: 0x000905B8 File Offset: 0x0008E7B8
		// Note: this type is marked as 'beforefieldinit'.
		static _HandleBackFromPopup_d__20()
		{
			Il2CppClassPointerStore<UI_Connecting._HandleBackFromPopup_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, "<HandleBackFromPopup>d__20");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_Connecting._HandleBackFromPopup_d__20>.NativeClassPtr);
			UI_Connecting._HandleBackFromPopup_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting._HandleBackFromPopup_d__20>.NativeClassPtr, "<>1__state");
			UI_Connecting._HandleBackFromPopup_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting._HandleBackFromPopup_d__20>.NativeClassPtr, "<>2__current");
			UI_Connecting._HandleBackFromPopup_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting._HandleBackFromPopup_d__20>.NativeClassPtr, "<>4__this");
			UI_Connecting._HandleBackFromPopup_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting._HandleBackFromPopup_d__20>.NativeClassPtr, 100666426);
			UI_Connecting._HandleBackFromPopup_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting._HandleBackFromPopup_d__20>.NativeClassPtr, 100666427);
			UI_Connecting._HandleBackFromPopup_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting._HandleBackFromPopup_d__20>.NativeClassPtr, 100666428);
			UI_Connecting._HandleBackFromPopup_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting._HandleBackFromPopup_d__20>.NativeClassPtr, 100666429);
			UI_Connecting._HandleBackFromPopup_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting._HandleBackFromPopup_d__20>.NativeClassPtr, 100666430);
			UI_Connecting._HandleBackFromPopup_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting._HandleBackFromPopup_d__20>.NativeClassPtr, 100666431);
		}

		// Token: 0x060027AD RID: 10157 RVA: 0x00090698 File Offset: 0x0008E898
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _HandleBackFromPopup_d__20(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_Connecting._HandleBackFromPopup_d__20>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting._HandleBackFromPopup_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x000906E0 File Offset: 0x0008E8E0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting._HandleBackFromPopup_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x00090714 File Offset: 0x0008E914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249361, XrefRangeEnd = 249371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting._HandleBackFromPopup_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x060027B0 RID: 10160 RVA: 0x00090750 File Offset: 0x0008E950
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting._HandleBackFromPopup_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x00090790 File Offset: 0x0008E990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249371, XrefRangeEnd = 249376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting._HandleBackFromPopup_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x060027B2 RID: 10162 RVA: 0x000907C4 File Offset: 0x0008E9C4
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting._HandleBackFromPopup_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060027B3 RID: 10163 RVA: 0x000187CB File Offset: 0x000169CB
		public _HandleBackFromPopup_d__20(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x060027B4 RID: 10164 RVA: 0x00090804 File Offset: 0x0008EA04
		// (set) Token: 0x060027B5 RID: 10165 RVA: 0x000187D4 File Offset: 0x000169D4
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._HandleBackFromPopup_d__20.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._HandleBackFromPopup_d__20.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x060027B6 RID: 10166 RVA: 0x0009082C File Offset: 0x0008EA2C
		// (set) Token: 0x060027B7 RID: 10167 RVA: 0x000187EF File Offset: 0x000169EF
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._HandleBackFromPopup_d__20.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._HandleBackFromPopup_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x060027B8 RID: 10168 RVA: 0x0009085C File Offset: 0x0008EA5C
		// (set) Token: 0x060027B9 RID: 10169 RVA: 0x0001880E File Offset: 0x00016A0E
		public unsafe UI_Connecting __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._HandleBackFromPopup_d__20.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_Connecting>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._HandleBackFromPopup_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B62 RID: 7010
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001B63 RID: 7011
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001B64 RID: 7012
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001B65 RID: 7013
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001B66 RID: 7014
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001B67 RID: 7015
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001B68 RID: 7016
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001B69 RID: 7017
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001B6A RID: 7018
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020001F0 RID: 496
	[ObfuscatedName("UI_Connecting+<ProcessDelayTime>d__21")]
	public sealed class _ProcessDelayTime_d__21 : global::Il2CppSystem.Object
	{
		// Token: 0x060027BA RID: 10170 RVA: 0x0009088C File Offset: 0x0008EA8C
		// Note: this type is marked as 'beforefieldinit'.
		static _ProcessDelayTime_d__21()
		{
			Il2CppClassPointerStore<UI_Connecting._ProcessDelayTime_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, "<ProcessDelayTime>d__21");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_Connecting._ProcessDelayTime_d__21>.NativeClassPtr);
			UI_Connecting._ProcessDelayTime_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting._ProcessDelayTime_d__21>.NativeClassPtr, "<>1__state");
			UI_Connecting._ProcessDelayTime_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting._ProcessDelayTime_d__21>.NativeClassPtr, "<>2__current");
			UI_Connecting._ProcessDelayTime_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting._ProcessDelayTime_d__21>.NativeClassPtr, "<>4__this");
			UI_Connecting._ProcessDelayTime_d__21.NativeFieldInfoPtr_totalDelayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting._ProcessDelayTime_d__21>.NativeClassPtr, "totalDelayTime");
			UI_Connecting._ProcessDelayTime_d__21.NativeFieldInfoPtr__accumulatedTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting._ProcessDelayTime_d__21>.NativeClassPtr, "<accumulatedTime>5__2");
			UI_Connecting._ProcessDelayTime_d__21.NativeFieldInfoPtr__previousTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting._ProcessDelayTime_d__21>.NativeClassPtr, "<previousTime>5__3");
			UI_Connecting._ProcessDelayTime_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting._ProcessDelayTime_d__21>.NativeClassPtr, 100666432);
			UI_Connecting._ProcessDelayTime_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting._ProcessDelayTime_d__21>.NativeClassPtr, 100666433);
			UI_Connecting._ProcessDelayTime_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting._ProcessDelayTime_d__21>.NativeClassPtr, 100666434);
			UI_Connecting._ProcessDelayTime_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting._ProcessDelayTime_d__21>.NativeClassPtr, 100666435);
			UI_Connecting._ProcessDelayTime_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting._ProcessDelayTime_d__21>.NativeClassPtr, 100666436);
			UI_Connecting._ProcessDelayTime_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting._ProcessDelayTime_d__21>.NativeClassPtr, 100666437);
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x000909A8 File Offset: 0x0008EBA8
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ProcessDelayTime_d__21(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_Connecting._ProcessDelayTime_d__21>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting._ProcessDelayTime_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x000909F0 File Offset: 0x0008EBF0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting._ProcessDelayTime_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x00090A24 File Offset: 0x0008EC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249376, XrefRangeEnd = 249388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting._ProcessDelayTime_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x060027BE RID: 10174 RVA: 0x00090A60 File Offset: 0x0008EC60
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting._ProcessDelayTime_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x00090AA0 File Offset: 0x0008ECA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249388, XrefRangeEnd = 249393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting._ProcessDelayTime_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x060027C0 RID: 10176 RVA: 0x00090AD4 File Offset: 0x0008ECD4
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting._ProcessDelayTime_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x0001882D File Offset: 0x00016A2D
		public _ProcessDelayTime_d__21(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x060027C2 RID: 10178 RVA: 0x00090B14 File Offset: 0x0008ED14
		// (set) Token: 0x060027C3 RID: 10179 RVA: 0x00018836 File Offset: 0x00016A36
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._ProcessDelayTime_d__21.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._ProcessDelayTime_d__21.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x060027C4 RID: 10180 RVA: 0x00090B3C File Offset: 0x0008ED3C
		// (set) Token: 0x060027C5 RID: 10181 RVA: 0x00018851 File Offset: 0x00016A51
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._ProcessDelayTime_d__21.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._ProcessDelayTime_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x060027C6 RID: 10182 RVA: 0x00090B6C File Offset: 0x0008ED6C
		// (set) Token: 0x060027C7 RID: 10183 RVA: 0x00018870 File Offset: 0x00016A70
		public unsafe UI_Connecting __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._ProcessDelayTime_d__21.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_Connecting>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._ProcessDelayTime_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x060027C8 RID: 10184 RVA: 0x00090B9C File Offset: 0x0008ED9C
		// (set) Token: 0x060027C9 RID: 10185 RVA: 0x0001888F File Offset: 0x00016A8F
		public unsafe float totalDelayTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._ProcessDelayTime_d__21.NativeFieldInfoPtr_totalDelayTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._ProcessDelayTime_d__21.NativeFieldInfoPtr_totalDelayTime)) = value;
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x060027CA RID: 10186 RVA: 0x00090BC4 File Offset: 0x0008EDC4
		// (set) Token: 0x060027CB RID: 10187 RVA: 0x000188AA File Offset: 0x00016AAA
		public unsafe float _accumulatedTime_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._ProcessDelayTime_d__21.NativeFieldInfoPtr__accumulatedTime_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._ProcessDelayTime_d__21.NativeFieldInfoPtr__accumulatedTime_5__2)) = value;
			}
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x060027CC RID: 10188 RVA: 0x00090BEC File Offset: 0x0008EDEC
		// (set) Token: 0x060027CD RID: 10189 RVA: 0x000188C5 File Offset: 0x00016AC5
		public unsafe float _previousTime_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._ProcessDelayTime_d__21.NativeFieldInfoPtr__previousTime_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._ProcessDelayTime_d__21.NativeFieldInfoPtr__previousTime_5__3)) = value;
			}
		}

		// Token: 0x04001B6B RID: 7019
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001B6C RID: 7020
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001B6D RID: 7021
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001B6E RID: 7022
		private static readonly IntPtr NativeFieldInfoPtr_totalDelayTime;

		// Token: 0x04001B6F RID: 7023
		private static readonly IntPtr NativeFieldInfoPtr__accumulatedTime_5__2;

		// Token: 0x04001B70 RID: 7024
		private static readonly IntPtr NativeFieldInfoPtr__previousTime_5__3;

		// Token: 0x04001B71 RID: 7025
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001B72 RID: 7026
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001B73 RID: 7027
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001B74 RID: 7028
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001B75 RID: 7029
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001B76 RID: 7030
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020001F1 RID: 497
	[ObfuscatedName("UI_Connecting+<ProcessConnection>d__22")]
	public sealed class _ProcessConnection_d__22 : global::Il2CppSystem.Object
	{
		// Token: 0x060027CE RID: 10190 RVA: 0x00090C14 File Offset: 0x0008EE14
		// Note: this type is marked as 'beforefieldinit'.
		static _ProcessConnection_d__22()
		{
			Il2CppClassPointerStore<UI_Connecting._ProcessConnection_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_Connecting>.NativeClassPtr, "<ProcessConnection>d__22");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_Connecting._ProcessConnection_d__22>.NativeClassPtr);
			UI_Connecting._ProcessConnection_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting._ProcessConnection_d__22>.NativeClassPtr, "<>1__state");
			UI_Connecting._ProcessConnection_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting._ProcessConnection_d__22>.NativeClassPtr, "<>2__current");
			UI_Connecting._ProcessConnection_d__22.NativeFieldInfoPtr_connectTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting._ProcessConnection_d__22>.NativeClassPtr, "connectTimeout");
			UI_Connecting._ProcessConnection_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting._ProcessConnection_d__22>.NativeClassPtr, "<>4__this");
			UI_Connecting._ProcessConnection_d__22.NativeFieldInfoPtr__accumulatedTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting._ProcessConnection_d__22>.NativeClassPtr, "<accumulatedTime>5__2");
			UI_Connecting._ProcessConnection_d__22.NativeFieldInfoPtr__previousTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Connecting._ProcessConnection_d__22>.NativeClassPtr, "<previousTime>5__3");
			UI_Connecting._ProcessConnection_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting._ProcessConnection_d__22>.NativeClassPtr, 100666438);
			UI_Connecting._ProcessConnection_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting._ProcessConnection_d__22>.NativeClassPtr, 100666439);
			UI_Connecting._ProcessConnection_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting._ProcessConnection_d__22>.NativeClassPtr, 100666440);
			UI_Connecting._ProcessConnection_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting._ProcessConnection_d__22>.NativeClassPtr, 100666441);
			UI_Connecting._ProcessConnection_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting._ProcessConnection_d__22>.NativeClassPtr, 100666442);
			UI_Connecting._ProcessConnection_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Connecting._ProcessConnection_d__22>.NativeClassPtr, 100666443);
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x00090D30 File Offset: 0x0008EF30
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ProcessConnection_d__22(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_Connecting._ProcessConnection_d__22>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting._ProcessConnection_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x00090D78 File Offset: 0x0008EF78
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting._ProcessConnection_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x00090DAC File Offset: 0x0008EFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249393, XrefRangeEnd = 249402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting._ProcessConnection_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x060027D2 RID: 10194 RVA: 0x00090DE8 File Offset: 0x0008EFE8
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting._ProcessConnection_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x00090E28 File Offset: 0x0008F028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249402, XrefRangeEnd = 249407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting._ProcessConnection_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x060027D4 RID: 10196 RVA: 0x00090E5C File Offset: 0x0008F05C
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Connecting._ProcessConnection_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060027D5 RID: 10197 RVA: 0x000188E0 File Offset: 0x00016AE0
		public _ProcessConnection_d__22(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x060027D6 RID: 10198 RVA: 0x00090E9C File Offset: 0x0008F09C
		// (set) Token: 0x060027D7 RID: 10199 RVA: 0x000188E9 File Offset: 0x00016AE9
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._ProcessConnection_d__22.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._ProcessConnection_d__22.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x060027D8 RID: 10200 RVA: 0x00090EC4 File Offset: 0x0008F0C4
		// (set) Token: 0x060027D9 RID: 10201 RVA: 0x00018904 File Offset: 0x00016B04
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._ProcessConnection_d__22.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._ProcessConnection_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x060027DA RID: 10202 RVA: 0x00090EF4 File Offset: 0x0008F0F4
		// (set) Token: 0x060027DB RID: 10203 RVA: 0x00018923 File Offset: 0x00016B23
		public unsafe float connectTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._ProcessConnection_d__22.NativeFieldInfoPtr_connectTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._ProcessConnection_d__22.NativeFieldInfoPtr_connectTimeout)) = value;
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x060027DC RID: 10204 RVA: 0x00090F1C File Offset: 0x0008F11C
		// (set) Token: 0x060027DD RID: 10205 RVA: 0x0001893E File Offset: 0x00016B3E
		public unsafe UI_Connecting __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._ProcessConnection_d__22.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_Connecting>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._ProcessConnection_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x060027DE RID: 10206 RVA: 0x00090F4C File Offset: 0x0008F14C
		// (set) Token: 0x060027DF RID: 10207 RVA: 0x0001895D File Offset: 0x00016B5D
		public unsafe float _accumulatedTime_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._ProcessConnection_d__22.NativeFieldInfoPtr__accumulatedTime_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._ProcessConnection_d__22.NativeFieldInfoPtr__accumulatedTime_5__2)) = value;
			}
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x060027E0 RID: 10208 RVA: 0x00090F74 File Offset: 0x0008F174
		// (set) Token: 0x060027E1 RID: 10209 RVA: 0x00018978 File Offset: 0x00016B78
		public unsafe float _previousTime_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._ProcessConnection_d__22.NativeFieldInfoPtr__previousTime_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Connecting._ProcessConnection_d__22.NativeFieldInfoPtr__previousTime_5__3)) = value;
			}
		}

		// Token: 0x04001B77 RID: 7031
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001B78 RID: 7032
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001B79 RID: 7033
		private static readonly IntPtr NativeFieldInfoPtr_connectTimeout;

		// Token: 0x04001B7A RID: 7034
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001B7B RID: 7035
		private static readonly IntPtr NativeFieldInfoPtr__accumulatedTime_5__2;

		// Token: 0x04001B7C RID: 7036
		private static readonly IntPtr NativeFieldInfoPtr__previousTime_5__3;

		// Token: 0x04001B7D RID: 7037
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001B7E RID: 7038
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001B7F RID: 7039
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001B80 RID: 7040
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001B81 RID: 7041
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001B82 RID: 7042
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
