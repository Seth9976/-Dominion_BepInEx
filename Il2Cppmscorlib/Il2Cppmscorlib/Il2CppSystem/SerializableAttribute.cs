using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000E3 RID: 227
	public sealed class SerializableAttribute : Attribute
	{
		// Token: 0x06000F62 RID: 3938 RVA: 0x00005DFD File Offset: 0x00003FFD
		// Note: this type is marked as 'beforefieldinit'.
		static SerializableAttribute()
		{
			Il2CppClassPointerStore<SerializableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "SerializableAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableAttribute>.NativeClassPtr);
			SerializableAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttribute>.NativeClassPtr, 100665911);
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00068ACC File Offset: 0x00066CCC
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializableAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00005E36 File Offset: 0x00004036
		public SerializableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
