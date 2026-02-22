using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020001DD RID: 477
	public sealed class GL
	{
		// Token: 0x06001CBD RID: 7357 RVA: 0x0000FD8A File Offset: 0x0000DF8A
		public static void Vertex3(float x, float y, float z)
		{
			GL.Vertex3DelegateField(x, y, z);
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x0000FD99 File Offset: 0x0000DF99
		public static void Vertex(Vector3 v)
		{
			GL.Vertex3(v.x, v.y, v.z);
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x0000FDB4 File Offset: 0x0000DFB4
		public static void TexCoord3(float x, float y, float z)
		{
			GL.TexCoord3DelegateField(x, y, z);
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x0000FDC3 File Offset: 0x0000DFC3
		public static void TexCoord(Vector3 v)
		{
			GL.TexCoord3(v.x, v.y, v.z);
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x0000FDDE File Offset: 0x0000DFDE
		public static void TexCoord2(float x, float y)
		{
			GL.TexCoord3(x, y, 0f);
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x0000FDEE File Offset: 0x0000DFEE
		public static void MultiTexCoord3(int unit, float x, float y, float z)
		{
			GL.MultiTexCoord3DelegateField(unit, x, y, z);
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x0000FDFE File Offset: 0x0000DFFE
		public static void MultiTexCoord(int unit, Vector3 v)
		{
			GL.MultiTexCoord3(unit, v.x, v.y, v.z);
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x0000FE1A File Offset: 0x0000E01A
		public static void MultiTexCoord2(int unit, float x, float y)
		{
			GL.MultiTexCoord3(unit, x, y, 0f);
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x0000FE2B File Offset: 0x0000E02B
		public static void ImmediateColor(float r, float g, float b, float a)
		{
			GL.ImmediateColorDelegateField(r, g, b, a);
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x0000FE3B File Offset: 0x0000E03B
		public static void Color(Color c)
		{
			GL.ImmediateColor(c.r, c.g, c.b, c.a);
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001CC7 RID: 7367 RVA: 0x0000FE5C File Offset: 0x0000E05C
		// (set) Token: 0x06001CC8 RID: 7368 RVA: 0x0000FE68 File Offset: 0x0000E068
		public static bool wireframe
		{
			get
			{
				return GL.get_wireframeDelegateField();
			}
			set
			{
				GL.set_wireframeDelegateField(value);
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001CC9 RID: 7369 RVA: 0x0000FE75 File Offset: 0x0000E075
		// (set) Token: 0x06001CCA RID: 7370 RVA: 0x0000FE81 File Offset: 0x0000E081
		public static bool sRGBWrite
		{
			get
			{
				return GL.get_sRGBWriteDelegateField();
			}
			set
			{
				GL.set_sRGBWriteDelegateField(value);
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001CCB RID: 7371 RVA: 0x0000FE8E File Offset: 0x0000E08E
		// (set) Token: 0x06001CCC RID: 7372 RVA: 0x0000FE9A File Offset: 0x0000E09A
		public static bool invertCulling
		{
			get
			{
				return GL.get_invertCullingDelegateField();
			}
			set
			{
				GL.set_invertCullingDelegateField(value);
			}
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x0000FEA7 File Offset: 0x0000E0A7
		public static void Flush()
		{
			GL.FlushDelegateField();
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x0000FEB3 File Offset: 0x0000E0B3
		public static void RenderTargetBarrier()
		{
			GL.RenderTargetBarrierDelegateField();
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x00062C88 File Offset: 0x00060E88
		public static Matrix4x4 GetWorldViewMatrix()
		{
			Matrix4x4 matrix4x;
			GL.GetWorldViewMatrix_Injected(out matrix4x);
			return matrix4x;
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x0000FEBF File Offset: 0x0000E0BF
		public static void SetViewMatrix(Matrix4x4 m)
		{
			GL.SetViewMatrix_Injected(ref m);
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001CD1 RID: 7377 RVA: 0x00062CA0 File Offset: 0x00060EA0
		// (set) Token: 0x06001CD2 RID: 7378 RVA: 0x0000FEC8 File Offset: 0x0000E0C8
		public static Matrix4x4 modelview
		{
			get
			{
				return GL.GetWorldViewMatrix();
			}
			set
			{
				GL.SetViewMatrix(value);
			}
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x0000FED2 File Offset: 0x0000E0D2
		public static void MultMatrix(Matrix4x4 m)
		{
			GL.MultMatrix_Injected(ref m);
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x0000FEDB File Offset: 0x0000E0DB
		public static void IssuePluginEvent(int eventID)
		{
			GL.IssuePluginEventDelegateField(eventID);
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x0000FEE8 File Offset: 0x0000E0E8
		public static void SetRevertBackfacing(bool revertBackFaces)
		{
			GL.SetRevertBackfacingDelegateField(revertBackFaces);
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x0000FEF5 File Offset: 0x0000E0F5
		public static void PushMatrix()
		{
			GL.PushMatrixDelegateField();
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x0000FF01 File Offset: 0x0000E101
		public static void PopMatrix()
		{
			GL.PopMatrixDelegateField();
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x0000FF0D File Offset: 0x0000E10D
		public static void LoadIdentity()
		{
			GL.LoadIdentityDelegateField();
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x0000FF19 File Offset: 0x0000E119
		public static void LoadOrtho()
		{
			GL.LoadOrthoDelegateField();
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x0000FF25 File Offset: 0x0000E125
		public static void LoadPixelMatrix()
		{
			GL.LoadPixelMatrixDelegateField();
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x0000FF31 File Offset: 0x0000E131
		public static void LoadProjectionMatrix(Matrix4x4 mat)
		{
			GL.LoadProjectionMatrix_Injected(ref mat);
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x0000FF3A File Offset: 0x0000E13A
		public static void InvalidateState()
		{
			GL.InvalidateStateDelegateField();
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x00062CB8 File Offset: 0x00060EB8
		public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture)
		{
			Matrix4x4 matrix4x;
			GL.GetGPUProjectionMatrix_Injected(ref proj, renderIntoTexture, out matrix4x);
			return matrix4x;
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x0000FF46 File Offset: 0x0000E146
		public static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top)
		{
			GL.GLLoadPixelMatrixScriptDelegateField(left, right, bottom, top);
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x0000FF56 File Offset: 0x0000E156
		public static void LoadPixelMatrix(float left, float right, float bottom, float top)
		{
			GL.GLLoadPixelMatrixScript(left, right, bottom, top);
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x0000FF63 File Offset: 0x0000E163
		public static void GLIssuePluginEvent(IntPtr callback, int eventID)
		{
			GL.GLIssuePluginEventDelegateField(callback, eventID);
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x00062CD0 File Offset: 0x00060ED0
		public static void IssuePluginEvent(IntPtr callback, int eventID)
		{
			bool flag = callback == IntPtr.Zero;
			if (flag)
			{
				throw new ArgumentException("Null callback specified.", "callback");
			}
			GL.GLIssuePluginEvent(callback, eventID);
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x0000FF71 File Offset: 0x0000E171
		public static void Begin(int mode)
		{
			GL.BeginDelegateField(mode);
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x0000FF7E File Offset: 0x0000E17E
		public static void End()
		{
			GL.EndDelegateField();
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x0000FF8A File Offset: 0x0000E18A
		public static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth)
		{
			GL.GLClear_Injected(clearDepth, clearColor, ref backgroundColor, depth);
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x0000FF96 File Offset: 0x0000E196
		public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor, float depth)
		{
			GL.GLClear(clearDepth, clearColor, backgroundColor, depth);
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x0000FFA3 File Offset: 0x0000E1A3
		public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor)
		{
			GL.GLClear(clearDepth, clearColor, backgroundColor, 1f);
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x0000FFB4 File Offset: 0x0000E1B4
		public static void Viewport(Rect pixelRect)
		{
			GL.Viewport_Injected(ref pixelRect);
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x0000FFBD File Offset: 0x0000E1BD
		public static void ClearWithSkybox(bool clearDepth, Camera camera)
		{
			GL.ClearWithSkyboxDelegateField(clearDepth, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x0000FFD0 File Offset: 0x0000E1D0
		public static void GetWorldViewMatrix_Injected(out Matrix4x4 ret)
		{
			GL.GetWorldViewMatrix_InjectedDelegateField(out ret);
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x0000FFDD File Offset: 0x0000E1DD
		public static void SetViewMatrix_Injected(ref Matrix4x4 m)
		{
			GL.SetViewMatrix_InjectedDelegateField(ref m);
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x0000FFEA File Offset: 0x0000E1EA
		public static void MultMatrix_Injected(ref Matrix4x4 m)
		{
			GL.MultMatrix_InjectedDelegateField(ref m);
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x0000FFF7 File Offset: 0x0000E1F7
		public static void LoadProjectionMatrix_Injected(ref Matrix4x4 mat)
		{
			GL.LoadProjectionMatrix_InjectedDelegateField(ref mat);
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x00010004 File Offset: 0x0000E204
		public static void GetGPUProjectionMatrix_Injected(ref Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 ret)
		{
			GL.GetGPUProjectionMatrix_InjectedDelegateField(ref proj, renderIntoTexture, out ret);
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x00010013 File Offset: 0x0000E213
		public static void GLClear_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth)
		{
			GL.GLClear_InjectedDelegateField(clearDepth, clearColor, ref backgroundColor, depth);
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x00010023 File Offset: 0x0000E223
		public static void Viewport_Injected(ref Rect pixelRect)
		{
			GL.Viewport_InjectedDelegateField(ref pixelRect);
		}

		// Token: 0x040016AE RID: 5806
		public const int TRIANGLES = 4;

		// Token: 0x040016AF RID: 5807
		public const int TRIANGLE_STRIP = 5;

		// Token: 0x040016B0 RID: 5808
		public const int QUADS = 7;

		// Token: 0x040016B1 RID: 5809
		public const int LINES = 1;

		// Token: 0x040016B2 RID: 5810
		public const int LINE_STRIP = 2;

		// Token: 0x040016B3 RID: 5811
		private static readonly GL.Vertex3Delegate Vertex3DelegateField = IL2CPP.ResolveICall<GL.Vertex3Delegate>("UnityEngine.GL::Vertex3");

		// Token: 0x040016B4 RID: 5812
		private static readonly GL.TexCoord3Delegate TexCoord3DelegateField = IL2CPP.ResolveICall<GL.TexCoord3Delegate>("UnityEngine.GL::TexCoord3");

		// Token: 0x040016B5 RID: 5813
		private static readonly GL.MultiTexCoord3Delegate MultiTexCoord3DelegateField = IL2CPP.ResolveICall<GL.MultiTexCoord3Delegate>("UnityEngine.GL::MultiTexCoord3");

		// Token: 0x040016B6 RID: 5814
		private static readonly GL.ImmediateColorDelegate ImmediateColorDelegateField = IL2CPP.ResolveICall<GL.ImmediateColorDelegate>("UnityEngine.GL::ImmediateColor");

		// Token: 0x040016B7 RID: 5815
		private static readonly GL.get_wireframeDelegate get_wireframeDelegateField = IL2CPP.ResolveICall<GL.get_wireframeDelegate>("UnityEngine.GL::get_wireframe");

		// Token: 0x040016B8 RID: 5816
		private static readonly GL.set_wireframeDelegate set_wireframeDelegateField = IL2CPP.ResolveICall<GL.set_wireframeDelegate>("UnityEngine.GL::set_wireframe");

		// Token: 0x040016B9 RID: 5817
		private static readonly GL.get_sRGBWriteDelegate get_sRGBWriteDelegateField = IL2CPP.ResolveICall<GL.get_sRGBWriteDelegate>("UnityEngine.GL::get_sRGBWrite");

		// Token: 0x040016BA RID: 5818
		private static readonly GL.set_sRGBWriteDelegate set_sRGBWriteDelegateField = IL2CPP.ResolveICall<GL.set_sRGBWriteDelegate>("UnityEngine.GL::set_sRGBWrite");

		// Token: 0x040016BB RID: 5819
		private static readonly GL.get_invertCullingDelegate get_invertCullingDelegateField = IL2CPP.ResolveICall<GL.get_invertCullingDelegate>("UnityEngine.GL::get_invertCulling");

		// Token: 0x040016BC RID: 5820
		private static readonly GL.set_invertCullingDelegate set_invertCullingDelegateField = IL2CPP.ResolveICall<GL.set_invertCullingDelegate>("UnityEngine.GL::set_invertCulling");

		// Token: 0x040016BD RID: 5821
		private static readonly GL.FlushDelegate FlushDelegateField = IL2CPP.ResolveICall<GL.FlushDelegate>("UnityEngine.GL::Flush");

		// Token: 0x040016BE RID: 5822
		private static readonly GL.RenderTargetBarrierDelegate RenderTargetBarrierDelegateField = IL2CPP.ResolveICall<GL.RenderTargetBarrierDelegate>("UnityEngine.GL::RenderTargetBarrier");

		// Token: 0x040016BF RID: 5823
		private static readonly GL.IssuePluginEventDelegate IssuePluginEventDelegateField = IL2CPP.ResolveICall<GL.IssuePluginEventDelegate>("UnityEngine.GL::IssuePluginEvent");

		// Token: 0x040016C0 RID: 5824
		private static readonly GL.SetRevertBackfacingDelegate SetRevertBackfacingDelegateField = IL2CPP.ResolveICall<GL.SetRevertBackfacingDelegate>("UnityEngine.GL::SetRevertBackfacing");

		// Token: 0x040016C1 RID: 5825
		private static readonly GL.PushMatrixDelegate PushMatrixDelegateField = IL2CPP.ResolveICall<GL.PushMatrixDelegate>("UnityEngine.GL::PushMatrix");

		// Token: 0x040016C2 RID: 5826
		private static readonly GL.PopMatrixDelegate PopMatrixDelegateField = IL2CPP.ResolveICall<GL.PopMatrixDelegate>("UnityEngine.GL::PopMatrix");

		// Token: 0x040016C3 RID: 5827
		private static readonly GL.LoadIdentityDelegate LoadIdentityDelegateField = IL2CPP.ResolveICall<GL.LoadIdentityDelegate>("UnityEngine.GL::LoadIdentity");

		// Token: 0x040016C4 RID: 5828
		private static readonly GL.LoadOrthoDelegate LoadOrthoDelegateField = IL2CPP.ResolveICall<GL.LoadOrthoDelegate>("UnityEngine.GL::LoadOrtho");

		// Token: 0x040016C5 RID: 5829
		private static readonly GL.LoadPixelMatrixDelegate LoadPixelMatrixDelegateField = IL2CPP.ResolveICall<GL.LoadPixelMatrixDelegate>("UnityEngine.GL::LoadPixelMatrix");

		// Token: 0x040016C6 RID: 5830
		private static readonly GL.InvalidateStateDelegate InvalidateStateDelegateField = IL2CPP.ResolveICall<GL.InvalidateStateDelegate>("UnityEngine.GL::InvalidateState");

		// Token: 0x040016C7 RID: 5831
		private static readonly GL.GLLoadPixelMatrixScriptDelegate GLLoadPixelMatrixScriptDelegateField = IL2CPP.ResolveICall<GL.GLLoadPixelMatrixScriptDelegate>("UnityEngine.GL::GLLoadPixelMatrixScript");

		// Token: 0x040016C8 RID: 5832
		private static readonly GL.GLIssuePluginEventDelegate GLIssuePluginEventDelegateField = IL2CPP.ResolveICall<GL.GLIssuePluginEventDelegate>("UnityEngine.GL::GLIssuePluginEvent");

		// Token: 0x040016C9 RID: 5833
		private static readonly GL.BeginDelegate BeginDelegateField = IL2CPP.ResolveICall<GL.BeginDelegate>("UnityEngine.GL::Begin");

		// Token: 0x040016CA RID: 5834
		private static readonly GL.EndDelegate EndDelegateField = IL2CPP.ResolveICall<GL.EndDelegate>("UnityEngine.GL::End");

		// Token: 0x040016CB RID: 5835
		private static readonly GL.ClearWithSkyboxDelegate ClearWithSkyboxDelegateField = IL2CPP.ResolveICall<GL.ClearWithSkyboxDelegate>("UnityEngine.GL::ClearWithSkybox");

		// Token: 0x040016CC RID: 5836
		private static readonly GL.GetWorldViewMatrix_InjectedDelegate GetWorldViewMatrix_InjectedDelegateField = IL2CPP.ResolveICall<GL.GetWorldViewMatrix_InjectedDelegate>("UnityEngine.GL::GetWorldViewMatrix_Injected");

		// Token: 0x040016CD RID: 5837
		private static readonly GL.SetViewMatrix_InjectedDelegate SetViewMatrix_InjectedDelegateField = IL2CPP.ResolveICall<GL.SetViewMatrix_InjectedDelegate>("UnityEngine.GL::SetViewMatrix_Injected");

		// Token: 0x040016CE RID: 5838
		private static readonly GL.MultMatrix_InjectedDelegate MultMatrix_InjectedDelegateField = IL2CPP.ResolveICall<GL.MultMatrix_InjectedDelegate>("UnityEngine.GL::MultMatrix_Injected");

		// Token: 0x040016CF RID: 5839
		private static readonly GL.LoadProjectionMatrix_InjectedDelegate LoadProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<GL.LoadProjectionMatrix_InjectedDelegate>("UnityEngine.GL::LoadProjectionMatrix_Injected");

		// Token: 0x040016D0 RID: 5840
		private static readonly GL.GetGPUProjectionMatrix_InjectedDelegate GetGPUProjectionMatrix_InjectedDelegateField = IL2CPP.ResolveICall<GL.GetGPUProjectionMatrix_InjectedDelegate>("UnityEngine.GL::GetGPUProjectionMatrix_Injected");

		// Token: 0x040016D1 RID: 5841
		private static readonly GL.GLClear_InjectedDelegate GLClear_InjectedDelegateField = IL2CPP.ResolveICall<GL.GLClear_InjectedDelegate>("UnityEngine.GL::GLClear_Injected");

		// Token: 0x040016D2 RID: 5842
		private static readonly GL.Viewport_InjectedDelegate Viewport_InjectedDelegateField = IL2CPP.ResolveICall<GL.Viewport_InjectedDelegate>("UnityEngine.GL::Viewport_Injected");

		// Token: 0x02000AD4 RID: 2772
		// (Invoke) Token: 0x060033A8 RID: 13224
		private delegate void Vertex3Delegate(float x, float y, float z);

		// Token: 0x02000AD5 RID: 2773
		// (Invoke) Token: 0x060033AA RID: 13226
		private delegate void TexCoord3Delegate(float x, float y, float z);

		// Token: 0x02000AD6 RID: 2774
		// (Invoke) Token: 0x060033AC RID: 13228
		private delegate void MultiTexCoord3Delegate(int unit, float x, float y, float z);

		// Token: 0x02000AD7 RID: 2775
		// (Invoke) Token: 0x060033AE RID: 13230
		private delegate void ImmediateColorDelegate(float r, float g, float b, float a);

		// Token: 0x02000AD8 RID: 2776
		// (Invoke) Token: 0x060033B0 RID: 13232
		private delegate bool get_wireframeDelegate();

		// Token: 0x02000AD9 RID: 2777
		// (Invoke) Token: 0x060033B2 RID: 13234
		private delegate void set_wireframeDelegate(bool value);

		// Token: 0x02000ADA RID: 2778
		// (Invoke) Token: 0x060033B4 RID: 13236
		private delegate bool get_sRGBWriteDelegate();

		// Token: 0x02000ADB RID: 2779
		// (Invoke) Token: 0x060033B6 RID: 13238
		private delegate void set_sRGBWriteDelegate(bool value);

		// Token: 0x02000ADC RID: 2780
		// (Invoke) Token: 0x060033B8 RID: 13240
		private delegate bool get_invertCullingDelegate();

		// Token: 0x02000ADD RID: 2781
		// (Invoke) Token: 0x060033BA RID: 13242
		private delegate void set_invertCullingDelegate(bool value);

		// Token: 0x02000ADE RID: 2782
		// (Invoke) Token: 0x060033BC RID: 13244
		private delegate void FlushDelegate();

		// Token: 0x02000ADF RID: 2783
		// (Invoke) Token: 0x060033BE RID: 13246
		private delegate void RenderTargetBarrierDelegate();

		// Token: 0x02000AE0 RID: 2784
		// (Invoke) Token: 0x060033C0 RID: 13248
		private delegate void IssuePluginEventDelegate(int eventID);

		// Token: 0x02000AE1 RID: 2785
		// (Invoke) Token: 0x060033C2 RID: 13250
		private delegate void SetRevertBackfacingDelegate(bool revertBackFaces);

		// Token: 0x02000AE2 RID: 2786
		// (Invoke) Token: 0x060033C4 RID: 13252
		private delegate void PushMatrixDelegate();

		// Token: 0x02000AE3 RID: 2787
		// (Invoke) Token: 0x060033C6 RID: 13254
		private delegate void PopMatrixDelegate();

		// Token: 0x02000AE4 RID: 2788
		// (Invoke) Token: 0x060033C8 RID: 13256
		private delegate void LoadIdentityDelegate();

		// Token: 0x02000AE5 RID: 2789
		// (Invoke) Token: 0x060033CA RID: 13258
		private delegate void LoadOrthoDelegate();

		// Token: 0x02000AE6 RID: 2790
		// (Invoke) Token: 0x060033CC RID: 13260
		private delegate void LoadPixelMatrixDelegate();

		// Token: 0x02000AE7 RID: 2791
		// (Invoke) Token: 0x060033CE RID: 13262
		private delegate void InvalidateStateDelegate();

		// Token: 0x02000AE8 RID: 2792
		// (Invoke) Token: 0x060033D0 RID: 13264
		private delegate void GLLoadPixelMatrixScriptDelegate(float left, float right, float bottom, float top);

		// Token: 0x02000AE9 RID: 2793
		// (Invoke) Token: 0x060033D2 RID: 13266
		private delegate void GLIssuePluginEventDelegate(IntPtr callback, int eventID);

		// Token: 0x02000AEA RID: 2794
		// (Invoke) Token: 0x060033D4 RID: 13268
		private delegate void BeginDelegate(int mode);

		// Token: 0x02000AEB RID: 2795
		// (Invoke) Token: 0x060033D6 RID: 13270
		private delegate void EndDelegate();

		// Token: 0x02000AEC RID: 2796
		// (Invoke) Token: 0x060033D8 RID: 13272
		private delegate void ClearWithSkyboxDelegate(bool clearDepth, IntPtr camera);

		// Token: 0x02000AED RID: 2797
		// (Invoke) Token: 0x060033DA RID: 13274
		private delegate void GetWorldViewMatrix_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000AEE RID: 2798
		// (Invoke) Token: 0x060033DC RID: 13276
		private delegate void SetViewMatrix_InjectedDelegate(IntPtr m);

		// Token: 0x02000AEF RID: 2799
		// (Invoke) Token: 0x060033DE RID: 13278
		private delegate void MultMatrix_InjectedDelegate(IntPtr m);

		// Token: 0x02000AF0 RID: 2800
		// (Invoke) Token: 0x060033E0 RID: 13280
		private delegate void LoadProjectionMatrix_InjectedDelegate(IntPtr mat);

		// Token: 0x02000AF1 RID: 2801
		// (Invoke) Token: 0x060033E2 RID: 13282
		private delegate void GetGPUProjectionMatrix_InjectedDelegate(IntPtr proj, bool renderIntoTexture, [Out] IntPtr ret);

		// Token: 0x02000AF2 RID: 2802
		// (Invoke) Token: 0x060033E4 RID: 13284
		private delegate void GLClear_InjectedDelegate(bool clearDepth, bool clearColor, IntPtr backgroundColor, float depth);

		// Token: 0x02000AF3 RID: 2803
		// (Invoke) Token: 0x060033E6 RID: 13286
		private delegate void Viewport_InjectedDelegate(IntPtr pixelRect);
	}
}
