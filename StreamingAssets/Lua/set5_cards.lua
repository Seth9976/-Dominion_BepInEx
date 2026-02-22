

g_ascension_cards["Energy Shard Start"] = {
	card_name = "Energy Shard Start";
   display_name = "Energy Shard";
    card_set = "RoV";
	card_type = "Treasure";
	honor = 0;
   do_not_put_in_void = true;

	effects = {
		{ "GainEnergy", 1 },
		{ "DrawCards", 1 },
	};

	effect_text = "Gain 1E. Draw a card.";

   ai = {
      trivial_draw = 1;

      gain_draw = 1;
      gain_energy = 1;
   },
   
   --image_large = { "T_EnergyShardSTART_ROV", {0, 0, 364/512, 1} };
   --image_medium = { "T_EnergyShardSTART_ROV", {392/512, 0, 512/512, 168/512} };
   --image_small = { "T_EnergyShardSTART_ROV", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "T_EnergyShardSTART_ROV", {384/512, 395/512, 512/512, 512/512} };
   
   image_large = { "T_EnergyShard", {0, 0, 364/512, 1} };
   image_medium = { "T_EnergyShard", {392/512, 0, 512/512, 168/512} };
   image_small = { "T_EnergyShard", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "T_EnergyShard", {384/512, 395/512, 512/512, 512/512} };
   
}

g_ascension_cards["Energy Shard"] = {
	card_name = "Energy Shard";
   display_name = "Energy Shard";
    card_set = "RoV";
	card_type = "Treasure";
	honor = 0;

	effects = {
		{ "GainEnergy", 1 },
		{ "DrawCards", 1 },
	};

	effect_text = "Gain 1E. Draw a card.";

   ai = {
      trivial_draw = 1;

      gain_draw = 1;
      gain_energy = 1;
   },
   
   --image_large = { "T_EnergyShard_ROV", {0, 0, 364/512, 1} };
   --image_medium = { "T_EnergyShard_ROV", {392/512, 0, 512/512, 168/512} };
   --image_small = { "T_EnergyShard_ROV", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "T_EnergyShard_ROV", {384/512, 395/512, 512/512, 512/512} };
   
   image_large = { "T_EnergyShard", {0, 0, 364/512, 1} };
   image_medium = { "T_EnergyShard", {392/512, 0, 512/512, 168/512} };
   image_small = { "T_EnergyShard", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "T_EnergyShard", {384/512, 395/512, 512/512, 512/512} };
   
}

g_ascension_cards["Militia RoV"] = {
	card_name = "Militia RoV";
	display_name = "Militia";
    card_set = "RoV";
	card_type = "Hero";
	rune_cost = 0;
   do_not_put_in_void = true;
	effect = { "GainPower", 1 };
	effect_text = "Gain 1P.";
   
   ai = {
      trivial = true;
      preferred_discard = true;
      preferred_banish = true;

      gain_power = 1;
   },
      
   --image_large = { "H_Militia_ROV", {0, 0, 364/512, 1} };
   --image_medium = { "H_Militia_ROV", {392/512, 0, 512/512, 168/512} };
   --image_small = { "H_Militia_ROV", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "H_Militia_ROV", {384/512, 395/512, 512/512, 512/512} };
   image_large = { "H_Militia", {0, 0, 364/512, 1} };
   image_medium = { "H_Militia", {392/512, 0, 512/512, 168/512} };
   image_small = { "H_Militia", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "H_Militia", {384/512, 395/512, 512/512, 512/512} };
}

g_ascension_cards["Apprentice RoV"] = {
	card_name = "Apprentice RoV";
	display_name = "Apprentice";
    card_set = "RoV";
	card_type = "Hero";
	rune_cost = 0;
   do_not_put_in_void = true;
	effect = { "GainRunes", 1 };
	effect_text = "Gain 1R.";
   
   ai = {
      trivial = true;
      preferred_discard = true;
      preferred_banish = true;

      gain_rune = 1;
   },

   --image_large = { "H_Apprentice_ROV", {0, 0, 364/512, 1} };
   --image_medium = { "H_Apprentice_ROV", {392/512, 0, 512/512, 168/512} };
   --image_small = { "H_Apprentice_ROV", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "H_Apprentice_ROV", {384/512, 395/512, 512/512, 512/512} };
   image_large = { "H_Apprentice", {0, 0, 364/512, 1} };
   image_medium = { "H_Apprentice", {392/512, 0, 512/512, 168/512} };
   image_small = { "H_Apprentice", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "H_Apprentice", {384/512, 395/512, 512/512, 512/512} };
}

g_ascension_cards["Mystic RoV"] = {
	card_name = "Mystic RoV";
   display_name = "Mystic";
    card_set = "RoV";
	card_type = "Hero";
	rune_cost = 3;
	honor = 1;
   do_not_put_in_void = true;
	effect = { "GainRunes", 2 };
	effect_text = "Gain 2R.";
   
   ai = {
      trivial = true;

      gain_rune = 2;
   },

   --image_large = { "H_Mystic_ROV", {0, 0, 364/512, 1} };
   --image_medium = { "H_Mystic_ROV", {392/512, 0, 512/512, 168/512} };
   --image_small = { "H_Mystic_ROV", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "H_Mystic_ROV", {384/512, 395/512, 512/512, 512/512} };
   image_large = { "H_Mystic", {0, 0, 364/512, 1} };
   image_medium = { "H_Mystic", {392/512, 0, 512/512, 168/512} };
   image_small = { "H_Mystic", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "H_Mystic", {384/512, 395/512, 512/512, 512/512} };
}

g_ascension_cards["Heavy Infantry RoV"] = {
	card_name = "Heavy Infantry RoV";
   display_name = "Heavy Infantry";
    card_set = "RoV";
	card_type = "Hero";
	rune_cost = 2;
	honor = 1;
   do_not_put_in_void = true;
	effect = { "GainPower", 2 };
	effect_text = "Gain 2P.";
   
   ai = {
      trivial = true;

      gain_power = 2;
   },

   --image_large = { "H_HeavyInfantry_ROV", {0, 0, 364/512, 1} };
   --image_medium = { "H_HeavyInfantry_ROV", {392/512, 0, 512/512, 168/512} };
   --image_small = { "H_HeavyInfantry_ROV", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "H_HeavyInfantry_ROV", {384/512, 395/512, 512/512, 512/512} };
   image_large = { "H_HeavyInfantry", {0, 0, 364/512, 1} };
   image_medium = { "H_HeavyInfantry", {392/512, 0, 512/512, 168/512} };
   image_small = { "H_HeavyInfantry", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "H_HeavyInfantry", {384/512, 395/512, 512/512, 512/512} };
}

g_ascension_cards["Cultist RoV"] = {
	card_name = "Cultist RoV";
	display_name = "Cultist";
    card_set = "RoV";
	card_type = "Monster";
	power_cost = 2;
   do_not_put_in_void = true;
	reward = { "GainHonor", 1 };
	effect_text = "Reward: Gain 1H.";
   --image_large = { "M_Cultist_ROV", {0, 0, 364/512, 1} };
   --image_medium = { "M_Cultist_ROV", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_Cultist_ROV", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_Cultist_ROV", {384/512, 395/512, 512/512, 512/512} };
   image_large = { "M_Cultist", {0, 0, 364/512, 1} };
   image_medium = { "M_Cultist", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_Cultist", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_Cultist", {384/512, 395/512, 512/512, 512/512} };
}



-- TODO: allow acquire to deck/hand effects
g_ascension_cards["Monastic Tutor"] = {
	card_name = "Monastic Tutor";
	card_type = "Hero";
    card_set = "RoV";
	faction = "Enlightened";
	rune_cost = 1;
	honor = 1;

   uses_energy = true;
   energy_required = 1;

	effects = {
		{ "AcquireMysticOrHeavyInfantryToHand", 0, condition={"IfHasCurrentTurnEnergy",1} },
		{ "AcquireMysticOrHeavyInfantry", 0, condition={"IfDoesNotHaveCurrentTurnEnergy",1} },
      { "EnergizeThisCard", 1 },
   };
   
	effect_text = "Acquire a Mystic or Heavy Infantry without paying its cost.\n" ..
                  "ENERGIZE 1E: Put the acquired card into your hand.";

   ai = {
      energy_threshold = 1;
   },
   
   image_large = { "EH_MonasticTutor", {0, 0, 364/512, 1} };
   image_medium = { "EH_MonasticTutor", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_MonasticTutor", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_MonasticTutor", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Monk of the Lidless Eye"] = {
	card_name = "Monk of the Lidless Eye";
	card_type = "Hero";
    card_set = "RoV";
	faction = "Enlightened";
	rune_cost = 5;
	honor = 2;
   
	center_row = { "EachPlayerDrawCardsForTreasureUnderCenterRow", 1 },

	effects = {
      { "DrawCards", 2 },
   };

	--effect_text = "FATE: When this enters the center row, for each treasure under this, " ..
    --              "each player draws a card.\n" ..
    --              "Draw two cards.";
	fate_text = "FATE: When this enters the center row, for each treasure under this, " ..
                  "each player draws a card.";
	effect_text = "Draw two cards.";

   ai = {
      trivial_draw = 2;

      gain_draw = 2;
   },

   image_large = { "EH_MonkLidlessEye", {0, 0, 364/512, 1} };
   image_medium = { "EH_MonkLidlessEye", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_MonkLidlessEye", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_MonkLidlessEye", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Oziah, Judge of Logos"] = {
	card_name = "Oziah, Judge of Logos";
	card_type = "Hero";
    card_set = "RoV";
	faction = "Enlightened";
	rune_cost = 9;
	honor = 5;

	center_row_continuous_effects = {
		{
			conditions = {
				{ "TriggerIfHasCurrentTurnEnergy", 7 },
			};
			effect = { "MayAcquireThisAtNoCost", 0 };
		},
	};

	effects = {
      { "DefeatAllMonstersInCenterRow", 0 },
   };

	effect_text = "While this is in the center row, you may acquire this without paying its cost " ..
                  "if you have gained 7E or more this turn.\n" ..
                  "Defeat all Monsters in the center row without paying their costs.";

   ai = {
   },
   
   image_large = { "EH_OziahJudgeLogos", {0, 0, 364/512, 1} };
   image_medium = { "EH_OziahJudgeLogos", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_OziahJudgeLogos", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_OziahJudgeLogos", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Reality Sculptor"] = {
	card_name = "Reality Sculptor";
	card_type = "Hero";
    card_set = "RoV";
	faction = "Enlightened";
	rune_cost = 3;
	honor = 1;
   
	effects = {
   	{ "CopyEffectOfAnyPlayedHeroWithLessCost", 3 },
   };

	effect_text = "Copy the effect of a Hero played this turn with cost 3R or less.";

   ai = {
      do_not_copy_played_card = true;
      requires_copyable_played_card = true;
   },
   
   image_large = { "EH_RealitySculptor", {0, 0, 364/512, 1} };
   image_medium = { "EH_RealitySculptor", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_RealitySculptor", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_RealitySculptor", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Righteous Templar"] = {
	card_name = "Righteous Templar";
	card_type = "Hero";
    card_set = "RoV";
	faction = "Enlightened";
	rune_cost = 4;
	honor = 2;
   
   uses_energy = true;
   energy_required = 3;

	effects = {
		{ "DefeatMonsterWithLessPower", 0, condition={"IfHasCurrentTurnEnergy",3} },
		{ "DefeatMonsterWithLessPower", 4, condition={"IfDoesNotHaveCurrentTurnEnergy",3} },
      { "EnergizeThisCard", 3 },
   };

	effect_text = "Defeat a Monster that costs 4P or less without paying its cost.\n" ..
               "ENERGIZE 3E: Instead, defeat any Monster without paying its cost.";

   ai = {
      defeat_monster = 4;

      energy_threshold = 3;
   },
   
   image_large = { "EH_RighteousTemplar", {0, 0, 364/512, 1} };
   image_medium = { "EH_RighteousTemplar", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_RighteousTemplar", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_RighteousTemplar", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Tablet of the Dreamer"] = {
	card_name = "Tablet of the Dreamer";
	card_type = "Construct";
    card_set = "RoV";
	faction = "Enlightened";
	rune_cost = 5;
	honor = 3;
   
   uses_energy = true;
   energy_required = 4;
   
	construct_ability = {
		description = "Acquire/Defeat";
		condition = { "IfConstructHasCurrentTurnEnergy", 4 },
		{ "AcquireOrDefeatAnyCenterRow", 0 },
	};

	effect_text = "ENERGIZE 4E: Once this turn, acquire or defeat any card " ..
                  "in the center row without paying its cost.";

   ai = {
      energy_threshold = 4;
   },
   
   image_large = { "EC_TabletDreamer", {0, 0, 364/512, 1} };
   image_medium = { "EC_TabletDreamer", {392/512, 0, 512/512, 168/512} };
   image_small = { "EC_TabletDreamer", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EC_TabletDreamer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Temporal Eye"] = {
	card_name = "Temporal Eye";
	card_type = "Construct";
    card_set = "RoV";
	faction = "Enlightened";
	rune_cost = 3;
    --honor = 3;
	honor = 1;
   
	triggered_effects = {
		{
			conditions = {
				{ "IfThisHasntBeenUsedThisTurn", 0 },
				{ "WhenYouPutThisConstructIntoPlay", 0 },
			};
			triggereffect = {
				{ "TriggerConstructOwnerDrawCards", 1 },
				{ "TriggerSetThisHasBeenUsedThisTurn", 0 },
			};
		},
	};

	construct_ability = {
		description = "Gain a Turn";
		condition = { "IfHasOtherTemporalEyeInPlay", 1 },
		{ "TakeAnAdditionalTurn", 0 },
		{ "BanishOtherTemporalEyeInPlay", 0 },
		{ "BanishThisConstruct", 0 },

      ai = {
         use_at_end_of_turn = true,
      },
	};

	effect_text = "When this enters play, draw a card.\n" ..
                  "You may banish this and another Temporal Eye you control to take an additional turn.";

   ai = {
   },
   
   image_large = { "EC_TemporalEye", {0, 0, 364/512, 1} };
   image_medium = { "EC_TemporalEye", {392/512, 0, 512/512, 168/512} };
   image_small = { "EC_TemporalEye", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EC_TemporalEye", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Truth Seeker"] = {
	card_name = "Truth Seeker";
	card_type = "Hero";
    card_set = "RoV";
	faction = "Enlightened";
	rune_cost = 4;
	honor = 2;
   
	effects = {
		{ "DrawCards", 1 },
		{ "BanishFromCenterRowAndAcquireReplacementTreasure", 1 },
	};

	effect_text = "Draw a card. You may banish a card in the center row. " ..
                  "If the next card to enter the center row is a Treasure, acquire it.";

   ai = {
      gain_draw = 1;
   },
   
   image_large = { "EH_TruthSeeker", {0, 0, 364/512, 1} };
   image_medium = { "EH_TruthSeeker", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_TruthSeeker", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_TruthSeeker", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Ulu, Askara Prince"] = {
	card_name = "Ulu, Askara Prince";
	card_type = "Hero";
    card_set = "RoV";
	faction = "Enlightened";
	rune_cost = 6;
	honor = 3;
   
   uses_energy = true;
   energy_required = 2;

   played_effect_cannot_be_copied = true;
   
	effects = {
		{ "CopyEffectOfAnyPlayedHero", 0 },
		{ "CopyEffectOfInstanceEffectDataCard", 0, condition={"IfHasCurrentTurnEnergy",2} },
      { "EnergizeThisCard", 2 },
	};

	effect_text = "Copy the effect of a Hero played this turn. This effect cannot be copied.\n" ..
                  "ENERGIZE 2E: Copy the chosen effect an additional time.";

   ai = {
      energy_threshold = 2;

      requires_copyable_played_card = true,
   },
   
   image_large = { "EH_UluAskaraPrince", {0, 0, 364/512, 1} };
   image_medium = { "EH_UluAskaraPrince", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_UluAskaraPrince", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_UluAskaraPrince", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}





g_ascension_cards["Beacon Shaman"] = {
	card_name = "Beacon Shaman";
	card_type = "Hero";
    card_set = "RoV";
	faction = "Lifebound";
	rune_cost = 2;
	honor = 1;
   
	effects = {
      { "RevealTopCardOfDeck", 0 },
      { "GainHonor", 3, condition={"IfTopOfDeckIsTreasure",0} },
      { "Pause", 0 },
      --{ "PopResolvingCardFromEffectData", 0 },
      { "PopAndDrawRevealedCard", 0 },
	};

	effect_text = "Reveal the top card of your deck and put it in your hand. " ..
                  "If it is a Treasure, gain 3H.";

   ai = {
      gain_draw = 1;
   },
   
   image_large = { "LH_BeaconShaman", {0, 0, 364/512, 1} };
   image_medium = { "LH_BeaconShaman", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_BeaconShaman", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_BeaconShaman", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Leotan's Familiar"] = {
	card_name = "Leotan's Familiar";
	card_type = "Hero";
    card_set = "RoV";
	faction = "Lifebound";
	rune_cost = 1;
	honor = 1;
   
   uses_energy = true;
   energy_required = 1;

	effects = {
		{ "GainRunes", 1 },
		{ "GainHonor", 2, condition={"IfHasCurrentTurnEnergy",1} },
      { "EnergizeThisCard", 1 },
   };

	effect_text = "Gain 1R.\n" ..
                  "ENERGIZE 1E: Gain 2H.";

   ai = {
      energy_threshold = 1;
      trivial = true;

      gain_rune = 1;
      gain_honor = 2;
   },
   
   image_large = { "LH_LeotansFamiliar", {0, 0, 364/512, 1} };
   image_medium = { "LH_LeotansFamiliar", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_LeotansFamiliar", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_LeotansFamiliar", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Lifebound Muse"] = {
	card_name = "Lifebound Muse";
	card_type = "Hero";
    card_set = "RoV";
	faction = "Lifebound";
	rune_cost = 4;
	honor = 3;
   
   uses_energy = true;
   energy_required = 2;

	effects = {
		{ "AcquireHeroWithLessCost", 0, condition={"IfHasCurrentTurnEnergy",2} },
		{ "AcquireHeroWithLessCost", 4, condition={"IfDoesNotHaveCurrentTurnEnergy",2} },
      { "EnergizeThisCard", 2 },
   };

	effect_text = "Acquire a Hero with cost 4R or less without paying its cost.\n" ..
                  "ENERGIZE 2E: Instead, acquire any Hero without paying its cost.";

   ai = {
      energy_threshold = 2;
   },
   
   image_large = { "LH_LifeboundMuse", {0, 0, 364/512, 1} };
   image_medium = { "LH_LifeboundMuse", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_LifeboundMuse", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_LifeboundMuse", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Loamspeaker Druid"] = {
	card_name = "Loamspeaker Druid";
	card_type = "Hero";
    card_set = "RoV";
	faction = "Lifebound";
	rune_cost = 5;
	honor = 2;
   
	center_row = { "AddToHonorPoolForEachTreasureUnderCenterRow", 10 },

	effects = {
		{ "GainRunes", 3 },
   };

	--effect_text = "FATE: When this enters the center row, for each Treasure under this, " ..
    --              "add 10H to the honor pool.\n" ..
    --              "Gain 3R.";
	fate_text = "FATE: When this enters the center row, for each Treasure under this, " ..
                  "add 10H to the honor pool.";
	effect_text = "Gain 3R.";

   ai = {
      trivial = true;

      gain_rune = 3;
   },
   
   image_large = { "LH_LoamspeakerDruid", {0, 0, 364/512, 1} };
   image_medium = { "LH_LoamspeakerDruid", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_LoamspeakerDruid", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_LoamspeakerDruid", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Ogo Demontrap"] = {
	card_name = "Ogo Demontrap";
	card_type = "Construct";
    card_set = "RoV";
	faction = "Lifebound";
	rune_cost = 4;
	honor = 2;
   
   uses_energy = true;
   energy_required = 4;
   
   construct_abilities = {
		{
         description = "Gain 1P";
         { "GainPower", 1 },
         
         ai = {
            trivial = true,
         },
		},
      {
         description = "Gain 3H";
         condition = { "IfConstructHasCurrentTurnEnergy", 4 },
         { "GainHonor", 3 },
         
         ai = {
            trivial = true,
         },
		},
	};

	effect_text = "Once per turn, gain 1P.\n" ..
                  "ENERGIZE 4E: Once this turn, gain 3H.";

   ai = {
      energy_threshold = 4;

      gain_power = 1;
      gain_honor = 3;
   },
   
   image_large = { "LC_OgoDemontrap", {0, 0, 364/512, 1} };
   image_medium = { "LC_OgoDemontrap", {392/512, 0, 512/512, 168/512} };
   image_small = { "LC_OgoDemontrap", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LC_OgoDemontrap", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_active_effects["gain honor for acquired hero"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouAcquireHeroFromCenterRow", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerGainHonorForAcquiredCard", 0 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}


g_ascension_cards["Oras, the Redeemer"] = {
	card_name = "Oras, the Redeemer";
	card_type = "Hero";
    card_set = "RoV";
	faction = "Lifebound";
	rune_cost = 7;
	honor = 4;
   
	effects = {
		{ "GainRunes", 4 },
      { "GainHonorForAcquiredHeroThisTurn", 0 },
   };

	effect_text = "Gain 4R.\n" ..
                  "Each time you acquire a Hero from the center row this turn, " ..
                  "gain honor equal to its honor value.";

   ai = {
      gain_rune = 4;
   },
   
   image_large = { "LH_OrasRedeemer", {0, 0, 364/512, 1} };
   image_medium = { "LH_OrasRedeemer", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_OrasRedeemer", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_OrasRedeemer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Runic Honiskrot"] = {
	card_name = "Runic Honiskrot";
	card_type = "Hero";
    card_set = "RoV";
	faction = "Lifebound";
	rune_cost = 3;
	honor = 1;
   
   uses_energy = true;
   energy_required = 3;

	effects = {
		{ "GainRunes", 2 },
		{ "GainPower", 2, condition={"IfHasCurrentTurnEnergy",3} },
      { "EnergizeThisCard", 3 },
   };

	effect_text = "Gain 2R.\n" ..
                  "ENERGIZE 3E: Gain 2P.";

   ai = {
      energy_threshold = 3;

      gain_rune = 2;
      gain_power = 2;
   },
   
   image_large = { "LH_RunicHoniskrot", {0, 0, 364/512, 1} };
   image_medium = { "LH_RunicHoniskrot", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_RunicHoniskrot", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_RunicHoniskrot", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Starcaller Leotan"] = {
	card_name = "Starcaller Leotan";
	card_type = "Hero";
    card_set = "RoV";
	faction = "Lifebound";
	rune_cost = 6;
	honor = 3;
   
   uses_energy = true;
   energy_required = 1;
   
	effects = {
		{ "GainHonor", 4 },
		{ "GainHonorForCurrentTurnEnergy", 1, condition={"IfHasCurrentTurnEnergy",1} },
      { "EnergizeThisCard", 1 },
   };

	effect_text = "Gain 4H.\n" ..
                  "ENERGIZE: Gain an additional 1H for each 1E you have gained this turn.";

   ai = {
      energy_threshold = 1;

      gain_honor = 4;
   },
   
   image_large = { "LH_StarcallerLeotan", {0, 0, 364/512, 1} };
   image_medium = { "LH_StarcallerLeotan", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_StarcallerLeotan", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_StarcallerLeotan", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Wildcall Staff"] = {
	card_name = "Wildcall Staff";
	card_type = "Construct";
    card_set = "RoV";
	faction = "Lifebound";
	rune_cost = 5;
	honor = 3;
      
   uses_energy = true;


   continuous_effects = {
      {
			conditions = {
				{ "TriggerIfConstructEffectDataIsZero", 0 },
         };
         effect = { "ReduceRuneCostWithTreasureUnder", 2 };
      },
   };
	triggered_effects = {
		{
			conditions = {
				{ "WhenConstructOwnerAcquiresCardWithTreasure", 0 },
			};
			triggereffect = {
				{ "TriggerIncrementConstructEffectData", 0 },
			};
		},
		{
			conditions = {
				{ "AtEndOfConstructOwnerTurn", 0 },
			};
			triggereffect = {
				{ "TriggerConstructSetEffectDataToZero", 0 },
			};
		},
	};

	effect_text = "Once per turn, you pay 2R less to acquire a card with Treasure under it.";

   ai = {
   },
   
   image_large = { "LC_WildcallStaff", {0, 0, 364/512, 1} };
   image_medium = { "LC_WildcallStaff", {392/512, 0, 512/512, 168/512} };
   image_small = { "LC_WildcallStaff", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LC_WildcallStaff", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}





g_ascension_active_effects["construct acquired costs less"] = {
	type = "continuous";
	effectfunc = { "ReduceConstructRuneCostForEffectData", 0 };
}

g_ascension_cards["Cognition Courier"] = {
	card_name = "Cognition Courier";
	card_type = "Hero";
    card_set = "RoV";
	faction = "Mechana";
	rune_cost = 5;
	honor = 3;
   
   uses_energy = true;
   energy_required = 1;
   
	effects = {
		{ "GainRunes", 2 },
		{ "NextContructYouAcquireCostsLessForCurrentEnergy", 1, condition={"IfHasCurrentTurnEnergy",1} },
      { "EnergizeThisCard", 1 },
	};

	effect_text = "Gain 2R.\n" ..
                  "ENERGIZE: You pay 1R less the next time you acquire a Construct this turn " ..
                     "for each 1E you have gained this turn.";

   ai = {
      energy_threshold = 1;
      
      gain_rune = 2;
   },
   
   image_large = { "MH_CognitionCourier", {0, 0, 364/512, 1} };
   image_medium = { "MH_CognitionCourier", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_CognitionCourier", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_CognitionCourier", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Foresight Monacle"] = {
	card_name = "Foresight Monacle";
	card_type = "Construct";
    card_set = "RoV";
	faction = "Mechana";
	rune_cost = 4;
	honor = 4;
   
   uses_energy = true;
   energy_required = 4;
   
	construct_abilities = {
		{
			description = "Gain R";
			condition = { "IfConstructHasCurrentTurnEnergy", 4 },
			{ "GainRunesForEachMechanaConstructInPlay", 1 },

		},
	};

	effect_text = "ENERGIZE 4E: Once this turn, gain 1R for each Mechana Construct you control.";

   ai = {
      energy_threshold = 4;
   },
   
   image_large = { "MC_ForesightMonocle", {0, 0, 364/512, 1} };
   image_medium = { "MC_ForesightMonocle", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_ForesightMonocle", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_ForesightMonocle", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Magnet Monk"] = {
	card_name = "Magnet Monk";
	card_type = "Hero";
    card_set = "RoV";
	faction = "Mechana";
	rune_cost = 3;
	honor = 2;
   
   uses_energy = true;

	effects = {
		{ "GainPower", 2 },
		{ "GainEnergyForEachTypeOfConstructInPlay", 1 },
   };

	effect_text = "Gain 2P.\n" ..
                  "Gain 1E for each faction among Constructs you control.";

   ai = {
      gain_power = 2;
   },
   
   image_large = { "MH_MagnetMonk", {0, 0, 364/512, 1} };
   image_medium = { "MH_MagnetMonk", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_MagnetMonk", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_MagnetMonk", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Omnicron"] = {
	card_name = "Omnicron";
	card_type = "Construct";
    card_set = "RoV";
	faction = "Mechana";
	rune_cost = 7;
	honor = 7;
   
   uses_energy = true;

   center_row = { "AddSeventhRowIfTreasureUnderCenterRow", 1 },

   construct_abilities = {
		{
			description = "Gain E";
			{ "GainEnergyForEachMechanaConstructInPlay", 1 },
		},
	};

	--effect_text = "FATE: When this enters the center row, for each Treasure under this, " ..
    --                 "add a card to the center row.\n" ..
    --              "Once per turn, gain 1E for each Mechana Construct you control.";
	fate_text = "FATE: When this enters the center row, for each Treasure under this, " ..
                     "add a card to the center row.";
	effect_text = "Once per turn, gain 1E for each Mechana Construct you control.";

   ai = {
   },
   
   image_large = { "MC_Omnicron", {0, 0, 364/512, 1} };
   image_medium = { "MC_Omnicron", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_Omnicron", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_Omnicron", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Portabillet"] = {
	card_name = "Portabillet";
	card_type = "Construct";
    card_set = "RoV";
	faction = "Mechana";
	rune_cost = 5;
	honor = 5;
   
   uses_energy = true;
   energy_required = 5;
   
	triggered_effects = {
		{
			conditions = {
				{ "IfThisHasntBeenUsedThisTurn", 0 },
				{ "WhenYouPutMechanaConstructIntoPlay", 0 },
			};
			triggereffect = {
				{ "TriggerConstructOwnerDrawCards", 1 },
				{ "TriggerSetThisHasBeenUsedThisTurn", 0 },
			};
		},
	};
	construct_abilities = {
		{
			description = "Draw a Card";
			condition = { "IfConstructHasCurrentTurnEnergy", 5 },
			{ "DrawCards", 1 },

         ai = {
            trivial_draw = 1,

            gain_draw = 1,
         },
		},
	};

	effect_text = "Once per turn, when you play a Mechana Construct (including this one), draw a card.\n" ..
                  "ENERGIZE 5E: Once this turn, draw a card.";

   ai = {
      energy_threshold = 5;
   },
   
   image_large = { "MC_Portabillet", {0, 0, 364/512, 1} };
   image_medium = { "MC_Portabillet", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_Portabillet", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_Portabillet", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Prototype CH32"] = {
	card_name = "Prototype CH32";
	card_type = "Construct";
    card_set = "RoV";
	faction = "Mechana";
	rune_cost = 3;
	honor = 3;
   
   uses_energy = true;
   energy_required = 1;
   
   continuous_effects = {
      {
			conditions = {
				{ "TriggerIfHasCurrentTurnEnergyOrIsEnergized", 1 },
			};
         effect = { "MayPutAcquiredMechanaConstructIntoPlayOncePerTurn", 0 };
      },
   };

	effect_text = "ENERGIZE 1E: Once this turn, when you acquire a Mechana Construct, " ..
                     "you may put it directly into play.";

   ai = {
      energy_threshold = 1;
   },
   
   image_large = { "MC_PrototypeCH32", {0, 0, 364/512, 1} };
   image_medium = { "MC_PrototypeCH32", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_PrototypeCH32", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_PrototypeCH32", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Reactor Shrine"] = {
	card_name = "Reactor Shrine";
	card_type = "Construct";
    card_set = "RoV";
	faction = "Mechana";
	rune_cost = 8;
	honor = 8;
   
   uses_energy = true;
   energy_required = 2;
   
   construct_abilities = {
		{
			description = "Gain H";
			condition = { "IfConstructHasCurrentTurnEnergy", 2 },
			{ "GainHonorForEachMechanaConstructInPlay", 1 },
		},
	};

	effect_text = "ENERGIZE 2E: Once this turn, gain 1H for each Mechana Construct you control.";

   ai = {
      energy_threshold = 2;
   },
   
   image_large = { "MC_ReactorShrine", {0, 0, 364/512, 1} };
   image_medium = { "MC_ReactorShrine", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_ReactorShrine", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_ReactorShrine", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Skyrocket Drone"] = {
	card_name = "Skyrocket Drone";
	card_type = "Hero";
    card_set = "RoV";
	faction = "Mechana";
	rune_cost = 1;
	honor = 1;
   
	effects = {
		{ "GainRunes", 1 },
		{ "GainRunes", 1, condition={"IfYouControlConstructs",1} },
   };

	effect_text = "Gain 1R and an additional 1R if you control a Construct.";

   ai = {
      gain_rune = 1;
   },
   
   image_large = { "MH_SkyrocketDrone", {0, 0, 364/512, 1} };
   image_medium = { "MH_SkyrocketDrone", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_SkyrocketDrone", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_SkyrocketDrone", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Zeta Arsenal"] = {
	card_name = "Zeta Arsenal";
	card_type = "Construct";
    card_set = "RoV";
	faction = "Mechana";
	rune_cost = 6;
	honor = 6;
   
   uses_energy = true;
   energy_required = 3;
   
   construct_abilities = {
		{
			description = "Gain P";
			condition = { "IfConstructHasCurrentTurnEnergy", 3 },
			{ "GainPowerForEachMechanaConstructInPlay", 1 },

		},
	};

	effect_text = "ENERGIZE 3E: Once this turn, gain 1P for each Mechana Construct you control.";

   ai = {
      energy_threshold = 3;
   },
   
   image_large = { "MC_ZetaArsenal", {0, 0, 364/512, 1} };
   image_medium = { "MC_ZetaArsenal", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_ZetaArsenal", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_ZetaArsenal", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}





g_ascension_cards["Blackwatch Vanquisher"] = {
	card_name = "Blackwatch Vanquisher";
	card_type = "Hero";
    card_set = "RoV";
	faction = "Void";
	rune_cost = 4;
	honor = 2;
   
   uses_energy = true;
   energy_required = 3;
   
	effects = {
		{ "GainPower", 2 },
		{ "GainPower", 2, condition={"IfHasCurrentTurnEnergy",3} },
      { "EnergizeThisCard", 3 },
   };

	effect_text = "Gain 2P.\n" ..
                  "ENERGIZE 3E: Gain an additional 2P.";

   ai = {
      energy_threshold = 3;
      
      gain_power = 4;
   },
   
   image_large = { "VH_BlackwaterVanquisher", {0, 0, 364/512, 1} };
   image_medium = { "VH_BlackwaterVanquisher", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_BlackwaterVanquisher", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_BlackwaterVanquisher", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Darkwalker"] = {
	card_name = "Darkwalker";
	card_type = "Hero";
    card_set = "RoV";
	faction = "Void";
	rune_cost = 3;
	honor = 2;
   
   uses_energy = true;
   energy_required = 1;
   
	effects = {
		{ "GainPower", 2 },
		{ "BanishFromHandOrDiscard", 1, condition={"IfHasCurrentTurnEnergy",1} },
      { "EnergizeThisCard", 1 },
   };

	effect_text = "Gain 2P.\n" ..
                  "ENERGIZE 1E: You may banish a card in your hand or discard pile.";

   ai = {
      energy_threshold = 1;
      
      gain_power = 2;
   },
   
   image_large = { "VH_Darkwalker", {0, 0, 364/512, 1} };
   image_medium = { "VH_Darkwalker", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_Darkwalker", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_Darkwalker", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Illiya the Demonborn"] = {
	card_name = "Illiya the Demonborn";
	card_type = "Hero";
    card_set = "RoV";
	faction = "Void";
	rune_cost = 7;
	honor = 4;
   
   uses_energy = true;
   energy_required = 1;
   
	effects = {
		{ "GainPower", 4 },
		{ "GainPowerForCurrentTurnEnergy", 1, condition={"IfHasCurrentTurnEnergy",1} },
      { "EnergizeThisCard", 1 },
   };

	effect_text = "Gain 4P.\n" ..
                  "ENERGIZE: Gain an additional 1P for each 1E you have gained this turn.";

   ai = {
      energy_threshold = 1;
      
      gain_power = 4;
   },
   
   image_large = { "VH_IlliyaDemonborn", {0, 0, 364/512, 1} };
   image_medium = { "VH_IlliyaDemonborn", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_IlliyaDemonborn", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_IlliyaDemonborn", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Nyxian Spiritcaster"] = {
	card_name = "Nyxian Spiritcaster";
    card_set = "RoV";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 6;
	honor = 3;
   
   uses_energy = true;

	effects = {
		{ "GainEnergy", 3 },
		{ "DrawCards", 1 },
	};

	effect_text = "Gain 3E.\n" ..
                  "Draw a card.";

   ai = {
      trivial_draw = 1;

      gain_draw = 1;
      gain_energy = 3;
   },
   
   image_large = { "VH_NyxianSpiritcaster", {0, 0, 364/512, 1} };
   image_medium = { "VH_NyxianSpiritcaster", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_NyxianSpiritcaster", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_NyxianSpiritcaster", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Spirit Merchant"] = {
	card_name = "Spirit Merchant";
    card_set = "RoV";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 1;
	honor = 1;
   
   uses_energy = true;

	center_row = { "EachPlayerMayBanishForTreasureUnderCenterRow", 1 },

	effects = {
		{ "GainEnergy", 1 },
		{ "BanishFromHandOrDiscard", 1 },
   };

	--effect_text = "FATE: When this enters the center row, for each Treasure under this, " ..
    --                 "each player may banish a card in their hand or discard pile.\n" ..
    --              "Gain 1E.\n" ..
    --              "You may banish a card in your hand or discard pile.";
	fate_text = "FATE: When this enters the center row, for each Treasure under this, " ..
                     "each player may banish a card in their hand or discard pile.";
	effect_text = "Gain 1E.\n" ..
                  "You may banish a card in your hand or discard pile.";

   ai = {
      gain_energy = 1;
   },
   
   image_large = { "VH_SpiritMerchant", {0, 0, 364/512, 1} };
   image_medium = { "VH_SpiritMerchant", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_SpiritMerchant", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_SpiritMerchant", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Tome of Erabus"] = {
	card_name = "Tome of Erabus";
    card_set = "RoV";
	card_type = "Construct";
	faction = "Void";
	rune_cost = 4;
	honor = 2;
   
   uses_energy = true;

   construct_ability = {
		description = "Gain 1E";
		{ "GainEnergy", 1 },
      
      ai = {
         trivial = true,
      },
	};

	effect_text = "Once per turn, gain 1E.";

   ai = {
      gain_energy = 1;
   },
   
   image_large = { "VC_TomeErabus", {0, 0, 364/512, 1} };
   image_medium = { "VC_TomeErabus", {392/512, 0, 512/512, 168/512} };
   image_small = { "VC_TomeErabus", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VC_TomeErabus", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_active_effects["defeat monster with treasure costs 1 less"] = {
	type = "continuous";
	effectfunc = { "ReduceDefeatMonsterWithTreasureCost", 1 };
}

g_ascension_cards["Treasure Hunter"] = {
	card_name = "Treasure Hunter";
    card_set = "RoV";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 2;
	honor = 1;
   
	effects = {
		{ "GainPower", 2 },
		{ "NextMonsterWithTreasureYouDefeatCostsLess", 1 },
	};

	effect_text = "Gain 2P.\n" ..
                  "You may pay 1P less the next time you defeat a Monster " ..
                  "with Treasure under it this turn.";

   ai = {
      gain_power = 2;
   },
   
   image_large = { "VH_TreasureHunter", {0, 0, 364/512, 1} };
   image_medium = { "VH_TreasureHunter", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_TreasureHunter", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_TreasureHunter", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Voidfeeder"] = {
	card_name = "Voidfeeder";
    card_set = "RoV";
	card_type = "Construct";
	faction = "Void";
	rune_cost = 5;
	honor = 3;
   
   uses_energy = true;
   energy_required = 2;
   
	construct_abilities = {
		{
         description = "Gain 1P";
         { "GainPower", 1 },
         
         ai = {
            trivial = true,
         },
		},
		{
         description = "Banish";
			condition = { "IfConstructHasCurrentTurnEnergy", 2 },
         { "BanishFromHandOrDiscard", 0 },
		},
	};

	effect_text = "Once per turn, gain 1P.\n" ..
                  "ENERGIZE 2E: Once this turn, you may banish a card in your hand or discard pile.";

   ai = {
      energy_threshold = 2;
      
      gain_power = 1;
   },
   
   image_large = { "VC_Voidfeeder", {0, 0, 364/512, 1} };
   image_medium = { "VC_Voidfeeder", {392/512, 0, 512/512, 168/512} };
   image_small = { "VC_Voidfeeder", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VC_Voidfeeder", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}





g_ascension_cards["Deviant Fiend"] = {
	card_name = "Deviant Fiend";
    card_set = "RoV";
	card_type = "Monster";
	power_cost = 5;
   
   uses_energy = true;
   energy_required = 1;
   
	rewards = {
		{ "GainHonor", 3 },
		{ "GainHonorForCurrentTurnEnergy", 1, condition={"IfHasCurrentTurnEnergy",1} },
	};

	effect_text = "REWARD: Gain 3H.\n" ..
                  "ENERGIZE: Gain an additional 1H for each 1E you have gained this turn.";

   ai = {
   },
   
   image_large = { "M_DeviantFiend", {0, 0, 364/512, 1} };
   image_medium = { "M_DeviantFiend", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_DeviantFiend", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_DeviantFiend", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "deviant_fiend" };

   rarity_count = 3
}


g_ascension_cards["Firestorm Effigy"] = {
	card_name = "Firestorm Effigy";
    card_set = "RoV";
	card_type = "Monster";
	power_cost = 4;
   
   uses_energy = true;
   energy_required = 1;
   
	rewards = {
		{ "GainHonor", 3 },
      { "BanishFromHandOrDiscard", 1 },
		{ "BanishFromHandOrDiscard", 1, condition={"IfHasCurrentTurnEnergy",1} },
	};

	effect_text = "REWARD: Gain 3H. You may banish a card in your hand or discard pile.\n" ..
                  "ENERGIZE 1E: You may banish an additional card in your hand or discard pile.";

   ai = {
   },
   
   image_large = { "M_FirestormEffigy", {0, 0, 364/512, 1} };
   image_medium = { "M_FirestormEffigy", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_FirestormEffigy", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_FirestormEffigy", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "firestorm_effigy" };

   rarity_count = 4
}


g_ascension_cards["Herald of Doom"] = {
	card_name = "Herald of Doom";
    card_set = "RoV";
	card_type = "Monster";
	power_cost = 8;
   
   uses_energy = true;
   energy_required = 7;
   
	rewards = {
		{ "GainHonor", 6 },
		{ "AcquireOrDefeatAllCardsInCenterRow", 0, condition={"IfHasCurrentTurnEnergy",7} },
		{ "AcquireOrDefeatAnyCenterRow", 0, condition={"IfDoesNotHaveCurrentTurnEnergy",7} },
	};

	effect_text = "REWARD: Gain 6H. Acquire or defeat a card in the center row without paying its cost.\n" ..
                  "ENERGIZE 7E: Instead, acquire and defeat all cards in the center row without paying their costs.";

   ai = {
   },
   
   image_large = { "M_HeraldDoom", {0, 0, 364/512, 1} };
   image_medium = { "M_HeraldDoom", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_HeraldDoom", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_HeraldDoom", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "herald_of_doom" };

   rarity_count = 1
}


g_ascension_cards["Lagoon Troll"] = {
	card_name = "Lagoon Troll";
    card_set = "RoV";
	card_type = "Monster";
	power_cost = 3;
   
	rewards = {
		{ "GainHonor", 2 },
		{ "DrawCards", 1 },
	};

	effect_text = "REWARD: Gain 2H. Draw a card.";

   ai = {
   },
   
   image_large = { "M_LagoonTroll", {0, 0, 364/512, 1} };
   image_medium = { "M_LagoonTroll", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_LagoonTroll", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_LagoonTroll", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "lagoon_troll" };

   rarity_count = 3
}


g_ascension_cards["Mordant Widow"] = {
	card_name = "Mordant Widow";
    card_set = "RoV";
	card_type = "Monster";
	power_cost = 5;
   
	rewards = {
		{ "GainHonor", 4 },
		{ "DestroyConstructForEachOpponent", 0 },
	};

	effect_text = "REWARD: Gain 4H. For each opponent, you choose and destroy a Construct they control.";

   ai = {
   },
   
   image_large = { "M_MordantWidow", {0, 0, 364/512, 1} };
   image_medium = { "M_MordantWidow", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_MordantWidow", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_MordantWidow", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "mordant_widow" };

   rarity_count = 3
}


g_ascension_cards["Protean Sea Slug"] = {
	card_name = "Protean Sea Slug";
    card_set = "RoV";
	card_type = "Monster";
	power_cost = 6;
   
	rewards = {
		{ "GainHonor", 5 },
		{ "EachOpponentDestroysAllConstructsInPlay", 0 },
	};

	effect_text = "REWARD: Gain 5H. Each opponent destroys all Constructs they control.";

   ai = {
   },
   
   image_large = { "M_ProteanSeaSlug", {0, 0, 364/512, 1} };
   image_medium = { "M_ProteanSeaSlug", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_ProteanSeaSlug", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_ProteanSeaSlug", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "protean_sea_slug" };

   rarity_count = 1
}


g_ascension_cards["Raging Ursine"] = {
	card_name = "Raging Ursine";
    card_set = "RoV";
	card_type = "Monster";
	power_cost = 3;
   
   uses_energy = true;
   energy_required = 2;
   
	rewards = {
		{ "GainHonor", 3 },
		{ "GainRunes", 2, condition={"IfHasCurrentTurnEnergy",2} },
	};

	effect_text = "REWARD: Gain 3H.\n" ..
                  "ENERGIZE 2E: Gain 2R.";

   ai = {
   },
   
   image_large = { "M_RagingUrsine", {0, 0, 364/512, 1} };
   image_medium = { "M_RagingUrsine", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_RagingUrsine", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_RagingUrsine", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "raging_ursine" };

   rarity_count = 3
}


g_ascension_cards["Serpent Siren"] = {
	card_name = "Serpent Siren";
    card_set = "RoV";
	card_type = "Monster";
	power_cost = 2;
   trophy_monster = true;
   
   uses_energy = true;

	rewards = {
		{ "GainHonor", 1 },
	};
	trophy_effects = {
		{ "GainEnergy", 1 },
      { "BanishThisTrophy", 0 },
	};

	--effect_text = "REWARD: Gain 1H.\n" ..
    --              "TROPHY: You may banish this to gain 1E.";
	effect_text = "REWARD: Gain 1H.";
	trophy_text = "<color=#951719FF><B>Trophy:</B></color> You may banish this to gain 1E.";
				  
   ai = {
      gain_energy = 1;
   },
   
   image_large = { "M_SerpentSiren", {0, 0, 364/512, 1} };
   image_medium = { "M_SerpentSiren", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_SerpentSiren", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_SerpentSiren", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "serpent_siren" };

   rarity_count = 3
}


g_ascension_cards["Terrus, Paragon of Strife"] = {
	card_name = "Terrus, Paragon of Strife";
    card_set = "RoV";
	card_type = "Monster";
	power_cost = 7;
   
	rewards = {
		{ "GainHonor", 5 },
		{ "TakeCardFromEachOpponentDiscard", 0 },
	};

	effect_text = "REWARD: Gain 5H. Each opponent discards a random card from their hand. " ..
                  "You may choose a card discarded this way and put it in your hand.";

   ai = {
   },
   
   image_large = { "M_TerrusParagonStrife", {0, 0, 364/512, 1} };
   image_medium = { "M_TerrusParagonStrife", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_TerrusParagonStrife", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_TerrusParagonStrife", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "terrus-paragon-of strife" };

   rarity_count = 1
}


g_ascension_cards["Twisted Tyrant"] = {
	card_name = "Twisted Tyrant";
    card_set = "RoV";
	card_type = "Monster";
	power_cost = 6;
   
   uses_energy = true;
   energy_required = 3;

	rewards = {
		{ "GainHonor", 6 },
		{ "DrawCards", 3, condition={"IfHasCurrentTurnEnergy",3} },
	};

	effect_text = "REWARD: Gain 6H.\n" ..
                  "ENERGIZE 3E: Draw three cards.";

   ai = {
   },
   
   image_large = { "M_TwistedTyrant", {0, 0, 364/512, 1} };
   image_medium = { "M_TwistedTyrant", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_TwistedTyrant", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_TwistedTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "twisted_tyrant" };

   rarity_count = 2
}


g_ascension_cards["Vault Sphinx"] = {
	card_name = "Vault Sphinx";
    card_set = "RoV";
	card_type = "Monster";
	power_cost = 4;
   trophy_monster = true;
   
   uses_energy = true;

	rewards = {
		{ "GainHonor", 2 },
	};
	trophy_effects = {
		{ "GainEnergy", 2 },
      { "BanishThisTrophy", 0 },
	};

	--effect_text = "REWARD: Gain 2H.\n" ..
    --              "TROPHY: You may banish this to gain 2E.";
	effect_text = "REWARD: Gain 2H.";
	trophy_text = "<color=#951719FF><B>Trophy:</B></color> You may banish this to gain 2E.";

   ai = {
      gain_energy = 2;
   },
   
   image_large = { "M_VaultSphinx", {0, 0, 364/512, 1} };
   image_medium = { "M_VaultSphinx", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_VaultSphinx", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_VaultSphinx", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "vault_sphinx" };

   rarity_count = 4
}





