using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000120 RID: 288
	public static class UQueryExtensions
	{
		// Token: 0x06000DF6 RID: 3574 RVA: 0x00008DA5 File Offset: 0x00006FA5
		public static T Q<T>(VisualElement e, [Optional] string name, Il2CppStringArray classes) where T : VisualElement
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00008DB2 File Offset: 0x00006FB2
		public static T Q<T>(VisualElement e, [Optional] string name, params string[] classes) where T : VisualElement
		{
			return UQueryExtensions.Q(e, name, new Il2CppStringArray(classes));
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00008DC1 File Offset: 0x00006FC1
		public static VisualElement Q(VisualElement e, [Optional] string name, Il2CppStringArray classes)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00008DCE File Offset: 0x00006FCE
		public static VisualElement Q(VisualElement e, [Optional] string name, params string[] classes)
		{
			return UQueryExtensions.Q(e, name, new Il2CppStringArray(classes));
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00008DDD File Offset: 0x00006FDD
		public static T Q<T>(VisualElement e, [Optional] string name, [Optional] string className) where T : VisualElement
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00035508 File Offset: 0x00033708
		public static T MandatoryQ<T>(VisualElement e, string name, [Optional] string className) where T : VisualElement
		{
			T t = UQueryExtensions.Q<T>(e, name, className);
			bool flag = t == null;
			if (flag)
			{
				throw new UQueryExtensions.MissingVisualElementException(String.Concat("Element not found: ", name));
			}
			return t;
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00008DEA File Offset: 0x00006FEA
		public static VisualElement Q(VisualElement e, [Optional] string name, [Optional] string className)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00035544 File Offset: 0x00033744
		public static VisualElement MandatoryQ(VisualElement e, string name, [Optional] string className)
		{
			VisualElement visualElement = UQueryExtensions.Q<VisualElement>(e, name, className);
			bool flag = visualElement == null;
			if (flag)
			{
				throw new UQueryExtensions.MissingVisualElementException(String.Concat("Element not found: ", name));
			}
			return visualElement;
		}

		// Token: 0x0200023F RID: 575
		public class MissingVisualElementException : Exception
		{
		}
	}
}
