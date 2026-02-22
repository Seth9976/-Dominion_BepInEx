using System;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000246 RID: 582
	[Serializable]
	public struct Pose
	{
		// Token: 0x06001F60 RID: 8032 RVA: 0x00012089 File Offset: 0x00010289
		public override string ToString()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x00012096 File Offset: 0x00010296
		public string ToString(string format)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x00066510 File Offset: 0x00064710
		public Pose GetTransformedBy(Pose lhs)
		{
			return new Pose
			{
				position = lhs.position + lhs.rotation * this.position,
				rotation = lhs.rotation * this.rotation
			};
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x00066568 File Offset: 0x00064768
		public Pose GetTransformedBy(Transform lhs)
		{
			return new Pose
			{
				position = lhs.TransformPoint(this.position),
				rotation = lhs.rotation * this.rotation
			};
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06001F64 RID: 8036 RVA: 0x000665B0 File Offset: 0x000647B0
		public Vector3 forward
		{
			get
			{
				return this.rotation * Vector3.forward;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001F65 RID: 8037 RVA: 0x000665D4 File Offset: 0x000647D4
		public Vector3 right
		{
			get
			{
				return this.rotation * Vector3.right;
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001F66 RID: 8038 RVA: 0x000665F8 File Offset: 0x000647F8
		public Vector3 up
		{
			get
			{
				return this.rotation * Vector3.up;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001F67 RID: 8039 RVA: 0x000120A3 File Offset: 0x000102A3
		public static Pose identity
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x0006661C File Offset: 0x0006481C
		public override bool Equals(Object obj)
		{
			bool flag = !(obj is Pose);
			return !flag && this.Equals((Pose)obj);
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x00066650 File Offset: 0x00064850
		public bool Equals(Pose other)
		{
			return this.position == other.position && this.rotation == other.rotation;
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x0006668C File Offset: 0x0006488C
		public override int GetHashCode()
		{
			return this.position.GetHashCode() ^ (this.rotation.GetHashCode() << 1);
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x000666C4 File Offset: 0x000648C4
		public static bool operator ==(Pose a, Pose b)
		{
			return a.Equals(b);
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x000666E0 File Offset: 0x000648E0
		public static bool operator !=(Pose a, Pose b)
		{
			return !(a == b);
		}

		// Token: 0x040018C6 RID: 6342
		public Vector3 position;

		// Token: 0x040018C7 RID: 6343
		public Quaternion rotation;
	}
}
