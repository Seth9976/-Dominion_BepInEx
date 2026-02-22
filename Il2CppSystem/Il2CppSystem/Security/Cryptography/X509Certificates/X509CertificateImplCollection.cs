using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x02000090 RID: 144
	public class X509CertificateImplCollection : Object
	{
		// Token: 0x060008A2 RID: 2210 RVA: 0x00030424 File Offset: 0x0002E624
		// Note: this type is marked as 'beforefieldinit'.
		static X509CertificateImplCollection()
		{
			Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509CertificateImplCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr);
			X509CertificateImplCollection.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr, "list");
			X509CertificateImplCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr, 100664427);
			X509CertificateImplCollection.NativeMethodInfoPtr__ctor_Private_Void_X509CertificateImplCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr, 100664428);
			X509CertificateImplCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr, 100664429);
			X509CertificateImplCollection.NativeMethodInfoPtr_get_Item_Public_get_X509CertificateImpl_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr, 100664430);
			X509CertificateImplCollection.NativeMethodInfoPtr_Add_Public_Void_X509CertificateImpl_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr, 100664431);
			X509CertificateImplCollection.NativeMethodInfoPtr_Clone_Public_X509CertificateImplCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr, 100664432);
			X509CertificateImplCollection.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr, 100664433);
			X509CertificateImplCollection.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr, 100664434);
			X509CertificateImplCollection.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr, 100664435);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x0003051C File Offset: 0x0002E71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42516, XrefRangeEnd = 42523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509CertificateImplCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00030558 File Offset: 0x0002E758
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 42547, RefRangeEnd = 42550, XrefRangeStart = 42523, XrefRangeEnd = 42547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509CertificateImplCollection(X509CertificateImplCollection other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509CertificateImplCollection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplCollection.NativeMethodInfoPtr__ctor_Private_Void_X509CertificateImplCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x000305A4 File Offset: 0x0002E7A4
		public unsafe int Count
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 42551, RefRangeEnd = 42553, XrefRangeStart = 42550, XrefRangeEnd = 42551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700029F RID: 671
		public unsafe X509CertificateImpl this[int index]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 42555, RefRangeEnd = 42556, XrefRangeStart = 42553, XrefRangeEnd = 42555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplCollection.NativeMethodInfoPtr_get_Item_Public_get_X509CertificateImpl_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
				}
			}
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x0003062C File Offset: 0x0002E82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42556, XrefRangeEnd = 42560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(X509CertificateImpl impl, bool takeOwnership)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref takeOwnership;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplCollection.NativeMethodInfoPtr_Add_Public_Void_X509CertificateImpl_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x0003067C File Offset: 0x0002E87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42560, XrefRangeEnd = 42564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509CertificateImplCollection Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplCollection.NativeMethodInfoPtr_Clone_Public_X509CertificateImplCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImplCollection>(intPtr3) : null;
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x000306BC File Offset: 0x0002E8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42564, XrefRangeEnd = 42568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplCollection.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x000306F0 File Offset: 0x0002E8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42568, XrefRangeEnd = 42587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImplCollection.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x0003073C File Offset: 0x0002E93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42587, XrefRangeEnd = 42590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImplCollection.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x000057B3 File Offset: 0x000039B3
		public X509CertificateImplCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x00030778 File Offset: 0x0002E978
		// (set) Token: 0x060008AE RID: 2222 RVA: 0x000057BC File Offset: 0x000039BC
		public unsafe List<X509CertificateImpl> list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509CertificateImplCollection.NativeFieldInfoPtr_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<X509CertificateImpl>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509CertificateImplCollection.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeFieldInfoPtr_list;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_X509CertificateImplCollection_0;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_X509CertificateImpl_Int32_0;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_X509CertificateImpl_Boolean_0;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_X509CertificateImplCollection_0;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}
