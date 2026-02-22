using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x0200009D RID: 157
	public sealed class X509KeyUsageExtension : X509Extension
	{
		// Token: 0x06000945 RID: 2373 RVA: 0x00032598 File Offset: 0x00030798
		// Note: this type is marked as 'beforefieldinit'.
		static X509KeyUsageExtension()
		{
			Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509KeyUsageExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr);
			X509KeyUsageExtension.NativeFieldInfoPtr_oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, "oid");
			X509KeyUsageExtension.NativeFieldInfoPtr_friendlyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, "friendlyName");
			X509KeyUsageExtension.NativeFieldInfoPtr_all = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, "all");
			X509KeyUsageExtension.NativeFieldInfoPtr__keyUsages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, "_keyUsages");
			X509KeyUsageExtension.NativeFieldInfoPtr__status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, "_status");
			X509KeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100664496);
			X509KeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100664497);
			X509KeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_X509KeyUsageFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100664498);
			X509KeyUsageExtension.NativeMethodInfoPtr_get_KeyUsages_Public_get_X509KeyUsageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100664499);
			X509KeyUsageExtension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100664500);
			X509KeyUsageExtension.NativeMethodInfoPtr_GetValidFlags_Internal_X509KeyUsageFlags_X509KeyUsageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100664501);
			X509KeyUsageExtension.NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100664502);
			X509KeyUsageExtension.NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100664503);
			X509KeyUsageExtension.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr, 100664504);
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x000326E0 File Offset: 0x000308E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42889, XrefRangeEnd = 42898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509KeyUsageExtension()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0003271C File Offset: 0x0003091C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42908, RefRangeEnd = 42909, XrefRangeStart = 42898, XrefRangeEnd = 42908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509KeyUsageExtension(AsnEncodedData encodedKeyUsage, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encodedKeyUsage);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00032778 File Offset: 0x00030978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42909, XrefRangeEnd = 42920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509KeyUsageExtension(X509KeyUsageFlags keyUsages, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509KeyUsageExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyUsages;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_X509KeyUsageFlags_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x000327D0 File Offset: 0x000309D0
		public unsafe X509KeyUsageFlags KeyUsages
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr_get_KeyUsages_Public_get_X509KeyUsageFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x0003280C File Offset: 0x00030A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42920, XrefRangeEnd = 42934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asnEncodedData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00032850 File Offset: 0x00030A50
		[CallerCount(0)]
		public unsafe X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr_GetValidFlags_Internal_X509KeyUsageFlags_X509KeyUsageFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0003289C File Offset: 0x00030A9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 42942, RefRangeEnd = 42944, XrefRangeStart = 42934, XrefRangeEnd = 42942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsnDecodeStatus Decode(Il2CppStructArray<byte> extension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extension);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x000328EC File Offset: 0x00030AEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42969, RefRangeEnd = 42970, XrefRangeStart = 42944, XrefRangeEnd = 42969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Encode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0003292C File Offset: 0x00030B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42970, XrefRangeEnd = 43051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509KeyUsageExtension.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00005C72 File Offset: 0x00003E72
		public X509KeyUsageExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x00032970 File Offset: 0x00030B70
		// (set) Token: 0x06000951 RID: 2385 RVA: 0x00005C7B File Offset: 0x00003E7B
		public unsafe static string oid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509KeyUsageExtension.NativeFieldInfoPtr_oid, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509KeyUsageExtension.NativeFieldInfoPtr_oid, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x00032990 File Offset: 0x00030B90
		// (set) Token: 0x06000953 RID: 2387 RVA: 0x00005C8D File Offset: 0x00003E8D
		public unsafe static string friendlyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509KeyUsageExtension.NativeFieldInfoPtr_friendlyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509KeyUsageExtension.NativeFieldInfoPtr_friendlyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x000329B0 File Offset: 0x00030BB0
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x00005C9F File Offset: 0x00003E9F
		public unsafe static X509KeyUsageFlags all
		{
			get
			{
				X509KeyUsageFlags x509KeyUsageFlags;
				IL2CPP.il2cpp_field_static_get_value(X509KeyUsageExtension.NativeFieldInfoPtr_all, (void*)(&x509KeyUsageFlags));
				return x509KeyUsageFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509KeyUsageExtension.NativeFieldInfoPtr_all, (void*)(&value));
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x000329CC File Offset: 0x00030BCC
		// (set) Token: 0x06000957 RID: 2391 RVA: 0x00005CAD File Offset: 0x00003EAD
		public unsafe X509KeyUsageFlags _keyUsages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509KeyUsageExtension.NativeFieldInfoPtr__keyUsages);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509KeyUsageExtension.NativeFieldInfoPtr__keyUsages)) = value;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x000329F4 File Offset: 0x00030BF4
		// (set) Token: 0x06000959 RID: 2393 RVA: 0x00005CC8 File Offset: 0x00003EC8
		public unsafe AsnDecodeStatus _status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509KeyUsageExtension.NativeFieldInfoPtr__status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509KeyUsageExtension.NativeFieldInfoPtr__status)) = value;
			}
		}

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeFieldInfoPtr_oid;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeFieldInfoPtr_friendlyName;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeFieldInfoPtr_all;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeFieldInfoPtr__keyUsages;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeFieldInfoPtr__status;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_X509KeyUsageFlags_Boolean_0;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyUsages_Public_get_X509KeyUsageFlags_0;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeMethodInfoPtr_GetValidFlags_Internal_X509KeyUsageFlags_X509KeyUsageFlags_0;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0;
	}
}
