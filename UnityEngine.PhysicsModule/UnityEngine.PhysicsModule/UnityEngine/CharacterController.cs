using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	public class CharacterController : Collider
	{
		// Token: 0x060000EB RID: 235 RVA: 0x00005908 File Offset: 0x00003B08
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterController()
		{
			Il2CppClassPointerStore<CharacterController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "CharacterController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterController>.NativeClassPtr);
			CharacterController.get_isGroundedDelegateField = IL2CPP.ResolveICall<CharacterController.get_isGroundedDelegate>("UnityEngine.CharacterController::get_isGrounded");
			CharacterController.get_collisionFlagsDelegateField = IL2CPP.ResolveICall<CharacterController.get_collisionFlagsDelegate>("UnityEngine.CharacterController::get_collisionFlags");
			CharacterController.get_radiusDelegateField = IL2CPP.ResolveICall<CharacterController.get_radiusDelegate>("UnityEngine.CharacterController::get_radius");
			CharacterController.set_radiusDelegateField = IL2CPP.ResolveICall<CharacterController.set_radiusDelegate>("UnityEngine.CharacterController::set_radius");
			CharacterController.get_heightDelegateField = IL2CPP.ResolveICall<CharacterController.get_heightDelegate>("UnityEngine.CharacterController::get_height");
			CharacterController.set_heightDelegateField = IL2CPP.ResolveICall<CharacterController.set_heightDelegate>("UnityEngine.CharacterController::set_height");
			CharacterController.get_slopeLimitDelegateField = IL2CPP.ResolveICall<CharacterController.get_slopeLimitDelegate>("UnityEngine.CharacterController::get_slopeLimit");
			CharacterController.set_slopeLimitDelegateField = IL2CPP.ResolveICall<CharacterController.set_slopeLimitDelegate>("UnityEngine.CharacterController::set_slopeLimit");
			CharacterController.get_stepOffsetDelegateField = IL2CPP.ResolveICall<CharacterController.get_stepOffsetDelegate>("UnityEngine.CharacterController::get_stepOffset");
			CharacterController.set_stepOffsetDelegateField = IL2CPP.ResolveICall<CharacterController.set_stepOffsetDelegate>("UnityEngine.CharacterController::set_stepOffset");
			CharacterController.get_skinWidthDelegateField = IL2CPP.ResolveICall<CharacterController.get_skinWidthDelegate>("UnityEngine.CharacterController::get_skinWidth");
			CharacterController.set_skinWidthDelegateField = IL2CPP.ResolveICall<CharacterController.set_skinWidthDelegate>("UnityEngine.CharacterController::set_skinWidth");
			CharacterController.get_minMoveDistanceDelegateField = IL2CPP.ResolveICall<CharacterController.get_minMoveDistanceDelegate>("UnityEngine.CharacterController::get_minMoveDistance");
			CharacterController.set_minMoveDistanceDelegateField = IL2CPP.ResolveICall<CharacterController.set_minMoveDistanceDelegate>("UnityEngine.CharacterController::set_minMoveDistance");
			CharacterController.get_detectCollisionsDelegateField = IL2CPP.ResolveICall<CharacterController.get_detectCollisionsDelegate>("UnityEngine.CharacterController::get_detectCollisions");
			CharacterController.set_detectCollisionsDelegateField = IL2CPP.ResolveICall<CharacterController.set_detectCollisionsDelegate>("UnityEngine.CharacterController::set_detectCollisions");
			CharacterController.get_enableOverlapRecoveryDelegateField = IL2CPP.ResolveICall<CharacterController.get_enableOverlapRecoveryDelegate>("UnityEngine.CharacterController::get_enableOverlapRecovery");
			CharacterController.set_enableOverlapRecoveryDelegateField = IL2CPP.ResolveICall<CharacterController.set_enableOverlapRecoveryDelegate>("UnityEngine.CharacterController::set_enableOverlapRecovery");
			CharacterController.SimpleMove_InjectedDelegateField = IL2CPP.ResolveICall<CharacterController.SimpleMove_InjectedDelegate>("UnityEngine.CharacterController::SimpleMove_Injected");
			CharacterController.Move_InjectedDelegateField = IL2CPP.ResolveICall<CharacterController.Move_InjectedDelegate>("UnityEngine.CharacterController::Move_Injected");
			CharacterController.get_velocity_InjectedDelegateField = IL2CPP.ResolveICall<CharacterController.get_velocity_InjectedDelegate>("UnityEngine.CharacterController::get_velocity_Injected");
			CharacterController.get_center_InjectedDelegateField = IL2CPP.ResolveICall<CharacterController.get_center_InjectedDelegate>("UnityEngine.CharacterController::get_center_Injected");
			CharacterController.set_center_InjectedDelegateField = IL2CPP.ResolveICall<CharacterController.set_center_InjectedDelegate>("UnityEngine.CharacterController::set_center_Injected");
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000029C4 File Offset: 0x00000BC4
		public CharacterController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000029CD File Offset: 0x00000BCD
		public bool SimpleMove(Vector3 speed)
		{
			return this.SimpleMove_Injected(ref speed);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000029D7 File Offset: 0x00000BD7
		public CollisionFlags Move(Vector3 motion)
		{
			return this.Move_Injected(ref motion);
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00005A94 File Offset: 0x00003C94
		public Vector3 velocity
		{
			get
			{
				Vector3 vector;
				this.get_velocity_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x000029E1 File Offset: 0x00000BE1
		public bool isGrounded
		{
			get
			{
				return CharacterController.get_isGroundedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x000029F3 File Offset: 0x00000BF3
		public CollisionFlags collisionFlags
		{
			get
			{
				return CharacterController.get_collisionFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00002A05 File Offset: 0x00000C05
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002A17 File Offset: 0x00000C17
		public float radius
		{
			get
			{
				return CharacterController.get_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterController.set_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00002A2A File Offset: 0x00000C2A
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00002A3C File Offset: 0x00000C3C
		public float height
		{
			get
			{
				return CharacterController.get_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterController.set_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00005AAC File Offset: 0x00003CAC
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00002A4F File Offset: 0x00000C4F
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

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00002A59 File Offset: 0x00000C59
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00002A6B File Offset: 0x00000C6B
		public float slopeLimit
		{
			get
			{
				return CharacterController.get_slopeLimitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterController.set_slopeLimitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00002A7E File Offset: 0x00000C7E
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00002A90 File Offset: 0x00000C90
		public float stepOffset
		{
			get
			{
				return CharacterController.get_stepOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterController.set_stepOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00002AA3 File Offset: 0x00000CA3
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00002AB5 File Offset: 0x00000CB5
		public float skinWidth
		{
			get
			{
				return CharacterController.get_skinWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterController.set_skinWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00002AC8 File Offset: 0x00000CC8
		// (set) Token: 0x060000FF RID: 255 RVA: 0x00002ADA File Offset: 0x00000CDA
		public float minMoveDistance
		{
			get
			{
				return CharacterController.get_minMoveDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterController.set_minMoveDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00002AED File Offset: 0x00000CED
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00002AFF File Offset: 0x00000CFF
		public bool detectCollisions
		{
			get
			{
				return CharacterController.get_detectCollisionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterController.set_detectCollisionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00002B12 File Offset: 0x00000D12
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00002B24 File Offset: 0x00000D24
		public bool enableOverlapRecovery
		{
			get
			{
				return CharacterController.get_enableOverlapRecoveryDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterController.set_enableOverlapRecoveryDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002B37 File Offset: 0x00000D37
		public bool SimpleMove_Injected(ref Vector3 speed)
		{
			return CharacterController.SimpleMove_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref speed);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002B4A File Offset: 0x00000D4A
		public CollisionFlags Move_Injected(ref Vector3 motion)
		{
			return CharacterController.Move_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref motion);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002B5D File Offset: 0x00000D5D
		public void get_velocity_Injected(out Vector3 ret)
		{
			CharacterController.get_velocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002B70 File Offset: 0x00000D70
		public void get_center_Injected(out Vector3 ret)
		{
			CharacterController.get_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002B83 File Offset: 0x00000D83
		public void set_center_Injected(ref Vector3 value)
		{
			CharacterController.set_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000079 RID: 121
		private static readonly CharacterController.get_isGroundedDelegate get_isGroundedDelegateField;

		// Token: 0x0400007A RID: 122
		private static readonly CharacterController.get_collisionFlagsDelegate get_collisionFlagsDelegateField;

		// Token: 0x0400007B RID: 123
		private static readonly CharacterController.get_radiusDelegate get_radiusDelegateField;

		// Token: 0x0400007C RID: 124
		private static readonly CharacterController.set_radiusDelegate set_radiusDelegateField;

		// Token: 0x0400007D RID: 125
		private static readonly CharacterController.get_heightDelegate get_heightDelegateField;

		// Token: 0x0400007E RID: 126
		private static readonly CharacterController.set_heightDelegate set_heightDelegateField;

		// Token: 0x0400007F RID: 127
		private static readonly CharacterController.get_slopeLimitDelegate get_slopeLimitDelegateField;

		// Token: 0x04000080 RID: 128
		private static readonly CharacterController.set_slopeLimitDelegate set_slopeLimitDelegateField;

		// Token: 0x04000081 RID: 129
		private static readonly CharacterController.get_stepOffsetDelegate get_stepOffsetDelegateField;

		// Token: 0x04000082 RID: 130
		private static readonly CharacterController.set_stepOffsetDelegate set_stepOffsetDelegateField;

		// Token: 0x04000083 RID: 131
		private static readonly CharacterController.get_skinWidthDelegate get_skinWidthDelegateField;

		// Token: 0x04000084 RID: 132
		private static readonly CharacterController.set_skinWidthDelegate set_skinWidthDelegateField;

		// Token: 0x04000085 RID: 133
		private static readonly CharacterController.get_minMoveDistanceDelegate get_minMoveDistanceDelegateField;

		// Token: 0x04000086 RID: 134
		private static readonly CharacterController.set_minMoveDistanceDelegate set_minMoveDistanceDelegateField;

		// Token: 0x04000087 RID: 135
		private static readonly CharacterController.get_detectCollisionsDelegate get_detectCollisionsDelegateField;

		// Token: 0x04000088 RID: 136
		private static readonly CharacterController.set_detectCollisionsDelegate set_detectCollisionsDelegateField;

		// Token: 0x04000089 RID: 137
		private static readonly CharacterController.get_enableOverlapRecoveryDelegate get_enableOverlapRecoveryDelegateField;

		// Token: 0x0400008A RID: 138
		private static readonly CharacterController.set_enableOverlapRecoveryDelegate set_enableOverlapRecoveryDelegateField;

		// Token: 0x0400008B RID: 139
		private static readonly CharacterController.SimpleMove_InjectedDelegate SimpleMove_InjectedDelegateField;

		// Token: 0x0400008C RID: 140
		private static readonly CharacterController.Move_InjectedDelegate Move_InjectedDelegateField;

		// Token: 0x0400008D RID: 141
		private static readonly CharacterController.get_velocity_InjectedDelegate get_velocity_InjectedDelegateField;

		// Token: 0x0400008E RID: 142
		private static readonly CharacterController.get_center_InjectedDelegate get_center_InjectedDelegateField;

		// Token: 0x0400008F RID: 143
		private static readonly CharacterController.set_center_InjectedDelegate set_center_InjectedDelegateField;

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x06000411 RID: 1041
		private delegate bool get_isGroundedDelegate(IntPtr @this);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x06000413 RID: 1043
		private delegate CollisionFlags get_collisionFlagsDelegate(IntPtr @this);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x06000415 RID: 1045
		private delegate float get_radiusDelegate(IntPtr @this);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x06000417 RID: 1047
		private delegate void set_radiusDelegate(IntPtr @this, float value);

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x06000419 RID: 1049
		private delegate float get_heightDelegate(IntPtr @this);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x0600041B RID: 1051
		private delegate void set_heightDelegate(IntPtr @this, float value);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x0600041D RID: 1053
		private delegate float get_slopeLimitDelegate(IntPtr @this);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x0600041F RID: 1055
		private delegate void set_slopeLimitDelegate(IntPtr @this, float value);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x06000421 RID: 1057
		private delegate float get_stepOffsetDelegate(IntPtr @this);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x06000423 RID: 1059
		private delegate void set_stepOffsetDelegate(IntPtr @this, float value);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x06000425 RID: 1061
		private delegate float get_skinWidthDelegate(IntPtr @this);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x06000427 RID: 1063
		private delegate void set_skinWidthDelegate(IntPtr @this, float value);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x06000429 RID: 1065
		private delegate float get_minMoveDistanceDelegate(IntPtr @this);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x0600042B RID: 1067
		private delegate void set_minMoveDistanceDelegate(IntPtr @this, float value);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x0600042D RID: 1069
		private delegate bool get_detectCollisionsDelegate(IntPtr @this);

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x0600042F RID: 1071
		private delegate void set_detectCollisionsDelegate(IntPtr @this, bool value);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x06000431 RID: 1073
		private delegate bool get_enableOverlapRecoveryDelegate(IntPtr @this);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x06000433 RID: 1075
		private delegate void set_enableOverlapRecoveryDelegate(IntPtr @this, bool value);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x06000435 RID: 1077
		private delegate bool SimpleMove_InjectedDelegate(IntPtr @this, IntPtr speed);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x06000437 RID: 1079
		private delegate CollisionFlags Move_InjectedDelegate(IntPtr @this, IntPtr motion);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x06000439 RID: 1081
		private delegate void get_velocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x0600043B RID: 1083
		private delegate void get_center_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x0600043D RID: 1085
		private delegate void set_center_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
