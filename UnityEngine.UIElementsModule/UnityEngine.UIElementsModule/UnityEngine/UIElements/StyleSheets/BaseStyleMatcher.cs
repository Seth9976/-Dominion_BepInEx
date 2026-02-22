using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UIElements.StyleSheets.Syntax;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020000E8 RID: 232
	public class BaseStyleMatcher : Object
	{
		// Token: 0x06000CEF RID: 3311 RVA: 0x00033824 File Offset: 0x00031A24
		// Note: this type is marked as 'beforefieldinit'.
		static BaseStyleMatcher()
		{
			Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "BaseStyleMatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr);
			BaseStyleMatcher.NativeFieldInfoPtr_m_MarkStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, "m_MarkStack");
			BaseStyleMatcher.NativeFieldInfoPtr_m_CurrentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, "m_CurrentIndex");
			BaseStyleMatcher.NativeFieldInfoPtr__matchedVariableCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, "<matchedVariableCount>k__BackingField");
			BaseStyleMatcher.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr, 100664284);
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x000338A4 File Offset: 0x00031AA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 97343, RefRangeEnd = 97346, XrefRangeStart = 97336, XrefRangeEnd = 97343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseStyleMatcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseStyleMatcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStyleMatcher.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x0000831E File Offset: 0x0000651E
		public BaseStyleMatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x000338E0 File Offset: 0x00031AE0
		// (set) Token: 0x06000CF3 RID: 3315 RVA: 0x00008327 File Offset: 0x00006527
		public unsafe Stack<int> m_MarkStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStyleMatcher.NativeFieldInfoPtr_m_MarkStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStyleMatcher.NativeFieldInfoPtr_m_MarkStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x00033910 File Offset: 0x00031B10
		// (set) Token: 0x06000CF5 RID: 3317 RVA: 0x00008346 File Offset: 0x00006546
		public unsafe int m_CurrentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStyleMatcher.NativeFieldInfoPtr_m_CurrentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStyleMatcher.NativeFieldInfoPtr_m_CurrentIndex)) = value;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x00033938 File Offset: 0x00031B38
		// (set) Token: 0x06000CF7 RID: 3319 RVA: 0x00008361 File Offset: 0x00006561
		public unsafe int _matchedVariableCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStyleMatcher.NativeFieldInfoPtr__matchedVariableCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStyleMatcher.NativeFieldInfoPtr__matchedVariableCount_k__BackingField)) = value;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x0000837C File Offset: 0x0000657C
		public bool hasCurrent
		{
			get
			{
				return this.m_CurrentIndex < this.valueCount;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x0000838C File Offset: 0x0000658C
		// (set) Token: 0x06000CFA RID: 3322 RVA: 0x00008394 File Offset: 0x00006594
		public int matchedVariableCount
		{
			get
			{
				return this._matchedVariableCount_k__BackingField;
			}
			set
			{
				this._matchedVariableCount_k__BackingField = value;
			}
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x0000839D File Offset: 0x0000659D
		public void Initialize()
		{
			this.m_CurrentIndex = 0;
			this.m_MarkStack.Clear();
			this.matchedVariableCount = 0;
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00033960 File Offset: 0x00031B60
		public void MoveNext()
		{
			bool flag = this.m_CurrentIndex + 1 <= this.valueCount;
			if (flag)
			{
				this.m_CurrentIndex++;
			}
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x000083BB File Offset: 0x000065BB
		public void SaveMark()
		{
			this.m_MarkStack.Push(this.m_CurrentIndex);
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x000083D0 File Offset: 0x000065D0
		public void RestoreMark()
		{
			this.m_CurrentIndex = this.m_MarkStack.Pop();
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x000083E4 File Offset: 0x000065E4
		public void DropMark()
		{
			this.m_MarkStack.Pop();
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x000083F3 File Offset: 0x000065F3
		public bool Match(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00033998 File Offset: 0x00031B98
		public bool MatchExpression(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			bool flag = false;
			bool flag2 = exp.type == UnityEngine.UIElements.StyleSheets.Syntax.ExpressionType.Combinator;
			if (flag2)
			{
				flag = this.MatchCombinator(exp);
			}
			else
			{
				bool isVariable = this.isVariable;
				if (isVariable)
				{
					flag = true;
					int matchedVariableCount = this.matchedVariableCount;
					this.matchedVariableCount = matchedVariableCount + 1;
				}
				else
				{
					bool flag3 = exp.type == UnityEngine.UIElements.StyleSheets.Syntax.ExpressionType.Data;
					if (flag3)
					{
						flag = this.MatchDataType(exp);
					}
					else
					{
						bool flag4 = exp.type == UnityEngine.UIElements.StyleSheets.Syntax.ExpressionType.Keyword;
						if (flag4)
						{
							flag = this.MatchKeyword(exp.keyword);
						}
					}
				}
				bool flag5 = flag;
				if (flag5)
				{
					this.MoveNext();
				}
			}
			bool flag6 = !flag && !this.hasCurrent && this.matchedVariableCount > 0;
			if (flag6)
			{
				flag = true;
			}
			return flag;
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x00008400 File Offset: 0x00006600
		public bool MatchGroup(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00033A54 File Offset: 0x00031C54
		public bool MatchCombinator(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			this.SaveMark();
			bool flag = false;
			switch (exp.combinator)
			{
			case UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator.Or:
				flag = this.MatchOr(exp);
				break;
			case UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator.OrOr:
				flag = this.MatchOrOr(exp);
				break;
			case UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator.AndAnd:
				flag = this.MatchAndAnd(exp);
				break;
			case UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator.Juxtaposition:
				flag = this.MatchJuxtaposition(exp);
				break;
			case UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator.Group:
				flag = this.MatchGroup(exp);
				break;
			}
			bool flag2 = flag;
			if (flag2)
			{
				this.DropMark();
			}
			else
			{
				this.RestoreMark();
			}
			return flag;
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x0000840D File Offset: 0x0000660D
		public bool MatchOr(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x00033AE4 File Offset: 0x00031CE4
		public bool MatchOrOr(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			int num = this.MatchMany(exp);
			return num > 0;
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00033B04 File Offset: 0x00031D04
		public bool MatchAndAnd(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			int num = this.MatchMany(exp);
			int num2 = exp.subExpressions.Length;
			return num == num2;
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x0000841A File Offset: 0x0000661A
		public int MatchMany(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00008427 File Offset: 0x00006627
		public bool MatchJuxtaposition(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00033B30 File Offset: 0x00031D30
		public bool MatchDataType(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
		{
			bool flag = false;
			bool hasCurrent = this.hasCurrent;
			if (hasCurrent)
			{
				switch (exp.dataType)
				{
				case UnityEngine.UIElements.StyleSheets.Syntax.DataType.Number:
					flag = this.MatchNumber();
					break;
				case UnityEngine.UIElements.StyleSheets.Syntax.DataType.Integer:
					flag = this.MatchInteger();
					break;
				case UnityEngine.UIElements.StyleSheets.Syntax.DataType.Length:
					flag = this.MatchLength();
					break;
				case UnityEngine.UIElements.StyleSheets.Syntax.DataType.Percentage:
					flag = this.MatchPercentage();
					break;
				case UnityEngine.UIElements.StyleSheets.Syntax.DataType.Color:
					flag = this.MatchColor();
					break;
				case UnityEngine.UIElements.StyleSheets.Syntax.DataType.Resource:
					flag = this.MatchResource();
					break;
				case UnityEngine.UIElements.StyleSheets.Syntax.DataType.Url:
					flag = this.MatchUrl();
					break;
				}
			}
			return flag;
		}

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeFieldInfoPtr_m_MarkStack;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentIndex;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeFieldInfoPtr__matchedVariableCount_k__BackingField;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
