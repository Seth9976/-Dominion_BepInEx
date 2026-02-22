using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x020000C2 RID: 194
public class UI_NetworkBase : MonoBehaviour
{
	// Token: 0x0600175D RID: 5981 RVA: 0x000608EC File Offset: 0x0005EAEC
	// Note: this type is marked as 'beforefieldinit'.
	static UI_NetworkBase()
	{
		Il2CppClassPointerStore<UI_NetworkBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_NetworkBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_NetworkBase>.NativeClassPtr);
		UI_NetworkBase.NativeFieldInfoPtr_m_localPlayerProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_NetworkBase>.NativeClassPtr, "m_localPlayerProfile");
		UI_NetworkBase.NativeFieldInfoPtr_m_localUserID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_NetworkBase>.NativeClassPtr, "m_localUserID");
		UI_NetworkBase.NativeFieldInfoPtr_m_bIgnoreNetworkEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_NetworkBase>.NativeClassPtr, "m_bIgnoreNetworkEvents");
		UI_NetworkBase.NativeFieldInfoPtr_m_bRequestingLocalPlayerProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_NetworkBase>.NativeClassPtr, "m_bRequestingLocalPlayerProfile");
		UI_NetworkBase.NativeFieldInfoPtr_m_profileUpdatedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_NetworkBase>.NativeClassPtr, "m_profileUpdatedCallback");
		UI_NetworkBase.NativeMethodInfoPtr_NetworkStart_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_NetworkBase>.NativeClassPtr, 100665158);
		UI_NetworkBase.NativeMethodInfoPtr_NetworkOnDestroy_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_NetworkBase>.NativeClassPtr, 100665159);
		UI_NetworkBase.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_NetworkBase>.NativeClassPtr, 100665160);
		UI_NetworkBase.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_NetworkBase>.NativeClassPtr, 100665161);
		UI_NetworkBase.NativeMethodInfoPtr_AddNetworkEventHandler_Private_Void_NetworkEventDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_NetworkBase>.NativeClassPtr, 100665162);
		UI_NetworkBase.NativeMethodInfoPtr_RemoveNetworkEventHandler_Private_Void_NetworkEventDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_NetworkBase>.NativeClassPtr, 100665163);
		UI_NetworkBase.NativeMethodInfoPtr_ClearLocalPlayerProfile_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_NetworkBase>.NativeClassPtr, 100665164);
		UI_NetworkBase.NativeMethodInfoPtr_RequestLocalPlayerProfile_Protected_Boolean_LocalPlayerProfileUpdatedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_NetworkBase>.NativeClassPtr, 100665165);
		UI_NetworkBase.NativeMethodInfoPtr_HandleUpdatedPlayerProfileEvent_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_NetworkBase>.NativeClassPtr, 100665166);
		UI_NetworkBase.NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_New_Void_EventType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_NetworkBase>.NativeClassPtr, 100665167);
		UI_NetworkBase.NativeMethodInfoPtr_TryNetworkReconnect_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_NetworkBase>.NativeClassPtr, 100665168);
		UI_NetworkBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_NetworkBase>.NativeClassPtr, 100665169);
	}

	// Token: 0x0600175E RID: 5982 RVA: 0x00060A70 File Offset: 0x0005EC70
	[CallerCount(0)]
	public unsafe virtual void NetworkStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_NetworkBase.NativeMethodInfoPtr_NetworkStart_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600175F RID: 5983 RVA: 0x00060AAC File Offset: 0x0005ECAC
	[CallerCount(0)]
	public unsafe virtual void NetworkOnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_NetworkBase.NativeMethodInfoPtr_NetworkOnDestroy_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001760 RID: 5984 RVA: 0x00060AE8 File Offset: 0x0005ECE8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248224, XrefRangeEnd = 248237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_NetworkBase.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001761 RID: 5985 RVA: 0x00060B1C File Offset: 0x0005ED1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248237, XrefRangeEnd = 248249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_NetworkBase.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001762 RID: 5986 RVA: 0x00060B50 File Offset: 0x0005ED50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248249, XrefRangeEnd = 248257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddNetworkEventHandler(Network.NetworkEventDelegate d)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_NetworkBase.NativeMethodInfoPtr_AddNetworkEventHandler_Private_Void_NetworkEventDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001763 RID: 5987 RVA: 0x00060B94 File Offset: 0x0005ED94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248257, XrefRangeEnd = 248265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveNetworkEventHandler(Network.NetworkEventDelegate d)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_NetworkBase.NativeMethodInfoPtr_RemoveNetworkEventHandler_Private_Void_NetworkEventDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001764 RID: 5988 RVA: 0x00060BD8 File Offset: 0x0005EDD8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248265, XrefRangeEnd = 248270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearLocalPlayerProfile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_NetworkBase.NativeMethodInfoPtr_ClearLocalPlayerProfile_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001765 RID: 5989 RVA: 0x00060C0C File Offset: 0x0005EE0C
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 248278, RefRangeEnd = 248284, XrefRangeStart = 248270, XrefRangeEnd = 248278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RequestLocalPlayerProfile(UI_NetworkBase.LocalPlayerProfileUpdatedCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_NetworkBase.NativeMethodInfoPtr_RequestLocalPlayerProfile_Protected_Boolean_LocalPlayerProfileUpdatedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06001766 RID: 5990 RVA: 0x00060C5C File Offset: 0x0005EE5C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 248298, RefRangeEnd = 248299, XrefRangeStart = 248284, XrefRangeEnd = 248298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleUpdatedPlayerProfileEvent(int eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_NetworkBase.NativeMethodInfoPtr_HandleUpdatedPlayerProfileEvent_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001767 RID: 5991 RVA: 0x00060C9C File Offset: 0x0005EE9C
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 248327, RefRangeEnd = 248334, XrefRangeStart = 248299, XrefRangeEnd = 248327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void NetworkEventCallback(NetworkEvent.EventType eventType, int eventData)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_NetworkBase.NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_New_Void_EventType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001768 RID: 5992 RVA: 0x00060CF4 File Offset: 0x0005EEF4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 248353, RefRangeEnd = 248354, XrefRangeStart = 248334, XrefRangeEnd = 248353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TryNetworkReconnect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_NetworkBase.NativeMethodInfoPtr_TryNetworkReconnect_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001769 RID: 5993 RVA: 0x00060D28 File Offset: 0x0005EF28
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_NetworkBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_NetworkBase>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_NetworkBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600176A RID: 5994 RVA: 0x0000F16B File Offset: 0x0000D36B
	public UI_NetworkBase(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000770 RID: 1904
	// (get) Token: 0x0600176B RID: 5995 RVA: 0x00060D64 File Offset: 0x0005EF64
	// (set) Token: 0x0600176C RID: 5996 RVA: 0x0000F174 File Offset: 0x0000D374
	public unsafe static NetworkPlayerProfileInfo m_localPlayerProfile
	{
		get
		{
			IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NetworkPlayerProfileInfo>.NativeClassPtr, (UIntPtr)0)];
			IL2CPP.il2cpp_field_static_get_value(UI_NetworkBase.NativeFieldInfoPtr_m_localPlayerProfile, intPtr);
			return new NetworkPlayerProfileInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkPlayerProfileInfo>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(UI_NetworkBase.NativeFieldInfoPtr_m_localPlayerProfile, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
		}
	}

	// Token: 0x17000771 RID: 1905
	// (get) Token: 0x0600176D RID: 5997 RVA: 0x00060DA0 File Offset: 0x0005EFA0
	// (set) Token: 0x0600176E RID: 5998 RVA: 0x0000F18B File Offset: 0x0000D38B
	public unsafe static uint m_localUserID
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(UI_NetworkBase.NativeFieldInfoPtr_m_localUserID, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(UI_NetworkBase.NativeFieldInfoPtr_m_localUserID, (void*)(&value));
		}
	}

	// Token: 0x17000772 RID: 1906
	// (get) Token: 0x0600176F RID: 5999 RVA: 0x00060DBC File Offset: 0x0005EFBC
	// (set) Token: 0x06001770 RID: 6000 RVA: 0x0000F199 File Offset: 0x0000D399
	public unsafe bool m_bIgnoreNetworkEvents
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_NetworkBase.NativeFieldInfoPtr_m_bIgnoreNetworkEvents);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_NetworkBase.NativeFieldInfoPtr_m_bIgnoreNetworkEvents)) = value;
		}
	}

	// Token: 0x17000773 RID: 1907
	// (get) Token: 0x06001771 RID: 6001 RVA: 0x00060DE4 File Offset: 0x0005EFE4
	// (set) Token: 0x06001772 RID: 6002 RVA: 0x0000F1B4 File Offset: 0x0000D3B4
	public unsafe static bool m_bRequestingLocalPlayerProfile
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(UI_NetworkBase.NativeFieldInfoPtr_m_bRequestingLocalPlayerProfile, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(UI_NetworkBase.NativeFieldInfoPtr_m_bRequestingLocalPlayerProfile, (void*)(&value));
		}
	}

	// Token: 0x17000774 RID: 1908
	// (get) Token: 0x06001773 RID: 6003 RVA: 0x00060E00 File Offset: 0x0005F000
	// (set) Token: 0x06001774 RID: 6004 RVA: 0x0000F1C2 File Offset: 0x0000D3C2
	public unsafe UI_NetworkBase.LocalPlayerProfileUpdatedCallback m_profileUpdatedCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_NetworkBase.NativeFieldInfoPtr_m_profileUpdatedCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_NetworkBase.LocalPlayerProfileUpdatedCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_NetworkBase.NativeFieldInfoPtr_m_profileUpdatedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400100B RID: 4107
	private static readonly IntPtr NativeFieldInfoPtr_m_localPlayerProfile;

	// Token: 0x0400100C RID: 4108
	private static readonly IntPtr NativeFieldInfoPtr_m_localUserID;

	// Token: 0x0400100D RID: 4109
	private static readonly IntPtr NativeFieldInfoPtr_m_bIgnoreNetworkEvents;

	// Token: 0x0400100E RID: 4110
	private static readonly IntPtr NativeFieldInfoPtr_m_bRequestingLocalPlayerProfile;

	// Token: 0x0400100F RID: 4111
	private static readonly IntPtr NativeFieldInfoPtr_m_profileUpdatedCallback;

	// Token: 0x04001010 RID: 4112
	private static readonly IntPtr NativeMethodInfoPtr_NetworkStart_Protected_Abstract_Virtual_New_Void_0;

	// Token: 0x04001011 RID: 4113
	private static readonly IntPtr NativeMethodInfoPtr_NetworkOnDestroy_Protected_Abstract_Virtual_New_Void_0;

	// Token: 0x04001012 RID: 4114
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x04001013 RID: 4115
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x04001014 RID: 4116
	private static readonly IntPtr NativeMethodInfoPtr_AddNetworkEventHandler_Private_Void_NetworkEventDelegate_0;

	// Token: 0x04001015 RID: 4117
	private static readonly IntPtr NativeMethodInfoPtr_RemoveNetworkEventHandler_Private_Void_NetworkEventDelegate_0;

	// Token: 0x04001016 RID: 4118
	private static readonly IntPtr NativeMethodInfoPtr_ClearLocalPlayerProfile_Private_Void_0;

	// Token: 0x04001017 RID: 4119
	private static readonly IntPtr NativeMethodInfoPtr_RequestLocalPlayerProfile_Protected_Boolean_LocalPlayerProfileUpdatedCallback_0;

	// Token: 0x04001018 RID: 4120
	private static readonly IntPtr NativeMethodInfoPtr_HandleUpdatedPlayerProfileEvent_Protected_Void_Int32_0;

	// Token: 0x04001019 RID: 4121
	private static readonly IntPtr NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_New_Void_EventType_Int32_0;

	// Token: 0x0400101A RID: 4122
	private static readonly IntPtr NativeMethodInfoPtr_TryNetworkReconnect_Protected_Void_0;

	// Token: 0x0400101B RID: 4123
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	// Token: 0x020001DF RID: 479
	public sealed class LocalPlayerProfileUpdatedCallback : MulticastDelegate
	{
		// Token: 0x060026FB RID: 9979 RVA: 0x0008EA10 File Offset: 0x0008CC10
		// Note: this type is marked as 'beforefieldinit'.
		static LocalPlayerProfileUpdatedCallback()
		{
			Il2CppClassPointerStore<UI_NetworkBase.LocalPlayerProfileUpdatedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_NetworkBase>.NativeClassPtr, "LocalPlayerProfileUpdatedCallback");
			UI_NetworkBase.LocalPlayerProfileUpdatedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_NetworkBase.LocalPlayerProfileUpdatedCallback>.NativeClassPtr, 100666386);
			UI_NetworkBase.LocalPlayerProfileUpdatedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_NetworkBase.LocalPlayerProfileUpdatedCallback>.NativeClassPtr, 100666387);
			UI_NetworkBase.LocalPlayerProfileUpdatedCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_NetworkBase.LocalPlayerProfileUpdatedCallback>.NativeClassPtr, 100666388);
			UI_NetworkBase.LocalPlayerProfileUpdatedCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_NetworkBase.LocalPlayerProfileUpdatedCallback>.NativeClassPtr, 100666389);
		}

		// Token: 0x060026FC RID: 9980 RVA: 0x0008EA84 File Offset: 0x0008CC84
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalPlayerProfileUpdatedCallback(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_NetworkBase.LocalPlayerProfileUpdatedCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_NetworkBase.LocalPlayerProfileUpdatedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026FD RID: 9981 RVA: 0x0008EAE0 File Offset: 0x0008CCE0
		[CallerCount(149)]
		[CachedScanResults(RefRangeStart = 59293, RefRangeEnd = 59442, XrefRangeStart = 59293, XrefRangeEnd = 59442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_NetworkBase.LocalPlayerProfileUpdatedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x0008EB14 File Offset: 0x0008CD14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_NetworkBase.LocalPlayerProfileUpdatedCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x0008EB78 File Offset: 0x0008CD78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_NetworkBase.LocalPlayerProfileUpdatedCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002700 RID: 9984 RVA: 0x0001810F File Offset: 0x0001630F
		public LocalPlayerProfileUpdatedCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002701 RID: 9985 RVA: 0x00018118 File Offset: 0x00016318
		public static implicit operator UI_NetworkBase.LocalPlayerProfileUpdatedCallback(Action A_0)
		{
			return DelegateSupport.ConvertDelegate<UI_NetworkBase.LocalPlayerProfileUpdatedCallback>(A_0);
		}

		// Token: 0x06002702 RID: 9986 RVA: 0x00018120 File Offset: 0x00016320
		public static UI_NetworkBase.LocalPlayerProfileUpdatedCallback operator +(UI_NetworkBase.LocalPlayerProfileUpdatedCallback A_0, UI_NetworkBase.LocalPlayerProfileUpdatedCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UI_NetworkBase.LocalPlayerProfileUpdatedCallback>();
		}

		// Token: 0x06002703 RID: 9987 RVA: 0x0001812E File Offset: 0x0001632E
		public static UI_NetworkBase.LocalPlayerProfileUpdatedCallback operator -(UI_NetworkBase.LocalPlayerProfileUpdatedCallback A_0, UI_NetworkBase.LocalPlayerProfileUpdatedCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<UI_NetworkBase.LocalPlayerProfileUpdatedCallback>();
			}
			return delegate2;
		}

		// Token: 0x04001AEA RID: 6890
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001AEB RID: 6891
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		// Token: 0x04001AEC RID: 6892
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04001AED RID: 6893
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
