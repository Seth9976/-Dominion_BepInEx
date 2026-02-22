using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000A0 RID: 160
	public class Datatype_timeTimeZone : Datatype_dateTimeBase
	{
		// Token: 0x06000B30 RID: 2864 RVA: 0x00005DBF File Offset: 0x00003FBF
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_timeTimeZone()
		{
			Il2CppClassPointerStore<Datatype_timeTimeZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_timeTimeZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_timeTimeZone>.NativeClassPtr);
			Datatype_timeTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_timeTimeZone>.NativeClassPtr, 100664946);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00036EB0 File Offset: 0x000350B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22843, XrefRangeEnd = 22847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_timeTimeZone()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_timeTimeZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_timeTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00005DF8 File Offset: 0x00003FF8
		public Datatype_timeTimeZone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
