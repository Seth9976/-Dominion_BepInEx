using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine.AI
{
	// Token: 0x0200000B RID: 11
	public sealed class NavMeshObstacle : Behaviour
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00002800 File Offset: 0x00000A00
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00002812 File Offset: 0x00000A12
		public float height
		{
			get
			{
				return NavMeshObstacle.get_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshObstacle.set_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00002825 File Offset: 0x00000A25
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00002837 File Offset: 0x00000A37
		public float radius
		{
			get
			{
				return NavMeshObstacle.get_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshObstacle.set_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000092 RID: 146 RVA: 0x000035A8 File Offset: 0x000017A8
		// (set) Token: 0x06000093 RID: 147 RVA: 0x0000284A File Offset: 0x00000A4A
		public Vector3 velocity
		{
			get
			{
				Vector3 vector;
				this.get_velocity_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_velocity_Injected(ref value);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00002854 File Offset: 0x00000A54
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00002866 File Offset: 0x00000A66
		public bool carving
		{
			get
			{
				return NavMeshObstacle.get_carvingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshObstacle.set_carvingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00002879 File Offset: 0x00000A79
		// (set) Token: 0x06000097 RID: 151 RVA: 0x0000288B File Offset: 0x00000A8B
		public bool carveOnlyStationary
		{
			get
			{
				return NavMeshObstacle.get_carveOnlyStationaryDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshObstacle.set_carveOnlyStationaryDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000098 RID: 152 RVA: 0x0000289E File Offset: 0x00000A9E
		// (set) Token: 0x06000099 RID: 153 RVA: 0x000028B0 File Offset: 0x00000AB0
		public float carvingMoveThreshold
		{
			get
			{
				return NavMeshObstacle.get_carvingMoveThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshObstacle.set_carvingMoveThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000028C3 File Offset: 0x00000AC3
		// (set) Token: 0x0600009B RID: 155 RVA: 0x000028D5 File Offset: 0x00000AD5
		public float carvingTimeToStationary
		{
			get
			{
				return NavMeshObstacle.get_carvingTimeToStationaryDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshObstacle.set_carvingTimeToStationaryDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600009C RID: 156 RVA: 0x000028E8 File Offset: 0x00000AE8
		// (set) Token: 0x0600009D RID: 157 RVA: 0x000028FA File Offset: 0x00000AFA
		public NavMeshObstacleShape shape
		{
			get
			{
				return NavMeshObstacle.get_shapeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				NavMeshObstacle.set_shapeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000035C0 File Offset: 0x000017C0
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0000290D File Offset: 0x00000B0D
		public Vector3 center
		{
			get
			{
				Vector3 vector;
				this.get_center_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_center_Injected(ref value);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000035D8 File Offset: 0x000017D8
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00002917 File Offset: 0x00000B17
		public Vector3 size
		{
			get
			{
				Vector3 vector;
				this.get_size_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_size_Injected(ref value);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002921 File Offset: 0x00000B21
		public void FitExtents()
		{
			NavMeshObstacle.FitExtentsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002933 File Offset: 0x00000B33
		public void get_velocity_Injected(out Vector3 ret)
		{
			NavMeshObstacle.get_velocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002946 File Offset: 0x00000B46
		public void set_velocity_Injected(ref Vector3 value)
		{
			NavMeshObstacle.set_velocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002959 File Offset: 0x00000B59
		public void get_center_Injected(out Vector3 ret)
		{
			NavMeshObstacle.get_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000296C File Offset: 0x00000B6C
		public void set_center_Injected(ref Vector3 value)
		{
			NavMeshObstacle.set_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000297F File Offset: 0x00000B7F
		public void get_size_Injected(out Vector3 ret)
		{
			NavMeshObstacle.get_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002992 File Offset: 0x00000B92
		public void set_size_Injected(ref Vector3 value)
		{
			NavMeshObstacle.set_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000076 RID: 118
		private static readonly NavMeshObstacle.get_heightDelegate get_heightDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.get_heightDelegate>("UnityEngine.AI.NavMeshObstacle::get_height");

		// Token: 0x04000077 RID: 119
		private static readonly NavMeshObstacle.set_heightDelegate set_heightDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.set_heightDelegate>("UnityEngine.AI.NavMeshObstacle::set_height");

		// Token: 0x04000078 RID: 120
		private static readonly NavMeshObstacle.get_radiusDelegate get_radiusDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.get_radiusDelegate>("UnityEngine.AI.NavMeshObstacle::get_radius");

		// Token: 0x04000079 RID: 121
		private static readonly NavMeshObstacle.set_radiusDelegate set_radiusDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.set_radiusDelegate>("UnityEngine.AI.NavMeshObstacle::set_radius");

		// Token: 0x0400007A RID: 122
		private static readonly NavMeshObstacle.get_carvingDelegate get_carvingDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.get_carvingDelegate>("UnityEngine.AI.NavMeshObstacle::get_carving");

		// Token: 0x0400007B RID: 123
		private static readonly NavMeshObstacle.set_carvingDelegate set_carvingDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.set_carvingDelegate>("UnityEngine.AI.NavMeshObstacle::set_carving");

		// Token: 0x0400007C RID: 124
		private static readonly NavMeshObstacle.get_carveOnlyStationaryDelegate get_carveOnlyStationaryDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.get_carveOnlyStationaryDelegate>("UnityEngine.AI.NavMeshObstacle::get_carveOnlyStationary");

		// Token: 0x0400007D RID: 125
		private static readonly NavMeshObstacle.set_carveOnlyStationaryDelegate set_carveOnlyStationaryDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.set_carveOnlyStationaryDelegate>("UnityEngine.AI.NavMeshObstacle::set_carveOnlyStationary");

		// Token: 0x0400007E RID: 126
		private static readonly NavMeshObstacle.get_carvingMoveThresholdDelegate get_carvingMoveThresholdDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.get_carvingMoveThresholdDelegate>("UnityEngine.AI.NavMeshObstacle::get_carvingMoveThreshold");

		// Token: 0x0400007F RID: 127
		private static readonly NavMeshObstacle.set_carvingMoveThresholdDelegate set_carvingMoveThresholdDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.set_carvingMoveThresholdDelegate>("UnityEngine.AI.NavMeshObstacle::set_carvingMoveThreshold");

		// Token: 0x04000080 RID: 128
		private static readonly NavMeshObstacle.get_carvingTimeToStationaryDelegate get_carvingTimeToStationaryDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.get_carvingTimeToStationaryDelegate>("UnityEngine.AI.NavMeshObstacle::get_carvingTimeToStationary");

		// Token: 0x04000081 RID: 129
		private static readonly NavMeshObstacle.set_carvingTimeToStationaryDelegate set_carvingTimeToStationaryDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.set_carvingTimeToStationaryDelegate>("UnityEngine.AI.NavMeshObstacle::set_carvingTimeToStationary");

		// Token: 0x04000082 RID: 130
		private static readonly NavMeshObstacle.get_shapeDelegate get_shapeDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.get_shapeDelegate>("UnityEngine.AI.NavMeshObstacle::get_shape");

		// Token: 0x04000083 RID: 131
		private static readonly NavMeshObstacle.set_shapeDelegate set_shapeDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.set_shapeDelegate>("UnityEngine.AI.NavMeshObstacle::set_shape");

		// Token: 0x04000084 RID: 132
		private static readonly NavMeshObstacle.FitExtentsDelegate FitExtentsDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.FitExtentsDelegate>("UnityEngine.AI.NavMeshObstacle::FitExtents");

		// Token: 0x04000085 RID: 133
		private static readonly NavMeshObstacle.get_velocity_InjectedDelegate get_velocity_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.get_velocity_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::get_velocity_Injected");

		// Token: 0x04000086 RID: 134
		private static readonly NavMeshObstacle.set_velocity_InjectedDelegate set_velocity_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.set_velocity_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::set_velocity_Injected");

		// Token: 0x04000087 RID: 135
		private static readonly NavMeshObstacle.get_center_InjectedDelegate get_center_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.get_center_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::get_center_Injected");

		// Token: 0x04000088 RID: 136
		private static readonly NavMeshObstacle.set_center_InjectedDelegate set_center_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.set_center_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::set_center_Injected");

		// Token: 0x04000089 RID: 137
		private static readonly NavMeshObstacle.get_size_InjectedDelegate get_size_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.get_size_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::get_size_Injected");

		// Token: 0x0400008A RID: 138
		private static readonly NavMeshObstacle.set_size_InjectedDelegate set_size_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshObstacle.set_size_InjectedDelegate>("UnityEngine.AI.NavMeshObstacle::set_size_Injected");

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x0600019B RID: 411
		private delegate float get_heightDelegate(IntPtr @this);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x0600019D RID: 413
		private delegate void set_heightDelegate(IntPtr @this, float value);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x0600019F RID: 415
		private delegate float get_radiusDelegate(IntPtr @this);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x060001A1 RID: 417
		private delegate void set_radiusDelegate(IntPtr @this, float value);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x060001A3 RID: 419
		private delegate bool get_carvingDelegate(IntPtr @this);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x060001A5 RID: 421
		private delegate void set_carvingDelegate(IntPtr @this, bool value);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x060001A7 RID: 423
		private delegate bool get_carveOnlyStationaryDelegate(IntPtr @this);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x060001A9 RID: 425
		private delegate void set_carveOnlyStationaryDelegate(IntPtr @this, bool value);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x060001AB RID: 427
		private delegate float get_carvingMoveThresholdDelegate(IntPtr @this);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x060001AD RID: 429
		private delegate void set_carvingMoveThresholdDelegate(IntPtr @this, float value);

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x060001AF RID: 431
		private delegate float get_carvingTimeToStationaryDelegate(IntPtr @this);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x060001B1 RID: 433
		private delegate void set_carvingTimeToStationaryDelegate(IntPtr @this, float value);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x060001B3 RID: 435
		private delegate NavMeshObstacleShape get_shapeDelegate(IntPtr @this);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x060001B5 RID: 437
		private delegate void set_shapeDelegate(IntPtr @this, NavMeshObstacleShape value);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x060001B7 RID: 439
		private delegate void FitExtentsDelegate(IntPtr @this);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x060001B9 RID: 441
		private delegate void get_velocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x060001BB RID: 443
		private delegate void set_velocity_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x060001BD RID: 445
		private delegate void get_center_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x060001BF RID: 447
		private delegate void set_center_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x060001C1 RID: 449
		private delegate void get_size_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x060001C3 RID: 451
		private delegate void set_size_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
