using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000A2 RID: 162
	public class Datatype_date : Datatype_dateTimeBase
	{
		// Token: 0x06000B37 RID: 2871 RVA: 0x00036FC8 File Offset: 0x000351C8
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_date()
		{
			Il2CppClassPointerStore<Datatype_date>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_date");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_date>.NativeClassPtr);
			Datatype_date.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_date>.NativeClassPtr, 100664949);
			Datatype_date.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_date>.NativeClassPtr, 100664950);
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x00037020 File Offset: 0x00035220
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_date.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00037068 File Offset: 0x00035268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22851, XrefRangeEnd = 22855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_date()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_date>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_date.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00005E0A File Offset: 0x0000400A
		public Datatype_date(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
