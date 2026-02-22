
g_ascension_cards["Militia SoS"] = { 
	card_name = "Militia SoS";
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
      
   --image_large = { "H_Militia_SOS", {0, 0, 364/512, 1} };
   --image_medium = { "H_Militia_SOS", {392/512, 0, 512/512, 168/512} };
   --image_small = { "H_Militia_SOS", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "H_Militia_SOS", {384/512, 395/512, 512/512, 512/512} };
   image_large = { "H_Militia", {0, 0, 364/512, 1} };
   image_medium = { "H_Militia", {392/512, 0, 512/512, 168/512} };
   image_small = { "H_Militia", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "H_Militia", {384/512, 395/512, 512/512, 512/512} };
}

g_ascension_cards["Apprentice SoS"] = { 
	card_name = "Apprentice SoS";
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

   --image_large = { "H_Apprentice_SOS", {0, 0, 364/512, 1} };
   --image_medium = { "H_Apprentice_SOS", {392/512, 0, 512/512, 168/512} };
   --image_small = { "H_Apprentice_SOS", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "H_Apprentice_SOS", {384/512, 395/512, 512/512, 512/512} };
   image_large = { "H_Apprentice", {0, 0, 364/512, 1} };
   image_medium = { "H_Apprentice", {392/512, 0, 512/512, 168/512} };
   image_small = { "H_Apprentice", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "H_Apprentice", {384/512, 395/512, 512/512, 512/512} };
}

g_ascension_cards["Mystic SoS"] = { 
	card_name = "Mystic SoS";
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

   --image_large = { "H_Mystic_SOS", {0, 0, 364/512, 1} };
   --image_medium = { "H_Mystic_SOS", {392/512, 0, 512/512, 168/512} };
   --image_small = { "H_Mystic_SOS", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "H_Mystic_SOS", {384/512, 395/512, 512/512, 512/512} };
   image_large = { "H_Mystic", {0, 0, 364/512, 1} };
   image_medium = { "H_Mystic", {392/512, 0, 512/512, 168/512} };
   image_small = { "H_Mystic", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "H_Mystic", {384/512, 395/512, 512/512, 512/512} };
}

g_ascension_cards["Heavy Infantry SoS"] = { 
	card_name = "Heavy Infantry SoS";
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

   --image_large = { "H_HeavyInfantry_SOS", {0, 0, 364/512, 1} };
   --image_medium = { "H_HeavyInfantry_SOS", {392/512, 0, 512/512, 168/512} };
   --image_small = { "H_HeavyInfantry_SOS", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "H_HeavyInfantry_SOS", {384/512, 395/512, 512/512, 512/512} };
   image_large = { "H_HeavyInfantry", {0, 0, 364/512, 1} };
   image_medium = { "H_HeavyInfantry", {392/512, 0, 512/512, 168/512} };
   image_small = { "H_HeavyInfantry", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "H_HeavyInfantry", {384/512, 395/512, 512/512, 512/512} };
}

g_ascension_cards["Cultist SoS"] = { 
	card_name = "Cultist SoS";
	display_name = "Cultist";
	card_type = "Monster";
	power_cost = 2;
   do_not_put_in_void = true;
	reward = { "GainHonor", 1 };
	effect_text = "Reward: Gain 1H.";
   --image_large = { "M_Cultist_SOS", {0, 0, 364/512, 1} };
   --image_medium = { "M_Cultist_SOS", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_Cultist_SOS", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_Cultist_SOS", {384/512, 395/512, 512/512, 512/512} };
   image_large = { "M_Cultist", {0, 0, 364/512, 1} };
   image_medium = { "M_Cultist", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_Cultist", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_Cultist", {384/512, 395/512, 512/512, 512/512} };
}

--[[
   function IfCurrentEventHasTrophyEffect( world, active_player, effect_source, condition_data, effect_instance_data )
         
      local current_event = World.GetEventCardInPlay( world );
      if( current_event == nil ) then
         return false
      end
      
      local event_card = CardInPlayInstance.GetCardInstance( current_event );
      local event_card_def = CardInstance.GetCard( event_card );
      local event_card_trophy_effect = AscensionCard.GetTrophyEffect( event_card_def );
      
      -- need to test that the effect can currently be used
      return( event_card_trophy_effect ~= nil );

   end
]]

g_ascension_cards["Fanatic SoS"] = { 
	card_name = "Fanatic SoS";
	display_name = "Fanatic";
	card_set = "SoS";
	card_type = "Monster";
	power_cost = 3;
   trophy_monster = true;
   unique_trophy = true;
   do_not_put_in_void = true;
   
	reward = { "GainHonor", 1 };
   
	trophy_effects = {
      usageconditions = {
         { "IfCurrentEventHasTrophyEffect", 2 },
      },
      { "BanishThisTrophy", 0 },
      { "GainCurrentEventTrophyEffect", 0 },
	};

	--effect_text = "Reward: Gain 2H.\n" ..
    --              "TROPHY: Banish this to gain the current Event Trophy's effect.";
	effect_text = "Reward: Gain 2H.";
	--trophy_text = "TROPHY: Banish this to gain the current Event Trophy's effect.";
	trophy_text = "<color=#951719FF><B>Trophy:</B></color> Banish this to gain the current Event Trophy's effect.";
				  
   --image_large = { "M_Fanatic_SOS", {0, 0, 364/512, 1} };
   --image_medium = { "M_Fanatic_SOS", {392/512, 0, 512/512, 168/512} };
   --image_small = { "M_Fanatic_SOS", {410/512, 170/512, 512/512, 312/512} };
   --image_half  = { "M_Fanatic_SOS", {384/512, 395/512, 512/512, 512/512} };
   image_large = { "M_Fanatic", {0, 0, 364/512, 1} };
   image_medium = { "M_Fanatic", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_Fanatic", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_Fanatic", {384/512, 395/512, 512/512, 512/512} };
}

   function WhenTurnPlayerDiscardsCard( world, effect_instance, event, condition_data )

      if( not EventDiscardCardsFromHand.IsDiscardCardsFromHand(event) ) then
         return false
      end
      
      local turn_player = World.GetCurrentTurnPlayer( world );
      local event_player = EventDiscardCardsFromHand.GetTurnPlayer( event );
      
      return Player.IsSamePlayer( turn_player, event_player );
      
   end
   
   
   function TriggerRecoverDiscardedCard( state_machine, active_instance, source, event, effect_data )

      if( EventDiscardCardsFromHand.IsDiscardCardsFromHand(event) ) then
         local event_player = EventDiscardCardsFromHand.GetTurnPlayer( event );
         local new_state = ascensionrules.CreateStateRecoverDiscardedCard( event_player, event, active_instance );
         StateMachine.PushListState( state_machine, new_state )
      end
   end
      

g_ascension_cards["Arha Rising"] = { 
	card_name = "Arha Rising";
	card_set = "SoS";
	card_type = "Event";
	faction = "Enlightened";
   
	triggered_effects = {
		{
			conditions = {
				{ "IfThisHasntBeenUsedThisTurn", 0 },
				{ "WhenTurnPlayerDiscardsCard", 0 },
            { "TriggerIfNotScryerOfLidlessEyeDiscard", 0 },
			};
			triggereffect = {
				{ "TriggerRecoverDiscardedCard", 0 },
			};
		},
	};
   
   trophy_effects = {
      { "DrawCards", 1 },
	};
   
   effect_text = "Once per turn, when a player discards any number of cards, they may return one of them to their hand.\n" ..
                  "EVENT TROPHY: Draw a card.";

   image_large = { "E_ArhaRising", {0, 0, 364/512, 1} };
   image_medium = { "E_ArhaRising", {392/512, 0, 512/512, 168/512} };
   image_small = { "E_ArhaRising", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "E_ArhaRising", {384/512, 395/512, 512/512, 512/512} };
}


   function PutCardFromHandUnderThisConstruct( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

      if( ConstructAbilityInstance.IsConstructAbilityInstance(source_instance) ) then
         local construct_instance = ConstructAbilityInstance.GetConstructInstance( source_instance )
         local construct_owner = ConstructInstance.GetOwner( construct_instance )

         local new_state = ascensionrules.CreateStatePutCardUnderConstruct( construct_owner, construct_instance, effect_instance_data );
         StateMachine.PushListState( state_machine, new_state )
      end
   end

g_ascension_cards["Dreamer's Glass"] = { 
	card_name = "Dreamer's Glass";
	card_set = "SoS";
	card_type = "Construct";
	faction = "Enlightened";
	rune_cost = 5;
	honor = 3;
   
	construct_abilities = {
		{
			description = "Put Card Under This";
			condition = { "IfHasCardsInHand", 1 },
			{ "PushResolvingConstruct", 0 },
			{ "PutCardFromHandUnderThisConstruct", 0 },
			{ "DrawCards", 1, condition={"IfYouDo",1} },
			{ "PopResolvingConstruct", 0 },
		},
	};
   
	effect_text = "Once per turn, you may put a card from your hand under this face up.\n" ..
                  "If you do, draw a card.\n" ..
                  "When Dreamer's Glass leaves play or the game ends, put all cards under it into your discard pile.";

   image_large = { "EC_DreamersGlass", {0, 0, 364/512, 1} };
   image_medium = { "EC_DreamersGlass", {392/512, 0, 512/512, 168/512} };
   image_small = { "EC_DreamersGlass", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EC_DreamersGlass", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Tower Askara"] = { 
	card_name = "Tower Askara";
	card_set = "SoS";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 5;
	honor = 2;
	effects = {
		{"DrawCards", 3},
		{"DiscardCardsOrEnlightenedCard", 2},
	};
	effect_text = "Draw 3 cards.  Then, discard 2 cards or an Enlightened card.";

   image_large = { "EH_TowerAskara", {0, 0, 364/512, 1} };
   image_medium = { "EH_TowerAskara", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_TowerAskara", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_TowerAskara", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


   function BanishHeroFromHand( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

      local new_state = ascensionrules.CreateStateProcessBanishFromHand( active_player, effect_data, "Hero", effect_instance_data );
      StateMachine.PushListState( state_machine, new_state )
   end
   
   function AcquireHeroWithPlus2HonorIntoHand( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )
      local banish_card = AscensionEffectInstanceData.GetEffectData_ptr( effect_instance_data, effect_data );
      if( banish_card ~= nil ) then
         local banish_card_def = CardInstance.GetCard( banish_card );
         local banish_honor = AscensionCard.GetHonorValue( banish_card_def );
         
         local acquire_honor = banish_honor + 2;
         local new_state = ascensionrules.CreateStateProcessAcquireHeroOfHonorValueToHand( active_player, acquire_honor );
         StateMachine.PushListState( state_machine, new_state )
      end
   end
         
         
g_ascension_cards["Raj, Psionic Master"] = { 
	card_name = "Raj, Psionic Master";
	card_set = "SoS";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 6;
	honor = 3;
	effects = {
		{"BanishHeroFromHand", 0},
      {"AcquireHeroWithPlus2HonorIntoHand", 0},
	};

	effect_text = "Banish a Hero from your hand.\n" ..
                  "If you do, acquire a Hero with honor up to two more than that of the banished card and put it into your hand.";

   image_large = { "EH_RajPsionicMaster", {0, 0, 364/512, 1} };
   image_medium = { "EH_RajPsionicMaster", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_RajPsionicMaster", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_RajPsionicMaster", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


   function MayPutAcquiredHeroIntoHandOncePerTurn( world, effect_instance, event, effect_data )

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

      EventQueryAcquireCardLocation.AddAcquireLocationHand( event, effect_instance )
      return true

   end

g_ascension_cards["Eye of Destiny"] = { 
	card_name = "Eye of Destiny";
	card_set = "SoS";
	card_type = "Construct";
	faction = "Enlightened";
	rune_cost = 7;
	honor = 3;
   
   continuous_effects = {
      {
         effect = {"MayPutAcquiredHeroIntoHandOncePerTurn", 0 };
      },
   };
   effect_text = "Once per turn, when you acquire a Hero, you may put it into your hand.";

   image_large = { "EC_EyeDestiny", {0, 0, 364/512, 1} };
   image_medium = { "EC_EyeDestiny", {392/512, 0, 512/512, 168/512} };
   image_small = { "EC_EyeDestiny", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EC_EyeDestiny", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


g_ascension_cards["Elder Skeptic"] = { 
	card_name = "Elder Skeptic";
	card_set = "SoS";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 3;
	honor = 1;
	effects = {
		{ "DrawCards", 2 },
		{ "DiscardFromHand", 0 },
	};
	effect_text = "Draw 2 cards.  Then, discard a card.";

   image_large = { "EH_ElderSkeptic", {0, 0, 364/512, 1} };
   image_medium = { "EH_ElderSkeptic", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_ElderSkeptic", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_ElderSkeptic", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


   function IfCurrentEventIsEnlightened( world, active_player, source_instance, condition_data, effect_instance_data )

      local current_event = World.GetEventCardInPlay( world );
      if( current_event == nil ) then
         return false
      end
      
      local event_card = CardInPlayInstance.GetCardInstance( current_event );
      local event_card_def = CardInstance.GetCard( event_card );
      return AscensionCard.GetCardFaction(event_card_def) == "Enlightened";
      
   end

g_ascension_cards["Elemental Adept"] = { 
	card_name = "Elemental Adept";
	card_set = "SoS";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 4;
	honor = 3;
	effects = {
		{ "DrawCards", 1 },
      { "DrawCards", 1, condition={"IfCurrentEventIsEnlightened",0} },
		{ "BanishFromCenterRow", 1 },
	};
	effect_text = "Draw a card.\n" ..
                  "If the Current event is Enlightened, draw an additional 1 card.\n" ..
                  "You may banish a card in the center row.";

   image_large = { "EH_ElementalAdept", {0, 0, 364/512, 1} };
   image_medium = { "EH_ElementalAdept", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_ElementalAdept", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_ElementalAdept", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}




   function EachPlayerMayDiscardTopOfDeck( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

      ascensionrules.EachPlayerMayDiscardTopOfDeck( active_player, state_machine );
   end

   function MayDiscardTopOfDeck( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

      local new_state = ascensionrules.CreateStateProcessMayDiscardTopOfDeck( active_player );
      StateMachine.PushListState( state_machine, new_state )
   end



g_ascension_cards["Nook Hound"] = { 
	card_name = "Nook Hound";
	card_set = "SoS";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 2;
	honor = 1;
   
	center_row = { "EachPlayerMayDiscardTopOfDeck", 0 },
   
	effects = {
      { "MayDiscardTopOfDeck", 0 },
		{ "DrawCards", 1 },
	};
	--effect_text = "FATE: When this enters the center row, each player may look at the top card of their deck.  They may put it into their discard pile." ..
    --              "  Look at the top card of your deck.  You may put it into your discard pile.  Draw a card.";
	fate_text = "FATE: When this enters the center row, each player may look at the top card of their deck.  They may put it into their discard pile.";
    effect_text = "Look at the top card of your deck.  You may put it into your discard pile.  Draw a card.";

   image_large = { "EH_NookHound", {0, 0, 364/512, 1} };
   image_medium = { "EH_NookHound", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_NookHound", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_NookHound", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Prodigal"] = { 
	card_name = "Prodigal";
	card_set = "SoS";
	card_type = "Hero";
	faction = "Enlightened";
	rune_cost = 1;
	honor = 1;
	effects = { 
		{"DefeatMonsterWithLessPower", 3},
	};
	effect_text = "Defeat a monster with P3 or less.";

   image_large = { "EH_Prodigal", {0, 0, 364/512, 1} };
   image_medium = { "EH_Prodigal", {392/512, 0, 512/512, 168/512} };
   image_small = { "EH_Prodigal", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EH_Prodigal", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}





g_ascension_cards["Treasures of the Study"] = { 
	card_name = "Treasures of the Study";
	card_set = "SoS";
	card_type = "Construct";
	faction = "Enlightened";
	rune_cost = 5;
	honor = 3;
	construct_abilities = {
		{
			description = "Discard 2 Cards -> 3H";
			condition = { "IfHasCardsInHand", 2 },
         { "DiscardFromHand", 0, condition={"IfRulesVersionIsLessThan",4} },
         { "DiscardFromHand", 0, condition={"IfRulesVersionIsLessThan",4} },
         { "DiscardMultipleFromHand", 2, condition={"IfRulesVersionIsAtLeast",4} },
         { "GainHonor", 3 },
		},
	};

	effect_text = "Once per turn, you may discard 2 cards.  If you do, gain 3H.";

   image_large = { "EC_TreauresStudy", {0, 0, 364/512, 1} };
   image_medium = { "EC_TreauresStudy", {392/512, 0, 512/512, 168/512} };
   image_small = { "EC_TreauresStudy", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "EC_TreauresStudy", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}








   function FirstHeroPlayedIsLifebound( world, effect_instance, event, effect_data )

      if( EventQueryCardFaction.IsQueryCardFaction(event) ) then
         
         local query_card_instance = EventQueryCardFaction.GetQueryCard( event );
         local query_card = CardInstance.GetCard( query_card_instance );
         
         if( EventQueryCardFaction.GetQueryFaction(event) == "Lifebound"
            and AscensionCard.GetCardType(query_card) == "Hero" ) then
            
            if( World.IsFirstHeroPlayed(world,query_card_instance) ) then
               EventQueryCardFaction.SetFactionFlag( event, true )
               return true
            end
         end

      end
      
      
      return false
   end

   function BeforePlayerPlaysHero( world, effect_instance, event, condition_data )

      if( World.GetRulesVersion(world) < 4 ) then
         return EventPlayHero.IsPlayHero( event );
      end
      
      return EventBeforePlayHero.IsBeforePlayHero( event );
      
   end

   function PlayedHeroIsLifebound( world, effect_instance, event, effect_data )

      if( EventQueryCardFaction.IsQueryCardFaction(event) ) then
         
         local query_card_instance = EventQueryCardFaction.GetQueryCard( event );
         local effect_target = ActiveEffectInstance.GetEffectInstance( effect_instance );
         if( not Instance.IsSameInstance(query_card_instance,effect_target) ) then
            return false
         end
         
         if( EventQueryCardFaction.GetQueryFaction(event) == "Lifebound" ) then
            
            EventQueryCardFaction.SetFactionFlag( event, true )
            return true
         end

      end
      
      return false
   end

g_ascension_active_effects["played hero is lifebound"] = {
	type = "continuous";
	effectfunc = { "PlayedHeroIsLifebound", 1 };
}

   function TriggerPlayedHeroIsLifeboundUntilEndOfTurn( state_machine, active_instance, source, event, effect_data )
      
      local world = Instance.GetWorld( active_instance );
      local event_player = nil;
      local event_card = nil;
      
      if( World.GetRulesVersion(world) < 4 ) then
         if( not EventPlayHero.IsPlayHero(event) ) then
            return;
         end
         
         event_player = EventPlayHero.GetTurnPlayer( event );
         event_card_instance = EventPlayHero.GetHeroCard( event );
      else
         if( not EventBeforePlayHero.IsBeforePlayHero(event) ) then
            return;
         end
         
         event_player = EventBeforePlayHero.GetTurnPlayer( event );
         event_card_instance = EventBeforePlayHero.GetHeroCard( event );
      end
      
   
      local event_card = CardInstance.GetCard( event_card_instance );

      if( AscensionCard.GetCardFaction(event_card) ~= "Lifebound" ) then
      
         local new_effect = ActiveEffectInstance.Create( world, "played hero is lifebound", source, event_card_instance )
         ActiveEffectInstance.AddEffectDuration( new_effect, "UntilEndOfTurn", 0 )
         World.AddActiveEffect( world, new_effect )
         
         
      end
      
   end
   
g_ascension_cards["Ogo Rising"] = { 
	card_name = "Ogo Rising";
	card_set = "SoS";
	card_type = "Event";
	faction = "Lifebound";
   
   --[[
	continuous_effects = {
      {
			effect = {"FirstHeroPlayedIsLifebound", 0 };
		},
	};
   ]]
   
	triggered_effects = {
		{
			conditions = {
				{"IfThisHasntBeenUsedThisTurn", 0 },
				{"BeforePlayerPlaysHero", 0 },
			};
			triggereffect = {
				{"TriggerPlayedHeroIsLifeboundUntilEndOfTurn", 1},
				{"TriggerSetThisHasBeenUsedThisTurn", 0},
			};
		},
	};
      
	trophy_effects = {
      { "GainRunes", 1 },
	};

   effect_text = "The first Hero played this turn is also a Lifebound Hero.\n" ..
                  "  EVENT TROPHY: Gain 1R.";

   image_large = { "E_OgoRising", {0, 0, 364/512, 1} };
   image_medium = { "E_OgoRising", {392/512, 0, 512/512, 168/512} };
   image_small = { "E_OgoRising", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "E_OgoRising", {384/512, 395/512, 512/512, 512/512} };
}



g_ascension_cards["Starchild"] = { 
	card_name = "Starchild";
	card_set = "SoS";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 4;
	honor = 2;
	effects = {
		{ "GainRunes", 1 },
		{ "GainHonor", 1 },
		{ "DrawCards", 1 },
	};
	effect_text = "Gain 1R and 1H.  Then, draw a card.";

   image_large = { "LH_Starchild", {0, 0, 364/512, 1} };
   image_medium = { "LH_Starchild", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_Starchild", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_Starchild", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


   function WhenYouPlayLifeboundHero( world, active_effect_instance, event, condition_data )

      if( EventPlayHero.IsPlayHero(event) ) then
         local event_player = EventPlayHero.GetTurnPlayer( event );
         local effect_player = ActiveEffectInstance.GetEffectInstance( active_effect_instance );
	
         if( Player.IsSamePlayer(event_player,effect_player) ) then
		
            local event_card_instance = EventPlayHero.GetHeroCard( event );
            local event_card = CardInstance.GetCard( event_card_instance );

            if( AscensionCard.GetCardType(event_card) == "Hero" ) then

               if( World.QueryCardFaction(world,event_player,event_card_instance,"Lifebound") ) then
                  return true;
               end
            end
				
			end
			
		end
      
      return false;

	end
   
g_ascension_active_effects["unite 1R and 1H"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayLifeboundHero", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerGainRunes", 1 },
		{ "TriggerGainHonor", 1 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

   function Unite1RAnd1H( state_machine, world, active_player, effect_data )
      
      local new_effect = ActiveEffectInstance.Create( world, "unite 1R and 1H", active_player, active_player )
      ActiveEffectInstance.AddEffectDuration( new_effect, "WhenYouPlayLifeboundHero", 0 )
      ActiveEffectInstance.AddEffectDuration( new_effect, "UntilEndOfTurn", 0 )
      World.AddActiveEffect( world, new_effect )
      
   end
   
   function IfHaventPlayedLifeboundHero( world, active_player, source_instance, condition_data, effect_instance_data )

      return World.GetPlayedHeroCount(world,"Lifebound",source_instance) == 0;
	
   end


g_ascension_cards["Granger"] = { 
	card_name = "Granger";
	card_set = "SoS";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 3;
	honor = 2;
	effects = {
		{ "GainRunes", 1 },
		{ "GainHonor", 1 },
		{ "GainRunes", 1, condition={"IfPlayedLifeboundHero",1} },
		{ "GainHonor", 1, condition={"IfPlayedLifeboundHero",1} },
      { "Unite1RAnd1H", 0, condition={"IfHaventPlayedLifeboundHero",1} },
	};
	effect_text = "Gain 1R and 1H.  UNITE: Gain 1R and 1H.";

   image_large = { "LH_Granger", {0, 0, 364/512, 1} };
   image_medium = { "LH_Granger", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_Granger", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_Granger", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_active_effects["unite 3P"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayLifeboundHero", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerGainPower", 3 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

   function Unite3P( state_machine, world, active_player, effect_data )
      
      local new_effect = ActiveEffectInstance.Create( world, "unite 3P", active_player, active_player )
      ActiveEffectInstance.AddEffectDuration( new_effect, "WhenYouPlayLifeboundHero", 0 )
      ActiveEffectInstance.AddEffectDuration( new_effect, "UntilEndOfTurn", 0 )
      World.AddActiveEffect( world, new_effect )
      
   end
   
g_ascension_cards["Syril, Runic Alpha"] = { 
	card_name = "Syril, Runic Alpha";
	card_set = "SoS";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 6;
	honor = 2;
	effects = {
		{ "GainRunes", 3 },
		{ "GainPower", 3, condition={"IfPlayedLifeboundHero",1} },
      { "Unite3P", 0, condition={"IfHaventPlayedLifeboundHero",1} },
	};
	effect_text = "Gain 3R.  UNITE: Gain 3P.";

   image_large = { "LH_SyrilRunicAlpha", {0, 0, 364/512, 1} };
   image_medium = { "LH_SyrilRunicAlpha", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_SyrilRunicAlpha", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_SyrilRunicAlpha", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

   function TriggerEffectPlayerDrawCards( state_machine, active_instance, source, event, effect_data )

      local active_player = ActiveEffectInstance.GetEffectInstance( active_instance );
      
      local new_state = ascensionrules.CreateStateProcessDrawCards( active_player, effect_data );
      StateMachine.PushListState( state_machine, new_state )
      
   end
   
g_ascension_active_effects["unite draw 1 card"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouPlayLifeboundHero", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerEffectPlayerDrawCards", 1 },
      { "TriggerRemovePlayedCardEffectActive", 0 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

   function UniteDraw1Card( state_machine, world, active_player, effect_data )
      
      local new_effect = ActiveEffectInstance.Create( world, "unite draw 1 card", active_player, active_player )
      ActiveEffectInstance.AddEffectDuration( new_effect, "WhenYouPlayLifeboundHero", 0 )
      ActiveEffectInstance.AddEffectDuration( new_effect, "UntilEndOfTurn", 0 )
      World.AddActiveEffect( world, new_effect )
      
   end


g_ascension_cards["Lionheart"] = { 
	card_name = "Lionheart";
	card_set = "SoS";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 5;
	honor = 3;
	effects = {
		{ "GainHonor", 3 },
		{ "DrawCards", 1, condition={"IfPlayedLifeboundHero",1} },
      { "UniteDraw1Card", 0, condition={"IfHaventPlayedLifeboundHero",1} },
	};
	effect_text = "Gain 3H.  UNITE: Draw a card.";

   image_large = { "LH_Lionheart", {0, 0, 364/512, 1} };
   image_medium = { "LH_Lionheart", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_Lionheart", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_Lionheart", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Everbloom"] = { 
	card_name = "Everbloom";
	card_set = "SoS";
	card_type = "Construct";
	faction = "Lifebound";
	rune_cost = 3;
	honor = 2;
	construct_ability = {
		description = "Gain 1H";
		{ "GainHonor", 1 },
      
      ai = {
         trivial = true,
      },
   };
	effect_text = "Once per turn, gain 1 Honor.";

   image_large = { "LC_Everbloom", {0, 0, 364/512, 1} };
   image_medium = { "LC_Everbloom", {392/512, 0, 512/512, 168/512} };
   image_small = { "LC_Everbloom", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LC_Everbloom", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}

   function IfCurrentEventIsLifebound( world, active_player, source_instance, condition_data, effect_instance_data )

      local current_event = World.GetEventCardInPlay( world );
      if( current_event == nil ) then
         return false
      end
      
      local event_card = CardInPlayInstance.GetCardInstance( current_event );
      local event_card_def = CardInstance.GetCard( event_card );
      return AscensionCard.GetCardFaction(event_card_def) == "Lifebound";
      
   end


g_ascension_cards["Snake Shaman"] = { 
	card_name = "Snake Shaman";
	card_set = "SoS";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 2;
	honor = 1;
	effects = {
		{ "GainRunes", 1 },
		{ "GainRunes", 1, condition={"IfCurrentEventIsLifebound",0} },
      --{ "AddConvertRunesToHonorCount", 4 },
      { "AddConvertRunesToHonorCard", 4 },
	};
   
	effect_text = "Gain 1R.  If the Current Event is Lifebound, gain an additional 1R.\n" ..
                  "Once this turn, you may spend up to 4R to gain that much honor.";

   image_large = { "LH_SnakeShaman", {0, 0, 364/512, 1} };
   image_medium = { "LH_SnakeShaman", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_SnakeShaman", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_SnakeShaman", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}



   function EachPlayerMayPutHeroFromDiscardOnTopOfDeck( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

      ascensionrules.EachPlayerMayPutHeroFromDiscardOnTopOfDeck( active_player, state_machine );
   end
   
   function MayAcquireHeroToTopOfDeck( world, effect_instance, event, effect_data )

      if( not EventQueryAcquireCardLocation.IsQueryAcquireCardLocation(event) ) then
         return false
      end

      local query_player = EventQueryAcquireCardLocation.GetQueryPlayer( event );
      local source_player = ActiveEffectInstance.GetEffectInstance( effect_instance );

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

g_ascension_active_effects["acquire hero to top of deck"] = {
	type = "continuous";
   priority = -8;
	effectfunc = { "MayAcquireHeroToTopOfDeck", 1 };
}

   function NextHeroYouAcquireMayGoOnTopOfDeck( state_machine, world, active_player, effect_data )
      
      local new_effect = ActiveEffectInstance.Create( world, "acquire hero to top of deck", active_player, active_player )
      ActiveEffectInstance.AddEffectDuration( new_effect, "UntilHeroIsAcquired", 0 )
      ActiveEffectInstance.AddEffectDuration( new_effect, "UntilEndOfTurn", 0 )
      World.AddActiveEffect( world, new_effect )
      
   end

g_ascension_cards["Honey Siren"] = { 
	card_name = "Honey Siren";
	card_set = "SoS";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 4;
	honor = 2;
   
	center_row = { "EachPlayerMayPutHeroFromDiscardOnTopOfDeck", 0 },
   
	effects = {
		{ "GainRunes", 2 },
      { "NextHeroYouAcquireMayGoOnTopOfDeck", 0 },
	};
	--effect_text = "FATE: When Honey Siren enters the center row, each player may put a Hero from their discard pile on top of their deck.\n" ..
    --              "Gain 2R.  The next time you acquire a Hero this turn, you may put it on top of your deck.";
	fate_text = "FATE: When Honey Siren enters the center row, each player may put a Hero from their discard pile on top of their deck.";
	effect_text = "Gain 2R.  The next time you acquire a Hero this turn, you may put it on top of your deck.";

   image_large = { "LH_HoneySiren", {0, 0, 364/512, 1} };
   image_medium = { "LH_HoneySiren", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_HoneySiren", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_HoneySiren", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


   function PayHonorCostToAcquireHeroesUntilEndOfTurn( state_machine, world, active_player, effect_data )
      World.SetPayHonorCostToAcquireHeroes( world );
   end

g_ascension_cards["Avatar of Aiyana"] = { 
	card_name = "Avatar of Aiyana";
	card_set = "SoS";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 7;
	honor = 4;
	effects = {
		{ "GainRunes", 2 },
      { "PayHonorCostToAcquireHeroesUntilEndOfTurn", 0 },
	};
	effect_text = "Gain 2R.\n" ..
                  "This turn, you may acquire Heroes in the center row by paying runes equal to their Honor instead of paying their rune cost.";

   image_large = { "LH_AvatarAiyana", {0, 0, 364/512, 1} };
   image_medium = { "LH_AvatarAiyana", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_AvatarAiyana", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_AvatarAiyana", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}



   function ReduceHeroRuneCost( world, effect_instance, event, effect_data )
      
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
      if( AscensionCard.GetCardType(query_card_def) == "Hero" ) then
         EventQueryCardAttribute.AddAttributeAdjustValue( event, -effect_data )
         return true
      end
      
      return false
   end

g_ascension_active_effects["hero acquired costs 1 less"] = {
	type = "continuous";
	effectfunc = { "ReduceHeroRuneCost", 1 };
}


   function UntilHeroIsAcquired( world, effect_instance, event, condition_data )

      if( EventAcquireCard.IsAcquireCard(event) ) then
      
         local event_player = EventAcquireCard.GetTurnPlayer( event );
         
         local effect_instance = ActiveEffectInstance.GetSourceInstance( effect_instance );
      
         if( Player.IsSamePlayer(event_player,effect_instance) ) then
         
            local event_card_instance = EventAcquireCard.GetAcquiredCard( event );
            local event_card = CardInstance.GetCard( event_card_instance );

            if( AscensionCard.GetCardType(event_card) == "Hero" ) then
               return true;
            end
            
         end

      end
      
      return false;
      
   end


   function NextHeroYouAcquireCostsLess( state_machine, world, active_player, effect_data )
      
      local new_effect = ActiveEffectInstance.Create( world, "hero acquired costs 1 less", active_player, active_player )
      ActiveEffectInstance.AddEffectDuration( new_effect, "UntilHeroIsAcquired", 0 )
      ActiveEffectInstance.AddEffectDuration( new_effect, "UntilEndOfTurn", 0 )
      World.AddActiveEffect( world, new_effect )
      
   end


g_ascension_cards["Aiyana's Messenger"] = { 
	card_name = "Aiyana's Messenger";
	card_set = "SoS";
	card_type = "Hero";
	faction = "Lifebound";
	rune_cost = 1;
	honor = 1;
	effects = {
		{ "GainRunes", 1 },
      { "NextHeroYouAcquireCostsLess", 1 },
	};
	effect_text = "Gain 1R.  You may pay 1 less Rune the next time you aquire a Hero this turn.";

   image_large = { "LH_AiyanasMessenger", {0, 0, 364/512, 1} };
   image_medium = { "LH_AiyanasMessenger", {392/512, 0, 512/512, 168/512} };
   image_small = { "LH_AiyanasMessenger", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "LH_AiyanasMessenger", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}






   function AllConstructsAreAlsoMechanaConstructs( world, effect_instance, event, effect_data )

      if( EventQueryCardFaction.IsQueryCardFaction(event) ) then
         
         local query_card_instance = EventQueryCardFaction.GetQueryCard( event );
         local query_card = CardInstance.GetCard( query_card_instance );
         
         if( EventQueryCardFaction.GetQueryFaction(event) == "Mechana"
            and AscensionCard.GetCardType(query_card) == "Construct" ) then
            
            EventQueryCardFaction.SetFactionFlag( event, true )
            return true
         end

      end
      
      return false
   end


   function IfPreventConstructDestoryPlayerHasFanaticTrophy( world, effect_instance, event, condition_data )
   
      if( not EventPreventDestroyConstruct.IsPreventDestroyConstruct(event) ) then
         return false;
      end
      
      if( EventPreventDestroyConstruct.GetConstructCount(event) == 0 ) then
         return false;
      end
      
      local discard_player = EventPreventDestroyConstruct.GetDestroyPlayer( event );
      return Player.HasTrophyInPlay( discard_player, "Fanatic SoS" );
      
   end
   
   
   function TriggerMayDiscardFanaticTrophyToSaveDestroyedConstruct( state_machine, active_instance, source, event, effect_data )
   
      if( not EventPreventDestroyConstruct.IsPreventDestroyConstruct(event) ) then
         return;
      end
      
      local destroy_player = EventPreventDestroyConstruct.GetDestroyPlayer( event );

      local new_state = ascensionrules.CreateStateMayDiscardFanaticTrophyToSaveDestroyedConstruct( destroy_player, event );
      StateMachine.PushListState( state_machine, new_state )      

   end


g_ascension_cards["Hedron Rising"] = { 
	card_name = "Hedron Rising";
	card_set = "SoS";
	card_type = "Event";
	faction = "Mechana";
   
	continuous_effects = {
		{
			effect = { "AllConstructsAreAlsoMechanaConstructs", 0 };
		},
	};
	triggered_effects = {
		{
			conditions = {
				{ "IfPreventConstructDestoryPlayerHasFanaticTrophy", 0 },
			};
			triggereffect = {
				{ "TriggerMayDiscardFanaticTrophyToSaveDestroyedConstruct", 0 },
			};
		},
	};
   
   effect_text = "All Constructs are also Mechana Constructs.\n" ..
                  "EVENT TROPHY: When a Construct you control would be destroyed, you may prevent it from being destroyed.";

   image_large = { "E_HedronRising", {0, 0, 364/512, 1} };
   image_medium = { "E_HedronRising", {392/512, 0, 512/512, 168/512} };
   image_small = { "E_HedronRising", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "E_HedronRising", {384/512, 395/512, 512/512, 512/512} };
}


g_ascension_cards["Weapon 303-V"] = { 
	card_name = "Weapon 303-V";
	card_set = "SoS";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 8;
	honor = 8;
	triggered_effects = {
		{
			conditions = {
				{"IfThisHasntBeenUsedThisTurn", 0 },
				{"WhenYouPutMechanaConstructIntoPlay", 0 },
			};
			triggereffect = {
				{"TriggerConstructGainPower", 3},
				{"TriggerSetThisHasBeenUsedThisTurn", 0},
			};
		},
	};
	effect_text = "Once per turn, when you play a Mechana Construct (including this one), you gain 3P.";

   image_large = { "MC_Weapon303V", {0, 0, 364/512, 1} };
   image_medium = { "MC_Weapon303V", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_Weapon303V", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_Weapon303V", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


   function DestroyConstruct( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

      local new_state = ascensionrules.CreateStateProcessDestroyConstructInPlay( active_player, effect_data, nil, effect_instance_data );
      StateMachine.PushListState( state_machine, new_state )
   end
   
g_ascension_cards["Scrap Flinger"] = { 
	card_name = "Scrap Flinger";
	card_set = "SoS";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 4;
	honor = 2;
	effects = {
		{ "GainPower", 2 },
      { "DestroyConstruct", 1 },
		{ "GainPower", 2, condition={"IfYouDo",1} },
	};
	effect_text = "Gain 2P.  You may destroy a Construct you control.  If you do, gain an additional 2P.";

   image_large = { "MH_ScrapFlinger", {0, 0, 364/512, 1} };
   image_medium = { "MH_ScrapFlinger", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_ScrapFlinger", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_ScrapFlinger", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}



   function EachPlayerMayReturnConstructToHand( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

      ascensionrules.EachPlayerReturnConstructToHand( active_player, state_machine );
   end

--[[
   function IfHasOtherMechanaConstructInPlay( world, effect_instance, event, condition_data )

      local active_player = World.GetCurrentTurnPlayer( world );

      return Player.CountConstructsInPlay( active_player, "Mechana" ) >= 2;
   end
]]

   function ReturnMechanaConstructToHand( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

      local source_construct = ConstructAbilityInstance.GetConstructInstance( source_instance );
      
      local new_state = ascensionrules.CreateStateProcessReturnConstructToHand( active_player, effect_data, "Mechana", source_construct );
      StateMachine.PushListState( state_machine, new_state )
   end

g_ascension_cards["Dream Machine"] = { 
	card_name = "Dream Machine";
	card_set = "SoS";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 7;
	honor = 7;

	center_row = { "EachPlayerMayReturnConstructToHand", 0 },
   
	construct_abilities = {
		{
			condition = { "IfHasOtherMechanaConstructInPlay", 0 },
         { "ReturnMechanaConstructToHand", 0 },
		},
	};
   
	--effect_text = "FATE: When Dream Machine enters the center row, each player may return a Construct they control to their hand.\n" ..
    --              "Once per turn, you may return another Mechana Construct you control to your hand.";
	fate_text = "FATE: When Dream Machine enters the center row, each player may return a Construct they control to their hand.";
	effect_text = "Once per turn, you may return another Mechana Construct you control to your hand.";

   image_large = { "MC_DreamMachine", {0, 0, 364/512, 1} };
   image_medium = { "MC_DreamMachine", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_DreamMachine", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_DreamMachine", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}



   function AddConstructFromDiscardIntoHand( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )
      local new_state = ascensionrules.CreateStateAddConstructFromDiscardIntoHand( active_player );
      StateMachine.PushListState( state_machine, new_state )
   end

g_ascension_cards["Brazer Drone"] = { 
	card_name = "Brazer Drone";
	card_set = "SoS";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 2;
	honor = 1;
	effects = {
		{ "GainRunes", 1 },
      { "AddConstructFromDiscardIntoHand", 0 },
	};
	effect_text = "Gain 1R.  You may return a Construct from your discard pile to your hand.";

   image_large = { "MH_BrazerDrone", {0, 0, 364/512, 1} };
   image_medium = { "MH_BrazerDrone", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_BrazerDrone", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_BrazerDrone", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


   function ReduceMechanaConstructRuneCost( world, effect_instance, event, effect_data )
      
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
         if( World.QueryCardFaction(world,query_player,query_card_instance,"Mechana") ) then
            EventQueryCardAttribute.AddAttributeAdjustValue( event, -effect_data )
            return true
         end
      end
      
      return false
   end

g_ascension_active_effects["mechana construct acquired costs 2 less"] = {
	type = "continuous";
	effectfunc = { "ReduceMechanaConstructRuneCost", 2 };
}

   function UntilMechanaConstructIsAcquired( world, effect_instance, event, condition_data )

      if( EventAcquireCard.IsAcquireCard(event) ) then
      
         local event_player = EventAcquireCard.GetTurnPlayer( event );
         
         local effect_instance = ActiveEffectInstance.GetSourceInstance( effect_instance );
      
         if( Player.IsSamePlayer(event_player,effect_instance) ) then
         
            local event_card_instance = EventAcquireCard.GetAcquiredCard( event );
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
   
   function NextMechanaConstructYouAcquireCosts2Less( state_machine, world, active_player, effect_data )
      
      local new_effect = ActiveEffectInstance.Create( world, "mechana construct acquired costs 2 less", active_player, active_player )
      ActiveEffectInstance.AddEffectDuration( new_effect, "UntilMechanaConstructIsAcquired", 0 )
      ActiveEffectInstance.AddEffectDuration( new_effect, "UntilEndOfTurn", 0 )
      World.AddActiveEffect( world, new_effect )
      
   end

g_ascension_cards["Autobuilder 5.0"] = { 
	card_name = "Autobuilder 5.0";
	card_set = "SoS";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 5;
	honor = 5;
   
	construct_abilities = {
		{
         { "DiscardThisConstruct", 0 },
         { "NextMechanaConstructYouAcquireCosts2Less", 0 },
		},
	};

	effect_text = "You may destroy this to pay 2R less the next time you acquire a Mechana Construct this turn.";

   image_large = { "MC_Autobuilder50", {0, 0, 364/512, 1} };
   image_medium = { "MC_Autobuilder50", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_Autobuilder50", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_Autobuilder50", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}



   function WhenPlayerPutsMechanaConstructIntoPlay( world, effect_instance, event, condition_data )

      if( EventPutConstructIntoPlay.IsPutConstructIntoPlay(event) ) then
      
         local event_player = EventPutConstructIntoPlay.GetTurnPlayer( event );
         local event_card_instance = EventPutConstructIntoPlay.GetConstructCard( event );
         local event_card = CardInstance.GetCard( event_card_instance );

         if( AscensionCard.GetCardType(event_card) == "Construct" ) then

            if( World.QueryCardFaction(world,event_player,event_card_instance,"Mechana") ) then
               return true;
            end

         end

      end

      return false;

   end
   
   
   function IfThisCardIsInEventPlayerDiscardPile( world, effect_instance, event, condition_data )
   
      if( EventPutConstructIntoPlay.IsPutConstructIntoPlay(event) ) then
      
         local source_instance = ActiveEffectInstance.GetSourceInstance( effect_instance );
         local event_player = EventPutConstructIntoPlay.GetTurnPlayer( event );
         
         return Player.IsCardInDiscard( event_player, source_instance );
      end

      return false;
      
   end
   
   --[[
   function TriggerConstructEventPlayerMayAddConstructFromDiscardIntoHand( state_machine, active_instance, source, event, effect_data  )

      local world = Instance.GetWorld( source );

      if( EventPutConstructIntoPlay.IsPutConstructIntoPlay(event) ) then
		
         local event_player = EventPutConstructIntoPlay.GetTurnPlayer( event );
		         
         local new_state = ascensionrules.CreateStateAddConstructFromDiscardIntoHand( event_player );
         StateMachine.PushListState( state_machine, new_state )
      end
   end
   ]]
   
   function GainRunesOrAcquireConstruct( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

      local new_state = ascensionrules.CreateStateProcessGainRunesOrAcquireConstruct( active_player, effect_data, source_instance );
      StateMachine.PushListState( state_machine, new_state )
   end


g_ascension_cards["P.R.I.M.E."] = { 
	card_name = "P.R.I.M.E.";
	card_set = "SoS";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 7;
	honor = 3;
   
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
		{ "GainRunesOrAcquireConstruct", 3 },
	};
   
	effect_text = "Gain 3R or acquire a Construct in the center row.\n" ..
                  "When you play a Mechana Construct, you may return P.R.I.M.E. from your discard pile to your hand.";

   image_large = { "MH_Prime", {0, 0, 364/512, 1} };
   image_medium = { "MH_Prime", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_Prime", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_Prime", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}

--[[
   function TriggerBanishFromHandOrDiscard( state_machine, active_instance, source, event, effect_data )

      local active_player = ConstructInstance.GetOwner( source );
      local new_state = ascensionrules.CreateStateProcessBanishFromHandOrDiscard( active_player, effect_data, nil, nil );
      StateMachine.PushListState( state_machine, new_state )
   end
]]

g_ascension_cards["Personal Wormhole"] = { 
	card_name = "Personal Wormhole";
	card_set = "SoS";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 4;
	honor = 4;
	triggered_effects = {
      {
			conditions = {
				{ "IfThisHasntBeenUsedThisTurn", 0 },
				{ "WhenYouPutMechanaConstructIntoPlay", 0 },
			};
			triggereffect = {
            { "TriggerConstructOwnerBanishFromHandOrDiscard", 1 },
            { "TriggerSetThisHasBeenUsedThisTurn", 0 },
			};
		},
	};
	effect_text = "Once per turn, when you play a Mechana Construct (including this one), you may banish a card in your hand or discard pile.";

   image_large = { "MC_PersonalWormhole", {0, 0, 364/512, 1} };
   image_medium = { "MC_PersonalWormhole", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_PersonalWormhole", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_PersonalWormhole", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


   function IfYouDoAndCurrentEventIsMechana( world, active_player, source_instance, condition_data, effect_instance_data )

      if( AscensionEffectInstanceData.GetEffectData(effect_instance_data,condition_data) == 0 ) then
         return false
      end

      local current_event = World.GetEventCardInPlay( world );
      if( current_event == nil ) then
         return false
      end
      
      local event_card = CardInPlayInstance.GetCardInstance( current_event );
      local event_card_def = CardInstance.GetCard( event_card );
      return AscensionCard.GetCardFaction(event_card_def) == "Mechana";
      
   end



   function DestroyMechanaConstruct( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

      local new_state = ascensionrules.CreateStateProcessDestroyConstructInPlay( active_player, effect_data, "Mechana", effect_instance_data );
      StateMachine.PushListState( state_machine, new_state )
   end

g_ascension_cards["Cog Maw"] = { 
	card_name = "Cog Maw";
	card_set = "SoS";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 6;
	honor = 6;
   
   construct_ability = {
		description = "Destroy Construct -> Gain 1R";
      { "DestroyMechanaConstruct", 0 },
		{ "GainRunes", 1, condition={"IfYouDo",0} },
		{ "GainRunes", 1, condition={"IfYouDoAndCurrentEventIsMechana",0} },
	};
   
	effect_text = "Once per turn, you may destroy a Mechana Construct you control to gain 1R.\n" ..
                  "If the Current event is Mechana, gain an additional 1R.";

   image_large = { "MC_CogMaw", {0, 0, 364/512, 1} };
   image_medium = { "MC_CogMaw", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_CogMaw", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_CogMaw", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Synchronizer"] = { 
	card_name = "Synchronizer";
	card_set = "SoS";
	card_type = "Construct";
	faction = "Mechana";
	rune_cost = 3;
	honor = 3;
	triggered_effects = {
		{
			conditions = {
				{"IfThisHasntBeenUsedThisTurn", 0 },
				{"WhenYouPutMechanaConstructIntoPlay", 0 },
			};
			triggereffect = {
				{"TriggerConstructGainRunes", 1},
				{"TriggerSetThisHasBeenUsedThisTurn", 0},
			};
		},
	};
	effect_text = "Once per turn, when you play a Mechana Construct (including this one), gain 1R.";

   image_large = { "MC_Synchronizer", {0, 0, 364/512, 1} };
   image_medium = { "MC_Synchronizer", {392/512, 0, 512/512, 168/512} };
   image_small = { "MC_Synchronizer", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MC_Synchronizer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


g_ascension_cards["Grease Monk"] = { 
	card_name = "Grease Monk";
	card_set = "SoS";
	card_type = "Hero";
	faction = "Mechana";
	rune_cost = 1;
	honor = 1;
	effects = {
		{ "GainRunes", 1 },
      { "NextContructYouAcquireCostsLess", 1 },
	};
	effect_text = "Gain 1R.  You may pay 1 Rune less the next time you acquire a Construct this turn.";

   image_large = { "MH_GreaseMonk", {0, 0, 364/512, 1} };
   image_medium = { "MH_GreaseMonk", {392/512, 0, 512/512, 168/512} };
   image_small = { "MH_GreaseMonk", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "MH_GreaseMonk", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}







   function WhenPlayerDefeatsMonsterInCenterRow( world, effect_instance, event, condition_data )

      if( EventDefeatMonster.IsDefeatMonster(event) ) then
         if( EventDefeatMonster.IsDefeatFromCenterRow(event) or EventDefeatMonster.IsDefeatFromVoid(event) ) then
            return true;
         end
      end
      
      return false;
      
   end
   
   function TriggerDefeatPlayerGainHonor( state_machine, active_instance, source, event, effect_data )

      if( not EventDefeatMonster.IsDefeatMonster(event) ) then
         return false
      end
      
      local defeat_player = EventDefeatMonster.GetTurnPlayer( event );
      
      local world = Instance.GetWorld( defeat_player );
      
      local output_message = string.format( "%s gains %d honor tokens from %s\n",
         Instance.GetName(defeat_player), effect_data, Instance.GetName(source) )
      World.OutputMessage( world, output_message )
      
      World.OutputAnimationHonor( world, effect_data, defeat_player, source );

      Player.AddHonorTokens( defeat_player, effect_data )
      
      World.TakeHonorTokenPool( world, effect_data )
      
   end
   

g_ascension_cards["Void Rising"] = { 
	card_name = "Void Rising";
	card_set = "SoS";
	card_type = "Event";
	faction = "Void";
	triggered_effects = {
		{
			conditions = {
				{"IfThisHasntBeenUsedThisTurn", 0 },
				{"WhenPlayerDefeatsMonsterInCenterRow", 0 },
			};
			triggereffect = {
				{"TriggerDefeatPlayerGainHonor", 1},
				{"TriggerSetThisHasBeenUsedThisTurn", 0},
			};
		},
	};
   
	trophy_effects = {
      { "BanishFromHandOrDiscard", 0 },
	};

   effect_text = "Once per turn, when a player defeats a Monster in the Center Row, that player gains 1H.\n" ..
                  "EVENT TROPHY: Banish a card in your hand or discard pile.";

   image_large = { "E_VoidRising", {0, 0, 364/512, 1} };
   image_medium = { "E_VoidRising", {392/512, 0, 512/512, 168/512} };
   image_small = { "E_VoidRising", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "E_VoidRising", {384/512, 395/512, 512/512, 512/512} };
}



   function ReduceDefeatMonsterInCenterRowCost( world, effect_instance, event, effect_data )
      
      if( not EventQueryCardAttribute.IsAttributePowerCost(event) ) then
         return false
      end
      
      local query_player = EventQueryCardAttribute.GetQueryPlayer( event )
      local effect_target = ActiveEffectInstance.GetEffectInstance( effect_instance );
      if( not Player.IsSamePlayer(query_player,effect_target) ) then
         return false
      end
      
      if( EventQueryCardAttribute.IsQueryCardLocationCenterRow(event)
         or EventQueryCardAttribute.IsQueryCardLocationVoid(event) ) then
      
         local query_card_instance = EventQueryCardAttribute.GetQueryCard( event );
         local query_card_def = CardInstance.GetCard( query_card_instance );
         if( AscensionCard.GetCardType(query_card_def) == "Monster" ) then
            EventQueryCardAttribute.AddAttributeAdjustValue( event, -effect_data )
            return true
         end
         
      end
      
      return false
   end
   
g_ascension_active_effects["defeat monster costs 1 less"] = {
	type = "continuous";
	effectfunc = { "ReduceDefeatMonsterInCenterRowCost", 1 };
}

   function NextMonsterInCenterRowYouDefeatCostsLess( state_machine, world, active_player, effect_data )
      
      local new_effect = ActiveEffectInstance.Create( world, "defeat monster costs 1 less", active_player, active_player )
      ActiveEffectInstance.AddEffectDuration( new_effect, "UntilMonsterIsDefeatedFromCenterRow", 0 )
      ActiveEffectInstance.AddEffectDuration( new_effect, "UntilEndOfTurn", 0 )
      World.AddActiveEffect( world, new_effect )
      
   end
   
g_ascension_cards["Void Militia"] = { 
	card_name = "Void Militia";
	card_set = "SoS";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 1;
	honor = 1;
   effects = { 
		{ "GainPower", 1 },
		{ "NextMonsterInCenterRowYouDefeatCostsLess", 1 },
	};
	effect_text = "Gain 1P.  You may pay 1 Power less the next time you defeat a Monster in the center row this turn.";

   image_large = { "VH_VoidMilitia", {0, 0, 364/512, 1} };
   image_medium = { "VH_VoidMilitia", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_VoidMilitia", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_VoidMilitia", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Abolisher"] = { 
	card_name = "Abolisher";
	card_set = "SoS";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 2;
	honor = 1;
   effects = { 
		{ "GainRunes", 1 },
		{ "BanishFromHand", 1 },
		{ "GainRunes", 1, condition={"IfYouDo",1} },
	};
	effect_text = "Gain 1R.  You may banish a card in you hand; if you do, gain an additional 1R.";

   image_large = { "VH_Abolisher", {0, 0, 364/512, 1} };
   image_medium = { "VH_Abolisher", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_Abolisher", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_Abolisher", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


g_ascension_cards["Nihilmancer"] = { 
	card_name = "Nihilmancer";
	card_set = "SoS";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 3;
	honor = 1;
   effects = { 
		{ "GainPower", 2 },
		{ "BanishFromHand", 1 },
		{ "GainPower", 1, condition={"IfYouDo",1} },
	};
	effect_text = "Gain 2P.  You may banish a card in you hand; if you do, gain an additional 1P.";

   image_large = { "VH_Nihilmancer", {0, 0, 364/512, 1} };
   image_medium = { "VH_Nihilmancer", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_Nihilmancer", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_Nihilmancer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 3
}


   function WhenConstructOwnerDefeatsMonster( world, effect_instance, event, condition_data )

      if( EventDefeatMonster.IsDefeatMonster(event) ) then
         if( EventDefeatMonster.IsDefeatFromCenterRow(event) or EventDefeatMonster.IsDefeatFromVoid(event) ) then
            local event_player = EventDefeatMonster.GetTurnPlayer( event );
            local source_instance = ActiveEffectInstance.GetSourceInstance( effect_instance );
            local source_player = ConstructInstance.GetOwner( source_instance );
         
            if( Player.IsSamePlayer(event_player,source_player) ) then
               return true;
            end
         end
      end
      
      return false;
      
   end

g_ascension_cards["Canopic Jar"] = { 
	card_name = "Canopic Jar";
	card_set = "SoS";
	card_type = "Construct";
	faction = "Void";
	rune_cost = 4;
	honor = 2;
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
				{"IfThisHasntBeenUsedThisTurn", 0 },
				{"WhenConstructOwnerDefeatsMonster", 0 },
			};
			triggereffect = {
				{"TriggerConstructGainRunes", 1},
				{"TriggerSetThisHasBeenUsedThisTurn", 0},
			};
		},
	};
	effect_text = "Once per turn, gain 1P.\nOnce per turn, when you defeat a Monster in the center row, gain 1R.";

   image_large = { "VC_CanopicJar", {0, 0, 364/512, 1} };
   image_medium = { "VC_CanopicJar", {392/512, 0, 512/512, 168/512} };
   image_small = { "VC_CanopicJar", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VC_CanopicJar", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


   function WhenYouDefeatMonsterFromCenterRow( world, effect_instance, event, condition_data )

      if( EventDefeatMonster.IsDefeatMonster(event) ) then
         if( EventDefeatMonster.IsDefeatFromCenterRow(event) or EventDefeatMonster.IsDefeatFromVoid(event) ) then
            local event_player = EventDefeatMonster.GetTurnPlayer( event );
            local source_instance = ActiveEffectInstance.GetSourceInstance( effect_instance );
         
            return Player.IsSamePlayer(event_player,source_instance)
         end
      end
      
      return false;
      
   end

g_ascension_active_effects["monster defeated gains 2 runes"] = {
	type = "triggered";
	conditions = {
		{ "WhenYouDefeatMonsterFromCenterRow", 0 },
	};
	triggereffect = {
      { "TriggerPushResolveEffectFromPlayedCard", 0 },
		{ "TriggerGainRunes", 2 },
      { "TriggerPopResolveEffectFromPlayedCard", 0 },
	};
}

   function NextMonsterYouDefeatFromCenterRowGains2Runes( state_machine, world, active_player, effect_data )
      
      local new_effect = ActiveEffectInstance.Create( world, "monster defeated gains 2 runes", active_player, active_player )
      ActiveEffectInstance.AddEffectDuration( new_effect, "UntilMonsterIsDefeatedFromCenterRow", 0 )
      ActiveEffectInstance.AddEffectDuration( new_effect, "UntilEndOfTurn", 0 )
      World.AddActiveEffect( world, new_effect )
      
   end

g_ascension_cards["Soul Assassin"] = { 
	card_name = "Soul Assassin";
	card_set = "SoS";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 4;
	honor = 2;
	effects = {
		{ "GainPower", 2 },
		{ "NextMonsterYouDefeatFromCenterRowGains2Runes", 1 },
	};
	effect_text = "Gain 2P. The next time you defeat a Monster in the center row, gain 2R.";

   image_large = { "VH_SoulAssassin", {0, 0, 364/512, 1} };
   image_medium = { "VH_SoulAssassin", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_SoulAssassin", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_SoulAssassin", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}


   function IfCurrentEventIsVoid( world, active_player, source_instance, condition_data, effect_instance_data )

      local current_event = World.GetEventCardInPlay( world );
      if( current_event == nil ) then
         return false
      end
      
      local event_card = CardInPlayInstance.GetCardInstance( current_event );
      local event_card_def = CardInstance.GetCard( event_card );
      return AscensionCard.GetCardFaction(event_card_def) == "Void";
      
   end
   
   
g_ascension_cards["Shadowcaster"] = { 
	card_name = "Shadowcaster";
	card_set = "SoS";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 5;
	honor = 3;
   effects = { 
		{ "DrawCards", 1 },
      { "BanishFromHand", 1 },
		{ "DrawCards", 1, condition={"IfYouDo",1} },
		{ "BanishFromDiscard", 1, condition={"IfCurrentEventIsVoid",0} },
	};
	effect_text = "Draw a card.\nYou may banish a card from your hand; if you do, you may draw an additional 1 card.\n" ..
                  "If the current event is Void, you may banish a card in your discard pile.";

   image_large = { "VH_Shadowcaster", {0, 0, 364/512, 1} };
   image_medium = { "VH_Shadowcaster", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_Shadowcaster", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_Shadowcaster", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 2
}



   function IfYouControlUmbralEdge( world, active_player, source_instance, condition_data, effect_instance_data )

      return Player.HasConstructInPlay( active_player, "Umbral Edge" );
      
   end

g_ascension_cards["Penumbral Edge"] = { 
	card_name = "Penumbral Edge";
	card_set = "SoS";
	card_type = "Construct";
	faction = "Void";
	rune_cost = 6;
	honor = 3;
   construct_ability = {
		description = "Gain 2P";
		{ "GainPower", 2 },
		{ "GainPower", 2, condition={"IfYouControlUmbralEdge",0} },
	};
	effect_text = "Once per turn, gain 2P.  Gain an additional 2P if you control Umbral Edge.";

   image_large = { "VC_PenumbralEdge", {0, 0, 364/512, 1} };
   image_medium = { "VC_PenumbralEdge", {392/512, 0, 512/512, 168/512} };
   image_small = { "VC_PenumbralEdge", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VC_PenumbralEdge", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


   function IfYouControlPenumbralEdge( world, active_player, source_instance, condition_data, effect_instance_data )

      return Player.HasConstructInPlay( active_player, "Penumbral Edge" );
      
   end

g_ascension_cards["Umbral Edge"] = { 
	card_name = "Umbral Edge";
	card_set = "SoS";
	card_type = "Construct";
	faction = "Void";
	rune_cost = 6;
	honor = 3;
   construct_ability = {
		description = "Gain 2P";
		{ "GainPower", 2 },
		{ "GainPower", 2, condition={"IfYouControlPenumbralEdge",0} },
	};
	effect_text = "Once per turn, gain 2P.  Gain an additional 2P if you control Penumbral Edge.";

   image_large = { "VC_UmbralEdge", {0, 0, 364/512, 1} };
   image_medium = { "VC_UmbralEdge", {392/512, 0, 512/512, 168/512} };
   image_small = { "VC_UmbralEdge", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VC_UmbralEdge", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}


   function EachPlayerMayBanishMultipleFromHandOrDiscard( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

      ascensionrules.EachPlayerBanishMultipleFromHandOrDiscard( active_player, state_machine, effect_data );
   end

   function BanishMultipleFromHandOrDiscard( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

      local new_state = ascensionrules.CreateStateProcessBanishMultipleFromHandOrDiscard( active_player, effect_data, effect_instance_data );
      StateMachine.PushListState( state_machine, new_state )
   end

   function GainPowerForBanishedCards( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )
   
      local banish_count = AscensionEffectInstanceData.GetEffectData( effect_instance_data, effect_data )
      if( banish_count > 0 ) then
         GainPower( state_machine, world, active_player, banish_count, source_instance, effect_instance_data );
      end
   end

g_ascension_cards["Emri, Soulslayer"] = { 
	card_name = "Emri, Soulslayer";
	card_set = "SoS";
	card_type = "Hero";
	faction = "Void";
	rune_cost = 8;
	honor = 4;

	center_row = { "EachPlayerMayBanishMultipleFromHandOrDiscard", 2 },

   effects = { 
		{ "GainPower", 4 },
      { "BanishMultipleFromHandOrDiscard", 2 },
      { "GainPowerForBanishedCards", 1 },
	};
	--effect_text = "FATE: Each player may banish 2 cards from their hand and/or discard pile.\n" .. 
    --           "Gain 4P.  You may banish up to 2 cards from you hand or discard pile; gain an additional 1P for each card banished this way.";
	fate_text = "FATE: Each player may banish 2 cards from their hand and/or discard pile.";
	effect_text = "Gain 4P.  You may banish up to 2 cards from you hand or discard pile; gain an additional 1P for each card banished this way.";

   image_large = { "VH_EmriSoulslayer", {0, 0, 364/512, 1} };
   image_medium = { "VH_EmriSoulslayer", {392/512, 0, 512/512, 168/512} };
   image_small = { "VH_EmriSoulslayer", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "VH_EmriSoulslayer", {384/512, 395/512, 512/512, 512/512} };

   rarity_count = 1
}






   function IncreaseCostToDefeatCultistOrFanatic( world, effect_instance, event, effect_data )
      
      if( not EventQueryCardAttribute.IsAttributePowerCost(event) ) then
         return false
      end
      
      if( EventQueryCardAttribute.IsQueryCardLocationKingdomStack(event) ) then
      
         local query_card_instance = EventQueryCardAttribute.GetQueryCard( event );
         local query_card_def = CardInstance.GetCard( query_card_instance );
         if( AscensionCard.GetCardType(query_card_def) == "Monster" ) then
            EventQueryCardAttribute.AddAttributeAdjustValue( event, effect_data )
            return true
         end
         
      end
      
      return false
   end
   
   function WhenCultistOrFanaticIsDefeated( world, effect_instance, event, condition_data )

      return EventDefeatMonster.IsDefeatFromKingdomStack( event );
      
   end
   
   function TriggerDefeatPlayerGainHonor( state_machine, active_instance, source, event, effect_data )

      if( EventDefeatMonster.IsDefeatMonster(event) ) then
      
         local active_player = EventDefeatMonster.GetTurnPlayer( event );
         local world = Instance.GetWorld( active_player );
      
         local output_message = string.format( "%s gains %d honor tokens from %s\n",
            Instance.GetName(active_player), effect_data, Instance.GetName(source) )
         World.OutputMessage( world, output_message )
      
         World.OutputAnimationHonor( world, effect_data, active_player, source );

         Player.AddHonorTokens( active_player, effect_data )
      
         World.TakeHonorTokenPool( world, effect_data )
         
      end
   end

g_ascension_cards["Rise of the Cult"] = { 
	card_name = "Rise of the Cult";
	card_set = "SoS";
	card_type = "Event";
	--faction = "Monster";
   
	continuous_effects = {
		{
			effect = {"IncreaseCostToDefeatCultistOrFanatic", 1 };
		},
	};
	triggered_effects = {
		{
			conditions = {
				{ "WhenCultistOrFanaticIsDefeated", 0 },
			};
			triggereffect = {
				{ "TriggerDefeatPlayerGainHonor", 1 },
			};
		},
	};
   
	trophy_effects = {
		{ "GainHonor", 1 },
	};
   
   effect_text = "Cultists and Fanatics have +1P and their rewards have +1P.\n" ..
                  "EVENT TROPHY: Gain 1H.";

   image_large = { "E_RiseCult", {0, 0, 364/512, 1} };
   image_medium = { "E_RiseCult", {392/512, 0, 512/512, 168/512} };
   image_small = { "E_RiseCult", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "E_RiseCult", {384/512, 395/512, 512/512, 512/512} };
}






g_ascension_cards["Unchained Fates"] = { 
	card_name = "Unchained Fates";
	card_set = "SoS";
	card_type = "Monster";
	power_cost = 7;
   trophy_monster = true;
	rewards = {
		{ "GainHonor", 5 },
	};
	trophy_effects = {
		{ "DrawCards", 2 },
      { "BanishThisTrophy", 0 },
	};
	
	--effect_text = "Reward: 5H.  TROPHY: Draw 2 cards.";
	effect_text = "Reward: 5H.";
	trophy_text = "<color=#951719FF><B>Trophy:</B></color> Draw 2 cards.";

   image_large = { "M_UnchainedFates", {0, 0, 364/512, 1} };
   image_medium = { "M_UnchainedFates", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_UnchainedFates", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_UnchainedFates", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "unchained_fates" };

   rarity_count = 1
}


g_ascension_cards["Minotaur"] = { 
	card_name = "Minotaur";
	card_set = "SoS";
	card_type = "Monster";
	power_cost = 4;
   trophy_monster = true;
	rewards = {
		{ "GainHonor", 3 },
	};
	trophy_effects = {
		{ "DrawCards", 1 },
      { "BanishThisTrophy", 0 },
	};
	
	--effect_text = "Reward: 3H.  TROPHY: Draw 1 card.";
	effect_text = "Reward: 3H.";
	trophy_text = "<color=#951719FF><B>Trophy:</B></color> Draw 1 card.";

   image_large = { "M_Minotaur", {0, 0, 364/512, 1} };
   image_medium = { "M_Minotaur", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_Minotaur", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_Minotaur", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "minotaur" };

   rarity_count = 4
}


g_ascension_cards["Hoarding Whelp"] = { 
	card_name = "Hoarding Whelp";
	card_set = "SoS";
	card_type = "Monster";
	power_cost = 3;
   trophy_monster = true;
	rewards = {
		{ "GainHonor", 2 },
	};
	trophy_effects = {
		{ "GainPower", 1 },
      { "BanishThisTrophy", 0 },
	};
	
	--effect_text = "Reward: 2H.  TROPHY: Gain 1P.";
	effect_text = "Reward: 2H.";
	trophy_text = "<color=#951719FF><B>Trophy:</B></color> Gain 1P.";

   image_large = { "M_HoardingWhelp", {0, 0, 364/512, 1} };
   image_medium = { "M_HoardingWhelp", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_HoardingWhelp", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_HoardingWhelp", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "hoarding_whelp" };

   rarity_count = 4
}


g_ascension_cards["Hoarding Tyrant"] = { 
	card_name = "Hoarding Tyrant";
	card_set = "SoS";
	card_type = "Monster";
	power_cost = 6;
   trophy_monster = true;
	rewards = {
		{ "GainHonor", 4 },
	};
	trophy_effects = {
		{ "GainRunes", 2 },
      { "BanishThisTrophy", 0 },
	};
	
	--effect_text = "Reward: 4H.  TROPHY: Gain 2R.";
	effect_text = "Reward: 4H.";
	trophy_text = "<color=#951719FF><B>Trophy:</B></color> Gain 2R.";

   image_large = { "M_HoardingTyrant", {0, 0, 364/512, 1} };
   image_medium = { "M_HoardingTyrant", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_HoardingTyrant", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_HoardingTyrant", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "hoarding_tyrant" };

   rarity_count = 2
}


g_ascension_cards["Fettered Soul"] = { 
	card_name = "Fettered Soul";
	card_set = "SoS";
	card_type = "Monster";
	power_cost = 3;
	rewards = {
		{ "GainHonor", 2 },
		{ "BanishFromCenterRow", 1 },
	};
	effect_text = "Reward: Gain 2H.  You may banish a card in the center row.",

   image_large = { "M_FetteredSoul", {0, 0, 364/512, 1} };
   image_medium = { "M_FetteredSoul", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_FetteredSoul", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_FetteredSoul", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "fettered_soul" };

   rarity_count = 4
}


function EachOpponentDiscardsLowestCostConstruct( state_machine, world, active_player, effect_data )

   ascensionrules.EachOpponentDiscardsLowestCostConstruct( active_player, state_machine );
end

g_ascension_cards["Vandal Soul"] = { 
	card_name = "Vandal Soul";
	card_set = "SoS";
	card_type = "Monster";
	power_cost = 4;
	rewards = {
		{ "GainHonor", 3 },
		{ "EachOpponentDiscardsLowestCostConstruct", 0 },
	};
	effect_text = "Reward: 3H.  Each opponent destroys the lowest cost construct they control.";

   image_large = { "M_VandalSoul", {0, 0, 364/512, 1} };
   image_medium = { "M_VandalSoul", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_VandalSoul", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_VandalSoul", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "vandal_soul" };

   rarity_count = 3
}


   
   function EachOpponentDestroysEvenOrOddCostConstructs( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

      local new_state = ascensionrules.CreateStateEachOpponentDestroysEvenOrOddCostConstructs( active_player );
      StateMachine.PushListState( state_machine, new_state )
   end

g_ascension_cards["Polaris Demon"] = { 
	card_name = "Polaris Demon";
	card_set = "SoS";
	card_type = "Monster";
	power_cost = 5;
	rewards = {
		{ "GainHonor", 5 },
		{ "EachOpponentDestroysEvenOrOddCostConstructs", 0 },
	};
	effect_text = "Reward: 5H.  Choose one:\n" .. 
               "Destroy all even cost Constructs opponents control OR destroy all odd cost Contructs opponents control.";

   image_large = { "M_PolarisDemon", {0, 0, 364/512, 1} };
   image_medium = { "M_PolarisDemon", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_PolarisDemon", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_PolarisDemon", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "polaris_demon" };

   rarity_count = 2
}


   function BanishCurrentEventCard( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

      ascensionrules.BanishCurrentEventCard( world );
   end

   function AcquireTrophiesFromVoid( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

      local new_state = ascensionrules.CreateStateProcessAcquireTrophiesFromVoid( active_player, effect_data );
      StateMachine.PushListState( state_machine, new_state )
   end

g_ascension_cards["Nemesis"] = { 
	card_name = "Nemesis";
	card_set = "SoS";
	card_type = "Monster";
	power_cost = 8;
   
	center_row = { "BanishCurrentEventCard", 0 },
   
	rewards = {
		{ "GainHonor", 6 },
		{ "AcquireTrophiesFromVoid", 3 },
	};
	--effect_text = "FATE: Banish the current event.\n" ..
    --              "  Reward: 6H. Choose up to 3 Trophy Monsters from the Void and put them into play under your control.";
	fate_text = "FATE: Banish the current event.";
	effect_text = "Reward: 6H. Choose up to 3 Trophy Monsters from the Void and put them into play under your control.";

   image_large = { "M_Nemesis", {0, 0, 364/512, 1} };
   image_medium = { "M_Nemesis", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_Nemesis", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_Nemesis", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "nemesis" };
   fate_sound = { "remove_card" };

   rarity_count = 1
}


g_ascension_cards["Tarik, the Trickster"] = { 
	card_name = "Tarik, the Trickster";
	card_set = "SoS";
	card_type = "Monster";
	power_cost = 6;
	rewards = {
		{ "GainHonor", 5 },
      { "CopyEffectOfAnyCenterRowHero", 0 },
	};
	effect_text = "Reward: 5H.  You may choose a Hero in the center row and copy its effect.";

   image_large = { "M_TarikTrickster", {0, 0, 364/512, 1} };
   image_medium = { "M_TarikTrickster", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_TarikTrickster", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_TarikTrickster", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "tarik" };

   rarity_count = 1
}


   function EachOpponentDiscardsRandomCard( state_machine, world, active_player, effect_data )

      local new_state = ascensionrules.CreateStateEachOpponentDiscardsRandomCard( active_player );
      StateMachine.PushListState( state_machine, new_state )
   end

g_ascension_cards["Noxious Soul"] = { 
	card_name = "Noxious Soul";
	card_set = "SoS";
	card_type = "Monster";
	power_cost = 5;
	rewards = {
		{ "GainHonor", 4 },
      { "EachOpponentDiscardsRandomCard", 0 },
	};
	effect_text = "Reward: 4H.  Each opponent must discard a card at random from their hand.";

   image_large = { "M_NoxiousSoul", {0, 0, 364/512, 1} };
   image_medium = { "M_NoxiousSoul", {392/512, 0, 512/512, 168/512} };
   image_small = { "M_NoxiousSoul", {410/512, 170/512, 512/512, 312/512} };
   image_half  = { "M_NoxiousSoul", {384/512, 395/512, 512/512, 512/512} };
   defeat_sound = { "noxious_soul" };

   rarity_count = 2
}






