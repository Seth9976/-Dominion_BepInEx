

function GainRunes( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

   World.OutputAnimationRune( world, effect_data, source_instance );
   
	World.AddCurrentTurnRunes( world, effect_data );
	
	local output_message = string.format( "%s gains %d runes\n", Instance.GetName(active_player), effect_data )
	World.OutputMessage( world, output_message )
end


function GainRunesForMechanaConstruct( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

   World.OutputAnimationRuneMechana( world, effect_data, source_instance );

	World.AddCurrentTurnRunesForMechanaConstruct( world, effect_data );
	
	local output_message = string.format( "%s gains %d runes\n", Instance.GetName(active_player), effect_data )
	World.OutputMessage( world, output_message )

end

function LoseRunes( state_machine, world, active_player, effect_data )

	World.RemoveCurrentTurnRunes( world, effect_data );
	
	--local output_message = string.format( "%s gains %d runes\n", Instance.GetName(active_player), effect_data )
	--World.OutputMessage( world, output_message )

end

function GainPower( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

   World.OutputAnimationPower( world, effect_data, source_instance );

	World.AddCurrentTurnPower( world, effect_data );
	
	local output_message = string.format( "%s gains %d power\n", Instance.GetName(active_player), effect_data )
	World.OutputMessage( world, output_message )
	
end


function GainPowerForEachMechanaConstructInPlay( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

	local construct_count = Player.CountConstructsInPlay( active_player, "Mechana" );
	GainPower( state_machine, world, active_player, construct_count, source_instance, effect_instance_data );
	
end

function GainHonor( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

	if( effect_data > 0 ) then
		local output_message = string.format( "%s gains %d honor tokens\n", Instance.GetName(active_player), effect_data )
		World.OutputMessage( world, output_message )
	
		World.OutputAnimationHonor( world, effect_data, active_player, source_instance );
   
		Player.AddHonorTokens( active_player, effect_data )
	
		--output_message = string.format( "%s now has %d honor tokens\n", Instance.GetName(active_player), Player.GetHonorTokenCount(active_player) )
		--World.OutputMessage( world, output_message )
	
		World.TakeHonorTokenPool( world, effect_data )
		--output_message = string.format( "%d honor tokens remain in pool\n", World.GetHonorTokenPool(world) )
		--World.OutputMessage( world, output_message )
	end
	
end

function GainHonorForEachTypeOfConstructInPlay( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

	local construct_type_count = 0;
	
	local enlightened_count = Player.CountConstructsInPlay( active_player, "Enlightened" );
	if( enlightened_count > 0 ) then
		construct_type_count = construct_type_count + 1;
	end
	
	local lifebound_count = Player.CountConstructsInPlay( active_player, "Lifebound" );
	if( lifebound_count > 0 ) then
		construct_type_count = construct_type_count + 1;
	end
	
	local mechana_count = Player.CountConstructsInPlay( active_player, "Mechana" );
	if( mechana_count > 0 ) then
		construct_type_count = construct_type_count + 1;
	end
	
	local void_count = Player.CountConstructsInPlay( active_player, "Void" );
	if( void_count > 0 ) then
		construct_type_count = construct_type_count + 1;
	end
	
	GainHonor( state_machine, world, active_player, construct_type_count, source_instance, effect_instance_data );
	
end

function DrawCards( state_machine, world, active_player, effect_data )

	local new_state = ascensionrules.CreateStateProcessDrawCards( active_player, effect_data );
	StateMachine.PushListState( state_machine, new_state )
end

--[[
function DrawCardsIfYouControl2Constructs( state_machine, world, active_player, effect_data )

	local construct_count = Player.CountConstructsInPlay( active_player );
	if( construct_count < 2 ) then
		return;
	end
	
	local new_state = ascensionrules.CreateStateProcessDrawCards( active_player, effect_data );
	StateMachine.PushListState( state_machine, new_state )
end
]]

function DiscardFromHand( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

	local new_state = ascensionrules.CreateStateProcessDiscardFromHand( active_player, effect_data, effect_instance_data );
	StateMachine.PushListState( state_machine, new_state )
end

--[[
function DiscardFromHandToDraw( state_machine, world, active_player, effect_data )

	local new_state = ascensionrules.CreateStateProcessDiscardFromHandToDraw( active_player, effect_data );
	StateMachine.PushListState( state_machine, new_state )
end
]]

function DiscardMultipleFromHand( state_machine, world, active_player, effect_data )

	local new_state = ascensionrules.CreateStateProcessDiscardMultipleFromHand( active_player, effect_data );
	StateMachine.PushListState( state_machine, new_state )
end

function DiscardCardsOrEnlightenedCard( state_machine, world, active_player, effect_data )

	local new_state = ascensionrules.CreateStateProcessDiscardCardsOrEnlightenedCard( active_player, effect_data );
	StateMachine.PushListState( state_machine, new_state )
end

function AcquireHeroToTopOfDeck( state_machine, world, active_player, effect_data )

	local new_state = ascensionrules.CreateStateProcessAcquireHeroToTopOfDeck( active_player, 0, 1, effect_data );
	StateMachine.PushListState( state_machine, new_state )
end

--[[
function AcquireFromCenterRow( state_machine, world, active_player, effect_data )

	local new_state = ascensionrules.CreateStateProcessAcquireFromCenterRow( active_player, effect_data );
	StateMachine.PushListState( state_machine, new_state )
end
]]

function AcquireMysticOrHeavyInfantryToTopOfDeck( state_machine, world, active_player, effect_data )

	local new_state = ascensionrules.CreateStateProcessAcquireMysticOrHeavyInfantry( active_player, effect_data, 0, 0 );
	StateMachine.PushListState( state_machine, new_state )
end

function AcquireMysticOrHeavyInfantryToHand( state_machine, world, active_player, effect_data )

	local new_state = ascensionrules.CreateStateProcessAcquireMysticOrHeavyInfantry( active_player, effect_data, 1, 1 );
	StateMachine.PushListState( state_machine, new_state )
end

function AcquireOrDefeatAnyCenterRow( state_machine, world, active_player, effect_data )

	local new_state = ascensionrules.CreateStateProcessAcquireOrDefeatAnyCenterRow( active_player );
	StateMachine.PushListState( state_machine, new_state )
end

function BanishFromHand( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

	local new_state = ascensionrules.CreateStateProcessBanishFromHand( active_player, effect_data, nil, effect_instance_data );
	StateMachine.PushListState( state_machine, new_state )
end

function BanishFromDiscard( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

	local new_state = ascensionrules.CreateStateProcessBanishFromDiscard( active_player, effect_data, nil, effect_instance_data );
	StateMachine.PushListState( state_machine, new_state )
end

function BanishFromHandOrDiscard( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

	local new_state = ascensionrules.CreateStateProcessBanishFromHandOrDiscard( active_player, effect_data, nil, effect_instance_data );
	StateMachine.PushListState( state_machine, new_state )
end

function BanishFromCenterRow( state_machine, world, active_player, effect_data, source_instance, effect_instance_data )

	local new_state = ascensionrules.CreateStateProcessBanishFromCenterRow( active_player, effect_data, -1, effect_instance_data );
	StateMachine.PushListState( state_machine, new_state )
end


function DefeatMonsterWithLessPower( state_machine, world, active_player, effect_data )

	local new_state = ascensionrules.CreateStateProcessDefeatMonsterWithLessPower( active_player, effect_data );
	StateMachine.PushListState( state_machine, new_state )
end


function CopyEffectOfAnyPlayedHero( state_machine, world, active_player, effect_data, source_instance )

	local new_state = ascensionrules.CreateStateProcessCopyEffectOfPlayedHero( active_player, source_instance );
	StateMachine.PushListState( state_machine, new_state )
end

--[[
function TriggerCopyEffectOfAnyPlayedHero( state_machine, active_instance, source, event, effect_data )

	local source_player = ActiveEffectInstance.GetSourceInstance( active_instance );
	local world = Instance.GetWorld( source_player );
   
   CopyEffectOfAnyPlayedHero( state_machine, world, source_player, effect_data, nil )
end
]]

function TriggerGainRunes( state_machine, active_instance, source, event, effect_data )

	local source_player = ActiveEffectInstance.GetSourceInstance( active_instance );
	local world = Instance.GetWorld( source_player );
		
	GainRunes( state_machine, world, source_player, effect_data )
end

function TriggerGainPower( state_machine, active_instance, source, event, effect_data )

	local source_player = ActiveEffectInstance.GetSourceInstance( active_instance );
	local world = Instance.GetWorld( source_player );
		
	GainPower( state_machine, world, source_player, effect_data )
end

function TriggerGainHonor( state_machine, active_instance, source, event, effect_data )

	local effect_player = ActiveEffectInstance.GetEffectInstance( active_instance );
	local world = Instance.GetWorld( effect_player );
	
	--local output_message = string.format( "%s gains %d honor tokens from %s\n",
	--	Instance.GetName(effect_player), effect_data, Instance.GetName(source) )
	local output_message = string.format( "%s gains %d honor tokens\n",
		Instance.GetName(effect_player), effect_data )
	World.OutputMessage( world, output_message )
	
   World.OutputAnimationHonor( world, effect_data, effect_player, source );
   
	Player.AddHonorTokens( effect_player, effect_data )
	
	World.TakeHonorTokenPool( world, effect_data )
	
end



function TriggerConstructGainRunes( state_machine, active_instance, source, event, effect_data )

	local active_player = ConstructInstance.GetOwner( source );
	local world = Instance.GetWorld( active_player );
		
   World.OutputAnimationRune( world, effect_data, source );
   
	World.AddCurrentTurnRunes( world, effect_data );
	
	local output_message = string.format( "%s gains %d runes from %s\n",
      Instance.GetName(active_player), effect_data, Instance.GetName(source) )
	World.OutputMessage( world, output_message )
end


function TriggerConstructGainPower( state_machine, active_instance, source, event, effect_data )

	local active_player = ConstructInstance.GetOwner( source );
	local world = Instance.GetWorld( active_player );
		
   World.OutputAnimationPower( world, effect_data, source );
   
	World.AddCurrentTurnPower( world, effect_data );
	
	local output_message = string.format( "%s gains %d power from %s\n",
      Instance.GetName(active_player), effect_data, Instance.GetName(source) )
	World.OutputMessage( world, output_message )
end

function TriggerConstructGainHonor( state_machine, active_instance, source, event, effect_data )

	local active_player = ConstructInstance.GetOwner( source );
	local world = Instance.GetWorld( active_player );
	
	local output_message = string.format( "%s gains %d honor tokens from %s\n",
		Instance.GetName(active_player), effect_data, Instance.GetName(source) )
	World.OutputMessage( world, output_message )
	
   World.OutputAnimationHonor( world, effect_data, active_player, source );

	Player.AddHonorTokens( active_player, effect_data )
	
	World.TakeHonorTokenPool( world, effect_data )
	
end



function ChooseFromEffectList( state_machine, world, active_player, effect_data, source_instance, effect_instance_data, event )

	local new_state = ascensionrules.CreateStateProcessChooseEffectFromList( active_player, effect_data, source_instance, event );
	StateMachine.PushListState( state_machine, new_state )

end


