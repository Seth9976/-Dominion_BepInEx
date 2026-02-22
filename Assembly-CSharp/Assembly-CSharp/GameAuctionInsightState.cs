using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000051 RID: 81
public sealed class GameAuctionInsightState : ValueType
{
	// Token: 0x06000CC6 RID: 3270 RVA: 0x000402A0 File Offset: 0x0003E4A0
	// Note: this type is marked as 'beforefieldinit'.
	static GameAuctionInsightState()
	{
		Il2CppClassPointerStore<GameAuctionInsightState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GameAuctionInsightState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameAuctionInsightState>.NativeClassPtr);
		GameAuctionInsightState.NativeFieldInfoPtr_auction_card_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameAuctionInsightState>.NativeClassPtr, "auction_card_instance_id");
		GameAuctionInsightState.NativeFieldInfoPtr_first_bidder_player_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameAuctionInsightState>.NativeClassPtr, "first_bidder_player_index");
		GameAuctionInsightState.NativeFieldInfoPtr_bid_player_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameAuctionInsightState>.NativeClassPtr, "bid_player_index");
		GameAuctionInsightState.NativeFieldInfoPtr_insight_available = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameAuctionInsightState>.NativeClassPtr, "insight_available");
		GameAuctionInsightState.NativeFieldInfoPtr_insight_bid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameAuctionInsightState>.NativeClassPtr, "insight_bid");
	}

	// Token: 0x06000CC7 RID: 3271 RVA: 0x00009951 File Offset: 0x00007B51
	public GameAuctionInsightState(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x06000CC8 RID: 3272 RVA: 0x0000995A File Offset: 0x00007B5A
	public GameAuctionInsightState()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameAuctionInsightState>.NativeClassPtr))
	{
	}

	// Token: 0x17000448 RID: 1096
	// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x00040334 File Offset: 0x0003E534
	// (set) Token: 0x06000CCA RID: 3274 RVA: 0x0000996C File Offset: 0x00007B6C
	public unsafe int auction_card_instance_id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameAuctionInsightState.NativeFieldInfoPtr_auction_card_instance_id);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameAuctionInsightState.NativeFieldInfoPtr_auction_card_instance_id)) = value;
		}
	}

	// Token: 0x17000449 RID: 1097
	// (get) Token: 0x06000CCB RID: 3275 RVA: 0x0004035C File Offset: 0x0003E55C
	// (set) Token: 0x06000CCC RID: 3276 RVA: 0x00009987 File Offset: 0x00007B87
	public unsafe int first_bidder_player_index
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameAuctionInsightState.NativeFieldInfoPtr_first_bidder_player_index);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameAuctionInsightState.NativeFieldInfoPtr_first_bidder_player_index)) = value;
		}
	}

	// Token: 0x1700044A RID: 1098
	// (get) Token: 0x06000CCD RID: 3277 RVA: 0x00040384 File Offset: 0x0003E584
	// (set) Token: 0x06000CCE RID: 3278 RVA: 0x000099A2 File Offset: 0x00007BA2
	public unsafe Il2CppStructArray<int> bid_player_index
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameAuctionInsightState.NativeFieldInfoPtr_bid_player_index);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameAuctionInsightState.NativeFieldInfoPtr_bid_player_index), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700044B RID: 1099
	// (get) Token: 0x06000CCF RID: 3279 RVA: 0x000403B4 File Offset: 0x0003E5B4
	// (set) Token: 0x06000CD0 RID: 3280 RVA: 0x000099C1 File Offset: 0x00007BC1
	public unsafe Il2CppStructArray<int> insight_available
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameAuctionInsightState.NativeFieldInfoPtr_insight_available);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameAuctionInsightState.NativeFieldInfoPtr_insight_available), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700044C RID: 1100
	// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x000403E4 File Offset: 0x0003E5E4
	// (set) Token: 0x06000CD2 RID: 3282 RVA: 0x000099E0 File Offset: 0x00007BE0
	public unsafe Il2CppStructArray<int> insight_bid
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameAuctionInsightState.NativeFieldInfoPtr_insight_bid);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameAuctionInsightState.NativeFieldInfoPtr_insight_bid), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400084F RID: 2127
	private static readonly IntPtr NativeFieldInfoPtr_auction_card_instance_id;

	// Token: 0x04000850 RID: 2128
	private static readonly IntPtr NativeFieldInfoPtr_first_bidder_player_index;

	// Token: 0x04000851 RID: 2129
	private static readonly IntPtr NativeFieldInfoPtr_bid_player_index;

	// Token: 0x04000852 RID: 2130
	private static readonly IntPtr NativeFieldInfoPtr_insight_available;

	// Token: 0x04000853 RID: 2131
	private static readonly IntPtr NativeFieldInfoPtr_insight_bid;
}
