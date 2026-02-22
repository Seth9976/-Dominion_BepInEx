using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.SceneManagement;

namespace UnityEngine
{
	// Token: 0x02000027 RID: 39
	public static class PhysicsSceneExtensions
	{
		// Token: 0x06000373 RID: 883 RVA: 0x0000A16C File Offset: 0x0000836C
		public static PhysicsScene GetPhysicsScene(Scene scene)
		{
			bool flag = !scene.IsValid();
			if (flag)
			{
				throw new ArgumentException("Cannot get physics scene; Unity scene is invalid.", "scene");
			}
			PhysicsScene physicsScene_Internal = PhysicsSceneExtensions.GetPhysicsScene_Internal(scene);
			bool flag2 = physicsScene_Internal.IsValid();
			if (flag2)
			{
				return physicsScene_Internal;
			}
			throw new Exception("The physics scene associated with the Unity scene is invalid.");
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000A1BC File Offset: 0x000083BC
		public static PhysicsScene GetPhysicsScene_Internal(Scene scene)
		{
			PhysicsScene physicsScene;
			PhysicsSceneExtensions.GetPhysicsScene_Internal_Injected(ref scene, out physicsScene);
			return physicsScene;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00004261 File Offset: 0x00002461
		public static void GetPhysicsScene_Internal_Injected(ref Scene scene, out PhysicsScene ret)
		{
			PhysicsSceneExtensions.GetPhysicsScene_Internal_InjectedDelegateField(ref scene, out ret);
		}

		// Token: 0x04000233 RID: 563
		private static readonly PhysicsSceneExtensions.GetPhysicsScene_Internal_InjectedDelegate GetPhysicsScene_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsSceneExtensions.GetPhysicsScene_Internal_InjectedDelegate>("UnityEngine.PhysicsSceneExtensions::GetPhysicsScene_Internal_Injected");

		// Token: 0x020001AB RID: 427
		// (Invoke) Token: 0x0600067B RID: 1659
		private delegate void GetPhysicsScene_Internal_InjectedDelegate(IntPtr scene, [Out] IntPtr ret);
	}
}
