using System;

namespace GameEvent
{
	// Token: 0x02000136 RID: 310
	public enum EventType
	{
		// Token: 0x040016B8 RID: 5816
		OutputEventPause = 1,
		// Token: 0x040016B9 RID: 5817
		OutputEventAnimationCard,
		// Token: 0x040016BA RID: 5818
		OutputEventAnimationResource,
		// Token: 0x040016BB RID: 5819
		OutputEventAnimationDeliriumDie,
		// Token: 0x040016BC RID: 5820
		KingdomStackStatus,
		// Token: 0x040016BD RID: 5821
		CenterRowStatus,
		// Token: 0x040016BE RID: 5822
		CardInPlayStatus,
		// Token: 0x040016BF RID: 5823
		RevealedCardList,
		// Token: 0x040016C0 RID: 5824
		CardLocation,
		// Token: 0x040016C1 RID: 5825
		ResetPlayerDiscardPile,
		// Token: 0x040016C2 RID: 5826
		CloseDreamscapeTray,
		// Token: 0x040016C3 RID: 5827
		TransformCard,
		// Token: 0x040016C4 RID: 5828
		UpdatePlayedCardList,
		// Token: 0x040016C5 RID: 5829
		UpdateResolveEffectList,
		// Token: 0x040016C6 RID: 5830
		RemovePlayedCard,
		// Token: 0x040016C7 RID: 5831
		AddOwnedCard,
		// Token: 0x040016C8 RID: 5832
		RemoveOwnedCard,
		// Token: 0x040016C9 RID: 5833
		DefeatMonster,
		// Token: 0x040016CA RID: 5834
		AcquireCard,
		// Token: 0x040016CB RID: 5835
		ActionEvent,
		// Token: 0x040016CC RID: 5836
		PlayerSelectedOption,
		// Token: 0x040016CD RID: 5837
		TutorialAISelectedOption,
		// Token: 0x040016CE RID: 5838
		TurnNumber,
		// Token: 0x040016CF RID: 5839
		GameOver,
		// Token: 0x040016D0 RID: 5840
		DiscardsReshuffled,
		// Token: 0x040016D1 RID: 5841
		CardsAdded,
		// Token: 0x040016D2 RID: 5842
		CardPlayed,
		// Token: 0x040016D3 RID: 5843
		EventPlayed,
		// Token: 0x040016D4 RID: 5844
		PushResolveCard,
		// Token: 0x040016D5 RID: 5845
		PopResolveCard,
		// Token: 0x040016D6 RID: 5846
		PushRevealCard,
		// Token: 0x040016D7 RID: 5847
		PopRevealCard,
		// Token: 0x040016D8 RID: 5848
		SetRevealCardPlayer,
		// Token: 0x040016D9 RID: 5849
		SetHeadlineCardRevealed,
		// Token: 0x040016DA RID: 5850
		LoadProgress,
		// Token: 0x040016DB RID: 5851
		CommitPlayerDecision,
		// Token: 0x040016DC RID: 5852
		Achievement,
		// Token: 0x040016DD RID: 5853
		EndTurn,
		// Token: 0x040016DE RID: 5854
		DrawHandAtEndOfTurn,
		// Token: 0x040016DF RID: 5855
		Reshuffle,
		// Token: 0x040016E0 RID: 5856
		PauseForRevealedCards,
		// Token: 0x040016E1 RID: 5857
		EndOfRainbowTray,
		// Token: 0x040016E2 RID: 5858
		DeliriumResult,
		// Token: 0x040016E3 RID: 5859
		LogUpdated = 99,
		// Token: 0x040016E4 RID: 5860
		LogBeginTurn,
		// Token: 0x040016E5 RID: 5861
		LogEndTurn,
		// Token: 0x040016E6 RID: 5862
		LogBeginActionRound,
		// Token: 0x040016E7 RID: 5863
		LogEndActionRound,
		// Token: 0x040016E8 RID: 5864
		LogBeginCardEvent,
		// Token: 0x040016E9 RID: 5865
		LogEndCardEvent,
		// Token: 0x040016EA RID: 5866
		LogBeginOps,
		// Token: 0x040016EB RID: 5867
		LogEndOps,
		// Token: 0x040016EC RID: 5868
		LogInfluenceChange,
		// Token: 0x040016ED RID: 5869
		LogRevealHeadline,
		// Token: 0x040016EE RID: 5870
		LogWarResult = 112,
		// Token: 0x040016EF RID: 5871
		LogSpaceRaceResult = 116,
		// Token: 0x040016F0 RID: 5872
		LogSpaceRaceAdvance,
		// Token: 0x040016F1 RID: 5873
		LogDiscard,
		// Token: 0x040016F2 RID: 5874
		LogCardInPlayStatus,
		// Token: 0x040016F3 RID: 5875
		LogCancelAction,
		// Token: 0x040016F4 RID: 5876
		LogReportSides,
		// Token: 0x040016F5 RID: 5877
		LogRevealCard,
		// Token: 0x040016F6 RID: 5878
		LogPlayAdditionalCard,
		// Token: 0x040016F7 RID: 5879
		LogTrapResult,
		// Token: 0x040016F8 RID: 5880
		LogBiddingResult,
		// Token: 0x040016F9 RID: 5881
		LogGrainSalesResult,
		// Token: 0x040016FA RID: 5882
		LogChernobyl,
		// Token: 0x040016FB RID: 5883
		LogOlympics
	}
}
