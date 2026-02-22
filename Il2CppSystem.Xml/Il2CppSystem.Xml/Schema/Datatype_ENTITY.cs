using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000B6 RID: 182
	public class Datatype_ENTITY : Datatype_NCName
	{
		// Token: 0x06000BB9 RID: 3001 RVA: 0x000391C8 File Offset: 0x000373C8
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_ENTITY()
		{
			Il2CppClassPointerStore<Datatype_ENTITY>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_ENTITY");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_ENTITY>.NativeClassPtr);
			Datatype_ENTITY.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_ENTITY>.NativeClassPtr, 100665027);
			Datatype_ENTITY.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_ENTITY>.NativeClassPtr, 100665028);
			Datatype_ENTITY.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_ENTITY>.NativeClassPtr, 100665029);
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x00039234 File Offset: 0x00037434
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_ENTITY.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x0003927C File Offset: 0x0003747C
		public unsafe override XmlTokenizedType TokenizedType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_ENTITY.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x000392C4 File Offset: 0x000374C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_ENTITY()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_ENTITY>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_ENTITY.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00005F4E File Offset: 0x0000414E
		public Datatype_ENTITY(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0;

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
