using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000C8 RID: 200
	public class Datatype_ENUMERATION : Datatype_NMTOKEN
	{
		// Token: 0x06000C79 RID: 3193 RVA: 0x0003C2D8 File Offset: 0x0003A4D8
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_ENUMERATION()
		{
			Il2CppClassPointerStore<Datatype_ENUMERATION>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_ENUMERATION");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_ENUMERATION>.NativeClassPtr);
			Datatype_ENUMERATION.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_ENUMERATION>.NativeClassPtr, 100665133);
			Datatype_ENUMERATION.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_ENUMERATION>.NativeClassPtr, 100665134);
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x0003C330 File Offset: 0x0003A530
		public unsafe override XmlTokenizedType TokenizedType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_ENUMERATION.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x0003C378 File Offset: 0x0003A578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_ENUMERATION()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_ENUMERATION>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_ENUMERATION.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00006230 File Offset: 0x00004430
		public Datatype_ENUMERATION(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0;

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
