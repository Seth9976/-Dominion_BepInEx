using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Unity.Collections;

namespace UnityEngine
{
	// Token: 0x02000043 RID: 67
	public class HumanPoseHandler
	{
		// Token: 0x06000453 RID: 1107 RVA: 0x00004B63 File Offset: 0x00002D63
		public static IntPtr Internal_CreateFromRoot(Avatar avatar, Transform root)
		{
			return HumanPoseHandler.Internal_CreateFromRootDelegateField(IL2CPP.Il2CppObjectBaseToPtr(avatar), IL2CPP.Il2CppObjectBaseToPtr(root));
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00004B7B File Offset: 0x00002D7B
		public static IntPtr Internal_CreateFromJointPaths(Avatar avatar, Il2CppStringArray jointPaths)
		{
			return HumanPoseHandler.Internal_CreateFromJointPathsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(avatar), IL2CPP.Il2CppObjectBaseToPtr(jointPaths));
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00004B93 File Offset: 0x00002D93
		public static void Internal_Destroy(IntPtr ptr)
		{
			HumanPoseHandler.Internal_DestroyDelegateField(ptr);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00004BA0 File Offset: 0x00002DA0
		public void GetHumanPose(out Vector3 bodyPosition, out Quaternion bodyRotation, [Out] Il2CppStructArray<float> muscles)
		{
			HumanPoseHandler.GetHumanPoseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out bodyPosition, out bodyRotation, IL2CPP.Il2CppObjectBaseToPtr(muscles));
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00004BBA File Offset: 0x00002DBA
		public void SetHumanPose(ref Vector3 bodyPosition, ref Quaternion bodyRotation, Il2CppStructArray<float> muscles)
		{
			HumanPoseHandler.SetHumanPoseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref bodyPosition, ref bodyRotation, IL2CPP.Il2CppObjectBaseToPtr(muscles));
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00004BD4 File Offset: 0x00002DD4
		public void GetInternalHumanPose(out Vector3 bodyPosition, out Quaternion bodyRotation, [Out] Il2CppStructArray<float> muscles)
		{
			HumanPoseHandler.GetInternalHumanPoseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out bodyPosition, out bodyRotation, IL2CPP.Il2CppObjectBaseToPtr(muscles));
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00004BEE File Offset: 0x00002DEE
		public void SetInternalHumanPose(ref Vector3 bodyPosition, ref Quaternion bodyRotation, Il2CppStructArray<float> muscles)
		{
			HumanPoseHandler.SetInternalHumanPoseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref bodyPosition, ref bodyRotation, IL2CPP.Il2CppObjectBaseToPtr(muscles));
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00004C08 File Offset: 0x00002E08
		public unsafe void GetInternalAvatarPose(void* avatarPose, int avatarPoseLength)
		{
			HumanPoseHandler.GetInternalAvatarPoseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), avatarPose, avatarPoseLength);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00004C1C File Offset: 0x00002E1C
		public unsafe void SetInternalAvatarPose(void* avatarPose, int avatarPoseLength)
		{
			HumanPoseHandler.SetInternalAvatarPoseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), avatarPose, avatarPoseLength);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00004C30 File Offset: 0x00002E30
		public void Dispose()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00004C3D File Offset: 0x00002E3D
		public void GetInternalAvatarPose(NativeArray<float> avatarPose)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00004C4A File Offset: 0x00002E4A
		public void SetInternalAvatarPose(NativeArray<float> avatarPose)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400032A RID: 810
		private static readonly HumanPoseHandler.Internal_CreateFromRootDelegate Internal_CreateFromRootDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.Internal_CreateFromRootDelegate>("UnityEngine.HumanPoseHandler::Internal_CreateFromRoot");

		// Token: 0x0400032B RID: 811
		private static readonly HumanPoseHandler.Internal_CreateFromJointPathsDelegate Internal_CreateFromJointPathsDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.Internal_CreateFromJointPathsDelegate>("UnityEngine.HumanPoseHandler::Internal_CreateFromJointPaths");

		// Token: 0x0400032C RID: 812
		private static readonly HumanPoseHandler.Internal_DestroyDelegate Internal_DestroyDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.Internal_DestroyDelegate>("UnityEngine.HumanPoseHandler::Internal_Destroy");

		// Token: 0x0400032D RID: 813
		private static readonly HumanPoseHandler.GetHumanPoseDelegate GetHumanPoseDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.GetHumanPoseDelegate>("UnityEngine.HumanPoseHandler::GetHumanPose");

		// Token: 0x0400032E RID: 814
		private static readonly HumanPoseHandler.SetHumanPoseDelegate SetHumanPoseDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.SetHumanPoseDelegate>("UnityEngine.HumanPoseHandler::SetHumanPose");

		// Token: 0x0400032F RID: 815
		private static readonly HumanPoseHandler.GetInternalHumanPoseDelegate GetInternalHumanPoseDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.GetInternalHumanPoseDelegate>("UnityEngine.HumanPoseHandler::GetInternalHumanPose");

		// Token: 0x04000330 RID: 816
		private static readonly HumanPoseHandler.SetInternalHumanPoseDelegate SetInternalHumanPoseDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.SetInternalHumanPoseDelegate>("UnityEngine.HumanPoseHandler::SetInternalHumanPose");

		// Token: 0x04000331 RID: 817
		private static readonly HumanPoseHandler.GetInternalAvatarPoseDelegate GetInternalAvatarPoseDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.GetInternalAvatarPoseDelegate>("UnityEngine.HumanPoseHandler::GetInternalAvatarPose");

		// Token: 0x04000332 RID: 818
		private static readonly HumanPoseHandler.SetInternalAvatarPoseDelegate SetInternalAvatarPoseDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.SetInternalAvatarPoseDelegate>("UnityEngine.HumanPoseHandler::SetInternalAvatarPose");

		// Token: 0x020001EC RID: 492
		// (Invoke) Token: 0x0600087C RID: 2172
		private delegate IntPtr Internal_CreateFromRootDelegate(IntPtr avatar, IntPtr root);

		// Token: 0x020001ED RID: 493
		// (Invoke) Token: 0x0600087E RID: 2174
		private delegate IntPtr Internal_CreateFromJointPathsDelegate(IntPtr avatar, IntPtr jointPaths);

		// Token: 0x020001EE RID: 494
		// (Invoke) Token: 0x06000880 RID: 2176
		private delegate void Internal_DestroyDelegate(IntPtr ptr);

		// Token: 0x020001EF RID: 495
		// (Invoke) Token: 0x06000882 RID: 2178
		private delegate void GetHumanPoseDelegate(IntPtr @this, [Out] IntPtr bodyPosition, [Out] IntPtr bodyRotation, [Out] IntPtr muscles);

		// Token: 0x020001F0 RID: 496
		// (Invoke) Token: 0x06000884 RID: 2180
		private delegate void SetHumanPoseDelegate(IntPtr @this, IntPtr bodyPosition, IntPtr bodyRotation, IntPtr muscles);

		// Token: 0x020001F1 RID: 497
		// (Invoke) Token: 0x06000886 RID: 2182
		private delegate void GetInternalHumanPoseDelegate(IntPtr @this, [Out] IntPtr bodyPosition, [Out] IntPtr bodyRotation, [Out] IntPtr muscles);

		// Token: 0x020001F2 RID: 498
		// (Invoke) Token: 0x06000888 RID: 2184
		private delegate void SetInternalHumanPoseDelegate(IntPtr @this, IntPtr bodyPosition, IntPtr bodyRotation, IntPtr muscles);

		// Token: 0x020001F3 RID: 499
		// (Invoke) Token: 0x0600088A RID: 2186
		private delegate void GetInternalAvatarPoseDelegate(IntPtr @this, IntPtr avatarPose, int avatarPoseLength);

		// Token: 0x020001F4 RID: 500
		// (Invoke) Token: 0x0600088C RID: 2188
		private delegate void SetInternalAvatarPoseDelegate(IntPtr @this, IntPtr avatarPose, int avatarPoseLength);
	}
}
