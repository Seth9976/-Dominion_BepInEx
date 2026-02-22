using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x0200001C RID: 28
	[StructLayout(2)]
	public struct TagAttribute
	{
		// Token: 0x060002EC RID: 748 RVA: 0x000133D8 File Offset: 0x000115D8
		// Note: this type is marked as 'beforefieldinit'.
		static TagAttribute()
		{
			Il2CppClassPointerStore<TagAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TagAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TagAttribute>.NativeClassPtr);
			TagAttribute.NativeFieldInfoPtr_startIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TagAttribute>.NativeClassPtr, "startIndex");
			TagAttribute.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TagAttribute>.NativeClassPtr, "length");
			TagAttribute.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TagAttribute>.NativeClassPtr, "hashCode");
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000373B File Offset: 0x0000193B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TagAttribute>.NativeClassPtr, ref this));
		}

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeFieldInfoPtr_startIndex;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeFieldInfoPtr_hashCode;

		// Token: 0x0400021B RID: 539
		[FieldOffset(0)]
		public int startIndex;

		// Token: 0x0400021C RID: 540
		[FieldOffset(4)]
		public int length;

		// Token: 0x0400021D RID: 541
		[FieldOffset(8)]
		public int hashCode;
	}
}
