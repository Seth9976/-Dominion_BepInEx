using System;

namespace Steamworks
{
	// Token: 0x0200024F RID: 591
	public enum EInputActionOrigin
	{
		// Token: 0x04002175 RID: 8565
		k_EInputActionOrigin_None,
		// Token: 0x04002176 RID: 8566
		k_EInputActionOrigin_SteamController_A,
		// Token: 0x04002177 RID: 8567
		k_EInputActionOrigin_SteamController_B,
		// Token: 0x04002178 RID: 8568
		k_EInputActionOrigin_SteamController_X,
		// Token: 0x04002179 RID: 8569
		k_EInputActionOrigin_SteamController_Y,
		// Token: 0x0400217A RID: 8570
		k_EInputActionOrigin_SteamController_LeftBumper,
		// Token: 0x0400217B RID: 8571
		k_EInputActionOrigin_SteamController_RightBumper,
		// Token: 0x0400217C RID: 8572
		k_EInputActionOrigin_SteamController_LeftGrip,
		// Token: 0x0400217D RID: 8573
		k_EInputActionOrigin_SteamController_RightGrip,
		// Token: 0x0400217E RID: 8574
		k_EInputActionOrigin_SteamController_Start,
		// Token: 0x0400217F RID: 8575
		k_EInputActionOrigin_SteamController_Back,
		// Token: 0x04002180 RID: 8576
		k_EInputActionOrigin_SteamController_LeftPad_Touch,
		// Token: 0x04002181 RID: 8577
		k_EInputActionOrigin_SteamController_LeftPad_Swipe,
		// Token: 0x04002182 RID: 8578
		k_EInputActionOrigin_SteamController_LeftPad_Click,
		// Token: 0x04002183 RID: 8579
		k_EInputActionOrigin_SteamController_LeftPad_DPadNorth,
		// Token: 0x04002184 RID: 8580
		k_EInputActionOrigin_SteamController_LeftPad_DPadSouth,
		// Token: 0x04002185 RID: 8581
		k_EInputActionOrigin_SteamController_LeftPad_DPadWest,
		// Token: 0x04002186 RID: 8582
		k_EInputActionOrigin_SteamController_LeftPad_DPadEast,
		// Token: 0x04002187 RID: 8583
		k_EInputActionOrigin_SteamController_RightPad_Touch,
		// Token: 0x04002188 RID: 8584
		k_EInputActionOrigin_SteamController_RightPad_Swipe,
		// Token: 0x04002189 RID: 8585
		k_EInputActionOrigin_SteamController_RightPad_Click,
		// Token: 0x0400218A RID: 8586
		k_EInputActionOrigin_SteamController_RightPad_DPadNorth,
		// Token: 0x0400218B RID: 8587
		k_EInputActionOrigin_SteamController_RightPad_DPadSouth,
		// Token: 0x0400218C RID: 8588
		k_EInputActionOrigin_SteamController_RightPad_DPadWest,
		// Token: 0x0400218D RID: 8589
		k_EInputActionOrigin_SteamController_RightPad_DPadEast,
		// Token: 0x0400218E RID: 8590
		k_EInputActionOrigin_SteamController_LeftTrigger_Pull,
		// Token: 0x0400218F RID: 8591
		k_EInputActionOrigin_SteamController_LeftTrigger_Click,
		// Token: 0x04002190 RID: 8592
		k_EInputActionOrigin_SteamController_RightTrigger_Pull,
		// Token: 0x04002191 RID: 8593
		k_EInputActionOrigin_SteamController_RightTrigger_Click,
		// Token: 0x04002192 RID: 8594
		k_EInputActionOrigin_SteamController_LeftStick_Move,
		// Token: 0x04002193 RID: 8595
		k_EInputActionOrigin_SteamController_LeftStick_Click,
		// Token: 0x04002194 RID: 8596
		k_EInputActionOrigin_SteamController_LeftStick_DPadNorth,
		// Token: 0x04002195 RID: 8597
		k_EInputActionOrigin_SteamController_LeftStick_DPadSouth,
		// Token: 0x04002196 RID: 8598
		k_EInputActionOrigin_SteamController_LeftStick_DPadWest,
		// Token: 0x04002197 RID: 8599
		k_EInputActionOrigin_SteamController_LeftStick_DPadEast,
		// Token: 0x04002198 RID: 8600
		k_EInputActionOrigin_SteamController_Gyro_Move,
		// Token: 0x04002199 RID: 8601
		k_EInputActionOrigin_SteamController_Gyro_Pitch,
		// Token: 0x0400219A RID: 8602
		k_EInputActionOrigin_SteamController_Gyro_Yaw,
		// Token: 0x0400219B RID: 8603
		k_EInputActionOrigin_SteamController_Gyro_Roll,
		// Token: 0x0400219C RID: 8604
		k_EInputActionOrigin_SteamController_Reserved0,
		// Token: 0x0400219D RID: 8605
		k_EInputActionOrigin_SteamController_Reserved1,
		// Token: 0x0400219E RID: 8606
		k_EInputActionOrigin_SteamController_Reserved2,
		// Token: 0x0400219F RID: 8607
		k_EInputActionOrigin_SteamController_Reserved3,
		// Token: 0x040021A0 RID: 8608
		k_EInputActionOrigin_SteamController_Reserved4,
		// Token: 0x040021A1 RID: 8609
		k_EInputActionOrigin_SteamController_Reserved5,
		// Token: 0x040021A2 RID: 8610
		k_EInputActionOrigin_SteamController_Reserved6,
		// Token: 0x040021A3 RID: 8611
		k_EInputActionOrigin_SteamController_Reserved7,
		// Token: 0x040021A4 RID: 8612
		k_EInputActionOrigin_SteamController_Reserved8,
		// Token: 0x040021A5 RID: 8613
		k_EInputActionOrigin_SteamController_Reserved9,
		// Token: 0x040021A6 RID: 8614
		k_EInputActionOrigin_SteamController_Reserved10,
		// Token: 0x040021A7 RID: 8615
		k_EInputActionOrigin_PS4_X,
		// Token: 0x040021A8 RID: 8616
		k_EInputActionOrigin_PS4_Circle,
		// Token: 0x040021A9 RID: 8617
		k_EInputActionOrigin_PS4_Triangle,
		// Token: 0x040021AA RID: 8618
		k_EInputActionOrigin_PS4_Square,
		// Token: 0x040021AB RID: 8619
		k_EInputActionOrigin_PS4_LeftBumper,
		// Token: 0x040021AC RID: 8620
		k_EInputActionOrigin_PS4_RightBumper,
		// Token: 0x040021AD RID: 8621
		k_EInputActionOrigin_PS4_Options,
		// Token: 0x040021AE RID: 8622
		k_EInputActionOrigin_PS4_Share,
		// Token: 0x040021AF RID: 8623
		k_EInputActionOrigin_PS4_LeftPad_Touch,
		// Token: 0x040021B0 RID: 8624
		k_EInputActionOrigin_PS4_LeftPad_Swipe,
		// Token: 0x040021B1 RID: 8625
		k_EInputActionOrigin_PS4_LeftPad_Click,
		// Token: 0x040021B2 RID: 8626
		k_EInputActionOrigin_PS4_LeftPad_DPadNorth,
		// Token: 0x040021B3 RID: 8627
		k_EInputActionOrigin_PS4_LeftPad_DPadSouth,
		// Token: 0x040021B4 RID: 8628
		k_EInputActionOrigin_PS4_LeftPad_DPadWest,
		// Token: 0x040021B5 RID: 8629
		k_EInputActionOrigin_PS4_LeftPad_DPadEast,
		// Token: 0x040021B6 RID: 8630
		k_EInputActionOrigin_PS4_RightPad_Touch,
		// Token: 0x040021B7 RID: 8631
		k_EInputActionOrigin_PS4_RightPad_Swipe,
		// Token: 0x040021B8 RID: 8632
		k_EInputActionOrigin_PS4_RightPad_Click,
		// Token: 0x040021B9 RID: 8633
		k_EInputActionOrigin_PS4_RightPad_DPadNorth,
		// Token: 0x040021BA RID: 8634
		k_EInputActionOrigin_PS4_RightPad_DPadSouth,
		// Token: 0x040021BB RID: 8635
		k_EInputActionOrigin_PS4_RightPad_DPadWest,
		// Token: 0x040021BC RID: 8636
		k_EInputActionOrigin_PS4_RightPad_DPadEast,
		// Token: 0x040021BD RID: 8637
		k_EInputActionOrigin_PS4_CenterPad_Touch,
		// Token: 0x040021BE RID: 8638
		k_EInputActionOrigin_PS4_CenterPad_Swipe,
		// Token: 0x040021BF RID: 8639
		k_EInputActionOrigin_PS4_CenterPad_Click,
		// Token: 0x040021C0 RID: 8640
		k_EInputActionOrigin_PS4_CenterPad_DPadNorth,
		// Token: 0x040021C1 RID: 8641
		k_EInputActionOrigin_PS4_CenterPad_DPadSouth,
		// Token: 0x040021C2 RID: 8642
		k_EInputActionOrigin_PS4_CenterPad_DPadWest,
		// Token: 0x040021C3 RID: 8643
		k_EInputActionOrigin_PS4_CenterPad_DPadEast,
		// Token: 0x040021C4 RID: 8644
		k_EInputActionOrigin_PS4_LeftTrigger_Pull,
		// Token: 0x040021C5 RID: 8645
		k_EInputActionOrigin_PS4_LeftTrigger_Click,
		// Token: 0x040021C6 RID: 8646
		k_EInputActionOrigin_PS4_RightTrigger_Pull,
		// Token: 0x040021C7 RID: 8647
		k_EInputActionOrigin_PS4_RightTrigger_Click,
		// Token: 0x040021C8 RID: 8648
		k_EInputActionOrigin_PS4_LeftStick_Move,
		// Token: 0x040021C9 RID: 8649
		k_EInputActionOrigin_PS4_LeftStick_Click,
		// Token: 0x040021CA RID: 8650
		k_EInputActionOrigin_PS4_LeftStick_DPadNorth,
		// Token: 0x040021CB RID: 8651
		k_EInputActionOrigin_PS4_LeftStick_DPadSouth,
		// Token: 0x040021CC RID: 8652
		k_EInputActionOrigin_PS4_LeftStick_DPadWest,
		// Token: 0x040021CD RID: 8653
		k_EInputActionOrigin_PS4_LeftStick_DPadEast,
		// Token: 0x040021CE RID: 8654
		k_EInputActionOrigin_PS4_RightStick_Move,
		// Token: 0x040021CF RID: 8655
		k_EInputActionOrigin_PS4_RightStick_Click,
		// Token: 0x040021D0 RID: 8656
		k_EInputActionOrigin_PS4_RightStick_DPadNorth,
		// Token: 0x040021D1 RID: 8657
		k_EInputActionOrigin_PS4_RightStick_DPadSouth,
		// Token: 0x040021D2 RID: 8658
		k_EInputActionOrigin_PS4_RightStick_DPadWest,
		// Token: 0x040021D3 RID: 8659
		k_EInputActionOrigin_PS4_RightStick_DPadEast,
		// Token: 0x040021D4 RID: 8660
		k_EInputActionOrigin_PS4_DPad_North,
		// Token: 0x040021D5 RID: 8661
		k_EInputActionOrigin_PS4_DPad_South,
		// Token: 0x040021D6 RID: 8662
		k_EInputActionOrigin_PS4_DPad_West,
		// Token: 0x040021D7 RID: 8663
		k_EInputActionOrigin_PS4_DPad_East,
		// Token: 0x040021D8 RID: 8664
		k_EInputActionOrigin_PS4_Gyro_Move,
		// Token: 0x040021D9 RID: 8665
		k_EInputActionOrigin_PS4_Gyro_Pitch,
		// Token: 0x040021DA RID: 8666
		k_EInputActionOrigin_PS4_Gyro_Yaw,
		// Token: 0x040021DB RID: 8667
		k_EInputActionOrigin_PS4_Gyro_Roll,
		// Token: 0x040021DC RID: 8668
		k_EInputActionOrigin_PS4_DPad_Move,
		// Token: 0x040021DD RID: 8669
		k_EInputActionOrigin_PS4_Reserved1,
		// Token: 0x040021DE RID: 8670
		k_EInputActionOrigin_PS4_Reserved2,
		// Token: 0x040021DF RID: 8671
		k_EInputActionOrigin_PS4_Reserved3,
		// Token: 0x040021E0 RID: 8672
		k_EInputActionOrigin_PS4_Reserved4,
		// Token: 0x040021E1 RID: 8673
		k_EInputActionOrigin_PS4_Reserved5,
		// Token: 0x040021E2 RID: 8674
		k_EInputActionOrigin_PS4_Reserved6,
		// Token: 0x040021E3 RID: 8675
		k_EInputActionOrigin_PS4_Reserved7,
		// Token: 0x040021E4 RID: 8676
		k_EInputActionOrigin_PS4_Reserved8,
		// Token: 0x040021E5 RID: 8677
		k_EInputActionOrigin_PS4_Reserved9,
		// Token: 0x040021E6 RID: 8678
		k_EInputActionOrigin_PS4_Reserved10,
		// Token: 0x040021E7 RID: 8679
		k_EInputActionOrigin_XBoxOne_A,
		// Token: 0x040021E8 RID: 8680
		k_EInputActionOrigin_XBoxOne_B,
		// Token: 0x040021E9 RID: 8681
		k_EInputActionOrigin_XBoxOne_X,
		// Token: 0x040021EA RID: 8682
		k_EInputActionOrigin_XBoxOne_Y,
		// Token: 0x040021EB RID: 8683
		k_EInputActionOrigin_XBoxOne_LeftBumper,
		// Token: 0x040021EC RID: 8684
		k_EInputActionOrigin_XBoxOne_RightBumper,
		// Token: 0x040021ED RID: 8685
		k_EInputActionOrigin_XBoxOne_Menu,
		// Token: 0x040021EE RID: 8686
		k_EInputActionOrigin_XBoxOne_View,
		// Token: 0x040021EF RID: 8687
		k_EInputActionOrigin_XBoxOne_LeftTrigger_Pull,
		// Token: 0x040021F0 RID: 8688
		k_EInputActionOrigin_XBoxOne_LeftTrigger_Click,
		// Token: 0x040021F1 RID: 8689
		k_EInputActionOrigin_XBoxOne_RightTrigger_Pull,
		// Token: 0x040021F2 RID: 8690
		k_EInputActionOrigin_XBoxOne_RightTrigger_Click,
		// Token: 0x040021F3 RID: 8691
		k_EInputActionOrigin_XBoxOne_LeftStick_Move,
		// Token: 0x040021F4 RID: 8692
		k_EInputActionOrigin_XBoxOne_LeftStick_Click,
		// Token: 0x040021F5 RID: 8693
		k_EInputActionOrigin_XBoxOne_LeftStick_DPadNorth,
		// Token: 0x040021F6 RID: 8694
		k_EInputActionOrigin_XBoxOne_LeftStick_DPadSouth,
		// Token: 0x040021F7 RID: 8695
		k_EInputActionOrigin_XBoxOne_LeftStick_DPadWest,
		// Token: 0x040021F8 RID: 8696
		k_EInputActionOrigin_XBoxOne_LeftStick_DPadEast,
		// Token: 0x040021F9 RID: 8697
		k_EInputActionOrigin_XBoxOne_RightStick_Move,
		// Token: 0x040021FA RID: 8698
		k_EInputActionOrigin_XBoxOne_RightStick_Click,
		// Token: 0x040021FB RID: 8699
		k_EInputActionOrigin_XBoxOne_RightStick_DPadNorth,
		// Token: 0x040021FC RID: 8700
		k_EInputActionOrigin_XBoxOne_RightStick_DPadSouth,
		// Token: 0x040021FD RID: 8701
		k_EInputActionOrigin_XBoxOne_RightStick_DPadWest,
		// Token: 0x040021FE RID: 8702
		k_EInputActionOrigin_XBoxOne_RightStick_DPadEast,
		// Token: 0x040021FF RID: 8703
		k_EInputActionOrigin_XBoxOne_DPad_North,
		// Token: 0x04002200 RID: 8704
		k_EInputActionOrigin_XBoxOne_DPad_South,
		// Token: 0x04002201 RID: 8705
		k_EInputActionOrigin_XBoxOne_DPad_West,
		// Token: 0x04002202 RID: 8706
		k_EInputActionOrigin_XBoxOne_DPad_East,
		// Token: 0x04002203 RID: 8707
		k_EInputActionOrigin_XBoxOne_DPad_Move,
		// Token: 0x04002204 RID: 8708
		k_EInputActionOrigin_XBoxOne_Reserved1,
		// Token: 0x04002205 RID: 8709
		k_EInputActionOrigin_XBoxOne_Reserved2,
		// Token: 0x04002206 RID: 8710
		k_EInputActionOrigin_XBoxOne_Reserved3,
		// Token: 0x04002207 RID: 8711
		k_EInputActionOrigin_XBoxOne_Reserved4,
		// Token: 0x04002208 RID: 8712
		k_EInputActionOrigin_XBoxOne_Reserved5,
		// Token: 0x04002209 RID: 8713
		k_EInputActionOrigin_XBoxOne_Reserved6,
		// Token: 0x0400220A RID: 8714
		k_EInputActionOrigin_XBoxOne_Reserved7,
		// Token: 0x0400220B RID: 8715
		k_EInputActionOrigin_XBoxOne_Reserved8,
		// Token: 0x0400220C RID: 8716
		k_EInputActionOrigin_XBoxOne_Reserved9,
		// Token: 0x0400220D RID: 8717
		k_EInputActionOrigin_XBoxOne_Reserved10,
		// Token: 0x0400220E RID: 8718
		k_EInputActionOrigin_XBox360_A,
		// Token: 0x0400220F RID: 8719
		k_EInputActionOrigin_XBox360_B,
		// Token: 0x04002210 RID: 8720
		k_EInputActionOrigin_XBox360_X,
		// Token: 0x04002211 RID: 8721
		k_EInputActionOrigin_XBox360_Y,
		// Token: 0x04002212 RID: 8722
		k_EInputActionOrigin_XBox360_LeftBumper,
		// Token: 0x04002213 RID: 8723
		k_EInputActionOrigin_XBox360_RightBumper,
		// Token: 0x04002214 RID: 8724
		k_EInputActionOrigin_XBox360_Start,
		// Token: 0x04002215 RID: 8725
		k_EInputActionOrigin_XBox360_Back,
		// Token: 0x04002216 RID: 8726
		k_EInputActionOrigin_XBox360_LeftTrigger_Pull,
		// Token: 0x04002217 RID: 8727
		k_EInputActionOrigin_XBox360_LeftTrigger_Click,
		// Token: 0x04002218 RID: 8728
		k_EInputActionOrigin_XBox360_RightTrigger_Pull,
		// Token: 0x04002219 RID: 8729
		k_EInputActionOrigin_XBox360_RightTrigger_Click,
		// Token: 0x0400221A RID: 8730
		k_EInputActionOrigin_XBox360_LeftStick_Move,
		// Token: 0x0400221B RID: 8731
		k_EInputActionOrigin_XBox360_LeftStick_Click,
		// Token: 0x0400221C RID: 8732
		k_EInputActionOrigin_XBox360_LeftStick_DPadNorth,
		// Token: 0x0400221D RID: 8733
		k_EInputActionOrigin_XBox360_LeftStick_DPadSouth,
		// Token: 0x0400221E RID: 8734
		k_EInputActionOrigin_XBox360_LeftStick_DPadWest,
		// Token: 0x0400221F RID: 8735
		k_EInputActionOrigin_XBox360_LeftStick_DPadEast,
		// Token: 0x04002220 RID: 8736
		k_EInputActionOrigin_XBox360_RightStick_Move,
		// Token: 0x04002221 RID: 8737
		k_EInputActionOrigin_XBox360_RightStick_Click,
		// Token: 0x04002222 RID: 8738
		k_EInputActionOrigin_XBox360_RightStick_DPadNorth,
		// Token: 0x04002223 RID: 8739
		k_EInputActionOrigin_XBox360_RightStick_DPadSouth,
		// Token: 0x04002224 RID: 8740
		k_EInputActionOrigin_XBox360_RightStick_DPadWest,
		// Token: 0x04002225 RID: 8741
		k_EInputActionOrigin_XBox360_RightStick_DPadEast,
		// Token: 0x04002226 RID: 8742
		k_EInputActionOrigin_XBox360_DPad_North,
		// Token: 0x04002227 RID: 8743
		k_EInputActionOrigin_XBox360_DPad_South,
		// Token: 0x04002228 RID: 8744
		k_EInputActionOrigin_XBox360_DPad_West,
		// Token: 0x04002229 RID: 8745
		k_EInputActionOrigin_XBox360_DPad_East,
		// Token: 0x0400222A RID: 8746
		k_EInputActionOrigin_XBox360_DPad_Move,
		// Token: 0x0400222B RID: 8747
		k_EInputActionOrigin_XBox360_Reserved1,
		// Token: 0x0400222C RID: 8748
		k_EInputActionOrigin_XBox360_Reserved2,
		// Token: 0x0400222D RID: 8749
		k_EInputActionOrigin_XBox360_Reserved3,
		// Token: 0x0400222E RID: 8750
		k_EInputActionOrigin_XBox360_Reserved4,
		// Token: 0x0400222F RID: 8751
		k_EInputActionOrigin_XBox360_Reserved5,
		// Token: 0x04002230 RID: 8752
		k_EInputActionOrigin_XBox360_Reserved6,
		// Token: 0x04002231 RID: 8753
		k_EInputActionOrigin_XBox360_Reserved7,
		// Token: 0x04002232 RID: 8754
		k_EInputActionOrigin_XBox360_Reserved8,
		// Token: 0x04002233 RID: 8755
		k_EInputActionOrigin_XBox360_Reserved9,
		// Token: 0x04002234 RID: 8756
		k_EInputActionOrigin_XBox360_Reserved10,
		// Token: 0x04002235 RID: 8757
		k_EInputActionOrigin_Switch_A,
		// Token: 0x04002236 RID: 8758
		k_EInputActionOrigin_Switch_B,
		// Token: 0x04002237 RID: 8759
		k_EInputActionOrigin_Switch_X,
		// Token: 0x04002238 RID: 8760
		k_EInputActionOrigin_Switch_Y,
		// Token: 0x04002239 RID: 8761
		k_EInputActionOrigin_Switch_LeftBumper,
		// Token: 0x0400223A RID: 8762
		k_EInputActionOrigin_Switch_RightBumper,
		// Token: 0x0400223B RID: 8763
		k_EInputActionOrigin_Switch_Plus,
		// Token: 0x0400223C RID: 8764
		k_EInputActionOrigin_Switch_Minus,
		// Token: 0x0400223D RID: 8765
		k_EInputActionOrigin_Switch_Capture,
		// Token: 0x0400223E RID: 8766
		k_EInputActionOrigin_Switch_LeftTrigger_Pull,
		// Token: 0x0400223F RID: 8767
		k_EInputActionOrigin_Switch_LeftTrigger_Click,
		// Token: 0x04002240 RID: 8768
		k_EInputActionOrigin_Switch_RightTrigger_Pull,
		// Token: 0x04002241 RID: 8769
		k_EInputActionOrigin_Switch_RightTrigger_Click,
		// Token: 0x04002242 RID: 8770
		k_EInputActionOrigin_Switch_LeftStick_Move,
		// Token: 0x04002243 RID: 8771
		k_EInputActionOrigin_Switch_LeftStick_Click,
		// Token: 0x04002244 RID: 8772
		k_EInputActionOrigin_Switch_LeftStick_DPadNorth,
		// Token: 0x04002245 RID: 8773
		k_EInputActionOrigin_Switch_LeftStick_DPadSouth,
		// Token: 0x04002246 RID: 8774
		k_EInputActionOrigin_Switch_LeftStick_DPadWest,
		// Token: 0x04002247 RID: 8775
		k_EInputActionOrigin_Switch_LeftStick_DPadEast,
		// Token: 0x04002248 RID: 8776
		k_EInputActionOrigin_Switch_RightStick_Move,
		// Token: 0x04002249 RID: 8777
		k_EInputActionOrigin_Switch_RightStick_Click,
		// Token: 0x0400224A RID: 8778
		k_EInputActionOrigin_Switch_RightStick_DPadNorth,
		// Token: 0x0400224B RID: 8779
		k_EInputActionOrigin_Switch_RightStick_DPadSouth,
		// Token: 0x0400224C RID: 8780
		k_EInputActionOrigin_Switch_RightStick_DPadWest,
		// Token: 0x0400224D RID: 8781
		k_EInputActionOrigin_Switch_RightStick_DPadEast,
		// Token: 0x0400224E RID: 8782
		k_EInputActionOrigin_Switch_DPad_North,
		// Token: 0x0400224F RID: 8783
		k_EInputActionOrigin_Switch_DPad_South,
		// Token: 0x04002250 RID: 8784
		k_EInputActionOrigin_Switch_DPad_West,
		// Token: 0x04002251 RID: 8785
		k_EInputActionOrigin_Switch_DPad_East,
		// Token: 0x04002252 RID: 8786
		k_EInputActionOrigin_Switch_ProGyro_Move,
		// Token: 0x04002253 RID: 8787
		k_EInputActionOrigin_Switch_ProGyro_Pitch,
		// Token: 0x04002254 RID: 8788
		k_EInputActionOrigin_Switch_ProGyro_Yaw,
		// Token: 0x04002255 RID: 8789
		k_EInputActionOrigin_Switch_ProGyro_Roll,
		// Token: 0x04002256 RID: 8790
		k_EInputActionOrigin_Switch_DPad_Move,
		// Token: 0x04002257 RID: 8791
		k_EInputActionOrigin_Switch_Reserved1,
		// Token: 0x04002258 RID: 8792
		k_EInputActionOrigin_Switch_Reserved2,
		// Token: 0x04002259 RID: 8793
		k_EInputActionOrigin_Switch_Reserved3,
		// Token: 0x0400225A RID: 8794
		k_EInputActionOrigin_Switch_Reserved4,
		// Token: 0x0400225B RID: 8795
		k_EInputActionOrigin_Switch_Reserved5,
		// Token: 0x0400225C RID: 8796
		k_EInputActionOrigin_Switch_Reserved6,
		// Token: 0x0400225D RID: 8797
		k_EInputActionOrigin_Switch_Reserved7,
		// Token: 0x0400225E RID: 8798
		k_EInputActionOrigin_Switch_Reserved8,
		// Token: 0x0400225F RID: 8799
		k_EInputActionOrigin_Switch_Reserved9,
		// Token: 0x04002260 RID: 8800
		k_EInputActionOrigin_Switch_Reserved10,
		// Token: 0x04002261 RID: 8801
		k_EInputActionOrigin_Switch_RightGyro_Move,
		// Token: 0x04002262 RID: 8802
		k_EInputActionOrigin_Switch_RightGyro_Pitch,
		// Token: 0x04002263 RID: 8803
		k_EInputActionOrigin_Switch_RightGyro_Yaw,
		// Token: 0x04002264 RID: 8804
		k_EInputActionOrigin_Switch_RightGyro_Roll,
		// Token: 0x04002265 RID: 8805
		k_EInputActionOrigin_Switch_LeftGyro_Move,
		// Token: 0x04002266 RID: 8806
		k_EInputActionOrigin_Switch_LeftGyro_Pitch,
		// Token: 0x04002267 RID: 8807
		k_EInputActionOrigin_Switch_LeftGyro_Yaw,
		// Token: 0x04002268 RID: 8808
		k_EInputActionOrigin_Switch_LeftGyro_Roll,
		// Token: 0x04002269 RID: 8809
		k_EInputActionOrigin_Switch_LeftGrip_Lower,
		// Token: 0x0400226A RID: 8810
		k_EInputActionOrigin_Switch_LeftGrip_Upper,
		// Token: 0x0400226B RID: 8811
		k_EInputActionOrigin_Switch_RightGrip_Lower,
		// Token: 0x0400226C RID: 8812
		k_EInputActionOrigin_Switch_RightGrip_Upper,
		// Token: 0x0400226D RID: 8813
		k_EInputActionOrigin_Switch_Reserved11,
		// Token: 0x0400226E RID: 8814
		k_EInputActionOrigin_Switch_Reserved12,
		// Token: 0x0400226F RID: 8815
		k_EInputActionOrigin_Switch_Reserved13,
		// Token: 0x04002270 RID: 8816
		k_EInputActionOrigin_Switch_Reserved14,
		// Token: 0x04002271 RID: 8817
		k_EInputActionOrigin_Switch_Reserved15,
		// Token: 0x04002272 RID: 8818
		k_EInputActionOrigin_Switch_Reserved16,
		// Token: 0x04002273 RID: 8819
		k_EInputActionOrigin_Switch_Reserved17,
		// Token: 0x04002274 RID: 8820
		k_EInputActionOrigin_Switch_Reserved18,
		// Token: 0x04002275 RID: 8821
		k_EInputActionOrigin_Switch_Reserved19,
		// Token: 0x04002276 RID: 8822
		k_EInputActionOrigin_Switch_Reserved20,
		// Token: 0x04002277 RID: 8823
		k_EInputActionOrigin_Count,
		// Token: 0x04002278 RID: 8824
		k_EInputActionOrigin_MaximumPossibleValue = 32767
	}
}
