using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000B2 RID: 178
	public class Datatype_Name : Datatype_token
	{
		// Token: 0x06000BA6 RID: 2982 RVA: 0x00038CE8 File Offset: 0x00036EE8
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_Name()
		{
			Il2CppClassPointerStore<Datatype_Name>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_Name");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_Name>.NativeClassPtr);
			Datatype_Name.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_Name>.NativeClassPtr, 100665016);
			Datatype_Name.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_Name>.NativeClassPtr, 100665017);
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x00038D40 File Offset: 0x00036F40
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_Name.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00038D88 File Offset: 0x00036F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_Name()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_Name>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_Name.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00005F2A File Offset: 0x0000412A
		public Datatype_Name(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
