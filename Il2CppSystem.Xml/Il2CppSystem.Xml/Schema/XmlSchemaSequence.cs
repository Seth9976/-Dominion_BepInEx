using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000F7 RID: 247
	public class XmlSchemaSequence : XmlSchemaGroupBase
	{
		// Token: 0x06000EF0 RID: 3824 RVA: 0x00046034 File Offset: 0x00044234
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaSequence()
		{
			Il2CppClassPointerStore<XmlSchemaSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaSequence>.NativeClassPtr);
			XmlSchemaSequence.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSequence>.NativeClassPtr, "items");
			XmlSchemaSequence.NativeMethodInfoPtr_get_Items_Public_Virtual_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSequence>.NativeClassPtr, 100665467);
			XmlSchemaSequence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSequence>.NativeClassPtr, 100665468);
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x000460A0 File Offset: 0x000442A0
		public unsafe override XmlSchemaObjectCollection Items
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaSequence.NativeMethodInfoPtr_get_Items_Public_Virtual_get_XmlSchemaObjectCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x000460EC File Offset: 0x000442EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24832, XrefRangeEnd = 24840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSequence()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSequence>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSequence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x000070DB File Offset: 0x000052DB
		public XmlSchemaSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x00046128 File Offset: 0x00044328
		// (set) Token: 0x06000EF5 RID: 3829 RVA: 0x000070E4 File Offset: 0x000052E4
		public unsafe XmlSchemaObjectCollection items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSequence.NativeFieldInfoPtr_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSequence.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B07 RID: 2823
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Public_Virtual_get_XmlSchemaObjectCollection_0;

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
