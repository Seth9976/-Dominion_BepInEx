using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000096 RID: 150
public class VersionManager : MonoBehaviour
{
	// Token: 0x06001225 RID: 4645 RVA: 0x00050AA8 File Offset: 0x0004ECA8
	// Note: this type is marked as 'beforefieldinit'.
	static VersionManager()
	{
		Il2CppClassPointerStore<VersionManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "VersionManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionManager>.NativeClassPtr);
		VersionManager.NativeFieldInfoPtr_m_VersionNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionManager>.NativeClassPtr, "m_VersionNumber");
		VersionManager.NativeFieldInfoPtr_m_UsePlaytestVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionManager>.NativeClassPtr, "m_UsePlaytestVersion");
		VersionManager.NativeFieldInfoPtr_m_VersionTextString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionManager>.NativeClassPtr, "m_VersionTextString");
		VersionManager.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionManager>.NativeClassPtr, "_instance");
		VersionManager.NativeMethodInfoPtr_get_instance_Public_Static_get_VersionManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionManager>.NativeClassPtr, 100664706);
		VersionManager.NativeMethodInfoPtr_GetVersionTextString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionManager>.NativeClassPtr, 100664707);
		VersionManager.NativeMethodInfoPtr_UsePlaytestVersion_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionManager>.NativeClassPtr, 100664708);
		VersionManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionManager>.NativeClassPtr, 100664709);
		VersionManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionManager>.NativeClassPtr, 100664710);
	}

	// Token: 0x170005DB RID: 1499
	// (get) Token: 0x06001226 RID: 4646 RVA: 0x00050B8C File Offset: 0x0004ED8C
	public unsafe static VersionManager instance
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 243312, RefRangeEnd = 243316, XrefRangeStart = 243271, XrefRangeEnd = 243312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionManager.NativeMethodInfoPtr_get_instance_Public_Static_get_VersionManager_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VersionManager>(intPtr3) : null;
		}
	}

	// Token: 0x06001227 RID: 4647 RVA: 0x00050BC0 File Offset: 0x0004EDC0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetVersionTextString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionManager.NativeMethodInfoPtr_GetVersionTextString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06001228 RID: 4648 RVA: 0x00050BF8 File Offset: 0x0004EDF8
	[CallerCount(0)]
	public unsafe bool UsePlaytestVersion()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionManager.NativeMethodInfoPtr_UsePlaytestVersion_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001229 RID: 4649 RVA: 0x00050C34 File Offset: 0x0004EE34
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243316, XrefRangeEnd = 243321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600122A RID: 4650 RVA: 0x00050C68 File Offset: 0x0004EE68
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VersionManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600122B RID: 4651 RVA: 0x0000C22A File Offset: 0x0000A42A
	public VersionManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005D7 RID: 1495
	// (get) Token: 0x0600122C RID: 4652 RVA: 0x00050CA4 File Offset: 0x0004EEA4
	// (set) Token: 0x0600122D RID: 4653 RVA: 0x0000C233 File Offset: 0x0000A433
	public unsafe string m_VersionNumber
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionManager.NativeFieldInfoPtr_m_VersionNumber);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionManager.NativeFieldInfoPtr_m_VersionNumber), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170005D8 RID: 1496
	// (get) Token: 0x0600122E RID: 4654 RVA: 0x00050CCC File Offset: 0x0004EECC
	// (set) Token: 0x0600122F RID: 4655 RVA: 0x0000C252 File Offset: 0x0000A452
	public unsafe bool m_UsePlaytestVersion
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionManager.NativeFieldInfoPtr_m_UsePlaytestVersion);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionManager.NativeFieldInfoPtr_m_UsePlaytestVersion)) = value;
		}
	}

	// Token: 0x170005D9 RID: 1497
	// (get) Token: 0x06001230 RID: 4656 RVA: 0x00050CF4 File Offset: 0x0004EEF4
	// (set) Token: 0x06001231 RID: 4657 RVA: 0x0000C26D File Offset: 0x0000A46D
	public unsafe string m_VersionTextString
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionManager.NativeFieldInfoPtr_m_VersionTextString);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionManager.NativeFieldInfoPtr_m_VersionTextString), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170005DA RID: 1498
	// (get) Token: 0x06001232 RID: 4658 RVA: 0x00050D1C File Offset: 0x0004EF1C
	// (set) Token: 0x06001233 RID: 4659 RVA: 0x0000C28C File Offset: 0x0000A48C
	public unsafe static VersionManager _instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(VersionManager.NativeFieldInfoPtr__instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(VersionManager.NativeFieldInfoPtr__instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000CB7 RID: 3255
	private static readonly IntPtr NativeFieldInfoPtr_m_VersionNumber;

	// Token: 0x04000CB8 RID: 3256
	private static readonly IntPtr NativeFieldInfoPtr_m_UsePlaytestVersion;

	// Token: 0x04000CB9 RID: 3257
	private static readonly IntPtr NativeFieldInfoPtr_m_VersionTextString;

	// Token: 0x04000CBA RID: 3258
	private static readonly IntPtr NativeFieldInfoPtr__instance;

	// Token: 0x04000CBB RID: 3259
	private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_VersionManager_0;

	// Token: 0x04000CBC RID: 3260
	private static readonly IntPtr NativeMethodInfoPtr_GetVersionTextString_Public_String_0;

	// Token: 0x04000CBD RID: 3261
	private static readonly IntPtr NativeMethodInfoPtr_UsePlaytestVersion_Public_Boolean_0;

	// Token: 0x04000CBE RID: 3262
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000CBF RID: 3263
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
