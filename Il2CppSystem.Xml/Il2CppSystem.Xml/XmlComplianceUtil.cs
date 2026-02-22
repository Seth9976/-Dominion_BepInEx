using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200004E RID: 78
	public static class XmlComplianceUtil : Object
	{
		// Token: 0x060006F5 RID: 1781 RVA: 0x00026890 File Offset: 0x00024A90
		// Note: this type is marked as 'beforefieldinit'.
		static XmlComplianceUtil()
		{
			Il2CppClassPointerStore<XmlComplianceUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlComplianceUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlComplianceUtil>.NativeClassPtr);
			XmlComplianceUtil.NativeMethodInfoPtr_NonCDataNormalize_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlComplianceUtil>.NativeClassPtr, 100664436);
			XmlComplianceUtil.NativeMethodInfoPtr_CDataNormalize_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlComplianceUtil>.NativeClassPtr, 100664437);
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x000268E8 File Offset: 0x00024AE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19670, RefRangeEnd = 19673, XrefRangeStart = 19643, XrefRangeEnd = 19670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NonCDataNormalize(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlComplianceUtil.NativeMethodInfoPtr_NonCDataNormalize_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00026924 File Offset: 0x00024B24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19684, RefRangeEnd = 19685, XrefRangeStart = 19673, XrefRangeEnd = 19684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CDataNormalize(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlComplianceUtil.NativeMethodInfoPtr_CDataNormalize_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x000044F6 File Offset: 0x000026F6
		public XmlComplianceUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeMethodInfoPtr_NonCDataNormalize_Public_Static_String_String_0;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr_CDataNormalize_Public_Static_String_String_0;
	}
}
