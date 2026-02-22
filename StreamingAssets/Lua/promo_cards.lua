

function DrawOrDefeatTopOfCenterDeck( state_machine, world, active_player, effect_data )

	local new_state = ascensionrules.CreateStateProcessDrawOrDefeatTopOfCenterDeck( active_player );
	StateMachine.PushListState( state_machine, new_state )
end


g_ascension_cards["Vedah, Sage of Swords"] = { 
	card_name = "Vedah, Sage of Swords";
	card_set = "promo";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 7;
	honor = 4;
   
	effect = { "DrawOrDefeatTopOfCenterDeck", 0 };
   
	effect_text = "Reveal the top card of the center deck.  Draw it or defeat it.";
   
   image_large = { "EH_VedahSageSwords", {0, 0, 364/512, 1} };
   image_medium = { "EH_VedahSageSwords", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_VedahSageSwords", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_VedahSageSwords", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1
}



g_ascension_cards["Giant Rat"] = { 
	card_name = "Giant Rat";
	card_set = "promo";
	card_type = "Monster";
	power_cost = 1;
   do_not_put_in_void = true;
	rewards = {
		{ "GainHonor", 1 },
	},
	effect_text = "Any card underneath Giant Rat cannot be acquired, banished, or defeated until Giant Rat is banished or defeated.\nReward: Gain 1H.";
   
   image_large = { "M_GiantRat", {0, 0, 364/1024, 1} };
   image_medium = { "M_GiantRat", {392/1024, 0, 512/1024, 168/512} };
   image_small = { "M_GiantRat", {410/1024, 170/512, 512/1024, 312/512} };
   image_half  = { "M_GiantRat", {768/1024, 0, 1024/1024, 236/512} };
   defeat_sound = { "Giant Rat" };
   -- image_half  = { "M_GiantRat_hh", {768/1024, 0, 1024/1024, 236/512} };
}


function PlaceGiantRatOnTopOfEachOtherCenterRow( state_machine, world, active_player, effect_data, source_instance, effect_instance_data, event )

	if( EventEnterCenterRow.IsEnterCenterRow(event) ) then
		local center_row_index = EventEnterCenterRow.GetCenterRowIndex( event );
		
		for index=0,5 do
			if( index ~= center_row_index ) then
				local new_card_instance = World.CreateCard( world, "Giant Rat" );
				World.PutCardOnCenterRow( world, index, new_card_instance, 1 );
			end
		end
   end
end

function DefeatAllGiantRatsInPlay( state_machine, world, active_player, effect_data )

	for center_row_index=0,5 do
		local center_row_card = World.GetCenterRowCard( world, center_row_index );
		
      if( center_row_card ~= nil ) then
      
         local card_name = Instance.GetName( center_row_card );
         if( card_name == "Giant Rat" ) then
         
            local output_message = string.format( "%s defeats %s\n", Instance.GetName(active_player), card_name );
            World.OutputMessage( world, output_message );
                                          
            local remove_state = ascensionrules.CreateStateRemoveCenterRowCard( active_player, center_row_index );
            StateMachine.PushListState( state_machine, remove_state );
            
            local defeat_state = ascensionrules.CreateStateProcessDefeatMonster( active_player, center_row_card, center_row_index );
            StateMachine.PushListState( state_machine, defeat_state );
            
         end
         
      end
		
	end
end

g_ascension_cards["Rat King"] = { 
	card_name = "Rat King";
	card_set = "promo";
	card_type = "Monster";
	power_cost = 6;

	center_row = { "PlaceGiantRatOnTopOfEachOtherCenterRow", 0 };

	rewards = {
		{ "GainHonor", 4 },
		{ "DefeatAllGiantRatsInPlay", 0 },
	};
	--effect_text = "When Rat King enters the center row, place a Giant Rat on top of each other center row space.\nReward: Gain 4H and defeat all Giant Rats in play.";
	fate_text = "FATE: When Rat King enters the center row, place a Giant Rat on top of each other center row space.";
	effect_text = "Reward: Gain 4H and defeat all Giant Rats in play.";
   
   image_large = { "M_RatKing", {0, 0, 364/512, 1} };
   image_medium = { "M_RatKing", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_RatKing", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_RatKing", {384/512, 395/512, 512/512, 512/512} };
   fate_sound = { "king_rat_enter" };
   defeat_sound = { "Rat King" };
   
   rarity_count = 2
}


function UseRunesAsPowerUntilEndOfTurn( state_machine, world, active_player, effect_data )
   World.SetUseRunesAsPower( world );
end

g_ascension_cards["Pathwarden"] = { 
	card_name = "Pathwarden";
	card_set = "promo";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 6;
	honor = 3;
	effects = {
      { "GainRunes", 2 },
      { "UseRunesAsPowerUntilEndOfTurn", 0 }
   };
	effect_text = "Gain 2R.  You may spend R as though it was P this turn.";
   
   image_large = { "LH_Pathwarden", {0, 0, 364/512, 1} };
   image_medium = { "LH_Pathwarden", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_Pathwarden", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_Pathwarden", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}


function AcquireConstructDirectlyIntoPlay( world, effect_instance, event, effect_data )

   if( not EventQueryAcquireCardLocation.IsQueryAcquireCardLocation(event) ) then
      return false
   end

   --if( World.HasPlayedActiveEffect( world, effect_instance ) ) then
   --   return false
   --end

   local query_player = EventQueryAcquireCardLocation.GetQueryPlayer( event );
   local source_player = ActiveEffectInstance.GetEffectInstance( effect_instance );

   if( not Player.IsSamePlayer(query_player,source_player) ) then
      return false
   end

   local event_card_instance = EventQueryAcquireCardLocation.GetQueryCard( event );
   local event_card = CardInstance.GetCard( event_card_instance );

   if( AscensionCard.GetCardType(event_card) ~= "Construct" ) then
      return false			
   end

   EventQueryAcquireCardLocation.AddAcquireLocationConstructInPlay( event, effect_instance, true )
   return true

end

g_ascension_active_effects["acquire construct directly into play"] = {
	type = "continuous";
	effectfunc = { "AcquireConstructDirectlyIntoPlay", 1 };
}

function NextContructYouAcquireGoesDirectlyIntoPlay( state_machine, world, active_player, effect_data )
	
	local new_effect = ActiveEffectInstance.Create( world, "acquire construct directly into play", active_player, active_player )
	ActiveEffectInstance.AddEffectDuration( new_effect, "UntilConstructIsAcquired", 0 )
	ActiveEffectInstance.AddEffectDuration( new_effect, "UntilEndOfTurn", 0 )
	World.AddActiveEffect( world, new_effect )
	
end

g_ascension_cards["Deep Drone"] = { 
	card_name = "Deep Drone";
	card_set = "promo";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 4;
	honor = 2;
	effects = {
      { "GainRunes", 2 },
      { "NextContructYouAcquireGoesDirectlyIntoPlay", 0 },
   };
	effect_text = "Gain 2R.  Put the next construct you acquire this turn directly into play.";
   
   image_large = { "MH_DeepDrone", {0, 0, 364/512, 1} };
   image_medium = { "MH_DeepDrone", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_DeepDrone", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_DeepDrone", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}


function WhenYouDefeatMonster( world, active_effect_instance, event, condition_data )

	if( EventDefeatMonster.IsDefeatMonster(event) ) then
		local event_player = EventDefeatMonster.GetTurnPlayer( event );
		local target_instance = ActiveEffectInstance.GetEffectInstance( active_effect_instance );
	
		return Player.IsSamePlayer(event_player,target_instance)
	end
	
	return false;
	
end

function YouMayAcquireHeroWithCostLessThanDefeatedMonster( state_machine, active_instance, source, event, effect_data )

	if( EventDefeatMonster.IsDefeatMonster(event) ) then

		local active_player = ActiveEffectInstance.GetEffectInstance( active_instance );
		
      local monster_instance = EventDefeatMonster.GetMonsterCard(event);
      local monster_card = CardInstance.GetCard( monster_instance );
      local power_cost = AscensionCard.GetPowerCost( monster_card );
      
      if( power_cost > 0 ) then
         local new_state = ascensionrules.CreateStateProcessAcquireHeroToTopOfDeck( active_player, 1, 0, power_cost );
         StateMachine.PushListState( state_machine, new_state );
      end
   end
end

g_ascension_active_effects["acquire hero when defeat a monster"] = {
	type = "triggered";
   priority = 10;
	conditions = {
		{ "WhenYouDefeatMonster", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "YouMayAcquireHeroWithCostLessThanDefeatedMonster", 0 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

function UntilMonsterIsDefeated( world, active_effect_instance, event, condition_data )
	
	if( EventDefeatMonster.IsDefeatMonster(event) ) then
	
      local event_player = EventDefeatMonster.GetTurnPlayer( event );
      local effect_target = ActiveEffectInstance.GetEffectInstance( active_effect_instance );
   
      return Player.IsSamePlayer( event_player, effect_target );
	end
	
	return false;
	
end

function AcquireHeroNextTimeYouDefeatAMonsterThisTurn( state_machine, world, active_player, effect_data )
	
	local new_effect = ActiveEffectInstance.Create( world, "acquire hero when defeat a monster", active_player, active_player )
	ActiveEffectInstance.AddEffectDuration( new_effect, "UntilMonsterIsDefeated", 0 )
	ActiveEffectInstance.AddEffectDuration( new_effect, "UntilEndOfTurn", 0 )
	World.AddActiveEffect( world, new_effect )
	
end


g_ascension_cards["Void Mesmer"] = { 
	card_name = "Void Mesmer";
	card_set = "promo";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 6;
	honor = 3;
	effects = {
      { "GainPower", 2 },
      { "AcquireHeroNextTimeYouDefeatAMonsterThisTurn", 0 },
   };
	effect_text = "Gain 2P.  The next time you defeat a Monster this turn, you may acquire a Hero of equal or lesser cost.";
   
   image_large = { "VH_VoidMesmer", {0, 0, 364/512, 1} };
   image_medium = { "VH_VoidMesmer", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_VoidMesmer", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_VoidMesmer", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}

--[[
   function AcquireOrDefeatCardInCenterRow( state_machine, world, active_player, effect_data, source_instance, effect_instance_data, event )

      if( EventDefeatMonster.IsDefeatFromCenterRow(event) ) then
         
         local is_center_row, center_row_index = EventDefeatMonster.GetCenterRowPosition( event );
         if( is_center_row ) then         
            local new_state = ascensionrules.CreateStateProcessAcquireOrDefeatTopOfCenterRowStack( active_player, center_row_index );
            StateMachine.PushListState( state_machine, new_state )
         end
      end
   end
]]

g_ascension_cards["Kythis, the Gatekeeper"] = { 
	card_name = "Kythis, the Gatekeeper";
	card_set = "promo";
	card_type = "Monster";
	power_cost = 7;
   
	center_row = { "PlaceTopOfPortalDeckUnderCenterRow", 0 };

	rewards = {
		{ "GainHonor", 5 },
		{ "AcquireOrDefeatCardInCenterRow", 0 },
	};
	--effect_text = "When Kythis enters the center row, take the top card of the center deck and place it face down underneath him.\n" ..
    --              "Reward: Gain 5H and acquire or defeat the card underneath Kythis.";
	fate_text = "FATE: When Kythis enters the center row, take the top card of the center deck and place it face down underneath him.";
	effect_text = "Reward: Gain 5H and acquire or defeat the card underneath Kythis.";

   image_large = { "M_KythisGatekeeper", {0, 0, 364/512, 1} };
   image_medium = { "M_KythisGatekeeper", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_KythisGatekeeper", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_KythisGatekeeper", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Kythis the Gatekeeper" };
   
   rarity_count = 1
}



g_ascension_cards["Journeyman Sage"] = { 
	card_name = "Journeyman Sage";
	card_set = "promo";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 4;
	honor = 2;

	center_row = { "EachPlayerMayBanishHeroToAcquireMysticOrHeavyInfantryToHand", 0 },
	effects = {
		{"BanishHeroFromHand", 0},
      {"AcquireHeroWithPlus1HonorIntoHand", 0},
	};

	--effect_text = "FATE: When this enters the center row, each player may banish a Hero in their hand to acquire a Mystic or Heavy Infantry and add it to their hand.\n" ..
    --              "Banish a Hero in your hand.  If you do, acquire a Hero with Honor value up to one more than that of the banished card and put it in your hand.";
	fate_text = "FATE: When this enters the center row, each player may banish a Hero in their hand to acquire a Mystic or Heavy Infantry and add it to their hand.";
	effect_text = "Banish a Hero in your hand.  If you do, acquire a Hero with Honor value up to one more than that of the banished card and put it in your hand.";

   image_large = { "EH_JourneymanSage", {0, 0, 364/512, 1} };
   image_medium = { "EH_JourneymanSage", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_JourneymanSage", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_JourneymanSage", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}



g_ascension_cards["Nethersnare"] = { 
	card_name = "Nethersnare";
	card_set = "promo";
	card_type = "Construct";
	faction = "Void";
	rune_cost = 3;
	honor = 2;

   construct_abilities = {
		{
			description = "Put Monster Under This";
			condition = { "IfNoCardsUnderThisConstructAndMonseterInCenterRow", 0 },
         { "PutMonsterUnderThisConstruct", 0 },
		},
	};

	effect_text = "Once per turn, if there is no Monster under this, you may put a Monster from the center row under it.\n" ..
                  "You may defeat Monsters under this as though they were in the center row.\n" ..
                  "If this leaves play, put any monster under this on top of the center deck.";

   image_large = { "VC_Nethersnare", {0, 0, 364/512, 1} };
   image_medium = { "VC_Nethersnare", {392/512, 0, 512/512, 168/512} };
   image_small = { "VC_Nethersnare", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VC_Nethersnare", {384/512, 395/512, 512/512, 512/512} };
   monsters_under_construct = true;
   
   rarity_count = 2
}


g_ascension_cards["Askara of Fortune"] = { 
	card_name = "Askara of Fortune";
	card_set = "promo";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 3;
	honor = 1;

	effects = {
      { "CopyEffectFromTopOfAnyPlayerDeck", 0 },
	};

	effect_text = "Each player reveals the top card of their deck. " ..
                  "Choose a Hero revealed this way and copy its effect.";

   image_large = { "EH_AskaraFortune", {0, 0, 364/512, 1} };
   image_medium = { "EH_AskaraFortune", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_AskaraFortune", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_AskaraFortune", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1
}


g_ascension_cards["Hedron Flare"] = { 
	card_name = "Hedron Flare";
	card_set = "promo";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 6;
	honor = 6;
   
	construct_ability = {
		description = "Acquire";
		condition = { "IfCanAcquireMechanaHeroFromCenterRow", 0 },
		{ "AcquireMechanaHeroFromCenterRow", 0 },
	};

	effect_text = "Once per turn, you may acquire a Mechana Hero in the center row without paying its cost.";

   image_large = { "MC_HedronFlare", {0, 0, 364/512, 1} };
   image_medium = { "MC_HedronFlare", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_HedronFlare", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_HedronFlare", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}


g_ascension_cards["Cetra, Guide of Ogo"] = { 
	card_name = "Cetra, Guide of Ogo";
	card_set = "promo";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 8;
	honor = 4;

	effects = {
      { "AcquireAllCenterRowHeroesToTopOfDeck", 0 },
	};

	effect_text = "Acquire all Heroes in the center row without paying their costs. " ..
                  "Put them on top of your deck in any order.";

   image_large = { "LH_CetraGuideOgo", {0, 0, 364/512, 1} };
   image_medium = { "LH_CetraGuideOgo", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_CetraGuideOgo", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_CetraGuideOgo", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1
}


-- TODO
g_ascension_cards["Ring of Life"] = { 
	card_name = "Ring of Life";
	card_set = "promo";
	card_type = "Construct";
	faction = "Lifebound";
	rune_cost = 4;
	honor = 2;

	effect_text = "Once per turn, if you have played a Lifebound Hero, gain 1R. " ..
                  "When Ring of Life enters play, choose a faction. " ..
                  "Your Heroes of that factions are also Lifebound Heroes.";
}

g_ascension_cards["Ender of Days"] = { 
	card_name = "Ender of Days";
	card_set = "promo";
	card_type = "Monster";
	power_cost = 10;
   
	rewards = {
		{ "GainHonor", 10 },
      { "SetHonorPool", 0 }
	},
	effect_text = "Reward: Gain 10H. Remove all Honor from the Honor Pool.";

   image_large = { "M_EnderDays", {0, 0, 364/512, 1} };
   image_medium = { "M_EnderDays", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_EnderDays", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_EnderDays", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Ender_of_Days" };
   
   rarity_count = 1
}


g_ascension_cards["Leprechaun"] = {
	card_name = "Leprechaun";
	card_set = "promo";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 4;
	honor = 2;

	effects = {
      { "GainRunes", 2 },
      { "PlayLeprechaun", 0 },
      { "AcquirePotOfGold", 0 },
   };
	effect_text = "Gain 2R.  Acquire a Pot of Gold from the End of the Rainbow or from another player's control.";

   image_large = { "LH_Leprechaun", {0, 0, 364/512, 1} };
   image_medium = { "LH_Leprechaun", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_Leprechaun", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_Leprechaun", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 3
}

g_ascension_cards["Pot of Gold"] = {
	card_name = "Pot of Gold";
	card_set = "promo";
	card_type = "Construct";
	faction = "Lifebound";
	rune_cost = 1;
	honor = 1;

   triggered_effects = {
      {
         conditions = {
            { "WhenYouPutThisConstructIntoPlay", 0 },
         };
         triggereffect = {
            { "TriggerConstructOwnerDrawCards", 1 },
         };
      },
      {
         conditions = {
            { "WhenConstructOwnerPlaysLeprechaun", 0 },
         };
         triggereffect = {
            { "TriggerPushResolveEffectFromCardsInPlay", 0 },
            { "TriggerConstructGainHonor", 1 },
            --{ "TriggerPauseForAllAnimation", 1 },
            { "TriggerPopResolveEffectFromCardsInPlay", 0 },
         };
      },
   };

	effect_text = "When you play this, draw a card.  When you play a Leprechaun, gain 1H.";

   image_large = { "LC_PotOfGold", {0, 0, 364/512, 1} };
   image_medium = { "LC_PotOfGold", {392/512, 0, 512/512, 168/512} };
   image_small = { "LC_PotOfGold", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LC_PotOfGold", {384/512, 395/512, 512/512, 512/512} };
}



g_ascension_active_effects["on lifebound draw 1 card"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayLifeboundCard", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerEffectPlayerDrawCards", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

g_ascension_active_effects["on mechana draw 1 card"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayMechanaCard", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerEffectPlayerDrawCards", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

g_ascension_active_effects["on void draw 1 card"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayVoidCard", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerEffectPlayerDrawCards", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

g_ascension_active_effects["on enlightened draw 1 card"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayEnlightenedCard", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerEffectPlayerDrawCards", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}



g_ascension_cards["Miles, Golden Prodigy"] = { 
	card_name = "Miles, Golden Prodigy";
	card_set = "promo";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 5;
	honor = 3;
   
	effects = {
      { "DrawCards", 1 },
      { "OnLifeBoundPlayDraw1Card", 0, condition={"IfEffectSourceIsNotLifebound",0}},
      { "OnMechanaPlayDraw1Card", 0, condition={"IfEffectSourceIsNotMechana",0}},
      { "OnVoidPlayDraw1Card", 0, condition={"IfEffectSourceIsNotVoid",0}},
      { "OnEnlightenedPlayDraw1Card", 0, condition={"IfEffectSourceIsNotEnlightened",0}},
   };
   
	effect_text = "Draw a card. Whenever you play a card of another faction this turn, draw a card. This only happens once per faction.";
   
   image_large = { "EH_MilesGoldenProdigy", {0, 0, 364/512, 1} };
   image_medium = { "EH_MilesGoldenProdigy", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_MilesGoldenProdigy", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_MilesGoldenProdigy", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}


g_ascension_cards["Control Room"] = { 
	card_name = "Control Room";
	card_set = "promo";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 5;
	honor = 5;

   construct_abilities = {
		{
			description = "Return Construct to Acquire New Construct";
			condition = { "IfCenterRowHasMechanaConstruct", 0 },
			{ "ReturnConstructToPortalDeck", 0 },
			{ "AcquireMechanaConstructFromCenterRowToHand", 0 },

		},
	};
   
	effect_text = "Once per turn, you may put a Mechana Construct you control on top of the center deck.\n" ..
                  "If you do, acquire a Mechana Construct in the center row and put it in your hand.";
                  
   image_large = { "MC_ControlRoom", {0, 0, 364/512, 1} };
   image_medium = { "MC_ControlRoom", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_ControlRoom", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_ControlRoom", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1
}


g_ascension_cards["Soul Collector"] = { 
	card_name = "Soul Collector";
	card_set = "promo";
	card_type = "Construct";
	faction = "Void";
	rune_cost = 6;
	honor = 4;

   triggered_effects = {
		{
			conditions = {
				{"IfThisHasntBeenUsedThisTurn", 0 },
				{"WhenConstructOwnerDefeatsMonster", 0 },
			};
			triggereffect = {
				{"TriggerIncrementConstructEffectData", 0},
				{"TriggerSetThisHasBeenUsedThisTurn", 0},
			};
		},
	};

   construct_ability = {
		description = "Gain X Power";
      condition = { "IfConstructEffectDataGreaterThanZero", 0 },
		{ "GainPowerEqualToEffectData", 0 },
	};

	effect_text = "Once per turn, add a Soul counter to this if you've defeated a Monster in the center row.\n" ..
                  "Once per turn, gain power equal to the number of Soul counters on this.";
                  
   image_large = { "VC_SoulCollector", {0, 0, 364/512, 1} };
   image_medium = { "VC_SoulCollector", {392/512, 0, 512/512, 168/512} };
   image_small = { "VC_SoulCollector", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VC_SoulCollector", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}


-- TODO
g_ascension_cards["Arha Sanctuary"] = { 
	card_name = "Arha Sanctuary";
	card_set = "promo";
	card_type = "Construct";
	faction = "Enlightened";
	rune_cost = 3;
	honor = 2;

	effect_text = "When this enters play, put the top card of your deck under this face up.\n" ..
                  "Once per turn, you may swap a card in your hand for the card under Arha Sanctuary.\n" ..
                  "When Arha Sanctuary leaves play of the game ends, put the card under it into your discard pile.";

   --image_large = { "VC_Nethersnare", {0, 0, 364/512, 1} };
   --image_medium = { "VC_Nethersnare", {392/512, 0, 512/512, 168/512} };
   --image_small = { "VC_Nethersnare", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "VC_Nethersnare", {384/512, 395/512, 512/512, 512/512} };
}


g_ascension_cards["Moon Staff"] = { 
	card_name = "Moon Staff";
	card_set = "promo";
	card_type = "Construct";
	faction = "Lifebound";
	rune_cost = 4;
	honor = 2;

	effect_text = "Once per turn, you may spend 4R to double your power.";

   construct_abilities = {
		{
			description = "Double Power for 4 Runes";
			condition = { "IfHasCurrentTurnRunesAndAnyPower", 4 },

         { "PayRunes", 4 },
			{ "DoubleCurrentTurnPower", 0 },

		},
	};
   
   image_large = { "LC_MoonStaff", {0, 0, 364/512, 1} };
   image_medium = { "LC_MoonStaff", {392/512, 0, 512/512, 168/512} };
   image_small = { "LC_MoonStaff", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LC_MoonStaff", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}



g_ascension_cards["Constricting Horror"] = { 
	card_name = "Constricting Horror";
	card_set = "promo";
	card_type = "Monster";
	power_cost = 5;
   
	rewards = {
		{ "GainHonor", 4 },
      { "RevealCenterDeckCardsUntilHeroIsFound", 0 },
      { "AcquireTopOfCenterDeckIfHero", 0 },
	},
	effect_text = "Reward: Gain 4H. Reveal cards from the center deck until you reveal a Hero. " ..
                  "Acquire that Hero without paying its cost and banish each other card revealed this way.";

   image_large = { "M_ConstrictingHorror", {0, 0, 364/512, 1} };
   image_medium = { "M_ConstrictingHorror", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_ConstrictingHorror", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_ConstrictingHorror", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Constricting_Horror" };
   
   rarity_count = 2
}




-- TODO
g_ascension_cards["Big Bad Bunny"] = { 
	card_name = "Big Bad Bunny";
	card_set = "promo";
	card_type = "Monster";
	power_cost = 8;
   
	rewards = {
		{ "GainHonor", 5 },
	},
	--effect_text = "FATE: Place a card from the center deck facedown under this and each other card in the center row. " ..
    --              "Whenever a player acquires or defeats  a card on top of a facedown card, they acquire or defeat the facedown card without paying its cost. " ..
    --              "Reward: Gain 5H. Acquire or defeat all facedown cards in the center row.";
	fate_text = "FATE: Place a card from the center deck facedown under this and each other card in the center row. " ..
                  "Whenever a player acquires or defeats  a card on top of a facedown card, they acquire or defeat the facedown card without paying its cost.";
	effect_text = "Reward: Gain 5H. Acquire or defeat all facedown cards in the center row.";

   --image_large = { "M_EnderOfDays", {0, 0, 364/512, 1} };
   --image_medium = { "M_EnderOfDays", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_EnderOfDays", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_EnderOfDays", {384/512, 395/512, 512/512, 512/512} };
   --defeat_sound = { "Ender_of_Days" };
}



-- TODO
g_ascension_cards["Lotus Siren"] = {
	card_name = "Lotus Siren";
	card_set = "promo";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 4;
	honor = 2;
	effects = {
      { "GainRunes", 2 },
   };
	effect_text = "Gain 2R.\n" ..
                  "Whenever you acquire a Hero or Treasure card from the center row this turn, gain 1H. " ..
                     "(Gain honor for each card acquired.)";
}






--Promo Pack 4
g_ascension_cards["Aether Channeler"] = { 
	card_name = "Aether Channeler";
	card_set = "promo";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 4;
	honor = 2;
	effects = {
      { "BanishFromHand", 0 },
      { "CreateRandomHeroFromGame", 0, condition={"IfYouDo",0} },

   };
	effect_text = "Banish a card from your hand.  Replace it with a random hero and put it in your hand.";
   
   image_large = { "EH_AetherChanneler", {0, 0, 364/512, 1} };
   image_medium = { "EH_AetherChanneler", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_AetherChanneler", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_AetherChanneler", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}

g_ascension_cards["Spirit of the Ancients"] = { 
	card_name = "Spirit of the Ancients";
	card_set = "promo";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 6;
	honor = 3;
	effects = {
      { "CopyEffectOfAnyLifebound", 0 },
      
   };
	effect_text = "Choose a Lifebound Hero that hasn't been chosen with this before. This card counts as a copy of that Hero.";
   
   image_large = { "LH_SpiritAncients", {0, 0, 364/512, 1} };
   image_medium = { "LH_SpiritAncients", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_SpiritAncients", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_SpiritAncients", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}

g_ascension_cards["Temporal Excavator"] = {
	card_name = "Temporal Excavator";
	card_set = "promo";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 3;
	honor = 3;
   triggered_effects = {
		{
			conditions = {
				{"WhenYouPutThisConstructIntoPlay", 0 },
			};
			triggereffect = {
            --{ "ReplaceSeventhCenterCard", 0 },
				{"TriggerReplaceSeventhCard", 0},
			};
		},
	};

   continuous_effects = {
		{
			effect = {"CenterRowIsSevenCards", 0 };
		},
	};

	effects = {
      --{ "GainRunes", 2 },
      { "ReplaceSeventhCenterCard", 0 },
   };
	effect_text = ":  Add one card and if it is already there then banish it and replace it.";
   
   image_large = { "MC_TemporalExcavator", {0, 0, 364/512, 1} };
   image_medium = { "MC_TemporalExcavator", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_TemporalExcavator", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_TemporalExcavator", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}

g_ascension_cards["Eternal Tormentor"] = { 
	card_name = "Eternal Tormentor";
	card_set = "promo";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 5;
	honor = 3;
	effects = {
      { "DefeatRandomVoidMonster", 0 },
      
   };
	effect_text = "Defeat a random Monster in the void without paying its costs and put it on the bottom of the center deck.";
   
   image_large = { "VH_EternalTormentor", {0, 0, 364/512, 1} };
   image_medium = { "VH_EternalTormentor", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_EternalTormentor", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_EternalTormentor", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}

g_ascension_cards["Explosive Swarm"] = { 
	card_name = "Explosive Swarm";
	card_set = "promo";
	card_type = "Monster";
	power_cost = 4;

	rewards = {
		{ "GainHonor", 4 },
	},
	effect_text = "Reward: Gain 4H. When an adjacent non-Monster card would be replaced," ..
                  "replace it with a copy of this Monster instead";

   image_large = { "M_ExplosiveSwarm", {0, 0, 364/512, 1} };
   image_medium = { "M_ExplosiveSwarm", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_ExplosiveSwarm", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_ExplosiveSwarm", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Constricting_Horror" };
   
   rarity_count = 1
}







g_ascension_cards["Portal"] = {
	card_name = "Portal";
	card_set = "promo";
	card_type = "Portal";

   do_not_put_in_void = true;

	effect_text = "This is any hero or construct that could be found in the center deck of any Ascension set. " ..
                  "You never know what you're going to get!";
   
   image_large = { "Portal", {0, 0, 364/512, 1} };
   image_medium = { "Portal", {392/512, 0, 512/512, 168/512} };
   image_small = { "Portal", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "Portal", {384/512, 395/512, 512/512, 512/512} };
}

g_ascension_active_effects["portal acquired costs 1 less"] = {
	type = "continuous";
	effectfunc = { "ReducePortalRuneCost", 1 };
}

g_ascension_cards["Aether Curator"] = {
	card_name = "Aether Curator";
	card_set = "promo";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 4;
	honor = 2;
	effects = {
		{ "BanishFromCenterRowAndReplaceWithPortal", 0 },
      --{ "PortalsYouAcquireCostLessThisTurn", 1 },
      { "DrawCards", 1 },
	};
	--effect_text = "Banish a card in the center row. Replace it with a Portal.\n" ..
   --               "Portals cost 1R less to acquire this turn.";
	effect_text = "Banish a card in the center row. Replace it with a Portal.\n" ..
                  "Draw a card.";

   image_large = { "EH_AEtherCurator", {0, 0, 364/512, 1} };
   image_medium = { "EH_AEtherCurator", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_AEtherCurator", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_AEtherCurator", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 3
}

g_ascension_cards["Aetherspring Witch"] = {
	card_name = "Aetherspring Witch";
	card_set = "promo";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 2;
	honor = 1;
	effects = {
      { "AcquirePortalFromCenterRowOrGainHonor", 3 },
   };
	effect_text = "Choose one: Gain 3H, or acquire a Portal in the center row without paying its cost.";
   
   image_large = { "LH_AEtherspringWitch", {0, 0, 364/512, 1} };
   image_medium = { "LH_AEtherspringWitch", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_AEtherspringWitch", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_AEtherspringWitch", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 3
}

g_ascension_cards["Destroyer's Gate"] = {
	card_name = "Destroyer's Gate";
	card_set = "promo";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 5;
	honor = 5;

   triggered_effects = {
		{
			conditions = {
				{ "WhenYouPutThisConstructIntoPlay", 0 },
			};
			triggereffect = {
				{ "TriggerConstructSetEffectData0ToRandom", 5 },
         };
		},
		{
			conditions = {
				{ "AtStartOfConstructOwnerTurn", 0 },
			};
			triggereffect = {
            { "TriggerDecrementConstructEffectData", 0 },
            { "TriggerPushResolvingConstructIfEffectDataIs0", 0 },
            { "TriggerTransformThisConstructIntoRandomMechanaIfEffectDataIs0", 0 },
			};
		},
	};

	effect_text = "After a certain amount of time, this transforms into something awesome!";

   -- When you play this, it gets a random number of hidden turn counters.
   -- At the beginning of that player's turn, remove a counter.
   -- When it has 0 counters, it becomes Yolocrix and goes into that player's hand.
   -- Counters can range from 1-5.

   image_large = { "MC_DestroyersGate", {0, 0, 364/512, 1} };
   image_medium = { "MC_DestroyersGate", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_DestroyersGate", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_DestroyersGate", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}

g_ascension_active_effects["monster defeated acquires portal"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouDefeatMonsterFromCenterRow", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerAcquirePortalFromCenterRow", 0 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

g_ascension_cards["Aether Ritualist"] = {
	card_name = "Aether Ritualist";
	card_set = "promo";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 2;
	honor = 1;
	effects = {
		{ "GainPower", 2 },
		{ "NextMonsterYouDefeatFromCenterRowAcquirePortal", 0 },
	};
	effect_text = "Gain 2P.\n" ..
                  "The next time you defeat a Monster in the center row this turn, " ..
                  "you may acquire a Portal without paying its cost.";
   
   image_large = { "VH_AEtherRitualist", {0, 0, 364/512, 1} };
   image_medium = { "VH_AEtherRitualist", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_AEtherRitualist", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_AEtherRitualist", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 3
}

g_ascension_cards["Tollmaster Ky'lek"] = {
	card_name = "Tollmaster Ky'lek";
	card_set = "promo";
	card_type = "Monster";
	power_cost = 8;

	center_row = { "BanishAllOtherCenterRowWithPortals", 0 };

	rewards = {
		{ "GainHonor", 6 },
      { "AcquireAllCenterRowPortals", 0 },
	},
	--effect_text = "FATE: Banish all other cards in the center row and replace them with Portals.\n" ..
    --              "Reward: Gain 6H. Acquire all Portals in the center row without paying their costs.";
	fate_text = "FATE: Banish all other cards in the center row and replace them with Portals.";
	effect_text = "Reward: Gain 6H. Acquire all Portals in the center row without paying their costs.";

   image_large = { "M_TollmasterKylek", {0, 0, 364/512, 1} };
   image_medium = { "M_TollmasterKylek", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_TollmasterKylek", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_TollmasterKylek", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Tollmaster_Kylek_Defeat" };
   
   rarity_count = 1
}


g_ascension_active_effects["gain 1 rune for apprentice played"] = {
   type = "triggered";
   conditions = {
      { "WhenYouPlayApprentice", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerGainRunes", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}

g_ascension_active_effects["gain 1 power for militia played"] = {
   type = "triggered";
   conditions = {
      { "WhenYouPlayMilitia", 0 },
   };
   triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
      { "TriggerGainPower", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
   };
}


g_ascension_cards["Defender of Vigil"] = {
	card_name = "Defender of Vigil";
	card_set = "promo";
	card_type = "Hero";
	
	rune_cost = 6;
	honor = 3;
		
	effects = {
		{ "GainRunes", 2 },
		{ "GainPower", 2 },
		{ "GainRunesForEachApprenticeAlreadyPlayed", 1 },
		{ "GainPowerForEachMilitiaAlreadyPlayed", 1 },
		{ "Gain1RuneForEachApprenticePlayedThisTurn", 0 },
		{ "Gain1PowerForEachMilitiaPlayedThisTurn", 0 },

	};

	effect_text = "Gain 2R and 2P.\n" ..
					"Gain 1R for each Apprentice you play or have played this turn.\n" ..
					"Gain 1P for each Militia you play or have played this turn.";

   image_large = { "H_DefenderVigil", {0, 0, 364/512, 1} };
   image_medium = { "H_DefenderVigil", {392/512, 0, 512/512, 168/512} };
   image_small = { "H_DefenderVigil", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "H_DefenderVigil", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1
}


g_ascension_cards["David, Prophetic Guide"] = {
	card_name = "David, Prophetic Guide";
	card_set = "promo";
	card_type = "Hero";
	faction = "Enlightened";
	
	rune_cost = 5;
	honor = 3;
			
	effects = {
		{ "DrawCards", 3 },
		{ "DiscardMultipleFromHandToTopOfDeck", 2 },
	};

	effect_text = "Draw three card, then put two cards from your hand on top of your deck in any order.";
	
   image_large = { "EH_DavidPropheticGuide", {0, 0, 364/512, 1} };
   image_medium = { "EH_DavidPropheticGuide", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_DavidPropheticGuide", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_DavidPropheticGuide", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}


g_ascension_cards["Eye of Potential"] = {
	card_name = "Eye of Potential";
	card_set = "promo";
	card_type = "Construct";
	faction = "Enlightened";
		
	rune_cost = 6;
	honor = 3;
	
   construct_abilities = {
      {
         description = "Banish Card";
         condition = { "IfHasCardsInHand", 1 },
         { "PushResolvingConstruct", 0 },
         { "BanishFromHand", 0 },
         { "AcquireMysticOrHeavyInfantryToHand", 0, condition={"IfEffectInstanceDataIsBanishFromHand",1} },
         { "PopResolvingConstruct", 0 },
      },
   };
	effect_text = "Once per turn, you may banish a card in your hand. " ..
					"If you do, acquire a Mystic or Heavy Infantry without paying its cost and put it in your hand.";
	
   image_large = { "EC_EyePotential", {0, 0, 364/512, 1} };
   image_medium = { "EC_EyePotential", {392/512, 0, 512/512, 168/512} };
   image_small = { "EC_EyePotential", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EC_EyePotential", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1
}


g_ascension_cards["Forrest, Beastwarden"] = {
	card_name = "Forrest, Beastwarden";
	card_set = "promo";
	card_type = "Hero";
	faction = "Lifebound";
		
	rune_cost = 4;
	honor = 2;
		
	effects = {
		{ "GainRunes", 2 },
		{ "MayAcquireHeroFromVoidThisTurn", 1 },
	};
	
	effect_text = "Gain 2R.\n" ..
					"Once this turn, you may acquire a Hero in the void as though it were in the center row.";
	
   image_large = { "LH_ForrestBeastwarden", {0, 0, 364/512, 1} };
   image_medium = { "LH_ForrestBeastwarden", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_ForrestBeastwarden", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_ForrestBeastwarden", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}


g_ascension_cards["Lunar Matriarch"] = {
	card_name = "Lunar Matriarch";
	card_set = "promo";
	card_type = "Hero";
	faction = "Lifebound";
		
	rune_cost = 7;
	honor = 4;
		
	effects = {
		{ "GainHonor", 5 },
      		{ "AddConvertRunesToHonorCard", 5 },
	};
	
	effect_text = "Gain 5H.\n" ..
					"Once this turn, you may pay up to 5R to gain that much H.";
	
   image_large = { "LH_LunarMatriarch", {0, 0, 364/512, 1} };
   image_medium = { "LH_LunarMatriarch", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_LunarMatriarch", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_LunarMatriarch", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 1
}


g_ascension_cards["N.I.N.E."] = {
	card_name = "N.I.N.E.";
	card_set = "promo";
	card_type = "Hero";
	faction = "Mechana";
		
	rune_cost = 4;
	honor = 2;
	
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
		
	effects = {
		{ "GainRunes", 2 },
	};

	effect_text = "Gain 2R.\n" ..
					"When you play a Mechana Construct, you may return this from your discard pile to your hand. " ..
					"(Cards played during your turn do not go to your discard pile until the end of the turn.)";
	
   image_large = { "MH_NINE", {0, 0, 364/512, 1} };
   image_medium = { "MH_NINE", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_NINE", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_NINE", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}


g_ascension_cards["Tinkering Monk"] = {
	card_name = "Tinkering Monk";
	card_set = "promo";
	card_type = "Hero";
	faction = "Mechana";
		
	rune_cost = 4;
	honor = 2;
	
	effects = {
		{ "GainRunes", 2 },
		{ "EachPlayerGainHonorForMechanaConstructs", 1 },
	};
	
	effect_text = "Gain 2R.\n" ..
					"You may have each player gain H equal to the number of Mechana Constructs they control.";
	
   image_large = { "MH_TinkeringMonk", {0, 0, 364/512, 1} };
   image_medium = { "MH_TinkeringMonk", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_TinkeringMonk", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_TinkeringMonk", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}


g_ascension_cards["Ethereal Huntress"] = {
	card_name = "Ethereal Huntress";
	card_set = "promo";
	card_type = "Hero";
	faction = "Void";
		
	rune_cost = 5;
	honor = 3;
	
	effects = {
		{ "GainPower", 3 },
		{ "PutMonsterFromVoidOnTopOfPortalDeck", 1 },
	};
	
	effect_text = "Gain 3P.\n" ..
					"You may put a Monster from the Void on top of the center deck.";
	
   image_large = { "VH_EtherealHuntress", {0, 0, 364/512, 1} };
   image_medium = { "VH_EtherealHuntress", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_EtherealHuntress", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_EtherealHuntress", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}


g_ascension_cards["Chaos Rider"] = {
	card_name = "Chaos Rider";
	card_set = "promo";
	card_type = "Hero";
	faction = "Void";
		
    rune_cost = 3;
    power_cost = 3;
	honor = 3;
	
	effects = {
		{ "GainPower", 3 },
		{ "PutVoidCardFromDiscardIntoHand", 0 },
	};

	effect_text = "Gain 3P.\n" ..
					"You may return a Void card from your discard pile to your hand.";
	
   image_large = { "VH_ChaosRider", {0, 0, 364/512, 1} };
   image_medium = { "VH_ChaosRider", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_ChaosRider", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_ChaosRider", {384/512, 395/512, 512/512, 512/512} };
   
   rarity_count = 2
}


g_ascension_cards["Nova, Born of Chaos"] = {
	card_name = "Nova, Born of Chaos";
	card_set = "promo";
	card_type = "Monster";
	
	power_cost = 10;
	
	rewards = {
		{ "ReturnAllHonorTokensToHonorPool", 0 },
		{ "SetGameCannotEndThisRound", 1 },
		{ "GainHonor", 10 },
	},

	effect_text = "Reward: All players return all honor tokens to the honor pool. " ..
					"If the game would end this round, it does not end.\n" ..
					"Gain 10H.";
					
   image_large = { "M_NovaBornChaos", {0, 0, 364/512, 1} };
   image_medium = { "M_NovaBornChaos", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_NovaBornChaos", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_NovaBornChaos", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Nova Born of Chaos" };
   
   rarity_count = 1
}





