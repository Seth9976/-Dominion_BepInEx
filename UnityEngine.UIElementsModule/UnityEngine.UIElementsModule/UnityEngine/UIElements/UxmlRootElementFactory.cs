using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000198 RID: 408
	public class UxmlRootElementFactory : UxmlFactory<VisualElement, UxmlRootElementTraits>
	{
		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x0600112D RID: 4397 RVA: 0x0000B044 File Offset: 0x00009244
		public override string uxmlName
		{
			get
			{
				return "UXML";
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x0600112E RID: 4398 RVA: 0x0000B04B File Offset: 0x0000924B
		public override string uxmlQualifiedName
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x0600112F RID: 4399 RVA: 0x0000B058 File Offset: 0x00009258
		public override string substituteForTypeName
		{
			get
			{
				return String.Empty;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x0000B05F File Offset: 0x0000925F
		public override string substituteForTypeNamespace
		{
			get
			{
				return String.Empty;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x0000B066 File Offset: 0x00009266
		public override string substituteForTypeQualifiedName
		{
			get
			{
				return String.Empty;
			}
		}

		// Token: 0x040007F3 RID: 2035
		public const string k_ElementName = "UXML";
	}
}
