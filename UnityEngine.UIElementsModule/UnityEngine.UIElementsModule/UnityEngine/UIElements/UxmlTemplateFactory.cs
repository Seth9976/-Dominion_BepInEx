using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200019C RID: 412
	public class UxmlTemplateFactory : UxmlFactory<VisualElement, UxmlTemplateTraits>
	{
		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x0000B0D7 File Offset: 0x000092D7
		public override string uxmlName
		{
			get
			{
				return "Template";
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x0600113A RID: 4410 RVA: 0x0000B0DE File Offset: 0x000092DE
		public override string uxmlQualifiedName
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x0600113B RID: 4411 RVA: 0x0000B0EB File Offset: 0x000092EB
		public override string substituteForTypeName
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).Name;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x0000B0FC File Offset: 0x000092FC
		public override string substituteForTypeNamespace
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).Namespace ?? String.Empty;
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x0600113D RID: 4413 RVA: 0x0000B116 File Offset: 0x00009316
		public override string substituteForTypeQualifiedName
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).FullName;
			}
		}

		// Token: 0x040007F5 RID: 2037
		public const string k_ElementName = "Template";
	}
}
