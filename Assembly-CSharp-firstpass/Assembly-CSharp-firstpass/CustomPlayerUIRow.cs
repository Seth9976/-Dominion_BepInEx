using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000117 RID: 279
public class CustomPlayerUIRow : MonoBehaviour
{
	// Token: 0x06001310 RID: 4880 RVA: 0x00058E1C File Offset: 0x0005701C
	// Note: this type is marked as 'beforefieldinit'.
	static CustomPlayerUIRow()
	{
		Il2CppClassPointerStore<CustomPlayerUIRow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CustomPlayerUIRow");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomPlayerUIRow>.NativeClassPtr);
		CustomPlayerUIRow.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomPlayerUIRow>.NativeClassPtr, "playerId");
		CustomPlayerUIRow.NativeFieldInfoPtr_playerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomPlayerUIRow>.NativeClassPtr, "playerName");
		CustomPlayerUIRow.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomPlayerUIRow>.NativeClassPtr, "avatar");
		CustomPlayerUIRow.NativeFieldInfoPtr_hasIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomPlayerUIRow>.NativeClassPtr, "hasIcon");
		CustomPlayerUIRow.NativeFieldInfoPtr_hasImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomPlayerUIRow>.NativeClassPtr, "hasImage");
		CustomPlayerUIRow.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomPlayerUIRow>.NativeClassPtr, 100665591);
		CustomPlayerUIRow.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomPlayerUIRow>.NativeClassPtr, 100665592);
		CustomPlayerUIRow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomPlayerUIRow>.NativeClassPtr, 100665593);
	}

	// Token: 0x06001311 RID: 4881 RVA: 0x00058EEC File Offset: 0x000570EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183757, XrefRangeEnd = 183769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomPlayerUIRow.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001312 RID: 4882 RVA: 0x00058F20 File Offset: 0x00057120
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183769, XrefRangeEnd = 183783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Disable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomPlayerUIRow.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001313 RID: 4883 RVA: 0x00058F54 File Offset: 0x00057154
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CustomPlayerUIRow()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomPlayerUIRow>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomPlayerUIRow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001314 RID: 4884 RVA: 0x000096EC File Offset: 0x000078EC
	public CustomPlayerUIRow(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700059B RID: 1435
	// (get) Token: 0x06001315 RID: 4885 RVA: 0x00058F90 File Offset: 0x00057190
	// (set) Token: 0x06001316 RID: 4886 RVA: 0x000096F5 File Offset: 0x000078F5
	public unsafe TextMesh playerId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomPlayerUIRow.NativeFieldInfoPtr_playerId);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMesh>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomPlayerUIRow.NativeFieldInfoPtr_playerId), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700059C RID: 1436
	// (get) Token: 0x06001317 RID: 4887 RVA: 0x00058FC0 File Offset: 0x000571C0
	// (set) Token: 0x06001318 RID: 4888 RVA: 0x00009714 File Offset: 0x00007914
	public unsafe TextMesh playerName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomPlayerUIRow.NativeFieldInfoPtr_playerName);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMesh>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomPlayerUIRow.NativeFieldInfoPtr_playerName), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700059D RID: 1437
	// (get) Token: 0x06001319 RID: 4889 RVA: 0x00058FF0 File Offset: 0x000571F0
	// (set) Token: 0x0600131A RID: 4890 RVA: 0x00009733 File Offset: 0x00007933
	public unsafe GameObject avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomPlayerUIRow.NativeFieldInfoPtr_avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomPlayerUIRow.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700059E RID: 1438
	// (get) Token: 0x0600131B RID: 4891 RVA: 0x00059020 File Offset: 0x00057220
	// (set) Token: 0x0600131C RID: 4892 RVA: 0x00009752 File Offset: 0x00007952
	public unsafe TextMesh hasIcon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomPlayerUIRow.NativeFieldInfoPtr_hasIcon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMesh>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomPlayerUIRow.NativeFieldInfoPtr_hasIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700059F RID: 1439
	// (get) Token: 0x0600131D RID: 4893 RVA: 0x00059050 File Offset: 0x00057250
	// (set) Token: 0x0600131E RID: 4894 RVA: 0x00009771 File Offset: 0x00007971
	public unsafe TextMesh hasImage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomPlayerUIRow.NativeFieldInfoPtr_hasImage);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMesh>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomPlayerUIRow.NativeFieldInfoPtr_hasImage), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000E95 RID: 3733
	private static readonly IntPtr NativeFieldInfoPtr_playerId;

	// Token: 0x04000E96 RID: 3734
	private static readonly IntPtr NativeFieldInfoPtr_playerName;

	// Token: 0x04000E97 RID: 3735
	private static readonly IntPtr NativeFieldInfoPtr_avatar;

	// Token: 0x04000E98 RID: 3736
	private static readonly IntPtr NativeFieldInfoPtr_hasIcon;

	// Token: 0x04000E99 RID: 3737
	private static readonly IntPtr NativeFieldInfoPtr_hasImage;

	// Token: 0x04000E9A RID: 3738
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000E9B RID: 3739
	private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

	// Token: 0x04000E9C RID: 3740
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
