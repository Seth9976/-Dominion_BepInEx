

g_ascension_cards["Dhartha's Trial"] = {
   card_name = "Dhartha's Trial";
   card_set = "GotE";
   card_type = "Event";
   faction = "Enlightened";

   transform_into = "Dhartha, Eternal Seer";

   cardinplay_abilities = {
      {
         description = "Draw Card";
         condition = { "IfPlayedMysticOrHeavyInfantry", 0 },
         { "DrawCards", 1 },

         ai = {
            trivial = true,
         },
      },
      {
         description = "Transform";
         condition = { "IfHasCurrentTurnRunes", 8 },
         { "PushResolvingCurrentEvent", 0 },
         { "PauseForAnimation", 0 },
         { "PayRunes", 8 },
         { "TransformThisEventIntoDharthaEternalSeer", 0 },
      },
   };

   effect_text = "Once per turn, if you have played a Mystic or Heavy Infantry, draw a card.\n" ..
                  "Pay 8R: Transform this into Dhartha, Eternal Seer and acquire it.";

   image_large = { "E_DharthasTrial", {0, 0, 364/512, 1} };
   image_medium = { "E_DharthasTrial", {392/512, 0, 512/512, 168/512} };
   image_small = { "E_DharthasTrial", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "E_DharthasTrial", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Dhartha, Eternal Seer"] = {
	card_name = "Dhartha, Eternal Seer";
    card_set = "GotE";
	card_type = "Hero";
	faction = "Enlightened";

   transform_from = "Dhartha's Trial";

	rune_cost = 8;
	honor = 6;

   effects = {
      { "DrawCards", 4 },
   };

	effect_text = "Draw four cards.";

   ai = {
   },
   
   image_large = { "EH_DharthaEternalSeer", {0, 0, 364/512, 1} };
   image_medium = { "EH_DharthaEternalSeer", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_DharthaEternalSeer", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_DharthaEternalSeer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_cards["Radiant Aspirant"] = {
   card_name = "Radiant Aspirant";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Enlightened";

   rune_cost = 1;
   honor = 1;

   empower = true;
   effects = {
      { "DrawCards", 1 },
   };

   effect_text = "EMPOWER\n" ..
                  "Draw a card.";

   ai = {
   },

   image_large = { "EH_RadiantAspirant", {0, 0, 364/512, 1} };
   image_medium = { "EH_RadiantAspirant", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_RadiantAspirant", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_RadiantAspirant", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2

}


g_ascension_cards["Water Elemental"] = {
   card_name = "Water Elemental";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Enlightened";

   rune_cost = 2;
   honor = 1;

   effects = {
      { "DrawCards", 1 },
   };
   banish_effect = { "DrawCardsForTurnPlayer", 2 };

   effect_text = "Draw a card.\n" ..
                  "If this is banished from anywhere during your turn, draw two cards.";

   ai = {
   },

   image_large = { "EH_WaterElemental", {0, 0, 364/512, 1} };
   image_medium = { "EH_WaterElemental", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_WaterElemental", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_WaterElemental", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3

}


g_ascension_cards["Sister of the Wind"] = {
   card_name = "Sister of the Wind";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Enlightened";

   rune_cost = 3;
   honor = 1;

   effects = {
      { "BanishThisCard", 0 },
      { "BanishFromHand", 0 },
      { "AcquireMysticToHand", 0, condition={"IfYouDo",1} },
      { "AcquireHeavyInfantryToHand", 0, condition={"IfYouDo",1} },
   };

   effect_text = "Banish Sister of the Wind and a card in your hand. " ..
                  "If you do, add a Mystic and/or a Heavy Infantry to your hand.";

   ai = {
   },

   image_large = { "EH_SisterWind", {0, 0, 364/512, 1} };
   image_medium = { "EH_SisterWind", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_SisterWind", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_SisterWind", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2

}


g_ascension_cards["Yuk Tribe Outcast"] = {
   card_name = "Yuk Tribe Outcast";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Enlightened";

   rune_cost = 3;
   honor = 1;

   effects = {
      { "DrawCards", 1 },
      { "BanishFromCenterRow", 1 },
      { "BanishYukTribeFromHand", 1 },
      { "AcquireOrDefeatAnyCenterRow", 0, condition={"IfYouDo",2} },
	  { "PlayYukTribeOutcast", 0, condition={"IfYouDo",2} },
   };

   effect_text = "Draw a card.\n" ..
                  "Banish a card in the center row. " ..
                  "Then you may banish a Yuk Tribe Outcast or Yuk Tribe Gremlin in your hand " ..
                  "to acquire or defeat a card in the center row without paying its cost.";

   ai = {
   },

   image_large = { "EH_YukTribeOutcast", {0, 0, 364/512, 1} };
   image_medium = { "EH_YukTribeOutcast", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_YukTribeOutcast", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_YukTribeOutcast", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3

}


g_ascension_cards["Thunder Templar"] = {
   card_name = "Thunder Templar";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Enlightened";

   rune_cost = 4;
   honor = 2;

   empower = true;
   effects = {
      { "DefeatMonsterWithLessPower", 5 },
   };

   effect_text = "EMPOWER\n" ..
                  "Defeat a Monster with cost 5P or less without paying its cost.";

   ai = {
   },

   image_large = { "EH_ThunderTemplar", {0, 0, 364/512, 1} };
   image_medium = { "EH_ThunderTemplar", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_ThunderTemplar", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_ThunderTemplar", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2

}


g_ascension_cards["Whirlwind Ascetic"] = {
   card_name = "Whirlwind Ascetic";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Enlightened";

   rune_cost = 5;
   honor = 3;

   effects = {
      { "DrawCards", 3 },
      { "DiscardMultipleFromHand", 2 },
      { "PutEffectInstanceDataMysticFromDiscardIntoHand", 1, condition={"IfEffectInstanceDataHasMysticAndHeavyInfantry",1} },
      { "PutEffectInstanceDataHeavyInfantryFromDiscardIntoHand", 1, condition={"IfEffectInstanceDataHasMysticAndHeavyInfantry",1} },
   };

   effect_text = "Draw three cards, then discard two cards. " ..
                  "You may return a Mystic AND a Heavy Infantry discarded this way to your hand.";

   ai = {
   },

   image_large = { "EH_WhirlwindAscetic", {0, 0, 364/512, 1} };
   image_medium = { "EH_WhirlwindAscetic", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_WhirlwindAscetic", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_WhirlwindAscetic", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2

}


g_ascension_cards["Brother Laias"] = {
   card_name = "Brother Laias";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Enlightened";

   rune_cost = 6;
   honor = 4;


   global_continuous_effects = {
      {
         priority = -5;
         conditions = {
            { "TriggerIfHasPlayedMystic", 0 },
         };
         effect = { "AcquireThisCardToHand", 0 };
      },
   };

   empower = true;
   effects = {
      { "DrawCards", 2 },
   };

   effect_text = "EMPOWER\n" ..
                  "When you acquire Brother Laias, put it into your hand " ..
                  "if you have played a Mystic this turn.\n" ..
                  "Draw two cards.";

   ai = {
   },

   image_large = { "EH_BrotherLaias", {0, 0, 364/512, 1} };
   image_medium = { "EH_BrotherLaias", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_BrotherLaias", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_BrotherLaias", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1

}


g_ascension_cards["Sonny, Lightwielder"] = {
   card_name = "Sonny, Lightwielder";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Enlightened";

   rune_cost = 7;
   honor = 5;

   empower = true;
   effects = {
      { "DefeatAnyMonsterToPlayerDiscard", 0 },
   };

   effect_text = "EMPOWER\n" ..
                  "Defeat a Monster without paying its cost. " ..
                  "If that Monster would go to the Void, " ..
                  "you may pay put it into a player's discard pile instead.";

   ai = {
   },

   image_large = { "EH_SonnyLightwielder", {0, 0, 364/512, 1} };
   image_medium = { "EH_SonnyLightwielder", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_SonnyLightwielder", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_SonnyLightwielder", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1

}

g_ascension_cards["Piercing Eye"] = {
   card_name = "Piercing Eye";
   card_set = "GotE";
   card_type = "Construct";
   faction = "Enlightened";

   rune_cost = 1;
   honor = 1;

   construct_abilities = {
      {
         description = "Draw Card";
         condition = { "IfHasDefeatedMonstersThisTurn", 1 },
         { "DrawCards", 1 },

      },
   };

   effect_text = "Once per turn, if you have defeated a Monster in the center row, " ..
                  "you may draw a card.";

   ai = {
   },

   image_large = { "EC_PiercingEye", {0, 0, 364/512, 1} };
   image_medium = { "EC_PiercingEye", {392/512, 0, 512/512, 168/512} };
   image_small = { "EC_PiercingEye", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EC_PiercingEye", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2

}

g_ascension_cards["Temple of the Wind"] = {
   card_name = "Temple of the Wind";
   card_set = "GotE";
   card_type = "Construct";
   faction = "Enlightened";

   rune_cost = 6;
   honor = 4;

   construct_abilities = {
      {
         description = "Banish Card";
         condition = { "IfHasCardsInDiscard", 1 },
         { "PushResolvingConstruct", 0 },
         { "BanishFromDiscard", 0 },
         { "AcquireMysticOrHeavyInfantry", 0, condition={"IfEffectInstanceDataIsBanishFromDiscard",1} },
         { "PopResolvingConstruct", 0 },
      },
   };

   effect_text = "Once per turn, you may banish a card in your discard pile " ..
                  "and replace it with a Mystic or Heavy Infantry.";

   ai = {
   },

   image_large = { "EC_TempleWind", {0, 0, 364/512, 1} };
   image_medium = { "EC_TempleWind", {392/512, 0, 512/512, 168/512} };
   image_small = { "EC_TempleWind", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EC_TempleWind", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1

}







g_ascension_cards["Cetra's Trial"] = {
   card_name = "Cetra's Trial";
   card_set = "GotE";
   card_type = "Event";
   faction = "Lifebound";

   transform_into = "Cetra, Celestial Body";

   continuous_effects = {
      {
         priority = 8;
         effect = { "ReduceCenterRowHeroRuneCost", 1 };
      },
   };

   cardinplay_abilities = {
      {
         description = "Transform";
         condition = { "IfHasCurrentTurnRunes", 8 },
         { "PushResolvingCurrentEvent", 0 },
         { "PauseForAnimation", 0 },
         { "PayRunes", 8 },
         { "TransformThisEventIntoCetraCelestialBody", 0 },
      },
   };

   effect_text = "Heroes in the center row cost 1R less to acquire (to a minimum of 1R).\n" ..
      "Pay 8R: Transform this into Cetra, Celestial Body and acquire it.";

   image_large = { "E_CetrasTrial", {0, 0, 364/512, 1} };
   image_medium = { "E_CetrasTrial", {392/512, 0, 512/512, 168/512} };
   image_small = { "E_CetrasTrial", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "E_CetrasTrial", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Cetra, Celestial Body"] = {
   card_name = "Cetra, Celestial Body";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Lifebound";

   transform_from = "Cetra's Trial";

   rune_cost = 8;
   honor = 6;

   effects = {
      { "GainHonorForCenterRowHeroesAndConstructs", 1 },
   };

   effect_text = "Gain H equal to the total H of all Heroes and Constructs in the center row.";

   ai = {
   },

   image_large = { "LH_CetraCelestialBody", {0, 0, 364/512, 1} };
   image_medium = { "LH_CetraCelestialBody", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_CetraCelestialBody", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_CetraCelestialBody", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Keen-eyed Aspirant"] = {
   card_name = "Keen-eyed Aspirant";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 1;
   honor = 1;

   empower = true;
   effects = {
      { "GainRunes", 1 },
      { "GainHonor", 1 },
   };

   effect_text = "EMPOWER\n" ..
                  "Gain 1R and 1H.";

   ai = {
   },

   image_large = { "LH_KeeneyedAspirant", {0, 0, 364/512, 1} };
   image_medium = { "LH_KeeneyedAspirant", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_KeeneyedAspirant", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_KeeneyedAspirant", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}

g_ascension_cards["Thicket Familiar"] = {
   card_name = "Thicket Familiar";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 2;
   honor = 1;

   empower = true;
   effects = {
      { "RevealTopCardOfDeck", 0 },
      { "GainHonor", 2, condition={"IfTopOfDeckHasEmpower",0} },
	  { "PlayThicketFamiliar", 0, condition={"IfTopOfDeckHasEmpower",0} },
      { "Pause", 0 },
      --{ "PopResolvingCardFromEffectData", 0 },
      { "PopAndDrawRevealedCard", 0 },
   };

   effect_text = "EMPOWER\n" ..
      "Reveal the top card of your deck and put it in your hand. " ..
      "If it is a card with Empower, gain 2H.";

   ai = {
   },

   image_large = { "LH_ThicketFamiliar", {0, 0, 364/512, 1} };
   image_medium = { "LH_ThicketFamiliar", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_ThicketFamiliar", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_ThicketFamiliar", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

-- TODO: when banished from anywhere
g_ascension_cards["Verdant Elemental"] = {
   card_name = "Verdant Elemental";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 3;
   honor = 1;

   effects = {
      { "GainHonor", 3 },
   };
   banish_effect = { "GainHonorForTurnPlayer", 3 };

   effect_text = "Gain 3H.\n" ..
                  "If this is banished from anywhere during your turn, gain 3H.";

   ai = {
   },

   image_large = { "LH_VerdantElemental", {0, 0, 364/512, 1} };
   image_medium = { "LH_VerdantElemental", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_VerdantElemental", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_VerdantElemental", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Flourishing Druidess"] = {
   card_name = "Flourishing Druidess";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 3;
   honor = 2;

   empower = true;
   effects = {
      { "GainRunes", 2 },
      { "GainRunes", 1, condition={"IfYouHaveMoreHonorThanOpponents",0} },
   };

   effect_text = "EMPOWER\n" ..
               "Gain 2R. If you have more H than every other player, gain an additional 1R.";

   ai = {
   },

   image_large = { "LH_FlourishingDruidess", {0, 0, 364/512, 1} };
   image_medium = { "LH_FlourishingDruidess", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_FlourishingDruidess", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_FlourishingDruidess", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_active_effects["unite 5H"] = {
   type = "triggered";
   conditions = {
      { "WhenYouPlayLifeboundHero", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerGainHonor", 5 },
      { "TriggerRemovePlayedCardEffectActive", 0 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}

g_ascension_cards["Kiri, Meadow Witch"] = {
   card_name = "Kiri, Meadow Witch";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 5;
   honor = 2;

   effects = {
      { "DrawCards", 1 },
      { "GainHonor", 5, condition={"IfPlayedLifeboundHero",1} },
      { "Unite5H", 0, condition={"IfHaventPlayedLifeboundHero",1} },
   };

   effect_text = "Draw a card.\n" ..
                  "UNITE: Gain 5H.";

   ai = {
   },

   image_large = { "LH_KiriMeadowWitch", {0, 0, 364/512, 1} };
   image_medium = { "LH_KiriMeadowWitch", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_KiriMeadowWitch", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_KiriMeadowWitch", {384/512, 395/512, 512/512, 512/512} };

   highlight_played_effect = { 0.023, 0.22, 0, 0.98 };

   rarity_count = 1
}


g_ascension_cards["Hearthglow Clique"] = {
   card_name = "Hearthglow Clique";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 5;
   honor = 2;

   empower = true;
   effects = {
      { "GainRunes", 2 },
      { "GainHonor", 2 },
      { "DrawCards", 1, condition={"IfPlayedLifeboundHero",1} },
      { "UniteDraw1Card", 0, condition={"IfHaventPlayedLifeboundHero",1} },
   };

   effect_text = "EMPOWER\n" ..
                  "Gain 2R and 2H.\n" ..
                  "UNITE: Draw a card.";

   ai = {
   },

   image_large = { "LH_HearthglowClique", {0, 0, 364/512, 1} };
   image_medium = { "LH_HearthglowClique", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_HearthglowClique", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_HearthglowClique", {384/512, 395/512, 512/512, 512/512} };

   highlight_played_effect = { -0.082, 0.18, 0, 0.98 };

   rarity_count = 2
}


g_ascension_cards["Earthmender Pura"] = {
   card_name = "Earthmender Pura";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Lifebound";

   rune_cost = 6;
   honor = 4;

   effects = {
      { "GainRunes", 3 },
      { "PutOwnedMonsterIntoOpponentDiscardPile", 1 },
   };

   effect_text = "Gain 3R.\n" ..
                  "You may put a Monster from your hand or discard pile into an opponent's discard pile.";

   ai = {
   },

   image_large = { "LH_EarthmenderPura", {0, 0, 364/512, 1} };
   image_medium = { "LH_EarthmenderPura", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_EarthmenderPura", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_EarthmenderPura", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_cards["Wildbark Mail"] = {
   card_name = "Wildbark Mail";
   card_set = "GotE";
   card_type = "Construct";
   faction = "Lifebound";

   rune_cost = 1;
   honor = 1;

   construct_abilities = {
      {
         description = "Gain 2H";
         condition = { "IfHasDefeatedMonstersThisTurn", 1 },
         { "GainHonor", 2 },

         ai = {
            trivial = true,
         },
      },
   };

   effect_text = "Once per turn, if you have defeated a Monster in the center row, gain 2H.";

   ai = {
   },

   image_large = { "LC_WildbarkMail", {0, 0, 364/512, 1} };
   image_medium = { "LC_WildbarkMail", {392/512, 0, 512/512, 168/512} };
   image_small = { "LC_WildbarkMail", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LC_WildbarkMail", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Temple of Heroes"] = {
   card_name = "Temple of Heroes";
   card_set = "GotE";
   card_type = "Construct";
   faction = "Lifebound";

   rune_cost = 4;
   honor = 3;

   construct_abilities = {
      {
         description = "Gain 2H";
         condition = { "IfPlayedLifeboundHeroOrMonster", 1 },
         { "GainHonor", 2 },

         ai = {
            trivial = true,
         },
      },
   };

   effect_text = "Once per turn, if you have played a Lifebound Hero or Monster, gain 2H.";

   ai = {
   },

   image_large = { "LC_TempleHeroes", {0, 0, 364/512, 1} };
   image_medium = { "LC_TempleHeroes", {392/512, 0, 512/512, 168/512} };
   image_small = { "LC_TempleHeroes", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LC_TempleHeroes", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}







g_ascension_cards["Reysa's Trial"] = {
   card_name = "Reysa's Trial";
   card_set = "GotE";
   card_type = "Event";
   faction = "Mechana";

   transform_into = "Forgemother Reysa";

   continuous_effects = {
      {
         priority = 8;
         effect = { "ReduceCenterRowConstructRuneCostForAll", 1 };
      },
   };

   cardinplay_abilities = {
      {
         description = "Transform";
         condition = { "IfHasCurrentTurnRunes", 8 },
         { "PushResolvingCurrentEvent", 0 },
         { "PauseForAnimation", 0 },
         { "PayRunes", 8 },
         { "TransformThisEventIntoForgemotherReysa", 0 },
      },
   };

   effect_text = "Constructs in the center row cost 1R less to acquire (to a minimum of 1R).\n" ..
                  "Pay 8R: Transform this into Forgemother Reysa and acquire it.";

   image_large = { "E_ReysasTrial", {0, 0, 364/512, 1} };
   image_medium = { "E_ReysasTrial", {392/512, 0, 512/512, 168/512} };
   image_small = { "E_ReysasTrial", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "E_ReysasTrial", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Forgemother Reysa"] = {
   card_name = "Forgemother Reysa";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Mechana";

   transform_from = "Reysa's Trial";

   rune_cost = 8;
   honor = 6;


   effects = {
      { "AcquireAllConstructsInCenterRowOrDrawCard", 1 },
   };

   effect_text = "Choose one: Draw a card OR acquire any number of Constructs " ..
                  "in the center row without paying their cost.";

   ai = {
   },

   image_large = { "MH_ForgemotherReysa", {0, 0, 364/512, 1} };
   image_medium = { "MH_ForgemotherReysa", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_ForgemotherReysa", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_ForgemotherReysa", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Innovative Aspirant"] = {
   card_name = "Innovative Aspirant";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Mechana";

   rune_cost = 1;
   honor = 1;

   empower = true;
   effects = {
      { "GainRunes", 1 },
      { "GainPower", 1 },
   };

   effect_text = "EMPOWER\n" ..
                  "Gain 1R and 1P.";

   ai = {
   },

   image_large = { "MH_InnovativeAspirant", {0, 0, 364/512, 1} };
   image_medium = { "MH_InnovativeAspirant", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_InnovativeAspirant", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_InnovativeAspirant", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_active_effects["may acquire construct directly into play"] = {
   type = "continuous";
   effectfunc = { "AcquireConstructDirectlyIntoPlay", 1 };
}


g_ascension_cards["Scrap Weaver"] = {
   card_name = "Scrap Weaver";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Mechana";

   rune_cost = 2;
   honor = 1;

   effects = {
      { "DrawCards", 1 },
      { "NextContructYouAcquireMayGoDirectlyIntoPlay", 0 },
   };

   effect_text = "Draw a card.\n" ..
                  "You may put the next Construct you acquire this turn directly into play.";

   ai = {
   },

   image_large = { "MH_ScrapWeaver", {0, 0, 364/512, 1} };
   image_medium = { "MH_ScrapWeaver", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_ScrapWeaver", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_ScrapWeaver", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

-- TODO: when banished from anywhere
g_ascension_cards["Iron Elemental"] = {
   card_name = "Iron Elemental";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Mechana";

   rune_cost = 3;
   honor = 1;

   effects = {
      { "GainRunes", 2 },
   };
   banish_effect = { "GainRunesForTurnPlayer", 2 };

   effect_text = "Gain 2R.\n" ..
                  "If this is banished from anyhere during your turn, gain 2R.";

   ai = {
   },

   image_large = { "MH_IronElemental", {0, 0, 364/512, 1} };
   image_medium = { "MH_IronElemental", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_IronElemental", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_IronElemental", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Conduit Monk"] = {
   card_name = "Conduit Monk";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Mechana";

   rune_cost = 6;
   honor = 4;

   effects = {
      { "GainRunes", 3 },
      { "AddMechanaConstructCountUntilEndOfTurn", 2 },
   };

   empower = true;
   effect_text = "EMPOWER\n" ..
               "Gain 3R.\n" ..
               "You are considered to control two additional Mechana Constructs this turn.";

   ai = {
   },

   image_large = { "MH_ConduitMonk", {0, 0, 364/512, 1} };
   image_medium = { "MH_ConduitMonk", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_ConduitMonk", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_ConduitMonk", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Elemental Projector"] = {
   card_name = "Elemental Projector";
   card_set = "GotE";
   card_type = "Construct";
   faction = "Mechana";

   rune_cost = 2;
   honor = 2;

   construct_abilities = {
      {
         description = "Gain 2P";
         condition = { "IfYouControlMechanaConstructs", 2 },
         { "GainPower", 2 },

         ai = {
            trivial = true,
         },
      },
   };

   effect_text = "Once per turn, if you control two or more Mechana Constructs, gain 2P.";

   ai = {
   },

   image_large = { "MC_ElementalProjector", {0, 0, 364/512, 1} };
   image_medium = { "MC_ElementalProjector", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_ElementalProjector", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_ElementalProjector", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Processing Hub"] = {
   card_name = "Processing Hub";
   card_set = "GotE";
   card_type = "Construct";
   faction = "Mechana";

   rune_cost = 3;
   honor = 3;

   construct_abilities = {
      {
         description = "Gain 2R";
         condition = { "IfYouControlMechanaConstructs", 3 },
         { "GainRunes", 2 },

         ai = {
            trivial = true,
         },
      },
   };

   effect_text = "Once per turn, if you control three or more Mechana Constructs, gain 2R.";

   ai = {
   },

   image_large = { "MC_ProcessingHub", {0, 0, 364/512, 1} };
   image_medium = { "MC_ProcessingHub", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_ProcessingHub", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_ProcessingHub", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Spire of Insight"] = {
   card_name = "Spire of Insight";
   card_set = "GotE";
   card_type = "Construct";
   faction = "Mechana";

   rune_cost = 4;
   honor = 4;

   construct_abilities = {
      {
         description = "Draw 2 cards";
         condition = { "IfYouControlMechanaConstructs", 4 },
         { "DrawCards", 2 },

         ai = {
            trivial_draw = 2,

            gain_draw = 2,
         },
      },
   };

   effect_text = "Once per turn, if you control four or more Mechana Constructs, you may draw two cards.";

   ai = {
   },

   image_large = { "MC_SpireInsight", {0, 0, 364/512, 1} };
   image_medium = { "MC_SpireInsight", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_SpireInsight", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_SpireInsight", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Blast Goggles"] = {
   card_name = "Blast Goggles";
   card_set = "GotE";
   card_type = "Construct";
   faction = "Mechana";

   rune_cost = 5;
   honor = 5;

   construct_abilities = {
      {
         description = "Gain 5H";
         condition = { "IfYouControlMechanaConstructs", 5 },
         { "GainHonor", 5 },

         ai = {
            trivial = true,
         },
      },
   };

   effect_text = "Once per turn, if you control five or more Mechana Constructs, gain 5H.";

   ai = {
   },

   image_large = { "MC_BlastGoggles", {0, 0, 364/512, 1} };
   image_medium = { "MC_BlastGoggles", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_BlastGoggles", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_BlastGoggles", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Cell Block E"] = {
   card_name = "Cell Block E";
   card_set = "GotE";
   card_type = "Construct";
   faction = "Mechana";

   rune_cost = 7;
   honor = 7;

   treat_monsters_as_mechana_constructs = true;
   
   effect_text = "When you defeat a Monster in the center row or play a Monster, " ..
                  "you may put it directly into play and treat it as a Mechana Construct.";

   --effects = {
   --   { "TreatMechanaHeroesAsConstructs", 0 },
   --};
   --[[
	triggered_effects = {
		{
			conditions = {
				{ "WhenYouPutThisConstructIntoPlay", 0 },
			};
			triggereffect = {
				{ "TriggerConstructOwnerTreatsMonstersAsConstructs", 1 },
			};
		},
	};
	]]--
   ai = {
   },

   image_large = { "MC_CellBlockE", {0, 0, 364/512, 1} };
   image_medium = { "MC_CellBlockE", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_CellBlockE", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_CellBlockE", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["P.R.I.M.E. Directive"] = {
   card_name = "P.R.I.M.E. Directive";
   card_set = "GotE";
   card_type = "Construct";
   faction = "Mechana";

   rune_cost = 8;
   honor = 8;

   construct_abilities = {
      {
         description = "Win Game!";
         condition = { "IfYouControlMechanaConstructs", 8 },
         { "PushResolvingConstruct", 0 },
         { "WinTheGame", 0 },
         { "PopResolvingConstruct", 0 },

         ai = {
            trivial = true,
         },
      },
   };

   effect_text = "If you control eight or more Mechana Constructs, you win the game.";

   ai = {
   },

   image_large = { "MC_PrimeDirective", {0, 0, 364/512, 1} };
   image_medium = { "MC_PrimeDirective", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_PrimeDirective", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_PrimeDirective", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}





g_ascension_cards["Emri's Trial"] = {
   card_name = "Emri's Trial";
   card_set = "GotE";
   card_type = "Event";
   faction = "Void";

   transform_into = "Emri, Born of Battle";

   continuous_effects = {
      {
         priority = 8;
         effect = { "ReduceDefeatMonsterInCenterRowCostForAll", 1 };
      },
   };

   cardinplay_abilities = {
      {
         description = "Transform";
         condition = { "IfHasCurrentTurnRunes", 8 },
         { "PushResolvingCurrentEvent", 0 },
         { "PauseForAnimation", 0 },
         { "PayRunes", 8 },
         { "TransformThisEventIntoEmriBornOfBattle", 0 },
      },
   };

   effect_text = "Monsters in the center row cost 1P less to defeat (to a minimum of 1P).\n" ..
                  "Pay 8R: Transform this into Emri, Born of Battle and acquire it.";

   image_large = { "E_EmrisTrial", {0, 0, 364/512, 1} };
   image_medium = { "E_EmrisTrial", {392/512, 0, 512/512, 168/512} };
   image_small = { "E_EmrisTrial", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "E_EmrisTrial", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_active_effects["steal 2 honor from opponents when defeat a monster"] = {
   type = "triggered";
   priority = 8;
   conditions = {
      { "WhenYouDefeatMonster", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerStealHonorFromEachOpponent", 2 },
      { "TriggerRemovePlayedCardEffectActive", 0 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}

g_ascension_active_effects["steal 2 honor from opponents when defeat from center row"] = {
   type = "triggered";
   priority = 8;
   conditions = {
      { "WhenYouDefeatMonsterFromCenterRow", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerStealHonorFromEachOpponent", 2 },
      { "TriggerRemovePlayedCardEffectActive", 0 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}

g_ascension_cards["Emri, Born of Battle"] = {
   card_name = "Emri, Born of Battle";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Void";

   transform_from = "Emri's Trial";

   rune_cost = 8;
   honor = 6;

   effects = {
      { "GainPower", 4 },
      { "NextMonsterYouDefeatSteal2HonorFromEachOpponent", 0 },
   };

   effect_text = "Gain 4P.\n" ..
                  "Once per turn, when you defeat a Monster in the center row, " ..
                  "take 2H from each other player.";

   ai = {
   },

   image_large = { "VH_EmriBornBattle", {0, 0, 364/512, 1} };
   image_medium = { "VH_EmriBornBattle", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_EmriBornBattle", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_EmriBornBattle", {384/512, 395/512, 512/512, 512/512} };

   highlight_played_effect = { -0.03, 0.55, 0, 0.98 };

   rarity_count = 1
}


g_ascension_cards["Deranged Aspirant"] = {
   card_name = "Deranged Aspirant";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 1;
   honor = 1;

   empower = true;
   effects = {
      { "BanishFromHandOrDiscard", 1 },
   };

   effect_text = "EMPOWER\n" ..
                  "You may banish a card in your hand or discard pile.";

   ai = {
   },

   image_large = { "VH_DerangedAspirant", {0, 0, 364/512, 1} };
   image_medium = { "VH_DerangedAspirant", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_DerangedAspirant", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_DerangedAspirant", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}

-- TODO: when banished from anywhere
g_ascension_cards["Shadow Elemental"] = {
   card_name = "Shadow Elemental";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 2;
   honor = 1;

   effects = {
      { "GainPower", 2 },
   };
   banish_effect = { "GainPowerForTurnPlayer", 2 };


   effect_text = "Gain 2P.\n" ..
                  "If this is banished from anywhere during your turn, gain 2P.";

   ai = {
   },

   image_large = { "VH_ShadowElemental", {0, 0, 364/512, 1} };
   image_medium = { "VH_ShadowElemental", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_ShadowElemental", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_ShadowElemental", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}

g_ascension_cards["Patient Assassin"] = {
   card_name = "Patient Assassin";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 3;
   honor = 2;

   effects = {
      { "GainPower", 2 },
      { "GainPower", 1, condition={"IfHasVoidCardsInDiscardPile",1} },
   };

   effect_text = "Gain 2P.\n" ..
                  "If there is a Void card in your discard pile, gain an additional 1P.";

   ai = {
   },

   image_large = { "VH_PatientAssassin", {0, 0, 364/512, 1} };
   image_medium = { "VH_PatientAssassin", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_PatientAssassin", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_PatientAssassin", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Venom Priestess"] = {
   card_name = "Venom Priestess";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 4;
   honor = 3;

   effects = {
      { "GainPower", 2 },
      { "BanishFromDiscardOrPlayed", 1 },
   };

   effect_text = "Gain 2P.\n" ..
                  "You may banish a card you have played this turn or in your discard pile.";

   ai = {
   },

   image_large = { "VH_VenomPriestess", {0, 0, 364/512, 1} };
   image_medium = { "VH_VenomPriestess", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_VenomPriestess", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_VenomPriestess", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Voidrift Stalker"] = {
   card_name = "Voidrift Stalker";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 5;
   honor = 4;

   empower = true;
   effects = {
      { "GainPower", 3 },
      { "DrawCards", 1, condition={"IfHasVoidCardsInDiscardPile",1} },
   };

   effect_text = "EMPOWER\n" ..
                  "Gain 3P.\n" ..
                  "If there is a Void card in your discard pile, draw a card.";

   ai = {
   },

   image_large = { "VH_VoidriftStalker", {0, 0, 364/512, 1} };
   image_medium = { "VH_VoidriftStalker", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_VoidriftStalker", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_VoidriftStalker", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Grand-Arbiter Todd"] = {
   card_name = "Grand-Arbiter Todd";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 6;
   honor = 3;

   empower = true;
   effects = {
      { "DrawCards", 2 },
      { "BanishFromHand", 0 },
      { "DrawCards", 1, condition={"IfEffectInstanceDataIsMonster",1} },
   };

   effect_text = "EMPOWER\n" ..
                  "Draw two cards.\n" ..
                  "Banish a card in your hand. " ..
                  "If you banished a Monster this way, draw an additional card.";

   ai = {
   },

   image_large = { "VH_GrandArbiterTodd", {0, 0, 364/512, 1} };
   image_medium = { "VH_GrandArbiterTodd", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_GrandArbiterTodd", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_GrandArbiterTodd", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Ulan, the Crusher"] = {
   card_name = "Ulan, the Crusher";
   card_set = "GotE";
   card_type = "Hero";
   faction = "Void";

   rune_cost = 6;
   honor = 4;

   empower = true;
   effects = {
      { "GainPower", 4 },
      { "DrawCards", 1, condition={"IfYouControlUlansFist",0} },
   };


   effect_text = "EMPOWER\n" ..
                  "Gain 4P.\n" ..
                  "If you control Ulan's Fist, draw a card.";

   ai = {
   },

   image_large = { "VH_UlanCrusher", {0, 0, 364/512, 1} };
   image_medium = { "VH_UlanCrusher", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_UlanCrusher", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_UlanCrusher", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_cards["Madness' Embrace"] = {
   card_name = "Madness' Embrace";
   card_set = "GotE";
   card_type = "Construct";
   faction = "Void";

   rune_cost = 1;
   honor = 1;

   construct_abilities = {
      {
         description = "Banish Card";
         condition = { "IfHasCardsInHandOrDiscardAndHasDefeatedMonstersThisTurn", 1 },
         { "PushResolvingConstruct", 0 },
         { "BanishFromHandOrDiscard", 0 },
         { "PopResolvingConstruct", 0 },

      },
   };

   effect_text = "Once per turn, if you have defeated a Monster in the center row, " ..
                  "you may banish a card in your hand or discard pile.";

   ai = {
   },

   image_large = { "VC_MadnessEmbrace", {0, 0, 364/512, 1} };
   image_medium = { "VC_MadnessEmbrace", {392/512, 0, 512/512, 168/512} };
   image_small = { "VC_MadnessEmbrace", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VC_MadnessEmbrace", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Oblivion Blossoms"] = {
   card_name = "Oblivion Blossoms";
   card_set = "GotE";
   card_type = "Construct";
   faction = "Void";

   rune_cost = 3;
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
         description = "Gain 1H";
         condition = { "IfHasBanishedCardsThisTurn", 1 },
         { "GainHonor", 1 },

         ai = {
            trivial = true,
         },
      },
   };

   effect_text = "Once per turn, gain 1P.\n" ..
                  "Once per turn, if you have banished a card, gain 1H.";

   ai = {
   },

   image_large = { "VC_OblivionBlossoms", {0, 0, 364/512, 1} };
   image_medium = { "VC_OblivionBlossoms", {392/512, 0, 512/512, 168/512} };
   image_small = { "VC_OblivionBlossoms", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VC_OblivionBlossoms", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Ulan's Fist"] = {
   card_name = "Ulan's Fist";
   card_set = "GotE";
   card_type = "Construct";
   faction = "Void";

   rune_cost = 6;
   honor = 4;

   construct_abilities = {
      {
         description = "Gain 2P";
         { "GainPower", 2 },

         ai = {
            trivial = true,
         },
      },
      {
         description = "Gain 2P";
         condition = { "IfHasPlayedUlanTheCrusher", 0 },
         { "GainPower", 2 },

         ai = {
            trivial = true,
         },
      },
   };
   effect_text = "Once per turn, gain 2P.\n" ..
                  "Once per turn, if you have played Ulan, the Crusher, " ..
                  "gain an additional 2P.";


   ai = {
      gain_power = 2;
   },

   image_large = { "VC_UlansFist", {0, 0, 364/512, 1} };
   image_medium = { "VC_UlansFist", {392/512, 0, 512/512, 168/512} };
   image_small = { "VC_UlansFist", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VC_UlansFist", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}





g_ascension_cards["Xeron's Trial"] = {
   card_name = "Xeron's Trial";
   card_set = "GotE";
   card_type = "Event";
   --faction = "Monster";

   transform_into = "Xeron, False Ally";

   triggered_effects = {
      {
         conditions = {
            { "WhenPlayerPlaysMonster", 0 },
         };
         triggereffect = {
            { "TriggerCurrentEventGainPower", 2 },
         };
      },
   };

   cardinplay_abilities = {
      {
         description = "Transform";
         condition = { "IfHasCurrentTurnPower", 8 },
         { "PushResolvingCurrentEvent", 0 },
         { "PauseForAnimation", 0 },
         { "PayPower", 8 },
         { "TransformThisEventIntoXeronFalseAlly", 0 },
      },
   };

   effect_text = "When you play a Monster, gain 2P.\n" ..
               "Pay 8R: Transform this into Xeron, False Ally and acquire it.";

   image_large = { "E_XeronsTrial", {0, 0, 364/512, 1} };
   image_medium = { "E_XeronsTrial", {392/512, 0, 512/512, 168/512} };
   image_small = { "E_XeronsTrial", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "E_XeronsTrial", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_active_effects["gain 2 runes for monster played"] = {
   type = "triggered";
   conditions = {
      { "WhenYouPlayMonster", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerGainRunes", 2 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}

g_ascension_cards["Xeron, False Ally"] = {
   card_name = "Xeron, False Ally";
   card_set = "GotE";
   card_type = "Hero";

   transform_from = "Xeron's Trial";

   rune_cost = 8;
   honor = 6;

   effects = {
      { "GainRunes", 5 },
      { "GainRunesForEachMonsterAlreadyPlayed", 2 },
      { "Gain2RunesForEachMonsterPlayedThisTurn", 0 },
   };

   effect_text = "Gain 5R.\n" ..
                  "Gain an additional 2R for each Monster you play or have played this turn.";

   ai = {
   },

   image_large = { "H_XeronFalseAlly", {0, 0, 364/512, 1} };
   image_medium = { "H_XeronFalseAlly", {392/512, 0, 512/512, 168/512} };
   image_small = { "H_XeronFalseAlly", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "H_XeronFalseAlly", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Nom Tribe Gremlin"] = {
   card_name = "Nom Tribe Gremlin";
   card_set = "GotE";
   card_type = "Monster";

   power_cost = 1;

   rewards = {
      { "GainHonor", 1 },
	  { "PlayInfest", 0 },
      { "PutThisIntoPlayerDiscardPile", 1 },
   };
   effects = {
      { "PutThisIntoOpponentDiscardPile", 1 },
   };

   effect_text = "Reward: Gain 1H.\n" ..
               "INFEST: When you defeat Nom Tribe Gremlin, you may put it into a player's discard pile.\n" ..
               "When you play Nom Tribe Gremlin, you may put it into another player's discard pile.";

   ai = {
   },

   image_large = { "M_NomTribeGremlin", {0, 0, 364/512, 1} };
   image_medium = { "M_NomTribeGremlin", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_NomTribeGremlin", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_NomTribeGremlin", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Nom Tribe Gremlin" };

   rarity_count = 4

}


g_ascension_cards["Yuk Tribe Gremlin"] = {
   card_name = "Yuk Tribe Gremlin";
   card_set = "GotE";
   card_type = "Monster";

   power_cost = 2;

   rewards = {
      { "GainHonor", 1 },
	  { "PlayInfest", 0 },
      { "PutThisIntoPlayerDiscardPile", 1 },
   };

   effect_text = "Reward: Gain 1H.\n" ..
               "INFEST: When you defeat Yuk Tribe Gremlin, you may put it into a player's discard pile.";

   ai = {
   },

   image_large = { "M_YukTribeGremlin", {0, 0, 364/512, 1} };
   image_medium = { "M_YukTribeGremlin", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_YukTribeGremlin", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_YukTribeGremlin", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Yuk Tribe Gremlin" };

   rarity_count = 4

}


g_ascension_cards["Bam Tribe Gremlins"] = {
   card_name = "Bam Tribe Gremlins";
   card_set = "GotE";
   card_type = "Monster";

   power_cost = 3;

   rewards = {
      { "GainHonor", 2 },
	  { "PlayInfest", 0 },
      { "PutThisIntoPlayerDiscardPile", 1 },
   };

   effect_text = "Reward: Gain 2H.\n" ..
               "INFEST: When you defeat Bam Tribe Gremlins, you may put it into a player's discard pile.";

   ai = {
   },

   image_large = { "M_BamTribeGremlins", {0, 0, 364/512, 1} };
   image_medium = { "M_BamTribeGremlins", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_BamTribeGremlins", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_BamTribeGremlins", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Bam Tribe Gremlins" };

   rarity_count = 4

}


g_ascension_cards["Bramble Elemental"] = {
   card_name = "Bramble Elemental";
   card_set = "GotE";
   card_type = "Monster";

   power_cost = 4;

   rewards = {
      { "GainHonor", 5 },
      { "BanishFromHandOrDiscard", 1 },
   };

   effect_text = "Reward: Gain 5H.\n" ..
                  "You may banish a card in your hand or discard pile.";

   ai = {
   },

   image_large = { "M_BrambleElemental", {0, 0, 364/512, 1} };
   image_medium = { "M_BrambleElemental", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_BrambleElemental", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_BrambleElemental", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Bramble Elemental" };

   rarity_count = 4

}


g_ascension_cards["Wildfire Elemental"] = {
   card_name = "Wildfire Elemental";
   card_set = "GotE";
   card_type = "Monster";

   power_cost = 4;

   rewards = {
      { "GainHonor", 4 },
	  { "BanishMultipleFromCenterRow", 2 },
   };

   effect_text = "Reward: Gain 4H.\n" ..
                  "Choose up to two cards in the center row and banish them.";

   ai = {
   },

   image_large = { "M_WildfireElemental", {0, 0, 364/512, 1} };
   image_medium = { "M_WildfireElemental", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_WildfireElemental", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_WildfireElemental", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Wildfire Elemental" };

   rarity_count = 2

}


g_ascension_cards["Unspeakable Doom"] = {
   card_name = "Unspeakable Doom";
   card_set = "GotE";
   card_type = "Monster";

   power_cost = 5;

   rewards = {
      { "GainHonor", 5 },
      { "EachOpponentRevealsHandGainHonorPerMonster", 2 },
   };

   effect_text = "Reward: Gain 5H.\n" ..
                  "Each opponent reveals their hand. " ..
                  "Gain an additional 2H for each Monster revealed this way.";

   ai = {
   },

   image_large = { "M_UnspeakableDoom", {0, 0, 364/512, 1} };
   image_medium = { "M_UnspeakableDoom", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_UnspeakableDoom", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_UnspeakableDoom", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Unspeakable Doom" };

   rarity_count = 2

}


g_ascension_cards["Tectonic Thrasher"] = {
   card_name = "Tectonic Thrasher";
   card_set = "GotE";
   card_type = "Monster";

   power_cost = 5;

   rewards = {
      { "GainHonor", 4 },
      { "EachOpponentDestroysConstructsInPlay", 2 },
   };

   effect_text = "Reward: Gain 4H.\n" ..
                  "Each opponent must choose and destroy two Constructs they control.";

   ai = {
   },

   image_large = { "M_TectonicThrasher", {0, 0, 364/512, 1} };
   image_medium = { "M_TectonicThrasher", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_TectonicThrasher", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_TectonicThrasher", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Tectonic Thrasher" };

   rarity_count = 2

}


g_ascension_cards["Static Elemental"] = {
   card_name = "Static Elemental";
   card_set = "GotE";
   card_type = "Monster";

   power_cost = 6;

   rewards = {
      { "GainHonor", 5 },
      { "EachOpponentPutsAllConstructsOnTopOfDeck", 0 },
   };

   effect_text = "Reward: Gain 5H.\n" ..
               "Each opponent puts all Constructs they control on top of their deck in random order.";

   ai = {
   },

   image_large = { "M_StaticElemental", {0, 0, 364/512, 1} };
   image_medium = { "M_StaticElemental", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_StaticElemental", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_StaticElemental", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Static Elemental" };

   rarity_count = 1

}


g_ascension_cards["Eek Tribe Gremlin"] = {
   card_name = "Eek Tribe Gremlin";
   card_set = "GotE";
   card_type = "Monster";

   power_cost = 6;

   rewards = {
      { "GainHonor", 5 },
      { "PutMonsterFromVoidIntoPlayerDiscardPile", 1 },
	  { "PlayInfest", 0 },
      { "PutThisIntoPlayerDiscardPile", 1 },
   };

   effect_text = "Reward: Gain 5H.\n" ..
               "Put a Monster from the void into a player's discard pile. " ..
               "INFEST: When you defeat Eek Tribe Gremlin, you may put it into a player's discard pile.";

   ai = {
   },

   image_large = { "M_EekTribeGremlin", {0, 0, 364/512, 1} };
   image_medium = { "M_EekTribeGremlin", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_EekTribeGremlin", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_EekTribeGremlin", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Eek Tribe Gremlin" };

   rarity_count = 1

}


g_ascension_cards["Yur, Eye of Chaos"] = {
   card_name = "Yur, Eye of Chaos";
   card_set = "GotE";
   card_type = "Monster";

   power_cost = 7;

   rewards = {
      { "GainHonor", 4 },
      { "DrawCards", 3 },
   };

   effect_text = "Reward: Gain 4H.\n" ..
                  "Draw three cards.";

   ai = {
   },

   image_large = { "M_YurEyeChaos", {0, 0, 364/512, 1} };
   image_medium = { "M_YurEyeChaos", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_YurEyeChaos", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_YurEyeChaos", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Yur Eye of Chaos" };

   rarity_count = 1

}



g_ascension_cards["Deluge Elemental"] = {
   card_name = "Deluge Elemental";
   card_set = "GotE";
   card_type = "Monster";

   power_cost = 8;


   rewards = {
      { "GainHonor", 6 },
      { "BanishMultipleFromHandDiscardDeckOrPlayed", 4 },
   };

   effect_text = "Reward: Gain 6H.\n" ..
                  "You may banish up to four cards in your hand, deck, discard pile, and/or cards played this turn. " ..
                  "If you do, shuffle your deck.";

   ai = {
   },

   image_large = { "M_DelugeElemental", {0, 0, 364/512, 1} };
   image_medium = { "M_DelugeElemental", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_DelugeElemental", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_DelugeElemental", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Deluge Elemental" };

   rarity_count = 1

}









