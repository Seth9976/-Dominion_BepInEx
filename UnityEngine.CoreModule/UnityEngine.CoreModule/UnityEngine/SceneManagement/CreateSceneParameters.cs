using System;

namespace UnityEngine.SceneManagement
{
	// Token: 0x0200026C RID: 620
	[Serializable]
	public struct CreateSceneParameters
	{
		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06002001 RID: 8193 RVA: 0x00067130 File Offset: 0x00065330
		// (set) Token: 0x06002002 RID: 8194 RVA: 0x000127D4 File Offset: 0x000109D4
		public LocalPhysicsMode localPhysicsMode
		{
			get
			{
				return this.m_LocalPhysicsMode;
			}
			set
			{
				this.m_LocalPhysicsMode = value;
			}
		}

		// Token: 0x04001956 RID: 6486
		public LocalPhysicsMode m_LocalPhysicsMode;
	}
}
