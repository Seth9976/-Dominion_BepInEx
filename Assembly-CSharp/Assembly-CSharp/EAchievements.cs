using System;

// Token: 0x02000078 RID: 120
public enum EAchievements
{
	// Token: 0x04000A56 RID: 2646
	NONE = -1,
	// Token: 0x04000A57 RID: 2647
	Win1Game,
	// Token: 0x04000A58 RID: 2648
	Win100Games,
	// Token: 0x04000A59 RID: 2649
	Win1OnlineGame,
	// Token: 0x04000A5A RID: 2650
	ClaimAllCardsInCOTG,
	// Token: 0x04000A5B RID: 2651
	ClaimAllCardsInROTF,
	// Token: 0x04000A5C RID: 2652
	ClaimAllCardsInSOS,
	// Token: 0x04000A5D RID: 2653
	Win10GamesInARow,
	// Token: 0x04000A5E RID: 2654
	Win10GamesNoCultistKill,
	// Token: 0x04000A5F RID: 2655
	DefeatXeronIn4PlayerGame,
	// Token: 0x04000A60 RID: 2656
	AcquireHedronAfterAvatarDefeat,
	// Token: 0x04000A61 RID: 2657
	DefeatSamaelAndAvatarInSameTurn,
	// Token: 0x04000A62 RID: 2658
	DefeatSamaelWithAdayu,
	// Token: 0x04000A63 RID: 2659
	GetDreamMachineWithPrime,
	// Token: 0x04000A64 RID: 2660
	UmbralPenumbralEdgeInPlay,
	// Token: 0x04000A65 RID: 2661
	Win10OnlineGamesInARow,
	// Token: 0x04000A66 RID: 2662
	Kill1000Cultists,
	// Token: 0x04000A67 RID: 2663
	Get1000CenterRowHeroes,
	// Token: 0x04000A68 RID: 2664
	Play1000Constructs,
	// Token: 0x04000A69 RID: 2665
	Kill1000Monsters,
	// Token: 0x04000A6A RID: 2666
	Gain9001Honor,
	// Token: 0x04000A6B RID: 2667
	HaveAllCOTGConstructsInPlay,
	// Token: 0x04000A6C RID: 2668
	ROTF5TurnsInARow,
	// Token: 0x04000A6D RID: 2669
	AllSOSTrophyMonstersInPlay,
	// Token: 0x04000A6E RID: 2670
	COTG5TurnsInARow,
	// Token: 0x04000A6F RID: 2671
	CaptureAllROTFMonstersWithSamael,
	// Token: 0x04000A70 RID: 2672
	Play5LifeboundIn1Turn,
	// Token: 0x04000A71 RID: 2673
	Defeat5Growmites,
	// Token: 0x04000A72 RID: 2674
	Gain5HonorFromBeastStaff,
	// Token: 0x04000A73 RID: 2675
	UseEverySoulGem,
	// Token: 0x04000A74 RID: 2676
	Play5SoulGemsIn1Turn,
	// Token: 0x04000A75 RID: 2677
	TakeExtraTurnWithWanderingAskara,
	// Token: 0x04000A76 RID: 2678
	Get5TreasureIn1Turn,
	// Token: 0x04000A77 RID: 2679
	Get10EnergyIn1Turn,
	// Token: 0x04000A78 RID: 2680
	DefeatAndEnergizeHarbingerOfDoom,
	// Token: 0x04000A79 RID: 2681
	Defeat5MonstersWithOziah,
	// Token: 0x04000A7A RID: 2682
	AcquireOziahWithEnergyForFree,
	// Token: 0x04000A7B RID: 2683
	TransformAllDUCards,
	// Token: 0x04000A7C RID: 2684
	UseYolocrixDiscardAbility,
	// Token: 0x04000A7D RID: 2685
	EndWithMokenAnd10Treasures,
	// Token: 0x04000A7E RID: 2686
	Get20HonorWithJakeb,
	// Token: 0x04000A7F RID: 2687
	UniteAdayuWithAllFourFactions,
	// Token: 0x04000A80 RID: 2688
	WinWith2FactionsInDeck,
	// Token: 0x04000A81 RID: 2689
	Acquire7HeroesIn1Turn,
	// Token: 0x04000A82 RID: 2690
	DefeatAdayuWithCanonTemplar,
	// Token: 0x04000A83 RID: 2691
	MultiUnite1Card3Times,
	// Token: 0x04000A84 RID: 2692
	RallyWithEachFaction,
	// Token: 0x04000A85 RID: 2693
	DefeatMonsterWithEmrisSting,
	// Token: 0x04000A86 RID: 2694
	DefeatAranyxAndXeronIn1Turn,
	// Token: 0x04000A87 RID: 2695
	PlayThreeCannonsIn1Turn,
	// Token: 0x04000A88 RID: 2696
	WinAsEachChampion,
	// Token: 0x04000A89 RID: 2697
	AcquireAllVisions,
	// Token: 0x04000A8A RID: 2698
	Acquire2VisionsForFreeIn1Game,
	// Token: 0x04000A8B RID: 2699
	UseWickedEndOnEnderOfDays,
	// Token: 0x04000A8C RID: 2700
	UsePasytheasWardOnPasythea,
	// Token: 0x04000A8D RID: 2701
	AcquireAllDreambornCards,
	// Token: 0x04000A8E RID: 2702
	Gain20HonorFrom1NonMonster,
	// Token: 0x04000A8F RID: 2703
	GetDayAndNightBonusIn1Turn,
	// Token: 0x04000A90 RID: 2704
	PlayBothTrackersIn1Turn,
	// Token: 0x04000A91 RID: 2705
	PlayDeadeyeWith10Discards,
	// Token: 0x04000A92 RID: 2706
	WinWithOnlyNightCards,
	// Token: 0x04000A93 RID: 2707
	WinWithOnlyDayCards,
	// Token: 0x04000A94 RID: 2708
	AcquireAllGoteEvents,
	// Token: 0x04000A95 RID: 2709
	WinViaPrimeDirective,
	// Token: 0x04000A96 RID: 2710
	WinWithNoInfestInDeck,
	// Token: 0x04000A97 RID: 2711
	DefeatAllInfestIn1Game,
	// Token: 0x04000A98 RID: 2712
	WinWith5OrLessCardsInDeck,
	// Token: 0x04000A99 RID: 2713
	TriggerSerenityAndEchoInOneTurn,
	// Token: 0x04000A9A RID: 2714
	WinVotaWithoutAcquiringAnyTemples,
	// Token: 0x04000A9B RID: 2715
	DefeatFiveHellfrostImpsInOneTurn,
	// Token: 0x04000A9C RID: 2716
	StealAllTemplesOnLastTurnAndWin,
	// Token: 0x04000A9D RID: 2717
	MagnifyBrotherMarius,
	// Token: 0x04000A9E RID: 2718
	JubliantMonkEntireDeck,
	// Token: 0x04000A9F RID: 2719
	Roll3DeliriumSixesIn1Game,
	// Token: 0x04000AA0 RID: 2720
	Draw7CardsWithMechamonkIn1Turn,
	// Token: 0x04000AA1 RID: 2721
	RecurAllDeliriumCards,
	// Token: 0x04000AA2 RID: 2722
	Win2FateAuctionsIn1Turn,
	// Token: 0x04000AA3 RID: 2723
	TriggerDreamDealerEffect,
	// Token: 0x04000AA4 RID: 2724
	TransformAllDLVCards,
	// Token: 0x04000AA5 RID: 2725
	UsePlunder5TimesInOneGame,
	// Token: 0x04000AA6 RID: 2726
	UsePhantasm5TimesInOneGame,
	// Token: 0x04000AA7 RID: 2727
	AcquirePasytheaRedeemedForFree,
	// Token: 0x04000AA8 RID: 2728
	PlayNakaEmrisChosenAndEmriSoulstealerOnSameTurn,
	// Token: 0x04000AA9 RID: 2729
	DlvEndWithOnlyDreambindCards
}
