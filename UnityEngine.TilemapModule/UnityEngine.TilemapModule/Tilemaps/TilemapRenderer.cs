using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.U2D;

namespace UnityEngine.Tilemaps
{
	// Token: 0x02000007 RID: 7
	public sealed class TilemapRenderer : Renderer
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x00003DBC File Offset: 0x00001FBC
		// Note: this type is marked as 'beforefieldinit'.
		static TilemapRenderer()
		{
			Il2CppClassPointerStore<TilemapRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TilemapModule.dll", "UnityEngine.Tilemaps", "TilemapRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TilemapRenderer>.NativeClassPtr);
			TilemapRenderer.NativeMethodInfoPtr_RegisterSpriteAtlasRegistered_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilemapRenderer>.NativeClassPtr, 100663323);
			TilemapRenderer.NativeMethodInfoPtr_UnregisterSpriteAtlasRegistered_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilemapRenderer>.NativeClassPtr, 100663324);
			TilemapRenderer.NativeMethodInfoPtr_OnSpriteAtlasRegistered_Internal_Void_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilemapRenderer>.NativeClassPtr, 100663325);
			TilemapRenderer.get_maxChunkCountDelegateField = IL2CPP.ResolveICall<TilemapRenderer.get_maxChunkCountDelegate>("UnityEngine.Tilemaps.TilemapRenderer::get_maxChunkCount");
			TilemapRenderer.set_maxChunkCountDelegateField = IL2CPP.ResolveICall<TilemapRenderer.set_maxChunkCountDelegate>("UnityEngine.Tilemaps.TilemapRenderer::set_maxChunkCount");
			TilemapRenderer.get_maxFrameAgeDelegateField = IL2CPP.ResolveICall<TilemapRenderer.get_maxFrameAgeDelegate>("UnityEngine.Tilemaps.TilemapRenderer::get_maxFrameAge");
			TilemapRenderer.set_maxFrameAgeDelegateField = IL2CPP.ResolveICall<TilemapRenderer.set_maxFrameAgeDelegate>("UnityEngine.Tilemaps.TilemapRenderer::set_maxFrameAge");
			TilemapRenderer.get_sortOrderDelegateField = IL2CPP.ResolveICall<TilemapRenderer.get_sortOrderDelegate>("UnityEngine.Tilemaps.TilemapRenderer::get_sortOrder");
			TilemapRenderer.set_sortOrderDelegateField = IL2CPP.ResolveICall<TilemapRenderer.set_sortOrderDelegate>("UnityEngine.Tilemaps.TilemapRenderer::set_sortOrder");
			TilemapRenderer.get_modeDelegateField = IL2CPP.ResolveICall<TilemapRenderer.get_modeDelegate>("UnityEngine.Tilemaps.TilemapRenderer::get_mode");
			TilemapRenderer.set_modeDelegateField = IL2CPP.ResolveICall<TilemapRenderer.set_modeDelegate>("UnityEngine.Tilemaps.TilemapRenderer::set_mode");
			TilemapRenderer.get_detectChunkCullingBoundsDelegateField = IL2CPP.ResolveICall<TilemapRenderer.get_detectChunkCullingBoundsDelegate>("UnityEngine.Tilemaps.TilemapRenderer::get_detectChunkCullingBounds");
			TilemapRenderer.set_detectChunkCullingBoundsDelegateField = IL2CPP.ResolveICall<TilemapRenderer.set_detectChunkCullingBoundsDelegate>("UnityEngine.Tilemaps.TilemapRenderer::set_detectChunkCullingBounds");
			TilemapRenderer.get_maskInteractionDelegateField = IL2CPP.ResolveICall<TilemapRenderer.get_maskInteractionDelegate>("UnityEngine.Tilemaps.TilemapRenderer::get_maskInteraction");
			TilemapRenderer.set_maskInteractionDelegateField = IL2CPP.ResolveICall<TilemapRenderer.set_maskInteractionDelegate>("UnityEngine.Tilemaps.TilemapRenderer::set_maskInteraction");
			TilemapRenderer.get_chunkSize_InjectedDelegateField = IL2CPP.ResolveICall<TilemapRenderer.get_chunkSize_InjectedDelegate>("UnityEngine.Tilemaps.TilemapRenderer::get_chunkSize_Injected");
			TilemapRenderer.set_chunkSize_InjectedDelegateField = IL2CPP.ResolveICall<TilemapRenderer.set_chunkSize_InjectedDelegate>("UnityEngine.Tilemaps.TilemapRenderer::set_chunkSize_Injected");
			TilemapRenderer.get_chunkCullingBounds_InjectedDelegateField = IL2CPP.ResolveICall<TilemapRenderer.get_chunkCullingBounds_InjectedDelegate>("UnityEngine.Tilemaps.TilemapRenderer::get_chunkCullingBounds_Injected");
			TilemapRenderer.set_chunkCullingBounds_InjectedDelegateField = IL2CPP.ResolveICall<TilemapRenderer.set_chunkCullingBounds_InjectedDelegate>("UnityEngine.Tilemaps.TilemapRenderer::set_chunkCullingBounds_Injected");
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00003F18 File Offset: 0x00002118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90702, XrefRangeEnd = 90714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterSpriteAtlasRegistered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilemapRenderer.NativeMethodInfoPtr_RegisterSpriteAtlasRegistered_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00003F4C File Offset: 0x0000214C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90714, XrefRangeEnd = 90726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterSpriteAtlasRegistered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilemapRenderer.NativeMethodInfoPtr_UnregisterSpriteAtlasRegistered_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00003F80 File Offset: 0x00002180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90726, XrefRangeEnd = 90728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSpriteAtlasRegistered(SpriteAtlas atlas)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(atlas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilemapRenderer.NativeMethodInfoPtr_OnSpriteAtlasRegistered_Internal_Void_SpriteAtlas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000266A File Offset: 0x0000086A
		public TilemapRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00003FC4 File Offset: 0x000021C4
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00002673 File Offset: 0x00000873
		public Vector3Int chunkSize
		{
			get
			{
				Vector3Int vector3Int;
				this.get_chunkSize_Injected(out vector3Int);
				return vector3Int;
			}
			set
			{
				this.set_chunkSize_Injected(ref value);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00003FDC File Offset: 0x000021DC
		// (set) Token: 0x060000AB RID: 171 RVA: 0x0000267D File Offset: 0x0000087D
		public Vector3 chunkCullingBounds
		{
			get
			{
				Vector3 vector;
				this.get_chunkCullingBounds_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_chunkCullingBounds_Injected(ref value);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00002687 File Offset: 0x00000887
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00002699 File Offset: 0x00000899
		public int maxChunkCount
		{
			get
			{
				return TilemapRenderer.get_maxChunkCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TilemapRenderer.set_maxChunkCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000AE RID: 174 RVA: 0x000026AC File Offset: 0x000008AC
		// (set) Token: 0x060000AF RID: 175 RVA: 0x000026BE File Offset: 0x000008BE
		public int maxFrameAge
		{
			get
			{
				return TilemapRenderer.get_maxFrameAgeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TilemapRenderer.set_maxFrameAgeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000026D1 File Offset: 0x000008D1
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x000026E3 File Offset: 0x000008E3
		public TilemapRenderer.SortOrder sortOrder
		{
			get
			{
				return TilemapRenderer.get_sortOrderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TilemapRenderer.set_sortOrderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000026F6 File Offset: 0x000008F6
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00002708 File Offset: 0x00000908
		public TilemapRenderer.Mode mode
		{
			get
			{
				return TilemapRenderer.get_modeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TilemapRenderer.set_modeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x0000271B File Offset: 0x0000091B
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x0000272D File Offset: 0x0000092D
		public TilemapRenderer.DetectChunkCullingBounds detectChunkCullingBounds
		{
			get
			{
				return TilemapRenderer.get_detectChunkCullingBoundsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TilemapRenderer.set_detectChunkCullingBoundsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00002740 File Offset: 0x00000940
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00002752 File Offset: 0x00000952
		public SpriteMaskInteraction maskInteraction
		{
			get
			{
				return TilemapRenderer.get_maskInteractionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TilemapRenderer.set_maskInteractionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002765 File Offset: 0x00000965
		public void get_chunkSize_Injected(out Vector3Int ret)
		{
			TilemapRenderer.get_chunkSize_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002778 File Offset: 0x00000978
		public void set_chunkSize_Injected(ref Vector3Int value)
		{
			TilemapRenderer.set_chunkSize_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000278B File Offset: 0x0000098B
		public void get_chunkCullingBounds_Injected(out Vector3 ret)
		{
			TilemapRenderer.get_chunkCullingBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000279E File Offset: 0x0000099E
		public void set_chunkCullingBounds_Injected(ref Vector3 value)
		{
			TilemapRenderer.set_chunkCullingBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_RegisterSpriteAtlasRegistered_Internal_Void_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterSpriteAtlasRegistered_Internal_Void_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_OnSpriteAtlasRegistered_Internal_Void_SpriteAtlas_0;

		// Token: 0x0400005E RID: 94
		private static readonly TilemapRenderer.get_maxChunkCountDelegate get_maxChunkCountDelegateField;

		// Token: 0x0400005F RID: 95
		private static readonly TilemapRenderer.set_maxChunkCountDelegate set_maxChunkCountDelegateField;

		// Token: 0x04000060 RID: 96
		private static readonly TilemapRenderer.get_maxFrameAgeDelegate get_maxFrameAgeDelegateField;

		// Token: 0x04000061 RID: 97
		private static readonly TilemapRenderer.set_maxFrameAgeDelegate set_maxFrameAgeDelegateField;

		// Token: 0x04000062 RID: 98
		private static readonly TilemapRenderer.get_sortOrderDelegate get_sortOrderDelegateField;

		// Token: 0x04000063 RID: 99
		private static readonly TilemapRenderer.set_sortOrderDelegate set_sortOrderDelegateField;

		// Token: 0x04000064 RID: 100
		private static readonly TilemapRenderer.get_modeDelegate get_modeDelegateField;

		// Token: 0x04000065 RID: 101
		private static readonly TilemapRenderer.set_modeDelegate set_modeDelegateField;

		// Token: 0x04000066 RID: 102
		private static readonly TilemapRenderer.get_detectChunkCullingBoundsDelegate get_detectChunkCullingBoundsDelegateField;

		// Token: 0x04000067 RID: 103
		private static readonly TilemapRenderer.set_detectChunkCullingBoundsDelegate set_detectChunkCullingBoundsDelegateField;

		// Token: 0x04000068 RID: 104
		private static readonly TilemapRenderer.get_maskInteractionDelegate get_maskInteractionDelegateField;

		// Token: 0x04000069 RID: 105
		private static readonly TilemapRenderer.set_maskInteractionDelegate set_maskInteractionDelegateField;

		// Token: 0x0400006A RID: 106
		private static readonly TilemapRenderer.get_chunkSize_InjectedDelegate get_chunkSize_InjectedDelegateField;

		// Token: 0x0400006B RID: 107
		private static readonly TilemapRenderer.set_chunkSize_InjectedDelegate set_chunkSize_InjectedDelegateField;

		// Token: 0x0400006C RID: 108
		private static readonly TilemapRenderer.get_chunkCullingBounds_InjectedDelegate get_chunkCullingBounds_InjectedDelegateField;

		// Token: 0x0400006D RID: 109
		private static readonly TilemapRenderer.set_chunkCullingBounds_InjectedDelegate set_chunkCullingBounds_InjectedDelegateField;

		// Token: 0x02000040 RID: 64
		public enum SortOrder
		{
			// Token: 0x04000090 RID: 144
			BottomLeft,
			// Token: 0x04000091 RID: 145
			BottomRight,
			// Token: 0x04000092 RID: 146
			TopLeft,
			// Token: 0x04000093 RID: 147
			TopRight
		}

		// Token: 0x02000041 RID: 65
		public enum Mode
		{
			// Token: 0x04000095 RID: 149
			Chunk,
			// Token: 0x04000096 RID: 150
			Individual
		}

		// Token: 0x02000042 RID: 66
		public enum DetectChunkCullingBounds
		{
			// Token: 0x04000098 RID: 152
			Auto,
			// Token: 0x04000099 RID: 153
			Manual
		}

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x06000162 RID: 354
		private delegate int get_maxChunkCountDelegate(IntPtr @this);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x06000164 RID: 356
		private delegate void set_maxChunkCountDelegate(IntPtr @this, int value);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x06000166 RID: 358
		private delegate int get_maxFrameAgeDelegate(IntPtr @this);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x06000168 RID: 360
		private delegate void set_maxFrameAgeDelegate(IntPtr @this, int value);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x0600016A RID: 362
		private delegate TilemapRenderer.SortOrder get_sortOrderDelegate(IntPtr @this);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x0600016C RID: 364
		private delegate void set_sortOrderDelegate(IntPtr @this, TilemapRenderer.SortOrder value);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x0600016E RID: 366
		private delegate TilemapRenderer.Mode get_modeDelegate(IntPtr @this);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x06000170 RID: 368
		private delegate void set_modeDelegate(IntPtr @this, TilemapRenderer.Mode value);

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x06000172 RID: 370
		private delegate TilemapRenderer.DetectChunkCullingBounds get_detectChunkCullingBoundsDelegate(IntPtr @this);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x06000174 RID: 372
		private delegate void set_detectChunkCullingBoundsDelegate(IntPtr @this, TilemapRenderer.DetectChunkCullingBounds value);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x06000176 RID: 374
		private delegate SpriteMaskInteraction get_maskInteractionDelegate(IntPtr @this);

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x06000178 RID: 376
		private delegate void set_maskInteractionDelegate(IntPtr @this, SpriteMaskInteraction value);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x0600017A RID: 378
		private delegate void get_chunkSize_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x0600017C RID: 380
		private delegate void set_chunkSize_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x0600017E RID: 382
		private delegate void get_chunkCullingBounds_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x06000180 RID: 384
		private delegate void set_chunkCullingBounds_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
