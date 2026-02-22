using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x020000C6 RID: 198
public class LogoSplashScreen : MonoBehaviour
{
	// Token: 0x060017CC RID: 6092 RVA: 0x00061E40 File Offset: 0x00060040
	// Note: this type is marked as 'beforefieldinit'.
	static LogoSplashScreen()
	{
		Il2CppClassPointerStore<LogoSplashScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LogoSplashScreen");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogoSplashScreen>.NativeClassPtr);
		LogoSplashScreen.NativeFieldInfoPtr_m_loadLevelSplashScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogoSplashScreen>.NativeClassPtr, "m_loadLevelSplashScreen");
		LogoSplashScreen.NativeFieldInfoPtr_m_AutoAdvanceTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogoSplashScreen>.NativeClassPtr, "m_AutoAdvanceTimer");
		LogoSplashScreen.NativeMethodInfoPtr_UnityEditorSetAnimationComplete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogoSplashScreen>.NativeClassPtr, 100665197);
		LogoSplashScreen.NativeMethodInfoPtr_SetAnimationComplete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogoSplashScreen>.NativeClassPtr, 100665198);
		LogoSplashScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogoSplashScreen>.NativeClassPtr, 100665199);
		LogoSplashScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogoSplashScreen>.NativeClassPtr, 100665200);
	}

	// Token: 0x060017CD RID: 6093 RVA: 0x00061EE8 File Offset: 0x000600E8
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnityEditorSetAnimationComplete()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogoSplashScreen.NativeMethodInfoPtr_UnityEditorSetAnimationComplete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017CE RID: 6094 RVA: 0x00061F1C File Offset: 0x0006011C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 248611, RefRangeEnd = 248612, XrefRangeStart = 248609, XrefRangeEnd = 248611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAnimationComplete()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogoSplashScreen.NativeMethodInfoPtr_SetAnimationComplete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017CF RID: 6095 RVA: 0x00061F50 File Offset: 0x00060150
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248612, XrefRangeEnd = 248614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogoSplashScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017D0 RID: 6096 RVA: 0x00061F84 File Offset: 0x00060184
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LogoSplashScreen()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogoSplashScreen>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogoSplashScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017D1 RID: 6097 RVA: 0x0000F527 File Offset: 0x0000D727
	public LogoSplashScreen(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000792 RID: 1938
	// (get) Token: 0x060017D2 RID: 6098 RVA: 0x00061FC0 File Offset: 0x000601C0
	// (set) Token: 0x060017D3 RID: 6099 RVA: 0x0000F530 File Offset: 0x0000D730
	public unsafe LoadLevelSplashScreen m_loadLevelSplashScreen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogoSplashScreen.NativeFieldInfoPtr_m_loadLevelSplashScreen);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadLevelSplashScreen>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogoSplashScreen.NativeFieldInfoPtr_m_loadLevelSplashScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000793 RID: 1939
	// (get) Token: 0x060017D4 RID: 6100 RVA: 0x00061FF0 File Offset: 0x000601F0
	// (set) Token: 0x060017D5 RID: 6101 RVA: 0x0000F54F File Offset: 0x0000D74F
	public unsafe float m_AutoAdvanceTimer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogoSplashScreen.NativeFieldInfoPtr_m_AutoAdvanceTimer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogoSplashScreen.NativeFieldInfoPtr_m_AutoAdvanceTimer)) = value;
		}
	}

	// Token: 0x04001051 RID: 4177
	private static readonly IntPtr NativeFieldInfoPtr_m_loadLevelSplashScreen;

	// Token: 0x04001052 RID: 4178
	private static readonly IntPtr NativeFieldInfoPtr_m_AutoAdvanceTimer;

	// Token: 0x04001053 RID: 4179
	private static readonly IntPtr NativeMethodInfoPtr_UnityEditorSetAnimationComplete_Public_Void_0;

	// Token: 0x04001054 RID: 4180
	private static readonly IntPtr NativeMethodInfoPtr_SetAnimationComplete_Public_Void_0;

	// Token: 0x04001055 RID: 4181
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04001056 RID: 4182
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
