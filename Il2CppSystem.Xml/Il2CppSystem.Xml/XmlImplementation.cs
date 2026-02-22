using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000035 RID: 53
	public class XmlImplementation : Object
	{
		// Token: 0x060004E3 RID: 1251 RVA: 0x0001D50C File Offset: 0x0001B70C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlImplementation()
		{
			Il2CppClassPointerStore<XmlImplementation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlImplementation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlImplementation>.NativeClassPtr);
			XmlImplementation.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlImplementation>.NativeClassPtr, "nameTable");
			XmlImplementation.NativeMethodInfoPtr_CreateDocument_Public_Virtual_New_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlImplementation>.NativeClassPtr, 100664088);
			XmlImplementation.NativeMethodInfoPtr_get_NameTable_Internal_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlImplementation>.NativeClassPtr, 100664089);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0001D578 File Offset: 0x0001B778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15561, XrefRangeEnd = 15565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlDocument CreateDocument()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlImplementation.NativeMethodInfoPtr_CreateDocument_Public_Virtual_New_XmlDocument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr3) : null;
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x0001D5C4 File Offset: 0x0001B7C4
		public unsafe XmlNameTable NameTable
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlImplementation.NativeMethodInfoPtr_get_NameTable_Internal_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00003B5B File Offset: 0x00001D5B
		public XmlImplementation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x0001D604 File Offset: 0x0001B804
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x00003B64 File Offset: 0x00001D64
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlImplementation.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlImplementation.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeMethodInfoPtr_CreateDocument_Public_Virtual_New_XmlDocument_0;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Internal_get_XmlNameTable_0;
	}
}
