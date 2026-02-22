using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020001D7 RID: 471
	public class StyleSheetBuilder
	{
		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060012D8 RID: 4824 RVA: 0x0000C3A0 File Offset: 0x0000A5A0
		public StyleProperty currentProperty
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x0000C3AD File Offset: 0x0000A5AD
		public StyleRule BeginRule(int ruleLine)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x0000C3BA File Offset: 0x0000A5BA
		public void AddSimpleSelector(Il2CppReferenceArray<StyleSelectorPart> parts, StyleSelectorRelationship previousRelationsip)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x0000C3C7 File Offset: 0x0000A5C7
		public void EndComplexSelector()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x0000C3D4 File Offset: 0x0000A5D4
		public StyleProperty BeginProperty(string name, [Optional] int line)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x0000C3E1 File Offset: 0x0000A5E1
		public void AddImport(StyleSheet.ImportStruct importStruct)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x0000C3EE File Offset: 0x0000A5EE
		public void AddValue(float value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x0000C3FB File Offset: 0x0000A5FB
		public void AddValue(Dimension value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x0000C408 File Offset: 0x0000A608
		public void AddValue(StyleValueKeyword keyword)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x0000C415 File Offset: 0x0000A615
		public void AddValue(StyleValueFunction function)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x0000C422 File Offset: 0x0000A622
		public void AddValue(string value, StyleValueType type)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x0000C42F File Offset: 0x0000A62F
		public void AddValue(Color value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x0000C43C File Offset: 0x0000A63C
		public void AddValue(Object value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x0000C449 File Offset: 0x0000A649
		public void AddValue(ScalableImage value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x0000C456 File Offset: 0x0000A656
		public void EndProperty()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x0000C463 File Offset: 0x0000A663
		public int EndRule()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x0000C470 File Offset: 0x0000A670
		public void BuildTo(StyleSheet writeTo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x0000C47D File Offset: 0x0000A67D
		public void RegisterVariable(string value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x0000C48A File Offset: 0x0000A68A
		public void RegisterValue<T>(List<T> list, StyleValueType type, T value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x0000C497 File Offset: 0x0000A697
		public static void Log(string msg)
		{
		}

		// Token: 0x0200029A RID: 666
		public enum BuilderState
		{
			// Token: 0x0400092C RID: 2348
			Init,
			// Token: 0x0400092D RID: 2349
			Rule,
			// Token: 0x0400092E RID: 2350
			ComplexSelector,
			// Token: 0x0400092F RID: 2351
			Property
		}
	}
}
