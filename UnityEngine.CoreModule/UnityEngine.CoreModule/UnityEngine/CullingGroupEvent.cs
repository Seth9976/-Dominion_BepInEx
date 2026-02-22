using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200003A RID: 58
	[StructLayout(2)]
	public struct CullingGroupEvent
	{
		// Token: 0x06000318 RID: 792 RVA: 0x0001D8A0 File Offset: 0x0001BAA0
		// Note: this type is marked as 'beforefieldinit'.
		static CullingGroupEvent()
		{
			Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CullingGroupEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr);
			CullingGroupEvent.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr, "m_Index");
			CullingGroupEvent.NativeFieldInfoPtr_m_PrevState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr, "m_PrevState");
			CullingGroupEvent.NativeFieldInfoPtr_m_ThisState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr, "m_ThisState");
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00003F7F File Offset: 0x0000217F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr, ref this));
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0001D90C File Offset: 0x0001BB0C
		public int index
		{
			get
			{
				return this.m_Index;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600031B RID: 795 RVA: 0x0001D924 File Offset: 0x0001BB24
		public bool isVisible
		{
			get
			{
				return (this.m_ThisState & 128) > 0;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600031C RID: 796 RVA: 0x0001D948 File Offset: 0x0001BB48
		public bool wasVisible
		{
			get
			{
				return (this.m_PrevState & 128) > 0;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600031D RID: 797 RVA: 0x0001D96C File Offset: 0x0001BB6C
		public bool hasBecomeVisible
		{
			get
			{
				return this.isVisible && !this.wasVisible;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0001D994 File Offset: 0x0001BB94
		public bool hasBecomeInvisible
		{
			get
			{
				return !this.isVisible && this.wasVisible;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600031F RID: 799 RVA: 0x0001D9B8 File Offset: 0x0001BBB8
		public int currentDistance
		{
			get
			{
				return (int)(this.m_ThisState & 127);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0001D9D4 File Offset: 0x0001BBD4
		public int previousDistance
		{
			get
			{
				return (int)(this.m_PrevState & 127);
			}
		}

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeFieldInfoPtr_m_Index;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevState;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeFieldInfoPtr_m_ThisState;

		// Token: 0x04000237 RID: 567
		[FieldOffset(0)]
		public int m_Index;

		// Token: 0x04000238 RID: 568
		[FieldOffset(4)]
		public byte m_PrevState;

		// Token: 0x04000239 RID: 569
		[FieldOffset(5)]
		public byte m_ThisState;

		// Token: 0x0400023A RID: 570
		public const byte kIsVisibleMask = 128;

		// Token: 0x0400023B RID: 571
		public const byte kDistanceMask = 127;
	}
}
