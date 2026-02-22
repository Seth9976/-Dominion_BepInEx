


g_ascension_cards["Temple of Life"] = {
   card_name = "Temple of Life";
   card_set = "VotA";
   card_type = "Temple";

   life_cost = 1;
   honor = 5;
   
   cardinplay_abilities = {
      {
         description = "Use Temple";
         condition = { "IfCanPayLife", 1 },
         { "PushResolvingCardInPlay", 0 },
	 { "PayLife", 1 },
		 { "UseTempleEffect", 0 },
         { "GainTempleOfImmortality", 0 },
         { "GainRunes", 2 },
         { "PopResolvingCardInPlay", 0 },

         ai = {
            trivial = true,
         },
      },
   };

   effect_text = "1L: Gain control of the Temple of Immortality. Gain 2R.";

   ai = {
   },

   image_large = { "TMP_TempleLife", {0, 0, 364/512, 1} };
   image_medium = { "TMP_TempleLife", {392/512, 0, 512/512, 168/512} };
   image_small = { "TMP_TempleLife", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "TMP_TempleLife", {384/512, 395/512, 512/512, 512/512} };
}


g_ascension_cards["Temple of Death"] = {
   card_name = "Temple of Death";
   card_set = "VotA";
   card_type = "Temple";

   death_cost = 1;
   honor = 5;
   
   cardinplay_abilities = {
      {
         description = "Use Temple";
         condition = { "IfCanPayDeath", 1 },
         { "PushResolvingCardInPlay", 0 },
	 { "PayDeath", 1 },
		 { "UseTempleEffect", 0 },
         { "GainTempleOfImmortality", 0 },
         { "BanishFromHandOrDiscard", 1 },
         { "PopResolvingCardInPlay", 0 },
      },
   };

   effect_text = "1D: Gain control of the Temple of Immortality. " ..
					"You may banish a card in your hand or discard pile.";

   ai = {
   },

   image_large = { "TMP_TempleDeath", {0, 0, 364/512, 1} };
   image_medium = { "TMP_TempleDeath", {392/512, 0, 512/512, 168/512} };
   image_small = { "TMP_TempleDeath", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "TMP_TempleDeath", {384/512, 395/512, 512/512, 512/512} };
}


g_ascension_cards["Temple of Immortality"] = {
   card_name = "Temple of Immortality";
   card_set = "VotA";
   card_type = "Temple";

   honor = 10;
   
	triggered_effects = {
      {
         conditions = {
            { "AtStartOfCardInPlayOwnerTurn", 0 },
         };
         triggereffect = {
            { "TriggerConstructSetEffectDataToZero", 0 },
         };
      },
      {
         conditions = {
            { "AtEndOfCardInPlayOwnerTurn", 0 },
         };
         triggereffect = {
            { "TriggerConstructSetEffectDataToZero", 0 },
         };
      },
      {
         trigger_type = 1,
         conditions = {
            { "WhenOwnerAcquiresEffectDataMatchedCardFromCenterRow", 0 },
         };
         triggereffect = {
            { "TriggerMarkAcquireEventForRallyEffectData", 0 },
         };
      },
   };
   cardinplay_abilities = {
      {
         description = "Use Temple";
         condition = { "IfCardInPlayEffectDataEquals0", 0 },
         { "PushResolvingCardInPlay", 0 },
		 { "UseTempleEffect", 0 },
         { "ChooseFactionForCardInPlayEffectData", 0 },
         { "PopResolvingCardInPlay", 0 },
      },
   };

   effect_text = "Once per turn, choose a faction. " ..
					"When you acquire a card of that faction, " ..
					"if the next card to enter the center row is also that faction, " ..
					"acquire it without paying its cost.";

   ai = {
   },

   image_large = { "TMP_TempleImmortality", {0, 0, 364/512, 1} };
   image_medium = { "TMP_TempleImmortality", {392/512, 0, 512/512, 168/512} };
   image_small = { "TMP_TempleImmortality", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "TMP_TempleImmortality", {384/512, 395/512, 512/512, 512/512} };
}












g_ascension_cards["Blind Seer"] = {
   card_name = "Blind Seer";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Enlightened";

   rune_cost = 2;
   honor = 1;
   
   effects = {
      { "DrawCards", 1 },
	  { "GainLife", 1, condition={"IfHasZeroCardsInDiscard",0} },
	  { "SerenityEffect", 0, condition={"IfHasZeroCardsInDiscard",0} },
   };

   effect_text = "Draw a card.\n" ..
					"Serenity: Gain 1L. (Gain this effect if there are no cards in your discard pile.)";

   ai = {
   },

   image_large = { "EH_BlindSeer", {0, 0, 364/512, 1} };
   image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Ominous Augur"] = {
   card_name = "Ominous Augur";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Enlightened";

   rune_cost = 3;
   honor = 1;
   
	effects = {
		{ "CheckForSerenity", 0 },
		{ "AcquireHeroOrConstructWithCostLessThan", 5, condition={"IfYouDoNot",0} },
		{ "AcquireHeroOrConstructToHandWithCostLessThan", 5, condition={"IfYouDo",0} },	
		{ "SerenityEffect", 0, condition={"IfYouDo",0} },		
	};

   effect_text = "Acquire a Hero or Construct with cost 5R or less without paying its cost.\n" ..
					"Serenity: Put the acquired card in your hand. (Gain this effect if there are no cards in your discard pile.)";

   ai = {
   },

   image_large = { "EH_OminousAugur", {0, 0, 364/512, 1} };
   image_medium = { "EH_OminousAugur", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_OminousAugur", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_OminousAugur", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Jubilant Monk"] = {
   card_name = "Jubilant Monk";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Enlightened";

   rune_cost = 3;
   honor = 1;

   effects = {
	  { "RevealAndDrawFromDeckUntilHeavyMysticOrEnlightened", 0 },
   };
   
   effect_text = "Reveal the top card of your deck and put it into your hand. " ..
					"Repeat this effect until you reveal a card other than a " ..
					"Mystic, Heavy Infantry, or Enlightened card.";

   ai = {
   },

   image_large = { "EH_JubilantMonk", {0, 0, 364/512, 1} };
   image_medium = { "EH_JubilantMonk", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_JubilantMonk", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_JubilantMonk", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_active_effects["mystic and heavy gain 1D"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayMysticAndHeavyInfantry", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerGainDeath", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}


g_ascension_cards["Keeper of Secrets"] = {
   card_name = "Keeper of Secrets";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Enlightened";

   rune_cost = 4;
   honor = 2;
   
	effects = {
		{ "BanishFromHand", 0 },
		{ "AcquireMysticOrHeavyInfantryToHand", 0, condition={"IfYouDo",0} },
		{ "GainDeath", 1, condition={"IfPlayedMysticAndHeavyInfantry",1} },
		{ "NextHeavyAndMystic1Death", 0, condition={"IfHasNotPlayedMysticAndHeavyInfantry",1} },
		
	};

   effect_text = "Banish a card in your hand and replace it with a Mystic or Heavy Infantry.\n" ..
				"If you play or have played a Mystic and a Heavy Infantry this turn, gain 1D.";

   ai = {
   },

   image_large = { "EH_KeeperSecrets", {0, 0, 364/512, 1} };
   image_medium = { "EH_KeeperSecrets", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_KeeperSecrets", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_KeeperSecrets", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Fist of the Dragon"] = {
   card_name = "Fist of the Dragon";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Enlightened";

   rune_cost = 4;
   honor = 3;
   
   effects = {
      { "DrawCards", 1 },
      { "BanishFromCenterRowAndDefeatReplacementMonster", 1 },
   };

   effect_text = "Draw a card. Banish a card in the center row. " ..
					"If the next card to enter the center row is a Monster, " ..
					"defeat it without paying its cost.";

   ai = {
   },

   image_large = { "EH_FistDragon", {0, 0, 364/512, 1} };
   image_medium = { "EH_FistDragon", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_FistDragon", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_FistDragon", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_active_effects["copy next played hero with cost less than 3R"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayHeroWithCostLessThan", 3 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerCopyEventPlayHero", 0 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

g_ascension_cards["Flanking Askara"] = {
   card_name = "Flanking Askara";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Enlightened";

   rune_cost = 5;
   honor = 3;
   
   effects = {
      { "DrawCards", 1 },
	  { "CopyNextPlayedHeroWithCostLessThan3R", 0 },
   };
   
   effect_text = "Draw a card.\n" ..
					"Copy the effect of the next Hero you play this turn with cost 3R or less.";

   ai = {
   },

   image_large = { "EH_FlankingAskara", {0, 0, 364/512, 1} };
   image_medium = { "EH_FlankingAskara", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_FlankingAskara", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_FlankingAskara", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Isla, Serene Prodigy"] = {
   card_name = "Isla, Serene Prodigy";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Enlightened";

   rune_cost = 8;
   honor = 6;
   
	effects = {
		{ "AcquireHeroOrConstructInCenterRowAtNoCost", 0 },
		{ "PutThisCardOnTopOfDeck", 0 },
		{ "ShuffleDiscardPileIntoDeck", 0 },
		{ "PlayUniqueHeroSound", 0 },
	};
   effect_text = "Acquire a Hero or Construct in the center row without paying its cost.\n" ..
					"Shuffle Isla, Serene Prodigy and your discard pile into your deck.";

   ai = {
   },

   image_large = { "EH_IslaSereneProdigy", {0, 0, 364/512, 1} };
   image_medium = { "EH_IslaSereneProdigy", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_IslaSereneProdigy", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_IslaSereneProdigy", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Sacred Pot"] = {
   card_name = "Sacred Pot";
   card_set = "VotA";
   card_type = "Construct";
   faction = "Enlightened";

   rune_cost = 1;
   honor = 1;
   
   construct_abilities = {
      {
         description = "Draw Card";
         condition = { "IfHasZeroCardsInDiscard", 0 },
         { "DrawCards", 1 },
		 { "SerenityEffect", 0 },

      },
   };
   effect_text = "Serenity: Once per turn, draw a card. " ..
					"(Gain this effect if there are no cards in your discard pile.)";

   ai = {
   },

   image_large = { "EC_SacredPot", {0, 0, 364/512, 1} };
   image_medium = { "EC_SacredPot", {392/512, 0, 512/512, 168/512} };
   image_small = { "EC_SacredPot", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EC_SacredPot", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Templar Outpost"] = {
   card_name = "Templar Outpost";
   card_set = "VotA";
   card_type = "Construct";
   faction = "Enlightened";

   rune_cost = 6;
   honor = 4;

   
      construct_abilities = {
      {
         description = "Defeat Monster";
         condition = { "IfCanDefeatMonsterWithLessPowerFromCenterRow", 4 },
         { "DefeatMonsterFromCenterRowWithLessPower", 4 },

      },
   };
   effect_text = "Once per turn, defeat a Monster in the center row with cost 4P or less without paying its cost.";

   ai = {
   },

   image_large = { "EC_TemplarOutpost", {0, 0, 364/512, 1} };
   image_medium = { "EC_TemplarOutpost", {392/512, 0, 512/512, 168/512} };
   image_small = { "EC_TemplarOutpost", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EC_TemplarOutpost", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}









g_ascension_active_effects["unite 1L"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayLifeboundHero", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerGainLife", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}


g_ascension_cards["Ancient Stag"] = {
   card_name = "Ancient Stag";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 2;
   honor = 1;
   
   effects = {
      { "GainHonor", 3 },
	  { "GainLife", 1, condition={"IfPlayedLifeboundHero",1} },
	  { "Unite1Life", 0, condition={"IfHaventPlayedLifeboundHero",1} },
   };

   effect_text = "Gain 3H.\n" ..
					"Unite: Gain 1L.";

   ai = {
   },

   image_large = { "LH_AncientStag", {0, 0, 364/512, 1} };
   image_medium = { "LH_AncientStag", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_AncientStag", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_AncientStag", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Cheerful Consort"] = {
   card_name = "Cheerful Consort";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 2;
   honor = 1;
   
   effects = {
      { "GainHonor", 1 },
      { "DrawCards", 1 },
   };

   effect_text = "Gain 1H.\n" ..
					"Draw a card.";

   ai = {
   },

   image_large = { "LH_CheerfulConsort", {0, 0, 364/512, 1} };
   image_medium = { "LH_CheerfulConsort", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_CheerfulConsort", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_CheerfulConsort", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Alosyan Guide"] = {
   card_name = "Alosyan Guide";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 3;
   honor = 1;
   

   global_continuous_effects = {
      {
         priority = -5;
         conditions = {
			{ "TriggerIfQueryCardAcquireIsThisCard", 0 },
            { "TriggerIfTurnPlayerHasPlayedLifeboundHero", 0 },
         };
         effect = { "AcquireThisCardToHand", 0 };
      },
   };
   effects = {
      { "GainHonor", 3 },
   };

   effect_text = "When you acquire this, if you have played a Lifebound Hero this turn, " ..
					"put this directly into your hand.\n" ..
					"Gain 3H.";

   ai = {
   },

   image_large = { "LH_AlosyanGuide", {0, 0, 364/512, 1} };
   image_medium = { "LH_AlosyanGuide", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_AlosyanGuide", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_AlosyanGuide", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}



g_ascension_cards["Sirewood Elder"] = {
   card_name = "Sirewood Elder";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 3;
   honor = 2;
   
   effects = {
      { "GainRunes", 2 },
      { "DrawCards", 1, condition={"IfPlayedLifeboundHero",1} },
      { "UniteDraw1Card", 0, condition={"IfHaventPlayedLifeboundHero",1} },
   };

   effect_text = "Gain 2R.\n" ..
					"Unite: Draw a card.";

   ai = {
   },

   image_large = { "LH_SirewoodElder", {0, 0, 364/512, 1} };
   image_medium = { "LH_SirewoodElder", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_SirewoodElder", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_SirewoodElder", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_active_effects["gain 1D on Lifebound acquire"] = {
   type = "triggered";
   conditions = {
      { "WhenYouAcquireLifeboundCard", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerGainDeath", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}

g_ascension_cards["Burial Guardian"] = {
   card_name = "Burial Guardian";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 4;
   honor = 2;
   
   effects = {
      { "GainRunes", 2 },
	  { "NextLifeboundYouAcquireGain1D", 0 },
   };

   effect_text = "Gain 2R.\n" ..
					"The next time you acquire a Lifebound card this turn, gain 1D.";

   ai = {
   },

   image_large = { "LH_BurialGuardian", {0, 0, 364/512, 1} };
   image_medium = { "LH_BurialGuardian", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_BurialGuardian", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_BurialGuardian", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_active_effects["unite 2H"] = {
   type = "triggered";
   conditions = {
      { "WhenYouPlayLifeboundHero", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerGainHonor", 2 },
      { "TriggerRemovePlayedCardEffectActive", 0 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}


g_ascension_cards["Qadim Stalker"] = {
   card_name = "Qadim Stalker";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 5;
   honor = 3;
   
   effects = {
      { "GainRunes", 2 },
      { "GainPower", 2 },
      { "GainHonor", 2, condition={"IfPlayedLifeboundHero",1} },
      { "Unite2H", 0, condition={"IfHaventPlayedLifeboundHero",1} },
   };

   effect_text = "Gain 2R and 2P.\n" ..
					"Unite: Gain 2H.";

   ai = {
   },

   image_large = { "LH_QadimStalker", {0, 0, 364/512, 1} };
   image_medium = { "LH_QadimStalker", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_QadimStalker", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_QadimStalker", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}



g_ascension_cards["Caretaker Zahral"] = {
   card_name = "Caretaker Zahral";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 6;
   honor = 4;
   
   effects = {
      { "GainRunes", 3 },
      { "NextHeroYouAcquireMayGoOnTopOfDeck", 0 },
   };

   effect_text = "Gain 3R.\n" ..
					"The next time you acquire a Hero this turn, you may put it on top of your deck.";

   ai = {
   },

   image_large = { "LH_CaretakerZahral", {0, 0, 364/512, 1} };
   image_medium = { "LH_CaretakerZahral", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_CaretakerZahral", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_CaretakerZahral", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_active_effects["gain power for acquired hero rune cost"] = {
   type = "triggered";
   conditions = {
      { "WhenYouAcquireHero", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerGainPowerForAcquiredCardRuneCost", 0 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}

g_ascension_cards["Asalas, the Impaler"] = {
   card_name = "Asalas, the Impaler";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 7;
   honor = 5;
   
   effects = {
      { "GainRunes", 2 },
      { "GainPowerForNextAcquiredHeroRuneCostThisTurn", 0 },
   };
   
   effect_text = "Gain 2R.\n" ..
					"The next time you acquire a Hero this turn, gain P equal to the acquired Hero's R cost.";

   ai = {
   },

   image_large = { "LH_AsalasImpaler", {0, 0, 364/512, 1} };
   image_medium = { "LH_AsalasImpaler", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_AsalasImpaler", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_AsalasImpaler", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Pathfinder's Totem"] = {
   card_name = "Pathfinder's Totem";
   card_set = "VotA";
   card_type = "Construct";
   faction = "Lifebound";

   rune_cost = 1;
   honor = 1;
   
   construct_abilities = {
      {
         description = "Gain 1R";
         condition = { "IfPlayedLifeboundHero", 1 },
         { "GainRunes", 1 },

         ai = {
            trivial = true,
         },
      },
   };

   effect_text = "Unite: Once per turn, gain 1R. " ..
					"(Gain this effect if you have played a Lifebound Hero this turn.)";

   ai = {
   },

   image_large = { "LC_PathfindersTotem", {0, 0, 364/512, 1} };
   image_medium = { "LC_PathfindersTotem", {392/512, 0, 512/512, 168/512} };
   image_small = { "LC_PathfindersTotem", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LC_PathfindersTotem", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}








g_ascension_active_effects["gain 1D on construct acquire"] = {
   type = "triggered";
   conditions = {
      { "WhenYouAcquireConstruct", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerGainDeath", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}


g_ascension_cards["Resourceful Trader"] = {
   card_name = "Resourceful Trader";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Mechana";

   rune_cost = 2;
   honor = 1;
   
   effects = {
		{ "DrawCards", 1 },
		{ "NextConstructYouAcquireGain1D", 0 },
   };

   effect_text = "Draw a card.\n" ..
					"The next time you acquire a Construct this turn, gain 1D.";

   ai = {
   },

   image_large = { "MH_ResourcefulTrader", {0, 0, 364/512, 1} };
   image_medium = { "MH_ResourcefulTrader", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_ResourcefulTrader", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_ResourcefulTrader", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Brother Marius"] = {
   card_name = "Brother Marius";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Mechana";

   rune_cost = 3;
   honor = 2;
   
   effects = {
		{ "GainRunes", 1 },
		{ "GainRunesForEachTypeOfConstructInPlay", 1 },
   };

   effect_text = "Gain 1R.\n" ..
					"Gain an additional 1R for each faction among Constructs you control.";

   ai = {
   },

   image_large = { "MH_BrotherMarius", {0, 0, 364/512, 1} };
   image_medium = { "MH_BrotherMarius", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_BrotherMarius", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_BrotherMarius", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Excavator Pilot"] = {
   card_name = "Excavator Pilot";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Mechana";

   rune_cost = 4;
   honor = 2;
   
   effects = {
		{ "GainRunes", 2 },
		{ "GainLife", 1, condition={"IfYouControlConstructs",2} },
   };

   effect_text = "Gain 2R.\n" ..
					"If you control two or more Constructs, gain 1L.";

   ai = {
   },

   image_large = { "MH_ExcavatorPilot", {0, 0, 364/512, 1} };
   image_medium = { "MH_ExcavatorPilot", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_ExcavatorPilot", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_ExcavatorPilot", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Salvagemaster Mila"] = {
   card_name = "Salvagemaster Mila";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Mechana";

   rune_cost = 7;
   honor = 5;
   
   effects = {
		{ "GainRunes", 4 },
		{ "ContructsYouAcquireMayGoIntoPlayThisTurn", 0 },
   };

   effect_text = "Gain 4R.\n" ..
					"You may put any Constructs you acquire this turn directly into play.";

   ai = {
   },

   image_large = { "MH_SalvagemasterMila", {0, 0, 364/512, 1} };
   image_medium = { "MH_SalvagemasterMila", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_SalvagemasterMila", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_SalvagemasterMila", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Forgemaster's Suit"] = {
   card_name = "Forgemaster's Suit";
   card_set = "VotA";
   card_type = "Construct";
   faction = "Mechana";

   rune_cost = 1;
   honor = 1;
   
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
            { "TriggerConstructGainHonor", 1 },
            { "TriggerIncrementConstructEffectData", 0 },
         };
      },
   };
   construct_abilities = {
      {
         description = "Gain 1H";
         condition = { "IfConstructEffectDataEquals0AndControlTemple", 0 },
         { "GainHonor", 1 },
         { "IncrementConstructEffectData", 0 },

         ai = {
            trivial = true,
         },
      },
   };
   
   effect_text = "Once per turn, when you play a Mechana Construct (including this one) " ..
					"or if you control a Temple, gain 1H.";

   ai = {
   },

   image_large = { "MC_ForgemastersSuit", {0, 0, 364/512, 1} };
   image_medium = { "MC_ForgemastersSuit", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_ForgemastersSuit", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_ForgemastersSuit", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Stormsmith Anvil"] = {
   card_name = "Stormsmith Anvil";
   card_set = "VotA";
   card_type = "Construct";
   faction = "Mechana";

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
            { "TriggerConstructGainRunes", 1 },
            { "TriggerIncrementConstructEffectData", 0 },
         };
      },
   };
   construct_abilities = {
      {
         description = "Gain 1R";
         condition = { "IfConstructEffectDataEquals0AndControlTemple", 0 },
         { "GainRunes", 1 },
         { "IncrementConstructEffectData", 0 },

         ai = {
            trivial = true,
         },
      },
   };
   
   effect_text = "Once per turn, when you play a Mechana Construct (including this one) " ..
					"or if you control a Temple, gain 1R.";

   ai = {
   },

   image_large = { "MC_StormsmithAnvil", {0, 0, 364/512, 1} };
   image_medium = { "MC_StormsmithAnvil", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_StormsmithAnvil", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_StormsmithAnvil", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Siegemaster's Ram"] = {
   card_name = "Siegemaster's Ram";
   card_set = "VotA";
   card_type = "Construct";
   faction = "Mechana";

   rune_cost = 5;
   honor = 5;
   
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
         condition = { "IfConstructEffectDataEquals0AndControlTemple", 0 },
         { "GainPower", 2 },
         { "IncrementConstructEffectData", 0 },

         ai = {
            trivial = true,
         },
      },
   };

   effect_text = "Once per turn, when you play a Mechana Construct (including this one) " ..
					"or if you control a Temple, gain 2P.";

   ai = {
   },

   image_large = { "MC_SiegemastersRam", {0, 0, 364/512, 1} };
   image_medium = { "MC_SiegemastersRam", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_SiegemastersRam", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_SiegemastersRam", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["K-YL3 Repairbot"] = {
   card_name = "K-YL3 Repairbot";
   card_set = "VotA";
   card_type = "Construct";
   faction = "Mechana";

   rune_cost = 6;
   honor = 6;
   
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
            { "TriggerConstructOwnerDrawCards", 1 },
            { "TriggerIncrementConstructEffectData", 0 },
         };
      },
   };
   construct_abilities = {
      {
         description = "Draw Card";
         condition = { "IfConstructEffectDataEquals0AndControlTemple", 0 },
         { "DrawCards", 1 },
         { "IncrementConstructEffectData", 0 },
      },
   };
   
   effect_text = "Once per turn, when you play a Mechana Construct (including this one) " ..
					"or if you control a Temple, draw a card.";

   ai = {
   },

   image_large = { "MC_KYL3Repairbot", {0, 0, 364/512, 1} };
   image_medium = { "MC_KYL3Repairbot", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_KYL3Repairbot", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_KYL3Repairbot", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Tyranyx, the Pillager"] = {
   card_name = "Tyranyx, the Pillager";
   card_set = "VotA";
   card_type = "Construct";
   faction = "Mechana";

   rune_cost = 7;
   spend_power_to_acquire = true;
   honor = 7;
   
   continuous_effects = {
      {
         priority = 9;
         effect = { "MaySpendPowerToAcquireMechanaConstructs", 0 };
      },
   };
   effect_text = "You may spend P in addition to R to acquire this.\n" ..
					"You may spend P in addition to R to acquire Mechana Constructs.";

   ai = {
   },

   image_large = { "MC_TyranyxPillager", {0, 0, 364/512, 1} };
   image_medium = { "MC_TyranyxPillager", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_TyranyxPillager", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_TyranyxPillager", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Reckless Excavator"] = {
   card_name = "Reckless Excavator";
   card_set = "VotA";
   card_type = "Construct";
   faction = "Mechana";

   rune_cost = 8;
   honor = 8;

   effect_text = "Once per turn, when you play a Mechana Construct (including this one), gain 1L or 1D.";

   triggered_effects = {
		{
			conditions = {
				{"IfThisHasntBeenUsedThisTurn", 0 },
				{"WhenYouPutMechanaConstructIntoPlay", 0 },
			};
			triggereffect = {
				{ "TriggerPushResolveEffectFromCardsInPlay", 0 },
				{ "TriggerConstructChooseFromEffectList",
					{
						prompt = "Choose Life or Death",
						{
							{ "GainLife", 1 },
							description = "Gain Life",
						},
						{
							{ "GainDeath", 1 },
							description = "Gain Death",
						},
					}
				},
				{"TriggerSetThisHasBeenUsedThisTurn", 0},
				{ "TriggerPopResolveEffectFromCardsInPlay", 0 },
			};
		},
	};
	
   ai = {
   },

   image_large = { "MC_RecklessExcavator", {0, 0, 364/512, 1} };
   image_medium = { "MC_RecklessExcavator", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_RecklessExcavator", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_RecklessExcavator", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}










g_ascension_cards["Shadowridge Scout"] = {
   card_name = "Shadowridge Scout";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 2;
   honor = 1;
   
   effects = {
      { "GainPower", 2 },
      { "GainDeath", 1, condition={"IfHasVoidCardsInDiscardPile",1} },
	  { "EchoEffect", 0, condition={"IfHasVoidCardsInDiscardPile",1} },
   };

   effect_text = "Gain 2P.\n" ..
					"Echo: Gain 1D. (Gain this effect if there is a Void card in your discard pile.)";

   ai = {
   },

   image_large = { "VH_ShadowridgeScout", {0, 0, 364/512, 1} };
   image_medium = { "VH_ShadowridgeScout", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_ShadowridgeScout", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_ShadowridgeScout", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}



g_ascension_cards["Spiteful Gladiator"] = {
   card_name = "Spiteful Gladiator";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 3;
   honor = 2;
   
   effects = {
      { "GainPower", 2 },
      { "GainPower", 2, condition={"IfHasVoidCardsInDiscardPile",1} },
	  { "EchoEffect", 0, condition={"IfHasVoidCardsInDiscardPile",1} },
   };

   effect_text = "Gain 2P.\n" ..
					"Echo: Gain an additional 2P. (Gain this effect if there is a Void card in your discard pile.)";

   ai = {
   },

   image_large = { "VH_SpitefulGladiator", {0, 0, 364/512, 1} };
   image_medium = { "VH_SpitefulGladiator", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_SpitefulGladiator", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_SpitefulGladiator", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Excavation Sentry"] = {
   card_name = "Excavation Sentry";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 3;
   honor = 1;
   
   effects = {
      { "GainPower", 2 },
	  { "DiscardTopXCardsOfDeck", 1 },
      { "BanishFromHandOrDiscard", 1 },
   };

   effect_text = "Gain 2P.\n" ..
					"Put the top card of your deck into your discard pile, " ..
					"then you may banish a card in your hand or discard pile.";

   ai = {
   },

   image_large = { "VH_ExcavationSentry", {0, 0, 364/512, 1} };
   image_medium = { "VH_ExcavationSentry", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_ExcavationSentry", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_ExcavationSentry", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_active_effects["gain 1 life when you defeat a monster"] = {
   type = "triggered";
   conditions = {
      { "WhenYouDefeatMonsterFromCenterRow", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerGainLife", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}

g_ascension_cards["Soulsnare Hunter"] = {
   card_name = "Soulsnare Hunter";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 4;
   honor = 2;
   
   effects = {
      { "GainPower", 2 },
      { "NextMonsterYouDefeatFromCenterRowGain1Life", 0 },
   };

   effect_text = "Gain 2P.\n" ..
					"The next time you defeat a Monster in the center row this turn, gain 1L.";

   ai = {
   },

   image_large = { "VH_SoulsnareHunter", {0, 0, 364/512, 1} };
   image_medium = { "VH_SoulsnareHunter", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_SoulsnareHunter", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_SoulsnareHunter", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Silenced Prophet"] = {
   card_name = "Silenced Prophet";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 5;
   honor = 3;
   
   effects = {
      { "DrawCards", 1 },
	  { "DiscardTopXCardsOfDeck", 1 },
      { "BanishFromHandOrDiscard", 1 },
   };

   effect_text = "Draw a card.\n" ..
					"Put the top card of your deck into your discard pile, " ..
					"then you may banish a card in your hand or discard pile.";

   ai = {
   },

   image_large = { "VH_SilencedProphet", {0, 0, 364/512, 1} };
   image_medium = { "VH_SilencedProphet", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_SilencedProphet", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_SilencedProphet", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}



g_ascension_cards["Endbringer Jora"] = {
   card_name = "Endbringer Jora";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 6;
   honor = 4;
   
   effects = {
      { "GainPower", 3 },
	  { "Gain2RunesForEachMonsterDefeatedInCenterRowThisTurn", 0 },
   };
   
   effect_text = "Gain 3P.\n" ..
					"Whenever you defeat a Monster in the center row this turn, gain 2R.";

   ai = {
   },

   image_large = { "VH_EndbringerJora", {0, 0, 364/512, 1} };
   image_medium = { "VH_EndbringerJora", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_EndbringerJora", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_EndbringerJora", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Randall, Umbral Sage"] = {
   card_name = "Randall, Umbral Sage";
   card_set = "VotA";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 7;
   honor = 4;
   
   effects = {
      { "GainPower", 3 },
	  { "DiscardEntireDeck", 0 },
	  { "PlayUniqueHeroSound", 0 },
	  { "PutVoidCardFromDiscardIntoHand", 0 },
   };

   effect_text = "Gain 3P.\n" ..
					"Put all cards from your deck into your discard pile, " ..
					"then return a Void card in your discard pile to your hand.";

   ai = {
   },

   image_large = { "VH_RandallUmbralSage", {0, 0, 364/512, 1} };
   image_medium = { "VH_RandallUmbralSage", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_RandallUmbralSage", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_RandallUmbralSage", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}



g_ascension_cards["Beacon of the Lost"] = {
   card_name = "Beacon of the Lost";
   card_set = "VotA";
   card_type = "Construct";
   faction = "Void";

   rune_cost = 1;
   honor = 1;
   
   construct_abilities = {
      {
         description = "Gain 1P";
         condition = { "IfHasVoidCardsInDiscardPile", 1 },
         { "GainPower", 1 },
		 { "EchoEffect", 0 },

         ai = {
            trivial = true,
         },
      },
   };

   effect_text = "Echo: Once per turn, gain 1P. " ..
					"(Gain this effect if there is a Void card in your discard pile.)";

   ai = {
   },

   image_large = { "VC_BeaconLost", {0, 0, 364/512, 1} };
   image_medium = { "VC_BeaconLost", {392/512, 0, 512/512, 168/512} };
   image_small = { "VC_BeaconLost", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VC_BeaconLost", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Deranged Dirge"] = {
   card_name = "Deranged Dirge";
   card_set = "VotA";
   card_type = "Construct";
   faction = "Void";

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
         description = "Banish Card";
         condition = { "IfHasCardsInHandOrDiscard", 1 },
         { "PushResolvingConstruct", 0 },
         { "BanishFromHandOrDiscard", 0 },
         { "PopResolvingConstruct", 0 },
         { "DiscardThisConstruct", 1 },
      },
   };

   effect_text = "Once per turn, gain 1P.\n" ..
					"You may destroy this to banish a card in your hand or discard pile.";

   ai = {
   },

   image_large = { "VC_DerangedDirge", {0, 0, 364/512, 1} };
   image_medium = { "VC_DerangedDirge", {392/512, 0, 512/512, 168/512} };
   image_small = { "VC_DerangedDirge", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VC_DerangedDirge", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}















g_ascension_cards["Cavern Horror"] = {
   card_name = "Cavern Horror";
   card_set = "VotA";
   card_type = "Monster";

   power_cost = 2;
   
   rewards = {
      { "GainHonor", 1 },
	  { "ShuffleDiscardPileIntoDeck", 1 },
   }; 

   effect_text = "Reward: Gain 1H. You may shuffle your discard pile into your deck. " ..
					"(Cards played this turn do not go to your discard pile until the end of the turn.)";

   ai = {
   },

   image_large = { "M_CavernHorror", {0, 0, 364/512, 1} };
   image_medium = { "M_CavernHorror", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_CavernHorror", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_CavernHorror", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Cavern Horror" };

   rarity_count = 3
}


g_ascension_cards["Hellfrost Imps"] = {
   card_name = "Hellfrost Imps";
   card_set = "VotA";
   card_type = "Monster";

   power_cost = 3;
   
   rewards = {
      { "GainHonor", 2 },
      { "DefeatHellfrostImpsInCenterRow", 0 },
   }; 

   effect_text = "Reward: Gain 2H. You may defeat a Monster in the center row named Hellfrost Imps without paying its cost.";

   ai = {
   },

   image_large = { "M_HellfrostImps", {0, 0, 364/512, 1} };
   image_medium = { "M_HellfrostImps", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_HellfrostImps", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_HellfrostImps", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Hellfrost Imps" };

   rarity_count = 6
}


g_ascension_cards["Crypt Lurker"] = {
   card_name = "Crypt Lurker";
   card_set = "VotA";
   card_type = "Monster";

   power_cost = 4;
   
   rewards = {
      { "GainHonor", 3 },
      { "GainDeath", 1 },
   }; 

   effect_text = "Reward: Gain 3H. Gain 1D.";

   ai = {
   },

   image_large = { "M_CryptLurker", {0, 0, 364/512, 1} };
   image_medium = { "M_CryptLurker", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_CryptLurker", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_CryptLurker", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Crypt Lurker" };

   rarity_count = 3
}


g_ascension_cards["Starved Abomination"] = {
   card_name = "Starved Abomination";
   card_set = "VotA";
   card_type = "Monster";

   power_cost = 4;
   
   rewards = {
      { "GainHonor", 3 },
      { "GainLife", 1 },
   }; 

   effect_text = "Reward: Gain 3H. Gain 1L.";

   ai = {
   },

   image_large = { "M_StarvedAbomination", {0, 0, 364/512, 1} };
   image_medium = { "M_StarvedAbomination", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_StarvedAbomination", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_StarvedAbomination", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Starved Abomination" };

   rarity_count = 3
}


g_ascension_cards["Death's Widow"] = {
   card_name = "Death's Widow";
   card_set = "VotA";
   card_type = "Monster";

   power_cost = 4;
   
	rewards = {
		{ "GainHonor", 2 },
		{ "EachOpponentDiscardsConstructInPlay", 0 },
		{ "DrawCardsForEachOpponentNotInEffectInstanceData", 1 },
	}; 

   effect_text = "Reward: Gain 2H. Each opponent must destroy a Construct they control. " ..
					"Draw a card for each opponent that did not destroy a Construct this way.";

   ai = {
   },

   image_large = { "M_DeathsWidow", {0, 0, 364/512, 1} };
   image_medium = { "M_DeathsWidow", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_DeathsWidow", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_DeathsWidow", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Death's Widow" };

   rarity_count = 3
}


g_ascension_cards["Grave Golem"] = {
   card_name = "Grave Golem";
   card_set = "VotA";
   card_type = "Monster";

   power_cost = 5;
   
   rewards = {
      { "GainHonor", 4 },
	  { "CopyEffectFromTopOfOpponentDeck", 1 },
   }; 

   effect_text = "Reward: Gain 4H. Each opponent reveals the top card of their deck " ..
					"and puts it into their discard pile. " ..
					"Choose a Hero revealed this way and copy its effect.";

   ai = {
   },

   image_large = { "M_GraveGolem", {0, 0, 364/512, 1} };
   image_medium = { "M_GraveGolem", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_GraveGolem", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_GraveGolem", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Grave Golem" };

   rarity_count = 2
}



g_ascension_cards["Iku's Minions"] = {
   card_name = "Iku's Minions";
   card_set = "VotA";
   card_type = "Monster";

   power_cost = 5;
   
   global_continuous_effects = {
      {
			conditions = {
				{ "TriggerIfDefeatQueryPlayerControlsTemple", 1 },
			};
         effect = { "ReduceDefeatThisMonsterCost", 2 };
      },
	};
	
   rewards = {
      { "GainHonor", 4 },
	  { "BanishFromHandOrDiscard", 1 },
   }; 

   effect_text = "This costs 2 less to defeat if you control a Temple.\n" ..
					"Reward: Gain 4H. You may banish a card in your hand or discard pile.";

   ai = {
   },

   image_large = { "M_IkusMinions", {0, 0, 364/512, 1} };
   image_medium = { "M_IkusMinions", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_IkusMinions", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_IkusMinions", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Iku's Minions" };

   rarity_count = 2
}


g_ascension_cards["Mutated Scavenger"] = {
   card_name = "Mutated Scavenger";
   card_set = "VotA";
   card_type = "Monster";

   power_cost = 6;

   effect_text = "Reward: Gain 4H. Gain 5R.";
   
   rewards = {
      { "GainHonor", 4 },
	  { "GainRunes", 5 },
   }; 
   
   ai = {
   },

   image_large = { "M_MutatedScavenger", {0, 0, 364/512, 1} };
   image_medium = { "M_MutatedScavenger", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_MutatedScavenger", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_MutatedScavenger", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Mutated Scavenger" };

   rarity_count = 2
}


g_ascension_cards["Kan'zir, the Ravager"] = {
   card_name = "Kan'zir, the Ravager";
   card_set = "VotA";
   card_type = "Monster";

   power_cost = 6;
   
   rewards = {
      { "GainHonor", 5 },
      { "EachOpponentLosesControlOfAllTemples", 0 },
      { "EachOpponentDestroysAllConstructsInPlay", 0 },
   }; 

   effect_text = "Reward: Gain 5H. Each opponent loses control of all Temples and destroys all Constructs they control.";

   ai = {
   },

   image_large = { "M_KanzirRavager", {0, 0, 364/512, 1} };
   image_medium = { "M_KanzirRavager", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_KanzirRavager", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_KanzirRavager", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Kan'zir the Ravager" };

   rarity_count = 1
}


g_ascension_cards["Hurras, Sea's Fury"] = {
   card_name = "Hurras, Sea's Fury";
   card_set = "VotA";
   card_type = "Monster";

   power_cost = 7;
   
   rewards = {
      { "GainHonor", 4 },
      { "GainLife", 1 },
      { "GainDeath", 1 },
   }; 

   effect_text = "Reward: Gain 4H. Gain 1L and 1D.";

   ai = {
   },

   image_large = { "M_HurrasSeasFury", {0, 0, 364/512, 1} };
   image_medium = { "M_HurrasSeasFury", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_HurrasSeasFury", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_HurrasSeasFury", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Hurras Sea's Fury" };

   rarity_count = 1
}


g_ascension_cards["Iku, Valley Tyrant"] = {
   card_name = "Iku, Valley Tyrant";
   card_set = "VotA";
   card_type = "Monster";

   power_cost = 10;
   
   global_continuous_effects = {
      {
			conditions = {
				{ "TriggerIfDefeatQueryPlayerControlsTemple", 1 },
			};
         effect = { "ReduceDefeatThisMonsterCostForEachControlledTemple", 2 };
      },
	};

   rewards = {
      { "GainHonor", 8 },
   };
   
   effect_text = "This costs 2P less to defeat for each Temple you control.\n" ..
					"Reward: Gain 8H.";

   ai = {
   },

   image_large = { "M_IkuValleyTyrant", {0, 0, 364/512, 1} };
   image_medium = { "M_IkuValleyTyrant", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_IkuValleyTyrant", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_IkuValleyTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Iku Valley Tyrant" };

   rarity_count = 1
}














