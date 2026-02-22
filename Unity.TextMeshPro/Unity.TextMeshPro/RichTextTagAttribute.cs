using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x0200001D RID: 29
	[StructLayout(2)]
	public struct RichTextTagAttribute
	{
		// Token: 0x060002EE RID: 750 RVA: 0x00013444 File Offset: 0x00011644
		// Note: this type is marked as 'beforefieldinit'.
		static RichTextTagAttribute()
		{
			Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "RichTextTagAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr);
			RichTextTagAttribute.NativeFieldInfoPtr_nameHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, "nameHashCode");
			RichTextTagAttribute.NativeFieldInfoPtr_valueHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, "valueHashCode");
			RichTextTagAttribute.NativeFieldInfoPtr_valueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, "valueType");
			RichTextTagAttribute.NativeFieldInfoPtr_valueStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, "valueStartIndex");
			RichTextTagAttribute.NativeFieldInfoPtr_valueLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, "valueLength");
			RichTextTagAttribute.NativeFieldInfoPtr_unitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, "unitType");
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000374D File Offset: 0x0000194D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, ref this));
		}

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeFieldInfoPtr_nameHashCode;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeFieldInfoPtr_valueHashCode;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeFieldInfoPtr_valueType;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeFieldInfoPtr_valueStartIndex;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeFieldInfoPtr_valueLength;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeFieldInfoPtr_unitType;

		// Token: 0x04000224 RID: 548
		[FieldOffset(0)]
		public int nameHashCode;

		// Token: 0x04000225 RID: 549
		[FieldOffset(4)]
		public int valueHashCode;

		// Token: 0x04000226 RID: 550
		[FieldOffset(8)]
		public TagValueType valueType;

		// Token: 0x04000227 RID: 551
		[FieldOffset(12)]
		public int valueStartIndex;

		// Token: 0x04000228 RID: 552
		[FieldOffset(16)]
		public int valueLength;

		// Token: 0x04000229 RID: 553
		[FieldOffset(20)]
		public TagUnitType unitType;
	}
}
