

g_ascension_cards["Moment of Clarity"] = { 
	card_name = "Moment of Clarity";
	card_set = "IH";
	card_type = "Event";
	faction = "Enlightened";
   
	triggered_effects = {
		{
			conditions = {
				{ "WhenPlayerAcquiresEnlightenedCard", 0 },
			};
			triggereffect = {
            { "TriggerPushResolvingEvent", 0 },
				{ "TriggerAcquirePlayerMayDrawCards", 1 },
            { "TriggerPopResolvingEvent", 0 },
			};
		},
	};
   
	trophy_effects = {
		{ "BanishFromHand", 0 },
		{ "AcquireMysticToHand", 0, condition={"IfYouDo",0} },
	};
   
   effect_text = "When a player acquires an Enlightened card, that player may draw a card.\n" ..
                  "  EVENT TROPHY: Banish a card in your hand. If you do, acquire a Mystic without paying its cost. Put it into your hand.";

   image_large = { "E_MomentClarity", {0, 0, 364/512, 1} };
   image_medium = { "E_MomentClarity", {392/512, 0, 512/512, 168/512} };
   image_small = { "E_MomentClarity", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "E_MomentClarity", {384/512, 395/512, 512/512, 512/512} };
}


g_ascension_cards["Aaron, the Godslayer"] = { 
	card_name = "Aaron, the Godslayer";
	card_set = "IH";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 7;
	honor = 4;
   
	effects = {
      { "DefeatMonsterWithLessPower", 0 },
   };
	effect_text = "Defeat a Monster without paying its cost.";

   ai = {
      defeat_monster = 10;
   },
   
   image_large = { "EH_AaronGodslayer", {0, 0, 364/512, 1} };
   image_medium = { "EH_AaronGodslayer", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_AaronGodslayer", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_AaronGodslayer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Arha Medium"] = { 
	card_name = "Arha Medium";
	card_set = "IH";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 2;
	honor = 1;
   
	effects = {
		{ "BanishThisCard", 0 },
		{ "AcquireMysticOrHeavyInfantryToHand", 0, condition={"IfYouDo",0} },
   };
	effect_text = "You may banish this to acquire a Mystic or Heavy Infantry without paying its cost.  Put it into your hand.";

   image_large = { "EH_ArhaMedium", {0, 0, 364/512, 1} };
   image_medium = { "EH_ArhaMedium", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_ArhaMedium", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_ArhaMedium", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Askara of Souls"] = { 
	card_name = "Askara of Souls";
	card_set = "IH";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 4;
	honor = 2;
   
	effects = {
		{ "GainSoulGem", 1 },
   };
	effect_text = "Gain a Soul Gem.";

   image_large = { "EH_AskaraSouls", {0, 0, 364/512, 1} };
   image_medium = { "EH_AskaraSouls", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_AskaraSouls", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_AskaraSouls", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Elan, Soul Marshal"] = { 
	card_name = "Elan, Soul Marshal";
	card_set = "IH";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 6;
	honor = 3;
   
	effects = {
		{ "GainSoulGem", 1 },
		{ "DrawCards", 1 },
   };
	effect_text = "Gain a Soul Gem.  Draw a card.";

   ai = {
      gain_draw = 1;
   },

   image_large = { "EH_ElanSoulMarshal", {0, 0, 364/512, 1} };
   image_medium = { "EH_ElanSoulMarshal", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_ElanSoulMarshal", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_ElanSoulMarshal", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Temple Guardian"] = { 
	card_name = "Temple Guardian";
	card_set = "IH";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 5;
	honor = 4;
   
	effects = {
      { "DefeatMonsterWithLessPower", 5 },
      { "DrawCards", 1, condition={"IfCurrentEventIsEnlightened",0} },
   };
	effect_text = "Defeat a Monster with P5 or less without paying its cost.\n" ..
                  "If the current Event is Enlightened, draw a card.";

   ai = {
      defeat_monster = 5;
   },

   image_large = { "EH_TempleGuardian", {0, 0, 364/512, 1} };
   image_medium = { "EH_TempleGuardian", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_TempleGuardian", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_TempleGuardian", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Wandering Askara"] = { 
	card_name = "Wandering Askara";
	card_set = "IH";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 3;
	honor = 1;
   
	effects = {
      { "DrawCards", 1 },
		{ "BanishFromCenterRow", 1 },
      { "YouMayBanishThisCard", 0, condition={"IfYouHaveWanderingAskaraInPlay",0} },
      { "TakeAnAdditionalTurn", 0, condition={"IfYouDo",2} },
      { "BanishAWanderingAskaraFromPlay", 0, condition={"IfYouDo",2} },
   };
	effect_text = "Draw a card, then you may banish a card in the center row.\n" ..
                  "If you have played another Wandering Askara this turn, you may banish both cards to take another turn after this one.";

   ai = {
      gain_draw = 1;
   },

   image_large = { "EH_WanderingAskara", {0, 0, 364/512, 1} };
   image_medium = { "EH_WanderingAskara", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_WanderingAskara", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_WanderingAskara", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}





g_ascension_active_effects["hero is lifebound"] = {
	type = "continuous";
	effectfunc = { "HeroIsLifebound", 1 };
}


g_ascension_cards["The Great Eclipse"] = { 
	card_name = "The Great Eclipse";
	card_set = "IH";
	card_type = "Event";
	faction = "Lifebound";
   
   continuous_effects = {
      {
         priority = -10;
         effect = { "AnyPlayerMayPutAcquiredLifeboundHeroOnTopOfDeck", 0 };
      },
   };
   
   trophy_effects = {
      { "PushResolvingEvent", 0 },
      { "ChooseHeroName", 0 },
      { "MarkHeroIsLifeboundThisTurn", 1 },
      { "PopResolvingEvent", 0 },
	};
   
   
   effect_text = "When a player acquires a Lifebound Hero, that player may put it on top of their deck.\n" ..
                  "  EVENT TROPHY: Name a Hero. That Hero is also Lifebound this turn.";

   image_large = { "E_GreatEclipse", {0, 0, 364/512, 1} };
   image_medium = { "E_GreatEclipse", {392/512, 0, 512/512, 168/512} };
   image_small = { "E_GreatEclipse", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "E_GreatEclipse", {384/512, 395/512, 512/512, 512/512} };
}


g_ascension_active_effects["unite gain 1H 1R 1P 1D"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayLifeboundHero", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerGainRunes", 1 },
      { "TriggerGainPower", 1 },
      { "TriggerGainHonor", 1 },
		{ "TriggerEffectPlayerDrawCards", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}


g_ascension_cards["Sabre, the Moonlit"] = { 
	card_name = "Sabre, the Moonlit";
	card_set = "IH";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 6;
	honor = 3;
	effects = {
		{ "GainRunes", 1 },
		{ "GainPower", 1 },
		{ "GainHonor", 1 },
		{ "DrawCards", 1 },
		{ "GainRunes", 1, condition={"IfPlayedLifeboundHero",1} },
		{ "GainPower", 1, condition={"IfPlayedLifeboundHero",1} },
		{ "GainHonor", 1, condition={"IfPlayedLifeboundHero",1} },
		{ "DrawCards", 1, condition={"IfPlayedLifeboundHero",1} },
      { "UniteGain1Rand1Pand1HandDraw1Card", 0, condition={"IfHaventPlayedLifeboundHero",1} },
	};
	effect_text = "Gain 1R. Gain 1P. Gain 1H. Draw a card. \n" ..
                  "UNITE: Gain 1R. Gain 1P. Gain 1H. Draw a card.";

   ai = {

      gain_power = 1;
      gain_rune = 1;
      gain_honor = 1;
      gain_draw = 1;
   },

   image_large = { "LH_SabreMoonlit", {0, 0, 364/512, 1} };
   image_medium = { "LH_SabreMoonlit", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_SabreMoonlit", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_SabreMoonlit", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_active_effects["unite gain 1 soul gem"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayLifeboundHero", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerEffectPlayerGainsSoulGems", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}


g_ascension_cards["Spider Witch"] = { 
	card_name = "Spider Witch";
	card_set = "IH";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 3;
	honor = 2;
	effects = {
		{ "GainHonor", 2 },
		{ "GainSoulGem", 1, condition={"IfPlayedLifeboundHero",1} },
      { "UniteGain1SoulGem", 0, condition={"IfHaventPlayedLifeboundHero",1} },
	};
	effect_text = "Gain 2H.  UNITE: Gain a Soul Gem.";

   ai = {

      gain_honor = 2;
   },

   image_large = { "LH_SpiderWitch", {0, 0, 364/512, 1} };
   image_medium = { "LH_SpiderWitch", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_SpiderWitch", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_SpiderWitch", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Stone Circle Elder"] = { 
	card_name = "Stone Circle Elder";
	card_set = "IH";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 5;
	honor = 3;
   
	effects = {
      { "AcquireHeroToTopOfDeck", 5 },
      { "DrawCards", 1, condition={"IfCurrentEventIsLifebound",0} },
   };
   
	effect_text = "Acquire a Hero that costs R5 or less without paying its cost.  Put it on top of your deck.\n" ..
                  "If the current Event is Lifebound, draw a card.";
   
   image_large = { "LH_StoneCircleElder", {0, 0, 364/512, 1} };
   image_medium = { "LH_StoneCircleElder", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_StoneCircleElder", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_StoneCircleElder", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Wolf Acolyte"] = { 
	card_name = "Wolf Acolyte";
	card_set = "IH";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 1;
	honor = 1;
	effects = {
		{ "GainRunes", 1 },
		{ "DrawCards", 1, condition={"IfPlayedLifeboundHero",1} },
      { "UniteDraw1Card", 0, condition={"IfHaventPlayedLifeboundHero",1} },
	};
	effect_text = "Gain 1R.  UNITE: Draw a card.";

   ai = {
      gain_rune = 1;
   },

   image_large = { "LH_WolfAcolyte", {0, 0, 364/512, 1} };
   image_medium = { "LH_WolfAcolyte", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_WolfAcolyte", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_WolfAcolyte", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}



g_ascension_cards["Beast Staff"] = { 
	card_name = "Beast Staff";
	card_set = "IH";
	card_type = "Construct";
	faction = "Lifebound";
	rune_cost = 4;
	honor = 2;
   
	construct_abilities = {
		{
			ability_name = "Beast Staff to gain 1 Power",
			description = "Gain 1P";
			{ "GainPower", 1 },
      
         ai = {
            trivial = true,
         },
		},
		{
			ability_name = "Beast Staff to reveal deck",
			description = "Pay 1R, Reveal top of Deck and gain H";
			condition = { "IfHasCurrentTurnRunesAndCardInDeckOrDiscard", 1 },
         { "PushResolvingConstruct", 0 },
			{ "PayRunes", 1 },
			{ "RevealTopCardOfDeck", 0 },
         { "Pause", 0, condition={"IfYouDo",2} },
         { "GainHonorEqualToRevealedCardHonorValue", 2, condition={"IfYouDo",2} },
         { "PopRevealedCardToDeck", 2, condition={"IfYouDo",2} },
         { "PopResolvingConstruct", 0 },
		},
	};
	effect_text = "Once per turn, gain 1P.\n" ..
                  "Once per turn, you may pay 1R to reveal the top card of you deck. Gain Honor equal to its Honor Value.";

   ai = {
      gain_power = 1;
   },

   image_large = { "LC_BeastStaff", {0, 0, 364/512, 1} };
   image_medium = { "LC_BeastStaff", {392/512, 0, 512/512, 168/512} };
   image_small = { "LC_BeastStaff", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LC_BeastStaff", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}



g_ascension_cards["The World Tree"] = { 
	card_name = "The World Tree";
	card_set = "IH";
	card_type = "Construct";
	faction = "Lifebound";
	rune_cost = 7;
	honor = 4;
   
   
   construct_ability = {
		description = "Pay R -> Gain H";
      condition = { "IfHasCurrentTurnRunes", 1 },
      { "PushResolvingConstruct", 0 },
		{ "ChooseFromEffectList",
			{
            prompt = "You May Convert Runes To Honor",
				{
               { "PayRunes", 1 },
					{ "GainHonor", 1 },
					description = "Gain 1 Honor",
               usagecondition = { "IfHasCurrentTurnRunes", 1 },
				},
				{
               { "PayRunes", 2 },
					{ "GainHonor", 2 },
					description = "Gain 2 Honor",
               usagecondition = { "IfHasCurrentTurnRunes", 2 },
				},
				{
               { "PayRunes", 3 },
					{ "GainHonor", 3 },
					description = "Gain 3 Honor",
               usagecondition = { "IfHasCurrentTurnRunes", 3 },
				},
				{
               { "PayRunes", 4 },
					{ "GainHonor", 4 },
					description = "Gain 4 Honor",
               usagecondition = { "IfHasCurrentTurnRunes", 4 },
				},
				{
               { "PayRunes", 5 },
					{ "GainHonor", 5 },
					description = "Gain 5 Honor",
               usagecondition = { "IfHasCurrentTurnRunes", 5 },
				},
			}
		},
      { "PopResolvingConstruct", 0 },

      ai = {
         use_at_end_of_turn = true,
      },
	};

	triggered_effects = {
		{
			conditions = {
				{"WhenConstructOwnerPlaysLifeboundHero", 0 },
			};
			triggereffect = {
				{"TriggerConstructGainRunes", 1},
			};
		},
	};
   
	effect_text = "Once per turn, you may pay up to 5R to gain that much H. \n" ..
                  "When you play a Lifebound Hero, gain 1R.";

   image_large = { "LC_WorldTree", {0, 0, 364/512, 1} };
   image_medium = { "LC_WorldTree", {392/512, 0, 512/512, 168/512} };
   image_small = { "LC_WorldTree", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LC_WorldTree", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}







g_ascension_cards["Cosmic Protocol"] = { 
	card_name = "Cosmic Protocol";
	card_set = "IH";
	card_type = "Event";
	faction = "Mechana";
   
   continuous_effects = {
      {
         priority = -10;
         effect = { "AnyPlayerMayPutAcquiredMechanaConstructIntoPlay", 0 };
      },
   };
   
   trophy_effects = {
      { "NextMechanaConstructYouAcquireCosts2Less", 0 },
	};
   
   effect_text = "When a player acquires a Mechana Construct, that player may put it directly into play.\n" ..
                  "  EVENT TROPHY: You pay 2R less to acquire your next Mechana Construct this turn.";

   image_large = { "E_CosmicProtocol", {0, 0, 364/512, 1} };
   image_medium = { "E_CosmicProtocol", {392/512, 0, 512/512, 168/512} };
   image_small = { "E_CosmicProtocol", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "E_CosmicProtocol", {384/512, 395/512, 512/512, 512/512} };
}


g_ascension_cards["Energy Monk"] = { 
	card_name = "Energy Monk";
	card_set = "IH";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 4;
	honor = 3;
   
	effects = {
		{ "GainPower", 2 },
      { "ReturnConstructToHand", 1 },
	};
	effect_text = "Gain 2P.  You may return a Construct you control to your hand.";

   ai = {
      gain_power = 2;
   },

   image_large = { "MH_EnergyMonk", {0, 0, 364/512, 1} };
   image_medium = { "MH_EnergyMonk", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_EnergyMonk", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_EnergyMonk", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Hedron Pyromaniac"] = { 
	card_name = "Hedron Pyromaniac";
	card_set = "IH";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 4;
	honor = 2;
	effects = {
		{"GainRunes", 2},
      { "DestroyConstruct", 1 },
		{ "GainSoulGem", 1, condition={"IfYouDo",1} },
	};
	effect_text = "Gain 2R.  You may destroy a Construct you control to gain a Soul Gem.";

   ai = {
      gain_runes = 2;
   },

   image_large = { "MH_HedronPyromaniac", {0, 0, 364/512, 1} };
   image_medium = { "MH_HedronPyromaniac", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_HedronPyromaniac", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_HedronPyromaniac", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Astroblade TRX"] = { 
	card_name = "Astroblade TRX";
	card_set = "IH";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 5;
	honor = 5;
   
	triggered_effects = {
		{
			conditions = {
				{"IfThisHasntBeenUsedThisTurn", 0 },
				{"WhenYouPutMechanaConstructIntoPlay", 0 },
			};
			triggereffect = {
				{"TriggerConstructGainHonor", 1},
				{"TriggerSetThisHasBeenUsedThisTurn", 0},
			};
		},
	};
   
	effect_text = "Once per turn, when you play a Mechana Construct (including this one), gain 1H.";

   image_large = { "MC_AstrolabeTRX", {0, 0, 364/512, 1} };
   image_medium = { "MC_AstrolabeTRX", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_AstrolabeTRX", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_AstrolabeTRX", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Driller Mark IV"] = { 
	card_name = "Driller Mark IV";
	card_set = "IH";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 6;
	honor = 6;
   
	triggered_effects = {
		{
			conditions = {
				{"IfThisHasntBeenUsedThisTurn", 0 },
				{"WhenYouPutMechanaConstructIntoPlay", 0 },
			};
			triggereffect = {
				{"TriggerEffectPlayerGainsSoulGems", 1},
				{"TriggerSetThisHasBeenUsedThisTurn", 0},
			};
		},
	};
   
	effect_text = "Once per turn, when you play a Mechana Construct (including this one), gain a Soul Gem.";

   image_large = { "MC_DrillerMarkIV", {0, 0, 364/512, 1} };
   image_medium = { "MC_DrillerMarkIV", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_DrillerMarkIV", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_DrillerMarkIV", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Recyclicrab"] = { 
	card_name = "Recyclicrab";
	card_set = "IH";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 3;
	honor = 3;
   
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
   
	effect_text = "When you play a Mechana Construct, if this is in your discard pile you may return it to your hand.";

   image_large = { "MC_Recyclicrab", {0, 0, 364/512, 1} };
   image_medium = { "MC_Recyclicrab", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_Recyclicrab", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_Recyclicrab", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Repurposer"] = { 
	card_name = "Repurposer";
	card_set = "IH";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 7;
	honor = 7;
   
	triggered_effects = {
      {
			conditions = {
				{"IfThisHasntBeenUsedThisTurn", 0 },
				{"WhenYouPutMechanaConstructIntoPlay", 0 },
			};
			triggereffect = {
            {"TriggerAddConstructFromDiscardIntoHand", 0},
            {"TriggerSetThisHasBeenUsedThisTurn", 0},
			};
		},
	};

	effect_text = "Once per turn, when you play a Mechana Construct (including this one), " ..
                  "you may return a Construct from your discard pile to your hand.";

   image_large = { "MC_Repurposer", {0, 0, 364/512, 1} };
   image_medium = { "MC_Repurposer", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_Repurposer", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_Repurposer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Spark Sprayer"] = { 
	card_name = "Spark Sprayer";
	card_set = "IH";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 4;
	honor = 4;
   
   construct_ability = {
		description = "Destroy Construct -> Gain 1P";
      { "DestroyMechanaConstruct", 0 },
		{ "GainPower", 1, condition={"IfYouDo",0} },
		{ "GainPower", 1, condition={"IfYouDoAndCurrentEventIsMechana",0} },
	};
   
	effect_text = "Once per turn, you may destroy a Mechana Construct you control to gain 1P.\n" ..
                  "  If the current Event is Mechana, gain an additional 1P.";

   image_large = { "MC_SparkSprayer", {0, 0, 364/512, 1} };
   image_medium = { "MC_SparkSprayer", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_SparkSprayer", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_SparkSprayer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}








g_ascension_cards["Annihilation"] = { 
	card_name = "Annihilation";
	card_set = "IH";
	card_type = "Event";
	faction = "Void";

	triggered_effects = {
		{
			conditions = {
				{ "WhenPlayerAcquiresVoidCard", 0 },
			};
			triggereffect = {
            { "TriggerPushResolvingEvent", 0 },
            { "TriggerAcquirePlayerBanishFromHandOrDiscard", 1 },
            { "TriggerPopResolvingEvent", 0 },
			};
		},
	};
   
   trophy_effects = {
      { "GainPower", 1 },
	};
   
   effect_text = "When a player acquires a Void card, that player may banish a card in their hand or discard pile.\n" ..
                  "  EVENT TROPHY: Gain 1P.";

   image_large = { "E_Annihilation", {0, 0, 364/512, 1} };
   image_medium = { "E_Annihilation", {392/512, 0, 512/512, 168/512} };
   image_small = { "E_Annihilation", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "E_Annihilation", {384/512, 395/512, 512/512, 512/512} };
}


g_ascension_active_effects["monster defeated gains 3 runes"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouDefeatMonsterFromCenterRow", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerGainRunes", 3 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}


g_ascension_cards["Belthar, Soul Collector"] = { 
	card_name = "Belthar, Soul Collector";
	card_set = "IH";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 6;
	honor = 3;
	effects = {
		{ "GainPower", 3 },
		{ "NextMonsterYouDefeatFromCenterRowGains3Runes", 1 },
	};
	effect_text = "Gain 3P. The next time you defeat a Monster in the center row this turn, gain 3R.";

   ai = {
      gain_power = 3;
   },

   image_large = { "VH_BeltharSoulCollector", {0, 0, 364/512, 1} };
   image_medium = { "VH_BeltharSoulCollector", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_BeltharSoulCollector", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_BeltharSoulCollector", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}



g_ascension_cards["Deathsworn Warrior"] = { 
	card_name = "Deathsworn Warrior";
	card_set = "IH";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 1;
	honor = 1;

	center_row = { "EachPlayerMayBanishFromHandOrDiscard", 1 },
	
   effects = {
		{ "GainPower", 1 },
		{ "BanishFromHandOrDiscard", 1 },
		{ "YouMayBanishThisCard", 2 },
		{ "BanishFromHandOrDiscard", 1, condition={"IfYouDo",2}  },
	};
   
   ai = {
      gain_power = 1;
      
      preferred_banish = true;
   },

   
	--effect_text = "FATE: Each player may banish a card from their hand or discard pile.\n" ..
    --              "Gain 1P. You may banish a card in your hand or discard pile. " ..
    --              "Then, you may banish this to banish a second card in your hand or discard pile.";
	fate_text = "FATE: Each player may banish a card from their hand or discard pile.";
	effect_text = "Gain 1P. You may banish a card in your hand or discard pile. " ..
                  "Then, you may banish this to banish a second card in your hand or discard pile.";

   image_large = { "VH_DeathswornWarrior", {0, 0, 364/512, 1} };
   image_medium = { "VH_DeathswornWarrior", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_DeathswornWarrior", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_DeathswornWarrior", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}



g_ascension_cards["Soulshaper"] = { 
	card_name = "Soulshaper";
	card_set = "IH";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 2;
	honor = 1;
	

   effects = {
		{ "BanishFromHandOrSource", 1, condition={"IfCurrentEventIsNotVoid",0} },
		{ "GainSoulGem", 1, condition={"IfYouDo",0} },
      { "BanishFromHandOrDiscardOrSource", 1, condition={"IfCurrentEventIsVoid",0} },
		{ "GainSoulGem", 1, condition={"IfYouDo",2} },
	};

   
	effect_text = "You may banish this or another card in your hand. \n" ..
                  "If you do, gain a Soul Gem. If the current event is Void, " ..
                  "you may banish a card in your discard pile to gain a Soul Gem instead.";

   image_large = { "VH_Soulshaper", {0, 0, 364/512, 1} };
   image_medium = { "VH_Soulshaper", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_Soulshaper", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_Soulshaper", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_active_effects["defeat trophy monster costs 1 less"] = {
	type = "continuous";
	effectfunc = { "ReduceDefeatTrophyMonsterCost", 1 };
}


g_ascension_cards["Trophy Hunter"] = { 
	card_name = "Trophy Hunter";
	card_set = "IH";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 3;
	honor = 1;
   
   effects = { 
		{ "GainPower", 2 },
		{ "NextTrophyMonsterYouDefeatCostsLess", 1 },
	};
   
	effect_text = "Gain 2P.  You pay 1P less the next time you defeat a Trophy Monster this turn.";

   ai = {
      gain_power = 2;
   },

   image_large = { "VH_TrophyHunter", {0, 0, 364/512, 1} };
   image_medium = { "VH_TrophyHunter", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_TrophyHunter", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_TrophyHunter", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_active_effects["monster defeated gains soul gem"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouDefeatMonsterFromCenterRow", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerEffectPlayerGainsSoulGems", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}


g_ascension_cards["Void Avenger"] = { 
	card_name = "Void Avenger";
	card_set = "IH";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 5;
	honor = 3;
   
	effects = {
		{ "GainPower", 3 },
		{ "NextMonsterYouDefeatFromCenterRowGainsSoulGem", 1 },
	};
	effect_text = "Gain 3P. The next time you defeat a Monster in the center row, gain a Soul Gem.";

   ai = {
      gain_power = 3;
   },

   image_large = { "VH_VoidAvenger", {0, 0, 364/512, 1} };
   image_medium = { "VH_VoidAvenger", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_VoidAvenger", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_VoidAvenger", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Orb of Nyx"] = { 
	card_name = "Orb of Nyx";
	card_set = "IH";
	card_type = "Construct";
	faction = "Void";
	rune_cost = 8;
	honor = 5;
   construct_ability = {
		description = "Gain 3P";
		{ "GainPower", 3 },
      
      ai = {
         trivial = true,
      },
	};
   triggered_effects = {
		{
			conditions = {
				{"WhenConstructOwnerDefeatsMonster", 0 },
			};
			triggereffect = {
				{"TriggerConstructOwnerGainSoulGem", 1},
			};
		},
	};
	effect_text = "Once per turn, gain 3P.\nWhen you defeat a Monster in the center row, gain a Soul Gem.";

   ai = {
      gain_power = 3;
   },

   image_large = { "VC_OrbNyx", {0, 0, 364/512, 1} };
   image_medium = { "VC_OrbNyx", {392/512, 0, 512/512, 168/512} };
   image_small = { "VC_OrbNyx", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VC_OrbNyx", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}












g_ascension_cards["Souls Unbound"] = { 
	card_name = "Souls Unbound";
	card_set = "IH";
	card_type = "Event";
	--faction = "Monster";
   
   continuous_effects = {
      {
         priority = -10;
         effect = { "MonstersCannotBeBanishedUnlessDefeated", 0 };
      },
   };
   
	trophy_effects = {
      usageconditions = {
         { "IfPlayerHasCardInHand", 0 },
      },
		{ "DiscardFromHand", 0 },
		{ "GainSoulGem", 1, condition={"IfYouDo",0} },
	};
   
   effect_text = "Monsters in the center row are Unbanishable.\n" ..
                  "  EVENT TROPHY: Discard a card. If you do, gain a Soul Gem.";

   image_large = { "E_SoulsUnbound", {0, 0, 364/512, 1} };
   image_medium = { "E_SoulsUnbound", {392/512, 0, 512/512, 168/512} };
   image_small = { "E_SoulsUnbound", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "E_SoulsUnbound", {384/512, 395/512, 512/512, 512/512} };
}


g_ascension_cards["Acidic Crawler"] = { 
	card_name = "Acidic Crawler";
	card_set = "IH";
	card_type = "Monster";
	power_cost = 6;
	rewards = {
		{ "GainHonor", 5 },
      { "IfOppControlsMostConstructsDestroyAllTheyControl", 0 },
	};
	effect_text = "Reward: 5H.  If an opponent controls the most Constructs, destroy all Constructs that player controls.";

   image_large = { "M_AcidicCrawler", {0, 0, 364/512, 1} };
   image_medium = { "M_AcidicCrawler", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_AcidicCrawler", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_AcidicCrawler", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Acidic_Crawler" };

   rarity_count = 3
}



g_ascension_cards["Akam, the Genie"] = { 
	card_name = "Akam, the Genie";
	card_set = "IH";
	card_type = "Monster";
	power_cost = 7;
   trophy_monster = true;
	rewards = {
		{ "GainHonor", 3 },
	};
   

	trophy_effects = {
      usageconditions = {
         { "IfTrophyEffectDataEquals0", 1 },
      },
		{ "PushResolvingTrophy", 0 },
 		{ "ChooseFromEffectList",
			{
            prompt = "Choose Rune or Power",
				{
					{ "GainRunes", 2 },
					description = "Gain 2 Runes",
				},
				{
					{ "GainPower", 2 },
					description = "Gain 2 Power",
				},
			}
		},
		{ "PopResolvingTrophy", 0 },
      { "IncrementTrophyEffectData", 0 },
      { "IncrementTrophyEffectData", 1 },
      { "BanishThisTrophy", 0, condition={"IfTrophyEffectDataIsGreaterThan2",0}  },
	};

   triggered_effects = {
		{
			conditions = {
				{"AtStartOfTrophyOwnerTurn", 0 },
			};
			triggereffect = {
				{"TriggerResetTrophyEffectData", 1},
			};
		},
	};
	
	--effect_text = "Reward: 3H.  ONGOING TROPHY: Put three Wish counters on Akam. \n" ..
    --              "Once per turn, you may remove a Wish counter to gain 2R or 2P. \n" ..
    --              "When Akam has no Wish counters, banish it.";
	effect_text = "Reward: 3H.";
	trophy_text = "<color=#951719FF><B>Ongoing Trophy:</B></color> Put three Wish counters on Akam. \n" ..
                  "Once per turn, you may remove a Wish counter to gain 2R or 2P. \n" ..
                  "When Akam has no Wish counters, banish it.";

   image_large = { "M_AkamGenie", {0, 0, 364/512, 1} };
   image_medium = { "M_AkamGenie", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_AkamGenie", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_AkamGenie", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Akam_the_Genie" };

   rarity_count = 1
}


g_ascension_cards["Cackling Jackal"] = { 
	card_name = "Cackling Jackal";
	card_set = "IH";
	card_type = "Monster";
	power_cost = 3;
   trophy_monster = true;
	rewards = {
		{ "GainHonor", 2 },
	};
	trophy_effects = {
		{ "GainRunes", 1 },
      { "BanishThisTrophy", 0 },
	};
	
	--effect_text = "Reward: 2H.  TROPHY: Banish this to gain 1R.";
	effect_text = "Reward: 2H.";
	trophy_text = "<color=#951719FF><B>Trophy:</B></color> Banish this to gain 1R.";

   image_large = { "M_CacklingJackal", {0, 0, 364/512, 1} };
   image_medium = { "M_CacklingJackal", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_CacklingJackal", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_CacklingJackal", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Cackling_Jackal" };

   rarity_count = 3
}



g_ascension_cards["Growmites"] = { 
	card_name = "Growmites";
	card_set = "IH";
	card_type = "Monster";
	power_cost = 3;
   trophy_monster = true;
	rewards = {
		{ "GainHonor", 2 },
	};
   
   triggered_effects = {
		{
			conditions = {
				{"WhenTrophyOwnerDefeatsGrowmites", 0 },
			};
			triggereffect = {
				{"TriggerTrophyOwnerGainHonor", 2},
			};
		},
	};

	--effect_text = "Reward: Gain 2H.  ONGOING TROPHY: When you defeat another Growmites, gain 2H.";
	effect_text = "Reward: Gain 2H.";
	trophy_text = "<color=#951719FF><B>Ongoing Trophy:</B></color> When you defeat another Growmites, gain 2H.";

   image_large = { "M_Growmites", {0, 0, 364/512, 1} };
   image_medium = { "M_Growmites", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_Growmites", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_Growmites", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Growmites" };

   rarity_count = 5
}



g_ascension_cards["Nothing Man"] = { 
	card_name = "Nothing Man";
	card_set = "IH";
	card_type = "Monster";
	power_cost = 4;
   trophy_monster = true;
	rewards = {
		{ "GainHonor", 3 },
	};
	trophy_effects = {
		{ "GainSoulGem", 1 },
      { "BanishThisTrophy", 0 },
	};
	
	--effect_text = "Reward: 3H.  TROPHY: Banish this to gain a Soul Gem.";
	effect_text = "Reward: 3H.";
	trophy_text = "<color=#951719FF><B>Trophy:</B></color> Banish this to gain a Soul Gem.";

   image_large = { "M_NothingMan", {0, 0, 364/512, 1} };
   image_medium = { "M_NothingMan", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_NothingMan", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_NothingMan", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Nothing_Man" };

   rarity_count = 3
}



g_ascension_cards["Kythis, Rebel Godling"] = { 
	card_name = "Kythis, Rebel Godling";
	card_set = "IH";
	card_type = "Monster";
	power_cost = 8;
   trophy_monster = true;
	rewards = {
		{ "GainHonor", 8 },
      { "GainSoulGem", 1 },
	};
   
   triggered_effects = {
		{
			conditions = {
				{"AtStartOfTrophyOwnerTurn", 0 },
			};
			triggereffect = {
				{"TriggerTrophyOwnerGainSoulGem", 1},
			};
		},
	};
   
   --effect_text = "Reward: 8H.  ONGOING TROPHY: Once per turn, gain a Soul Gem.";
   effect_text = "Reward: 8H.";
   trophy_text = "<color=#951719FF><B>Ongoing Trophy:</B></color> Once per turn, gain a Soul Gem.";

   image_large = { "M_KythisRebelGodling", {0, 0, 364/512, 1} };
   image_medium = { "M_KythisRebelGodling", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_KythisRebelGodling", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_KythisRebelGodling", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Kythis_Rebel_Godling" };

   rarity_count = 1
}

g_ascension_cards["Kythis, Rebel Godling v2"] = { 
	card_name = "Kythis, Rebel Godling v2";
	card_set = "IH";
	card_type = "Monster";
	power_cost = 8;
   trophy_monster = true;
	rewards = {
		{ "GainHonor", 8 },
	};   
   
	trophy_effects = {
      usageconditions = {
         { "IfTrophyEffectDataEquals0", 0 },
      },
      { "IncrementTrophyEffectData", 0 },
      { "GainSoulGem", 1 },
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
   
   --effect_text = "Reward: 8H.  ONGOING TROPHY: Once per turn, gain a Soul Gem.";
   effect_text = "Reward: 8H.";
   trophy_text = "<color=#951719FF><B>Ongoing Trophy:</B></color> Once per turn, gain a Soul Gem.";

   ai = {
      trivial = true,
   },

   image_large = { "M_KythisRebelGodling", {0, 0, 364/512, 1} };
   image_medium = { "M_KythisRebelGodling", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_KythisRebelGodling", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_KythisRebelGodling", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Kythis_Rebel_Godling" };

   rarity_count = 1
}
