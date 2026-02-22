


g_ascension_cards["Twilight Scout"] = {
	card_name = "Twilight Scout";
    card_set = "WoS";
	card_type = "Hero";
	faction = "Enlightened";
   day_night = "day";

	rune_cost = 1;
   power_cost = 1;
	honor = 2;

   effects = {
      { "DrawCards", 1 },
      { "OutputPauseForEffectDayNight", 0, condition={"IfIsDay",0} },
      { "MarkPlayedEffectDay", 1, condition={"IfIsDay",0} },
      { "DrawCards", 1, condition={"IfIsDay",0} },
   };

	--effect_text = "Draw a card.\n" ..
    --              "DAY: Draw an additional card.";
	effect_text = "Draw a card.";
	day_text = "DAY: Draw an additional card.";

   ai = {
   },
   
   image_large = { "EH_TwilightScout", {0, 0, 364/512, 1} };
   image_medium = { "EH_TwilightScout", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_TwilightScout", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_TwilightScout", {384/512, 395/512, 512/512, 512/512} };

   highlight_day = { -0.002, 0.24, 0, 0.94 };

   rarity_count = 3

}


g_ascension_cards["Inspired Templar"] = {
   card_name = "Inspired Templar";
    card_set = "WoS";
   card_type = "Hero";
   faction = "Enlightened";
   day_night = "day";

   rune_cost = 4;
   honor = 2;

   effects = {
      { "StoreDayNightFlagsToEffectInstanceData", 0 },
      { "OutputPauseForEffectDayNight", 0, condition={"IfEffectInstanceDataIsDay",0} },
      { "MarkPlayedEffectDay", 1, condition={"IfEffectInstanceDataIsDay",0} },
      { "DefeatMonsterWithLessPower", 4, condition={"IfEffectInstanceDataIsNotDay",0} },
      { "DefeatMonsterWithLessPower", 0, condition={"IfEffectInstanceDataIsDay",0} },
   };

   --effect_text = "Defeat a Monster with cost 4P or less without paying its cost.\n" ..
   --               "DAY: Defeat any Monster instead.";
   effect_text = "Defeat a Monster with cost 4P or less without paying its cost.";
   day_text = "DAY: Defeat any Monster instead.";

   ai = {
   },

   image_large = { "EH_InspiredTemplar", {0, 0, 364/512, 1} };
   image_medium = { "EH_InspiredTemplar", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_InspiredTemplar", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_InspiredTemplar", {384/512, 395/512, 512/512, 512/512} };

   highlight_day = { -0.036, 0.23, 0, 0.94 };

   rarity_count = 3

}



g_ascension_cards["Pillar of Resolve"] = {
   card_name = "Pillar of Resolve";
    card_set = "WoS";
   card_type = "Construct";
   faction = "Enlightened";
   day_night = "day";

   rune_cost = 3;
   power_cost = 3;
   honor = 4;

   construct_abilities = {
      {
         description = "Draw 2 cards";
         condition = { "IfPlayedMysticAndHeavyInfantry", 1 },
         { "DrawCards", 2 },

         ai = {
            trivial_draw = 2,

            gain_draw = 2,
         },
      },
   };

   effect_text = "Once per turn, if you have played a Mystic and a Heavy Infantry, draw two cards.";

   ai = {
   },

   image_large = { "EC_PillarResolve", {0, 0, 364/512, 1} };
   image_medium = { "EC_PillarResolve", {392/512, 0, 512/512, 168/512} };
   image_small = { "EC_PillarResolve", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EC_PillarResolve", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1

}



g_ascension_cards["Ta'hyr, the Sun"] = {
   card_name = "Ta'hyr, the Sun";
    card_set = "WoS";
   card_type = "Hero";
   faction = "Enlightened";
   day_night = "day";

   rune_cost = 7;
   honor = 5;

   center_row_continuous_effects = {
      {
         conditions = {
            { "TriggerIfAllCenterRowIsDay", 0 },
         };
         effect = { "MayAcquireThisAtNoCost", 0 };
      },
   };

   effects = {
      { "StoreDayNightFlagsToEffectInstanceData", 0 },
      { "OutputPauseForEffectDayNight", 0, condition={"IfEffectInstanceDataIsDay",0} },
      { "MarkPlayedEffectDay", 1, condition={"IfEffectInstanceDataIsDay",0} },
      { "AcquireAnyCenterRow", 0, condition={"IfEffectInstanceDataIsNotDay",0} },
      { "AcquireAnyCenterRowToHand", 0, condition={"IfEffectInstanceDataIsDay",0} },
   };

   --effect_text = "If all cards in the center row are DAY cards, " ..
   --               "you may acquire this without paying its cost.\n" ..
   --               "Acquire a card in the center row without paying its cost.\n" ..
   --               "DAY: Add the acquired card to your hand.";
   effect_text = "If all cards in the center row are DAY cards, " ..
                  "you may acquire this without paying its cost.\n" ..
                  "Acquire a card in the center row without paying its cost.";
   day_text = "DAY: Add the acquired card to your hand.";

   ai = {
   },

   image_large = { "EH_TahyrSun", {0, 0, 364/512, 1} };
   image_medium = { "EH_TahyrSun", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_TahyrSun", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_TahyrSun", {384/512, 395/512, 512/512, 512/512} };

   highlight_day = { -0.098, 0.20, 0, 0.94 };

   rarity_count = 1

}


g_ascension_cards["Shrine Attendant"] = {
   card_name = "Shrine Attendant";
    card_set = "WoS";
   card_type = "Hero";
   faction = "Enlightened";
   day_night = "night";

   rune_cost = 2;
   honor = 1;

   effects = {
      { "AcquireMysticOrHeavyInfantryToHand", 0 },
   };

   effect_text = "Add a Mystic or Heavy Infantry to your hand.";

   ai = {
   },

   image_large = { "EH_ShrineAttendant", {0, 0, 364/512, 1} };
   image_medium = { "EH_ShrineAttendant", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_ShrineAttendant", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_ShrineAttendant", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3

}

g_ascension_cards["Searing Askara"] = {
   card_name = "Searing Askara";
    card_set = "WoS";
   card_type = "Hero";
   faction = "Enlightened";
   day_night = "night";

   rune_cost = 3;
   honor = 2;

   effects = {
      { "BanishFromCenterRow", 1 },
      { "AcquireCardWithCostLessThan", 3 },
   };

   effect_text = "Banish a card in the center row. " ..
                  "Then you may acquire a card with cost 3R or less " ..
                     "without paying its cost.";

   ai = {
   },

   image_large = { "EH_SearingAskara", {0, 0, 364/512, 1} };
   image_medium = { "EH_SearingAskara", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_SearingAskara", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_SearingAskara", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2

}

g_ascension_active_effects["draw card when play mystic or heavy infantry"] = {
   type = "triggered";
   conditions = {
      { "WhenYouPlayMysticOrHeavyInfantry", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerEffectPlayerDrawCards", 1 },
      { "TriggerRemovePlayedCardEffectActive", 0 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}

g_ascension_cards["Arha Historian"] = {
   card_name = "Arha Historian";
    card_set = "WoS";
   card_type = "Hero";
   faction = "Enlightened";
   day_night = "night";

   rune_cost = 4;
   honor = 2;

   effects = {
      { "DrawCards", 1 },
      { "DrawCards", 1, condition={"IfPlayedMysticOrHeavyInfantry",0} },
      { "Draw1CardNextTimeYouPlayMysticOrHeavyInfantry", 1, condition={"IfHasNotPlayedMysticOrHeavyInfantry",0} },
   };

   effect_text = "Draw a card. " ..
                  "If you play or have played a Mystic or Heavy Infantry this turn, " ..
                  "draw an additional card.";

   ai = {
   },

   image_large = { "EH_ArhaHistorian", {0, 0, 364/512, 1} };
   image_medium = { "EH_ArhaHistorian", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_ArhaHistorian", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_ArhaHistorian", {384/512, 395/512, 512/512, 512/512} };

   highlight_played_effect = { 0.038, 0.50, 0, 0.98 };

   rarity_count = 3

}


g_ascension_cards["Bringer of Hope"] = {
   card_name = "Bringer of Hope";
    card_set = "WoS";
   card_type = "Hero";
   faction = "Enlightened";
   day_night = "night";

   rune_cost = 4;
   power_cost = 2;
   honor = 4;

   effects = {
      { "BanishFromHand", 0 },
      { "AcquireMysticToHand", 0, condition={"IfYouDo",0} },
      { "AcquireHeavyInfantryToHand", 0, condition={"IfYouDo",0} },
   };

   effect_text = "Banish a card in your hand. " ..
                  "If you do, add a Mystic AND a Heavy Infantry to your hand.";

   ai = {
   },

   image_large = { "EH_BringerHope", {0, 0, 364/512, 1} };
   image_medium = { "EH_BringerHope", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_BringerHope", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_BringerHope", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2

}




g_ascension_cards["Sunstreak Courier"] = {
   card_name = "Sunstreak Courier";
    card_set = "WoS";
   card_type = "Hero";
   faction = "Lifebound";
   day_night = "day";

   rune_cost = 1;
   honor = 1;

   effects = {
      { "GainRunes", 1 },
      { "GainPower", 1 },
   };

   effect_text = "Gain 1R and 1P.";

   ai = {
   },

   image_large = { "LH_SunstreakCourier", {0, 0, 364/512, 1} };
   image_medium = { "LH_SunstreakCourier", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_SunstreakCourier", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_SunstreakCourier", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3

}

g_ascension_active_effects["unite 3H"] = {
   type = "triggered";
   conditions = {
      { "WhenYouPlayLifeboundHero", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerGainHonor", 3 },
      { "TriggerRemovePlayedCardEffectActive", 0 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}

g_ascension_cards["Everbloom Witch"] = {
   card_name = "Everbloom Witch";
    card_set = "WoS";
   card_type = "Hero";
   faction = "Lifebound";
   day_night = "day";

   rune_cost = 3;
   honor = 2;

   effects = {
      { "GainHonor", 3 },
      { "GainHonor", 3, condition={"IfPlayedLifeboundHero",1} },
      { "Unite3H", 0, condition={"IfHaventPlayedLifeboundHero",1} },
   };

   effect_text = "Gain 3H.\n" ..
                  "UNITE: Gain 3H.";

   ai = {
   },

   image_large = { "LH_EverbloomWitch", {0, 0, 364/512, 1} };
   image_medium = { "LH_EverbloomWitch", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_EverbloomWitch", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_EverbloomWitch", {384/512, 395/512, 512/512, 512/512} };

   highlight_played_effect = { 0.025, 0.19, 0, 0.98 };

   rarity_count = 3

}


g_ascension_active_effects["unite gain 1R 1H 1D"] = {
   type = "triggered";
   conditions = {
      { "WhenYouPlayLifeboundHero", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerGainRunes", 1 },
      { "TriggerGainHonor", 1 },
      { "TriggerEffectPlayerDrawCards", 1 },
      { "TriggerRemovePlayedCardEffectActive", 0 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}

g_ascension_cards["Marsh Ranger"] = {
   card_name = "Marsh Ranger";
    card_set = "WoS";
   card_type = "Hero";
   faction = "Lifebound";
   day_night = "day";

   rune_cost = 3;
   power_cost = 3;
   honor = 4;

   effects = {
      { "GainRunes", 1 },
      { "GainHonor", 1 },
      { "DrawCards", 1 },
      { "GainRunes", 1, condition={"IfPlayedLifeboundHero",1} },
      { "GainHonor", 1, condition={"IfPlayedLifeboundHero",1} },
      { "DrawCards", 1, condition={"IfPlayedLifeboundHero",1} },
      { "UniteGain1Rand1HandDraw1Card", 0, condition={"IfHaventPlayedLifeboundHero",1} },
   };

   effect_text = "Gain 1R and 1H. Draw a card.\n" ..
                  "UNITE: Gain 1R and 1H. Draw a card.";

   ai = {
   },

   image_large = { "LH_MarshRanger", {0, 0, 364/512, 1} };
   image_medium = { "LH_MarshRanger", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_MarshRanger", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_MarshRanger", {384/512, 395/512, 512/512, 512/512} };

   highlight_played_effect = { 0.027, 0.19, 0, 0.98 };

   rarity_count = 2

}


g_ascension_cards["Vyrak, the First"] = {
   card_name = "Vyrak, the First";
    card_set = "WoS";
   card_type = "Hero";
   faction = "Lifebound";
   day_night = "day";

   rune_cost = 12;
   spend_power_to_acquire = true;
   honor = 7;

   effects = {
      { "GainHonor", 10 },
   };

   effect_text = "You may spend P as R to acquire this.\n" ..
                  "Gain 10H.";

   ai = {
   },

   image_large = { "LH_VyrakFirst", {0, 0, 364/512, 1} };
   image_medium = { "LH_VyrakFirst", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_VyrakFirst", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_VyrakFirst", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1

}


g_ascension_cards["Lunar Guardian"] = {
   card_name = "Lunar Guardian";
    card_set = "WoS";
   card_type = "Hero";
   faction = "Lifebound";
   day_night = "night";

   rune_cost = 1;
   power_cost = 1;
   honor = 2;

   effects = {
      { "GainRunes", 2 },
      { "OutputPauseForEffectDayNight", 0, condition={"IfIsNight",0} },
      { "MarkPlayedEffectNight", 1, condition={"IfIsNight",0} },
      { "GainPower", 2, condition={"IfIsNight",0} },
   };

   --effect_text = "Gain 2R.\n" ..
   --               "NIGHT: Gain 2P.";
   effect_text = "Gain 2R.";
   night_text = "NIGHT: Gain 2P.";

   ai = {
   },

   image_large = { "LH_LunarGuardian", {0, 0, 364/512, 1} };
   image_medium = { "LH_LunarGuardian", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_LunarGuardian", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_LunarGuardian", {384/512, 395/512, 512/512, 512/512} };

   highlight_night = { -0.002, 0.26, 0, 0.94 };

   rarity_count = 3

}

g_ascension_cards["Verdant Chanter"] = {
   card_name = "Verdant Chanter";
    card_set = "WoS";
   card_type = "Hero";
   faction = "Lifebound";
   day_night = "night";

   rune_cost = 2;
   power_cost = 2;
   honor = 2;

   effects = {
      { "GainRunes", 2 },
      { "OutputPauseForEffectDayNight", 0, condition={"IfIsNight",0} },
      { "MarkPlayedEffectNight", 1, condition={"IfIsNight",0} },
      { "YouMayAcquireHeroesToTopOfDeckThisTurn", 0, condition={"IfIsNight",0} },
   };

   --effect_text = "Gain 2R.\n" ..
   --               "NIGHT: You may put Heroes you acquire this turn on top of your deck.";
   effect_text = "Gain 2R.";
   night_text = "NIGHT: You may put Heroes you acquire this turn on top of your deck.";

   ai = {
   },

   image_large = { "LH_VerdantChanter", {0, 0, 364/512, 1} };
   image_medium = { "LH_VerdantChanter", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_VerdantChanter", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_VerdantChanter", {384/512, 395/512, 512/512, 512/512} };

   highlight_night = { -0.014, 0.39, 0, 0.94 };

   rarity_count = 3

}


g_ascension_cards["Map of the Stars"] = {
   card_name = "Map of the Stars";
    card_set = "WoS";
   card_type = "Construct";
   faction = "Lifebound";
   day_night = "night";

   rune_cost = 5;
   honor = 3;

   construct_abilities = {
      {
         description = "Gain 1R and 1P";
         { "GainRunes", 1 },
         { "GainPower", 1 },

         ai = {
            trivial = true,
         },
      },
   };

   effect_text = "Once per turn, gain 1R and 1P.";

   ai = {
   },

   image_large = { "LC_MapStars", {0, 0, 364/512, 1} };
   image_medium = { "LC_MapStars", {392/512, 0, 512/512, 168/512} };
   image_small = { "LC_MapStars", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LC_MapStars", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2

}


g_ascension_cards["Luro, the Hunter"] = {
   card_name = "Luro, the Hunter";
    card_set = "WoS";
   card_type = "Hero";
   faction = "Lifebound";
   day_night = "night";

   rune_cost = 6;
   honor = 3;

   effects = {
      { "GainRunes", 3 },
      { "OutputPauseForEffectDayNight", 0, condition={"IfIsNight",0} },
      { "MarkPlayedEffectNight", 1, condition={"IfIsNight",0} },
      { "UseRunesAsPowerUntilEndOfTurn", 0, condition={"IfIsNight",0} },
      { "UsePowerAsRunesUntilEndOfTurn", 0, condition={"IfIsNight",0} },
   };

   --effect_text = "Gain 3R.\n" ..
   --               "NIGHT: You may spend R as P and P as R this turn.";
   effect_text = "Gain 3R.";
   night_text = "NIGHT: You may spend R as P and P as R this turn.";

   ai = {
   },

   image_large = { "LH_LuroHunter", {0, 0, 364/512, 1} };
   image_medium = { "LH_LuroHunter", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_LuroHunter", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_LuroHunter", {384/512, 395/512, 512/512, 512/512} };

   highlight_night = { -0.023, 0.43, 0, 0.94 };

   rarity_count = 1

}





g_ascension_cards["Solar Sentry"] = {
   card_name = "Solar Sentry";
    card_set = "WoS";
   card_type = "Hero";
   faction = "Mechana";
   day_night = "day";

   rune_cost = 1;
   power_cost = 1;
   honor = 2;

   effects = {
      { "GainRunes", 2 },
      { "OutputPauseForEffectDayNight", 0, condition={"IfIsDay",0} },
      { "MarkPlayedEffectDay", 1, condition={"IfIsDay",0} },
      { "GainRunes", 2, condition={"IfIsDay",0} },
   };

   --effect_text = "Gain 2R.\n" ..
   --               "DAY: Gain an additional 2R.";
   effect_text = "Gain 2R.";
   day_text = "DAY: Gain an additional 2R.";

   ai = {
   },

   image_large = { "MH_SolarSentry", {0, 0, 364/512, 1} };
   image_medium = { "MH_SolarSentry", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_SolarSentry", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_SolarSentry", {384/512, 395/512, 512/512, 512/512} };

   highlight_day = { -0.003, 0.25, 0, 0.94 };

   rarity_count = 3

}

g_ascension_active_effects["draw card when play flare tracker"] = {
   type = "triggered";
   conditions = {
      { "WhenYouPlayFlareTracker", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerEffectPlayerDrawCards", 1 },
      { "TriggerRemovePlayedCardEffectActive", 0 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}

g_ascension_cards["Sureshot Tracker"] = {
   card_name = "Sureshot Tracker";
    card_set = "WoS";
   card_type = "Hero";
   faction = "Mechana";
   day_night = "day";

   rune_cost = 2;
   honor = 1;

   effects = {
      { "GainPower", 2 },
      { "DrawCards", 1, condition={"IfHasPlayedFlareTracker",0} },
      { "Draw1CardNextTimeYouPlayFlareTracker", 1, condition={"IfHasNotPlayedFlareTracker",0} },
   };

   effect_text = "Gain 2P.\n" ..
                  "If you play or have played a Flare Tracker this turn, draw a card.";

   ai = {
   },

   image_large = { "MH_SureshotTracker", {0, 0, 364/512, 1} };
   image_medium = { "MH_SureshotTracker", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_SureshotTracker", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_SureshotTracker", {384/512, 395/512, 512/512, 512/512} };

   highlight_played_effect = { 0.004, 0.34, 0, 0.98 };

   rarity_count = 2

}

g_ascension_cards["Foundry Hound"] = {
   card_name = "Foundry Hound";
    card_set = "WoS";
   card_type = "Construct";
   faction = "Mechana";
   day_night = "day";

   rune_cost = 3;
   power_cost = 2;
   honor = 3;

   triggered_effects = {
      {
         conditions = {
            { "AtStartOfConstructOwnerTurn", 0 },
         };
         triggereffect = {
            { "TriggerConstructSetEffectDataToZero", 0 },
         };
      },
      {
         conditions = {
            { "WhenYouPutMechanaConstructIntoPlay", 0 },
            { "TriggerIfConstructEffectDataIsZero", 0 },
         };
         triggereffect = {
            { "TriggerConstructGainRunes", 2 },
            { "TriggerIncrementConstructEffectData", 0 },
         };
      },
   };
   construct_abilities = {
      {
         description = "Gain 2R";
         condition = { "IfConstructEffectDataEquals0AndIsDay", 0 },
         { "GainRunes", 2 },
         { "IncrementConstructEffectData", 0 },

         ai = {
            trivial = true,
         },
      },
   };

   effect_text = "Once per turn, if you play a Mechana Contruct " ..
                  "(including this one) or if it is Day, gain 2R.";

   ai = {
   },

   image_large = { "MC_FoundryHound", {0, 0, 364/512, 1} };
   image_medium = { "MC_FoundryHound", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_FoundryHound", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_FoundryHound", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2

}


g_ascension_cards["Watchtower Golem"] = {
   card_name = "Watchtower Golem";
    card_set = "WoS";
   card_type = "Construct";
   faction = "Mechana";
   day_night = "day";

   rune_cost = 4;
   honor = 4;

   triggered_effects = {
      {
         conditions = {
            { "AtStartOfConstructOwnerTurn", 0 },
         };
         triggereffect = {
            { "TriggerConstructSetEffectDataToZero", 0 },
         };
      },
      {
         conditions = {
            { "WhenYouPutMechanaConstructIntoPlay", 0 },
            { "TriggerIfConstructEffectDataIsZero", 0 },
         };
         triggereffect = {
            { "TriggerConstructGainPower", 2 },
            { "TriggerIncrementConstructEffectData", 0 },
         };
      },
   };
   construct_abilities = {
      {
         description = "Gain 2P";
         condition = { "IfConstructEffectDataEquals0AndIsDay", 0 },
         { "GainPower", 2 },
         { "IncrementConstructEffectData", 0 },

         ai = {
            trivial = true,
         },
      },
   };

   effect_text = "Once per turn, if you play a Mechana Contruct " ..
                  "(including this one) or if it is Day, gain 2P.";

   ai = {
   },

   image_large = { "MC_WatchtowerGolem", {0, 0, 364/512, 1} };
   image_medium = { "MC_WatchtowerGolem", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_WatchtowerGolem", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_WatchtowerGolem", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2

}

g_ascension_cards["Wrecklamax"] = {
   card_name = "Wrecklamax";
    card_set = "WoS";
   card_type = "Construct";
   faction = "Mechana";
   day_night = "day";

   power_cost = 2;
   rune_cost = 4;
   honor = 4;

   construct_abilities = {
      {
         description = "Draw a card";
         condition = { "IfIsDayOrPlayedMechanaConstructs", 1 },
         { "DrawCards", 1 },

         ai = {
            trivial_draw = 1,

            gain_draw = 1,
         },

      },
   };

   effect_text = "Once per turn, if you play a Mechana Contruct " ..
                  "(including this one) or if it is Day, draw a card.";

   ai = {
   },

   image_large = { "MC_Wrecklamax", {0, 0, 364/512, 1} };
   image_medium = { "MC_Wrecklamax", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_Wrecklamax", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_Wrecklamax", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2

}


g_ascension_cards["Illuminator"] = {
   card_name = "Illuminator";
    card_set = "WoS";
   card_type = "Construct";
   faction = "Mechana";
   day_night = "day";

   power_cost = 3;
   rune_cost = 6;
   honor = 6;

   construct_abilities = {
      {
         description = "Gain R and P";
         condition = { "IfIsDay", 0 },
         { "GainRunesForEachMechanaConstructInPlay", 1 },
         { "GainPowerForEachMechanaConstructInPlay", 1 },

         ai = {
         },
      },
   };

   --effect_text = "DAY: Once per turn, gain 1R and 1P " ..
   --               "for each Mechana Construct you control.";
   day_text = "DAY: Once per turn, gain 1R and 1P " ..
                  "for each Mechana Construct you control.";

   ai = {
   },

   image_large = { "MC_Illuminator", {0, 0, 364/512, 1} };
   image_medium = { "MC_Illuminator", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_Illuminator", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_Illuminator", {384/512, 395/512, 512/512, 512/512} };

   highlight_day = { 0.051, 0.40, 0, 0.90 };

   rarity_count = 1

}


g_ascension_active_effects["draw card when play sureshot tracker"] = {
   type = "triggered";
   conditions = {
      { "WhenYouPlaySureshotTracker", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerEffectPlayerDrawCards", 1 },
      { "TriggerRemovePlayedCardEffectActive", 0 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}


g_ascension_cards["Flare Tracker"] = {
   card_name = "Flare Tracker";
    card_set = "WoS";
   card_type = "Hero";
   faction = "Mechana";
   day_night = "night";

   rune_cost = 3;
   honor = 1;

   effects = {
      { "GainRunes", 2 },
      { "DrawCards", 1, condition={"IfHasPlayedSureshotTracker",0} },
      { "Draw1CardNextTimeYouPlaySureshotTracker", 1, condition={"IfHasNotPlayedSureshotTracker",0} },
   };

   effect_text = "Gain 2R.\n" ..
                  "If you play or have played a Sureshot Tracker this turn, draw a card.";

   ai = {
   },

   image_large = { "MH_FlareTracker", {0, 0, 364/512, 1} };
   image_medium = { "MH_FlareTracker", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_FlareTracker", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_FlareTracker", {384/512, 395/512, 512/512, 512/512} };

   highlight_played_effect = { 0.004, 0.34, 0, 0.98 };

   rarity_count = 2

}


g_ascension_cards["Rescuebot 505"] = {
   card_name = "Rescuebot 505";
    card_set = "WoS";
   card_type = "Construct";
   faction = "Mechana";
   day_night = "night";

   rune_cost = 5;
   honor = 5;

   global_continuous_effects = {
      {
         priority = -5;
         conditions = {
            { "TriggerIfIsDay", 0 },
         };
         effect = { "AcquireThisCardDirectlyIntoPlay", 0 };
      },
   };
   continuous_effects = {
      {
         priority = 8;
         effect = { "AcquireMechanaConstructDirectlyIntoPlay", 0 };
      },
   };

   effect_text = "When you acquire this and it is Day, put it directly into play.\n" ..
                  "When you acquire a Mechana Construct, put it directly into play.";

   ai = {
   },

   image_large = { "MC_Rescuebot505", {0, 0, 364/512, 1} };
   image_medium = { "MC_Rescuebot505", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_Rescuebot505", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_Rescuebot505", {384/512, 395/512, 512/512, 512/512} };

   highlight_centerrow_day = { 0.059, 0.31, 0, 0.94 };

   rarity_count = 2

}



g_ascension_cards["Shade Converter"] = {
   card_name = "Shade Converter";
    card_set = "WoS";
   card_type = "Construct";
   faction = "Mechana";
   day_night = "night";

   rune_cost = 7;
   honor = 7;

   continuous_effects = {
      {
         conditions = {
            { "TriggerIfIsQueryEventDayNight", 3 },
            { "TriggerIfConstructOwnerControlsMechanaConstructs", 3 },
         };
         effect = { "OwnerAlwaysHasDay", 0 };
      },
   };

   effect_text = "If you control three or more Mechana Constructs, " ..
                  "you may treat your turn as Day.";

   ai = {
   },

   image_large = { "MC_ShadeConverter", {0, 0, 364/512, 1} };
   image_medium = { "MC_ShadeConverter", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_ShadeConverter", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_ShadeConverter", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1

}


g_ascension_cards["Dogs of War"] = {
   card_name = "Dogs of War";
    card_set = "WoS";
   card_type = "Hero";
   faction = "Void";
   day_night = "day";

   rune_cost = 2;
   honor = 1;

   effects = {
      { "GainPower", 1 },
      { "BanishFromHandOrDiscard", 1 },
      { "GainPower", 1, condition={"IfYouDo",1} },
   };

   effect_text = "Gain 1P.\n" ..
                  "You may banish a card in your hand or discard pile. " ..
                  "If you do, gain an additional 1P.";

   ai = {
   },

   image_large = { "VH_DogsWar", {0, 0, 364/512, 1} };
   image_medium = { "VH_DogsWar", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_DogsWar", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_DogsWar", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3

}


g_ascension_cards["Riftwatch Outpost"] = {
   card_name = "Riftwatch Outpost";
    card_set = "WoS";
   card_type = "Construct";
   faction = "Void";
   day_night = "day";

   rune_cost = 4;
   honor = 2;

   construct_abilities = {
      {
         description = "Gain 1P";
         { "GainPower", 1 },

         ai = {
            trivial = true,
         },
      },
      {
         description = "Destroy for 1P";
         { "DiscardThisConstruct", 0 },
         { "GainPower", 1 },
      },
   };

   effect_text = "Once per turn, gain 1P.\n" ..
                  "You may destroy this to gain 1P.";

   ai = {
   },

   image_large = { "VC_RiftwatchOutpost", {0, 0, 364/512, 1} };
   image_medium = { "VC_RiftwatchOutpost", {392/512, 0, 512/512, 168/512} };
   image_small = { "VC_RiftwatchOutpost", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VC_RiftwatchOutpost", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2

}


g_ascension_cards["Deadeye Assassin"] = {
   card_name = "Deadeye Assassin";
    card_set = "WoS";
   card_type = "Hero";
   faction = "Void";
   day_night = "day";

   rune_cost = 5;
   honor = 3;

   effects = {
      { "GainPower", 3 },
      { "GainPowerForVoidCardsInDiscardPile", 1 },
   };

   effect_text = "Gain 3P.\n" ..
                  "Gain an additional 1P for each Void card in your discard pile.";

   ai = {
   },

   image_large = { "VH_DeadeyeAssassin", {0, 0, 364/512, 1} };
   image_medium = { "VH_DeadeyeAssassin", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_DeadeyeAssassin", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_DeadeyeAssassin", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2

}


g_ascension_cards["Dark Gladiator"] = {
   card_name = "Dark Gladiator";
    card_set = "WoS";
   card_type = "Hero";
   faction = "Void";
   day_night = "night";

   power_cost = 1;
   rune_cost = 1;
   honor = 2;

   effects = {
      { "GainPower", 2 },
      { "OutputPauseForEffectDayNight", 0, condition={"IfIsNight",0} },
      { "MarkPlayedEffectNight", 1, condition={"IfIsNight",0} },
      { "GainPower", 2, condition={"IfIsNight",0} },
   };

   --effect_text = "Gain 2P.\n" ..
   --            "NIGHT: Gain an additional 2P.";
   effect_text = "Gain 2P.";
   night_text = "NIGHT: Gain an additional 2P.";

   ai = {
   },

   image_large = { "VH_DarkGladiator", {0, 0, 364/512, 1} };
   image_medium = { "VH_DarkGladiator", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_DarkGladiator", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_DarkGladiator", {384/512, 395/512, 512/512, 512/512} };

   highlight_night = { 0, 0.26, 0, 0.94 };

   rarity_count = 3

}


g_ascension_cards["Dread Conjurer"] = {
   card_name = "Dread Conjurer";
    card_set = "WoS";
   card_type = "Hero";
   faction = "Void";
   day_night = "night";

   rune_cost = 3;
   honor = 2;

   effects = {
      { "DrawCards", 1 },
      { "OutputPauseForEffectDayNight", 0, condition={"IfIsNight",0} },
      { "MarkPlayedEffectNight", 1, condition={"IfIsNight",0} },
      { "BanishFromHandOrDiscard", 1, condition={"IfIsNight",0} },
   };

   --effect_text = "Draw a card.\n" ..
   --               "NIGHT: You may banish a card in your hand or discard pile.";
   effect_text = "Draw a card.";
   night_text = "NIGHT: You may banish a card in your hand or discard pile.";

   ai = {
   },

   image_large = { "VH_DreadConjuror", {0, 0, 364/512, 1} };
   image_medium = { "VH_DreadConjuror", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_DreadConjuror", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_DreadConjuror", {384/512, 395/512, 512/512, 512/512} };

   highlight_night = { -0.015, 0.40, 0, 0.94 };

   rarity_count = 3

}


g_ascension_cards["Wartorn Arbiter"] = {
   card_name = "Wartorn Arbiter";
    card_set = "WoS";
   card_type = "Hero";
   faction = "Void";
   day_night = "night";

   rune_cost = 1;
   power_cost = 3;
   honor = 2;

   effects = {
      { "GainPower", 1 },
      { "BanishFromHandOrDiscard", 1 },
      { "OutputPauseForEffectDayNight", 0, condition={"IfIsNight",0} },
      { "MarkPlayedEffectNight", 1, condition={"IfIsNight",0} },
      { "GainPower", 1, condition={"IfIsNight",0} },
      { "BanishFromHandOrDiscard", 1, condition={"IfIsNight",0} },
   };

   --effect_text = "Gain 1P. " ..
   --                  "You may banish a card in your hand or discard pile.\n" ..
   --               "NIGHT: Gain 1P. " ..
   --                  "You may banish a card in your hand or discard pile.";
   effect_text = "Gain 1P. You may banish a card in your hand or discard pile.";
   night_text = "NIGHT: Gain 1P. You may banish a card in your hand or discard pile.";

   ai = {
   },

   image_large = { "VH_WartornArbiter", {0, 0, 364/512, 1} };
   image_medium = { "VH_WartornArbiter", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_WartornArbiter", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_WartornArbiter", {384/512, 395/512, 512/512, 512/512} };

   highlight_night = { -0.05, 0.40, 0, 0.94 };

   rarity_count = 3

}


g_ascension_cards["Shade of Sadranis"] = {
   card_name = "Shade of Sadranis";
    card_set = "WoS";
   card_type = "Hero";
   faction = "Void";
   day_night = "night";

   rune_cost = 6;
   honor = 3;

   effects = {
      { "GainPower", 4 },
      { "OutputPauseForEffectDayNight", 0, condition={"IfIsNight",0} },
      { "MarkPlayedEffectNight", 1, condition={"IfIsNight",0} },
      { "MayDefeatNonTrophyMonsterFromVoidThisTurn", 1, condition={"IfIsNight",0} },
   };

   --effect_text = "Gain 4P.\n" ..
   --         "NIGHT: Once this turn, you may defeat a non-Trophy Monster in the void " ..
   --            "as though it was in the center row. " ..
   --            "If you do, put it on the bottom of the center deck.";
   effect_text = "Gain 4P.";
   night_text = "NIGHT: Once this turn, you may defeat a non-Trophy Monster in the void " ..
               "as though it was in the center row. " ..
               "If you do, put it on the bottom of the center deck.";

   ai = {
   },

   image_large = { "VH_ShadeSadranis", {0, 0, 364/512, 1} };
   image_medium = { "VH_ShadeSadranis", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_ShadeSadranis", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_ShadeSadranis", {384/512, 395/512, 512/512, 512/512} };

   highlight_night = { -0.043, 0.58, 0, 0.94 };

   rarity_count = 1

}


g_ascension_active_effects["gain runes for power cost when defeat a monster"] = {
   type = "triggered";
   priority = 10;
   conditions = {
      { "WhenYouDefeatMonster", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerGainRunesForDefeatedMonsterPowerCost", 3 },
      { "TriggerRemovePlayedCardEffectActive", 0 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}

g_ascension_cards["Isha, the Pursuer"] = {
   card_name = "Isha, the Pursuer";
    card_set = "WoS";
   card_type = "Hero";
   faction = "Void";
   day_night = "night";

   rune_cost = 1;
   power_cost = 6;
   honor = 3;

   effects = {
      { "GainPower", 3 },
      { "NextMonsterYouDefeatGainsRunesForPowerCost", 0 },
   };

   effect_text = "Gain 3P.\n" ..
                  "The next time you defeat a Monster this turn, " ..
                     "gain R equal to the defeated Monster's P cost.";

   ai = {
   },

   image_large = { "VH_IshaPursuer", {0, 0, 364/512, 1} };
   image_medium = { "VH_IshaPursuer", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_IshaPursuer", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_IshaPursuer", {384/512, 395/512, 512/512, 512/512} };

   highlight_played_effect = { -0.03, 0.55, 0, 0.98 };

   rarity_count = 1

}




g_ascension_cards["Shardwing Beetle"] = {
   card_name = "Shardwing Beetle";
    card_set = "WoS";
   card_type = "Monster";
   day_night = "day";

   power_cost = 3;

   rewards = {
      { "GainHonor", 3 },
      { "GainHonorForRunes", 3*256 + 3 },
   };

   effect_text = "Reward: Gain 3H.\n" ..
                  "When you defeat this, you may pay 3R " ..
                     "to gain an additional 3H.";

   ai = {
   },

   image_large = { "M_ShardwingBeetle", {0, 0, 364/512, 1} };
   image_medium = { "M_ShardwingBeetle", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_ShardwingBeetle", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_ShardwingBeetle", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Shardwing Beetle" };

   rarity_count = 4

}


g_ascension_cards["Deceitful Ghoul"] = {
   card_name = "Deceitful Ghoul";
    card_set = "WoS";
   card_type = "Monster";
   day_night = "day";

   power_cost = 3;
   trophy_monster = true;

   rewards = {
      { "GainHonor", 2 },
   };
   trophy_effects = {
	  { "PushResolvingTrophy", 0 },
      { "BanishFromCenterRow", 0 },
	  { "PopResolvingTrophy", 0 },
      { "BanishThisTrophy", 0 },
   };

   --effect_text = "Reward: Gain 2H.\n" ..
   --               "TROPHY: Banish this to banish a card in the center row.";
   effect_text = "Reward: Gain 2H.";
   trophy_text = "<color=#951719FF><B>Trophy:</B></color> Banish this to banish a card in the center row.";

   ai = {
   },

   image_large = { "M_DeceitfulGhoul", {0, 0, 364/512, 1} };
   image_medium = { "M_DeceitfulGhoul", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_DeceitfulGhoul", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_DeceitfulGhoul", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Deceitful Ghoul" };

   rarity_count = 3

}



g_ascension_cards["Scavenger Ants"] = {
   card_name = "Scavenger Ants";
    card_set = "WoS";
   card_type = "Monster";
   day_night = "day";

   power_cost = 4;

   rewards = {
      { "GainHonor", 4 },
      { "OutputPauseForEffectDayNight", 0, condition={"IfDefeatEventIsDay",0} },
      { "MarkPlayedEffectDay", 1, condition={"IfDefeatEventIsDay",0} },
      { "GainRunes", 3, condition={"IfDefeatEventIsDay",0} },
   };

   --effect_text = "Reward: Gain 4H.\n" ..
   --               "DAY: Gain 3R.";
   effect_text = "Reward: Gain 4H.";
   day_text = "DAY: Gain 3R.";

   ai = {
   },

   image_large = { "M_ScavengerAnts", {0, 0, 364/512, 1} };
   image_medium = { "M_ScavengerAnts", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_ScavengerAnts", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_ScavengerAnts", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Scavenger Ants" };

   highlight_centerrow_day = { 0.009, 0.26, 0, 0.90 };

   rarity_count = 3

}



g_ascension_cards["Emberwing Moth"] = {
   card_name = "Emberwing Moth";
    card_set = "WoS";
   card_type = "Monster";
   day_night = "day";

   power_cost = 5;

   rewards = {
      { "GainHonor", 5 },
      { "OutputPauseForEffectDayNight", 0, condition={"IfDefeatEventIsDayOrNight",0} },
      { "MarkPlayedEffectDay", 1, condition={"IfDefeatEventIsDay",0} },
      { "DestroyConstructForEachOpponent", 0, condition={"IfDefeatEventIsDay",0} },
      { "MarkPlayedEffectNight", 1, condition={"IfDefeatEventIsNight",0} },
      { "EachOpponentDiscardsAllButOneConstructInPlay", 0, condition={"IfDefeatEventIsNight",0} },
   };

   --effect_text = "Reward: Gain 5H.\n" ..
   --            "DAY: For each opponent, you choose and destroy a Construct they control.\n" ..
   --            "NIGHT: Each opponent chooses a Construct they control and destroys the rest.";
   effect_text = "Reward: Gain 5H.";
   day_text = "DAY: For each opponent, you choose and destroy a Construct they control.";
   night_text = "NIGHT: Each opponent chooses a Construct they control and destroys the rest.";

   ai = {
   },

   image_large = { "M_EmberwingMoth", {0, 0, 364/512, 1} };
   image_medium = { "M_EmberwingMoth", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_EmberwingMoth", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_EmberwingMoth", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Embrewing Moth" };

   highlight_centerrow_day = { 0.032, 0.28, 0, 0.90 };
   highlight_centerrow_night = { -0.062, 0.28, 0, 0.90 };

   rarity_count = 2

}


g_ascension_cards["Cavern Creeper"] = {
   card_name = "Cavern Creeper";
    card_set = "WoS";
   card_type = "Monster";
   day_night = "night";

   power_cost = 1;

   rewards = {
      { "GainHonor", 1 },
      { "GainRunes", 1 },
   };

   effect_text = "Reward: Gain 1H and 1R.";

   ai = {
   },

   image_large = { "M_CavernCreeper", {0, 0, 364/512, 1} };
   image_medium = { "M_CavernCreeper", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_CavernCreeper", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_CavernCreeper", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Cavern Creeper" };

   rarity_count = 3

}


g_ascension_cards["Shade Viper"] = {
   card_name = "Shade Viper";
    card_set = "WoS";
   card_type = "Monster";
   day_night = "night";

   power_cost = 3;
   trophy_monster = true;

   rewards = {
      { "GainHonor", 2 },
   };
   trophy_effects = {
      usageconditions = {
         { "IfIsDayOrNight", 0 },
      },
      { "GainRunes", 1, condition={"IfIsDay",0} },
      { "GainPower", 1, condition={"IfIsNight",0} },
      { "BanishThisTrophy", 0 },
   };

   --effect_text = "Reward: Gain 2H.\n" ..
   --               "TROPHY: If it is Day, banish this to gain 1R.\n" ..
   --               "TROPHY: If it is Night, banish this to gain 1P.";
   effect_text = "Reward: Gain 2H.";
   day_text = "<color=#951719FF><B>Trophy:</B></color> If it is Day, banish this to gain 1R.";
   night_text = "<color=#951719FF><B>Trophy:</B></color> If it is Night, banish this to gain 1P.";

   ai = {
   },

   image_large = { "M_ShadeViper", {0, 0, 364/512, 1} };
   image_medium = { "M_ShadeViper", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_ShadeViper", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_ShadeViper", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Shade Viper" };

   highlight_day = { 0.007, 0.24, 0, 0.975 };
   highlight_night = { -0.087, 0.24, 0, 0.975 };

   rarity_count = 4

}


g_ascension_cards["Light of False Hope"] = {
   card_name = "Light of False Hope";
    card_set = "WoS";
   card_type = "Monster";
   day_night = "night";

   power_cost = 4;

   rewards = {
      { "GainHonor", 4 },
      { "OutputPauseForEffectDayNight", 0, condition={"IfDefeatEventIsNight",0} },
      { "MarkPlayedEffectNight", 1, condition={"IfDefeatEventIsNight",0} },
      { "DrawCards", 2, condition={"IfDefeatEventIsNight",0} },
   };

--   effect_text = "Reward: Gain 4H.\n" ..
--                  "NIGHT: Draw 2 Cards.";
   effect_text = "Reward: Gain 4H.";
   night_text = "NIGHT: Draw 2 Cards.";

   ai = {
   },

   image_large = { "M_LightFalseHope", {0, 0, 364/512, 1} };
   image_medium = { "M_LightFalseHope", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_LightFalseHope", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_LightFalseHope", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Light of False Hope" };

   highlight_centerrow_night = { -0.005, 0.26, 0, 0.90 };

   rarity_count = 3

}


g_ascension_cards["Lieutenant Duros"] = {
   card_name = "Lieutenant Duros";
    card_set = "WoS";
   card_type = "Monster";
   day_night = "night";

   power_cost = 6;

   rewards = {
      { "GainHonor", 4 },
      { "OutputPauseForEffectDayNight", 0, condition={"IfDefeatEventIsDayOrNight",0} },
      { "MarkPlayedEffectDay", 1, condition={"IfDefeatEventIsDay",0} },
      { "TakeRandomCardFromEachOpponent", 0, condition={"IfDefeatEventIsDay",0} },
      { "MarkPlayedEffectNight", 1, condition={"IfDefeatEventIsNight",0} },
      { "GainHonorFromOpponent", 5, condition={"IfDefeatEventIsNight",0} },
   };

   --effect_text = "Reward: Gain 4H.\n" ..
   --      "DAY: Take a card at random from each opponent's hand and add them to your hand.\n" ..
   --      "NIGHT: Take 5H from an opponent of your choice.";
   effect_text = "Reward: Gain 4H.";
   day_text = "DAY: Take a card at random from each opponent's hand and add them to your hand.";
   night_text = "NIGHT: Take 5H from an opponent of your choice.";

   ai = {
   },

   image_large = { "M_LieutenantDuros", {0, 0, 364/512, 1} };
   image_medium = { "M_LieutenantDuros", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_LieutenantDuros", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_LieutenantDuros", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Lieutenant Duros" };

   highlight_centerrow_day = { 0.016, 0.28, 0, 0.90 };
   highlight_centerrow_night = { -0.074, 0.22, 0, 0.90 };

   rarity_count = 1

}


g_ascension_cards["Legion of Aklys"] = {
   card_name = "Legion of Aklys";
    card_set = "WoS";
   card_type = "Monster";
   day_night = "night";

   power_cost = 7;
   trophy_monster = true;

   global_continuous_effects = {
      {
         conditions = {
            { "TriggerIfAllCenterRowIsNight", 0 },
         };
         effect = { "MayDefeatThisAtNoCost", 0 };
      },
   };

   rewards = {
      { "GainHonor", 5 },
   };
   triggered_effects = {
      {
         conditions = {
            { "WhenTrophyOwnerAcquiresOrDefeatsNightCard", 0 },
         };
         triggereffect = {
            { "TriggerTrophyOwnerGainHonor", 2 },
         };
      },
   };

   --effect_text = "If all cards in the center row are NIGHT cards, " ..
   --                  "you may defeat this without paying its cost." ..
   --               "Reward: Gain 5H.\n" ..
   --               "ONGOING TROPHY: When you acquire or defeat a NIGHT card, gain 2H.";
   effect_text = "If all cards in the center row are NIGHT cards, " ..
                     "you may defeat this without paying its cost." ..
                  "Reward: Gain 5H.";
   --trophy_text = "<color=#951719FF><B>Ongoing Trophy:</B></color> When you acquire or defeat a NIGHT card, gain 2H.";
   night_text = "<color=#951719FF><B>Ongoing Trophy:</B></color> When you acquire or defeat a NIGHT card, gain 2H.";

   ai = {
   },

   image_large = { "M_LegionAklys", {0, 0, 364/512, 1} };
   image_medium = { "M_LegionAklys", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_LegionAklys", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_LegionAklys", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Legion of Aklys" };

   rarity_count = 1

}


g_ascension_cards["Aklys, the Scourge"] = {
   card_name = "Aklys, the Scourge";
    card_set = "WoS";
   card_type = "Monster";
   day_night = "night";

   power_cost = 10;

   global_continuous_effects = {
      {
         conditions = {
            { "TriggerIfIsDay", 0 },
         };
         effect = { "ReduceDefeatThisMonsterCost", 5 };
      },
   };
   rewards = {
      { "GainHonor", 6 },
      { "OutputPauseForEffectDayNight", 0, condition={"IfDefeatEventIsDayOrNight",0} },
      { "MarkPlayedEffectNight", 1, condition={"IfDefeatEventIsNight",0} },
      { "DefeatAllMonstersInCenterRow", 0, condition={"IfDefeatEventIsNight",0} },
   };

   --effect_text = "Reward: Gain 6H.\n" ..
   --   "DAY: This costs 5 less to defeat.\n" ..
   --   "NIGHT: Defeat all other Monsters in the center row without paying their costs.";
   effect_text = "Reward: Gain 6H.";
   day_text = "DAY: This costs 5 less to defeat.";
   night_text = "NIGHT: Defeat all other Monsters in the center row without paying their costs.";

   ai = {
   },

   image_large = { "M_AklysScourge", {0, 0, 364/512, 1} };
   image_medium = { "M_AklysScourge", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_AklysScourge", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_AklysScourge", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Aklys, the Scourge" };

   highlight_centerrow_day = { 0.035, 0.22, 0, 0.90 };
   highlight_centerrow_night = { -0.06, 0.32, 0, 0.90 };

   rarity_count = 1

}




