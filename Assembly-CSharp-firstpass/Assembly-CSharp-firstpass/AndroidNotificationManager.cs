using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using SA.Common.Pattern;

// Token: 0x020000E4 RID: 228
public class AndroidNotificationManager : Singleton<AndroidNotificationManager>
{
	// Token: 0x0600106C RID: 4204 RVA: 0x00050CE4 File Offset: 0x0004EEE4
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidNotificationManager()
	{
		Il2CppClassPointerStore<AndroidNotificationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidNotificationManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidNotificationManager>.NativeClassPtr);
		AndroidNotificationManager.NativeFieldInfoPtr_LENGTH_SHORT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNotificationManager>.NativeClassPtr, "LENGTH_SHORT");
		AndroidNotificationManager.NativeFieldInfoPtr_LENGTH_LONG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNotificationManager>.NativeClassPtr, "LENGTH_LONG");
		AndroidNotificationManager.NativeFieldInfoPtr_OnNotificationIdLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNotificationManager>.NativeClassPtr, "OnNotificationIdLoaded");
		AndroidNotificationManager.NativeFieldInfoPtr_PP_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNotificationManager>.NativeClassPtr, "PP_KEY");
		AndroidNotificationManager.NativeFieldInfoPtr_PP_ID_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNotificationManager>.NativeClassPtr, "PP_ID_KEY");
		AndroidNotificationManager.NativeFieldInfoPtr_DATA_SPLITTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNotificationManager>.NativeClassPtr, "DATA_SPLITTER");
		AndroidNotificationManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationManager>.NativeClassPtr, 100665329);
		AndroidNotificationManager.NativeMethodInfoPtr_LocadAppLaunchNotificationId_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationManager>.NativeClassPtr, 100665330);
		AndroidNotificationManager.NativeMethodInfoPtr_HideAllNotifications_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationManager>.NativeClassPtr, 100665331);
		AndroidNotificationManager.NativeMethodInfoPtr_ShowToastNotification_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationManager>.NativeClassPtr, 100665332);
		AndroidNotificationManager.NativeMethodInfoPtr_ShowToastNotification_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationManager>.NativeClassPtr, 100665333);
		AndroidNotificationManager.NativeMethodInfoPtr_ScheduleLocalNotification_Public_Int32_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationManager>.NativeClassPtr, 100665334);
		AndroidNotificationManager.NativeMethodInfoPtr_ScheduleLocalNotification_Public_Int32_AndroidNotificationBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationManager>.NativeClassPtr, 100665335);
		AndroidNotificationManager.NativeMethodInfoPtr_CancelLocalNotification_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationManager>.NativeClassPtr, 100665336);
		AndroidNotificationManager.NativeMethodInfoPtr_CancelAllLocalNotifications_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationManager>.NativeClassPtr, 100665337);
		AndroidNotificationManager.NativeMethodInfoPtr_get_GetNextId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationManager>.NativeClassPtr, 100665338);
		AndroidNotificationManager.NativeMethodInfoPtr_OnNotificationIdLoadedEvent_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationManager>.NativeClassPtr, 100665339);
		AndroidNotificationManager.NativeMethodInfoPtr_SaveNotifications_Private_Void_List_1_LocalNotificationTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationManager>.NativeClassPtr, 100665340);
		AndroidNotificationManager.NativeMethodInfoPtr_LoadPendingNotifications_Public_List_1_LocalNotificationTemplate_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationManager>.NativeClassPtr, 100665341);
		AndroidNotificationManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationManager>.NativeClassPtr, 100665342);
	}

	// Token: 0x0600106D RID: 4205 RVA: 0x00050EA4 File Offset: 0x0004F0A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181211, XrefRangeEnd = 181216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600106E RID: 4206 RVA: 0x00050ED8 File Offset: 0x0004F0D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181216, XrefRangeEnd = 181217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LocadAppLaunchNotificationId()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationManager.NativeMethodInfoPtr_LocadAppLaunchNotificationId_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600106F RID: 4207 RVA: 0x00050F0C File Offset: 0x0004F10C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181217, XrefRangeEnd = 181218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideAllNotifications()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationManager.NativeMethodInfoPtr_HideAllNotifications_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001070 RID: 4208 RVA: 0x00050F40 File Offset: 0x0004F140
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181218, XrefRangeEnd = 181219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowToastNotification(string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationManager.NativeMethodInfoPtr_ShowToastNotification_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001071 RID: 4209 RVA: 0x00050F84 File Offset: 0x0004F184
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181219, XrefRangeEnd = 181220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowToastNotification(string text, int duration)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationManager.NativeMethodInfoPtr_ShowToastNotification_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001072 RID: 4210 RVA: 0x00050FD4 File Offset: 0x0004F1D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181220, XrefRangeEnd = 181226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int ScheduleLocalNotification(string title, string message, int seconds)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seconds;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationManager.NativeMethodInfoPtr_ScheduleLocalNotification_Public_Int32_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001073 RID: 4211 RVA: 0x00051044 File Offset: 0x0004F244
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 181239, RefRangeEnd = 181241, XrefRangeStart = 181226, XrefRangeEnd = 181239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int ScheduleLocalNotification(AndroidNotificationBuilder builder)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationManager.NativeMethodInfoPtr_ScheduleLocalNotification_Public_Int32_AndroidNotificationBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06001074 RID: 4212 RVA: 0x00051094 File Offset: 0x0004F294
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 181249, RefRangeEnd = 181250, XrefRangeStart = 181241, XrefRangeEnd = 181249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CancelLocalNotification(int id, bool clearFromPrefs = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFromPrefs;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationManager.NativeMethodInfoPtr_CancelLocalNotification_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001075 RID: 4213 RVA: 0x000510E0 File Offset: 0x0004F2E0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 181257, RefRangeEnd = 181258, XrefRangeStart = 181250, XrefRangeEnd = 181257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CancelAllLocalNotifications()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationManager.NativeMethodInfoPtr_CancelAllLocalNotifications_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170004D9 RID: 1241
	// (get) Token: 0x06001076 RID: 4214 RVA: 0x00051114 File Offset: 0x0004F314
	public unsafe int GetNextId
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 181265, RefRangeEnd = 181266, XrefRangeStart = 181258, XrefRangeEnd = 181265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationManager.NativeMethodInfoPtr_get_GetNextId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06001077 RID: 4215 RVA: 0x00051150 File Offset: 0x0004F350
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181266, XrefRangeEnd = 181274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnNotificationIdLoadedEvent(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationManager.NativeMethodInfoPtr_OnNotificationIdLoadedEvent_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001078 RID: 4216 RVA: 0x00051194 File Offset: 0x0004F394
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181274, XrefRangeEnd = 181288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveNotifications(List<LocalNotificationTemplate> notifications)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(notifications);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationManager.NativeMethodInfoPtr_SaveNotifications_Private_Void_List_1_LocalNotificationTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001079 RID: 4217 RVA: 0x000511D8 File Offset: 0x0004F3D8
	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<LocalNotificationTemplate> LoadPendingNotifications(bool includeAll = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref includeAll;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationManager.NativeMethodInfoPtr_LoadPendingNotifications_Public_List_1_LocalNotificationTemplate_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<LocalNotificationTemplate>>(intPtr3) : null;
		}
	}

	// Token: 0x0600107A RID: 4218 RVA: 0x00051224 File Offset: 0x0004F424
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181288, XrefRangeEnd = 181310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidNotificationManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidNotificationManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600107B RID: 4219 RVA: 0x00008383 File Offset: 0x00006583
	public AndroidNotificationManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004D3 RID: 1235
	// (get) Token: 0x0600107C RID: 4220 RVA: 0x00051260 File Offset: 0x0004F460
	// (set) Token: 0x0600107D RID: 4221 RVA: 0x0000838C File Offset: 0x0000658C
	public unsafe static int LENGTH_SHORT
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AndroidNotificationManager.NativeFieldInfoPtr_LENGTH_SHORT, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNotificationManager.NativeFieldInfoPtr_LENGTH_SHORT, (void*)(&value));
		}
	}

	// Token: 0x170004D4 RID: 1236
	// (get) Token: 0x0600107E RID: 4222 RVA: 0x0005127C File Offset: 0x0004F47C
	// (set) Token: 0x0600107F RID: 4223 RVA: 0x0000839A File Offset: 0x0000659A
	public unsafe static int LENGTH_LONG
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AndroidNotificationManager.NativeFieldInfoPtr_LENGTH_LONG, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNotificationManager.NativeFieldInfoPtr_LENGTH_LONG, (void*)(&value));
		}
	}

	// Token: 0x170004D5 RID: 1237
	// (get) Token: 0x06001080 RID: 4224 RVA: 0x00051298 File Offset: 0x0004F498
	// (set) Token: 0x06001081 RID: 4225 RVA: 0x000083A8 File Offset: 0x000065A8
	public unsafe Action<int> OnNotificationIdLoaded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationManager.NativeFieldInfoPtr_OnNotificationIdLoaded);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationManager.NativeFieldInfoPtr_OnNotificationIdLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004D6 RID: 1238
	// (get) Token: 0x06001082 RID: 4226 RVA: 0x000512C8 File Offset: 0x0004F4C8
	// (set) Token: 0x06001083 RID: 4227 RVA: 0x000083C7 File Offset: 0x000065C7
	public unsafe static string PP_KEY
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNotificationManager.NativeFieldInfoPtr_PP_KEY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNotificationManager.NativeFieldInfoPtr_PP_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004D7 RID: 1239
	// (get) Token: 0x06001084 RID: 4228 RVA: 0x000512E8 File Offset: 0x0004F4E8
	// (set) Token: 0x06001085 RID: 4229 RVA: 0x000083D9 File Offset: 0x000065D9
	public unsafe static string PP_ID_KEY
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNotificationManager.NativeFieldInfoPtr_PP_ID_KEY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNotificationManager.NativeFieldInfoPtr_PP_ID_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004D8 RID: 1240
	// (get) Token: 0x06001086 RID: 4230 RVA: 0x00051308 File Offset: 0x0004F508
	// (set) Token: 0x06001087 RID: 4231 RVA: 0x000083EB File Offset: 0x000065EB
	public unsafe static string DATA_SPLITTER
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNotificationManager.NativeFieldInfoPtr_DATA_SPLITTER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNotificationManager.NativeFieldInfoPtr_DATA_SPLITTER, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000CEB RID: 3307
	private static readonly IntPtr NativeFieldInfoPtr_LENGTH_SHORT;

	// Token: 0x04000CEC RID: 3308
	private static readonly IntPtr NativeFieldInfoPtr_LENGTH_LONG;

	// Token: 0x04000CED RID: 3309
	private static readonly IntPtr NativeFieldInfoPtr_OnNotificationIdLoaded;

	// Token: 0x04000CEE RID: 3310
	private static readonly IntPtr NativeFieldInfoPtr_PP_KEY;

	// Token: 0x04000CEF RID: 3311
	private static readonly IntPtr NativeFieldInfoPtr_PP_ID_KEY;

	// Token: 0x04000CF0 RID: 3312
	private static readonly IntPtr NativeFieldInfoPtr_DATA_SPLITTER;

	// Token: 0x04000CF1 RID: 3313
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000CF2 RID: 3314
	private static readonly IntPtr NativeMethodInfoPtr_LocadAppLaunchNotificationId_Public_Void_0;

	// Token: 0x04000CF3 RID: 3315
	private static readonly IntPtr NativeMethodInfoPtr_HideAllNotifications_Public_Void_0;

	// Token: 0x04000CF4 RID: 3316
	private static readonly IntPtr NativeMethodInfoPtr_ShowToastNotification_Public_Void_String_0;

	// Token: 0x04000CF5 RID: 3317
	private static readonly IntPtr NativeMethodInfoPtr_ShowToastNotification_Public_Void_String_Int32_0;

	// Token: 0x04000CF6 RID: 3318
	private static readonly IntPtr NativeMethodInfoPtr_ScheduleLocalNotification_Public_Int32_String_String_Int32_0;

	// Token: 0x04000CF7 RID: 3319
	private static readonly IntPtr NativeMethodInfoPtr_ScheduleLocalNotification_Public_Int32_AndroidNotificationBuilder_0;

	// Token: 0x04000CF8 RID: 3320
	private static readonly IntPtr NativeMethodInfoPtr_CancelLocalNotification_Public_Void_Int32_Boolean_0;

	// Token: 0x04000CF9 RID: 3321
	private static readonly IntPtr NativeMethodInfoPtr_CancelAllLocalNotifications_Public_Void_0;

	// Token: 0x04000CFA RID: 3322
	private static readonly IntPtr NativeMethodInfoPtr_get_GetNextId_Public_get_Int32_0;

	// Token: 0x04000CFB RID: 3323
	private static readonly IntPtr NativeMethodInfoPtr_OnNotificationIdLoadedEvent_Private_Void_String_0;

	// Token: 0x04000CFC RID: 3324
	private static readonly IntPtr NativeMethodInfoPtr_SaveNotifications_Private_Void_List_1_LocalNotificationTemplate_0;

	// Token: 0x04000CFD RID: 3325
	private static readonly IntPtr NativeMethodInfoPtr_LoadPendingNotifications_Public_List_1_LocalNotificationTemplate_Boolean_0;

	// Token: 0x04000CFE RID: 3326
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000398 RID: 920
	[ObfuscatedName("AndroidNotificationManager+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x0600368E RID: 13966 RVA: 0x000DFB6C File Offset: 0x000DDD6C
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<AndroidNotificationManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndroidNotificationManager>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidNotificationManager.__c>.NativeClassPtr);
			AndroidNotificationManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNotificationManager.__c>.NativeClassPtr, "<>9");
			AndroidNotificationManager.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNotificationManager.__c>.NativeClassPtr, "<>9__20_0");
			AndroidNotificationManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationManager.__c>.NativeClassPtr, 100670235);
			AndroidNotificationManager.__c.NativeMethodInfoPtr___ctor_b__20_0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationManager.__c>.NativeClassPtr, 100670236);
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x000DFBE8 File Offset: 0x000DDDE8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidNotificationManager.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003690 RID: 13968 RVA: 0x000DFC24 File Offset: 0x000DDE24
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__20_0(int <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <p0>;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationManager.__c.NativeMethodInfoPtr___ctor_b__20_0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003691 RID: 13969 RVA: 0x0001527B File Offset: 0x0001347B
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x06003692 RID: 13970 RVA: 0x000DFC64 File Offset: 0x000DDE64
		// (set) Token: 0x06003693 RID: 13971 RVA: 0x00015284 File Offset: 0x00013484
		public unsafe static AndroidNotificationManager.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidNotificationManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidNotificationManager.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidNotificationManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x06003694 RID: 13972 RVA: 0x000DFC8C File Offset: 0x000DDE8C
		// (set) Token: 0x06003695 RID: 13973 RVA: 0x00015296 File Offset: 0x00013496
		public unsafe static Action<int> __9__20_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidNotificationManager.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidNotificationManager.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031DC RID: 12764
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040031DD RID: 12765
		private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

		// Token: 0x040031DE RID: 12766
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040031DF RID: 12767
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__20_0_Internal_Void_Int32_0;
	}
}
