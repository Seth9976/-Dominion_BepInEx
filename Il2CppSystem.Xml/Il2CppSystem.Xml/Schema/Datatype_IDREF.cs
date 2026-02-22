using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000B5 RID: 181
	public class Datatype_IDREF : Datatype_NCName
	{
		// Token: 0x06000BB4 RID: 2996 RVA: 0x00039090 File Offset: 0x00037290
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_IDREF()
		{
			Il2CppClassPointerStore<Datatype_IDREF>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_IDREF");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_IDREF>.NativeClassPtr);
			Datatype_IDREF.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_IDREF>.NativeClassPtr, 100665024);
			Datatype_IDREF.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_IDREF>.NativeClassPtr, 100665025);
			Datatype_IDREF.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_IDREF>.NativeClassPtr, 100665026);
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x000390FC File Offset: 0x000372FC
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_IDREF.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x00039144 File Offset: 0x00037344
		public unsafe override XmlTokenizedType TokenizedType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_IDREF.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x0003918C File Offset: 0x0003738C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_IDREF()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_IDREF>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_IDREF.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00005F45 File Offset: 0x00004145
		public Datatype_IDREF(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0;

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
