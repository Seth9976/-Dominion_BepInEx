using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000E8 RID: 232
	public class XmlSchemaChoice : XmlSchemaGroupBase
	{
		// Token: 0x06000E60 RID: 3680 RVA: 0x00043F58 File Offset: 0x00042158
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaChoice()
		{
			Il2CppClassPointerStore<XmlSchemaChoice>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaChoice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaChoice>.NativeClassPtr);
			XmlSchemaChoice.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaChoice>.NativeClassPtr, "items");
			XmlSchemaChoice.NativeMethodInfoPtr_get_Items_Public_Virtual_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaChoice>.NativeClassPtr, 100665402);
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x00043FB0 File Offset: 0x000421B0
		public unsafe override XmlSchemaObjectCollection Items
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaChoice.NativeMethodInfoPtr_get_Items_Public_Virtual_get_XmlSchemaObjectCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x00006D06 File Offset: 0x00004F06
		public XmlSchemaChoice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x00043FFC File Offset: 0x000421FC
		// (set) Token: 0x06000E64 RID: 3684 RVA: 0x00006D0F File Offset: 0x00004F0F
		public unsafe XmlSchemaObjectCollection items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaChoice.NativeFieldInfoPtr_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaChoice.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Public_Virtual_get_XmlSchemaObjectCollection_0;
	}
}
