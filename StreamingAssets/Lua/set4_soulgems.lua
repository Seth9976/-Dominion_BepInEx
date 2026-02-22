

g_ascension_cards["Soul Gem - Arha Initiate"] = { 
	card_name = "Soul Gem - Arha Initiate";
	display_name = "Arha Initiate";
	card_set = "IH";
	card_type = "Soul Gem";
	faction = "none";
	rune_cost = 0;
	honor = 0;
   
	effect = { "DrawCards", 1 };
	effect_text = "Draw a card.";
   
   ai = {
      trivial_draw = 1,

      gain_draw = 1;
   },

   image_large = { "SG_ArhaInitiate", {0, 0, 364/512, 1} };
   image_medium = { "SG_ArhaInitiate", {392/512, 0, 512/512, 168/512} };
   image_small = { "SG_ArhaInitiate", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "SG_ArhaInitiate", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Soul Gem - Arha Templar"] = { 
	card_name = "Soul Gem - Arha Templar";
	display_name = "Arha Templar";
	card_set = "IH";
	card_type = "Soul Gem";
	faction = "none";
	rune_cost = 0;
	honor = 0;
   
	effect = { "DefeatMonsterWithLessPower", 4 };
	effect_text = "Defeat a Monster that has P4 or less.";

   ai = {
      defeat_monster = 4;
   },

   image_large = { "SG_ArhaTemplar", {0, 0, 364/512, 1} };
   image_medium = { "SG_ArhaTemplar", {392/512, 0, 512/512, 168/512} };
   image_small = { "SG_ArhaTemplar", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "SG_ArhaTemplar", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Soul Gem - Ascetic of the Lidless Eye"] = { 
	card_name = "Soul Gem - Ascetic of the Lidless Eye";
	display_name = "Ascetic of the Lidless Eye";
	card_set = "IH";
	card_type = "Soul Gem";
	faction = "none";
	rune_cost = 0;
	honor = 0;
   
	effect = { "DrawCards", 2 };

	effect_text = "Draw two cards.";

   ai = {
      trivial_draw = 2,

      gain_draw = 2;
   },

   image_large = { "SG_AsceticLidlessEye", {0, 0, 364/512, 1} };
   image_medium = { "SG_AsceticLidlessEye", {392/512, 0, 512/512, 168/512} };
   image_small = { "SG_AsceticLidlessEye", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "SG_AsceticLidlessEye", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Soul Gem - Askara of Fate"] = { 
	card_name = "Soul Gem - Askara of Fate";
	display_name = "Askara of Fate";
	card_set = "IH";
	card_type = "Soul Gem";
	faction = "none";
	rune_cost = 0;
	honor = 0;
   
	--center_row = { "EachPlayerDrawCards", 1 },

	effects = {
		{ "DrawCards", 2 },
		{ "EachOpponentDrawCards", 1 },
		{ "BanishFromCenterRow", 1 },
	};
	effect_text = "Draw two cards.  Each other player may draw a card.  Then you may banish a card in the center row.";

   ai = {
      trivial_draw = 2,

      gain_draw = 2,
   },

   image_large = { "SG_AskaraFate", {0, 0, 364/512, 1} };
   image_medium = { "SG_AskaraFate", {392/512, 0, 512/512, 168/512} };
   image_small = { "SG_AskaraFate", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "SG_AskaraFate", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Soul Gem - Master Dhartha"] = { 
	card_name = "Soul Gem - Master Dhartha";
	display_name = "Master Dhartha";
	card_set = "IH";
	card_type = "Soul Gem";
	faction = "none";
	rune_cost = 0;
	honor = 0;
	effect = { "DrawCards", 3 };
	effect_text = "Draw three cards.";
   
   ai = {
      trivial_draw = 3,

      gain_draw = 3;
   },

   image_large = { "SG_MasterDhartha", {0, 0, 364/512, 1} };
   image_medium = { "SG_MasterDhartha", {392/512, 0, 512/512, 168/512} };
   image_small = { "SG_MasterDhartha", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "SG_MasterDhartha", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Soul Gem - Seer of the Forked Path"] = { 
	card_name = "Soul Gem - Seer of the Forked Path";
	display_name = "Seer of the Forked Path";
	card_set = "IH";
	card_type = "Soul Gem";
	faction = "none";
	rune_cost = 0;
	honor = 0;
   
	effects = {
		{ "DrawCards", 1 },
		{ "BanishFromCenterRow", 1 },
	};
	effect_text = "Draw a card.  Then you may banish a card in the center row.";

   ai = {
      gain_draw = 1;
   },

   image_large = { "SG_SeerForkedPath", {0, 0, 364/512, 1} };
   image_medium = { "SG_SeerForkedPath", {392/512, 0, 512/512, 168/512} };
   image_small = { "SG_SeerForkedPath", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "SG_SeerForkedPath", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}









g_ascension_cards["Soul Gem - Druids of the Stone Circle"] = { 
	card_name = "Soul Gem - Druids of the Stone Circle";
	display_name = "Druids of the Stone Circle";
	card_set = "IH";
	card_type = "Soul Gem";
	faction = "none";
	rune_cost = 0;
	honor = 0;
   
	effect = { "AcquireHeroToTopOfDeck", 3 };
	effect_text = "Acquire a Hero that costs R3 or less.  Place it on top of your deck.";
   
   image_large = { "SG_DruidsStoneCircle", {0, 0, 364/512, 1} };
   image_medium = { "SG_DruidsStoneCircle", {392/512, 0, 512/512, 168/512} };
   image_small = { "SG_DruidsStoneCircle", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "SG_DruidsStoneCircle", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Soul Gem - Great-Omen Raven"] = { 
	card_name = "Soul Gem - Great-Omen Raven";
	display_name = "Great-Omen Raven";
	card_set = "IH";
	card_type = "Soul Gem";
	faction = "none";
	rune_cost = 0;
	honor = 0;
	effects = {
      { "ChooseCardNameFromDeck", 0 },
      { "RevealTopCardOfDeck", 0 },
      { "GainHonor", 3, condition={"IfTopOfDeckIsSameNameAsEffectInstanceData",0} },
      { "Pause", 0 },
      { "PopResolvingCardFromEffectData", 0 },
      { "PopAndDrawRevealedCard", 1 },
	};
	effect_text = "Name a card.  Reveal the top card of your deck and put it into your hand.  If it is the named card, gain 3H.";

   ai = {
      --trivial_draw = 1,

      gain_draw = 1;
   },
   
   image_large = { "SG_GreatOmenRaven", {0, 0, 364/512, 1} };
   image_medium = { "SG_GreatOmenRaven", {392/512, 0, 512/512, 168/512} };
   image_small = { "SG_GreatOmenRaven", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "SG_GreatOmenRaven", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Soul Gem - Landtalker"] = { 
	card_name = "Soul Gem - Landtalker";
	display_name = "Landtalker";
	card_set = "IH";
	card_type = "Soul Gem";
	faction = "none";
	rune_cost = 0;
	honor = 0;
	effect = { "GainRunes", 3 };
	effect_text = "Gain 3R.";
   
   ai = {
      trivial = true,

      gain_rune = 3;
   },

   image_large = { "SG_Landtalker", {0, 0, 364/512, 1} };
   image_medium = { "SG_Landtalker", {392/512, 0, 512/512, 168/512} };
   image_small = { "SG_Landtalker", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "SG_Landtalker", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Soul Gem - Lifebound Initiate"] = { 
	card_name = "Soul Gem - Lifebound Initiate";
	display_name = "Lifebound Initiate";
	card_set = "IH";
	card_type = "Soul Gem";
	faction = "none";
	rune_cost = 0;
	honor = 0;
   
	effects = {
		{ "GainRunes", 1 },
		{ "GainHonor", 1 },
	};
	effect_text = "Gain 1R and 1H.";
   
   ai = {
      trivial = true,

      gain_rune = 1;
      gain_honor = 1;
   },

   image_large = { "SG_LifeboundInitiate", {0, 0, 364/512, 1} };
   image_medium = { "SG_LifeboundInitiate", {392/512, 0, 512/512, 168/512} };
   image_small = { "SG_LifeboundInitiate", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "SG_LifeboundInitiate", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Soul Gem - Runic Lycanthrope"] = { 
	card_name = "Soul Gem - Runic Lycanthrope";
	display_name = "Runic Lycanthrope";
	card_set = "IH";
	card_type = "Soul Gem";
	faction = "none";
	rune_cost = 0;
	honor = 0;
   
	effects = {
		{ "GainRunes", 2 },
		{ "GainPower", 2, condition={"IfPlayedLifeboundHero",1} },
	};
	effect_text = "Gain 2R.  If you've played a Lifebound Hero this turn, gain 2P.";

   ai = {
      gain_rune = 2;
   },

   image_large = { "SG_RunicLycanthrope", {0, 0, 364/512, 1} };
   image_medium = { "SG_RunicLycanthrope", {392/512, 0, 512/512, 168/512} };
   image_small = { "SG_RunicLycanthrope", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "SG_RunicLycanthrope", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Soul Gem - Wolf Shaman"] = { 
	card_name = "Soul Gem - Wolf Shaman";
	display_name = "Wolf Shaman";
	card_set = "IH";
	card_type = "Soul Gem";
	faction = "none";
	rune_cost = 0;
	honor = 0;
   
	effects = {
		{ "GainRunes", 1 },
		{ "DrawCards", 1 },
	};
	effect_text = "Gain 1R.  Draw a card.";
   
   ai = {
      trivial_draw = 1,

      gain_rune = 1;
      gain_draw = 1;
   },
   
   image_large = { "SG_WolfShaman", {0, 0, 364/512, 1} };
   image_medium = { "SG_WolfShaman", {392/512, 0, 512/512, 168/512} };
   image_small = { "SG_WolfShaman", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "SG_WolfShaman", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}











g_ascension_cards["Soul Gem - Avatar Golem"] = { 
	card_name = "Soul Gem - Avatar Golem";
	display_name = "Avatar Golem";
	card_set = "IH";
	card_type = "Soul Gem";
	faction = "none";
	rune_cost = 0;
	honor = 0;
	effects = {
		{ "GainPower", 2 },
		{ "GainHonorForEachTypeOfConstructInPlay", 1 },
	};
	effect_text = "Gain 2P.  Gain 1H for each type of Construct you control.";

   ai = {
      gain_power = 2;
   },

   image_large = { "SG_AvatarGolem", {0, 0, 364/512, 1} };
   image_medium = { "SG_AvatarGolem", {392/512, 0, 512/512, 168/512} };
   image_small = { "SG_AvatarGolem", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "SG_AvatarGolem", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Soul Gem - Dimension Diver"] = { 
	card_name = "Soul Gem - Dimension Diver";
	display_name = "Dimension Diver";
	card_set = "IH";
	card_type = "Soul Gem";
	faction = "none";
	rune_cost = 0;
	honor = 0;
   
	effects = {
		{ "GainRunes", 2 },
		{ "AllConstructsAreMechanaUntilEndOfTurn", 0 },
	};
	effect_text = "Gain 2R.  You may treat all Constructs as Mechana Constructs this turn.";

   ai = {
      trivial = true,

      gain_rune = 2;
   },

   image_large = { "SG_DimensionDiver", {0, 0, 364/512, 1} };
   image_medium = { "SG_DimensionDiver", {392/512, 0, 512/512, 168/512} };
   image_small = { "SG_DimensionDiver", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "SG_DimensionDiver", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Soul Gem - Mechana Initiate"] = { 
	card_name = "Soul Gem - Mechana Initiate";
	display_name = "Mechana Initiate";
	card_set = "IH";
	card_type = "Soul Gem";
	faction = "none";
	rune_cost = 0;
	honor = 0;
   
	effects = {
		{ "ChooseFromEffectList",
			{
            prompt = "Choose Rune or Power",
				{
					{ "GainRunes", 1 },
					description = "Gain 1 Rune",
				},
				{
					{ "GainPower", 1 },
					description = "Gain 1 Power",
				},
			}
		}			
	};
	effect_text = "Gain 1R or 1P.";

   ai = {
      gain_rune = 0.5;
      gain_power = 0.5;
   },

   image_large = { "SG_MechanaInitiate", {0, 0, 364/512, 1} };
   image_medium = { "SG_MechanaInitiate", {392/512, 0, 512/512, 168/512} };
   image_small = { "SG_MechanaInitiate", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "SG_MechanaInitiate", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Soul Gem - Reactor Monk"] = { 
	card_name = "Soul Gem - Reactor Monk";
	display_name = "Reactor Monk";
	card_set = "IH";
	card_type = "Soul Gem";
	faction = "none";
	rune_cost = 0;
	honor = 0;
	effects = {
		{ "GainRunes", 2 },
		{ "NextContructYouAcquireCostsLess", 1 },
	};
   
   ai = {
      trivial = true,

      gain_rune = 2,
   },

	effect_text = "Gain 2R.  The next Construct you acquire this turn costs 1R less.";

   image_large = { "SG_ReactorMonk", {0, 0, 364/512, 1} };
   image_medium = { "SG_ReactorMonk", {392/512, 0, 512/512, 168/512} };
   image_small = { "SG_ReactorMonk", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "SG_ReactorMonk", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}









g_ascension_cards["Soul Gem - Arbiter of Fate"] = { 
	card_name = "Soul Gem - Arbiter of Fate";
	display_name = "Arbiter of Fate";
	card_set = "IH";
	card_type = "Soul Gem";
	faction = "none";
	rune_cost = 0;
	honor = 0;

	--center_row = { "EachPlayerMayBanishFromHandOrDiscard", 1 },

	effects = {
		{ "DrawCards", 1 },
		{ "BanishFromHandOrDiscard", 1 },
	};
	--effect_text = "FATE: When this enters the center row, each player may banish a card from their hand or discard pile.\n" ..
	--               "Draw a card. You may banish a card in your hand or discard pile.";
	effect_text = "Draw a card. You may banish a card in your hand or discard pile.";

   ai = {
      trivial_draw = 1,

      gain_draw = 1;
   },

   image_large = { "SG_ArbiterFate", {0, 0, 364/512, 1} };
   image_medium = { "SG_ArbiterFate", {392/512, 0, 512/512, 168/512} };
   image_small = { "SG_ArbiterFate", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "SG_ArbiterFate", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Soul Gem - Demon Slayer"] = { 
	card_name = "Soul Gem - Demon Slayer";
	display_name = "Demon Slayer";
	card_set = "IH";
	card_type = "Soul Gem";
	faction = "none";
	rune_cost = 0;
	honor = 0;
	effect = { "GainPower", 3 };
	effect_text = "Gain 3P.";
   
   ai = {
      trivial = true,

      gain_power = 3;
   },

   image_large = { "SG_DemonSlayer", {0, 0, 364/512, 1} };
   image_medium = { "SG_DemonSlayer", {392/512, 0, 512/512, 168/512} };
   image_small = { "SG_DemonSlayer", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "SG_DemonSlayer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Soul Gem - Shade of the Black Watch"] = { 
	card_name = "Soul Gem - Shade of the Black Watch";
	display_name = "Shade of the Black Watch";
	card_set = "IH";
	card_type = "Soul Gem";
	faction = "none";
	rune_cost = 0;
	honor = 0;
   
	effects = {
		{ "GainPower", 2 },
		{ "BanishFromHandOrDiscard", 1 },
	};
	effect_text = "Gain 2P.  You may banish a card in your hand or discard pile.";

   ai = {
      gain_power = 2;
   },

   image_large = { "SG_ShadeBlackWatch", {0, 0, 364/512, 1} };
   image_medium = { "SG_ShadeBlackWatch", {392/512, 0, 512/512, 168/512} };
   image_small = { "SG_ShadeBlackWatch", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "SG_ShadeBlackWatch", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Soul Gem - Spike Vixen"] = { 
	card_name = "Soul Gem - Spike Vixen";
	display_name = "Spike Vixen";
	card_set = "IH";
	card_type = "Soul Gem";
	faction = "none";
	rune_cost = 0;
	honor = 0;
	effects = {
		{ "GainPower", 1 },
		{ "DrawCards", 1 },
	};
   
   ai = {
      trivial_draw = 1,

      gain_power = 1,
      gain_draw = 1,
   },

	effect_text = "Gain 1P.  Draw a card.";

   image_large = { "SG_SpikeVixen", {0, 0, 364/512, 1} };
   image_medium = { "SG_SpikeVixen", {392/512, 0, 512/512, 168/512} };
   image_small = { "SG_SpikeVixen", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "SG_SpikeVixen", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Soul Gem - Void Initiate"] = { 
	card_name = "Soul Gem - Void Initiate";
	display_name = "Void Initiate";
	card_set = "IH";
	card_type = "Soul Gem";
	faction = "none";
	rune_cost = 0;
	honor = 0;
	effects = {
		{ "GainRunes", 1 },
		{ "BanishFromHandOrDiscard", 1 },
	};
	effect_text = "Gain 1R.  You may banish a card in your hand or discard pile.";

   ai = {
      gain_rune = 1;
   },

   image_large = { "SG_VoidInitiate", {0, 0, 364/512, 1} };
   image_medium = { "SG_VoidInitiate", {392/512, 0, 512/512, 168/512} };
   image_small = { "SG_VoidInitiate", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "SG_VoidInitiate", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}




