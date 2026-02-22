using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	public class BoxCollider : Collider
	{
		// Token: 0x06000127 RID: 295 RVA: 0x00005CCC File Offset: 0x00003ECC
		// Note: this type is marked as 'beforefieldinit'.
		static BoxCollider()
		{
			Il2CppClassPointerStore<BoxCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "BoxCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoxCollider>.NativeClassPtr);
			BoxCollider.get_center_InjectedDelegateField = IL2CPP.ResolveICall<BoxCollider.get_center_InjectedDelegate>("UnityEngine.BoxCollider::get_center_Injected");
			BoxCollider.set_center_InjectedDelegateField = IL2CPP.ResolveICall<BoxCollider.set_center_InjectedDelegate>("UnityEngine.BoxCollider::set_center_Injected");
			BoxCollider.get_size_InjectedDelegateField = IL2CPP.ResolveICall<BoxCollider.get_size_InjectedDelegate>("UnityEngine.BoxCollider::get_size_Injected");
			BoxCollider.set_size_InjectedDelegateField = IL2CPP.ResolveICall<BoxCollider.set_size_InjectedDelegate>("UnityEngine.BoxCollider::set_size_Injected");
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002CD8 File Offset: 0x00000ED8
		public BoxCollider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00005D38 File Offset: 0x00003F38
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00002CE1 File Offset: 0x00000EE1
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

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00005D50 File Offset: 0x00003F50
		// (set) Token: 0x0600012C RID: 300 RVA: 0x00002CEB File Offset: 0x00000EEB
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

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00005D68 File Offset: 0x00003F68
		// (set) Token: 0x0600012E RID: 302 RVA: 0x00002CF5 File Offset: 0x00000EF5
		public Vector3 extents
		{
			get
			{
				return this.size * 0.5f;
			}
			set
			{
				this.size = value * 2f;
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002D0A File Offset: 0x00000F0A
		public void get_center_Injected(out Vector3 ret)
		{
			BoxCollider.get_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002D1D File Offset: 0x00000F1D
		public void set_center_Injected(ref Vector3 value)
		{
			BoxCollider.set_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002D30 File Offset: 0x00000F30
		public void get_size_Injected(out Vector3 ret)
		{
			BoxCollider.get_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002D43 File Offset: 0x00000F43
		public void set_size_Injected(ref Vector3 value)
		{
			BoxCollider.set_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040000A0 RID: 160
		private static readonly BoxCollider.get_center_InjectedDelegate get_center_InjectedDelegateField;

		// Token: 0x040000A1 RID: 161
		private static readonly BoxCollider.set_center_InjectedDelegate set_center_InjectedDelegateField;

		// Token: 0x040000A2 RID: 162
		private static readonly BoxCollider.get_size_InjectedDelegate get_size_InjectedDelegateField;

		// Token: 0x040000A3 RID: 163
		private static readonly BoxCollider.set_size_InjectedDelegate set_size_InjectedDelegateField;

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x0600045F RID: 1119
		private delegate void get_center_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200009E RID: 158
		// (Invoke) Token: 0x06000461 RID: 1121
		private delegate void set_center_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200009F RID: 159
		// (Invoke) Token: 0x06000463 RID: 1123
		private delegate void get_size_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x06000465 RID: 1125
		private delegate void set_size_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
