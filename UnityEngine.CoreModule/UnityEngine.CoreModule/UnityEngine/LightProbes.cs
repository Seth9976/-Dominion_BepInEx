using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000050 RID: 80
	public sealed class LightProbes : Object
	{
		// Token: 0x06000606 RID: 1542 RVA: 0x000248A0 File Offset: 0x00022AA0
		// Note: this type is marked as 'beforefieldinit'.
		static LightProbes()
		{
			Il2CppClassPointerStore<LightProbes>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightProbes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightProbes>.NativeClassPtr);
			LightProbes.TetrahedralizeDelegateField = IL2CPP.ResolveICall<LightProbes.TetrahedralizeDelegate>("UnityEngine.LightProbes::Tetrahedralize");
			LightProbes.TetrahedralizeAsyncDelegateField = IL2CPP.ResolveICall<LightProbes.TetrahedralizeAsyncDelegate>("UnityEngine.LightProbes::TetrahedralizeAsync");
			LightProbes.AreLightProbesAllowedDelegateField = IL2CPP.ResolveICall<LightProbes.AreLightProbesAllowedDelegate>("UnityEngine.LightProbes::AreLightProbesAllowed");
			LightProbes.get_positionsDelegateField = IL2CPP.ResolveICall<LightProbes.get_positionsDelegate>("UnityEngine.LightProbes::get_positions");
			LightProbes.get_countDelegateField = IL2CPP.ResolveICall<LightProbes.get_countDelegate>("UnityEngine.LightProbes::get_count");
			LightProbes.get_cellCountDelegateField = IL2CPP.ResolveICall<LightProbes.get_cellCountDelegate>("UnityEngine.LightProbes::get_cellCount");
			LightProbes.GetCountDelegateField = IL2CPP.ResolveICall<LightProbes.GetCountDelegate>("UnityEngine.LightProbes::GetCount");
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x0000564C File Offset: 0x0000384C
		public LightProbes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00005655 File Offset: 0x00003855
		public static void Internal_CallTetrahedralizationCompletedFunction()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00005662 File Offset: 0x00003862
		public static void Internal_CallNeedsRetetrahedralizationFunction()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0000566F File Offset: 0x0000386F
		public static void Tetrahedralize()
		{
			LightProbes.TetrahedralizeDelegateField();
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0000567B File Offset: 0x0000387B
		public static void TetrahedralizeAsync()
		{
			LightProbes.TetrahedralizeAsyncDelegateField();
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00005687 File Offset: 0x00003887
		public static bool AreLightProbesAllowed(Renderer renderer)
		{
			return LightProbes.AreLightProbesAllowedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(renderer));
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x0002493C File Offset: 0x00022B3C
		public Il2CppStructArray<Vector3> positions
		{
			get
			{
				IntPtr intPtr = LightProbes.get_positionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x00005699 File Offset: 0x00003899
		public int count
		{
			get
			{
				return LightProbes.get_countDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x000056AB File Offset: 0x000038AB
		public int cellCount
		{
			get
			{
				return LightProbes.get_cellCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x000056BD File Offset: 0x000038BD
		public static int GetCount()
		{
			return LightProbes.GetCountDelegateField();
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x000056C9 File Offset: 0x000038C9
		public void GetInterpolatedLightProbe(Vector3 position, Renderer renderer, Il2CppStructArray<float> coefficients)
		{
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x000056CC File Offset: 0x000038CC
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x000056D9 File Offset: 0x000038D9
		public Il2CppStructArray<float> coefficients
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
			}
		}

		// Token: 0x040003C4 RID: 964
		private static readonly LightProbes.TetrahedralizeDelegate TetrahedralizeDelegateField;

		// Token: 0x040003C5 RID: 965
		private static readonly LightProbes.TetrahedralizeAsyncDelegate TetrahedralizeAsyncDelegateField;

		// Token: 0x040003C6 RID: 966
		private static readonly LightProbes.AreLightProbesAllowedDelegate AreLightProbesAllowedDelegateField;

		// Token: 0x040003C7 RID: 967
		private static readonly LightProbes.get_positionsDelegate get_positionsDelegateField;

		// Token: 0x040003C8 RID: 968
		private static readonly LightProbes.get_countDelegate get_countDelegateField;

		// Token: 0x040003C9 RID: 969
		private static readonly LightProbes.get_cellCountDelegate get_cellCountDelegateField;

		// Token: 0x040003CA RID: 970
		private static readonly LightProbes.GetCountDelegate GetCountDelegateField;

		// Token: 0x0200049C RID: 1180
		// (Invoke) Token: 0x06002707 RID: 9991
		private delegate void TetrahedralizeDelegate();

		// Token: 0x0200049D RID: 1181
		// (Invoke) Token: 0x06002709 RID: 9993
		private delegate void TetrahedralizeAsyncDelegate();

		// Token: 0x0200049E RID: 1182
		// (Invoke) Token: 0x0600270B RID: 9995
		private delegate bool AreLightProbesAllowedDelegate(IntPtr renderer);

		// Token: 0x0200049F RID: 1183
		// (Invoke) Token: 0x0600270D RID: 9997
		private delegate IntPtr get_positionsDelegate(IntPtr @this);

		// Token: 0x020004A0 RID: 1184
		// (Invoke) Token: 0x0600270F RID: 9999
		private delegate int get_countDelegate(IntPtr @this);

		// Token: 0x020004A1 RID: 1185
		// (Invoke) Token: 0x06002711 RID: 10001
		private delegate int get_cellCountDelegate(IntPtr @this);

		// Token: 0x020004A2 RID: 1186
		// (Invoke) Token: 0x06002713 RID: 10003
		private delegate int GetCountDelegate();
	}
}
