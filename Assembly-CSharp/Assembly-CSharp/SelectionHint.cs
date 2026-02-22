using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200005E RID: 94
public class SelectionHint : Object
{
	// Token: 0x06000CF6 RID: 3318 RVA: 0x00040A74 File Offset: 0x0003EC74
	// Note: this type is marked as 'beforefieldinit'.
	static SelectionHint()
	{
		Il2CppClassPointerStore<SelectionHint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SelectionHint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr);
		SelectionHint.NativeFieldInfoPtr_NONE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "NONE");
		SelectionHint.NativeFieldInfoPtr_END_TURN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "END_TURN");
		SelectionHint.NativeFieldInfoPtr_CANCEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "CANCEL");
		SelectionHint.NativeFieldInfoPtr_PLAY_CARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "PLAY_CARD");
		SelectionHint.NativeFieldInfoPtr_PLAY_CONSTRUCT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "PLAY_CONSTRUCT");
		SelectionHint.NativeFieldInfoPtr_PLAY_ENTIRE_HAND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "PLAY_ENTIRE_HAND");
		SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "ACQUIRE_CARD");
		SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD_TO_DISCARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "ACQUIRE_CARD_TO_DISCARD");
		SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD_TO_DECK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "ACQUIRE_CARD_TO_DECK");
		SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD_INTO_PLAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "ACQUIRE_CARD_INTO_PLAY");
		SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD_TO_HAND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "ACQUIRE_CARD_TO_HAND");
		SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD_FROM_VOID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "ACQUIRE_CARD_FROM_VOID");
		SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD_FROM_VOID_TO_DECK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "ACQUIRE_CARD_FROM_VOID_TO_DECK");
		SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD_FROM_VOID_INTO_PLAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "ACQUIRE_CARD_FROM_VOID_INTO_PLAY");
		SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD_FROM_VOID_TO_HAND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "ACQUIRE_CARD_FROM_VOID_TO_HAND");
		SelectionHint.NativeFieldInfoPtr_ACQUIRE_TEMPLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "ACQUIRE_TEMPLE");
		SelectionHint.NativeFieldInfoPtr_MOVE_TREASURE_FROM_CENTER_ROW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "MOVE_TREASURE_FROM_CENTER_ROW");
		SelectionHint.NativeFieldInfoPtr_MOVE_TREASURE_TO_CENTER_ROW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "MOVE_TREASURE_TO_CENTER_ROW");
		SelectionHint.NativeFieldInfoPtr_ACQUIRE_PORTAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "ACQUIRE_PORTAL");
		SelectionHint.NativeFieldInfoPtr_ACQUIRE_VISION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "ACQUIRE_VISION");
		SelectionHint.NativeFieldInfoPtr_ACQUIRE_VISION_ONGOING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "ACQUIRE_VISION_ONGOING");
		SelectionHint.NativeFieldInfoPtr_PUT_DISCARD_IN_HAND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "PUT_DISCARD_IN_HAND");
		SelectionHint.NativeFieldInfoPtr_PUT_DISCARD_ON_DECK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "PUT_DISCARD_ON_DECK");
		SelectionHint.NativeFieldInfoPtr_PUT_REVEALED_CARD_ON_DECK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "PUT_REVEALED_CARD_ON_DECK");
		SelectionHint.NativeFieldInfoPtr_PUT_REVEALED_CARD_IN_DISCARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "PUT_REVEALED_CARD_IN_DISCARD");
		SelectionHint.NativeFieldInfoPtr_PUT_CARD_UNDER_CONSTRUCT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "PUT_CARD_UNDER_CONSTRUCT");
		SelectionHint.NativeFieldInfoPtr_DRAW_CARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "DRAW_CARD");
		SelectionHint.NativeFieldInfoPtr_PUT_CARD_ON_PORTAL_DECK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "PUT_CARD_ON_PORTAL_DECK");
		SelectionHint.NativeFieldInfoPtr_TAKE_DISCARD_FROM_OPPONENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "TAKE_DISCARD_FROM_OPPONENT");
		SelectionHint.NativeFieldInfoPtr_PUT_VOID_CARD_ON_PORTAL_DECK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "PUT_VOID_CARD_ON_PORTAL_DECK");
		SelectionHint.NativeFieldInfoPtr_DEFEAT_MONSTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "DEFEAT_MONSTER");
		SelectionHint.NativeFieldInfoPtr_DEFEAT_CULTIST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "DEFEAT_CULTIST");
		SelectionHint.NativeFieldInfoPtr_DEFEAT_MONSTER_IN_VOID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "DEFEAT_MONSTER_IN_VOID");
		SelectionHint.NativeFieldInfoPtr_DEFEAT_MONSTER_TO_DISCARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "DEFEAT_MONSTER_TO_DISCARD");
		SelectionHint.NativeFieldInfoPtr_DEFEAT_MONSTER_IN_VOID_TO_DISCARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "DEFEAT_MONSTER_IN_VOID_TO_DISCARD");
		SelectionHint.NativeFieldInfoPtr_DEFEAT_TROPHY_MONSTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "DEFEAT_TROPHY_MONSTER");
		SelectionHint.NativeFieldInfoPtr_DEFEAT_HERO_WITH_POWER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "DEFEAT_HERO_WITH_POWER");
		SelectionHint.NativeFieldInfoPtr_DEFEAT_MONSTER_INTO_PLAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "DEFEAT_MONSTER_INTO_PLAY");
		SelectionHint.NativeFieldInfoPtr_DEFEAT_MONSTER_IN_VOID_INTO_PLAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "DEFEAT_MONSTER_IN_VOID_INTO_PLAY");
		SelectionHint.NativeFieldInfoPtr_DEFEAT_MONSTER_TO_PORTAL_DECK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "DEFEAT_MONSTER_TO_PORTAL_DECK");
		SelectionHint.NativeFieldInfoPtr_DISCARD_CARD_FROM_HAND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "DISCARD_CARD_FROM_HAND");
		SelectionHint.NativeFieldInfoPtr_DISCARD_CONSTRUCT_FROM_PLAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "DISCARD_CONSTRUCT_FROM_PLAY");
		SelectionHint.NativeFieldInfoPtr_DISCARD_ALL_OTHER_CONSTRUCT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "DISCARD_ALL_OTHER_CONSTRUCT");
		SelectionHint.NativeFieldInfoPtr_DISCARD_ALL_CONSTRUCTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "DISCARD_ALL_CONSTRUCTS");
		SelectionHint.NativeFieldInfoPtr_RETURN_CONSTRUCT_TO_HAND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "RETURN_CONSTRUCT_TO_HAND");
		SelectionHint.NativeFieldInfoPtr_PREVENT_DESTROY_CONSTRUCT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "PREVENT_DESTROY_CONSTRUCT");
		SelectionHint.NativeFieldInfoPtr_DISCARD_CONSTRUCT_FROM_OPP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "DISCARD_CONSTRUCT_FROM_OPP");
		SelectionHint.NativeFieldInfoPtr_ACQUIRE_CONSTRUCT_FROM_OPP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "ACQUIRE_CONSTRUCT_FROM_OPP");
		SelectionHint.NativeFieldInfoPtr_DISCARD_CARD_TO_PLAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "DISCARD_CARD_TO_PLAYER");
		SelectionHint.NativeFieldInfoPtr_DISCARD_MONSTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "DISCARD_MONSTER");
		SelectionHint.NativeFieldInfoPtr_DISCARD_MONSTER_IN_VOID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "DISCARD_MONSTER_IN_VOID");
		SelectionHint.NativeFieldInfoPtr_DISCARD_CARD_ONTO_DECK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "DISCARD_CARD_ONTO_DECK");
		SelectionHint.NativeFieldInfoPtr_BANISH_CARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "BANISH_CARD");
		SelectionHint.NativeFieldInfoPtr_BANISH_CARD_MASK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "BANISH_CARD_MASK");
		SelectionHint.NativeFieldInfoPtr_BANISH_CARD_FROM_HAND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "BANISH_CARD_FROM_HAND");
		SelectionHint.NativeFieldInfoPtr_BANISH_CARD_FROM_DISCARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "BANISH_CARD_FROM_DISCARD");
		SelectionHint.NativeFieldInfoPtr_BANISH_CARD_FROM_CENTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "BANISH_CARD_FROM_CENTER");
		SelectionHint.NativeFieldInfoPtr_BANISH_CARD_FROM_DECK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "BANISH_CARD_FROM_DECK");
		SelectionHint.NativeFieldInfoPtr_BANISH_PHANTASM_FROM_CENTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "BANISH_PHANTASM_FROM_CENTER");
		SelectionHint.NativeFieldInfoPtr_USE_CONSTRUCT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "USE_CONSTRUCT");
		SelectionHint.NativeFieldInfoPtr_USE_TROPHY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "USE_TROPHY");
		SelectionHint.NativeFieldInfoPtr_USE_CONSTRUCT_TRANSFORM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "USE_CONSTRUCT_TRANSFORM");
		SelectionHint.NativeFieldInfoPtr_CHOOSE_EFFECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "CHOOSE_EFFECT");
		SelectionHint.NativeFieldInfoPtr_COPY_EFFECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "COPY_EFFECT");
		SelectionHint.NativeFieldInfoPtr_COPY_LIFEBOUND_FROM_LIST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "COPY_LIFEBOUND_FROM_LIST");
		SelectionHint.NativeFieldInfoPtr_COPY_DEFEATED_MONSTER_FROM_LIST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "COPY_DEFEATED_MONSTER_FROM_LIST");
		SelectionHint.NativeFieldInfoPtr_CHOOSE_FACTION_ENLIGHTENED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "CHOOSE_FACTION_ENLIGHTENED");
		SelectionHint.NativeFieldInfoPtr_CHOOSE_FACTION_LIFEBOUND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "CHOOSE_FACTION_LIFEBOUND");
		SelectionHint.NativeFieldInfoPtr_CHOOSE_FACTION_MECHANA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "CHOOSE_FACTION_MECHANA");
		SelectionHint.NativeFieldInfoPtr_CHOOSE_FACTION_VOID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "CHOOSE_FACTION_VOID");
		SelectionHint.NativeFieldInfoPtr_PAY_RESOURCE_COST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "PAY_RESOURCE_COST");
		SelectionHint.NativeFieldInfoPtr_PAY_TRANSFORM_COST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "PAY_TRANSFORM_COST");
		SelectionHint.NativeFieldInfoPtr_SELECT_DREAMSCAPE_CARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "SELECT_DREAMSCAPE_CARD");
		SelectionHint.NativeFieldInfoPtr_ADD_CARD_TO_DREAMSCAPE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "ADD_CARD_TO_DREAMSCAPE");
		SelectionHint.NativeFieldInfoPtr_TAKE_PLAYER_INSIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "TAKE_PLAYER_INSIGHT");
		SelectionHint.NativeFieldInfoPtr_AUCTION_INSIGHT_BID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "AUCTION_INSIGHT_BID");
		SelectionHint.NativeFieldInfoPtr_AUCTION_INSIGHT_PASS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "AUCTION_INSIGHT_PASS");
		SelectionHint.NativeFieldInfoPtr_PAY_FOR_DELIRIUM_DIE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "PAY_FOR_DELIRIUM_DIE");
		SelectionHint.NativeFieldInfoPtr_ROLL_DELIRIUM_ROLL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "ROLL_DELIRIUM_ROLL");
		SelectionHint.NativeFieldInfoPtr_TAKE_PLAYER_HONOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "TAKE_PLAYER_HONOR");
		SelectionHint.NativeFieldInfoPtr_NAME_CARD_FROM_DECK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "NAME_CARD_FROM_DECK");
		SelectionHint.NativeFieldInfoPtr_CONVERT_1_RUNE_TO_HONOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "CONVERT_1_RUNE_TO_HONOR");
		SelectionHint.NativeFieldInfoPtr_CONVERT_2_RUNE_TO_HONOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "CONVERT_2_RUNE_TO_HONOR");
		SelectionHint.NativeFieldInfoPtr_CONVERT_3_RUNE_TO_HONOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "CONVERT_3_RUNE_TO_HONOR");
		SelectionHint.NativeFieldInfoPtr_CONVERT_4_RUNE_TO_HONOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "CONVERT_4_RUNE_TO_HONOR");
		SelectionHint.NativeFieldInfoPtr_CONVERT_5_RUNE_TO_HONOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "CONVERT_5_RUNE_TO_HONOR");
		SelectionHint.NativeFieldInfoPtr_YES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "YES");
		SelectionHint.NativeFieldInfoPtr_NO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "NO");
		SelectionHint.NativeFieldInfoPtr_ID_OVERRIDE_FORCE_MAGNIFY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "ID_OVERRIDE_FORCE_MAGNIFY");
		SelectionHint.NativeFieldInfoPtr_ID_OFFSET_PLAYER_OWNED_CARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "ID_OFFSET_PLAYER_OWNED_CARD");
		SelectionHint.NativeFieldInfoPtr_ID_OFFSET_RESOLVE_FATE_CARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "ID_OFFSET_RESOLVE_FATE_CARD");
		SelectionHint.NativeFieldInfoPtr_ID_OFFSET_PLAYED_CARD_COPY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "ID_OFFSET_PLAYED_CARD_COPY");
		SelectionHint.NativeFieldInfoPtr_ID_OFFSET_FILTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, "ID_OFFSET_FILTER");
		SelectionHint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr, 100664235);
	}

	// Token: 0x06000CF7 RID: 3319 RVA: 0x000411FC File Offset: 0x0003F3FC
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SelectionHint()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionHint>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionHint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CF8 RID: 3320 RVA: 0x00009B86 File Offset: 0x00007D86
	public SelectionHint(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000455 RID: 1109
	// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x00041238 File Offset: 0x0003F438
	// (set) Token: 0x06000CFA RID: 3322 RVA: 0x00009B8F File Offset: 0x00007D8F
	public unsafe static ushort NONE
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_NONE, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_NONE, (void*)(&value));
		}
	}

	// Token: 0x17000456 RID: 1110
	// (get) Token: 0x06000CFB RID: 3323 RVA: 0x00041254 File Offset: 0x0003F454
	// (set) Token: 0x06000CFC RID: 3324 RVA: 0x00009B9D File Offset: 0x00007D9D
	public unsafe static ushort END_TURN
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_END_TURN, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_END_TURN, (void*)(&value));
		}
	}

	// Token: 0x17000457 RID: 1111
	// (get) Token: 0x06000CFD RID: 3325 RVA: 0x00041270 File Offset: 0x0003F470
	// (set) Token: 0x06000CFE RID: 3326 RVA: 0x00009BAB File Offset: 0x00007DAB
	public unsafe static ushort CANCEL
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_CANCEL, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_CANCEL, (void*)(&value));
		}
	}

	// Token: 0x17000458 RID: 1112
	// (get) Token: 0x06000CFF RID: 3327 RVA: 0x0004128C File Offset: 0x0003F48C
	// (set) Token: 0x06000D00 RID: 3328 RVA: 0x00009BB9 File Offset: 0x00007DB9
	public unsafe static ushort PLAY_CARD
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_PLAY_CARD, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_PLAY_CARD, (void*)(&value));
		}
	}

	// Token: 0x17000459 RID: 1113
	// (get) Token: 0x06000D01 RID: 3329 RVA: 0x000412A8 File Offset: 0x0003F4A8
	// (set) Token: 0x06000D02 RID: 3330 RVA: 0x00009BC7 File Offset: 0x00007DC7
	public unsafe static ushort PLAY_CONSTRUCT
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_PLAY_CONSTRUCT, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_PLAY_CONSTRUCT, (void*)(&value));
		}
	}

	// Token: 0x1700045A RID: 1114
	// (get) Token: 0x06000D03 RID: 3331 RVA: 0x000412C4 File Offset: 0x0003F4C4
	// (set) Token: 0x06000D04 RID: 3332 RVA: 0x00009BD5 File Offset: 0x00007DD5
	public unsafe static ushort PLAY_ENTIRE_HAND
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_PLAY_ENTIRE_HAND, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_PLAY_ENTIRE_HAND, (void*)(&value));
		}
	}

	// Token: 0x1700045B RID: 1115
	// (get) Token: 0x06000D05 RID: 3333 RVA: 0x000412E0 File Offset: 0x0003F4E0
	// (set) Token: 0x06000D06 RID: 3334 RVA: 0x00009BE3 File Offset: 0x00007DE3
	public unsafe static ushort ACQUIRE_CARD
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD, (void*)(&value));
		}
	}

	// Token: 0x1700045C RID: 1116
	// (get) Token: 0x06000D07 RID: 3335 RVA: 0x000412FC File Offset: 0x0003F4FC
	// (set) Token: 0x06000D08 RID: 3336 RVA: 0x00009BF1 File Offset: 0x00007DF1
	public unsafe static ushort ACQUIRE_CARD_TO_DISCARD
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD_TO_DISCARD, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD_TO_DISCARD, (void*)(&value));
		}
	}

	// Token: 0x1700045D RID: 1117
	// (get) Token: 0x06000D09 RID: 3337 RVA: 0x00041318 File Offset: 0x0003F518
	// (set) Token: 0x06000D0A RID: 3338 RVA: 0x00009BFF File Offset: 0x00007DFF
	public unsafe static ushort ACQUIRE_CARD_TO_DECK
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD_TO_DECK, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD_TO_DECK, (void*)(&value));
		}
	}

	// Token: 0x1700045E RID: 1118
	// (get) Token: 0x06000D0B RID: 3339 RVA: 0x00041334 File Offset: 0x0003F534
	// (set) Token: 0x06000D0C RID: 3340 RVA: 0x00009C0D File Offset: 0x00007E0D
	public unsafe static ushort ACQUIRE_CARD_INTO_PLAY
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD_INTO_PLAY, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD_INTO_PLAY, (void*)(&value));
		}
	}

	// Token: 0x1700045F RID: 1119
	// (get) Token: 0x06000D0D RID: 3341 RVA: 0x00041350 File Offset: 0x0003F550
	// (set) Token: 0x06000D0E RID: 3342 RVA: 0x00009C1B File Offset: 0x00007E1B
	public unsafe static ushort ACQUIRE_CARD_TO_HAND
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD_TO_HAND, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD_TO_HAND, (void*)(&value));
		}
	}

	// Token: 0x17000460 RID: 1120
	// (get) Token: 0x06000D0F RID: 3343 RVA: 0x0004136C File Offset: 0x0003F56C
	// (set) Token: 0x06000D10 RID: 3344 RVA: 0x00009C29 File Offset: 0x00007E29
	public unsafe static ushort ACQUIRE_CARD_FROM_VOID
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD_FROM_VOID, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD_FROM_VOID, (void*)(&value));
		}
	}

	// Token: 0x17000461 RID: 1121
	// (get) Token: 0x06000D11 RID: 3345 RVA: 0x00041388 File Offset: 0x0003F588
	// (set) Token: 0x06000D12 RID: 3346 RVA: 0x00009C37 File Offset: 0x00007E37
	public unsafe static ushort ACQUIRE_CARD_FROM_VOID_TO_DECK
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD_FROM_VOID_TO_DECK, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD_FROM_VOID_TO_DECK, (void*)(&value));
		}
	}

	// Token: 0x17000462 RID: 1122
	// (get) Token: 0x06000D13 RID: 3347 RVA: 0x000413A4 File Offset: 0x0003F5A4
	// (set) Token: 0x06000D14 RID: 3348 RVA: 0x00009C45 File Offset: 0x00007E45
	public unsafe static ushort ACQUIRE_CARD_FROM_VOID_INTO_PLAY
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD_FROM_VOID_INTO_PLAY, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD_FROM_VOID_INTO_PLAY, (void*)(&value));
		}
	}

	// Token: 0x17000463 RID: 1123
	// (get) Token: 0x06000D15 RID: 3349 RVA: 0x000413C0 File Offset: 0x0003F5C0
	// (set) Token: 0x06000D16 RID: 3350 RVA: 0x00009C53 File Offset: 0x00007E53
	public unsafe static ushort ACQUIRE_CARD_FROM_VOID_TO_HAND
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD_FROM_VOID_TO_HAND, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_CARD_FROM_VOID_TO_HAND, (void*)(&value));
		}
	}

	// Token: 0x17000464 RID: 1124
	// (get) Token: 0x06000D17 RID: 3351 RVA: 0x000413DC File Offset: 0x0003F5DC
	// (set) Token: 0x06000D18 RID: 3352 RVA: 0x00009C61 File Offset: 0x00007E61
	public unsafe static ushort ACQUIRE_TEMPLE
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_TEMPLE, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_TEMPLE, (void*)(&value));
		}
	}

	// Token: 0x17000465 RID: 1125
	// (get) Token: 0x06000D19 RID: 3353 RVA: 0x000413F8 File Offset: 0x0003F5F8
	// (set) Token: 0x06000D1A RID: 3354 RVA: 0x00009C6F File Offset: 0x00007E6F
	public unsafe static ushort MOVE_TREASURE_FROM_CENTER_ROW
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_MOVE_TREASURE_FROM_CENTER_ROW, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_MOVE_TREASURE_FROM_CENTER_ROW, (void*)(&value));
		}
	}

	// Token: 0x17000466 RID: 1126
	// (get) Token: 0x06000D1B RID: 3355 RVA: 0x00041414 File Offset: 0x0003F614
	// (set) Token: 0x06000D1C RID: 3356 RVA: 0x00009C7D File Offset: 0x00007E7D
	public unsafe static ushort MOVE_TREASURE_TO_CENTER_ROW
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_MOVE_TREASURE_TO_CENTER_ROW, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_MOVE_TREASURE_TO_CENTER_ROW, (void*)(&value));
		}
	}

	// Token: 0x17000467 RID: 1127
	// (get) Token: 0x06000D1D RID: 3357 RVA: 0x00041430 File Offset: 0x0003F630
	// (set) Token: 0x06000D1E RID: 3358 RVA: 0x00009C8B File Offset: 0x00007E8B
	public unsafe static ushort ACQUIRE_PORTAL
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_PORTAL, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_PORTAL, (void*)(&value));
		}
	}

	// Token: 0x17000468 RID: 1128
	// (get) Token: 0x06000D1F RID: 3359 RVA: 0x0004144C File Offset: 0x0003F64C
	// (set) Token: 0x06000D20 RID: 3360 RVA: 0x00009C99 File Offset: 0x00007E99
	public unsafe static ushort ACQUIRE_VISION
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_VISION, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_VISION, (void*)(&value));
		}
	}

	// Token: 0x17000469 RID: 1129
	// (get) Token: 0x06000D21 RID: 3361 RVA: 0x00041468 File Offset: 0x0003F668
	// (set) Token: 0x06000D22 RID: 3362 RVA: 0x00009CA7 File Offset: 0x00007EA7
	public unsafe static ushort ACQUIRE_VISION_ONGOING
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_VISION_ONGOING, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_VISION_ONGOING, (void*)(&value));
		}
	}

	// Token: 0x1700046A RID: 1130
	// (get) Token: 0x06000D23 RID: 3363 RVA: 0x00041484 File Offset: 0x0003F684
	// (set) Token: 0x06000D24 RID: 3364 RVA: 0x00009CB5 File Offset: 0x00007EB5
	public unsafe static ushort PUT_DISCARD_IN_HAND
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_PUT_DISCARD_IN_HAND, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_PUT_DISCARD_IN_HAND, (void*)(&value));
		}
	}

	// Token: 0x1700046B RID: 1131
	// (get) Token: 0x06000D25 RID: 3365 RVA: 0x000414A0 File Offset: 0x0003F6A0
	// (set) Token: 0x06000D26 RID: 3366 RVA: 0x00009CC3 File Offset: 0x00007EC3
	public unsafe static ushort PUT_DISCARD_ON_DECK
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_PUT_DISCARD_ON_DECK, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_PUT_DISCARD_ON_DECK, (void*)(&value));
		}
	}

	// Token: 0x1700046C RID: 1132
	// (get) Token: 0x06000D27 RID: 3367 RVA: 0x000414BC File Offset: 0x0003F6BC
	// (set) Token: 0x06000D28 RID: 3368 RVA: 0x00009CD1 File Offset: 0x00007ED1
	public unsafe static ushort PUT_REVEALED_CARD_ON_DECK
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_PUT_REVEALED_CARD_ON_DECK, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_PUT_REVEALED_CARD_ON_DECK, (void*)(&value));
		}
	}

	// Token: 0x1700046D RID: 1133
	// (get) Token: 0x06000D29 RID: 3369 RVA: 0x000414D8 File Offset: 0x0003F6D8
	// (set) Token: 0x06000D2A RID: 3370 RVA: 0x00009CDF File Offset: 0x00007EDF
	public unsafe static ushort PUT_REVEALED_CARD_IN_DISCARD
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_PUT_REVEALED_CARD_IN_DISCARD, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_PUT_REVEALED_CARD_IN_DISCARD, (void*)(&value));
		}
	}

	// Token: 0x1700046E RID: 1134
	// (get) Token: 0x06000D2B RID: 3371 RVA: 0x000414F4 File Offset: 0x0003F6F4
	// (set) Token: 0x06000D2C RID: 3372 RVA: 0x00009CED File Offset: 0x00007EED
	public unsafe static ushort PUT_CARD_UNDER_CONSTRUCT
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_PUT_CARD_UNDER_CONSTRUCT, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_PUT_CARD_UNDER_CONSTRUCT, (void*)(&value));
		}
	}

	// Token: 0x1700046F RID: 1135
	// (get) Token: 0x06000D2D RID: 3373 RVA: 0x00041510 File Offset: 0x0003F710
	// (set) Token: 0x06000D2E RID: 3374 RVA: 0x00009CFB File Offset: 0x00007EFB
	public unsafe static ushort DRAW_CARD
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_DRAW_CARD, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_DRAW_CARD, (void*)(&value));
		}
	}

	// Token: 0x17000470 RID: 1136
	// (get) Token: 0x06000D2F RID: 3375 RVA: 0x0004152C File Offset: 0x0003F72C
	// (set) Token: 0x06000D30 RID: 3376 RVA: 0x00009D09 File Offset: 0x00007F09
	public unsafe static ushort PUT_CARD_ON_PORTAL_DECK
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_PUT_CARD_ON_PORTAL_DECK, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_PUT_CARD_ON_PORTAL_DECK, (void*)(&value));
		}
	}

	// Token: 0x17000471 RID: 1137
	// (get) Token: 0x06000D31 RID: 3377 RVA: 0x00041548 File Offset: 0x0003F748
	// (set) Token: 0x06000D32 RID: 3378 RVA: 0x00009D17 File Offset: 0x00007F17
	public unsafe static ushort TAKE_DISCARD_FROM_OPPONENT
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_TAKE_DISCARD_FROM_OPPONENT, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_TAKE_DISCARD_FROM_OPPONENT, (void*)(&value));
		}
	}

	// Token: 0x17000472 RID: 1138
	// (get) Token: 0x06000D33 RID: 3379 RVA: 0x00041564 File Offset: 0x0003F764
	// (set) Token: 0x06000D34 RID: 3380 RVA: 0x00009D25 File Offset: 0x00007F25
	public unsafe static ushort PUT_VOID_CARD_ON_PORTAL_DECK
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_PUT_VOID_CARD_ON_PORTAL_DECK, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_PUT_VOID_CARD_ON_PORTAL_DECK, (void*)(&value));
		}
	}

	// Token: 0x17000473 RID: 1139
	// (get) Token: 0x06000D35 RID: 3381 RVA: 0x00041580 File Offset: 0x0003F780
	// (set) Token: 0x06000D36 RID: 3382 RVA: 0x00009D33 File Offset: 0x00007F33
	public unsafe static ushort DEFEAT_MONSTER
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_DEFEAT_MONSTER, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_DEFEAT_MONSTER, (void*)(&value));
		}
	}

	// Token: 0x17000474 RID: 1140
	// (get) Token: 0x06000D37 RID: 3383 RVA: 0x0004159C File Offset: 0x0003F79C
	// (set) Token: 0x06000D38 RID: 3384 RVA: 0x00009D41 File Offset: 0x00007F41
	public unsafe static ushort DEFEAT_CULTIST
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_DEFEAT_CULTIST, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_DEFEAT_CULTIST, (void*)(&value));
		}
	}

	// Token: 0x17000475 RID: 1141
	// (get) Token: 0x06000D39 RID: 3385 RVA: 0x000415B8 File Offset: 0x0003F7B8
	// (set) Token: 0x06000D3A RID: 3386 RVA: 0x00009D4F File Offset: 0x00007F4F
	public unsafe static ushort DEFEAT_MONSTER_IN_VOID
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_DEFEAT_MONSTER_IN_VOID, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_DEFEAT_MONSTER_IN_VOID, (void*)(&value));
		}
	}

	// Token: 0x17000476 RID: 1142
	// (get) Token: 0x06000D3B RID: 3387 RVA: 0x000415D4 File Offset: 0x0003F7D4
	// (set) Token: 0x06000D3C RID: 3388 RVA: 0x00009D5D File Offset: 0x00007F5D
	public unsafe static ushort DEFEAT_MONSTER_TO_DISCARD
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_DEFEAT_MONSTER_TO_DISCARD, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_DEFEAT_MONSTER_TO_DISCARD, (void*)(&value));
		}
	}

	// Token: 0x17000477 RID: 1143
	// (get) Token: 0x06000D3D RID: 3389 RVA: 0x000415F0 File Offset: 0x0003F7F0
	// (set) Token: 0x06000D3E RID: 3390 RVA: 0x00009D6B File Offset: 0x00007F6B
	public unsafe static ushort DEFEAT_MONSTER_IN_VOID_TO_DISCARD
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_DEFEAT_MONSTER_IN_VOID_TO_DISCARD, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_DEFEAT_MONSTER_IN_VOID_TO_DISCARD, (void*)(&value));
		}
	}

	// Token: 0x17000478 RID: 1144
	// (get) Token: 0x06000D3F RID: 3391 RVA: 0x0004160C File Offset: 0x0003F80C
	// (set) Token: 0x06000D40 RID: 3392 RVA: 0x00009D79 File Offset: 0x00007F79
	public unsafe static ushort DEFEAT_TROPHY_MONSTER
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_DEFEAT_TROPHY_MONSTER, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_DEFEAT_TROPHY_MONSTER, (void*)(&value));
		}
	}

	// Token: 0x17000479 RID: 1145
	// (get) Token: 0x06000D41 RID: 3393 RVA: 0x00041628 File Offset: 0x0003F828
	// (set) Token: 0x06000D42 RID: 3394 RVA: 0x00009D87 File Offset: 0x00007F87
	public unsafe static ushort DEFEAT_HERO_WITH_POWER
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_DEFEAT_HERO_WITH_POWER, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_DEFEAT_HERO_WITH_POWER, (void*)(&value));
		}
	}

	// Token: 0x1700047A RID: 1146
	// (get) Token: 0x06000D43 RID: 3395 RVA: 0x00041644 File Offset: 0x0003F844
	// (set) Token: 0x06000D44 RID: 3396 RVA: 0x00009D95 File Offset: 0x00007F95
	public unsafe static ushort DEFEAT_MONSTER_INTO_PLAY
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_DEFEAT_MONSTER_INTO_PLAY, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_DEFEAT_MONSTER_INTO_PLAY, (void*)(&value));
		}
	}

	// Token: 0x1700047B RID: 1147
	// (get) Token: 0x06000D45 RID: 3397 RVA: 0x00041660 File Offset: 0x0003F860
	// (set) Token: 0x06000D46 RID: 3398 RVA: 0x00009DA3 File Offset: 0x00007FA3
	public unsafe static ushort DEFEAT_MONSTER_IN_VOID_INTO_PLAY
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_DEFEAT_MONSTER_IN_VOID_INTO_PLAY, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_DEFEAT_MONSTER_IN_VOID_INTO_PLAY, (void*)(&value));
		}
	}

	// Token: 0x1700047C RID: 1148
	// (get) Token: 0x06000D47 RID: 3399 RVA: 0x0004167C File Offset: 0x0003F87C
	// (set) Token: 0x06000D48 RID: 3400 RVA: 0x00009DB1 File Offset: 0x00007FB1
	public unsafe static ushort DEFEAT_MONSTER_TO_PORTAL_DECK
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_DEFEAT_MONSTER_TO_PORTAL_DECK, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_DEFEAT_MONSTER_TO_PORTAL_DECK, (void*)(&value));
		}
	}

	// Token: 0x1700047D RID: 1149
	// (get) Token: 0x06000D49 RID: 3401 RVA: 0x00041698 File Offset: 0x0003F898
	// (set) Token: 0x06000D4A RID: 3402 RVA: 0x00009DBF File Offset: 0x00007FBF
	public unsafe static ushort DISCARD_CARD_FROM_HAND
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_DISCARD_CARD_FROM_HAND, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_DISCARD_CARD_FROM_HAND, (void*)(&value));
		}
	}

	// Token: 0x1700047E RID: 1150
	// (get) Token: 0x06000D4B RID: 3403 RVA: 0x000416B4 File Offset: 0x0003F8B4
	// (set) Token: 0x06000D4C RID: 3404 RVA: 0x00009DCD File Offset: 0x00007FCD
	public unsafe static ushort DISCARD_CONSTRUCT_FROM_PLAY
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_DISCARD_CONSTRUCT_FROM_PLAY, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_DISCARD_CONSTRUCT_FROM_PLAY, (void*)(&value));
		}
	}

	// Token: 0x1700047F RID: 1151
	// (get) Token: 0x06000D4D RID: 3405 RVA: 0x000416D0 File Offset: 0x0003F8D0
	// (set) Token: 0x06000D4E RID: 3406 RVA: 0x00009DDB File Offset: 0x00007FDB
	public unsafe static ushort DISCARD_ALL_OTHER_CONSTRUCT
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_DISCARD_ALL_OTHER_CONSTRUCT, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_DISCARD_ALL_OTHER_CONSTRUCT, (void*)(&value));
		}
	}

	// Token: 0x17000480 RID: 1152
	// (get) Token: 0x06000D4F RID: 3407 RVA: 0x000416EC File Offset: 0x0003F8EC
	// (set) Token: 0x06000D50 RID: 3408 RVA: 0x00009DE9 File Offset: 0x00007FE9
	public unsafe static ushort DISCARD_ALL_CONSTRUCTS
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_DISCARD_ALL_CONSTRUCTS, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_DISCARD_ALL_CONSTRUCTS, (void*)(&value));
		}
	}

	// Token: 0x17000481 RID: 1153
	// (get) Token: 0x06000D51 RID: 3409 RVA: 0x00041708 File Offset: 0x0003F908
	// (set) Token: 0x06000D52 RID: 3410 RVA: 0x00009DF7 File Offset: 0x00007FF7
	public unsafe static ushort RETURN_CONSTRUCT_TO_HAND
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_RETURN_CONSTRUCT_TO_HAND, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_RETURN_CONSTRUCT_TO_HAND, (void*)(&value));
		}
	}

	// Token: 0x17000482 RID: 1154
	// (get) Token: 0x06000D53 RID: 3411 RVA: 0x00041724 File Offset: 0x0003F924
	// (set) Token: 0x06000D54 RID: 3412 RVA: 0x00009E05 File Offset: 0x00008005
	public unsafe static ushort PREVENT_DESTROY_CONSTRUCT
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_PREVENT_DESTROY_CONSTRUCT, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_PREVENT_DESTROY_CONSTRUCT, (void*)(&value));
		}
	}

	// Token: 0x17000483 RID: 1155
	// (get) Token: 0x06000D55 RID: 3413 RVA: 0x00041740 File Offset: 0x0003F940
	// (set) Token: 0x06000D56 RID: 3414 RVA: 0x00009E13 File Offset: 0x00008013
	public unsafe static ushort DISCARD_CONSTRUCT_FROM_OPP
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_DISCARD_CONSTRUCT_FROM_OPP, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_DISCARD_CONSTRUCT_FROM_OPP, (void*)(&value));
		}
	}

	// Token: 0x17000484 RID: 1156
	// (get) Token: 0x06000D57 RID: 3415 RVA: 0x0004175C File Offset: 0x0003F95C
	// (set) Token: 0x06000D58 RID: 3416 RVA: 0x00009E21 File Offset: 0x00008021
	public unsafe static ushort ACQUIRE_CONSTRUCT_FROM_OPP
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_CONSTRUCT_FROM_OPP, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_ACQUIRE_CONSTRUCT_FROM_OPP, (void*)(&value));
		}
	}

	// Token: 0x17000485 RID: 1157
	// (get) Token: 0x06000D59 RID: 3417 RVA: 0x00041778 File Offset: 0x0003F978
	// (set) Token: 0x06000D5A RID: 3418 RVA: 0x00009E2F File Offset: 0x0000802F
	public unsafe static ushort DISCARD_CARD_TO_PLAYER
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_DISCARD_CARD_TO_PLAYER, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_DISCARD_CARD_TO_PLAYER, (void*)(&value));
		}
	}

	// Token: 0x17000486 RID: 1158
	// (get) Token: 0x06000D5B RID: 3419 RVA: 0x00041794 File Offset: 0x0003F994
	// (set) Token: 0x06000D5C RID: 3420 RVA: 0x00009E3D File Offset: 0x0000803D
	public unsafe static ushort DISCARD_MONSTER
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_DISCARD_MONSTER, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_DISCARD_MONSTER, (void*)(&value));
		}
	}

	// Token: 0x17000487 RID: 1159
	// (get) Token: 0x06000D5D RID: 3421 RVA: 0x000417B0 File Offset: 0x0003F9B0
	// (set) Token: 0x06000D5E RID: 3422 RVA: 0x00009E4B File Offset: 0x0000804B
	public unsafe static ushort DISCARD_MONSTER_IN_VOID
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_DISCARD_MONSTER_IN_VOID, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_DISCARD_MONSTER_IN_VOID, (void*)(&value));
		}
	}

	// Token: 0x17000488 RID: 1160
	// (get) Token: 0x06000D5F RID: 3423 RVA: 0x000417CC File Offset: 0x0003F9CC
	// (set) Token: 0x06000D60 RID: 3424 RVA: 0x00009E59 File Offset: 0x00008059
	public unsafe static ushort DISCARD_CARD_ONTO_DECK
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_DISCARD_CARD_ONTO_DECK, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_DISCARD_CARD_ONTO_DECK, (void*)(&value));
		}
	}

	// Token: 0x17000489 RID: 1161
	// (get) Token: 0x06000D61 RID: 3425 RVA: 0x000417E8 File Offset: 0x0003F9E8
	// (set) Token: 0x06000D62 RID: 3426 RVA: 0x00009E67 File Offset: 0x00008067
	public unsafe static ushort BANISH_CARD
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_BANISH_CARD, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_BANISH_CARD, (void*)(&value));
		}
	}

	// Token: 0x1700048A RID: 1162
	// (get) Token: 0x06000D63 RID: 3427 RVA: 0x00041804 File Offset: 0x0003FA04
	// (set) Token: 0x06000D64 RID: 3428 RVA: 0x00009E75 File Offset: 0x00008075
	public unsafe static ushort BANISH_CARD_MASK
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_BANISH_CARD_MASK, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_BANISH_CARD_MASK, (void*)(&value));
		}
	}

	// Token: 0x1700048B RID: 1163
	// (get) Token: 0x06000D65 RID: 3429 RVA: 0x00041820 File Offset: 0x0003FA20
	// (set) Token: 0x06000D66 RID: 3430 RVA: 0x00009E83 File Offset: 0x00008083
	public unsafe static ushort BANISH_CARD_FROM_HAND
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_BANISH_CARD_FROM_HAND, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_BANISH_CARD_FROM_HAND, (void*)(&value));
		}
	}

	// Token: 0x1700048C RID: 1164
	// (get) Token: 0x06000D67 RID: 3431 RVA: 0x0004183C File Offset: 0x0003FA3C
	// (set) Token: 0x06000D68 RID: 3432 RVA: 0x00009E91 File Offset: 0x00008091
	public unsafe static ushort BANISH_CARD_FROM_DISCARD
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_BANISH_CARD_FROM_DISCARD, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_BANISH_CARD_FROM_DISCARD, (void*)(&value));
		}
	}

	// Token: 0x1700048D RID: 1165
	// (get) Token: 0x06000D69 RID: 3433 RVA: 0x00041858 File Offset: 0x0003FA58
	// (set) Token: 0x06000D6A RID: 3434 RVA: 0x00009E9F File Offset: 0x0000809F
	public unsafe static ushort BANISH_CARD_FROM_CENTER
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_BANISH_CARD_FROM_CENTER, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_BANISH_CARD_FROM_CENTER, (void*)(&value));
		}
	}

	// Token: 0x1700048E RID: 1166
	// (get) Token: 0x06000D6B RID: 3435 RVA: 0x00041874 File Offset: 0x0003FA74
	// (set) Token: 0x06000D6C RID: 3436 RVA: 0x00009EAD File Offset: 0x000080AD
	public unsafe static ushort BANISH_CARD_FROM_DECK
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_BANISH_CARD_FROM_DECK, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_BANISH_CARD_FROM_DECK, (void*)(&value));
		}
	}

	// Token: 0x1700048F RID: 1167
	// (get) Token: 0x06000D6D RID: 3437 RVA: 0x00041890 File Offset: 0x0003FA90
	// (set) Token: 0x06000D6E RID: 3438 RVA: 0x00009EBB File Offset: 0x000080BB
	public unsafe static ushort BANISH_PHANTASM_FROM_CENTER
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_BANISH_PHANTASM_FROM_CENTER, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_BANISH_PHANTASM_FROM_CENTER, (void*)(&value));
		}
	}

	// Token: 0x17000490 RID: 1168
	// (get) Token: 0x06000D6F RID: 3439 RVA: 0x000418AC File Offset: 0x0003FAAC
	// (set) Token: 0x06000D70 RID: 3440 RVA: 0x00009EC9 File Offset: 0x000080C9
	public unsafe static ushort USE_CONSTRUCT
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_USE_CONSTRUCT, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_USE_CONSTRUCT, (void*)(&value));
		}
	}

	// Token: 0x17000491 RID: 1169
	// (get) Token: 0x06000D71 RID: 3441 RVA: 0x000418C8 File Offset: 0x0003FAC8
	// (set) Token: 0x06000D72 RID: 3442 RVA: 0x00009ED7 File Offset: 0x000080D7
	public unsafe static ushort USE_TROPHY
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_USE_TROPHY, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_USE_TROPHY, (void*)(&value));
		}
	}

	// Token: 0x17000492 RID: 1170
	// (get) Token: 0x06000D73 RID: 3443 RVA: 0x000418E4 File Offset: 0x0003FAE4
	// (set) Token: 0x06000D74 RID: 3444 RVA: 0x00009EE5 File Offset: 0x000080E5
	public unsafe static ushort USE_CONSTRUCT_TRANSFORM
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_USE_CONSTRUCT_TRANSFORM, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_USE_CONSTRUCT_TRANSFORM, (void*)(&value));
		}
	}

	// Token: 0x17000493 RID: 1171
	// (get) Token: 0x06000D75 RID: 3445 RVA: 0x00041900 File Offset: 0x0003FB00
	// (set) Token: 0x06000D76 RID: 3446 RVA: 0x00009EF3 File Offset: 0x000080F3
	public unsafe static ushort CHOOSE_EFFECT
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_CHOOSE_EFFECT, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_CHOOSE_EFFECT, (void*)(&value));
		}
	}

	// Token: 0x17000494 RID: 1172
	// (get) Token: 0x06000D77 RID: 3447 RVA: 0x0004191C File Offset: 0x0003FB1C
	// (set) Token: 0x06000D78 RID: 3448 RVA: 0x00009F01 File Offset: 0x00008101
	public unsafe static ushort COPY_EFFECT
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_COPY_EFFECT, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_COPY_EFFECT, (void*)(&value));
		}
	}

	// Token: 0x17000495 RID: 1173
	// (get) Token: 0x06000D79 RID: 3449 RVA: 0x00041938 File Offset: 0x0003FB38
	// (set) Token: 0x06000D7A RID: 3450 RVA: 0x00009F0F File Offset: 0x0000810F
	public unsafe static ushort COPY_LIFEBOUND_FROM_LIST
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_COPY_LIFEBOUND_FROM_LIST, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_COPY_LIFEBOUND_FROM_LIST, (void*)(&value));
		}
	}

	// Token: 0x17000496 RID: 1174
	// (get) Token: 0x06000D7B RID: 3451 RVA: 0x00041954 File Offset: 0x0003FB54
	// (set) Token: 0x06000D7C RID: 3452 RVA: 0x00009F1D File Offset: 0x0000811D
	public unsafe static ushort COPY_DEFEATED_MONSTER_FROM_LIST
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_COPY_DEFEATED_MONSTER_FROM_LIST, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_COPY_DEFEATED_MONSTER_FROM_LIST, (void*)(&value));
		}
	}

	// Token: 0x17000497 RID: 1175
	// (get) Token: 0x06000D7D RID: 3453 RVA: 0x00041970 File Offset: 0x0003FB70
	// (set) Token: 0x06000D7E RID: 3454 RVA: 0x00009F2B File Offset: 0x0000812B
	public unsafe static ushort CHOOSE_FACTION_ENLIGHTENED
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_CHOOSE_FACTION_ENLIGHTENED, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_CHOOSE_FACTION_ENLIGHTENED, (void*)(&value));
		}
	}

	// Token: 0x17000498 RID: 1176
	// (get) Token: 0x06000D7F RID: 3455 RVA: 0x0004198C File Offset: 0x0003FB8C
	// (set) Token: 0x06000D80 RID: 3456 RVA: 0x00009F39 File Offset: 0x00008139
	public unsafe static ushort CHOOSE_FACTION_LIFEBOUND
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_CHOOSE_FACTION_LIFEBOUND, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_CHOOSE_FACTION_LIFEBOUND, (void*)(&value));
		}
	}

	// Token: 0x17000499 RID: 1177
	// (get) Token: 0x06000D81 RID: 3457 RVA: 0x000419A8 File Offset: 0x0003FBA8
	// (set) Token: 0x06000D82 RID: 3458 RVA: 0x00009F47 File Offset: 0x00008147
	public unsafe static ushort CHOOSE_FACTION_MECHANA
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_CHOOSE_FACTION_MECHANA, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_CHOOSE_FACTION_MECHANA, (void*)(&value));
		}
	}

	// Token: 0x1700049A RID: 1178
	// (get) Token: 0x06000D83 RID: 3459 RVA: 0x000419C4 File Offset: 0x0003FBC4
	// (set) Token: 0x06000D84 RID: 3460 RVA: 0x00009F55 File Offset: 0x00008155
	public unsafe static ushort CHOOSE_FACTION_VOID
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_CHOOSE_FACTION_VOID, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_CHOOSE_FACTION_VOID, (void*)(&value));
		}
	}

	// Token: 0x1700049B RID: 1179
	// (get) Token: 0x06000D85 RID: 3461 RVA: 0x000419E0 File Offset: 0x0003FBE0
	// (set) Token: 0x06000D86 RID: 3462 RVA: 0x00009F63 File Offset: 0x00008163
	public unsafe static ushort PAY_RESOURCE_COST
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_PAY_RESOURCE_COST, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_PAY_RESOURCE_COST, (void*)(&value));
		}
	}

	// Token: 0x1700049C RID: 1180
	// (get) Token: 0x06000D87 RID: 3463 RVA: 0x000419FC File Offset: 0x0003FBFC
	// (set) Token: 0x06000D88 RID: 3464 RVA: 0x00009F71 File Offset: 0x00008171
	public unsafe static ushort PAY_TRANSFORM_COST
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_PAY_TRANSFORM_COST, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_PAY_TRANSFORM_COST, (void*)(&value));
		}
	}

	// Token: 0x1700049D RID: 1181
	// (get) Token: 0x06000D89 RID: 3465 RVA: 0x00041A18 File Offset: 0x0003FC18
	// (set) Token: 0x06000D8A RID: 3466 RVA: 0x00009F7F File Offset: 0x0000817F
	public unsafe static ushort SELECT_DREAMSCAPE_CARD
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_SELECT_DREAMSCAPE_CARD, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_SELECT_DREAMSCAPE_CARD, (void*)(&value));
		}
	}

	// Token: 0x1700049E RID: 1182
	// (get) Token: 0x06000D8B RID: 3467 RVA: 0x00041A34 File Offset: 0x0003FC34
	// (set) Token: 0x06000D8C RID: 3468 RVA: 0x00009F8D File Offset: 0x0000818D
	public unsafe static ushort ADD_CARD_TO_DREAMSCAPE
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_ADD_CARD_TO_DREAMSCAPE, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_ADD_CARD_TO_DREAMSCAPE, (void*)(&value));
		}
	}

	// Token: 0x1700049F RID: 1183
	// (get) Token: 0x06000D8D RID: 3469 RVA: 0x00041A50 File Offset: 0x0003FC50
	// (set) Token: 0x06000D8E RID: 3470 RVA: 0x00009F9B File Offset: 0x0000819B
	public unsafe static ushort TAKE_PLAYER_INSIGHT
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_TAKE_PLAYER_INSIGHT, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_TAKE_PLAYER_INSIGHT, (void*)(&value));
		}
	}

	// Token: 0x170004A0 RID: 1184
	// (get) Token: 0x06000D8F RID: 3471 RVA: 0x00041A6C File Offset: 0x0003FC6C
	// (set) Token: 0x06000D90 RID: 3472 RVA: 0x00009FA9 File Offset: 0x000081A9
	public unsafe static ushort AUCTION_INSIGHT_BID
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_AUCTION_INSIGHT_BID, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_AUCTION_INSIGHT_BID, (void*)(&value));
		}
	}

	// Token: 0x170004A1 RID: 1185
	// (get) Token: 0x06000D91 RID: 3473 RVA: 0x00041A88 File Offset: 0x0003FC88
	// (set) Token: 0x06000D92 RID: 3474 RVA: 0x00009FB7 File Offset: 0x000081B7
	public unsafe static ushort AUCTION_INSIGHT_PASS
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_AUCTION_INSIGHT_PASS, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_AUCTION_INSIGHT_PASS, (void*)(&value));
		}
	}

	// Token: 0x170004A2 RID: 1186
	// (get) Token: 0x06000D93 RID: 3475 RVA: 0x00041AA4 File Offset: 0x0003FCA4
	// (set) Token: 0x06000D94 RID: 3476 RVA: 0x00009FC5 File Offset: 0x000081C5
	public unsafe static ushort PAY_FOR_DELIRIUM_DIE
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_PAY_FOR_DELIRIUM_DIE, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_PAY_FOR_DELIRIUM_DIE, (void*)(&value));
		}
	}

	// Token: 0x170004A3 RID: 1187
	// (get) Token: 0x06000D95 RID: 3477 RVA: 0x00041AC0 File Offset: 0x0003FCC0
	// (set) Token: 0x06000D96 RID: 3478 RVA: 0x00009FD3 File Offset: 0x000081D3
	public unsafe static ushort ROLL_DELIRIUM_ROLL
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_ROLL_DELIRIUM_ROLL, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_ROLL_DELIRIUM_ROLL, (void*)(&value));
		}
	}

	// Token: 0x170004A4 RID: 1188
	// (get) Token: 0x06000D97 RID: 3479 RVA: 0x00041ADC File Offset: 0x0003FCDC
	// (set) Token: 0x06000D98 RID: 3480 RVA: 0x00009FE1 File Offset: 0x000081E1
	public unsafe static ushort TAKE_PLAYER_HONOR
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_TAKE_PLAYER_HONOR, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_TAKE_PLAYER_HONOR, (void*)(&value));
		}
	}

	// Token: 0x170004A5 RID: 1189
	// (get) Token: 0x06000D99 RID: 3481 RVA: 0x00041AF8 File Offset: 0x0003FCF8
	// (set) Token: 0x06000D9A RID: 3482 RVA: 0x00009FEF File Offset: 0x000081EF
	public unsafe static ushort NAME_CARD_FROM_DECK
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_NAME_CARD_FROM_DECK, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_NAME_CARD_FROM_DECK, (void*)(&value));
		}
	}

	// Token: 0x170004A6 RID: 1190
	// (get) Token: 0x06000D9B RID: 3483 RVA: 0x00041B14 File Offset: 0x0003FD14
	// (set) Token: 0x06000D9C RID: 3484 RVA: 0x00009FFD File Offset: 0x000081FD
	public unsafe static ushort CONVERT_1_RUNE_TO_HONOR
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_CONVERT_1_RUNE_TO_HONOR, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_CONVERT_1_RUNE_TO_HONOR, (void*)(&value));
		}
	}

	// Token: 0x170004A7 RID: 1191
	// (get) Token: 0x06000D9D RID: 3485 RVA: 0x00041B30 File Offset: 0x0003FD30
	// (set) Token: 0x06000D9E RID: 3486 RVA: 0x0000A00B File Offset: 0x0000820B
	public unsafe static ushort CONVERT_2_RUNE_TO_HONOR
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_CONVERT_2_RUNE_TO_HONOR, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_CONVERT_2_RUNE_TO_HONOR, (void*)(&value));
		}
	}

	// Token: 0x170004A8 RID: 1192
	// (get) Token: 0x06000D9F RID: 3487 RVA: 0x00041B4C File Offset: 0x0003FD4C
	// (set) Token: 0x06000DA0 RID: 3488 RVA: 0x0000A019 File Offset: 0x00008219
	public unsafe static ushort CONVERT_3_RUNE_TO_HONOR
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_CONVERT_3_RUNE_TO_HONOR, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_CONVERT_3_RUNE_TO_HONOR, (void*)(&value));
		}
	}

	// Token: 0x170004A9 RID: 1193
	// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x00041B68 File Offset: 0x0003FD68
	// (set) Token: 0x06000DA2 RID: 3490 RVA: 0x0000A027 File Offset: 0x00008227
	public unsafe static ushort CONVERT_4_RUNE_TO_HONOR
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_CONVERT_4_RUNE_TO_HONOR, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_CONVERT_4_RUNE_TO_HONOR, (void*)(&value));
		}
	}

	// Token: 0x170004AA RID: 1194
	// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x00041B84 File Offset: 0x0003FD84
	// (set) Token: 0x06000DA4 RID: 3492 RVA: 0x0000A035 File Offset: 0x00008235
	public unsafe static ushort CONVERT_5_RUNE_TO_HONOR
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_CONVERT_5_RUNE_TO_HONOR, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_CONVERT_5_RUNE_TO_HONOR, (void*)(&value));
		}
	}

	// Token: 0x170004AB RID: 1195
	// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x00041BA0 File Offset: 0x0003FDA0
	// (set) Token: 0x06000DA6 RID: 3494 RVA: 0x0000A043 File Offset: 0x00008243
	public unsafe static ushort YES
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_YES, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_YES, (void*)(&value));
		}
	}

	// Token: 0x170004AC RID: 1196
	// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x00041BBC File Offset: 0x0003FDBC
	// (set) Token: 0x06000DA8 RID: 3496 RVA: 0x0000A051 File Offset: 0x00008251
	public unsafe static ushort NO
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_NO, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_NO, (void*)(&value));
		}
	}

	// Token: 0x170004AD RID: 1197
	// (get) Token: 0x06000DA9 RID: 3497 RVA: 0x00041BD8 File Offset: 0x0003FDD8
	// (set) Token: 0x06000DAA RID: 3498 RVA: 0x0000A05F File Offset: 0x0000825F
	public unsafe static ushort ID_OVERRIDE_FORCE_MAGNIFY
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_ID_OVERRIDE_FORCE_MAGNIFY, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_ID_OVERRIDE_FORCE_MAGNIFY, (void*)(&value));
		}
	}

	// Token: 0x170004AE RID: 1198
	// (get) Token: 0x06000DAB RID: 3499 RVA: 0x00041BF4 File Offset: 0x0003FDF4
	// (set) Token: 0x06000DAC RID: 3500 RVA: 0x0000A06D File Offset: 0x0000826D
	public unsafe static ushort ID_OFFSET_PLAYER_OWNED_CARD
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_ID_OFFSET_PLAYER_OWNED_CARD, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_ID_OFFSET_PLAYER_OWNED_CARD, (void*)(&value));
		}
	}

	// Token: 0x170004AF RID: 1199
	// (get) Token: 0x06000DAD RID: 3501 RVA: 0x00041C10 File Offset: 0x0003FE10
	// (set) Token: 0x06000DAE RID: 3502 RVA: 0x0000A07B File Offset: 0x0000827B
	public unsafe static ushort ID_OFFSET_RESOLVE_FATE_CARD
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_ID_OFFSET_RESOLVE_FATE_CARD, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_ID_OFFSET_RESOLVE_FATE_CARD, (void*)(&value));
		}
	}

	// Token: 0x170004B0 RID: 1200
	// (get) Token: 0x06000DAF RID: 3503 RVA: 0x00041C2C File Offset: 0x0003FE2C
	// (set) Token: 0x06000DB0 RID: 3504 RVA: 0x0000A089 File Offset: 0x00008289
	public unsafe static ushort ID_OFFSET_PLAYED_CARD_COPY
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_ID_OFFSET_PLAYED_CARD_COPY, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_ID_OFFSET_PLAYED_CARD_COPY, (void*)(&value));
		}
	}

	// Token: 0x170004B1 RID: 1201
	// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x00041C48 File Offset: 0x0003FE48
	// (set) Token: 0x06000DB2 RID: 3506 RVA: 0x0000A097 File Offset: 0x00008297
	public unsafe static ushort ID_OFFSET_FILTER
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(SelectionHint.NativeFieldInfoPtr_ID_OFFSET_FILTER, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SelectionHint.NativeFieldInfoPtr_ID_OFFSET_FILTER, (void*)(&value));
		}
	}

	// Token: 0x040008D8 RID: 2264
	private static readonly IntPtr NativeFieldInfoPtr_NONE;

	// Token: 0x040008D9 RID: 2265
	private static readonly IntPtr NativeFieldInfoPtr_END_TURN;

	// Token: 0x040008DA RID: 2266
	private static readonly IntPtr NativeFieldInfoPtr_CANCEL;

	// Token: 0x040008DB RID: 2267
	private static readonly IntPtr NativeFieldInfoPtr_PLAY_CARD;

	// Token: 0x040008DC RID: 2268
	private static readonly IntPtr NativeFieldInfoPtr_PLAY_CONSTRUCT;

	// Token: 0x040008DD RID: 2269
	private static readonly IntPtr NativeFieldInfoPtr_PLAY_ENTIRE_HAND;

	// Token: 0x040008DE RID: 2270
	private static readonly IntPtr NativeFieldInfoPtr_ACQUIRE_CARD;

	// Token: 0x040008DF RID: 2271
	private static readonly IntPtr NativeFieldInfoPtr_ACQUIRE_CARD_TO_DISCARD;

	// Token: 0x040008E0 RID: 2272
	private static readonly IntPtr NativeFieldInfoPtr_ACQUIRE_CARD_TO_DECK;

	// Token: 0x040008E1 RID: 2273
	private static readonly IntPtr NativeFieldInfoPtr_ACQUIRE_CARD_INTO_PLAY;

	// Token: 0x040008E2 RID: 2274
	private static readonly IntPtr NativeFieldInfoPtr_ACQUIRE_CARD_TO_HAND;

	// Token: 0x040008E3 RID: 2275
	private static readonly IntPtr NativeFieldInfoPtr_ACQUIRE_CARD_FROM_VOID;

	// Token: 0x040008E4 RID: 2276
	private static readonly IntPtr NativeFieldInfoPtr_ACQUIRE_CARD_FROM_VOID_TO_DECK;

	// Token: 0x040008E5 RID: 2277
	private static readonly IntPtr NativeFieldInfoPtr_ACQUIRE_CARD_FROM_VOID_INTO_PLAY;

	// Token: 0x040008E6 RID: 2278
	private static readonly IntPtr NativeFieldInfoPtr_ACQUIRE_CARD_FROM_VOID_TO_HAND;

	// Token: 0x040008E7 RID: 2279
	private static readonly IntPtr NativeFieldInfoPtr_ACQUIRE_TEMPLE;

	// Token: 0x040008E8 RID: 2280
	private static readonly IntPtr NativeFieldInfoPtr_MOVE_TREASURE_FROM_CENTER_ROW;

	// Token: 0x040008E9 RID: 2281
	private static readonly IntPtr NativeFieldInfoPtr_MOVE_TREASURE_TO_CENTER_ROW;

	// Token: 0x040008EA RID: 2282
	private static readonly IntPtr NativeFieldInfoPtr_ACQUIRE_PORTAL;

	// Token: 0x040008EB RID: 2283
	private static readonly IntPtr NativeFieldInfoPtr_ACQUIRE_VISION;

	// Token: 0x040008EC RID: 2284
	private static readonly IntPtr NativeFieldInfoPtr_ACQUIRE_VISION_ONGOING;

	// Token: 0x040008ED RID: 2285
	private static readonly IntPtr NativeFieldInfoPtr_PUT_DISCARD_IN_HAND;

	// Token: 0x040008EE RID: 2286
	private static readonly IntPtr NativeFieldInfoPtr_PUT_DISCARD_ON_DECK;

	// Token: 0x040008EF RID: 2287
	private static readonly IntPtr NativeFieldInfoPtr_PUT_REVEALED_CARD_ON_DECK;

	// Token: 0x040008F0 RID: 2288
	private static readonly IntPtr NativeFieldInfoPtr_PUT_REVEALED_CARD_IN_DISCARD;

	// Token: 0x040008F1 RID: 2289
	private static readonly IntPtr NativeFieldInfoPtr_PUT_CARD_UNDER_CONSTRUCT;

	// Token: 0x040008F2 RID: 2290
	private static readonly IntPtr NativeFieldInfoPtr_DRAW_CARD;

	// Token: 0x040008F3 RID: 2291
	private static readonly IntPtr NativeFieldInfoPtr_PUT_CARD_ON_PORTAL_DECK;

	// Token: 0x040008F4 RID: 2292
	private static readonly IntPtr NativeFieldInfoPtr_TAKE_DISCARD_FROM_OPPONENT;

	// Token: 0x040008F5 RID: 2293
	private static readonly IntPtr NativeFieldInfoPtr_PUT_VOID_CARD_ON_PORTAL_DECK;

	// Token: 0x040008F6 RID: 2294
	private static readonly IntPtr NativeFieldInfoPtr_DEFEAT_MONSTER;

	// Token: 0x040008F7 RID: 2295
	private static readonly IntPtr NativeFieldInfoPtr_DEFEAT_CULTIST;

	// Token: 0x040008F8 RID: 2296
	private static readonly IntPtr NativeFieldInfoPtr_DEFEAT_MONSTER_IN_VOID;

	// Token: 0x040008F9 RID: 2297
	private static readonly IntPtr NativeFieldInfoPtr_DEFEAT_MONSTER_TO_DISCARD;

	// Token: 0x040008FA RID: 2298
	private static readonly IntPtr NativeFieldInfoPtr_DEFEAT_MONSTER_IN_VOID_TO_DISCARD;

	// Token: 0x040008FB RID: 2299
	private static readonly IntPtr NativeFieldInfoPtr_DEFEAT_TROPHY_MONSTER;

	// Token: 0x040008FC RID: 2300
	private static readonly IntPtr NativeFieldInfoPtr_DEFEAT_HERO_WITH_POWER;

	// Token: 0x040008FD RID: 2301
	private static readonly IntPtr NativeFieldInfoPtr_DEFEAT_MONSTER_INTO_PLAY;

	// Token: 0x040008FE RID: 2302
	private static readonly IntPtr NativeFieldInfoPtr_DEFEAT_MONSTER_IN_VOID_INTO_PLAY;

	// Token: 0x040008FF RID: 2303
	private static readonly IntPtr NativeFieldInfoPtr_DEFEAT_MONSTER_TO_PORTAL_DECK;

	// Token: 0x04000900 RID: 2304
	private static readonly IntPtr NativeFieldInfoPtr_DISCARD_CARD_FROM_HAND;

	// Token: 0x04000901 RID: 2305
	private static readonly IntPtr NativeFieldInfoPtr_DISCARD_CONSTRUCT_FROM_PLAY;

	// Token: 0x04000902 RID: 2306
	private static readonly IntPtr NativeFieldInfoPtr_DISCARD_ALL_OTHER_CONSTRUCT;

	// Token: 0x04000903 RID: 2307
	private static readonly IntPtr NativeFieldInfoPtr_DISCARD_ALL_CONSTRUCTS;

	// Token: 0x04000904 RID: 2308
	private static readonly IntPtr NativeFieldInfoPtr_RETURN_CONSTRUCT_TO_HAND;

	// Token: 0x04000905 RID: 2309
	private static readonly IntPtr NativeFieldInfoPtr_PREVENT_DESTROY_CONSTRUCT;

	// Token: 0x04000906 RID: 2310
	private static readonly IntPtr NativeFieldInfoPtr_DISCARD_CONSTRUCT_FROM_OPP;

	// Token: 0x04000907 RID: 2311
	private static readonly IntPtr NativeFieldInfoPtr_ACQUIRE_CONSTRUCT_FROM_OPP;

	// Token: 0x04000908 RID: 2312
	private static readonly IntPtr NativeFieldInfoPtr_DISCARD_CARD_TO_PLAYER;

	// Token: 0x04000909 RID: 2313
	private static readonly IntPtr NativeFieldInfoPtr_DISCARD_MONSTER;

	// Token: 0x0400090A RID: 2314
	private static readonly IntPtr NativeFieldInfoPtr_DISCARD_MONSTER_IN_VOID;

	// Token: 0x0400090B RID: 2315
	private static readonly IntPtr NativeFieldInfoPtr_DISCARD_CARD_ONTO_DECK;

	// Token: 0x0400090C RID: 2316
	private static readonly IntPtr NativeFieldInfoPtr_BANISH_CARD;

	// Token: 0x0400090D RID: 2317
	private static readonly IntPtr NativeFieldInfoPtr_BANISH_CARD_MASK;

	// Token: 0x0400090E RID: 2318
	private static readonly IntPtr NativeFieldInfoPtr_BANISH_CARD_FROM_HAND;

	// Token: 0x0400090F RID: 2319
	private static readonly IntPtr NativeFieldInfoPtr_BANISH_CARD_FROM_DISCARD;

	// Token: 0x04000910 RID: 2320
	private static readonly IntPtr NativeFieldInfoPtr_BANISH_CARD_FROM_CENTER;

	// Token: 0x04000911 RID: 2321
	private static readonly IntPtr NativeFieldInfoPtr_BANISH_CARD_FROM_DECK;

	// Token: 0x04000912 RID: 2322
	private static readonly IntPtr NativeFieldInfoPtr_BANISH_PHANTASM_FROM_CENTER;

	// Token: 0x04000913 RID: 2323
	private static readonly IntPtr NativeFieldInfoPtr_USE_CONSTRUCT;

	// Token: 0x04000914 RID: 2324
	private static readonly IntPtr NativeFieldInfoPtr_USE_TROPHY;

	// Token: 0x04000915 RID: 2325
	private static readonly IntPtr NativeFieldInfoPtr_USE_CONSTRUCT_TRANSFORM;

	// Token: 0x04000916 RID: 2326
	private static readonly IntPtr NativeFieldInfoPtr_CHOOSE_EFFECT;

	// Token: 0x04000917 RID: 2327
	private static readonly IntPtr NativeFieldInfoPtr_COPY_EFFECT;

	// Token: 0x04000918 RID: 2328
	private static readonly IntPtr NativeFieldInfoPtr_COPY_LIFEBOUND_FROM_LIST;

	// Token: 0x04000919 RID: 2329
	private static readonly IntPtr NativeFieldInfoPtr_COPY_DEFEATED_MONSTER_FROM_LIST;

	// Token: 0x0400091A RID: 2330
	private static readonly IntPtr NativeFieldInfoPtr_CHOOSE_FACTION_ENLIGHTENED;

	// Token: 0x0400091B RID: 2331
	private static readonly IntPtr NativeFieldInfoPtr_CHOOSE_FACTION_LIFEBOUND;

	// Token: 0x0400091C RID: 2332
	private static readonly IntPtr NativeFieldInfoPtr_CHOOSE_FACTION_MECHANA;

	// Token: 0x0400091D RID: 2333
	private static readonly IntPtr NativeFieldInfoPtr_CHOOSE_FACTION_VOID;

	// Token: 0x0400091E RID: 2334
	private static readonly IntPtr NativeFieldInfoPtr_PAY_RESOURCE_COST;

	// Token: 0x0400091F RID: 2335
	private static readonly IntPtr NativeFieldInfoPtr_PAY_TRANSFORM_COST;

	// Token: 0x04000920 RID: 2336
	private static readonly IntPtr NativeFieldInfoPtr_SELECT_DREAMSCAPE_CARD;

	// Token: 0x04000921 RID: 2337
	private static readonly IntPtr NativeFieldInfoPtr_ADD_CARD_TO_DREAMSCAPE;

	// Token: 0x04000922 RID: 2338
	private static readonly IntPtr NativeFieldInfoPtr_TAKE_PLAYER_INSIGHT;

	// Token: 0x04000923 RID: 2339
	private static readonly IntPtr NativeFieldInfoPtr_AUCTION_INSIGHT_BID;

	// Token: 0x04000924 RID: 2340
	private static readonly IntPtr NativeFieldInfoPtr_AUCTION_INSIGHT_PASS;

	// Token: 0x04000925 RID: 2341
	private static readonly IntPtr NativeFieldInfoPtr_PAY_FOR_DELIRIUM_DIE;

	// Token: 0x04000926 RID: 2342
	private static readonly IntPtr NativeFieldInfoPtr_ROLL_DELIRIUM_ROLL;

	// Token: 0x04000927 RID: 2343
	private static readonly IntPtr NativeFieldInfoPtr_TAKE_PLAYER_HONOR;

	// Token: 0x04000928 RID: 2344
	private static readonly IntPtr NativeFieldInfoPtr_NAME_CARD_FROM_DECK;

	// Token: 0x04000929 RID: 2345
	private static readonly IntPtr NativeFieldInfoPtr_CONVERT_1_RUNE_TO_HONOR;

	// Token: 0x0400092A RID: 2346
	private static readonly IntPtr NativeFieldInfoPtr_CONVERT_2_RUNE_TO_HONOR;

	// Token: 0x0400092B RID: 2347
	private static readonly IntPtr NativeFieldInfoPtr_CONVERT_3_RUNE_TO_HONOR;

	// Token: 0x0400092C RID: 2348
	private static readonly IntPtr NativeFieldInfoPtr_CONVERT_4_RUNE_TO_HONOR;

	// Token: 0x0400092D RID: 2349
	private static readonly IntPtr NativeFieldInfoPtr_CONVERT_5_RUNE_TO_HONOR;

	// Token: 0x0400092E RID: 2350
	private static readonly IntPtr NativeFieldInfoPtr_YES;

	// Token: 0x0400092F RID: 2351
	private static readonly IntPtr NativeFieldInfoPtr_NO;

	// Token: 0x04000930 RID: 2352
	private static readonly IntPtr NativeFieldInfoPtr_ID_OVERRIDE_FORCE_MAGNIFY;

	// Token: 0x04000931 RID: 2353
	private static readonly IntPtr NativeFieldInfoPtr_ID_OFFSET_PLAYER_OWNED_CARD;

	// Token: 0x04000932 RID: 2354
	private static readonly IntPtr NativeFieldInfoPtr_ID_OFFSET_RESOLVE_FATE_CARD;

	// Token: 0x04000933 RID: 2355
	private static readonly IntPtr NativeFieldInfoPtr_ID_OFFSET_PLAYED_CARD_COPY;

	// Token: 0x04000934 RID: 2356
	private static readonly IntPtr NativeFieldInfoPtr_ID_OFFSET_FILTER;

	// Token: 0x04000935 RID: 2357
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
