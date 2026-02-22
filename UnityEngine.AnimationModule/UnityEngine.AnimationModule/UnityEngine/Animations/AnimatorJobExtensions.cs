using System;
using Il2CppInterop.Runtime;
using Unity.Jobs;

namespace UnityEngine.Animations
{
	// Token: 0x02000055 RID: 85
	public static class AnimatorJobExtensions
	{
		// Token: 0x060004C3 RID: 1219 RVA: 0x00005108 File Offset: 0x00003308
		public static void AddJobDependency(Animator animator, JobHandle jobHandle)
		{
			AnimatorJobExtensions.InternalAddJobDependency(animator, jobHandle);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0000CDE0 File Offset: 0x0000AFE0
		public static bool OpenAnimationStream(Animator animator, ref AnimationStream stream)
		{
			return AnimatorJobExtensions.InternalOpenAnimationStream(animator, ref stream);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00005113 File Offset: 0x00003313
		public static void CloseAnimationStream(Animator animator, ref AnimationStream stream)
		{
			AnimatorJobExtensions.InternalCloseAnimationStream(animator, ref stream);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0000511E File Offset: 0x0000331E
		public static void ResolveAllStreamHandles(Animator animator)
		{
			AnimatorJobExtensions.InternalResolveAllStreamHandles(animator);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00005128 File Offset: 0x00003328
		public static void ResolveAllSceneHandles(Animator animator)
		{
			AnimatorJobExtensions.InternalResolveAllSceneHandles(animator);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00005132 File Offset: 0x00003332
		public static void UnbindAllHandles(Animator animator)
		{
			AnimatorJobExtensions.InternalUnbindAllStreamHandles(animator);
			AnimatorJobExtensions.InternalUnbindAllSceneHandles(animator);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00005143 File Offset: 0x00003343
		public static void UnbindAllStreamHandles(Animator animator)
		{
			AnimatorJobExtensions.InternalUnbindAllStreamHandles(animator);
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0000514D File Offset: 0x0000334D
		public static void UnbindAllSceneHandles(Animator animator)
		{
			AnimatorJobExtensions.InternalUnbindAllSceneHandles(animator);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00005157 File Offset: 0x00003357
		public static void InternalAddJobDependency(Animator animator, JobHandle jobHandle)
		{
			AnimatorJobExtensions.InternalAddJobDependency_Injected(animator, ref jobHandle);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00005161 File Offset: 0x00003361
		public static bool InternalOpenAnimationStream(Animator animator, ref AnimationStream stream)
		{
			return AnimatorJobExtensions.InternalOpenAnimationStreamDelegateField(IL2CPP.Il2CppObjectBaseToPtr(animator), ref stream);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00005174 File Offset: 0x00003374
		public static void InternalCloseAnimationStream(Animator animator, ref AnimationStream stream)
		{
			AnimatorJobExtensions.InternalCloseAnimationStreamDelegateField(IL2CPP.Il2CppObjectBaseToPtr(animator), ref stream);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00005187 File Offset: 0x00003387
		public static void InternalResolveAllStreamHandles(Animator animator)
		{
			AnimatorJobExtensions.InternalResolveAllStreamHandlesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(animator));
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00005199 File Offset: 0x00003399
		public static void InternalResolveAllSceneHandles(Animator animator)
		{
			AnimatorJobExtensions.InternalResolveAllSceneHandlesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(animator));
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x000051AB File Offset: 0x000033AB
		public static void InternalUnbindAllStreamHandles(Animator animator)
		{
			AnimatorJobExtensions.InternalUnbindAllStreamHandlesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(animator));
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x000051BD File Offset: 0x000033BD
		public static void InternalUnbindAllSceneHandles(Animator animator)
		{
			AnimatorJobExtensions.InternalUnbindAllSceneHandlesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(animator));
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x000051CF File Offset: 0x000033CF
		public static void InternalAddJobDependency_Injected(Animator animator, ref JobHandle jobHandle)
		{
			AnimatorJobExtensions.InternalAddJobDependency_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(animator), ref jobHandle);
		}

		// Token: 0x04000381 RID: 897
		private static readonly AnimatorJobExtensions.InternalOpenAnimationStreamDelegate InternalOpenAnimationStreamDelegateField = IL2CPP.ResolveICall<AnimatorJobExtensions.InternalOpenAnimationStreamDelegate>("UnityEngine.Animations.AnimatorJobExtensions::InternalOpenAnimationStream");

		// Token: 0x04000382 RID: 898
		private static readonly AnimatorJobExtensions.InternalCloseAnimationStreamDelegate InternalCloseAnimationStreamDelegateField = IL2CPP.ResolveICall<AnimatorJobExtensions.InternalCloseAnimationStreamDelegate>("UnityEngine.Animations.AnimatorJobExtensions::InternalCloseAnimationStream");

		// Token: 0x04000383 RID: 899
		private static readonly AnimatorJobExtensions.InternalResolveAllStreamHandlesDelegate InternalResolveAllStreamHandlesDelegateField = IL2CPP.ResolveICall<AnimatorJobExtensions.InternalResolveAllStreamHandlesDelegate>("UnityEngine.Animations.AnimatorJobExtensions::InternalResolveAllStreamHandles");

		// Token: 0x04000384 RID: 900
		private static readonly AnimatorJobExtensions.InternalResolveAllSceneHandlesDelegate InternalResolveAllSceneHandlesDelegateField = IL2CPP.ResolveICall<AnimatorJobExtensions.InternalResolveAllSceneHandlesDelegate>("UnityEngine.Animations.AnimatorJobExtensions::InternalResolveAllSceneHandles");

		// Token: 0x04000385 RID: 901
		private static readonly AnimatorJobExtensions.InternalUnbindAllStreamHandlesDelegate InternalUnbindAllStreamHandlesDelegateField = IL2CPP.ResolveICall<AnimatorJobExtensions.InternalUnbindAllStreamHandlesDelegate>("UnityEngine.Animations.AnimatorJobExtensions::InternalUnbindAllStreamHandles");

		// Token: 0x04000386 RID: 902
		private static readonly AnimatorJobExtensions.InternalUnbindAllSceneHandlesDelegate InternalUnbindAllSceneHandlesDelegateField = IL2CPP.ResolveICall<AnimatorJobExtensions.InternalUnbindAllSceneHandlesDelegate>("UnityEngine.Animations.AnimatorJobExtensions::InternalUnbindAllSceneHandles");

		// Token: 0x04000387 RID: 903
		private static readonly AnimatorJobExtensions.InternalAddJobDependency_InjectedDelegate InternalAddJobDependency_InjectedDelegateField = IL2CPP.ResolveICall<AnimatorJobExtensions.InternalAddJobDependency_InjectedDelegate>("UnityEngine.Animations.AnimatorJobExtensions::InternalAddJobDependency_Injected");

		// Token: 0x0200022D RID: 557
		// (Invoke) Token: 0x060008FC RID: 2300
		private delegate bool InternalOpenAnimationStreamDelegate(IntPtr animator, IntPtr stream);

		// Token: 0x0200022E RID: 558
		// (Invoke) Token: 0x060008FE RID: 2302
		private delegate void InternalCloseAnimationStreamDelegate(IntPtr animator, IntPtr stream);

		// Token: 0x0200022F RID: 559
		// (Invoke) Token: 0x06000900 RID: 2304
		private delegate void InternalResolveAllStreamHandlesDelegate(IntPtr animator);

		// Token: 0x02000230 RID: 560
		// (Invoke) Token: 0x06000902 RID: 2306
		private delegate void InternalResolveAllSceneHandlesDelegate(IntPtr animator);

		// Token: 0x02000231 RID: 561
		// (Invoke) Token: 0x06000904 RID: 2308
		private delegate void InternalUnbindAllStreamHandlesDelegate(IntPtr animator);

		// Token: 0x02000232 RID: 562
		// (Invoke) Token: 0x06000906 RID: 2310
		private delegate void InternalUnbindAllSceneHandlesDelegate(IntPtr animator);

		// Token: 0x02000233 RID: 563
		// (Invoke) Token: 0x06000908 RID: 2312
		private delegate void InternalAddJobDependency_InjectedDelegate(IntPtr animator, IntPtr jobHandle);
	}
}
