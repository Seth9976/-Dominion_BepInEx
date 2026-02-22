using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020001B2 RID: 434
	public static class VisualElementFactoryRegistry
	{
		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001192 RID: 4498 RVA: 0x0000B4FA File Offset: 0x000096FA
		public static Dictionary<string, List<IUxmlFactory>> factories
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x00038938 File Offset: 0x00036B38
		public static void RegisterFactory(IUxmlFactory factory)
		{
			List<IUxmlFactory> list;
			bool flag = VisualElementFactoryRegistry.factories.TryGetValue(factory.uxmlQualifiedName, out list);
			if (flag)
			{
				List<IUxmlFactory>.Enumerator enumerator = list.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						IUxmlFactory uxmlFactory = enumerator.Current;
						bool flag2 = uxmlFactory.GetType() == factory.GetType();
						if (flag2)
						{
							throw new ArgumentException(String.Concat("A factory for the type ", factory.GetType().FullName, " was already registered"));
						}
					}
				}
				finally
				{
					enumerator.Dispose();
				}
				list.Add(factory);
			}
			else
			{
				list = new List<IUxmlFactory>();
				list.Add(factory);
				VisualElementFactoryRegistry.factories.Add(factory.uxmlQualifiedName, list);
			}
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x00038A00 File Offset: 0x00036C00
		public static bool TryGetValue(string fullTypeName, out List<IUxmlFactory> factoryList)
		{
			factoryList = null;
			return VisualElementFactoryRegistry.factories.TryGetValue(fullTypeName, out factoryList);
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x0000B507 File Offset: 0x00009707
		public static void RegisterEngineFactories()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x0000B514 File Offset: 0x00009714
		public static void RegisterUserFactories()
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
