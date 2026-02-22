using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x02000148 RID: 328
	[StructLayout(2)]
	public struct FrameData
	{
		// Token: 0x06001932 RID: 6450 RVA: 0x0005BF74 File Offset: 0x0005A174
		// Note: this type is marked as 'beforefieldinit'.
		static FrameData()
		{
			Il2CppClassPointerStore<FrameData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "FrameData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameData>.NativeClassPtr);
			FrameData.NativeFieldInfoPtr_m_FrameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_FrameID");
			FrameData.NativeFieldInfoPtr_m_DeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_DeltaTime");
			FrameData.NativeFieldInfoPtr_m_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_Weight");
			FrameData.NativeFieldInfoPtr_m_EffectiveWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_EffectiveWeight");
			FrameData.NativeFieldInfoPtr_m_EffectiveParentDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_EffectiveParentDelay");
			FrameData.NativeFieldInfoPtr_m_EffectiveParentSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_EffectiveParentSpeed");
			FrameData.NativeFieldInfoPtr_m_EffectiveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_EffectiveSpeed");
			FrameData.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_Flags");
			FrameData.NativeFieldInfoPtr_m_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_Output");
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x0000E160 File Offset: 0x0000C360
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FrameData>.NativeClassPtr, ref this));
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x0005C058 File Offset: 0x0005A258
		public bool HasFlags(FrameData.Flags flag)
		{
			return (this.m_Flags & flag) == flag;
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001935 RID: 6453 RVA: 0x0005C078 File Offset: 0x0005A278
		public ulong frameId
		{
			get
			{
				return this.m_FrameID;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x0005C090 File Offset: 0x0005A290
		public float deltaTime
		{
			get
			{
				return (float)this.m_DeltaTime;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001937 RID: 6455 RVA: 0x0005C0AC File Offset: 0x0005A2AC
		public float weight
		{
			get
			{
				return this.m_Weight;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x0005C0C4 File Offset: 0x0005A2C4
		public float effectiveWeight
		{
			get
			{
				return this.m_EffectiveWeight;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001939 RID: 6457 RVA: 0x0005C0DC File Offset: 0x0005A2DC
		public double effectiveParentDelay
		{
			get
			{
				return this.m_EffectiveParentDelay;
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x0005C0F4 File Offset: 0x0005A2F4
		public float effectiveParentSpeed
		{
			get
			{
				return this.m_EffectiveParentSpeed;
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x0600193B RID: 6459 RVA: 0x0005C10C File Offset: 0x0005A30C
		public float effectiveSpeed
		{
			get
			{
				return this.m_EffectiveSpeed;
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x0005C124 File Offset: 0x0005A324
		public FrameData.EvaluationType evaluationType
		{
			get
			{
				return this.HasFlags(FrameData.Flags.Evaluate) ? FrameData.EvaluationType.Evaluate : FrameData.EvaluationType.Playback;
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x0600193D RID: 6461 RVA: 0x0005C144 File Offset: 0x0005A344
		public bool seekOccurred
		{
			get
			{
				return this.HasFlags(FrameData.Flags.SeekOccured);
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x0005C160 File Offset: 0x0005A360
		public bool timeLooped
		{
			get
			{
				return this.HasFlags(FrameData.Flags.Loop);
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x0600193F RID: 6463 RVA: 0x0005C17C File Offset: 0x0005A37C
		public bool timeHeld
		{
			get
			{
				return this.HasFlags(FrameData.Flags.Hold);
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001940 RID: 6464 RVA: 0x0005C198 File Offset: 0x0005A398
		public PlayableOutput output
		{
			get
			{
				return this.m_Output;
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001941 RID: 6465 RVA: 0x0005C1B0 File Offset: 0x0005A3B0
		public PlayState effectivePlayState
		{
			get
			{
				bool flag = this.HasFlags(FrameData.Flags.EffectivePlayStateDelayed);
				PlayState playState;
				if (flag)
				{
					playState = PlayState.Delayed;
				}
				else
				{
					bool flag2 = this.HasFlags(FrameData.Flags.EffectivePlayStatePlaying);
					if (flag2)
					{
						playState = PlayState.Playing;
					}
					else
					{
						playState = PlayState.Paused;
					}
				}
				return playState;
			}
		}

		// Token: 0x0400127E RID: 4734
		private static readonly IntPtr NativeFieldInfoPtr_m_FrameID;

		// Token: 0x0400127F RID: 4735
		private static readonly IntPtr NativeFieldInfoPtr_m_DeltaTime;

		// Token: 0x04001280 RID: 4736
		private static readonly IntPtr NativeFieldInfoPtr_m_Weight;

		// Token: 0x04001281 RID: 4737
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectiveWeight;

		// Token: 0x04001282 RID: 4738
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectiveParentDelay;

		// Token: 0x04001283 RID: 4739
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectiveParentSpeed;

		// Token: 0x04001284 RID: 4740
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectiveSpeed;

		// Token: 0x04001285 RID: 4741
		private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

		// Token: 0x04001286 RID: 4742
		private static readonly IntPtr NativeFieldInfoPtr_m_Output;

		// Token: 0x04001287 RID: 4743
		[FieldOffset(0)]
		public ulong m_FrameID;

		// Token: 0x04001288 RID: 4744
		[FieldOffset(8)]
		public double m_DeltaTime;

		// Token: 0x04001289 RID: 4745
		[FieldOffset(16)]
		public float m_Weight;

		// Token: 0x0400128A RID: 4746
		[FieldOffset(20)]
		public float m_EffectiveWeight;

		// Token: 0x0400128B RID: 4747
		[FieldOffset(24)]
		public double m_EffectiveParentDelay;

		// Token: 0x0400128C RID: 4748
		[FieldOffset(32)]
		public float m_EffectiveParentSpeed;

		// Token: 0x0400128D RID: 4749
		[FieldOffset(36)]
		public float m_EffectiveSpeed;

		// Token: 0x0400128E RID: 4750
		[FieldOffset(40)]
		public FrameData.Flags m_Flags;

		// Token: 0x0400128F RID: 4751
		[FieldOffset(48)]
		public PlayableOutput m_Output;

		// Token: 0x020009AC RID: 2476
		[Flags]
		public enum Flags
		{
			// Token: 0x04001D2C RID: 7468
			Evaluate = 1,
			// Token: 0x04001D2D RID: 7469
			SeekOccured = 2,
			// Token: 0x04001D2E RID: 7470
			Loop = 4,
			// Token: 0x04001D2F RID: 7471
			Hold = 8,
			// Token: 0x04001D30 RID: 7472
			EffectivePlayStateDelayed = 16,
			// Token: 0x04001D31 RID: 7473
			EffectivePlayStatePlaying = 32
		}

		// Token: 0x020009AD RID: 2477
		public enum EvaluationType
		{
			// Token: 0x04001D33 RID: 7475
			Evaluate,
			// Token: 0x04001D34 RID: 7476
			Playback
		}
	}
}
