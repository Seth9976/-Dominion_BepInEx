using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	[StructLayout(2)]
	public struct RaycastHit2D
	{
		// Token: 0x06000219 RID: 537 RVA: 0x00009C10 File Offset: 0x00007E10
		// Note: this type is marked as 'beforefieldinit'.
		static RaycastHit2D()
		{
			Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "RaycastHit2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr);
			RaycastHit2D.NativeFieldInfoPtr_m_Centroid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, "m_Centroid");
			RaycastHit2D.NativeFieldInfoPtr_m_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, "m_Point");
			RaycastHit2D.NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, "m_Normal");
			RaycastHit2D.NativeFieldInfoPtr_m_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, "m_Distance");
			RaycastHit2D.NativeFieldInfoPtr_m_Fraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, "m_Fraction");
			RaycastHit2D.NativeFieldInfoPtr_m_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, "m_Collider");
			RaycastHit2D.NativeMethodInfoPtr_get_point_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, 100663338);
			RaycastHit2D.NativeMethodInfoPtr_get_normal_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, 100663339);
			RaycastHit2D.NativeMethodInfoPtr_get_distance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, 100663340);
			RaycastHit2D.NativeMethodInfoPtr_get_collider_Public_get_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, 100663341);
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00009D08 File Offset: 0x00007F08
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00002BC3 File Offset: 0x00000DC3
		public unsafe Vector2 point
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 88826, RefRangeEnd = 88828, XrefRangeStart = 88826, XrefRangeEnd = 88826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit2D.NativeMethodInfoPtr_get_point_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Point = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00009D38 File Offset: 0x00007F38
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00002BCD File Offset: 0x00000DCD
		public unsafe Vector2 normal
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88828, RefRangeEnd = 88829, XrefRangeStart = 88828, XrefRangeEnd = 88828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit2D.NativeMethodInfoPtr_get_normal_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Normal = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00009D68 File Offset: 0x00007F68
		// (set) Token: 0x06000223 RID: 547 RVA: 0x00002BD7 File Offset: 0x00000DD7
		public unsafe float distance
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88829, RefRangeEnd = 88830, XrefRangeStart = 88829, XrefRangeEnd = 88829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit2D.NativeMethodInfoPtr_get_distance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Distance = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00009D98 File Offset: 0x00007F98
		public unsafe Collider2D collider
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 88835, RefRangeEnd = 88837, XrefRangeStart = 88830, XrefRangeEnd = 88835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit2D.NativeMethodInfoPtr_get_collider_Public_get_Collider2D_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr3) : null;
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002BA7 File Offset: 0x00000DA7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, ref this));
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00009DCC File Offset: 0x00007FCC
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00002BB9 File Offset: 0x00000DB9
		public Vector2 centroid
		{
			get
			{
				return this.m_Centroid;
			}
			set
			{
				this.m_Centroid = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00009DE4 File Offset: 0x00007FE4
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00002BE1 File Offset: 0x00000DE1
		public float fraction
		{
			get
			{
				return this.m_Fraction;
			}
			set
			{
				this.m_Fraction = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00009DFC File Offset: 0x00007FFC
		public Rigidbody2D rigidbody
		{
			get
			{
				return (this.collider != null) ? this.collider.attachedRigidbody : null;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00009E2C File Offset: 0x0000802C
		public Transform transform
		{
			get
			{
				Rigidbody2D rigidbody = this.rigidbody;
				bool flag = rigidbody != null;
				Transform transform;
				if (flag)
				{
					transform = rigidbody.transform;
				}
				else
				{
					bool flag2 = this.collider != null;
					if (flag2)
					{
						transform = this.collider.transform;
					}
					else
					{
						transform = null;
					}
				}
				return transform;
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00009E78 File Offset: 0x00008078
		public static implicit operator bool(RaycastHit2D hit)
		{
			return hit.collider != null;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00009E98 File Offset: 0x00008098
		public int CompareTo(RaycastHit2D other)
		{
			bool flag = this.collider == null;
			int num;
			if (flag)
			{
				num = 1;
			}
			else
			{
				bool flag2 = other.collider == null;
				if (flag2)
				{
					num = -1;
				}
				else
				{
					num = this.fraction.CompareTo(other.fraction);
				}
			}
			return num;
		}

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_m_Centroid;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeFieldInfoPtr_m_Point;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeFieldInfoPtr_m_Normal;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeFieldInfoPtr_m_Distance;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeFieldInfoPtr_m_Fraction;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeFieldInfoPtr_m_Collider;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_get_point_Public_get_Vector2_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_get_normal_Public_get_Vector2_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_get_distance_Public_get_Single_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_get_collider_Public_get_Collider2D_0;

		// Token: 0x040000E9 RID: 233
		[FieldOffset(0)]
		public Vector2 m_Centroid;

		// Token: 0x040000EA RID: 234
		[FieldOffset(8)]
		public Vector2 m_Point;

		// Token: 0x040000EB RID: 235
		[FieldOffset(16)]
		public Vector2 m_Normal;

		// Token: 0x040000EC RID: 236
		[FieldOffset(24)]
		public float m_Distance;

		// Token: 0x040000ED RID: 237
		[FieldOffset(28)]
		public float m_Fraction;

		// Token: 0x040000EE RID: 238
		[FieldOffset(32)]
		public int m_Collider;
	}
}
