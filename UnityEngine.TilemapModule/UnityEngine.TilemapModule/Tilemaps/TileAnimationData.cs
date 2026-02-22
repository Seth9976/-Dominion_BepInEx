using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Tilemaps
{
	// Token: 0x02000009 RID: 9
	public sealed class TileAnimationData : ValueType
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x00004444 File Offset: 0x00002644
		// Note: this type is marked as 'beforefieldinit'.
		static TileAnimationData()
		{
			Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TilemapModule.dll", "UnityEngine.Tilemaps", "TileAnimationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr);
			TileAnimationData.NativeFieldInfoPtr_m_AnimatedSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr, "m_AnimatedSprites");
			TileAnimationData.NativeFieldInfoPtr_m_AnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr, "m_AnimationSpeed");
			TileAnimationData.NativeFieldInfoPtr_m_AnimationStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr, "m_AnimationStartTime");
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002876 File Offset: 0x00000A76
		public TileAnimationData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000287F File Offset: 0x00000A7F
		public TileAnimationData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr))
		{
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000DA RID: 218 RVA: 0x000044B0 File Offset: 0x000026B0
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00002891 File Offset: 0x00000A91
		public unsafe Il2CppReferenceArray<Sprite> m_AnimatedSprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAnimationData.NativeFieldInfoPtr_m_AnimatedSprites);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAnimationData.NativeFieldInfoPtr_m_AnimatedSprites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000DC RID: 220 RVA: 0x000044E0 File Offset: 0x000026E0
		// (set) Token: 0x060000DD RID: 221 RVA: 0x000028B0 File Offset: 0x00000AB0
		public unsafe float m_AnimationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAnimationData.NativeFieldInfoPtr_m_AnimationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAnimationData.NativeFieldInfoPtr_m_AnimationSpeed)) = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00004508 File Offset: 0x00002708
		// (set) Token: 0x060000DF RID: 223 RVA: 0x000028CB File Offset: 0x00000ACB
		public unsafe float m_AnimationStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAnimationData.NativeFieldInfoPtr_m_AnimationStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileAnimationData.NativeFieldInfoPtr_m_AnimationStartTime)) = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00004530 File Offset: 0x00002730
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x000028E6 File Offset: 0x00000AE6
		public Il2CppReferenceArray<Sprite> animatedSprites
		{
			get
			{
				return this.m_AnimatedSprites;
			}
			set
			{
				this.m_AnimatedSprites = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00004548 File Offset: 0x00002748
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x000028F0 File Offset: 0x00000AF0
		public float animationSpeed
		{
			get
			{
				return this.m_AnimationSpeed;
			}
			set
			{
				this.m_AnimationSpeed = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00004560 File Offset: 0x00002760
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x000028FA File Offset: 0x00000AFA
		public float animationStartTime
		{
			get
			{
				return this.m_AnimationStartTime;
			}
			set
			{
				this.m_AnimationStartTime = value;
			}
		}

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimatedSprites;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimationSpeed;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimationStartTime;
	}
}
