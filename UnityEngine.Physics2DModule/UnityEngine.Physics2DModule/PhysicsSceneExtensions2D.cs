using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.SceneManagement;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	public static class PhysicsSceneExtensions2D
	{
		// Token: 0x060002FE RID: 766 RVA: 0x0000AEDC File Offset: 0x000090DC
		public static PhysicsScene2D GetPhysicsScene2D(Scene scene)
		{
			bool flag = !scene.IsValid();
			if (flag)
			{
				throw new ArgumentException("Cannot get physics scene; Unity scene is invalid.", "scene");
			}
			PhysicsScene2D physicsScene_Internal = PhysicsSceneExtensions2D.GetPhysicsScene_Internal(scene);
			bool flag2 = physicsScene_Internal.IsValid();
			if (flag2)
			{
				return physicsScene_Internal;
			}
			throw new Exception("The physics scene associated with the Unity scene is invalid.");
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000AF2C File Offset: 0x0000912C
		public static PhysicsScene2D GetPhysicsScene_Internal(Scene scene)
		{
			PhysicsScene2D physicsScene2D;
			PhysicsSceneExtensions2D.GetPhysicsScene_Internal_Injected(ref scene, out physicsScene2D);
			return physicsScene2D;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000035BD File Offset: 0x000017BD
		public static void GetPhysicsScene_Internal_Injected(ref Scene scene, out PhysicsScene2D ret)
		{
			PhysicsSceneExtensions2D.GetPhysicsScene_Internal_InjectedDelegateField(ref scene, out ret);
		}

		// Token: 0x0400015B RID: 347
		private static readonly PhysicsSceneExtensions2D.GetPhysicsScene_Internal_InjectedDelegate GetPhysicsScene_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsSceneExtensions2D.GetPhysicsScene_Internal_InjectedDelegate>("UnityEngine.PhysicsSceneExtensions2D::GetPhysicsScene_Internal_Injected");

		// Token: 0x02000117 RID: 279
		// (Invoke) Token: 0x060005FC RID: 1532
		private delegate void GetPhysicsScene_Internal_InjectedDelegate(IntPtr scene, [Out] IntPtr ret);
	}
}
