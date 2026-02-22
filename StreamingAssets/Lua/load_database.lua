
ascension_active_effect_count = 0
ascension_card_count = 0

function ParseAscensionEffect( parse_effect, effect_def )

	if( type(effect_def) == "table" ) then
		
		local effect_func = effect_def[1];
		local effect_data = effect_def[2];
		
		if( type(effect_data) == "table" ) then
			local effect_list = AscensionEffectList.Create();
			
         if( effect_data.prompt ~= nil ) then
            AscensionEffectList.SetPromptText( effect_list, effect_data.prompt );
         end

			for index,single_effect in ipairs(effect_data) do
				local new_effect = CreateAscensionEffects( single_effect );
				AscensionEffectList.AddEffectToList( effect_list, new_effect, single_effect.description );
			end
			
			Database.AddEffectList( effect_list )

			effect_data = effect_list;
		end
		
		if( type(effect_def.condition) == "table" ) then
			AscensionEffect.AddEffect( parse_effect, effect_func, effect_data,
										effect_def.condition[1], effect_def.condition[2] )
		
		else
			AscensionEffect.AddEffect( parse_effect, effect_func, effect_data )
		end
	end
	
end

function CreateAscensionEffect( effect_def )

	local new_effect = AscensionEffect.Create()
	
	ParseAscensionEffect( new_effect, effect_def )
		
	if( type(effect_def.usagecondition) == "table" ) then
		AscensionEffect.AddUsageCondition( new_effect, effect_def.usagecondition[1], effect_def.usagecondition[2] )
	elseif( type(effect_def.usageconditions) == "table" ) then
		for index,usage in ipairs(effect_def.usageconditions) do
			AscensionEffect.AddUsageCondition( new_effect, usage[1], usage[2] )
		end
	end
   			
	return new_effect
end

function CreateAscensionEffects( effect_def )

	local new_effect = AscensionEffect.Create()
		
	if( type(effect_def.usagecondition) == "table" ) then
		AscensionEffect.AddUsageCondition( new_effect, effect_def.usagecondition[1], effect_def.usagecondition[2] )
	elseif( type(effect_def.usageconditions) == "table" ) then
		for index,usage in ipairs(effect_def.usageconditions) do
			AscensionEffect.AddUsageCondition( new_effect, usage[1], usage[2] )
		end
	end

	for index,single_effect_def in ipairs(effect_def) do
		ParseAscensionEffect( new_effect, single_effect_def )
	end
	
	return new_effect
end


function CreateAscensionCardInPlayAbility( default_name, ability_def )

	local cardinplay_ability_name = default_name .. " ability"
	if( ability_def.ability_name ~= nil ) then
		cardinplay_ability_name = ability_def.ability_name
	end
	
	local cardinplay_ability = CardInPlayAbilityDefinition.Create( cardinplay_ability_name )
	
	if( ability_def.description ~= nil ) then
		CardInPlayAbilityDefinition.SetAbilityDescription( cardinplay_ability, ability_def.description );
	end
	
	if( type(ability_def.condition) == "table" ) then
		CardInPlayAbilityDefinition.SetAbilityConditionFunc( cardinplay_ability, 0, ability_def.condition[1], ability_def.condition[2] )
	end	
		
	local ability_effect = AscensionEffect.Create()
	for index,single_effect_def in ipairs(ability_def) do
		ParseAscensionEffect( ability_effect, single_effect_def )
	end
	CardInPlayAbilityDefinition.SetEffect( cardinplay_ability, ability_effect )
   
   if( ability_def.ai ~= nil ) then
      local ai_def = ability_def.ai;
   
      if( ai_def.trivial ~= nil ) then
         CardInPlayAbilityDefinition.SetAI_Trivial( cardinplay_ability, ai_def.trivial );
      end
      if( ai_def.trivial_draw ~= nil ) then
         CardInPlayAbilityDefinition.SetAI_TrivialDraw( cardinplay_ability, ai_def.trivial_draw );
      end
      if( ai_def.use_at_end_of_turn ~= nil ) then
         CardInPlayAbilityDefinition.SetAI_UseAtEndOfTurn( cardinplay_ability, ai_def.use_at_end_of_turn );
      end


   end
	
	return cardinplay_ability
end


function CreateAscensionConstructAbility( default_name, ability_def )

	local construct_ability_name = default_name .. " ability"
	if( ability_def.ability_name ~= nil ) then
		construct_ability_name = ability_def.ability_name
	end
	
	local construct_ability = ConstructAbilityDefinition.Create( construct_ability_name )
	
	if( ability_def.description ~= nil ) then
		ConstructAbilityDefinition.SetAbilityDescription( construct_ability, ability_def.description );
	end
	
	if( type(ability_def.condition) == "table" ) then
		ConstructAbilityDefinition.SetAbilityConditionFunc( construct_ability, 0, ability_def.condition[1], ability_def.condition[2] )
	end	
		
	local ability_effect = AscensionEffect.Create()
	for index,single_effect_def in ipairs(ability_def) do
		ParseAscensionEffect( ability_effect, single_effect_def )
	end
	ConstructAbilityDefinition.SetEffect( construct_ability, ability_effect )
   
   if( ability_def.ai ~= nil ) then
      local ai_def = ability_def.ai;
   
      if( ai_def.trivial ~= nil ) then
         ConstructAbilityDefinition.SetAI_Trivial( construct_ability, ai_def.trivial );
      end
      if( ai_def.trivial_draw ~= nil ) then
         ConstructAbilityDefinition.SetAI_TrivialDraw( construct_ability, ai_def.trivial_draw );
      end
      if( ai_def.use_at_end_of_turn ~= nil ) then
         ConstructAbilityDefinition.SetAI_UseAtEndOfTurn( construct_ability, ai_def.use_at_end_of_turn );
      end


   end
	
	return construct_ability
end

function CreateContinuousEffect( effect_name, effect_def )

	local new_effect = ContinuousEffectDefinition.Create( effect_name )
	
   if( effect_def.version_before ~= nil ) then
      ActiveEffectDefinition.SetVersionBefore( new_effect, effect_def.version_before );
   end
   if( effect_def.version_after ~= nil ) then
      ActiveEffectDefinition.SetVersionAfter( new_effect, effect_def.version_after );
   end

   if( effect_def.priority ~= nil ) then
      ActiveEffectDefinition.SetEffectPriority( new_effect, effect_def.priority );
   end
   
	if( type(effect_def.effect) == "table" ) then
		ContinuousEffectDefinition.SetContinuousEffectFunc( new_effect, effect_def.effect[1], effect_def.effect[2] )
	end
	
	if( type(effect_def.conditions) == "table" ) then
		for cond_index,condition_def in pairs(effect_def.conditions) do
			if( type(condition_def) == "table" ) then
				ActiveEffectDefinition.SetEffectConditionFunc( new_effect, cond_index-1, condition_def[1], condition_def[2] )
			end
		end
	end	

	return new_effect
end

function CreateTriggeredEffect( effect_name, effect_def )
	
	local new_effect = TriggeredEffectDefinition.Create( effect_name )

   if( effect_def.version_before ~= nil ) then
      ActiveEffectDefinition.SetVersionBefore( new_effect, effect_def.version_before );
   end
   if( effect_def.version_after ~= nil ) then
      ActiveEffectDefinition.SetVersionAfter( new_effect, effect_def.version_after );
   end

   if( effect_def.priority ~= nil ) then
      ActiveEffectDefinition.SetEffectPriority( new_effect, effect_def.priority );
   end

   if( effect_def.trigger_type ~= nil ) then
      TriggeredEffectDefinition.SetTriggerType( new_effect, effect_def.trigger_type );
   end

	if( type(effect_def.triggereffect) == "table" ) then

		for index,trigger_effect_def in pairs(effect_def.triggereffect) do
			if( type(trigger_effect_def) == "table" ) then

				local trigger_effect_func = trigger_effect_def[1];
				local trigger_effect_data = trigger_effect_def[2];
		
				if( type(trigger_effect_data) == "table" ) then
					local effect_list = AscensionEffectList.Create();
			
         				if( trigger_effect_data.prompt ~= nil ) then
            					AscensionEffectList.SetPromptText( effect_list, trigger_effect_data.prompt );
         				end

					for index,single_effect in ipairs(trigger_effect_data) do
						local new_effect = CreateAscensionEffects( single_effect );
						AscensionEffectList.AddEffectToList( effect_list, new_effect, single_effect.description );
					end
			
					Database.AddEffectList( effect_list )

					trigger_effect_data = effect_list;
				end

				TriggeredEffectDefinition.AddTriggerEffect( new_effect, trigger_effect_func, trigger_effect_data )
			end
		end
		
	end

	if( type(effect_def.conditions) == "table" ) then
		for cond_index,condition_def in pairs(effect_def.conditions) do
			if( type(condition_def) == "table" ) then
				ActiveEffectDefinition.SetEffectConditionFunc( new_effect, cond_index-1, condition_def[1], condition_def[2] )
			end
		end
	end	
	
	return new_effect
end

function ParseEffect( effect_def )

	local effect_func = effect_def[1]
	
	local effect_data = 0
	if( type(effect_def[2]) == "number" or type(effect_def[2]) == "string" ) then
		effect_data = effect_def[2]
	end
	
	return effect_func,effect_data
end


function CreateActiveEffect( effect_name, effect_def )
	
	if( effect_def.type == nil ) then
		return nil
	end
	
	local new_effect = nil
	if( effect_def.type == "continuous" ) then
		new_effect = ContinuousEffectDefinition.Create( effect_name )
	
      if( effect_def.priority ~= nil ) then
         ActiveEffectDefinition.SetEffectPriority( new_effect, effect_def.priority );
      end

		local effect_func = nil
		local effect_data = nil
		if( type(effect_def.effectfunc) == "table" ) then
			effect_func,effect_data = ParseEffect( effect_def.effectfunc )
			ContinuousEffectDefinition.SetContinuousEffectFunc( new_effect, effect_func, effect_data )
			
		elseif( type(effect_def.effectfuncs) == "table" ) then
	
			for index,effectfunc in pairs(effect_def.effectfuncs) do
				effect_func,effect_data = ParseEffect( effectfunc )
				ContinuousEffectDefinition.SetContinuousEffectFunc( new_effect, effect_func, effect_data )
			end
		end
      
	elseif( effect_def.type == "triggered" ) then
   
		new_effect = CreateTriggeredEffect( effect_name, effect_def )
		return new_effect
      
	end
	
	if( new_effect ~= nil ) then

      if( effect_def.version_before ~= nil ) then
         ActiveEffectDefinition.SetVersionBefore( new_effect, effect_def.version_before );
      end
      if( effect_def.version_after ~= nil ) then
         ActiveEffectDefinition.SetVersionAfter( new_effect, effect_def.version_after );
      end

		if( type(effect_def.conditions) == "table" ) then
			for cond_index,condition_def in pairs(effect_def.conditions) do
				if( type(condition_def) == "table" ) then
					ActiveEffectDefinition.SetEffectConditionFunc( new_effect, cond_index-1, condition_def[1], condition_def[2] )
				end
			end
		end	
	end
	
	return new_effect
end


print( "" )

for index,effect_def in pairs(g_ascension_active_effects) do
	--print( string.format( "effect: %s", index ) )
	
	local active_effect = CreateActiveEffect( index, effect_def )
	if( active_effect ~= nil ) then
		Database.AddActiveEffect( active_effect )
		ascension_active_effect_count = ascension_active_effect_count + 1
	end
end

print( string.format( "loaded %d active effects", ascension_active_effect_count ) )
print( "" )

for index,card_def in pairs(g_ascension_cards) do

	print( string.format( "card[%s]: %s", index, card_def.card_name ) )
	
	local new_card = AscensionCard.Create( card_def.card_name, card_def.card_type )

   if( card_def.display_name ~= nil ) then
		AscensionCard.SetDisplayName( new_card, card_def.display_name )
   end
   
   if( card_def.card_set ~= nil ) then
		AscensionCard.SetCardSet( new_card, card_def.card_set )
   end
   
	if( card_def.faction ~= nil ) then
		AscensionCard.SetFaction( new_card, card_def.faction )
	elseif( card_def.factions ~= nil ) then
		for index,faction_name in pairs(card_def.factions) do
         AscensionCard.SetFaction( new_card, faction_name )
		end
	end
	
	if( card_def.rune_cost ~= nil ) then
		AscensionCard.SetRuneCost( new_card, card_def.rune_cost )
	end
	if( card_def.rune_cost_prever20 ~= nil ) then
		AscensionCard.SetRuneCost_PreVer20( new_card, card_def.rune_cost_prever20 )
	end


	if( card_def.power_cost ~= nil ) then
		AscensionCard.SetPowerCost( new_card, card_def.power_cost )
	end
	
	if( card_def.honor ~= nil ) then
		AscensionCard.SetHonorValue( new_card, card_def.honor )
	end


   if( card_def.uses_energy ~= nil ) then
		AscensionCard.SetUsesEnergy( new_card, card_def.uses_energy )
	end
   if( card_def.energy_required ~= nil ) then
		AscensionCard.SetEnergyCost( new_card, card_def.energy_required )
	end

   if( card_def.insight_cost ~= nil ) then
      AscensionCard.SetInsightCost( new_card, card_def.insight_cost )
   end
   
   if( card_def.phantasm_cost ~= nil ) then
      AscensionCard.SetPhantasmCost( new_card, card_def.phantasm_cost )
   end
   
   if( card_def.transform_cost ~= nil ) then
      AscensionCard.SetTransformCost( new_card, card_def.transform_cost )
   end   
   
   if( card_def.life_cost ~= nil ) then
      AscensionCard.SetLifeCost( new_card, card_def.life_cost )
   end
   
   if( card_def.death_cost ~= nil ) then
      AscensionCard.SetDeathCost( new_card, card_def.death_cost )
   end

	if( card_def.honor_value_equals_treasure ~= nil ) then
		AscensionCard.SetHonorValueEqualsTreasure( new_card, card_def.honor_value_equals_treasure )
	end


   if( card_def.trophy_monster ~= nil ) then
   	AscensionCard.SetTrophyMonster( new_card, card_def.trophy_monster )
      if( card_def.unique_trophy ~= nil ) then
         AscensionCard.SetUniqueTrophy( new_card, card_def.unique_trophy )
      end
   end
   
   if( card_def.do_not_put_in_void ~= nil ) then
		AscensionCard.SetEffectDoNotSendToVoid( new_card, card_def.do_not_put_in_void )
	end
   
   if( card_def.use_transformed_frame ~= nil ) then
		AscensionCard.SetEffectUseTransformedFrame( new_card, card_def.use_transformed_frame )
	end
   
   if( card_def.played_effect_cannot_be_copied ~= nil ) then
		AscensionCard.SetPlayedEffectCannotBeCopied( new_card, card_def.played_effect_cannot_be_copied )
	end
   if( card_def.delay_played_event_until_after_resolution ~= nil ) then
		AscensionCard.SetDelayPlayedEventUntilAfterResolution( new_card, card_def.delay_played_event_until_after_resolution )
	end



   if( card_def.monsters_under_construct ~= nil ) then
		AscensionCard.SetEffectHoldsMonsters( new_card, card_def.monsters_under_construct )
	end

   if( card_def.construct_count_value ) then
		AscensionCard.SetConstructCountValue( new_card, card_def.construct_count_value )
   end

   if( card_def.rally_faction_when_defeated ~= nil ) then
		AscensionCard.SetRallyFactionWhenDefeated( new_card, card_def.rally_faction_when_defeated )
	end

   if( card_def.dream ~= nil ) then
      AscensionCard.SetDreamCard( new_card, card_def.dream )
   end
   if( card_def.dreamborn ~= nil ) then
      AscensionCard.SetDreambornCard( new_card, card_def.dreamborn )
   end
   if( card_def.dreambind ~= nil ) then
      AscensionCard.SetDreambindCard( new_card, card_def.dreambind )
   end
   if( card_def.ongoing ~= nil ) then
      AscensionCard.SetOngoing( new_card, card_def.ongoing )
   end
   if( card_def.spend_power_to_acquire ~= nil ) then
      AscensionCard.SetSpendPowerToAcquire( new_card, card_def.spend_power_to_acquire )
   end
   if( card_def.spend_insight_to_acquire ~= nil ) then
      AscensionCard.SetSpendInsightToAcquire( new_card, card_def.spend_insight_to_acquire )
   end
   if( card_def.spend_insight_to_defeat ~= nil ) then
      AscensionCard.SetSpendInsightToDefeat( new_card, card_def.spend_insight_to_defeat )
   end
   if( card_def.counts_as_played_hero ~= nil ) then
      AscensionCard.SetCountsAsPlayedHero( new_card, card_def.counts_as_played_hero )
   end
   if( card_def.treat_monsters_as_mechana_constructs ~= nil ) then
      AscensionCard.SetTreatMonstersAsMechanaConstructs( new_card, card_def.treat_monsters_as_mechana_constructs )
   end

   if( card_def.day_night ~= nil ) then
      if( card_def.day_night == "day" ) then
         AscensionCard.SetDayValue( new_card, 1 )
      elseif( card_def.day_night == "night" ) then
         AscensionCard.SetNightValue( new_card, 1 )
      end
   end

   if( card_def.empower ~= nil ) then
      AscensionCard.SetEmpower( new_card, card_def.empower )
   end


	if( card_def.effect ~= nil ) then
		local played_effect = CreateAscensionEffect( card_def.effect )
		AscensionCard.SetPlayedEffect( new_card, played_effect )
	elseif( card_def.effects ~= nil ) then
		local played_effect = CreateAscensionEffects( card_def.effects )
		AscensionCard.SetPlayedEffect( new_card, played_effect )
	end

	if( card_def.reward ~= nil ) then
		local played_effect = CreateAscensionEffect( card_def.reward )
		AscensionCard.SetRewardEffect( new_card, played_effect )
	elseif( card_def.rewards ~= nil ) then
		local reward_effect = CreateAscensionEffects( card_def.rewards )
		AscensionCard.SetRewardEffect( new_card, reward_effect )
	end
	
   if( card_def.trophy_effects ~= nil ) then
		local trophy_effect = CreateAscensionEffects( card_def.trophy_effects )
		AscensionCard.SetTrophyEffect( new_card, trophy_effect )
   end
   
	if( card_def.center_row ~= nil ) then
		local center_row_effect = CreateAscensionEffect( card_def.center_row )
		AscensionCard.SetCenterRowEffect( new_card, center_row_effect )
	end
	
	if( card_def.banish_effect ~= nil ) then
		local banish_effect = CreateAscensionEffect( card_def.banish_effect )
		AscensionCard.SetBanishEffect( new_card, banish_effect )
	end
	
	if( card_def.transform ~= nil ) then
		local transform_effect = CreateAscensionEffects( card_def.transform )
		AscensionCard.SetTransformEffect( new_card, transform_effect )
	end

	if( card_def.cardinplay_ability ~= nil ) then
		local new_cardinplay_ability = CreateAscensionCardInPlayAbility( card_def.card_name, card_def.cardinplay_ability )
		AscensionCard.AddCardInPlayAbility( new_card, new_cardinplay_ability )
	elseif( card_def.cardinplay_abilities ~= nil ) then
		for index,cardinplay_ability_def in pairs(card_def.cardinplay_abilities) do
			local new_cardinplay_ability = CreateAscensionCardInPlayAbility( card_def.card_name, cardinplay_ability_def )
			AscensionCard.AddCardInPlayAbility( new_card, new_cardinplay_ability )
		end
	end

	if( card_def.construct_ability ~= nil ) then
		local new_construct_ability = CreateAscensionConstructAbility( card_def.card_name, card_def.construct_ability )
		AscensionCard.AddConstructAbility( new_card, new_construct_ability )
	elseif( card_def.construct_abilities ~= nil ) then
		
		for index,construct_ability_def in pairs(card_def.construct_abilities) do
			local new_construct_ability = CreateAscensionConstructAbility( card_def.card_name, construct_ability_def )
			AscensionCard.AddConstructAbility( new_card, new_construct_ability )
		end
	end

	if( card_def.continuous_effects ~= nil ) then
		local continuous_effect = CreateContinuousEffect( card_def.card_name, card_def.continuous_effects[1] );
		AscensionCard.AddActiveEffect( new_card, continuous_effect );
	end
	
	if( card_def.triggered_effects ~= nil ) then
		for trigger_index,trigger_def in pairs(card_def.triggered_effects) do
			local trigger_effect = CreateTriggeredEffect( card_def.card_name .. trigger_index, trigger_def );
         AscensionCard.AddActiveEffect( new_card, trigger_effect );
		end
		--local trigger_effect = CreateTriggeredEffect( card_def.card_name, card_def.triggered_effects[1] );
		--AscensionCard.AddActiveEffect( new_card, trigger_effect );
	end
	
	--if( card_def.center_row_continuous_effects ~= nil ) then
	--	local continuous_effect = CreateContinuousEffect( card_def.card_name, card_def.center_row_continuous_effects[1] );
	--	AscensionCard.AddCenterRowActiveEffect( new_card, continuous_effect );
	--end

   if( type(card_def.center_row_continuous_effects) == "table" ) then
      for continuous_index,continuous_def in pairs(card_def.center_row_continuous_effects) do
         local continuous_effect = CreateContinuousEffect( card_def.card_name .. " center continuous " .. continuous_index, continuous_def );
         AscensionCard.AddCenterRowActiveEffect( new_card, continuous_effect );
      end
   end
	
	if( card_def.center_row_triggered_effects ~= nil ) then
		local trigger_effect = CreateTriggeredEffect( card_def.card_name .. " center triggered" , card_def.center_row_triggered_effects[1] );
		AscensionCard.AddCenterRowActiveEffect( new_card, trigger_effect );
	end
	
	if( card_def.global_continuous_effects ~= nil ) then
		local continuous_effect = CreateContinuousEffect( card_def.card_name .. " global continuous", card_def.global_continuous_effects[1] );
		AscensionCard.AddGlobalActiveEffect( new_card, continuous_effect );
	end

	if( card_def.global_triggered_effects ~= nil ) then
		local trigger_effect = CreateTriggeredEffect( card_def.card_name .. " global triggered", card_def.global_triggered_effects[1] );
		AscensionCard.AddGlobalActiveEffect( new_card, trigger_effect );
	end
   
	if( card_def.effect_text ~= nil ) then
		AscensionCard.SetEffectText( new_card, card_def.effect_text );
	end
	if( card_def.fate_text ~= nil ) then
		AscensionCard.SetFateEffectText( new_card, card_def.fate_text );
	end
	if( card_def.trophy_text ~= nil ) then
		AscensionCard.SetTrophyEffectText( new_card, card_def.trophy_text );
	end
	if( card_def.day_text ~= nil ) then
		AscensionCard.SetDayEffectText( new_card, card_def.day_text );
	end
	if( card_def.night_text ~= nil ) then
		AscensionCard.SetNightEffectText( new_card, card_def.night_text );
	end
	if( card_def.flavor_text ~= nil ) then
		AscensionCard.SetFlavorText( new_card, card_def.flavor_text );
	end
	
   
   
   if( card_def.ai ~= nil ) then
      local ai_def = card_def.ai;
   
      if( ai_def.trivial ~= nil ) then
         AscensionCard.SetAI_Trivial( new_card, ai_def.trivial );
      end
      if( ai_def.trivial_draw ~= nil ) then
         AscensionCard.SetAI_TrivialDraw( new_card, ai_def.trivial_draw );
      end
      if( ai_def.preferred_discard ~= nil ) then
         AscensionCard.SetAI_PreferredDiscard( new_card, ai_def.preferred_discard );
      end
      if( ai_def.preferred_banish ~= nil ) then
         AscensionCard.SetAI_PreferredBanish( new_card, ai_def.preferred_banish );
      end
      if( ai_def.requires_copyable_played_card ~= nil ) then
         AscensionCard.SetAI_RequiresCopyablePlayedCard( new_card, ai_def.requires_copyable_played_card );
      end
      if( ai_def.do_not_copy_played_card ~= nil ) then
         AscensionCard.SetAI_DoNotCopyPlayedCard( new_card, ai_def.do_not_copy_played_card );
      end


      if( ai_def.might_not_play ~= nil ) then
         AscensionCard.SetAI_MightNotPlay( new_card, ai_def.might_not_play );
      end

      if( ai_def.gain_rune ~= nil ) then
         AscensionCard.SetAI_GainRune( new_card, ai_def.gain_rune );
      end
      if( ai_def.gain_power ~= nil ) then
         AscensionCard.SetAI_GainPower( new_card, ai_def.gain_power );
      end
      if( ai_def.gain_honor ~= nil ) then
         AscensionCard.SetAI_GainHonor( new_card, ai_def.gain_honor );
      end
      if( ai_def.gain_draw ~= nil ) then
         AscensionCard.SetAI_GainDraw( new_card, ai_def.gain_draw );
      end
      if( ai_def.gain_energy ~= nil ) then
         AscensionCard.SetAI_GainEnergy( new_card, ai_def.gain_energy );
      end
      if( ai_def.gain_insight ~= nil ) then
         AscensionCard.SetAI_GainInsight( new_card, ai_def.gain_insight );
      end
      if( ai_def.gain_dreamscape ~= nil ) then
         AscensionCard.SetAI_GainDreamscape( new_card, ai_def.gain_dreamscape );
      end
      if( ai_def.energy_threshold ~= nil ) then
         AscensionCard.SetAI_EnergyThreshold( new_card, ai_def.energy_threshold );
      end

   end
   
   
   
   if( card_def.image_large ~= nil ) then
      if( card_def.image_large[2] ~= nil ) then
         AscensionCard.SetCardImageLarge( new_card, card_def.image_large[1],
                                       card_def.image_large[2][1], card_def.image_large[2][2],
                                       card_def.image_large[2][3], card_def.image_large[2][4] );
      else
         AscensionCard.SetCardImageLarge( new_card, card_def.image_large[1], 0, 0, 1, 1 );
      end
   end
   
   if( card_def.image_medium ~= nil ) then
      if( card_def.image_medium[2] ~= nil ) then
         AscensionCard.SetCardImageMedium( new_card, card_def.image_medium[1],
                                       card_def.image_medium[2][1], card_def.image_medium[2][2],
                                       card_def.image_medium[2][3], card_def.image_medium[2][4] );
      else
         AscensionCard.SetCardImageMedium( new_card, card_def.image_medium[1], 0, 0, 1, 1 );
      end
   end   
    
   if( card_def.image_small ~= nil ) then
      if( card_def.image_small[2] ~= nil ) then
         AscensionCard.SetCardImageSmall( new_card, card_def.image_small[1],
                                       card_def.image_small[2][1], card_def.image_small[2][2],
                                       card_def.image_small[2][3], card_def.image_small[2][4] );
      else
         AscensionCard.SetCardImageSmall( new_card, card_def.image_small[1], 0, 0, 1, 1 );
      end
   end   
   
   if( card_def.image_half ~= nil ) then
      if( card_def.image_half[2] ~= nil ) then
         AscensionCard.SetCardImageHalf( new_card, card_def.image_half[1],
                                       card_def.image_half[2][1], card_def.image_half[2][2],
                                       card_def.image_half[2][3], card_def.image_half[2][4] );
      else
         AscensionCard.SetCardImageHalf( new_card, card_def.image_half[1], 0, 0, 1, 1 );
      end
   end   
   
   if( card_def.defeat_sound ~= nil ) then
      if( card_def.defeat_sound[2] ~= nil ) then
         AscensionCard.SetCardDefeatSoundData( new_card, card_def.defeat_sound[1],
                                       card_def.defeat_sound[2][1], card_def.defeat_sound[2][2],
                                       card_def.defeat_sound[2][3], card_def.defeat_sound[2][4] );
      else
         AscensionCard.SetCardDefeatSoundData( new_card, card_def.defeat_sound[1], 0, 0, 0, 1 );
      end
   end
   
   if( card_def.fate_sound ~= nil ) then
      if( card_def.fate_sound[2] ~= nil ) then
         AscensionCard.SetCardFateSoundData( new_card, card_def.fate_sound[1],
                                       card_def.fate_sound[2][1], card_def.fate_sound[2][2],
                                       card_def.fate_sound[2][3], card_def.fate_sound[2][4] );
      else
         AscensionCard.SetCardFateSoundData( new_card, card_def.fate_sound[1], 0, 0, 0, 1 );
      end
   end


   if( card_def.highlight_played_effect ~= nil ) then
      AscensionCard.SetCardHighlightPlayedEffect( new_card,
                                       card_def.highlight_played_effect[1], card_def.highlight_played_effect[2],
                                       card_def.highlight_played_effect[3], card_def.highlight_played_effect[4] );
   end

   if( card_def.highlight_day ~= nil ) then
      AscensionCard.SetCardHighlightDay( new_card,
                                       card_def.highlight_day[1], card_def.highlight_day[2],
                                       card_def.highlight_day[3], card_def.highlight_day[4] );
   end

   if( card_def.highlight_night ~= nil ) then
      AscensionCard.SetCardHighlightNight( new_card,
                                       card_def.highlight_night[1], card_def.highlight_night[2],
                                       card_def.highlight_night[3], card_def.highlight_night[4] );
   end

   if( card_def.highlight_centerrow_day ~= nil ) then
      AscensionCard.SetCardHighlightCenterRowDay( new_card,
                                       card_def.highlight_centerrow_day[1], card_def.highlight_centerrow_day[2],
                                       card_def.highlight_centerrow_day[3], card_def.highlight_centerrow_day[4] );
   end

   if( card_def.highlight_centerrow_night ~= nil ) then
      AscensionCard.SetCardHighlightCenterRowNight( new_card,
                                       card_def.highlight_centerrow_night[1], card_def.highlight_centerrow_night[2],
                                       card_def.highlight_centerrow_night[3], card_def.highlight_centerrow_night[4] );
   end

   if( card_def.rarity_count ~= nil ) then
      AscensionCard.SetRarityCount( new_card, card_def.rarity_count )
   end

	Database.AddCard( new_card )

	ascension_card_count = ascension_card_count + 1
end

for index,card_def in pairs(g_ascension_cards) do
	
   local new_card = Database.GetCard( card_def.card_name );
   
   if( card_def.transform_into ~= nil ) then
   
      print( string.format( "transform_into[%s]: %s", card_def.card_name, card_def.transform_into ) )

      local transform_into = Database.GetCard( card_def.transform_into );
      AscensionCard.SetTransformInto( new_card, transform_into );

   end
   
   if( card_def.transform_from ~= nil ) then
   
      print( string.format( "transform_from[%s]: %s", card_def.card_name, card_def.transform_from ) )

      local transform_from = Database.GetCard( card_def.transform_from );
      AscensionCard.SetTransformFrom( new_card, transform_from );

   end
end


print( string.format( "loaded %d cards", ascension_card_count ) )
--print( "" )


g_ascension_active_effects = nil
g_ascension_cards = nil

ascension_active_effect_count = nil
ascension_card_count = nil
