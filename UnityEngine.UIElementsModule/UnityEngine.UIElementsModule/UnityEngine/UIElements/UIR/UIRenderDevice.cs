using System;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020001C5 RID: 453
	public class UIRenderDevice
	{
		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x0000BC15 File Offset: 0x00009E15
		public uint maxVerticesPerPage
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001231 RID: 4657 RVA: 0x0000BC22 File Offset: 0x00009E22
		// (set) Token: 0x06001232 RID: 4658 RVA: 0x0000BC2F File Offset: 0x00009E2F
		public bool breakBatches
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x0000BC3C File Offset: 0x00009E3C
		public static Texture2D defaultShaderInfoTexFloat
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001234 RID: 4660 RVA: 0x0000BC49 File Offset: 0x00009E49
		public static Texture2D defaultShaderInfoTexARGB8
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001235 RID: 4661 RVA: 0x0000BC56 File Offset: 0x00009E56
		public static bool vertexTexturingIsAvailable
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001236 RID: 4662 RVA: 0x0000BC63 File Offset: 0x00009E63
		public static bool shaderModelIs35
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x0000BC70 File Offset: 0x00009E70
		public void InitVertexDeclaration()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x0000BC7D File Offset: 0x00009E7D
		public void CompleteCreation()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x0000BC8A File Offset: 0x00009E8A
		public bool fullyCreated
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x0000BC97 File Offset: 0x00009E97
		// (set) Token: 0x0600123B RID: 4667 RVA: 0x0000BCA4 File Offset: 0x00009EA4
		public bool disposed
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x0000BCB1 File Offset: 0x00009EB1
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x0000BCC3 File Offset: 0x00009EC3
		public void DisposeImmediate()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x0000BCD0 File Offset: 0x00009ED0
		public virtual void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x00039374 File Offset: 0x00037574
		public bool TryAllocFromPage(Page page, uint vertexCount, uint indexCount, ref Alloc va, ref Alloc ia, bool shortLived)
		{
			va = page.vertices.allocator.Allocate(vertexCount, shortLived);
			bool flag = va.size > 0U;
			if (flag)
			{
				ia = page.indices.allocator.Allocate(indexCount, shortLived);
				bool flag2 = ia.size > 0U;
				if (flag2)
				{
					return true;
				}
				page.vertices.allocator.Free(va);
				va.size = 0U;
			}
			return false;
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x0000BCDD File Offset: 0x00009EDD
		public void Free(MeshHandle mesh)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x0000BCEA File Offset: 0x00009EEA
		public static void Set1PixelSizeParameter(DrawParams drawParams, MaterialPropertyBlock props)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x0000BCF7 File Offset: 0x00009EF7
		public void OnFrameRenderingBegin()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x0000BD04 File Offset: 0x00009F04
		public void UpdateFenceValue()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x0000BD11 File Offset: 0x00009F11
		public void AdvanceFrame()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x0000BD1E File Offset: 0x00009F1E
		public void PruneUnusedPages()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x0000BD2B File Offset: 0x00009F2B
		public static void PrepareForGfxDeviceRecreate()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x0000BD38 File Offset: 0x00009F38
		public static void WrapUpGfxDeviceRecreate()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x0000BD45 File Offset: 0x00009F45
		public static void FlushAllPendingDeviceDisposes()
		{
			Utility.SyncRenderThread();
			UIRenderDevice.ProcessDeviceFreeQueue();
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x0000BD54 File Offset: 0x00009F54
		public static void ProcessDeviceFreeQueue()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x0000BD61 File Offset: 0x00009F61
		public static void OnEngineUpdateGlobal()
		{
			UIRenderDevice.ProcessDeviceFreeQueue();
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x0000BD6A File Offset: 0x00009F6A
		public static void OnFlushPendingResources()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000803 RID: 2051
		public const uint k_MaxQueuedFrameCount = 4U;

		// Token: 0x04000804 RID: 2052
		public const int k_PruneEmptyPageFrameCount = 60;

		// Token: 0x04000805 RID: 2053
		public const string k_VertexTexturingIsAvailableTag = "UIE_VertexTexturingIsAvailable";

		// Token: 0x04000806 RID: 2054
		public const string k_VertexTexturingIsAvailableTrue = "1";

		// Token: 0x04000807 RID: 2055
		public const string k_ShaderModelIs35Tag = "UIE_ShaderModelIs35";

		// Token: 0x04000808 RID: 2056
		public const string k_ShaderModelIs35True = "1";

		// Token: 0x02000299 RID: 665
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
