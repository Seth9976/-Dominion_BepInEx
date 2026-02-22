


g_ascension_cards["Militia 10TH"] = { 
	card_name = "Militia 10TH";
	display_name = "Militia";
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
      
   image_large = { "H_Militia10", {0, 0, 364/512, 1} };
   image_medium = { "H_Militia10", {392/512, 0, 512/512, 168/512} };
   image_small = { "H_Militia10", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "H_Militia10", {384/512, 395/512, 512/512, 512/512} };
}

g_ascension_cards["Apprentice 10TH"] = { 
	card_name = "Apprentice 10TH";
	display_name = "Apprentice";
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

   image_large = { "H_Apprentice10", {0, 0, 364/512, 1} };
   image_medium = { "H_Apprentice10", {392/512, 0, 512/512, 168/512} };
   image_small = { "H_Apprentice10", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "H_Apprentice10", {384/512, 395/512, 512/512, 512/512} };
}

g_ascension_cards["Mystic 10TH"] = { 
	card_name = "Mystic 10TH";
   display_name = "Mystic";
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

   image_large = { "H_Mystic10", {0, 0, 364/512, 1} };
   image_medium = { "H_Mystic10", {392/512, 0, 512/512, 168/512} };
   image_small = { "H_Mystic10", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "H_Mystic10", {384/512, 395/512, 512/512, 512/512} };
}

g_ascension_cards["Heavy Infantry 10TH"] = { 
	card_name = "Heavy Infantry 10TH";
   display_name = "Heavy Infantry";
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

   image_large = { "H_HeavyInfantry10", {0, 0, 364/512, 1} };
   image_medium = { "H_HeavyInfantry10", {392/512, 0, 512/512, 168/512} };
   image_small = { "H_HeavyInfantry10", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "H_HeavyInfantry10", {384/512, 395/512, 512/512, 512/512} };
}

g_ascension_cards["Cultist 10TH"] = { 
	card_name = "Cultist 10TH";
	display_name = "Cultist";
	card_type = "Monster";
	power_cost = 2;
   do_not_put_in_void = true;
	reward = { "GainHonor", 1 };
	effect_text = "Reward: Gain 1H.";
   image_large = { "M_Cultist10", {0, 0, 364/512, 1} };
   image_medium = { "M_Cultist10", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_Cultist10", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_Cultist10", {384/512, 395/512, 512/512, 512/512} };
}

g_ascension_cards["Arha Initiate 10TH"] = { 
	card_name = "Arha Initiate 10TH";
	display_name = "Arha Initiate";
	card_set = "CotG10";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 1;
	honor = 1;
	effect = { "DrawCards", 1 };
	effect_text = "Draw a card.";
   
   ai = {
      trivial_draw = 1,

      gain_draw = 1;
   },

   image_large = { "EH_ArhaInitiate", {0, 0, 364/512, 1} };
   image_medium = { "EH_ArhaInitiate", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_ArhaInitiate", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_ArhaInitiate", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}

g_ascension_cards["Arha Templar 10TH"] = { 
	card_name = "Arha Templar 10TH";
	display_name = "Arha Templar";
	card_set = "CotG10";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 4;
	honor = 3;
	effect = { "DefeatMonsterWithLessPower", 4 };
	--effect_text = "Defeat a Monster that has P4 or less.";
	effect_text = "Defeat a Monster with cost P4 or less for free.";

   ai = {
      defeat_monster = 4;
   },

   image_large = { "EH_ArhaTemplar", {0, 0, 364/512, 1} };
   image_medium = { "EH_ArhaTemplar", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_ArhaTemplar", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_ArhaTemplar", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Ascetic of the Lidless Eye 10TH"] = { 
	card_name = "Ascetic of the Lidless Eye 10TH";
	display_name = "Ascetic of the Lidless Eye";
	card_set = "CotG10";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 5;
	--honor = 2;
	honor = 3;
	effect = { "DrawCards", 2 };
	effect_text = "Draw two cards.";
   
   ai = {
      trivial_draw = 2,

      gain_draw = 2;
   },

   image_large = { "EH_AsceticLidlessEye", {0, 0, 364/512, 1} };
   image_medium = { "EH_AsceticLidlessEye", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_AsceticLidlessEye", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_AsceticLidlessEye", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Master Dhartha 10TH"] = { 
	card_name = "Master Dhartha 10TH";
	display_name = "Master Dhartha";
	card_set = "CotG10";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 7;
	--honor = 3;
	honor = 4;
	effect = { "DrawCards", 3 };
	effect_text = "Draw three cards.";
   
   ai = {
      trivial_draw = 3,

      gain_draw = 3;
   },

   image_large = { "EH_MasterDhartha", {0, 0, 364/512, 1} };
   image_medium = { "EH_MasterDhartha", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_MasterDhartha", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_MasterDhartha", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_cards["Oziah the Peerless 10TH"] = { 
	card_name = "Oziah the Peerless 10TH";
	display_name = "Oziah the Peerless";
	card_set = "CotG10";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 6;
	honor = 3;
	effect = { "DefeatMonsterWithLessPower", 6 };
	--effect_text = "Defeat a Monster that has P6 or less.";
	effect_text = "Defeat a Monster with cost P6 or less for free.";

   ai = {
      defeat_monster = 6;
   },

   image_large = { "EH_OziahPeerless", {0, 0, 364/512, 1} };
   image_medium = { "EH_OziahPeerless", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_OziahPeerless", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_OziahPeerless", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Seer of the Forked Path 10TH"] = { 
	card_name = "Seer of the Forked Path 10TH";
	display_name = "Seer of the Forked Path";
	card_set = "CotG10";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 2;
	honor = 1;
	effects = {
		{ "DrawCards", 1 },
		{ "BanishFromCenterRow", 1 },
	};
	effect_text = "Draw a card.  Then you may banish a card in the center row.";

   ai = {
      gain_draw = 1;
   },

   image_large = { "EH_SeerForkedPath", {0, 0, 364/512, 1} };
   image_medium = { "EH_SeerForkedPath", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_SeerForkedPath", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_SeerForkedPath", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Tablet of Time's Dawn 10TH"] = { 
	card_name = "Tablet of Time's Dawn 10TH";
	display_name = "Tablet of Time's Dawn";
	card_set = "CotG10";
	card_type = "Construct";
	faction = "Enlightened";
	rune_cost = 5;
	--honor = 2;
	honor = 3;
	construct_ability = {
		description = "Gain a Turn";
		{ "TakeAnAdditionalTurn", 0 },
		{ "BanishThisConstruct", 0 },

      ai = {
         use_at_end_of_turn = true,
      },
	};
	effect_text = "Banish this Construct to take an additional turn after this one.";
   image_large = { "EC_TabletTimesDawn", {0, 0, 364/512, 1} };
   image_medium = { "EC_TabletTimesDawn", {392/512, 0, 512/512, 168/512} };
   image_small = { "EC_TabletTimesDawn", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EC_TabletTimesDawn", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Temple Librarian 10TH"] = { 
	card_name = "Temple Librarian 10TH";
	display_name = "Temple Librarian";
	card_set = "CotG10";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 2;
	honor = 1;
	effects = {
		{ "DiscardFromHand", 0 },
		{ "DrawCards", 2, condition={"IfYouDo",0} },
	};
	effect_text = "Discard a card.  If you do, draw two cards.";
   
   ai = {
      might_not_play = true,
   },

   image_large = { "EH_TempleLibrarian", {0, 0, 364/512, 1} };
   image_medium = { "EH_TempleLibrarian", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_TempleLibrarian", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_TempleLibrarian", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}

g_ascension_cards["The All-Seeing Eye 10TH"] = { 
	card_name = "The All-Seeing Eye 10TH";
	display_name = "The All-Seeing Eye";
	card_set = "CotG10";
	card_type = "Construct";
	faction = "Enlightened";
	rune_cost = 6;
	--honor = 2;
	honor = 3;
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
   image_large = { "EC_AllSeeingEye", {0, 0, 364/512, 1} };
   image_medium = { "EC_AllSeeingEye", {392/512, 0, 512/512, 168/512} };
   image_small = { "EC_AllSeeingEye", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EC_AllSeeingEye", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_cards["Twofold Askara 10TH"] = { 
	card_name = "Twofold Askara 10TH";
	display_name = "Twofold Askara";
	card_set = "CotG10";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 4;
	honor = 2;
	effect = { "CopyEffectOfAnyPlayedHero", 0 };

   ai = {
      requires_copyable_played_card = true,
   },

   effect_text = "Copy the effect of a Hero played this turn.";
   image_large = { "EH_TwofoldAskara", {0, 0, 364/512, 1} };
   image_medium = { "EH_TwofoldAskara", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_TwofoldAskara", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_TwofoldAskara", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}



g_ascension_cards["Cetra, Weaver of Stars 10TH"] = { 
	card_name = "Cetra, Weaver of Stars 10TH";
	display_name = "Cetra, Weaver of Stars";
	card_set = "CotG10";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 7;
	honor = 4;
	--honor = 5;
	effect = { "AcquireHeroToTopOfDeck", 0 };
	--effect_text = "Acquire any Hero.  Place it on top of your deck.";
	effect_text = "Acquire a Hero without paying its cost.  Place it on top of your deck.";
   image_large = { "LH_CetraWeaverStars", {0, 0, 364/512, 1} };
   image_medium = { "LH_CetraWeaverStars", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_CetraWeaverStars", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_CetraWeaverStars", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_cards["Druids of the Stone Circle 10TH"] = { 
	card_name = "Druids of the Stone Circle 10TH";
	display_name = "Druids of the Stone Circle";
	card_set = "CotG10";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 4;
	honor = 3;
	--effect = { "AcquireHeroToTopOfDeck", 3 };
	effect = { "AcquireHeroToTopOfDeck", 4 };
	--effect_text = "Acquire a Hero that costs R3 or less.  Place it on top of your deck.";
	effect_text = "Acquire a Hero with cost R4 or less without paying its cost. Place it on top of your deck.";
	
   image_large = { "LH_DruidsStoneCircle", {0, 0, 364/512, 1} };
   image_medium = { "LH_DruidsStoneCircle", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_DruidsStoneCircle", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_DruidsStoneCircle", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Flytrap Witch 10TH"] = { 
	card_name = "Flytrap Witch 10TH";
	display_name = "Flytrap Witch";
	card_set = "CotG10";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 5;
	honor = 2;
	effects = {
		{ "GainHonor", 2 },
		{ "DrawCards", 1 },
	};
   
   ai = {
      trivial_draw = 1,

      gain_honor = 2,
      gain_draw = 1,
   },

	effect_text = "Gain 2H.  Draw a card.";
   image_large = { "LH_FlytrapWitch", {0, 0, 364/512, 1} };
   image_medium = { "LH_FlytrapWitch", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_FlytrapWitch", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_FlytrapWitch", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Landtalker 10TH"] = { 
	card_name = "Landtalker 10TH";
	display_name = "Landtalker";
	card_set = "CotG10";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 6;
	--honor = 3;
	honor = 4;
	effect = { "GainRunes", 3 };
	effect_text = "Gain 3R.";
   
   ai = {
      trivial = true,

      gain_rune = 3;
   },

   image_large = { "LH_Landtalker", {0, 0, 364/512, 1} };
   image_medium = { "LH_Landtalker", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_Landtalker", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_Landtalker", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_cards["Lifebound Initiate 10TH"] = { 
	card_name = "Lifebound Initiate 10TH";
	display_name = "Lifebound Initiate";
	card_set = "CotG10";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 1;
	honor = 1;
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

   image_large = { "LH_LifeboundInitiate", {0, 0, 364/512, 1} };
   image_medium = { "LH_LifeboundInitiate", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_LifeboundInitiate", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_LifeboundInitiate", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_active_effects["unite 2P"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayLifeboundHero", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerGainPower", 2 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

g_ascension_cards["Runic Lycanthrope 10TH"] = { 
	card_name = "Runic Lycanthrope 10TH";
	display_name = "Runic Lycanthrope";
	card_set = "CotG10";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 3;
	honor = 1;
	effects = {
		{ "GainRunes", 2 },
		--{ "GainPower", 2, condition={"IfPlayedLifeboundHero",1} },
		{ "GainPower", 2, condition={"IfPlayedLifeboundHero",1} },
        { "Unite2P", 0, condition={"IfHaventPlayedLifeboundHero",1} },
	};
	--effect_text = "Gain 2R.  If you've played a Lifebound Hero this turn, gain 2P.";
	effect_text = "Gain 2R. Unite: If you play or have played another Lifebound Hero this turn, gain 2P.";

   ai = {
      gain_rune = 2;
   },

   image_large = { "LH_RunicLycanthrope", {0, 0, 364/512, 1} };
   image_medium = { "LH_RunicLycanthrope", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_RunicLycanthrope", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_RunicLycanthrope", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Snapdragon 10TH"] = { 
	card_name = "Snapdragon 10TH";
	display_name = "Snapdragon";
	card_set = "CotG10";
	card_type = "Construct";
	faction = "Lifebound";
	rune_cost = 5;
	--honor = 2;
	honor = 3;
	--construct_ability = {
	--	description = "Gain 1R";
	--	{ "GainRunes", 1 },
    --  
    --  ai = {
    --     trivial = true,
    --  },
	--};
	--triggered_effects = {
	--	{
	--		conditions = {
	--			{ "IfThisHasntBeenUsedThisTurn", 0 },
	--			{ "WhenConstructOwnerPlaysFirstLifeboundHero", 0 },
	--		};
	--		triggereffect = {
	--			{ "TriggerConstructGainHonor", 1 },
	--			{ "TriggerSetThisHasBeenUsedThisTurn", 0 },
	--		};
	--	},
	--};
	construct_abilities = {
      {
		description = "Gain 1R";
		{ "GainRunes", 1 },

         ai = {
            trivial = true,
         },
      },
      {
         description = "Gain 1H";
         condition = { "IfPlayedLifeboundHero", 1 },
         { "GainHonor", 1 },

         ai = {
            trivial = true,
         },
      },
   };
	--effect_text = "Once per turn, gain 1R.  The first time you play a Lifebound Hero each turn, gain 1H.";
	effect_text = "Once per turn, gain 1R. Unite: If you play or have played a Lifebound Hero this turn, gain 1H.";

   ai = {
      gain_rune = 1;
   },

   image_large = { "LC_Snapdragon", {0, 0, 364/512, 1} };
   image_medium = { "LC_Snapdragon", {392/512, 0, 512/512, 168/512} };
   image_small = { "LC_Snapdragon", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LC_Snapdragon", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Wolf Shaman 10TH"] = { 
	card_name = "Wolf Shaman 10TH";
	display_name = "Wolf Shaman";
	card_set = "CotG10";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 3;
	honor = 1;
	effects = {
		{ "GainRunes", 1 },
		{ "DrawCards", 1 },
	};
   
   ai = {
      trivial_draw = 1,

      gain_rune = 1;
      gain_draw = 1;
   },

	effect_text = "Gain 1R.  Draw a card.";
   image_large = { "LH_WolfShaman", {0, 0, 364/512, 1} };
   image_medium = { "LH_WolfShaman", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_WolfShaman", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_WolfShaman", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Yggdrasil Staff 10TH"] = { 
	card_name = "Yggdrasil Staff 10TH";
	display_name = "Yggdrasil Staff";
	card_set = "CotG10";
	card_type = "Construct";
	faction = "Lifebound";
	rune_cost = 4;
	honor = 2;
	construct_abilities = {
		{
			ability_name = "Yggdrasil Staff to gain 1 Power",
			description = "Gain 1P";
			{ "GainPower", 1 },
      
         ai = {
            trivial = true,
         },
		},
		{
			ability_name = "Yggdrasil Staff to gain 3 Honor",
			description = "Gain 3H for 4R";
			condition = { "IfHasCurrentTurnRunes", 4 },
         { "PayRunes", 4 },
			{ "GainHonor", 3 },

         ai = {
            use_at_end_of_turn = true,
         },
		},
	};
	effect_text = "Once per turn, gain 1P.\nOnce per turn, you may spend 4R to gain 3H.";

   ai = {
      gain_power = 1;
   },

   image_large = { "LC_YggdrasilStaff", {0, 0, 364/512, 1} };
   image_medium = { "LC_YggdrasilStaff", {392/512, 0, 512/512, 168/512} };
   image_small = { "LC_YggdrasilStaff", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LC_YggdrasilStaff", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}




g_ascension_cards["Avatar Golem 10TH"] = { 
	card_name = "Avatar Golem 10TH";
	display_name = "Avatar Golem";
	card_set = "CotG10";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 4;
	honor = 2;
	effects = {
		{ "GainPower", 2 },
		{ "GainHonorForEachTypeOfConstructInPlay", 1 },
	};
	effect_text = "Gain 2P.  Gain 1H for each type of Construct you control.";

   ai = {
      gain_power = 2;
   },

   image_large = { "MH_AvatarGolem", {0, 0, 364/512, 1} };
   image_medium = { "MH_AvatarGolem", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_AvatarGolem", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_AvatarGolem", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Burrower Mark II 10TH"] = { 
	card_name = "Burrower Mark II 10TH";
	display_name = "Burrower Mark II";
	card_set = "CotG10";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 3;
	honor = 3;
	triggered_effects = {
		{
			conditions = {
				{ "IfThisHasntBeenUsedThisTurn", 0 },
				{ "WhenYouPutFirstMechanaConstructIntoPlay", 0 },
			};
			triggereffect = {
				{ "TriggerConstructOwnerDrawCards", 1 },
				{ "TriggerSetThisHasBeenUsedThisTurn", 0 },
			};
		},
	};
	effect_text = "Draw a card the first time you put a Mechana construct into play each turn (including this one).";

   image_large = { "MC_BurrowerMarkII", {0, 0, 364/512, 1} };
   image_medium = { "MC_BurrowerMarkII", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_BurrowerMarkII", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_BurrowerMarkII", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Hedron Cannon 10TH"] = { 
	card_name = "Hedron Cannon 10TH";
	display_name = "Hedron Cannon";
	card_set = "CotG10";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 8;
	honor = 8;
	construct_ability = {
		description = "Gain X Power";
		{ "GainPowerForEachMechanaConstructInPlay", 1 },
	};
	effect_text = "Once per turn, gain 1P for each Mechana Construct you control.";
   image_large = { "MC_HedronCannon", {0, 0, 364/512, 1} };
   image_medium = { "MC_HedronCannon", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_HedronCannon", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_HedronCannon", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Hedron Link Device 10TH"] = { 
	card_name = "Hedron Link Device 10TH";
	display_name = "Hedron Link Device";
	card_set = "CotG10";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 7;
	honor = 7;
	continuous_effects = {
		{
			effect = {"OwnerTreatsAllConstructsAsMechanaConstructs", 0 };
		},
	};
	effect_text = "You may treat all Constructs as Mechana Constructs.";
   image_large = { "MC_HedronLinkDevice", {0, 0, 364/512, 1} };
   image_medium = { "MC_HedronLinkDevice", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_HedronLinkDevice", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_HedronLinkDevice", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Kor, the Ferromancer 10TH"] = { 
	card_name = "Kor, the Ferromancer 10TH";
	display_name = "Kor, the Ferromancer";
	card_set = "CotG10";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 3;
	--honor = 2;
	honor = 3;
	effects = {
		{ "GainPower", 2 },
		{ "DrawCards", 1, condition={"IfYouControlConstructs",2} },
	};

   ai = {
      gain_power = 2;
   },

	effect_text = "Gain 2P.  Draw a card if you control 2 or more Constructs.";
   image_large = { "MH_KorFerromancer", {0, 0, 364/512, 1} };
   image_medium = { "MH_KorFerromancer", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_KorFerromancer", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_KorFerromancer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Mechana Initiate 10TH"] = { 
	card_name = "Mechana Initiate 10TH";
	display_name = "Mechana Initiate";
	card_set = "CotG10";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 1;
	honor = 1;
	effects = {
		--{ "ChooseFromEffectList",
		--	{
        --    prompt = "Choose Rune or Power",
		--		{
		--			{ "GainRunes", 1 },
		--			description = "Gain 1 Rune",
		--		},
		--		{
		--			{ "GainPower", 1 },
		--			description = "Gain 1 Power",
		--		},
		--	}
		--}			
		{ "GainRunes", 1 },
		{ "GainPower", 1 },
	};
	--effect_text = "Gain 1R or 1P.";
	effect_text = "Gain 1R and 1P.";

   ai = {
      gain_rune = 0.5;
      gain_power = 0.5;
   },

   image_large = { "MH_MechanaInitiate", {0, 0, 364/512, 1} };
   image_medium = { "MH_MechanaInitiate", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_MechanaInitiate", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_MechanaInitiate", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_active_effects["construct acquired costs 1 less"] = {
	type = "continuous";
	effectfunc = { "ReduceConstructRuneCost", 1 };
}


g_ascension_cards["Reactor Monk 10TH"] = { 
	card_name = "Reactor Monk 10TH";
	display_name = "Reactor Monk";
	card_set = "CotG10";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 4;
	honor = 2;
	effects = {
		{ "GainRunes", 2 },
		{ "NextContructYouAcquireCostsLess", 1 },
	};
   
   ai = {
      trivial = true,

      gain_rune = 2,
   },

	effect_text = "Gain 2R.  The next Construct you acquire this turn costs 1R less.";
   image_large = { "MH_ReactorMonk", {0, 0, 364/512, 1} };
   image_medium = { "MH_ReactorMonk", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_ReactorMonk", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_ReactorMonk", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Rocket Courier X-99 10TH"] = { 
	card_name = "Rocket Courier X-99 10TH";
	display_name = "Rocket Courier X-99";
	card_set = "CotG10";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 4;
	honor = 4;

	--triggered_effects = {
	--	{
	--		version_before = 1;
	--		conditions = {
	--			{ "IfThisHasntBeenUsedThisTurn", 0 },
	--			{ "WhenYouAcquireMechanaConstruct", 0 },
	--		};
	--		triggereffect = {
	--			{ "TriggerMayPutConstructIntoPlay", 1 },
	--		};
	--	},
	--};

	continuous_effects = {
		{
			--version_after = 2;
			--effect = { "MayPutAcquiredMechanaConstructIntoPlayOncePerTurn", 0 };
			effect = { "MayPutAcquiredMechanaConstructIntoHandOncePerTurn", 0 };
		},
	};

   --effect_text = "Once per turn, when you acquire another Mechana Construct, you may put it directly into play.";
   effect_text = "Once per turn, when you acquire another Mechana Construct, you may put it in your hand.";
   
   image_large = { "MC_RocketCourierX99", {0, 0, 364/512, 1} };
   image_medium = { "MC_RocketCourierX99", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_RocketCourierX99", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_RocketCourierX99", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["The Grand Design 10TH"] = { 
	card_name = "The Grand Design 10TH";
	display_name = "The Grand Design";
	card_set = "CotG10";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 6;
	honor = 6;
	construct_ability = {
		description = "Gain 2R *";
		{ "GainRunesForMechanaConstruct", 2 },
      
      ai = {
         trivial = true,
      },
	};
	effect_text = "Once per turn, gain 2R.  You may spend it only to acquire Mechana Constructs.";

   ai = {
      gain_rune_mechana = 2;
   },

   image_large = { "MC_GrandDesign", {0, 0, 364/512, 1} };
   image_medium = { "MC_GrandDesign", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_GrandDesign", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_GrandDesign", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Watchmaker's Altar 10TH"] = { 
	card_name = "Watchmaker's Altar 10TH";
	display_name = "Watchmaker's Altar";
	card_set = "CotG10";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 5;
	honor = 5;
	construct_ability = {
		description = "Gain 1R *";
		{ "GainRunesForMechanaConstruct", 1 },
      
      ai = {
         trivial = true,
      },
	};
	effect_text = "Once per turn, gain 1R.  You may spend it only to acquire Mechana Constructs.";

   ai = {
      gain_rune_mechana = 1;
   },

   image_large = { "MC_WatchmakersAltar", {0, 0, 364/512, 1} };
   image_medium = { "MC_WatchmakersAltar", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_WatchmakersAltar", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_WatchmakersAltar", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Arbiter of the Precipice 10TH"] = { 
	card_name = "Arbiter of the Precipice 10TH";
	display_name = "Arbiter of the Precipice";
	card_set = "CotG10";
	card_type = "Hero";
	faction = "Void";
	--rune_cost = 4;
	rune_cost = 5;
	--honor = 1;
	honor = 3;
	effects = {
		{ "DrawCards", 2 },
		{ "BanishFromHand", 0 },
	};
	effect_text = "Draw two cards.  Then banish any card in your hand.";
   
   ai = {
      might_not_play = true,
   },

   image_large = { "VH_ArbiterPrecipice", {0, 0, 364/512, 1} };
   image_medium = { "VH_ArbiterPrecipice", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_ArbiterPrecipice", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_ArbiterPrecipice", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Demon Slayer 10TH"] = { 
	card_name = "Demon Slayer 10TH";
	display_name = "Demon Slayer";
	card_set = "CotG10";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 4;
	honor = 2;
	effect = { "GainPower", 3 };
	effect_text = "Gain 3P.";
   
   ai = {
      trivial = true,

      gain_power = 3;
   },

   image_large = { "VH_DemonSlayer", {0, 0, 364/512, 1} };
   image_medium = { "VH_DemonSlayer", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_DemonSlayer", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_DemonSlayer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Emri, One with the Void 10TH"] = { 
	card_name = "Emri, One with the Void 10TH";
	display_name = "Emri, One with the Void";
	card_set = "CotG10";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 6;
	--honor = 3;
	honor = 4;
	effect = { "GainPower", 4 };
	effect_text = "Gain 4P.";
   
   ai = {
      trivial = true,

      gain_power = 4;
   },

   image_large = { "VH_EmriOneVoid", {0, 0, 364/512, 1} };
   image_medium = { "VH_EmriOneVoid", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_EmriOneVoid", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_EmriOneVoid", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_cards["Muramasa 10TH"] = { 
	card_name = "Muramasa 10TH";
	display_name = "Muramasa";
	card_set = "CotG10";
	card_type = "Construct";
	faction = "Void";
	rune_cost = 7;
	honor = 4;
	construct_ability = {
		description = "Gain 3P";
		{ "GainPower", 3 },
      
      ai = {
         trivial = true,
      },
	};
	effect_text = "Once per turn, gain 3P.";

   ai = {
      gain_power = 3;
   },

   image_large = { "VC_Muramasa", {0, 0, 364/512, 1} };
   image_medium = { "VC_Muramasa", {392/512, 0, 512/512, 168/512} };
   image_small = { "VC_Muramasa", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VC_Muramasa", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_cards["Shade of the Black Watch 10TH"] = { 
	card_name = "Shade of the Black Watch 10TH";
	display_name = "Shade of the Black Watch";
	card_set = "CotG10";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 3;
	honor = 1;
	effects = {
		{ "GainPower", 2 },
		{ "BanishFromHandOrDiscard", 1 },
	};
	effect_text = "Gain 2P.  You may banish a card in your hand or discard pile.";

   ai = {
      gain_power = 2;
   },

   image_large = { "VH_ShadeBlackWatch", {0, 0, 364/512, 1} };
   image_medium = { "VH_ShadeBlackWatch", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_ShadeBlackWatch", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_ShadeBlackWatch", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}

g_ascension_cards["Shadow Star 10TH"] = { 
	card_name = "Shadow Star 10TH";
	display_name = "Shadow Star";
	card_set = "CotG10";
	card_type = "Construct";
	faction = "Void";
	rune_cost = 3;
	honor = 2;
	construct_ability = {
		description = "Gain 1P";
		{ "GainPower", 1 },
      
      ai = {
         trivial = true,
      },
	};
	effect_text = "Once per turn, gain 1P.";

   ai = {
      gain_power = 1;
   },

   image_large = { "VC_ShadowStar", {0, 0, 364/512, 1} };
   image_medium = { "VC_ShadowStar", {392/512, 0, 512/512, 168/512} };
   image_small = { "VC_ShadowStar", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VC_ShadowStar", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Spike Vixen 10TH"] = { 
	card_name = "Spike Vixen 10TH";
    display_name = "Spike Vixen";
	card_set = "CotG10";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 2;
	honor = 1;
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
   image_large = { "VH_SpikeVixen", {0, 0, 364/512, 1} };
   image_medium = { "VH_SpikeVixen", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_SpikeVixen", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_SpikeVixen", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Void Initiate 10TH"] = { 
	card_name = "Void Initiate 10TH";
	display_name = "Void Initiate";
	card_set = "CotG10";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 1;
	honor = 1;
	effects = {
		{ "GainRunes", 1 },
		{ "BanishFromHandOrDiscard", 1 },
	};
	effect_text = "Gain 1R.  You may banish a card in your hand or discard pile.";

   ai = {
      gain_rune = 1;
   },

   image_large = { "VH_VoidInitiate", {0, 0, 364/512, 1} };
   image_medium = { "VH_VoidInitiate", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_VoidInitiate", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_VoidInitiate", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Voidthirster 10TH"] = { 
	card_name = "Voidthirster 10TH";
	display_name = "Voidthirster";
	card_set = "CotG10";
	card_type = "Construct";
	faction = "Void";
	rune_cost = 5;
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
				{ "IfThisHasntBeenUsedThisTurn", 0 },
				{ "WhenConstructOwnerDefeatsFirstMonster", 0 },
			};
			triggereffect = {
				{ "TriggerConstructGainHonor", 1 },
				{ "TriggerSetThisHasBeenUsedThisTurn", 0 },
			};
		},
	};
	effect_text = "Once per turn, gain 1P.  The first time you defeat a Monster in the center row each turn, gain 1H.";

   ai = {
      gain_power = 1;
   },

   image_large = { "VC_Voidthirster", {0, 0, 364/512, 1} };
   image_medium = { "VC_Voidthirster", {392/512, 0, 512/512, 168/512} };
   image_small = { "VC_Voidthirster", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VC_Voidthirster", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}



g_ascension_cards["Avatar of the Fallen 10TH"] = { 
	card_name = "Avatar of the Fallen 10TH";
	display_name = "Avatar of the Fallen";
	card_set = "CotG10";
	card_type = "Monster";
	power_cost = 7;
	center_row_continuous_effects = {
		{
			effect = {"ThisCannotBeBanishedUnlessDefeated", 0 };
		},
	};
	rewards = {
		{ "GainHonor", 4 },
		{ "AcquireOrDefeatAnyCenterRow", 0 },
	};
	effect_text = "This Monster can't be banished unless defeated.\nReward: Gain 4H.  Acquire or Defeat any other card in the center row.";
   image_large = { "M_AvatarFallen", {0, 0, 364/512, 1} };
   image_medium = { "M_AvatarFallen", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_AvatarFallen", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_AvatarFallen", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Avatar_Fallen_Die_1" };

   rarity_count = 1
}


g_ascension_cards["Corrosive Widow 10TH"] = { 
	card_name = "Corrosive Widow 10TH";
	display_name = "Corrosive Widow";
	card_set = "CotG10";
	card_type = "Monster";
	power_cost = 4;
	rewards = {
		{ "GainHonor", 3 },
		{ "EachOpponentDiscardsConstructInPlay", 0 },
	};
	effect_text = "Reward: Gain 3H.  Each opponent must put a Construct he controls into his discard pile.",
   image_large = { "M_CorrosiveWidow", {0, 0, 364/512, 1} };
   image_medium = { "M_CorrosiveWidow", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_CorrosiveWidow", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_CorrosiveWidow", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Corrosive_Widow_Die_1" };

   rarity_count = 4
}

g_ascension_cards["Earth Tyrant 10TH"] = { 
	card_name = "Earth Tyrant 10TH";
	display_name = "Earth Tyrant";
	card_set = "CotG10";
	card_type = "Monster";
	power_cost = 6;
	rewards = {
		{ "GainHonor", 5 },
		{ "DrawCards", 2 },
	};
	effect_text = "Reward: Gain 5H.  Draw two cards.",
   image_large = { "M_EarthTyrant", {0, 0, 364/512, 1} };
   image_medium = { "M_EarthTyrant", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_EarthTyrant", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_EarthTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Earth_Tyrant_Die_1" };

   rarity_count = 2
}

g_ascension_cards["Mephit 10TH"] = { 
	card_name = "Mephit 10TH";
	display_name = "Mephit";
	card_set = "CotG10";
	card_type = "Monster";
	power_cost = 3;
	rewards = {
		{ "GainHonor", 2 },
		{ "BanishFromCenterRow", 1 },
	};
	effect_text = "Reward: Gain 2H.  You may banish a card in the center row.",
   image_large = { "M_Mephit", {0, 0, 364/512, 1} };
   image_medium = { "M_Mephit", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_Mephit", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_Mephit", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Mephit_Die_1" };

   rarity_count = 3
}

g_ascension_cards["Mistake of Creation 10TH"] = { 
	card_name = "Mistake of Creation 10TH";
	display_name = "Mistake of Creation";
	card_set = "CotG10";
	card_type = "Monster";
	power_cost = 4;
	rewards = {
		{ "GainHonor", 4 },
		{ "BanishFromCenterRow", 1 },
		{ "BanishFromDiscard", 1 },
	};
	effect_text = "Reward: Gain 4H.  You may banish a card in the center row and/or a card in your discard pile.",
   image_large = { "M_MistakeCreation", {0, 0, 364/512, 1} };
   image_medium = { "M_MistakeCreation", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_MistakeCreation", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_MistakeCreation", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Mistake_Creation_Die_1" };

   rarity_count = 4
}

g_ascension_cards["Samael's Trickster 10TH"] = { 
	card_name = "Samael's Trickster 10TH";
	display_name = "Samael's Trickster";
	card_set = "CotG10";
	card_type = "Monster";
	power_cost = 3;
	rewards = {
		--{ "GainHonor", 1 },
		{ "GainHonor", 2 },
		{ "GainRunes", 1 },
	};
	--effect_text = "Reward: Gain 1H.  Gain 1R.",
	effect_text = "Reward: Gain 2H and 1R.",
   image_large = { "M_SamaelsTrickster", {0, 0, 364/512, 1} };
   image_medium = { "M_SamaelsTrickster", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_SamaelsTrickster", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_SamaelsTrickster", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Samaels_Trickster_Die_1" };

   rarity_count = 4
}


g_ascension_cards["Sea Tyrant 10TH"] = { 
	card_name = "Sea Tyrant 10TH";
	display_name = "Sea Tyrant";
	card_set = "CotG10";
	card_type = "Monster";
	power_cost = 5;
	rewards = {
		{ "GainHonor", 5 },
		{ "EachOpponentDiscardsAllButOneConstructInPlay", 0 },
	};
	effect_text = "Reward: Gain 5H.  Each opponent must choose a Construct they control and put the rest into their discard pile.",
   image_large = { "M_SeaTyrant", {0, 0, 364/512, 1} };
   image_medium = { "M_SeaTyrant", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_SeaTyrant", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_SeaTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Sea_Tyrant_Die_1" };

   rarity_count = 3
}


g_ascension_cards["Tormented Soul 10TH"] = { 
	card_name = "Tormented Soul 10TH";
	display_name = "Tormented Soul";
	card_set = "CotG10";
	card_type = "Monster";
	power_cost = 3;
	rewards = {
		--{ "GainHonor", 1 },
		{ "GainHonor", 2 },
		{ "DrawCards", 1 },
	};
	--effect_text = "Reward: Gain 1H.  Draw a card.",
	effect_text = "Reward: Gain 2H. Draw a card.",
   image_large = { "M_TormentedSoul", {0, 0, 364/512, 1} };
   image_medium = { "M_TormentedSoul", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_TormentedSoul", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_TormentedSoul", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Tormented_Soul_Die_1" };

   rarity_count = 3
}

g_ascension_cards["Wind Tyrant 10TH"] = { 
	card_name = "Wind Tyrant 10TH";
	display_name = "Wind Tyrant";
	card_set = "CotG10";
	card_type = "Monster";
	power_cost = 5;
	rewards = {
		{ "GainHonor", 3 },
		{ "GainRunes", 3 },
	};
	effect_text = "Reward: Gain 3H.  Gain 3R.",
   image_large = { "M_WindTyrant", {0, 0, 364/512, 1} };
   image_medium = { "M_WindTyrant", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_WindTyrant", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_WindTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Wind_Tyrant_Die_1" };

   --rarity_count = 3
   rarity_count = 2
}


g_ascension_cards["Xeron, Duke of Lies 10TH"] = { 
	card_name = "Xeron, Duke of Lies 10TH";
	display_name = "Xeron, Duke of Lies";
	card_set = "CotG10";
	card_type = "Monster";
	power_cost = 6;
	rewards = {
		--{ "GainHonor", 3 },
		{ "GainHonor", 4 },
		{ "TakeRandomCardFromEachOpponent", 0 },
	};
	--effect_text = "Reward: Gain 3H.  Take a card at random from each opponent's hand and add that card to your hand.",
	effect_text = "Reward: Reward: Gain 4H. Take a card at random from each opponent's hand and add that card to your hand.",
   image_large = { "M_XeronDukeLies", {0, 0, 364/512, 1} };
   image_medium = { "M_XeronDukeLies", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_XeronDukeLies", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_XeronDukeLies", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Xeron_Die_1" };

   rarity_count = 1
}



