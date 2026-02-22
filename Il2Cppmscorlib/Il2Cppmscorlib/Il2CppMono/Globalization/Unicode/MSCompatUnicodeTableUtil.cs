using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Globalization.Unicode
{
	// Token: 0x0200001A RID: 26
	public class MSCompatUnicodeTableUtil : Object
	{
		// Token: 0x0600010F RID: 271 RVA: 0x00026358 File Offset: 0x00024558
		// Note: this type is marked as 'beforefieldinit'.
		static MSCompatUnicodeTableUtil()
		{
			Il2CppClassPointerStore<MSCompatUnicodeTableUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "MSCompatUnicodeTableUtil");
			MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Ignorable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTableUtil>.NativeClassPtr, "Ignorable");
			MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTableUtil>.NativeClassPtr, "Category");
			MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Level1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTableUtil>.NativeClassPtr, "Level1");
			MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Level2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTableUtil>.NativeClassPtr, "Level2");
			MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Level3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTableUtil>.NativeClassPtr, "Level3");
			MSCompatUnicodeTableUtil.NativeFieldInfoPtr_CjkCHS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTableUtil>.NativeClassPtr, "CjkCHS");
			MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Cjk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTableUtil>.NativeClassPtr, "Cjk");
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000268A File Offset: 0x0000088A
		public MSCompatUnicodeTableUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0002640C File Offset: 0x0002460C
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00002693 File Offset: 0x00000893
		public unsafe static CodePointIndexer Ignorable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Ignorable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Ignorable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00026434 File Offset: 0x00024634
		// (set) Token: 0x06000114 RID: 276 RVA: 0x000026A5 File Offset: 0x000008A5
		public unsafe static CodePointIndexer Category
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Category, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Category, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0002645C File Offset: 0x0002465C
		// (set) Token: 0x06000116 RID: 278 RVA: 0x000026B7 File Offset: 0x000008B7
		public unsafe static CodePointIndexer Level1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Level1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Level1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00026484 File Offset: 0x00024684
		// (set) Token: 0x06000118 RID: 280 RVA: 0x000026C9 File Offset: 0x000008C9
		public unsafe static CodePointIndexer Level2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Level2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Level2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000119 RID: 281 RVA: 0x000264AC File Offset: 0x000246AC
		// (set) Token: 0x0600011A RID: 282 RVA: 0x000026DB File Offset: 0x000008DB
		public unsafe static CodePointIndexer Level3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Level3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Level3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600011B RID: 283 RVA: 0x000264D4 File Offset: 0x000246D4
		// (set) Token: 0x0600011C RID: 284 RVA: 0x000026ED File Offset: 0x000008ED
		public unsafe static CodePointIndexer CjkCHS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_CjkCHS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_CjkCHS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600011D RID: 285 RVA: 0x000264FC File Offset: 0x000246FC
		// (set) Token: 0x0600011E RID: 286 RVA: 0x000026FF File Offset: 0x000008FF
		public unsafe static CodePointIndexer Cjk
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Cjk, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTableUtil.NativeFieldInfoPtr_Cjk, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeFieldInfoPtr_Ignorable;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeFieldInfoPtr_Category;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr_Level1;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_Level2;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr_Level3;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeFieldInfoPtr_CjkCHS;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeFieldInfoPtr_Cjk;
	}
}
