


g_ascension_cards["Adayu the Omnipotent"] = { 
	card_name = "Adayu the Omnipotent";
	card_set = "RotF";
    display_name = "Adayu, the Chosen";
   card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 8;
	honor = 6;
	effect = { "AcquireOrDefeatAnyCenterRow", 0 };
	effect_text = "Acquire or defeat any card in the center row.  (You do not have to pay Runes or Power).";

   image_large = { "EH_AdayuChosen", {0, 0, 364/512, 1} };
   image_medium = { "EH_AdayuChosen", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_AdayuChosen", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_AdayuChosen", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}





g_ascension_cards["Arha Sensei"] = { 
	card_name = "Arha Sensei";
	card_set = "RotF";
    display_name = "Arha Sensei";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 3;
	honor = 2;
	effects = {
		{ "BanishFromHand", 0 },
		{ "AcquireMysticOrHeavyInfantryToHand", 0, condition={"IfYouDo",0} },
	};
	effect_text = "Banish a card in your hand.  If you do, acquire a Mystic or Heavy Infantry.  Add it to your hand.";

   ai = {
      might_not_play = true,
   },

   
   image_large = { "EH_ArhaSensei", {0, 0, 364/512, 1} };
   image_medium = { "EH_ArhaSensei", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_ArhaSensei", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_ArhaSensei", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}




function EachPlayerDrawCards( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

   ascensionrules.EachPlayerDrawCards( active_player, state_machine, effect_data );
end


g_ascension_cards["Askara of Fate"] = { 
	card_name = "Askara of Fate";
	card_set = "RotF";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 4;
	honor = 2;
	center_row = { "EachPlayerDrawCards", 1 },

	effects = {
		{ "DrawCards", 2 },
		{ "EachOpponentDrawCards", 1 },
		{ "BanishFromCenterRow", 1 },
	};
	--effect_text = "FATE: When this enters the center row, each player may draw a card.\nDraw two cards.  Each other player may draw a card.  Then you may banish a card in the center row.";
	fate_text = "FATE: When this enters the center row, each player may draw a card.";
	effect_text = "Draw two cards.  Each other player may draw a card.  Then you may banish a card in the center row.";

   ai = {
      trivial_draw = 2,

      gain_draw = 2,
   },

   image_large = { "EH_AskaraFate", {0, 0, 364/512, 1} };
   image_medium = { "EH_AskaraFate", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_AskaraFate", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_AskaraFate", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

function AtEndOfConstructOwnerTurn( world, active_effect, event, duration_data )

	if( EventTurnSequence.IsTurnSequenceEndTurn(event) ) then
		local event_player = EventTurnSequence.GetTurnPlayer( event );
		local source_instance = ActiveEffectInstance.GetSourceInstance( active_effect );
		local source_player = ConstructInstance.GetOwner( source_instance );
		
		if( Player.IsSamePlayer(event_player,source_player) ) then
			return true
		end
	end
	
	return false
end

function IfNoCardsWereAcquired( world, active_effect, event, duration_data )
	return World.GetAcquiredCardCount( world ) == 0;
end

function IfNoMonstersWereDefeated( world, active_effect, event, duration_data )
	return World.GetDefeatedMonsterCount( world ) == 0;
end

function DiscardThisConstruct( state_machine, active_instance, source, event, effect_data )

	local construct_instance = source
	local construct_card = ConstructInstance.GetCardInstance( construct_instance )
	local construct_owner = ConstructInstance.GetOwner( construct_instance )
				
	if( Player.RemoveConstructFromPlay(construct_owner,construct_instance) ) then
	
		Player.PutCardInDiscard( construct_owner, construct_card )
		--Player.UpdateHonorCardTotal( construct_owner );

		local world = Instance.GetWorld( construct_owner );
		local output_message = string.format( "%s discards %s from play\n",
				Instance.GetName(construct_owner), Instance.GetName(construct_card) )
		World.OutputMessage( world, output_message )
		
	end
end

g_ascension_cards["Dhartha's Retreat"] = { 
	card_name = "Dhartha's Retreat";
	card_set = "RotF";
	card_type = "Construct";
	faction = "Enlightened";
	rune_cost = 4;
	honor = 3;
	triggered_effects = {
		{
			conditions = {
				{"AtEndOfConstructOwnerTurn", 0 },
				{"IfNoCardsWereAcquired", 0 },
				{"IfNoMonstersWereDefeated", 0 },
			};
			triggereffect = {
				--{"DiscardThisConstruct", 0},
				{"TriggerConstructOwnerDrawCards", 2},
			};
		},
	};
	effect_text = "If you do not acquire or defeat a card on your turn, you may draw two additional cards at the end of your turn.";

   image_large = { "EC_DharthasRetreat", {0, 0, 364/512, 1} };
   image_medium = { "EC_DharthasRetreat", {392/512, 0, 512/512, 168/512} };
   image_small = { "EC_DharthasRetreat", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EC_DharthasRetreat", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


function IfEffectInstanceDataIsMonster( world, active_player, source_instance, condition_data, effect_instance_data )

	local instance = AscensionEffectInstanceData.GetEffectData_ptr( effect_instance_data, condition_data );
	local card = CardInstance.GetCard( instance );
	
	return( AscensionCard.GetCardType(card) == "Monster" );
end

--[[
function GainEffectInstanceDataCardHonor( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

	local instance = AscensionEffectInstanceData.GetEffectData_ptr( effect_instance_data, effect_data );
	local card = CardInstance.GetCard( instance );
	local honor_value = AscensionCard.GetHonorValue();
	
	if( honor_value > 0 ) then
	
		local output_message = string.format( "%s gains %d honor tokens\n", Instance.GetName(active_player), honor_value )
		World.OutputMessage( world, output_message )
	
		Player.AddHonorTokens( active_player, honor_value )
		
		World.TakeHonorTokenPool( world, honor_value )
	end
		
end
]]

g_ascension_cards["Eternal Askara"] = { 
	card_name = "Eternal Askara";
	card_set = "RotF";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 5;
	honor = 3;
	effects = {
		{ "BanishFromCenterRow", 0 },
		{ "GainHonor", 3, condition={"IfEffectInstanceDataIsMonster",0} },
	};
	effect_text = "Banish a card in the center row.   If you banish a monster this way, gain 3H.";

   ai = {
      might_not_play = true,
   },

   image_large = { "EH_EternalAskara", {0, 0, 364/512, 1} };
   image_medium = { "EH_EternalAskara", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_EternalAskara", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_EternalAskara", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

--[[
function IfRulesVersionIsLessThan( world, effect_instance, event, condition_data )
   return World.GetRulesVersion(world) < condition_data;
end

function IfRulesVersionIsAtLeast( world, effect_instance, event, condition_data )
   return World.GetRulesVersion(world) >= condition_data;
end
]]

g_ascension_cards["Hectic Scribe"] = { 
	card_name = "Hectic Scribe";
	card_set = "RotF";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 1;
	honor = 1;
	effects = {
		{ "DrawCards", 2 },
		{ "DiscardFromHand", 0, condition={"IfRulesVersionIsLessThan",4} },
		{ "DiscardFromHand", 0, condition={"IfRulesVersionIsLessThan",4} },
		{ "DiscardMultipleFromHand", 2, condition={"IfRulesVersionIsAtLeast",4} },
	};
	effect_text = "Draw two cards, then discard two cards.";

   ai = {
      might_not_play = true,
   },

   image_large = { "EH_HecticScribe", {0, 0, 364/512, 1} };
   image_medium = { "EH_HecticScribe", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_HecticScribe", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_HecticScribe", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}










g_ascension_cards["Nairi, Henge Queen"] = { 
	card_name = "Nairi, Henge Queen";
	card_set = "RotF";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 6;
	honor = 3;
	effect = { "GainHonor", 5 };
	effect_text = "Gain 5H.";

   ai = {
      trivial = true,

      gain_honor = 5,
   },

   image_large = { "LH_NairiHengeQueen", {0, 0, 364/512, 1} };
   image_medium = { "LH_NairiHengeQueen", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_NairiHengeQueen", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_NairiHengeQueen", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

function GainHonorForEachLifeboundHeroAlreadyPlayed( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

	local played_count = World.GetPlayedHeroCount( world, "Lifebound" )
	GainHonor( state_machine, world, active_player, effect_data * played_count );
	
end

function WhenYouPlayLifeboundHero( world, effect_instance, event, condition_data )

	if( EventPlayHero.IsPlayHero(event) ) then
		local event_player = EventPlayHero.GetTurnPlayer( event );
		local effect_player = ActiveEffectInstance.GetEffectInstance( effect_instance );
	
		if( Player.IsSamePlayer(event_player,effect_player) ) then
		
			local event_card_instance = EventPlayHero.GetHeroCard( event );
			local event_card = CardInstance.GetCard( event_card_instance );

			if( AscensionCard.GetCardType(event_card) == "Hero" ) then
			
				local world = Instance.GetWorld( event_player )
				if( World.QueryCardFaction(world,event_player,event_card_instance,"Lifebound") ) then
					return true;
				end
				
			end
			
		end

	end
	
	return false;
	
end

g_ascension_active_effects["gain 1 honor for lifebound hero played"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayLifeboundHero", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerGainHonor", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

function Gain1HonorForEachLifeboundHeroPlayedThisTurn( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )
	
	local new_effect = ActiveEffectInstance.Create( world, "gain 1 honor for lifebound hero played", source_instance, active_player )
	ActiveEffectInstance.AddEffectDuration( new_effect, "UntilEndOfTurn", 0 )
	World.AddActiveEffect( world, new_effect )
	
end



g_ascension_cards["Dandelion Witch"] = { 
	card_name = "Dandelion Witch";
	card_set = "RotF";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 4;
	honor = 2;
	effects = {
		{ "DrawCards", 1 },
		{ "GainHonorForEachLifeboundHeroAlreadyPlayed", 1 },
		{ "Gain1HonorForEachLifeboundHeroPlayedThisTurn", 0 },
	};
	effect_text = "Draw a card.  Gain 1H for each Lifebound Hero you play or have played this turn (including this one).";


   ai = {
      trivial_draw = 1,

      gain_draw = 1;
   },

   image_large = { "LH_DandelionWitch", {0, 0, 364/512, 1} };
   image_medium = { "LH_DandelionWitch", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_DandelionWitch", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_DandelionWitch", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}



--[[
function GainHonorIfTopOfDeckIsApprentice( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

   local reveal_card = Player.RevealTopCardFromDeck( active_player )
   if( Instance.GetName(reveal_card) == "Apprentice" ) then
      GainHonor( state_machine, world, active_player, effect_data, source_instance, effect_instance_data );
   end
end
]]

g_ascension_cards["Great-Omen Raven"] = { 
	card_name = "Great-Omen Raven";
	card_set = "RotF";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 2;
	honor = 1;
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
   
   image_large = { "LH_GreatOmenRaven", {0, 0, 364/512, 1} };
   image_medium = { "LH_GreatOmenRaven", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_GreatOmenRaven", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_GreatOmenRaven", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}

--[[
function GainRunesOrHonor( state_machine, world, active_player, effect_data )

	local new_state = ascensionrules.CreateStateProcessGainRunesOrHonor( active_player, effect_data );
	StateMachine.PushListState( state_machine, new_state )
end
]]

g_ascension_cards["Lunar Stag"] = { 
	card_name = "Lunar Stag";
	card_set = "RotF";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 3;
	honor = 1;
	effects = {
		--{ "GainRunesOrHonor", 2 },
		{ "ChooseFromEffectList",
			{
				{
					{ "GainRunes", 2 },
					description = "Gain 2 Runes",
				},
				{
					{ "GainHonor", 2 },
					description = "Gain 2 Honor",
				},
			}
		}			
	};
	effect_text = "Gain 2R or 2H.";


   ai = {
      gain_rune = 1;
      gain_honor = 1;
   },

   image_large = { "LH_LunarStag", {0, 0, 364/512, 1} };
   image_medium = { "LH_LunarStag", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_LunarStag", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_LunarStag", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


--[[
function IfCanAcquireHeroFromVoid( world, effect_instance, event, condition_data )

	local active_player = World.GetCurrentTurnPlayer( world );
	
	return ascensionrules.CanAcquireFromVoid( active_player, "Hero", nil );
end
]]

function AcquireHeroFromTheVoid( state_machine, world, active_player, effect_data )

	local new_state = ascensionrules.CreateStateProcessAcquireFromTheVoid( active_player, "Hero", "" );
	StateMachine.PushListState( state_machine, new_state )
end

g_ascension_cards["Serpentcall"] = { 
	card_name = "Serpentcall";
	card_set = "RotF";
	card_type = "Construct";
	faction = "Lifebound";
	rune_cost = 7;
	honor = 4;

	construct_abilities = {
		{
			ability_name = "Serpentcall to Gain 2 Runes",
			description = "Gain 2R";
			{ "GainRunes", 2 },

         ai = {
            trivial = true,
         },
		},
		{
			ability_name = "Serpentcall to acquire Hero",
			description = "Acquire";
			condition = { "IfCanAcquireHeroFromVoid", 0 },
			{ "AcquireHeroFromTheVoid", 0 },
		},
	};
	effect_text = "Once per turn, gain 2R.\nOnce per turn, you may acquire a hero from the Void by paying its Rune cost.";

   image_large = { "LC_Serpentcall", {0, 0, 364/512, 1} };
   image_medium = { "LC_Serpentcall", {392/512, 0, 512/512, 168/512} };
   image_small = { "LC_Serpentcall", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LC_Serpentcall", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}







--[[
function RevealTopCardOfDeck( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

	local new_state = ascensionrules.CreateStateProcessRevealTopCardOfDeck( active_player, effect_instance_data );
	StateMachine.PushListState( state_machine, new_state )
end


function IfEffectInstanceDataIsLifeboundHero( world, active_player, source_instance, condition_data, effect_instance_data )

	local instance = AscensionEffectInstanceData.GetEffectData_ptr( effect_instance_data, condition_data );
	local card = CardInstance.GetCard( instance );
	
	return( AscensionCard.GetCardType(card) == "Hero" and World.QueryCardFaction(world,active_player,instance,"Lifebound") );
end


g_ascension_cards["Stone Circle"] = { 
	card_name = "Stone Circle";
	card_type = "Construct";
	faction = "Lifebound";
	rune_cost = 5;
	honor = 3;
	construct_abilities = {
		{
			ability_name = "Stone Circle to Reveal Top Card",
			description = "Reveal Top Card";
         { "PushResolvingConstruct", 0 },
			{ "RevealTopCardOfDeck", 0 },
			{ "DrawCards", 1, condition={"IfEffectInstanceDataIsLifeboundHero",1} },
         { "PopRevealedCardToDeck", 1 },
         { "PopResolvingConstruct", 0 },
		},
		{
			ability_name = "Stone Circle to gain 1 Honor",
			description = "Gain 1H for 2R";
			condition = { "IfHasCurrentTurnRunes", 2 },
         { "PayRunes", 2 },
			{ "GainHonor", 1 },
		},
	};
	effect_text = "Once per turn, you may reveal the top card of your deck.  If it's a Lifebound Hero, draw it.\nOnce per turn, you may spend 2R to gain 1H.";
}
]]


--[[
function EachPlayerMayAcquireMysticOrHeavyInfantryToTopOfDeck( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

	local player_count = World.GetPlayerCount( world )
	for index=1,player_count do
		local player = World.GetPlayer( world, index );
		AcquireMysticOrHeavyInfantryToTopOfDeck( state_machine, world, player, effect_data );
	end
end
]]

function EachPlayerMayAcquireMysticOrHeavyInfantryToTopOfDeck( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

   ascensionrules.EachPlayerAcquireMysticOrHeavyInfantry( active_player, state_machine, effect_data, 0, 0 );
   --local new_state = ascensionrules.CreateStateProcessAcquireMysticOrHeavyInfantry( active_player, effect_data, 0, 0 );
   --StateMachine.PushListState( state_machine, new_state )
end

function MayPutAcquiredHeroOnTopOfDeckOncePerTurn( world, effect_instance, event, effect_data )

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

   if( AscensionCard.GetCardType(event_card) ~= "Hero" ) then			
      return false			
   end

   EventQueryAcquireCardLocation.AddAcquireLocationTopOfDeck( event, effect_instance )
   return true

end

g_ascension_cards["Stone Circle"] = { 
	card_name = "Stone Circle";
	card_set = "RotF";
	card_type = "Construct";
	faction = "Lifebound";
	rune_cost = 5;
	honor = 4;
   
	center_row = { "EachPlayerMayAcquireMysticOrHeavyInfantryToTopOfDeck", 1 },

   continuous_effects = {
      {
         effect = {"MayPutAcquiredHeroOnTopOfDeckOncePerTurn", 0 };
      },
   };
	--effect_text = "FATE: When this enters the center row, each player may acquire a Mystic.  Put it on top of their deck.\nOnce per turn, when you acquire a Hero, you may put it on top of your deck.";
	fate_text = "FATE: When this enters the center row, each player may acquire a Mystic.  Put it on top of their deck.";
	effect_text = "Once per turn, when you acquire a Hero, you may put it on top of your deck.";

   image_large = { "LC_StoneCircle", {0, 0, 364/512, 1} };
   image_medium = { "LC_StoneCircle", {392/512, 0, 512/512, 168/512} };
   image_small = { "LC_StoneCircle", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LC_StoneCircle", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


--[[
function IfCanAcquireHeroOrConstructWithCostLessThanMechanaConstructs( world, effect_instance, event, condition_data )

	local turn_player = World.GetCurrentTurnPlayer( world );
	
	local construct_count = Player.CountConstructsInPlay( turn_player, "Mechana" );
	return ascensionrules.CanAcquireHeroOrConstruct( turn_player, construct_count );
end
]]

function AcquireHeroOrConstructWithCostLessThanMechanaConstructs( state_machine, world, active_player, effect_data )

	local construct_count = Player.CountConstructsInPlay( active_player, "Mechana" );
	local new_state = ascensionrules.CreateStateProcessAcquireHeroOrConstruct( active_player, construct_count );
	StateMachine.PushListState( state_machine, new_state )
end


g_ascension_cards["Project Alpha"] = { 
	card_name = "Project Alpha";
	card_set = "RotF";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 7;
	honor = 7;
	construct_ability = {
		description = "Acquire";
		condition = { "IfCanAcquireHeroOrConstructWithCostLessThanMechanaConstructs", 0 },
		{ "AcquireHeroOrConstructWithCostLessThanMechanaConstructs", 0 },
	};
	effect_text = "Once per turn, you may acquire a Hero or Construct with cost less than or equal to the number of Mechana Constructs you control.";

   image_large = { "MC_ProjectAlpha", {0, 0, 364/512, 1} };
   image_medium = { "MC_ProjectAlpha", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_ProjectAlpha", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_ProjectAlpha", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

function TreatAllConstructsAsMechanaConstructs( world, effect_instance, event, effect_data )

	if( EventQueryCardFaction.IsQueryCardFaction(event) ) then
		local query_player = EventQueryCardFaction.GetQueryPlayer( event )
		
		local source_player = ActiveEffectInstance.GetSourceInstance( effect_instance );
		
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

g_ascension_active_effects["all constructs are mechana"] = {
	type = "continuous";
	effectfunc = { "TreatAllConstructsAsMechanaConstructs", 0 };
}

function AllConstructsAreMechanaUntilEndOfTurn( state_machine, world, active_player, effect_data )
	
	local new_effect = ActiveEffectInstance.Create( world, "all constructs are mechana", active_player, active_player )
	ActiveEffectInstance.AddEffectDuration( new_effect, "UntilEndOfTurn", 0 )
	World.AddActiveEffect( world, new_effect )
	
end

g_ascension_cards["Dimension Diver"] = { 
	card_name = "Dimension Diver";
	card_set = "RotF";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 3;
	honor = 1;
	effects = {
		{ "GainRunes", 2 },
		{ "AllConstructsAreMechanaUntilEndOfTurn", 0 },
	};
	effect_text = "Gain 2R.  You may treat all Constructs as Mechana Constructs this turn.";

   ai = {
      trivial = true,

      gain_rune = 2;
   },

   image_large = { "MH_DimensionDiver", {0, 0, 364/512, 1} };
   image_medium = { "MH_DimensionDiver", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_DimensionDiver", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_DimensionDiver", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

--[[
   function IfYouControlMechanaConstructs( world, effect_instance, event, condition_data )

      --local source_instance = ActiveEffectInstance.GetSourceInstance( effect_instance );
      --local source_player = ConstructInstance.GetOwner( source_instance );
      local turn_player = World.GetCurrentTurnPlayer( world );
      
      local construct_count = Player.CountConstructsInPlay( turn_player, "Mechana" );
      return( construct_count >= condition_data )
   end
]]

g_ascension_cards["Combustion Idol"] = { 
	card_name = "Combustion Idol";
	card_set = "RotF";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 5;
	honor = 5;
	construct_abilities = {
		{
			description = "Draw a Card";
			condition = { "IfYouControlMechanaConstructs", 3 },
			{ "DrawCards", 1 },

         ai = {
            trivial_draw = 1,

            gain_draw = 1,
         },
		},
	};
	effect_text = "Once per turn, you may draw a card if you control three or more Mechana Constructs.";

   ai = {
      trivial_draw = 1,

      gain_draw = 1,
   },

   image_large = { "MC_CombustionIdol", {0, 0, 364/512, 1} };
   image_medium = { "MC_CombustionIdol", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_CombustionIdol", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_CombustionIdol", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Battery Monk"] = { 
	card_name = "Battery Monk";
	card_set = "RotF";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 2;
	honor = 1;
	effects = {
		{ "NextContructYouAcquireCostsLess", 1 },
		{ "DrawCards", 1 },
	};
	effect_text = "You may pay 1R less the next time you acquire a Construct this turn.  Draw a card.";

   ai = {
      trivial_draw = 1,

      gain_draw = 1;
   },

   image_large = { "MH_BatteryMonk", {0, 0, 364/512, 1} };
   image_medium = { "MH_BatteryMonk", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_BatteryMonk", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_BatteryMonk", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}




function EachPlayerMayAddConstructFromDiscardIntoHand( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

   ascensionrules.EachPlayerAddConstructFromDiscardIntoHand( active_player, state_machine );
end


function DiscardThisConstruct( state_machine, world, active_player, effect_data, source_instance )

   if( ConstructAbilityInstance.IsConstructAbilityInstance(source_instance) ) then
      local construct_instance = ConstructAbilityInstance.GetConstructInstance( source_instance )
      local construct_card = ConstructInstance.GetCardInstance( construct_instance )
      local construct_owner = ConstructInstance.GetOwner( construct_instance )

      local new_state = ascensionrules.CreateStateDiscardConstruct( construct_owner, construct_instance );
      StateMachine.PushListState( state_machine, new_state )
   end
end

--[[
function IfCanAcquireMechanaConstructFromVoid( world, effect_instance, event, condition_data )

	local active_player = World.GetCurrentTurnPlayer( world );
	
	return ascensionrules.CanAcquireFromVoid( active_player, "Construct", "Mechana" );
end
]]

function AcquireMechanaConstructFromTheVoid( state_machine, world, active_player, effect_data )

	local new_state = ascensionrules.CreateStateProcessAcquireFromTheVoid( active_player, "Construct", "Mechana" );
	StateMachine.PushListState( state_machine, new_state )
end

g_ascension_cards["Reclamax"] = { 
	card_name = "Reclamax";
	card_set = "RotF";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 4;
	honor = 4;

	center_row = { "EachPlayerMayAddConstructFromDiscardIntoHand", 0 },

	construct_abilities = {
		{
			--ability_name = "Reclamax to acquire Mechana Construct from Void",
			description = "Acquire";
			condition = { "IfCanAcquireMechanaConstructFromVoid", 0 },
         { "DiscardThisConstruct", 0 },
			{ "AcquireMechanaConstructFromTheVoid", 0 },
		},
	};
	--effect_text = "FATE: When this enters the center row, each player may choose a Construct in their discard pile and put it in their hand.\n"
    --              .. "You may discard Reclamax from play to acquire a Mechana Construct in the Void as though it were in the Center Row.";
	fate_text = "FATE: When this enters the center row, each player may choose a Construct in their discard pile and put it in their hand.";
	effect_text = "You may discard Reclamax from play to acquire a Mechana Construct in the Void as though it were in the Center Row.";

   image_large = { "MC_Reclamax", {0, 0, 364/512, 1} };
   image_medium = { "MC_Reclamax", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_Reclamax", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_Reclamax", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

--[[
function IfYouPlayedMechanaConstructs( world, effect_instance, event, condition_data )

	local played_count = World.GetPlayedHeroCount( world, "Mechana" );
	return( played_count >= condition_data );
	
end
]]

function WhenYouPutMechanaConstructIntoPlay( world, effect_instance, event, condition_data )

   if( EventPutConstructIntoPlay.IsPutConstructIntoPlay(event) ) then
      local event_player = EventPutConstructIntoPlay.GetTurnPlayer( event );
      local source_instance = ActiveEffectInstance.GetSourceInstance( effect_instance );
      local source_player = ConstructInstance.GetOwner( source_instance );

      if( Player.IsSamePlayer(event_player,source_player) ) then

         local event_card_instance = EventPutConstructIntoPlay.GetConstructCard( event );
         local event_card = CardInstance.GetCard( event_card_instance );

         if( AscensionCard.GetCardType(event_card) == "Construct" ) then

            if( World.QueryCardFaction(world,event_player,event_card_instance,"Mechana") ) then
               return true;
            end

         end

      end

   end

   return false;

end

g_ascension_cards["Socket Altar"] = { 
	card_name = "Socket Altar";
	card_set = "RotF";
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
				{"TriggerConstructGainRunes", 2},
				{"TriggerSetThisHasBeenUsedThisTurn", 0},
			};
		},
	};

	effect_text = "Once per turn, when you put a Mechana Construct into play (including this one), gain 2R.";

   image_large = { "MC_SocketAltar", {0, 0, 364/512, 1} };
   image_medium = { "MC_SocketAltar", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_SocketAltar", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_SocketAltar", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


--[[
function CreateStateProcessDiscardConstructInPlay( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

	local new_state = ascensionrules.CreateStateProcessDiscardConstructInPlay( active_player, effect_data, effect_instance_data );
	StateMachine.PushListState( state_machine, new_state )
end

g_ascension_cards["Ferromancer's Helper"] = { 
	card_name = "Ferromancer's Helper";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 4;
	honor = 2;
	effects = {
		{ "GainRunes", 2 },
		{ "CreateStateProcessDiscardConstructInPlay", 1 },
		{ "GainPower", 2, condition={"IfYouDo",1} },
	};
	effect_text = "Gain 2R.  You may put a Construct you control into your discard pile.  If you do, gain 2P.";
}
]]

--[[
function EachPlayerMayBanishFromHandOrDiscard( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

	local player_count = World.GetPlayerCount( world )
	for index=1,player_count do
		local player = World.GetPlayer( world, index );
		BanishFromHandOrDiscard( state_machine, world, player, effect_data )
   --local new_state = ascensionrules.CreateStateProcessBanishFromHandOrDiscard( active_player, effect_data, effect_instance_data );
   --StateMachine.PushListState( state_machine, new_state )
	end
end
]]

function EachPlayerMayBanishFromHandOrDiscard( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

   ascensionrules.EachPlayerBanishFromHandOrDiscard( active_player, state_machine, effect_data );
end


g_ascension_cards["Arbiter of Fate"] = { 
	card_name = "Arbiter of Fate";
	card_set = "RotF";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 4;
	honor = 2;

	center_row = { "EachPlayerMayBanishFromHandOrDiscard", 1 },

	effects = {
		{ "DrawCards", 1 },
		{ "BanishFromHandOrDiscard", 1 },
	};
	--effect_text = "FATE: When this enters the center row, each player may banish a card from their hand or discard pile.\nDraw a card. You may banish a card in your hand or discard pile.";
	fate_text = "FATE: When this enters the center row, each player may banish a card from their hand or discard pile.";
	effect_text = "Draw a card. You may banish a card in your hand or discard pile.";

   ai = {
      trivial_draw = 1,

      gain_draw = 1;
   },

   image_large = { "VH_ArbiterFate", {0, 0, 364/512, 1} };
   image_medium = { "VH_ArbiterFate", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_ArbiterFate", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_ArbiterFate", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


function WhenYouDefeatMonsterWithPower( world, active_effect_instance, event, condition_data )

	if( EventDefeatMonster.IsDefeatMonster(event) ) then
      if( EventDefeatMonster.IsDefeatFromCenterRow(event) or EventDefeatMonster.IsDefeatFromVoid(event) ) then
         local event_player = EventDefeatMonster.GetTurnPlayer( event );
         local target_instance = ActiveEffectInstance.GetEffectInstance( active_effect_instance );
      
         if( Player.IsSamePlayer(event_player,target_instance) ) then
      
            if( World.GetRulesVersion(world) >= 4 ) then
               return true;
            end
            
            local monster_instance = EventDefeatMonster.GetMonsterCard(event);
            local monster_card = CardInstance.GetCard( monster_instance );
            local power_cost = AscensionCard.GetPowerCost( monster_card );
            
            return power_cost >= condition_data;
            
         end
      end
	end
	
	return false;
	
end

g_ascension_active_effects["monster defeated with power 3 gains 2 honor"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouDefeatMonsterWithPower", 3 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerGainHonor", 2 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}


function UntilMonsterIsDefeatedFromCenterRow( world, active_effect_instance, event, condition_data )
	
	if( EventDefeatMonster.IsDefeatMonster(event) ) then
	
      if( EventDefeatMonster.IsDefeatFromCenterRow(event) or EventDefeatMonster.IsDefeatFromVoid(event) ) then
         local event_player = EventDefeatMonster.GetTurnPlayer( event );
         local effect_target = ActiveEffectInstance.GetEffectInstance( active_effect_instance );
      
         return Player.IsSamePlayer( event_player, effect_target );
      end
	end
	
	return false;
	
end


function NextMonsterWithPower3YouDefeatGains2Honor( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )
	
	local new_effect = ActiveEffectInstance.Create( world, "monster defeated with power 3 gains 2 honor", source_instance, active_player )
	ActiveEffectInstance.AddEffectDuration( new_effect, "UntilMonsterIsDefeatedFromCenterRow", 0 )
	ActiveEffectInstance.AddEffectDuration( new_effect, "UntilEndOfTurn", 0 )
	World.AddActiveEffect( world, new_effect )
	
end

g_ascension_cards["Guardian of Sadranis"] = { 
	card_name = "Guardian of Sadranis";
	card_set = "RotF";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 1;
	honor = 1;
	effects = {
		{ "GainPower", 1 },
		{ "NextMonsterWithPower3YouDefeatGains2Honor", 1 },
	};
	effect_text = "Gain 1P. The next time you defeat a Monster in the center row or the Void this turn, gain 2H.";

   ai = {
      gain_power = 1,
   },

   image_large = { "VH_GuardianSadranis", {0, 0, 364/512, 1} };
   image_medium = { "VH_GuardianSadranis", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_GuardianSadranis", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_GuardianSadranis", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


--[[
function IfHasCardsInHand( world, effect_instance, event, condition_data )

	local active_player = World.GetCurrentTurnPlayer( world );

	return Player.CountCardsInHand( active_player ) >= condition_data;
end
]]


g_ascension_cards["Black Hole"] = { 
	card_name = "Black Hole";
	card_set = "RotF";
	card_type = "Construct";
	faction = "Void";
	rune_cost = 5;
	honor = 4;
	construct_ability = {
		description = "Banish -> 1P";
		condition = { "IfHasCardsInHand", 1 },
		{ "BanishFromHand", 0 },
		{ "GainPower", 1, condition={"IfYouDo",0} },
	};
	effect_text = "Once per turn, you may banish a card in your hand.  If you do, gain 1P.";

   image_large = { "VC_BlackHole", {0, 0, 364/512, 1} };
   image_medium = { "VC_BlackHole", {392/512, 0, 512/512, 168/512} };
   image_small = { "VC_BlackHole", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VC_BlackHole", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Deathseeker"] = { 
	card_name = "Deathseeker";
	card_set = "RotF";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 2;
	honor = 1;
	effect = { "GainPower", 2 };
	banish_effect = { "GainHonor", 3, condition={"IfBanishEventIsFromHandOrDiscard",0} };
	effect_text = "Gain 2P.  If this is banished from your hand or discard pile, gain 3H.";

   ai = {
      trivial = true,
      preferred_banish = true,

      gain_power = 2,
   },

   image_large = { "VH_Deathseeker", {0, 0, 364/512, 1} };
   image_medium = { "VH_Deathseeker", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_Deathseeker", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_Deathseeker", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


function DefeatMonsterFromTheVoid( state_machine, world, active_player, effect_data )

	local new_state = ascensionrules.CreateStateProcessDefeatMonsterFromTheVoid( active_player );
	StateMachine.PushListState( state_machine, new_state )
end

g_ascension_cards["Sadranis, Dark Emissary"] = { 
	card_name = "Sadranis, Dark Emissary";
	card_set = "RotF";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 7;
	honor = 4;
	effects = {
		{ "GainPower", 3 },
		{ "DefeatMonsterFromTheVoid", 0 },
	};
	effect_text = "Gain 3P. You may defeat a Monster from the Void by paying its Power cost. Put it on the bottom of the center deck.";

   image_large = { "VH_SadranisDarkEmissary", {0, 0, 364/512, 1} };
   image_medium = { "VH_SadranisDarkEmissary", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_SadranisDarkEmissary", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_SadranisDarkEmissary", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Black Watch Elite"] = { 
	card_name = "Black Watch Elite";
	card_set = "RotF";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 5;
	honor = 2;
	effects = {
		{ "GainPower", 3 },
		{ "BanishFromHandOrDiscard", 1 },
	};
	effect_text = "Gain 3P.  You may banish a card in your hand or discard pile.";

   ai = {
      gain_power = 3;
   },

   image_large = { "VH_BlackWatchElite", {0, 0, 364/512, 1} };
   image_medium = { "VH_BlackWatchElite", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_BlackWatchElite", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_BlackWatchElite", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}









function EachOpponentDiscardsFromHandForEachConstruct( state_machine, world, active_player, effect_data )

   local new_state = ascensionrules.CreateStateEachOpponentDiscardsFromHandForEachConstruct( active_player );
   StateMachine.PushListState( state_machine, new_state )
end

g_ascension_cards["Bazu, Duke of Scorn"] = { 
   card_name = "Bazu, Duke of Scorn";
	card_set = "RotF";
   card_type = "Monster";
   power_cost = 6;
   rewards = {
      { "GainHonor", 4 },
      { "EachOpponentDiscardsFromHandForEachConstruct", 0 },
   };
   effect_text = "Reward: Gain 4H.  Each opponent either discards a card for each Construct they control or puts all Constructs into their discard pile.";

   image_large = { "M_BazuDukeScorn", {0, 0, 364/512, 1} };
   image_medium = { "M_BazuDukeScorn", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_BazuDukeScorn", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_BazuDukeScorn", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Duke of Scorn" };

   rarity_count = 1
}




g_ascension_cards["Doom Weeper"] = { 
	card_name = "Doom Weeper";
	card_set = "RotF";
	card_type = "Monster";
	power_cost = 4;
	rewards = {
		{ "GainHonor", 2 },
		{ "GainRunes", 2 },
	};
	effect_text = "Reward: Gain 2H.  Gain 2R.";

   image_large = { "M_DoomWeeper", {0, 0, 364/512, 1} };
   image_medium = { "M_DoomWeeper", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_DoomWeeper", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_DoomWeeper", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Doom Weeper" };

   rarity_count = 3
}


--[[
function EachOpponentLosesHonor( state_machine, world, active_player, effect_data )

	local player_count = World.GetPlayerCount( world )
	for index=1,player_count do
		local player = World.GetPlayer( world, index );
		if( not Player.IsSamePlayer(player,active_player) ) then
		
			local honor_count = Player.GetHonorTokenCount(player);
			local lose_honor = effect_data;
			if( honor_count < lose_honor ) then
				lose_honor = honor_count
			end
			
			if( lose_honor > 0 ) then
				Player.RemoveHonorTokens( player, lose_honor )
				
				-- do they go back into honor pool?
				-- World.TakeHonorTokenPool( world, effect_data )
	
				local output_message = string.format( "%s loses %d honor tokens\n", Instance.GetName(player), lose_honor )
				World.OutputMessage( world, output_message )
			end
			
		end
	end
	
end
]]

function EachOpponentDiscardsFromHand( state_machine, world, active_player, effect_data )

	local new_state = ascensionrules.CreateStateEachOpponentDiscardsFromHand( active_player );
	StateMachine.PushListState( state_machine, new_state )
end

g_ascension_cards["Fire Tyrant"] = { 
	card_name = "Fire Tyrant";
	card_set = "RotF";
	card_type = "Monster";
	power_cost = 6;
   rewards = {
      { "GainHonor", 6 },
      { "EachOpponentDiscardsFromHand", 0 },
   };
   effect_text = "Reward: Gain 6H.  Each opponent must discard a card.";

   --[[
   rewards = {
		{ "ChooseFromEffectList",
			{
				{
					{ "EachOpponentLosesHonor", 5 },
					{ "EachOpponentDiscardsFromHand", 0 },
					description = "Opponents lose 5H and discard",
				},
				{
					{ "GainHonor", 5 },
					{ "DrawCards", 1 },
					description = "Gain 5 Honor and draw a card",
				},
			}
		}			
	};
   effect_text = "Reward: Choose one - Each other player loses 5 Honor and discards a card OR Gain 5 Honor and draw a card."
   ]]


   image_large = { "M_FireTyrant", {0, 0, 364/512, 1} };
   image_medium = { "M_FireTyrant", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_FireTyrant", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_FireTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Fire Tyrant" };

   rarity_count = 2
}



function BanishAllAdjacentFromCenterRow( state_machine, world, active_player, effect_data, source_instance, effect_instance_data, event )

	if( EventEnterCenterRow.IsEnterCenterRow(event) ) then
		
		local center_row_index = EventEnterCenterRow.GetCenterRowIndex( event );
		
		local new_state = ascensionrules.CreateStateBanishAllAdjacentFromCenterRow( active_player, center_row_index );
		StateMachine.PushListState( state_machine, new_state )
	end
end

--[[
function TriggerBanishAllAdjacentFromCenterRow( state_machine, active_instance, source, event, effect_data  )

	local world = Instance.GetWorld( source );

	if( EventEnterCenterRow.IsEnterCenterRow(event) ) then
		
		local turn_player = World.GetCurrentTurnPlayer( world );
		local center_row_index = EventEnterCenterRow.GetCenterRowIndex( event );
		
		local new_state = ascensionrules.CreateStateBanishAllAdjacentFromCenterRow( turn_player, center_row_index );
		StateMachine.PushListState( state_machine, new_state )
	end
end
]]

function BanishFromAdjacentCenterRow( state_machine, world, active_player, effect_data, source_instance, effect_instance_data, event )

	if( EventDefeatMonster.IsDefeatMonster(event) ) then
		
      if( EventDefeatMonster.IsDefeatFromCenterRow(event) ) then
         local is_center_row, center_row_index = EventDefeatMonster.GetCenterRowPosition( event );
         if( is_center_row ) then
         
            local new_state = ascensionrules.CreateStateProcessBanishFromCenterRow( active_player, effect_data, center_row_index, effect_instance_data );
            StateMachine.PushListState( state_machine, new_state )
         end
      end
	end
end

g_ascension_cards["Ravenous Gorph"] = { 
	card_name = "Ravenous Gorph";
	card_set = "RotF";
	card_type = "Monster";
	power_cost = 3;
	center_row = { "BanishAllAdjacentFromCenterRow", 0 };
--[[
	center_row_triggered_effects = {
		{
			conditions = {
				{ "WhenThisEntersTheCenterRow", 0 },
			};
			triggereffect = {
				{ "TriggerOutputMessageThisEntersCenterRow", 0 },
				{ "TriggerBanishAllAdjacentFromCenterRow", 0 },
			};
		},
	};
]]
	rewards = {
		{ "GainHonor", 3 },
		{ "BanishFromAdjacentCenterRow", 1 },
	};
	--effect_text = "FATE: When this enters the center row, banish all cards adjacent to it.\nReward: Gain 3H. You may banish a card that was adjacent to this.";
	fate_text = "FATE: When this enters the center row, banish all cards adjacent to it.";
	effect_text = "Reward: Gain 3H. You may banish a card that was adjacent to this.";

   image_large = { "M_RavenousGorph", {0, 0, 364/512, 1} };
   image_medium = { "M_RavenousGorph", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_RavenousGorph", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_RavenousGorph", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Ravenous Gorph" };

   rarity_count = 3
}



function PutDefeatedMonsterCardIntoPlay( world, effect_instance, event, effect_data )

   if( not EventQueryDefeatCardLocation.IsQueryDefeatCardLocation(event) ) then
      return false
   end

   local source_instance = ActiveEffectInstance.GetSourceInstance( effect_instance );
   local event_card_instance = EventQueryDefeatCardLocation.GetQueryCard( event );
   if( not Instance.IsSameInstance(source_instance,event_card_instance) ) then
      return false
   end

   EventQueryDefeatCardLocation.AddDefeatLocationInPlay( event, nil )
   return true

end




function OwnerAcquiresDefeatedMonsters( world, effect_instance, event, effect_data )

   if( not EventQueryDefeatCardLocation.IsQueryDefeatCardLocation(event) ) then
      return false
   end

   local turn_player = EventQueryDefeatCardLocation.GetQueryPlayer( event );

   local source_instance = ActiveEffectInstance.GetSourceInstance( effect_instance );
   local source_player = CardInPlayInstance.GetOwner( source_instance );
   if( not Player.IsSamePlayer(turn_player,source_player) ) then
      return false
   end

   EventQueryDefeatCardLocation.AddDefeatLocationDiscardPile( event, nil )
   return true
end


g_ascension_cards["Samael the Fallen"] = { 
	card_name = "Samael the Fallen";
	card_set = "RotF";
	card_type = "Monster";
	power_cost = 8;
   --power_cost = 2;
   global_continuous_effects = {
      {
         effect = {"PutDefeatedMonsterCardIntoPlay", 0 };
      },
	};
	center_row_continuous_effects = {
		{
			effect = {"ThisCannotBeBanishedUnlessDefeated", 0 };
		},
      {
         effect = {"PutDefeatedMonsterCardIntoPlay", 0 };
      },
   };
	rewards = {
		{ "GainHonor", 8 },
		--{ "PutMonsterCardIntoPlay", 0 },
	};
	continuous_effects = {
		{
			effect = {"OwnerAcquiresDefeatedMonsters", 0 };
		},
	};
	effect_text = "Unbanishable.\nReward: Gain 8H.  Place this face up in front of you.  For the rest of the game, when you defeat a Monster in the center row, acquire it.  Monsters in your deck are considered Heroes that gain you Power equal to their cost.";

   image_large = { "M_SamaelFallen", {0, 0, 364/512, 1} };
   image_medium = { "M_SamaelFallen", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_SamaelFallen", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_SamaelFallen", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Samael Reborn" };

   rarity_count = 1
}

function GainHonorFromPlayerWithMostHonorTokens( state_machine, world, active_player, effect_data )

	local new_state = ascensionrules.CreateStateGainHonorFromPlayerWithMostHonorTokens( active_player, effect_data );
	StateMachine.PushListState( state_machine, new_state )
end

g_ascension_cards["Sordid Asp"] = { 
	card_name = "Sordid Asp";
	card_set = "RotF";
	card_type = "Monster";
	power_cost = 3;
	rewards = {
		{ "GainHonor", 1 },
		{ "GainHonorFromPlayerWithMostHonorTokens", 2 },
	};
	effect_text = "Reward: Gain 1H, then steal 2H from an opponent with the most Honor if they have more than you.";

   image_large = { "M_SordidAsp", {0, 0, 364/512, 1} };
   image_medium = { "M_SordidAsp", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_SordidAsp", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_SordidAsp", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Sordid Asp" };

   rarity_count = 4
}






function EachOpponentDiscardsHighestCostConstruct( state_machine, world, active_player, effect_data )

	--local new_state = ascensionrules.CreateStateEachOpponentDiscardsHighestCostConstruct( active_player );
	--StateMachine.PushListState( state_machine, new_state )

   ascensionrules.EachOpponentDiscardsHighestCostConstruct( active_player, state_machine );
end

g_ascension_cards["Vaultbreaker Wurm"] = { 
	card_name = "Vaultbreaker Wurm";
	card_set = "RotF";
	card_type = "Monster";
	power_cost = 5;
	rewards = {
		{ "GainHonor", 4 },
		{ "EachOpponentDiscardsHighestCostConstruct", 0 },
	};
	effect_text = "Reward: Gain 4H.  Each other player must discard their highest cost Construct. (They choose in case of a tie).";

   image_large = { "M_VaultbreakerWurm", {0, 0, 364/512, 1} };
   image_medium = { "M_VaultbreakerWurm", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_VaultbreakerWurm", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_VaultbreakerWurm", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "Vaultbreaker Wurm" };

   rarity_count = 3
}


