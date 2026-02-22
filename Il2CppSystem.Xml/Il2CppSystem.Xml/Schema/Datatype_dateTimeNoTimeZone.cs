using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200009C RID: 156
	public class Datatype_dateTimeNoTimeZone : Datatype_dateTimeBase
	{
		// Token: 0x06000B24 RID: 2852 RVA: 0x00005CB7 File Offset: 0x00003EB7
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_dateTimeNoTimeZone()
		{
			Il2CppClassPointerStore<Datatype_dateTimeNoTimeZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_dateTimeNoTimeZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_dateTimeNoTimeZone>.NativeClassPtr);
			Datatype_dateTimeNoTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_dateTimeNoTimeZone>.NativeClassPtr, 100664942);
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00036DC0 File Offset: 0x00034FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22827, XrefRangeEnd = 22831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_dateTimeNoTimeZone()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_dateTimeNoTimeZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_dateTimeNoTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00005CF0 File Offset: 0x00003EF0
		public Datatype_dateTimeNoTimeZone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
