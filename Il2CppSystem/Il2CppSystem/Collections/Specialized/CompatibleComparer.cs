using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Specialized
{
	// Token: 0x020000A7 RID: 167
	[Serializable]
	public class CompatibleComparer : Object
	{
		// Token: 0x06000A23 RID: 2595 RVA: 0x000362C0 File Offset: 0x000344C0
		// Note: this type is marked as 'beforefieldinit'.
		static CompatibleComparer()
		{
			Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Specialized", "CompatibleComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr);
			CompatibleComparer.NativeFieldInfoPtr__comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, "_comparer");
			CompatibleComparer.NativeFieldInfoPtr_defaultComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, "defaultComparer");
			CompatibleComparer.NativeFieldInfoPtr__hcp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, "_hcp");
			CompatibleComparer.NativeFieldInfoPtr_defaultHashProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, "defaultHashProvider");
			CompatibleComparer.NativeMethodInfoPtr__ctor_Internal_Void_IComparer_IHashCodeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100664657);
			CompatibleComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100664658);
			CompatibleComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100664659);
			CompatibleComparer.NativeMethodInfoPtr_get_Comparer_Public_get_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100664660);
			CompatibleComparer.NativeMethodInfoPtr_get_HashCodeProvider_Public_get_IHashCodeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100664661);
			CompatibleComparer.NativeMethodInfoPtr_get_DefaultComparer_Public_Static_get_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100664662);
			CompatibleComparer.NativeMethodInfoPtr_get_DefaultHashCodeProvider_Public_Static_get_IHashCodeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr, 100664663);
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x000363CC File Offset: 0x000345CC
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompatibleComparer(IComparer comparer, IHashCodeProvider hashCodeProvider)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompatibleComparer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hashCodeProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompatibleComparer.NativeMethodInfoPtr__ctor_Internal_Void_IComparer_IHashCodeProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x0003642C File Offset: 0x0003462C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44252, XrefRangeEnd = 44262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(Object a, Object b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompatibleComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x0003648C File Offset: 0x0003468C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44262, XrefRangeEnd = 44271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetHashCode(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompatibleComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x000364DC File Offset: 0x000346DC
		public unsafe IComparer Comparer
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompatibleComparer.NativeMethodInfoPtr_get_Comparer_Public_get_IComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComparer>(intPtr3) : null;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x0003651C File Offset: 0x0003471C
		public unsafe IHashCodeProvider HashCodeProvider
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompatibleComparer.NativeMethodInfoPtr_get_HashCodeProvider_Public_get_IHashCodeProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHashCodeProvider>(intPtr3) : null;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x0003655C File Offset: 0x0003475C
		public unsafe static IComparer DefaultComparer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 44286, RefRangeEnd = 44287, XrefRangeStart = 44271, XrefRangeEnd = 44286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompatibleComparer.NativeMethodInfoPtr_get_DefaultComparer_Public_Static_get_IComparer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComparer>(intPtr3) : null;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x00036590 File Offset: 0x00034790
		public unsafe static IHashCodeProvider DefaultHashCodeProvider
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 44302, RefRangeEnd = 44303, XrefRangeStart = 44287, XrefRangeEnd = 44302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompatibleComparer.NativeMethodInfoPtr_get_DefaultHashCodeProvider_Public_Static_get_IHashCodeProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHashCodeProvider>(intPtr3) : null;
			}
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x000060F6 File Offset: 0x000042F6
		public CompatibleComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x000365C4 File Offset: 0x000347C4
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x000060FF File Offset: 0x000042FF
		public unsafe IComparer _comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompatibleComparer.NativeFieldInfoPtr__comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompatibleComparer.NativeFieldInfoPtr__comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x000365F4 File Offset: 0x000347F4
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x0000611E File Offset: 0x0000431E
		public unsafe static IComparer defaultComparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CompatibleComparer.NativeFieldInfoPtr_defaultComparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompatibleComparer.NativeFieldInfoPtr_defaultComparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x0003661C File Offset: 0x0003481C
		// (set) Token: 0x06000A31 RID: 2609 RVA: 0x00006130 File Offset: 0x00004330
		public unsafe IHashCodeProvider _hcp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompatibleComparer.NativeFieldInfoPtr__hcp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHashCodeProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompatibleComparer.NativeFieldInfoPtr__hcp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x0003664C File Offset: 0x0003484C
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x0000614F File Offset: 0x0000434F
		public unsafe static IHashCodeProvider defaultHashProvider
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CompatibleComparer.NativeFieldInfoPtr_defaultHashProvider, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHashCodeProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompatibleComparer.NativeFieldInfoPtr_defaultHashProvider, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeFieldInfoPtr__comparer;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeFieldInfoPtr_defaultComparer;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeFieldInfoPtr__hcp;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeFieldInfoPtr_defaultHashProvider;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IComparer_IHashCodeProvider_0;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr_get_Comparer_Public_get_IComparer_0;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_get_HashCodeProvider_Public_get_IHashCodeProvider_0;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultComparer_Public_Static_get_IComparer_0;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultHashCodeProvider_Public_Static_get_IHashCodeProvider_0;
	}
}
