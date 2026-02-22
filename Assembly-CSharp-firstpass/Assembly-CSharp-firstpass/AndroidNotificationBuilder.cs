using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x020000E3 RID: 227
public class AndroidNotificationBuilder : global::Il2CppSystem.Object
{
	// Token: 0x06001032 RID: 4146 RVA: 0x000500A0 File Offset: 0x0004E2A0
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidNotificationBuilder()
	{
		Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidNotificationBuilder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr);
		AndroidNotificationBuilder.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, "_id");
		AndroidNotificationBuilder.NativeFieldInfoPtr__title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, "_title");
		AndroidNotificationBuilder.NativeFieldInfoPtr__message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, "_message");
		AndroidNotificationBuilder.NativeFieldInfoPtr__time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, "_time");
		AndroidNotificationBuilder.NativeFieldInfoPtr__sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, "_sound");
		AndroidNotificationBuilder.NativeFieldInfoPtr__smallIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, "_smallIcon");
		AndroidNotificationBuilder.NativeFieldInfoPtr__vibration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, "_vibration");
		AndroidNotificationBuilder.NativeFieldInfoPtr__showIfAppForeground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, "_showIfAppForeground");
		AndroidNotificationBuilder.NativeFieldInfoPtr__repeating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, "_repeating");
		AndroidNotificationBuilder.NativeFieldInfoPtr__repeatDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, "_repeatDelay");
		AndroidNotificationBuilder.NativeFieldInfoPtr__largeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, "_largeIcon");
		AndroidNotificationBuilder.NativeFieldInfoPtr__bigPicture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, "_bigPicture");
		AndroidNotificationBuilder.NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, "_color");
		AndroidNotificationBuilder.NativeFieldInfoPtr__wakeLockTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, "_wakeLockTime");
		AndroidNotificationBuilder.NativeFieldInfoPtr_SOUND_SILENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, "SOUND_SILENT");
		AndroidNotificationBuilder.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665303);
		AndroidNotificationBuilder.NativeMethodInfoPtr_SetColor_Public_Void_NotificationColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665304);
		AndroidNotificationBuilder.NativeMethodInfoPtr_SetSoundName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665305);
		AndroidNotificationBuilder.NativeMethodInfoPtr_SetIconName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665306);
		AndroidNotificationBuilder.NativeMethodInfoPtr_SetVibration_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665307);
		AndroidNotificationBuilder.NativeMethodInfoPtr_SetSilentNotification_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665308);
		AndroidNotificationBuilder.NativeMethodInfoPtr_ShowIfAppIsForeground_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665309);
		AndroidNotificationBuilder.NativeMethodInfoPtr_SetRepeating_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665310);
		AndroidNotificationBuilder.NativeMethodInfoPtr_SetRepeatDelay_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665311);
		AndroidNotificationBuilder.NativeMethodInfoPtr_SetLargeIcon_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665312);
		AndroidNotificationBuilder.NativeMethodInfoPtr_SetBigPicture_Public_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665313);
		AndroidNotificationBuilder.NativeMethodInfoPtr_SetWakeLockTime_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665314);
		AndroidNotificationBuilder.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665315);
		AndroidNotificationBuilder.NativeMethodInfoPtr_get_Title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665316);
		AndroidNotificationBuilder.NativeMethodInfoPtr_get_Message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665317);
		AndroidNotificationBuilder.NativeMethodInfoPtr_get_Time_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665318);
		AndroidNotificationBuilder.NativeMethodInfoPtr_get_Color_Public_get_NotificationColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665319);
		AndroidNotificationBuilder.NativeMethodInfoPtr_get_Sound_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665320);
		AndroidNotificationBuilder.NativeMethodInfoPtr_get_Icon_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665321);
		AndroidNotificationBuilder.NativeMethodInfoPtr_get_Vibration_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665322);
		AndroidNotificationBuilder.NativeMethodInfoPtr_get_ShowIfAppForeground_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665323);
		AndroidNotificationBuilder.NativeMethodInfoPtr_get_Repeating_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665324);
		AndroidNotificationBuilder.NativeMethodInfoPtr_get_RepeatDelay_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665325);
		AndroidNotificationBuilder.NativeMethodInfoPtr_get_LargeIcon_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665326);
		AndroidNotificationBuilder.NativeMethodInfoPtr_get_BigPicture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665327);
		AndroidNotificationBuilder.NativeMethodInfoPtr_get_WakeLockTime_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, 100665328);
	}

	// Token: 0x06001033 RID: 4147 RVA: 0x00050404 File Offset: 0x0004E604
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 181207, RefRangeEnd = 181209, XrefRangeStart = 181155, XrefRangeEnd = 181207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidNotificationBuilder(int id, string title, string message, int time)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001034 RID: 4148 RVA: 0x00050480 File Offset: 0x0004E680
	[CallerCount(0)]
	public unsafe void SetColor(AndroidNotificationBuilder.NotificationColor color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr_SetColor_Public_Void_NotificationColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001035 RID: 4149 RVA: 0x000504C4 File Offset: 0x0004E6C4
	[CallerCount(0)]
	public unsafe void SetSoundName(string sound)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sound);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr_SetSoundName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001036 RID: 4150 RVA: 0x00050508 File Offset: 0x0004E708
	[CallerCount(0)]
	public unsafe void SetIconName(string icon)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(icon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr_SetIconName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001037 RID: 4151 RVA: 0x0005054C File Offset: 0x0004E74C
	[CallerCount(0)]
	public unsafe void SetVibration(bool vibration)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref vibration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr_SetVibration_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001038 RID: 4152 RVA: 0x0005058C File Offset: 0x0004E78C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181209, XrefRangeEnd = 181211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSilentNotification()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr_SetSilentNotification_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001039 RID: 4153 RVA: 0x000505C0 File Offset: 0x0004E7C0
	[CallerCount(0)]
	public unsafe void ShowIfAppIsForeground(bool show)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref show;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr_ShowIfAppIsForeground_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600103A RID: 4154 RVA: 0x00050600 File Offset: 0x0004E800
	[CallerCount(0)]
	public unsafe void SetRepeating(bool repeat)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref repeat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr_SetRepeating_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600103B RID: 4155 RVA: 0x00050640 File Offset: 0x0004E840
	[CallerCount(0)]
	public unsafe void SetRepeatDelay(int delay)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr_SetRepeatDelay_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600103C RID: 4156 RVA: 0x00050680 File Offset: 0x0004E880
	[CallerCount(0)]
	public unsafe void SetLargeIcon(string icon)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(icon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr_SetLargeIcon_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600103D RID: 4157 RVA: 0x000506C4 File Offset: 0x0004E8C4
	[CallerCount(0)]
	public unsafe void SetBigPicture(Texture2D picture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(picture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr_SetBigPicture_Public_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600103E RID: 4158 RVA: 0x00050708 File Offset: 0x0004E908
	[CallerCount(169)]
	[CachedScanResults(RefRangeStart = 90728, RefRangeEnd = 90897, XrefRangeStart = 90728, XrefRangeEnd = 90897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetWakeLockTime(int wakeTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref wakeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr_SetWakeLockTime_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x170004C5 RID: 1221
	// (get) Token: 0x0600103F RID: 4159 RVA: 0x00050748 File Offset: 0x0004E948
	public unsafe int Id
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170004C6 RID: 1222
	// (get) Token: 0x06001040 RID: 4160 RVA: 0x00050784 File Offset: 0x0004E984
	public unsafe string Title
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr_get_Title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170004C7 RID: 1223
	// (get) Token: 0x06001041 RID: 4161 RVA: 0x000507BC File Offset: 0x0004E9BC
	public unsafe string Message
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr_get_Message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170004C8 RID: 1224
	// (get) Token: 0x06001042 RID: 4162 RVA: 0x000507F4 File Offset: 0x0004E9F4
	public unsafe int Time
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr_get_Time_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170004C9 RID: 1225
	// (get) Token: 0x06001043 RID: 4163 RVA: 0x00050830 File Offset: 0x0004EA30
	public unsafe AndroidNotificationBuilder.NotificationColor Color
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr_get_Color_Public_get_NotificationColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidNotificationBuilder.NotificationColor>(intPtr3) : null;
		}
	}

	// Token: 0x170004CA RID: 1226
	// (get) Token: 0x06001044 RID: 4164 RVA: 0x00050870 File Offset: 0x0004EA70
	public unsafe string Sound
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr_get_Sound_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170004CB RID: 1227
	// (get) Token: 0x06001045 RID: 4165 RVA: 0x000508A8 File Offset: 0x0004EAA8
	public unsafe string Icon
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr_get_Icon_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170004CC RID: 1228
	// (get) Token: 0x06001046 RID: 4166 RVA: 0x000508E0 File Offset: 0x0004EAE0
	public unsafe bool Vibration
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr_get_Vibration_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170004CD RID: 1229
	// (get) Token: 0x06001047 RID: 4167 RVA: 0x0005091C File Offset: 0x0004EB1C
	public unsafe bool ShowIfAppForeground
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr_get_ShowIfAppForeground_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170004CE RID: 1230
	// (get) Token: 0x06001048 RID: 4168 RVA: 0x00050958 File Offset: 0x0004EB58
	public unsafe bool Repeating
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr_get_Repeating_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170004CF RID: 1231
	// (get) Token: 0x06001049 RID: 4169 RVA: 0x00050994 File Offset: 0x0004EB94
	public unsafe int RepeatDelay
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr_get_RepeatDelay_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170004D0 RID: 1232
	// (get) Token: 0x0600104A RID: 4170 RVA: 0x000509D0 File Offset: 0x0004EBD0
	public unsafe string LargeIcon
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr_get_LargeIcon_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170004D1 RID: 1233
	// (get) Token: 0x0600104B RID: 4171 RVA: 0x00050A08 File Offset: 0x0004EC08
	public unsafe Texture2D BigPicture
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr_get_BigPicture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}
	}

	// Token: 0x170004D2 RID: 1234
	// (get) Token: 0x0600104C RID: 4172 RVA: 0x00050A48 File Offset: 0x0004EC48
	public unsafe int WakeLockTime
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NativeMethodInfoPtr_get_WakeLockTime_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600104D RID: 4173 RVA: 0x000081D2 File Offset: 0x000063D2
	public AndroidNotificationBuilder(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004B6 RID: 1206
	// (get) Token: 0x0600104E RID: 4174 RVA: 0x00050A84 File Offset: 0x0004EC84
	// (set) Token: 0x0600104F RID: 4175 RVA: 0x000081DB File Offset: 0x000063DB
	public unsafe int _id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__id);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__id)) = value;
		}
	}

	// Token: 0x170004B7 RID: 1207
	// (get) Token: 0x06001050 RID: 4176 RVA: 0x00050AAC File Offset: 0x0004ECAC
	// (set) Token: 0x06001051 RID: 4177 RVA: 0x000081F6 File Offset: 0x000063F6
	public unsafe string _title
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__title);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__title), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004B8 RID: 1208
	// (get) Token: 0x06001052 RID: 4178 RVA: 0x00050AD4 File Offset: 0x0004ECD4
	// (set) Token: 0x06001053 RID: 4179 RVA: 0x00008215 File Offset: 0x00006415
	public unsafe string _message
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__message);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__message), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004B9 RID: 1209
	// (get) Token: 0x06001054 RID: 4180 RVA: 0x00050AFC File Offset: 0x0004ECFC
	// (set) Token: 0x06001055 RID: 4181 RVA: 0x00008234 File Offset: 0x00006434
	public unsafe int _time
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__time);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__time)) = value;
		}
	}

	// Token: 0x170004BA RID: 1210
	// (get) Token: 0x06001056 RID: 4182 RVA: 0x00050B24 File Offset: 0x0004ED24
	// (set) Token: 0x06001057 RID: 4183 RVA: 0x0000824F File Offset: 0x0000644F
	public unsafe string _sound
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__sound);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__sound), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004BB RID: 1211
	// (get) Token: 0x06001058 RID: 4184 RVA: 0x00050B4C File Offset: 0x0004ED4C
	// (set) Token: 0x06001059 RID: 4185 RVA: 0x0000826E File Offset: 0x0000646E
	public unsafe string _smallIcon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__smallIcon);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__smallIcon), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004BC RID: 1212
	// (get) Token: 0x0600105A RID: 4186 RVA: 0x00050B74 File Offset: 0x0004ED74
	// (set) Token: 0x0600105B RID: 4187 RVA: 0x0000828D File Offset: 0x0000648D
	public unsafe bool _vibration
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__vibration);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__vibration)) = value;
		}
	}

	// Token: 0x170004BD RID: 1213
	// (get) Token: 0x0600105C RID: 4188 RVA: 0x00050B9C File Offset: 0x0004ED9C
	// (set) Token: 0x0600105D RID: 4189 RVA: 0x000082A8 File Offset: 0x000064A8
	public unsafe bool _showIfAppForeground
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__showIfAppForeground);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__showIfAppForeground)) = value;
		}
	}

	// Token: 0x170004BE RID: 1214
	// (get) Token: 0x0600105E RID: 4190 RVA: 0x00050BC4 File Offset: 0x0004EDC4
	// (set) Token: 0x0600105F RID: 4191 RVA: 0x000082C3 File Offset: 0x000064C3
	public unsafe bool _repeating
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__repeating);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__repeating)) = value;
		}
	}

	// Token: 0x170004BF RID: 1215
	// (get) Token: 0x06001060 RID: 4192 RVA: 0x00050BEC File Offset: 0x0004EDEC
	// (set) Token: 0x06001061 RID: 4193 RVA: 0x000082DE File Offset: 0x000064DE
	public unsafe int _repeatDelay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__repeatDelay);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__repeatDelay)) = value;
		}
	}

	// Token: 0x170004C0 RID: 1216
	// (get) Token: 0x06001062 RID: 4194 RVA: 0x00050C14 File Offset: 0x0004EE14
	// (set) Token: 0x06001063 RID: 4195 RVA: 0x000082F9 File Offset: 0x000064F9
	public unsafe string _largeIcon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__largeIcon);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__largeIcon), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004C1 RID: 1217
	// (get) Token: 0x06001064 RID: 4196 RVA: 0x00050C3C File Offset: 0x0004EE3C
	// (set) Token: 0x06001065 RID: 4197 RVA: 0x00008318 File Offset: 0x00006518
	public unsafe Texture2D _bigPicture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__bigPicture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__bigPicture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004C2 RID: 1218
	// (get) Token: 0x06001066 RID: 4198 RVA: 0x00050C6C File Offset: 0x0004EE6C
	// (set) Token: 0x06001067 RID: 4199 RVA: 0x00008337 File Offset: 0x00006537
	public unsafe AndroidNotificationBuilder.NotificationColor _color
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__color);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidNotificationBuilder.NotificationColor>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__color), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004C3 RID: 1219
	// (get) Token: 0x06001068 RID: 4200 RVA: 0x00050C9C File Offset: 0x0004EE9C
	// (set) Token: 0x06001069 RID: 4201 RVA: 0x00008356 File Offset: 0x00006556
	public unsafe int _wakeLockTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__wakeLockTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NativeFieldInfoPtr__wakeLockTime)) = value;
		}
	}

	// Token: 0x170004C4 RID: 1220
	// (get) Token: 0x0600106A RID: 4202 RVA: 0x00050CC4 File Offset: 0x0004EEC4
	// (set) Token: 0x0600106B RID: 4203 RVA: 0x00008371 File Offset: 0x00006571
	public unsafe static string SOUND_SILENT
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNotificationBuilder.NativeFieldInfoPtr_SOUND_SILENT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNotificationBuilder.NativeFieldInfoPtr_SOUND_SILENT, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000CC2 RID: 3266
	private static readonly IntPtr NativeFieldInfoPtr__id;

	// Token: 0x04000CC3 RID: 3267
	private static readonly IntPtr NativeFieldInfoPtr__title;

	// Token: 0x04000CC4 RID: 3268
	private static readonly IntPtr NativeFieldInfoPtr__message;

	// Token: 0x04000CC5 RID: 3269
	private static readonly IntPtr NativeFieldInfoPtr__time;

	// Token: 0x04000CC6 RID: 3270
	private static readonly IntPtr NativeFieldInfoPtr__sound;

	// Token: 0x04000CC7 RID: 3271
	private static readonly IntPtr NativeFieldInfoPtr__smallIcon;

	// Token: 0x04000CC8 RID: 3272
	private static readonly IntPtr NativeFieldInfoPtr__vibration;

	// Token: 0x04000CC9 RID: 3273
	private static readonly IntPtr NativeFieldInfoPtr__showIfAppForeground;

	// Token: 0x04000CCA RID: 3274
	private static readonly IntPtr NativeFieldInfoPtr__repeating;

	// Token: 0x04000CCB RID: 3275
	private static readonly IntPtr NativeFieldInfoPtr__repeatDelay;

	// Token: 0x04000CCC RID: 3276
	private static readonly IntPtr NativeFieldInfoPtr__largeIcon;

	// Token: 0x04000CCD RID: 3277
	private static readonly IntPtr NativeFieldInfoPtr__bigPicture;

	// Token: 0x04000CCE RID: 3278
	private static readonly IntPtr NativeFieldInfoPtr__color;

	// Token: 0x04000CCF RID: 3279
	private static readonly IntPtr NativeFieldInfoPtr__wakeLockTime;

	// Token: 0x04000CD0 RID: 3280
	private static readonly IntPtr NativeFieldInfoPtr_SOUND_SILENT;

	// Token: 0x04000CD1 RID: 3281
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_Int32_0;

	// Token: 0x04000CD2 RID: 3282
	private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_NotificationColor_0;

	// Token: 0x04000CD3 RID: 3283
	private static readonly IntPtr NativeMethodInfoPtr_SetSoundName_Public_Void_String_0;

	// Token: 0x04000CD4 RID: 3284
	private static readonly IntPtr NativeMethodInfoPtr_SetIconName_Public_Void_String_0;

	// Token: 0x04000CD5 RID: 3285
	private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_Boolean_0;

	// Token: 0x04000CD6 RID: 3286
	private static readonly IntPtr NativeMethodInfoPtr_SetSilentNotification_Public_Void_0;

	// Token: 0x04000CD7 RID: 3287
	private static readonly IntPtr NativeMethodInfoPtr_ShowIfAppIsForeground_Public_Void_Boolean_0;

	// Token: 0x04000CD8 RID: 3288
	private static readonly IntPtr NativeMethodInfoPtr_SetRepeating_Public_Void_Boolean_0;

	// Token: 0x04000CD9 RID: 3289
	private static readonly IntPtr NativeMethodInfoPtr_SetRepeatDelay_Public_Void_Int32_0;

	// Token: 0x04000CDA RID: 3290
	private static readonly IntPtr NativeMethodInfoPtr_SetLargeIcon_Public_Void_String_0;

	// Token: 0x04000CDB RID: 3291
	private static readonly IntPtr NativeMethodInfoPtr_SetBigPicture_Public_Void_Texture2D_0;

	// Token: 0x04000CDC RID: 3292
	private static readonly IntPtr NativeMethodInfoPtr_SetWakeLockTime_Public_Void_Int32_0;

	// Token: 0x04000CDD RID: 3293
	private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

	// Token: 0x04000CDE RID: 3294
	private static readonly IntPtr NativeMethodInfoPtr_get_Title_Public_get_String_0;

	// Token: 0x04000CDF RID: 3295
	private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_String_0;

	// Token: 0x04000CE0 RID: 3296
	private static readonly IntPtr NativeMethodInfoPtr_get_Time_Public_get_Int32_0;

	// Token: 0x04000CE1 RID: 3297
	private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_NotificationColor_0;

	// Token: 0x04000CE2 RID: 3298
	private static readonly IntPtr NativeMethodInfoPtr_get_Sound_Public_get_String_0;

	// Token: 0x04000CE3 RID: 3299
	private static readonly IntPtr NativeMethodInfoPtr_get_Icon_Public_get_String_0;

	// Token: 0x04000CE4 RID: 3300
	private static readonly IntPtr NativeMethodInfoPtr_get_Vibration_Public_get_Boolean_0;

	// Token: 0x04000CE5 RID: 3301
	private static readonly IntPtr NativeMethodInfoPtr_get_ShowIfAppForeground_Public_get_Boolean_0;

	// Token: 0x04000CE6 RID: 3302
	private static readonly IntPtr NativeMethodInfoPtr_get_Repeating_Public_get_Boolean_0;

	// Token: 0x04000CE7 RID: 3303
	private static readonly IntPtr NativeMethodInfoPtr_get_RepeatDelay_Public_get_Int32_0;

	// Token: 0x04000CE8 RID: 3304
	private static readonly IntPtr NativeMethodInfoPtr_get_LargeIcon_Public_get_String_0;

	// Token: 0x04000CE9 RID: 3305
	private static readonly IntPtr NativeMethodInfoPtr_get_BigPicture_Public_get_Texture2D_0;

	// Token: 0x04000CEA RID: 3306
	private static readonly IntPtr NativeMethodInfoPtr_get_WakeLockTime_Public_get_Int32_0;

	// Token: 0x02000397 RID: 919
	public class NotificationColor : global::Il2CppSystem.Object
	{
		// Token: 0x06003688 RID: 13960 RVA: 0x000DFA58 File Offset: 0x000DDC58
		// Note: this type is marked as 'beforefieldinit'.
		static NotificationColor()
		{
			Il2CppClassPointerStore<AndroidNotificationBuilder.NotificationColor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndroidNotificationBuilder>.NativeClassPtr, "NotificationColor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidNotificationBuilder.NotificationColor>.NativeClassPtr);
			AndroidNotificationBuilder.NotificationColor.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNotificationBuilder.NotificationColor>.NativeClassPtr, "_value");
			AndroidNotificationBuilder.NotificationColor.NativeMethodInfoPtr__ctor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder.NotificationColor>.NativeClassPtr, 100670232);
			AndroidNotificationBuilder.NotificationColor.NativeMethodInfoPtr_get_Value_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNotificationBuilder.NotificationColor>.NativeClassPtr, 100670233);
		}

		// Token: 0x06003689 RID: 13961 RVA: 0x000DFAC0 File Offset: 0x000DDCC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181154, XrefRangeEnd = 181155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotificationColor(Color value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidNotificationBuilder.NotificationColor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NotificationColor.NativeMethodInfoPtr__ctor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x0600368A RID: 13962 RVA: 0x000DFB08 File Offset: 0x000DDD08
		public unsafe Color Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNotificationBuilder.NotificationColor.NativeMethodInfoPtr_get_Value_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600368B RID: 13963 RVA: 0x00015257 File Offset: 0x00013457
		public NotificationColor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x0600368C RID: 13964 RVA: 0x000DFB44 File Offset: 0x000DDD44
		// (set) Token: 0x0600368D RID: 13965 RVA: 0x00015260 File Offset: 0x00013460
		public unsafe Color _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NotificationColor.NativeFieldInfoPtr__value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNotificationBuilder.NotificationColor.NativeFieldInfoPtr__value)) = value;
			}
		}

		// Token: 0x040031D9 RID: 12761
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x040031DA RID: 12762
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_0;

		// Token: 0x040031DB RID: 12763
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Color_0;
	}
}
