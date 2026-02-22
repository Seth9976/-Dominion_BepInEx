using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200009F RID: 159
	public class Datatype_timeNoTimeZone : Datatype_dateTimeBase
	{
		// Token: 0x06000B2D RID: 2861 RVA: 0x00005D7D File Offset: 0x00003F7D
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_timeNoTimeZone()
		{
			Il2CppClassPointerStore<Datatype_timeNoTimeZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_timeNoTimeZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_timeNoTimeZone>.NativeClassPtr);
			Datatype_timeNoTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_timeNoTimeZone>.NativeClassPtr, 100664945);
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00036E74 File Offset: 0x00035074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22839, XrefRangeEnd = 22843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_timeNoTimeZone()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_timeNoTimeZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_timeNoTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00005DB6 File Offset: 0x00003FB6
		public Datatype_timeNoTimeZone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
