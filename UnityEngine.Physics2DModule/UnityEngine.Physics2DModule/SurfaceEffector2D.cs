using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200002D RID: 45
	public class SurfaceEffector2D : Effector2D
	{
		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x0000469D File Offset: 0x0000289D
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x000046AF File Offset: 0x000028AF
		public float speed
		{
			get
			{
				return SurfaceEffector2D.get_speedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SurfaceEffector2D.set_speedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x000046C2 File Offset: 0x000028C2
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x000046D4 File Offset: 0x000028D4
		public float speedVariation
		{
			get
			{
				return SurfaceEffector2D.get_speedVariationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SurfaceEffector2D.set_speedVariationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x000046E7 File Offset: 0x000028E7
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x000046F9 File Offset: 0x000028F9
		public float forceScale
		{
			get
			{
				return SurfaceEffector2D.get_forceScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SurfaceEffector2D.set_forceScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x0000470C File Offset: 0x0000290C
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x0000471E File Offset: 0x0000291E
		public bool useContactForce
		{
			get
			{
				return SurfaceEffector2D.get_useContactForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SurfaceEffector2D.set_useContactForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x00004731 File Offset: 0x00002931
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x00004743 File Offset: 0x00002943
		public bool useFriction
		{
			get
			{
				return SurfaceEffector2D.get_useFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SurfaceEffector2D.set_useFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x00004756 File Offset: 0x00002956
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x00004768 File Offset: 0x00002968
		public bool useBounce
		{
			get
			{
				return SurfaceEffector2D.get_useBounceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SurfaceEffector2D.set_useBounceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000267 RID: 615
		private static readonly SurfaceEffector2D.get_speedDelegate get_speedDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.get_speedDelegate>("UnityEngine.SurfaceEffector2D::get_speed");

		// Token: 0x04000268 RID: 616
		private static readonly SurfaceEffector2D.set_speedDelegate set_speedDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.set_speedDelegate>("UnityEngine.SurfaceEffector2D::set_speed");

		// Token: 0x04000269 RID: 617
		private static readonly SurfaceEffector2D.get_speedVariationDelegate get_speedVariationDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.get_speedVariationDelegate>("UnityEngine.SurfaceEffector2D::get_speedVariation");

		// Token: 0x0400026A RID: 618
		private static readonly SurfaceEffector2D.set_speedVariationDelegate set_speedVariationDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.set_speedVariationDelegate>("UnityEngine.SurfaceEffector2D::set_speedVariation");

		// Token: 0x0400026B RID: 619
		private static readonly SurfaceEffector2D.get_forceScaleDelegate get_forceScaleDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.get_forceScaleDelegate>("UnityEngine.SurfaceEffector2D::get_forceScale");

		// Token: 0x0400026C RID: 620
		private static readonly SurfaceEffector2D.set_forceScaleDelegate set_forceScaleDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.set_forceScaleDelegate>("UnityEngine.SurfaceEffector2D::set_forceScale");

		// Token: 0x0400026D RID: 621
		private static readonly SurfaceEffector2D.get_useContactForceDelegate get_useContactForceDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.get_useContactForceDelegate>("UnityEngine.SurfaceEffector2D::get_useContactForce");

		// Token: 0x0400026E RID: 622
		private static readonly SurfaceEffector2D.set_useContactForceDelegate set_useContactForceDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.set_useContactForceDelegate>("UnityEngine.SurfaceEffector2D::set_useContactForce");

		// Token: 0x0400026F RID: 623
		private static readonly SurfaceEffector2D.get_useFrictionDelegate get_useFrictionDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.get_useFrictionDelegate>("UnityEngine.SurfaceEffector2D::get_useFriction");

		// Token: 0x04000270 RID: 624
		private static readonly SurfaceEffector2D.set_useFrictionDelegate set_useFrictionDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.set_useFrictionDelegate>("UnityEngine.SurfaceEffector2D::set_useFriction");

		// Token: 0x04000271 RID: 625
		private static readonly SurfaceEffector2D.get_useBounceDelegate get_useBounceDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.get_useBounceDelegate>("UnityEngine.SurfaceEffector2D::get_useBounce");

		// Token: 0x04000272 RID: 626
		private static readonly SurfaceEffector2D.set_useBounceDelegate set_useBounceDelegateField = IL2CPP.ResolveICall<SurfaceEffector2D.set_useBounceDelegate>("UnityEngine.SurfaceEffector2D::set_useBounce");

		// Token: 0x020001F4 RID: 500
		// (Invoke) Token: 0x060007B2 RID: 1970
		private delegate float get_speedDelegate(IntPtr @this);

		// Token: 0x020001F5 RID: 501
		// (Invoke) Token: 0x060007B4 RID: 1972
		private delegate void set_speedDelegate(IntPtr @this, float value);

		// Token: 0x020001F6 RID: 502
		// (Invoke) Token: 0x060007B6 RID: 1974
		private delegate float get_speedVariationDelegate(IntPtr @this);

		// Token: 0x020001F7 RID: 503
		// (Invoke) Token: 0x060007B8 RID: 1976
		private delegate void set_speedVariationDelegate(IntPtr @this, float value);

		// Token: 0x020001F8 RID: 504
		// (Invoke) Token: 0x060007BA RID: 1978
		private delegate float get_forceScaleDelegate(IntPtr @this);

		// Token: 0x020001F9 RID: 505
		// (Invoke) Token: 0x060007BC RID: 1980
		private delegate void set_forceScaleDelegate(IntPtr @this, float value);

		// Token: 0x020001FA RID: 506
		// (Invoke) Token: 0x060007BE RID: 1982
		private delegate bool get_useContactForceDelegate(IntPtr @this);

		// Token: 0x020001FB RID: 507
		// (Invoke) Token: 0x060007C0 RID: 1984
		private delegate void set_useContactForceDelegate(IntPtr @this, bool value);

		// Token: 0x020001FC RID: 508
		// (Invoke) Token: 0x060007C2 RID: 1986
		private delegate bool get_useFrictionDelegate(IntPtr @this);

		// Token: 0x020001FD RID: 509
		// (Invoke) Token: 0x060007C4 RID: 1988
		private delegate void set_useFrictionDelegate(IntPtr @this, bool value);

		// Token: 0x020001FE RID: 510
		// (Invoke) Token: 0x060007C6 RID: 1990
		private delegate bool get_useBounceDelegate(IntPtr @this);

		// Token: 0x020001FF RID: 511
		// (Invoke) Token: 0x060007C8 RID: 1992
		private delegate void set_useBounceDelegate(IntPtr @this, bool value);
	}
}
