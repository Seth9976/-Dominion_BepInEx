using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000076 RID: 118
public class PlatformManager : MonoBehaviour
{
	// Token: 0x06000EFE RID: 3838 RVA: 0x00045E64 File Offset: 0x00044064
	// Note: this type is marked as 'beforefieldinit'.
	static PlatformManager()
	{
		Il2CppClassPointerStore<PlatformManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PlatformManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformManager>.NativeClassPtr);
		PlatformManager.NativeFieldInfoPtr_s_AspectRatioValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformManager>.NativeClassPtr, "s_AspectRatioValues");
		PlatformManager.NativeFieldInfoPtr_m_Platform_Steam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformManager>.NativeClassPtr, "m_Platform_Steam");
		PlatformManager.NativeFieldInfoPtr_m_Platform_iOS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformManager>.NativeClassPtr, "m_Platform_iOS");
		PlatformManager.NativeFieldInfoPtr_m_Platform_Android = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformManager>.NativeClassPtr, "m_Platform_Android");
		PlatformManager.NativeFieldInfoPtr_m_LoadHalfCardsDesktop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformManager>.NativeClassPtr, "m_LoadHalfCardsDesktop");
		PlatformManager.NativeFieldInfoPtr_m_LoadHalfCardsTablet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformManager>.NativeClassPtr, "m_LoadHalfCardsTablet");
		PlatformManager.NativeFieldInfoPtr_m_MaxScreenDiagonalPhone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformManager>.NativeClassPtr, "m_MaxScreenDiagonalPhone");
		PlatformManager.NativeFieldInfoPtr_m_LoadHalfCardsPhone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformManager>.NativeClassPtr, "m_LoadHalfCardsPhone");
		PlatformManager.NativeFieldInfoPtr_m_ActivePlatforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformManager>.NativeClassPtr, "m_ActivePlatforms");
		PlatformManager.NativeFieldInfoPtr_m_DeviceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformManager>.NativeClassPtr, "m_DeviceType");
		PlatformManager.NativeFieldInfoPtr_m_ScreenDiagonal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformManager>.NativeClassPtr, "m_ScreenDiagonal");
		PlatformManager.NativeFieldInfoPtr_m_AspectRatioValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformManager>.NativeClassPtr, "m_AspectRatioValue");
		PlatformManager.NativeFieldInfoPtr_m_AspectRatioType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformManager>.NativeClassPtr, "m_AspectRatioType");
		PlatformManager.NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformManager>.NativeClassPtr, "s_instance");
		PlatformManager.NativeMethodInfoPtr_GetDeviceType_Public_DeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformManager>.NativeClassPtr, 100664370);
		PlatformManager.NativeMethodInfoPtr_GetAspectRatioType_Public_AspectRatioType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformManager>.NativeClassPtr, 100664371);
		PlatformManager.NativeMethodInfoPtr_LoadHalfCards_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformManager>.NativeClassPtr, 100664372);
		PlatformManager.NativeMethodInfoPtr_DetermineDeviceType_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformManager>.NativeClassPtr, 100664373);
		PlatformManager.NativeMethodInfoPtr_DetermineAspectRatioType_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformManager>.NativeClassPtr, 100664374);
		PlatformManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformManager>.NativeClassPtr, 100664375);
		PlatformManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformManager>.NativeClassPtr, 100664376);
	}

	// Token: 0x06000EFF RID: 3839 RVA: 0x00046038 File Offset: 0x00044238
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 11837, RefRangeEnd = 11840, XrefRangeStart = 11837, XrefRangeEnd = 11840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlatformManager.DeviceType GetDeviceType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformManager.NativeMethodInfoPtr_GetDeviceType_Public_DeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000F00 RID: 3840 RVA: 0x00046074 File Offset: 0x00044274
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 12351, RefRangeEnd = 12355, XrefRangeStart = 12351, XrefRangeEnd = 12355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlatformManager.AspectRatioType GetAspectRatioType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformManager.NativeMethodInfoPtr_GetAspectRatioType_Public_AspectRatioType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000F01 RID: 3841 RVA: 0x000460B0 File Offset: 0x000442B0
	[CallerCount(0)]
	public unsafe bool LoadHalfCards()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformManager.NativeMethodInfoPtr_LoadHalfCards_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000F02 RID: 3842 RVA: 0x000460EC File Offset: 0x000442EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240257, XrefRangeEnd = 240280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DetermineDeviceType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformManager.NativeMethodInfoPtr_DetermineDeviceType_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F03 RID: 3843 RVA: 0x00046120 File Offset: 0x00044320
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 240305, RefRangeEnd = 240307, XrefRangeStart = 240280, XrefRangeEnd = 240305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DetermineAspectRatioType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformManager.NativeMethodInfoPtr_DetermineAspectRatioType_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F04 RID: 3844 RVA: 0x00046154 File Offset: 0x00044354
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240307, XrefRangeEnd = 240389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F05 RID: 3845 RVA: 0x00046188 File Offset: 0x00044388
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240389, XrefRangeEnd = 240396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlatformManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F06 RID: 3846 RVA: 0x0000AA5C File Offset: 0x00008C5C
	public PlatformManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000505 RID: 1285
	// (get) Token: 0x06000F07 RID: 3847 RVA: 0x000461C4 File Offset: 0x000443C4
	// (set) Token: 0x06000F08 RID: 3848 RVA: 0x0000AA65 File Offset: 0x00008C65
	public unsafe static Il2CppStructArray<float> s_AspectRatioValues
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(PlatformManager.NativeFieldInfoPtr_s_AspectRatioValues, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(PlatformManager.NativeFieldInfoPtr_s_AspectRatioValues, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000506 RID: 1286
	// (get) Token: 0x06000F09 RID: 3849 RVA: 0x000461EC File Offset: 0x000443EC
	// (set) Token: 0x06000F0A RID: 3850 RVA: 0x0000AA77 File Offset: 0x00008C77
	public unsafe GameObject m_Platform_Steam
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformManager.NativeFieldInfoPtr_m_Platform_Steam);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformManager.NativeFieldInfoPtr_m_Platform_Steam), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000507 RID: 1287
	// (get) Token: 0x06000F0B RID: 3851 RVA: 0x0004621C File Offset: 0x0004441C
	// (set) Token: 0x06000F0C RID: 3852 RVA: 0x0000AA96 File Offset: 0x00008C96
	public unsafe GameObject m_Platform_iOS
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformManager.NativeFieldInfoPtr_m_Platform_iOS);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformManager.NativeFieldInfoPtr_m_Platform_iOS), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000508 RID: 1288
	// (get) Token: 0x06000F0D RID: 3853 RVA: 0x0004624C File Offset: 0x0004444C
	// (set) Token: 0x06000F0E RID: 3854 RVA: 0x0000AAB5 File Offset: 0x00008CB5
	public unsafe GameObject m_Platform_Android
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformManager.NativeFieldInfoPtr_m_Platform_Android);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformManager.NativeFieldInfoPtr_m_Platform_Android), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000509 RID: 1289
	// (get) Token: 0x06000F0F RID: 3855 RVA: 0x0004627C File Offset: 0x0004447C
	// (set) Token: 0x06000F10 RID: 3856 RVA: 0x0000AAD4 File Offset: 0x00008CD4
	public unsafe bool m_LoadHalfCardsDesktop
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformManager.NativeFieldInfoPtr_m_LoadHalfCardsDesktop);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformManager.NativeFieldInfoPtr_m_LoadHalfCardsDesktop)) = value;
		}
	}

	// Token: 0x1700050A RID: 1290
	// (get) Token: 0x06000F11 RID: 3857 RVA: 0x000462A4 File Offset: 0x000444A4
	// (set) Token: 0x06000F12 RID: 3858 RVA: 0x0000AAEF File Offset: 0x00008CEF
	public unsafe bool m_LoadHalfCardsTablet
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformManager.NativeFieldInfoPtr_m_LoadHalfCardsTablet);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformManager.NativeFieldInfoPtr_m_LoadHalfCardsTablet)) = value;
		}
	}

	// Token: 0x1700050B RID: 1291
	// (get) Token: 0x06000F13 RID: 3859 RVA: 0x000462CC File Offset: 0x000444CC
	// (set) Token: 0x06000F14 RID: 3860 RVA: 0x0000AB0A File Offset: 0x00008D0A
	public unsafe float m_MaxScreenDiagonalPhone
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformManager.NativeFieldInfoPtr_m_MaxScreenDiagonalPhone);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformManager.NativeFieldInfoPtr_m_MaxScreenDiagonalPhone)) = value;
		}
	}

	// Token: 0x1700050C RID: 1292
	// (get) Token: 0x06000F15 RID: 3861 RVA: 0x000462F4 File Offset: 0x000444F4
	// (set) Token: 0x06000F16 RID: 3862 RVA: 0x0000AB25 File Offset: 0x00008D25
	public unsafe bool m_LoadHalfCardsPhone
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformManager.NativeFieldInfoPtr_m_LoadHalfCardsPhone);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformManager.NativeFieldInfoPtr_m_LoadHalfCardsPhone)) = value;
		}
	}

	// Token: 0x1700050D RID: 1293
	// (get) Token: 0x06000F17 RID: 3863 RVA: 0x0004631C File Offset: 0x0004451C
	// (set) Token: 0x06000F18 RID: 3864 RVA: 0x0000AB40 File Offset: 0x00008D40
	public unsafe List<GameObject> m_ActivePlatforms
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformManager.NativeFieldInfoPtr_m_ActivePlatforms);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformManager.NativeFieldInfoPtr_m_ActivePlatforms), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700050E RID: 1294
	// (get) Token: 0x06000F19 RID: 3865 RVA: 0x0004634C File Offset: 0x0004454C
	// (set) Token: 0x06000F1A RID: 3866 RVA: 0x0000AB5F File Offset: 0x00008D5F
	public unsafe PlatformManager.DeviceType m_DeviceType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformManager.NativeFieldInfoPtr_m_DeviceType);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformManager.NativeFieldInfoPtr_m_DeviceType)) = value;
		}
	}

	// Token: 0x1700050F RID: 1295
	// (get) Token: 0x06000F1B RID: 3867 RVA: 0x00046374 File Offset: 0x00044574
	// (set) Token: 0x06000F1C RID: 3868 RVA: 0x0000AB7A File Offset: 0x00008D7A
	public unsafe float m_ScreenDiagonal
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformManager.NativeFieldInfoPtr_m_ScreenDiagonal);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformManager.NativeFieldInfoPtr_m_ScreenDiagonal)) = value;
		}
	}

	// Token: 0x17000510 RID: 1296
	// (get) Token: 0x06000F1D RID: 3869 RVA: 0x0004639C File Offset: 0x0004459C
	// (set) Token: 0x06000F1E RID: 3870 RVA: 0x0000AB95 File Offset: 0x00008D95
	public unsafe float m_AspectRatioValue
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformManager.NativeFieldInfoPtr_m_AspectRatioValue);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformManager.NativeFieldInfoPtr_m_AspectRatioValue)) = value;
		}
	}

	// Token: 0x17000511 RID: 1297
	// (get) Token: 0x06000F1F RID: 3871 RVA: 0x000463C4 File Offset: 0x000445C4
	// (set) Token: 0x06000F20 RID: 3872 RVA: 0x0000ABB0 File Offset: 0x00008DB0
	public unsafe PlatformManager.AspectRatioType m_AspectRatioType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformManager.NativeFieldInfoPtr_m_AspectRatioType);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformManager.NativeFieldInfoPtr_m_AspectRatioType)) = value;
		}
	}

	// Token: 0x17000512 RID: 1298
	// (get) Token: 0x06000F21 RID: 3873 RVA: 0x000463EC File Offset: 0x000445EC
	// (set) Token: 0x06000F22 RID: 3874 RVA: 0x0000ABCB File Offset: 0x00008DCB
	public unsafe static PlatformManager s_instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(PlatformManager.NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(PlatformManager.NativeFieldInfoPtr_s_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000A3D RID: 2621
	private static readonly IntPtr NativeFieldInfoPtr_s_AspectRatioValues;

	// Token: 0x04000A3E RID: 2622
	private static readonly IntPtr NativeFieldInfoPtr_m_Platform_Steam;

	// Token: 0x04000A3F RID: 2623
	private static readonly IntPtr NativeFieldInfoPtr_m_Platform_iOS;

	// Token: 0x04000A40 RID: 2624
	private static readonly IntPtr NativeFieldInfoPtr_m_Platform_Android;

	// Token: 0x04000A41 RID: 2625
	private static readonly IntPtr NativeFieldInfoPtr_m_LoadHalfCardsDesktop;

	// Token: 0x04000A42 RID: 2626
	private static readonly IntPtr NativeFieldInfoPtr_m_LoadHalfCardsTablet;

	// Token: 0x04000A43 RID: 2627
	private static readonly IntPtr NativeFieldInfoPtr_m_MaxScreenDiagonalPhone;

	// Token: 0x04000A44 RID: 2628
	private static readonly IntPtr NativeFieldInfoPtr_m_LoadHalfCardsPhone;

	// Token: 0x04000A45 RID: 2629
	private static readonly IntPtr NativeFieldInfoPtr_m_ActivePlatforms;

	// Token: 0x04000A46 RID: 2630
	private static readonly IntPtr NativeFieldInfoPtr_m_DeviceType;

	// Token: 0x04000A47 RID: 2631
	private static readonly IntPtr NativeFieldInfoPtr_m_ScreenDiagonal;

	// Token: 0x04000A48 RID: 2632
	private static readonly IntPtr NativeFieldInfoPtr_m_AspectRatioValue;

	// Token: 0x04000A49 RID: 2633
	private static readonly IntPtr NativeFieldInfoPtr_m_AspectRatioType;

	// Token: 0x04000A4A RID: 2634
	private static readonly IntPtr NativeFieldInfoPtr_s_instance;

	// Token: 0x04000A4B RID: 2635
	private static readonly IntPtr NativeMethodInfoPtr_GetDeviceType_Public_DeviceType_0;

	// Token: 0x04000A4C RID: 2636
	private static readonly IntPtr NativeMethodInfoPtr_GetAspectRatioType_Public_AspectRatioType_0;

	// Token: 0x04000A4D RID: 2637
	private static readonly IntPtr NativeMethodInfoPtr_LoadHalfCards_Public_Boolean_0;

	// Token: 0x04000A4E RID: 2638
	private static readonly IntPtr NativeMethodInfoPtr_DetermineDeviceType_Private_Void_0;

	// Token: 0x04000A4F RID: 2639
	private static readonly IntPtr NativeMethodInfoPtr_DetermineAspectRatioType_Public_Void_0;

	// Token: 0x04000A50 RID: 2640
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000A51 RID: 2641
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200018D RID: 397
	public enum DeviceType
	{
		// Token: 0x04001934 RID: 6452
		DESKTOP,
		// Token: 0x04001935 RID: 6453
		TABLET,
		// Token: 0x04001936 RID: 6454
		PHONE
	}

	// Token: 0x0200018E RID: 398
	public enum AspectRatioType
	{
		// Token: 0x04001938 RID: 6456
		ASPECT_UNKNOWN,
		// Token: 0x04001939 RID: 6457
		ASPECT_4_3,
		// Token: 0x0400193A RID: 6458
		ASPECT_3_2,
		// Token: 0x0400193B RID: 6459
		ASPECT_16_10,
		// Token: 0x0400193C RID: 6460
		ASPECT_16_9
	}
}
