using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x02000007 RID: 7
	public sealed class XPathNodePageInfo : Object
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00009D78 File Offset: 0x00007F78
		// Note: this type is marked as 'beforefieldinit'.
		static XPathNodePageInfo()
		{
			Il2CppClassPointerStore<XPathNodePageInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.Cache", "XPathNodePageInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathNodePageInfo>.NativeClassPtr);
			XPathNodePageInfo.NativeFieldInfoPtr_pageNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodePageInfo>.NativeClassPtr, "pageNum");
			XPathNodePageInfo.NativeFieldInfoPtr_nodeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodePageInfo>.NativeClassPtr, "nodeCount");
			XPathNodePageInfo.NativeFieldInfoPtr_pageNext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodePageInfo>.NativeClassPtr, "pageNext");
			XPathNodePageInfo.NativeMethodInfoPtr_get_PageNumber_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodePageInfo>.NativeClassPtr, 100663337);
			XPathNodePageInfo.NativeMethodInfoPtr_get_NodeCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodePageInfo>.NativeClassPtr, 100663338);
			XPathNodePageInfo.NativeMethodInfoPtr_get_NextPage_Public_get_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodePageInfo>.NativeClassPtr, 100663339);
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00009E20 File Offset: 0x00008020
		public unsafe int PageNumber
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodePageInfo.NativeMethodInfoPtr_get_PageNumber_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00009E5C File Offset: 0x0000805C
		public unsafe int NodeCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodePageInfo.NativeMethodInfoPtr_get_NodeCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00009E98 File Offset: 0x00008098
		public unsafe Il2CppReferenceArray<XPathNode> NextPage
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodePageInfo.NativeMethodInfoPtr_get_NextPage_Public_get_Il2CppReferenceArray_1_XPathNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr3) : null;
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002231 File Offset: 0x00000431
		public XPathNodePageInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00009ED8 File Offset: 0x000080D8
		// (set) Token: 0x06000057 RID: 87 RVA: 0x0000223A File Offset: 0x0000043A
		public unsafe int pageNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodePageInfo.NativeFieldInfoPtr_pageNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodePageInfo.NativeFieldInfoPtr_pageNum)) = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00009F00 File Offset: 0x00008100
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00002255 File Offset: 0x00000455
		public unsafe int nodeCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodePageInfo.NativeFieldInfoPtr_nodeCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodePageInfo.NativeFieldInfoPtr_nodeCount)) = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00009F28 File Offset: 0x00008128
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00002270 File Offset: 0x00000470
		public unsafe Il2CppReferenceArray<XPathNode> pageNext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodePageInfo.NativeFieldInfoPtr_pageNext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodePageInfo.NativeFieldInfoPtr_pageNext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_pageNum;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_nodeCount;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_pageNext;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_get_PageNumber_Public_get_Int32_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeCount_Public_get_Int32_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_get_NextPage_Public_get_Il2CppReferenceArray_1_XPathNode_0;
	}
}
