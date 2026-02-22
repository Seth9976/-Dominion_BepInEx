using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x020000DF RID: 223
	public sealed class SpriteRenderer : Renderer
	{
		// Token: 0x060013B5 RID: 5045 RVA: 0x0004C870 File Offset: 0x0004AA70
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteRenderer()
		{
			Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SpriteRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr);
			SpriteRenderer.get_shouldSupportTilingDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_shouldSupportTilingDelegate>("UnityEngine.SpriteRenderer::get_shouldSupportTiling");
			SpriteRenderer.get_spriteDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_spriteDelegate>("UnityEngine.SpriteRenderer::get_sprite");
			SpriteRenderer.set_spriteDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_spriteDelegate>("UnityEngine.SpriteRenderer::set_sprite");
			SpriteRenderer.get_drawModeDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_drawModeDelegate>("UnityEngine.SpriteRenderer::get_drawMode");
			SpriteRenderer.set_drawModeDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_drawModeDelegate>("UnityEngine.SpriteRenderer::set_drawMode");
			SpriteRenderer.get_adaptiveModeThresholdDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_adaptiveModeThresholdDelegate>("UnityEngine.SpriteRenderer::get_adaptiveModeThreshold");
			SpriteRenderer.set_adaptiveModeThresholdDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_adaptiveModeThresholdDelegate>("UnityEngine.SpriteRenderer::set_adaptiveModeThreshold");
			SpriteRenderer.get_tileModeDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_tileModeDelegate>("UnityEngine.SpriteRenderer::get_tileMode");
			SpriteRenderer.set_tileModeDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_tileModeDelegate>("UnityEngine.SpriteRenderer::set_tileMode");
			SpriteRenderer.get_maskInteractionDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_maskInteractionDelegate>("UnityEngine.SpriteRenderer::get_maskInteraction");
			SpriteRenderer.set_maskInteractionDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_maskInteractionDelegate>("UnityEngine.SpriteRenderer::set_maskInteraction");
			SpriteRenderer.get_flipXDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_flipXDelegate>("UnityEngine.SpriteRenderer::get_flipX");
			SpriteRenderer.set_flipXDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_flipXDelegate>("UnityEngine.SpriteRenderer::set_flipX");
			SpriteRenderer.get_flipYDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_flipYDelegate>("UnityEngine.SpriteRenderer::get_flipY");
			SpriteRenderer.set_flipYDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_flipYDelegate>("UnityEngine.SpriteRenderer::set_flipY");
			SpriteRenderer.get_spriteSortPointDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_spriteSortPointDelegate>("UnityEngine.SpriteRenderer::get_spriteSortPoint");
			SpriteRenderer.set_spriteSortPointDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_spriteSortPointDelegate>("UnityEngine.SpriteRenderer::set_spriteSortPoint");
			SpriteRenderer.get_size_InjectedDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_size_InjectedDelegate>("UnityEngine.SpriteRenderer::get_size_Injected");
			SpriteRenderer.set_size_InjectedDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_size_InjectedDelegate>("UnityEngine.SpriteRenderer::set_size_Injected");
			SpriteRenderer.get_color_InjectedDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_color_InjectedDelegate>("UnityEngine.SpriteRenderer::get_color_Injected");
			SpriteRenderer.set_color_InjectedDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_color_InjectedDelegate>("UnityEngine.SpriteRenderer::set_color_Injected");
			SpriteRenderer.Internal_GetSpriteBounds_InjectedDelegateField = IL2CPP.ResolveICall<SpriteRenderer.Internal_GetSpriteBounds_InjectedDelegate>("UnityEngine.SpriteRenderer::Internal_GetSpriteBounds_Injected");
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x0000B6BA File Offset: 0x000098BA
		public SpriteRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x0000B6C3 File Offset: 0x000098C3
		public bool shouldSupportTiling
		{
			get
			{
				return SpriteRenderer.get_shouldSupportTilingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x060013B8 RID: 5048 RVA: 0x0004C9EC File Offset: 0x0004ABEC
		// (set) Token: 0x060013B9 RID: 5049 RVA: 0x0000B6D5 File Offset: 0x000098D5
		public Sprite sprite
		{
			get
			{
				IntPtr intPtr = SpriteRenderer.get_spriteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				SpriteRenderer.set_spriteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x060013BA RID: 5050 RVA: 0x0000B6ED File Offset: 0x000098ED
		// (set) Token: 0x060013BB RID: 5051 RVA: 0x0000B6FF File Offset: 0x000098FF
		public SpriteDrawMode drawMode
		{
			get
			{
				return SpriteRenderer.get_drawModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteRenderer.set_drawModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x060013BC RID: 5052 RVA: 0x0004CA18 File Offset: 0x0004AC18
		// (set) Token: 0x060013BD RID: 5053 RVA: 0x0000B712 File Offset: 0x00009912
		public Vector2 size
		{
			get
			{
				Vector2 vector;
				this.get_size_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_size_Injected(ref value);
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x0000B71C File Offset: 0x0000991C
		// (set) Token: 0x060013BF RID: 5055 RVA: 0x0000B72E File Offset: 0x0000992E
		public float adaptiveModeThreshold
		{
			get
			{
				return SpriteRenderer.get_adaptiveModeThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteRenderer.set_adaptiveModeThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x060013C0 RID: 5056 RVA: 0x0000B741 File Offset: 0x00009941
		// (set) Token: 0x060013C1 RID: 5057 RVA: 0x0000B753 File Offset: 0x00009953
		public SpriteTileMode tileMode
		{
			get
			{
				return SpriteRenderer.get_tileModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteRenderer.set_tileModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x060013C2 RID: 5058 RVA: 0x0004CA30 File Offset: 0x0004AC30
		// (set) Token: 0x060013C3 RID: 5059 RVA: 0x0000B766 File Offset: 0x00009966
		public Color color
		{
			get
			{
				Color color;
				this.get_color_Injected(out color);
				return color;
			}
			set
			{
				this.set_color_Injected(ref value);
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060013C4 RID: 5060 RVA: 0x0000B770 File Offset: 0x00009970
		// (set) Token: 0x060013C5 RID: 5061 RVA: 0x0000B782 File Offset: 0x00009982
		public SpriteMaskInteraction maskInteraction
		{
			get
			{
				return SpriteRenderer.get_maskInteractionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteRenderer.set_maskInteractionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060013C6 RID: 5062 RVA: 0x0000B795 File Offset: 0x00009995
		// (set) Token: 0x060013C7 RID: 5063 RVA: 0x0000B7A7 File Offset: 0x000099A7
		public bool flipX
		{
			get
			{
				return SpriteRenderer.get_flipXDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteRenderer.set_flipXDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060013C8 RID: 5064 RVA: 0x0000B7BA File Offset: 0x000099BA
		// (set) Token: 0x060013C9 RID: 5065 RVA: 0x0000B7CC File Offset: 0x000099CC
		public bool flipY
		{
			get
			{
				return SpriteRenderer.get_flipYDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteRenderer.set_flipYDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060013CA RID: 5066 RVA: 0x0000B7DF File Offset: 0x000099DF
		// (set) Token: 0x060013CB RID: 5067 RVA: 0x0000B7F1 File Offset: 0x000099F1
		public SpriteSortPoint spriteSortPoint
		{
			get
			{
				return SpriteRenderer.get_spriteSortPointDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteRenderer.set_spriteSortPointDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x0004CA48 File Offset: 0x0004AC48
		public Bounds Internal_GetSpriteBounds(SpriteDrawMode mode)
		{
			Bounds bounds;
			this.Internal_GetSpriteBounds_Injected(mode, out bounds);
			return bounds;
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x0004CA60 File Offset: 0x0004AC60
		public Bounds GetSpriteBounds()
		{
			return this.Internal_GetSpriteBounds(this.drawMode);
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x0000B804 File Offset: 0x00009A04
		public void get_size_Injected(out Vector2 ret)
		{
			SpriteRenderer.get_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x0000B817 File Offset: 0x00009A17
		public void set_size_Injected(ref Vector2 value)
		{
			SpriteRenderer.set_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x0000B82A File Offset: 0x00009A2A
		public void get_color_Injected(out Color ret)
		{
			SpriteRenderer.get_color_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x0000B83D File Offset: 0x00009A3D
		public void set_color_Injected(ref Color value)
		{
			SpriteRenderer.set_color_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x0000B850 File Offset: 0x00009A50
		public void Internal_GetSpriteBounds_Injected(SpriteDrawMode mode, out Bounds ret)
		{
			SpriteRenderer.Internal_GetSpriteBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), mode, out ret);
		}

		// Token: 0x04000EC1 RID: 3777
		private static readonly SpriteRenderer.get_shouldSupportTilingDelegate get_shouldSupportTilingDelegateField;

		// Token: 0x04000EC2 RID: 3778
		private static readonly SpriteRenderer.get_spriteDelegate get_spriteDelegateField;

		// Token: 0x04000EC3 RID: 3779
		private static readonly SpriteRenderer.set_spriteDelegate set_spriteDelegateField;

		// Token: 0x04000EC4 RID: 3780
		private static readonly SpriteRenderer.get_drawModeDelegate get_drawModeDelegateField;

		// Token: 0x04000EC5 RID: 3781
		private static readonly SpriteRenderer.set_drawModeDelegate set_drawModeDelegateField;

		// Token: 0x04000EC6 RID: 3782
		private static readonly SpriteRenderer.get_adaptiveModeThresholdDelegate get_adaptiveModeThresholdDelegateField;

		// Token: 0x04000EC7 RID: 3783
		private static readonly SpriteRenderer.set_adaptiveModeThresholdDelegate set_adaptiveModeThresholdDelegateField;

		// Token: 0x04000EC8 RID: 3784
		private static readonly SpriteRenderer.get_tileModeDelegate get_tileModeDelegateField;

		// Token: 0x04000EC9 RID: 3785
		private static readonly SpriteRenderer.set_tileModeDelegate set_tileModeDelegateField;

		// Token: 0x04000ECA RID: 3786
		private static readonly SpriteRenderer.get_maskInteractionDelegate get_maskInteractionDelegateField;

		// Token: 0x04000ECB RID: 3787
		private static readonly SpriteRenderer.set_maskInteractionDelegate set_maskInteractionDelegateField;

		// Token: 0x04000ECC RID: 3788
		private static readonly SpriteRenderer.get_flipXDelegate get_flipXDelegateField;

		// Token: 0x04000ECD RID: 3789
		private static readonly SpriteRenderer.set_flipXDelegate set_flipXDelegateField;

		// Token: 0x04000ECE RID: 3790
		private static readonly SpriteRenderer.get_flipYDelegate get_flipYDelegateField;

		// Token: 0x04000ECF RID: 3791
		private static readonly SpriteRenderer.set_flipYDelegate set_flipYDelegateField;

		// Token: 0x04000ED0 RID: 3792
		private static readonly SpriteRenderer.get_spriteSortPointDelegate get_spriteSortPointDelegateField;

		// Token: 0x04000ED1 RID: 3793
		private static readonly SpriteRenderer.set_spriteSortPointDelegate set_spriteSortPointDelegateField;

		// Token: 0x04000ED2 RID: 3794
		private static readonly SpriteRenderer.get_size_InjectedDelegate get_size_InjectedDelegateField;

		// Token: 0x04000ED3 RID: 3795
		private static readonly SpriteRenderer.set_size_InjectedDelegate set_size_InjectedDelegateField;

		// Token: 0x04000ED4 RID: 3796
		private static readonly SpriteRenderer.get_color_InjectedDelegate get_color_InjectedDelegateField;

		// Token: 0x04000ED5 RID: 3797
		private static readonly SpriteRenderer.set_color_InjectedDelegate set_color_InjectedDelegateField;

		// Token: 0x04000ED6 RID: 3798
		private static readonly SpriteRenderer.Internal_GetSpriteBounds_InjectedDelegate Internal_GetSpriteBounds_InjectedDelegateField;

		// Token: 0x0200085F RID: 2143
		// (Invoke) Token: 0x06002E71 RID: 11889
		private delegate bool get_shouldSupportTilingDelegate(IntPtr @this);

		// Token: 0x02000860 RID: 2144
		// (Invoke) Token: 0x06002E73 RID: 11891
		private delegate IntPtr get_spriteDelegate(IntPtr @this);

		// Token: 0x02000861 RID: 2145
		// (Invoke) Token: 0x06002E75 RID: 11893
		private delegate void set_spriteDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000862 RID: 2146
		// (Invoke) Token: 0x06002E77 RID: 11895
		private delegate SpriteDrawMode get_drawModeDelegate(IntPtr @this);

		// Token: 0x02000863 RID: 2147
		// (Invoke) Token: 0x06002E79 RID: 11897
		private delegate void set_drawModeDelegate(IntPtr @this, SpriteDrawMode value);

		// Token: 0x02000864 RID: 2148
		// (Invoke) Token: 0x06002E7B RID: 11899
		private delegate float get_adaptiveModeThresholdDelegate(IntPtr @this);

		// Token: 0x02000865 RID: 2149
		// (Invoke) Token: 0x06002E7D RID: 11901
		private delegate void set_adaptiveModeThresholdDelegate(IntPtr @this, float value);

		// Token: 0x02000866 RID: 2150
		// (Invoke) Token: 0x06002E7F RID: 11903
		private delegate SpriteTileMode get_tileModeDelegate(IntPtr @this);

		// Token: 0x02000867 RID: 2151
		// (Invoke) Token: 0x06002E81 RID: 11905
		private delegate void set_tileModeDelegate(IntPtr @this, SpriteTileMode value);

		// Token: 0x02000868 RID: 2152
		// (Invoke) Token: 0x06002E83 RID: 11907
		private delegate SpriteMaskInteraction get_maskInteractionDelegate(IntPtr @this);

		// Token: 0x02000869 RID: 2153
		// (Invoke) Token: 0x06002E85 RID: 11909
		private delegate void set_maskInteractionDelegate(IntPtr @this, SpriteMaskInteraction value);

		// Token: 0x0200086A RID: 2154
		// (Invoke) Token: 0x06002E87 RID: 11911
		private delegate bool get_flipXDelegate(IntPtr @this);

		// Token: 0x0200086B RID: 2155
		// (Invoke) Token: 0x06002E89 RID: 11913
		private delegate void set_flipXDelegate(IntPtr @this, bool value);

		// Token: 0x0200086C RID: 2156
		// (Invoke) Token: 0x06002E8B RID: 11915
		private delegate bool get_flipYDelegate(IntPtr @this);

		// Token: 0x0200086D RID: 2157
		// (Invoke) Token: 0x06002E8D RID: 11917
		private delegate void set_flipYDelegate(IntPtr @this, bool value);

		// Token: 0x0200086E RID: 2158
		// (Invoke) Token: 0x06002E8F RID: 11919
		private delegate SpriteSortPoint get_spriteSortPointDelegate(IntPtr @this);

		// Token: 0x0200086F RID: 2159
		// (Invoke) Token: 0x06002E91 RID: 11921
		private delegate void set_spriteSortPointDelegate(IntPtr @this, SpriteSortPoint value);

		// Token: 0x02000870 RID: 2160
		// (Invoke) Token: 0x06002E93 RID: 11923
		private delegate void get_size_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000871 RID: 2161
		// (Invoke) Token: 0x06002E95 RID: 11925
		private delegate void set_size_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000872 RID: 2162
		// (Invoke) Token: 0x06002E97 RID: 11927
		private delegate void get_color_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000873 RID: 2163
		// (Invoke) Token: 0x06002E99 RID: 11929
		private delegate void set_color_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000874 RID: 2164
		// (Invoke) Token: 0x06002E9B RID: 11931
		private delegate void Internal_GetSpriteBounds_InjectedDelegate(IntPtr @this, SpriteDrawMode mode, [Out] IntPtr ret);
	}
}
