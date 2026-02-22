

g_ascension_cards["Militia RU"] = {
	card_name = "Militia RU";
	display_name = "Militia";
    card_set = "RU";
	card_type = "Hero";
	rune_cost = 0;
   do_not_put_in_void = true;
	effect = { "GainPower", 1 };
	effect_text = "Gain 1P.";
   
   ai = {
      trivial = true,
      preferred_discard = true;
      preferred_banish = true;

      gain_power = 1;
   },
   
   --image_large = { "H_Militia_RU", {0, 0, 364/512, 1} };
   --image_medium = { "H_Militia_RU", {392/512, 0, 512/512, 168/512} };
   --image_small = { "H_Militia_RU", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "H_Militia_RU", {384/512, 395/512, 512/512, 512/512} };
   image_large = { "H_Militia", {0, 0, 364/512, 1} };
   image_medium = { "H_Militia", {392/512, 0, 512/512, 168/512} };
   image_small = { "H_Militia", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "H_Militia", {384/512, 395/512, 512/512, 512/512} };
}

g_ascension_cards["Apprentice RU"] = {
	card_name = "Apprentice RU";
	display_name = "Apprentice";
    card_set = "RU";
	card_type = "Hero";
	rune_cost = 0;
   do_not_put_in_void = true;
	effect = { "GainRunes", 1 };
	effect_text = "Gain 1R.";
   
   ai = {
      trivial = true,
      preferred_discard = true;
      preferred_banish = true;

      gain_rune = 1;
   },

   --image_large = { "H_Apprentice_RU", {0, 0, 364/512, 1} };
   --image_medium = { "H_Apprentice_RU", {392/512, 0, 512/512, 168/512} };
   --image_small = { "H_Apprentice_RU", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "H_Apprentice_RU", {384/512, 395/512, 512/512, 512/512} };
   image_large = { "H_Apprentice", {0, 0, 364/512, 1} };
   image_medium = { "H_Apprentice", {392/512, 0, 512/512, 168/512} };
   image_small = { "H_Apprentice", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "H_Apprentice", {384/512, 395/512, 512/512, 512/512} };
}

g_ascension_cards["Mystic RU"] = {
	card_name = "Mystic RU";
   display_name = "Mystic";
    card_set = "RU";
	card_type = "Hero";
	rune_cost = 3;
	honor = 1;
   do_not_put_in_void = true;
	effect = { "GainRunes", 2 };
	effect_text = "Gain 2R.";
   
   ai = {
      trivial = true,

      gain_rune = 2;
   },

   --image_large = { "H_Mystic_RU", {0, 0, 364/512, 1} };
   --image_medium = { "H_Mystic_RU", {392/512, 0, 512/512, 168/512} };
   --image_small = { "H_Mystic_RU", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "H_Mystic_RU", {384/512, 395/512, 512/512, 512/512} };
   image_large = { "H_Mystic", {0, 0, 364/512, 1} };
   image_medium = { "H_Mystic", {392/512, 0, 512/512, 168/512} };
   image_small = { "H_Mystic", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "H_Mystic", {384/512, 395/512, 512/512, 512/512} };
}

g_ascension_cards["Heavy Infantry RU"] = {
	card_name = "Heavy Infantry RU";
   display_name = "Heavy Infantry";
    card_set = "RU";
	card_type = "Hero";
	rune_cost = 2;
	honor = 1;
   do_not_put_in_void = true;
	effect = { "GainPower", 2 };
	effect_text = "Gain 2P.";
   
   ai = {
      trivial = true,
      gain_power = 2;
   },

   --image_large = { "H_HeavyInfantry_RU", {0, 0, 364/512, 1} };
   --image_medium = { "H_HeavyInfantry_RU", {392/512, 0, 512/512, 168/512} };
   --image_small = { "H_HeavyInfantry_RU", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "H_HeavyInfantry_RU", {384/512, 395/512, 512/512, 512/512} };
   image_large = { "H_HeavyInfantry", {0, 0, 364/512, 1} };
   image_medium = { "H_HeavyInfantry", {392/512, 0, 512/512, 168/512} };
   image_small = { "H_HeavyInfantry", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "H_HeavyInfantry", {384/512, 395/512, 512/512, 512/512} };
}

g_ascension_cards["Cultist RU"] = {
	card_name = "Cultist RU";
   display_name = "Cultist";
    card_set = "RU";
	card_type = "Monster";
	power_cost = 2;
   do_not_put_in_void = true;
	reward = { "GainHonor", 1 };
	effect_text = "Reward: Gain 1H.";

   --image_large = { "M_Cultist_RU", {0, 0, 364/512, 1} };
   --image_medium = { "M_Cultist_RU", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_Cultist_RU", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_Cultist_RU", {384/512, 395/512, 512/512, 512/512} };
   image_large = { "M_Cultist", {0, 0, 364/512, 1} };
   image_medium = { "M_Cultist", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_Cultist", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_Cultist", {384/512, 395/512, 512/512, 512/512} };
}




g_ascension_active_effects["acquire or defeat center deck for enlightened hero played"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayEnlightenedHero", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerMultiUnite", 0 },
		{ "TriggerAcquireOrDefeatTopOfCenterDeck", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

g_ascension_cards["Dhartha, the Eternal"] = {
	card_name = "Dhartha, the Eternal";
    card_set = "RU";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 7;
	honor = 5;

	effects = {
      { "AcquireOrDefeatTopOfCenterDeck", 0 },
      { "MultiUnite_MayAcquireOrDefeatCenterDeckForEnlightenedHeroPlayed", 1 },
   };
   
	effect_text = "Reveal the top card of the center deck. " ..
                  "Acquire or defeat that card without paying its cost.\n" ..
                  "MULTI-UNITE: You may repeat this.";

   ai = {
   },
   
   image_large = { "EH_DharthaEternal", {0, 0, 364/512, 1} };
   image_medium = { "EH_DharthaEternal", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_DharthaEternal", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_DharthaEternal", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Journeyman Outrider"] = {
	card_name = "Journeyman Outrider";
    card_set = "RU";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 3;
	honor = 1;

	effects = {
		{ "AcquireHeroOrConstructWithCostLessThan", 5 },
   };
   
	effect_text = "Acquire a Hero or Construct with cost 5R or less without paying its cost.";

   ai = {
   },
   
   image_large = { "EH_JourneymanOutrider", {0, 0, 364/512, 1} };
   image_medium = { "EH_JourneymanOutrider", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_JourneymanOutrider", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_JourneymanOutrider", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_active_effects["choose faction for played mystic or heavy infantry"] = {
	type = "triggered";
   priority = 5;
	conditions = {
		{ "BeforeYouPlayMysticOrHeavyInfantry", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerEffectPlayerChooseFactionForPlayedCard", 0 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}


g_ascension_cards["Neophyte Mentor"] = {
	card_name = "Neophyte Mentor";
    card_set = "RU";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 4;
	honor = 2;

	effects = {
		{ "DrawCards", 1 },
      { "ChooseFactionForNextPlayedMysticOrHeavyInfantry", 0 },
   };
   
	effect_text = "Draw a card.\n" ..
                  "The next Mystic or Heavy Infantry you play this turn counts as a faction of your choice.";

   ai = {
   },
   
   image_large = { "EH_NeophyteMentor", {0, 0, 364/512, 1} };
   image_medium = { "EH_NeophyteMentor", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_NeophyteMentor", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_NeophyteMentor", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


--[[
g_ascension_active_effects["banish to upgrade for enlightened hero played"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayEnlightenedHero", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerMultiUnite", 0 },
		{ "TriggerAddBanishFromHandToUpgradeCount", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

g_ascension_cards["Sage of Lucid Dreams"] = {
	card_name = "Sage of Lucid Dreams";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 4;
	honor = 2;

	effects = {
      { "AddBanishFromHandToUpgradeCount", 1 },
      { "MultiUnite_BanishFromHandToUpgradeForEachEnlightenedHeroPlayed", 1 },
   };
   
	effect_text = "Once this turn, banish a card in your hand. " ..
                  "If you do, acquire a Hero with H value up to one more than that of the banished card " ..
                  "and put it in your hand.\n" ..
                  "MULTI-UNITE: You may repeat this.";

   ai = {
   },
   
   image_large = { "EH_SageLucidDreams", {0, 0, 364/512, 1} };
   image_medium = { "EH_SageLucidDreams", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_SageLucidDreams", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_SageLucidDreams", {384/512, 395/512, 512/512, 512/512} };
   
}
]]


g_ascension_active_effects["defeat monster for enlightened hero played"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayEnlightenedHero", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerMultiUnite", 0 },
		{ "TriggerDefeatMonsterWithLessPower", 4 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

g_ascension_cards["Oziah's Familiar"] = {
	card_name = "Oziah's Familiar";
    card_set = "RU";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 4;
	honor = 2;

   effects = {
		{ "DefeatMonsterWithLessPower", 4  },
      { "MultiUnite_DefeatMonsterLessPowerForEachEnlightenedHeroPlayed", 4 },
	};

	effect_text = "Defeat a Monster with cost 4P or less without paying its cost.\n" ..
                  "MULTI-UNITE: Repeat this effect.";

   ai = {
   },
   
   image_large = { "EH_OziahsFamiliar", {0, 0, 364/512, 1} };
   image_medium = { "EH_OziahsFamiliar", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_OziahsFamiliar", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_OziahsFamiliar", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Scryer of the Lidless Eye"] = {
	card_name = "Scryer of the Lidless Eye";
    card_set = "RU";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 4;
	honor = 2;

	effects = {
		{ "DrawCards", 2 },
		{ "DiscardFromHand", 0 },
		{ "ReturnEffectInstanceDataFromDiscardToHand", 1, condition={"IfEffectInstanceDataIsEnlightened",1} },

   };
   
	effect_text = "Draw two card, then discard a card. " ..
                  "If the discarded card is Enlightened, return it to your hand.";

   ai = {
   },
   
   image_large = { "EH_ScryerLidlessEye", {0, 0, 364/512, 1} };
   image_medium = { "EH_ScryerLidlessEye", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_ScryerLidlessEye", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_ScryerLidlessEye", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}



g_ascension_cards["Disciple of Oziah"] = {
	card_name = "Disciple of Oziah";
    card_set = "RU";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 1;
	honor = 1;

	effects = {
      { "DefeatMonsterWithLessPower", 3 },
   };
   transform = {
      usageconditions = {
         { "IfPlayedEnlightenedHero", 1 },
      },
      { "PauseForAnimation", 0 },
      { "TransformIntoScionOfOziah", 0 },
   };
   transform_into = "Scion of Oziah";

	effect_text = "While this is in your hand, if you have played another Enlightened Hero this turn, " ..
                  "transform this into Scion of Oziah.\n" ..
                  "Defeat a Monster with cost 3P or less without paying its cost.";

   ai = {
   },
   
   image_large = { "EH_DiscipleOziah", {0, 0, 364/512, 1} };
   image_medium = { "EH_DiscipleOziah", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_DiscipleOziah", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_DiscipleOziah", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Scion of Oziah"] = {
	card_name = "Scion of Oziah";
    card_set = "RU";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 1;
	honor = 2;

   transform_from = "Disciple of Oziah";

	effects = {
      { "DefeatMonsterWithLessPower", 5 },
   };
   
	effect_text = "Defeat a Monster with cost 5P or less without paying its cost.";

   ai = {
   },
   
   image_large = { "EH_ScionOziah", {0, 0, 364/512, 1} };
   image_medium = { "EH_ScionOziah", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_ScionOziah", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_ScionOziah", {384/512, 395/512, 512/512, 512/512} };

   --rarity_count = 2
}



g_ascension_cards["Vir, Ascetic Master"] = {
	card_name = "Vir, Ascetic Master";
    card_set = "RU";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 8;
	honor = 6;

	effects = {
      { "AcquireHeroFromCenterRowIntoHand", 0 },
   };
   transform = {
      usageconditions = {
         { "IfPlayedHeroOfEveryFaction", 1 },
      },
      { "PauseForAnimation", 0 },
      { "TransformIntoVirEphemeralGuru", 0 },
   };
   transform_into = "Vir, Ephemeral Guru";

	effect_text = "While this is in your hand, if you have played a Hero of every faction this turn, " ..
                  "transform this into Vir, Ephemeral Guru.\n" ..
                  "Acquire a Hero in the center row without paying its cost and put it in your hand.";

   ai = {
   },
   
   image_large = { "EH_VirAsceticMaster", {0, 0, 364/512, 1} };
   image_medium = { "EH_VirAsceticMaster", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_VirAsceticMaster", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_VirAsceticMaster", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Vir, Ephemeral Guru"] = {
	card_name = "Vir, Ephemeral Guru";
    card_set = "RU";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 8;
	honor = 7;

   transform_from = "Vir, Ascetic Master";

	effects = {
      { "AcquireAllCenterRowHeroesToHand", 0 },
   };
   
	effect_text = "Acquire all Heroes in the center row without paying their costs " ..
                  "and put them in your hand.";

   ai = {
   },
   
   image_large = { "EH_VirEphemeralGuru", {0, 0, 364/512, 1} };
   image_medium = { "EH_VirEphemeralGuru", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_VirEphemeralGuru", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_VirEphemeralGuru", {384/512, 395/512, 512/512, 512/512} };

   --rarity_count = 1
}


g_ascension_cards["Forgotten Scripture"] = {
	card_name = "Forgotten Scripture";
    card_set = "RU";
	card_type = "Construct";
	faction = "Enlightened";
	rune_cost = 4;
	honor = 3;

	construct_abilities = {
		{
         description = "Transform";
			condition = { "IfPlayedEnlightenedHero", 2 },
         { "PushResolvingConstruct", 0 },
         { "PauseForAnimation", 0 },
         { "TransformThisConstructIntoMantraOfTrueSight", 0 },
         
         ai = {
            trivial = true,
         },
		},
	};
   transform_into = "Mantra of True Sight";

	effect_text = "If you have played two of more Enlightened Heroes this turn, " ..
                  "transform this into Mantra of True Sight.";

   ai = {
   },
   
   image_large = { "EC_ForgottenScripture", {0, 0, 364/512, 1} };
   image_medium = { "EC_ForgottenScripture", {392/512, 0, 512/512, 168/512} };
   image_small = { "EC_ForgottenScripture", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EC_ForgottenScripture", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Mantra of True Sight"] = {
	card_name = "Mantra of True Sight";
    card_set = "RU";
	card_type = "Construct";
	faction = "Enlightened";
	rune_cost = 4;
	honor = 4;

   transform_from = "Forgotten Scripture";

	construct_ability = {
		description = "Draw a card";
		{ "DrawCards", 1 },
      
      ai = {
         trivial_draw = 1,

         gain_draw = 1,
      },
	};
   
   ai = {
      trivial_draw = 1,

      gain_draw = 1,
   },

	effect_text = "Once per turn, you may draw a card.";

   image_large = { "EC_MantraTrueSight", {0, 0, 364/512, 1} };
   image_medium = { "EC_MantraTrueSight", {392/512, 0, 512/512, 168/512} };
   image_small = { "EC_MantraTrueSight", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EC_MantraTrueSight", {384/512, 395/512, 512/512, 512/512} };

   --rarity_count = 2
}






g_ascension_cards["Animus of the Wild"] = {
	card_name = "Animus of the Wild";
    card_set = "RU";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 4;
	honor = 2;

	effects = {
		{ "GainRunes", 2 },
      { "NextHeroYouAcquireCostsLess", 1 },
	};

	effect_text = "Gain 2R.\n" ..
                  "You pay 1R less the next time you acquire a Hero this turn.";

   ai = {
   },
   
   image_large = { "LH_AnimusWild", {0, 0, 364/512, 1} };
   image_medium = { "LH_AnimusWild", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_AnimusWild", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_AnimusWild", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_active_effects["acquire hero for lifebound hero played"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayLifeboundHero", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerMultiUnite", 0 },
		{ "TriggerEffectPlayerMayAcquireHeroToTopOfDeck", 0 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

g_ascension_cards["Cetra, Matron of Stars"] = {
	card_name = "Cetra, Matron of Stars";
    card_set = "RU";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 7;
	honor = 4;

	effects = {
      { "AcquireHeroToTopOfDeck", 0 },
      { "MultiUnite_AcquireHeroToTopOfDeckForEachLifeboundHeroPlayed", 0 },
   };
   
	effect_text = "Once this turn, acquire a Hero without paying its cost. " ..
                  "Put it on top of your deck.\n" ..
                  "MULTI-UNITE: You may repeat this.";

   ai = {
   },
   
   image_large = { "LH_CetraMatronStars", {0, 0, 364/512, 1} };
   image_medium = { "LH_CetraMatronStars", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_CetraMatronStars", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_CetraMatronStars", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_active_effects["mu_gain 1 honor for lifebound hero played"] = {
   type = "triggered";
   conditions = {
      { "WhenYouPlayLifeboundHero", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerMultiUnite", 0 },
      { "TriggerGainHonor", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}

g_ascension_cards["Everbloom Clique"] = {
	card_name = "Everbloom Clique";
    card_set = "RU";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 2;
	honor = 1;

	effects = {
		{ "GainHonor", 2 },
		{ "MultiUnite_GainHonorForEachLifeboundHeroPlayed", 1 },
   };
   
	effect_text = "Gain 2H.\n" ..
                  "MULTI-UNITE: Gain 1H.";

   ai = {
   },
   
   image_large = { "LH_EverbloomClique", {0, 0, 364/512, 1} };
   image_medium = { "LH_EverbloomClique", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_EverbloomClique", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_EverbloomClique", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Snapdragon Witch"] = {
	card_name = "Snapdragon Witch";
    card_set = "RU";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 5;
	honor = 3;

	effects = {
		{ "GainHonor", 1 },
		{ "DrawCards", 1 },
		{ "DrawCards", 1, condition={"IfYouHaveMoreHonorThanOpponents",0} },
   };
   
	effect_text = "Gain 1H.\n" ..
                  "Draw a card.\n" ..
                  "If you have more H than every other player, draw an additional card.";

   ai = {
   },
   
   image_large = { "LH_SnapdragonWitch", {0, 0, 364/512, 1} };
   image_medium = { "LH_SnapdragonWitch", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_SnapdragonWitch", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_SnapdragonWitch", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Wolf Shaman RU"] = {
	card_name = "Wolf Shaman RU";
	display_name = "Wolf Shaman";
    card_set = "RU";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 3;
	honor = 1;

	effects = {
		{ "GainRunes", 1 },
		{ "DrawCards", 1 },
	};
   
	effect_text = "Gain 1R.\n" ..
                  "Draw a card.";

   ai = {
      trivial_draw = 1,

      gain_rune = 1;
      gain_draw = 1;
   },

   --image_large = { "LH_WolfShaman_RU", {0, 0, 364/512, 1} };
   --image_medium = { "LH_WolfShaman_RU", {392/512, 0, 512/512, 168/512} };
   --image_small = { "LH_WolfShaman_RU", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "LH_WolfShaman_RU", {384/512, 395/512, 512/512, 512/512} };
   image_large = { "LH_WolfShaman", {0, 0, 364/512, 1} };
   image_medium = { "LH_WolfShaman", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_WolfShaman", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_WolfShaman", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Disciple of Cetra"] = {
	card_name = "Disciple of Cetra";
	card_type = "Hero";
    card_set = "RU";
	faction = "Lifebound";
	rune_cost = 1;
	honor = 1;

	effects = {
		{ "GainRunes", 1 },
		{ "GainHonor", 1 },
   };
   transform = {
      usageconditions = {
         { "IfPlayedLifeboundHero", 1 },
      },
      { "PauseForAnimation", 0 },
      { "TransformIntoScionOfCetra", 0 },
   };
   transform_into = "Scion of Cetra";

	effect_text = "While this is in your hand, if you have played another Lifebound Hero this turn, " ..
                  "transform this into Scion of Cetra.\n" ..
                  "Gain 1R and 1H.";

   ai = {
      trivial = true,

      gain_rune = 1;
      gain_honor = 1;
   },
   
   image_large = { "LH_DiscipleCetra", {0, 0, 364/512, 1} };
   image_medium = { "LH_DiscipleCetra", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_DiscipleCetra", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_DiscipleCetra", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Scion of Cetra"] = {
	card_name = "Scion of Cetra";
	card_type = "Hero";
    card_set = "RU";
	faction = "Lifebound";
	rune_cost = 1;
	honor = 2;

   transform_from = "Disciple of Cetra";

	effects = {
		{ "GainRunes", 2 },
		{ "GainHonor", 2 },
   };
   
	effect_text = "Gain 2R and 2H.";

   ai = {
      trivial = true,

      gain_rune = 1;
      gain_honor = 1;
   },
   
   image_large = { "LH_ScionCetra", {0, 0, 364/512, 1} };
   image_medium = { "LH_ScionCetra", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_ScionCetra", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_ScionCetra", {384/512, 395/512, 512/512, 512/512} };

   --rarity_count = 2
}



g_ascension_cards["Remus, Pack Guardian"] = {
	card_name = "Remus, Pack Guardian";
	card_type = "Hero";
    card_set = "RU";
	faction = "Lifebound";
	rune_cost = 6;
	honor = 3;

   transform = {
      usageconditions = {
         { "IfHasGainedHonorThisTurn", 3 },
      },
      { "PauseForAnimation", 0 },
      { "TransformIntoRemusWildEmissary", 0 },
   };
	effects = {
		{ "GainRunes", 3 },
   };
   transform_into = "Remus, Wild Emissary";

	effect_text = "While this is in your hand, if you have gained 3H or more this turn, " ..
                  "transform this into Remus, Wild Emissary.\n" ..
                  "Gain 3R.";

   ai = {
   },
   
   image_large = { "LH_RemusPackGuardian", {0, 0, 364/512, 1} };
   image_medium = { "LH_RemusPackGuardian", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_RemusPackGuardian", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_RemusPackGuardian", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Remus, Wild Emissary"] = {
	card_name = "Remus, Wild Emissary";
	card_type = "Hero";
    card_set = "RU";
	faction = "Lifebound";
	rune_cost = 6;
	honor = 4;

   transform_from = "Remus, Pack Guardian";

	effects = {
		{ "GainRunes", 3 },
      { "UseRunesAsPowerUntilEndOfTurn", 0 }
   };
   
	effect_text = "Gain 3R.\n" ..
                  "You may spend R as through it was P this turn.";

   ai = {
   },
   
   image_large = { "LH_RemusWildEmissary", {0, 0, 364/512, 1} };
   image_medium = { "LH_RemusWildEmissary", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_RemusWildEmissary", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_RemusWildEmissary", {384/512, 395/512, 512/512, 512/512} };

   --rarity_count = 1
}


g_ascension_cards["Druid's Wreath"] = {
	card_name = "Druid's Wreath";
    card_set = "RU";
	card_type = "Construct";
	faction = "Lifebound";
	rune_cost = 4;
	honor = 3;

	construct_abilities = {
		{
         description = "Transform";
			condition = { "IfPlayedLifeboundHero", 2 },
         { "PushResolvingConstruct", 0 },
         { "PauseForAnimation", 0 },
         { "TransformThisConstructIntoVerdantCrown", 0 },
         
         ai = {
            trivial = true,
         },
		},
	};
   transform_into = "Verdant Crown";

	effect_text = "If you have played two or more Lifebound Heroes this turn, " ..
                  "transform this into Verdant Crown.";

   ai = {
   },
   
   image_large = { "LC_DruidsWreath", {0, 0, 364/512, 1} };
   image_medium = { "LC_DruidsWreath", {392/512, 0, 512/512, 168/512} };
   image_small = { "LC_DruidsWreath", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LC_DruidsWreath", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Verdant Crown"] = {
	card_name = "Verdant Crown";
    card_set = "RU";
	card_type = "Construct";
	faction = "Lifebound";
	rune_cost = 4;
	honor = 4;

   transform_from = "Druid's Wreath";

	construct_ability = {
		description = "Gain 2H";
		{ "GainHonor", 2 },
      
      ai = {
         trivial = true,
      },
   };

	effect_text = "Once per turn, gain 2H.";

   ai = {
   },
   
   image_large = { "LC_VerdantCrown", {0, 0, 364/512, 1} };
   image_medium = { "LC_VerdantCrown", {392/512, 0, 512/512, 168/512} };
   image_small = { "LC_VerdantCrown", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LC_VerdantCrown", {384/512, 395/512, 512/512, 512/512} };

   --rarity_count = 2
}









g_ascension_cards["Air Support Squadron"] = {
	card_name = "Air Support Squadron";
    card_set = "RU";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 6;
	honor = 6;

   continuous_effects = {
      {
         effect = { "MayPutAcquiredMechanaCardIntoHandOncePerTurn", 0 };
      },
   };

	effect_text = "Once per turn, when you acquire a Mechana card, you may put it in your hand.";

   ai = {
   },
   
   image_large = { "MC_AirSupportSquadron", {0, 0, 364/512, 1} };
   image_medium = { "MC_AirSupportSquadron", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_AirSupportSquadron", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_AirSupportSquadron", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_cards["Defense Generator"] = {
	card_name = "Defense Generator";
    card_set = "RU";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 3;
	honor = 3;

	triggered_effects = {
		{
			conditions = {
				{ "WhenConstructOwnerAcquiresOtherMechanaCard", 0 },
				{ "IfThisHasntBeenUsedThisTurn", 0 },
			};
			triggereffect = {
				{ "TriggerConstructGainPowerIfThisHasntBeenUsed", 2 },
				{ "TriggerSetThisHasBeenUsedThisTurn", 0 },
			};
		},
	};

	effect_text = "Once per turn, when you acquire a Mechana card, gain 2P.";

   ai = {
   },
   
   image_large = { "MC_DefenseGenerator", {0, 0, 364/512, 1} };
   image_medium = { "MC_DefenseGenerator", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_DefenseGenerator", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_DefenseGenerator", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Hedron Watchtower"] = {
	card_name = "Hedron Watchtower";
    card_set = "RU";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 5;
	honor = 5;

	triggered_effects = {
		{
			conditions = {
				{ "WhenConstructOwnerAcquiresOtherMechanaCard", 0 },
				{ "IfThisHasntBeenUsedThisTurn", 0 },
			};
			triggereffect = {
				{ "TriggerGainHonorForAcquiredCardIfThisHasntBeenUsed", 0 },
				{ "TriggerSetThisHasBeenUsedThisTurn", 0 },
			};
		},
	};
   
	effect_text = "Once per turn, when you acquire a Mechana card, gain H equal to that card's H value.";

   ai = {
   },
   
   image_large = { "MC_HedronWatchtower", {0, 0, 364/512, 1} };
   image_medium = { "MC_HedronWatchtower", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_HedronWatchtower", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_HedronWatchtower", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_active_effects["gain 1 rune for mechana hero played"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayMechanaHero", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerMultiUnite", 0 },
		{ "TriggerGainRunes", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

g_ascension_cards["Matron of Discovery"] = {
	card_name = "Matron of Discovery";
    card_set = "RU";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 3;
	honor = 2;

	effects = {
		{ "GainRunes", 2 },
		{ "MultiUnite_GainRuneForEachMechanaHeroPlayed", 1 },
   };

	effect_text = "Gain 2R.\n" ..
                  "MULTI-UNITE: Gain 1R.";

   ai = {
   },
   
   image_large = { "MH_MatronDiscovery", {0, 0, 364/512, 1} };
   image_medium = { "MH_MatronDiscovery", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_MatronDiscovery", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_MatronDiscovery", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Upgrade Foundry"] = {
	card_name = "Upgrade Foundry";
    card_set = "RU";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 7;
	honor = 7;

	triggered_effects = {
		{
			conditions = {
				{ "WhenConstructOwnerAcquiresOtherMechanaCard", 0 },
				{ "IfThisHasntBeenUsedThisTurn", 0 },
			};
			triggereffect = {
				{ "TriggerConstructOwnerDrawCardsIfThisHasntBeenUsed", 2 },
				{ "TriggerSetThisHasBeenUsedThisTurn", 0 },
			};
		},
	};

	effect_text = "Once per turn, when you acquire a Mechana card, draw two cards.";

   ai = {
   },
   
   image_large = { "MC_UpgradeFoundry", {0, 0, 364/512, 1} };
   image_medium = { "MC_UpgradeFoundry", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_UpgradeFoundry", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_UpgradeFoundry", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Workshop Gargoyle"] = {
	card_name = "Workshop Gargoyle";
    card_set = "RU";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 2;
	honor = 2;

	triggered_effects = {
		{
			conditions = {
				{ "WhenConstructOwnerAcquiresOtherMechanaCard", 0 },
				{ "IfThisHasntBeenUsedThisTurn", 0 },
			};
			triggereffect = {
				{ "TriggerConstructGainHonorIfThisHasntBeenUsed", 1 },
				{ "TriggerSetThisHasBeenUsedThisTurn", 0 },
			};
		},
	};
   
	effect_text = "Once per turn, when you acquire a Mechana card, gain 1H.";

   ai = {
   },
   
   image_large = { "MC_WorkshopGargoyle", {0, 0, 364/512, 1} };
   image_medium = { "MC_WorkshopGargoyle", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_WorkshopGargoyle", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_WorkshopGargoyle", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}




g_ascension_cards["Disciple of Euloth"] = {
	card_name = "Disciple of Euloth";
    card_set = "RU";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 1;
	honor = 1;

	effects = {
		{ "GainRunes", 1 },
		{ "GainPower", 1 },
   };
   transform = {
      usageconditions = {
         { "IfPlayedMechanaHero", 1 },
      },
      { "PauseForAnimation", 0 },
      { "TransformIntoScionOfEuloth", 0 },
   };
   transform_into = "Scion of Euloth";

	effect_text = "While this is in your hand, if you have played another Mechana Hero this turn, " ..
                  "transform this into Scion of Euloth.\n" ..
                  "Gain 1R and 1P.";

   ai = {
   },
   
   image_large = { "MH_DiscipleEuloth", {0, 0, 364/512, 1} };
   image_medium = { "MH_DiscipleEuloth", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_DiscipleEuloth", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_DiscipleEuloth", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Scion of Euloth"] = {
	card_name = "Scion of Euloth";
    card_set = "RU";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 1;
	honor = 2;

   transform_from = "Disciple of Euloth";

	effects = {
		{ "GainRunes", 2 },
		{ "GainPower", 2 },
   };
   
	effect_text = "Gain 2R and 2P.";

   ai = {
   },
   
   image_large = { "MH_ScionEuloth", {0, 0, 364/512, 1} };
   image_medium = { "MH_ScionEuloth", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_ScionEuloth", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_ScionEuloth", {384/512, 395/512, 512/512, 512/512} };

   --rarity_count = 2
}






g_ascension_cards["Alset, Monk Prodigy"] = {
	card_name = "Alset, Monk Prodigy";
    card_set = "RU";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 6;
	honor = 3;

	effects = {
		{ "GainRunes", 3 },
   };
   transform = {
      usageconditions = {
         { "IfYouControlConstructs", 2 },
      },
      { "PauseForAnimation", 0 },
      { "TransformIntoAlsetReactorSavant", 0 },
   };
   transform_into = "Alset, Reactor Savant";

	effect_text = "While this is in your hand, if you control 2 or more Constructs, " ..
                  "transform this into Alset, Reactor Savant.\n" ..
                  "Gain 3R.";

   ai = {
   },
   
   image_large = { "MH_AlsetMonkProdigy", {0, 0, 364/512, 1} };
   image_medium = { "MH_AlsetMonkProdigy", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_AlsetMonkProdigy", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_AlsetMonkProdigy", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_active_effects["may acquire constructs into play"] = {
	type = "continuous";
	effectfunc = { "MayAcquireConstructsIntoPlay", 1 };
}

g_ascension_cards["Alset, Reactor Savant"] = {
	card_name = "Alset, Reactor Savant";
    card_set = "RU";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 6;
	honor = 4;

   transform_from = "Alset, Monk Prodigy";

	effects = {
		{ "GainRunes", 4 },
      { "ContructsYouAcquireMayGoIntoPlayThisTurn", 0 },
   };
   
	effect_text = "Gain 4R.\n" ..
                  "When you acquire a Construct this turn, you may put it into play.";

   ai = {
   },
   
   image_large = { "MH_AlsetReactorSavant", {0, 0, 364/512, 1} };
   image_medium = { "MH_AlsetReactorSavant", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_AlsetReactorSavant", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_AlsetReactorSavant", {384/512, 395/512, 512/512, 512/512} };

   --rarity_count = 1
}




g_ascension_cards["Secluded Laboratory"] = {
	card_name = "Secluded Laboratory";
    card_set = "RU";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 4;
	honor = 4;

	construct_abilities = {
		{
         description = "Transform";
			condition = { "IfPlayedMechanaHero", 2 },
         { "PushResolvingConstruct", 0 },
         { "PauseForAnimation", 0 },
         { "TransformThisConstructIntoZeroPointReactor", 0 },
         
         ai = {
            trivial = true,
         },
		},
	};
   transform_into = "Zero Point Reactor";

	effect_text = "If you have played two or more Mechana Heroes, " ..
                  "transform this into Zero Point Reactor.";

   ai = {
   },
   
   image_large = { "MC_SecludedLaboratory", {0, 0, 364/512, 1} };
   image_medium = { "MC_SecludedLaboratory", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_SecludedLaboratory", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_SecludedLaboratory", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Zero Point Reactor"] = {
	card_name = "Zero Point Reactor";
    card_set = "RU";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 4;
	honor = 5;

   transform_from = "Secluded Laboratory";

	construct_ability = {
		description = "Gain 2R";
		{ "GainRunes", 2 },
      
      ai = {
         trivial = true,
      },
	};

	effect_text = "Once per turn, gain 2R.";

   ai = {
   },
   
   image_large = { "MC_ZeroPointReactor", {0, 0, 364/512, 1} };
   image_medium = { "MC_ZeroPointReactor", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_ZeroPointReactor", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_ZeroPointReactor", {384/512, 395/512, 512/512, 512/512} };

   --rarity_count = 2
}










g_ascension_active_effects["banish from discard for void hero played"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayVoidHero", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerMultiUnite", 0 },
		{ "TriggerEffectPlayerBanishFromDiscard", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

g_ascension_cards["Black Watch Exemplar"] = {
	card_name = "Black Watch Exemplar";
    card_set = "RU";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 5;
	honor = 3;

	effects = {
		{ "GainPower", 3 },
		{ "MultiUnite_BanishFromDiscardForEachVoidHeroPlayed", 1 },
   };
   
	effect_text = "Gain 3P.\n" ..
                  "MULTI-UNITE: You may banish a card in your discard pile.";

   ai = {
   },
   
   image_large = { "VH_BlackWatchExemplar", {0, 0, 364/512, 1} };
   image_medium = { "VH_BlackWatchExemplar", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_BlackWatchExemplar", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_BlackWatchExemplar", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_active_effects["gain 1 power for void hero played"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayVoidHero", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerMultiUnite", 0 },
		{ "TriggerGainPower", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

g_ascension_cards["Deathdealer Noble"] = {
	card_name = "Deathdealer Noble";
    card_set = "RU";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 3;
	honor = 2;

	effects = {
		{ "GainPower", 2 },
		{ "MultiUnite_GainPowerForEachVoidHeroPlayed", 1 },
   };
   
	effect_text = "Gain 2P.\n" ..
                  "MULTI-UNITE: Gain 1P.";

   ai = {
   },
   
   image_large = { "VH_DeathdealerNoble", {0, 0, 364/512, 1} };
   image_medium = { "VH_DeathdealerNoble", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_DeathdealerNoble", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_DeathdealerNoble", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}



g_ascension_cards["Shadow Stalker"] = {
	card_name = "Shadow Stalker";
    card_set = "RU";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 3;
	honor = 1;

	effects = {
		{ "BanishFromDiscard", 1 },
		{ "DrawCards", 1 },
   };
   
	effect_text = "You may banish a card in your discard pile.\n" ..
                  "Draw a card.";

   ai = {
      trivial_draw = 1,

      gain_draw = 1,
   },
   
   image_large = { "VH_ShadowStalker", {0, 0, 364/512, 1} };
   image_medium = { "VH_ShadowStalker", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_ShadowStalker", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_ShadowStalker", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Spike Vixen RU"] = {
	card_name = "Spike Vixen RU";
   display_name = "Spike Vixen";
    card_set = "RU";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 2;
	honor = 1;

	effects = {
		{ "GainPower", 1 },
		{ "DrawCards", 1 },
	};

	effect_text = "Gain 1P.\n" ..
                  "Draw a card.";

   ai = {
      trivial_draw = 1,

      gain_power = 1,
      gain_draw = 1,
   },

   image_large = { "VH_SpikeVixen", {0, 0, 364/512, 1} };
   image_medium = { "VH_SpikeVixen", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_SpikeVixen", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_SpikeVixen", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}



g_ascension_cards["Disciple of Emri"] = {
	card_name = "Disciple of Emri";
    card_set = "RU";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 1;
	honor = 1;

	effects = {
		{ "GainPower", 1 },
		{ "BanishFromDiscard", 1 },
   };
   transform = {
      usageconditions = {
         { "IfPlayedVoidHero", 1 },
      },
      { "PauseForAnimation", 0 },
      { "TransformIntoScionOfEmri", 0 },
   };
   transform_into = "Scion of Emri";

	effect_text = "While this is in your hand, if you have played another Void Hero this turn, " ..
                  "transform this into Scion of Emri.\n" ..
                  "Gain 1P.\n" ..
                  "You may banish a card in your discard pile.";

   ai = {
   },
   
   image_large = { "VH_DiscipleEmri", {0, 0, 364/512, 1} };
   image_medium = { "VH_DiscipleEmri", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_DiscipleEmri", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_DiscipleEmri", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Scion of Emri"] = {
	card_name = "Scion of Emri";
    card_set = "RU";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 1;
	honor = 2;

   transform_from = "Disciple of Emri";

	effects = {
		{ "GainPower", 3 },
		{ "BanishFromDiscard", 1 },
   };
   
	effect_text = "Gain 3P.\n" ..
                  "You may banish a card in your discard pile.";

   ai = {
   },
   
   image_large = { "VH_ScionEmri", {0, 0, 364/512, 1} };
   image_medium = { "VH_ScionEmri", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_ScionEmri", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_ScionEmri", {384/512, 395/512, 512/512, 512/512} };

   --rarity_count = 2
}

g_ascension_cards["Emri, the Unmaker"] = {
	card_name = "Emri, the Unmaker";
    card_set = "RU";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 7;
	honor = 5;

	effects = {
		{ "GainPower", 4 },
   };
   transform = {
      usageconditions = {
         { "IfThereAreMonstersInVoid", 8 },
      },
      { "PauseForAnimation", 0 },
      { "TransformIntoEmriDemonsbane", 0 },
   };
   transform_into = "Emri, Demonsbane";

	effect_text = "While this is in your hand, if there are 8 or more Monsters in the Void, " ..
                  "transform this into Emri, Demonsbane.\n" ..
                  "Gain 4P.";

   ai = {
   },
   
   image_large = { "VH_EmriUnmaker", {0, 0, 364/512, 1} };
   image_medium = { "VH_EmriUnmaker", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_EmriUnmaker", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_EmriUnmaker", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_cards["Emri, Demonsbane"] = {
	card_name = "Emri, Demonsbane";
    card_set = "RU";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 7;
	honor = 6;

   transform_from = "Emri, the Unmaker";

	effects = {
		{ "GainPower", 5 },
      { "MayDefeatMonstersFromVoidUntilEndOfTurn", 0 },
   };
   
	effect_text = "Gain 5P.\n" ..
                  "This turn, you may defeat Monsters in the Void as through they were in the center row. " ..
                  "Put Monsters defeated this way on the bottom of the center deck.";

   ai = {
   },
   
   image_large = { "VH_EmriDemonsbane", {0, 0, 364/512, 1} };
   image_medium = { "VH_EmriDemonsbane", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_EmriDemonsbane", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_EmriDemonsbane", {384/512, 395/512, 512/512, 512/512} };

   --rarity_count = 1
}

g_ascension_cards["Initiate's Gauntlets"] = {
	card_name = "Initiate's Gauntlets";
    card_set = "RU";
	card_type = "Construct";
	faction = "Void";
	rune_cost = 4;
	honor = 3;

	construct_abilities = {
		{
         description = "Transform";
			condition = { "IfPlayedVoidHero", 2 },
         { "PushResolvingConstruct", 0 },
         { "PauseForAnimation", 0 },
         { "TransformThisConstructIntoClutchOfDarkness", 0 },
         
         ai = {
            trivial = true,
         },
		},
	};
   transform_into = "Clutch of Darkness";

	effect_text = "If you have played two or more Void Heroes this turn, " ..
                  "transform this into Clutch of Darkness.";

   ai = {
   },
   
   image_large = { "VC_InitiatesGauntlets", {0, 0, 364/512, 1} };
   image_medium = { "VC_InitiatesGauntlets", {392/512, 0, 512/512, 168/512} };
   image_small = { "VC_InitiatesGauntlets", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VC_InitiatesGauntlets", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Clutch of Darkness"] = {
	card_name = "Clutch of Darkness";
    card_set = "RU";
	card_type = "Construct";
	faction = "Void";
	rune_cost = 4;
	honor = 4;

   transform_from = "Initiate's Gauntlets";

	construct_ability = {
		description = "Gain 2P";
		{ "GainPower", 2 },
      
      ai = {
         trivial = true,
      },
	};

	effect_text = "Once per turn, gain 2P.";

   ai = {
      gain_power = 2;
   },

   image_large = { "VC_ClutchDarkness", {0, 0, 364/512, 1} };
   image_medium = { "VC_ClutchDarkness", {392/512, 0, 512/512, 168/512} };
   image_small = { "VC_ClutchDarkness", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VC_ClutchDarkness", {384/512, 395/512, 512/512, 512/512} };

   --rarity_count = 2
}








g_ascension_cards["Canon Templar"] = {
	card_name = "Canon Templar";
    card_set = "RU";
	card_type = "Hero";
	factions = { "Enlightened", "Mechana" };
	rune_cost = 5;
	honor = 3;

	effects = {
		{ "GainRunes", 2 },
      { "DefeatMonsterWithLessPowerThanContructValue", 0 },
   };
   
	effect_text = "Gain 2R.\n" ..
                  "You may defeat a Monster with P cost less than or equal to " ..
                  "the R cost of a Construct you control.";

   ai = {
   },
   
   image_large = { "EMH_CanonTemplar", {0, 0, 364/512, 1} };
   image_medium = { "EMH_CanonTemplar", {392/512, 0, 512/512, 168/512} };
   image_small = { "EMH_CanonTemplar", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EMH_CanonTemplar", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Deathbound Druid"] = {
	card_name = "Deathbound Druid";
    card_set = "RU";
	card_type = "Hero";
	factions = { "Lifebound", "Void" };
	rune_cost = 4;
	honor = 3;

	effects = {
		{ "GainHonor", 3 },
		{ "BanishFromDiscard", 1 },
   };
   
	effect_text = "Gain 3H.\n" ..
                  "You may banish a card in your discard pile.";

   ai = {
   },
   
   image_large = { "LVH_DeathboundDruid", {0, 0, 364/512, 1} };
   image_medium = { "LVH_DeathboundDruid", {392/512, 0, 512/512, 168/512} };
   image_small = { "LVH_DeathboundDruid", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LVH_DeathboundDruid", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Nightmare Delver"] = {
	card_name = "Nightmare Delver";
    card_set = "RU";
	card_type = "Hero";
	factions = { "Mechana", "Void" };
	rune_cost = 4;
	honor = 2;

	effects = {
		{ "GainRunes", 2 },
		{ "BanishFromDiscard", 1, condition={"IfYouControlConstructs",2} },
	};

	effect_text = "Gain 2R.\n" ..
                  "If you control two or more Constructs, " ..
                  "you may banish a card in your discard pile.";

   ai = {
      gain_rune = 2;
   },
   
   image_large = { "MVH_NightmareDelver", {0, 0, 364/512, 1} };
   image_medium = { "MVH_NightmareDelver", {392/512, 0, 512/512, 168/512} };
   image_small = { "MVH_NightmareDelver", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MVH_NightmareDelver", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Timestream Seer"] = {
	card_name = "Timestream Seer";
    card_set = "RU";
	card_type = "Hero";
	factions = { "Enlightened", "Lifebound" };
	rune_cost = 4;
	honor = 2;

	effects = {
		{ "GainRunes", 2 },
		{ "BanishFromCenterRow", 1 },
	};

	effect_text = "Gain 2R.\n" ..
                  "You may banish a card in the center row.";

   ai = {
      gain_rune = 2;
   },

   image_large = { "ELH_TimestreamSeer", {0, 0, 364/512, 1} };
   image_medium = { "ELH_TimestreamSeer", {392/512, 0, 512/512, 168/512} };
   image_small = { "ELH_TimestreamSeer", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "ELH_TimestreamSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_active_effects["draw 2 cards when you defeat a monster"] = {
	type = "triggered";
	conditions = {
      { "WhenYouDefeatMonsterFromCenterRow", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerEffectPlayerDrawCards", 2 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

g_ascension_cards["Voidforged Paladin"] = {
	card_name = "Voidforged Paladin";
    card_set = "RU";
	card_type = "Hero";
	factions = { "Enlightened", "Void" };
	rune_cost = 5;
	honor = 3;

	effects = {
		{ "GainPower", 2 },
      { "NextMonsterYouDefeatFromCenterRowDraw2Cards", 0 },
   };
   
	effect_text = "Gain 2P.\n" ..
                  "The first time you defeat a Monster in the center row this turn, draw two cards.";

   ai = {
   },
   
   image_large = { "EVH_VoidforgedPaladin", {0, 0, 364/512, 1} };
   image_medium = { "EVH_VoidforgedPaladin", {392/512, 0, 512/512, 168/512} };
   image_small = { "EVH_VoidforgedPaladin", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EVH_VoidforgedPaladin", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Wildgear Druid"] = {
	card_name = "Wildgear Druid";
    card_set = "RU";
	card_type = "Hero";
	factions = { "Lifebound", "Mechana" };
	rune_cost = 3;
	honor = 2;

	effects = {
		{ "GainRunes", 2 },
		{ "GainHonor", 2, condition={"IfYouControlConstructs",2} },
	};
   
	effect_text = "Gain 2R.\n" ..
                  "If you control two or more Constructs, gain 2H.";

   ai = {
      gain_rune = 2;
   },
   
   image_large = { "LMH_WildgearDruid", {0, 0, 364/512, 1} };
   image_medium = { "LMH_WildgearDruid", {392/512, 0, 512/512, 168/512} };
   image_small = { "LMH_WildgearDruid", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LMH_WildgearDruid", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}













g_ascension_cards["Foundation Burrower"] = {
	card_name = "Foundation Burrower";
    card_set = "RU";
	card_type = "Monster";
	power_cost = 2;

	rewards = {
		{ "GainHonor", 1 },
		{ "BanishFromCenterRow", 1 },
   };
   
	effect_text = "REWARD: Gain 1H. You may banish a card in the center row.";

   ai = {
   },
   
   image_large = { "M_FoundationBurrower", {0, 0, 364/512, 1} };
   image_medium = { "M_FoundationBurrower", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_FoundationBurrower", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_FoundationBurrower", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "foundation_burrower" };

   rarity_count = 4
}


g_ascension_cards["Sadistic Giant"] = {
	card_name = "Sadistic Giant";
    card_set = "RU";
	card_type = "Monster";
	power_cost = 4;

	rewards = {
		{ "GainHonor", 5 },
   };
   
	effect_text = "REWARD: Gain 5H.";

   ai = {
   },
   
   image_large = { "M_SadisticGiant", {0, 0, 364/512, 1} };
   image_medium = { "M_SadisticGiant", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_SadisticGiant", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_SadisticGiant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "sadistic_giant" };

   rarity_count = 4
}

g_ascension_cards["Sower of Betrayal"] = {
	card_name = "Sower of Betrayal";
    card_set = "RU";
	card_type = "Monster";
	power_cost = 6;

	rewards = {
		{ "GainHonor", 3 },
		{ "GainHonorForMostFactionHeroesPlayed", 2 },
   };
   
	effect_text = "REWARD: Gain 3H. Name a faction. " ..
                  "Gain an additional 2H for each Hero of that faction you have played this turn.";

   ai = {
   },
   
   image_large = { "M_SowerBetrayal", {0, 0, 364/512, 1} };
   image_medium = { "M_SowerBetrayal", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_SowerBetrayal", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_SowerBetrayal", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "sower_of_betrayal" };

   rarity_count = 2
}

g_ascension_cards["Sower of Discontent"] = {
	card_name = "Sower of Discontent";
    card_set = "RU";
	card_type = "Monster";
	power_cost = 3;

	rewards = {
		{ "GainHonor", 2 },
		{ "GainHonorForMostFactionHeroesPlayed", 1 },
   };
   
	effect_text = "REWARD: Gain 2H. Name a faction. " ..
                  "Gain an additional 1H for each Hero of that faction you have played this turn.";

   ai = {
   },
   
   image_large = { "M_SowerDiscontent", {0, 0, 364/512, 1} };
   image_medium = { "M_SowerDiscontent", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_SowerDiscontent", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_SowerDiscontent", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "sower_of_discontent" };

   rarity_count = 4
}

g_ascension_cards["Terrorizing Fiend"] = {
	card_name = "Terrorizing Fiend";
    card_set = "RU";
	card_type = "Monster";
	power_cost = 4;

	rewards = {
		{ "GainHonor", 2 },
		{ "DrawCards", 2 },
   };
   
	effect_text = "REWARD: Gain 2H. Draw two cards.";

   ai = {
   },
   
   image_large = { "M_TerrorizingFiend", {0, 0, 364/512, 1} };
   image_medium = { "M_TerrorizingFiend", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_TerrorizingFiend", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_TerrorizingFiend", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "terrorizing_fiend" };

   rarity_count = 3
}

g_ascension_cards["Wailing Spectre"] = {
	card_name = "Wailing Spectre";
    card_set = "RU";
	card_type = "Monster";
	power_cost = 5;

	rewards = {
		{ "GainHonor", 4 },
      { "BanishMultipleFromDiscard", 2 },
   };
   
	effect_text = "REWARD: Gain 4H. You may banish up to two cards in your discard pile.";

   ai = {
   },
   
   image_large = { "M_WailingSpectre", {0, 0, 364/512, 1} };
   image_medium = { "M_WailingSpectre", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_WailingSpectre", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_WailingSpectre", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "wailing_spectre" };

   rarity_count = 3
}

g_ascension_cards["Borderland Nihilist"] = {
	card_name = "Borderland Nihilist";
    card_set = "RU";
	card_type = "Monster";
	power_cost = 3;

	rewards = {
      { "PauseForAnimation", 0 },
		{ "TransformThisMonsterIntoBorderlandMercenary", 0 },
	};
   transform_into = "Borderland Mercenary";

	effect_text = "REWARD: Transform this into Borderland Mercenary and acquire it.";

   ai = {
   },
   
   image_large = { "M_BorderlandNihilist", {0, 0, 364/512, 1} };
   image_medium = { "M_BorderlandNihilist", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_BorderlandNihilist", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_BorderlandNihilist", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "borderland_nihilist" };

   rarity_count = 4
}

g_ascension_active_effects["effect hero is faction"] = {
	type = "continuous";
	effectfunc = { "EffectHeroIsFaction", 0 };
}

g_ascension_cards["Borderland Mercenary"] = {
	card_name = "Borderland Mercenary";
    card_set = "RU";
	card_type = "Hero";
	rune_cost = 3;
	honor = 2;

   transform_from = "Borderland Nihilist";

   delay_played_event_until_after_resolution = true;

	effects = {
      { "DrawCards", 1 },
      { "ChooseFactionForThisCard", 0 },
   };

	effect_text = "Draw a card.\n" ..
                  "Name a faction. This Hero counts as that faction this turn.";
   
   ai = {
      trivial_draw = 1,

      gain_draw = 1;
   },
   
   image_large = { "M_BorderlandMercenary", {0, 0, 364/512, 1} };
   image_medium = { "M_BorderlandMercenary", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_BorderlandMercenary", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_BorderlandMercenary", {384/512, 395/512, 512/512, 512/512} };

   --rarity_count = 4
}


g_ascension_cards["Adayu the Tormented"] = {
	card_name = "Adayu the Tormented";
    card_set = "RU";
	card_type = "Monster";
	power_cost = 7;

	rewards = {
      { "PauseForAnimation", 0 },
		{ "TransformThisMonsterIntoAdayuTheSerene", 0 },
	};
   transform_into = "Adayu the Serene";

	effect_text = "REWARD: Transform this into Adayu the Serene and acquire it.";

   ai = {
   },
   
   image_large = { "M_AdayuTormented", {0, 0, 364/512, 1} };
   image_medium = { "M_AdayuTormented", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_AdayuTormented", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_AdayuTormented", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "adayu_the_tormented" };

   rarity_count = 1
}


g_ascension_active_effects["draw 1 card for enlightened hero played"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayEnlightenedHero", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerMultiUnite", 0 },
		{ "TriggerEffectPlayerDrawCards", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

g_ascension_cards["Adayu the Serene"] = {
	card_name = "Adayu the Serene";
    card_set = "RU";
	card_type = "Hero";
	factions = { "Enlightened", "Lifebound", "Mechana", "Void" };
	rune_cost = 7;
	honor = 6;

   transform_from = "Adayu the Tormented";

	effects = {
		{ "GainRunes", 1 },
		{ "GainPower", 1 },
		{ "GainHonor", 1 },
		{ "DrawCards", 1 },
		{ "MultiUnite_GainRuneForEachMechanaHeroPlayed", 1 },
		{ "MultiUnite_GainPowerForEachVoidHeroPlayed", 1 },
		{ "MultiUnite_GainHonorForEachLifeboundHeroPlayed", 1 },
		{ "MultiUnite_DrawCardsForEachEnlightenedHeroPlayed", 1 },
   };

	effect_text = "This Hero counts as all factions.\n" ..
                  "Gain 1R, 1P and 1H. Draw a card.\n" ..
                  "MULTI-UNITE: Gain 1R for each Mechana Hero, 1P for each Void Hero," ..
                     "1H for each Lifebound Hero, and draw a card for each Enlightened Hero " ..
                     "you play or have played this turn.";

   ai = {
   },
   
   image_large = { "M_AdayuSerene", {0, 0, 364/512, 1} };
   image_medium = { "M_AdayuSerene", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_AdayuSerene", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_AdayuSerene", {384/512, 395/512, 512/512, 512/512} };

   --rarity_count = 1
}














--[[

-- PROMO CARDS


-- TODO
g_ascension_cards["Eye of Potential"] = {
	card_name = "Eye of Potential";
	card_type = "Construct";
	faction = "Enlightened";
	rune_cost = 6;
	honor = 3;

	effects = {
   };
   
	effect_text = "Once per turn, you may banish a card in your hand. " ..
                  "If you do, acquire a Mystic or Heavy Infantry without paying its cost " ..
                  "and put it in your hand.";

   ai = {
   },
   
}

-- TODO
g_ascension_cards["Cetra, Benefactor of All"] = {
	card_name = "Cetra, Benefactor of All";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 4;
	honor = 2;

	effects = {
   };
   
	effect_text = "Starting with you, and then going in turn order, " ..
                  "each player acquires a Hero without paying its cost. " ..
                  "The Heroes acquired this way are put on top of their owners' decks.";

   ai = {
   },
   
}


g_ascension_cards["Nyxian Corruptor"] = {
	card_name = "Nyxian Corruptor";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 6;
	honor = 3;

	effects = {
		{ "GainPower", 3 },
      { "UseRunesAsPowerUntilEndOfTurn", 0 }
   };
   
	effect_text = "Gain 3P.\n" ..
                  "You may spend R as though it was P this turn.";

   ai = {
   },
   
}


-- TODO
g_ascension_cards["Sadistic Laboratory"] = {
	card_name = "Sadistic Laboratory";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 6;
	honor = 3;

	effects = {
   };
   
	effect_text = "Once per turn, gain 1P.\n" ..
                  "When you defeat a Monster in the Center Row, banish any Monsters under this " ..
                  "and place the defeated monster under this. " ..
                  "You may defeat the monster under this as though it were in the center row. " ..
                  "If this leaves play, banish any monsters under this.";

   ai = {
   },
   
}

-- TODO
g_ascension_cards["Foul Replicant"] = {
	card_name = "Foul Replicant";
	card_type = "Monster";
	power_cost = 5;

	rewards = {
		{ "GainHonor", 4 },
   };
   
	effect_text = "REWARD: Gain 4H.\n" ..
                  "ONGOING TROPHY: Once per turn, choose a Construct you control. " ..
                     "This gains the text of the chosen Construct for this turn.";

   ai = {
   },
   
}

]]

