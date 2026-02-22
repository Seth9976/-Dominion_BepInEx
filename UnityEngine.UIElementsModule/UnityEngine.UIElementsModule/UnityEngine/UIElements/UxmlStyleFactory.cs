using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200019A RID: 410
	public class UxmlStyleFactory : UxmlFactory<VisualElement, UxmlStyleTraits>
	{
		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001133 RID: 4403 RVA: 0x0000B07A File Offset: 0x0000927A
		public override string uxmlName
		{
			get
			{
				return "Style";
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001134 RID: 4404 RVA: 0x0000B081 File Offset: 0x00009281
		public override string uxmlQualifiedName
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001135 RID: 4405 RVA: 0x0000B08E File Offset: 0x0000928E
		public override string substituteForTypeName
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).Name;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x0000B09F File Offset: 0x0000929F
		public override string substituteForTypeNamespace
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).Namespace ?? String.Empty;
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x0000B0B9 File Offset: 0x000092B9
		public override string substituteForTypeQualifiedName
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).FullName;
			}
		}

		// Token: 0x040007F4 RID: 2036
		public const string k_ElementName = "Style";
	}
}
