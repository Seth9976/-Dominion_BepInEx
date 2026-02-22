using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.StyleSheets.Syntax
{
	// Token: 0x020000EA RID: 234
	public class Expression : Object
	{
		// Token: 0x06000D1A RID: 3354 RVA: 0x00033CBC File Offset: 0x00031EBC
		// Note: this type is marked as 'beforefieldinit'.
		static Expression()
		{
			Il2CppClassPointerStore<Expression>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets.Syntax", "Expression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Expression>.NativeClassPtr);
			Expression.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expression>.NativeClassPtr, "type");
			Expression.NativeFieldInfoPtr_multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expression>.NativeClassPtr, "multiplier");
			Expression.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expression>.NativeClassPtr, "dataType");
			Expression.NativeFieldInfoPtr_combinator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expression>.NativeClassPtr, "combinator");
			Expression.NativeFieldInfoPtr_subExpressions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expression>.NativeClassPtr, "subExpressions");
			Expression.NativeFieldInfoPtr_keyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expression>.NativeClassPtr, "keyword");
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x000084D4 File Offset: 0x000066D4
		public Expression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000D1C RID: 3356 RVA: 0x00033D64 File Offset: 0x00031F64
		// (set) Token: 0x06000D1D RID: 3357 RVA: 0x000084DD File Offset: 0x000066DD
		public unsafe ExpressionType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x00033D8C File Offset: 0x00031F8C
		// (set) Token: 0x06000D1F RID: 3359 RVA: 0x000084F8 File Offset: 0x000066F8
		public unsafe ExpressionMultiplier multiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.NativeFieldInfoPtr_multiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.NativeFieldInfoPtr_multiplier)) = value;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x00033DB4 File Offset: 0x00031FB4
		// (set) Token: 0x06000D21 RID: 3361 RVA: 0x00008513 File Offset: 0x00006713
		public unsafe DataType dataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.NativeFieldInfoPtr_dataType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.NativeFieldInfoPtr_dataType)) = value;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000D22 RID: 3362 RVA: 0x00033DDC File Offset: 0x00031FDC
		// (set) Token: 0x06000D23 RID: 3363 RVA: 0x0000852E File Offset: 0x0000672E
		public unsafe ExpressionCombinator combinator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.NativeFieldInfoPtr_combinator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.NativeFieldInfoPtr_combinator)) = value;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x00033E04 File Offset: 0x00032004
		// (set) Token: 0x06000D25 RID: 3365 RVA: 0x00008549 File Offset: 0x00006749
		public unsafe Il2CppReferenceArray<Expression> subExpressions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.NativeFieldInfoPtr_subExpressions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Expression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.NativeFieldInfoPtr_subExpressions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x00033E34 File Offset: 0x00032034
		// (set) Token: 0x06000D27 RID: 3367 RVA: 0x00008568 File Offset: 0x00006768
		public unsafe string keyword
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.NativeFieldInfoPtr_keyword);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.NativeFieldInfoPtr_keyword), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeFieldInfoPtr_multiplier;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeFieldInfoPtr_dataType;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeFieldInfoPtr_combinator;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeFieldInfoPtr_subExpressions;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeFieldInfoPtr_keyword;
	}
}
