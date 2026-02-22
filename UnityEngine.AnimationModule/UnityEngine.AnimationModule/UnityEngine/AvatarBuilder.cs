using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000040 RID: 64
	public class AvatarBuilder
	{
		// Token: 0x0600043E RID: 1086 RVA: 0x0000C364 File Offset: 0x0000A564
		public static Avatar BuildGenericAvatar(GameObject go, string rootMotionTransformName)
		{
			IntPtr intPtr = AvatarBuilder.BuildGenericAvatarDelegateField(IL2CPP.Il2CppObjectBaseToPtr(go), IL2CPP.ManagedStringToIl2Cpp(rootMotionTransformName));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
		}

		// Token: 0x0400030E RID: 782
		private static readonly AvatarBuilder.BuildGenericAvatarDelegate BuildGenericAvatarDelegateField = IL2CPP.ResolveICall<AvatarBuilder.BuildGenericAvatarDelegate>("UnityEngine.AvatarBuilder::BuildGenericAvatar");

		// Token: 0x020001DF RID: 479
		// (Invoke) Token: 0x06000862 RID: 2146
		private delegate IntPtr BuildGenericAvatarDelegate(IntPtr go, IntPtr rootMotionTransformName);
	}
}
