using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using SA.Common.Pattern;

// Token: 0x02000031 RID: 49
public class GooglePlayConnection : Singleton<GooglePlayConnection>
{
	// Token: 0x0600048F RID: 1167 RVA: 0x000260BC File Offset: 0x000242BC
	// Note: this type is marked as 'beforefieldinit'.
	static GooglePlayConnection()
	{
		Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GooglePlayConnection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr);
		GooglePlayConnection.NativeFieldInfoPtr_ActionConnectionResultReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, "ActionConnectionResultReceived");
		GooglePlayConnection.NativeFieldInfoPtr_ActionConnectionStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, "ActionConnectionStateChanged");
		GooglePlayConnection.NativeFieldInfoPtr_ActionPlayerConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, "ActionPlayerConnected");
		GooglePlayConnection.NativeFieldInfoPtr_ActionPlayerDisconnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, "ActionPlayerDisconnected");
		GooglePlayConnection.NativeFieldInfoPtr__IsInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, "_IsInitialized");
		GooglePlayConnection.NativeFieldInfoPtr__State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, "_State");
		GooglePlayConnection.NativeMethodInfoPtr_add_ActionConnectionResultReceived_Public_Static_add_Void_Action_1_GooglePlayConnectionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663818);
		GooglePlayConnection.NativeMethodInfoPtr_remove_ActionConnectionResultReceived_Public_Static_rem_Void_Action_1_GooglePlayConnectionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663819);
		GooglePlayConnection.NativeMethodInfoPtr_add_ActionConnectionStateChanged_Public_Static_add_Void_Action_1_GPConnectionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663820);
		GooglePlayConnection.NativeMethodInfoPtr_remove_ActionConnectionStateChanged_Public_Static_rem_Void_Action_1_GPConnectionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663821);
		GooglePlayConnection.NativeMethodInfoPtr_add_ActionPlayerConnected_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663822);
		GooglePlayConnection.NativeMethodInfoPtr_remove_ActionPlayerConnected_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663823);
		GooglePlayConnection.NativeMethodInfoPtr_add_ActionPlayerDisconnected_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663824);
		GooglePlayConnection.NativeMethodInfoPtr_remove_ActionPlayerDisconnected_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663825);
		GooglePlayConnection.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663826);
		GooglePlayConnection.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663827);
		GooglePlayConnection.NativeMethodInfoPtr_connect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663828);
		GooglePlayConnection.NativeMethodInfoPtr_Connect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663829);
		GooglePlayConnection.NativeMethodInfoPtr_connect_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663830);
		GooglePlayConnection.NativeMethodInfoPtr_Connect_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663831);
		GooglePlayConnection.NativeMethodInfoPtr_disconnect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663832);
		GooglePlayConnection.NativeMethodInfoPtr_Disconnect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663833);
		GooglePlayConnection.NativeMethodInfoPtr_SignOut_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663834);
		GooglePlayConnection.NativeMethodInfoPtr_CheckState_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663835);
		GooglePlayConnection.NativeMethodInfoPtr_get_IsConnected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663836);
		GooglePlayConnection.NativeMethodInfoPtr_get_state_Public_Static_get_GPConnectionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663837);
		GooglePlayConnection.NativeMethodInfoPtr_get_State_Public_Static_get_GPConnectionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663838);
		GooglePlayConnection.NativeMethodInfoPtr_get_isInitialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663839);
		GooglePlayConnection.NativeMethodInfoPtr_get_IsInitialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663840);
		GooglePlayConnection.NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663841);
		GooglePlayConnection.NativeMethodInfoPtr_OnPlayServiceDisconnected_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663842);
		GooglePlayConnection.NativeMethodInfoPtr_OnConnectionResult_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663843);
		GooglePlayConnection.NativeMethodInfoPtr_OnStateChange_Private_Void_GPConnectionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663844);
		GooglePlayConnection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, 100663845);
	}

	// Token: 0x06000490 RID: 1168 RVA: 0x00026394 File Offset: 0x00024594
	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 163792, RefRangeEnd = 163801, XrefRangeStart = 163781, XrefRangeEnd = 163792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionConnectionResultReceived(Action<GooglePlayConnectionResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_add_ActionConnectionResultReceived_Public_Static_add_Void_Action_1_GooglePlayConnectionResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x000263CC File Offset: 0x000245CC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 163812, RefRangeEnd = 163815, XrefRangeStart = 163801, XrefRangeEnd = 163812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionConnectionResultReceived(Action<GooglePlayConnectionResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_remove_ActionConnectionResultReceived_Public_Static_rem_Void_Action_1_GooglePlayConnectionResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000492 RID: 1170 RVA: 0x00026404 File Offset: 0x00024604
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163815, XrefRangeEnd = 163826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionConnectionStateChanged(Action<GPConnectionState> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_add_ActionConnectionStateChanged_Public_Static_add_Void_Action_1_GPConnectionState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000493 RID: 1171 RVA: 0x0002643C File Offset: 0x0002463C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163826, XrefRangeEnd = 163837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionConnectionStateChanged(Action<GPConnectionState> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_remove_ActionConnectionStateChanged_Public_Static_rem_Void_Action_1_GPConnectionState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000494 RID: 1172 RVA: 0x00026474 File Offset: 0x00024674
	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 163848, RefRangeEnd = 163857, XrefRangeStart = 163837, XrefRangeEnd = 163848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionPlayerConnected(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_add_ActionPlayerConnected_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000495 RID: 1173 RVA: 0x000264AC File Offset: 0x000246AC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 163868, RefRangeEnd = 163871, XrefRangeStart = 163857, XrefRangeEnd = 163868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionPlayerConnected(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_remove_ActionPlayerConnected_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000496 RID: 1174 RVA: 0x000264E4 File Offset: 0x000246E4
	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 163882, RefRangeEnd = 163891, XrefRangeStart = 163871, XrefRangeEnd = 163882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionPlayerDisconnected(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_add_ActionPlayerDisconnected_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x0002651C File Offset: 0x0002471C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 163902, RefRangeEnd = 163905, XrefRangeStart = 163891, XrefRangeEnd = 163902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionPlayerDisconnected(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_remove_ActionPlayerDisconnected_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x00026554 File Offset: 0x00024754
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163905, XrefRangeEnd = 163931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000499 RID: 1177 RVA: 0x00026588 File Offset: 0x00024788
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 163964, RefRangeEnd = 163965, XrefRangeStart = 163931, XrefRangeEnd = 163964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600049A RID: 1178 RVA: 0x000265BC File Offset: 0x000247BC
	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 163966, RefRangeEnd = 163975, XrefRangeStart = 163965, XrefRangeEnd = 163966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void connect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_connect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x000265F0 File Offset: 0x000247F0
	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 163966, RefRangeEnd = 163975, XrefRangeStart = 163966, XrefRangeEnd = 163975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Connect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_Connect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x00026624 File Offset: 0x00024824
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163975, XrefRangeEnd = 163976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void connect(string accountName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(accountName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_connect_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x00026668 File Offset: 0x00024868
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 163985, RefRangeEnd = 163990, XrefRangeStart = 163976, XrefRangeEnd = 163985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Connect(string accountName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(accountName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_Connect_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x000266AC File Offset: 0x000248AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163990, XrefRangeEnd = 163991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void disconnect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_disconnect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600049F RID: 1183 RVA: 0x000266E0 File Offset: 0x000248E0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 163999, RefRangeEnd = 164001, XrefRangeStart = 163991, XrefRangeEnd = 163999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Disconnect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_Disconnect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004A0 RID: 1184 RVA: 0x00026714 File Offset: 0x00024914
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164001, XrefRangeEnd = 164009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SignOut()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_SignOut_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004A1 RID: 1185 RVA: 0x00026748 File Offset: 0x00024948
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 164013, RefRangeEnd = 164020, XrefRangeStart = 164009, XrefRangeEnd = 164013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckState()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_CheckState_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x1700018B RID: 395
	// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00026778 File Offset: 0x00024978
	public unsafe bool IsConnected
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164020, XrefRangeEnd = 164028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_get_IsConnected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700018C RID: 396
	// (get) Token: 0x060004A3 RID: 1187 RVA: 0x000267B4 File Offset: 0x000249B4
	public unsafe static GPConnectionState state
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164028, XrefRangeEnd = 164036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_get_state_Public_Static_get_GPConnectionState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700018D RID: 397
	// (get) Token: 0x060004A4 RID: 1188 RVA: 0x000267E4 File Offset: 0x000249E4
	public unsafe static GPConnectionState State
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164036, XrefRangeEnd = 164040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_get_State_Public_Static_get_GPConnectionState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700018E RID: 398
	// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00026814 File Offset: 0x00024A14
	public unsafe bool isInitialized
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_get_isInitialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700018F RID: 399
	// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00026850 File Offset: 0x00024A50
	public unsafe bool IsInitialized
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_get_IsInitialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060004A7 RID: 1191 RVA: 0x0002688C File Offset: 0x00024A8C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164040, XrefRangeEnd = 164041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnApplicationPause(bool pauseStatus)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pauseStatus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004A8 RID: 1192 RVA: 0x000268CC File Offset: 0x00024ACC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164041, XrefRangeEnd = 164042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayServiceDisconnected(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_OnPlayServiceDisconnected_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004A9 RID: 1193 RVA: 0x00026910 File Offset: 0x00024B10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164042, XrefRangeEnd = 164066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnConnectionResult(string resultCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(resultCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_OnConnectionResult_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004AA RID: 1194 RVA: 0x00026954 File Offset: 0x00024B54
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 164097, RefRangeEnd = 164102, XrefRangeStart = 164066, XrefRangeEnd = 164097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnStateChange(GPConnectionState connectionState)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref connectionState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr_OnStateChange_Private_Void_GPConnectionState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004AB RID: 1195 RVA: 0x00026994 File Offset: 0x00024B94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164102, XrefRangeEnd = 164108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GooglePlayConnection()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004AC RID: 1196 RVA: 0x00003F48 File Offset: 0x00002148
	public GooglePlayConnection(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000185 RID: 389
	// (get) Token: 0x060004AD RID: 1197 RVA: 0x000269D0 File Offset: 0x00024BD0
	// (set) Token: 0x060004AE RID: 1198 RVA: 0x00003F51 File Offset: 0x00002151
	public unsafe static Action<GooglePlayConnectionResult> ActionConnectionResultReceived
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayConnection.NativeFieldInfoPtr_ActionConnectionResultReceived, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GooglePlayConnectionResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayConnection.NativeFieldInfoPtr_ActionConnectionResultReceived, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000186 RID: 390
	// (get) Token: 0x060004AF RID: 1199 RVA: 0x000269F8 File Offset: 0x00024BF8
	// (set) Token: 0x060004B0 RID: 1200 RVA: 0x00003F63 File Offset: 0x00002163
	public unsafe static Action<GPConnectionState> ActionConnectionStateChanged
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayConnection.NativeFieldInfoPtr_ActionConnectionStateChanged, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GPConnectionState>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayConnection.NativeFieldInfoPtr_ActionConnectionStateChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000187 RID: 391
	// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00026A20 File Offset: 0x00024C20
	// (set) Token: 0x060004B2 RID: 1202 RVA: 0x00003F75 File Offset: 0x00002175
	public unsafe static Action ActionPlayerConnected
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayConnection.NativeFieldInfoPtr_ActionPlayerConnected, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayConnection.NativeFieldInfoPtr_ActionPlayerConnected, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000188 RID: 392
	// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00026A48 File Offset: 0x00024C48
	// (set) Token: 0x060004B4 RID: 1204 RVA: 0x00003F87 File Offset: 0x00002187
	public unsafe static Action ActionPlayerDisconnected
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayConnection.NativeFieldInfoPtr_ActionPlayerDisconnected, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayConnection.NativeFieldInfoPtr_ActionPlayerDisconnected, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000189 RID: 393
	// (get) Token: 0x060004B5 RID: 1205 RVA: 0x00026A70 File Offset: 0x00024C70
	// (set) Token: 0x060004B6 RID: 1206 RVA: 0x00003F99 File Offset: 0x00002199
	public unsafe bool _IsInitialized
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayConnection.NativeFieldInfoPtr__IsInitialized);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayConnection.NativeFieldInfoPtr__IsInitialized)) = value;
		}
	}

	// Token: 0x1700018A RID: 394
	// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00026A98 File Offset: 0x00024C98
	// (set) Token: 0x060004B8 RID: 1208 RVA: 0x00003FB4 File Offset: 0x000021B4
	public unsafe static GPConnectionState _State
	{
		get
		{
			GPConnectionState gpconnectionState;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayConnection.NativeFieldInfoPtr__State, (void*)(&gpconnectionState));
			return gpconnectionState;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayConnection.NativeFieldInfoPtr__State, (void*)(&value));
		}
	}

	// Token: 0x04000365 RID: 869
	private static readonly IntPtr NativeFieldInfoPtr_ActionConnectionResultReceived;

	// Token: 0x04000366 RID: 870
	private static readonly IntPtr NativeFieldInfoPtr_ActionConnectionStateChanged;

	// Token: 0x04000367 RID: 871
	private static readonly IntPtr NativeFieldInfoPtr_ActionPlayerConnected;

	// Token: 0x04000368 RID: 872
	private static readonly IntPtr NativeFieldInfoPtr_ActionPlayerDisconnected;

	// Token: 0x04000369 RID: 873
	private static readonly IntPtr NativeFieldInfoPtr__IsInitialized;

	// Token: 0x0400036A RID: 874
	private static readonly IntPtr NativeFieldInfoPtr__State;

	// Token: 0x0400036B RID: 875
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionConnectionResultReceived_Public_Static_add_Void_Action_1_GooglePlayConnectionResult_0;

	// Token: 0x0400036C RID: 876
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionConnectionResultReceived_Public_Static_rem_Void_Action_1_GooglePlayConnectionResult_0;

	// Token: 0x0400036D RID: 877
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionConnectionStateChanged_Public_Static_add_Void_Action_1_GPConnectionState_0;

	// Token: 0x0400036E RID: 878
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionConnectionStateChanged_Public_Static_rem_Void_Action_1_GPConnectionState_0;

	// Token: 0x0400036F RID: 879
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionPlayerConnected_Public_Static_add_Void_Action_0;

	// Token: 0x04000370 RID: 880
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionPlayerConnected_Public_Static_rem_Void_Action_0;

	// Token: 0x04000371 RID: 881
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionPlayerDisconnected_Public_Static_add_Void_Action_0;

	// Token: 0x04000372 RID: 882
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionPlayerDisconnected_Public_Static_rem_Void_Action_0;

	// Token: 0x04000373 RID: 883
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000374 RID: 884
	private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

	// Token: 0x04000375 RID: 885
	private static readonly IntPtr NativeMethodInfoPtr_connect_Public_Void_0;

	// Token: 0x04000376 RID: 886
	private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Void_0;

	// Token: 0x04000377 RID: 887
	private static readonly IntPtr NativeMethodInfoPtr_connect_Public_Void_String_0;

	// Token: 0x04000378 RID: 888
	private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Void_String_0;

	// Token: 0x04000379 RID: 889
	private static readonly IntPtr NativeMethodInfoPtr_disconnect_Public_Void_0;

	// Token: 0x0400037A RID: 890
	private static readonly IntPtr NativeMethodInfoPtr_Disconnect_Public_Void_0;

	// Token: 0x0400037B RID: 891
	private static readonly IntPtr NativeMethodInfoPtr_SignOut_Public_Void_0;

	// Token: 0x0400037C RID: 892
	private static readonly IntPtr NativeMethodInfoPtr_CheckState_Public_Static_Boolean_0;

	// Token: 0x0400037D RID: 893
	private static readonly IntPtr NativeMethodInfoPtr_get_IsConnected_Public_get_Boolean_0;

	// Token: 0x0400037E RID: 894
	private static readonly IntPtr NativeMethodInfoPtr_get_state_Public_Static_get_GPConnectionState_0;

	// Token: 0x0400037F RID: 895
	private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_Static_get_GPConnectionState_0;

	// Token: 0x04000380 RID: 896
	private static readonly IntPtr NativeMethodInfoPtr_get_isInitialized_Public_get_Boolean_0;

	// Token: 0x04000381 RID: 897
	private static readonly IntPtr NativeMethodInfoPtr_get_IsInitialized_Public_get_Boolean_0;

	// Token: 0x04000382 RID: 898
	private static readonly IntPtr NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0;

	// Token: 0x04000383 RID: 899
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayServiceDisconnected_Private_Void_String_0;

	// Token: 0x04000384 RID: 900
	private static readonly IntPtr NativeMethodInfoPtr_OnConnectionResult_Private_Void_String_0;

	// Token: 0x04000385 RID: 901
	private static readonly IntPtr NativeMethodInfoPtr_OnStateChange_Private_Void_GPConnectionState_0;

	// Token: 0x04000386 RID: 902
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200036E RID: 878
	[ObfuscatedName("GooglePlayConnection+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x0600349B RID: 13467 RVA: 0x000D9604 File Offset: 0x000D7804
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<GooglePlayConnection.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GooglePlayConnection>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayConnection.__c>.NativeClassPtr);
			GooglePlayConnection.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayConnection.__c>.NativeClassPtr, "<>9");
			GooglePlayConnection.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection.__c>.NativeClassPtr, 100669987);
			GooglePlayConnection.__c.NativeMethodInfoPtr___cctor_b__39_0_Internal_Void_GooglePlayConnectionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection.__c>.NativeClassPtr, 100669988);
			GooglePlayConnection.__c.NativeMethodInfoPtr___cctor_b__39_1_Internal_Void_GPConnectionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection.__c>.NativeClassPtr, 100669989);
			GooglePlayConnection.__c.NativeMethodInfoPtr___cctor_b__39_2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection.__c>.NativeClassPtr, 100669990);
			GooglePlayConnection.__c.NativeMethodInfoPtr___cctor_b__39_3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnection.__c>.NativeClassPtr, 100669991);
		}

		// Token: 0x0600349C RID: 13468 RVA: 0x000D96A8 File Offset: 0x000D78A8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayConnection.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600349D RID: 13469 RVA: 0x000D96E4 File Offset: 0x000D78E4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__39_0(GooglePlayConnectionResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.__c.NativeMethodInfoPtr___cctor_b__39_0_Internal_Void_GooglePlayConnectionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600349E RID: 13470 RVA: 0x000D9728 File Offset: 0x000D7928
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__39_1(GPConnectionState <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <p0>;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.__c.NativeMethodInfoPtr___cctor_b__39_1_Internal_Void_GPConnectionState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600349F RID: 13471 RVA: 0x000D9768 File Offset: 0x000D7968
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__39_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.__c.NativeMethodInfoPtr___cctor_b__39_2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034A0 RID: 13472 RVA: 0x000D979C File Offset: 0x000D799C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__39_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnection.__c.NativeMethodInfoPtr___cctor_b__39_3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034A1 RID: 13473 RVA: 0x0001487A File Offset: 0x00012A7A
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x060034A2 RID: 13474 RVA: 0x000D97D0 File Offset: 0x000D79D0
		// (set) Token: 0x060034A3 RID: 13475 RVA: 0x00014883 File Offset: 0x00012A83
		public unsafe static GooglePlayConnection.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GooglePlayConnection.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GooglePlayConnection.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GooglePlayConnection.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030A3 RID: 12451
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040030A4 RID: 12452
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040030A5 RID: 12453
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__39_0_Internal_Void_GooglePlayConnectionResult_0;

		// Token: 0x040030A6 RID: 12454
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__39_1_Internal_Void_GPConnectionState_0;

		// Token: 0x040030A7 RID: 12455
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__39_2_Internal_Void_0;

		// Token: 0x040030A8 RID: 12456
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__39_3_Internal_Void_0;
	}
}
