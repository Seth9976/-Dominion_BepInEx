using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000049 RID: 73
[Serializable]
public class GPScoreCollection : Object
{
	// Token: 0x06000626 RID: 1574 RVA: 0x0002C238 File Offset: 0x0002A438
	// Note: this type is marked as 'beforefieldinit'.
	static GPScoreCollection()
	{
		Il2CppClassPointerStore<GPScoreCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GPScoreCollection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPScoreCollection>.NativeClassPtr);
		GPScoreCollection.NativeFieldInfoPtr_AllTimeScores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPScoreCollection>.NativeClassPtr, "AllTimeScores");
		GPScoreCollection.NativeFieldInfoPtr_WeekScores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPScoreCollection>.NativeClassPtr, "WeekScores");
		GPScoreCollection.NativeFieldInfoPtr_TodayScores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPScoreCollection>.NativeClassPtr, "TodayScores");
		GPScoreCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPScoreCollection>.NativeClassPtr, 100664054);
	}

	// Token: 0x06000627 RID: 1575 RVA: 0x0002C2B8 File Offset: 0x0002A4B8
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 166477, RefRangeEnd = 166481, XrefRangeStart = 166462, XrefRangeEnd = 166477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GPScoreCollection()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPScoreCollection>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPScoreCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000628 RID: 1576 RVA: 0x0000476E File Offset: 0x0000296E
	public GPScoreCollection(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700020E RID: 526
	// (get) Token: 0x06000629 RID: 1577 RVA: 0x0002C2F4 File Offset: 0x0002A4F4
	// (set) Token: 0x0600062A RID: 1578 RVA: 0x00004777 File Offset: 0x00002977
	public unsafe Dictionary<int, GPScore> AllTimeScores
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPScoreCollection.NativeFieldInfoPtr_AllTimeScores);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GPScore>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPScoreCollection.NativeFieldInfoPtr_AllTimeScores), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700020F RID: 527
	// (get) Token: 0x0600062B RID: 1579 RVA: 0x0002C324 File Offset: 0x0002A524
	// (set) Token: 0x0600062C RID: 1580 RVA: 0x00004796 File Offset: 0x00002996
	public unsafe Dictionary<int, GPScore> WeekScores
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPScoreCollection.NativeFieldInfoPtr_WeekScores);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GPScore>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPScoreCollection.NativeFieldInfoPtr_WeekScores), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000210 RID: 528
	// (get) Token: 0x0600062D RID: 1581 RVA: 0x0002C354 File Offset: 0x0002A554
	// (set) Token: 0x0600062E RID: 1582 RVA: 0x000047B5 File Offset: 0x000029B5
	public unsafe Dictionary<int, GPScore> TodayScores
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPScoreCollection.NativeFieldInfoPtr_TodayScores);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GPScore>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPScoreCollection.NativeFieldInfoPtr_TodayScores), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000518 RID: 1304
	private static readonly IntPtr NativeFieldInfoPtr_AllTimeScores;

	// Token: 0x04000519 RID: 1305
	private static readonly IntPtr NativeFieldInfoPtr_WeekScores;

	// Token: 0x0400051A RID: 1306
	private static readonly IntPtr NativeFieldInfoPtr_TodayScores;

	// Token: 0x0400051B RID: 1307
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
