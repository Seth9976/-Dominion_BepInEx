using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	public class Gyroscope
	{
		// Token: 0x0600007A RID: 122 RVA: 0x000039C8 File Offset: 0x00001BC8
		public static Vector3 rotationRate_Internal(int idx)
		{
			Vector3 vector;
			Gyroscope.rotationRate_Internal_Injected(idx, out vector);
			return vector;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000039E0 File Offset: 0x00001BE0
		public static Vector3 rotationRateUnbiased_Internal(int idx)
		{
			Vector3 vector;
			Gyroscope.rotationRateUnbiased_Internal_Injected(idx, out vector);
			return vector;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000039F8 File Offset: 0x00001BF8
		public static Vector3 gravity_Internal(int idx)
		{
			Vector3 vector;
			Gyroscope.gravity_Internal_Injected(idx, out vector);
			return vector;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003A10 File Offset: 0x00001C10
		public static Vector3 userAcceleration_Internal(int idx)
		{
			Vector3 vector;
			Gyroscope.userAcceleration_Internal_Injected(idx, out vector);
			return vector;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003A28 File Offset: 0x00001C28
		public static Quaternion attitude_Internal(int idx)
		{
			Quaternion quaternion;
			Gyroscope.attitude_Internal_Injected(idx, out quaternion);
			return quaternion;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000022FD File Offset: 0x000004FD
		public static bool getEnabled_Internal(int idx)
		{
			return Gyroscope.getEnabled_InternalDelegateField(idx);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000230A File Offset: 0x0000050A
		public static void setEnabled_Internal(int idx, bool enabled)
		{
			Gyroscope.setEnabled_InternalDelegateField(idx, enabled);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002318 File Offset: 0x00000518
		public static float getUpdateInterval_Internal(int idx)
		{
			return Gyroscope.getUpdateInterval_InternalDelegateField(idx);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002325 File Offset: 0x00000525
		public static void setUpdateInterval_Internal(int idx, float interval)
		{
			Gyroscope.setUpdateInterval_InternalDelegateField(idx, interval);
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00002333 File Offset: 0x00000533
		public Vector3 rotationRate
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00002340 File Offset: 0x00000540
		public Vector3 rotationRateUnbiased
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0000234D File Offset: 0x0000054D
		public Vector3 gravity
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0000235A File Offset: 0x0000055A
		public Vector3 userAcceleration
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00002367 File Offset: 0x00000567
		public Quaternion attitude
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00002374 File Offset: 0x00000574
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00002381 File Offset: 0x00000581
		public bool enabled
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0000238E File Offset: 0x0000058E
		// (set) Token: 0x0600008B RID: 139 RVA: 0x0000239B File Offset: 0x0000059B
		public float updateInterval
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000023A8 File Offset: 0x000005A8
		public static void rotationRate_Internal_Injected(int idx, out Vector3 ret)
		{
			Gyroscope.rotationRate_Internal_InjectedDelegateField(idx, out ret);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000023B6 File Offset: 0x000005B6
		public static void rotationRateUnbiased_Internal_Injected(int idx, out Vector3 ret)
		{
			Gyroscope.rotationRateUnbiased_Internal_InjectedDelegateField(idx, out ret);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000023C4 File Offset: 0x000005C4
		public static void gravity_Internal_Injected(int idx, out Vector3 ret)
		{
			Gyroscope.gravity_Internal_InjectedDelegateField(idx, out ret);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000023D2 File Offset: 0x000005D2
		public static void userAcceleration_Internal_Injected(int idx, out Vector3 ret)
		{
			Gyroscope.userAcceleration_Internal_InjectedDelegateField(idx, out ret);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000023E0 File Offset: 0x000005E0
		public static void attitude_Internal_Injected(int idx, out Quaternion ret)
		{
			Gyroscope.attitude_Internal_InjectedDelegateField(idx, out ret);
		}

		// Token: 0x04000085 RID: 133
		private static readonly Gyroscope.getEnabled_InternalDelegate getEnabled_InternalDelegateField = IL2CPP.ResolveICall<Gyroscope.getEnabled_InternalDelegate>("UnityEngine.Gyroscope::getEnabled_Internal");

		// Token: 0x04000086 RID: 134
		private static readonly Gyroscope.setEnabled_InternalDelegate setEnabled_InternalDelegateField = IL2CPP.ResolveICall<Gyroscope.setEnabled_InternalDelegate>("UnityEngine.Gyroscope::setEnabled_Internal");

		// Token: 0x04000087 RID: 135
		private static readonly Gyroscope.getUpdateInterval_InternalDelegate getUpdateInterval_InternalDelegateField = IL2CPP.ResolveICall<Gyroscope.getUpdateInterval_InternalDelegate>("UnityEngine.Gyroscope::getUpdateInterval_Internal");

		// Token: 0x04000088 RID: 136
		private static readonly Gyroscope.setUpdateInterval_InternalDelegate setUpdateInterval_InternalDelegateField = IL2CPP.ResolveICall<Gyroscope.setUpdateInterval_InternalDelegate>("UnityEngine.Gyroscope::setUpdateInterval_Internal");

		// Token: 0x04000089 RID: 137
		private static readonly Gyroscope.rotationRate_Internal_InjectedDelegate rotationRate_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Gyroscope.rotationRate_Internal_InjectedDelegate>("UnityEngine.Gyroscope::rotationRate_Internal_Injected");

		// Token: 0x0400008A RID: 138
		private static readonly Gyroscope.rotationRateUnbiased_Internal_InjectedDelegate rotationRateUnbiased_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Gyroscope.rotationRateUnbiased_Internal_InjectedDelegate>("UnityEngine.Gyroscope::rotationRateUnbiased_Internal_Injected");

		// Token: 0x0400008B RID: 139
		private static readonly Gyroscope.gravity_Internal_InjectedDelegate gravity_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Gyroscope.gravity_Internal_InjectedDelegate>("UnityEngine.Gyroscope::gravity_Internal_Injected");

		// Token: 0x0400008C RID: 140
		private static readonly Gyroscope.userAcceleration_Internal_InjectedDelegate userAcceleration_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Gyroscope.userAcceleration_Internal_InjectedDelegate>("UnityEngine.Gyroscope::userAcceleration_Internal_Injected");

		// Token: 0x0400008D RID: 141
		private static readonly Gyroscope.attitude_Internal_InjectedDelegate attitude_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Gyroscope.attitude_Internal_InjectedDelegate>("UnityEngine.Gyroscope::attitude_Internal_Injected");

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x060000EA RID: 234
		private delegate bool getEnabled_InternalDelegate(int idx);

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x060000EC RID: 236
		private delegate void setEnabled_InternalDelegate(int idx, bool enabled);

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x060000EE RID: 238
		private delegate float getUpdateInterval_InternalDelegate(int idx);

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x060000F0 RID: 240
		private delegate void setUpdateInterval_InternalDelegate(int idx, float interval);

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x060000F2 RID: 242
		private delegate void rotationRate_Internal_InjectedDelegate(int idx, [Out] IntPtr ret);

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x060000F4 RID: 244
		private delegate void rotationRateUnbiased_Internal_InjectedDelegate(int idx, [Out] IntPtr ret);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x060000F6 RID: 246
		private delegate void gravity_Internal_InjectedDelegate(int idx, [Out] IntPtr ret);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x060000F8 RID: 248
		private delegate void userAcceleration_Internal_InjectedDelegate(int idx, [Out] IntPtr ret);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x060000FA RID: 250
		private delegate void attitude_Internal_InjectedDelegate(int idx, [Out] IntPtr ret);
	}
}
