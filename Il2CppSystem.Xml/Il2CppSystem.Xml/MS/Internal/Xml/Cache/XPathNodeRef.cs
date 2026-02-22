using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x02000005 RID: 5
	public sealed class XPathNodeRef : ValueType
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00009814 File Offset: 0x00007A14
		// Note: this type is marked as 'beforefieldinit'.
		static XPathNodeRef()
		{
			Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.Cache", "XPathNodeRef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr);
			XPathNodeRef.NativeFieldInfoPtr_page = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr, "page");
			XPathNodeRef.NativeFieldInfoPtr_idx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr, "idx");
			XPathNodeRef.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_XPathNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr, 100663327);
			XPathNodeRef.NativeMethodInfoPtr_get_Page_Public_get_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr, 100663328);
			XPathNodeRef.NativeMethodInfoPtr_get_Index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr, 100663329);
			XPathNodeRef.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr, 100663330);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000098BC File Offset: 0x00007ABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 11679, RefRangeEnd = 11680, XrefRangeStart = 11679, XrefRangeEnd = 11679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XPathNodeRef(Il2CppReferenceArray<XPathNode> page, int idx)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(page);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeRef.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_XPathNode_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000040 RID: 64 RVA: 0x0000991C File Offset: 0x00007B1C
		public unsafe Il2CppReferenceArray<XPathNode> Page
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeRef.NativeMethodInfoPtr_get_Page_Public_get_Il2CppReferenceArray_1_XPathNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr3) : null;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00009960 File Offset: 0x00007B60
		public unsafe int Index
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeRef.NativeMethodInfoPtr_get_Index_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000099A4 File Offset: 0x00007BA4
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeRef.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000021D3 File Offset: 0x000003D3
		public XPathNodeRef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000021DC File Offset: 0x000003DC
		public XPathNodeRef()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr))
		{
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000099E8 File Offset: 0x00007BE8
		// (set) Token: 0x06000046 RID: 70 RVA: 0x000021EE File Offset: 0x000003EE
		public unsafe Il2CppReferenceArray<XPathNode> page
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeRef.NativeFieldInfoPtr_page);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeRef.NativeFieldInfoPtr_page), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00009A18 File Offset: 0x00007C18
		// (set) Token: 0x06000048 RID: 72 RVA: 0x0000220D File Offset: 0x0000040D
		public unsafe int idx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeRef.NativeFieldInfoPtr_idx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeRef.NativeFieldInfoPtr_idx)) = value;
			}
		}

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_page;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_idx;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_XPathNode_Int32_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_get_Page_Public_get_Il2CppReferenceArray_1_XPathNode_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_get_Index_Public_get_Int32_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
