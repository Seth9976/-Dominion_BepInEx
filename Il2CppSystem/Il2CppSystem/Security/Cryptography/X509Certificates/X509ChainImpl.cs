using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x02000095 RID: 149
	public class X509ChainImpl : Object
	{
		// Token: 0x060008D7 RID: 2263 RVA: 0x00031110 File Offset: 0x0002F310
		// Note: this type is marked as 'beforefieldinit'.
		static X509ChainImpl()
		{
			Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509ChainImpl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr);
			X509ChainImpl.NativeMethodInfoPtr_get_IsValid_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr, 100664458);
			X509ChainImpl.NativeMethodInfoPtr_ThrowIfContextInvalid_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr, 100664459);
			X509ChainImpl.NativeMethodInfoPtr_get_ChainElements_Public_Abstract_Virtual_New_get_X509ChainElementCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr, 100664460);
			X509ChainImpl.NativeMethodInfoPtr_set_ChainPolicy_Public_Abstract_Virtual_New_set_Void_X509ChainPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr, 100664461);
			X509ChainImpl.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr, 100664462);
			X509ChainImpl.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr, 100664463);
			X509ChainImpl.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr, 100664464);
			X509ChainImpl.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr, 100664465);
			X509ChainImpl.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr, 100664466);
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x000311F4 File Offset: 0x0002F3F4
		public unsafe virtual bool IsValid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImpl.NativeMethodInfoPtr_get_IsValid_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x0003123C File Offset: 0x0002F43C
		[CallerCount(0)]
		public unsafe void ThrowIfContextInvalid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImpl.NativeMethodInfoPtr_ThrowIfContextInvalid_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x00031270 File Offset: 0x0002F470
		public unsafe virtual X509ChainElementCollection ChainElements
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImpl.NativeMethodInfoPtr_get_ChainElements_Public_Abstract_Virtual_New_get_X509ChainElementCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ChainElementCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170002AE RID: 686
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x000312BC File Offset: 0x0002F4BC
		public unsafe virtual X509ChainPolicy ChainPolicy
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImpl.NativeMethodInfoPtr_set_ChainPolicy_Public_Abstract_Virtual_New_set_Void_X509ChainPolicy_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x0003130C File Offset: 0x0002F50C
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImpl.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00031348 File Offset: 0x0002F548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42694, XrefRangeEnd = 42698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImpl.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0003137C File Offset: 0x0002F57C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImpl.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x000313C8 File Offset: 0x0002F5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42698, XrefRangeEnd = 42701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509ChainImpl.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00031404 File Offset: 0x0002F604
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainImpl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainImpl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainImpl.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0000589A File Offset: 0x00003A9A
		public X509ChainImpl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfContextInvalid_Protected_Void_0;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeMethodInfoPtr_get_ChainElements_Public_Abstract_Virtual_New_get_X509ChainElementCollection_0;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeMethodInfoPtr_set_ChainPolicy_Public_Abstract_Virtual_New_set_Void_X509ChainPolicy_0;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
