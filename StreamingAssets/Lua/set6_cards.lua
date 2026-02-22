


g_ascension_cards["Dark Energy Shard"] = {
	card_name = "Dark Energy Shard";
	card_type = "Treasure";
	card_set = "DU";
	honor = 0;
   energy_required = 99;

	center_row = { "EachPlayerMayBanishFromDiscard", 1 },

	effects = {
		{ "GainEnergy", 1 },
		{ "DrawCards", 1 },
	};

	--effect_text = "FATE: Each player may banish a card in their discard pile.\n" ..
    --              "Gain 1E. Draw a card.";
	fate_text = "FATE: Each player may banish a card in their discard pile.";
	effect_text = "Gain 1E. Draw a card.";

   ai = {
      trivial_draw = 1;

      gain_draw = 1;
      gain_energy = 1;
   },
   
   image_large = { "T_DarkEnergyShard", {0, 0, 364/512, 1} };
   image_medium = { "T_DarkEnergyShard", {392/512, 0, 512/512, 168/512} };
   image_small = { "T_DarkEnergyShard", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "T_DarkEnergyShard", {384/512, 395/512, 512/512, 512/512} };
}





g_ascension_active_effects["acquire hero or construct from center row into hand"] = {
	type = "continuous";
   conditions = {
      { "IfThisHasntBeenUsedThisTurn", 0 },
   };
	effectfunc = { "MayPutAcquiredHeroOrConstructFromCenterRowIntoHand", 1 };
}

g_ascension_cards["Anointed Askara"] = {
	card_name = "Anointed Askara";
    card_set = "DU";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 5;
	honor = 3;
   
	effects = {
      { "DrawCards", 1 },
		{ "AcquireHeroOrContructFromCenterRowIntoHandThisTurn", 0 },
   };

	effect_text = "Draw a card.\n" ..
                  "Once this turn, when you acquire a Hero or Consruct from the center row, " ..
                     "put it into your hand.";

   ai = {
      trivial_draw = 1;

      gain_draw = 1;
   },
   
   image_large = { "EH_AnointedAskara", {0, 0, 364/512, 1} };
   image_medium = { "EH_AnointedAskara", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_AnointedAskara", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_AnointedAskara", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Arha Mentor"] = {
	card_name = "Arha Mentor";
    card_set = "DU";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 4;
	honor = 2;
   
   uses_energy = true;
   energy_required = 2;
   
	effects = {
      { "DrawCards", 1, condition={"IfHasCurrentTurnEnergy",2} },
		{ "BanishFromHand", 1 },
		{ "AcquireMysticOrHeavyInfantryToHand", 0, condition={"IfYouDo",1} },
      { "EnergizeThisCard", 2 },
   };
	effect_text = "ENERGIZE 2E: Draw a card.\n" ..
                  "You may banish a card from your hand. " ..
                     "If you do, acquire a Mystic or Heavy Infantry without paying its cost " ..
                     "and put it into your hand.";

   ai = {
      gain_draw = 1;
      energy_threshold = 2;
   },
   
   image_large = { "EH_ArhaMentor", {0, 0, 364/512, 1} };
   image_medium = { "EH_ArhaMentor", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_ArhaMentor", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_ArhaMentor", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Shardfinder Compass"] = {
	card_name = "Shardfinder Compass";
    card_set = "DU";
	card_type = "Construct";
	faction = "Enlightened";
	rune_cost = 3;
	honor = 1;
   
   uses_energy = true;

	construct_ability = {
		description = "Acquire All Treasure";
      condition = { "IfThereIsTreasureInCenterRow", 0 },
		{ "BanishThisConstruct", 0 },
		{ "AcquireAllCenterRowTreasure", 0 },

      ai = {
         use_at_end_of_turn = true,
      },
	};

	effect_text = "You may banish this to acquire all of the Treasures in the center row.";

   ai = {
   },
   
   image_large = { "EC_ShardfinderCompass", {0, 0, 364/512, 1} };
   image_medium = { "EC_ShardfinderCompass", {392/512, 0, 512/512, 168/512} };
   image_small = { "EC_ShardfinderCompass", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EC_ShardfinderCompass", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Valiant Ascetic"] = {
	card_name = "Valiant Ascetic";
    card_set = "DU";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 2;
	honor = 1;
   
   effects = {
		{ "YouMayBanishThisCard", 0 },
		{ "DefeatMonsterWithLessPower", 5, condition={"IfYouDo",0}  },
	};

	effect_text = "You may banish this to defeat a Monster with cost 5P or less without paying its cost.";

   ai = {
      defeat_monster = 5;
   },
   
   image_large = { "EH_ValiantAscetic", {0, 0, 364/512, 1} };
   image_medium = { "EH_ValiantAscetic", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_ValiantAscetic", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_ValiantAscetic", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Veya, Handmaiden of Logos"] = {
	card_name = "Veya, Handmaiden of Logos";
    card_set = "DU";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 7;
	honor = 4;
   
   uses_energy = true;
   energy_required = 2;
   
	effects = {
		{ "AcquireHeroAndDefeatMonster", 6, condition={"IfHasCurrentTurnEnergy",2} },
		{ "AcquireHeroOrDefeatMonster", 6, condition={"IfDoesNotHaveCurrentTurnEnergy",2} },
      { "EnergizeThisCard", 2 },
	};

	effect_text = "Choose one: Acquire a Hero with cost 6R or less without paying its cost, " ..
                     "or defeat a Monster with cost 6P or less without paying its cost.\n" ..
                  "ENERGIZE 2E: Instead, you may choose both.";

   ai = {
      energy_threshold = 2;
   },
   
   image_large = { "EH_VeyaHandmaidenLogos", {0, 0, 364/512, 1} };
   image_medium = { "EH_VeyaHandmaidenLogos", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_VeyaHandmaidenLogos", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_VeyaHandmaidenLogos", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Gemcatcher Spirit"] = {
	card_name = "Gemcatcher Spirit";
    card_set = "DU";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 2;
	honor = 1;
   
   uses_energy = true;
   energy_required = 2;

	effects = {
      { "PauseForAnimation", 0, condition={"IfHasCurrentTurnEnergyAndIsNotCopy",2} },
      { "TransformIntoOtherworldlyGuide", 0, condition={"IfHasCurrentTurnEnergyAndIsNotCopy",2} },
      { "DrawCards", 1, condition={"IfDoesNotHaveCurrentTurnEnergyOrIsCopy",2} },
   };
   transform = {
      usageconditions = {
         { "IfHasCurrentTurnEnergy", 2 },
      },
      { "PauseForAnimation", 0 },
      { "TransformIntoOtherworldlyGuide", 0 },
   };
   transform_into = "Otherworldly Guide";

	effect_text = "ENERGIZE 2E: Transform this into Otherworldly Guide. " ..
                     "(Ignore the rest of this card's effect.)\n" ..
                  "Draw a card.";

   ai = {
      gain_draw = 1;
      energy_threshold = 2;
   },
   
   image_large = { "EH_GemcatcherSpirit", {0, 0, 364/512, 1} };
   image_medium = { "EH_GemcatcherSpirit", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_GemcatcherSpirit", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_GemcatcherSpirit", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Otherworldly Guide"] = {
	card_name = "Otherworldly Guide";
    card_set = "DU";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 2;
	honor = 3;
   
   use_transformed_frame = true;

   transform_from = "Gemcatcher Spirit";

	effects = {
      { "DrawCards", 2 },
   };

	effect_text = "Draw two cards.";

   ai = {
      trivial_draw = 2;
      gain_draw = 2;
   },
   
   image_large = { "EH_OtherworldlyGuide", {0, 0, 364/512, 1} };
   image_medium = { "EH_OtherworldlyGuide", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_OtherworldlyGuide", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_OtherworldlyGuide", {384/512, 395/512, 512/512, 512/512} };

   --rarity_count = 2
}


g_ascension_cards["Toric, Devoted Disciple"] = {
	card_name = "Toric, Devoted Disciple";
    card_set = "DU";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 6;
	honor = 3;
   
   uses_energy = true;
   energy_required = 4;
      
	effects = {
      { "PauseForAnimation", 0, condition={"IfHasCurrentTurnEnergyAndIsNotCopy",4} },
      { "TransformIntoToricAscendant", 0, condition={"IfHasCurrentTurnEnergyAndIsNotCopy",4} },
      { "CopyEffectOfAnyCenterRowHero", 0, condition={"IfDoesNotHaveCurrentTurnEnergyOrIsCopy",4} },
   };
   transform = {
      usageconditions = {
         { "IfHasCurrentTurnEnergy", 4 },
      },
      { "PauseForAnimation", 0 },
      { "TransformIntoToricAscendant", 0 },
   };
   transform_into = "Toric, Ascendant";

	effect_text = "ENERGIZE 4E: Transform this into Toric, Ascendant. " ..
                     "(Ignore the rest of this card's effect.)\n" ..
                  "Copy the effect of a Hero in the center row.";

   ai = {
      energy_threshold = 4;
   },
   
   image_large = { "EH_ToricDevotedDisciple", {0, 0, 364/512, 1} };
   image_medium = { "EH_ToricDevotedDisciple", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_ToricDevotedDisciple", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_ToricDevotedDisciple", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Toric, Ascendant"] = {
	card_name = "Toric, Ascendant";
    card_set = "DU";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 6;
	honor = 5;
   
   use_transformed_frame = true;

   transform_from = "Toric, Devoted Disciple";

	effects = {
      { "AcquireHeroIntoHand", 0 },
   };

	effect_text = "Acquire a Hero without paying its cost and put it into your hand.";

   ai = {
   },
   
   image_large = { "EH_ToricAscendant", {0, 0, 364/512, 1} };
   image_medium = { "EH_ToricAscendant", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_ToricAscendant", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_ToricAscendant", {384/512, 395/512, 512/512, 512/512} };

   --rarity_count = 1
}





g_ascension_cards["Dendris the Gladewyrm"] = {
	card_name = "Dendris the Gladewyrm";
    card_set = "DU";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 6;
	honor = 3;
   
   uses_energy = true;
   energy_required = 3;
   
	effects = {
      { "GainRunes", 2 },
      { "GainPower", 2 },
      { "GainHonor", 2 },
      { "GainRunes", 2, condition={"IfHasCurrentTurnEnergy",3} },
      { "GainPower", 2, condition={"IfHasCurrentTurnEnergy",3} },
      { "GainHonor", 2, condition={"IfHasCurrentTurnEnergy",3} },
      { "EnergizeThisCard", 3 },
   };

	effect_text = "Gain 2R, 2P, and 2H.\n" ..
                  "ENERGIZE 3E: Gain an additional 2R, 2P, and 2H.";

   ai = {
      energy_threshold = 3;
      
      gain_power = 4;
      gain_rune = 4;
      gain_honor = 4;
   },
   
   image_large = { "LH_DendrisGladewyrm", {0, 0, 364/512, 1} };
   image_medium = { "LH_DendrisGladewyrm", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_DendrisGladewyrm", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_DendrisGladewyrm", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Gem-Eater Leprechaun"] = {
	card_name = "Gem-Eater Leprechaun";
    card_set = "DU";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 4;
	honor = 2;
   
   uses_energy = true;

	effects = {
      { "GainRunes", 2 },
      { "GainEnergy", 2 },
   };

	effect_text = "Gain 2R and 2E.";

   ai = {
      gain_rune = 2;
      gain_energy = 2;
   },
   
   image_large = { "LH_GemEaterLeprechaun", {0, 0, 364/512, 1} };
   image_medium = { "LH_GemEaterLeprechaun", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_GemEaterLeprechaun", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_GemEaterLeprechaun", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Moken, the Huntmaster"] = {
	card_name = "Moken, the Huntmaster";
    card_set = "DU";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 7;
	honor = 0;
   honor_value_equals_treasure = true;
   
   uses_energy = true;

	effects = {
      { "GainHonor", 5 },
   };

	effect_text = "Gain 5H.\n" ..
                  "At the end of the game, Moken, the Huntmaster's honor value is equal to " ..
                     "the number of Treasure cards in your deck.";

   ai = {
      gain_honor = 5;
   },
   
   image_large = { "LH_MokenHuntmaster", {0, 0, 364/512, 1} };
   image_medium = { "LH_MokenHuntmaster", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_MokenHuntmaster", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_MokenHuntmaster", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Mosaic Horn"] = {
	card_name = "Mosaic Horn";
    card_set = "DU";
	card_type = "Construct";
	faction = "Lifebound";
	rune_cost = 3;
	honor = 2;
   
   uses_energy = true;
   energy_required = 2;
   
	construct_abilities = {
		{
         description = "Gain 2R";
			condition = { "IfConstructHasCurrentTurnEnergy", 2 },
         { "GainRunes", 2 },
         
         ai = {
            trivial = true,
         },
		},
	};

	effect_text = "ENERGIZE 2E: Once this turn, gain 2R.";

   ai = {
   },
   
   image_large = { "LC_MosaicHorn", {0, 0, 364/512, 1} };
   image_medium = { "LC_MosaicHorn", {392/512, 0, 512/512, 168/512} };
   image_small = { "LC_MosaicHorn", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LC_MosaicHorn", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_active_effects["hero acquired costs less"] = {
	type = "continuous";
	effectfunc = { "ReduceHeroRuneCostForEffectData", 0 };
}

g_ascension_cards["Raven Siren"] = {
	card_name = "Raven Siren";
    card_set = "DU";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 3;
	honor = 1;
   
   uses_energy = true;
   energy_required = 1;
   
	effects = {
      { "GainRunes", 1 },
		{ "NextHeroYouAcquireCostsLessForCurrentEnergy", 1, condition={"IfHasCurrentTurnEnergy",1} },
      { "EnergizeThisCard", 1 },
   };

	effect_text = "Gain 1R.\n" ..
                  "ENERGIZE: You pay 1R less for each 1E you have gained this turn " ..
                     "the next time you acquire a Hero this turn.";

   ai = {
      gain_rune = 1;
   },
   
   image_large = { "LH_RavenSiren", {0, 0, 364/512, 1} };
   image_medium = { "LH_RavenSiren", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_RavenSiren", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_RavenSiren", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Honiskrot Tribesman"] = {
	card_name = "Honiskrot Tribesman";
    card_set = "DU";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 2;
	honor = 1;
   
   uses_energy = true;
   energy_required = 2;
   
	effects = {
      { "PauseForAnimation", 0, condition={"IfHasCurrentTurnEnergyAndIsNotCopy",2} },
      { "TransformIntoHoniskrotChieftain", 0, condition={"IfHasCurrentTurnEnergyAndIsNotCopy",2} },
      { "GainRunes", 1, condition={"IfDoesNotHaveCurrentTurnEnergyOrIsCopy",2} },
   };
   transform = {
      usageconditions = {
         { "IfHasCurrentTurnEnergy", 2 },
      },
      { "PauseForAnimation", 0 },
      { "TransformIntoHoniskrotChieftain", 0 },
   };
   transform_into = "Honiskrot Chieftain";

	effect_text = "ENERGIZE 2E: Transform this into Honiskrot Chieftain. " ..
                     "(Ignore the rest of this card's effect.)\n" ..
                  "Gain 1R.";

   ai = {
      gain_rune = 1;

      energy_threshold = 2;
   },
   
   image_large = { "LH_HoniskrotTribesman", {0, 0, 364/512, 1} };
   image_medium = { "LH_HoniskrotTribesman", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_HoniskrotTribesman", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_HoniskrotTribesman", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Honiskrot Chieftain"] = {
	card_name = "Honiskrot Chieftain";
    card_set = "DU";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 2;
	honor = 3;
   
   use_transformed_frame = true;

   transform_from = "Honiskrot Tribesman";

	effects = {
      { "GainRunes", 3 },
   };

	effect_text = "Gain 3R.";

   ai = {
      trivial = true;

      gain_rune = 3;
   },
   
   image_large = { "LH_HoniskrotChieftan", {0, 0, 364/512, 1} };
   image_medium = { "LH_HoniskrotChieftan", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_HoniskrotChieftan", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_HoniskrotChieftan", {384/512, 395/512, 512/512, 512/512} };

   --rarity_count = 2
}


g_ascension_cards["Jakeb, Cobra Shaman"] = {
	card_name = "Jakeb, Cobra Shaman";
    card_set = "DU";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 5;
	honor = 3;
   
   uses_energy = true;
   energy_required = 4;
   
	effects = {
      { "PauseForAnimation", 0, condition={"IfHasCurrentTurnEnergyAndIsNotCopy",4} },
      { "TransformIntoJakebCobraKing", 0, condition={"IfHasCurrentTurnEnergyAndIsNotCopy",4} },
      { "GainHonor", 3, 1, condition={"IfDoesNotHaveCurrentTurnEnergyOrIsCopy",4} },
   };
   transform = {
      usageconditions = {
         { "IfHasCurrentTurnEnergy", 4 },
      },
      { "PauseForAnimation", 0 },
      { "TransformIntoJakebCobraKing", 0 },
   };
   transform_into = "Jakeb, Cobra King";

	effect_text = "ENERGIZE 4E: Transform this into Jakeb, Cobra King. " ..
                     "(Ignore the rest of this card's effect.)\n" ..
                  "Gain 3H.";

   ai = {
      gain_honor = 3;

      energy_threshold = 4;
   },
   
   image_large = { "LH_JakebCobraShaman", {0, 0, 364/512, 1} };
   image_medium = { "LH_JakebCobraShaman", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_JakebCobraShaman", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_JakebCobraShaman", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Jakeb, Cobra King"] = {
	card_name = "Jakeb, Cobra King";
    card_set = "DU";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 5;
	honor = 5;
   
   use_transformed_frame = true;

   transform_from = "Jakeb, Cobra Shaman";

	effects = {
      { "GainHonor", 6 },
      { "SetGainHonorModifier", 2 },
   };

	effect_text = "Gain 6H.\n" ..
                  "When you gain honor from another card this turn, gain twice that much honor instead.";

   ai = {
      gain_honor = 6;
   },
   
   image_large = { "LH_JakebCobraKing", {0, 0, 364/512, 1} };
   image_medium = { "LH_JakebCobraKing", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_JakebCobraKing", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_JakebCobraKing", {384/512, 395/512, 512/512, 512/512} };

   --rarity_count = 1
}





g_ascension_cards["Charging Chamber"] = {
	card_name = "Charging Chamber";
    card_set = "DU";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 3;
	honor = 3;
   
   uses_energy = true;

	triggered_effects = {
		{
			conditions = {
				{ "IfThisHasntBeenUsedThisTurn", 0 },
				{ "WhenYouPutMechanaConstructIntoPlay", 0 },
			};
			triggereffect = {
				{ "TriggerConstructGainEnergy", 1 },
				{ "TriggerSetThisHasBeenUsedThisTurn", 0 },
			};
		},
	};

	effect_text = "Once per turn, when you play a Mechana Construct (including this one), gain 1E.";

   ai = {
   },
   
   image_large = { "MC_ChargingChamber", {0, 0, 364/512, 1} };
   image_medium = { "MC_ChargingChamber", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_ChargingChamber", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_ChargingChamber", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Crystalline Monk"] = {
	card_name = "Crystalline Monk";
    card_set = "DU";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 4;
	honor = 2;
   
   uses_energy = true;

	effects = {
      { "GainRunes", 2 },
      { "MoveTreasureCardInCenterRow", 0 },
   };

	effect_text = "Gain 2R.\n" ..
                  "You may move a Treasure from underneath a card in the center row " ..
                     "to another card in the center row.";

   ai = {
      gain_rune = 2;
   },
   
   image_large = { "MH_CrystallineMonk", {0, 0, 364/512, 1} };
   image_medium = { "MH_CrystallineMonk", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_CrystallineMonk", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_CrystallineMonk", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Hedron Dredger"] = {
	card_name = "Hedron Dredger";
    card_set = "DU";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 5;
	honor = 5;
   
   uses_energy = true;

	construct_abilities = {
		{
			description = "Energize Construct";
			condition = { "IfYouControlMechanaConstructsAndHaveUnenergizedConstruct", 3 },
			{ "PushResolvingConstruct", 0 },
			{ "EnergizeConstruct", 0 },
			{ "PopResolvingConstruct", 0 },
		},
	};

	effect_text = "Once per turn, if you control three or more Mechana Constructs, " ..
                  "you may Energize a Construct you control.";

   ai = {
   },
   
   image_large = { "MC_HedronDredger", {0, 0, 364/512, 1} };
   image_medium = { "MC_HedronDredger", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_HedronDredger", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_HedronDredger", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Replication Drone"] = {
	card_name = "Replication Drone";
    card_set = "DU";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 4;
	honor = 4;
   
   construct_count_value = 2;

	effect_text = "You are considered to control an additional Mechana Construct.";

   ai = {
   },
   
   image_large = { "MC_ReplicationDrone", {0, 0, 364/512, 1} };
   image_medium = { "MC_ReplicationDrone", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_ReplicationDrone", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_ReplicationDrone", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Scrap Scrabbler"] = {
	card_name = "Scrap Scrabbler";
    card_set = "DU";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 2;
	honor = 1;
   
   uses_energy = true;
   energy_required = 2;
   
	effects = {
      { "PauseForAnimation", 0, condition={"IfHasCurrentTurnEnergyAndIsNotCopy",2} },
      { "TransformIntoScrabblingSquad", 0, condition={"IfHasCurrentTurnEnergyAndIsNotCopy",2} },
      { "GainRunes", 1, condition={"IfDoesNotHaveCurrentTurnEnergyOrIsCopy",2} },
      { "GainPower", 1, condition={"IfDoesNotHaveCurrentTurnEnergyOrIsCopy",2} },
   };
   transform = {
      usageconditions = {
         { "IfHasCurrentTurnEnergy", 2 },
      },
      { "PauseForAnimation", 0 },
      { "TransformIntoScrabblingSquad", 0 },
   };
   transform_into = "Scrabbling Squad";

	effect_text = "ENERGIZE 2E: Transform this into Scrabbling Squad. " ..
                     "(Ignore the rest of this card's effect.)\n" ..
                  "Gain 1R and 1P.";

   ai = {
      gain_rune = 1;
      gain_power = 1;
      
      energy_threshold = 2;
   },
   
   image_large = { "MH_ScrapScrabbler", {0, 0, 364/512, 1} };
   image_medium = { "MH_ScrapScrabbler", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_ScrapScrabbler", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_ScrapScrabbler", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Scrabbling Squad"] = {
	card_name = "Scrabbling Squad";
    card_set = "DU";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 2;
	honor = 3;
   
   use_transformed_frame = true;

   transform_from = "Scrap Scrabbler";
   
	effects = {
      { "GainRunes", 2 },
      { "GainPower", 2 },
   };

	effect_text = "Gain 2R and 2P.";

   ai = {
      gain_rune = 2;
      gain_power = 2;
      
      trivial = true;
   },
   
   image_large = { "MH_ScrabblingSquad", {0, 0, 364/512, 1} };
   image_medium = { "MH_ScrabblingSquad", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_ScrabblingSquad", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_ScrabblingSquad", {384/512, 395/512, 512/512, 512/512} };

   --rarity_count = 2
}


g_ascension_cards["Yolothian Monolith"] = {
	card_name = "Yolothian Monolith";
    card_set = "DU";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 8;
	honor = 8;
   
   uses_energy = true;
   energy_required = 4;
   
	construct_abilities = {
		{
         description = "Transform";
			condition = { "IfConstructHasCurrentTurnEnergy", 4 },
         { "PushResolvingConstruct", 0 },
         { "PauseForAnimation", 0 },
         { "TransformThisConstructIntoYolocryx", 2 },
         
         ai = {
            trivial = true,
         },
		},
	};
   transform_into = "Yolocryx, the Guardian";

	effect_text = "ENERGIZE 4E: Transform this into Yolocryx, the Guardian and put it into your hand.";

   ai = {
   },
   
   image_large = { "MC_YolothianMonolith", {0, 0, 364/512, 1} };
   image_medium = { "MC_YolothianMonolith", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_YolothianMonolith", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_YolothianMonolith", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Yolocryx, the Guardian"] = {
	card_name = "Yolocryx, the Guardian";
    card_set = "DU";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 8;
	honor = 8;
   
   use_transformed_frame = true;

   transform_from = "Yolothian Monolith";

	effects = {
      { "GainPower", 5 },
      { "GainPowerForEachMechanaConstructInPlay", 1 },
   };

   global_triggered_effects = {
		{
			conditions = {
				{ "WhenPlayerPutsMechanaConstructIntoPlay", 0 },
            { "IfThisCardIsInEventPlayerDiscardPile", 0 },
			};
			triggereffect = {
				{ "TriggerPutEffectSourceFromDiscardIntoHand", 0 },
			};
		},
	};

	effect_text = "Gain 5P and an additional 1P for each Mechana Construct you control.\n" ..
                  "When you play a Mechana Construct, you may return this from your discard pile to your hand.";

   ai = {
      gain_power = 5;
   },
   
   image_large = { "MH_YolocryxGuardian", {0, 0, 364/512, 1} };
   image_medium = { "MH_YolocryxGuardian", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_YolocryxGuardian", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_YolocryxGuardian", {384/512, 395/512, 512/512, 512/512} };

   --rarity_count = 1
}





g_ascension_cards["Arbiter of the Lost"] = {
	card_name = "Arbiter of the Lost";
    card_set = "DU";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 4;
	honor = 3;
   
   uses_energy = true;

	effects = {
		{ "GainEnergy", 2 },
		{ "BanishFromHandOrDiscard", 1 },
   };

	effect_text = "Gain 2E.\n" ..
                  "You may banish a card in your hand or discard pile.";

   ai = {
      gain_energy = 2;
   },
   
   image_large = { "VH_ArbiterLost", {0, 0, 364/512, 1} };
   image_medium = { "VH_ArbiterLost", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_ArbiterLost", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_ArbiterLost", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_active_effects["monster defeated may banish"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouDefeatMonsterFromCenterRow", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerEffectPlayerBanishFromHandOrDiscard", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

g_ascension_cards["Nightmare Sentinel"] = {
	card_name = "Nightmare Sentinel";
    card_set = "DU";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 3;
	honor = 2;
   
	effects = {
		{ "GainPower", 2 },
		{ "NextMonsterYouDefeatFromCenterRowMayBanishCard", 1 },
   };

	effect_text = "Gain 2P.\n" ..
                  "The next time you defeat a Monster in the center row this turn, " ..
                     "you may banish a card in your hand or discard pile.";

   ai = {
      gain_power = 2;
   },
   
   image_large = { "VH_NightmareSentinel", {0, 0, 364/512, 1} };
   image_medium = { "VH_NightmareSentinel", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_NightmareSentinel", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_NightmareSentinel", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Nyxian Ritualist"] = {
	card_name = "Nyxian Ritualist";
    card_set = "DU";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 5;
	honor = 3;
   
   uses_energy = true;

	effects = {
		{ "GainPower", 3 },
		{ "GainEnergy", 3 },
   };

	effect_text = "Gain 3P and 3E.";

   ai = {
      gain_power = 3;
      gain_energy = 3;
   },
   
   image_large = { "VH_NyxianRitualist", {0, 0, 364/512, 1} };
   image_medium = { "VH_NyxianRitualist", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_NyxianRitualist", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_NyxianRitualist", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Riftwalker's Axe"] = {
	card_name = "Riftwalker's Axe";
    card_set = "DU";
	card_type = "Construct";
	faction = "Void";
	rune_cost = 3;
	honor = 2;
   
   uses_energy = true;
   energy_required = 2;
   
	construct_abilities = {
		{
         description = "Gain 2P";
			condition = { "IfConstructHasCurrentTurnEnergy", 2 },
         { "GainPower", 2 },
         
         ai = {
            trivial = true,
         },
		},
	};

	effect_text = "ENERGIZE 2E: Once this turn, gain 2P.";

   ai = {
   },
   
   image_large = { "VC_RiftwalkersAxe", {0, 0, 364/512, 1} };
   image_medium = { "VC_RiftwalkersAxe", {392/512, 0, 512/512, 168/512} };
   image_small = { "VC_RiftwalkersAxe", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VC_RiftwalkersAxe", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Voidsworn Warrior"] = {
	card_name = "Voidsworn Warrior";
    card_set = "DU";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 2;
	honor = 1;
   
   uses_energy = true;
   energy_required = 2;
   
	effects = {
      { "PauseForAnimation", 0, condition={"IfHasCurrentTurnEnergyAndIsNotCopy",2} },
      { "TransformIntoVoidswornChampion", 0, condition={"IfHasCurrentTurnEnergyAndIsNotCopy",2} },
      { "GainPower", 1, condition={"IfDoesNotHaveCurrentTurnEnergyOrIsCopy",2} },
   };
   transform = {
      usageconditions = {
         { "IfHasCurrentTurnEnergy", 2 },
      },
      { "PauseForAnimation", 0 },
      { "TransformIntoVoidswornChampion", 0 },
   };
   transform_into = "Voidsworn Champion";

	effect_text = "ENERGIZE 2E: Transform this into Voidsworn Champion. " ..
                     "(Ignore the rest of this card's effect.)\n" ..
                  "Gain 1P.";

   ai = {
      gain_power = 1;
      
      energy_threshold = 2;
   },
   
   image_large = { "VH_VoidswornWarrior", {0, 0, 364/512, 1} };
   image_medium = { "VH_VoidswornWarrior", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_VoidswornWarrior", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_VoidswornWarrior", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Voidsworn Champion"] = {
	card_name = "Voidsworn Champion";
    card_set = "DU";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 2;
	honor = 3;
   
   use_transformed_frame = true;

   transform_from = "Voidsworn Warrior";

	effects = {
		{ "GainPower", 4 },
   };

	effect_text = "Gain 4P.";

   ai = {
      trivial = true;
      gain_power = 4;
   },
   
   image_large = { "VH_VoidswornChampion", {0, 0, 364/512, 1} };
   image_medium = { "VH_VoidswornChampion", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_VoidswornChampion", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_VoidswornChampion", {384/512, 395/512, 512/512, 512/512} };

   --rarity_count = 2
}


g_ascension_cards["Azerax of the Black Watch"] = {
	card_name = "Azerax of the Black Watch";
    card_set = "DU";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 7;
	honor = 3;
   
   uses_energy = true;
   energy_required = 4;
   
	effects = {
      { "PauseForAnimation", 0, condition={"IfHasCurrentTurnEnergyAndIsNotCopy",4} },
      { "TransformIntoAzeraxNyxsChosen", 0, condition={"IfHasCurrentTurnEnergyAndIsNotCopy",4} },
		{ "GainPower", 4, condition={"IfDoesNotHaveCurrentTurnEnergyOrIsCopy",4} },
		{ "BanishFromHandOrDiscard", 1, condition={"IfDoesNotHaveCurrentTurnEnergyOrIsCopy",4} },
   };
   transform = {
      usageconditions = {
         { "IfHasCurrentTurnEnergy", 4 },
      },
      { "PauseForAnimation", 0 },
      { "TransformIntoAzeraxNyxsChosen", 0 },
   };
   transform_into = "Azerax, Nyx's Chosen";

	effect_text = "ENERGIZE 4E: Transform this into Azerax, Nyx's Chosen. " ..
                     "(Ignore the rest of this card's effect.)\n" ..
                  "Gain 4P.\n" ..
                  "You may banish a card in your hand or discard pile.";

   ai = {
      gain_power = 4;
      
      energy_threshold = 4;
   },
   
   image_large = { "VH_AzeraxBlackWatch", {0, 0, 364/512, 1} };
   image_medium = { "VH_AzeraxBlackWatch", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_AzeraxBlackWatch", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_AzeraxBlackWatch", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Azerax, Nyx's Chosen"] = {
	card_name = "Azerax, Nyx's Chosen";
    card_set = "DU";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 7;
	honor = 5;
   
   use_transformed_frame = true;

   transform_from = "Azerax of the Black Watch";

	effects = {
		{ "GainPower", 6 },
      { "BanishAnyNumberFromHandOrDiscard", 0 },
   };

	effect_text = "Gain 6P.\n" ..
                  "You may banish any number of cards in your hand and/or discard pile.";

   ai = {
      gain_power = 6;
   },
   
   image_large = { "VH_AzeraxNyxChosen", {0, 0, 364/512, 1} };
   image_medium = { "VH_AzeraxNyxChosen", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_AzeraxNyxChosen", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_AzeraxNyxChosen", {384/512, 395/512, 512/512, 512/512} };

   --rarity_count = 1
}





g_ascension_cards["Cacklecast Wretch"] = {
	card_name = "Cacklecast Wretch";
    card_set = "DU";
	card_type = "Monster";
	power_cost = 4;
   
   uses_energy = true;
   --energy_required = 4;

	center_row_continuous_effects = {
		{
			conditions = {
				{ "TriggerIfHasCurrentTurnEnergy", 4 },
			};
			effect = { "MayDefeatThisAtNoCost", 0 };
		},
	};

	rewards = {
		{ "GainHonor", 4 },
	};

	effect_text = "If you have gained 4E or more this turn, you may defeat this without paying its cost.\n" ..
                  "REWARD: Gain 4H.";

   ai = {
   },
   
   image_large = { "M_CacklecastWretch", {0, 0, 364/512, 1} };
   image_medium = { "M_CacklecastWretch", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_CacklecastWretch", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_CacklecastWretch", {384/512, 395/512, 512/512, 512/512} };

   defeat_sound = { "cacklecast_wretch" };

   rarity_count = 3
}


g_ascension_cards["Oxipede"] = {
	card_name = "Oxipede";
    card_set = "DU";
	card_type = "Monster";
	power_cost = 3;
   
   uses_energy = true;
   energy_required = 2;

	rewards = {
		{ "GainHonor", 2 },
		{ "GainHonor", 2, condition={"IfHasCurrentTurnEnergy",2} },
	};

	effect_text = "REWARD: Gain 2H.\n" ..
                  "ENERGIZE 2E: Gain 2H.";

   ai = {
   },
   
   image_large = { "M_Oxipede", {0, 0, 364/512, 1} };
   image_medium = { "M_Oxipede", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_Oxipede", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_Oxipede", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "oxipede" };

   rarity_count = 4
}


g_ascension_cards["Phasefiend"] = {
	card_name = "Phasefiend";
    card_set = "DU";
	card_type = "Monster";
	power_cost = 2;

	rewards = {
		{ "GainHonor", 1 },
		{ "BanishFromHandOrDiscard", 1 },
	};

	effect_text = "REWARD: Gain 1H. You may banish a card in your hand or discard pile.";

   ai = {
   },
   
   image_large = { "M_Phasefiend", {0, 0, 364/512, 1} };
   image_medium = { "M_Phasefiend", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_Phasefiend", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_Phasefiend", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "phasefiend" };

   rarity_count = 3
}


g_ascension_cards["Plunder Devil"] = {
	card_name = "Plunder Devil";
    card_set = "DU";
	card_type = "Monster";
	power_cost = 5;
   
   uses_energy = true;
   energy_required = 2;

	rewards = {
		{ "GainHonor", 5 },
		{ "AcquireHeroOrConstructWithCostLessThan", 6, condition={"IfHasCurrentTurnEnergy",2} },
		{ "AcquireHeroOrConstructWithCostLessThan", 3, condition={"IfDoesNotHaveCurrentTurnEnergy",2} },
	};

	effect_text = "REWARD: Gain 5H. You may acquire a Hero or Construct with cost 3R or less without paying its cost.\n" ..
                  "ENERGIZE 2E: Instead, you may acquire a Hero or Construct with cost 6R or less without paying its cost.";

   ai = {
   },
   
   image_large = { "M_PlunderDevil", {0, 0, 364/512, 1} };
   image_medium = { "M_PlunderDevil", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_PlunderDevil", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_PlunderDevil", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "plunder_devil" };

   rarity_count = 3
}


g_ascension_cards["Smoke Tyrant"] = {
	card_name = "Smoke Tyrant";
    card_set = "DU";
	card_type = "Monster";
	power_cost = 7;
   trophy_monster = true;
   
   uses_energy = true;

	rewards = {
		{ "GainHonor", 4 },
		{ "RevealCenterDeckPlaceTreasureUnderTrophy", 7 },
      --{ "GainEnergyForCardsUnderTrophy", 1 },
	};


   triggered_effects = {
		{
			conditions = {
				{"AtStartOfTrophyOwnerTurn", 0 },
			};
			triggereffect = {
            { "TriggerGainEnergyForCardsUnderTrophy", 1 },
			};
		},
	};

	--effect_text = "REWARD: Gain 4H. Banish the top seven cards of the center deck. " ..
    --                 "Put all Treasures banished this way under this.\n" ..
    --              "ONGOING TROPHY: Once per turn, gain 1E for each Treasure under this.";
	effect_text = "REWARD: Gain 4H. Banish the top seven cards of the center deck. " ..
                     "Put all Treasures banished this way under this.";
	trophy_text = "<color=#951719FF><B>Ongoing Trophy:</B></color> Once per turn, gain 1E for each Treasure under this.";

   ai = {
   },
   
   image_large = { "M_SmokeTyrant", {0, 0, 364/512, 1} };
   image_medium = { "M_SmokeTyrant", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_SmokeTyrant", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_SmokeTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "smoke_tyrant" };

   rarity_count = 1
}


g_ascension_cards["Vault Lich"] = {
	card_name = "Vault Lich";
    card_set = "DU";
	card_type = "Monster";
	power_cost = 3;
   
   uses_energy = true;

	center_row = { "BanishAllCenterRowWithTreasure", 0 };

	rewards = {
		{ "GainHonor", 3 },
		{ "BanishFromCenterRowWithTreasure", 1 },
	};

	--effect_text = "FATE: When this enters the center row, banish each card in the center row with Treasure under it.\n" ..
    --              "REWARD: Gain 3H. You may banish a card in the center row with Treasure under it.";
	fate_text = "FATE: When this enters the center row, banish each card in the center row with Treasure under it.";
	effect_text = "REWARD: Gain 3H. You may banish a card in the center row with Treasure under it.";

   ai = {
   },
   
   image_large = { "M_VaultLich", {0, 0, 364/512, 1} };
   image_medium = { "M_VaultLich", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_VaultLich", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_VaultLich", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "vault_lich" };

   rarity_count = 4
}


g_ascension_cards["Webclaw"] = {
	card_name = "Webclaw";
    card_set = "DU";
	card_type = "Monster";
	power_cost = 4;
   
   uses_energy = true;
   energy_required = 3;

	rewards = {
		{ "GainHonor", 3 },
		{ "EachOpponentDiscardsConstructInPlay", 0, condition={"IfHasCurrentTurnEnergy",3} },
		{ "EachOpponentWithConstructsDiscardsConstruct", 3, condition={"IfDoesNotHaveCurrentTurnEnergy",3} },
	};

	effect_text = "REWARD: Gain 3H. Each opponent with three or more Constructs in play " ..
                     "desroys a construct they control.\n" ..
                  "ENERGIZE 3E: Instead, each opponent destroys a Construct they control.";

   ai = {
   },
   
   image_large = { "M_Webclaw", {0, 0, 364/512, 1} };
   image_medium = { "M_Webclaw", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_Webclaw", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_Webclaw", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "webclaw" };

   rarity_count = 2
}


g_ascension_cards["Erabus, the Exiled"] = {
	card_name = "Erabus, the Exiled";
    card_set = "DU";
	card_type = "Monster";
	power_cost = 9;

   global_continuous_effects = {
      {
			conditions = {
				{ "TriggerIfHasPlayedDarkEnergyShard", 0 },
			};
         effect = { "ReduceDefeatThisMonsterCost", 2 };
      },
	};

	rewards = {
		{ "GainHonor", 5, condition={"IfRulesVersionIsLessThan",15} },
      { "PauseForAnimation", 0 },
		{ "TransformThisMonsterIntoErabus", 0 },
	};
   transform_into = "Erabus, Son of Nyx";

	effect_text = "If you have played a Dark Energy Shard this turn, " ..
                     "you pay 2P less to defeat this.\n" ..
                  "REWARD: Transform this into Erabus, Son of Nyx and put it into your hand.";

   ai = {
   },
   
   image_large = { "M_ErabusExiled", {0, 0, 364/512, 1} };
   image_medium = { "M_ErabusExiled", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_ErabusExiled", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_ErabusExiled", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "erabus" };

   rarity_count = 1
}


g_ascension_cards["Erabus, Son of Nyx"] = {
	card_name = "Erabus, Son of Nyx";
    card_set = "DU";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 9;
	honor = 7;

   use_transformed_frame = true;

   transform_from = "Erabus, the Exiled";

	effects = {
      { "DefeatMonsterFromTheVoidAtNoCost", 0 },
   };

	effect_text = "Defeat a Monster in the Void without paying its cost " ..
                  "and put it on the bottom of the center deck.";

   ai = {
   },
   
   image_large = { "VH_ErabusSonNyx", {0, 0, 364/512, 1} };
   image_medium = { "VH_ErabusSonNyx", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_ErabusSonNyx", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_ErabusSonNyx", {384/512, 395/512, 512/512, 512/512} };

   --rarity_count = 1
}









