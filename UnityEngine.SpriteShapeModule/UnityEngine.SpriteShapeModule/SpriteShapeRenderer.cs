using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Unity.Collections;

namespace UnityEngine.U2D
{
	// Token: 0x02000002 RID: 2
	public class SpriteShapeRenderer : Renderer
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020F8 File Offset: 0x000002F8
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteShapeRenderer()
		{
			Il2CppClassPointerStore<SpriteShapeRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SpriteShapeModule.dll", "UnityEngine.U2D", "SpriteShapeRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteShapeRenderer>.NativeClassPtr);
			SpriteShapeRenderer.get_maskInteractionDelegateField = IL2CPP.ResolveICall<SpriteShapeRenderer.get_maskInteractionDelegate>("UnityEngine.U2D.SpriteShapeRenderer::get_maskInteraction");
			SpriteShapeRenderer.set_maskInteractionDelegateField = IL2CPP.ResolveICall<SpriteShapeRenderer.set_maskInteractionDelegate>("UnityEngine.U2D.SpriteShapeRenderer::set_maskInteraction");
			SpriteShapeRenderer.SetSegmentCountDelegateField = IL2CPP.ResolveICall<SpriteShapeRenderer.SetSegmentCountDelegate>("UnityEngine.U2D.SpriteShapeRenderer::SetSegmentCount");
			SpriteShapeRenderer.SetMeshDataCountDelegateField = IL2CPP.ResolveICall<SpriteShapeRenderer.SetMeshDataCountDelegate>("UnityEngine.U2D.SpriteShapeRenderer::SetMeshDataCount");
			SpriteShapeRenderer.SetMeshChannelInfoDelegateField = IL2CPP.ResolveICall<SpriteShapeRenderer.SetMeshChannelInfoDelegate>("UnityEngine.U2D.SpriteShapeRenderer::SetMeshChannelInfo");
			SpriteShapeRenderer.get_color_InjectedDelegateField = IL2CPP.ResolveICall<SpriteShapeRenderer.get_color_InjectedDelegate>("UnityEngine.U2D.SpriteShapeRenderer::get_color_Injected");
			SpriteShapeRenderer.set_color_InjectedDelegateField = IL2CPP.ResolveICall<SpriteShapeRenderer.set_color_InjectedDelegate>("UnityEngine.U2D.SpriteShapeRenderer::set_color_Injected");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		public SpriteShapeRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002194 File Offset: 0x00000394
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002059 File Offset: 0x00000259
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

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002063 File Offset: 0x00000263
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002075 File Offset: 0x00000275
		public SpriteMaskInteraction maskInteraction
		{
			get
			{
				return SpriteShapeRenderer.get_maskInteractionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteShapeRenderer.set_maskInteractionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002088 File Offset: 0x00000288
		public NativeArray<T> GetNativeDataArray<T>(SpriteShapeDataType dataType) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002095 File Offset: 0x00000295
		public void SetSegmentCount(int geomCount)
		{
			SpriteShapeRenderer.SetSegmentCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), geomCount);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020A8 File Offset: 0x000002A8
		public void SetMeshDataCount(int vertexCount, int indexCount)
		{
			SpriteShapeRenderer.SetMeshDataCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), vertexCount, indexCount);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020BC File Offset: 0x000002BC
		public void SetMeshChannelInfo(int vertexCount, int indexCount, int hotChannelMask)
		{
			SpriteShapeRenderer.SetMeshChannelInfoDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), vertexCount, indexCount, hotChannelMask);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000021AC File Offset: 0x000003AC
		public NativeArray<Bounds> GetBounds()
		{
			return this.GetNativeDataArray<Bounds>(SpriteShapeDataType.BoundingBox);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020D1 File Offset: 0x000002D1
		public void get_color_Injected(out Color ret)
		{
			SpriteShapeRenderer.get_color_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020E4 File Offset: 0x000002E4
		public void set_color_Injected(ref Color value)
		{
			SpriteShapeRenderer.set_color_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000001 RID: 1
		private static readonly SpriteShapeRenderer.get_maskInteractionDelegate get_maskInteractionDelegateField;

		// Token: 0x04000002 RID: 2
		private static readonly SpriteShapeRenderer.set_maskInteractionDelegate set_maskInteractionDelegateField;

		// Token: 0x04000003 RID: 3
		private static readonly SpriteShapeRenderer.SetSegmentCountDelegate SetSegmentCountDelegateField;

		// Token: 0x04000004 RID: 4
		private static readonly SpriteShapeRenderer.SetMeshDataCountDelegate SetMeshDataCountDelegateField;

		// Token: 0x04000005 RID: 5
		private static readonly SpriteShapeRenderer.SetMeshChannelInfoDelegate SetMeshChannelInfoDelegateField;

		// Token: 0x04000006 RID: 6
		private static readonly SpriteShapeRenderer.get_color_InjectedDelegate get_color_InjectedDelegateField;

		// Token: 0x04000007 RID: 7
		private static readonly SpriteShapeRenderer.set_color_InjectedDelegate set_color_InjectedDelegateField;

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x0600000F RID: 15
		private delegate SpriteMaskInteraction get_maskInteractionDelegate(IntPtr @this);

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x06000011 RID: 17
		private delegate void set_maskInteractionDelegate(IntPtr @this, SpriteMaskInteraction value);

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x06000013 RID: 19
		private delegate void SetSegmentCountDelegate(IntPtr @this, int geomCount);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x06000015 RID: 21
		private delegate void SetMeshDataCountDelegate(IntPtr @this, int vertexCount, int indexCount);

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x06000017 RID: 23
		private delegate void SetMeshChannelInfoDelegate(IntPtr @this, int vertexCount, int indexCount, int hotChannelMask);

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x06000019 RID: 25
		private delegate void get_color_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x0600001B RID: 27
		private delegate void set_color_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
