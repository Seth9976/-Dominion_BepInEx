using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000D9 RID: 217
	public class NamespaceList : Object
	{
		// Token: 0x06000D0A RID: 3338 RVA: 0x0003F378 File Offset: 0x0003D578
		// Note: this type is marked as 'beforefieldinit'.
		static NamespaceList()
		{
			Il2CppClassPointerStore<NamespaceList>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "NamespaceList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr);
			NamespaceList.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, "type");
			NamespaceList.NativeFieldInfoPtr_set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, "set");
			NamespaceList.NativeFieldInfoPtr_targetNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, "targetNamespace");
			NamespaceList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100665232);
			NamespaceList.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100665233);
			NamespaceList.NativeMethodInfoPtr_get_Type_Public_get_ListType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100665234);
			NamespaceList.NativeMethodInfoPtr_get_Excluded_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100665235);
			NamespaceList.NativeMethodInfoPtr_get_Enumerate_Public_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100665236);
			NamespaceList.NativeMethodInfoPtr_Allows_Public_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100665237);
			NamespaceList.NativeMethodInfoPtr_Allows_Public_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100665238);
			NamespaceList.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100665239);
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x0003F484 File Offset: 0x0003D684
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NamespaceList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x0003F4C0 File Offset: 0x0003D6C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 24023, RefRangeEnd = 24027, XrefRangeStart = 23993, XrefRangeEnd = 24023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NamespaceList(string namespaces, string targetNamespace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaces);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x0003F520 File Offset: 0x0003D720
		public unsafe NamespaceList.ListType Type
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr_get_Type_Public_get_ListType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x0003F55C File Offset: 0x0003D75C
		public unsafe string Excluded
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr_get_Excluded_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x0003F594 File Offset: 0x0003D794
		public unsafe ICollection Enumerate
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24027, XrefRangeEnd = 24033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr_get_Enumerate_Public_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x0003F5D4 File Offset: 0x0003D7D4
		[CallerCount(0)]
		public unsafe virtual bool Allows(string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamespaceList.NativeMethodInfoPtr_Allows_Public_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x0003F62C File Offset: 0x0003D82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24033, XrefRangeEnd = 24034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Allows(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr_Allows_Public_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x0003F67C File Offset: 0x0003D87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24034, XrefRangeEnd = 24045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamespaceList.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x000063B6 File Offset: 0x000045B6
		public NamespaceList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x0003F6C0 File Offset: 0x0003D8C0
		// (set) Token: 0x06000D15 RID: 3349 RVA: 0x000063BF File Offset: 0x000045BF
		public unsafe NamespaceList.ListType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceList.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceList.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x0003F6E8 File Offset: 0x0003D8E8
		// (set) Token: 0x06000D17 RID: 3351 RVA: 0x000063DA File Offset: 0x000045DA
		public unsafe Hashtable set
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceList.NativeFieldInfoPtr_set);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceList.NativeFieldInfoPtr_set), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x0003F718 File Offset: 0x0003D918
		// (set) Token: 0x06000D19 RID: 3353 RVA: 0x000063F9 File Offset: 0x000045F9
		public unsafe string targetNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceList.NativeFieldInfoPtr_targetNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceList.NativeFieldInfoPtr_targetNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeFieldInfoPtr_set;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeFieldInfoPtr_targetNamespace;

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_ListType_0;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeMethodInfoPtr_get_Excluded_Public_get_String_0;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeMethodInfoPtr_get_Enumerate_Public_get_ICollection_0;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeMethodInfoPtr_Allows_Public_Virtual_New_Boolean_String_0;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeMethodInfoPtr_Allows_Public_Boolean_XmlQualifiedName_0;

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x02000131 RID: 305
		public enum ListType
		{
			// Token: 0x04000EBD RID: 3773
			Any,
			// Token: 0x04000EBE RID: 3774
			Other,
			// Token: 0x04000EBF RID: 3775
			Set
		}
	}
}
