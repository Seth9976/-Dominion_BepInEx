using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x0200006A RID: 106
public class InitializeAscensionLib : MonoBehaviour
{
	// Token: 0x06000DCC RID: 3532 RVA: 0x00041EB4 File Offset: 0x000400B4
	// Note: this type is marked as 'beforefieldinit'.
	static InitializeAscensionLib()
	{
		Il2CppClassPointerStore<InitializeAscensionLib>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "InitializeAscensionLib");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeAscensionLib>.NativeClassPtr);
		InitializeAscensionLib.NativeFieldInfoPtr_m_RunSoakTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeAscensionLib>.NativeClassPtr, "m_RunSoakTest");
		InitializeAscensionLib.NativeFieldInfoPtr_m_HidePromoPack6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeAscensionLib>.NativeClassPtr, "m_HidePromoPack6");
		InitializeAscensionLib.NativeFieldInfoPtr_m_HideValleyOfTheAncients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeAscensionLib>.NativeClassPtr, "m_HideValleyOfTheAncients");
		InitializeAscensionLib.NativeFieldInfoPtr_m_HideDelirium = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeAscensionLib>.NativeClassPtr, "m_HideDelirium");
		InitializeAscensionLib.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeAscensionLib>.NativeClassPtr, 100664236);
		InitializeAscensionLib.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeAscensionLib>.NativeClassPtr, 100664237);
	}

	// Token: 0x06000DCD RID: 3533 RVA: 0x00041F5C File Offset: 0x0004015C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238136, XrefRangeEnd = 238250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeAscensionLib.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DCE RID: 3534 RVA: 0x00041F90 File Offset: 0x00040190
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238250, XrefRangeEnd = 238251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InitializeAscensionLib()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializeAscensionLib>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeAscensionLib.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DCF RID: 3535 RVA: 0x0000A23A File Offset: 0x0000843A
	public InitializeAscensionLib(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004B8 RID: 1208
	// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x00041FCC File Offset: 0x000401CC
	// (set) Token: 0x06000DD1 RID: 3537 RVA: 0x0000A243 File Offset: 0x00008443
	public unsafe bool m_RunSoakTest
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeAscensionLib.NativeFieldInfoPtr_m_RunSoakTest);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeAscensionLib.NativeFieldInfoPtr_m_RunSoakTest)) = value;
		}
	}

	// Token: 0x170004B9 RID: 1209
	// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x00041FF4 File Offset: 0x000401F4
	// (set) Token: 0x06000DD3 RID: 3539 RVA: 0x0000A25E File Offset: 0x0000845E
	public unsafe bool m_HidePromoPack6
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeAscensionLib.NativeFieldInfoPtr_m_HidePromoPack6);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeAscensionLib.NativeFieldInfoPtr_m_HidePromoPack6)) = value;
		}
	}

	// Token: 0x170004BA RID: 1210
	// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x0004201C File Offset: 0x0004021C
	// (set) Token: 0x06000DD5 RID: 3541 RVA: 0x0000A279 File Offset: 0x00008479
	public unsafe bool m_HideValleyOfTheAncients
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeAscensionLib.NativeFieldInfoPtr_m_HideValleyOfTheAncients);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeAscensionLib.NativeFieldInfoPtr_m_HideValleyOfTheAncients)) = value;
		}
	}

	// Token: 0x170004BB RID: 1211
	// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x00042044 File Offset: 0x00040244
	// (set) Token: 0x06000DD7 RID: 3543 RVA: 0x0000A294 File Offset: 0x00008494
	public unsafe bool m_HideDelirium
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeAscensionLib.NativeFieldInfoPtr_m_HideDelirium);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeAscensionLib.NativeFieldInfoPtr_m_HideDelirium)) = value;
		}
	}

	// Token: 0x0400096E RID: 2414
	private static readonly IntPtr NativeFieldInfoPtr_m_RunSoakTest;

	// Token: 0x0400096F RID: 2415
	private static readonly IntPtr NativeFieldInfoPtr_m_HidePromoPack6;

	// Token: 0x04000970 RID: 2416
	private static readonly IntPtr NativeFieldInfoPtr_m_HideValleyOfTheAncients;

	// Token: 0x04000971 RID: 2417
	private static readonly IntPtr NativeFieldInfoPtr_m_HideDelirium;

	// Token: 0x04000972 RID: 2418
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000973 RID: 2419
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
