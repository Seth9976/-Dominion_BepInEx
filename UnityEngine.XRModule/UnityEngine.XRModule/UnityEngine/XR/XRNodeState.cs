using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.XR
{
	// Token: 0x02000007 RID: 7
	[StructLayout(2)]
	public struct XRNodeState
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00003070 File Offset: 0x00001270
		// Note: this type is marked as 'beforefieldinit'.
		static XRNodeState()
		{
			Il2CppClassPointerStore<XRNodeState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "XRNodeState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr);
			XRNodeState.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, "m_Type");
			XRNodeState.NativeFieldInfoPtr_m_AvailableFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, "m_AvailableFields");
			XRNodeState.NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, "m_Position");
			XRNodeState.NativeFieldInfoPtr_m_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, "m_Rotation");
			XRNodeState.NativeFieldInfoPtr_m_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, "m_Velocity");
			XRNodeState.NativeFieldInfoPtr_m_AngularVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, "m_AngularVelocity");
			XRNodeState.NativeFieldInfoPtr_m_Acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, "m_Acceleration");
			XRNodeState.NativeFieldInfoPtr_m_AngularAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, "m_AngularAcceleration");
			XRNodeState.NativeFieldInfoPtr_m_Tracked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, "m_Tracked");
			XRNodeState.NativeFieldInfoPtr_m_UniqueID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, "m_UniqueID");
			XRNodeState.NativeMethodInfoPtr_set_uniqueID_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, 100663301);
			XRNodeState.NativeMethodInfoPtr_set_nodeType_Public_set_Void_XRNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, 100663302);
			XRNodeState.NativeMethodInfoPtr_set_tracked_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, 100663303);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00003240 File Offset: 0x00001440
		// (set) Token: 0x06000027 RID: 39 RVA: 0x000031A4 File Offset: 0x000013A4
		public unsafe ulong uniqueID
		{
			get
			{
				return this.m_UniqueID;
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRNodeState.NativeMethodInfoPtr_set_uniqueID_Public_set_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00003258 File Offset: 0x00001458
		// (set) Token: 0x06000028 RID: 40 RVA: 0x000031D8 File Offset: 0x000013D8
		public unsafe XRNode nodeType
		{
			get
			{
				return this.m_Type;
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRNodeState.NativeMethodInfoPtr_set_nodeType_Public_set_Void_XRNode_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00003270 File Offset: 0x00001470
		// (set) Token: 0x06000029 RID: 41 RVA: 0x0000320C File Offset: 0x0000140C
		public unsafe bool tracked
		{
			get
			{
				return this.m_Tracked == 1;
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRNodeState.NativeMethodInfoPtr_set_tracked_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002200 File Offset: 0x00000400
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, ref this));
		}

		// Token: 0x17000009 RID: 9
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00002212 File Offset: 0x00000412
		public Vector3 position
		{
			set
			{
				this.m_Position = value;
				this.m_AvailableFields |= AvailableTrackingData.PositionAvailable;
			}
		}

		// Token: 0x1700000A RID: 10
		// (set) Token: 0x0600002F RID: 47 RVA: 0x0000222A File Offset: 0x0000042A
		public Quaternion rotation
		{
			set
			{
				this.m_Rotation = value;
				this.m_AvailableFields |= AvailableTrackingData.RotationAvailable;
			}
		}

		// Token: 0x1700000B RID: 11
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002242 File Offset: 0x00000442
		public Vector3 velocity
		{
			set
			{
				this.m_Velocity = value;
				this.m_AvailableFields |= AvailableTrackingData.VelocityAvailable;
			}
		}

		// Token: 0x1700000C RID: 12
		// (set) Token: 0x06000031 RID: 49 RVA: 0x0000225A File Offset: 0x0000045A
		public Vector3 angularVelocity
		{
			set
			{
				this.m_AngularVelocity = value;
				this.m_AvailableFields |= AvailableTrackingData.AngularVelocityAvailable;
			}
		}

		// Token: 0x1700000D RID: 13
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00002272 File Offset: 0x00000472
		public Vector3 acceleration
		{
			set
			{
				this.m_Acceleration = value;
				this.m_AvailableFields |= AvailableTrackingData.AccelerationAvailable;
			}
		}

		// Token: 0x1700000E RID: 14
		// (set) Token: 0x06000033 RID: 51 RVA: 0x0000228B File Offset: 0x0000048B
		public Vector3 angularAcceleration
		{
			set
			{
				this.m_AngularAcceleration = value;
				this.m_AvailableFields |= AvailableTrackingData.AngularAccelerationAvailable;
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000328C File Offset: 0x0000148C
		public bool TryGetPosition(out Vector3 position)
		{
			return this.TryGet(this.m_Position, AvailableTrackingData.PositionAvailable, out position);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000032AC File Offset: 0x000014AC
		public bool TryGetRotation(out Quaternion rotation)
		{
			return this.TryGet(this.m_Rotation, AvailableTrackingData.RotationAvailable, out rotation);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000032CC File Offset: 0x000014CC
		public bool TryGetVelocity(out Vector3 velocity)
		{
			return this.TryGet(this.m_Velocity, AvailableTrackingData.VelocityAvailable, out velocity);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000032EC File Offset: 0x000014EC
		public bool TryGetAngularVelocity(out Vector3 angularVelocity)
		{
			return this.TryGet(this.m_AngularVelocity, AvailableTrackingData.AngularVelocityAvailable, out angularVelocity);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000330C File Offset: 0x0000150C
		public bool TryGetAcceleration(out Vector3 acceleration)
		{
			return this.TryGet(this.m_Acceleration, AvailableTrackingData.AccelerationAvailable, out acceleration);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003330 File Offset: 0x00001530
		public bool TryGetAngularAcceleration(out Vector3 angularAcceleration)
		{
			return this.TryGet(this.m_AngularAcceleration, AvailableTrackingData.AngularAccelerationAvailable, out angularAcceleration);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003354 File Offset: 0x00001554
		public bool TryGet(Vector3 inValue, AvailableTrackingData availabilityFlag, out Vector3 outValue)
		{
			bool flag = (this.m_AvailableFields & availabilityFlag) > AvailableTrackingData.None;
			bool flag2;
			if (flag)
			{
				outValue = inValue;
				flag2 = true;
			}
			else
			{
				outValue = Vector3.zero;
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003390 File Offset: 0x00001590
		public bool TryGet(Quaternion inValue, AvailableTrackingData availabilityFlag, out Quaternion outValue)
		{
			bool flag = (this.m_AvailableFields & availabilityFlag) > AvailableTrackingData.None;
			bool flag2;
			if (flag)
			{
				outValue = inValue;
				flag2 = true;
			}
			else
			{
				outValue = Quaternion.identity;
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_m_AvailableFields;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_m_Position;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_m_Rotation;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr_m_Velocity;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_m_AngularVelocity;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_m_Acceleration;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_m_AngularAcceleration;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_m_Tracked;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_m_UniqueID;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_set_uniqueID_Public_set_Void_UInt64_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_set_nodeType_Public_set_Void_XRNode_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_set_tracked_Public_set_Void_Boolean_0;

		// Token: 0x04000030 RID: 48
		[FieldOffset(0)]
		public XRNode m_Type;

		// Token: 0x04000031 RID: 49
		[FieldOffset(4)]
		public AvailableTrackingData m_AvailableFields;

		// Token: 0x04000032 RID: 50
		[FieldOffset(8)]
		public Vector3 m_Position;

		// Token: 0x04000033 RID: 51
		[FieldOffset(20)]
		public Quaternion m_Rotation;

		// Token: 0x04000034 RID: 52
		[FieldOffset(36)]
		public Vector3 m_Velocity;

		// Token: 0x04000035 RID: 53
		[FieldOffset(48)]
		public Vector3 m_AngularVelocity;

		// Token: 0x04000036 RID: 54
		[FieldOffset(60)]
		public Vector3 m_Acceleration;

		// Token: 0x04000037 RID: 55
		[FieldOffset(72)]
		public Vector3 m_AngularAcceleration;

		// Token: 0x04000038 RID: 56
		[FieldOffset(84)]
		public int m_Tracked;

		// Token: 0x04000039 RID: 57
		[FieldOffset(88)]
		public ulong m_UniqueID;
	}
}
