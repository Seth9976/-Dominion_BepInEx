using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x02000072 RID: 114
	public class XmlIgnoreAttribute : Attribute
	{
		// Token: 0x06000895 RID: 2197 RVA: 0x00004B93 File Offset: 0x00002D93
		// Note: this type is marked as 'beforefieldinit'.
		static XmlIgnoreAttribute()
		{
			Il2CppClassPointerStore<XmlIgnoreAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlIgnoreAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlIgnoreAttribute>.NativeClassPtr);
			XmlIgnoreAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlIgnoreAttribute>.NativeClassPtr, 100664697);
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x0002E1B4 File Offset: 0x0002C3B4
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlIgnoreAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlIgnoreAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlIgnoreAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00004BCC File Offset: 0x00002DCC
		public XmlIgnoreAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
