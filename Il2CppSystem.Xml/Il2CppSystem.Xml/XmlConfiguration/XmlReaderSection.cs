using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.XmlConfiguration
{
	// Token: 0x02000112 RID: 274
	public sealed class XmlReaderSection : Object
	{
		// Token: 0x0600115C RID: 4444 RVA: 0x00051954 File Offset: 0x0004FB54
		// Note: this type is marked as 'beforefieldinit'.
		static XmlReaderSection()
		{
			Il2CppClassPointerStore<XmlReaderSection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.XmlConfiguration", "XmlReaderSection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlReaderSection>.NativeClassPtr);
			XmlReaderSection.NativeMethodInfoPtr_get_ProhibitDefaultUrlResolver_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSection>.NativeClassPtr, 100665883);
			XmlReaderSection.NativeMethodInfoPtr_get_CollapseWhiteSpaceIntoEmptyString_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSection>.NativeClassPtr, 100665884);
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x0600115D RID: 4445 RVA: 0x000519AC File Offset: 0x0004FBAC
		public unsafe static bool ProhibitDefaultUrlResolver
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSection.NativeMethodInfoPtr_get_ProhibitDefaultUrlResolver_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x000519DC File Offset: 0x0004FBDC
		public unsafe static bool CollapseWhiteSpaceIntoEmptyString
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSection.NativeMethodInfoPtr_get_CollapseWhiteSpaceIntoEmptyString_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x00007957 File Offset: 0x00005B57
		public XmlReaderSection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D54 RID: 3412
		private static readonly IntPtr NativeMethodInfoPtr_get_ProhibitDefaultUrlResolver_Internal_Static_get_Boolean_0;

		// Token: 0x04000D55 RID: 3413
		private static readonly IntPtr NativeMethodInfoPtr_get_CollapseWhiteSpaceIntoEmptyString_Internal_Static_get_Boolean_0;
	}
}
