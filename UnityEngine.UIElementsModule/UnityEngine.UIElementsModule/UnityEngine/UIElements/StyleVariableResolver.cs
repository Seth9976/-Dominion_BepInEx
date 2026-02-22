using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.UIElements.StyleSheets.Syntax;

namespace UnityEngine.UIElements
{
	// Token: 0x020000C8 RID: 200
	public class StyleVariableResolver : Object
	{
		// Token: 0x06000B66 RID: 2918 RVA: 0x0002F8E0 File Offset: 0x0002DAE0
		// Note: this type is marked as 'beforefieldinit'.
		static StyleVariableResolver()
		{
			Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleVariableResolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr);
			StyleVariableResolver.NativeFieldInfoPtr_kMaxResolves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, "kMaxResolves");
			StyleVariableResolver.NativeFieldInfoPtr_s_SyntaxParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, "s_SyntaxParser");
			StyleVariableResolver.NativeFieldInfoPtr_m_Matcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, "m_Matcher");
			StyleVariableResolver.NativeFieldInfoPtr_m_ResolvedValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, "m_ResolvedValues");
			StyleVariableResolver.NativeFieldInfoPtr_m_ResolvedVarStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, "m_ResolvedVarStack");
			StyleVariableResolver.NativeFieldInfoPtr_m_ValidationExpression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, "m_ValidationExpression");
			StyleVariableResolver.NativeFieldInfoPtr_m_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, "m_Property");
			StyleVariableResolver.NativeFieldInfoPtr_m_Sheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, "m_Sheet");
			StyleVariableResolver.NativeFieldInfoPtr_m_Handles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, "m_Handles");
			StyleVariableResolver.NativeFieldInfoPtr__variableContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, "<variableContext>k__BackingField");
			StyleVariableResolver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr, 100664265);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x0002F9EC File Offset: 0x0002DBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97216, XrefRangeEnd = 97233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleVariableResolver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleVariableResolver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleVariableResolver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00007235 File Offset: 0x00005435
		public StyleVariableResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x0002FA28 File Offset: 0x0002DC28
		// (set) Token: 0x06000B6A RID: 2922 RVA: 0x0000723E File Offset: 0x0000543E
		public unsafe static int kMaxResolves
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StyleVariableResolver.NativeFieldInfoPtr_kMaxResolves, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StyleVariableResolver.NativeFieldInfoPtr_kMaxResolves, (void*)(&value));
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x0002FA44 File Offset: 0x0002DC44
		// (set) Token: 0x06000B6C RID: 2924 RVA: 0x0000724C File Offset: 0x0000544C
		public unsafe static UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser s_SyntaxParser
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StyleVariableResolver.NativeFieldInfoPtr_s_SyntaxParser, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StyleVariableResolver.NativeFieldInfoPtr_s_SyntaxParser, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x0002FA6C File Offset: 0x0002DC6C
		// (set) Token: 0x06000B6E RID: 2926 RVA: 0x0000725E File Offset: 0x0000545E
		public unsafe UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcher m_Matcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_Matcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_Matcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x0002FA9C File Offset: 0x0002DC9C
		// (set) Token: 0x06000B70 RID: 2928 RVA: 0x0000727D File Offset: 0x0000547D
		public unsafe List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_ResolvedValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_ResolvedValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnityEngine.UIElements.StyleSheets.StylePropertyValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_ResolvedValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x0002FACC File Offset: 0x0002DCCC
		// (set) Token: 0x06000B72 RID: 2930 RVA: 0x0000729C File Offset: 0x0000549C
		public unsafe Stack<string> m_ResolvedVarStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_ResolvedVarStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_ResolvedVarStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x0002FAFC File Offset: 0x0002DCFC
		// (set) Token: 0x06000B74 RID: 2932 RVA: 0x000072BB File Offset: 0x000054BB
		public unsafe UnityEngine.UIElements.StyleSheets.Syntax.Expression m_ValidationExpression
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_ValidationExpression);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.UIElements.StyleSheets.Syntax.Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_ValidationExpression), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x0002FB2C File Offset: 0x0002DD2C
		// (set) Token: 0x06000B76 RID: 2934 RVA: 0x000072DA File Offset: 0x000054DA
		public unsafe StyleProperty m_Property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_Property);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleProperty>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x0002FB5C File Offset: 0x0002DD5C
		// (set) Token: 0x06000B78 RID: 2936 RVA: 0x000072F9 File Offset: 0x000054F9
		public unsafe StyleSheet m_Sheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_Sheet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleSheet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_Sheet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x0002FB8C File Offset: 0x0002DD8C
		// (set) Token: 0x06000B7A RID: 2938 RVA: 0x00007318 File Offset: 0x00005518
		public unsafe Il2CppStructArray<StyleValueHandle> m_Handles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_Handles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<StyleValueHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr_m_Handles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x0002FBBC File Offset: 0x0002DDBC
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x00007337 File Offset: 0x00005537
		public unsafe StyleVariableContext _variableContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr__variableContext_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleVariableContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleVariableResolver.NativeFieldInfoPtr__variableContext_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x00007356 File Offset: 0x00005556
		public List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> resolvedValues
		{
			get
			{
				return this.m_ResolvedValues;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000B7E RID: 2942 RVA: 0x0000735E File Offset: 0x0000555E
		// (set) Token: 0x06000B7F RID: 2943 RVA: 0x00007366 File Offset: 0x00005566
		public StyleVariableContext variableContext
		{
			get
			{
				return this._variableContext_k__BackingField;
			}
			set
			{
				this._variableContext_k__BackingField = value;
			}
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0000736F File Offset: 0x0000556F
		public void Init(StyleProperty property, StyleSheet sheet, Il2CppStructArray<StyleValueHandle> handles)
		{
			this.m_ResolvedValues.Clear();
			this.m_Sheet = sheet;
			this.m_Property = property;
			this.m_Handles = handles;
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0002FBEC File Offset: 0x0002DDEC
		public void AddValue(StyleValueHandle handle)
		{
			List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> resolvedValues = this.m_ResolvedValues;
			UnityEngine.UIElements.StyleSheets.StylePropertyValue stylePropertyValue = null;
			stylePropertyValue.sheet = this.m_Sheet;
			stylePropertyValue.handle = handle;
			resolvedValues.Add(stylePropertyValue);
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0002FC24 File Offset: 0x0002DE24
		public StyleVariableResolver.Result ResolveVarFunction(ref int index)
		{
			this.m_ResolvedVarStack.Clear();
			this.m_ValidationExpression = null;
			bool flag = !this.m_Property.isCustomProperty;
			if (flag)
			{
				string text;
				bool flag2 = !UnityEngine.UIElements.StyleSheets.StylePropertyCache.TryGetSyntax(this.m_Property.name, out text);
				if (flag2)
				{
					Debug.LogAssertion(String.Concat("Unknown style property ", this.m_Property.name));
					return StyleVariableResolver.Result.Invalid;
				}
				this.m_ValidationExpression = StyleVariableResolver.s_SyntaxParser.Parse(text);
			}
			int num;
			string text2;
			StyleVariableResolver.ParseVarFunction(this.m_Sheet, this.m_Handles, ref index, out num, out text2);
			StyleVariableResolver.Result result = this.ResolveVariable(text2);
			bool flag3 = result > StyleVariableResolver.Result.Valid;
			if (flag3)
			{
				bool flag4 = result == StyleVariableResolver.Result.NotFound && num > 1 && !this.m_Property.isCustomProperty;
				if (flag4)
				{
					Il2CppArrayBase<StyleValueHandle> handles = this.m_Handles;
					int num2 = index + 1;
					index = num2;
					StyleValueHandle styleValueHandle = handles[num2];
					Debug.Assert(styleValueHandle.valueType == StyleValueType.FunctionSeparator, String.Format("Unexpected value type {0} in var function", styleValueHandle.valueType));
					bool flag5 = styleValueHandle.valueType == StyleValueType.FunctionSeparator && index + 1 < this.m_Handles.Length;
					if (flag5)
					{
						index++;
						result = this.ResolveFallback(ref index);
					}
				}
				else
				{
					this.m_ResolvedValues.Clear();
				}
			}
			return result;
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x0002FD88 File Offset: 0x0002DF88
		public StyleVariableResolver.Result ResolveVariable(string variableName)
		{
			StyleVariable styleVariable;
			bool flag = !this.variableContext.TryFindVariable(variableName, out styleVariable);
			StyleVariableResolver.Result result;
			if (flag)
			{
				result = StyleVariableResolver.Result.NotFound;
			}
			else
			{
				bool flag2 = this.m_ResolvedVarStack.Contains(styleVariable.name);
				if (flag2)
				{
					result = StyleVariableResolver.Result.NotFound;
				}
				else
				{
					this.m_ResolvedVarStack.Push(styleVariable.name);
					StyleVariableResolver.Result result2 = StyleVariableResolver.Result.Valid;
					int num = 0;
					while (num < styleVariable.handles.Length && result2 == StyleVariableResolver.Result.Valid)
					{
						StyleValueHandle styleValueHandle = styleVariable.handles[num];
						bool flag3 = styleValueHandle.IsVarFunction();
						if (flag3)
						{
							int num2;
							string text;
							StyleVariableResolver.ParseVarFunction(styleVariable.sheet, styleVariable.handles, ref num, out num2, out text);
							result2 = this.ResolveVariable(text);
						}
						else
						{
							UnityEngine.UIElements.StyleSheets.StylePropertyValue stylePropertyValue = null;
							stylePropertyValue.sheet = styleVariable.sheet;
							stylePropertyValue.handle = styleValueHandle;
							UnityEngine.UIElements.StyleSheets.StylePropertyValue stylePropertyValue2 = stylePropertyValue;
							result2 = this.ValidateResolve(stylePropertyValue2);
						}
						num++;
					}
					this.m_ResolvedVarStack.Pop();
					result = result2;
				}
			}
			return result;
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00007393 File Offset: 0x00005593
		public StyleVariableResolver.Result ValidateResolve(UnityEngine.UIElements.StyleSheets.StylePropertyValue spv)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x0002FE94 File Offset: 0x0002E094
		public StyleVariableResolver.Result ResolveFallback(ref int index)
		{
			StyleVariableResolver.Result result = StyleVariableResolver.Result.Valid;
			while (index < this.m_Handles.Length && result == StyleVariableResolver.Result.Valid)
			{
				StyleValueHandle styleValueHandle = this.m_Handles[index];
				bool flag = styleValueHandle.IsVarFunction();
				if (flag)
				{
					int num;
					string text;
					StyleVariableResolver.ParseVarFunction(this.m_Sheet, this.m_Handles, ref index, out num, out text);
					result = this.ResolveVariable(text);
					bool flag2 = result == StyleVariableResolver.Result.NotFound;
					if (flag2)
					{
						bool flag3 = num > 1;
						if (flag3)
						{
							Il2CppArrayBase<StyleValueHandle> handles = this.m_Handles;
							int num2 = index + 1;
							index = num2;
							styleValueHandle = handles[num2];
							Debug.Assert(styleValueHandle.valueType == StyleValueType.FunctionSeparator, String.Format("Unexpected value type {0} in var function", styleValueHandle.valueType));
							bool flag4 = styleValueHandle.valueType == StyleValueType.FunctionSeparator && index + 1 < this.m_Handles.Length;
							if (flag4)
							{
								index++;
								result = this.ResolveFallback(ref index);
							}
						}
					}
				}
				else
				{
					UnityEngine.UIElements.StyleSheets.StylePropertyValue stylePropertyValue = null;
					stylePropertyValue.sheet = this.m_Sheet;
					stylePropertyValue.handle = styleValueHandle;
					UnityEngine.UIElements.StyleSheets.StylePropertyValue stylePropertyValue2 = stylePropertyValue;
					result = this.ValidateResolve(stylePropertyValue2);
				}
				index++;
			}
			return result;
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0002FFD4 File Offset: 0x0002E1D4
		public static void ParseVarFunction(StyleSheet sheet, Il2CppStructArray<StyleValueHandle> handles, ref int index, out int argCount, out string variableName)
		{
			int num = index + 1;
			index = num;
			argCount = (int)sheet.ReadFloat(handles[num]);
			num = index + 1;
			index = num;
			variableName = sheet.ReadVariable(handles[num]);
		}

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeFieldInfoPtr_kMaxResolves;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeFieldInfoPtr_s_SyntaxParser;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeFieldInfoPtr_m_Matcher;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeFieldInfoPtr_m_ResolvedValues;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeFieldInfoPtr_m_ResolvedVarStack;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeFieldInfoPtr_m_ValidationExpression;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeFieldInfoPtr_m_Property;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeFieldInfoPtr_m_Sheet;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeFieldInfoPtr_m_Handles;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeFieldInfoPtr__variableContext_k__BackingField;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000229 RID: 553
		public enum Result
		{
			// Token: 0x040008EE RID: 2286
			Valid,
			// Token: 0x040008EF RID: 2287
			Invalid,
			// Token: 0x040008F0 RID: 2288
			NotFound
		}
	}
}
