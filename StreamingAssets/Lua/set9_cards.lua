


g_ascension_cards["Ephemeral Monk"] = {
	card_name = "Ephemeral Monk";
    card_set = "DS";
	card_type = "Hero";
	faction = "Enlightened";
	
	rune_cost = 1;
	honor = 1;

   effects = {
      { "DrawCards", 2 },
      { "BanishThisCard", 0 },
   };
	effect_text = "Draw 2 cards, then banish this.";

   ai = {
      trivial_draw = 2;

      gain_draw = 2;
   },

   image_large = { "EH_EphemeralMonk", {0, 0, 364/512, 1} };
   image_medium = { "EH_EphemeralMonk", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_EphemeralMonk", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_EphemeralMonk", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 3

}

g_ascension_active_effects["unite banish from center row"] = {
   type = "triggered";
   conditions = {
      { "WhenYouPlayEnlightenedHero", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerEffectPlayerBanishFromCenterRow", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}

g_ascension_cards["Auspicious Askara"] = {
	card_name = "Auspicious Askara";
    card_set = "DS";
	card_type = "Hero";
	faction = "Enlightened";
	dreamborn = true;
	
	rune_cost = 2;
	honor = 1;

   center_row = { "EachPlayerGainInsight", 1 },

   effects = {
      { "DrawCards", 1 },
      { "BanishFromCenterRow", 1, condition={"IfPlayedEnlightenedHero",1} },
      { "UniteBanishFromCenterRow", 0, condition={"IfHaventPlayedEnlightenedHero",1} },
   };
	effect_text = "Draw a card.\n" ..
					"UNITE: You may banish a card in the center row.";

   ai = {
      trivial_draw = 1;

      gain_draw = 1;
   },

   image_large = { "EH_AuspiciousAskara", {0, 0, 364/512, 1} };
   image_medium = { "EH_AuspiciousAskara", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_AuspiciousAskara", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_AuspiciousAskara", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2

}

g_ascension_active_effects["dreamborn acquired costs 1 less"] = {
   type = "continuous";
   effectfunc = { "ReduceDreambornRuneCost", 1 };
}

g_ascension_cards["Nocturnal Seer"] = {
	card_name = "Nocturnal Seer";
    card_set = "DS";
	card_type = "Hero";
	faction = "Enlightened";
	
	rune_cost = 2;
	honor = 1;

   effects = {
      { "DrawCards", 1 },
      { "NextDreambornYouAcquireCostsLess", 1 },
   };
	effect_text = "Draw a card.\n" ..
					"You may pay 1R less the next time you acquire " ..
					"a Dreamborn card this turn.";

   ai = {
      trivial_draw = 1;

      gain_draw = 1;
   },

   image_large = { "EH_NocturnalSeer", {0, 0, 364/512, 1} };
   image_medium = { "EH_NocturnalSeer", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_NocturnalSeer", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_NocturnalSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2

}


g_ascension_cards["Arha Sensei DS"] = {
	card_name = "Arha Sensei DS";
    card_set = "DS";
   display_name = "Arha Sensei";
	card_type = "Hero";
	faction = "Enlightened";
	
	rune_cost = 3;
	honor = 2;
	
	effects = {
		{ "BanishFromHand", 0 },
		{ "AcquireMysticOrHeavyInfantryToHand", 0, condition={"IfYouDo",0} },
	};
	effect_text = "Banish a card in your hand. " ..
					"If you do, acquire a Mystic or Heavy Infantry without paying its cost. " ..
					"Add it to your hand.";

   ai = {
      might_not_play = true,
   },

   
   --image_large = { "EH_ArhaSensei_DS", {0, 0, 364/512, 1} };
   --image_medium = { "EH_ArhaSensei_DS", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_ArhaSensei_DS", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_ArhaSensei_DS", {384/512, 395/512, 512/512, 512/512} };
   image_large = { "EH_ArhaSensei", {0, 0, 364/512, 1} };
   image_medium = { "EH_ArhaSensei", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_ArhaSensei", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_ArhaSensei", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 3
}

g_ascension_cards["Garden Attendant"] = {
	card_name = "Garden Attendant";
    card_set = "DS";
	card_type = "Hero";
	faction = "Enlightened";
	
	rune_cost = 3;
	honor = 1;

   effects = {
      { "GainInsight", 1 },
      { "DrawCards", 1 },
   };
	effect_text = "Gain 1I.\n" ..
					"Draw a card.";

   ai = {
      trivial_draw = 1;

      gain_draw = 1;
      gain_insight = 1;
   },

   image_large = { "EH_GardenAttendant", {0, 0, 364/512, 1} };
   image_medium = { "EH_GardenAttendant", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_GardenAttendant", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_GardenAttendant", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}

g_ascension_cards["Templar Dragoon"] = {
	card_name = "Templar Dragoon";
    card_set = "DS";
	card_type = "Hero";
	faction = "Enlightened";
	
	rune_cost = 4;
	honor = 2;
	
   effects = {
      { "DefeatMonsterWithLessPowerOrAddToDreamscape", 4 },
   };
	effect_text = "Defeat a Monster with cost 4 or less without paying its cost, " ..
					"or add a card to your Dreamscape.";

   ai = {
      defeat_monster = 4;
      gain_dreamscape = 1;
   },
   
   image_large = { "EH_TemplarDragoon", {0, 0, 364/512, 1} };
   image_medium = { "EH_TemplarDragoon", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_TemplarDragoon", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_TemplarDragoon", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}


g_ascension_cards["Pasythea's Ward"] = {
	card_name = "Pasythea's Ward";
    card_set = "DS";
	card_type = "Construct";
	faction = "Enlightened";
	
	rune_cost = 5;
	honor = 3;

   construct_ability = {
      description = "Gain 1I";
      { "GainInsight", 1 },

      ai = {
         trivial = true,
      },
   };
	effect_text = "Once per turn, gain 1I.";

   ai = {
      gain_insight = 1;
   },
   
   image_large = { "EC_PasytheasWard", {0, 0, 364/512, 1} };
   image_medium = { "EC_PasytheasWard", {392/512, 0, 512/512, 168/512} };
   image_small = { "EC_PasytheasWard", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EC_PasytheasWard", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}

g_ascension_cards["Loa, Sleeping Dragon"] = {
	card_name = "Loa, Sleeping Dragon";
    card_set = "DS";
	card_type = "Hero";
	faction = "Enlightened";
	
	rune_cost = 6;
	honor = 4;

   effects = {
      { "GainInsight", 3 },
      { "DrawCards", 1 },
   };
	effect_text = "Gain 3I.\n" ..
					"Draw a card.";

   ai = {
      trivial_draw = 1;

      gain_draw = 1;
      gain_insight = 3;
   },

   image_large = { "EH_LoaSleepingDragon", {0, 0, 364/512, 1} };
   image_medium = { "EH_LoaSleepingDragon", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_LoaSleepingDragon", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_LoaSleepingDragon", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}


g_ascension_cards["Dreamshaper Jesse"] = {
	card_name = "Dreamshaper Jesse";
    card_set = "DS";
	card_type = "Hero";
	faction = "Enlightened";
	
	rune_cost = 7;
	honor = 5;


   effects = {
      { "AcquireTopOfDreamDeck", 0 },
   };

	effect_text = "Acquire the top card of the Dream deck without paying its cost.";

   ai = {
   },
   
   image_large = { "EH_DreamshaperJesse", {0, 0, 364/512, 1} };
   image_medium = { "EH_DreamshaperJesse", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_DreamshaperJesse", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_DreamshaperJesse", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}

g_ascension_cards["Unbound Emissary"] = {
	card_name = "Unbound Emissary";
    card_set = "DS";
	card_type = "Hero";
	faction = "Enlightened";
	dreamborn = true;
	
	rune_cost = 15;
   spend_insight_to_acquire = true;
	honor = 7;

   center_row = { "EachPlayerGainInsight", 1 },

   effects = {
      { "AcquireOrDefeatAnyCenterRowOrDreamscape", 0 },
   };

	effect_text = "You may spend I as though it was R to acquire this.\n" ..
					"Acquire or defeat any card in the center row or your Dreamscape without paying its cost.";

   ai = {
   },
   
   image_large = { "EH_UnboundEmissary", {0, 0, 364/512, 1} };
   image_medium = { "EH_UnboundEmissary", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_UnboundEmissary", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_UnboundEmissary", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}









g_ascension_cards["Ephemeral Druid"] = {
	card_name = "Ephemeral Druid";
    card_set = "DS";
	card_type = "Hero";
	faction = "Lifebound";
	
	rune_cost = 1;
	honor = 1;

   effects = {
      { "GainHonor", 5 },
      { "BanishThisCard", 0 },
   };
	effect_text = "Gain 5H, then banish this.";

   ai = {
      gain_honor = 5;
   },
   
   image_large = { "LH_EphemeralDruid", {0, 0, 364/512, 1} };
   image_medium = { "LH_EphemeralDruid", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_EphemeralDruid", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_EphemeralDruid", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 3
}


g_ascension_cards["Alluring Shaman"] = {
	card_name = "Alluring Shaman";
    card_set = "DS";
	card_type = "Hero";
	faction = "Lifebound";
	
	rune_cost = 2;
	honor = 1;

   effects = {
      { "GainRunes", 1 },
      { "GainHonorForInsight", 3 },
   };
	effect_text = "Gain 1R.\n" ..
					"You may pay 1I to gain 3H.";

   ai = {
      gain_rune = 1;
      gain_honor = 3;
   },

   image_large = { "LH_AlluringShaman", {0, 0, 364/512, 1} };
   image_medium = { "LH_AlluringShaman", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_AlluringShaman", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_AlluringShaman", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}

g_ascension_active_effects["unite 2R"] = {
   type = "triggered";
   conditions = {
      { "WhenYouPlayLifeboundHero", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerGainRunes", 2 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}

g_ascension_cards["Verdant Hatchling"] = {
	card_name = "Verdant Hatchling";
    card_set = "DS";
	card_type = "Hero";
	faction = "Lifebound";
	dreamborn = true;
	
	rune_cost = 2;
	honor = 1;

   center_row = { "EachPlayerGainInsight", 1 },

   effects = {
      { "GainHonor", 2 },
      { "GainRunes", 2, condition={"IfPlayedLifeboundHero",1} },
      { "Unite2R", 0, condition={"IfHaventPlayedLifeboundHero",1} },
   };
	effect_text = "Gain 2H.\n" ..
					"UNITE: Gain 2R.";

   ai = {
      gain_honor = 2;
      gain_rune = 2;
   },

   image_large = { "LH_VerdantHatchling", {0, 0, 364/512, 1} };
   image_medium = { "LH_VerdantHatchling", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_VerdantHatchling", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_VerdantHatchling", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 3

}

g_ascension_cards["Flytrap Fairy"] = {
	card_name = "Flytrap Fairy";
    card_set = "DS";
	card_type = "Hero";
	faction = "Lifebound";
	
	rune_cost = 3;
	honor = 1;

   effects = {
      { "GainRunes", 1 },
      { "GainHonor", 1 },
      { "GainInsight", 1 },
   };
	effect_text = "Gain 1R, 1H, and 1I.";

   ai = {
      gain_honor = 1;
      gain_rune = 1;
      gain_insight = 1;
   },

   image_large = { "LH_FlytrapFairy", {0, 0, 364/512, 1} };
   image_medium = { "LH_FlytrapFairy", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_FlytrapFairy", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_FlytrapFairy", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}


g_ascension_cards["Dreamwillow Druids"] = {
	card_name = "Dreamwillow Druids";
    card_set = "DS";
	card_type = "Hero";
	faction = "Lifebound";
	
	rune_cost = 4;
	honor = 3;

   effects = {
      { "AcquireHeroWithLessCostOrAddToDreamscape", 5 },
   };
	effect_text = "Choose one: acquire a Hero with cost 5R or less without paying its cost; " ..
					"or add a card to your Dreamscape.";

   ai = {
      gain_dreamscape = 1;
   },
   
   image_large = { "LH_DreamwillowDruids", {0, 0, 364/512, 1} };
   image_medium = { "LH_DreamwillowDruids", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_DreamwillowDruids", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_DreamwillowDruids", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}

g_ascension_active_effects["unite 2I"] = {
   type = "triggered";
   conditions = {
      { "WhenYouPlayLifeboundHero", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerGainInsight", 2 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}

g_ascension_cards["Lunar Pack"] = {
	card_name = "Lunar Pack";
    card_set = "DS";
	card_type = "Hero";
	faction = "Lifebound";
	
	rune_cost = 4;
	honor = 3;

   effects = {
      { "GainRunes", 2 },
      { "GainInsight", 2, condition={"IfPlayedLifeboundHero",1} },
      { "Unite2I", 0, condition={"IfHaventPlayedLifeboundHero",1} },
   };
	effect_text = "Gain 2R.\n" ..
					"UNITE: Gain 2I.";

   ai = {
      gain_rune = 2;
      gain_insight = 2;
   },

   image_large = { "LH_LunarPack", {0, 0, 364/512, 1} };
   image_medium = { "LH_LunarPack", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_LunarPack", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_LunarPack", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}


g_ascension_cards["Dreamwillow"] = {
	card_name = "Dreamwillow";
    card_set = "DS";
	card_type = "Construct";
	faction = "Lifebound";
	
	rune_cost = 5;
	honor = 4;

   construct_ability = {
      description = "Gain 1R";
      { "GainRunes", 1 },

      ai = {
         trivial = true,
      },
   };
   triggered_effects = {
      {
         conditions = {
            { "IfThisHasntBeenUsedThisTurn", 0 },
            { "WhenConstructOwnerPlaysFirstLifeboundHero", 0 },
         };
         triggereffect = {
            { "TriggerConstructGainInsight", 1 },
            { "TriggerSetThisHasBeenUsedThisTurn", 0 },
         };
      },
   };
	effect_text = "Once per turn, gain 1R.\n" ..
					"The first time you play a Lifebound Hero each turn, gain 1I.";

   ai = {
      gain_rune = 1;
      gain_insight = 1;
   },

   image_large = { "LC_Dreamwillow", {0, 0, 364/512, 1} };
   image_medium = { "LC_Dreamwillow", {392/512, 0, 512/512, 168/512} };
   image_small = { "LC_Dreamwillow", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LC_Dreamwillow", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}


g_ascension_cards["Raka, Dreamtender"] = {
	card_name = "Raka, Dreamtender";
    card_set = "DS";
	card_type = "Hero";
	faction = "Lifebound";
	
	rune_cost = 6;
	honor = 3;

   effects = {
      { "GainHonor", 5 },
      { "AddCardsToDreamscape", 1 },
   };
	effect_text = "Gain 5H.\n" ..
					"Add a card to your Dreamscape.";

   ai = {
      gain_honor = 5;
      gain_dreamscape = 1;
   },
   
   image_large = { "LH_RakaDreamtender", {0, 0, 364/512, 1} };
   image_medium = { "LH_RakaDreamtender", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_RakaDreamtender", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_RakaDreamtender", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}

g_ascension_active_effects["gain insight for acquired hero"] = {
   type = "triggered";
   conditions = {
      { "WhenYouAcquireHero", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerGainInsightForAcquiredCard", 0 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}

g_ascension_cards["Verdagris, the Wild"] = {
	card_name = "Verdagris, the Wild";
    card_set = "DS";
	card_type = "Hero";
	faction = "Lifebound";
	dreamborn = true;
	
	rune_cost = 7;
	honor = 4;

   center_row = { "EachPlayerGainInsight", 1 },

   effects = {
      { "GainRunes", 4 },
      { "GainInsightForAcquiredHeroThisTurn", 0 },
   };
	effect_text = "Gain 4R.\n" ..
					"Each time you acquire a Hero this turn, " ..
					"gain I equal to its H value.";

   ai = {
      gain_runes = 4;
      gain_insight = 3;
   },

   image_large = { "LH_VerdagrisWild", {0, 0, 364/512, 1} };
   image_medium = { "LH_VerdagrisWild", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_VerdagrisWild", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_VerdagrisWild", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}







g_ascension_cards["Ephemeral Inventor"] = {
	card_name = "Ephemeral Inventor";
    card_set = "DS";
	card_type = "Hero";
	faction = "Mechana";
	
	rune_cost = 1;
	honor = 1;

   effects = {
      { "GainRunes", 3 },
      { "BanishThisCard", 0 },
   };
	effect_text = "Gain 3R, then banish this.";

   ai = {
      gain_runes = 3;
   },
   
   image_large = { "MH_EphemeralInventor", {0, 0, 364/512, 1} };
   image_medium = { "MH_EphemeralInventor", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_EphemeralInventor", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_EphemeralInventor", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 3
}

g_ascension_cards["Planar Aperture"] = {
	card_name = "Planar Aperture";
    card_set = "DS";
	card_type = "Construct";
	faction = "Mechana";
	
	rune_cost = 2;
	honor = 2;

   continuous_effects = {
      {
         priority = 8;
         effect = { "MayAcquireMechanaConstructsIntoPlayForInsight", 1 };
      },
   };

	effect_text = "When you acquire a Mechana Construct, " ..
					"you may pay 1I to put it directly into play.";

   ai = {
   },
   
   image_large = { "MC_PlanarAperture", {0, 0, 364/512, 1} };
   image_medium = { "MC_PlanarAperture", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_PlanarAperture", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_PlanarAperture", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}

g_ascension_cards["ID34 Detector"] = {
	card_name = "ID34 Detector";
    card_set = "DS";
	card_type = "Construct";
	faction = "Mechana";
	
	rune_cost = 3;
	honor = 3;

   triggered_effects = {
      {
         conditions = {
            { "IfThisHasntBeenUsedThisTurn", 0 },
            { "WhenYouPutMechanaConstructIntoPlay", 0 },
         };
         triggereffect = {
            { "TriggerConstructGainInsight", 1 },
            { "TriggerSetThisHasBeenUsedThisTurn", 0 },
         };
      },
   };
	effect_text = "Once per turn, when you play a Mechana Construct " ..
					"(including this one), gain 1I.";

   ai = {
      gain_insight = 1;
   },
   
   image_large = { "MC_ID34Detector", {0, 0, 364/512, 1} };
   image_medium = { "MC_ID34Detector", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_ID34Detector", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_ID34Detector", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}

g_ascension_cards["Synapse Spire"] = {
	card_name = "Synapse Spire";
    card_set = "DS";
	card_type = "Construct";
	faction = "Mechana";
	dreamborn = true;
	
	rune_cost = 4;
	honor = 4;

   center_row = { "EachPlayerGainInsight", 1 },

   triggered_effects = {
      {
         conditions = {
            { "IfThisHasntBeenUsedThisTurn", 0 },
            { "WhenYouPutMechanaConstructIntoPlay", 0 },
         };
         triggereffect = {
            { "TriggerConstructOwnerAddCardsToDreamscape", 1 },
            { "TriggerSetThisHasBeenUsedThisTurn", 0 },
         };
      },
   };
	effect_text = "Once per turn, when you play a Mechana Construct (including this one), " ..
					"add a card to your Dreamscape.";

   ai = {
      gain_dreamscape = 1;
   },
   
   image_large = { "MC_SynapseSpire", {0, 0, 364/512, 1} };
   image_medium = { "MC_SynapseSpire", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_SynapseSpire", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_SynapseSpire", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}

g_ascension_cards["Hedron Berserker"] = {
	card_name = "Hedron Berserker";
    card_set = "DS";
	card_type = "Hero";
	faction = "Mechana";
	
	rune_cost = 5;
	honor = 3;

   effects = {
      { "GainRunes", 3, condition={"IfYouControlConstructs",3} },
      { "GainPower", 3, condition={"IfYouControlConstructs",3} },
      { "ChooseFromEffectList",
         {
            prompt = "Choose Rune or Power",
            {
               { "GainRunes", 3 },
               description = "Gain 3 Runes",
            },
            {
               { "GainPower", 3 },
               description = "Gain 3 Power",
            },
         },
         condition={"IfYouDoNotControlConstructs",3}
      }
   };
	effect_text = "Gain 3R or 3P. " ..
					"If you control three or more Constructs, gain both instead.";

   ai = {
      gain_runes = 3;
      gain_power = 3;
   },
   
   image_large = { "MH_HedronBerserker", {0, 0, 364/512, 1} };
   image_medium = { "MH_HedronBerserker", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_HedronBerserker", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_HedronBerserker", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 3

}

g_ascension_cards["Deluxe Capacitor"] = {
	card_name = "Deluxe Capacitor";
    card_set = "DS";
	card_type = "Construct";
	faction = "Mechana";
	
	rune_cost = 5;
	honor = 5;

   continuous_effects = {
      {
         effect = {"OwnerTreatsDreamConstructsAsMechanaConstructs", 0 };
      },
   };

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
	effect_text = "You may treat Dream Constructs as though they are Mechana Constructs.\n" ..
					"Once per turn, when you play a Mechana Construct (including this one), " ..
					"draw a card.";

   ai = {
      gain_draw = 1;
   },

   image_large = { "MC_DeluxeCapacitor", {0, 0, 364/512, 1} };
   image_medium = { "MC_DeluxeCapacitor", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_DeluxeCapacitor", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_DeluxeCapacitor", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}


g_ascension_cards["TH07 Tank"] = {
	card_name = "TH07 Tank";
    card_set = "DS";
	card_type = "Construct";
	faction = "Mechana";
	
	rune_cost = 6;
	honor = 6;

   construct_ability = {
      ability_name = "Pay 1I for 3R",
      description = "Pay 1I, Gain 3R for Mechana Constructs";
      condition = { "IfCanPayInsight", 1 },
      { "PushResolvingConstruct", 0 },
      { "PayInsight", 1 },
      { "GainRunesForMechanaConstruct", 3 },
      { "PopResolvingConstruct", 0 },
   };

	effect_text = "Once per turn, you may pay 1I to gain 3R. " ..
					"You may spend them only to acquire Mechana Constructs.";

   ai = {
      gain_rune_mechana = 3;
   },
   
   image_large = { "MC_TH07Tank", {0, 0, 364/512, 1} };
   image_medium = { "MC_TH07Tank", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_TH07Tank", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_TH07Tank", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}

g_ascension_cards["Inquarry Hydra"] = {
	card_name = "Inquarry Hydra";
    card_set = "DS";
	card_type = "Construct";
	faction = "Mechana";
	
	rune_cost = 7;
	honor = 7;

   construct_ability = {
      description = "Gain X Insight";
      { "GainInsightForEachMechanaConstructInPlay", 1 },
   };
	effect_text = "Once per turn, gain 1I for each Mechana Contruct you control (including this one).";

   ai = {
      gain_insight = 2;
   },
   
   image_large = { "MC_InquarryHydra", {0, 0, 364/512, 1} };
   image_medium = { "MC_InquarryHydra", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_InquarryHydra", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_InquarryHydra", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}

g_ascension_cards["Chaos Cannon"] = {
	card_name = "Chaos Cannon";
    card_set = "DS";
	card_type = "Construct";
	faction = "Mechana";
	dreamborn = true;
	
	rune_cost = 8;
	honor = 8;

   center_row = { "EachPlayerGainInsight", 1 },

   construct_ability = {
      ability_name = "Pay 5I for 10P",
      description = "Pay 5I, Gain 10P";
      condition = { "IfCanPayInsightMinusMechanaConstructCount", 5 },
      { "PushResolvingConstruct", 0 },
      { "LoseInsightMinusMechanaConstructCount", 5 },
      { "GainPower", 10 },
      { "PopResolvingConstruct", 0 },
   };
	effect_text = "Once per turn, you may pay 5I to gain 10P. " ..
					"You may pay 1I less to use this ability " ..
					"for each other Mechana Construct you control.";

   ai = {
      gain_power = 10;
   },
   
   image_large = { "MC_ChaosCannon", {0, 0, 364/512, 1} };
   image_medium = { "MC_ChaosCannon", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_ChaosCannon", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_ChaosCannon", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}








g_ascension_cards["Ephemeral Ritualist"] = {
	card_name = "Ephemeral Ritualist";
    card_set = "DS";
	card_type = "Hero";
	faction = "Void";
	
	rune_cost = 1;
	honor = 1;

   effects = {
      { "GainPower", 4 },
      { "BanishThisCard", 0 },
   };
	effect_text = "Gain 4P, then banish this.";

   ai = {
      gain_power = 4;
   },
   
   image_large = { "VH_EphemeralRitualist", {0, 0, 364/512, 1} };
   image_medium = { "VH_EphemeralRitualist", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_EphemeralRitualist", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_EphemeralRitualist", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 3
}


g_ascension_cards["Caustic Conjurer"] = {
	card_name = "Caustic Conjurer";
    card_set = "DS";
	card_type = "Hero";
	faction = "Void";
	
	rune_cost = 2;
	honor = 2;

   effects = {
      { "GainInsight", 1 },
      { "BanishFromHandOrDiscard", 1 },
   };
	effect_text = "Gain 1I.\n" ..
					"You may banish a card in your hand or discard pile.";

   ai = {
      gain_insight = 1;
   },
   
   image_large = { "VH_CausticConjurer", {0, 0, 364/512, 1} };
   image_medium = { "VH_CausticConjurer", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_CausticConjurer", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_CausticConjurer", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}


g_ascension_cards["Dreamkiller"] = {
	card_name = "Dreamkiller";
    card_set = "DS";
	card_type = "Hero";
	faction = "Void";
	
	rune_cost = 3;
	honor = 2;

   effects = {
      { "GainPower", 2 },
      { "GainInsight", 1 },
   };
	effect_text = "Gain 2P and 1I.";

   ai = {
      gain_power = 2;
      gain_insight = 1;
   },
   
   image_large = { "VH_Dreamkiller", {0, 0, 364/512, 1} };
   image_medium = { "VH_Dreamkiller", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_Dreamkiller", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_Dreamkiller", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 3
}


g_ascension_cards["Loam Summoner"] = {
	card_name = "Loam Summoner";
    card_set = "DS";
	card_type = "Hero";
	faction = "Void";
	
	rune_cost = 3;
	honor = 2;

   effects = {
      { "AddCardsToDreamscape", 1 },
      { "BanishFromHandOrDiscard", 1 },
   };
	effect_text = "Add a card to your Dreamscape.\n" ..
					"You may banish a card in your hand or discard pile.";

   ai = {
      gain_dreamscape = 1;
   },
   
   image_large = { "VH_LoamSummoner", {0, 0, 364/512, 1} };
   image_medium = { "VH_LoamSummoner", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_LoamSummoner", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_LoamSummoner", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}

g_ascension_active_effects["add card to dreamscape when you defeat a monster"] = {
   type = "triggered";
   conditions = {
      { "WhenYouDefeatMonsterFromCenterRow", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerEffectPlayerAddCardsToDreamscape", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}

g_ascension_cards["Fear Wielder"] = {
	card_name = "Fear Wielder";
    card_set = "DS";
	card_type = "Hero";
	faction = "Void";
	dreamborn = true;
	
	rune_cost = 4;
	honor = 2;

   center_row = { "EachPlayerGainInsight", 1 },

   effects = {
      { "GainPower", 3 },
      { "NextMonsterYouDefeatAddCardToDreamscape", 0 },
   };
	effect_text = "Gain 3P.\n" ..
					"The next time you defeat a Monster in the center row this turn, " ..
					"add a card to your Dreamscape.";

   ai = {
      gain_power = 3;
      gain_dreamscape = 1;
   },
   
   image_large = { "VH_FearWielder", {0, 0, 364/512, 1} };
   image_medium = { "VH_FearWielder", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_FearWielder", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_FearWielder", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}


g_ascension_cards["Fatality Blades"] = {
	card_name = "Fatality Blades";
    card_set = "DS";
	card_type = "Construct";
	faction = "Void";
	
	rune_cost = 5;
	honor = 4;

   construct_ability = {
      description = "Gain 1P";
      { "GainPower", 1 },

      ai = {
         trivial = true,
      },
   };

   triggered_effects = {
      {
         conditions = {
            { "IfThisHasntBeenUsedThisTurn", 0 },
            { "WhenConstructOwnerDefeatsMonster", 0 },
         };
         triggereffect = {
            { "TriggerConstructGainInsight", 1 },
            { "TriggerSetThisHasBeenUsedThisTurn", 0 },
         };
      },
   };

   effect_text = "Once per turn, gain 1P.\n" ..
					"Once per turn, when you defeat a Monster in the center row, gain 1I.";

   ai = {
      gain_power = 1;
      gain_insight = 1;
   },
   
   image_large = { "VC_FatalityBlades", {0, 0, 364/512, 1} };
   image_medium = { "VC_FatalityBlades", {392/512, 0, 512/512, 168/512} };
   image_small = { "VC_FatalityBlades", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VC_FatalityBlades", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}


g_ascension_cards["Nightmare Harvester"] = {
	card_name = "Nightmare Harvester";
    card_set = "DS";
	card_type = "Hero";
	faction = "Void";
	dreamborn = true;
	
	rune_cost = 6;
	honor = 3;

   center_row = { "EachPlayerGainInsight", 1 },

   effects = {
      --{ "GainPower", 4 },
      { "ChooseFromEffectList",
         {
            prompt = "Choose Rune or Power",
            {
               { "GainPower", 4 },
               description = "Gain 4 Power",
            },
            {
               { "PayInsight", 1 },
               { "GainRunes", 4 },
               description = "Gain 4 Runes",
               usagecondition = { "IfCanPayInsight", 1 },
            },
         }
      },
   };
	effect_text = "Gain 4P. " ..
					"You may pay 1I to gain 4R instead.";

   ai = {
      gain_power = 4;
      gain_runes = 4;
   },

   image_large = { "VH_NightmareHarvester", {0, 0, 364/512, 1} };
   image_medium = { "VH_NightmareHarvester", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_NightmareHarvester", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_NightmareHarvester", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}


g_ascension_cards["Emri, Shadowslayer"] = {
	card_name = "Emri, Shadowslayer";
    card_set = "DS";
	card_type = "Hero";
	faction = "Void";
	
	rune_cost = 8;
	honor = 4;

   effects = {
      { "GainPower", 5 },
      { "UsePowerAsInsightUntilEndOfTurn", 0 },
   };
	effect_text = "Gain 5P.\n" ..
					"You may spend P as though it was I this turn.";

   ai = {
      gain_power = 5;
   },
   
   image_large = { "VH_EmriShadowslayer", {0, 0, 364/512, 1} };
   image_medium = { "VH_EmriShadowslayer", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_EmriShadowslayer", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_EmriShadowslayer", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}







g_ascension_cards["Rust Gremlin"] = {
	card_name = "Rust Gremlin";
    card_set = "DS";
	card_type = "Monster";
	power_cost = 2;

	rewards = {
		{ "GainHonor", 1 },
      { "DrawCards", 1 },
	};
	effect_text = "REWARD: Gain 1H. Draw a card.";

   ai = {
   },
   
   image_large = { "M_RustGremlin", {0, 0, 364/512, 1} };
   image_medium = { "M_RustGremlin", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_RustGremlin", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_RustGremlin", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Rust Gremlin" };

   rarity_count = 3
}


g_ascension_cards["Thieving Gryphon"] = {
	card_name = "Thieving Gryphon";
    card_set = "DS";
	card_type = "Monster";
	power_cost = 3;

	rewards = {
		{ "GainHonor", 2 },
      { "GainRunes", 2 },
	};

	effect_text = "REWARD: Gain 2H. Gain 2R.";

   ai = {
   },
   
   image_large = { "M_ThievingGryphon", {0, 0, 364/512, 1} };
   image_medium = { "M_ThievingGryphon", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_ThievingGryphon", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_ThievingGryphon", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Thieving Gryphon" };

   rarity_count = 3
}


g_ascension_cards["Tidestalker"] = {
	card_name = "Tidestalker";
    card_set = "DS";
	card_type = "Monster";
	power_cost = 3;

	rewards = {
		{ "GainHonor", 4 },
	};

	effect_text = "REWARD: Gain 4H.";

   ai = {
   },
   
   image_large = { "M_Tidestalker", {0, 0, 364/512, 1} };
   image_medium = { "M_Tidestalker", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_Tidestalker", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_Tidestalker", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Tidestalker" };

   rarity_count = 4
}


g_ascension_cards["Fen Maw"] = {
	card_name = "Fen Maw";
    card_set = "DS";
	card_type = "Monster";
	power_cost = 4;

	rewards = {
		{ "GainHonor", 3 },
      { "GainInsight", 2 },
	};

	effect_text = "REWARD: Gain 3H. Gain 2I.";

   ai = {
   },
   
   image_large = { "M_FenMaw", {0, 0, 364/512, 1} };
   image_medium = { "M_FenMaw", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_FenMaw", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_FenMaw", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Fen Maw" };

   rarity_count = 4
}


g_ascension_cards["Trinket Harpy"] = {
	card_name = "Trinket Harpy";
    card_set = "DS";
	card_type = "Monster";
	power_cost = 4;

	rewards = {
		{ "GainHonor", 3 },
      { "AddCardsToDreamscape", 1 },
	};

	effect_text = "REWARD: Gain 3H. Add a card to your Dreamscape.";

   ai = {
   },
   
   image_large = { "M_TrinketHarpy", {0, 0, 364/512, 1} };
   image_medium = { "M_TrinketHarpy", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_TrinketHarpy", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_TrinketHarpy", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Trinket Harpy" };

   rarity_count = 3
}


g_ascension_cards["Deluding Djinn"] = {
	card_name = "Deluding Djinn";
    card_set = "DS";
	card_type = "Monster";

   power_cost = 5;
   spend_insight_to_defeat = true;

	rewards = {
		{ "GainHonor", 5 },
	};

	effect_text = "REWARD: Gain 5H.\n" ..
					"You may spend I as though it was P to defeat this.";

   ai = {
   },
   
   image_large = { "M_DeludingDjinn", {0, 0, 364/512, 1} };
   image_medium = { "M_DeludingDjinn", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_DeludingDjinn", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_DeludingDjinn", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Deluding Djinn" };

   rarity_count = 3
}


g_ascension_cards["Hulking Crab"] = {
	card_name = "Hulking Crab";
    card_set = "DS";
	card_type = "Monster";
	power_cost = 5;

	rewards = {
		{ "GainHonor", 4 },
      { "EachOpponentDestroysHalfOfConstructsInPlay", 0 },
   };

	effect_text = "REWARD: Gain 4H. " ..
					"Each opponent destroys half of their Constructs rounded up.";

   ai = {
   },
   
   image_large = { "M_HulkingCrab", {0, 0, 364/512, 1} };
   image_medium = { "M_HulkingCrab", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_HulkingCrab", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_HulkingCrab", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Hulking Crab" };

   rarity_count = 2
}


g_ascension_cards["Puppetmaster"] = {
	card_name = "Puppetmaster";
    card_set = "DS";
	card_type = "Monster";
	power_cost = 5;

	rewards = {
		{ "GainHonor", 4 },
      { "TakeInsightFromEachOpponent", 1 },
	};

	effect_text = "REWARD: Gain 4H. " ..
					"Take 1I from each opponent.";

   ai = {
   },
   
   image_large = { "M_Puppetmaster", {0, 0, 364/512, 1} };
   image_medium = { "M_Puppetmaster", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_Puppetmaster", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_Puppetmaster", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Puppet Master" };

   rarity_count = 1
}

g_ascension_cards["Fleeting Hope Djinn"] = {
	card_name = "Fleeting Hope Djinn";
    card_set = "DS";
	card_type = "Monster";
	power_cost = 6;

	rewards = {
		{ "GainHonor", 5 },
      { "AddCardsToDreamscape", 2 },
	};

	effect_text = "REWARD: Gain 5H. " ..
					"Add two cards to your Dreamscape.";

   ai = {
   },
   
   image_large = { "M_FleetingHopeDjinn", {0, 0, 364/512, 1} };
   image_medium = { "M_FleetingHopeDjinn", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_FleetingHopeDjinn", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_FleetingHopeDjinn", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Fleeting Hope Djinn" };

   rarity_count = 2
}


g_ascension_cards["Nightmare Tyrant"] = {
	card_name = "Nightmare Tyrant";
    card_set = "DS";
	card_type = "Monster";
	power_cost = 6;

	rewards = {
		{ "GainHonor", 5 },
      { "AcquireAnyCardFromDreamscape", 0 },
	};

	effect_text = "REWARD: Gain 5H. " ..
					"Acquire a card from your Dreamscape without paying its cost.";

   ai = {
   },
   
   image_large = { "M_NightmareTyrant", {0, 0, 364/512, 1} };
   image_medium = { "M_NightmareTyrant", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_NightmareTyrant", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_NightmareTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Nightmare Tyrant" };

   rarity_count = 1
}


g_ascension_cards["Engulfing Kraken"] = {
	card_name = "Engulfing Kraken";
    card_set = "DS";
	card_type = "Monster";
	power_cost = 7;

	rewards = {
		{ "GainHonor", 6 },
      { "TakeDreamscapeCardFromEachOpponent", 0 },
	};

	effect_text = "REWARD: Gain 6H. " ..
					"Take a card at random from each opponent's Dreamscape, " ..
					"and add them to your Dreamscape.";

   ai = {
   },
   
   image_large = { "M_EngulfingKraken", {0, 0, 364/512, 1} };
   image_medium = { "M_EngulfingKraken", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_EngulfingKraken", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_EngulfingKraken", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Engulfing Kraken" };

   rarity_count = 1
}


g_ascension_cards["Nilus, the Despair"] = {
	card_name = "Nilus, the Despair";
    card_set = "DS";
	card_type = "Monster";
	power_cost = 8;

	rewards = {
		{ "GainHonor", 7 },
      { "AcquireTopOfDreamDeck", 0 },
      { "AcquireTopOfDreamDeck", 0 },
      { "AcquireTopOfDreamDeck", 0 },
	};

	effect_text = "REWARD: Gain 7H. " ..
					"Acquire the top three cards of the Dream deck " ..
					"without paying their cost.";

   ai = {
   },
   
   image_large = { "M_NilusDespair", {0, 0, 364/512, 1} };
   image_medium = { "M_NilusDespair", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_NilusDespair", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_NilusDespair", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Nilus, the Despair" };

   rarity_count = 1
}






g_ascension_active_effects["unite recover discard"] = {
   type = "triggered";
   conditions = {
      { "WhenYouPlayEnlightenedHero", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerMayRecoverCardFromDiscardIntoHand", 0 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}

g_ascension_cards["Imaginative Matron"] = {
	card_name = "Imaginative Matron";
    card_set = "DS";
	card_type = "Hero";
	faction = "Enlightened";
	dream = true;
	
	insight_cost = 3;
	honor = 2;

   effects = {
      { "DrawCards", 1 },
      { "DiscardFromHand", 0 },
      { "PutCardFromDiscardIntoHand", 1, condition={"IfPlayedEnlightenedHero",1} },
      { "UniteRecoverDiscardIntoHand", 0, condition={"IfHaventPlayedEnlightenedHero",1} },
   };
	effect_text = "Draw a card, then discard a card.\n" ..
					"UNITE: Return a card from your discard pile to your hand.";

   ai = {
      gain_draw = 1;
   },
   
   image_large = { "EDH_ImaginativeMatron", {0, 0, 364/512, 1} };
   image_medium = { "EDH_ImaginativeMatron", {392/512, 0, 512/512, 168/512} };
   image_small = { "EDH_ImaginativeMatron", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EDH_ImaginativeMatron", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}

g_ascension_active_effects["unite double runes"] = {
   type = "triggered";
   conditions = {
      { "WhenYouPlayLifeboundHero", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerDoubleCurrentTurnRunes", 0 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}

g_ascension_cards["Reverie Muse"] = {
	card_name = "Reverie Muse";
    card_set = "DS";
	card_type = "Hero";
	faction = "Lifebound";
	dream = true;
	
	insight_cost = 3;
	honor = 2;

   effects = {
      { "GainRunes", 1 },
      { "DoubleCurrentTurnRunes", p, condition={"IfPlayedLifeboundHero",1} },
      { "UniteDoubleRunes", 0, condition={"IfHaventPlayedLifeboundHero",1} },
   };
	effect_text = "Gain 1R.\n" ..
					"UNITE: Double your R.";

   ai = {
      gain_runes = 4;
   },
   
   image_large = { "LDH_ReverieMuse", {0, 0, 364/512, 1} };
   image_medium = { "LDH_ReverieMuse", {392/512, 0, 512/512, 168/512} };
   image_small = { "LDH_ReverieMuse", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LDH_ReverieMuse", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}


g_ascension_cards["Brainstorm Sentry"] = {
	card_name = "Brainstorm Sentry";
    card_set = "DS";
	card_type = "Hero";
	faction = "Mechana";
	dream = true;
	
	insight_cost = 3;
	honor = 2;

   effects = {
      { "GainRunesForEachMechanaConstructInPlay", 1 },
      { "GainPowerForEachMechanaConstructInPlay", 1 },
   };
	effect_text = "Gain 1R and 1P for each Mechana Construct you control.";

   ai = {
      gain_runes = 2;
      gain_power = 2;
   },
   
   image_large = { "MDH_BrainstormSentry", {0, 0, 364/512, 1} };
   image_medium = { "MDH_BrainstormSentry", {392/512, 0, 512/512, 168/512} };
   image_small = { "MDH_BrainstormSentry", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MDH_BrainstormSentry", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}

g_ascension_active_effects["unite double power"] = {
   type = "triggered";
   conditions = {
      { "WhenYouPlayVoidHero", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerDoubleCurrentTurnPower", 0 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}


g_ascension_cards["Bringer of Despair"] = {
	card_name = "Bringer of Despair";
    card_set = "DS";
	card_type = "Hero";
	faction = "Void";
	dream = true;
	
	insight_cost = 3;
	honor = 2;

   effects = {
      { "GainPower", 2 },
      { "DoubleCurrentTurnPower", p, condition={"IfPlayedVoidHero",1} },
      { "UniteDoublePower", 0, condition={"IfHaventPlayedVoidHero",1} },
   };
	effect_text = "Gain 2P.\n" ..
					"UNITE: Double your P.";

   ai = {
      gain_power = 6;
   },

   image_large = { "VDH_BringerDespair", {0, 0, 364/512, 1} };
   image_medium = { "VDH_BringerDespair", {392/512, 0, 512/512, 168/512} };
   image_small = { "VDH_BringerDespair", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VDH_BringerDespair", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}


g_ascension_cards["Pasythea, the Aegis"] = {
	card_name = "Pasythea, the Aegis";
    card_set = "DS";
	card_type = "Hero";
	factions = { "Enlightened", "Lifebound", "Mechana", "Void" };
	dream = true;
	
	insight_cost = 7;
	honor = 5;

   global_continuous_effects = {
      {
         priority = -5;
         effect = { "MayAcquireThisCardToHandAtNoCostIfPasytheasWard", 0 };
      },
   };

   effects = {
      { "GainRunes", 3 },
      { "GainPower", 3 },
      { "GainHonor", 3 },
   };
	effect_text = "This Hero counts as all factions. " ..
					"Gain 3R, 3P, 3H.\n" ..
					"If you control Pasythea's Ward, you may acquire this " ..
					"without paying its cost and put it into your hand.";

   ai = {
      gain_runes = 3;
      gain_power = 3;
      gain_honor = 3;
   },
   
   image_large = { "DH_PasytheaAegis", {0, 0, 364/512, 1} };
   image_medium = { "DH_PasytheaAegis", {392/512, 0, 512/512, 168/512} };
   image_small = { "DH_PasytheaAegis", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "DH_PasytheaAegis", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}




g_ascension_cards["Chronicle of Vigil"] = {
	card_name = "Chronicle of Vigil";
    card_set = "DS";
	card_type = "Construct";
	dream = true;
	
	insight_cost = 2;
	honor = 2;

   construct_ability = {
      description = "Gain X Honor";
      { "GainHonorForEachTypeOfConstructInPlay", 1 },
   };

   effect_text = "Once per turn, gain 1H for each faction among Constructs you control. " ..
					"(This card has no faction.)";

   ai = {
      gain_honor = 2;
   },
   
   image_large = { "DC_ChronicleVigil", {0, 0, 364/512, 1} };
   image_medium = { "DC_ChronicleVigil", {392/512, 0, 512/512, 168/512} };
   image_small = { "DC_ChronicleVigil", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "DC_ChronicleVigil", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}

g_ascension_cards["Vigil's Resolve"] = {
	card_name = "Vigil's Resolve";
    card_set = "DS";
	card_type = "Construct";
	dream = true;
	
	insight_cost = 2;
	honor = 3;

   triggered_effects = {
      {
         conditions = {
            { "WhenConstructOwnerPlaysMystic", 0 },
         };
         triggereffect = {
            { "TriggerConstructGainRunes", 1 },
         };
      },
      {
         conditions = {
            { "WhenConstructOwnerPlaysHeavyInfantry", 0 },
         };
         triggereffect = {
            { "TriggerConstructGainPower", 1 },
         };
      },
   };
	effect_text = "When you play a Mystic, gain 1R.\n" ..
					"When you play a Heavy Infantry, gain 1P.";

   ai = {
      gain_runes = 1;
      gain_power = 1;
   },
   
   image_large = { "DC_VigilsResolve", {0, 0, 364/512, 1} };
   image_medium = { "DC_VigilsResolve", {392/512, 0, 512/512, 168/512} };
   image_small = { "DC_VigilsResolve", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "DC_VigilsResolve", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}


g_ascension_cards["Askaran Armor"] = {
	card_name = "Askaran Armor";
    card_set = "DS";
	card_type = "Construct";
	faction = "Enlightened";
	dream = true;
	
	insight_cost = 1;
	honor = 1;

   triggered_effects = {
      {
         conditions = {
            { "WhenConstructOwnerAcquiresFromDreamscape", 0 },
            { "IfThisHasntBeenUsedThisTurn", 0 },
         };
         triggereffect = {
            { "TriggerConstructOwnerAddCardsToDreamscape", 1 },
            { "TriggerSetThisHasBeenUsedThisTurn", 0 },
         };
      },
   };


	effect_text = "Once per turn, when you acquire a card from your Dreamscape, " ..
					"you may add a card to your Dreamscape.";

   ai = {
      gain_dreamscape = 1;
   },
   
   image_large = { "EDC_AskaranArmor", {0, 0, 364/512, 1} };
   image_medium = { "EDC_AskaranArmor", {392/512, 0, 512/512, 168/512} };
   image_small = { "EDC_AskaranArmor", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EDC_AskaranArmor", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}


g_ascension_cards["Yggdrasil Canopy"] = {
	card_name = "Yggdrasil Canopy";
    card_set = "DS";
	card_type = "Construct";
	faction = "Lifebound";
	dream = true;
	
	insight_cost = 5;
	honor = 2;

   triggered_effects = {
      {
         conditions = {
            { "WhenConstructOwnerGainsHonorFromNonMonster", 0 },
         };
         triggereffect = {
            { "TriggerHonorGainMultiply", 2 },
         };
      },
   };
	effect_text = "When you would gain H without defeating a Monster, " ..
					"gain twice that much H instead.";

   ai = {
      gain_honor = 3;
   },
   
   image_large = { "LDC_YggdrasilCanopy", {0, 0, 364/512, 1} };
   image_medium = { "LDC_YggdrasilCanopy", {392/512, 0, 512/512, 168/512} };
   image_small = { "LDC_YggdrasilCanopy", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LDC_YggdrasilCanopy", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}


g_ascension_cards["Dream Lab"] = {
	card_name = "Dream Lab";
    card_set = "DS";
	card_type = "Construct";
	faction = "Mechana";
	dream = true;
	
	insight_cost = 2;
	honor = 2;

   continuous_effects = {
      {
         effect = { "ReduceConstructRuneCost", 1 };
      },
   };

   effect_text = "You may pay 1R less to acquire Constructs in the center row.";

   ai = {
   },
   
   image_large = { "MDC_DreamLab", {0, 0, 364/512, 1} };
   image_medium = { "MDC_DreamLab", {392/512, 0, 512/512, 168/512} };
   image_small = { "MDC_DreamLab", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MDC_DreamLab", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}


g_ascension_cards["Arbiter's Censer"] = {
	card_name = "Arbiter's Censer";
    card_set = "DS";
	card_type = "Construct";
	faction = "Void";
	dream = true;
	
	insight_cost = 3;
	honor = 2;

   triggered_effects = {
      {
         conditions = {
            { "WhenConstructOwnerDefeatsMonster", 0 },
         };
         triggereffect = {
            { "TriggerConstructGainHonor", 2 },
         };
      },
   };
	effect_text = "When you defeat a Monster in the center row, gain 2H.";

   ai = {
      gain_honor = 2;
   },
   
   image_large = { "VDC_ArbitersCenser", {0, 0, 364/512, 1} };
   image_medium = { "VDC_ArbitersCenser", {392/512, 0, 512/512, 168/512} };
   image_small = { "VDC_ArbitersCenser", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VDC_ArbitersCenser", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}







g_ascension_cards["Ashes to Ashes"] = {
	card_name = "Ashes to Ashes";
    card_set = "DS";
	card_type = "Vision";
	dream = true;
	
	insight_cost = 3;



   effects = {
      { "BanishAllCenterRow", 0 },
   };
	effect_text = "Banish all cards in the center row.";

   ai = {
   },
   
   image_large = { "DV_AshesAshes", {0, 0, 364/512, 1} };
   image_medium = { "DV_AshesAshes", {392/512, 0, 512/512, 168/512} };
   image_small = { "DV_AshesAshes", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "DV_AshesAshes", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}

g_ascension_cards["Dust to Dust"] = {
	card_name = "Dust to Dust";
    card_set = "DS";
	card_type = "Vision";
	dream = true;
	
	insight_cost = 3;

   effects = {
      { "EachOpponentDestroysAllConstructsInPlay", 0 },
   };
	effect_text = "Destroy all Constructs your opponents control.";

   ai = {
   },
   
   image_large = { "DV_DustDust", {0, 0, 364/512, 1} };
   image_medium = { "DV_DustDust", {392/512, 0, 512/512, 168/512} };
   image_small = { "DV_DustDust", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "DV_DustDust", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}


g_ascension_cards["Armistice"] = {
	card_name = "Armistice";
    card_set = "DS";
	card_type = "Vision";
	dream = true;
	
	insight_cost = 7;

   effects = {
      { "DiscardEntireHand", 0 },
      { "DrawCards", 5 },
      { "EachOpponentDiscardsEntireHand", 0 },
      { "EachOpponentMustDrawCards", 5 },
   };
	effect_text = "Each player discards their hand and draws five cards.";

   ai = {
   },
   
   image_large = { "DV_Armistice", {0, 0, 364/512, 1} };
   image_medium = { "DV_Armistice", {392/512, 0, 512/512, 168/512} };
   image_small = { "DV_Armistice", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "DV_Armistice", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}


g_ascension_cards["Wicked End"] = {
	card_name = "Wicked End";
    card_set = "DS";
	card_type = "Vision";
	dream = true;
	
	insight_cost = 7;

   effects = {
      { "DefeatMonsterFromCenterRowWithLessPower", 0 },
   };
	effect_text = "Defeat a Monster in the center row without paying its cost.";

   ai = {
   },
   
   image_large = { "DV_WickedEnd", {0, 0, 364/512, 1} };
   image_medium = { "DV_WickedEnd", {392/512, 0, 512/512, 168/512} };
   image_small = { "DV_WickedEnd", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "DV_WickedEnd", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}



g_ascension_cards["Test of Faith"] = {
	card_name = "Test of Faith";
    card_set = "DS";
	card_type = "Vision";
	faction = "Enlightened";
	dream = true;
	
	insight_cost = 5;


   effects = {
      { "DrawHeroOrDefeatTopOfCenterDeck", 0 },
   };

	effect_text = "Reveal the top card of the center deck. " ..
				 "Acquire or defeat it without paying its cost. " ..
				 "If you acquire a Hero this way, put it into your hand.";

   ai = {
   },
   
   image_large = { "EDV_TestFaith", {0, 0, 364/512, 1} };
   image_medium = { "EDV_TestFaith", {392/512, 0, 512/512, 168/512} };
   image_small = { "EDV_TestFaith", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EDV_TestFaith", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}

g_ascension_cards["Aura of the Askara"] = {
	card_name = "Aura of the Askara";
    card_set = "DS";
	card_type = "Vision";
	faction = "Enlightened";
	dream = true;
   ongoing = true;

	insight_cost = 10;

   global_continuous_effects = {
      {
         priority = -2;
         effect = { "MayAcquireThisCardAtNoCostIfPlayedSameEnlightenedHeroes", 0 };
      },
   };
   cardinplay_abilities = {
      {
         description = "Copy Played Hero";
         condition = { "IfPlayedCopyableHero", 5 },
         { "PushResolvingConstruct", 0 },
         { "CopyEffectOfAnyPlayedHero", 0 },
         { "PopResolvingCardInPlay", 0 },
      },
   };

	effect_text = "If you have played two Enlightened Heroes " ..
					"with the same name this turn, " ..
					"you may acquire this without paying its cost.\n" ..
					"ONGOING: Once per turn, you may copy the effect " ..
					"of a Hero you have played this turn.";

   ai = {
   },
   
   image_large = { "EDV_AuraAskara", {0, 0, 364/512, 1} };
   image_medium = { "EDV_AuraAskara", {392/512, 0, 512/512, 168/512} };
   image_small = { "EDV_AuraAskara", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EDV_AuraAskara", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}

g_ascension_cards["Lunar Embrace"] = {
	card_name = "Lunar Embrace";
    card_set = "DS";
	card_type = "Vision";
	faction = "Lifebound";
	dream = true;
	
	insight_cost = 1;

   effects = {
      { "UseRunesAsPowerUntilEndOfTurn", 0 }
   };
	effect_text = "This turn you may spend R as though it was P.";

   ai = {
   },
   
   image_large = { "LDV_LunarEmbrace", {0, 0, 364/512, 1} };
   image_medium = { "LDV_LunarEmbrace", {392/512, 0, 512/512, 168/512} };
   image_small = { "LDV_LunarEmbrace", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LDV_LunarEmbrace", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}

g_ascension_cards["Cetra's Respite"] = {
	card_name = "Cetra's Respite";
    card_set = "DS";
	card_type = "Vision";
	faction = "Lifebound";
	dream = true;
	
	insight_cost = 6;

   effects = {
      { "AcquireHeroFromCenterRow", 0 },
   };
	effect_text = "Acquire a Hero in the center row without paying its cost.";

   ai = {
   },
   
   image_large = { "LDV_CetrasRespite", {0, 0, 364/512, 1} };
   image_medium = { "LDV_CetrasRespite", {392/512, 0, 512/512, 168/512} };
   image_small = { "LDV_CetrasRespite", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LDV_CetrasRespite", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}

g_ascension_cards["Nairi's Blessing"] = {
	card_name = "Nairi's Blessing";
    card_set = "DS";
	card_type = "Vision";
	faction = "Lifebound";
	dream = true;
   ongoing = true;
   counts_as_played_hero = true;

	insight_cost = 10;

   global_continuous_effects = {
      {
         priority = -2;
         effect = { "MayAcquireThisCardAtNoCostIfPlayedLifeboundHero", 3 };
      },
   };

   triggered_effects = {
      {
         version_after = 23;
         conditions = {
            { "AtStartOfOwnerTurn", 0 },
         };
         triggereffect = {
            { "TriggerSendPlayHeroEvent", 0 },
         };
      },
   };

   effects = {
      { "GainHonor", 10 },
      { "SendPlayHeroEvent", 0 },
   };
	effect_text = "If you have played three or more Lifebound Heroes this turn, " ..
					"you may acquire this without paying its cost.\n" ..
					"Gain 10H.\n" ..
					"ONGOING: You are considered to have played a Lifebound Hero each turn.";

   ai = {
   },
   
   image_large = { "LDV_NairisBlessing", {0, 0, 364/512, 1} };
   image_medium = { "LDV_NairisBlessing", {392/512, 0, 512/512, 168/512} };
   image_small = { "LDV_NairisBlessing", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LDV_NairisBlessing", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}


g_ascension_cards["Technological Leap"] = {
	card_name = "Technological Leap";
    card_set = "DS";
	card_type = "Vision";
	faction = "Mechana";
	dream = true;
	
	insight_cost = 5;


   effects = {
      { "AcquireAllConstructsInCenterRow", 0 },
   };
	effect_text = "Acquire all Constructs in the center row without paying their cost.";

   ai = {
   },
   
   image_large = { "MDV_TechnologicalLeap", {0, 0, 364/512, 1} };
   image_medium = { "MDV_TechnologicalLeap", {392/512, 0, 512/512, 168/512} };
   image_small = { "MDV_TechnologicalLeap", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MDV_TechnologicalLeap", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}


g_ascension_cards["Order of the Gear"] = {
	card_name = "Order of the Gear";
    card_set = "DS";
	card_type = "Vision";
	faction = "Mechana";
	dream = true;
   ongoing = true;

	insight_cost = 10;

   global_continuous_effects = {
      {
         priority = -2;
         effect = { "MayAcquireThisCardAtNoCostIfControlConstructs", 4 };
      },
   };
   effects = {
      { "TreatMechanaHeroesAsConstructs", 0 },
   };

	effect_text = "If you control four or more Constructs, " ..
					"you may acquire this without paying its cost.\n" ..
					"ONGOING: Your Mechana Heroes are Constructs instead. " ..
					"You may use their abilities once per turn.";

   ai = {
   },
   
   image_large = { "MDV_OrderGear", {0, 0, 364/512, 1} };
   image_medium = { "MDV_OrderGear", {392/512, 0, 512/512, 168/512} };
   image_small = { "MDV_OrderGear", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MDV_OrderGear", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}





g_ascension_cards["Stalk the Shadows"] = {
	card_name = "Stalk the Shadows";
    card_set = "DS";
	card_type = "Vision";
	faction = "Void";
	dream = true;
	
	insight_cost = 1;

   effects = {
      { "MayDefeatMonstersFromVoidUntilEndOfTurn", 0 },
   };
	effect_text = "This turn you may defeat Monsters in the void " ..
					"as though they were in the center row.";

   ai = {
   },
   
   image_large = { "VDV_StalkShadow", {0, 0, 364/512, 1} };
   image_medium = { "VDV_StalkShadow", {392/512, 0, 512/512, 168/512} };
   image_small = { "VDV_StalkShadow", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VDV_StalkShadow", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}

g_ascension_cards["Call of Darkness"] = {
	card_name = "Call of Darkness";
    card_set = "DS";
	card_type = "Vision";
	faction = "Void";
	dream = true;
	
	insight_cost = 8;

   effects = {
      { "BanishMultipleFromHandOrDiscard", 5 },
   };
	effect_text = "Banish up to 5 cards in your hand or discard pile.";

   ai = {
   },
   
   image_large = { "VDV_CallDarkness", {0, 0, 364/512, 1} };
   image_medium = { "VDV_CallDarkness", {392/512, 0, 512/512, 168/512} };
   image_small = { "VDV_CallDarkness", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VDV_CallDarkness", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}

g_ascension_cards["Berserker Frenzy"] = {
	card_name = "Berserker Frenzy";
    card_set = "DS";
	card_type = "Vision";
	faction = "Void";
	dream = true;
   ongoing = true;

	insight_cost = 10;

   global_continuous_effects = {
      {
         priority = -2;
         effect = { "MayAcquireThisCardAtNoCostIfDefeatedMonsters", 3 };
      },
   };
   triggered_effects = {
      {
         conditions = {
            { "WhenOwnerGainsHonorFromMonster", 0 },
         };
         triggereffect = {
            { "TriggerBerserkerFrenzy", 0 },
         };
      },
   };
   effects = {
      { "GainHonor", 10 },
   };
	effect_text = "If you have defeated three or more Monsters in the center row this turn, " ..
					"you may acquire this without paying its cost.\n" ..
					"Gain 10H.\n" ..
					"ONGOING: Once per turn, when you defeat a Monster, double its H reward.";

   ai = {
      gain_honor = 3;
   },
   
   image_large = { "VDV_BerserkerFrenzy", {0, 0, 364/512, 1} };
   image_medium = { "VDV_BerserkerFrenzy", {392/512, 0, 512/512, 168/512} };
   image_small = { "VDV_BerserkerFrenzy", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VDV_BerserkerFrenzy", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}



