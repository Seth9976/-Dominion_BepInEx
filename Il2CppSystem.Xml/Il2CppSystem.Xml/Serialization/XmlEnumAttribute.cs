using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x02000071 RID: 113
	public class XmlEnumAttribute : Attribute
	{
		// Token: 0x06000890 RID: 2192 RVA: 0x0002E0E8 File Offset: 0x0002C2E8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlEnumAttribute()
		{
			Il2CppClassPointerStore<XmlEnumAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlEnumAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlEnumAttribute>.NativeClassPtr);
			XmlEnumAttribute.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEnumAttribute>.NativeClassPtr, "name");
			XmlEnumAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEnumAttribute>.NativeClassPtr, 100664696);
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0002E140 File Offset: 0x0002C340
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlEnumAttribute(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlEnumAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEnumAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00004B6B File Offset: 0x00002D6B
		public XmlEnumAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x0002E18C File Offset: 0x0002C38C
		// (set) Token: 0x06000894 RID: 2196 RVA: 0x00004B74 File Offset: 0x00002D74
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEnumAttribute.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEnumAttribute.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
