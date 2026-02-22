using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x02000018 RID: 24
	[StructLayout(2)]
	public struct TMP_SpriteInfo
	{
		// Token: 0x06000259 RID: 601 RVA: 0x00012130 File Offset: 0x00010330
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_SpriteInfo()
		{
			Il2CppClassPointerStore<TMP_SpriteInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_SpriteInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_SpriteInfo>.NativeClassPtr);
			TMP_SpriteInfo.NativeFieldInfoPtr_spriteIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteInfo>.NativeClassPtr, "spriteIndex");
			TMP_SpriteInfo.NativeFieldInfoPtr_characterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteInfo>.NativeClassPtr, "characterIndex");
			TMP_SpriteInfo.NativeFieldInfoPtr_vertexIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteInfo>.NativeClassPtr, "vertexIndex");
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002EC6 File Offset: 0x000010C6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_SpriteInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeFieldInfoPtr_spriteIndex;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeFieldInfoPtr_characterIndex;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeFieldInfoPtr_vertexIndex;

		// Token: 0x040001C6 RID: 454
		[FieldOffset(0)]
		public int spriteIndex;

		// Token: 0x040001C7 RID: 455
		[FieldOffset(4)]
		public int characterIndex;

		// Token: 0x040001C8 RID: 456
		[FieldOffset(8)]
		public int vertexIndex;
	}
}
