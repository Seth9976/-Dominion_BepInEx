using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000F1 RID: 241
	public class XmlSchemaGroupBase : XmlSchemaParticle
	{
		// Token: 0x06000EB1 RID: 3761 RVA: 0x00045330 File Offset: 0x00043530
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaGroupBase()
		{
			Il2CppClassPointerStore<XmlSchemaGroupBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaGroupBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaGroupBase>.NativeClassPtr);
			XmlSchemaGroupBase.NativeMethodInfoPtr_get_Items_Public_Abstract_Virtual_New_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaGroupBase>.NativeClassPtr, 100665440);
			XmlSchemaGroupBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaGroupBase>.NativeClassPtr, 100665441);
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x00045388 File Offset: 0x00043588
		public unsafe virtual XmlSchemaObjectCollection Items
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaGroupBase.NativeMethodInfoPtr_get_Items_Public_Abstract_Virtual_New_get_XmlSchemaObjectCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x000453D4 File Offset: 0x000435D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24782, XrefRangeEnd = 24786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaGroupBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaGroupBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaGroupBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x00006F16 File Offset: 0x00005116
		public XmlSchemaGroupBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Public_Abstract_Virtual_New_get_XmlSchemaObjectCollection_0;

		// Token: 0x04000AE2 RID: 2786
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
