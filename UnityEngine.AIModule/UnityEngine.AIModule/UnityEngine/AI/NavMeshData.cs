using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine.AI
{
	// Token: 0x0200000E RID: 14
	public sealed class NavMeshData : Object
	{
		// Token: 0x060000BD RID: 189 RVA: 0x00002ABD File Offset: 0x00000CBD
		public static void Internal_Create(NavMeshData mono, int agentTypeID)
		{
			NavMeshData.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mono), agentTypeID);
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000037C8 File Offset: 0x000019C8
		public Bounds sourceBounds
		{
			get
			{
				Bounds bounds;
				this.get_sourceBounds_Injected(out bounds);
				return bounds;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000BF RID: 191 RVA: 0x000037E0 File Offset: 0x000019E0
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00002AD0 File Offset: 0x00000CD0
		public Vector3 position
		{
			get
			{
				Vector3 vector;
				this.get_position_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_position_Injected(ref value);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x000037F8 File Offset: 0x000019F8
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00002ADA File Offset: 0x00000CDA
		public Quaternion rotation
		{
			get
			{
				Quaternion quaternion;
				this.get_rotation_Injected(out quaternion);
				return quaternion;
			}
			set
			{
				this.set_rotation_Injected(ref value);
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002AE4 File Offset: 0x00000CE4
		public void get_sourceBounds_Injected(out Bounds ret)
		{
			NavMeshData.get_sourceBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002AF7 File Offset: 0x00000CF7
		public void get_position_Injected(out Vector3 ret)
		{
			NavMeshData.get_position_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002B0A File Offset: 0x00000D0A
		public void set_position_Injected(ref Vector3 value)
		{
			NavMeshData.set_position_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002B1D File Offset: 0x00000D1D
		public void get_rotation_Injected(out Quaternion ret)
		{
			NavMeshData.get_rotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002B30 File Offset: 0x00000D30
		public void set_rotation_Injected(ref Quaternion value)
		{
			NavMeshData.set_rotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0400009F RID: 159
		private static readonly NavMeshData.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<NavMeshData.Internal_CreateDelegate>("UnityEngine.AI.NavMeshData::Internal_Create");

		// Token: 0x040000A0 RID: 160
		private static readonly NavMeshData.get_sourceBounds_InjectedDelegate get_sourceBounds_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshData.get_sourceBounds_InjectedDelegate>("UnityEngine.AI.NavMeshData::get_sourceBounds_Injected");

		// Token: 0x040000A1 RID: 161
		private static readonly NavMeshData.get_position_InjectedDelegate get_position_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshData.get_position_InjectedDelegate>("UnityEngine.AI.NavMeshData::get_position_Injected");

		// Token: 0x040000A2 RID: 162
		private static readonly NavMeshData.set_position_InjectedDelegate set_position_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshData.set_position_InjectedDelegate>("UnityEngine.AI.NavMeshData::set_position_Injected");

		// Token: 0x040000A3 RID: 163
		private static readonly NavMeshData.get_rotation_InjectedDelegate get_rotation_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshData.get_rotation_InjectedDelegate>("UnityEngine.AI.NavMeshData::get_rotation_Injected");

		// Token: 0x040000A4 RID: 164
		private static readonly NavMeshData.set_rotation_InjectedDelegate set_rotation_InjectedDelegateField = IL2CPP.ResolveICall<NavMeshData.set_rotation_InjectedDelegate>("UnityEngine.AI.NavMeshData::set_rotation_Injected");

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x060001E5 RID: 485
		private delegate void Internal_CreateDelegate(IntPtr mono, int agentTypeID);

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x060001E7 RID: 487
		private delegate void get_sourceBounds_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000A2 RID: 162
		// (Invoke) Token: 0x060001E9 RID: 489
		private delegate void get_position_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000A3 RID: 163
		// (Invoke) Token: 0x060001EB RID: 491
		private delegate void set_position_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020000A4 RID: 164
		// (Invoke) Token: 0x060001ED RID: 493
		private delegate void get_rotation_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000A5 RID: 165
		// (Invoke) Token: 0x060001EF RID: 495
		private delegate void set_rotation_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
