






g_ascension_cards["Dreamscape Diviner"] = {
   card_name = "Dreamscape Diviner";
   card_set = "Del";
   card_type = "Hero";
   faction = "Enlightened";

   rune_cost = 1;
   honor = 1;

	effects = {
		{ "GainInsight", 2 },
	};

	effect_text = "Gain 2I.";
	
	flavor_text = "Are you sure you want to know?";

   ai = {
   },

   image_large = { "EH_DreamscapeDiviner", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Dimension Monk"] = {
   card_name = "Dimension Monk";
   card_set = "Del";
   card_type = "Hero";
   faction = "Enlightened";

   rune_cost = 2;
   honor = 1;

	effects = {
		{ "DrawCards", 1 },
		{ "MayRecurEffectForInsight", 1 },
		{ "DrawCards", 1, condition={"IfYouDo",1} },
	};

	effect_text = "Draw a card.\n" ..
					"You may pay 1I to Recur. " ..
						"(Gain the effect listed above an additional time. You may only Recur once.)";

   ai = {
   },

   image_large = { "EH_DimensionMonk", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}



g_ascension_cards["Aegis Knight"] = {
   card_name = "Aegis Knight";
   card_set = "Del";
   card_type = "Hero";
   faction = "Enlightened";

   rune_cost = 3;
   honor = 2;

   center_row = { "AuctionForInsight", 0 },

	effects = {
		{ "BanishFromHandOrDiscard", 0 },
		{ "AcquireMysticOrHeavyInfantryToHand", 0, condition={"IfEffectInstanceDataIsBanishFromHand",0} },
		{ "AcquireMysticOrHeavyInfantry", 0, condition={"IfEffectInstanceDataIsBanishFromDiscard",0} },
	};

	fate_text = "FATE: Auction I to gain the effect below.";
	effect_text = "Banish a card in your hand or discard pile. " ..
					"If you do, replace it with a Mystic or Heavy Infantry.";

   ai = {
   },

   image_large = { "EH_AegisKnight", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Dream Dealer"] = {
   card_name = "Dream Dealer";
   card_set = "Del";
   card_type = "Hero";
   faction = "Enlightened";

   rune_cost = 4;
   honor = 2;

	effects = {
		{ "DrawCards", 1 },
		{ "BanishFromCenterRow", 0 },
		{ "PauseForAnimation", 0, condition={"IfCenterRowHasCardFromEachFaction",0} },
		{ "RollDeliriumDie", 0, condition={"IfCenterRowHasCardFromEachFaction",0} },
		{ "DreamDealerEffect", 0, condition={"IfCenterRowHasCardFromEachFaction",0} },
	};

   effect_text = "Draw a card, then banish a card in the center row. " ..
					"Then, if there is an Enlightened, Lifebound, Mechana, AND Void card " ..
					"in the center row, roll the Delirium Die.";

   ai = {
   },

   image_large = { "EH_DreamDealer", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Templar General"] = {
   card_name = "Templar General";
   card_set = "Del";
   card_type = "Hero";
   faction = "Enlightened";
	dreamborn = true;
	
   rune_cost = 4;
   honor = 2;

   center_row = { "EachPlayerGainInsight", 1 },
   
   global_continuous_effects = {
      {
         priority = -5;
         conditions = {
			{ "TriggerIfAcquireQueryPlayerHasNoCardsInDiscardPile", 0 },
         };
         effect = { "AcquireThisCardToHand", 0 };
      },
   };
	effects = {
      { "DefeatMonsterWithLessPower", 4 },
	};

   effect_text = "Defeat a Monster with cost 4P or less without paying its cost.\n" ..
				"Serenity: When you acquire this, put it in your hand.";

   ai = {
   },

   image_large = { "EH_TemplarGeneral", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Divine Askara"] = {
   card_name = "Divine Askara";
   card_set = "Del";
   card_type = "Hero";
   faction = "Enlightened";

   rune_cost = 5;
   honor = 3;

   played_effect_cannot_be_copied = true;
   
	effects = {
		{ "CopyEffectOfAnyPlayedHero", 0 },
		{ "MayRecurEffectForInsight", 3 },
		{ "CopyEffectOfInstanceEffectDataCard", 0, condition={"IfYouDo",1} },
	};

   effect_text = "Copy the effect of a Hero played this turn.\n" ..
					"You may pay 3I to copy the chosen effect twice instead.\n" ..
					"This effect cannot be copied.";

   ai = {
   },

   image_large = { "EH_DivineAskara", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Loa, Dream Dragon"] = {
   card_name = "Loa, Dream Dragon";
   card_set = "Del";
   card_type = "Hero";
   faction = "Enlightened";

   rune_cost = 6;
   honor = 4;
   
	effects = {
		{ "PauseForAnimation", 0 },
		{ "RollDeliriumDie", 0 },
	};

   effect_text = "Roll the Delirium Die.";
	
	flavor_text = "His spirit, manifest through the Dreamscape.";

   ai = {
   },

   image_large = { "EH_LoaDreamDragon", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Emri, Lightbringer"] = {
   card_name = "Emri, Lightbringer";
   card_set = "Del";
   card_type = "Hero";
   faction = "Enlightened";
	dreamborn = true;

   rune_cost = 8;
   honor = 5;

   center_row = { "EachPlayerGainInsight", 1 },
   
	effects = {
         { "DefeatMonsterFromCenterRowOrVoidToBottomOfPortalDeck", 0 },
	};

   effect_text = "Defeat a Monster in the center row or the void without paying its cost. " ..
					"Put that Monster on the bottom of the center deck.";
	
	flavor_text = "";

   ai = {
   },

   image_large = { "EH_EmriLightbringer", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Dream Stone"] = {
   card_name = "Dream Stone";
   card_set = "Del";
   card_type = "Construct";
   faction = "Enlightened";

   rune_cost = 3;
   honor = 1;

	construct_ability = {
		description = "Roll Die";
        { "PushResolvingConstruct", 0 },
		{ "PauseForAnimation", 0 },
		{ "RollDeliriumDie", 0 },
        { "PopResolvingConstruct", 0 },
		{ "BanishThisConstruct", 0 },
	};
	
   effect_text = "You may banish this to roll the Delirium Die.";
   
	flavor_text = "Look upon what might have been and what may come to pass.";

   ai = {
   },

   image_large = { "EC_DreamStone", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["The Dragon's Eye"] = {
   card_name = "The Dragon's Eye";
   card_set = "Del";
   card_type = "Construct";
   faction = "Enlightened";

   rune_cost = 3;
   honor = 2;

	triggered_effects = {
		{
			conditions = {
				{ "IfThisHasntBeenUsedThisTurn", 0 },
				{ "WhenYouPutThisConstructIntoPlay", 0 },
			};
			triggereffect = {
				{ "TriggerConstructGainInsight", 1 },
				{ "TriggerSetThisHasBeenUsedThisTurn", 0 },
			};
		},
	};
	
	construct_abilities = {
      {
         description = "Gain Insight";
         condition = { "IfHasZeroCardsInDiscard", 0 },
         { "GainInsight", 1 },

		  ai = {
			 trivial = true,
		  },
      },
   };
   
   effect_text = "When you play this, gain 1I.\n" ..
				"Serenity: Once per turn, gain 1I. " ..
					"(Gain this effect if there are no cards in your discard pile.)";

   ai = {
   },

   image_large = { "EC_DragonsEye", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}






g_ascension_active_effects["unite draw 2 cards"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayLifeboundHero", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerEffectPlayerDrawCards", 2 },
      { "TriggerRemovePlayedCardEffectActive", 0 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

g_ascension_cards["Delirium Nymph"] = {
   card_name = "Delirium Nymph";
   card_set = "Del";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 1;
   honor = 1;

	effects = {
		{ "GainRunes", 1 },
		{ "DrawCards", 2, condition={"IfPlayedLifeboundHero",1} },
		{ "UniteDraw2Cards", 0, condition={"IfHaventPlayedLifeboundHero",1} },
	};
	
	effect_text = "Gain 1R.\n" ..
					"UNITE: Draw 2 cards. " ..
						"(Gain this effect once if you play or have played another Lifebound Hero this turn.)";
	
   ai = {
   },

   image_large = { "LH_DeliriumNymph", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Dreamscape Dryad"] = {
   card_name = "Dreamscape Dryad";
   card_set = "Del";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 2;
   honor = 1;

	effects = {
		{ "GainHonor", 3 },
		{ "MayRecurEffectForInsight", 3 },
		{ "GainHonor", 3, condition={"IfYouDo",1} },
	};
	
	effect_text = "Gain 3H.\n" ..
					"You may pay 3I to Recur. " ..
						"(Gain the effect listed above an additional time. You may only Recur once.)";
	
   ai = {
   },

   image_large = { "LH_DreamscapeDryad", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Pollen Pixie"] = {
   card_name = "Pollen Pixie";
   card_set = "Del";
   card_type = "Hero";
   faction = "Lifebound";
	dreamborn = true;
	
   rune_cost = 3;
   honor = 2;

   center_row = { "EachPlayerGainInsight", 1 },

	effects = {
		{ "GainRunes", 2 },
		{ "GainHonor", 1 },
	};
	
	effect_text = "Gain 2R and 1H.";
   
	flavor_text = "You're going to feel a little funny at first...";
	
   ai = {
   },

   image_large = { "LH_PollenPixie", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}



g_ascension_cards["Dream Guide"] = {
   card_name = "Dream Guide";
   card_set = "Del";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 4;
   honor = 2;

	effects = {
		{ "GainRunes", 2 },
		{ "GainInsight", 1 },
	};
	
	effect_text = "Gain 2R and 1I.";

	flavor_text = "At the edge of the world, she is a guide to everything beyond.";
	
   ai = {
   },

   image_large = { "LH_DreamGuide", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_active_effects["unite 4P"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayLifeboundHero", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerGainPower", 4 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

g_ascension_cards["Tuskrider"] = {
   card_name = "Tuskrider";
   card_set = "Del";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 4;
   honor = 3;

	effects = {
		{ "DrawCards", 1 },
		{ "GainPower", 4, condition={"IfPlayedLifeboundHero",1} },
		{ "Unite4P", 0, condition={"IfHaventPlayedLifeboundHero",1} },
	};
	
	effect_text = "Draw a card.\n" ..
					"UNITE: Gain 4P.";

	flavor_text = "Truffles and manflesh.";
	
   ai = {
   },

   image_large = { "LH_Tuskrider", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Vineweaver"] = {
   card_name = "Vineweaver";
   card_set = "Del";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 5;
   honor = 3;

   center_row = { "AuctionForInsight", 0 },

	effects = {
		{ "GainHonor", 4 },
	};
	
	fate_text = "FATE: Auction I to gain the effect below.";
	effect_text = "Gain 4H.";
	
   ai = {
   },

   image_large = { "LH_Vineweaver", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_active_effects["unite pair 6P"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlaySecondLifeboundHero", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerGainPower", 6 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

g_ascension_cards["Kor, Worldbreaker"] = {
   card_name = "Kor, Worldbreaker";
   card_set = "Del";
   card_type = "Hero";
   faction = "Lifebound";
	dreamborn = true;

   rune_cost = 6;
   honor = 3;

   center_row = { "EachPlayerGainInsight", 1 },

	effects = {
		{ "GainRunes", 2 },
		{ "DrawCards", 1 },
		{ "GainPower", 6, condition={"IfPlayedLifeboundHero",2} },
		{ "UnitePair6P", 0, condition={"IfHaventPlayedLifeboundHero",2} },
	};
	
	effect_text = "Gain 2R and draw a card.\n" ..
					"If you play or have played at least two other " ..
						"Lifebound Heroes this turn, gain 6P.";
	
   ai = {
   },

   image_large = { "LH_KorWorldbreaker", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Evvy, Ogo's Gift"] = {
   card_name = "Evvy, Ogo's Gift";
   card_set = "Del";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 7;
   honor = 4;

	effects = {
		{ "AcquireHeroToTopOfDeck", 0 },
		{ "MayRecurEffectForInsight", 3 },
		{ "AcquireHeroToTopOfDeck", 0, condition={"IfYouDo",1} },
	};
	
	effect_text = "Acquire a Hero without paying its cost and put it on top of your deck.\n" ..
					"You may 3I to Recur. " ..
						"(Gain the effect listed above an additional time. You may only Recur once.)";
	
   ai = {
   },

   image_large = { "LH_EvvyOgosGift", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Ogo War Tree"] = {
   card_name = "Ogo War Tree";
   card_set = "Del";
   card_type = "Construct";
   faction = "Lifebound";

   rune_cost = 3;
   honor = 2;

   continuous_effects = {
      {
         effect = {"MayPutAcquiredHeroFromCenterRowOnTopOfDeckOncePerTurn", 0 };
      },
   };

   effect_text = "Once per turn, when you acquire a Hero in the center row, " ..
					"you may put it on top of your deck.";
   
	flavor_text = "Safe travels!";

   ai = {
   },

   image_large = { "LC_OgoWarTree", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}






g_ascension_active_effects["acquire construct directly into play once per turn"] = {
   type = "continuous";
   effectfunc = { "PutAcquiredConstructIntoPlayOncePerTurn", 1 };
}

g_ascension_cards["Steelweaver"] = {
   card_name = "Steelweaver";
   card_set = "Del";
   card_type = "Hero";
   faction = "Mechana";

   rune_cost = 1;
   honor = 1;

	effects = {
		{ "GainRunes", 1 },
		{ "PutAcquiredConstructIntoPlayOnceThisTurn", 0 },
		{ "MayRecurEffectForInsight", 1 },
		{ "GainRunes", 1, condition={"IfYouDo",2} },
		{ "PutAcquiredConstructIntoPlayOnceThisTurn", 0, condition={"IfYouDo",2} },
	};
	
	effect_text = "Gain 1R. " ..
					"Once this turn, when you acquire a Construct, put it directly into play.\n" ..
					"You may pay 1I to Recur. " ..
						"(Gain the effect listed above an additional time. You may only Recur once.)";


   ai = {
   },

   image_large = { "MH_Steelweaver", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Scrapbot Scrapper"] = {
   card_name = "Scrapbot Scrapper";
   card_set = "Del";
   card_type = "Hero";
   faction = "Mechana";

   rune_cost = 3;
   honor = 2;

	effects = {
		{ "GainPower", 2 },
		{ "ReturnConstructToHand", 1 },
	};
	
	effect_text = "Gain 2P. " ..
					"You may return a Construct you control to your hand.";

	flavor_text = "One man's trash is another bot's weapon.";

   ai = {
   },

   image_large = { "MH_ScrapbotScrapper", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Inferna Templar"] = {
   card_name = "Inferna Templar";
   card_set = "Del";
   card_type = "Hero";
   faction = "Mechana";

   rune_cost = 4;
   honor = 3;

   center_row = { "AuctionForInsight", 0 },

	effects = {
		{ "DrawCards", 1 },
		{ "DrawCards", 1, condition={"IfYouControlConstructs",2} },
	};
	
	fate_text = "FATE: Auction I to gain the effect below.";
	effect_text = "Draw a card.\n" ..
					"If you control two or more Constructs, draw an additional card.";


   ai = {
   },

   image_large = { "MH_InfernaTemplar", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Emma Ironheart"] = {
   card_name = "Emma Ironheart";
   card_set = "Del";
   card_type = "Hero";
   faction = "Mechana";

   rune_cost = 6;
   honor = 3;

	effects = {
		{ "GainRunes", 3 },
		{ "GainPower", 3, condition={"IfYouControlConstructs",2} },
		{ "MayRecurEffectForInsight", 3 },
		{ "GainRunes", 3, condition={"IfYouDo",2} },
		{ "GainPower", 3, condition={"IfYouControl2ConstructsAndYouDo",2} },
	};
	
	effect_text = "Gain 3R. " ..
					"If you control two or more Constructs, gain 3P.\n" ..
					"You may pay 3I to Recur.";


   ai = {
   },

   image_large = { "MH_EmmaIronheart", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_cards["Clockwork Shield"] = {
	card_name = "Clockwork Shield";
    card_set = "Del";
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
            { "TriggerConstructGainHonorForEachMechanaConstructInPlay", 1 },
            { "TriggerSetThisHasBeenUsedThisTurn", 0 },
         };
      },
   };
	effect_text = "Once per turn, when you play a Mechana Construct (including this one), " ..
					"gain 1H for each Mechana Construct your control.";

   ai = {

   },
   
   image_large = { "MC_ClockworkShield", {0, 0, 364/512, 1} };
   --image_medium = { "MC_SynapseSpire", {392/512, 0, 512/512, 168/512} };
   --image_small = { "MC_SynapseSpire", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "MC_SynapseSpire", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}

g_ascension_cards["Clockwork Blade"] = {
	card_name = "Clockwork Blade";
    card_set = "Del";
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
            { "TriggerConstructGainPowerForEachMechanaConstructInPlay", 1 },
            { "TriggerSetThisHasBeenUsedThisTurn", 0 },
         };
      },
   };
	effect_text = "Once per turn, when you play a Mechana Construct (including this one), " ..
					"gain 1P for each Mechana Construct your control.";

   ai = {

   },
   
   image_large = { "MC_ClockworkBlade", {0, 0, 364/512, 1} };
   --image_medium = { "MC_SynapseSpire", {392/512, 0, 512/512, 168/512} };
   --image_small = { "MC_SynapseSpire", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "MC_SynapseSpire", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}


g_ascension_cards["Clockwork Helm"] = {
	card_name = "Clockwork Helm";
    card_set = "Del";
	card_type = "Construct";
	faction = "Mechana";
	
	rune_cost = 5;
	honor = 5;
	
   triggered_effects = {
      {
         conditions = {
            { "IfThisHasntBeenUsedThisTurn", 0 },
            { "WhenYouPutMechanaConstructIntoPlay", 0 },
         };
         triggereffect = {
            { "TriggerConstructGainInsightForEachMechanaConstructInPlay", 1 },
            { "TriggerSetThisHasBeenUsedThisTurn", 0 },
         };
      },
   };

   effect_text = "Once per turn, when you play a Mechana Construct (including this one), " ..
					"gain 1I for each Mechana Construct your control.";

   ai = {

   },
   
   image_large = { "MC_ClockworkHelm", {0, 0, 364/512, 1} };
   --image_medium = { "MC_SynapseSpire", {392/512, 0, 512/512, 168/512} };
   --image_small = { "MC_SynapseSpire", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "MC_SynapseSpire", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}


g_ascension_cards["Clockwork Familiar"] = {
	card_name = "Clockwork Familiar";
    card_set = "Del";
	card_type = "Construct";
	faction = "Mechana";
	
	rune_cost = 6;
	honor = 6;
	
   triggered_effects = {
      {
         conditions = {
            { "IfThisHasntBeenUsedThisTurn", 0 },
            { "WhenYouPutMechanaConstructIntoPlay", 0 },
         };
         triggereffect = {
            { "TriggerConstructGainRunesForEachMechanaConstructInPlay", 1 },
            { "TriggerSetThisHasBeenUsedThisTurn", 0 },
         };
      },
   };
   
   effect_text = "Once per turn, when you play a Mechana Construct (including this one), " ..
					"gain 1R for each Mechana Construct your control.";

   ai = {

   },
   
   image_large = { "MC_ClockworkFamiliar", {0, 0, 364/512, 1} };
   --image_medium = { "MC_SynapseSpire", {392/512, 0, 512/512, 168/512} };
   --image_small = { "MC_SynapseSpire", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "MC_SynapseSpire", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}


g_ascension_cards["Salvage Yard"] = {
	card_name = "Salvage Yard";
    card_set = "Del";
	card_type = "Construct";
	faction = "Mechana";
	dreamborn = true;
	
	rune_cost = 7;
	honor = 7;

   center_row = { "EachPlayerGainInsight", 1 },
   
   triggered_effects = {
      {
         conditions = {
            { "AtStartOfConstructOwnerTurn", 0 },
         };
         triggereffect = {
            { "TriggerReturnThisConstructToYourHand", 0 },
         };
      },
   };	
   
	effect_text = "At the start of your turn, return this to your hand.";

	flavor_text = "Recycle. Rebuild. Reuse.";

   ai = {

   },
   
   image_large = { "MC_SalvageYard", {0, 0, 364/512, 1} };
   --image_medium = { "MC_SynapseSpire", {392/512, 0, 512/512, 168/512} };
   --image_small = { "MC_SynapseSpire", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "MC_SynapseSpire", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1
}


g_ascension_cards["Dhartha, Mechamonk"] = {
	card_name = "Dhartha, Mechamonk";
    card_set = "Del";
	card_type = "Construct";
	faction = "Mechana";
	dreamborn = true;
	
	rune_cost = 9;
	honor = 9;

   center_row = { "EachPlayerGainInsight_v31", 1 },
	
   triggered_effects = {
      {
         conditions = {
            { "IfThisHasntBeenUsedThisTurn", 0 },
            { "WhenYouPutMechanaConstructIntoPlay", 0 },
         };
         triggereffect = {
            { "TriggerConstructOwnerDrawCardsForEachMechanaConstructInPlay", 1 },
            { "TriggerSetThisHasBeenUsedThisTurn", 0 },
         };
      },
   };
	effect_text = "Once per turn, when you play a Mechana Construct (including this one), " ..
					"draw a card for each Mechana Construct your control.";

   ai = {

   },
   
   image_large = { "MC_DharthaMechamonk", {0, 0, 364/512, 1} };
   --image_medium = { "MC_SynapseSpire", {392/512, 0, 512/512, 168/512} };
   --image_small = { "MC_SynapseSpire", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "MC_SynapseSpire", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1
}










g_ascension_cards["Nihil Chemist"] = {
   card_name = "Nihil Chemist";
   card_set = "Del";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 1;
   honor = 1;

	effects = {
		{ "GainPower", 1 },
		{ "BanishFromHandOrDiscard", 1 },
		{ "MayRecurEffectForInsight", 2 },
		{ "GainPower", 1, condition={"IfYouDo",2} },
		{ "BanishFromHandOrDiscard", 1, condition={"IfYouDo",2} },
	};
	
	effect_text = "Gain 1P. " ..
					"You may banish a card in your hand of discard pile.\n" ..
					"You may pay 2I to Recur. " ..
						"(Gain the effect listed an additional time. You may only Recur once.)";


   ai = {
   },

   image_large = { "VH_NihilChemist", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}



g_ascension_active_effects["monster defeated gains 1 insight"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouDefeatMonsterFromCenterRow", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerGainInsight", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

g_ascension_cards["Voidrager"] = {
   card_name = "Voidrager";
   card_set = "Del";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 2;
   honor = 1;

	effects = {
		{ "GainPower", 2 },
		{ "NextMonsterYouDefeatFromCenterRowGains1Insight", 0 },

	};
	
	effect_text = "Gain 2P. " ..
					"The next time you defeat a Monster in the center row this turn, gain 1I.";


   ai = {
   },

   image_large = { "VH_Voidrager", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Shield Bearer"] = {
   card_name = "Shield Bearer";
   card_set = "Del";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 4;
   honor = 2;

   center_row = { "AuctionForInsight", 0 },

	effects = {
		{ "DrawCards", 1 },
		{ "BanishFromHandOrDiscard", 1 },
	};
	
	fate_text = "FATE: Auction I to gain the effect below.";
	effect_text = "Draw a card.\n" ..
					"You may banish a card in your hand or discard pile.";


   ai = {
   },

   image_large = { "VH_ShieldBearer", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Voidspeaker"] = {
   card_name = "Voidspeaker";
   card_set = "Del";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 4;
   honor = 2;

	effects = {
		{ "GainPower", 2 },
		{ "GainRunes", 3, condition={"IfHasVoidCardsInDiscardPile",1} },
	};
	
	effect_text = "Gain 2P.\n" ..
					"Echo: Gain 3R. " ..
						"(Gain this effect if there is a Void card in your discard pile.)";


	flavor_text = "A ravenous appetite for human emotion.";

   ai = {
   },

   image_large = { "VH_Voidspeaker", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Darktome Librarian"] = {
   card_name = "Darktome Librarian";
   card_set = "Del";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 5;
   honor = 3;

	effects = {
		{ "GainInsight", 2 },
		{ "BanishFromHandOrDiscard", 1 },
	};
	
	effect_text = "Gain 2I.\n" ..
					"You may banish a card in your hand or discard pile.";

	flavor_text = "Be careful, page six bites.";

   ai = {
   },

   image_large = { "VH_DarktomeLibrarian", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}



g_ascension_cards["Naka, Shadeborn"] = {
   card_name = "Naka, Shadeborn";
   card_set = "Del";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 6;
   honor = 4;

	effects = {
		{ "GainPower", 3 },
		{ "PutVoidCardFromDiscardIntoHand", 0 },
		{ "MayRecurEffectForInsight", 3 },
		{ "GainPower", 3, condition={"IfYouDo",2} },
		{ "PutVoidCardFromDiscardIntoHand", 0, condition={"IfYouDo",2} },
	};
	
	effect_text = "Gain 3P.\n" ..
					"You may return a Void card in your discard pile to your hand.\n" ..
					"You may pay 3I to Recur.";

   ai = {
   },

   image_large = { "VH_NakaShadeborn", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_active_effects["acquire hero to top of deck for defeated monster"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouDefeatMonsterFromCenterRow", 0 },
	};
	triggereffect = {
		{ "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerEffectPlayerMayAcquireHeroToTopOfDeck", 0 },
		{ "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

g_ascension_cards["Cetra, Voidmother"] = {
   card_name = "Cetra, Voidmother";
   card_set = "Del";
   card_type = "Hero";
   faction = "Void";
	dreamborn = true;

   rune_cost = 7;
   honor = 5;

   center_row = { "EachPlayerGainInsight", 1 },

	effects = {
		{ "GainPower", 4 },
		{ "AcquireHeroToTopOfDeckNextTimeYouDefeatCenterRowMonster", 1 },
	};
	
	effect_text = "Gain 4P.\n" ..
					"The next time you defeat a Monster in the center row this turn, " ..
						"you may acquire a Hero without paying its cost " ..
						"and put it on top of your deck.";

   ai = {
   },

   image_large = { "VH_CetraVoidmother", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_cards["Arbiter Circlet"] = {
   card_name = "Arbiter Circlet";
   card_set = "Del";
   card_type = "Construct";
   faction = "Void";
	dreamborn = true;

   rune_cost = 3;
   honor = 2;

   center_row = { "EachPlayerGainInsight", 1 },

   construct_abilities = {
      {
         description = "Gain 1P";
         { "GainPower", 1 },

         ai = {
            trivial = true,
         },
      },
   };

   effect_text = "Once per turn, gain 1P.";
   
	flavor_text = "Demon bone and one hundred souls.";

   ai = {
   },

   image_large = { "VC_ArbiterCirclet", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}

g_ascension_cards["Nilhammer"] = {
   card_name = "Nilhammer";
   card_set = "Del";
   card_type = "Construct";
   faction = "Void";

   rune_cost = 5;
   honor = 3;

   construct_abilities = {
      {
         description = "Gain 3P";
         condition = { "IfHasVoidCardsInDiscardPile", 1 },
         { "GainPower", 3 },

         ai = {
            trivial = true,
         },
      },
   };

   effect_text = "Echo: Once per turn, gain 3P. " ..
					"(Gain this effect if there is a Void card in your discard pile.)";
   
	flavor_text = "Need something that breaks bones and spirits?";

   ai = {
   },

   image_large = { "VC_Nilhammer", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}
















g_ascension_cards["Demon Pups"] = {
   card_name = "Demon Pups";
   card_set = "Del";
   card_type = "Monster";

   power_cost = 3;

   rewards = {
		{ "GainHonor", 1 },
		{ "DrawCards", 1 },
		{ "MayRecurEffectForInsight", 1 },
		{ "DrawCards", 1, condition={"IfYouDo",2} },
   };
   
   effect_text = "Reward: Gain 1H. " ..
					"Draw a card. " ..
					"Then, you may pay 1I to draw an additional card.";
   
	flavor_text = "I just wanted to pet one!";

   ai = {
   },

   image_large = { "M_DemonPups", {0, 0, 364/512, 1} };
   --image_medium = { "M_IkuValleyTyrant", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_IkuValleyTyrant", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_IkuValleyTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Demon Pups" };

   rarity_count = 4
}


g_ascension_cards["Dream Eater"] = {
   card_name = "Dream Eater";
   card_set = "Del";
   card_type = "Monster";

   power_cost = 3;

   rewards = {
      { "GainHonor", 2 },
      { "GainInsight", 1 },
   };
   
   effect_text = "Reward: Gain 2H and 1I.";
   
	flavor_text = "The dream was painful, but the reality was torture.";

   ai = {
   },

   image_large = { "M_DreamEater", {0, 0, 364/512, 1} };
   --image_medium = { "M_IkuValleyTyrant", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_IkuValleyTyrant", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_IkuValleyTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Dream Eater" };

   rarity_count = 4
}

g_ascension_cards["Delirium Pixies"] = {
   card_name = "Delirium Pixies";
   card_set = "Del";
   card_type = "Monster";

   power_cost = 4;

   rewards = {
      { "GainHonor", 2 },
      { "GainRunes", 3 },
   };
   
   effect_text = "Reward: Gain 2H and 3R.";
   
	flavor_text = "Come play with us.";

   ai = {
   },

   image_large = { "M_DeliriumPixies", {0, 0, 364/512, 1} };
   --image_medium = { "M_IkuValleyTyrant", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_IkuValleyTyrant", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_IkuValleyTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Delirium Pixies" };

   rarity_count = 3
}


g_ascension_cards["Mammoth Beetle"] = {
   card_name = "Mammoth Beetle";
   card_set = "Del";
   card_type = "Monster";

   power_cost = 4;

	rewards = {
		{ "GainHonor", 3 },
		{ "EachOpponentDiscardsConstructInPlay", 0 },
		{ "MayRecurEffectForInsight", 1 },
		{ "EachOpponentDiscardsConstructInPlay", 0, condition={"IfYouDo",2} },
	};
   
   effect_text = "Reward: Gain 3H. " ..
					"Each opponent destroys a Construct they control. " ..
					"You may pay 1I to have each opponent destroy an " ..
					"additional Construct they control.";


   ai = {
   },

   image_large = { "M_MammothBeetle", {0, 0, 364/512, 1} };
   --image_medium = { "M_IkuValleyTyrant", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_IkuValleyTyrant", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_IkuValleyTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Mammoth Beetle" };

   rarity_count = 3
}


g_ascension_cards["Bleaktoad"] = {
   card_name = "Bleaktoad";
   card_set = "Del";
   card_type = "Monster";

   power_cost = 4;

	rewards = {
		{ "GainHonor", 4 },
		{ "BanishFromHandOrDiscard", 1 },
		{ "MayRecurEffectForInsight", 2 },
		{ "BanishFromHandOrDiscard", 0, condition={"IfYouDo",2} },
	};
   
   effect_text = "Reward: Gain 4H. " ..
					"You may banish a card in your hand or discard pile. " ..
					"You may pay 2I to banish an additional card in your hand or discard pile.";


   ai = {
   },

   image_large = { "M_Bleaktoad", {0, 0, 364/512, 1} };
   --image_medium = { "M_IkuValleyTyrant", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_IkuValleyTyrant", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_IkuValleyTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Bleaktoad" };

   rarity_count = 3
}


g_ascension_cards["Dreadmare"] = {
   card_name = "Dreadmare";
   card_set = "Del";
   card_type = "Monster";

   power_cost = 5;

   rewards = {
      { "GainHonor", 4 },
      { "GainInsight", 3 },
   };
   
   effect_text = "Reward: Gain 4H and 3I.";
   
	flavor_text = "A soul a day keeps the Dreadmare away.";

   ai = {
   },

   image_large = { "M_Dreadmare", {0, 0, 364/512, 1} };
   --image_medium = { "M_IkuValleyTyrant", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_IkuValleyTyrant", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_IkuValleyTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Dreamare" };

   rarity_count = 3
}


g_ascension_cards["Oak of Souls"] = {
   card_name = "Oak of Souls";
   card_set = "Del";
   card_type = "Monster";

   power_cost = 5;

   rewards = {
		{ "GainHonor", 3 },
		{ "PauseForAnimation", 0 },
		{ "RollDeliriumDie", 0 },
   };
   
   effect_text = "Reward: Gain 3H. " ..
					"Roll the Delirium Die.";
   
	flavor_text = "The result of conscious death in an unconscious world.";

   ai = {
   },

   image_large = { "M_OakSouls", {0, 0, 364/512, 1} };
   --image_medium = { "M_IkuValleyTyrant", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_IkuValleyTyrant", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_IkuValleyTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Oak of Souls" };

   rarity_count = 2
}


g_ascension_cards["Zis, Dreamreaper"] = {
   card_name = "Zis, Dreamreaper";
   card_set = "Del";
   card_type = "Monster";

   power_cost = 6;

   rewards = {
      { "GainHonor", 5 },
      { "TakeInsightFromEachOpponent", 2 },
   };
   
   effect_text = "Reward: Gain 5H. " ..
					"Take 2I from each opponent.";
   
	flavor_text = "As many ways to die, as there are dreams to be dreamt.";

   ai = {
   },

   image_large = { "M_ZisDreamreaper", {0, 0, 364/512, 1} };
   --image_medium = { "M_IkuValleyTyrant", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_IkuValleyTyrant", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_IkuValleyTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Zis Dreamreaper" };

   rarity_count = 1
}


g_ascension_cards["Torment Legionary"] = {
   card_name = "Torment Legionary";
   card_set = "Del";
   card_type = "Monster";

   power_cost = 6;

   rewards = {
      { "GainHonor", 6 },
	  { "AcquireDreambornFromCenterRow", 0 },
   };
   
   effect_text = "Reward: Gain 6H. " ..
					"Acquire a Dreamborn card in the center row without paying its cost.";
   
	flavor_text = "Boundless ambition, beyond death, beyond reality.";

   ai = {
   },

   image_large = { "M_TormentLegionary", {0, 0, 364/512, 1} };
   --image_medium = { "M_IkuValleyTyrant", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_IkuValleyTyrant", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_IkuValleyTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Torment Legionary" };

   rarity_count = 2
}


g_ascension_cards["Karion"] = {
   card_name = "Karion";
   card_set = "Del";
   card_type = "Monster";

   power_cost = 7;

   rewards = {
      { "GainHonor", 5 },
      { "GainInsight", 10 },
   };
   
   effect_text = "Reward: Gain 5H and 10I.";
   
	flavor_text = "The Dreamscape gate is corrupt, a hellish wound on two worlds.";

   ai = {
   },

   image_large = { "M_Karion", {0, 0, 364/512, 1} };
   --image_medium = { "M_IkuValleyTyrant", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_IkuValleyTyrant", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_IkuValleyTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Karion" };

   rarity_count = 1
}


g_ascension_cards["Glover, Dream Titan"] = {
   card_name = "Glover, Dream Titan";
   card_set = "Del";
   card_type = "Monster";

   power_cost = 8;

   rewards = {
      { "GainHonor", 7 },
	  { "TakeAllInsightFromOpponent", 0 },
	  { "StealRandomCardFromHandOfEffectDataPlayer", 1 },
   };
   
   effect_text = "Reward: Gain 7H. " ..
					"Choose a player and take all of their I " ..
						"and a random card from their hand. " ..
						"Add that card to your hand.";


   ai = {
   },

   image_large = { "M_GloverDreamTitan", {0, 0, 364/512, 1} };
   --image_medium = { "M_IkuValleyTyrant", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_IkuValleyTyrant", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_IkuValleyTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Glover Dream Titan" };

   rarity_count = 1
}








