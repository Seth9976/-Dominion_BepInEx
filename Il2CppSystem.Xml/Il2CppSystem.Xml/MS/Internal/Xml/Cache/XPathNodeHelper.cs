using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x02000006 RID: 6
	public class XPathNodeHelper : Object
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00009A40 File Offset: 0x00007C40
		// Note: this type is marked as 'beforefieldinit'.
		static XPathNodeHelper()
		{
			Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.Cache", "XPathNodeHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr);
			XPathNodeHelper.NativeMethodInfoPtr_GetLocalNamespaces_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr, 100663331);
			XPathNodeHelper.NativeMethodInfoPtr_GetInScopeNamespaces_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr, 100663332);
			XPathNodeHelper.NativeMethodInfoPtr_GetParent_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr, 100663333);
			XPathNodeHelper.NativeMethodInfoPtr_GetLocation_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr, 100663334);
			XPathNodeHelper.NativeMethodInfoPtr_GetTextFollowing_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr, 100663335);
			XPathNodeHelper.NativeMethodInfoPtr_GetNonDescendant_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr, 100663336);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00009AE8 File Offset: 0x00007CE8
		[CallerCount(0)]
		public unsafe static int GetLocalNamespaces(Il2CppReferenceArray<XPathNode> pageElem, int idxElem, out Il2CppReferenceArray<XPathNode> pageNmsp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pageElem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idxElem;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathNodeHelper.NativeMethodInfoPtr_GetLocalNamespaces_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pageNmsp = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00009B5C File Offset: 0x00007D5C
		[CallerCount(0)]
		public unsafe static int GetInScopeNamespaces(Il2CppReferenceArray<XPathNode> pageElem, int idxElem, out Il2CppReferenceArray<XPathNode> pageNmsp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pageElem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idxElem;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathNodeHelper.NativeMethodInfoPtr_GetInScopeNamespaces_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pageNmsp = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00009BD0 File Offset: 0x00007DD0
		[CallerCount(0)]
		public unsafe static bool GetParent(ref Il2CppReferenceArray<XPathNode> pageNode, ref int idxNode)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(pageNode);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idxNode;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathNodeHelper.NativeMethodInfoPtr_GetParent_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pageNode = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00009C38 File Offset: 0x00007E38
		[CallerCount(0)]
		public unsafe static int GetLocation(Il2CppReferenceArray<XPathNode> pageNode, int idxNode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pageNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idxNode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeHelper.NativeMethodInfoPtr_GetLocation_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00009C88 File Offset: 0x00007E88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 11686, RefRangeEnd = 11688, XrefRangeStart = 11680, XrefRangeEnd = 11686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetTextFollowing(ref Il2CppReferenceArray<XPathNode> pageCurrent, ref int idxCurrent, Il2CppReferenceArray<XPathNode> pageEnd, int idxEnd)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(pageCurrent);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idxCurrent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pageEnd);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idxEnd;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathNodeHelper.NativeMethodInfoPtr_GetTextFollowing_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pageCurrent = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00009D10 File Offset: 0x00007F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11688, XrefRangeEnd = 11689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetNonDescendant(ref Il2CppReferenceArray<XPathNode> pageNode, ref int idxNode)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(pageNode);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idxNode;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathNodeHelper.NativeMethodInfoPtr_GetNonDescendant_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pageNode = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002228 File Offset: 0x00000428
		public XPathNodeHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalNamespaces_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_GetInScopeNamespaces_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_GetParent_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_GetLocation_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_GetTextFollowing_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_GetNonDescendant_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_0;
	}
}
