using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000E6 RID: 230
	public class XmlSchemaAnyAttribute : XmlSchemaAnnotated
	{
		// Token: 0x06000E53 RID: 3667 RVA: 0x00043D70 File Offset: 0x00041F70
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaAnyAttribute()
		{
			Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaAnyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr);
			XmlSchemaAnyAttribute.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr, "ns");
			XmlSchemaAnyAttribute.NativeFieldInfoPtr_processContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr, "processContents");
			XmlSchemaAnyAttribute.NativeFieldInfoPtr_namespaceList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr, "namespaceList");
			XmlSchemaAnyAttribute.NativeMethodInfoPtr_set_ProcessContents_Public_set_Void_XmlSchemaContentProcessing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr, 100665399);
			XmlSchemaAnyAttribute.NativeMethodInfoPtr_BuildNamespaceList_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr, 100665400);
			XmlSchemaAnyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr, 100665401);
		}

		// Token: 0x17000556 RID: 1366
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x00043E18 File Offset: 0x00042018
		public unsafe XmlSchemaContentProcessing ProcessContents
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 6218, RefRangeEnd = 6219, XrefRangeStart = 6218, XrefRangeEnd = 6219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnyAttribute.NativeMethodInfoPtr_set_ProcessContents_Public_set_Void_XmlSchemaContentProcessing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x00043E58 File Offset: 0x00042058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24460, XrefRangeEnd = 24466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildNamespaceList(string targetNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnyAttribute.NativeMethodInfoPtr_BuildNamespaceList_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x00043E9C File Offset: 0x0004209C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaAnyAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaAnyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAnyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x00006C76 File Offset: 0x00004E76
		public XmlSchemaAnyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x00043ED8 File Offset: 0x000420D8
		// (set) Token: 0x06000E59 RID: 3673 RVA: 0x00006C7F File Offset: 0x00004E7F
		public unsafe string ns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAnyAttribute.NativeFieldInfoPtr_ns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAnyAttribute.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x00043F00 File Offset: 0x00042100
		// (set) Token: 0x06000E5B RID: 3675 RVA: 0x00006C9E File Offset: 0x00004E9E
		public unsafe XmlSchemaContentProcessing processContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAnyAttribute.NativeFieldInfoPtr_processContents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAnyAttribute.NativeFieldInfoPtr_processContents)) = value;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x00043F28 File Offset: 0x00042128
		// (set) Token: 0x06000E5D RID: 3677 RVA: 0x00006CB9 File Offset: 0x00004EB9
		public unsafe NamespaceList namespaceList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAnyAttribute.NativeFieldInfoPtr_namespaceList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NamespaceList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAnyAttribute.NativeFieldInfoPtr_namespaceList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A93 RID: 2707
		private static readonly IntPtr NativeFieldInfoPtr_ns;

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeFieldInfoPtr_processContents;

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeFieldInfoPtr_namespaceList;

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeMethodInfoPtr_set_ProcessContents_Public_set_Void_XmlSchemaContentProcessing_0;

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeMethodInfoPtr_BuildNamespaceList_Internal_Void_String_0;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
