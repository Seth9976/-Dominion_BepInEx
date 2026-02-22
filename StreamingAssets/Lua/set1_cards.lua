


g_ascension_cards["Militia"] = { 
	card_name = "Militia";
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
      
   image_large = { "H_Militia", {0, 0, 364/512, 1} };
   image_medium = { "H_Militia", {392/512, 0, 512/512, 168/512} };
   image_small = { "H_Militia", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "H_Militia", {384/512, 395/512, 512/512, 512/512} };
}

g_ascension_cards["Apprentice"] = { 
	card_name = "Apprentice";
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

   image_large = { "H_Apprentice", {0, 0, 364/512, 1} };
   image_medium = { "H_Apprentice", {392/512, 0, 512/512, 168/512} };
   image_small = { "H_Apprentice", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "H_Apprentice", {384/512, 395/512, 512/512, 512/512} };
}

g_ascension_cards["Mystic"] = { 
	card_name = "Mystic";
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

   image_large = { "H_Mystic", {0, 0, 364/512, 1} };
   image_medium = { "H_Mystic", {392/512, 0, 512/512, 168/512} };
   image_small = { "H_Mystic", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "H_Mystic", {384/512, 395/512, 512/512, 512/512} };
}

g_ascension_cards["Heavy Infantry"] = { 
	card_name = "Heavy Infantry";
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

   image_large = { "H_HeavyInfantry", {0, 0, 364/512, 1} };
   image_medium = { "H_HeavyInfantry", {392/512, 0, 512/512, 168/512} };
   image_small = { "H_HeavyInfantry", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "H_HeavyInfantry", {384/512, 395/512, 512/512, 512/512} };
}

g_ascension_cards["Cultist"] = { 
	card_name = "Cultist";
	display_name = "Cultist";
	card_type = "Monster";
	power_cost = 2;
   do_not_put_in_void = true;
	reward = { "GainHonor", 1 };
	effect_text = "Reward: Gain 1H.";
   image_large = { "M_Cultist", {0, 0, 364/512, 1} };
   image_medium = { "M_Cultist", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_Cultist", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_Cultist", {384/512, 395/512, 512/512, 512/512} };
}

g_ascension_cards["Arha Initiate"] = { 
	card_name = "Arha Initiate";
	card_set = "CotG";
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

g_ascension_cards["Arha Templar"] = { 
	card_name = "Arha Templar";
	card_set = "CotG";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 4;
	honor = 3;
	effect = { "DefeatMonsterWithLessPower", 4 };
	effect_text = "Defeat a Monster that has P4 or less.";

   ai = {
      defeat_monster = 4;
   },

   image_large = { "EH_ArhaTemplar", {0, 0, 364/512, 1} };
   image_medium = { "EH_ArhaTemplar", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_ArhaTemplar", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_ArhaTemplar", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Ascetic of the Lidless Eye"] = { 
	card_name = "Ascetic of the Lidless Eye";
	card_set = "CotG";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 5;
	honor = 2;
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

g_ascension_cards["Master Dhartha"] = { 
	card_name = "Master Dhartha";
	card_set = "CotG";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 7;
	honor = 3;
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

g_ascension_cards["Oziah the Peerless"] = { 
	card_name = "Oziah the Peerless";
	card_set = "CotG";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 6;
	honor = 3;
	effect = { "DefeatMonsterWithLessPower", 6 };
	effect_text = "Defeat a Monster that has P6 or less.";

   ai = {
      defeat_monster = 6;
   },

   image_large = { "EH_OziahPeerless", {0, 0, 364/512, 1} };
   image_medium = { "EH_OziahPeerless", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_OziahPeerless", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_OziahPeerless", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Seer of the Forked Path"] = { 
	card_name = "Seer of the Forked Path";
	card_set = "CotG";
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

function TakeAnAdditionalTurn( state_machine, world, active_player, effect_data )

	local world = Instance.GetWorld( active_player );
	World.SetNextTurnPlayer( world, active_player );
end

function BanishThisConstruct( state_machine, world, active_player, effect_data, source_instance )

	if( ConstructAbilityInstance.IsConstructAbilityInstance(source_instance) ) then
		local construct_instance = ConstructAbilityInstance.GetConstructInstance( source_instance )
		local construct_card = ConstructInstance.GetCardInstance( construct_instance )
		local construct_owner = ConstructInstance.GetOwner( construct_instance )
				

      ascensionrules.BanishConstruct( construct_owner, construct_instance );

	end
end


g_ascension_cards["Tablet of Time's Dawn"] = { 
	card_name = "Tablet of Time's Dawn";
	card_set = "CotG";
	card_type = "Construct";
	faction = "Enlightened";
	rune_cost = 5;
	honor = 2;
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


function IfYouDo( world, active_player, source_instance, condition_data, effect_instance_data )

	return AscensionEffectInstanceData.GetEffectData( effect_instance_data, condition_data ) > 0;
end

g_ascension_cards["Temple Librarian"] = { 
	card_name = "Temple Librarian";
	card_set = "CotG";
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

g_ascension_cards["The All-Seeing Eye"] = { 
	card_name = "The All-Seeing Eye";
	card_set = "CotG";
	card_type = "Construct";
	faction = "Enlightened";
	rune_cost = 6;
	honor = 2;
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

g_ascension_cards["Twofold Askara"] = { 
	card_name = "Twofold Askara";
	card_set = "CotG";
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



g_ascension_cards["Cetra, Weaver of Stars"] = { 
	card_name = "Cetra, Weaver of Stars";
	card_set = "CotG";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 7;
	honor = 4;
	effect = { "AcquireHeroToTopOfDeck", 0 };
	effect_text = "Acquire any Hero.  Place it on top of your deck.";
   image_large = { "LH_CetraWeaverStars", {0, 0, 364/512, 1} };
   image_medium = { "LH_CetraWeaverStars", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_CetraWeaverStars", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_CetraWeaverStars", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

g_ascension_cards["Druids of the Stone Circle"] = { 
	card_name = "Druids of the Stone Circle";
	card_set = "CotG";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 4;
	honor = 3;
	effect = { "AcquireHeroToTopOfDeck", 3 };
	effect_text = "Acquire a Hero that costs R3 or less.  Place it on top of your deck.";
   image_large = { "LH_DruidsStoneCircle", {0, 0, 364/512, 1} };
   image_medium = { "LH_DruidsStoneCircle", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_DruidsStoneCircle", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_DruidsStoneCircle", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Flytrap Witch"] = { 
	card_name = "Flytrap Witch";
	card_set = "CotG";
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

g_ascension_cards["Landtalker"] = { 
	card_name = "Landtalker";
	card_set = "CotG";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 6;
	honor = 3;
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

g_ascension_cards["Lifebound Initiate"] = { 
	card_name = "Lifebound Initiate";
	card_set = "CotG";
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


function IfPlayedLifeboundHero( world, active_player, source_instance, condition_data, effect_instance_data )

	return World.GetPlayedHeroCount(world,"Lifebound",source_instance) > 0;
	
end

g_ascension_cards["Runic Lycanthrope"] = { 
	card_name = "Runic Lycanthrope";
	card_set = "CotG";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 3;
	honor = 1;
	effects = {
		{ "GainRunes", 2 },
		{ "GainPower", 2, condition={"IfPlayedLifeboundHero",1} },
	};
	effect_text = "Gain 2R.  If you've played a Lifebound Hero this turn, gain 2P.";

   ai = {
      gain_rune = 2;
   },

   image_large = { "LH_RunicLycanthrope", {0, 0, 364/512, 1} };
   image_medium = { "LH_RunicLycanthrope", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_RunicLycanthrope", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_RunicLycanthrope", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

function IfThisHasntBeenUsedThisTurn( world, effect_instance, event, condition_data )
	return not World.HasPlayedActiveEffect( world, effect_instance );
end

--[[
function WhenConstructOwnerPlaysFirstLifeboundHero( world, effect_instance, event, condition_data )

	if( EventPlayHero.IsPlayHero(event) ) then
		local event_player = EventPlayHero.GetTurnPlayer( event );
		local source_instance = ActiveEffectInstance.GetSourceInstance( effect_instance );
		local source_player = ConstructInstance.GetOwner( source_instance );
	
		if( Player.IsSamePlayer(event_player,source_player) ) then
		
			local event_card_instance = EventPlayHero.GetHeroCard( event );
			local event_card = CardInstance.GetCard( event_card_instance );

			if( AscensionCard.GetCardType(event_card) == "Hero" ) then

            if( World.GetPlayedHeroCount(world,"Lifebound",event_card_instance) == 0 ) then
               if( World.QueryCardFaction(world,event_player,event_card_instance,"Lifebound") ) then
                  return true;
               end
            end
				
			end
			
		end

	end
	
	return false;
	
end
]]


function TriggerSetThisHasBeenUsedThisTurn( state_machine, active_instance, source, event, effect_data )

	local world = Instance.GetWorld( source );
	World.PlayActiveEffect( world, active_instance );
	
end

g_ascension_cards["Snapdragon"] = { 
	card_name = "Snapdragon";
	card_set = "CotG";
	card_type = "Construct";
	faction = "Lifebound";
	rune_cost = 5;
	honor = 2;
	construct_ability = {
		description = "Gain 1R";
		{ "GainRunes", 1 },
      
      ai = {
         trivial = true,
      },
	};
	triggered_effects = {
		{
			conditions = {
				{ "IfThisHasntBeenUsedThisTurn", 0 },
				{ "WhenConstructOwnerPlaysFirstLifeboundHero", 0 },
			};
			triggereffect = {
				{ "TriggerConstructGainHonor", 1 },
				{ "TriggerSetThisHasBeenUsedThisTurn", 0 },
			};
		},
	};
	effect_text = "Once per turn, gain 1R.  The first time you play a Lifebound Hero each turn, gain 1H.";

   ai = {
      gain_rune = 1;
   },

   image_large = { "LC_Snapdragon", {0, 0, 364/512, 1} };
   image_medium = { "LC_Snapdragon", {392/512, 0, 512/512, 168/512} };
   image_small = { "LC_Snapdragon", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LC_Snapdragon", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Wolf Shaman"] = { 
	card_name = "Wolf Shaman";
	card_set = "CotG";
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

--[[
function HasCurrentTurnRunes( world, effect_instance, event, condition_data )

	local current_runes = World.GetCurrentTurnRunes( world )
	return current_runes >= condition_data
end
]]

g_ascension_cards["Yggdrasil Staff"] = { 
	card_name = "Yggdrasil Staff";
	card_set = "CotG";
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




g_ascension_cards["Avatar Golem"] = { 
	card_name = "Avatar Golem";
	card_set = "CotG";
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

--[[
function WhenYouPutFirstMechanaConstructIntoPlay( world, effect_instance, event, condition_data )

	if( EventPutConstructIntoPlay.IsPutConstructIntoPlay(event) ) then
		local event_player = EventPutConstructIntoPlay.GetTurnPlayer( event );
		local source_instance = ActiveEffectInstance.GetSourceInstance( effect_instance );
		local source_player = ConstructInstance.GetOwner( source_instance );
	
		if( Player.IsSamePlayer(event_player,source_player) ) then
		
			local event_card_instance = EventPutConstructIntoPlay.GetConstructCard( event );
			local event_card = CardInstance.GetCard( event_card_instance );

			if( AscensionCard.GetCardType(event_card) == "Construct" ) then

            local rules_version = World.GetRulesVersion(world);
            if( rules_version >= 4 ) then
               return World.QueryCardFaction(world,event_player,event_card_instance,"Mechana");
            else
               local query_faction = (rules_version == 1);
               if( World.GetPlayedConstructCount(world,"Mechana",query_faction,event_card_instance) == 0 ) then
                  if( World.QueryCardFaction(world,event_player,event_card_instance,"Mechana") ) then
                     return true;
                  end
               end
            end
				
			end
			
		end

	end
	
	return false;
	
end
]]

function TriggerConstructOwnerDrawCards( state_machine, active_instance, source, event, effect_data )

	local active_player = ConstructInstance.GetOwner( source );
	local world = Instance.GetWorld( active_player );
	
	local new_state = ascensionrules.CreateStateProcessDrawCards( active_player, effect_data );
	StateMachine.PushListState( state_machine, new_state )
	
end

g_ascension_cards["Burrower Mark II"] = { 
	card_name = "Burrower Mark II";
	card_set = "CotG";
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

g_ascension_cards["Hedron Cannon"] = { 
	card_name = "Hedron Cannon";
	card_set = "CotG";
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


function OwnerTreatsAllConstructsAsMechanaConstructs( world, effect_instance, event, effect_data )

	if( EventQueryCardFaction.IsQueryCardFaction(event) ) then
		local query_player = EventQueryCardFaction.GetQueryPlayer( event )
		
		local source_instance = ActiveEffectInstance.GetSourceInstance( effect_instance );
		local source_player = ConstructInstance.GetOwner( source_instance );
		
		if( Player.IsSamePlayer(query_player,source_player) ) then
		
			local query_card_instance = EventQueryCardFaction.GetQueryCard( event );
			local query_card = CardInstance.GetCard( query_card_instance );
			
			if( EventQueryCardFaction.GetQueryFaction(event) == "Mechana"
				and AscensionCard.GetCardType(query_card) == "Construct" ) then
				
				EventQueryCardFaction.SetFactionFlag( event, true )
				return true
			end
		end
	end
	
	
	return false
end

g_ascension_cards["Hedron Link Device"] = { 
	card_name = "Hedron Link Device";
	card_set = "CotG";
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



function IfYouControlConstructs( world, active_player, source_instance, condition_data, effect_instance_data )

	local construct_count = Player.CountConstructsInPlay( active_player );
	return construct_count >= condition_data;

end

g_ascension_cards["Kor, the Ferromancer"] = { 
	card_name = "Kor, the Ferromancer";
	card_set = "CotG";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 3;
	honor = 2;
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


g_ascension_cards["Mechana Initiate"] = { 
	card_name = "Mechana Initiate";
	card_set = "CotG";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 1;
	honor = 1;
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

   image_large = { "MH_MechanaInitiate", {0, 0, 364/512, 1} };
   image_medium = { "MH_MechanaInitiate", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_MechanaInitiate", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_MechanaInitiate", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}



   function ReduceConstructRuneCost( world, effect_instance, event, effect_data )
      
      if( not EventQueryCardAttribute.IsAttributeRuneCost(event) ) then
         return false
      end
      
      local query_player = EventQueryCardAttribute.GetQueryPlayer( event )
      local effect_target = ActiveEffectInstance.GetEffectInstance( effect_instance );
      if( not Player.IsSamePlayer(query_player,effect_target) ) then
         return false
      end
      
      local query_card_instance = EventQueryCardAttribute.GetQueryCard( event );
      local query_card_def = CardInstance.GetCard( query_card_instance );
      if( AscensionCard.GetCardType(query_card_def) == "Construct" ) then
         EventQueryCardAttribute.AddAttributeAdjustValue( event, -effect_data )
         return true
      end
      
      return false
   end

g_ascension_active_effects["construct acquired costs 1 less"] = {
	type = "continuous";
	effectfunc = { "ReduceConstructRuneCost", 1 };
}


function UntilConstructIsAcquired( world, effect_instance, event, condition_data )

	if( EventAcquireCard.IsAcquireCard(event) ) then
	
		local event_player = EventAcquireCard.GetTurnPlayer( event );
		
		local effect_instance = ActiveEffectInstance.GetSourceInstance( effect_instance );
	
		if( Player.IsSamePlayer(event_player,effect_instance) ) then
		
			local event_card_instance = EventAcquireCard.GetAcquiredCard( event );
			local event_card = CardInstance.GetCard( event_card_instance );

			if( AscensionCard.GetCardType(event_card) == "Construct" ) then
				return true;
			end
			
		end

	end
	
	return false;
	
end

function UntilEndOfTurn( world, active_effect, event, duration_data )

	return EventTurnSequence.IsTurnSequenceEndTurn( event ) 
end



g_ascension_cards["Reactor Monk"] = { 
	card_name = "Reactor Monk";
	card_set = "CotG";
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


function IfIsRulesVersion( world, effect_instance, event, condition_data )
   return World.GetRulesVersion(world) == condition_data;
end

function WhenYouAcquireMechanaConstruct( world, effect_instance, event, condition_data )

	if( EventAcquireCard.IsAcquireCard(event) ) then
		local event_player = EventAcquireCard.GetTurnPlayer( event );
		local source_instance = ActiveEffectInstance.GetSourceInstance( effect_instance );
		local source_player = ConstructInstance.GetOwner( source_instance );
	
		if( Player.IsSamePlayer(event_player,source_player) ) then
		
			local event_card_instance = EventAcquireCard.GetAcquiredCard( event );
			local event_card = CardInstance.GetCard( event_card_instance );

			if( AscensionCard.GetCardType(event_card) == "Construct" ) then
			
				local world = Instance.GetWorld( event_player )
				--if( AscensionCard.GetCardFaction(event_card) == "Mechana" ) then
				if( World.QueryCardFaction(world,event_player,event_card_instance,"Mechana") ) then
					return true;
				end
				
			end
			
		end

	end
	
	return false;
	
end

function TriggerMayPutConstructIntoPlay( state_machine, active_instance, source, event, effect_data )

	if( not EventAcquireCard.IsAcquireCard(event) ) then
		return;
	end
	
	local active_player = ConstructInstance.GetOwner( source );
	
	local event_card_instance = EventAcquireCard.GetAcquiredCard( event );
	
	local new_state = ascensionrules.CreateStateMayPutConstructIntoPlay( active_player, event_card_instance, event, active_instance );
	StateMachine.PushListState( state_machine, new_state )
end


function MayPutAcquiredMechanaConstructIntoPlayOncePerTurn( world, effect_instance, event, effect_data )

   if( not EventQueryAcquireCardLocation.IsQueryAcquireCardLocation(event) ) then
      return false
   end

   if( World.HasPlayedActiveEffect( world, effect_instance ) ) then
      return false
   end

   local query_player = EventQueryAcquireCardLocation.GetQueryPlayer( event );
   local source_instance = ActiveEffectInstance.GetSourceInstance( effect_instance );
   local source_player = ConstructInstance.GetOwner( source_instance );

   if( not Player.IsSamePlayer(query_player,source_player) ) then
      return false
   end

   local event_card_instance = EventQueryAcquireCardLocation.GetQueryCard( event );
   local event_card = CardInstance.GetCard( event_card_instance );

   if( AscensionCard.GetCardType(event_card) ~= "Construct" ) then
      return false			
   end

   if( not World.QueryCardFaction(world,query_player,event_card_instance,"Mechana") ) then
      return false
   end

   EventQueryAcquireCardLocation.AddAcquireLocationConstructInPlay( event, effect_instance, false )
   return true

end

g_ascension_cards["Rocket Courier X-99"] = { 
	card_name = "Rocket Courier X-99";
	card_set = "CotG";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 4;
	honor = 4;

	triggered_effects = {
		{
			version_before = 1;
			conditions = {
				{ "IfThisHasntBeenUsedThisTurn", 0 },
				{ "WhenYouAcquireMechanaConstruct", 0 },
			};
			triggereffect = {
				{ "TriggerMayPutConstructIntoPlay", 1 },
				--{ "TriggerSetThisHasBeenUsedThisTurn", 0 },
			};
		},
	};

	continuous_effects = {
		{
			version_after = 2;
			effect = { "MayPutAcquiredMechanaConstructIntoPlayOncePerTurn", 0 };
		},
	};

   effect_text = "Once per turn, when you acquire another Mechana Construct, you may put it directly into play.";
   image_large = { "MC_RocketCourierX99", {0, 0, 364/512, 1} };
   image_medium = { "MC_RocketCourierX99", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_RocketCourierX99", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_RocketCourierX99", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["The Grand Design"] = { 
	card_name = "The Grand Design";
	card_set = "CotG";
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

g_ascension_cards["Watchmaker's Altar"] = { 
	card_name = "Watchmaker's Altar";
	card_set = "CotG";
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
	effect_text = "Once per turn, gain 1R.  You may spend it only to acquire a Mechana Construct.";

   ai = {
      gain_rune_mechana = 1;
   },

   image_large = { "MC_WatchmakersAltar", {0, 0, 364/512, 1} };
   image_medium = { "MC_WatchmakersAltar", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_WatchmakersAltar", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_WatchmakersAltar", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

g_ascension_cards["Arbiter of the Precipice"] = { 
	card_name = "Arbiter of the Precipice";
	card_set = "CotG";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 4;
	honor = 1;
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

g_ascension_cards["Demon Slayer"] = { 
	card_name = "Demon Slayer";
	card_set = "CotG";
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

g_ascension_cards["Emri, One with the Void"] = { 
	card_name = "Emri, One with the Void";
	card_set = "CotG";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 6;
	honor = 3;
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

g_ascension_cards["Muramasa"] = { 
	card_name = "Muramasa";
	card_set = "CotG";
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

g_ascension_cards["Shade of the Black Watch"] = { 
	card_name = "Shade of the Black Watch";
	card_set = "CotG";
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

g_ascension_cards["Shadow Star"] = { 
	card_name = "Shadow Star";
	card_set = "CotG";
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

g_ascension_cards["Spike Vixen"] = { 
	card_name = "Spike Vixen";
    display_name = "Spike Vixen";
	card_set = "CotG";
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

g_ascension_cards["Void Initiate"] = { 
	card_name = "Void Initiate";
	card_set = "CotG";
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

--[[
function WhenConstructOwnerDefeatsFirstMonster( world, effect_instance, event, condition_data )

	if( EventDefeatMonster.IsDefeatMonster(event) ) then
      if( EventDefeatMonster.IsDefeatFromCenterRow(event) or EventDefeatMonster.IsDefeatFromVoid(event) ) then
         local event_player = EventDefeatMonster.GetTurnPlayer( event );
         local source_instance = ActiveEffectInstance.GetSourceInstance( effect_instance );
         local source_player = ConstructInstance.GetOwner( source_instance );
      
         if( Player.IsSamePlayer(event_player,source_player) ) then
         
            local monster_card_instance = EventDefeatMonster.GetMonsterCard(event);
            if( World.CountDefeatedMonsterList(world,monster_card_instance) == 0 ) then
               return true;
            end
            
         end
      end
	end
	
	return false;
	
end
]]

g_ascension_cards["Voidthirster"] = { 
	card_name = "Voidthirster";
	card_set = "CotG";
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



function ThisCannotBeBanishedUnlessDefeated( world, effect_instance, event, effect_data )

	if( EventQueryCanBanish.IsQueryCanBanish(event) ) then
		local query_card = EventQueryCanBanish.GetQueryCard( event )

		local source_instance = ActiveEffectInstance.GetSourceInstance( effect_instance );
		
		if( Instance.IsSameInstance(query_card,source_instance) ) then
			EventQueryCanBanish.SetBanishFlag( event, false )
			return true		
		end
	end
	
	--[[
	if( EventQueryCardFaction.IsQueryCardFaction(event) ) then
		local query_player = EventQueryCardFaction.GetQueryPlayer( event )
		
		local source_instance = ActiveEffectInstance.GetSourceInstance( effect_instance );
		local source_player = ConstructInstance.GetOwner( source_instance );
		
		if( Player.IsSamePlayer(query_player,source_player) ) then
		
			local query_card_instance = EventQueryCardFaction.GetQueryCard( event );
			local query_card = CardInstance.GetCard( query_card_instance );
			
			if( EventQueryCardFaction.GetQueryFaction(event) == "Mechana"
				and AscensionCard.GetCardType(query_card) == "Construct" ) then
				
				EventQueryCardFaction.SetFactionFlag( event, true )
				return true
			end
		end
	end
	]]
	
	return false
end

g_ascension_cards["Avatar of the Fallen"] = { 
	card_name = "Avatar of the Fallen";
	card_set = "CotG";
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


function EachOpponentDiscardsConstructInPlay( state_machine, world, active_player, effect_data )

	--local new_state = ascensionrules.CreateStateEachOpponentDiscardsConstructInPlay( active_player );
	--StateMachine.PushListState( state_machine, new_state )

   ascensionrules.EachOpponentDiscardsConstructInPlay( active_player, state_machine );
end

g_ascension_cards["Corrosive Widow"] = { 
	card_name = "Corrosive Widow";
	card_set = "CotG";
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

g_ascension_cards["Earth Tyrant"] = { 
	card_name = "Earth Tyrant";
	card_set = "CotG";
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

g_ascension_cards["Mephit"] = { 
	card_name = "Mephit";
	card_set = "CotG";
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

g_ascension_cards["Mistake of Creation"] = { 
	card_name = "Mistake of Creation";
	card_set = "CotG";
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

g_ascension_cards["Samael's Trickster"] = { 
	card_name = "Samael's Trickster";
	card_set = "CotG";
	card_type = "Monster";
	power_cost = 3;
	rewards = {
		{ "GainHonor", 1 },
		{ "GainRunes", 1 },
	};
	effect_text = "Reward: Gain 1H.  Gain 1R.",
   image_large = { "M_SamaelsTrickster", {0, 0, 364/512, 1} };
   image_medium = { "M_SamaelsTrickster", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_SamaelsTrickster", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_SamaelsTrickster", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Samaels_Trickster_Die_1" };

   rarity_count = 4
}


function EachOpponentDiscardsAllButOneConstructInPlay( state_machine, world, active_player, effect_data )

	--local new_state = ascensionrules.CreateStateEachOpponentDiscardsAllButOneConstructInPlay( active_player );
	--StateMachine.PushListState( state_machine, new_state )

   ascensionrules.EachOpponentDiscardsAllButOneConstructInPlay( active_player, state_machine );
end

g_ascension_cards["Sea Tyrant"] = { 
	card_name = "Sea Tyrant";
	card_set = "CotG";
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


g_ascension_cards["Tormented Soul"] = { 
	card_name = "Tormented Soul";
	card_set = "CotG";
	card_type = "Monster";
	power_cost = 3;
	rewards = {
		{ "GainHonor", 1 },
		{ "DrawCards", 1 },
	};
	effect_text = "Reward: Gain 1H.  Draw a card.",
   image_large = { "M_TormentedSoul", {0, 0, 364/512, 1} };
   image_medium = { "M_TormentedSoul", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_TormentedSoul", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_TormentedSoul", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Tormented_Soul_Die_1" };

   rarity_count = 3
}

g_ascension_cards["Wind Tyrant"] = { 
	card_name = "Wind Tyrant";
	card_set = "CotG";
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

   rarity_count = 3
}


function TakeRandomCardFromEachOpponent( state_machine, world, active_player, effect_data )

	local new_state = ascensionrules.CreateStateTakeRandomCardFromEachOpponent( active_player );
	StateMachine.PushListState( state_machine, new_state )
end

g_ascension_cards["Xeron, Duke of Lies"] = { 
	card_name = "Xeron, Duke of Lies";
	card_set = "CotG";
	card_type = "Monster";
	power_cost = 6;
	rewards = {
		{ "GainHonor", 3 },
		{ "TakeRandomCardFromEachOpponent", 0 },
	};
	effect_text = "Reward: Gain 3H.  Take a card at random from each opponent's hand and add that card to your hand.",
   image_large = { "M_XeronDukeLies", {0, 0, 364/512, 1} };
   image_medium = { "M_XeronDukeLies", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_XeronDukeLies", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_XeronDukeLies", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Xeron_Die_1" };

   rarity_count = 1
}



