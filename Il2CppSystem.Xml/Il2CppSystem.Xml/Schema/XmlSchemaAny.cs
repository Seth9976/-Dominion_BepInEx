using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000E5 RID: 229
	public class XmlSchemaAny : XmlSchemaParticle
	{
		// Token: 0x06000E47 RID: 3655 RVA: 0x00043B34 File Offset: 0x00041D34
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaAny()
		{
			Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaAny");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr);
			XmlSchemaAny.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr, "ns");
			XmlSchemaAny.NativeFieldInfoPtr_processContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr, "processContents");
			XmlSchemaAny.NativeFieldInfoPtr_namespaceList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr, "namespaceList");
			XmlSchemaAny.NativeMethodInfoPtr_set_ProcessContents_Public_set_Void_XmlSchemaContentProcessing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr, 100665395);
			XmlSchemaAny.NativeMethodInfoPtr_get_NamespaceList_Internal_get_NamespaceList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr, 100665396);
			XmlSchemaAny.NativeMethodInfoPtr_BuildNamespaceList_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr, 100665397);
			XmlSchemaAny.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr, 100665398);
		}

		// Token: 0x17000551 RID: 1361
		// (set) Token: 0x06000E48 RID: 3656 RVA: 0x00043BF0 File Offset: 0x00041DF0
		public unsafe XmlSchemaContentProcessing ProcessContents
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAny.NativeMethodInfoPtr_set_ProcessContents_Public_set_Void_XmlSchemaContentProcessing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x00043C30 File Offset: 0x00041E30
		public unsafe NamespaceList NamespaceList
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAny.NativeMethodInfoPtr_get_NamespaceList_Internal_get_NamespaceList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NamespaceList>(intPtr3) : null;
			}
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x00043C70 File Offset: 0x00041E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24450, XrefRangeEnd = 24456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildNamespaceList(string targetNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAny.NativeMethodInfoPtr_BuildNamespaceList_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x00043CB4 File Offset: 0x00041EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24456, XrefRangeEnd = 24460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaAny()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaAny>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAny.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00006C14 File Offset: 0x00004E14
		public XmlSchemaAny(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x00043CF0 File Offset: 0x00041EF0
		// (set) Token: 0x06000E4E RID: 3662 RVA: 0x00006C1D File Offset: 0x00004E1D
		public unsafe string ns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAny.NativeFieldInfoPtr_ns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAny.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x00043D18 File Offset: 0x00041F18
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x00006C3C File Offset: 0x00004E3C
		public unsafe XmlSchemaContentProcessing processContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAny.NativeFieldInfoPtr_processContents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAny.NativeFieldInfoPtr_processContents)) = value;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x00043D40 File Offset: 0x00041F40
		// (set) Token: 0x06000E52 RID: 3666 RVA: 0x00006C57 File Offset: 0x00004E57
		public unsafe NamespaceList namespaceList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAny.NativeFieldInfoPtr_namespaceList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NamespaceList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAny.NativeFieldInfoPtr_namespaceList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A8C RID: 2700
		private static readonly IntPtr NativeFieldInfoPtr_ns;

		// Token: 0x04000A8D RID: 2701
		private static readonly IntPtr NativeFieldInfoPtr_processContents;

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeFieldInfoPtr_namespaceList;

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeMethodInfoPtr_set_ProcessContents_Public_set_Void_XmlSchemaContentProcessing_0;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceList_Internal_get_NamespaceList_0;

		// Token: 0x04000A91 RID: 2705
		private static readonly IntPtr NativeMethodInfoPtr_BuildNamespaceList_Internal_Void_String_0;

		// Token: 0x04000A92 RID: 2706
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
