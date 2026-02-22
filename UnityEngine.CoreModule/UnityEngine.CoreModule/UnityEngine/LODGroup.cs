using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000219 RID: 537
	public class LODGroup : Component
	{
		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001EB1 RID: 7857 RVA: 0x00064C2C File Offset: 0x00062E2C
		// (set) Token: 0x06001EB2 RID: 7858 RVA: 0x000118AE File Offset: 0x0000FAAE
		public Vector3 localReferencePoint
		{
			get
			{
				Vector3 vector;
				this.get_localReferencePoint_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_localReferencePoint_Injected(ref value);
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001EB3 RID: 7859 RVA: 0x000118B8 File Offset: 0x0000FAB8
		// (set) Token: 0x06001EB4 RID: 7860 RVA: 0x000118CA File Offset: 0x0000FACA
		public float size
		{
			get
			{
				return LODGroup.get_sizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LODGroup.set_sizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x000118DD File Offset: 0x0000FADD
		public int lodCount
		{
			get
			{
				return LODGroup.get_lodCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x000118EF File Offset: 0x0000FAEF
		// (set) Token: 0x06001EB7 RID: 7863 RVA: 0x00011901 File Offset: 0x0000FB01
		public LODFadeMode fadeMode
		{
			get
			{
				return LODGroup.get_fadeModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LODGroup.set_fadeModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001EB8 RID: 7864 RVA: 0x00011914 File Offset: 0x0000FB14
		// (set) Token: 0x06001EB9 RID: 7865 RVA: 0x00011926 File Offset: 0x0000FB26
		public bool animateCrossFading
		{
			get
			{
				return LODGroup.get_animateCrossFadingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LODGroup.set_animateCrossFadingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001EBA RID: 7866 RVA: 0x00011939 File Offset: 0x0000FB39
		// (set) Token: 0x06001EBB RID: 7867 RVA: 0x0001194B File Offset: 0x0000FB4B
		public bool enabled
		{
			get
			{
				return LODGroup.get_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LODGroup.set_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x0001195E File Offset: 0x0000FB5E
		public void RecalculateBounds()
		{
			LODGroup.RecalculateBoundsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x00011970 File Offset: 0x0000FB70
		public void ForceLOD(int index)
		{
			LODGroup.ForceLODDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001EBE RID: 7870 RVA: 0x00011983 File Offset: 0x0000FB83
		// (set) Token: 0x06001EBF RID: 7871 RVA: 0x0001198F File Offset: 0x0000FB8F
		public static float crossFadeAnimationDuration
		{
			get
			{
				return LODGroup.get_crossFadeAnimationDurationDelegateField();
			}
			set
			{
				LODGroup.set_crossFadeAnimationDurationDelegateField(value);
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001EC0 RID: 7872 RVA: 0x00064C44 File Offset: 0x00062E44
		public Vector3 worldReferencePoint
		{
			get
			{
				Vector3 vector;
				this.get_worldReferencePoint_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x0001199C File Offset: 0x0000FB9C
		public void get_localReferencePoint_Injected(out Vector3 ret)
		{
			LODGroup.get_localReferencePoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x000119AF File Offset: 0x0000FBAF
		public void set_localReferencePoint_Injected(ref Vector3 value)
		{
			LODGroup.set_localReferencePoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x000119C2 File Offset: 0x0000FBC2
		public void get_worldReferencePoint_Injected(out Vector3 ret)
		{
			LODGroup.get_worldReferencePoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x04001859 RID: 6233
		private static readonly LODGroup.get_sizeDelegate get_sizeDelegateField = IL2CPP.ResolveICall<LODGroup.get_sizeDelegate>("UnityEngine.LODGroup::get_size");

		// Token: 0x0400185A RID: 6234
		private static readonly LODGroup.set_sizeDelegate set_sizeDelegateField = IL2CPP.ResolveICall<LODGroup.set_sizeDelegate>("UnityEngine.LODGroup::set_size");

		// Token: 0x0400185B RID: 6235
		private static readonly LODGroup.get_lodCountDelegate get_lodCountDelegateField = IL2CPP.ResolveICall<LODGroup.get_lodCountDelegate>("UnityEngine.LODGroup::get_lodCount");

		// Token: 0x0400185C RID: 6236
		private static readonly LODGroup.get_fadeModeDelegate get_fadeModeDelegateField = IL2CPP.ResolveICall<LODGroup.get_fadeModeDelegate>("UnityEngine.LODGroup::get_fadeMode");

		// Token: 0x0400185D RID: 6237
		private static readonly LODGroup.set_fadeModeDelegate set_fadeModeDelegateField = IL2CPP.ResolveICall<LODGroup.set_fadeModeDelegate>("UnityEngine.LODGroup::set_fadeMode");

		// Token: 0x0400185E RID: 6238
		private static readonly LODGroup.get_animateCrossFadingDelegate get_animateCrossFadingDelegateField = IL2CPP.ResolveICall<LODGroup.get_animateCrossFadingDelegate>("UnityEngine.LODGroup::get_animateCrossFading");

		// Token: 0x0400185F RID: 6239
		private static readonly LODGroup.set_animateCrossFadingDelegate set_animateCrossFadingDelegateField = IL2CPP.ResolveICall<LODGroup.set_animateCrossFadingDelegate>("UnityEngine.LODGroup::set_animateCrossFading");

		// Token: 0x04001860 RID: 6240
		private static readonly LODGroup.get_enabledDelegate get_enabledDelegateField = IL2CPP.ResolveICall<LODGroup.get_enabledDelegate>("UnityEngine.LODGroup::get_enabled");

		// Token: 0x04001861 RID: 6241
		private static readonly LODGroup.set_enabledDelegate set_enabledDelegateField = IL2CPP.ResolveICall<LODGroup.set_enabledDelegate>("UnityEngine.LODGroup::set_enabled");

		// Token: 0x04001862 RID: 6242
		private static readonly LODGroup.RecalculateBoundsDelegate RecalculateBoundsDelegateField = IL2CPP.ResolveICall<LODGroup.RecalculateBoundsDelegate>("UnityEngine.LODGroup::RecalculateBounds");

		// Token: 0x04001863 RID: 6243
		private static readonly LODGroup.ForceLODDelegate ForceLODDelegateField = IL2CPP.ResolveICall<LODGroup.ForceLODDelegate>("UnityEngine.LODGroup::ForceLOD");

		// Token: 0x04001864 RID: 6244
		private static readonly LODGroup.get_crossFadeAnimationDurationDelegate get_crossFadeAnimationDurationDelegateField = IL2CPP.ResolveICall<LODGroup.get_crossFadeAnimationDurationDelegate>("UnityEngine.LODGroup::get_crossFadeAnimationDuration");

		// Token: 0x04001865 RID: 6245
		private static readonly LODGroup.set_crossFadeAnimationDurationDelegate set_crossFadeAnimationDurationDelegateField = IL2CPP.ResolveICall<LODGroup.set_crossFadeAnimationDurationDelegate>("UnityEngine.LODGroup::set_crossFadeAnimationDuration");

		// Token: 0x04001866 RID: 6246
		private static readonly LODGroup.get_localReferencePoint_InjectedDelegate get_localReferencePoint_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.get_localReferencePoint_InjectedDelegate>("UnityEngine.LODGroup::get_localReferencePoint_Injected");

		// Token: 0x04001867 RID: 6247
		private static readonly LODGroup.set_localReferencePoint_InjectedDelegate set_localReferencePoint_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.set_localReferencePoint_InjectedDelegate>("UnityEngine.LODGroup::set_localReferencePoint_Injected");

		// Token: 0x04001868 RID: 6248
		private static readonly LODGroup.get_worldReferencePoint_InjectedDelegate get_worldReferencePoint_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.get_worldReferencePoint_InjectedDelegate>("UnityEngine.LODGroup::get_worldReferencePoint_Injected");

		// Token: 0x02000BDE RID: 3038
		// (Invoke) Token: 0x060035AE RID: 13742
		private delegate float get_sizeDelegate(IntPtr @this);

		// Token: 0x02000BDF RID: 3039
		// (Invoke) Token: 0x060035B0 RID: 13744
		private delegate void set_sizeDelegate(IntPtr @this, float value);

		// Token: 0x02000BE0 RID: 3040
		// (Invoke) Token: 0x060035B2 RID: 13746
		private delegate int get_lodCountDelegate(IntPtr @this);

		// Token: 0x02000BE1 RID: 3041
		// (Invoke) Token: 0x060035B4 RID: 13748
		private delegate LODFadeMode get_fadeModeDelegate(IntPtr @this);

		// Token: 0x02000BE2 RID: 3042
		// (Invoke) Token: 0x060035B6 RID: 13750
		private delegate void set_fadeModeDelegate(IntPtr @this, LODFadeMode value);

		// Token: 0x02000BE3 RID: 3043
		// (Invoke) Token: 0x060035B8 RID: 13752
		private delegate bool get_animateCrossFadingDelegate(IntPtr @this);

		// Token: 0x02000BE4 RID: 3044
		// (Invoke) Token: 0x060035BA RID: 13754
		private delegate void set_animateCrossFadingDelegate(IntPtr @this, bool value);

		// Token: 0x02000BE5 RID: 3045
		// (Invoke) Token: 0x060035BC RID: 13756
		private delegate bool get_enabledDelegate(IntPtr @this);

		// Token: 0x02000BE6 RID: 3046
		// (Invoke) Token: 0x060035BE RID: 13758
		private delegate void set_enabledDelegate(IntPtr @this, bool value);

		// Token: 0x02000BE7 RID: 3047
		// (Invoke) Token: 0x060035C0 RID: 13760
		private delegate void RecalculateBoundsDelegate(IntPtr @this);

		// Token: 0x02000BE8 RID: 3048
		// (Invoke) Token: 0x060035C2 RID: 13762
		private delegate void ForceLODDelegate(IntPtr @this, int index);

		// Token: 0x02000BE9 RID: 3049
		// (Invoke) Token: 0x060035C4 RID: 13764
		private delegate float get_crossFadeAnimationDurationDelegate();

		// Token: 0x02000BEA RID: 3050
		// (Invoke) Token: 0x060035C6 RID: 13766
		private delegate void set_crossFadeAnimationDurationDelegate(float value);

		// Token: 0x02000BEB RID: 3051
		// (Invoke) Token: 0x060035C8 RID: 13768
		private delegate void get_localReferencePoint_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000BEC RID: 3052
		// (Invoke) Token: 0x060035CA RID: 13770
		private delegate void set_localReferencePoint_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000BED RID: 3053
		// (Invoke) Token: 0x060035CC RID: 13772
		private delegate void get_worldReferencePoint_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
