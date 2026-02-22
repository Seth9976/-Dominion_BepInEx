using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000028 RID: 40
	public class XmlCDataSection : XmlCharacterData
	{
		// Token: 0x06000363 RID: 867 RVA: 0x00016D98 File Offset: 0x00014F98
		// Note: this type is marked as 'beforefieldinit'.
		static XmlCDataSection()
		{
			Il2CppClassPointerStore<XmlCDataSection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlCDataSection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlCDataSection>.NativeClassPtr);
			XmlCDataSection.NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCDataSection>.NativeClassPtr, 100663875);
			XmlCDataSection.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCDataSection>.NativeClassPtr, 100663876);
			XmlCDataSection.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCDataSection>.NativeClassPtr, 100663877);
			XmlCDataSection.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCDataSection>.NativeClassPtr, 100663878);
			XmlCDataSection.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCDataSection>.NativeClassPtr, 100663879);
			XmlCDataSection.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCDataSection>.NativeClassPtr, 100663880);
			XmlCDataSection.NativeMethodInfoPtr_get_IsText_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCDataSection>.NativeClassPtr, 100663881);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00016E54 File Offset: 0x00015054
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 14889, RefRangeEnd = 14893, XrefRangeStart = 14888, XrefRangeEnd = 14889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlCDataSection(string data, XmlDocument doc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlCDataSection>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(doc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCDataSection.NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000365 RID: 869 RVA: 0x00016EB4 File Offset: 0x000150B4
		public unsafe override string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlCDataSection.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00016EF8 File Offset: 0x000150F8
		public unsafe override string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlCDataSection.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00016F3C File Offset: 0x0001513C
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlCDataSection.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000368 RID: 872 RVA: 0x00016F84 File Offset: 0x00015184
		public unsafe override XmlNode ParentNode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlCDataSection.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00016FD0 File Offset: 0x000151D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14893, XrefRangeEnd = 14894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlNode CloneNode(bool deep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlCDataSection.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600036A RID: 874 RVA: 0x00017028 File Offset: 0x00015228
		public unsafe override bool IsText
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlCDataSection.NativeMethodInfoPtr_get_IsText_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00003255 File Offset: 0x00001455
		public XmlCDataSection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_XmlDocument_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_XmlNode_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_get_IsText_Internal_Virtual_get_Boolean_0;
	}
}
