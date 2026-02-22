using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using Steamworks;
using UnityEngine;

// Token: 0x02000073 RID: 115
public class SteamManager : MonoBehaviour
{
	// Token: 0x06000EAC RID: 3756 RVA: 0x00044C28 File Offset: 0x00042E28
	// Note: this type is marked as 'beforefieldinit'.
	static SteamManager()
	{
		Il2CppClassPointerStore<SteamManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SteamManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamManager>.NativeClassPtr);
		SteamManager.NativeFieldInfoPtr_m_SteamAppId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, "m_SteamAppId");
		SteamManager.NativeFieldInfoPtr_m_EnableSteamDRM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, "m_EnableSteamDRM");
		SteamManager.NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, "s_instance");
		SteamManager.NativeFieldInfoPtr_s_EverInialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, "s_EverInialized");
		SteamManager.NativeFieldInfoPtr_m_bInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, "m_bInitialized");
		SteamManager.NativeFieldInfoPtr_m_SteamAPIWarningMessageHook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, "m_SteamAPIWarningMessageHook");
		SteamManager.NativeMethodInfoPtr_get_Instance_Private_Static_get_SteamManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100664331);
		SteamManager.NativeMethodInfoPtr_get_Initialized_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100664332);
		SteamManager.NativeMethodInfoPtr_SteamAPIDebugTextHook_Private_Static_Void_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100664333);
		SteamManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100664334);
		SteamManager.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100664335);
		SteamManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100664336);
		SteamManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100664337);
		SteamManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100664338);
	}

	// Token: 0x170004F6 RID: 1270
	// (get) Token: 0x06000EAD RID: 3757 RVA: 0x00044D70 File Offset: 0x00042F70
	public unsafe static SteamManager Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239822, XrefRangeEnd = 239832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamManager.NativeMethodInfoPtr_get_Instance_Private_Static_get_SteamManager_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SteamManager>(intPtr3) : null;
		}
	}

	// Token: 0x170004F7 RID: 1271
	// (get) Token: 0x06000EAE RID: 3758 RVA: 0x00044DA4 File Offset: 0x00042FA4
	public unsafe static bool Initialized
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 239849, RefRangeEnd = 239853, XrefRangeStart = 239832, XrefRangeEnd = 239849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamManager.NativeMethodInfoPtr_get_Initialized_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000EAF RID: 3759 RVA: 0x00044DD4 File Offset: 0x00042FD4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239853, XrefRangeEnd = 239857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref nSeverity;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pchDebugText);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamManager.NativeMethodInfoPtr_SteamAPIDebugTextHook_Private_Static_Void_Int32_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000EB0 RID: 3760 RVA: 0x00044E18 File Offset: 0x00043018
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239857, XrefRangeEnd = 239901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000EB1 RID: 3761 RVA: 0x00044E4C File Offset: 0x0004304C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239901, XrefRangeEnd = 239915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamManager.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000EB2 RID: 3762 RVA: 0x00044E80 File Offset: 0x00043080
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239915, XrefRangeEnd = 239923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000EB3 RID: 3763 RVA: 0x00044EB4 File Offset: 0x000430B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239923, XrefRangeEnd = 239924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000EB4 RID: 3764 RVA: 0x00044EE8 File Offset: 0x000430E8
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SteamManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000EB5 RID: 3765 RVA: 0x0000A844 File Offset: 0x00008A44
	public SteamManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004F0 RID: 1264
	// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x00044F24 File Offset: 0x00043124
	// (set) Token: 0x06000EB7 RID: 3767 RVA: 0x0000A84D File Offset: 0x00008A4D
	public unsafe uint m_SteamAppId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamManager.NativeFieldInfoPtr_m_SteamAppId);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamManager.NativeFieldInfoPtr_m_SteamAppId)) = value;
		}
	}

	// Token: 0x170004F1 RID: 1265
	// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x00044F4C File Offset: 0x0004314C
	// (set) Token: 0x06000EB9 RID: 3769 RVA: 0x0000A868 File Offset: 0x00008A68
	public unsafe bool m_EnableSteamDRM
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamManager.NativeFieldInfoPtr_m_EnableSteamDRM);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamManager.NativeFieldInfoPtr_m_EnableSteamDRM)) = value;
		}
	}

	// Token: 0x170004F2 RID: 1266
	// (get) Token: 0x06000EBA RID: 3770 RVA: 0x00044F74 File Offset: 0x00043174
	// (set) Token: 0x06000EBB RID: 3771 RVA: 0x0000A883 File Offset: 0x00008A83
	public unsafe static SteamManager s_instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SteamManager.NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SteamManager.NativeFieldInfoPtr_s_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004F3 RID: 1267
	// (get) Token: 0x06000EBC RID: 3772 RVA: 0x00044F9C File Offset: 0x0004319C
	// (set) Token: 0x06000EBD RID: 3773 RVA: 0x0000A895 File Offset: 0x00008A95
	public unsafe static bool s_EverInialized
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(SteamManager.NativeFieldInfoPtr_s_EverInialized, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SteamManager.NativeFieldInfoPtr_s_EverInialized, (void*)(&value));
		}
	}

	// Token: 0x170004F4 RID: 1268
	// (get) Token: 0x06000EBE RID: 3774 RVA: 0x00044FB8 File Offset: 0x000431B8
	// (set) Token: 0x06000EBF RID: 3775 RVA: 0x0000A8A3 File Offset: 0x00008AA3
	public unsafe bool m_bInitialized
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamManager.NativeFieldInfoPtr_m_bInitialized);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamManager.NativeFieldInfoPtr_m_bInitialized)) = value;
		}
	}

	// Token: 0x170004F5 RID: 1269
	// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x00044FE0 File Offset: 0x000431E0
	// (set) Token: 0x06000EC1 RID: 3777 RVA: 0x0000A8BE File Offset: 0x00008ABE
	public unsafe SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamManager.NativeFieldInfoPtr_m_SteamAPIWarningMessageHook);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamAPIWarningMessageHook_t>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamManager.NativeFieldInfoPtr_m_SteamAPIWarningMessageHook), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000A04 RID: 2564
	private static readonly IntPtr NativeFieldInfoPtr_m_SteamAppId;

	// Token: 0x04000A05 RID: 2565
	private static readonly IntPtr NativeFieldInfoPtr_m_EnableSteamDRM;

	// Token: 0x04000A06 RID: 2566
	private static readonly IntPtr NativeFieldInfoPtr_s_instance;

	// Token: 0x04000A07 RID: 2567
	private static readonly IntPtr NativeFieldInfoPtr_s_EverInialized;

	// Token: 0x04000A08 RID: 2568
	private static readonly IntPtr NativeFieldInfoPtr_m_bInitialized;

	// Token: 0x04000A09 RID: 2569
	private static readonly IntPtr NativeFieldInfoPtr_m_SteamAPIWarningMessageHook;

	// Token: 0x04000A0A RID: 2570
	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Private_Static_get_SteamManager_0;

	// Token: 0x04000A0B RID: 2571
	private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Static_get_Boolean_0;

	// Token: 0x04000A0C RID: 2572
	private static readonly IntPtr NativeMethodInfoPtr_SteamAPIDebugTextHook_Private_Static_Void_Int32_StringBuilder_0;

	// Token: 0x04000A0D RID: 2573
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000A0E RID: 2574
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x04000A0F RID: 2575
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x04000A10 RID: 2576
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000A11 RID: 2577
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
