using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200009D RID: 157
	public class Datatype_dateTimeTimeZone : Datatype_dateTimeBase
	{
		// Token: 0x06000B27 RID: 2855 RVA: 0x00005CF9 File Offset: 0x00003EF9
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_dateTimeTimeZone()
		{
			Il2CppClassPointerStore<Datatype_dateTimeTimeZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_dateTimeTimeZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_dateTimeTimeZone>.NativeClassPtr);
			Datatype_dateTimeTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_dateTimeTimeZone>.NativeClassPtr, 100664943);
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00036DFC File Offset: 0x00034FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22831, XrefRangeEnd = 22835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_dateTimeTimeZone()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_dateTimeTimeZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_dateTimeTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00005D32 File Offset: 0x00003F32
		public Datatype_dateTimeTimeZone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
