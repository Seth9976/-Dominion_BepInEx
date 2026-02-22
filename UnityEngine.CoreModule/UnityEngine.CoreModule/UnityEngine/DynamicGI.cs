using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine
{
	// Token: 0x020001D6 RID: 470
	public sealed class DynamicGI
	{
		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001C84 RID: 7300 RVA: 0x0000FA9A File Offset: 0x0000DC9A
		// (set) Token: 0x06001C85 RID: 7301 RVA: 0x0000FAA6 File Offset: 0x0000DCA6
		public static float indirectScale
		{
			get
			{
				return DynamicGI.get_indirectScaleDelegateField();
			}
			set
			{
				DynamicGI.set_indirectScaleDelegateField(value);
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001C86 RID: 7302 RVA: 0x0000FAB3 File Offset: 0x0000DCB3
		// (set) Token: 0x06001C87 RID: 7303 RVA: 0x0000FABF File Offset: 0x0000DCBF
		public static float updateThreshold
		{
			get
			{
				return DynamicGI.get_updateThresholdDelegateField();
			}
			set
			{
				DynamicGI.set_updateThresholdDelegateField(value);
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001C88 RID: 7304 RVA: 0x0000FACC File Offset: 0x0000DCCC
		// (set) Token: 0x06001C89 RID: 7305 RVA: 0x0000FAD8 File Offset: 0x0000DCD8
		public static int materialUpdateTimeSlice
		{
			get
			{
				return DynamicGI.get_materialUpdateTimeSliceDelegateField();
			}
			set
			{
				DynamicGI.set_materialUpdateTimeSliceDelegateField(value);
			}
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x0000FAE5 File Offset: 0x0000DCE5
		public static void SetEmissive(Renderer renderer, Color color)
		{
			DynamicGI.SetEmissive_Injected(renderer, ref color);
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x0000FAEF File Offset: 0x0000DCEF
		public static void SetEnvironmentData(Il2CppStructArray<float> input)
		{
			DynamicGI.SetEnvironmentDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(input));
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001C8C RID: 7308 RVA: 0x0000FB01 File Offset: 0x0000DD01
		// (set) Token: 0x06001C8D RID: 7309 RVA: 0x0000FB0D File Offset: 0x0000DD0D
		public static bool synchronousMode
		{
			get
			{
				return DynamicGI.get_synchronousModeDelegateField();
			}
			set
			{
				DynamicGI.set_synchronousModeDelegateField(value);
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001C8E RID: 7310 RVA: 0x0000FB1A File Offset: 0x0000DD1A
		public static bool isConverged
		{
			get
			{
				return DynamicGI.get_isConvergedDelegateField();
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001C8F RID: 7311 RVA: 0x0000FB26 File Offset: 0x0000DD26
		public static int scheduledMaterialUpdatesCount
		{
			get
			{
				return DynamicGI.get_scheduledMaterialUpdatesCountDelegateField();
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001C90 RID: 7312 RVA: 0x0000FB32 File Offset: 0x0000DD32
		// (set) Token: 0x06001C91 RID: 7313 RVA: 0x0000FB3E File Offset: 0x0000DD3E
		public static bool asyncMaterialUpdates
		{
			get
			{
				return DynamicGI.get_asyncMaterialUpdatesDelegateField();
			}
			set
			{
				DynamicGI.set_asyncMaterialUpdatesDelegateField(value);
			}
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x0000FB4B File Offset: 0x0000DD4B
		public static void UpdateEnvironment()
		{
			DynamicGI.UpdateEnvironmentDelegateField();
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x0000FB57 File Offset: 0x0000DD57
		public static void UpdateMaterials(Renderer renderer)
		{
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x0000FB5A File Offset: 0x0000DD5A
		public static void UpdateMaterials(Object renderer)
		{
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x0000FB5D File Offset: 0x0000DD5D
		public static void UpdateMaterials(Object renderer, int x, int y, int width, int height)
		{
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x0000FB60 File Offset: 0x0000DD60
		public static void SetEmissive_Injected(Renderer renderer, ref Color color)
		{
			DynamicGI.SetEmissive_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(renderer), ref color);
		}

		// Token: 0x04001677 RID: 5751
		private static readonly DynamicGI.get_indirectScaleDelegate get_indirectScaleDelegateField = IL2CPP.ResolveICall<DynamicGI.get_indirectScaleDelegate>("UnityEngine.DynamicGI::get_indirectScale");

		// Token: 0x04001678 RID: 5752
		private static readonly DynamicGI.set_indirectScaleDelegate set_indirectScaleDelegateField = IL2CPP.ResolveICall<DynamicGI.set_indirectScaleDelegate>("UnityEngine.DynamicGI::set_indirectScale");

		// Token: 0x04001679 RID: 5753
		private static readonly DynamicGI.get_updateThresholdDelegate get_updateThresholdDelegateField = IL2CPP.ResolveICall<DynamicGI.get_updateThresholdDelegate>("UnityEngine.DynamicGI::get_updateThreshold");

		// Token: 0x0400167A RID: 5754
		private static readonly DynamicGI.set_updateThresholdDelegate set_updateThresholdDelegateField = IL2CPP.ResolveICall<DynamicGI.set_updateThresholdDelegate>("UnityEngine.DynamicGI::set_updateThreshold");

		// Token: 0x0400167B RID: 5755
		private static readonly DynamicGI.get_materialUpdateTimeSliceDelegate get_materialUpdateTimeSliceDelegateField = IL2CPP.ResolveICall<DynamicGI.get_materialUpdateTimeSliceDelegate>("UnityEngine.DynamicGI::get_materialUpdateTimeSlice");

		// Token: 0x0400167C RID: 5756
		private static readonly DynamicGI.set_materialUpdateTimeSliceDelegate set_materialUpdateTimeSliceDelegateField = IL2CPP.ResolveICall<DynamicGI.set_materialUpdateTimeSliceDelegate>("UnityEngine.DynamicGI::set_materialUpdateTimeSlice");

		// Token: 0x0400167D RID: 5757
		private static readonly DynamicGI.SetEnvironmentDataDelegate SetEnvironmentDataDelegateField = IL2CPP.ResolveICall<DynamicGI.SetEnvironmentDataDelegate>("UnityEngine.DynamicGI::SetEnvironmentData");

		// Token: 0x0400167E RID: 5758
		private static readonly DynamicGI.get_synchronousModeDelegate get_synchronousModeDelegateField = IL2CPP.ResolveICall<DynamicGI.get_synchronousModeDelegate>("UnityEngine.DynamicGI::get_synchronousMode");

		// Token: 0x0400167F RID: 5759
		private static readonly DynamicGI.set_synchronousModeDelegate set_synchronousModeDelegateField = IL2CPP.ResolveICall<DynamicGI.set_synchronousModeDelegate>("UnityEngine.DynamicGI::set_synchronousMode");

		// Token: 0x04001680 RID: 5760
		private static readonly DynamicGI.get_isConvergedDelegate get_isConvergedDelegateField = IL2CPP.ResolveICall<DynamicGI.get_isConvergedDelegate>("UnityEngine.DynamicGI::get_isConverged");

		// Token: 0x04001681 RID: 5761
		private static readonly DynamicGI.get_scheduledMaterialUpdatesCountDelegate get_scheduledMaterialUpdatesCountDelegateField = IL2CPP.ResolveICall<DynamicGI.get_scheduledMaterialUpdatesCountDelegate>("UnityEngine.DynamicGI::get_scheduledMaterialUpdatesCount");

		// Token: 0x04001682 RID: 5762
		private static readonly DynamicGI.get_asyncMaterialUpdatesDelegate get_asyncMaterialUpdatesDelegateField = IL2CPP.ResolveICall<DynamicGI.get_asyncMaterialUpdatesDelegate>("UnityEngine.DynamicGI::get_asyncMaterialUpdates");

		// Token: 0x04001683 RID: 5763
		private static readonly DynamicGI.set_asyncMaterialUpdatesDelegate set_asyncMaterialUpdatesDelegateField = IL2CPP.ResolveICall<DynamicGI.set_asyncMaterialUpdatesDelegate>("UnityEngine.DynamicGI::set_asyncMaterialUpdates");

		// Token: 0x04001684 RID: 5764
		private static readonly DynamicGI.UpdateEnvironmentDelegate UpdateEnvironmentDelegateField = IL2CPP.ResolveICall<DynamicGI.UpdateEnvironmentDelegate>("UnityEngine.DynamicGI::UpdateEnvironment");

		// Token: 0x04001685 RID: 5765
		private static readonly DynamicGI.SetEmissive_InjectedDelegate SetEmissive_InjectedDelegateField = IL2CPP.ResolveICall<DynamicGI.SetEmissive_InjectedDelegate>("UnityEngine.DynamicGI::SetEmissive_Injected");

		// Token: 0x02000AAA RID: 2730
		// (Invoke) Token: 0x06003354 RID: 13140
		private delegate float get_indirectScaleDelegate();

		// Token: 0x02000AAB RID: 2731
		// (Invoke) Token: 0x06003356 RID: 13142
		private delegate void set_indirectScaleDelegate(float value);

		// Token: 0x02000AAC RID: 2732
		// (Invoke) Token: 0x06003358 RID: 13144
		private delegate float get_updateThresholdDelegate();

		// Token: 0x02000AAD RID: 2733
		// (Invoke) Token: 0x0600335A RID: 13146
		private delegate void set_updateThresholdDelegate(float value);

		// Token: 0x02000AAE RID: 2734
		// (Invoke) Token: 0x0600335C RID: 13148
		private delegate int get_materialUpdateTimeSliceDelegate();

		// Token: 0x02000AAF RID: 2735
		// (Invoke) Token: 0x0600335E RID: 13150
		private delegate void set_materialUpdateTimeSliceDelegate(int value);

		// Token: 0x02000AB0 RID: 2736
		// (Invoke) Token: 0x06003360 RID: 13152
		private delegate void SetEnvironmentDataDelegate(IntPtr input);

		// Token: 0x02000AB1 RID: 2737
		// (Invoke) Token: 0x06003362 RID: 13154
		private delegate bool get_synchronousModeDelegate();

		// Token: 0x02000AB2 RID: 2738
		// (Invoke) Token: 0x06003364 RID: 13156
		private delegate void set_synchronousModeDelegate(bool value);

		// Token: 0x02000AB3 RID: 2739
		// (Invoke) Token: 0x06003366 RID: 13158
		private delegate bool get_isConvergedDelegate();

		// Token: 0x02000AB4 RID: 2740
		// (Invoke) Token: 0x06003368 RID: 13160
		private delegate int get_scheduledMaterialUpdatesCountDelegate();

		// Token: 0x02000AB5 RID: 2741
		// (Invoke) Token: 0x0600336A RID: 13162
		private delegate bool get_asyncMaterialUpdatesDelegate();

		// Token: 0x02000AB6 RID: 2742
		// (Invoke) Token: 0x0600336C RID: 13164
		private delegate void set_asyncMaterialUpdatesDelegate(bool value);

		// Token: 0x02000AB7 RID: 2743
		// (Invoke) Token: 0x0600336E RID: 13166
		private delegate void UpdateEnvironmentDelegate();

		// Token: 0x02000AB8 RID: 2744
		// (Invoke) Token: 0x06003370 RID: 13168
		private delegate void SetEmissive_InjectedDelegate(IntPtr renderer, IntPtr color);
	}
}
