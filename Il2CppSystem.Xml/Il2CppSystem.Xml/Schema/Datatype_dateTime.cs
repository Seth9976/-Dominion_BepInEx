using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200009E RID: 158
	public class Datatype_dateTime : Datatype_dateTimeBase
	{
		// Token: 0x06000B2A RID: 2858 RVA: 0x00005D3B File Offset: 0x00003F3B
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_dateTime()
		{
			Il2CppClassPointerStore<Datatype_dateTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_dateTime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_dateTime>.NativeClassPtr);
			Datatype_dateTime.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_dateTime>.NativeClassPtr, 100664944);
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00036E38 File Offset: 0x00035038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22835, XrefRangeEnd = 22839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_dateTime()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_dateTime>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_dateTime.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00005D74 File Offset: 0x00003F74
		public Datatype_dateTime(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
