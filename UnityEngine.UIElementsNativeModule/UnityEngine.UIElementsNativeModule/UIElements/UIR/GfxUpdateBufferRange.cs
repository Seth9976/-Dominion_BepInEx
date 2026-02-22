using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200000C RID: 12
	[StructLayout(2)]
	public struct GfxUpdateBufferRange
	{
		// Token: 0x06000107 RID: 263 RVA: 0x00004A24 File Offset: 0x00002C24
		// Note: this type is marked as 'beforefieldinit'.
		static GfxUpdateBufferRange()
		{
			Il2CppClassPointerStore<GfxUpdateBufferRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsNativeModule.dll", "UnityEngine.UIElements.UIR", "GfxUpdateBufferRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GfxUpdateBufferRange>.NativeClassPtr);
			GfxUpdateBufferRange.NativeFieldInfoPtr_offsetFromWriteStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GfxUpdateBufferRange>.NativeClassPtr, "offsetFromWriteStart");
			GfxUpdateBufferRange.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GfxUpdateBufferRange>.NativeClassPtr, "size");
			GfxUpdateBufferRange.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GfxUpdateBufferRange>.NativeClassPtr, "source");
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002983 File Offset: 0x00000B83
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GfxUpdateBufferRange>.NativeClassPtr, ref this));
		}

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeFieldInfoPtr_offsetFromWriteStart;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04000094 RID: 148
		[FieldOffset(0)]
		public uint offsetFromWriteStart;

		// Token: 0x04000095 RID: 149
		[FieldOffset(4)]
		public uint size;

		// Token: 0x04000096 RID: 150
		[FieldOffset(8)]
		public UIntPtr source;
	}
}
