using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000F RID: 15
	[StructLayout(2)]
	public struct HumanLimit
	{
		// Token: 0x060001D6 RID: 470 RVA: 0x00008EAC File Offset: 0x000070AC
		// Note: this type is marked as 'beforefieldinit'.
		static HumanLimit()
		{
			Il2CppClassPointerStore<HumanLimit>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "HumanLimit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr);
			HumanLimit.NativeFieldInfoPtr_m_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, "m_Min");
			HumanLimit.NativeFieldInfoPtr_m_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, "m_Max");
			HumanLimit.NativeFieldInfoPtr_m_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, "m_Center");
			HumanLimit.NativeFieldInfoPtr_m_AxisLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, "m_AxisLength");
			HumanLimit.NativeFieldInfoPtr_m_UseDefaultValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, "m_UseDefaultValues");
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000339D File Offset: 0x0000159D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, ref this));
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00008F40 File Offset: 0x00007140
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x000033AF File Offset: 0x000015AF
		public bool useDefaultValues
		{
			get
			{
				return this.m_UseDefaultValues != 0;
			}
			set
			{
				this.m_UseDefaultValues = (value ? 1 : 0);
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00008F5C File Offset: 0x0000715C
		// (set) Token: 0x060001DB RID: 475 RVA: 0x000033BF File Offset: 0x000015BF
		public Vector3 min
		{
			get
			{
				return this.m_Min;
			}
			set
			{
				this.m_Min = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00008F74 File Offset: 0x00007174
		// (set) Token: 0x060001DD RID: 477 RVA: 0x000033C9 File Offset: 0x000015C9
		public Vector3 max
		{
			get
			{
				return this.m_Max;
			}
			set
			{
				this.m_Max = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00008F8C File Offset: 0x0000718C
		// (set) Token: 0x060001DF RID: 479 RVA: 0x000033D3 File Offset: 0x000015D3
		public Vector3 center
		{
			get
			{
				return this.m_Center;
			}
			set
			{
				this.m_Center = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00008FA4 File Offset: 0x000071A4
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x000033DD File Offset: 0x000015DD
		public float axisLength
		{
			get
			{
				return this.m_AxisLength;
			}
			set
			{
				this.m_AxisLength = value;
			}
		}

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeFieldInfoPtr_m_Min;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeFieldInfoPtr_m_Max;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeFieldInfoPtr_m_Center;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeFieldInfoPtr_m_AxisLength;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeFieldInfoPtr_m_UseDefaultValues;

		// Token: 0x0400012D RID: 301
		[FieldOffset(0)]
		public Vector3 m_Min;

		// Token: 0x0400012E RID: 302
		[FieldOffset(12)]
		public Vector3 m_Max;

		// Token: 0x0400012F RID: 303
		[FieldOffset(24)]
		public Vector3 m_Center;

		// Token: 0x04000130 RID: 304
		[FieldOffset(36)]
		public float m_AxisLength;

		// Token: 0x04000131 RID: 305
		[FieldOffset(40)]
		public int m_UseDefaultValues;
	}
}
