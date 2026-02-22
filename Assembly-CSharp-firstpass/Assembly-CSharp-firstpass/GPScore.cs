using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000048 RID: 72
[Serializable]
public class GPScore : Object
{
	// Token: 0x06000604 RID: 1540 RVA: 0x0002BA60 File Offset: 0x00029C60
	// Note: this type is marked as 'beforefieldinit'.
	static GPScore()
	{
		Il2CppClassPointerStore<GPScore>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GPScore");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPScore>.NativeClassPtr);
		GPScore.NativeFieldInfoPtr__rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPScore>.NativeClassPtr, "_rank");
		GPScore.NativeFieldInfoPtr__score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPScore>.NativeClassPtr, "_score");
		GPScore.NativeFieldInfoPtr__playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPScore>.NativeClassPtr, "_playerId");
		GPScore.NativeFieldInfoPtr__leaderboardId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPScore>.NativeClassPtr, "_leaderboardId");
		GPScore.NativeFieldInfoPtr__tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPScore>.NativeClassPtr, "_tag");
		GPScore.NativeFieldInfoPtr__collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPScore>.NativeClassPtr, "_collection");
		GPScore.NativeFieldInfoPtr__timeSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPScore>.NativeClassPtr, "_timeSpan");
		GPScore.NativeMethodInfoPtr__ctor_Public_Void_Int64_Int32_GPBoardTimeSpan_GPCollectionType_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPScore>.NativeClassPtr, 100664036);
		GPScore.NativeMethodInfoPtr_UpdateScore_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPScore>.NativeClassPtr, 100664037);
		GPScore.NativeMethodInfoPtr_get_rank_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPScore>.NativeClassPtr, 100664038);
		GPScore.NativeMethodInfoPtr_get_Rank_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPScore>.NativeClassPtr, 100664039);
		GPScore.NativeMethodInfoPtr_get_score_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPScore>.NativeClassPtr, 100664040);
		GPScore.NativeMethodInfoPtr_get_LongScore_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPScore>.NativeClassPtr, 100664041);
		GPScore.NativeMethodInfoPtr_get_CurrencyScore_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPScore>.NativeClassPtr, 100664042);
		GPScore.NativeMethodInfoPtr_get_TimeScore_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPScore>.NativeClassPtr, 100664043);
		GPScore.NativeMethodInfoPtr_get_Tag_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPScore>.NativeClassPtr, 100664044);
		GPScore.NativeMethodInfoPtr_get_playerId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPScore>.NativeClassPtr, 100664045);
		GPScore.NativeMethodInfoPtr_get_PlayerId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPScore>.NativeClassPtr, 100664046);
		GPScore.NativeMethodInfoPtr_get_Player_Public_get_GooglePlayerTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPScore>.NativeClassPtr, 100664047);
		GPScore.NativeMethodInfoPtr_get_leaderboardId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPScore>.NativeClassPtr, 100664048);
		GPScore.NativeMethodInfoPtr_get_LeaderboardId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPScore>.NativeClassPtr, 100664049);
		GPScore.NativeMethodInfoPtr_get_collection_Public_get_GPCollectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPScore>.NativeClassPtr, 100664050);
		GPScore.NativeMethodInfoPtr_get_Collection_Public_get_GPCollectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPScore>.NativeClassPtr, 100664051);
		GPScore.NativeMethodInfoPtr_get_timeSpan_Public_get_GPBoardTimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPScore>.NativeClassPtr, 100664052);
		GPScore.NativeMethodInfoPtr_get_TimeSpan_Public_get_GPBoardTimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPScore>.NativeClassPtr, 100664053);
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x0002BC84 File Offset: 0x00029E84
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 166447, RefRangeEnd = 166450, XrefRangeStart = 166444, XrefRangeEnd = 166447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GPScore(long vScore, int vRank, GPBoardTimeSpan vTimeSpan, GPCollectionType sCollection, string lid, string pid, string tag)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPScore>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref vScore;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vRank;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vTimeSpan;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sCollection;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lid);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pid);
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tag);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPScore.NativeMethodInfoPtr__ctor_Public_Void_Int64_Int32_GPBoardTimeSpan_GPCollectionType_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x0002BD30 File Offset: 0x00029F30
	[CallerCount(0)]
	public unsafe void UpdateScore(long vScore)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref vScore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPScore.NativeMethodInfoPtr_UpdateScore_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x170001FE RID: 510
	// (get) Token: 0x06000607 RID: 1543 RVA: 0x0002BD70 File Offset: 0x00029F70
	public unsafe int rank
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPScore.NativeMethodInfoPtr_get_rank_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170001FF RID: 511
	// (get) Token: 0x06000608 RID: 1544 RVA: 0x0002BDAC File Offset: 0x00029FAC
	public unsafe int Rank
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPScore.NativeMethodInfoPtr_get_Rank_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000200 RID: 512
	// (get) Token: 0x06000609 RID: 1545 RVA: 0x0002BDE8 File Offset: 0x00029FE8
	public unsafe long score
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPScore.NativeMethodInfoPtr_get_score_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000201 RID: 513
	// (get) Token: 0x0600060A RID: 1546 RVA: 0x0002BE24 File Offset: 0x0002A024
	public unsafe long LongScore
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPScore.NativeMethodInfoPtr_get_LongScore_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000202 RID: 514
	// (get) Token: 0x0600060B RID: 1547 RVA: 0x0002BE60 File Offset: 0x0002A060
	public unsafe float CurrencyScore
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPScore.NativeMethodInfoPtr_get_CurrencyScore_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000203 RID: 515
	// (get) Token: 0x0600060C RID: 1548 RVA: 0x0002BE9C File Offset: 0x0002A09C
	public unsafe TimeSpan TimeScore
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166450, XrefRangeEnd = 166454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPScore.NativeMethodInfoPtr_get_TimeScore_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000204 RID: 516
	// (get) Token: 0x0600060D RID: 1549 RVA: 0x0002BED8 File Offset: 0x0002A0D8
	public unsafe string Tag
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPScore.NativeMethodInfoPtr_get_Tag_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000205 RID: 517
	// (get) Token: 0x0600060E RID: 1550 RVA: 0x0002BF10 File Offset: 0x0002A110
	public unsafe string playerId
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPScore.NativeMethodInfoPtr_get_playerId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000206 RID: 518
	// (get) Token: 0x0600060F RID: 1551 RVA: 0x0002BF48 File Offset: 0x0002A148
	public unsafe string PlayerId
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPScore.NativeMethodInfoPtr_get_PlayerId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000207 RID: 519
	// (get) Token: 0x06000610 RID: 1552 RVA: 0x0002BF80 File Offset: 0x0002A180
	public unsafe GooglePlayerTemplate Player
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166454, XrefRangeEnd = 166462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPScore.NativeMethodInfoPtr_get_Player_Public_get_GooglePlayerTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GooglePlayerTemplate>(intPtr3) : null;
		}
	}

	// Token: 0x17000208 RID: 520
	// (get) Token: 0x06000611 RID: 1553 RVA: 0x0002BFC0 File Offset: 0x0002A1C0
	public unsafe string leaderboardId
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPScore.NativeMethodInfoPtr_get_leaderboardId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000209 RID: 521
	// (get) Token: 0x06000612 RID: 1554 RVA: 0x0002BFF8 File Offset: 0x0002A1F8
	public unsafe string LeaderboardId
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPScore.NativeMethodInfoPtr_get_LeaderboardId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x1700020A RID: 522
	// (get) Token: 0x06000613 RID: 1555 RVA: 0x0002C030 File Offset: 0x0002A230
	public unsafe GPCollectionType collection
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPScore.NativeMethodInfoPtr_get_collection_Public_get_GPCollectionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700020B RID: 523
	// (get) Token: 0x06000614 RID: 1556 RVA: 0x0002C06C File Offset: 0x0002A26C
	public unsafe GPCollectionType Collection
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPScore.NativeMethodInfoPtr_get_Collection_Public_get_GPCollectionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700020C RID: 524
	// (get) Token: 0x06000615 RID: 1557 RVA: 0x0002C0A8 File Offset: 0x0002A2A8
	public unsafe GPBoardTimeSpan timeSpan
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPScore.NativeMethodInfoPtr_get_timeSpan_Public_get_GPBoardTimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700020D RID: 525
	// (get) Token: 0x06000616 RID: 1558 RVA: 0x0002C0E4 File Offset: 0x0002A2E4
	public unsafe GPBoardTimeSpan TimeSpan
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPScore.NativeMethodInfoPtr_get_TimeSpan_Public_get_GPBoardTimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000617 RID: 1559 RVA: 0x0000469C File Offset: 0x0000289C
	public GPScore(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170001F7 RID: 503
	// (get) Token: 0x06000618 RID: 1560 RVA: 0x0002C120 File Offset: 0x0002A320
	// (set) Token: 0x06000619 RID: 1561 RVA: 0x000046A5 File Offset: 0x000028A5
	public unsafe int _rank
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPScore.NativeFieldInfoPtr__rank);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPScore.NativeFieldInfoPtr__rank)) = value;
		}
	}

	// Token: 0x170001F8 RID: 504
	// (get) Token: 0x0600061A RID: 1562 RVA: 0x0002C148 File Offset: 0x0002A348
	// (set) Token: 0x0600061B RID: 1563 RVA: 0x000046C0 File Offset: 0x000028C0
	public unsafe long _score
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPScore.NativeFieldInfoPtr__score);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPScore.NativeFieldInfoPtr__score)) = value;
		}
	}

	// Token: 0x170001F9 RID: 505
	// (get) Token: 0x0600061C RID: 1564 RVA: 0x0002C170 File Offset: 0x0002A370
	// (set) Token: 0x0600061D RID: 1565 RVA: 0x000046DB File Offset: 0x000028DB
	public unsafe string _playerId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPScore.NativeFieldInfoPtr__playerId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPScore.NativeFieldInfoPtr__playerId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170001FA RID: 506
	// (get) Token: 0x0600061E RID: 1566 RVA: 0x0002C198 File Offset: 0x0002A398
	// (set) Token: 0x0600061F RID: 1567 RVA: 0x000046FA File Offset: 0x000028FA
	public unsafe string _leaderboardId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPScore.NativeFieldInfoPtr__leaderboardId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPScore.NativeFieldInfoPtr__leaderboardId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170001FB RID: 507
	// (get) Token: 0x06000620 RID: 1568 RVA: 0x0002C1C0 File Offset: 0x0002A3C0
	// (set) Token: 0x06000621 RID: 1569 RVA: 0x00004719 File Offset: 0x00002919
	public unsafe string _tag
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPScore.NativeFieldInfoPtr__tag);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPScore.NativeFieldInfoPtr__tag), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170001FC RID: 508
	// (get) Token: 0x06000622 RID: 1570 RVA: 0x0002C1E8 File Offset: 0x0002A3E8
	// (set) Token: 0x06000623 RID: 1571 RVA: 0x00004738 File Offset: 0x00002938
	public unsafe GPCollectionType _collection
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPScore.NativeFieldInfoPtr__collection);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPScore.NativeFieldInfoPtr__collection)) = value;
		}
	}

	// Token: 0x170001FD RID: 509
	// (get) Token: 0x06000624 RID: 1572 RVA: 0x0002C210 File Offset: 0x0002A410
	// (set) Token: 0x06000625 RID: 1573 RVA: 0x00004753 File Offset: 0x00002953
	public unsafe GPBoardTimeSpan _timeSpan
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPScore.NativeFieldInfoPtr__timeSpan);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPScore.NativeFieldInfoPtr__timeSpan)) = value;
		}
	}

	// Token: 0x040004FF RID: 1279
	private static readonly IntPtr NativeFieldInfoPtr__rank;

	// Token: 0x04000500 RID: 1280
	private static readonly IntPtr NativeFieldInfoPtr__score;

	// Token: 0x04000501 RID: 1281
	private static readonly IntPtr NativeFieldInfoPtr__playerId;

	// Token: 0x04000502 RID: 1282
	private static readonly IntPtr NativeFieldInfoPtr__leaderboardId;

	// Token: 0x04000503 RID: 1283
	private static readonly IntPtr NativeFieldInfoPtr__tag;

	// Token: 0x04000504 RID: 1284
	private static readonly IntPtr NativeFieldInfoPtr__collection;

	// Token: 0x04000505 RID: 1285
	private static readonly IntPtr NativeFieldInfoPtr__timeSpan;

	// Token: 0x04000506 RID: 1286
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_Int32_GPBoardTimeSpan_GPCollectionType_String_String_String_0;

	// Token: 0x04000507 RID: 1287
	private static readonly IntPtr NativeMethodInfoPtr_UpdateScore_Public_Void_Int64_0;

	// Token: 0x04000508 RID: 1288
	private static readonly IntPtr NativeMethodInfoPtr_get_rank_Public_get_Int32_0;

	// Token: 0x04000509 RID: 1289
	private static readonly IntPtr NativeMethodInfoPtr_get_Rank_Public_get_Int32_0;

	// Token: 0x0400050A RID: 1290
	private static readonly IntPtr NativeMethodInfoPtr_get_score_Public_get_Int64_0;

	// Token: 0x0400050B RID: 1291
	private static readonly IntPtr NativeMethodInfoPtr_get_LongScore_Public_get_Int64_0;

	// Token: 0x0400050C RID: 1292
	private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyScore_Public_get_Single_0;

	// Token: 0x0400050D RID: 1293
	private static readonly IntPtr NativeMethodInfoPtr_get_TimeScore_Public_get_TimeSpan_0;

	// Token: 0x0400050E RID: 1294
	private static readonly IntPtr NativeMethodInfoPtr_get_Tag_Public_get_String_0;

	// Token: 0x0400050F RID: 1295
	private static readonly IntPtr NativeMethodInfoPtr_get_playerId_Public_get_String_0;

	// Token: 0x04000510 RID: 1296
	private static readonly IntPtr NativeMethodInfoPtr_get_PlayerId_Public_get_String_0;

	// Token: 0x04000511 RID: 1297
	private static readonly IntPtr NativeMethodInfoPtr_get_Player_Public_get_GooglePlayerTemplate_0;

	// Token: 0x04000512 RID: 1298
	private static readonly IntPtr NativeMethodInfoPtr_get_leaderboardId_Public_get_String_0;

	// Token: 0x04000513 RID: 1299
	private static readonly IntPtr NativeMethodInfoPtr_get_LeaderboardId_Public_get_String_0;

	// Token: 0x04000514 RID: 1300
	private static readonly IntPtr NativeMethodInfoPtr_get_collection_Public_get_GPCollectionType_0;

	// Token: 0x04000515 RID: 1301
	private static readonly IntPtr NativeMethodInfoPtr_get_Collection_Public_get_GPCollectionType_0;

	// Token: 0x04000516 RID: 1302
	private static readonly IntPtr NativeMethodInfoPtr_get_timeSpan_Public_get_GPBoardTimeSpan_0;

	// Token: 0x04000517 RID: 1303
	private static readonly IntPtr NativeMethodInfoPtr_get_TimeSpan_Public_get_GPBoardTimeSpan_0;
}
