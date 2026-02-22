using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	public class Collider : Component
	{
		// Token: 0x060000D3 RID: 211 RVA: 0x00005638 File Offset: 0x00003838
		// Note: this type is marked as 'beforefieldinit'.
		static Collider()
		{
			Il2CppClassPointerStore<Collider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "Collider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Collider>.NativeClassPtr);
			Collider.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663308);
			Collider.NativeMethodInfoPtr_get_attachedRigidbody_Public_get_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663309);
			Collider.get_enabledDelegateField = IL2CPP.ResolveICall<Collider.get_enabledDelegate>("UnityEngine.Collider::get_enabled");
			Collider.get_attachedArticulationBodyDelegateField = IL2CPP.ResolveICall<Collider.get_attachedArticulationBodyDelegate>("UnityEngine.Collider::get_attachedArticulationBody");
			Collider.get_isTriggerDelegateField = IL2CPP.ResolveICall<Collider.get_isTriggerDelegate>("UnityEngine.Collider::get_isTrigger");
			Collider.set_isTriggerDelegateField = IL2CPP.ResolveICall<Collider.set_isTriggerDelegate>("UnityEngine.Collider::set_isTrigger");
			Collider.get_contactOffsetDelegateField = IL2CPP.ResolveICall<Collider.get_contactOffsetDelegate>("UnityEngine.Collider::get_contactOffset");
			Collider.set_contactOffsetDelegateField = IL2CPP.ResolveICall<Collider.set_contactOffsetDelegate>("UnityEngine.Collider::set_contactOffset");
			Collider.get_sharedMaterialDelegateField = IL2CPP.ResolveICall<Collider.get_sharedMaterialDelegate>("UnityEngine.Collider::get_sharedMaterial");
			Collider.set_sharedMaterialDelegateField = IL2CPP.ResolveICall<Collider.set_sharedMaterialDelegate>("UnityEngine.Collider::set_sharedMaterial");
			Collider.get_materialDelegateField = IL2CPP.ResolveICall<Collider.get_materialDelegate>("UnityEngine.Collider::get_material");
			Collider.set_materialDelegateField = IL2CPP.ResolveICall<Collider.set_materialDelegate>("UnityEngine.Collider::set_material");
			Collider.ClosestPoint_InjectedDelegateField = IL2CPP.ResolveICall<Collider.ClosestPoint_InjectedDelegate>("UnityEngine.Collider::ClosestPoint_Injected");
			Collider.get_bounds_InjectedDelegateField = IL2CPP.ResolveICall<Collider.get_bounds_InjectedDelegate>("UnityEngine.Collider::get_bounds_Injected");
			Collider.Raycast_InjectedDelegateField = IL2CPP.ResolveICall<Collider.Raycast_InjectedDelegate>("UnityEngine.Collider::Raycast_Injected");
			Collider.Internal_ClosestPointOnBounds_InjectedDelegateField = IL2CPP.ResolveICall<Collider.Internal_ClosestPointOnBounds_InjectedDelegate>("UnityEngine.Collider::Internal_ClosestPointOnBounds_Injected");
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x000028D9 File Offset: 0x00000AD9
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00005764 File Offset: 0x00003964
		public unsafe bool enabled
		{
			get
			{
				return Collider.get_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 90398, RefRangeEnd = 90400, XrefRangeStart = 90396, XrefRangeEnd = 90398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x000057A4 File Offset: 0x000039A4
		public unsafe Rigidbody attachedRigidbody
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90400, XrefRangeEnd = 90402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collider.NativeMethodInfoPtr_get_attachedRigidbody_Public_get_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr3) : null;
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000028D0 File Offset: 0x00000AD0
		public Collider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x000057E4 File Offset: 0x000039E4
		public ArticulationBody attachedArticulationBody
		{
			get
			{
				IntPtr intPtr = Collider.get_attachedArticulationBodyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArticulationBody>(intPtr2) : null;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x000028EB File Offset: 0x00000AEB
		// (set) Token: 0x060000DA RID: 218 RVA: 0x000028FD File Offset: 0x00000AFD
		public bool isTrigger
		{
			get
			{
				return Collider.get_isTriggerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Collider.set_isTriggerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00002910 File Offset: 0x00000B10
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00002922 File Offset: 0x00000B22
		public float contactOffset
		{
			get
			{
				return Collider.get_contactOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Collider.set_contactOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00005810 File Offset: 0x00003A10
		public Vector3 ClosestPoint(Vector3 position)
		{
			Vector3 vector;
			this.ClosestPoint_Injected(ref position, out vector);
			return vector;
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00005828 File Offset: 0x00003A28
		public Bounds bounds
		{
			get
			{
				Bounds bounds;
				this.get_bounds_Injected(out bounds);
				return bounds;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00005840 File Offset: 0x00003A40
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x00002935 File Offset: 0x00000B35
		public PhysicMaterial sharedMaterial
		{
			get
			{
				IntPtr intPtr = Collider.get_sharedMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicMaterial>(intPtr2) : null;
			}
			set
			{
				Collider.set_sharedMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000586C File Offset: 0x00003A6C
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x0000294D File Offset: 0x00000B4D
		public PhysicMaterial material
		{
			get
			{
				IntPtr intPtr = Collider.get_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicMaterial>(intPtr2) : null;
			}
			set
			{
				Collider.set_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00005898 File Offset: 0x00003A98
		public RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit)
		{
			RaycastHit raycastHit;
			this.Raycast_Injected(ref ray, maxDistance, ref hasHit, out raycastHit);
			return raycastHit;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000058B4 File Offset: 0x00003AB4
		public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance)
		{
			bool flag = false;
			hitInfo = this.Raycast(ray, maxDistance, ref flag);
			return flag;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002965 File Offset: 0x00000B65
		public void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance)
		{
			this.Internal_ClosestPointOnBounds_Injected(ref point, ref outPos, ref distance);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000058DC File Offset: 0x00003ADC
		public Vector3 ClosestPointOnBounds(Vector3 position)
		{
			float num = 0f;
			Vector3 zero = Vector3.zero;
			this.Internal_ClosestPointOnBounds(position, ref zero, ref num);
			return zero;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002971 File Offset: 0x00000B71
		public void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret)
		{
			Collider.ClosestPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref position, out ret);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002985 File Offset: 0x00000B85
		public void get_bounds_Injected(out Bounds ret)
		{
			Collider.get_bounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002998 File Offset: 0x00000B98
		public void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret)
		{
			Collider.Raycast_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref ray, maxDistance, ref hasHit, out ret);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000029AF File Offset: 0x00000BAF
		public void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance)
		{
			Collider.Internal_ClosestPointOnBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref point, ref outPos, ref distance);
		}

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_get_attachedRigidbody_Public_get_Rigidbody_0;

		// Token: 0x0400006B RID: 107
		private static readonly Collider.get_enabledDelegate get_enabledDelegateField;

		// Token: 0x0400006C RID: 108
		private static readonly Collider.get_attachedArticulationBodyDelegate get_attachedArticulationBodyDelegateField;

		// Token: 0x0400006D RID: 109
		private static readonly Collider.get_isTriggerDelegate get_isTriggerDelegateField;

		// Token: 0x0400006E RID: 110
		private static readonly Collider.set_isTriggerDelegate set_isTriggerDelegateField;

		// Token: 0x0400006F RID: 111
		private static readonly Collider.get_contactOffsetDelegate get_contactOffsetDelegateField;

		// Token: 0x04000070 RID: 112
		private static readonly Collider.set_contactOffsetDelegate set_contactOffsetDelegateField;

		// Token: 0x04000071 RID: 113
		private static readonly Collider.get_sharedMaterialDelegate get_sharedMaterialDelegateField;

		// Token: 0x04000072 RID: 114
		private static readonly Collider.set_sharedMaterialDelegate set_sharedMaterialDelegateField;

		// Token: 0x04000073 RID: 115
		private static readonly Collider.get_materialDelegate get_materialDelegateField;

		// Token: 0x04000074 RID: 116
		private static readonly Collider.set_materialDelegate set_materialDelegateField;

		// Token: 0x04000075 RID: 117
		private static readonly Collider.ClosestPoint_InjectedDelegate ClosestPoint_InjectedDelegateField;

		// Token: 0x04000076 RID: 118
		private static readonly Collider.get_bounds_InjectedDelegate get_bounds_InjectedDelegateField;

		// Token: 0x04000077 RID: 119
		private static readonly Collider.Raycast_InjectedDelegate Raycast_InjectedDelegateField;

		// Token: 0x04000078 RID: 120
		private static readonly Collider.Internal_ClosestPointOnBounds_InjectedDelegate Internal_ClosestPointOnBounds_InjectedDelegateField;

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x060003F5 RID: 1013
		private delegate bool get_enabledDelegate(IntPtr @this);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x060003F7 RID: 1015
		private delegate IntPtr get_attachedArticulationBodyDelegate(IntPtr @this);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x060003F9 RID: 1017
		private delegate bool get_isTriggerDelegate(IntPtr @this);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x060003FB RID: 1019
		private delegate void set_isTriggerDelegate(IntPtr @this, bool value);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x060003FD RID: 1021
		private delegate float get_contactOffsetDelegate(IntPtr @this);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x060003FF RID: 1023
		private delegate void set_contactOffsetDelegate(IntPtr @this, float value);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x06000401 RID: 1025
		private delegate IntPtr get_sharedMaterialDelegate(IntPtr @this);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x06000403 RID: 1027
		private delegate void set_sharedMaterialDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x06000405 RID: 1029
		private delegate IntPtr get_materialDelegate(IntPtr @this);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x06000407 RID: 1031
		private delegate void set_materialDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x06000409 RID: 1033
		private delegate void ClosestPoint_InjectedDelegate(IntPtr @this, IntPtr position, [Out] IntPtr ret);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x0600040B RID: 1035
		private delegate void get_bounds_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x0600040D RID: 1037
		private delegate void Raycast_InjectedDelegate(IntPtr @this, IntPtr ray, float maxDistance, IntPtr hasHit, [Out] IntPtr ret);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x0600040F RID: 1039
		private delegate void Internal_ClosestPointOnBounds_InjectedDelegate(IntPtr @this, IntPtr point, IntPtr outPos, IntPtr distance);
	}
}
