using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000B0 RID: 176
	public class Datatype_language : Datatype_token
	{
		// Token: 0x06000B9D RID: 2973 RVA: 0x00038AD4 File Offset: 0x00036CD4
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_language()
		{
			Il2CppClassPointerStore<Datatype_language>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_language");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_language>.NativeClassPtr);
			Datatype_language.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_language>.NativeClassPtr, 100665011);
			Datatype_language.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_language>.NativeClassPtr, 100665012);
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x00038B2C File Offset: 0x00036D2C
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_language.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x00038B74 File Offset: 0x00036D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_language()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_language>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_language.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00005F18 File Offset: 0x00004118
		public Datatype_language(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
