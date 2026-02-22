using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x02000070 RID: 112
	public class XmlElementAttribute : Attribute
	{
		// Token: 0x06000887 RID: 2183 RVA: 0x0002DF88 File Offset: 0x0002C188
		// Note: this type is marked as 'beforefieldinit'.
		static XmlElementAttribute()
		{
			Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlElementAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr);
			XmlElementAttribute.NativeFieldInfoPtr_elementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr, "elementName");
			XmlElementAttribute.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr, "type");
			XmlElementAttribute.NativeFieldInfoPtr_order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr, "order");
			XmlElementAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr, 100664695);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x0002E008 File Offset: 0x0002C208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21343, XrefRangeEnd = 21344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlElementAttribute(string elementName, Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00004B09 File Offset: 0x00002D09
		public XmlElementAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x0002E068 File Offset: 0x0002C268
		// (set) Token: 0x0600088B RID: 2187 RVA: 0x00004B12 File Offset: 0x00002D12
		public unsafe string elementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementAttribute.NativeFieldInfoPtr_elementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementAttribute.NativeFieldInfoPtr_elementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x0002E090 File Offset: 0x0002C290
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x00004B31 File Offset: 0x00002D31
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementAttribute.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementAttribute.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x0002E0C0 File Offset: 0x0002C2C0
		// (set) Token: 0x0600088F RID: 2191 RVA: 0x00004B50 File Offset: 0x00002D50
		public unsafe int order
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementAttribute.NativeFieldInfoPtr_order);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementAttribute.NativeFieldInfoPtr_order)) = value;
			}
		}

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeFieldInfoPtr_elementName;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeFieldInfoPtr_order;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Type_0;
	}
}
