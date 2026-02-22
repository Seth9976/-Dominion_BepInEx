using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200001F RID: 31
	public class ImmediateStylePainter
	{
		// Token: 0x0600014C RID: 332 RVA: 0x00002C20 File Offset: 0x00000E20
		public static void DrawRect(Rect screenRect, Color color, Vector4 borderWidths, Vector4 borderRadiuses)
		{
			ImmediateStylePainter.DrawRect_Injected(ref screenRect, ref color, ref borderWidths, ref borderRadiuses);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000050CC File Offset: 0x000032CC
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, int leftBorder, int topBorder, int rightBorder, int bottomBorder, bool usePremultiplyAlpha)
		{
			ImmediateStylePainter.DrawTexture_Injected(ref screenRect, texture, ref sourceRect, ref color, ref borderWidths, ref borderRadiuses, leftBorder, topBorder, rightBorder, bottomBorder, usePremultiplyAlpha);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000050F4 File Offset: 0x000032F4
		public static void DrawText(Rect screenRect, string text, Font font, int fontSize, FontStyle fontStyle, Color fontColor, TextAnchor anchor, bool wordWrap, float wordWrapWidth, bool richText, TextClipping textClipping)
		{
			ImmediateStylePainter.DrawText_Injected(ref screenRect, text, font, fontSize, fontStyle, ref fontColor, anchor, wordWrap, wordWrapWidth, richText, textClipping);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002C2F File Offset: 0x00000E2F
		public static void DrawRect_Injected(ref Rect screenRect, ref Color color, ref Vector4 borderWidths, ref Vector4 borderRadiuses)
		{
			ImmediateStylePainter.DrawRect_InjectedDelegateField(ref screenRect, ref color, ref borderWidths, ref borderRadiuses);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000511C File Offset: 0x0000331C
		public static void DrawTexture_Injected(ref Rect screenRect, Texture texture, ref Rect sourceRect, ref Color color, ref Vector4 borderWidths, ref Vector4 borderRadiuses, int leftBorder, int topBorder, int rightBorder, int bottomBorder, bool usePremultiplyAlpha)
		{
			ImmediateStylePainter.DrawTexture_InjectedDelegateField(ref screenRect, IL2CPP.Il2CppObjectBaseToPtr(texture), ref sourceRect, ref color, ref borderWidths, ref borderRadiuses, leftBorder, topBorder, rightBorder, bottomBorder, usePremultiplyAlpha);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000514C File Offset: 0x0000334C
		public static void DrawText_Injected(ref Rect screenRect, string text, Font font, int fontSize, FontStyle fontStyle, ref Color fontColor, TextAnchor anchor, bool wordWrap, float wordWrapWidth, bool richText, TextClipping textClipping)
		{
			ImmediateStylePainter.DrawText_InjectedDelegateField(ref screenRect, IL2CPP.ManagedStringToIl2Cpp(text), IL2CPP.Il2CppObjectBaseToPtr(font), fontSize, fontStyle, ref fontColor, anchor, wordWrap, wordWrapWidth, richText, textClipping);
		}

		// Token: 0x04000100 RID: 256
		private static readonly ImmediateStylePainter.DrawRect_InjectedDelegate DrawRect_InjectedDelegateField = IL2CPP.ResolveICall<ImmediateStylePainter.DrawRect_InjectedDelegate>("UnityEngine.UIElements.ImmediateStylePainter::DrawRect_Injected");

		// Token: 0x04000101 RID: 257
		private static readonly ImmediateStylePainter.DrawTexture_InjectedDelegate DrawTexture_InjectedDelegateField = IL2CPP.ResolveICall<ImmediateStylePainter.DrawTexture_InjectedDelegate>("UnityEngine.UIElements.ImmediateStylePainter::DrawTexture_Injected");

		// Token: 0x04000102 RID: 258
		private static readonly ImmediateStylePainter.DrawText_InjectedDelegate DrawText_InjectedDelegateField = IL2CPP.ResolveICall<ImmediateStylePainter.DrawText_InjectedDelegate>("UnityEngine.UIElements.ImmediateStylePainter::DrawText_Injected");

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x0600023C RID: 572
		private delegate void DrawRect_InjectedDelegate(IntPtr screenRect, IntPtr color, IntPtr borderWidths, IntPtr borderRadiuses);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x0600023E RID: 574
		private delegate void DrawTexture_InjectedDelegate(IntPtr screenRect, IntPtr texture, IntPtr sourceRect, IntPtr color, IntPtr borderWidths, IntPtr borderRadiuses, int leftBorder, int topBorder, int rightBorder, int bottomBorder, bool usePremultiplyAlpha);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x06000240 RID: 576
		private delegate void DrawText_InjectedDelegate(IntPtr screenRect, IntPtr text, IntPtr font, int fontSize, FontStyle fontStyle, IntPtr fontColor, TextAnchor anchor, bool wordWrap, float wordWrapWidth, bool richText, TextClipping textClipping);
	}
}
