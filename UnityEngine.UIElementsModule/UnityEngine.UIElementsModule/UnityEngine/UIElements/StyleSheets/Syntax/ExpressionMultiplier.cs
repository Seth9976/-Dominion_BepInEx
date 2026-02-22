using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.StyleSheets.Syntax
{
	// Token: 0x020000EF RID: 239
	[StructLayout(2)]
	public struct ExpressionMultiplier
	{
		// Token: 0x06000D28 RID: 3368 RVA: 0x00033E5C File Offset: 0x0003205C
		// Note: this type is marked as 'beforefieldinit'.
		static ExpressionMultiplier()
		{
			Il2CppClassPointerStore<ExpressionMultiplier>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets.Syntax", "ExpressionMultiplier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionMultiplier>.NativeClassPtr);
			ExpressionMultiplier.NativeFieldInfoPtr_Infinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionMultiplier>.NativeClassPtr, "Infinity");
			ExpressionMultiplier.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionMultiplier>.NativeClassPtr, "m_Type");
			ExpressionMultiplier.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionMultiplier>.NativeClassPtr, "min");
			ExpressionMultiplier.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionMultiplier>.NativeClassPtr, "max");
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x00008587 File Offset: 0x00006787
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExpressionMultiplier>.NativeClassPtr, ref this));
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000D2A RID: 3370 RVA: 0x00033EDC File Offset: 0x000320DC
		// (set) Token: 0x06000D2B RID: 3371 RVA: 0x00008599 File Offset: 0x00006799
		public unsafe static int Infinity
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ExpressionMultiplier.NativeFieldInfoPtr_Infinity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExpressionMultiplier.NativeFieldInfoPtr_Infinity, (void*)(&value));
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x00033EF8 File Offset: 0x000320F8
		// (set) Token: 0x06000D2D RID: 3373 RVA: 0x000085A7 File Offset: 0x000067A7
		public ExpressionMultiplierType type
		{
			get
			{
				return this.m_Type;
			}
			set
			{
				this.SetType(value);
			}
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x00033F10 File Offset: 0x00032110
		public void SetType(ExpressionMultiplierType value)
		{
			this.m_Type = value;
			switch (value)
			{
			case ExpressionMultiplierType.ZeroOrMore:
				this.min = 0;
				this.max = 10;
				return;
			case ExpressionMultiplierType.OneOrMore:
			case ExpressionMultiplierType.OneOrMoreComma:
			case ExpressionMultiplierType.GroupAtLeastOne:
				this.min = 1;
				this.max = 10;
				return;
			case ExpressionMultiplierType.ZeroOrOne:
				this.min = 0;
				this.max = 1;
				return;
			}
			this.min = (this.max = 1);
		}

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeFieldInfoPtr_Infinity;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04000772 RID: 1906
		[FieldOffset(0)]
		public ExpressionMultiplierType m_Type;

		// Token: 0x04000773 RID: 1907
		[FieldOffset(4)]
		public int min;

		// Token: 0x04000774 RID: 1908
		[FieldOffset(8)]
		public int max;
	}
}
