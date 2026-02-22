using System;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	// Token: 0x02000187 RID: 391
	public class UIRRepaintUpdater : BaseVisualTreeUpdater
	{
		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x060010D3 RID: 4307 RVA: 0x0000AE14 File Offset: 0x00009014
		public override ProfilerMarker profilerMarker
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x060010D4 RID: 4308 RVA: 0x0000AE21 File Offset: 0x00009021
		// (set) Token: 0x060010D5 RID: 4309 RVA: 0x0000AE2E File Offset: 0x0000902E
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

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x060010D6 RID: 4310 RVA: 0x0000AE3B File Offset: 0x0000903B
		// (set) Token: 0x060010D7 RID: 4311 RVA: 0x0000AE48 File Offset: 0x00009048
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

		// Token: 0x060010D8 RID: 4312 RVA: 0x0000AE55 File Offset: 0x00009055
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x0000AE62 File Offset: 0x00009062
		public override void Update()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x00037A60 File Offset: 0x00035C60
		public virtual UnityEngine.UIElements.UIR.RenderChain CreateRenderChain()
		{
			return new UnityEngine.UIElements.UIR.RenderChain(base.panel);
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x00037A80 File Offset: 0x00035C80
		public static void OnGraphicsResourcesRecreate(bool recreate)
		{
			bool flag = !recreate;
			if (flag)
			{
				UnityEngine.UIElements.UIR.UIRenderDevice.PrepareForGfxDeviceRecreate();
			}
			Dictionary<int, Panel>.Enumerator panelsIterator = UIElementsUtility.GetPanelsIterator();
			while (panelsIterator.MoveNext())
			{
				if (recreate)
				{
					KeyValuePair<int, Panel> keyValuePair = panelsIterator.Current;
					AtlasBase atlas = keyValuePair.Value.atlas;
					if (atlas != null)
					{
						atlas.Reset();
					}
				}
				else
				{
					KeyValuePair<int, Panel> keyValuePair = panelsIterator.Current;
					UIRRepaintUpdater uirrepaintUpdater = keyValuePair.Value.GetUpdater(VisualTreeUpdatePhase.Repaint).TryCast<UIRRepaintUpdater>();
					if (uirrepaintUpdater != null)
					{
						uirrepaintUpdater.DestroyRenderChain();
					}
				}
			}
			bool flag2 = !recreate;
			if (flag2)
			{
				UnityEngine.UIElements.UIR.UIRenderDevice.FlushAllPendingDeviceDisposes();
			}
			else
			{
				UnityEngine.UIElements.UIR.UIRenderDevice.WrapUpGfxDeviceRecreate();
			}
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x0000AE6F File Offset: 0x0000906F
		public void OnPanelChanged(BaseVisualElementPanel obj)
		{
			this.DetachFromPanel();
			this.AttachToPanel();
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0000AE80 File Offset: 0x00009080
		public void AttachToPanel()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x0000AE8D File Offset: 0x0000908D
		public void DetachFromPanel()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x0000AE9A File Offset: 0x0000909A
		public void InitRenderChain()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x0000AEA7 File Offset: 0x000090A7
		public void DestroyRenderChain()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x0000AEB4 File Offset: 0x000090B4
		public void OnPanelAtlasChanged()
		{
			this.DestroyRenderChain();
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x0000AEBE File Offset: 0x000090BE
		public void OnPanelHierarchyChanged(VisualElement ve, HierarchyChangeType changeType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x0000AECB File Offset: 0x000090CB
		public void OnPanelStandardShaderChanged()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x0000AED8 File Offset: 0x000090D8
		public void OnPanelStandardWorldSpaceShaderChanged()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x0000AEE5 File Offset: 0x000090E5
		public void ResetAllElementsDataRecursive(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x0000AEF2 File Offset: 0x000090F2
		// (set) Token: 0x060010E7 RID: 4327 RVA: 0x0000AEFF File Offset: 0x000090FF
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

		// Token: 0x060010E8 RID: 4328 RVA: 0x00037B18 File Offset: 0x00035D18
		public override void Dispose(bool disposing)
		{
			bool disposed = this.disposed;
			if (!disposed)
			{
				if (disposing)
				{
					this.DetachFromPanel();
				}
				this.disposed = true;
			}
		}
	}
}
