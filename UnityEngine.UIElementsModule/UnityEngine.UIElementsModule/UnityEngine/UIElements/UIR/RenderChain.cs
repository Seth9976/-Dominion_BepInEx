using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnityEngine.UIElements.UIR.Implementation;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020001B7 RID: 439
	public class RenderChain
	{
		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x060011C8 RID: 4552 RVA: 0x0000B707 File Offset: 0x00009907
		public RenderChainCommand firstCommand
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x0000B714 File Offset: 0x00009914
		public void Constructor(BaseVisualElementPanel panelObj, UIRenderDevice deviceObj, AtlasBase atlas, VectorImageManager vectorImageMan)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x0000B721 File Offset: 0x00009921
		public void Destructor()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x060011CB RID: 4555 RVA: 0x0000B72E File Offset: 0x0000992E
		// (set) Token: 0x060011CC RID: 4556 RVA: 0x0000B73B File Offset: 0x0000993B
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

		// Token: 0x060011CD RID: 4557 RVA: 0x0000B748 File Offset: 0x00009948
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00038FF0 File Offset: 0x000371F0
		public void Dispose(bool disposing)
		{
			bool disposed = this.disposed;
			if (!disposed)
			{
				if (disposing)
				{
					this.Destructor();
				}
				this.disposed = true;
			}
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x0000B75A File Offset: 0x0000995A
		public void ProcessChanges()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x0000B767 File Offset: 0x00009967
		public void Render()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x0000B774 File Offset: 0x00009974
		public void ProcessTextRegen(bool timeSliced)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x0000B781 File Offset: 0x00009981
		public void UIEOnChildAdded(VisualElement parent, VisualElement ve, int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x0000B78E File Offset: 0x0000998E
		public void UIEOnChildrenReordered(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x0000B79B File Offset: 0x0000999B
		public void UIEOnChildRemoving(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x0000B7A8 File Offset: 0x000099A8
		public void StopTrackingGroupTransformElement(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x0000B7B5 File Offset: 0x000099B5
		public void UIEOnClippingChanged(VisualElement ve, bool hierarchical)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x0000B7C2 File Offset: 0x000099C2
		public void UIEOnOpacityChanged(VisualElement ve, [Optional] bool hierarchical)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x0000B7CF File Offset: 0x000099CF
		public void UIEOnTransformOrSizeChanged(VisualElement ve, bool transformChanged, bool clipRectSizeChanged)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x0000B7DC File Offset: 0x000099DC
		public void UIEOnVisualsChanged(VisualElement ve, bool hierarchical)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x0000B7E9 File Offset: 0x000099E9
		// (set) Token: 0x060011DB RID: 4571 RVA: 0x0000B7F6 File Offset: 0x000099F6
		public BaseVisualElementPanel panel
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

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x0000B803 File Offset: 0x00009A03
		// (set) Token: 0x060011DD RID: 4573 RVA: 0x0000B810 File Offset: 0x00009A10
		public UIRenderDevice device
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

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x060011DE RID: 4574 RVA: 0x0000B81D File Offset: 0x00009A1D
		// (set) Token: 0x060011DF RID: 4575 RVA: 0x0000B82A File Offset: 0x00009A2A
		public AtlasBase atlas
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

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x060011E0 RID: 4576 RVA: 0x0000B837 File Offset: 0x00009A37
		// (set) Token: 0x060011E1 RID: 4577 RVA: 0x0000B844 File Offset: 0x00009A44
		public VectorImageManager vectorImageManager
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

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x060011E2 RID: 4578 RVA: 0x0000B851 File Offset: 0x00009A51
		// (set) Token: 0x060011E3 RID: 4579 RVA: 0x0000B85E File Offset: 0x00009A5E
		public UnityEngine.UIElements.UIR.Implementation.UIRStylePainter painter
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

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x0000B86B File Offset: 0x00009A6B
		// (set) Token: 0x060011E5 RID: 4581 RVA: 0x0000B878 File Offset: 0x00009A78
		public bool drawStats
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

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x0000B885 File Offset: 0x00009A85
		// (set) Token: 0x060011E7 RID: 4583 RVA: 0x0000B892 File Offset: 0x00009A92
		public bool drawInCameras
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

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x0000B89F File Offset: 0x00009A9F
		// (set) Token: 0x060011E9 RID: 4585 RVA: 0x0000B8AC File Offset: 0x00009AAC
		public Shader defaultShader
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

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x0000B8B9 File Offset: 0x00009AB9
		// (set) Token: 0x060011EB RID: 4587 RVA: 0x0000B8C6 File Offset: 0x00009AC6
		public Shader defaultWorldSpaceShader
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

		// Token: 0x060011EC RID: 4588 RVA: 0x0000B8D3 File Offset: 0x00009AD3
		public Material GetStandardMaterial()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x0000B8E0 File Offset: 0x00009AE0
		public Material GetStandardWorldSpaceMaterial()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x0000B8ED File Offset: 0x00009AED
		public void EnsureFitsDepth(int depth)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x0000B8FA File Offset: 0x00009AFA
		public void ChildWillBeRemoved(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x0000B907 File Offset: 0x00009B07
		public RenderChainCommand AllocCommand()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x0000B914 File Offset: 0x00009B14
		public void FreeCommand(RenderChainCommand cmd)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x0000B921 File Offset: 0x00009B21
		public void OnRenderCommandAdded(RenderChainCommand command)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x0000B92E File Offset: 0x00009B2E
		public void OnRenderCommandsRemoved(RenderChainCommand firstCommand, RenderChainCommand lastCommand)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x0000B93B File Offset: 0x00009B3B
		public void AddTextElement(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x0000B948 File Offset: 0x00009B48
		public void RemoveTextElement(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x0000B955 File Offset: 0x00009B55
		public void OnGroupTransformElementChangedTransform(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x0000B962 File Offset: 0x00009B62
		public static void OnRenderNodeExecute(IntPtr obj)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x0000B96F File Offset: 0x00009B6F
		public static void OnRegisterIntermediateRenderers(Camera camera)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x0000B97C File Offset: 0x00009B7C
		public void RepaintTexturedElements()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x0000B989 File Offset: 0x00009B89
		public void OnFontReset(Font font)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x0000B996 File Offset: 0x00009B96
		public void AppendTexture(VisualElement ve, Texture src, TextureId id, bool isAtlas)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x0000B9A3 File Offset: 0x00009BA3
		public void ResetTextures(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x0000B9B0 File Offset: 0x00009BB0
		public void DrawStats()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x0000B9BD File Offset: 0x00009BBD
		public static VisualElement GetFirstElementInPanel(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x02000292 RID: 658
		public struct RenderChainStaticIndexAllocator
		{
		}

		// Token: 0x02000293 RID: 659
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
