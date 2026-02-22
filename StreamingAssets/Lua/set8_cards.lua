

g_ascension_cards["Dhartha"] = {
	card_name = "Dhartha";
    card_set = "DoC";
	card_type = "Champion";
	faction = "Enlightened";

   transform_into = "Dhartha, Master of Sight";

	cardinplay_abilities = {
		{
			ability_name = "Dhartha gain reputation",
         description = "Buy 1 Rep for 2 Runes";
			condition = { "IfHasCurrentTurnRunesAndReputationLessThan8", 2 },
			{ "PayRunes", 2 },
			{ "GainReputation", 1 },
			{ "AcquireTransformCard", 1, condition={"IfPlayerHasReputationLevelExact",2} },

         ai = {
            use_at_end_of_turn = true,
         },
		},
	};

	triggered_effects = {
		{
         trigger_type = 1,
         priority = -5,
			conditions = {
            { "TriggerIfOwnerReputationLessThan", 8 },
				{ "WhenOwnerAcquiresOrDefeatsEnlightenedFromCenterRow", 0 },
			};
			triggereffect = {
            { "TriggerPushResolveEffectFromCardsInPlay", 0 },
				{ "TriggerOwnerGainReputation", 1 },
            { "TriggerOwnerAcquireTransformCardIfReputationExact", 2 },
            { "TriggerPopResolveEffectFromCardsInPlay", 0 },
			};
      },
      {
         trigger_type = 1,
         conditions = {
            { "WhenOwnerAcquiresOrDefeatsEnlightenedFromCenterRow", 0 },
         };
         triggereffect = {
            { "TriggerMarkAcquireEventForRallyEnlightenedIfReputation", 8 },
            { "TriggerMarkDefeatEventForRallyEnlightenedIfReputation", 8 },
         };
      },
	};

	--effect_text = "+1: Whenever you acquire or defeat an Enlightened card from the center row, gain 1rep.\n" ..
    --              "+1: Once per turn, you may pay 2R to gain 1rep.\n" ..
    --              "2: Acquire Dhartha, Master of the Eye.\n" ..
    --              "8: Whenever you acquire or defeat an Enlightened card in the center row, Rally: Enlightened.";
   
   image_large = { "CE_ChampionDhartha", {0, 0, 364/512, 1} };
   image_medium = { "CE_ChampionDhartha", {392/512, 0, 512/512, 168/512} };
   image_small = { "CE_ChampionDhartha", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "CE_ChampionDhartha", {384/512, 395/512, 512/512, 512/512} };
}



g_ascension_cards["Dhartha, Master of Sight"] = {
	card_name = "Dhartha, Master of Sight";
    card_set = "DoC";
	card_type = "Hero";
	faction = "Enlightened";
   do_not_put_in_void = true;

   effects = {
		{ "BanishFromHandOrSource", 1 },
		{ "AcquireMysticOrHeavyInfantryToHand", 0, condition={"IfYouDo",0} },
	};

	effect_text = "You may banish this or a card in your hand. " ..
                  "If you do, acquire a Mystic or Heavy Infantry without paying its cost and put it in your hand.";

   image_large = { "EH_DharthaMasterSight", {0, 0, 364/512, 1} };
   image_medium = { "EH_DharthaMasterSight", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_DharthaMasterSight", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_DharthaMasterSight", {384/512, 395/512, 512/512, 512/512} };
}



g_ascension_cards["Nairi"] = {
	card_name = "Nairi";
    card_set = "DoC";
	card_type = "Champion";
	faction = "Lifebound";

   transform_into = "Nairi, Wild Queen";

	cardinplay_abilities = {
		{
			ability_name = "Nairi gain reputation",
         description = "Buy 1 Rep for 2 Runes";
			condition = { "IfHasCurrentTurnRunesAndReputationLessThan8", 2 },
			{ "PayRunes", 2 },
			{ "GainReputation", 1 },
			{ "AcquireTransformCard", 1, condition={"IfPlayerHasReputationLevelExact",3} },

         ai = {
            use_at_end_of_turn = true,
         },
		},
	};

	triggered_effects = {
		{
         trigger_type = 1,
         priority = -5,
			conditions = {
            { "TriggerIfOwnerReputationLessThan", 8 },
				{ "WhenOwnerAcquiresOrDefeatsLifeboundFromCenterRow", 0 },
			};
			triggereffect = {
            { "TriggerPushResolveEffectFromCardsInPlay", 0 },
				{ "TriggerOwnerGainReputation", 1 },
            { "TriggerOwnerAcquireTransformCardIfReputationExact", 3 },
            { "TriggerPopResolveEffectFromCardsInPlay", 0 },
			};
		},
      {
         trigger_type = 1,
         conditions = {
            { "WhenOwnerAcquiresOrDefeatsLifeboundFromCenterRow", 0 },
         };
         triggereffect = {
            { "TriggerMarkAcquireEventForRallyLifeboundIfReputation", 8 },
            { "TriggerMarkDefeatEventForRallyLifeboundIfReputation", 8 },
         };
      },
	};

	--effect_text = "+1: Whenever you acquire or defeat an Lifebound card from the center row, gain 1rep.\n" ..
    --              "+1: Once per turn, you may pay 2R to gain 1rep.\n" ..
    --              "3: Acquire Nairi, Wild Queen.\n" ..
    --              "8: Whenever you acquire or defeat an Lifebound card in the center row, Rally: Lifebound.";
   
   image_large = { "CL_ChampionNairi", {0, 0, 364/512, 1} };
   image_medium = { "CL_ChampionNairi", {392/512, 0, 512/512, 168/512} };
   image_small = { "CL_ChampionNairi", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "CL_ChampionNairi", {384/512, 395/512, 512/512, 512/512} };
}


g_ascension_active_effects["unite gain 1H 1D"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayLifeboundHero", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerGainHonor", 1 },
		{ "TriggerEffectPlayerDrawCards", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

g_ascension_cards["Nairi, Wild Queen"] = {
	card_name = "Nairi, Wild Queen";
    card_set = "DoC";
	card_type = "Hero";
	faction = "Lifebound";
   do_not_put_in_void = true;

	effects = {
		{ "GainHonor", 1 },
		{ "DrawCards", 1 },
		{ "GainHonor", 1, condition={"IfPlayedLifeboundHero",1} },
		{ "DrawCards", 1, condition={"IfPlayedLifeboundHero",1} },
      { "UniteGain1HandDraw1Card", 0, condition={"IfHaventPlayedLifeboundHero",1} },
	};

	effect_text = "Gain 1H. Draw a card.\n" ..
                  "UNITE: Gain 1H. Draw a card.";

   image_large = { "LH_NairiWildQueen", {0, 0, 364/512, 1} };
   image_medium = { "LH_NairiWildQueen", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_NairiWildQueen", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_NairiWildQueen", {384/512, 395/512, 512/512, 512/512} };
}


g_ascension_cards["Kor"] = {
	card_name = "Kor";
    card_set = "DoC";
	card_type = "Champion";
	faction = "Mechana";

   transform_into = "Kor, the Ironmind";

	cardinplay_abilities = {
		{
			ability_name = "Kor gain reputation",
         description = "Buy 1 Rep for 2 Runes";
			condition = { "IfHasCurrentTurnRunesAndReputationLessThan8", 2 },
			{ "PayRunes", 2 },
			{ "GainReputation", 1 },
			{ "AcquireTransformCard", 1, condition={"IfPlayerHasReputationLevelExact",4} },

         ai = {
            use_at_end_of_turn = true,
         },
		},
	};

	triggered_effects = {
		{
         trigger_type = 1,
         priority = -5,
			conditions = {
            { "TriggerIfOwnerReputationLessThan", 8 },
				{ "WhenOwnerAcquiresOrDefeatsMechanaFromCenterRow", 0 },
			};
			triggereffect = {
            { "TriggerPushResolveEffectFromCardsInPlay", 0 },
				{ "TriggerOwnerGainReputation", 1 },
            { "TriggerOwnerAcquireTransformCardIfReputationExact", 4 },
            { "TriggerPopResolveEffectFromCardsInPlay", 0 },
			};
		},
      {
         trigger_type = 1,
         conditions = {
            { "WhenOwnerAcquiresOrDefeatsMechanaFromCenterRow", 0 },
         };
         triggereffect = {
            { "TriggerMarkAcquireEventForRallyMechanaIfReputation", 8 },
            { "TriggerMarkDefeatEventForRallyMechanaIfReputation", 8 },
         };
      },
	};

	--effect_text = "+1: Whenever you acquire or defeat an Mechana card from the center row, gain 1rep.\n" ..
    --              "+1: Once per turn, you may pay 2R to gain 1rep.\n" ..
    --              "4: Acquire Kor, the Ironmind.\n" ..
    --              "8: Whenever you acquire or defeat an Mechana card in the center row, Rally: Mechana.";
   
   --image_large = { "CM_Kor", {0, 0, 364/512, 1} };
   --image_medium = { "CM_Kor", {392/512, 0, 512/512, 168/512} };
   --image_small = { "CM_Kor", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "CM_Kor", {384/512, 395/512, 512/512, 512/512} };
   image_large = { "CM_ChampionKor", {0, 0, 364/512, 1} };
   image_medium = { "CM_ChampionKor", {392/512, 0, 512/512, 168/512} };
   image_small = { "CM_ChampionKor", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "CM_ChampionKor", {384/512, 395/512, 512/512, 512/512} };
}


g_ascension_cards["Kor, the Ironmind"] = {
	card_name = "Kor, the Ironmind";
    card_set = "DoC";
	card_type = "Hero";
	faction = "Mechana";
   do_not_put_in_void = true;

	effects = {
		{ "GainRunes", 2 },
		{ "GainPower", 2 },
		{ "DrawCards", 1, condition={"IfYouControlConstructs",2} },
	};

	effect_text = "Gain 2R and 2P.\n" ..
                  "If you control two or more Constructs, draw a card.";

   image_large = { "MH_KorIronmind", {0, 0, 364/512, 1} };
   image_medium = { "MH_KorIronmind", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_KorIronmind", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_KorIronmind", {384/512, 395/512, 512/512, 512/512} };
}



g_ascension_cards["Sadranis"] = {
	card_name = "Sadranis";
    card_set = "DoC";
	card_type = "Champion";
	faction = "Void";

   transform_into = "Sadranis, Dark Savant";

	cardinplay_abilities = {
		{
			ability_name = "Sadranis gain reputation",
         description = "Buy 1 Rep for 2 Runes";
			condition = { "IfHasCurrentTurnRunesAndReputationLessThan8", 2 },
			{ "PayRunes", 2 },
			{ "GainReputation", 1 },
			{ "AcquireTransformCard", 1, condition={"IfPlayerHasReputationLevelExact",4} },

         ai = {
            use_at_end_of_turn = true,
         },
		},
	};

	triggered_effects = {
		{
         trigger_type = 1,
         priority = -5,
			conditions = {
            { "TriggerIfOwnerReputationLessThan", 8 },
				{ "WhenOwnerAcquiresOrDefeatsVoidFromCenterRow", 0 },
			};
			triggereffect = {
            { "TriggerPushResolveEffectFromCardsInPlay", 0 },
				{ "TriggerOwnerGainReputation", 1 },
            { "TriggerOwnerAcquireTransformCardIfReputationExact", 4 },
            { "TriggerPopResolveEffectFromCardsInPlay", 0 },
			};
		},
      {
         trigger_type = 1,
         conditions = {
            { "WhenOwnerAcquiresOrDefeatsVoidFromCenterRow", 0 },
         };
         triggereffect = {
            { "TriggerMarkAcquireEventForRallyVoidIfReputation", 8 },
            { "TriggerMarkDefeatEventForRallyVoidIfReputation", 8 },
         };
      },
	};

	--effect_text = "+1: Whenever you acquire or defeat an Void card from the center row, gain 1rep.\n" ..
    --              "+1: Once per turn, you may pay 2R to gain 1rep.\n" ..
    --              "4: Acquire Sadranis, Dark Savant.\n" ..
    --              "8: Whenever you acquire or defeat an Void card in the center row, Rally: Void.";
   
   --image_large = { "CV_Sadranis", {0, 0, 364/512, 1} };
   --image_medium = { "CV_Sadranis", {392/512, 0, 512/512, 168/512} };
   --image_small = { "CV_Sadranis", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "CV_Sadranis", {384/512, 395/512, 512/512, 512/512} };
   image_large = { "CV_ChampionSadranis", {0, 0, 364/512, 1} };
   image_medium = { "CV_ChampionSadranis", {392/512, 0, 512/512, 168/512} };
   image_small = { "CV_ChampionSadranis", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "CV_ChampionSadranis", {384/512, 395/512, 512/512, 512/512} };
   
}


g_ascension_cards["Sadranis, Dark Savant"] = {
	card_name = "Sadranis, Dark Savant";
    card_set = "DoC";
	card_type = "Hero";
	faction = "Void";
   do_not_put_in_void = true;

	effects = {
		{ "DrawCards", 2 },
		{ "DiscardFromHand", 0 },
		{ "BanishFromDiscard", 1 },
	};

	effect_text = "Draw two cards, then discard a card. " ..
                  "You may banish a card in your discard pile.";

   image_large = { "VH_SadranisDarkSavant", {0, 0, 364/512, 1} };
   image_medium = { "VH_SadranisDarkSavant", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_SadranisDarkSavant", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_SadranisDarkSavant", {384/512, 395/512, 512/512, 512/512} };
}




g_ascension_cards["Seer of Days Past"] = {
	card_name = "Seer of Days Past";
    card_set = "DoC";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 4;
	honor = 3;

	effects = {
		{ "DrawCards", 1 },
		{ "DrawCards", 1, condition={"IfPlayerHasReputationLevel",8} },
	};

   global_triggered_effects = {
		{
         trigger_type = 1,
			conditions = {
				{ "WhenPlayerAcquiresThisCard", 0 },
			};
			triggereffect = {
				{ "TriggerMarkAcquireEventForRallyEnlightened", 0 },
			};
		},
	};

	effect_text = "When you acquire this, Rally: Enlightened.\n" ..
                  "Draw a card. If you have 8rep or more, draw an additional card.";

   ai = {
   },
   
   image_large = { "EH_SeerDaysPast", {0, 0, 364/512, 1} };
   image_medium = { "EH_SeerDaysPast", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_SeerDaysPast", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_SeerDaysPast", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 3

}

g_ascension_cards["Daybreak Askara"] = {
	card_name = "Daybreak Askara";
    card_set = "DoC";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 5;
	honor = 3;

   played_effect_cannot_be_copied = true;
   
	effects = {
		{ "CopyEffectOfAnyPlayedHero", 0 },
		{ "CopyEffectOfInstanceEffectDataCard", 0, condition={"IfEffectInstanceDataIsEnlightened",0} },
	};
   
	effect_text = "Copy the effect of a Hero play this turn. " ..
                  "If the Hero was Enlightened, copy that Hero's effect an additional time. " ..
                  "This effect cannot be copied.";

   ai = {
   },
   
   image_large = { "EH_DaybreakAskara", {0, 0, 364/512, 1} };
   image_medium = { "EH_DaybreakAskara", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_DaybreakAskara", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_DaybreakAskara", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}


g_ascension_cards["Austere Sage"] = {
	card_name = "Austere Sage";
    card_set = "DoC";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 4;
	honor = 2;

	effects = {
		{ "DrawCards", 1 },
		{ "BanishFromCenterRowAndRallyEnlightened", 1 },
	};

	effect_text = "Draw a card.\n" ..
                  "You may banish a card in the center row, then Rally: Enlightened.";

   ai = {
   },
   
   image_large = { "EH_AustereSage", {0, 0, 364/512, 1} };
   image_medium = { "EH_AustereSage", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_AustereSage", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_AustereSage", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}

g_ascension_cards["Serene Ascetic"] = {
	card_name = "Serene Ascetic";
    card_set = "DoC";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 6;
	honor = 4;

	effects = {
      { "DrawCards", 2 },
   };
   global_continuous_effects = {
      {
         priority = -5;
         effect = { "MayAcquireThisCardToTopOfDeck", 0 };
      },
   };

	effect_text = "When you acquire this, you may put it on top of your deck.\n" ..
                  "Draw two cards.";

   ai = {
   },
   
   image_large = { "EH_SereneAscetic", {0, 0, 364/512, 1} };
   image_medium = { "EH_SereneAscetic", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_SereneAscetic", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_SereneAscetic", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}

g_ascension_cards["Surya, Light's Sword"] = {
	card_name = "Surya, Light's Sword";
    card_set = "DoC";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 8;
	honor = 6;

	effects = {
      { "DefeatMonsterFromCenterRowWithLessPower", 0 },
		{ "TakeAnAdditionalTurn", 0, condition={"IfEffectInstanceDataIsMonsterWithCostOver7",0} },
   };
   
	effect_text = "Defeat a Monster in the center row without paying its cost." ..
                     "If it cost 7P or more, take an additional turn after this one.";

   ai = {
   },
   
   image_large = { "EH_SuryaLightsSword", {0, 0, 364/512, 1} };
   image_medium = { "EH_SuryaLightsSword", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_SuryaLightsSword", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_SuryaLightsSword", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}

g_ascension_cards["Mantra of Renewal"] = {
	card_name = "Mantra of Renewal";
    card_set = "DoC";
	card_type = "Construct";
	faction = "Enlightened";
	rune_cost = 1;
	honor = 1;

	construct_abilities = {
		{
         description = "Draw a card";
			condition = { "IfPlayedEnlightenedCards", 2 },
         { "DrawCards", 1 },
      
         ai = {
            trivial_draw = 1,

            gain_draw = 1,
         },
		},
	};

	effect_text = "Once per turn, if you have played two or more Enlightened cards (including this one), draw a card.";

   ai = {
   },
   
   image_large = { "EC_MantraRenewal", {0, 0, 364/512, 1} };
   image_medium = { "EC_MantraRenewal", {392/512, 0, 512/512, 168/512} };
   image_small = { "EC_MantraRenewal", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EC_MantraRenewal", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}

g_ascension_cards["Premonition Bell"] = {
	card_name = "Premonition Bell";
    card_set = "DoC";
	card_type = "Construct";
	faction = "Enlightened";
	rune_cost = 5;
	honor = 3;

	construct_abilities = {
		{
			description = "Destroy to Copy";
			condition = { "IfHasCenterRowHeroWithLessCost", 5 },
         { "DiscardThisConstruct", 0 },
         { "PushResolvingConstruct", 0 },
         { "CopyEffectOfAnyCenterRowHeroWithLessCost", 5 },
         { "PopResolvingConstruct", 1 },
		},
	};

	effect_text = "You may destroy this to copy the effect of a Hero in the center row with cost 5R or less.";

   ai = {
   },
   
   image_large = { "EC_PremonitionBell", {0, 0, 364/512, 1} };
   image_medium = { "EC_PremonitionBell", {392/512, 0, 512/512, 168/512} };
   image_small = { "EC_PremonitionBell", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EC_PremonitionBell", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}






g_ascension_cards["Pack Leader"] = {
	card_name = "Pack Leader";
    card_set = "DoC";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 3;
	honor = 1;

	effects = {
		{ "GainRunes", 2 },
      { "UseRunesAsPowerForLifeboundUntilEndOfTurn", 0 },
   };
   
   global_triggered_effects = {
		{
         trigger_type = 1,
			conditions = {
				{ "WhenPlayerAcquiresThisCard", 0 },
			};
			triggereffect = {
				{ "TriggerMarkAcquireEventForRallyLifebound", 0 },
			};
		},
	};

	effect_text = "When you acquire this, Rally: Lifebound.\n" ..
                  "Gain 2R.\n" ..
                  "You may spend R as though it was power to defeat Lifebound Monsters this turn.";

   ai = {
   },
   
   image_large = { "LH_PackLeader", {0, 0, 364/512, 1} };
   image_medium = { "LH_PackLeader", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_PackLeader", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_PackLeader", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}



g_ascension_active_effects["rally lifebound for acquired hero"] = {
	type = "triggered";
   trigger_type = 1,
	conditions = {
		{ "WhenYouAcquireHeroFromCenterRow", 0 },
	};
	triggereffect = {
      { "TriggerMarkAcquireEventForRallyLifebound", 0 },
	};
}


g_ascension_cards["Ogo Courier"] = {
	card_name = "Ogo Courier";
    card_set = "DoC";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 4;
	honor = 2;

	effects = {
		{ "GainRunes", 2 },
      { "NextHeroYouAcquireFromCenterRowCanRallyLifebound", 0 },
   };
   
	effect_text = "Gain 2R.\n" ..
                  "The next time you acquire a Hero in the center row, Rally: Lifebound.";

   ai = {
   },
   
   image_large = { "LH_OgoCourier", {0, 0, 364/512, 1} };
   image_medium = { "LH_OgoCourier", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_OgoCourier", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_OgoCourier", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2

}

g_ascension_active_effects["unite put this card in hand"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayLifeboundHero", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerEffectPutThisCardInHandAtEndOfTurn", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

g_ascension_cards["Moonveil Clique"] = {
	card_name = "Moonveil Clique";
    card_set = "DoC";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 5;
	honor = 4;

	effects = {
		{ "GainRunes", 2 },
      { "PutThisCardInHandAtEndOfTurn", 0, condition={"IfPlayedLifeboundHero",1} },
      { "UnitePutThisCardInHandAtEndOfTurn", 0, condition={"IfHaventPlayedLifeboundHero",1} },
   };

	effect_text = "Gain 2R.\n" ..
                  "UNITE: At the end of the turn, put this in your hand instead of your discard pile.";

   ai = {
   },
   
   image_large = { "LH_MoonveilClique", {0, 0, 364/512, 1} };
   image_medium = { "LH_MoonveilClique", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_MoonveilClique", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_MoonveilClique", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Emissary of Dawn"] = {
	card_name = "Emissary of Dawn";
    card_set = "DoC";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 6;
	honor = 4;

	effects = {
		{ "AcquireHeroWithLessCost", 0 },
      { "GainHonorForEffectInstanceDataCardHonor", 0 },
   };
   
	effect_text = "Acquire a Hero without paying its cost. " ..
                  "Gain H equal to its H value.";

   ai = {
   },
   
   image_large = { "LH_EmissaryDawn", {0, 0, 364/512, 1} };
   image_medium = { "LH_EmissaryDawn", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_EmissaryDawn", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_EmissaryDawn", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Flytrap Staff"] = {
	card_name = "Flytrap Staff";
    card_set = "DoC";
	card_type = "Construct";
	faction = "Lifebound";
	rune_cost = 1;
	honor = 1;

	construct_abilities = {
		{
         description = "Gain 2 Honor";
			condition = { "IfPlayedLifeboundCards", 2 },
         { "GainHonor", 2 },
         
         ai = {
            trivial = true,
         },
		},
	};

	effect_text = "Once per turn, if you have played two or more Lifebound cards (including this one), gain 2H.";

   ai = {
   },
   
   image_large = { "LC_FlytrapStaff", {0, 0, 364/512, 1} };
   image_medium = { "LC_FlytrapStaff", {392/512, 0, 512/512, 168/512} };
   image_small = { "LC_FlytrapStaff", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LC_FlytrapStaff", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Starlight Sanctum"] = {
	card_name = "Starlight Sanctum";
    card_set = "DoC";
	card_type = "Construct";
	faction = "Lifebound";
	rune_cost = 8;
	honor = 6;

	construct_ability = {
		description = "Gain 2R";
		{ "GainRunes", 2 },
      
      ai = {
         trivial = true,
      },
	};
	triggered_effects = {
		{
			conditions = {
				{ "WhenConstructOwnerAcquiresHeroFromCenterRow", 0 },
				--{ "IfThisHasntBeenUsedThisTurn", 0 },
			};
			triggereffect = {
				--{ "TriggerSetThisHasBeenUsedThisTurn", 0 },
				{ "TriggerStarlightSanctum", 0 },
			};
		},
	};

	effect_text = "Once per turn, gain 2R.\n" ..
                  "Once per turn, when you acquire a Hero in the center row, " ..
                  "you may acquire a Hero of equal or lesser cost without paying its cost.";

   ai = {
   },
   
   image_large = { "LC_StarlightSanctum", {0, 0, 364/512, 1} };
   image_medium = { "LC_StarlightSanctum", {392/512, 0, 512/512, 168/512} };
   image_small = { "LC_StarlightSanctum", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LC_StarlightSanctum", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}






g_ascension_cards["Overhaul Cleric"] = {
	card_name = "Overhaul Cleric";
    card_set = "DoC";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 3;
	honor = 1;

	effects = {
		{ "GainRunes", 2 },
		{ "GainRunes", 1, condition={"IfYouControlConstructs",2} },
   };
   
   global_triggered_effects = {
		{
         trigger_type = 1,
			conditions = {
				{ "WhenPlayerAcquiresThisCard", 0 },
			};
			triggereffect = {
				{ "TriggerMarkAcquireEventForRallyMechana", 0 },
			};
		},
	};

	effect_text = "When you acquire this, Rally: Mechana.\n" ..
                  "Gain 2R.\n" ..
                  "If you control two or more Constructs, gain an additional 1R.";

   ai = {
   },
   
   image_large = { "MH_OverhaulCleric", {0, 0, 364/512, 1} };
   image_medium = { "MH_OverhaulCleric", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_OverhaulCleric", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_OverhaulCleric", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_active_effects["rally mechana for acquired construct"] = {
	type = "triggered";
   trigger_type = 1,
	conditions = {
		{ "WhenYouAcquireConstructFromCenterRow", 0 },
	};
	triggereffect = {
      { "TriggerMarkAcquireEventForRallyMechana", 0 },
	};
}


g_ascension_cards["Prospector Scout"] = {
	card_name = "Prospector Scout";
    card_set = "DoC";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 4;
   rune_cost_prever20 = 3;
	honor = 2;

	effects = {
		{ "GainRunes", 2 },
      { "NextConstructYouAcquireFromCenterRowCanRallyMechana", 0 },
   };

	effect_text = "Gain 2R.\n" ..
                  "The next time you acquire a Construct in the center row this turn, Rally: Mechana.";

   ai = {
   },
   
   image_large = { "MH_ProspectorScout", {0, 0, 364/512, 1} };
   image_medium = { "MH_ProspectorScout", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_ProspectorScout", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_ProspectorScout", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Adam, Builder Adept"] = {
	card_name = "Adam, Builder Adept";
    card_set = "DoC";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 7;
	honor = 5;

	effects = {
		{ "GainRunes", 4 },
   };

   global_triggered_effects = {
		{
			conditions = {
				{ "WhenPlayerAcquiresThisCard", 0 },
			};
			triggereffect = {
            { "TriggerPushResolveEffectFromAcquiredCard", 0 },
				{ "TriggerAcquirePlayerMayAcquireAnyCenterRowConstruct", 0 },
            { "TriggerPopResolveEffectFromAcquiredCard", 0 },
			};
		},
	};

	effect_text = "When you acquire this, you may acquire a Construct in the center row without paying its cost.\n" ..
                  "Gain 4R.";

   ai = {
   },
   
   image_large = { "MH_AdamBuilderAdept", {0, 0, 364/512, 1} };
   image_medium = { "MH_AdamBuilderAdept", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_AdamBuilderAdept", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_AdamBuilderAdept", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_cards["Spark Bug"] = {
	card_name = "Spark Bug";
    card_set = "DoC";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 1;
	honor = 1;

	construct_abilities = {
		{
         description = "Gain 2 Runes";
			condition = { "IfPlayedMechanaCards", 2 },
         { "GainRunes", 2 },
         
         ai = {
            trivial = true,
         },
		},
	};

	effect_text = "Once per turn, if you have played two or more Mechana cards (including this one), gain 2R.";

   ai = {
   },
   
   image_large = { "MC_SparkBug", {0, 0, 364/512, 1} };
   image_medium = { "MC_SparkBug", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_SparkBug", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_SparkBug", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Gnome Repairbot"] = {
	card_name = "Gnome Repairbot";
    card_set = "DoC";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 3;
	honor = 3;


	construct_abilities = {
		{
			description = "Recover Construct";
			condition = { "IfHasMechanaConstructsInDiscardPile", 1 },
         { "PushResolvingConstruct", 0 },
			{ "AddMechanaConstructFromDiscardToTopOfDeck", 0 },
         { "PopResolvingConstruct", 0 },
		},
	};

	effect_text = "Once per turn, you may put a Mechana Construct from your discard pile on top of your deck.";

   ai = {
   },
   
   image_large = { "MC_GnomeRepairbot", {0, 0, 364/512, 1} };
   image_medium = { "MC_GnomeRepairbot", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_GnomeRepairbot", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_GnomeRepairbot", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Plasma Cannon"] = {
	card_name = "Plasma Cannon";
    card_set = "DoC";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 8;
	honor = 8;

	construct_abilities = {
		{
			description = "Acquire or Defeat";
			condition = { "IfYouControlMechanaConstructs", 4 },
         { "PushResolvingConstruct", 0 },
			{ "AcquireOrDefeatAnyCenterRow", 0 },
         { "PopResolvingConstruct", 0 },
		},
	};

	effect_text = "Once per turn, if you control four or more Mechana Constructs, " ..
                  "you may acquire or defeat any card in the center row without paying its cost.";

   ai = {
   },
   
   image_large = { "MC_PlasmaCannon", {0, 0, 364/512, 1} };
   image_medium = { "MC_PlasmaCannon", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_PlasmaCannon", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_PlasmaCannon", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_cards["Conversion Port"] = {
	card_name = "Conversion Port";
    card_set = "DoC";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 7;
	honor = 7;

	continuous_effects = {
		{
			effect = { "OwnerTreatsAllConstructsAsAllFactions", 0 };
		},
	};

	effect_text = "You may treat all Constructs as though they are all factions.";

   ai = {
   },
   
   image_large = { "MC_ConversionPort", {0, 0, 364/512, 1} };
   image_medium = { "MC_ConversionPort", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_ConversionPort", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_ConversionPort", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}





g_ascension_cards["Emri's Sting"] = {
	card_name = "Emri's Sting";
    card_set = "DoC";
	card_type = "Construct";
	faction = "Void";
	rune_cost = 6;
	honor = 3;

	construct_ability = {
		description = "Gain 2P";
		{ "GainPower", 2 },
      
      ai = {
         trivial = true,
      },
	};
	triggered_effects = {
		{
			conditions = {
				{ "WhenYouPutThisConstructIntoPlay", 0 },
			};
			triggereffect = {
            { "TriggerPushResolveEffectFromCardsInPlay", 0 },
				{ "TriggerConstructOwnerBanishFromHandOrDiscard", 1 },
            { "TriggerPopResolveEffectFromCardsInPlay", 0 },
			};
		},
	};

	effect_text = "Once per turn, gain 2P.\n" ..
                  "When this enters play, you may banish a card in your hand or discard pile.";

   ai = {
   },
   
   image_large = { "VC_EmrisSting", {0, 0, 364/512, 1} };
   image_medium = { "VC_EmrisSting", {392/512, 0, 512/512, 168/512} };
   image_small = { "VC_EmrisSting", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VC_EmrisSting", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1

}


g_ascension_cards["Undaunted Scout"] = {
	card_name = "Undaunted Scout";
    card_set = "DoC";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 3;
	honor = 2;

	effects = {
		{ "GainPower", 2 },
   };
   
   global_triggered_effects = {
		{
         trigger_type = 1,
			conditions = {
				{ "WhenPlayerAcquiresThisCard", 0 },
			};
			triggereffect = {
				{ "TriggerMarkAcquireEventForRallyVoid", 0 },
			};
		},
	};

	effect_text = "When you acquire this, Rally: Void.\n" ..
                  "Gain 2P.";

   ai = {
   },
   
   image_large = { "VH_UndauntedScout", {0, 0, 364/512, 1} };
   image_medium = { "VH_UndauntedScout", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_UndauntedScout", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_UndauntedScout", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_active_effects["rally void for defeated monster"] = {
	type = "triggered";
   trigger_type = 1,
	conditions = {
		{ "WhenYouDefeatMonsterFromCenterRow", 0 },
	};
	triggereffect = {
      { "TriggerMarkDefeatEventForRallyVoid", 0 },
	};
}


g_ascension_cards["Maniacal Crusher"] = {
	card_name = "Maniacal Crusher";
    card_set = "DoC";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 4;
	honor = 3;

	effects = {
		{ "GainPower", 2 },
      { "NextMonsterYouDefeatFromCenterRowCanRallyVoid", 0 },
   };

	effect_text = "Gain 2P.\n" ..
                  "The next time you defeat a Monster in the center row this turn, Rally: Void.";

   ai = {
   },
   
   image_large = { "VH_ManiacalCrusher", {0, 0, 364/512, 1} };
   image_medium = { "VH_ManiacalCrusher", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_ManiacalCrusher", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_ManiacalCrusher", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_active_effects["defeat void monster gains additional reward"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouDefeatVoidMonster", 3 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerGainDefeatedMonsterReward", 0 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

g_ascension_cards["Riftgate Conjuror"] = {
	card_name = "Riftgate Conjuror";
    card_set = "DoC";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 5;
	honor = 2;

	effects = {
		{ "GainPower", 3 },
      { "NextVoidMonsterYouDefeatGainsAdditionalReward", 0 },
   };

	effect_text = "Gain 3P.\n" ..
                  "The next time you defeat a Void Monster this turn, gain its reward an additional time.";

   ai = {
   },
   
   image_large = { "VH_RiftgateConjuror", {0, 0, 364/512, 1} };
   image_medium = { "VH_RiftgateConjuror", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_RiftgateConjuror", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_RiftgateConjuror", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Shade's Bargain"] = {
	card_name = "Shade's Bargain";
    card_set = "DoC";
	card_type = "Construct";
	faction = "Void";
	rune_cost = 1;
	honor = 1;

	construct_abilities = {
		{
         description = "Gain 2 Power";
			condition = { "IfPlayedVoidCards", 2 },
         { "GainPower", 2 },
         
         ai = {
            trivial = true,
         },
		},
	};

	effect_text = "Once per turn, if you have played two or more Void cards (including this one), gain 2P.";

   ai = {
   },
   
   image_large = { "VC_ShadesBargain", {0, 0, 364/512, 1} };
   image_medium = { "VC_ShadesBargain", {392/512, 0, 512/512, 168/512} };
   image_small = { "VC_ShadesBargain", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VC_ShadesBargain", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Morbid Hammer"] = {
	card_name = "Morbid Hammer";
    card_set = "DoC";
	card_type = "Construct";
	faction = "Void";
	rune_cost = 4;
	honor = 3;

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
				{ "WhenYouPutThisConstructIntoPlay", 0 },
			};
			triggereffect = {
            { "TriggerPushResolveEffectFromCardsInPlay", 0 },
				{ "TriggerConstructOwnerBanishFromHandOrDiscard", 1 },
            { "TriggerPopResolveEffectFromCardsInPlay", 0 },
			};
		},
	};

	effect_text = "Once per turn, gain 1P.\n" ..
                  "When this enters play, you may banish a card in your hand or discard pile.";

   ai = {
   },
   
   image_large = { "VC_MorbidHammer", {0, 0, 364/512, 1} };
   image_medium = { "VC_MorbidHammer", {392/512, 0, 512/512, 168/512} };
   image_small = { "VC_MorbidHammer", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VC_MorbidHammer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}




g_ascension_cards["Rootscryer"] = {
	card_name = "Rootscryer";
    card_set = "DoC";
	card_type = "Hero";
	factions = { "Enlightened", "Lifebound" };
	rune_cost = 2;
	honor = 1;

	effects = {
      { "RevealTopCardOfDeck", 0 },
      { "GainHonor", 3, condition={"IfTopOfDeckIsEnlightenedOrLifebound",0} },
      { "Pause", 0 },
      --{ "PopResolvingCardFromEffectData", 0 },
      { "PopAndDrawRevealedCard", 0 },
	};

	effect_text = "Reveal the top card of your deck and put it into your hand. " ..
                  "If it is Enlightened or Lifebound, gain 3H.";

   ai = {
   },
   
   image_large = { "ELH_Rootscryer", {0, 0, 364/512, 1} };
   image_medium = { "ELH_Rootscryer", {392/512, 0, 512/512, 168/512} };
   image_small = { "ELH_Rootscryer", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "ELH_Rootscryer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 4
}


g_ascension_cards["Canopy Sanctuary"] = {
	card_name = "Canopy Sanctuary";
    card_set = "DoC";
	card_type = "Construct";
	factions = { "Enlightened", "Lifebound" };
	rune_cost = 7;
	honor = 3;

	construct_abilities = {
		{
         description = "Reveal Top of Deck";
         { "RevealTopCardOfDeck", 0 },
         { "GainHonor", 3, condition={"IfTopOfDeckIsEnlightenedOrLifebound",0} },
         { "Pause", 0 },
         --{ "PopResolvingCardFromEffectData", 0 },
         { "PopAndDrawRevealedCard", 0 },

         ai = {
         },
		},
	};

	effect_text = "Once per turn, you may reveal the top card of your deck and put it in your hand. " ..
                  "If it is Enlightened or Lifebound, gain 3H.";

   ai = {
   },
   
   image_large = { "ELC_CanopySanctuary", {0, 0, 364/512, 1} };
   image_medium = { "ELC_CanopySanctuary", {392/512, 0, 512/512, 168/512} };
   image_small = { "ELC_CanopySanctuary", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "ELC_CanopySanctuary", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_cards["Surge Protector"] = {
	card_name = "Surge Protector";
    card_set = "DoC";
	card_type = "Hero";
	factions = { "Enlightened", "Mechana" };
	rune_cost = 5;
	honor = 3;

	effects = {
		{ "AcquireConstructOrDefeatMonster", 5 },
	};

	effect_text = "Choose one: Acquire a Contruct with cost 5R or less without paying its cost, " ..
                  "or defeat a Monster with cost 5P or less without paying its cost.";

   ai = {
   },
   
   image_large = { "EMH_SurgeProtector", {0, 0, 364/512, 1} };
   image_medium = { "EMH_SurgeProtector", {392/512, 0, 512/512, 168/512} };
   image_small = { "EMH_SurgeProtector", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EMH_SurgeProtector", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Library Familiar"] = {
	card_name = "Library Familiar";
    card_set = "DoC";
	card_type = "Construct";
	factions = { "Enlightened", "Mechana" };
	rune_cost = 6;
	honor = 6;

	triggered_effects = {
		{
			conditions = {
				{ "WhenYouPutEnlightenedOrMechanaConstructIntoPlay", 0 },
				{ "IfThisHasntBeenUsedThisTurn", 0 },
			};
			triggereffect = {
				{ "TriggerSetThisHasBeenUsedThisTurn", 0 },
				{ "TriggerConstructOwnerDrawCards", 1 },
			};
		},
	};

	effect_text = "Once per turn, when you play an Enlightened Construct or a Mechana Construct (including this one), " ..
                  "draw a card.";

   ai = {
   },
   
   image_large = { "EMC_LibraryFamiliar", {0, 0, 364/512, 1} };
   image_medium = { "EMC_LibraryFamiliar", {392/512, 0, 512/512, 168/512} };
   image_small = { "EMC_LibraryFamiliar", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EMC_LibraryFamiliar", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Guide of Lost Souls"] = {
	card_name = "Guide of Lost Souls";
    card_set = "DoC";
	card_type = "Hero";
	factions = { "Enlightened", "Void" };
	rune_cost = 3;
	honor = 1;

	effects = {
		{ "BanishFromHandOrDiscard", 1 },
		{ "AcquireMysticOrHeavyInfantryToHand", 0, condition={"IfEffectInstanceDataIsBanishFromHand",0} },
		{ "AcquireMysticOrHeavyInfantry", 0, condition={"IfEffectInstanceDataIsBanishFromDiscard",0} },
	};

	effect_text = "You may banish a card in your hand or discard pile. " ..
                  "If you do, replace it with a Mystic or Heavy Infantry.";

   ai = {
   },
   
   image_large = { "EVH_GuideLostSouls", {0, 0, 364/512, 1} };
   image_medium = { "EVH_GuideLostSouls", {392/512, 0, 512/512, 168/512} };
   image_small = { "EVH_GuideLostSouls", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EVH_GuideLostSouls", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}

g_ascension_cards["Riftdrake Rider"] = {
	card_name = "Riftdrake Rider";
    card_set = "DoC";
	card_type = "Hero";
	factions = { "Enlightened", "Void" };
	rune_cost = 6;
	honor = 4;

	effects = {
		{ "DrawCards", 2 },
      { "BanishMultipleFromHandOrDiscard", 2 },
	};   
	effect_text = "Draw two cards.\n" ..
                  "You may banish up to two cards in your hand or discard pile.";

   ai = {
   },
   
   image_large = { "EVH_RiftdrakeRider", {0, 0, 364/512, 1} };
   image_medium = { "EVH_RiftdrakeRider", {392/512, 0, 512/512, 168/512} };
   image_small = { "EVH_RiftdrakeRider", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EVH_RiftdrakeRider", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_cards["Wildgear Sower"] = {
	card_name = "Wildgear Sower";
    card_set = "DoC";
	card_type = "Hero";
	factions = { "Lifebound", "Mechana" };
	rune_cost = 4;
	honor = 2;

	effects = {
		{ "GainRunes", 2 },
		{ "GainHonorForEachTypeOfConstructInPlay", 1 },
	};

	effect_text = "Gain 2R.\n" ..
                  "Gain 1H for each faction among Constructs your control. " ..
                  "(Factions are Enlightened, Lifebound, Mechana and Void).";

   ai = {
   },
   
   image_large = { "LMH_WildgearSower", {0, 0, 364/512, 1} };
   image_medium = { "LMH_WildgearSower", {392/512, 0, 512/512, 168/512} };
   image_small = { "LMH_WildgearSower", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LMH_WildgearSower", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Genesis Capsule"] = {
	card_name = "Genesis Capsule";
    card_set = "DoC";
	card_type = "Construct";
	factions = { "Lifebound", "Mechana" };
	rune_cost = 5;
	honor = 5;

   continuous_effects = {
      {
         effect = { "MayPutAcquiredLifeboundHeroOrMechanaConstructOnDeckEachTurn", 0 };
      },
   };

	effect_text = "Once per turn, when you acquire a Lifebound Hero or Mechana Construct, " ..
                  "you may put it on top of your deck.";

   ai = {
   },
   
   image_large = { "LMC_GenesisCapsule", {0, 0, 364/512, 1} };
   image_medium = { "LMC_GenesisCapsule", {392/512, 0, 512/512, 168/512} };
   image_small = { "LMC_GenesisCapsule", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LMC_GenesisCapsule", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Shepherd of the Lost"] = {
	card_name = "Shepherd of the Lost";
    card_set = "DoC";
	card_type = "Hero";
	factions = { "Lifebound", "Void" };
	rune_cost = 3;
	honor = 1;

	effects = {
		{ "GainRunes", 2 },
   };
	banish_effect = { "GainHonor", 5, condition={"IfBanishEventIsFromHandOrDiscard",0} };

	effect_text = "Gain 2R.\n" ..
                  "If this is banished from your hand or discard pile, gain 5H.";

   ai = {
      trivial = true,
      preferred_banish = true,

      gain_rune = 2,
   },
   
   image_large = { "LVH_ShepherdLost", {0, 0, 364/512, 1} };
   image_medium = { "LVH_ShepherdLost", {392/512, 0, 512/512, 168/512} };
   image_small = { "LVH_ShepherdLost", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LVH_ShepherdLost", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}

g_ascension_cards["Muse of Rebirth"] = {
	card_name = "Muse of Rebirth";
    card_set = "DoC";
	card_type = "Hero";
	factions = { "Lifebound", "Void" };
	rune_cost = 4;
	honor = 2;

	effects = {
		{ "GainRunes", 2 },
		{ "BanishFromHandOrDiscard", 1 },
   };

	effect_text = "Gain 2R.\n" ..
                  "You may banish a card in your hand or discard pile.";

   ai = {
   },
   
   image_large = { "LVH_MuseRebirth", {0, 0, 364/512, 1} };
   image_medium = { "LVH_MuseRebirth", {392/512, 0, 512/512, 168/512} };
   image_small = { "LVH_MuseRebirth", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LVH_MuseRebirth", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Clockwork Sentry"] = {
	card_name = "Clockwork Sentry";
    card_set = "DoC";
	card_type = "Hero";
	factions = { "Mechana", "Void" };
	rune_cost = 2;
	honor = 1;

	effects = {
		{ "GainPower", 2 },
		{ "GainPower", 2, condition={"IfYouControlConstructs",2} },
   };

	effect_text = "Gain 2P.\n" ..
                  "If you control two or more Constructs, gain an additional 2P.";

   ai = {
   },
   
   image_large = { "MVH_ClockworkSentry", {0, 0, 364/512, 1} };
   image_medium = { "MVH_ClockworkSentry", {392/512, 0, 512/512, 168/512} };
   image_small = { "MVH_ClockworkSentry", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MVH_ClockworkSentry", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Riftwatch Turret"] = {
	card_name = "Riftwatch Turret";
    card_set = "DoC";
	card_type = "Construct";
	factions = { "Mechana", "Void" };
	rune_cost = 4;
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
				{ "WhenYouPutMechanaConstructIntoPlay", 0 },
				{ "IfThisHasntBeenUsedThisTurn", 0 },
			};
			triggereffect = {
				{ "TriggerSetThisHasBeenUsedThisTurn", 0 },
				{ "TriggerConstructGainPower", 1 },
			};
		},
	};

	effect_text = "Once per turn, gain 1P.\n" ..
                  "Once per turn, when you play a Mechana Construct (including this one), gain 1P.";

   ai = {
   },
   
   image_large = { "MVC_RiftwatchTurret", {0, 0, 364/512, 1} };
   image_medium = { "MVC_RiftwatchTurret", {392/512, 0, 512/512, 168/512} };
   image_small = { "MVC_RiftwatchTurret", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MVC_RiftwatchTurret", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}








g_ascension_cards["Corrupted Sage"] = {
	card_name = "Corrupted Sage";
    card_set = "DoC";
	card_type = "Monster";
	faction = "Enlightened";
	power_cost = 3;

   rally_faction_when_defeated = true;
	rewards = {
		{ "GainHonor", 2 },
		{ "DrawCards", 1 },
      --{ "MarkDefeatEventForRallyEnlightened", 0 },
	};

	effect_text = "REWARD: Gain 2H. Draw a card.\n" ..
                  "Rally: Enlightened.";

   ai = {
   },
   
   image_large = { "EM_CorruptedSage", {0, 0, 364/512, 1} };
   image_medium = { "EM_CorruptedSage", {392/512, 0, 512/512, 168/512} };
   image_small = { "EM_CorruptedSage", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EM_CorruptedSage", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Corrupt_Sage_Defeat" };

   rarity_count = 4
}

g_ascension_cards["Betrayed Templar"] = {
	card_name = "Betrayed Templar";
    card_set = "DoC";
	card_type = "Monster";
	faction = "Enlightened";
	power_cost = 6;

	rewards = {
		{ "GainHonor", 5 },
      { "DefeatMonsterFromCenterRowWithLessPower", 5 },
	};
   
	effect_text = "REWARD: Gain 5H. " ..
                  "You may defeat a Monster in the center row with cost 5P or less without paying its cost.";

   ai = {
   },
   
   image_large = { "EM_BetrayedTemplar", {0, 0, 364/512, 1} };
   image_medium = { "EM_BetrayedTemplar", {392/512, 0, 512/512, 168/512} };
   image_small = { "EM_BetrayedTemplar", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EM_BetrayedTemplar", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Betrayed_Templar_Defeat" };

   rarity_count = 1
}


g_ascension_cards["Thorned Charger"] = {
	card_name = "Thorned Charger";
    card_set = "DoC";
	card_type = "Monster";
	faction = "Lifebound";
	power_cost = 4;

   rally_faction_when_defeated = true;
	rewards = {
		{ "GainHonor", 3 },
      { "PutHeroFromDiscardToTopOfDeck", 0 },
      --{ "MarkDefeatEventForRallyLifebound", 0 },
	};

	effect_text = "REWARD: Gain 3H. " ..
                  "You may put a Hero from your discard pile on top of your deck.\n" ..
                  "Rally: Lifebound.";

   ai = {
   },
   
   image_large = { "LM_ThornedCharger", {0, 0, 364/512, 1} };
   image_medium = { "LM_ThornedCharger", {392/512, 0, 512/512, 168/512} };
   image_small = { "LM_ThornedCharger", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LM_ThornedCharger", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Thorned_Charger_Defeat" };

   rarity_count = 4
}

g_ascension_cards["Cult of the False Circle"] = {
	card_name = "Cult of the False Circle";
    card_set = "DoC";
	card_type = "Monster";
	faction = "Lifebound";
	power_cost = 6;

	rewards = {
		{ "GainHonor", 5 },
		{ "MayAcquireHeroWithLessCost", 5 },
	};
   
	effect_text = "REWARD: Gain 5H. " ..
                  "You may acquire a Hero with cost 5R or less without paying its cost.";

   ai = {
   },
   
   image_large = { "LM_CultFalseCircle", {0, 0, 364/512, 1} };
   image_medium = { "LM_CultFalseCircle", {392/512, 0, 512/512, 168/512} };
   image_small = { "LM_CultFalseCircle", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LM_CultFalseCircle", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Cult_Of_The_False_Circle_Defeat" };

   rarity_count = 2
}

g_ascension_active_effects["construct acquired costs 3 less"] = {
	type = "continuous";
	effectfunc = { "ReduceConstructRuneCost", 3 };
}


g_ascension_cards["Rejected Prototype"] = {
	card_name = "Rejected Prototype";
    card_set = "DoC";
	card_type = "Monster";
	faction = "Mechana";
	power_cost = 4;

   rally_faction_when_defeated = true;
	rewards = {
		{ "GainHonor", 3 },
		{ "NextContructYouAcquireCosts3RLess", 0 },
      --{ "MarkDefeatEventForRallyMechana", 0 },
	};

	effect_text = "REWARD: Gain 3H. " ..
                  "You pay 3R less the next time you acquire a Construct this turn.\n" ..
                  "Rally: Mechana.";

   ai = {
   },
   
   image_large = { "MM_RejectedPrototype", {0, 0, 364/512, 1} };
   image_medium = { "MM_RejectedPrototype", {392/512, 0, 512/512, 168/512} };
   image_small = { "MM_RejectedPrototype", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MM_RejectedPrototype", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Rejected_Prototype_Defeat" };

   rarity_count = 4
}

g_ascension_cards["Exhaust Lurker"] = {
	card_name = "Exhaust Lurker";
    card_set = "DoC";
	card_type = "Monster";
	faction = "Mechana";
	power_cost = 5;

	rewards = {
		{ "GainHonor", 5 },
		{ "EachOpponentDestroysConstructsForYourConstructs", 0 },
	};

	effect_text = "REWARD: Gain 5H. " ..
                  "Each opponent destroys a Construct they control for each Construct you control.";

   ai = {
   },
   
   image_large = { "MM_ExhaustLurker", {0, 0, 364/512, 1} };
   image_medium = { "MM_ExhaustLurker", {392/512, 0, 512/512, 168/512} };
   image_small = { "MM_ExhaustLurker", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MM_ExhaustLurker", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Exhaust_Lurker_Defeat" };

   rarity_count = 2
}


g_ascension_cards["Deathfinder"] = {
	card_name = "Deathfinder";
    card_set = "DoC";
	card_type = "Monster";
	faction = "Void";
	power_cost = 3;

   rally_faction_when_defeated = true;
	rewards = {
		{ "GainHonor", 2 },
		{ "BanishFromHandOrDiscard", 1 },
      --{ "MarkDefeatEventForRallyVoid", 0 },
	};

	effect_text = "REWARD: Gain 2H. " ..
                  "You may banish a card in your hand or discard pile.\n" ..
                  "Rally: Void.";

   ai = {
   },
   
   image_large = { "VM_Deathfinder", {0, 0, 364/512, 1} };
   image_medium = { "VM_Deathfinder", {392/512, 0, 512/512, 168/512} };
   image_small = { "VM_Deathfinder", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VM_Deathfinder", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Deathfinder_Defeat" };

   rarity_count = 4
}

g_ascension_cards["Wild Riftdrake"] = {
	card_name = "Wild Riftdrake";
    card_set = "DoC";
	card_type = "Monster";
	faction = "Void";
	power_cost = 5;

	rewards = {
		{ "GainHonor", 4 },
      { "BanishMultipleFromHandOrDiscard", 2 },
	};

	effect_text = "REWARD: Gain 4H. " ..
                  "You may banish up to two cards from your hand or discard pile.";

   ai = {
   },
   
   image_large = { "VM_WildRiftdrake", {0, 0, 364/512, 1} };
   image_medium = { "VM_WildRiftdrake", {392/512, 0, 512/512, 168/512} };
   image_small = { "VM_WildRiftdrake", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VM_WildRiftdrake", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Wild_Riftdrake_Defeat" };

   rarity_count = 2
}


g_ascension_cards["Aranyx, the Glutton"] = {
	card_name = "Aranyx, the Glutton";
    card_set = "DoC";
	card_type = "Monster";
	power_cost = 7;

   rally_faction_when_defeated = true;
	rewards = {
		{ "GainHonor", 4 },
      { "GainPower", 7 },
      --{ "MarkDefeatEventForRallyMonster", 0 },
	};

	effect_text = "REWARD: Gain 4H. Gain 7P.\n" ..
                  "Rally: Monster.";

   ai = {
   },
   
   image_large = { "M_AranyxGlutton", {0, 0, 364/512, 1} };
   image_medium = { "M_AranyxGlutton", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_AranyxGlutton", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_AranyxGlutton", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Aranyx_The_Glutton_Defeat" };

   rarity_count = 1
}

g_ascension_cards["Xeron, Lord of Deofol"] = {
	card_name = "Xeron, Lord of Deofol";
    card_set = "DoC";
	card_type = "Monster";
	power_cost = 9;
   trophy_monster = true;

	rewards = {
		{ "GainHonor", 6 },
	};

	trophy_effects = {
      usageconditions = {
         { "IfTrophyEffectDataEquals0", 0 },
      },
      { "IncrementTrophyEffectData", 0 },
      { "MayDefeatHeroesWithPowerUntilEndOfTurn", 0 },

	};

   triggered_effects = {
		{
			conditions = {
				{ "AtStartOfTrophyOwnerTurn", 0 },
			};
			triggereffect = {
				{ "TriggerResetTrophyEffectData", 0 },
			};
		},
	};

	--effect_text = "REWARD: Gain 6H.\n" ..
    --              "ONGOING TROPHY: You may defeat Heroes in the center row by paying P equal to their R cost. " ..
    --              "If you do, gain H equal to its H value and copy the effect of that Hero.";
	effect_text = "REWARD: Gain 6H.";
	trophy_text = "<color=#951719FF><B>Ongoing Trophy:</B></color> You may defeat Heroes in the center row by paying P equal to their R cost. " ..
                  "If you do, gain H equal to its H value and copy the effect of that Hero.";

   ai = {
      trivial = true,
   },
   
   image_large = { "M_XeronLordDeofol", {0, 0, 364/512, 1} };
   image_medium = { "M_XeronLordDeofol", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_XeronLordDeofol", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_XeronLordDeofol", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Xeron_Lord_Of_Deogol_Defeat" };

   rarity_count = 1
}





