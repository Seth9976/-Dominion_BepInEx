using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200014A RID: 330
	public abstract class AbstractProgressBar : BindableElement
	{
		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x00009A90 File Offset: 0x00007C90
		// (set) Token: 0x06000F22 RID: 3874 RVA: 0x00009A9D File Offset: 0x00007C9D
		public string title
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

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x00009AAA File Offset: 0x00007CAA
		// (set) Token: 0x06000F24 RID: 3876 RVA: 0x00009AB7 File Offset: 0x00007CB7
		public float lowValue
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

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x00009AC4 File Offset: 0x00007CC4
		// (set) Token: 0x06000F26 RID: 3878 RVA: 0x00009AD1 File Offset: 0x00007CD1
		public float highValue
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

		// Token: 0x06000F27 RID: 3879 RVA: 0x00009ADE File Offset: 0x00007CDE
		public void OnGeometryChanged(GeometryChangedEvent e)
		{
			this.SetProgress(this.value);
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x00009AEE File Offset: 0x00007CEE
		// (set) Token: 0x06000F29 RID: 3881 RVA: 0x00009AFB File Offset: 0x00007CFB
		public virtual float value
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

		// Token: 0x06000F2A RID: 3882 RVA: 0x00009B08 File Offset: 0x00007D08
		public void SetValueWithoutNotify(float newValue)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x00009B15 File Offset: 0x00007D15
		public void SetProgress(float p)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x00009B22 File Offset: 0x00007D22
		public float CalculateProgressWidth(float width)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040007BE RID: 1982
		public const float k_MinVisibleProgress = 1f;

		// Token: 0x0200025D RID: 605
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
		}
	}
}
