using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000AF RID: 175
	public class Datatype_tokenV1Compat : Datatype_normalizedStringV1Compat
	{
		// Token: 0x06000B99 RID: 2969 RVA: 0x000389F8 File Offset: 0x00036BF8
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_tokenV1Compat()
		{
			Il2CppClassPointerStore<Datatype_tokenV1Compat>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_tokenV1Compat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_tokenV1Compat>.NativeClassPtr);
			Datatype_tokenV1Compat.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_tokenV1Compat>.NativeClassPtr, 100665009);
			Datatype_tokenV1Compat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_tokenV1Compat>.NativeClassPtr, 100665010);
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x00038A50 File Offset: 0x00036C50
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_tokenV1Compat.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x00038A98 File Offset: 0x00036C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_tokenV1Compat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_tokenV1Compat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_tokenV1Compat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00005F0F File Offset: 0x0000410F
		public Datatype_tokenV1Compat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
