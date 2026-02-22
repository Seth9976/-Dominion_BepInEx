using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000B1 RID: 177
	public class Datatype_NMTOKEN : Datatype_token
	{
		// Token: 0x06000BA1 RID: 2977 RVA: 0x00038BB0 File Offset: 0x00036DB0
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_NMTOKEN()
		{
			Il2CppClassPointerStore<Datatype_NMTOKEN>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_NMTOKEN");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_NMTOKEN>.NativeClassPtr);
			Datatype_NMTOKEN.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_NMTOKEN>.NativeClassPtr, 100665013);
			Datatype_NMTOKEN.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_NMTOKEN>.NativeClassPtr, 100665014);
			Datatype_NMTOKEN.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_NMTOKEN>.NativeClassPtr, 100665015);
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x00038C1C File Offset: 0x00036E1C
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_NMTOKEN.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x00038C64 File Offset: 0x00036E64
		public unsafe override XmlTokenizedType TokenizedType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_NMTOKEN.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00038CAC File Offset: 0x00036EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_NMTOKEN()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_NMTOKEN>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_NMTOKEN.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x00005F21 File Offset: 0x00004121
		public Datatype_NMTOKEN(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
