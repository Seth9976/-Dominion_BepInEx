using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x020002A8 RID: 680
	public class SplashScreen
	{
		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060021B1 RID: 8625 RVA: 0x00014052 File Offset: 0x00012252
		public static bool isFinished
		{
			get
			{
				return SplashScreen.get_isFinishedDelegateField();
			}
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x0001405E File Offset: 0x0001225E
		public static void CancelSplashScreen()
		{
			SplashScreen.CancelSplashScreenDelegateField();
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x0001406A File Offset: 0x0001226A
		public static void BeginSplashScreenFade()
		{
			SplashScreen.BeginSplashScreenFadeDelegateField();
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x00014076 File Offset: 0x00012276
		public static void Begin()
		{
			SplashScreen.BeginDelegateField();
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x00069798 File Offset: 0x00067998
		public static void Stop(SplashScreen.StopBehavior stopBehavior)
		{
			bool flag = stopBehavior == SplashScreen.StopBehavior.FadeOut;
			if (flag)
			{
				SplashScreen.BeginSplashScreenFade();
			}
			else
			{
				SplashScreen.CancelSplashScreen();
			}
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x00014082 File Offset: 0x00012282
		public static void Draw()
		{
			SplashScreen.DrawDelegateField();
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x0001408E File Offset: 0x0001228E
		public static void SetTime(float time)
		{
			SplashScreen.SetTimeDelegateField(time);
		}

		// Token: 0x04001B41 RID: 6977
		private static readonly SplashScreen.get_isFinishedDelegate get_isFinishedDelegateField = IL2CPP.ResolveICall<SplashScreen.get_isFinishedDelegate>("UnityEngine.Rendering.SplashScreen::get_isFinished");

		// Token: 0x04001B42 RID: 6978
		private static readonly SplashScreen.CancelSplashScreenDelegate CancelSplashScreenDelegateField = IL2CPP.ResolveICall<SplashScreen.CancelSplashScreenDelegate>("UnityEngine.Rendering.SplashScreen::CancelSplashScreen");

		// Token: 0x04001B43 RID: 6979
		private static readonly SplashScreen.BeginSplashScreenFadeDelegate BeginSplashScreenFadeDelegateField = IL2CPP.ResolveICall<SplashScreen.BeginSplashScreenFadeDelegate>("UnityEngine.Rendering.SplashScreen::BeginSplashScreenFade");

		// Token: 0x04001B44 RID: 6980
		private static readonly SplashScreen.BeginDelegate BeginDelegateField = IL2CPP.ResolveICall<SplashScreen.BeginDelegate>("UnityEngine.Rendering.SplashScreen::Begin");

		// Token: 0x04001B45 RID: 6981
		private static readonly SplashScreen.DrawDelegate DrawDelegateField = IL2CPP.ResolveICall<SplashScreen.DrawDelegate>("UnityEngine.Rendering.SplashScreen::Draw");

		// Token: 0x04001B46 RID: 6982
		private static readonly SplashScreen.SetTimeDelegate SetTimeDelegateField = IL2CPP.ResolveICall<SplashScreen.SetTimeDelegate>("UnityEngine.Rendering.SplashScreen::SetTime");

		// Token: 0x02000CFA RID: 3322
		public enum StopBehavior
		{
			// Token: 0x04001DB6 RID: 7606
			StopImmediate,
			// Token: 0x04001DB7 RID: 7607
			FadeOut
		}

		// Token: 0x02000CFB RID: 3323
		// (Invoke) Token: 0x060037DA RID: 14298
		private delegate bool get_isFinishedDelegate();

		// Token: 0x02000CFC RID: 3324
		// (Invoke) Token: 0x060037DC RID: 14300
		private delegate void CancelSplashScreenDelegate();

		// Token: 0x02000CFD RID: 3325
		// (Invoke) Token: 0x060037DE RID: 14302
		private delegate void BeginSplashScreenFadeDelegate();

		// Token: 0x02000CFE RID: 3326
		// (Invoke) Token: 0x060037E0 RID: 14304
		private delegate void BeginDelegate();

		// Token: 0x02000CFF RID: 3327
		// (Invoke) Token: 0x060037E2 RID: 14306
		private delegate void DrawDelegate();

		// Token: 0x02000D00 RID: 3328
		// (Invoke) Token: 0x060037E4 RID: 14308
		private delegate void SetTimeDelegate(float time);
	}
}
