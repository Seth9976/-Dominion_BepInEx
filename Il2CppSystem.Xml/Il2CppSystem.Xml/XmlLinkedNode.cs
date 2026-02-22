using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000036 RID: 54
	public class XmlLinkedNode : XmlNode
	{
		// Token: 0x060004E9 RID: 1257 RVA: 0x0001D634 File Offset: 0x0001B834
		// Note: this type is marked as 'beforefieldinit'.
		static XmlLinkedNode()
		{
			Il2CppClassPointerStore<XmlLinkedNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlLinkedNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlLinkedNode>.NativeClassPtr);
			XmlLinkedNode.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlLinkedNode>.NativeClassPtr, "next");
			XmlLinkedNode.NativeMethodInfoPtr__ctor_Internal_Void_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLinkedNode>.NativeClassPtr, 100664090);
			XmlLinkedNode.NativeMethodInfoPtr_get_PreviousSibling_Public_Virtual_get_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLinkedNode>.NativeClassPtr, 100664091);
			XmlLinkedNode.NativeMethodInfoPtr_get_NextSibling_Public_Virtual_get_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLinkedNode>.NativeClassPtr, 100664092);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0001D6B4 File Offset: 0x0001B8B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 15566, RefRangeEnd = 15567, XrefRangeStart = 15565, XrefRangeEnd = 15566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlLinkedNode(XmlDocument doc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlLinkedNode>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLinkedNode.NativeMethodInfoPtr__ctor_Internal_Void_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x0001D700 File Offset: 0x0001B900
		public unsafe override XmlNode PreviousSibling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlLinkedNode.NativeMethodInfoPtr_get_PreviousSibling_Public_Virtual_get_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x0001D74C File Offset: 0x0001B94C
		public unsafe override XmlNode NextSibling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlLinkedNode.NativeMethodInfoPtr_get_NextSibling_Public_Virtual_get_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00003B83 File Offset: 0x00001D83
		public XmlLinkedNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x0001D798 File Offset: 0x0001B998
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x00003B8C File Offset: 0x00001D8C
		public unsafe XmlLinkedNode next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlLinkedNode.NativeFieldInfoPtr_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlLinkedNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlLinkedNode.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlDocument_0;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeMethodInfoPtr_get_PreviousSibling_Public_Virtual_get_XmlNode_0;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeMethodInfoPtr_get_NextSibling_Public_Virtual_get_XmlNode_0;
	}
}
