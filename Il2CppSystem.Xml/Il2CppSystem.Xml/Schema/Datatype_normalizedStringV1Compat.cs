using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000AD RID: 173
	public class Datatype_normalizedStringV1Compat : Datatype_string
	{
		// Token: 0x06000B90 RID: 2960 RVA: 0x000387E4 File Offset: 0x000369E4
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_normalizedStringV1Compat()
		{
			Il2CppClassPointerStore<Datatype_normalizedStringV1Compat>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_normalizedStringV1Compat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_normalizedStringV1Compat>.NativeClassPtr);
			Datatype_normalizedStringV1Compat.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_normalizedStringV1Compat>.NativeClassPtr, 100665004);
			Datatype_normalizedStringV1Compat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_normalizedStringV1Compat>.NativeClassPtr, 100665005);
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000B91 RID: 2961 RVA: 0x0003883C File Offset: 0x00036A3C
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_normalizedStringV1Compat.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00038884 File Offset: 0x00036A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_normalizedStringV1Compat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_normalizedStringV1Compat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_normalizedStringV1Compat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00005EFD File Offset: 0x000040FD
		public Datatype_normalizedStringV1Compat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
