


g_ascension_cards["Dreamseeker Start"] = {
   card_name = "Dreamseeker Start";
   display_name = "Dreamseeker";
   card_set = "Dlvr";
   card_type = "Hero";

    effects = {
      { "GainInsight", 1 },
      { "DrawCards", 1 },
	};
	
	effect_text = "Gain 1I and draw a card.";
	
	flavor_text = "Dreams maketh and dreams breaketh.";

   ai = {
   },

   image_large = { "HeroDreamseeker", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };
}





g_ascension_cards["Pasythea, The Redeemed"] = {
   card_name = "Pasythea, The Redeemed";
   card_set = "Dlvr";
   card_type = "Hero";
	factions = { "Enlightened", "Lifebound", "Mechana", "Void" };

   insight_cost = 16;
   honor = 6;
   
   global_continuous_effects = {
      {
         priority = -5;
         --conditions = {
		 --	{ "TriggerIfAcquireQueryPlayerHasNoCardsInDiscardPile", 0 },
         --};
         effect = { "AcquireThisCardToHand", 0 };
      },
   };
   
   effects = {
      { "GainRunes", 2 },
      { "GainPower", 2 },
      { "GainHonor", 2 },
      { "DrawCards", 1 },
	};
   
	effect_text = "This Hero counts as all factions\n" ..
					"When you acquire this, it goes directly to your hand.\n" ..
					"Gain 2R, 2P, 2H and draw a card.";

   ai = {
   },

   image_large = { "H_PasytheaRedeemed", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Pasythea's Cutlass"] = {
   card_name = "Pasythea's Cutlass";
   card_set = "Dlvr";
   card_type = "Construct";
	factions = { "Enlightened", "Lifebound", "Mechana", "Void" };

   rune_cost = 4;
   honor = 4;

   	triggered_effects = {
		{
			conditions = {
				{ "IfThisHasntBeenUsedThisTurn", 0 },
				{ "WhenYouPutThisConstructIntoPlay", 0 },
			};
			triggereffect = {
				{ "TriggerConstructGainPower", 2 },
				{ "TriggerSetThisHasBeenUsedThisTurn", 0 },
			};
		},
	};
	
	continuous_effects = {
      {
         priority = 9;
         effect = { "ReduceCostOfPasytheaRedeemed", 4 };
      },
    };
   
	effect_text = "This Construct counts as all factions.\n" ..
					"When you play this, gain 2P.\n" ..
					"Pasythea costs you 4I less to acquire.";
	

   ai = {
   },

   image_large = { "C_PasytheasCutlass", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_cards["Pasythea's Katana"] = {
   card_name = "Pasythea's Katana";
   card_set = "Dlvr";
   card_type = "Construct";
	factions = { "Enlightened", "Lifebound", "Mechana", "Void" };

   rune_cost = 4;
   honor = 4;
   
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
	
	continuous_effects = {
      {
         priority = 9;
         effect = { "ReduceCostOfPasytheaRedeemed", 4 };
      },
	};
	
	effect_text = "This Construct counts as all factions.\n" ..
					"When you play this, draw a card.\n" ..
					"Pasythea costs you 4I less to acquire.";
	

   ai = {
   },

   image_large = { "C_PasytheasKatana", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_cards["Pasythea's Mace"] = {
   card_name = "Pasythea's Mace";
   card_set = "Dlvr";
   card_type = "Construct";
	factions = { "Enlightened", "Lifebound", "Mechana", "Void" };

   rune_cost = 4;
   honor = 4;
   
   	triggered_effects = {
		{
			conditions = {
				{ "IfThisHasntBeenUsedThisTurn", 0 },
				{ "WhenYouPutThisConstructIntoPlay", 0 },
			};
			triggereffect = {
				{ "TriggerConstructGainRunes", 2 },
				{ "TriggerSetThisHasBeenUsedThisTurn", 0 },
			};
		},
	};
	
	continuous_effects = {
      {
         priority = 9;
         effect = { "ReduceCostOfPasytheaRedeemed", 4 };
      },
    };
	
	effect_text = "This Construct counts as all factions.\n" ..
					"When you play this, gain 2R.\n" ..
					"Pasythea costs you 4I less to acquire.";
	

   ai = {
   },

   image_large = { "C_PasytheasMace", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_cards["Pasythea's Scimitar"] = {
   card_name = "Pasythea's Scimitar";
   card_set = "Dlvr";
   card_type = "Construct";
   factions = { "Enlightened", "Lifebound", "Mechana", "Void" };

   rune_cost = 4;
   honor = 4;

	triggered_effects = {
		{
			conditions = {
				{ "IfThisHasntBeenUsedThisTurn", 0 },
				{ "WhenYouPutThisConstructIntoPlay", 0 },
			};
			triggereffect = {
				{ "TriggerConstructGainHonor", 2 },
				{ "TriggerSetThisHasBeenUsedThisTurn", 0 },
			};
		},
	};
	
	continuous_effects = {
      {
         priority = 9;
         effect = { "ReduceCostOfPasytheaRedeemed", 4 };
      },
    };
	
	effect_text = "This Construct counts as all factions.\n" ..
					"When you play this, gain 2H.\n" ..
					"Pasythea costs you 4I less to acquire.";
	

   ai = {
   },

   image_large = { "C_PasytheasScimitar", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}














g_ascension_cards["Dreamwalker"] = {
   card_name = "Dreamwalker";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Enlightened";

   rune_cost = 1;
   honor = 1;

   effects = {
		{ "BanishFromCenterRowWithDreamwalkerEffect", 1, condition={"IfRulesVersionIsLessThan",33} },
		{ "BanishFromCenterRowWithDreamwalkerEffect", 0, condition={"IfRulesVersionIsAtLeast",33} },
	}; 
	
	effect_text = "Banish a card in the center row.\n" ..
					"If it is replaced by a Monster, gain 2I.\n" ..
					"If it is replaced by a Hero, gain 2H.\n" ..
					"If it is replaced by a Construct, draw 2 cards.";
	
	--flavor_text = "Are you sure you want to know?";

   ai = {
   },

   image_large = { "EH_Dreamwalker", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Dream Chamber Disciples"] = {
   card_name = "Dream Chamber Disciples";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Enlightened";

   rune_cost = 3;
   honor = 2;
   
   effects = {
      { "DrawCards", 1 },
      { "GainInsight", 2, condition={"IfHasZeroCardsInDiscard",0} },
	  { "SerenityEffect", 0, condition={"IfHasZeroCardsInDiscard",0} },
	};
	
	effect_text = "Draw a card.\n" ..
					"SERENITY: Gain 2I." ..
					" (Gain this effect if there are no cards in your discard pile.)";
	
	flavor_text = "The Arha teach us that in time all traditions" ..
					" break under the weight of principle.";

   ai = {
   },

   image_large = { "EH_DreamChamberDisciples", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}

g_ascension_active_effects["plunder 2I"] = {
   type = "triggered";
   conditions = {
      { "WhenYouPlunder", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerGainInsight", 2 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}

g_ascension_cards["Azurite Channeler"] = {
   card_name = "Azurite Channeler";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Enlightened";
   dreamborn = true;
   
   rune_cost = 3;
   honor = 2;
   
      center_row = { "EachPlayerGainInsight", 1 },

	effects = {
		{ "BanishFromHand", 0 },
		{ "AcquireMysticOrHeavyInfantryToHand", 0, condition={"IfYouDo",0} },
		{ "GainInsight", 2, condition={"IfHasPlunder",0} },
        { "Plunder2I", 0, condition={"IfHasNotPlunder",1} },
	};
	
	effect_text = "Banish a card in your hand and replace it with a Mystic or Heavy Infantry.\n" ..
					"PLUNDER - This turn, if you acquire a card AND defeat a Monster," ..
						"both in the center row, gain 2I.";

   ai = {
   },

   image_large = { "EH_AzurieChanneler", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}

-- TODO: transform
g_ascension_cards["Psyonic Apprentice"] = {
   card_name = "Psyonic Apprentice";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Enlightened";

   rune_cost = 4;
   honor = 2;
   
   effects = {
      { "DefeatMonsterWithLessPower", 4 },
   };
   
   transform_cost = 7;
   transform = {
      { "PauseForAnimation", 0 },
      { "TransformThisHero", 0 },
   };
   transform_into = "Psyonic Paladin";
   
	effect_text = "While this is in your hand, you may pay 7I " ..
					"to transform it into Psyonic Paladin.\n" ..
					"Defeat a Monster with cost 4P or less" ..
						" without paying its cost.";
	
   ai = {
   },

   image_large = { "EH_PsyonicApprentice", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Psyonic Paladin"] = {
   card_name = "Psyonic Paladin";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Enlightened";

   rune_cost = 4;
   honor = 4;
   
	effects = {
      { "DefeatMonsterWithLessPower", 0 },
   };
   transform_from = "Psyonic Apprentice";
   
	effect_text = "Defeat a Monster in the center row" ..
						" without paying its cost.";
						
	flavor_text = "As the armor is shaped by our thoughts," ..
					" the sword is directed by our will.";
	
   ai = {
   },

   image_large = { "EH_PsyonicPaladin", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Aether Warrior"] = {
   card_name = "Aether Warrior";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Enlightened";
   
   rune_cost = 5;
   phantasm_cost = 5;
   honor = 3;
   
	effects = {
      { "DrawCards", 2 },
   };
   
	effect_text = "PHANTASM - While this is in the center row, " ..
					"you may pay 5I to banish and play this.\n" ..
					"Draw two cards.";
	
	flavor_text = "My blade severs both flesh and soul.";

   ai = {
   },

   image_large = { "EH_AetherWarrior", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Psyche Askara"] = {
   card_name = "Psyche Askara";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Enlightened";
   dreamborn = true;
   
   rune_cost = 5;
   honor = 3;
   
   center_row = { "EachPlayerGainInsight", 1 },

   effects = {
      { "CopyEffectOfPlayedHeroOrDefeatedMonster", 0 },
   };
   
	effect_text = "Copy the effect of a Hero you have played this turn" ..
					" or a Monster Reward you have gained this turn.";
	
	flavor_text = "The Arha teach us that in time all traditions" ..
					" break under the weight of principle.";

   ai = {
   },

   image_large = { "EH_PsycheAskara", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Dhartha, Dream Master"] = {
   card_name = "Dhartha, Dream Master";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Enlightened";
   
   rune_cost = 8;
   phantasm_cost = 9;
   honor = 5;

	effect_text = "PHANTASM - While this is in the center row, " ..
					"you may pay 9I to banish and play this.\n" ..
					"Acquire a card in the center row without paying its cost" ..
						" and put it in your hand.";

	effects = {
      { "AcquireHeroOrConstructToHandInCenterRowAtNoCost", 0 },
   };
   
   ai = {
   },

   image_large = { "EH_DarthaDreamMaster", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


-- TODO: from center row
g_ascension_cards["Dream Anchor"] = {
   card_name = "Dream Anchor";
   card_set = "Dlvr";
   card_type = "Construct";
   faction = "Enlightened";
   
   rune_cost = 3;
   honor = 2;
   
   	construct_abilities = {
      {
         description = "Gain 2I";
		 condition = { "IfHasPlunder", 0 },
         { "GainInsight", 2 },

		  ai = {
			 trivial = true,
		  },
      },
   };
	effect_text = "PLUNDER - Once per turn, if you acquire a card AND defeat a Monster," ..
						"both in the center row, gain 2I.";

   ai = {
   },

   image_large = { "EC_DreamAnchor", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}








g_ascension_cards["Entrophantasm"] = {
   card_name = "Entrophantasm";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 1;
   honor = 1;
   
   effects = {
      { "GainRunes", 1 },
      { "GainInsight", 1 },
      { "DrawCards", 1, condition={"IfPlayedLifeboundHero",1} },
      { "UniteDraw1Card", 0, condition={"IfHaventPlayedLifeboundHero",1} },
   };
   
	effect_text = "Gain 1R and 1I.\n" ..
					"UNITE: Draw a card." ..
					"(Gain this effect if you play or have played another Lifebound Hero this turn.)";
	
	--flavor_text = "Are you sure you want to know?";

   ai = {
   },

   image_large = { "LH_Entrophantasm", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}

g_ascension_active_effects["plunder 3H"] = {
   type = "triggered";
   conditions = {
      { "WhenYouPlunder", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerGainHonor", 3 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}


g_ascension_cards["Dreamscarred Hunter"] = {
   card_name = "Dreamscarred Hunter";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 2;
   honor = 1;
   
   effects = {
      { "DrawCards", 1 },
	  { "GainHonor", 3, condition={"IfHasPlunder",0} },
      { "Plunder3H", 0, condition={"IfHasNotPlunder",1} },
  };

	effect_text = "Draw a card.\n" ..
					"PLUNDER - This turn, if you acquire a card AND defeat a Monster," ..
						"both in the center row, gain 3H.";
	
	--flavor_text = "Are you sure you want to know?";

   ai = {
   },

   image_large = { "LH_DreamscarredHunter", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_active_effects["gain 2P on center hero acquire"] = {
   type = "triggered";
   conditions = {
      { "WhenYouAcquireHeroFromCenterRow", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerGainPower", 2 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}


g_ascension_cards["Faerie Commander"] = {
   card_name = "Faerie Commander";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 3;
   honor = 2;

   effects = {
      { "GainRunes", 2 },
	  { "NextCenterRowHeroYouAcquireGain2P", 0 },
   };
   
	effect_text = "Gain 2R." ..
					" The next time you acquire a Hero in the center row" ..
						" this turn, gain 2P.";
	
	flavor_text = "He was found dead in the forest a million little cuts.";

   ai = {
   },

   image_large = { "LH_FaerieCommander", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Green Spritelings"] = {
   card_name = "Green Spritelings";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 3;
   phantasm_cost = 4;
   honor = 2;
   
   effects = {
      { "GainHonor", 3 },
   };
   
	effect_text = "PHANTASM - While this is in the center row, " ..
					"you may pay 4I to banish and play this.\n" ..
					"Gain 3H.";
	
	--flavor_text = "Are you sure you want to know?";

   ai = {
   },

   image_large = { "LH_GreenSpritelings", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_active_effects["unite 3R"] = {
   type = "triggered";
   conditions = {
      { "WhenYouPlayLifeboundHero", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerGainRunes", 3 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}

g_ascension_cards["Wereboar"] = {
   card_name = "Wereboar";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Lifebound";
   dreamborn = true;
   
   rune_cost = 4;
   honor = 2;
   
      center_row = { "EachPlayerGainInsight", 1 },

   effects = {
      { "GainPower", 2 },
      { "GainRunes", 3, condition={"IfPlayedLifeboundHero",1} },
      { "Unite3R", 0, condition={"IfHaventPlayedLifeboundHero",1} },
   };
   
	effect_text = "Gain 2P." ..
					"UNITE: Gain 3R.";
	
	--flavor_text = "Are you sure you want to know?";

   ai = {
   },

   image_large = { "LH_Wereboar", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Lychan Ranger"] = {
   card_name = "Lychan Ranger";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 5;
   honor = 3;
   
   effects = {
      { "GainPower", 2 },
      { "GainRunes", 2 },
   };
   
   transform_cost = 6;
   transform = {
      { "PauseForAnimation", 0 },
      { "TransformThisHero", 0 },
   };
   transform_into = "Lychan Beast";

	effect_text = "While this is in your hand, you may pay 6I" ..
					" to transform it into Lychan Beast.\n" ..
					"Gain 2R and 2P.";

   ai = {
   },

   image_large = { "LH_LychanRanger", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Lychan Beast"] = {
   card_name = "Lychan Beast";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 5;
   honor = 5;
   
   effects = {
      { "GainPower", 3 },
      { "GainRunes", 3 },
   };
   transform_from = "Lychan Ranger";

	effect_text = "Gain 3R and 3P.";
	
	flavor_text = "They'll never see me coming.";

   ai = {
   },

   image_large = { "LH_LychanBeast", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Rut, Oaken Master"] = {
   card_name = "Rut, Oaken Master";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Lifebound";
   dreamborn = true;
   
   rune_cost = 6;
   honor = 3;
   
      center_row = { "EachPlayerGainInsight", 1 },

   effects = {
      { "GainHonor", 3 },
      { "DrawCards", 1 },
	  { "GainHonor", 3, condition={"IfHasPlunder",0} },
      { "Plunder3H", 0, condition={"IfHasNotPlunder",1} },
   };
   
	effect_text = "Gain 3H and draw a card.\n" ..
					"PLUNDER - Once per turn, if you acquire a card AND defeat a Monster," ..
						"both in the center row, gain an additional 3H.";

   ai = {
   },

   image_large = { "LH_RutOakenMaster", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

-- TODO: from center row
g_ascension_cards["Tree of Bounty"] = {
   card_name = "Tree of Bounty";
   card_set = "Dlvr";
   card_type = "Construct";
   faction = "Lifebound";

   rune_cost = 4;
   honor = 3;
   
   	construct_abilities = {
      {
         description = "Gain 3H";
		 condition = { "IfHasPlunder", 0 },
         { "GainHonor", 3 },

		  ai = {
			 trivial = true,
		  },
      },
   };

	effect_text = "PLUNDER - Once per turn, if you acquire a card AND defeat a Monster," ..
						"both in the center row, gain 3H.";
	
	--flavor_text = "Are you sure you want to know?";

   ai = {
   },

   image_large = { "LC_TreeBounty", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}













g_ascension_cards["Corite Mechanadon"] = {
   card_name = "Corite Mechanadon";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Mechana";

   rune_cost = 1;
   phantasm_cost = 2;
   honor = 1;
   
   effects = {
      { "GainRunes", 1 },
      { "GainPower", 1 },
   };
   
	effect_text = "PHANTASM - While this is in the center row, " ..
					"you may pay 2I to banish and play this.\n" ..
					"Gain 1R and 1P.";

   ai = {
   },

   image_large = { "MH_CoriteMechanadon", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Controlsmith"] = {
   card_name = "Controlsmith";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Mechana";
   dreamborn = true;
   
   rune_cost = 3;
   honor = 2;
   
      center_row = { "EachPlayerGainInsight", 1 },

   effects = {
      { "GainRunes", 2 },
      { "DrawCards", 1, condition={"IfYouControlTransformedConstructs",1} },
   };

	effect_text = "Gain 2R." ..
					" If you control a Transformed Constuct, draw a card.";

   ai = {
   },

   image_large = { "MH_Controlsmith", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Stone Artificers"] = {
   card_name = "Stone Artificers";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Mechana";
   dreamborn = true;
   
   rune_cost = 4;
   honor = 2;
   
      center_row = { "EachPlayerGainInsight", 1 },

   effects = {
      { "GainRunes", 2 },
      { "NextContructYouAcquireMayGoDirectlyIntoPlay", 0 },
   };
   
	effect_text = "Gain 2R." ..
					" You may put the next Construct you acquire" ..
					" this turn directly into play.";

   ai = {
   },

   image_large = { "MH_StoneArtificers", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Gearseer"] = {
   card_name = "Gearseer";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Mechana";

   rune_cost = 5;
   phantasm_cost = 6;
   honor = 3;
   
   effects = {
      { "GainRunes", 3 },
   };
   
	effect_text = "PHANTASM - While this is in the center row, " ..
					"you may pay 6I to banish and play this.\n" ..
					"Gain 3R.";
	
	flavor_text = "The only difference between genius and madness is execution.";

   ai = {
   },

   image_large = { "MH_Gearseer", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Teletransmitter Blueprint"] = {
   card_name = "Teletransmitter Blueprint";
   card_set = "Dlvr";
   card_type = "Construct";
   faction = "Mechana";

   rune_cost = 3;
   honor = 3;
   
	construct_abilities = {
		{
         description = "Transform";
		condition = { "IfCanPayInsight", 5 },
         { "PushResolvingConstruct", 0 },
         { "PauseForAnimation", 0 },
		 { "PayInsight", 5 },
         { "TransformThisConstruct", 0 },

		},
	};
    transform_into = "Emma's Teletransmitter";

	effect_text = "You may pay 5I to transform this into Emma's Teletransmitter.";
	
	flavor_text = "It's like telepathy, but less effective.\n" ..
					"- Emma Ironheart";

   ai = {
   },

   image_large = { "MC_TeletransmitterBlueprint", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Emma's Teletransmitter"] = {
   card_name = "Emma's Teletransmitter";
   card_set = "Dlvr";
   card_type = "Construct";
   faction = "Mechana";

   rune_cost = 3;
   honor = 4;
   
    construct_abilities = {
      {
         description = "Gain H";
         { "GainHonorForEachTransformedMechanaConstructInPlay", 1 },

         ai = {
         },
      },
    };
   
    transform_from = "Teletransmitter Blueprint";

	effect_text = "Once per turn, gain 1H for each Transformed Mechana Construct you contol.";
	
	flavor_text = "\"Why in the five hells would I be calling you" ..
					" if I didn't need help?\" - Emma Ironheart";

   ai = {
   },

   image_large = { "MC_EmmasTeletransmitter", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Mechannon Blueprint"] = {
   card_name = "Mechannon Blueprint";
   card_set = "Dlvr";
   card_type = "Construct";
   faction = "Mechana";

   rune_cost = 4;
   honor = 4;
   
	construct_abilities = {
		{
         description = "Transform";
		condition = { "IfCanPayInsight", 5 },
         { "PushResolvingConstruct", 0 },
         { "PauseForAnimation", 0 },
		 { "PayInsight", 5 },
         { "TransformThisConstruct", 0 },

		},
	};
    transform_into = "Emma's Mechannon";

	effect_text = "You may pay 5I to transform this into Emma's Mechannon.";
	
	flavor_text = "\"I wonder what kind of dent this thing is" ..
					" going to make.\" - Emma Ironheart";

   ai = {
   },

   image_large = { "MC_MechannonBlueprint", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Emma's Mechannon"] = {
   card_name = "Emma's Mechannon";
   card_set = "Dlvr";
   card_type = "Construct";
   faction = "Mechana";

   rune_cost = 4;
   honor = 5;
	
    construct_abilities = {
      {
         description = "Gain P";
         { "GainPowerForEachTransformedMechanaConstructInPlay", 1 },

         ai = {
         },
      },
    };
   
    transform_from = "Mechannon Blueprint";

	effect_text = "Once per turn, gain 1P for each Transformed Mechana Construct you contol.";
	
	flavor_text = "\"Did anyone see that? I put a hole" ..
					" in that mountain!\" - Emma Ironheart";

   ai = {
   },

   image_large = { "MC_EmmasMechannons", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Voidcycler Blueprint"] = {
   card_name = "Voidcycler Blueprint";
   card_set = "Dlvr";
   card_type = "Construct";
   faction = "Mechana";

   rune_cost = 5;
   honor = 5;
   
	construct_abilities = {
		{
         description = "Transform";
		condition = { "IfCanPayInsight", 5 },
         { "PushResolvingConstruct", 0 },
         { "PauseForAnimation", 0 },
		 { "PayInsight", 5 },
         { "TransformThisConstruct", 0 },

		},
	};
    transform_into = "Emma's Voidcycler";

	effect_text = "You may pay 5I to transform this into Emma's Voidcycler.";
	
	flavor_text = "\"I wonder what kind of dent this thing is" ..
					" going to make.\" - Emma Ironheart";

   ai = {
   },

   image_large = { "MC_VoidcyclerBlueprint", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Emma's Voidcycler"] = {
   card_name = "Emma's Voidcycler";
   card_set = "Dlvr";
   card_type = "Construct";
   faction = "Mechana";

   rune_cost = 5;
   honor = 6;
   
    construct_abilities = {
      {
         description = "Gain R";
         { "GainRunesForEachTransformedMechanaConstructInPlay", 1 },

         ai = {
         },
      },
    };
    transform_from = "Voidcycler Blueprint";

	effect_text = "Once per turn, gain 1R for each Transformed Mechana Construct you contol.";
	
	flavor_text = "\"This proves it." ..
					" Emma, you're a genius.\" - Emma Ironheart";

   ai = {
   },

   image_large = { "MC_EmmasVoidcycler", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Emma's Workshop"] = {
   card_name = "Emma's Workshop";
   card_set = "Dlvr";
   card_type = "Construct";
   faction = "Mechana";

   rune_cost = 7;
   honor = 7;

   	construct_abilities = {
		{
			description = "Transform Construct";
			condition = { "IfHaveUntransformedMechanaConstruct", 1 },
			{ "PushResolvingConstruct", 0 },
			{ "TransformMechanaConstruct", 0 },
			{ "PopResolvingConstruct", 0 },
		},
	};
	
	effect_text = "Once per turn, you may transform a Mechana Construct" ..
					" without paying its cost.";
					
	flavor_text = "\"This place is falling apart." ..
					" It's perfect.\" - Emma Ironheart";

   ai = {
   },

   image_large = { "MC_EmmasWorkshop", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Ironheart Blueprint"] = {
   card_name = "Ironheart Blueprint";
   card_set = "Dlvr";
   card_type = "Construct";
   faction = "Mechana";

   rune_cost = 8;
   honor = 8;
   
	construct_abilities = {
      {
         description = "Gain I";
		 condition = { "IfYouControlMechanaConstructs_v33", 1 },
         { "GainInsightForEachTransformedMechanaConstructInPlay", 1, condition={"IfRulesVersionIsLessThan",33} },
         { "GainInsightForEachMechanaConstructInPlay", 1, condition={"IfRulesVersionIsAtLeast",33} },
		 

         ai = {
         },
      },
	  {
         description = "Transform";
		 condition = { "IfCanPayInsight", 15 },
         { "PushResolvingConstruct", 0 },
         { "PauseForAnimation", 0 },
		 { "PayInsight", 15 },
         { "TransformThisConstruct", 0 },

		},
	};
    transform_into = "The Ironheart";

	effect_text = "You may pay 15I to transform this into The Ironheart.\n" ..
					"Once per turn, gain 1I for each Mechana Construct you contol.";

   ai = {
   },

   image_large = { "MC_IronheartBlueprint", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["The Ironheart"] = {
   card_name = "The Ironheart";
   card_set = "Dlvr";
   card_type = "Construct";
   faction = "Mechana";

   rune_cost = 8;
   honor = 10;
   
	construct_abilities = {
      {
         description = "Gain 3R 3P and 3H";
         { "GainRunes", 3 },
         { "GainPower", 3 },
         { "GainHonor", 3 },

		  ai = {
			 trivial = true,
		  },
      },
   };
   
    transform_from = "Ironheart Blueprint";
   
	effect_text = "Once per turn, gain 3R, 3P, and 3H.";
	
	flavor_text = "\"I don't care how many tentacles you have." ..
					" I have an airship!\" - Emma Ironheart";

   ai = {
   },

   image_large = { "MC_Ironheart", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}












g_ascension_cards["Blackwatch Dreamer"] = {
   card_name = "Blackwatch Dreamer";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 1;
   phantasm_cost = 2;
   honor = 1;
   
   effects = {
      { "GainPower", 1 },
      { "BanishFromHandOrDiscard", 1 },
   };
   
	effect_text = "PHANTASM - While this is in the center row," ..
					" you may pay 2I to banish and play this.\n" ..
					"Gain 1P." ..
						" You may banish a card in your hand of discard pile.";

   ai = {
   },

   image_large = { "VH_BlackwatchDreamer", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Void Amathyst Defender"] = {
   card_name = "Void Amathyst Defender";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Void";
   dreamborn = true;
   
   rune_cost = 2;
   honor = 1;
   
      center_row = { "EachPlayerGainInsight", 1 },

   effects = {
      { "GainPower", 2 },
      { "GainInsight", 2, condition={"IfHasVoidCardsInDiscardPile",1} },
   };
   
	effect_text = "Gain 2P.\n" ..
					"ECHO: Gain 2I." ..
						"(Gain this effect if there is a Void card in your discard pile.)";

   ai = {
   },

   image_large = { "VH_VoidAmathystDefender", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Demon Hunter"] = {
   card_name = "Demon Hunter";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 3;
   honor = 2;
   
   effects = {
      { "GainPower", 2 },
   };
   
   transform_cost = 8;
   transform = {
      { "PauseForAnimation", 0 },
      { "TransformThisHero", 0 },
   };
   transform_into = "Demon Master";
   
	effect_text = "While this is in your hand, you may pay 8I" ..
					" to transform it into Demon Master.\n" ..
					"Gain 2P.";
					
	flavor_text = "Good. Bad. Try the one with the sword.";

   ai = {
   },

   image_large = { "VH_DemonHunter", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Demon Master"] = {
   card_name = "Demon Master";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 3;
   honor = 4;
   
   effects = {
      { "GainPower", 5 },
      { "BanishFromHandOrDiscard", 1 },
   };
   transform_from = "Demon Hunter";
   
	effect_text = "Gain 5P." ..
					" You may banish a card in your hand or discard pile.";
					
	flavor_text = "The job is tough, but the smell is worse.";

   ai = {
   },

   image_large = { "VH_DemonMaster", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Invokist"] = {
   card_name = "Invokist";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 4;
   phantasm_cost = 4;
   honor = 2;
   
   effects = {
      { "GainPower", 3 },
   };
   
	effect_text = "PHANTASM - While this is in the center row," ..
					" you may pay 4I to banish and play this.\n" ..
					"Gain 3P.";
					
	flavor_text = "Fear has a face.\n" ..
					"Allow me to show it to you.";

   ai = {
   },

   image_large = { "VH_Invokist", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Nihil Bomber"] = {
   card_name = "Nihil Bomber";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 5;
   honor = 3;
   
   effects = {
      { "DrawCards", 1 },
      { "BanishFromHandOrDiscard", 1 },
      { "GainInsight", 1, condition={"IfYouDo",1} },
   };
   
	effect_text = "Draw a card." ..
					" You may banish a card in your hand or discard pile." ..
					" If you do, gain 1I.";
					
	--flavor_text = "Fear has a face.\n" ..
	--				"Allow me to show it to you.";

   ai = {
   },

   image_large = { "VH_NihilBomber", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}

g_ascension_active_effects["reduce dreambind costs to 0"] = {
	type = "continuous";
	effectfunc = { "ReduceDreambindCostToZero", 0 };
}


g_ascension_cards["Naka, Emri's Chosen"] = {
   card_name = "Naka, Emri's Chosen";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Void";
   dreamborn = true;
   
   rune_cost = 6;
   honor = 3;
   
      center_row = { "EachPlayerGainInsight", 1 },

   effects = {
      { "GainPower", 4 },
      { "ReduceDreambindCostThisTurn", 0 },
	  
   };
   
	effect_text = "Gain 4P.\n" ..
					"This turn, you may pay 0I for Dreambind costs.";

   ai = {
   },

   image_large = { "VH_NakaEmrisChosen", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Emri, Soulstealer"] = {
   card_name = "Emri, Soulstealer";
   card_set = "Dlvr";
   card_type = "Hero";
   faction = "Void";
   
   rune_cost = 8;
   honor = 5;

   effects = {
      { "GainPower", 5, condition={"IfThereAreNotMonstersInVoid",10} },
	  { "GainPower", 10, condition={"IfThereAreMonstersInVoid",10} },
   };
   
	effect_text = "Gain 5P. If there are 10 or more Monsters in the Void, gain 10P instead";
	
	flavor_text = "Another day, another demigod.";

   ai = {
   },

   image_large = { "VH_EmriSoulstealer", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_cards["Zinta's Bracers"] = {
   card_name = "Zinta's Bracers";
   card_set = "Dlvr";
   card_type = "Construct";
   faction = "Void";

   rune_cost = 3;
   honor = 2;

   
   	construct_abilities = {
      {
         description = "Gain 2P";
		 condition = { "IfHasGainedInsightThisTurn", 2 },
         { "GainPower", 2 },

		  ai = {
			 trivial = true,
		  },
      },
   };
   
	effect_text = "Once per turn, if you have gained 2I or more, gain 2P.";

	flavor_text = "Zinta reached into the Void and from it pulled daggers.";

   ai = {
   },

   image_large = { "VC_ZintasBracers", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}







g_ascension_cards["Nightmarauders"] = {
   card_name = "Nightmarauders";
   card_set = "Dlvr";
   card_type = "Monster";

   power_cost = 2;

   rewards = {
		{ "GainHonor", 1 },
		{ "GainInsight", 1 },
   };
   
   effect_text = "Reward: Gain 1H and 1I.";
   
	flavor_text = "They're everywhere!.";

   ai = {
   },

   image_large = { "M_Nightmarauders", {0, 0, 364/512, 1} };
   --image_medium = { "M_IkuValleyTyrant", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_IkuValleyTyrant", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_IkuValleyTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "nightmarauders" };

   rarity_count = 4
}


g_ascension_cards["Terminites"] = {
   card_name = "Terminites";
   card_set = "Dlvr";
   card_type = "Monster";

   power_cost = 3;

   rewards = {
		{ "GainHonor", 3 },
		{ "EachOpponentDiscardsLowestCostConstruct", 0 },
   };
   
   effect_text = "Reward: Gain 3H. " ..
					"Each opponent destroys the lowest cost Construct they control.";
   
	flavor_text = "They're just bugs, soldier. How big could they be?.";

   ai = {
   },

   image_large = { "M_Terminites", {0, 0, 364/512, 1} };
   --image_medium = { "M_IkuValleyTyrant", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_IkuValleyTyrant", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_IkuValleyTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "terminites" };

   rarity_count = 4
}


g_ascension_cards["Warpdruid"] = {
   card_name = "Warpdruid";
   card_set = "Dlvr";
   card_type = "Monster";
	dreambind = true;
	
   power_cost = 3;

   rewards = {
		{ "GainHonor", 2 },
        { "BanishFromHandOrDiscard", 1 },
        { "MayDreambindCardForInsight", 1 },	   
   };
   effects = {
		{ "GainHonor", 2 },
        { "BanishFromHandOrDiscard", 1 },
   };   
   
   effect_text = "Reward: Gain 2H. " ..
					"You may banish a card in your hand or discard pile.\n" ..
					"DREAMBIND: 1I.";
   
	--flavor_text = "Bark split flesh as .";

   ai = {
   },

   image_large = { "M_Warpdruid", {0, 0, 364/512, 1} };
   --image_medium = { "M_IkuValleyTyrant", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_IkuValleyTyrant", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_IkuValleyTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "warpdruid" };

   rarity_count = 3
}


g_ascension_cards["Dreadmage"] = {
   card_name = "Dreadmage";
   card_set = "Dlvr";
   card_type = "Monster";
	dreambind = true;

   power_cost = 4;

   rewards = {
		{ "GainHonor", 2 },
 		{ "DrawCards", 2 },
        { "MayDreambindCardForInsight", 4 },	   
   };
   effects = {
		{ "GainHonor", 2 },
 		{ "DrawCards", 2 },
   };   
   
   effect_text = "Reward: Gain 2H and draw two cards. " ..
					"DREAMBIND: 4I." ..
						"(When you defeat this, you may pay its Dreambind cost." ..
						" If you do, put this in your discard pile." ..
						" When you play this, gain its Reward.)";

   ai = {
   },

   image_large = { "M_Dreadmage", {0, 0, 364/512, 1} };
   --image_medium = { "M_IkuValleyTyrant", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_IkuValleyTyrant", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_IkuValleyTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "dreadmage" };

   rarity_count = 3
}


g_ascension_cards["Warprogue"] = {
   card_name = "Warprogue";
   card_set = "Dlvr";
   card_type = "Monster";
	dreambind = true;

   power_cost = 4;

   rewards = {
		{ "GainHonor", 3 },
		{ "TakeInsightFromOpponent", 1 },
        { "MayDreambindCardForInsight", 3 },	   
   };
   effects = {
		{ "GainHonor", 3 },
		{ "TakeInsightFromOpponent", 1 },
   };   
   
   effect_text = "Reward: Gain 3H." ..
					" Take 1I from an opponent. " ..
					"DREAMBIND: 3I.";
					
	--flavor_text = "Love is a dream. Love is a nightmare.";

   ai = {
   },

   image_large = { "M_Warprogue", {0, 0, 364/512, 1} };
   --image_medium = { "M_IkuValleyTyrant", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_IkuValleyTyrant", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_IkuValleyTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "warprogue" };

   rarity_count = 3
}


g_ascension_cards["Dream Titan"] = {
   card_name = "Dream Titan";
   card_set = "Dlvr";
   card_type = "Monster";

   power_cost = 5;

   rewards = {
		{ "GainHonor", 6 },
   };
   
   effect_text = "Reward: Gain 6H.";
   
	flavor_text = "A gold giant, taller than the mountains" ..
					" and silent as the sea.";

   ai = {
   },

   image_large = { "M_DreamTitan", {0, 0, 364/512, 1} };
   --image_medium = { "M_IkuValleyTyrant", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_IkuValleyTyrant", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_IkuValleyTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "dream_titan" };

   rarity_count = 3
}


g_ascension_cards["Obfusca Spirit"] = {
   card_name = "Obfusca Spirit";
   card_set = "Dlvr";
   card_type = "Monster";
	dreambind = true;

   power_cost = 5;

   rewards = {
		{ "GainHonor", 4 },
		{ "ForceOpponentToRandomDiscard", 1 },
        { "MayDreambindCardForInsight", 4 },	   
   };
   effects = {
		{ "GainHonor", 4 },
		{ "ForceOpponentToRandomDiscard", 1 },
   };   
   
   effect_text = "Reward: Gain 4H. " ..
					"Choose an opponent to discard a card at random from their hand.\n" ..
					"DREAMBIND: 4I.";
   
	flavor_text = "Love is a dream. Love is a nightmare.";

   ai = {
   },

   image_large = { "M_ObfuscaSpirit", {0, 0, 364/512, 1} };
   --image_medium = { "M_IkuValleyTyrant", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_IkuValleyTyrant", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_IkuValleyTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "obfusca_spirit" };

   rarity_count = 2
}


g_ascension_cards["Dream Tyrant"] = {
   card_name = "Dream Tyrant";
   card_set = "Dlvr";
   card_type = "Monster";

   power_cost = 6;

   rewards = {
		{ "GainHonor", 5 },
		{ "GainInsight", 5 },
   };
   
   effect_text = "Reward: Gain 5H and 5I.";
   
	--flavor_text = "A gold giant, taller than the mountains"
	--				" and silent as the sea.";

   ai = {
   },

   image_large = { "M_DreamTyrant", {0, 0, 364/512, 1} };
   --image_medium = { "M_IkuValleyTyrant", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_IkuValleyTyrant", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_IkuValleyTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "dream_tyrant" };

   rarity_count = 1
}


g_ascension_cards["River Reaper"] = {
   card_name = "River Reaper";
   card_set = "Dlvr";
   card_type = "Monster";

   power_cost = 6;

   rewards = {
		{ "GainHonor", 6 },
		{ "EachOpponentDiscardsAllButOneConstructInPlay", 0 },
   };
   
   effect_text = "Reward: Gain 6H." ..
					" Each opponent destroys all but one Construct they control.";
   
	--flavor_text = "A gold giant, taller than the mountains"
	--				" and silent as the sea.";

   ai = {
   },

   image_large = { "M_RiverReaper", {0, 0, 364/512, 1} };
   --image_medium = { "M_IkuValleyTyrant", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_IkuValleyTyrant", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_IkuValleyTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "river_reaper" };

   rarity_count = 2
}


g_ascension_cards["Caaro, Desert Breaker"] = {
   card_name = "Caaro, Desert Breaker";
   card_set = "Dlvr";
   card_type = "Monster";
	dreambind = true;

   power_cost = 6;

   rewards = {
		{ "GainHonor", 4 },
		{ "DestroyConstructForEachOpponent", 0 },
        { "MayDreambindCardForInsight", 2 },	   
   };
   effects = {
		{ "GainHonor", 4 },
		{ "DestroyConstructForEachOpponent", 0 },
   };   
   
   effect_text = "Reward: Gain 4H." ..
					" For each opponent, you choose and destroy a Construct they control." ..
 					"DREAMBIND: 2I.";
  
	--flavor_text = "A gold giant, taller than the mountains"
	--				" and silent as the sea.";

   ai = {
   },

   image_large = { "M_CaaroDesertBreaker", {0, 0, 364/512, 1} };
   --image_medium = { "M_IkuValleyTyrant", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_IkuValleyTyrant", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_IkuValleyTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "caaro_desert_breaker" };

   rarity_count = 1
}


g_ascension_cards["Nilia, The Shattered"] = {
   card_name = "Nilia, The Shattered";
   card_set = "Dlvr";
   card_type = "Monster";
	dreambind = true;

   power_cost = 7;

   rewards = {
		{ "GainHonor", 5 },
		{ "TakeRandomCardFromEachOpponent", 0, condition={"IfRulesVersionIsLessThan",33} },
		{ "TakeRandomCardFromSingleOpponent", 0, condition={"IfRulesVersionIsAtLeast",33} },
        { "MayDreambindCardForInsight", 7 },	   
   };
   effects = {
		{ "GainHonor", 5 },
		{ "TakeRandomCardFromEachOpponent", 0, condition={"IfRulesVersionIsLessThan",33} },
		{ "TakeRandomCardFromSingleOpponent", 0, condition={"IfRulesVersionIsAtLeast",33} },
   };   
   
   effect_text = "Reward: Gain 5H." ..
					" Take a card at random from an opponent's hand" ..
						" and add that card to your hand." ..
 					"DREAMBIND: 7I.";
  
	--flavor_text = "A gold giant, taller than the mountains"
	--				" and silent as the sea.";

   ai = {
   },

   image_large = { "M_NiliaShattered", {0, 0, 364/512, 1} };
   --image_medium = { "M_IkuValleyTyrant", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_IkuValleyTyrant", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_IkuValleyTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "nilia_the_shattered" };

   rarity_count = 1
}


g_ascension_cards["Rakar, Corrupt Askara"] = {
   card_name = "Rakar, Corrupt Askara";
   card_set = "Dlvr";
   card_type = "Monster";

   power_cost = 8;

   rewards = {
		{ "GainHonor", 6 },
		{ "AcquireDreambindMonsterFromVoidToHand", 1 },
   };
   
   effect_text = "Reward: Gain 6H. " ..
					"Add a Dreambind Monster in the Void to your hand.";
   
	--flavor_text = "Love is a dream. Love is a nightmare.";

   ai = {
   },

   image_large = { "M_RakarCorruptAskara", {0, 0, 364/512, 1} };
   --image_medium = { "M_IkuValleyTyrant", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_IkuValleyTyrant", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_IkuValleyTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "rakar_corrupt_askara" };

   rarity_count = 1
}













-- TODO
g_ascension_cards["Vezra'Tull, The Voidwyrm"] = {
   card_name = "Vezra'Tull, The Voidwyrm";
   card_set = "promo";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 8;
   honor = 5;

	effect_text = "You may spend P instead of H to acquire this.\n" ..
					"Gain 1P for each Monster in the Void.";
   
	flavor_text = "Some Dragons horde gold. She hordes nightmares.";

   ai = {
   },

   image_large = { "VH_VezraTullVoidwyrm", {0, 0, 364/512, 1} };
   --image_medium = { "EH_BlindSeer", {392/512, 0, 512/512, 168/512} };
   --image_small = { "EH_BlindSeer", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "EH_BlindSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


