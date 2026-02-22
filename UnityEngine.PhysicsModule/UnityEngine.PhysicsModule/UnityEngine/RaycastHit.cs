using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	[StructLayout(2)]
	public struct RaycastHit
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00004A04 File Offset: 0x00002C04
		// Note: this type is marked as 'beforefieldinit'.
		static RaycastHit()
		{
			Il2CppClassPointerStore<RaycastHit>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "RaycastHit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr);
			RaycastHit.NativeFieldInfoPtr_m_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, "m_Point");
			RaycastHit.NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, "m_Normal");
			RaycastHit.NativeFieldInfoPtr_m_FaceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, "m_FaceID");
			RaycastHit.NativeFieldInfoPtr_m_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, "m_Distance");
			RaycastHit.NativeFieldInfoPtr_m_UV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, "m_UV");
			RaycastHit.NativeFieldInfoPtr_m_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, "m_Collider");
			RaycastHit.NativeMethodInfoPtr_get_collider_Public_get_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, 100663297);
			RaycastHit.NativeMethodInfoPtr_get_point_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, 100663298);
			RaycastHit.NativeMethodInfoPtr_get_normal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, 100663299);
			RaycastHit.NativeMethodInfoPtr_get_distance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, 100663300);
			RaycastHit.NativeMethodInfoPtr_get_transform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, 100663301);
			RaycastHit.NativeMethodInfoPtr_get_rigidbody_Public_get_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, 100663302);
			RaycastHit.CalculateRaycastTexCoord_InjectedDelegateField = IL2CPP.ResolveICall<RaycastHit.CalculateRaycastTexCoord_InjectedDelegate>("UnityEngine.RaycastHit::CalculateRaycastTexCoord_Injected");
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00004B34 File Offset: 0x00002D34
		public unsafe Collider collider
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 90341, RefRangeEnd = 90345, XrefRangeStart = 90336, XrefRangeEnd = 90341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit.NativeMethodInfoPtr_get_collider_Public_get_Collider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr3) : null;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00004B68 File Offset: 0x00002D68
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002223 File Offset: 0x00000423
		public unsafe Vector3 point
		{
			[CallerCount(36)]
			[CachedScanResults(RefRangeStart = 61063, RefRangeEnd = 61099, XrefRangeStart = 61063, XrefRangeEnd = 61099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit.NativeMethodInfoPtr_get_point_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Point = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00004B98 File Offset: 0x00002D98
		// (set) Token: 0x06000047 RID: 71 RVA: 0x0000222D File Offset: 0x0000042D
		public unsafe Vector3 normal
		{
			[CallerCount(64)]
			[CachedScanResults(RefRangeStart = 61152, RefRangeEnd = 61216, XrefRangeStart = 61152, XrefRangeEnd = 61216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit.NativeMethodInfoPtr_get_normal_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Normal = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00004BC8 File Offset: 0x00002DC8
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00002246 File Offset: 0x00000446
		public unsafe float distance
		{
			[CallerCount(32)]
			[CachedScanResults(RefRangeStart = 88870, RefRangeEnd = 88902, XrefRangeStart = 88870, XrefRangeEnd = 88902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit.NativeMethodInfoPtr_get_distance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Distance = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00004BF8 File Offset: 0x00002DF8
		public unsafe Transform transform
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 90354, RefRangeEnd = 90357, XrefRangeStart = 90345, XrefRangeEnd = 90354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit.NativeMethodInfoPtr_get_transform_Public_get_Transform_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00004C2C File Offset: 0x00002E2C
		public unsafe Rigidbody rigidbody
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 90365, RefRangeEnd = 90366, XrefRangeStart = 90357, XrefRangeEnd = 90365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit.NativeMethodInfoPtr_get_rigidbody_Public_get_Rigidbody_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr3) : null;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002211 File Offset: 0x00000411
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RaycastHit>.NativeClassPtr, ref this));
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00004C60 File Offset: 0x00002E60
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00002237 File Offset: 0x00000437
		public Vector3 barycentricCoordinate
		{
			get
			{
				return new Vector3(1f - (this.m_UV.y + this.m_UV.x), this.m_UV.x, this.m_UV.y);
			}
			set
			{
				this.m_UV = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00004CAC File Offset: 0x00002EAC
		public int triangleIndex
		{
			get
			{
				return (int)this.m_FaceID;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00004CC4 File Offset: 0x00002EC4
		public static Vector2 CalculateRaycastTexCoord(Collider collider, Vector2 uv, Vector3 pos, uint face, int textcoord)
		{
			Vector2 vector;
			RaycastHit.CalculateRaycastTexCoord_Injected(collider, ref uv, ref pos, face, textcoord, out vector);
			return vector;
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00004CE4 File Offset: 0x00002EE4
		public Vector2 textureCoord
		{
			get
			{
				return RaycastHit.CalculateRaycastTexCoord(this.collider, this.m_UV, this.m_Point, this.m_FaceID, 0);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00004D14 File Offset: 0x00002F14
		public Vector2 textureCoord2
		{
			get
			{
				return RaycastHit.CalculateRaycastTexCoord(this.collider, this.m_UV, this.m_Point, this.m_FaceID, 1);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00004D44 File Offset: 0x00002F44
		public ArticulationBody articulationBody
		{
			get
			{
				return (this.collider != null) ? this.collider.attachedArticulationBody : null;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00004D74 File Offset: 0x00002F74
		public Vector2 lightmapCoord
		{
			get
			{
				Vector2 vector = RaycastHit.CalculateRaycastTexCoord(this.collider, this.m_UV, this.m_Point, this.m_FaceID, 1);
				bool flag = this.collider.GetComponent<Renderer>() != null;
				if (flag)
				{
					Vector4 lightmapScaleOffset = this.collider.GetComponent<Renderer>().lightmapScaleOffset;
					vector.x = vector.x * lightmapScaleOffset.x + lightmapScaleOffset.z;
					vector.y = vector.y * lightmapScaleOffset.y + lightmapScaleOffset.w;
				}
				return vector;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00004E04 File Offset: 0x00003004
		public Vector2 textureCoord1
		{
			get
			{
				return this.textureCoord2;
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002250 File Offset: 0x00000450
		public static void CalculateRaycastTexCoord_Injected(Collider collider, ref Vector2 uv, ref Vector3 pos, uint face, int textcoord, out Vector2 ret)
		{
			RaycastHit.CalculateRaycastTexCoord_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(collider), ref uv, ref pos, face, textcoord, out ret);
		}

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_m_Point;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_m_Normal;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_m_FaceID;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_m_Distance;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_m_UV;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_m_Collider;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_get_collider_Public_get_Collider_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_get_point_Public_get_Vector3_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_get_normal_Public_get_Vector3_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_get_distance_Public_get_Single_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_get_transform_Public_get_Transform_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_get_rigidbody_Public_get_Rigidbody_0;

		// Token: 0x0400001F RID: 31
		[FieldOffset(0)]
		public Vector3 m_Point;

		// Token: 0x04000020 RID: 32
		[FieldOffset(12)]
		public Vector3 m_Normal;

		// Token: 0x04000021 RID: 33
		[FieldOffset(24)]
		public uint m_FaceID;

		// Token: 0x04000022 RID: 34
		[FieldOffset(28)]
		public float m_Distance;

		// Token: 0x04000023 RID: 35
		[FieldOffset(32)]
		public Vector2 m_UV;

		// Token: 0x04000024 RID: 36
		[FieldOffset(40)]
		public int m_Collider;

		// Token: 0x04000025 RID: 37
		private static readonly RaycastHit.CalculateRaycastTexCoord_InjectedDelegate CalculateRaycastTexCoord_InjectedDelegateField;

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x06000377 RID: 887
		private delegate void CalculateRaycastTexCoord_InjectedDelegate(IntPtr collider, IntPtr uv, IntPtr pos, uint face, int textcoord, [Out] IntPtr ret);
	}
}
