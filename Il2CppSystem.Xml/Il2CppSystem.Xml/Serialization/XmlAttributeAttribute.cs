using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x0200006F RID: 111
	public class XmlAttributeAttribute : Attribute
	{
		// Token: 0x06000882 RID: 2178 RVA: 0x0002DEBC File Offset: 0x0002C0BC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAttributeAttribute()
		{
			Il2CppClassPointerStore<XmlAttributeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlAttributeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAttributeAttribute>.NativeClassPtr);
			XmlAttributeAttribute.NativeFieldInfoPtr_attributeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributeAttribute>.NativeClassPtr, "attributeName");
			XmlAttributeAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeAttribute>.NativeClassPtr, 100664694);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x0002DF14 File Offset: 0x0002C114
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttributeAttribute(string attributeName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAttributeAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(attributeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00004AE1 File Offset: 0x00002CE1
		public XmlAttributeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x0002DF60 File Offset: 0x0002C160
		// (set) Token: 0x06000886 RID: 2182 RVA: 0x00004AEA File Offset: 0x00002CEA
		public unsafe string attributeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeAttribute.NativeFieldInfoPtr_attributeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeAttribute.NativeFieldInfoPtr_attributeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeFieldInfoPtr_attributeName;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
