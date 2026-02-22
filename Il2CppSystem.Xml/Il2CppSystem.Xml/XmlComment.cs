using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200002C RID: 44
	public class XmlComment : XmlCharacterData
	{
		// Token: 0x0600038D RID: 909 RVA: 0x0001785C File Offset: 0x00015A5C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlComment()
		{
			Il2CppClassPointerStore<XmlComment>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlComment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlComment>.NativeClassPtr);
			XmlComment.NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlComment>.NativeClassPtr, 100663899);
			XmlComment.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlComment>.NativeClassPtr, 100663900);
			XmlComment.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlComment>.NativeClassPtr, 100663901);
			XmlComment.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlComment>.NativeClassPtr, 100663902);
			XmlComment.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlComment>.NativeClassPtr, 100663903);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x000178F0 File Offset: 0x00015AF0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 14889, RefRangeEnd = 14893, XrefRangeStart = 14889, XrefRangeEnd = 14893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlComment(string comment, XmlDocument doc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlComment>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(comment);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(doc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlComment.NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00017950 File Offset: 0x00015B50
		public unsafe override string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlComment.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00017994 File Offset: 0x00015B94
		public unsafe override string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlComment.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000391 RID: 913 RVA: 0x000179D8 File Offset: 0x00015BD8
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 14937, RefRangeEnd = 14950, XrefRangeStart = 14937, XrefRangeEnd = 14937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlComment.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00017A20 File Offset: 0x00015C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14950, XrefRangeEnd = 14951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlNode CloneNode(bool deep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlComment.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00003310 File Offset: 0x00001510
		public XmlComment(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_XmlDocument_0;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0;
	}
}
