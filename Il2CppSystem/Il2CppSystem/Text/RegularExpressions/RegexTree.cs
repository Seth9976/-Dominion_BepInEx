using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000061 RID: 97
	public sealed class RegexTree : Object
	{
		// Token: 0x06000729 RID: 1833 RVA: 0x0002B394 File Offset: 0x00029594
		// Note: this type is marked as 'beforefieldinit'.
		static RegexTree()
		{
			Il2CppClassPointerStore<RegexTree>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexTree");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexTree>.NativeClassPtr);
			RegexTree.NativeFieldInfoPtr__root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexTree>.NativeClassPtr, "_root");
			RegexTree.NativeFieldInfoPtr__caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexTree>.NativeClassPtr, "_caps");
			RegexTree.NativeFieldInfoPtr__capnumlist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexTree>.NativeClassPtr, "_capnumlist");
			RegexTree.NativeFieldInfoPtr__capnames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexTree>.NativeClassPtr, "_capnames");
			RegexTree.NativeFieldInfoPtr__capslist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexTree>.NativeClassPtr, "_capslist");
			RegexTree.NativeFieldInfoPtr__options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexTree>.NativeClassPtr, "_options");
			RegexTree.NativeFieldInfoPtr__captop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexTree>.NativeClassPtr, "_captop");
			RegexTree.NativeMethodInfoPtr__ctor_Internal_Void_RegexNode_Hashtable_Il2CppStructArray_1_Int32_Int32_Hashtable_Il2CppStringArray_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexTree>.NativeClassPtr, 100664245);
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0002B464 File Offset: 0x00029664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40710, XrefRangeEnd = 40711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexTree(RegexNode root, Hashtable caps, Il2CppStructArray<int> capnumlist, int captop, Hashtable capnames, Il2CppStringArray capslist, RegexOptions opts)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexTree>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caps);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(capnumlist);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref captop;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(capnames);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(capslist);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opts;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexTree.NativeMethodInfoPtr__ctor_Internal_Void_RegexNode_Hashtable_Il2CppStructArray_1_Int32_Int32_Hashtable_Il2CppStringArray_RegexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00004C9B File Offset: 0x00002E9B
		public RegexTree(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x0002B518 File Offset: 0x00029718
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x00004CA4 File Offset: 0x00002EA4
		public unsafe RegexNode _root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x0002B548 File Offset: 0x00029748
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x00004CC3 File Offset: 0x00002EC3
		public unsafe Hashtable _caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x0002B578 File Offset: 0x00029778
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x00004CE2 File Offset: 0x00002EE2
		public unsafe Il2CppStructArray<int> _capnumlist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__capnumlist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__capnumlist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x0002B5A8 File Offset: 0x000297A8
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x00004D01 File Offset: 0x00002F01
		public unsafe Hashtable _capnames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__capnames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__capnames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x0002B5D8 File Offset: 0x000297D8
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x00004D20 File Offset: 0x00002F20
		public unsafe Il2CppStringArray _capslist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__capslist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__capslist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x0002B608 File Offset: 0x00029808
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x00004D3F File Offset: 0x00002F3F
		public unsafe RegexOptions _options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__options);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__options)) = value;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x0002B630 File Offset: 0x00029830
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x00004D5A File Offset: 0x00002F5A
		public unsafe int _captop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__captop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexTree.NativeFieldInfoPtr__captop)) = value;
			}
		}

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeFieldInfoPtr__root;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeFieldInfoPtr__caps;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeFieldInfoPtr__capnumlist;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeFieldInfoPtr__capnames;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeFieldInfoPtr__capslist;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeFieldInfoPtr__options;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeFieldInfoPtr__captop;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_RegexNode_Hashtable_Il2CppStructArray_1_Int32_Int32_Hashtable_Il2CppStringArray_RegexOptions_0;
	}
}
