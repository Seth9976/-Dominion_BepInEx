using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200002B RID: 43
	public class XmlChildNodes : XmlNodeList
	{
		// Token: 0x06000386 RID: 902 RVA: 0x000176CC File Offset: 0x000158CC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlChildNodes()
		{
			Il2CppClassPointerStore<XmlChildNodes>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlChildNodes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlChildNodes>.NativeClassPtr);
			XmlChildNodes.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlChildNodes>.NativeClassPtr, "container");
			XmlChildNodes.NativeMethodInfoPtr__ctor_Public_Void_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlChildNodes>.NativeClassPtr, 100663896);
			XmlChildNodes.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlChildNodes>.NativeClassPtr, 100663897);
			XmlChildNodes.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlChildNodes>.NativeClassPtr, 100663898);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0001774C File Offset: 0x0001594C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14926, XrefRangeEnd = 14927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlChildNodes(XmlNode container)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlChildNodes>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlChildNodes.NativeMethodInfoPtr__ctor_Public_Void_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000388 RID: 904 RVA: 0x00017798 File Offset: 0x00015998
		public unsafe override int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlChildNodes.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x000177E0 File Offset: 0x000159E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14932, XrefRangeEnd = 14937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlChildNodes.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x000032E8 File Offset: 0x000014E8
		public XmlChildNodes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600038B RID: 907 RVA: 0x0001782C File Offset: 0x00015A2C
		// (set) Token: 0x0600038C RID: 908 RVA: 0x000032F1 File Offset: 0x000014F1
		public unsafe XmlNode container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlChildNodes.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlChildNodes.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNode_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0;
	}
}
