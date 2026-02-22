using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Rendering;

namespace UnityEngine.U2D
{
	// Token: 0x0200024F RID: 591
	public static class SpriteDataAccessExtensions
	{
		// Token: 0x06001F71 RID: 8049 RVA: 0x000120E9 File Offset: 0x000102E9
		public static void CheckAttributeTypeMatchesAndThrow<T>(UnityEngine.Rendering.VertexAttribute channel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x000120F6 File Offset: 0x000102F6
		public static void SetVertexAttribute<T>(Sprite sprite, UnityEngine.Rendering.VertexAttribute channel, Unity.Collections.NativeArray<T> src) where T : struct
		{
			SpriteDataAccessExtensions.CheckAttributeTypeMatchesAndThrow<T>(channel);
			SpriteDataAccessExtensions.SetChannelData(sprite, channel, src.GetUnsafeReadOnlyPtr<T>());
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x0001210E File Offset: 0x0001030E
		public static Unity.Collections.NativeArray<Matrix4x4> GetBindPoses(Sprite sprite)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x0001211B File Offset: 0x0001031B
		public static void SetBindPoses(Sprite sprite, Unity.Collections.NativeArray<Matrix4x4> src)
		{
			SpriteDataAccessExtensions.SetBindPoseData(sprite, src.GetUnsafeReadOnlyPtr<Matrix4x4>(), src.Length);
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x00012132 File Offset: 0x00010332
		public static Unity.Collections.NativeArray<ushort> GetIndices(Sprite sprite)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x0001213F File Offset: 0x0001033F
		public static void SetIndices(Sprite sprite, Unity.Collections.NativeArray<ushort> src)
		{
			SpriteDataAccessExtensions.SetIndicesData(sprite, src.GetUnsafeReadOnlyPtr<ushort>(), src.Length);
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x00066790 File Offset: 0x00064990
		public static Il2CppReferenceArray<SpriteBone> GetBones(Sprite sprite)
		{
			return SpriteDataAccessExtensions.GetBoneInfo(sprite);
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x00012156 File Offset: 0x00010356
		public static void SetBones(Sprite sprite, Il2CppReferenceArray<SpriteBone> src)
		{
			SpriteDataAccessExtensions.SetBoneData(sprite, src);
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x00012161 File Offset: 0x00010361
		public static bool HasVertexAttribute(Sprite sprite, UnityEngine.Rendering.VertexAttribute channel)
		{
			return SpriteDataAccessExtensions.HasVertexAttributeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), channel);
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x00012174 File Offset: 0x00010374
		public static void SetVertexCount(Sprite sprite, int count)
		{
			SpriteDataAccessExtensions.SetVertexCountDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), count);
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x00012187 File Offset: 0x00010387
		public static int GetVertexCount(Sprite sprite)
		{
			return SpriteDataAccessExtensions.GetVertexCountDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite));
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x00012199 File Offset: 0x00010399
		public unsafe static void SetBindPoseData(Sprite sprite, void* src, int count)
		{
			SpriteDataAccessExtensions.SetBindPoseDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), src, count);
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x000121AD File Offset: 0x000103AD
		public unsafe static void SetIndicesData(Sprite sprite, void* src, int count)
		{
			SpriteDataAccessExtensions.SetIndicesDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), src, count);
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x000121C1 File Offset: 0x000103C1
		public unsafe static void SetChannelData(Sprite sprite, UnityEngine.Rendering.VertexAttribute channel, void* src)
		{
			SpriteDataAccessExtensions.SetChannelDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), channel, src);
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x000667A8 File Offset: 0x000649A8
		public static Il2CppReferenceArray<SpriteBone> GetBoneInfo(Sprite sprite)
		{
			IntPtr intPtr = SpriteDataAccessExtensions.GetBoneInfoDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpriteBone>>(intPtr2) : null;
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x000121D5 File Offset: 0x000103D5
		public static void SetBoneData(Sprite sprite, Il2CppReferenceArray<SpriteBone> src)
		{
			SpriteDataAccessExtensions.SetBoneDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), IL2CPP.Il2CppObjectBaseToPtr(src));
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x000121ED File Offset: 0x000103ED
		public static int GetPrimaryVertexStreamSize(Sprite sprite)
		{
			return SpriteDataAccessExtensions.GetPrimaryVertexStreamSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite));
		}

		// Token: 0x040018F0 RID: 6384
		private static readonly SpriteDataAccessExtensions.HasVertexAttributeDelegate HasVertexAttributeDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.HasVertexAttributeDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::HasVertexAttribute");

		// Token: 0x040018F1 RID: 6385
		private static readonly SpriteDataAccessExtensions.SetVertexCountDelegate SetVertexCountDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.SetVertexCountDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetVertexCount");

		// Token: 0x040018F2 RID: 6386
		private static readonly SpriteDataAccessExtensions.GetVertexCountDelegate GetVertexCountDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.GetVertexCountDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::GetVertexCount");

		// Token: 0x040018F3 RID: 6387
		private static readonly SpriteDataAccessExtensions.SetBindPoseDataDelegate SetBindPoseDataDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.SetBindPoseDataDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetBindPoseData");

		// Token: 0x040018F4 RID: 6388
		private static readonly SpriteDataAccessExtensions.SetIndicesDataDelegate SetIndicesDataDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.SetIndicesDataDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetIndicesData");

		// Token: 0x040018F5 RID: 6389
		private static readonly SpriteDataAccessExtensions.SetChannelDataDelegate SetChannelDataDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.SetChannelDataDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetChannelData");

		// Token: 0x040018F6 RID: 6390
		private static readonly SpriteDataAccessExtensions.GetBoneInfoDelegate GetBoneInfoDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.GetBoneInfoDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::GetBoneInfo");

		// Token: 0x040018F7 RID: 6391
		private static readonly SpriteDataAccessExtensions.SetBoneDataDelegate SetBoneDataDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.SetBoneDataDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetBoneData");

		// Token: 0x040018F8 RID: 6392
		private static readonly SpriteDataAccessExtensions.GetPrimaryVertexStreamSizeDelegate GetPrimaryVertexStreamSizeDelegateField = IL2CPP.ResolveICall<SpriteDataAccessExtensions.GetPrimaryVertexStreamSizeDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::GetPrimaryVertexStreamSize");

		// Token: 0x02000C2C RID: 3116
		// (Invoke) Token: 0x06003640 RID: 13888
		private delegate bool HasVertexAttributeDelegate(IntPtr sprite, UnityEngine.Rendering.VertexAttribute channel);

		// Token: 0x02000C2D RID: 3117
		// (Invoke) Token: 0x06003642 RID: 13890
		private delegate void SetVertexCountDelegate(IntPtr sprite, int count);

		// Token: 0x02000C2E RID: 3118
		// (Invoke) Token: 0x06003644 RID: 13892
		private delegate int GetVertexCountDelegate(IntPtr sprite);

		// Token: 0x02000C2F RID: 3119
		// (Invoke) Token: 0x06003646 RID: 13894
		private delegate void SetBindPoseDataDelegate(IntPtr sprite, IntPtr src, int count);

		// Token: 0x02000C30 RID: 3120
		// (Invoke) Token: 0x06003648 RID: 13896
		private delegate void SetIndicesDataDelegate(IntPtr sprite, IntPtr src, int count);

		// Token: 0x02000C31 RID: 3121
		// (Invoke) Token: 0x0600364A RID: 13898
		private delegate void SetChannelDataDelegate(IntPtr sprite, UnityEngine.Rendering.VertexAttribute channel, IntPtr src);

		// Token: 0x02000C32 RID: 3122
		// (Invoke) Token: 0x0600364C RID: 13900
		private delegate IntPtr GetBoneInfoDelegate(IntPtr sprite);

		// Token: 0x02000C33 RID: 3123
		// (Invoke) Token: 0x0600364E RID: 13902
		private delegate void SetBoneDataDelegate(IntPtr sprite, IntPtr src);

		// Token: 0x02000C34 RID: 3124
		// (Invoke) Token: 0x06003650 RID: 13904
		private delegate int GetPrimaryVertexStreamSizeDelegate(IntPtr sprite);
	}
}
