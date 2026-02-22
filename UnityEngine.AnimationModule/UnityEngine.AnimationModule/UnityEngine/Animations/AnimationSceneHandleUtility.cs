using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Animations
{
	// Token: 0x02000052 RID: 82
	public static class AnimationSceneHandleUtility
	{
		// Token: 0x060004BA RID: 1210 RVA: 0x0000CCF4 File Offset: 0x0000AEF4
		public static int ValidateAndGetArrayCount<T0, T1>(ref AnimationStream stream, NativeArray<T0> handles, NativeArray<T1> buffer) where T0 : struct where T1 : struct
		{
			stream.CheckIsValid();
			bool flag = !handles.IsCreated;
			if (flag)
			{
				throw new NullReferenceException("Handle array is invalid.");
			}
			bool flag2 = !buffer.IsCreated;
			if (flag2)
			{
				throw new NullReferenceException("Data buffer is invalid.");
			}
			bool flag3 = buffer.Length < handles.Length;
			if (flag3)
			{
				throw new InvalidOperationException("Data buffer array is smaller than handles array.");
			}
			return handles.Length;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00005066 File Offset: 0x00003266
		public unsafe static void ReadSceneIntsInternal(ref AnimationStream stream, void* propertySceneHandles, void* intBuffer, int count)
		{
			AnimationSceneHandleUtility.ReadSceneIntsInternalDelegateField(ref stream, propertySceneHandles, intBuffer, count);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00005076 File Offset: 0x00003276
		public unsafe static void ReadSceneFloatsInternal(ref AnimationStream stream, void* propertySceneHandles, void* floatBuffer, int count)
		{
			AnimationSceneHandleUtility.ReadSceneFloatsInternalDelegateField(ref stream, propertySceneHandles, floatBuffer, count);
		}

		// Token: 0x04000377 RID: 887
		private static readonly AnimationSceneHandleUtility.ReadSceneIntsInternalDelegate ReadSceneIntsInternalDelegateField = IL2CPP.ResolveICall<AnimationSceneHandleUtility.ReadSceneIntsInternalDelegate>("UnityEngine.Animations.AnimationSceneHandleUtility::ReadSceneIntsInternal");

		// Token: 0x04000378 RID: 888
		private static readonly AnimationSceneHandleUtility.ReadSceneFloatsInternalDelegate ReadSceneFloatsInternalDelegateField = IL2CPP.ResolveICall<AnimationSceneHandleUtility.ReadSceneFloatsInternalDelegate>("UnityEngine.Animations.AnimationSceneHandleUtility::ReadSceneFloatsInternal");

		// Token: 0x02000227 RID: 551
		// (Invoke) Token: 0x060008F0 RID: 2288
		private delegate void ReadSceneIntsInternalDelegate(IntPtr stream, IntPtr propertySceneHandles, IntPtr intBuffer, int count);

		// Token: 0x02000228 RID: 552
		// (Invoke) Token: 0x060008F2 RID: 2290
		private delegate void ReadSceneFloatsInternalDelegate(IntPtr stream, IntPtr propertySceneHandles, IntPtr floatBuffer, int count);
	}
}
