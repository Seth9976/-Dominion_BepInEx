using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000020 RID: 32
	public sealed class WebCamTexture : Texture
	{
		// Token: 0x060001BD RID: 445 RVA: 0x000034C7 File Offset: 0x000016C7
		public void Play()
		{
			WebCamTexture.PlayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000034D9 File Offset: 0x000016D9
		public void Pause()
		{
			WebCamTexture.PauseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000034EB File Offset: 0x000016EB
		public void Stop()
		{
			WebCamTexture.StopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x000034FD File Offset: 0x000016FD
		public bool isPlaying
		{
			get
			{
				return WebCamTexture.get_isPlayingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00006618 File Offset: 0x00004818
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x0000350F File Offset: 0x0000170F
		public string deviceName
		{
			get
			{
				IntPtr intPtr = WebCamTexture.get_deviceNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				WebCamTexture.set_deviceNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00003527 File Offset: 0x00001727
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x00003539 File Offset: 0x00001739
		public float requestedFPS
		{
			get
			{
				return WebCamTexture.get_requestedFPSDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WebCamTexture.set_requestedFPSDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x0000354C File Offset: 0x0000174C
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x0000355E File Offset: 0x0000175E
		public int requestedWidth
		{
			get
			{
				return WebCamTexture.get_requestedWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WebCamTexture.set_requestedWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00003571 File Offset: 0x00001771
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00003583 File Offset: 0x00001783
		public int requestedHeight
		{
			get
			{
				return WebCamTexture.get_requestedHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WebCamTexture.set_requestedHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00003596 File Offset: 0x00001796
		public int videoRotationAngle
		{
			get
			{
				return WebCamTexture.get_videoRotationAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001CA RID: 458 RVA: 0x000035A8 File Offset: 0x000017A8
		public bool videoVerticallyMirrored
		{
			get
			{
				return WebCamTexture.get_videoVerticallyMirroredDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001CB RID: 459 RVA: 0x000035BA File Offset: 0x000017BA
		public bool didUpdateThisFrame
		{
			get
			{
				return WebCamTexture.get_didUpdateThisFrameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000663C File Offset: 0x0000483C
		public Color GetPixel(int x, int y)
		{
			Color color;
			this.GetPixel_Injected(x, y, out color);
			return color;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00006654 File Offset: 0x00004854
		public Il2CppStructArray<Color> GetPixels()
		{
			return this.GetPixels(0, 0, this.width, this.height);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000667C File Offset: 0x0000487C
		public Il2CppStructArray<Color> GetPixels(int x, int y, int blockWidth, int blockHeight)
		{
			IntPtr intPtr = WebCamTexture.GetPixelsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), x, y, blockWidth, blockHeight);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000066B0 File Offset: 0x000048B0
		public Il2CppStructArray<Color32> GetPixels32()
		{
			return this.GetPixels32(null);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000066CC File Offset: 0x000048CC
		public Il2CppStructArray<Color32> GetPixels32(Il2CppStructArray<Color32> colors)
		{
			IntPtr intPtr = WebCamTexture.GetPixels32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(colors));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr2) : null;
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00006700 File Offset: 0x00004900
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x000035CC File Offset: 0x000017CC
		public Nullable<Vector2> autoFocusPoint
		{
			get
			{
				return (this.internalAutoFocusPoint.x < 0f) ? null : new Nullable<Vector2>(this.internalAutoFocusPoint);
			}
			set
			{
				this.internalAutoFocusPoint = ((!value.HasValue) ? new Vector2(-1f, -1f) : value.Value);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0000673C File Offset: 0x0000493C
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x000035F7 File Offset: 0x000017F7
		public Vector2 internalAutoFocusPoint
		{
			get
			{
				Vector2 vector;
				this.get_internalAutoFocusPoint_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_internalAutoFocusPoint_Injected(ref value);
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00003601 File Offset: 0x00001801
		public bool isDepth
		{
			get
			{
				return WebCamTexture.get_isDepthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00003613 File Offset: 0x00001813
		public static void Internal_CreateWebCamTexture(WebCamTexture self, string scriptingDevice, int requestedWidth, int requestedHeight, int maxFramerate)
		{
			WebCamTexture.Internal_CreateWebCamTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self), IL2CPP.ManagedStringToIl2Cpp(scriptingDevice), requestedWidth, requestedHeight, maxFramerate);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000362F File Offset: 0x0000182F
		public void GetPixel_Injected(int x, int y, out Color ret)
		{
			WebCamTexture.GetPixel_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), x, y, out ret);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00003644 File Offset: 0x00001844
		public void get_internalAutoFocusPoint_Injected(out Vector2 ret)
		{
			WebCamTexture.get_internalAutoFocusPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00003657 File Offset: 0x00001857
		public void set_internalAutoFocusPoint_Injected(ref Vector2 value)
		{
			WebCamTexture.set_internalAutoFocusPoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000171 RID: 369
		private static readonly WebCamTexture.PlayDelegate PlayDelegateField = IL2CPP.ResolveICall<WebCamTexture.PlayDelegate>("UnityEngine.WebCamTexture::Play");

		// Token: 0x04000172 RID: 370
		private static readonly WebCamTexture.PauseDelegate PauseDelegateField = IL2CPP.ResolveICall<WebCamTexture.PauseDelegate>("UnityEngine.WebCamTexture::Pause");

		// Token: 0x04000173 RID: 371
		private static readonly WebCamTexture.StopDelegate StopDelegateField = IL2CPP.ResolveICall<WebCamTexture.StopDelegate>("UnityEngine.WebCamTexture::Stop");

		// Token: 0x04000174 RID: 372
		private static readonly WebCamTexture.get_isPlayingDelegate get_isPlayingDelegateField = IL2CPP.ResolveICall<WebCamTexture.get_isPlayingDelegate>("UnityEngine.WebCamTexture::get_isPlaying");

		// Token: 0x04000175 RID: 373
		private static readonly WebCamTexture.get_deviceNameDelegate get_deviceNameDelegateField = IL2CPP.ResolveICall<WebCamTexture.get_deviceNameDelegate>("UnityEngine.WebCamTexture::get_deviceName");

		// Token: 0x04000176 RID: 374
		private static readonly WebCamTexture.set_deviceNameDelegate set_deviceNameDelegateField = IL2CPP.ResolveICall<WebCamTexture.set_deviceNameDelegate>("UnityEngine.WebCamTexture::set_deviceName");

		// Token: 0x04000177 RID: 375
		private static readonly WebCamTexture.get_requestedFPSDelegate get_requestedFPSDelegateField = IL2CPP.ResolveICall<WebCamTexture.get_requestedFPSDelegate>("UnityEngine.WebCamTexture::get_requestedFPS");

		// Token: 0x04000178 RID: 376
		private static readonly WebCamTexture.set_requestedFPSDelegate set_requestedFPSDelegateField = IL2CPP.ResolveICall<WebCamTexture.set_requestedFPSDelegate>("UnityEngine.WebCamTexture::set_requestedFPS");

		// Token: 0x04000179 RID: 377
		private static readonly WebCamTexture.get_requestedWidthDelegate get_requestedWidthDelegateField = IL2CPP.ResolveICall<WebCamTexture.get_requestedWidthDelegate>("UnityEngine.WebCamTexture::get_requestedWidth");

		// Token: 0x0400017A RID: 378
		private static readonly WebCamTexture.set_requestedWidthDelegate set_requestedWidthDelegateField = IL2CPP.ResolveICall<WebCamTexture.set_requestedWidthDelegate>("UnityEngine.WebCamTexture::set_requestedWidth");

		// Token: 0x0400017B RID: 379
		private static readonly WebCamTexture.get_requestedHeightDelegate get_requestedHeightDelegateField = IL2CPP.ResolveICall<WebCamTexture.get_requestedHeightDelegate>("UnityEngine.WebCamTexture::get_requestedHeight");

		// Token: 0x0400017C RID: 380
		private static readonly WebCamTexture.set_requestedHeightDelegate set_requestedHeightDelegateField = IL2CPP.ResolveICall<WebCamTexture.set_requestedHeightDelegate>("UnityEngine.WebCamTexture::set_requestedHeight");

		// Token: 0x0400017D RID: 381
		private static readonly WebCamTexture.get_videoRotationAngleDelegate get_videoRotationAngleDelegateField = IL2CPP.ResolveICall<WebCamTexture.get_videoRotationAngleDelegate>("UnityEngine.WebCamTexture::get_videoRotationAngle");

		// Token: 0x0400017E RID: 382
		private static readonly WebCamTexture.get_videoVerticallyMirroredDelegate get_videoVerticallyMirroredDelegateField = IL2CPP.ResolveICall<WebCamTexture.get_videoVerticallyMirroredDelegate>("UnityEngine.WebCamTexture::get_videoVerticallyMirrored");

		// Token: 0x0400017F RID: 383
		private static readonly WebCamTexture.get_didUpdateThisFrameDelegate get_didUpdateThisFrameDelegateField = IL2CPP.ResolveICall<WebCamTexture.get_didUpdateThisFrameDelegate>("UnityEngine.WebCamTexture::get_didUpdateThisFrame");

		// Token: 0x04000180 RID: 384
		private static readonly WebCamTexture.GetPixelsDelegate GetPixelsDelegateField = IL2CPP.ResolveICall<WebCamTexture.GetPixelsDelegate>("UnityEngine.WebCamTexture::GetPixels");

		// Token: 0x04000181 RID: 385
		private static readonly WebCamTexture.GetPixels32Delegate GetPixels32DelegateField = IL2CPP.ResolveICall<WebCamTexture.GetPixels32Delegate>("UnityEngine.WebCamTexture::GetPixels32");

		// Token: 0x04000182 RID: 386
		private static readonly WebCamTexture.get_isDepthDelegate get_isDepthDelegateField = IL2CPP.ResolveICall<WebCamTexture.get_isDepthDelegate>("UnityEngine.WebCamTexture::get_isDepth");

		// Token: 0x04000183 RID: 387
		private static readonly WebCamTexture.Internal_CreateWebCamTextureDelegate Internal_CreateWebCamTextureDelegateField = IL2CPP.ResolveICall<WebCamTexture.Internal_CreateWebCamTextureDelegate>("UnityEngine.WebCamTexture::Internal_CreateWebCamTexture");

		// Token: 0x04000184 RID: 388
		private static readonly WebCamTexture.GetPixel_InjectedDelegate GetPixel_InjectedDelegateField = IL2CPP.ResolveICall<WebCamTexture.GetPixel_InjectedDelegate>("UnityEngine.WebCamTexture::GetPixel_Injected");

		// Token: 0x04000185 RID: 389
		private static readonly WebCamTexture.get_internalAutoFocusPoint_InjectedDelegate get_internalAutoFocusPoint_InjectedDelegateField = IL2CPP.ResolveICall<WebCamTexture.get_internalAutoFocusPoint_InjectedDelegate>("UnityEngine.WebCamTexture::get_internalAutoFocusPoint_Injected");

		// Token: 0x04000186 RID: 390
		private static readonly WebCamTexture.set_internalAutoFocusPoint_InjectedDelegate set_internalAutoFocusPoint_InjectedDelegateField = IL2CPP.ResolveICall<WebCamTexture.set_internalAutoFocusPoint_InjectedDelegate>("UnityEngine.WebCamTexture::set_internalAutoFocusPoint_Injected");

		// Token: 0x02000120 RID: 288
		// (Invoke) Token: 0x060003F6 RID: 1014
		private delegate void PlayDelegate(IntPtr @this);

		// Token: 0x02000121 RID: 289
		// (Invoke) Token: 0x060003F8 RID: 1016
		private delegate void PauseDelegate(IntPtr @this);

		// Token: 0x02000122 RID: 290
		// (Invoke) Token: 0x060003FA RID: 1018
		private delegate void StopDelegate(IntPtr @this);

		// Token: 0x02000123 RID: 291
		// (Invoke) Token: 0x060003FC RID: 1020
		private delegate bool get_isPlayingDelegate(IntPtr @this);

		// Token: 0x02000124 RID: 292
		// (Invoke) Token: 0x060003FE RID: 1022
		private delegate IntPtr get_deviceNameDelegate(IntPtr @this);

		// Token: 0x02000125 RID: 293
		// (Invoke) Token: 0x06000400 RID: 1024
		private delegate void set_deviceNameDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000126 RID: 294
		// (Invoke) Token: 0x06000402 RID: 1026
		private delegate float get_requestedFPSDelegate(IntPtr @this);

		// Token: 0x02000127 RID: 295
		// (Invoke) Token: 0x06000404 RID: 1028
		private delegate void set_requestedFPSDelegate(IntPtr @this, float value);

		// Token: 0x02000128 RID: 296
		// (Invoke) Token: 0x06000406 RID: 1030
		private delegate int get_requestedWidthDelegate(IntPtr @this);

		// Token: 0x02000129 RID: 297
		// (Invoke) Token: 0x06000408 RID: 1032
		private delegate void set_requestedWidthDelegate(IntPtr @this, int value);

		// Token: 0x0200012A RID: 298
		// (Invoke) Token: 0x0600040A RID: 1034
		private delegate int get_requestedHeightDelegate(IntPtr @this);

		// Token: 0x0200012B RID: 299
		// (Invoke) Token: 0x0600040C RID: 1036
		private delegate void set_requestedHeightDelegate(IntPtr @this, int value);

		// Token: 0x0200012C RID: 300
		// (Invoke) Token: 0x0600040E RID: 1038
		private delegate int get_videoRotationAngleDelegate(IntPtr @this);

		// Token: 0x0200012D RID: 301
		// (Invoke) Token: 0x06000410 RID: 1040
		private delegate bool get_videoVerticallyMirroredDelegate(IntPtr @this);

		// Token: 0x0200012E RID: 302
		// (Invoke) Token: 0x06000412 RID: 1042
		private delegate bool get_didUpdateThisFrameDelegate(IntPtr @this);

		// Token: 0x0200012F RID: 303
		// (Invoke) Token: 0x06000414 RID: 1044
		private delegate IntPtr GetPixelsDelegate(IntPtr @this, int x, int y, int blockWidth, int blockHeight);

		// Token: 0x02000130 RID: 304
		// (Invoke) Token: 0x06000416 RID: 1046
		private delegate IntPtr GetPixels32Delegate(IntPtr @this, IntPtr colors);

		// Token: 0x02000131 RID: 305
		// (Invoke) Token: 0x06000418 RID: 1048
		private delegate bool get_isDepthDelegate(IntPtr @this);

		// Token: 0x02000132 RID: 306
		// (Invoke) Token: 0x0600041A RID: 1050
		private delegate void Internal_CreateWebCamTextureDelegate(IntPtr self, IntPtr scriptingDevice, int requestedWidth, int requestedHeight, int maxFramerate);

		// Token: 0x02000133 RID: 307
		// (Invoke) Token: 0x0600041C RID: 1052
		private delegate void GetPixel_InjectedDelegate(IntPtr @this, int x, int y, [Out] IntPtr ret);

		// Token: 0x02000134 RID: 308
		// (Invoke) Token: 0x0600041E RID: 1054
		private delegate void get_internalAutoFocusPoint_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000135 RID: 309
		// (Invoke) Token: 0x06000420 RID: 1056
		private delegate void set_internalAutoFocusPoint_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
