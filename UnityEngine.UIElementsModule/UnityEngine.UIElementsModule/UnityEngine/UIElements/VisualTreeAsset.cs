using System;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020001B3 RID: 435
	[Serializable]
	public class VisualTreeAsset : ScriptableObject
	{
		// Token: 0x06001197 RID: 4503 RVA: 0x0000B521 File Offset: 0x00009721
		public int GetNextChildSerialNumber()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x0000B52E File Offset: 0x0000972E
		public IEnumerable<VisualTreeAsset> templateDependencies
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x0000B53B File Offset: 0x0000973B
		public IEnumerable<StyleSheet> stylesheets
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x0000B548 File Offset: 0x00009748
		// (set) Token: 0x0600119B RID: 4507 RVA: 0x0000B555 File Offset: 0x00009755
		public List<VisualElementAsset> visualElementAssets
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

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x0000B562 File Offset: 0x00009762
		// (set) Token: 0x0600119D RID: 4509 RVA: 0x0000B56F File Offset: 0x0000976F
		public List<TemplateAsset> templateAssets
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

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x0000B57C File Offset: 0x0000977C
		// (set) Token: 0x0600119F RID: 4511 RVA: 0x0000B589 File Offset: 0x00009789
		public int contentContainerId
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

		// Token: 0x060011A0 RID: 4512 RVA: 0x0000B596 File Offset: 0x00009796
		public TemplateContainer Instantiate()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x00038A24 File Offset: 0x00036C24
		public TemplateContainer Instantiate(string bindingPath)
		{
			TemplateContainer templateContainer = this.Instantiate();
			templateContainer.bindingPath = bindingPath;
			return templateContainer;
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x00038A48 File Offset: 0x00036C48
		public TemplateContainer CloneTree()
		{
			return this.Instantiate();
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x00038A60 File Offset: 0x00036C60
		public TemplateContainer CloneTree(string bindingPath)
		{
			return this.Instantiate(bindingPath);
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x00038A7C File Offset: 0x00036C7C
		public void CloneTree(VisualElement target)
		{
			int num;
			int num2;
			this.CloneTree(target, out num, out num2);
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x0000B5A3 File Offset: 0x000097A3
		public void CloneTree(VisualElement target, out int firstElementIndex, out int elementAddedCount)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x00038A98 File Offset: 0x00036C98
		public static int CompareForOrder(VisualElementAsset a, VisualElementAsset b)
		{
			return a.orderInDocument.CompareTo(b.orderInDocument);
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x0000B5B0 File Offset: 0x000097B0
		public bool TryGetSlotInsertionPoint(int insertionPointId, out string slotName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x0000B5BD File Offset: 0x000097BD
		public VisualTreeAsset ResolveTemplate(string templateName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x0000B5CA File Offset: 0x000097CA
		public static void AssignClassListFromAssetToElement(VisualElementAsset asset, VisualElement element)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x0000B5D7 File Offset: 0x000097D7
		public static void AssignStyleSheetFromAssetToElement(VisualElementAsset asset, VisualElement element)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x0000B5E4 File Offset: 0x000097E4
		// (set) Token: 0x060011AC RID: 4524 RVA: 0x0000B5F1 File Offset: 0x000097F1
		public int contentHash
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

		// Token: 0x0200028C RID: 652
		public class UsingEntryComparer
		{
		}

		// Token: 0x0200028D RID: 653
		public sealed class <get_templateDependencies>d__8
		{
		}

		// Token: 0x0200028E RID: 654
		public sealed class <get_stylesheets>d__12
		{
		}

		// Token: 0x0200028F RID: 655
		public sealed class <>c__DisplayClass36_0
		{
		}
	}
}
