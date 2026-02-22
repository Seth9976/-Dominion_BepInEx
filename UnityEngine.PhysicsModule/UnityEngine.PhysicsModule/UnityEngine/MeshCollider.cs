using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	public class MeshCollider : Collider
	{
		// Token: 0x06000109 RID: 265 RVA: 0x00005AC4 File Offset: 0x00003CC4
		// Note: this type is marked as 'beforefieldinit'.
		static MeshCollider()
		{
			Il2CppClassPointerStore<MeshCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "MeshCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshCollider>.NativeClassPtr);
			MeshCollider.get_sharedMeshDelegateField = IL2CPP.ResolveICall<MeshCollider.get_sharedMeshDelegate>("UnityEngine.MeshCollider::get_sharedMesh");
			MeshCollider.set_sharedMeshDelegateField = IL2CPP.ResolveICall<MeshCollider.set_sharedMeshDelegate>("UnityEngine.MeshCollider::set_sharedMesh");
			MeshCollider.get_convexDelegateField = IL2CPP.ResolveICall<MeshCollider.get_convexDelegate>("UnityEngine.MeshCollider::get_convex");
			MeshCollider.set_convexDelegateField = IL2CPP.ResolveICall<MeshCollider.set_convexDelegate>("UnityEngine.MeshCollider::set_convex");
			MeshCollider.get_cookingOptionsDelegateField = IL2CPP.ResolveICall<MeshCollider.get_cookingOptionsDelegate>("UnityEngine.MeshCollider::get_cookingOptions");
			MeshCollider.set_cookingOptionsDelegateField = IL2CPP.ResolveICall<MeshCollider.set_cookingOptionsDelegate>("UnityEngine.MeshCollider::set_cookingOptions");
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002B96 File Offset: 0x00000D96
		public MeshCollider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00005B50 File Offset: 0x00003D50
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00002B9F File Offset: 0x00000D9F
		public Mesh sharedMesh
		{
			get
			{
				IntPtr intPtr = MeshCollider.get_sharedMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				MeshCollider.set_sharedMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00002BB7 File Offset: 0x00000DB7
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00002BC9 File Offset: 0x00000DC9
		public bool convex
		{
			get
			{
				return MeshCollider.get_convexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				MeshCollider.set_convexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00002BDC File Offset: 0x00000DDC
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00002BEE File Offset: 0x00000DEE
		public MeshColliderCookingOptions cookingOptions
		{
			get
			{
				return MeshCollider.get_cookingOptionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				MeshCollider.set_cookingOptionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00005B7C File Offset: 0x00003D7C
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00002C01 File Offset: 0x00000E01
		public bool smoothSphereCollisions
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00005B90 File Offset: 0x00003D90
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00002C04 File Offset: 0x00000E04
		public float skinWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00005BA8 File Offset: 0x00003DA8
		// (set) Token: 0x06000116 RID: 278 RVA: 0x00002C07 File Offset: 0x00000E07
		public bool inflateMesh
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x04000090 RID: 144
		private static readonly MeshCollider.get_sharedMeshDelegate get_sharedMeshDelegateField;

		// Token: 0x04000091 RID: 145
		private static readonly MeshCollider.set_sharedMeshDelegate set_sharedMeshDelegateField;

		// Token: 0x04000092 RID: 146
		private static readonly MeshCollider.get_convexDelegate get_convexDelegateField;

		// Token: 0x04000093 RID: 147
		private static readonly MeshCollider.set_convexDelegate set_convexDelegateField;

		// Token: 0x04000094 RID: 148
		private static readonly MeshCollider.get_cookingOptionsDelegate get_cookingOptionsDelegateField;

		// Token: 0x04000095 RID: 149
		private static readonly MeshCollider.set_cookingOptionsDelegate set_cookingOptionsDelegateField;

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x0600043F RID: 1087
		private delegate IntPtr get_sharedMeshDelegate(IntPtr @this);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x06000441 RID: 1089
		private delegate void set_sharedMeshDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x06000443 RID: 1091
		private delegate bool get_convexDelegate(IntPtr @this);

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x06000445 RID: 1093
		private delegate void set_convexDelegate(IntPtr @this, bool value);

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x06000447 RID: 1095
		private delegate MeshColliderCookingOptions get_cookingOptionsDelegate(IntPtr @this);

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x06000449 RID: 1097
		private delegate void set_cookingOptionsDelegate(IntPtr @this, MeshColliderCookingOptions value);
	}
}
