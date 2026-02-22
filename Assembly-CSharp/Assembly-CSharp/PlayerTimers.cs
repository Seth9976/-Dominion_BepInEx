using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x020000A5 RID: 165
public class PlayerTimers : Object
{
	// Token: 0x06001326 RID: 4902 RVA: 0x00053BC0 File Offset: 0x00051DC0
	// Note: this type is marked as 'beforefieldinit'.
	static PlayerTimers()
	{
		Il2CppClassPointerStore<PlayerTimers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PlayerTimers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTimers>.NativeClassPtr);
		PlayerTimers.NativeFieldInfoPtr_s_playerTimerOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTimers>.NativeClassPtr, "s_playerTimerOptions");
		PlayerTimers.NativeFieldInfoPtr_s_playerTimerText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTimers>.NativeClassPtr, "s_playerTimerText");
		PlayerTimers.NativeFieldInfoPtr_s_DeprecatedPlayerTimerOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTimers>.NativeClassPtr, "s_DeprecatedPlayerTimerOptions");
		PlayerTimers.NativeFieldInfoPtr_s_DeprecatedPlayerTimerText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTimers>.NativeClassPtr, "s_DeprecatedPlayerTimerText");
		PlayerTimers.NativeMethodInfoPtr_GetTimeStringFromSeconds_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTimers>.NativeClassPtr, 100664803);
		PlayerTimers.NativeMethodInfoPtr_GetClosestValue_Public_Static_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTimers>.NativeClassPtr, 100664804);
		PlayerTimers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTimers>.NativeClassPtr, 100664805);
	}

	// Token: 0x06001327 RID: 4903 RVA: 0x00053C7C File Offset: 0x00051E7C
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 244109, RefRangeEnd = 244113, XrefRangeStart = 244099, XrefRangeEnd = 244109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetTimeStringFromSeconds(int seconds)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref seconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTimers.NativeMethodInfoPtr_GetTimeStringFromSeconds_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06001328 RID: 4904 RVA: 0x00053CB4 File Offset: 0x00051EB4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244113, XrefRangeEnd = 244119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetClosestValue(int t, Il2CppStructArray<int> value_array)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref t;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value_array);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTimers.NativeMethodInfoPtr_GetClosestValue_Public_Static_Int32_Int32_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001329 RID: 4905 RVA: 0x00053D04 File Offset: 0x00051F04
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerTimers()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTimers>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTimers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600132A RID: 4906 RVA: 0x0000CA66 File Offset: 0x0000AC66
	public PlayerTimers(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700061C RID: 1564
	// (get) Token: 0x0600132B RID: 4907 RVA: 0x00053D40 File Offset: 0x00051F40
	// (set) Token: 0x0600132C RID: 4908 RVA: 0x0000CA6F File Offset: 0x0000AC6F
	public unsafe static Il2CppStructArray<int> s_playerTimerOptions
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(PlayerTimers.NativeFieldInfoPtr_s_playerTimerOptions, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(PlayerTimers.NativeFieldInfoPtr_s_playerTimerOptions, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700061D RID: 1565
	// (get) Token: 0x0600132D RID: 4909 RVA: 0x00053D68 File Offset: 0x00051F68
	// (set) Token: 0x0600132E RID: 4910 RVA: 0x0000CA81 File Offset: 0x0000AC81
	public unsafe static Il2CppStringArray s_playerTimerText
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(PlayerTimers.NativeFieldInfoPtr_s_playerTimerText, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(PlayerTimers.NativeFieldInfoPtr_s_playerTimerText, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700061E RID: 1566
	// (get) Token: 0x0600132F RID: 4911 RVA: 0x00053D90 File Offset: 0x00051F90
	// (set) Token: 0x06001330 RID: 4912 RVA: 0x0000CA93 File Offset: 0x0000AC93
	public unsafe static Il2CppStructArray<int> s_DeprecatedPlayerTimerOptions
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(PlayerTimers.NativeFieldInfoPtr_s_DeprecatedPlayerTimerOptions, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(PlayerTimers.NativeFieldInfoPtr_s_DeprecatedPlayerTimerOptions, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700061F RID: 1567
	// (get) Token: 0x06001331 RID: 4913 RVA: 0x00053DB8 File Offset: 0x00051FB8
	// (set) Token: 0x06001332 RID: 4914 RVA: 0x0000CAA5 File Offset: 0x0000ACA5
	public unsafe static Il2CppStringArray s_DeprecatedPlayerTimerText
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(PlayerTimers.NativeFieldInfoPtr_s_DeprecatedPlayerTimerText, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(PlayerTimers.NativeFieldInfoPtr_s_DeprecatedPlayerTimerText, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000D5E RID: 3422
	private static readonly IntPtr NativeFieldInfoPtr_s_playerTimerOptions;

	// Token: 0x04000D5F RID: 3423
	private static readonly IntPtr NativeFieldInfoPtr_s_playerTimerText;

	// Token: 0x04000D60 RID: 3424
	private static readonly IntPtr NativeFieldInfoPtr_s_DeprecatedPlayerTimerOptions;

	// Token: 0x04000D61 RID: 3425
	private static readonly IntPtr NativeFieldInfoPtr_s_DeprecatedPlayerTimerText;

	// Token: 0x04000D62 RID: 3426
	private static readonly IntPtr NativeMethodInfoPtr_GetTimeStringFromSeconds_Public_Static_String_Int32_0;

	// Token: 0x04000D63 RID: 3427
	private static readonly IntPtr NativeMethodInfoPtr_GetClosestValue_Public_Static_Int32_Int32_Il2CppStructArray_1_Int32_0;

	// Token: 0x04000D64 RID: 3428
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
