using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x02000091 RID: 145
	public class X509Chain : Object
	{
		// Token: 0x060008AF RID: 2223 RVA: 0x000307A8 File Offset: 0x0002E9A8
		// Note: this type is marked as 'beforefieldinit'.
		static X509Chain()
		{
			Il2CppClassPointerStore<X509Chain>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509Chain");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Chain>.NativeClassPtr);
			X509Chain.NativeFieldInfoPtr_impl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, "impl");
			X509Chain.NativeMethodInfoPtr_get_Impl_Internal_get_X509ChainImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100664436);
			X509Chain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100664437);
			X509Chain.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100664438);
			X509Chain.NativeMethodInfoPtr__ctor_Internal_Void_X509ChainImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100664439);
			X509Chain.NativeMethodInfoPtr_get_ChainElements_Public_get_X509ChainElementCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100664440);
			X509Chain.NativeMethodInfoPtr_set_ChainPolicy_Public_set_Void_X509ChainPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100664441);
			X509Chain.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100664442);
			X509Chain.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100664443);
			X509Chain.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100664444);
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x000308A0 File Offset: 0x0002EAA0
		public unsafe X509ChainImpl Impl
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 42590, RefRangeEnd = 42591, XrefRangeStart = 42590, XrefRangeEnd = 42590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr_get_Impl_Internal_get_X509ChainImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ChainImpl>(intPtr3) : null;
			}
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x000308E0 File Offset: 0x0002EAE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42609, RefRangeEnd = 42610, XrefRangeStart = 42591, XrefRangeEnd = 42609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Chain()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Chain>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x0003091C File Offset: 0x0002EB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42610, XrefRangeEnd = 42628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Chain(bool useMachineContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Chain>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useMachineContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00030964 File Offset: 0x0002EB64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42629, RefRangeEnd = 42630, XrefRangeStart = 42628, XrefRangeEnd = 42629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Chain(X509ChainImpl impl)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Chain>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr__ctor_Internal_Void_X509ChainImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x000309B0 File Offset: 0x0002EBB0
		public unsafe X509ChainElementCollection ChainElements
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 42634, RefRangeEnd = 42635, XrefRangeStart = 42630, XrefRangeEnd = 42634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr_get_ChainElements_Public_get_X509ChainElementCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ChainElementCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x000309F0 File Offset: 0x0002EBF0
		public unsafe X509ChainPolicy ChainPolicy
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 42639, RefRangeEnd = 42640, XrefRangeStart = 42635, XrefRangeEnd = 42639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr_set_ChainPolicy_Public_set_Void_X509ChainPolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00030A34 File Offset: 0x0002EC34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42644, RefRangeEnd = 42645, XrefRangeStart = 42640, XrefRangeEnd = 42644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00030A68 File Offset: 0x0002EC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42645, XrefRangeEnd = 42649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Chain.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00030AB4 File Offset: 0x0002ECB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Chain.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x000057DB File Offset: 0x000039DB
		public X509Chain(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x00030AF0 File Offset: 0x0002ECF0
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x000057E4 File Offset: 0x000039E4
		public unsafe X509ChainImpl impl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Chain.NativeFieldInfoPtr_impl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509ChainImpl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Chain.NativeFieldInfoPtr_impl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeFieldInfoPtr_impl;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeMethodInfoPtr_get_Impl_Internal_get_X509ChainImpl_0;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_X509ChainImpl_0;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeMethodInfoPtr_get_ChainElements_Public_get_X509ChainElementCollection_0;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeMethodInfoPtr_set_ChainPolicy_Public_set_Void_X509ChainPolicy_0;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}
