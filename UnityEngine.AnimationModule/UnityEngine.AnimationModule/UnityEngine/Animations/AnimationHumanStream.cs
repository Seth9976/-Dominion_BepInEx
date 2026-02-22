using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations
{
	// Token: 0x02000016 RID: 22
	[StructLayout(2)]
	public struct AnimationHumanStream
	{
		// Token: 0x06000226 RID: 550 RVA: 0x00009510 File Offset: 0x00007710
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationHumanStream()
		{
			Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationHumanStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr);
			AnimationHumanStream.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, "stream");
			AnimationHumanStream.GetHumanScale_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.GetHumanScale_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::GetHumanScale_Injected");
			AnimationHumanStream.GetFootHeight_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.GetFootHeight_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::GetFootHeight_Injected");
			AnimationHumanStream.InternalResetToStancePose_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalResetToStancePose_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalResetToStancePose_Injected");
			AnimationHumanStream.InternalGetGoalPositionFromPose_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetGoalPositionFromPose_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetGoalPositionFromPose_Injected");
			AnimationHumanStream.InternalGetGoalRotationFromPose_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetGoalRotationFromPose_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetGoalRotationFromPose_Injected");
			AnimationHumanStream.InternalGetBodyLocalPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetBodyLocalPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetBodyLocalPosition_Injected");
			AnimationHumanStream.InternalSetBodyLocalPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetBodyLocalPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetBodyLocalPosition_Injected");
			AnimationHumanStream.InternalGetBodyLocalRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetBodyLocalRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetBodyLocalRotation_Injected");
			AnimationHumanStream.InternalSetBodyLocalRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetBodyLocalRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetBodyLocalRotation_Injected");
			AnimationHumanStream.InternalGetBodyPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetBodyPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetBodyPosition_Injected");
			AnimationHumanStream.InternalSetBodyPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetBodyPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetBodyPosition_Injected");
			AnimationHumanStream.InternalGetBodyRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetBodyRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetBodyRotation_Injected");
			AnimationHumanStream.InternalSetBodyRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetBodyRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetBodyRotation_Injected");
			AnimationHumanStream.GetLeftFootVelocity_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.GetLeftFootVelocity_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::GetLeftFootVelocity_Injected");
			AnimationHumanStream.GetRightFootVelocity_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.GetRightFootVelocity_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::GetRightFootVelocity_Injected");
			AnimationHumanStream.InternalGetGoalLocalPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetGoalLocalPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetGoalLocalPosition_Injected");
			AnimationHumanStream.InternalSetGoalLocalPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetGoalLocalPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetGoalLocalPosition_Injected");
			AnimationHumanStream.InternalGetGoalLocalRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetGoalLocalRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetGoalLocalRotation_Injected");
			AnimationHumanStream.InternalSetGoalLocalRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetGoalLocalRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetGoalLocalRotation_Injected");
			AnimationHumanStream.InternalGetGoalPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetGoalPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetGoalPosition_Injected");
			AnimationHumanStream.InternalSetGoalPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetGoalPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetGoalPosition_Injected");
			AnimationHumanStream.InternalGetGoalRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetGoalRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetGoalRotation_Injected");
			AnimationHumanStream.InternalSetGoalRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetGoalRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetGoalRotation_Injected");
			AnimationHumanStream.InternalSetGoalWeightPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetGoalWeightPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetGoalWeightPosition_Injected");
			AnimationHumanStream.InternalSetGoalWeightRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetGoalWeightRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetGoalWeightRotation_Injected");
			AnimationHumanStream.InternalGetGoalWeightPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetGoalWeightPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetGoalWeightPosition_Injected");
			AnimationHumanStream.InternalGetGoalWeightRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetGoalWeightRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetGoalWeightRotation_Injected");
			AnimationHumanStream.InternalGetHintPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetHintPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetHintPosition_Injected");
			AnimationHumanStream.InternalSetHintPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetHintPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetHintPosition_Injected");
			AnimationHumanStream.InternalSetHintWeightPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetHintWeightPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetHintWeightPosition_Injected");
			AnimationHumanStream.InternalGetHintWeightPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetHintWeightPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetHintWeightPosition_Injected");
			AnimationHumanStream.InternalSetLookAtPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetLookAtPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetLookAtPosition_Injected");
			AnimationHumanStream.InternalSetLookAtClampWeight_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetLookAtClampWeight_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetLookAtClampWeight_Injected");
			AnimationHumanStream.InternalSetLookAtBodyWeight_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetLookAtBodyWeight_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetLookAtBodyWeight_Injected");
			AnimationHumanStream.InternalSetLookAtHeadWeight_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetLookAtHeadWeight_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetLookAtHeadWeight_Injected");
			AnimationHumanStream.InternalSetLookAtEyesWeight_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetLookAtEyesWeight_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetLookAtEyesWeight_Injected");
			AnimationHumanStream.InternalSolveIK_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSolveIK_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSolveIK_Injected");
		}

		// Token: 0x06000227 RID: 551 RVA: 0x000036D0 File Offset: 0x000018D0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, ref this));
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00009780 File Offset: 0x00007980
		public bool isValid
		{
			get
			{
				return this.stream != IntPtr.Zero;
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000097A4 File Offset: 0x000079A4
		public void ThrowIfInvalid()
		{
			bool flag = !this.isValid;
			if (flag)
			{
				throw new InvalidOperationException("The AnimationHumanStream is invalid.");
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600022A RID: 554 RVA: 0x000097CC File Offset: 0x000079CC
		public float humanScale
		{
			get
			{
				this.ThrowIfInvalid();
				return this.GetHumanScale();
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600022B RID: 555 RVA: 0x000097EC File Offset: 0x000079EC
		public float leftFootHeight
		{
			get
			{
				this.ThrowIfInvalid();
				return this.GetFootHeight(true);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600022C RID: 556 RVA: 0x0000980C File Offset: 0x00007A0C
		public float rightFootHeight
		{
			get
			{
				this.ThrowIfInvalid();
				return this.GetFootHeight(false);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0000982C File Offset: 0x00007A2C
		// (set) Token: 0x0600022E RID: 558 RVA: 0x000036E2 File Offset: 0x000018E2
		public Vector3 bodyLocalPosition
		{
			get
			{
				this.ThrowIfInvalid();
				return this.InternalGetBodyLocalPosition();
			}
			set
			{
				this.ThrowIfInvalid();
				this.InternalSetBodyLocalPosition(value);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600022F RID: 559 RVA: 0x0000984C File Offset: 0x00007A4C
		// (set) Token: 0x06000230 RID: 560 RVA: 0x000036F4 File Offset: 0x000018F4
		public Quaternion bodyLocalRotation
		{
			get
			{
				this.ThrowIfInvalid();
				return this.InternalGetBodyLocalRotation();
			}
			set
			{
				this.ThrowIfInvalid();
				this.InternalSetBodyLocalRotation(value);
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000231 RID: 561 RVA: 0x0000986C File Offset: 0x00007A6C
		// (set) Token: 0x06000232 RID: 562 RVA: 0x00003706 File Offset: 0x00001906
		public Vector3 bodyPosition
		{
			get
			{
				this.ThrowIfInvalid();
				return this.InternalGetBodyPosition();
			}
			set
			{
				this.ThrowIfInvalid();
				this.InternalSetBodyPosition(value);
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0000988C File Offset: 0x00007A8C
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00003718 File Offset: 0x00001918
		public Quaternion bodyRotation
		{
			get
			{
				this.ThrowIfInvalid();
				return this.InternalGetBodyRotation();
			}
			set
			{
				this.ThrowIfInvalid();
				this.InternalSetBodyRotation(value);
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000235 RID: 565 RVA: 0x000098AC File Offset: 0x00007AAC
		public Vector3 leftFootVelocity
		{
			get
			{
				this.ThrowIfInvalid();
				return this.GetLeftFootVelocity();
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000236 RID: 566 RVA: 0x000098CC File Offset: 0x00007ACC
		public Vector3 rightFootVelocity
		{
			get
			{
				this.ThrowIfInvalid();
				return this.GetRightFootVelocity();
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000372A File Offset: 0x0000192A
		public void ResetToStancePose()
		{
			this.ThrowIfInvalid();
			this.InternalResetToStancePose();
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000098EC File Offset: 0x00007AEC
		public Vector3 GetGoalPositionFromPose(AvatarIKGoal index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetGoalPositionFromPose(index);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000990C File Offset: 0x00007B0C
		public Quaternion GetGoalRotationFromPose(AvatarIKGoal index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetGoalRotationFromPose(index);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000992C File Offset: 0x00007B2C
		public Vector3 GetGoalLocalPosition(AvatarIKGoal index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetGoalLocalPosition(index);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000373B File Offset: 0x0000193B
		public void SetGoalLocalPosition(AvatarIKGoal index, Vector3 pos)
		{
			this.ThrowIfInvalid();
			this.InternalSetGoalLocalPosition(index, pos);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000994C File Offset: 0x00007B4C
		public Quaternion GetGoalLocalRotation(AvatarIKGoal index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetGoalLocalRotation(index);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000374E File Offset: 0x0000194E
		public void SetGoalLocalRotation(AvatarIKGoal index, Quaternion rot)
		{
			this.ThrowIfInvalid();
			this.InternalSetGoalLocalRotation(index, rot);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000996C File Offset: 0x00007B6C
		public Vector3 GetGoalPosition(AvatarIKGoal index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetGoalPosition(index);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00003761 File Offset: 0x00001961
		public void SetGoalPosition(AvatarIKGoal index, Vector3 pos)
		{
			this.ThrowIfInvalid();
			this.InternalSetGoalPosition(index, pos);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000998C File Offset: 0x00007B8C
		public Quaternion GetGoalRotation(AvatarIKGoal index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetGoalRotation(index);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00003774 File Offset: 0x00001974
		public void SetGoalRotation(AvatarIKGoal index, Quaternion rot)
		{
			this.ThrowIfInvalid();
			this.InternalSetGoalRotation(index, rot);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00003787 File Offset: 0x00001987
		public void SetGoalWeightPosition(AvatarIKGoal index, float value)
		{
			this.ThrowIfInvalid();
			this.InternalSetGoalWeightPosition(index, value);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000379A File Offset: 0x0000199A
		public void SetGoalWeightRotation(AvatarIKGoal index, float value)
		{
			this.ThrowIfInvalid();
			this.InternalSetGoalWeightRotation(index, value);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x000099AC File Offset: 0x00007BAC
		public float GetGoalWeightPosition(AvatarIKGoal index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetGoalWeightPosition(index);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x000099CC File Offset: 0x00007BCC
		public float GetGoalWeightRotation(AvatarIKGoal index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetGoalWeightRotation(index);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000099EC File Offset: 0x00007BEC
		public Vector3 GetHintPosition(AvatarIKHint index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetHintPosition(index);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000037AD File Offset: 0x000019AD
		public void SetHintPosition(AvatarIKHint index, Vector3 pos)
		{
			this.ThrowIfInvalid();
			this.InternalSetHintPosition(index, pos);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000037C0 File Offset: 0x000019C0
		public void SetHintWeightPosition(AvatarIKHint index, float value)
		{
			this.ThrowIfInvalid();
			this.InternalSetHintWeightPosition(index, value);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00009A0C File Offset: 0x00007C0C
		public float GetHintWeightPosition(AvatarIKHint index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetHintWeightPosition(index);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000037D3 File Offset: 0x000019D3
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
			this.ThrowIfInvalid();
			this.InternalSetLookAtPosition(lookAtPosition);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000037E5 File Offset: 0x000019E5
		public void SetLookAtClampWeight(float weight)
		{
			this.ThrowIfInvalid();
			this.InternalSetLookAtClampWeight(weight);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000037F7 File Offset: 0x000019F7
		public void SetLookAtBodyWeight(float weight)
		{
			this.ThrowIfInvalid();
			this.InternalSetLookAtBodyWeight(weight);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00003809 File Offset: 0x00001A09
		public void SetLookAtHeadWeight(float weight)
		{
			this.ThrowIfInvalid();
			this.InternalSetLookAtHeadWeight(weight);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000381B File Offset: 0x00001A1B
		public void SetLookAtEyesWeight(float weight)
		{
			this.ThrowIfInvalid();
			this.InternalSetLookAtEyesWeight(weight);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000382D File Offset: 0x00001A2D
		public void SolveIK()
		{
			this.ThrowIfInvalid();
			this.InternalSolveIK();
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000383E File Offset: 0x00001A3E
		public float GetHumanScale()
		{
			return AnimationHumanStream.GetHumanScale_Injected(ref this);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00003846 File Offset: 0x00001A46
		public float GetFootHeight(bool left)
		{
			return AnimationHumanStream.GetFootHeight_Injected(ref this, left);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000384F File Offset: 0x00001A4F
		public void InternalResetToStancePose()
		{
			AnimationHumanStream.InternalResetToStancePose_Injected(ref this);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00009A2C File Offset: 0x00007C2C
		public Vector3 InternalGetGoalPositionFromPose(AvatarIKGoal index)
		{
			Vector3 vector;
			AnimationHumanStream.InternalGetGoalPositionFromPose_Injected(ref this, index, out vector);
			return vector;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00009A44 File Offset: 0x00007C44
		public Quaternion InternalGetGoalRotationFromPose(AvatarIKGoal index)
		{
			Quaternion quaternion;
			AnimationHumanStream.InternalGetGoalRotationFromPose_Injected(ref this, index, out quaternion);
			return quaternion;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00009A5C File Offset: 0x00007C5C
		public Vector3 InternalGetBodyLocalPosition()
		{
			Vector3 vector;
			AnimationHumanStream.InternalGetBodyLocalPosition_Injected(ref this, out vector);
			return vector;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00003857 File Offset: 0x00001A57
		public void InternalSetBodyLocalPosition(Vector3 value)
		{
			AnimationHumanStream.InternalSetBodyLocalPosition_Injected(ref this, ref value);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00009A74 File Offset: 0x00007C74
		public Quaternion InternalGetBodyLocalRotation()
		{
			Quaternion quaternion;
			AnimationHumanStream.InternalGetBodyLocalRotation_Injected(ref this, out quaternion);
			return quaternion;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00003861 File Offset: 0x00001A61
		public void InternalSetBodyLocalRotation(Quaternion value)
		{
			AnimationHumanStream.InternalSetBodyLocalRotation_Injected(ref this, ref value);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00009A8C File Offset: 0x00007C8C
		public Vector3 InternalGetBodyPosition()
		{
			Vector3 vector;
			AnimationHumanStream.InternalGetBodyPosition_Injected(ref this, out vector);
			return vector;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000386B File Offset: 0x00001A6B
		public void InternalSetBodyPosition(Vector3 value)
		{
			AnimationHumanStream.InternalSetBodyPosition_Injected(ref this, ref value);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00009AA4 File Offset: 0x00007CA4
		public Quaternion InternalGetBodyRotation()
		{
			Quaternion quaternion;
			AnimationHumanStream.InternalGetBodyRotation_Injected(ref this, out quaternion);
			return quaternion;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00003875 File Offset: 0x00001A75
		public void InternalSetBodyRotation(Quaternion value)
		{
			AnimationHumanStream.InternalSetBodyRotation_Injected(ref this, ref value);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00009ABC File Offset: 0x00007CBC
		public Vector3 GetLeftFootVelocity()
		{
			Vector3 vector;
			AnimationHumanStream.GetLeftFootVelocity_Injected(ref this, out vector);
			return vector;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00009AD4 File Offset: 0x00007CD4
		public Vector3 GetRightFootVelocity()
		{
			Vector3 vector;
			AnimationHumanStream.GetRightFootVelocity_Injected(ref this, out vector);
			return vector;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00009AEC File Offset: 0x00007CEC
		public Vector3 InternalGetGoalLocalPosition(AvatarIKGoal index)
		{
			Vector3 vector;
			AnimationHumanStream.InternalGetGoalLocalPosition_Injected(ref this, index, out vector);
			return vector;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000387F File Offset: 0x00001A7F
		public void InternalSetGoalLocalPosition(AvatarIKGoal index, Vector3 pos)
		{
			AnimationHumanStream.InternalSetGoalLocalPosition_Injected(ref this, index, ref pos);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00009B04 File Offset: 0x00007D04
		public Quaternion InternalGetGoalLocalRotation(AvatarIKGoal index)
		{
			Quaternion quaternion;
			AnimationHumanStream.InternalGetGoalLocalRotation_Injected(ref this, index, out quaternion);
			return quaternion;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000388A File Offset: 0x00001A8A
		public void InternalSetGoalLocalRotation(AvatarIKGoal index, Quaternion rot)
		{
			AnimationHumanStream.InternalSetGoalLocalRotation_Injected(ref this, index, ref rot);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00009B1C File Offset: 0x00007D1C
		public Vector3 InternalGetGoalPosition(AvatarIKGoal index)
		{
			Vector3 vector;
			AnimationHumanStream.InternalGetGoalPosition_Injected(ref this, index, out vector);
			return vector;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00003895 File Offset: 0x00001A95
		public void InternalSetGoalPosition(AvatarIKGoal index, Vector3 pos)
		{
			AnimationHumanStream.InternalSetGoalPosition_Injected(ref this, index, ref pos);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00009B34 File Offset: 0x00007D34
		public Quaternion InternalGetGoalRotation(AvatarIKGoal index)
		{
			Quaternion quaternion;
			AnimationHumanStream.InternalGetGoalRotation_Injected(ref this, index, out quaternion);
			return quaternion;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000038A0 File Offset: 0x00001AA0
		public void InternalSetGoalRotation(AvatarIKGoal index, Quaternion rot)
		{
			AnimationHumanStream.InternalSetGoalRotation_Injected(ref this, index, ref rot);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x000038AB File Offset: 0x00001AAB
		public void InternalSetGoalWeightPosition(AvatarIKGoal index, float value)
		{
			AnimationHumanStream.InternalSetGoalWeightPosition_Injected(ref this, index, value);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000038B5 File Offset: 0x00001AB5
		public void InternalSetGoalWeightRotation(AvatarIKGoal index, float value)
		{
			AnimationHumanStream.InternalSetGoalWeightRotation_Injected(ref this, index, value);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x000038BF File Offset: 0x00001ABF
		public float InternalGetGoalWeightPosition(AvatarIKGoal index)
		{
			return AnimationHumanStream.InternalGetGoalWeightPosition_Injected(ref this, index);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000038C8 File Offset: 0x00001AC8
		public float InternalGetGoalWeightRotation(AvatarIKGoal index)
		{
			return AnimationHumanStream.InternalGetGoalWeightRotation_Injected(ref this, index);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00009B4C File Offset: 0x00007D4C
		public Vector3 InternalGetHintPosition(AvatarIKHint index)
		{
			Vector3 vector;
			AnimationHumanStream.InternalGetHintPosition_Injected(ref this, index, out vector);
			return vector;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x000038D1 File Offset: 0x00001AD1
		public void InternalSetHintPosition(AvatarIKHint index, Vector3 pos)
		{
			AnimationHumanStream.InternalSetHintPosition_Injected(ref this, index, ref pos);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x000038DC File Offset: 0x00001ADC
		public void InternalSetHintWeightPosition(AvatarIKHint index, float value)
		{
			AnimationHumanStream.InternalSetHintWeightPosition_Injected(ref this, index, value);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x000038E6 File Offset: 0x00001AE6
		public float InternalGetHintWeightPosition(AvatarIKHint index)
		{
			return AnimationHumanStream.InternalGetHintWeightPosition_Injected(ref this, index);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x000038EF File Offset: 0x00001AEF
		public void InternalSetLookAtPosition(Vector3 lookAtPosition)
		{
			AnimationHumanStream.InternalSetLookAtPosition_Injected(ref this, ref lookAtPosition);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x000038F9 File Offset: 0x00001AF9
		public void InternalSetLookAtClampWeight(float weight)
		{
			AnimationHumanStream.InternalSetLookAtClampWeight_Injected(ref this, weight);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00003902 File Offset: 0x00001B02
		public void InternalSetLookAtBodyWeight(float weight)
		{
			AnimationHumanStream.InternalSetLookAtBodyWeight_Injected(ref this, weight);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000390B File Offset: 0x00001B0B
		public void InternalSetLookAtHeadWeight(float weight)
		{
			AnimationHumanStream.InternalSetLookAtHeadWeight_Injected(ref this, weight);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00003914 File Offset: 0x00001B14
		public void InternalSetLookAtEyesWeight(float weight)
		{
			AnimationHumanStream.InternalSetLookAtEyesWeight_Injected(ref this, weight);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000391D File Offset: 0x00001B1D
		public void InternalSolveIK()
		{
			AnimationHumanStream.InternalSolveIK_Injected(ref this);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00003925 File Offset: 0x00001B25
		public static float GetHumanScale_Injected(ref AnimationHumanStream _unity_self)
		{
			return AnimationHumanStream.GetHumanScale_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00003932 File Offset: 0x00001B32
		public static float GetFootHeight_Injected(ref AnimationHumanStream _unity_self, bool left)
		{
			return AnimationHumanStream.GetFootHeight_InjectedDelegateField(ref _unity_self, left);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00003940 File Offset: 0x00001B40
		public static void InternalResetToStancePose_Injected(ref AnimationHumanStream _unity_self)
		{
			AnimationHumanStream.InternalResetToStancePose_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000394D File Offset: 0x00001B4D
		public static void InternalGetGoalPositionFromPose_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, out Vector3 ret)
		{
			AnimationHumanStream.InternalGetGoalPositionFromPose_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000395C File Offset: 0x00001B5C
		public static void InternalGetGoalRotationFromPose_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, out Quaternion ret)
		{
			AnimationHumanStream.InternalGetGoalRotationFromPose_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000396B File Offset: 0x00001B6B
		public static void InternalGetBodyLocalPosition_Injected(ref AnimationHumanStream _unity_self, out Vector3 ret)
		{
			AnimationHumanStream.InternalGetBodyLocalPosition_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00003979 File Offset: 0x00001B79
		public static void InternalSetBodyLocalPosition_Injected(ref AnimationHumanStream _unity_self, ref Vector3 value)
		{
			AnimationHumanStream.InternalSetBodyLocalPosition_InjectedDelegateField(ref _unity_self, ref value);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00003987 File Offset: 0x00001B87
		public static void InternalGetBodyLocalRotation_Injected(ref AnimationHumanStream _unity_self, out Quaternion ret)
		{
			AnimationHumanStream.InternalGetBodyLocalRotation_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00003995 File Offset: 0x00001B95
		public static void InternalSetBodyLocalRotation_Injected(ref AnimationHumanStream _unity_self, ref Quaternion value)
		{
			AnimationHumanStream.InternalSetBodyLocalRotation_InjectedDelegateField(ref _unity_self, ref value);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x000039A3 File Offset: 0x00001BA3
		public static void InternalGetBodyPosition_Injected(ref AnimationHumanStream _unity_self, out Vector3 ret)
		{
			AnimationHumanStream.InternalGetBodyPosition_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x000039B1 File Offset: 0x00001BB1
		public static void InternalSetBodyPosition_Injected(ref AnimationHumanStream _unity_self, ref Vector3 value)
		{
			AnimationHumanStream.InternalSetBodyPosition_InjectedDelegateField(ref _unity_self, ref value);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x000039BF File Offset: 0x00001BBF
		public static void InternalGetBodyRotation_Injected(ref AnimationHumanStream _unity_self, out Quaternion ret)
		{
			AnimationHumanStream.InternalGetBodyRotation_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000039CD File Offset: 0x00001BCD
		public static void InternalSetBodyRotation_Injected(ref AnimationHumanStream _unity_self, ref Quaternion value)
		{
			AnimationHumanStream.InternalSetBodyRotation_InjectedDelegateField(ref _unity_self, ref value);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000039DB File Offset: 0x00001BDB
		public static void GetLeftFootVelocity_Injected(ref AnimationHumanStream _unity_self, out Vector3 ret)
		{
			AnimationHumanStream.GetLeftFootVelocity_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x000039E9 File Offset: 0x00001BE9
		public static void GetRightFootVelocity_Injected(ref AnimationHumanStream _unity_self, out Vector3 ret)
		{
			AnimationHumanStream.GetRightFootVelocity_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000039F7 File Offset: 0x00001BF7
		public static void InternalGetGoalLocalPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, out Vector3 ret)
		{
			AnimationHumanStream.InternalGetGoalLocalPosition_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00003A06 File Offset: 0x00001C06
		public static void InternalSetGoalLocalPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, ref Vector3 pos)
		{
			AnimationHumanStream.InternalSetGoalLocalPosition_InjectedDelegateField(ref _unity_self, index, ref pos);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00003A15 File Offset: 0x00001C15
		public static void InternalGetGoalLocalRotation_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, out Quaternion ret)
		{
			AnimationHumanStream.InternalGetGoalLocalRotation_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00003A24 File Offset: 0x00001C24
		public static void InternalSetGoalLocalRotation_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, ref Quaternion rot)
		{
			AnimationHumanStream.InternalSetGoalLocalRotation_InjectedDelegateField(ref _unity_self, index, ref rot);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00003A33 File Offset: 0x00001C33
		public static void InternalGetGoalPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, out Vector3 ret)
		{
			AnimationHumanStream.InternalGetGoalPosition_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00003A42 File Offset: 0x00001C42
		public static void InternalSetGoalPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, ref Vector3 pos)
		{
			AnimationHumanStream.InternalSetGoalPosition_InjectedDelegateField(ref _unity_self, index, ref pos);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00003A51 File Offset: 0x00001C51
		public static void InternalGetGoalRotation_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, out Quaternion ret)
		{
			AnimationHumanStream.InternalGetGoalRotation_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00003A60 File Offset: 0x00001C60
		public static void InternalSetGoalRotation_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, ref Quaternion rot)
		{
			AnimationHumanStream.InternalSetGoalRotation_InjectedDelegateField(ref _unity_self, index, ref rot);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00003A6F File Offset: 0x00001C6F
		public static void InternalSetGoalWeightPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, float value)
		{
			AnimationHumanStream.InternalSetGoalWeightPosition_InjectedDelegateField(ref _unity_self, index, value);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00003A7E File Offset: 0x00001C7E
		public static void InternalSetGoalWeightRotation_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, float value)
		{
			AnimationHumanStream.InternalSetGoalWeightRotation_InjectedDelegateField(ref _unity_self, index, value);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00003A8D File Offset: 0x00001C8D
		public static float InternalGetGoalWeightPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index)
		{
			return AnimationHumanStream.InternalGetGoalWeightPosition_InjectedDelegateField(ref _unity_self, index);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00003A9B File Offset: 0x00001C9B
		public static float InternalGetGoalWeightRotation_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index)
		{
			return AnimationHumanStream.InternalGetGoalWeightRotation_InjectedDelegateField(ref _unity_self, index);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00003AA9 File Offset: 0x00001CA9
		public static void InternalGetHintPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKHint index, out Vector3 ret)
		{
			AnimationHumanStream.InternalGetHintPosition_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00003AB8 File Offset: 0x00001CB8
		public static void InternalSetHintPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKHint index, ref Vector3 pos)
		{
			AnimationHumanStream.InternalSetHintPosition_InjectedDelegateField(ref _unity_self, index, ref pos);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00003AC7 File Offset: 0x00001CC7
		public static void InternalSetHintWeightPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKHint index, float value)
		{
			AnimationHumanStream.InternalSetHintWeightPosition_InjectedDelegateField(ref _unity_self, index, value);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00003AD6 File Offset: 0x00001CD6
		public static float InternalGetHintWeightPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKHint index)
		{
			return AnimationHumanStream.InternalGetHintWeightPosition_InjectedDelegateField(ref _unity_self, index);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00003AE4 File Offset: 0x00001CE4
		public static void InternalSetLookAtPosition_Injected(ref AnimationHumanStream _unity_self, ref Vector3 lookAtPosition)
		{
			AnimationHumanStream.InternalSetLookAtPosition_InjectedDelegateField(ref _unity_self, ref lookAtPosition);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00003AF2 File Offset: 0x00001CF2
		public static void InternalSetLookAtClampWeight_Injected(ref AnimationHumanStream _unity_self, float weight)
		{
			AnimationHumanStream.InternalSetLookAtClampWeight_InjectedDelegateField(ref _unity_self, weight);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00003B00 File Offset: 0x00001D00
		public static void InternalSetLookAtBodyWeight_Injected(ref AnimationHumanStream _unity_self, float weight)
		{
			AnimationHumanStream.InternalSetLookAtBodyWeight_InjectedDelegateField(ref _unity_self, weight);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00003B0E File Offset: 0x00001D0E
		public static void InternalSetLookAtHeadWeight_Injected(ref AnimationHumanStream _unity_self, float weight)
		{
			AnimationHumanStream.InternalSetLookAtHeadWeight_InjectedDelegateField(ref _unity_self, weight);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00003B1C File Offset: 0x00001D1C
		public static void InternalSetLookAtEyesWeight_Injected(ref AnimationHumanStream _unity_self, float weight)
		{
			AnimationHumanStream.InternalSetLookAtEyesWeight_InjectedDelegateField(ref _unity_self, weight);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00003B2A File Offset: 0x00001D2A
		public static void InternalSolveIK_Injected(ref AnimationHumanStream _unity_self)
		{
			AnimationHumanStream.InternalSolveIK_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeFieldInfoPtr_stream;

		// Token: 0x04000150 RID: 336
		[FieldOffset(0)]
		public IntPtr stream;

		// Token: 0x04000151 RID: 337
		private static readonly AnimationHumanStream.GetHumanScale_InjectedDelegate GetHumanScale_InjectedDelegateField;

		// Token: 0x04000152 RID: 338
		private static readonly AnimationHumanStream.GetFootHeight_InjectedDelegate GetFootHeight_InjectedDelegateField;

		// Token: 0x04000153 RID: 339
		private static readonly AnimationHumanStream.InternalResetToStancePose_InjectedDelegate InternalResetToStancePose_InjectedDelegateField;

		// Token: 0x04000154 RID: 340
		private static readonly AnimationHumanStream.InternalGetGoalPositionFromPose_InjectedDelegate InternalGetGoalPositionFromPose_InjectedDelegateField;

		// Token: 0x04000155 RID: 341
		private static readonly AnimationHumanStream.InternalGetGoalRotationFromPose_InjectedDelegate InternalGetGoalRotationFromPose_InjectedDelegateField;

		// Token: 0x04000156 RID: 342
		private static readonly AnimationHumanStream.InternalGetBodyLocalPosition_InjectedDelegate InternalGetBodyLocalPosition_InjectedDelegateField;

		// Token: 0x04000157 RID: 343
		private static readonly AnimationHumanStream.InternalSetBodyLocalPosition_InjectedDelegate InternalSetBodyLocalPosition_InjectedDelegateField;

		// Token: 0x04000158 RID: 344
		private static readonly AnimationHumanStream.InternalGetBodyLocalRotation_InjectedDelegate InternalGetBodyLocalRotation_InjectedDelegateField;

		// Token: 0x04000159 RID: 345
		private static readonly AnimationHumanStream.InternalSetBodyLocalRotation_InjectedDelegate InternalSetBodyLocalRotation_InjectedDelegateField;

		// Token: 0x0400015A RID: 346
		private static readonly AnimationHumanStream.InternalGetBodyPosition_InjectedDelegate InternalGetBodyPosition_InjectedDelegateField;

		// Token: 0x0400015B RID: 347
		private static readonly AnimationHumanStream.InternalSetBodyPosition_InjectedDelegate InternalSetBodyPosition_InjectedDelegateField;

		// Token: 0x0400015C RID: 348
		private static readonly AnimationHumanStream.InternalGetBodyRotation_InjectedDelegate InternalGetBodyRotation_InjectedDelegateField;

		// Token: 0x0400015D RID: 349
		private static readonly AnimationHumanStream.InternalSetBodyRotation_InjectedDelegate InternalSetBodyRotation_InjectedDelegateField;

		// Token: 0x0400015E RID: 350
		private static readonly AnimationHumanStream.GetLeftFootVelocity_InjectedDelegate GetLeftFootVelocity_InjectedDelegateField;

		// Token: 0x0400015F RID: 351
		private static readonly AnimationHumanStream.GetRightFootVelocity_InjectedDelegate GetRightFootVelocity_InjectedDelegateField;

		// Token: 0x04000160 RID: 352
		private static readonly AnimationHumanStream.InternalGetGoalLocalPosition_InjectedDelegate InternalGetGoalLocalPosition_InjectedDelegateField;

		// Token: 0x04000161 RID: 353
		private static readonly AnimationHumanStream.InternalSetGoalLocalPosition_InjectedDelegate InternalSetGoalLocalPosition_InjectedDelegateField;

		// Token: 0x04000162 RID: 354
		private static readonly AnimationHumanStream.InternalGetGoalLocalRotation_InjectedDelegate InternalGetGoalLocalRotation_InjectedDelegateField;

		// Token: 0x04000163 RID: 355
		private static readonly AnimationHumanStream.InternalSetGoalLocalRotation_InjectedDelegate InternalSetGoalLocalRotation_InjectedDelegateField;

		// Token: 0x04000164 RID: 356
		private static readonly AnimationHumanStream.InternalGetGoalPosition_InjectedDelegate InternalGetGoalPosition_InjectedDelegateField;

		// Token: 0x04000165 RID: 357
		private static readonly AnimationHumanStream.InternalSetGoalPosition_InjectedDelegate InternalSetGoalPosition_InjectedDelegateField;

		// Token: 0x04000166 RID: 358
		private static readonly AnimationHumanStream.InternalGetGoalRotation_InjectedDelegate InternalGetGoalRotation_InjectedDelegateField;

		// Token: 0x04000167 RID: 359
		private static readonly AnimationHumanStream.InternalSetGoalRotation_InjectedDelegate InternalSetGoalRotation_InjectedDelegateField;

		// Token: 0x04000168 RID: 360
		private static readonly AnimationHumanStream.InternalSetGoalWeightPosition_InjectedDelegate InternalSetGoalWeightPosition_InjectedDelegateField;

		// Token: 0x04000169 RID: 361
		private static readonly AnimationHumanStream.InternalSetGoalWeightRotation_InjectedDelegate InternalSetGoalWeightRotation_InjectedDelegateField;

		// Token: 0x0400016A RID: 362
		private static readonly AnimationHumanStream.InternalGetGoalWeightPosition_InjectedDelegate InternalGetGoalWeightPosition_InjectedDelegateField;

		// Token: 0x0400016B RID: 363
		private static readonly AnimationHumanStream.InternalGetGoalWeightRotation_InjectedDelegate InternalGetGoalWeightRotation_InjectedDelegateField;

		// Token: 0x0400016C RID: 364
		private static readonly AnimationHumanStream.InternalGetHintPosition_InjectedDelegate InternalGetHintPosition_InjectedDelegateField;

		// Token: 0x0400016D RID: 365
		private static readonly AnimationHumanStream.InternalSetHintPosition_InjectedDelegate InternalSetHintPosition_InjectedDelegateField;

		// Token: 0x0400016E RID: 366
		private static readonly AnimationHumanStream.InternalSetHintWeightPosition_InjectedDelegate InternalSetHintWeightPosition_InjectedDelegateField;

		// Token: 0x0400016F RID: 367
		private static readonly AnimationHumanStream.InternalGetHintWeightPosition_InjectedDelegate InternalGetHintWeightPosition_InjectedDelegateField;

		// Token: 0x04000170 RID: 368
		private static readonly AnimationHumanStream.InternalSetLookAtPosition_InjectedDelegate InternalSetLookAtPosition_InjectedDelegateField;

		// Token: 0x04000171 RID: 369
		private static readonly AnimationHumanStream.InternalSetLookAtClampWeight_InjectedDelegate InternalSetLookAtClampWeight_InjectedDelegateField;

		// Token: 0x04000172 RID: 370
		private static readonly AnimationHumanStream.InternalSetLookAtBodyWeight_InjectedDelegate InternalSetLookAtBodyWeight_InjectedDelegateField;

		// Token: 0x04000173 RID: 371
		private static readonly AnimationHumanStream.InternalSetLookAtHeadWeight_InjectedDelegate InternalSetLookAtHeadWeight_InjectedDelegateField;

		// Token: 0x04000174 RID: 372
		private static readonly AnimationHumanStream.InternalSetLookAtEyesWeight_InjectedDelegate InternalSetLookAtEyesWeight_InjectedDelegateField;

		// Token: 0x04000175 RID: 373
		private static readonly AnimationHumanStream.InternalSolveIK_InjectedDelegate InternalSolveIK_InjectedDelegateField;

		// Token: 0x02000137 RID: 311
		// (Invoke) Token: 0x06000714 RID: 1812
		private delegate float GetHumanScale_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000138 RID: 312
		// (Invoke) Token: 0x06000716 RID: 1814
		private delegate float GetFootHeight_InjectedDelegate(IntPtr _unity_self, bool left);

		// Token: 0x02000139 RID: 313
		// (Invoke) Token: 0x06000718 RID: 1816
		private delegate void InternalResetToStancePose_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x0200013A RID: 314
		// (Invoke) Token: 0x0600071A RID: 1818
		private delegate void InternalGetGoalPositionFromPose_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, [Out] IntPtr ret);

		// Token: 0x0200013B RID: 315
		// (Invoke) Token: 0x0600071C RID: 1820
		private delegate void InternalGetGoalRotationFromPose_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, [Out] IntPtr ret);

		// Token: 0x0200013C RID: 316
		// (Invoke) Token: 0x0600071E RID: 1822
		private delegate void InternalGetBodyLocalPosition_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x0200013D RID: 317
		// (Invoke) Token: 0x06000720 RID: 1824
		private delegate void InternalSetBodyLocalPosition_InjectedDelegate(IntPtr _unity_self, IntPtr value);

		// Token: 0x0200013E RID: 318
		// (Invoke) Token: 0x06000722 RID: 1826
		private delegate void InternalGetBodyLocalRotation_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x0200013F RID: 319
		// (Invoke) Token: 0x06000724 RID: 1828
		private delegate void InternalSetBodyLocalRotation_InjectedDelegate(IntPtr _unity_self, IntPtr value);

		// Token: 0x02000140 RID: 320
		// (Invoke) Token: 0x06000726 RID: 1830
		private delegate void InternalGetBodyPosition_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x02000141 RID: 321
		// (Invoke) Token: 0x06000728 RID: 1832
		private delegate void InternalSetBodyPosition_InjectedDelegate(IntPtr _unity_self, IntPtr value);

		// Token: 0x02000142 RID: 322
		// (Invoke) Token: 0x0600072A RID: 1834
		private delegate void InternalGetBodyRotation_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x02000143 RID: 323
		// (Invoke) Token: 0x0600072C RID: 1836
		private delegate void InternalSetBodyRotation_InjectedDelegate(IntPtr _unity_self, IntPtr value);

		// Token: 0x02000144 RID: 324
		// (Invoke) Token: 0x0600072E RID: 1838
		private delegate void GetLeftFootVelocity_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x02000145 RID: 325
		// (Invoke) Token: 0x06000730 RID: 1840
		private delegate void GetRightFootVelocity_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x02000146 RID: 326
		// (Invoke) Token: 0x06000732 RID: 1842
		private delegate void InternalGetGoalLocalPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, [Out] IntPtr ret);

		// Token: 0x02000147 RID: 327
		// (Invoke) Token: 0x06000734 RID: 1844
		private delegate void InternalSetGoalLocalPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, IntPtr pos);

		// Token: 0x02000148 RID: 328
		// (Invoke) Token: 0x06000736 RID: 1846
		private delegate void InternalGetGoalLocalRotation_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, [Out] IntPtr ret);

		// Token: 0x02000149 RID: 329
		// (Invoke) Token: 0x06000738 RID: 1848
		private delegate void InternalSetGoalLocalRotation_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, IntPtr rot);

		// Token: 0x0200014A RID: 330
		// (Invoke) Token: 0x0600073A RID: 1850
		private delegate void InternalGetGoalPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, [Out] IntPtr ret);

		// Token: 0x0200014B RID: 331
		// (Invoke) Token: 0x0600073C RID: 1852
		private delegate void InternalSetGoalPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, IntPtr pos);

		// Token: 0x0200014C RID: 332
		// (Invoke) Token: 0x0600073E RID: 1854
		private delegate void InternalGetGoalRotation_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, [Out] IntPtr ret);

		// Token: 0x0200014D RID: 333
		// (Invoke) Token: 0x06000740 RID: 1856
		private delegate void InternalSetGoalRotation_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, IntPtr rot);

		// Token: 0x0200014E RID: 334
		// (Invoke) Token: 0x06000742 RID: 1858
		private delegate void InternalSetGoalWeightPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, float value);

		// Token: 0x0200014F RID: 335
		// (Invoke) Token: 0x06000744 RID: 1860
		private delegate void InternalSetGoalWeightRotation_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, float value);

		// Token: 0x02000150 RID: 336
		// (Invoke) Token: 0x06000746 RID: 1862
		private delegate float InternalGetGoalWeightPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index);

		// Token: 0x02000151 RID: 337
		// (Invoke) Token: 0x06000748 RID: 1864
		private delegate float InternalGetGoalWeightRotation_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index);

		// Token: 0x02000152 RID: 338
		// (Invoke) Token: 0x0600074A RID: 1866
		private delegate void InternalGetHintPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKHint index, [Out] IntPtr ret);

		// Token: 0x02000153 RID: 339
		// (Invoke) Token: 0x0600074C RID: 1868
		private delegate void InternalSetHintPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKHint index, IntPtr pos);

		// Token: 0x02000154 RID: 340
		// (Invoke) Token: 0x0600074E RID: 1870
		private delegate void InternalSetHintWeightPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKHint index, float value);

		// Token: 0x02000155 RID: 341
		// (Invoke) Token: 0x06000750 RID: 1872
		private delegate float InternalGetHintWeightPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKHint index);

		// Token: 0x02000156 RID: 342
		// (Invoke) Token: 0x06000752 RID: 1874
		private delegate void InternalSetLookAtPosition_InjectedDelegate(IntPtr _unity_self, IntPtr lookAtPosition);

		// Token: 0x02000157 RID: 343
		// (Invoke) Token: 0x06000754 RID: 1876
		private delegate void InternalSetLookAtClampWeight_InjectedDelegate(IntPtr _unity_self, float weight);

		// Token: 0x02000158 RID: 344
		// (Invoke) Token: 0x06000756 RID: 1878
		private delegate void InternalSetLookAtBodyWeight_InjectedDelegate(IntPtr _unity_self, float weight);

		// Token: 0x02000159 RID: 345
		// (Invoke) Token: 0x06000758 RID: 1880
		private delegate void InternalSetLookAtHeadWeight_InjectedDelegate(IntPtr _unity_self, float weight);

		// Token: 0x0200015A RID: 346
		// (Invoke) Token: 0x0600075A RID: 1882
		private delegate void InternalSetLookAtEyesWeight_InjectedDelegate(IntPtr _unity_self, float weight);

		// Token: 0x0200015B RID: 347
		// (Invoke) Token: 0x0600075C RID: 1884
		private delegate void InternalSolveIK_InjectedDelegate(IntPtr _unity_self);
	}
}
