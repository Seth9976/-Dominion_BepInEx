using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets.Syntax
{
	// Token: 0x020000F0 RID: 240
	public class StyleSyntaxParser : Object
	{
		// Token: 0x06000D2F RID: 3375 RVA: 0x00033F90 File Offset: 0x00032190
		// Note: this type is marked as 'beforefieldinit'.
		static StyleSyntaxParser()
		{
			Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets.Syntax", "StyleSyntaxParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr);
			StyleSyntaxParser.NativeFieldInfoPtr_m_ProcessExpressionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr, "m_ProcessExpressionList");
			StyleSyntaxParser.NativeFieldInfoPtr_m_ExpressionStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr, "m_ExpressionStack");
			StyleSyntaxParser.NativeFieldInfoPtr_m_CombinatorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr, "m_CombinatorStack");
			StyleSyntaxParser.NativeFieldInfoPtr_m_ParsedExpressionCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr, "m_ParsedExpressionCache");
			StyleSyntaxParser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr, 100664286);
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x00034024 File Offset: 0x00032224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97347, XrefRangeEnd = 97372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleSyntaxParser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleSyntaxParser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSyntaxParser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x000085B2 File Offset: 0x000067B2
		public StyleSyntaxParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x00034060 File Offset: 0x00032260
		// (set) Token: 0x06000D33 RID: 3379 RVA: 0x000085BB File Offset: 0x000067BB
		public unsafe List<Expression> m_ProcessExpressionList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxParser.NativeFieldInfoPtr_m_ProcessExpressionList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Expression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxParser.NativeFieldInfoPtr_m_ProcessExpressionList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x00034090 File Offset: 0x00032290
		// (set) Token: 0x06000D35 RID: 3381 RVA: 0x000085DA File Offset: 0x000067DA
		public unsafe Stack<Expression> m_ExpressionStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxParser.NativeFieldInfoPtr_m_ExpressionStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<Expression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxParser.NativeFieldInfoPtr_m_ExpressionStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x000340C0 File Offset: 0x000322C0
		// (set) Token: 0x06000D37 RID: 3383 RVA: 0x000085F9 File Offset: 0x000067F9
		public unsafe Stack<ExpressionCombinator> m_CombinatorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxParser.NativeFieldInfoPtr_m_CombinatorStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<ExpressionCombinator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxParser.NativeFieldInfoPtr_m_CombinatorStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000D38 RID: 3384 RVA: 0x000340F0 File Offset: 0x000322F0
		// (set) Token: 0x06000D39 RID: 3385 RVA: 0x00008618 File Offset: 0x00006818
		public unsafe Dictionary<string, Expression> m_ParsedExpressionCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxParser.NativeFieldInfoPtr_m_ParsedExpressionCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Expression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSyntaxParser.NativeFieldInfoPtr_m_ParsedExpressionCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00008637 File Offset: 0x00006837
		public Expression Parse(string syntax)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x00008644 File Offset: 0x00006844
		public Expression ParseExpression(StyleSyntaxTokenizer tokenizer)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x00034120 File Offset: 0x00032320
		public void ProcessCombinatorStack()
		{
			ExpressionCombinator expressionCombinator = this.m_CombinatorStack.Pop();
			Expression expression = this.m_ExpressionStack.Pop();
			Expression expression2 = this.m_ExpressionStack.Pop();
			this.m_ProcessExpressionList.Clear();
			this.m_ProcessExpressionList.Add(expression2);
			this.m_ProcessExpressionList.Add(expression);
			while (this.m_CombinatorStack.Count > 0 && expressionCombinator == this.m_CombinatorStack.Peek())
			{
				Expression expression3 = this.m_ExpressionStack.Pop();
				this.m_ProcessExpressionList.Insert(0, expression3);
				this.m_CombinatorStack.Pop();
			}
			Expression expression4 = new Expression(ExpressionType.Combinator);
			expression4.combinator = expressionCombinator;
			expression4.subExpressions = this.m_ProcessExpressionList.ToArray();
			this.m_ExpressionStack.Push(expression4);
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x00008651 File Offset: 0x00006851
		public Expression ParseTerm(StyleSyntaxTokenizer tokenizer)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x0000865E File Offset: 0x0000685E
		public ExpressionCombinator ParseCombinatorType(StyleSyntaxTokenizer tokenizer)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x0000866B File Offset: 0x0000686B
		public Expression ParseGroup(StyleSyntaxTokenizer tokenizer)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x00008678 File Offset: 0x00006878
		public Expression ParseDataType(StyleSyntaxTokenizer tokenizer)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x00008685 File Offset: 0x00006885
		public Expression ParseProperty(StyleSyntaxTokenizer tokenizer)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x00008692 File Offset: 0x00006892
		public void ParseMultiplier(StyleSyntaxTokenizer tokenizer, ref ExpressionMultiplier multiplier)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x0000869F File Offset: 0x0000689F
		public void ParseRanges(StyleSyntaxTokenizer tokenizer, out int min, out int max)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x000086AC File Offset: 0x000068AC
		public static void EatSpace(StyleSyntaxTokenizer tokenizer)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeFieldInfoPtr_m_ProcessExpressionList;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeFieldInfoPtr_m_ExpressionStack;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeFieldInfoPtr_m_CombinatorStack;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeFieldInfoPtr_m_ParsedExpressionCache;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
