using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.U2D
{
	// Token: 0x02000250 RID: 592
	public static class SpriteRendererDataAccessExtensions
	{
		// Token: 0x06001F83 RID: 8067 RVA: 0x000667D4 File Offset: 0x000649D4
		public static void SetDeformableBuffer(SpriteRenderer spriteRenderer, Unity.Collections.NativeArray<byte> src)
		{
			bool flag = spriteRenderer.sprite == null;
			if (flag)
			{
				throw new ArgumentException(String.Format("spriteRenderer does not have a valid sprite set.", new Il2CppReferenceArray<Object>(0L)));
			}
			bool flag2 = src.Length != SpriteDataAccessExtensions.GetPrimaryVertexStreamSize(spriteRenderer.sprite);
			if (flag2)
			{
				throw new InvalidOperationException(String.Format("custom sprite vertex data size must match sprite asset's vertex data size {0} {1}", src.Length, SpriteDataAccessExtensions.GetPrimaryVertexStreamSize(spriteRenderer.sprite)));
			}
			SpriteRendererDataAccessExtensions.SetDeformableBuffer(spriteRenderer, src.GetUnsafeReadOnlyPtr<byte>(), src.Length);
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x00066864 File Offset: 0x00064A64
		public static void SetDeformableBuffer(SpriteRenderer spriteRenderer, Unity.Collections.NativeArray<Vector3> src)
		{
			bool flag = spriteRenderer.sprite == null;
			if (flag)
			{
				throw new InvalidOperationException("spriteRenderer does not have a valid sprite set.");
			}
			bool flag2 = src.Length != SpriteDataAccessExtensions.GetVertexCount(spriteRenderer.sprite);
			if (flag2)
			{
				throw new InvalidOperationException(String.Format("The src length {0} must match the vertex count of source Sprite {1}.", src.Length, SpriteDataAccessExtensions.GetVertexCount(spriteRenderer.sprite)));
			}
			SpriteRendererDataAccessExtensions.SetDeformableBuffer(spriteRenderer, src.GetUnsafeReadOnlyPtr<Vector3>(), src.Length);
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x000668E8 File Offset: 0x00064AE8
		public static void SetBatchDeformableBufferAndLocalAABBArray(Il2CppReferenceArray<SpriteRenderer> spriteRenderers, Unity.Collections.NativeArray<IntPtr> buffers, Unity.Collections.NativeArray<int> bufferSizes, Unity.Collections.NativeArray<Bounds> bounds)
		{
			int num = spriteRenderers.Length;
			bool flag = num != buffers.Length || num != bufferSizes.Length || num != bounds.Length;
			if (flag)
			{
				throw new ArgumentException("Input array sizes are not the same.");
			}
			SpriteRendererDataAccessExtensions.SetBatchDeformableBufferAndLocalAABBArray(spriteRenderers, buffers.GetUnsafeReadOnlyPtr<IntPtr>(), bufferSizes.GetUnsafeReadOnlyPtr<int>(), bounds.GetUnsafeReadOnlyPtr<Bounds>(), num);
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x0001223D File Offset: 0x0001043D
		public static void DeactivateDeformableBuffer(SpriteRenderer renderer)
		{
			SpriteRendererDataAccessExtensions.DeactivateDeformableBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtr(renderer));
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x0001224F File Offset: 0x0001044F
		public static void SetLocalAABB(SpriteRenderer renderer, Bounds aabb)
		{
			SpriteRendererDataAccessExtensions.SetLocalAABB_Injected(renderer, ref aabb);
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x00012259 File Offset: 0x00010459
		public unsafe static void SetDeformableBuffer(SpriteRenderer spriteRenderer, void* src, int count)
		{
			SpriteRendererDataAccessExtensions.SetDeformableBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtr(spriteRenderer), src, count);
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x0001226D File Offset: 0x0001046D
		public unsafe static void SetBatchDeformableBufferAndLocalAABBArray(Il2CppReferenceArray<SpriteRenderer> spriteRenderers, void* buffers, void* bufferSizes, void* bounds, int count)
		{
			SpriteRendererDataAccessExtensions.SetBatchDeformableBufferAndLocalAABBArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr(spriteRenderers), buffers, bufferSizes, bounds, count);
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x00012284 File Offset: 0x00010484
		public static void SetLocalAABB_Injected(SpriteRenderer renderer, ref Bounds aabb)
		{
			SpriteRendererDataAccessExtensions.SetLocalAABB_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(renderer), ref aabb);
		}

		// Token: 0x040018F9 RID: 6393
		private static readonly SpriteRendererDataAccessExtensions.DeactivateDeformableBufferDelegate DeactivateDeformableBufferDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.DeactivateDeformableBufferDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::DeactivateDeformableBuffer");

		// Token: 0x040018FA RID: 6394
		private static readonly SpriteRendererDataAccessExtensions.SetDeformableBufferDelegate SetDeformableBufferDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.SetDeformableBufferDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::SetDeformableBuffer");

		// Token: 0x040018FB RID: 6395
		private static readonly SpriteRendererDataAccessExtensions.SetBatchDeformableBufferAndLocalAABBArrayDelegate SetBatchDeformableBufferAndLocalAABBArrayDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.SetBatchDeformableBufferAndLocalAABBArrayDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::SetBatchDeformableBufferAndLocalAABBArray");

		// Token: 0x040018FC RID: 6396
		private static readonly SpriteRendererDataAccessExtensions.SetLocalAABB_InjectedDelegate SetLocalAABB_InjectedDelegateField = IL2CPP.ResolveICall<SpriteRendererDataAccessExtensions.SetLocalAABB_InjectedDelegate>("UnityEngine.U2D.SpriteRendererDataAccessExtensions::SetLocalAABB_Injected");

		// Token: 0x02000C35 RID: 3125
		// (Invoke) Token: 0x06003652 RID: 13906
		private delegate void DeactivateDeformableBufferDelegate(IntPtr renderer);

		// Token: 0x02000C36 RID: 3126
		// (Invoke) Token: 0x06003654 RID: 13908
		private delegate void SetDeformableBufferDelegate(IntPtr spriteRenderer, IntPtr src, int count);

		// Token: 0x02000C37 RID: 3127
		// (Invoke) Token: 0x06003656 RID: 13910
		private delegate void SetBatchDeformableBufferAndLocalAABBArrayDelegate(IntPtr spriteRenderers, IntPtr buffers, IntPtr bufferSizes, IntPtr bounds, int count);

		// Token: 0x02000C38 RID: 3128
		// (Invoke) Token: 0x06003658 RID: 13912
		private delegate void SetLocalAABB_InjectedDelegate(IntPtr renderer, IntPtr aabb);
	}
}
