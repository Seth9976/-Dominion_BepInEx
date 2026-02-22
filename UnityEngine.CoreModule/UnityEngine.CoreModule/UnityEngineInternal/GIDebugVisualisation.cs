using System;
using Il2CppInterop.Runtime;

namespace UnityEngineInternal
{
	// Token: 0x02000178 RID: 376
	public static class GIDebugVisualisation
	{
		// Token: 0x06001B9B RID: 7067 RVA: 0x0000F1A0 File Offset: 0x0000D3A0
		public static void ResetRuntimeInputTextures()
		{
			GIDebugVisualisation.ResetRuntimeInputTexturesDelegateField();
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x0000F1AC File Offset: 0x0000D3AC
		public static void PlayCycleMode()
		{
			GIDebugVisualisation.PlayCycleModeDelegateField();
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x0000F1B8 File Offset: 0x0000D3B8
		public static void PauseCycleMode()
		{
			GIDebugVisualisation.PauseCycleModeDelegateField();
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x0000F1C4 File Offset: 0x0000D3C4
		public static void StopCycleMode()
		{
			GIDebugVisualisation.StopCycleModeDelegateField();
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x0000F1D0 File Offset: 0x0000D3D0
		public static void CycleSkipSystems(int skip)
		{
			GIDebugVisualisation.CycleSkipSystemsDelegateField(skip);
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x0000F1DD File Offset: 0x0000D3DD
		public static void CycleSkipInstances(int skip)
		{
			GIDebugVisualisation.CycleSkipInstancesDelegateField(skip);
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x0000F1EA File Offset: 0x0000D3EA
		public static bool cycleMode
		{
			get
			{
				return GIDebugVisualisation.get_cycleModeDelegateField();
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x0000F1F6 File Offset: 0x0000D3F6
		public static bool pauseCycleMode
		{
			get
			{
				return GIDebugVisualisation.get_pauseCycleModeDelegateField();
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x0000F202 File Offset: 0x0000D402
		// (set) Token: 0x06001BA4 RID: 7076 RVA: 0x0000F20E File Offset: 0x0000D40E
		public static GITextureType texType
		{
			get
			{
				return GIDebugVisualisation.get_texTypeDelegateField();
			}
			set
			{
				GIDebugVisualisation.set_texTypeDelegateField(value);
			}
		}

		// Token: 0x04001541 RID: 5441
		private static readonly GIDebugVisualisation.ResetRuntimeInputTexturesDelegate ResetRuntimeInputTexturesDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.ResetRuntimeInputTexturesDelegate>("UnityEngineInternal.GIDebugVisualisation::ResetRuntimeInputTextures");

		// Token: 0x04001542 RID: 5442
		private static readonly GIDebugVisualisation.PlayCycleModeDelegate PlayCycleModeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.PlayCycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::PlayCycleMode");

		// Token: 0x04001543 RID: 5443
		private static readonly GIDebugVisualisation.PauseCycleModeDelegate PauseCycleModeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.PauseCycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::PauseCycleMode");

		// Token: 0x04001544 RID: 5444
		private static readonly GIDebugVisualisation.StopCycleModeDelegate StopCycleModeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.StopCycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::StopCycleMode");

		// Token: 0x04001545 RID: 5445
		private static readonly GIDebugVisualisation.CycleSkipSystemsDelegate CycleSkipSystemsDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.CycleSkipSystemsDelegate>("UnityEngineInternal.GIDebugVisualisation::CycleSkipSystems");

		// Token: 0x04001546 RID: 5446
		private static readonly GIDebugVisualisation.CycleSkipInstancesDelegate CycleSkipInstancesDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.CycleSkipInstancesDelegate>("UnityEngineInternal.GIDebugVisualisation::CycleSkipInstances");

		// Token: 0x04001547 RID: 5447
		private static readonly GIDebugVisualisation.get_cycleModeDelegate get_cycleModeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.get_cycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::get_cycleMode");

		// Token: 0x04001548 RID: 5448
		private static readonly GIDebugVisualisation.get_pauseCycleModeDelegate get_pauseCycleModeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.get_pauseCycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::get_pauseCycleMode");

		// Token: 0x04001549 RID: 5449
		private static readonly GIDebugVisualisation.get_texTypeDelegate get_texTypeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.get_texTypeDelegate>("UnityEngineInternal.GIDebugVisualisation::get_texType");

		// Token: 0x0400154A RID: 5450
		private static readonly GIDebugVisualisation.set_texTypeDelegate set_texTypeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.set_texTypeDelegate>("UnityEngineInternal.GIDebugVisualisation::set_texType");

		// Token: 0x02000A45 RID: 2629
		// (Invoke) Token: 0x060032B0 RID: 12976
		private delegate void ResetRuntimeInputTexturesDelegate();

		// Token: 0x02000A46 RID: 2630
		// (Invoke) Token: 0x060032B2 RID: 12978
		private delegate void PlayCycleModeDelegate();

		// Token: 0x02000A47 RID: 2631
		// (Invoke) Token: 0x060032B4 RID: 12980
		private delegate void PauseCycleModeDelegate();

		// Token: 0x02000A48 RID: 2632
		// (Invoke) Token: 0x060032B6 RID: 12982
		private delegate void StopCycleModeDelegate();

		// Token: 0x02000A49 RID: 2633
		// (Invoke) Token: 0x060032B8 RID: 12984
		private delegate void CycleSkipSystemsDelegate(int skip);

		// Token: 0x02000A4A RID: 2634
		// (Invoke) Token: 0x060032BA RID: 12986
		private delegate void CycleSkipInstancesDelegate(int skip);

		// Token: 0x02000A4B RID: 2635
		// (Invoke) Token: 0x060032BC RID: 12988
		private delegate bool get_cycleModeDelegate();

		// Token: 0x02000A4C RID: 2636
		// (Invoke) Token: 0x060032BE RID: 12990
		private delegate bool get_pauseCycleModeDelegate();

		// Token: 0x02000A4D RID: 2637
		// (Invoke) Token: 0x060032C0 RID: 12992
		private delegate GITextureType get_texTypeDelegate();

		// Token: 0x02000A4E RID: 2638
		// (Invoke) Token: 0x060032C2 RID: 12994
		private delegate void set_texTypeDelegate(GITextureType value);
	}
}
