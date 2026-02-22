using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200019E RID: 414
	public class UxmlAttributeOverridesFactory : UxmlFactory<VisualElement, UxmlAttributeOverridesTraits>
	{
		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x0600113F RID: 4415 RVA: 0x0000B134 File Offset: 0x00009334
		public override string uxmlName
		{
			get
			{
				return "AttributeOverrides";
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x0000B13B File Offset: 0x0000933B
		public override string uxmlQualifiedName
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x0000B148 File Offset: 0x00009348
		public override string substituteForTypeName
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).Name;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001142 RID: 4418 RVA: 0x0000B159 File Offset: 0x00009359
		public override string substituteForTypeNamespace
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).Namespace ?? String.Empty;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001143 RID: 4419 RVA: 0x0000B173 File Offset: 0x00009373
		public override string substituteForTypeQualifiedName
		{
			get
			{
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).FullName;
			}
		}

		// Token: 0x040007F6 RID: 2038
		public const string k_ElementName = "AttributeOverrides";
	}
}
