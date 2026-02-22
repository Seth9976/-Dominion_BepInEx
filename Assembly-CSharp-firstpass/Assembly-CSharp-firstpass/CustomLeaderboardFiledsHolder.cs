using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000116 RID: 278
public class CustomLeaderboardFiledsHolder : MonoBehaviour
{
	// Token: 0x06001301 RID: 4865 RVA: 0x00058BB8 File Offset: 0x00056DB8
	// Note: this type is marked as 'beforefieldinit'.
	static CustomLeaderboardFiledsHolder()
	{
		Il2CppClassPointerStore<CustomLeaderboardFiledsHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CustomLeaderboardFiledsHolder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomLeaderboardFiledsHolder>.NativeClassPtr);
		CustomLeaderboardFiledsHolder.NativeFieldInfoPtr_rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomLeaderboardFiledsHolder>.NativeClassPtr, "rank");
		CustomLeaderboardFiledsHolder.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomLeaderboardFiledsHolder>.NativeClassPtr, "score");
		CustomLeaderboardFiledsHolder.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomLeaderboardFiledsHolder>.NativeClassPtr, "playerId");
		CustomLeaderboardFiledsHolder.NativeFieldInfoPtr_playerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomLeaderboardFiledsHolder>.NativeClassPtr, "playerName");
		CustomLeaderboardFiledsHolder.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomLeaderboardFiledsHolder>.NativeClassPtr, "avatar");
		CustomLeaderboardFiledsHolder.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomLeaderboardFiledsHolder>.NativeClassPtr, 100665588);
		CustomLeaderboardFiledsHolder.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomLeaderboardFiledsHolder>.NativeClassPtr, 100665589);
		CustomLeaderboardFiledsHolder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomLeaderboardFiledsHolder>.NativeClassPtr, 100665590);
	}

	// Token: 0x06001302 RID: 4866 RVA: 0x00058C88 File Offset: 0x00056E88
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183731, XrefRangeEnd = 183743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomLeaderboardFiledsHolder.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001303 RID: 4867 RVA: 0x00058CBC File Offset: 0x00056EBC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183743, XrefRangeEnd = 183757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Disable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomLeaderboardFiledsHolder.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001304 RID: 4868 RVA: 0x00058CF0 File Offset: 0x00056EF0
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CustomLeaderboardFiledsHolder()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomLeaderboardFiledsHolder>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomLeaderboardFiledsHolder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001305 RID: 4869 RVA: 0x00009648 File Offset: 0x00007848
	public CustomLeaderboardFiledsHolder(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000596 RID: 1430
	// (get) Token: 0x06001306 RID: 4870 RVA: 0x00058D2C File Offset: 0x00056F2C
	// (set) Token: 0x06001307 RID: 4871 RVA: 0x00009651 File Offset: 0x00007851
	public unsafe TextMesh rank
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomLeaderboardFiledsHolder.NativeFieldInfoPtr_rank);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMesh>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomLeaderboardFiledsHolder.NativeFieldInfoPtr_rank), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000597 RID: 1431
	// (get) Token: 0x06001308 RID: 4872 RVA: 0x00058D5C File Offset: 0x00056F5C
	// (set) Token: 0x06001309 RID: 4873 RVA: 0x00009670 File Offset: 0x00007870
	public unsafe TextMesh score
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomLeaderboardFiledsHolder.NativeFieldInfoPtr_score);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMesh>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomLeaderboardFiledsHolder.NativeFieldInfoPtr_score), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000598 RID: 1432
	// (get) Token: 0x0600130A RID: 4874 RVA: 0x00058D8C File Offset: 0x00056F8C
	// (set) Token: 0x0600130B RID: 4875 RVA: 0x0000968F File Offset: 0x0000788F
	public unsafe TextMesh playerId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomLeaderboardFiledsHolder.NativeFieldInfoPtr_playerId);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMesh>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomLeaderboardFiledsHolder.NativeFieldInfoPtr_playerId), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000599 RID: 1433
	// (get) Token: 0x0600130C RID: 4876 RVA: 0x00058DBC File Offset: 0x00056FBC
	// (set) Token: 0x0600130D RID: 4877 RVA: 0x000096AE File Offset: 0x000078AE
	public unsafe TextMesh playerName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomLeaderboardFiledsHolder.NativeFieldInfoPtr_playerName);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMesh>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomLeaderboardFiledsHolder.NativeFieldInfoPtr_playerName), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700059A RID: 1434
	// (get) Token: 0x0600130E RID: 4878 RVA: 0x00058DEC File Offset: 0x00056FEC
	// (set) Token: 0x0600130F RID: 4879 RVA: 0x000096CD File Offset: 0x000078CD
	public unsafe GameObject avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomLeaderboardFiledsHolder.NativeFieldInfoPtr_avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomLeaderboardFiledsHolder.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000E8D RID: 3725
	private static readonly IntPtr NativeFieldInfoPtr_rank;

	// Token: 0x04000E8E RID: 3726
	private static readonly IntPtr NativeFieldInfoPtr_score;

	// Token: 0x04000E8F RID: 3727
	private static readonly IntPtr NativeFieldInfoPtr_playerId;

	// Token: 0x04000E90 RID: 3728
	private static readonly IntPtr NativeFieldInfoPtr_playerName;

	// Token: 0x04000E91 RID: 3729
	private static readonly IntPtr NativeFieldInfoPtr_avatar;

	// Token: 0x04000E92 RID: 3730
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000E93 RID: 3731
	private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

	// Token: 0x04000E94 RID: 3732
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
