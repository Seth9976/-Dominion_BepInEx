using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000F9 RID: 249
	public class XmlSchemaSimpleType : XmlSchemaType
	{
		// Token: 0x06000F11 RID: 3857 RVA: 0x00046584 File Offset: 0x00044784
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaSimpleType()
		{
			Il2CppClassPointerStore<XmlSchemaSimpleType>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaSimpleType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaSimpleType>.NativeClassPtr);
			XmlSchemaSimpleType.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleType>.NativeClassPtr, "content");
			XmlSchemaSimpleType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleType>.NativeClassPtr, 100665472);
			XmlSchemaSimpleType.NativeMethodInfoPtr_get_Content_Public_get_XmlSchemaSimpleTypeContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleType>.NativeClassPtr, 100665473);
			XmlSchemaSimpleType.NativeMethodInfoPtr_set_Content_Public_set_Void_XmlSchemaSimpleTypeContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleType>.NativeClassPtr, 100665474);
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x00046604 File Offset: 0x00044804
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24894, RefRangeEnd = 24895, XrefRangeStart = 24893, XrefRangeEnd = 24894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSimpleType()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSimpleType>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06000F13 RID: 3859 RVA: 0x00046640 File Offset: 0x00044840
		// (set) Token: 0x06000F14 RID: 3860 RVA: 0x00046680 File Offset: 0x00044880
		public unsafe XmlSchemaSimpleTypeContent Content
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleType.NativeMethodInfoPtr_get_Content_Public_get_XmlSchemaSimpleTypeContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleTypeContent>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleType.NativeMethodInfoPtr_set_Content_Public_set_Void_XmlSchemaSimpleTypeContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x0000725D File Offset: 0x0000545D
		public XmlSchemaSimpleType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06000F16 RID: 3862 RVA: 0x000466C4 File Offset: 0x000448C4
		// (set) Token: 0x06000F17 RID: 3863 RVA: 0x00007266 File Offset: 0x00005466
		public unsafe XmlSchemaSimpleTypeContent content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleType.NativeFieldInfoPtr_content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleTypeContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleType.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B18 RID: 2840
		private static readonly IntPtr NativeFieldInfoPtr_content;

		// Token: 0x04000B19 RID: 2841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeMethodInfoPtr_get_Content_Public_get_XmlSchemaSimpleTypeContent_0;

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeMethodInfoPtr_set_Content_Public_set_Void_XmlSchemaSimpleTypeContent_0;
	}
}
