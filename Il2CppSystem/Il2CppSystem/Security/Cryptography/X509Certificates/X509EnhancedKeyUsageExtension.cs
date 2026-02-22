using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x02000099 RID: 153
	public sealed class X509EnhancedKeyUsageExtension : X509Extension
	{
		// Token: 0x06000925 RID: 2341 RVA: 0x00031E9C File Offset: 0x0003009C
		// Note: this type is marked as 'beforefieldinit'.
		static X509EnhancedKeyUsageExtension()
		{
			Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509EnhancedKeyUsageExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr);
			X509EnhancedKeyUsageExtension.NativeFieldInfoPtr__enhKeyUsage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr, "_enhKeyUsage");
			X509EnhancedKeyUsageExtension.NativeFieldInfoPtr__status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr, "_status");
			X509EnhancedKeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr, 100664478);
			X509EnhancedKeyUsageExtension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr, 100664479);
			X509EnhancedKeyUsageExtension.NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr, 100664480);
			X509EnhancedKeyUsageExtension.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr, 100664481);
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00031F44 File Offset: 0x00030144
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42765, RefRangeEnd = 42766, XrefRangeStart = 42755, XrefRangeEnd = 42765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509EnhancedKeyUsageExtension(AsnEncodedData encodedEnhancedKeyUsages, bool critical)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509EnhancedKeyUsageExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encodedEnhancedKeyUsages);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref critical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509EnhancedKeyUsageExtension.NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00031FA0 File Offset: 0x000301A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42766, XrefRangeEnd = 42780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asnEncodedData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509EnhancedKeyUsageExtension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00031FE4 File Offset: 0x000301E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 42798, RefRangeEnd = 42800, XrefRangeStart = 42780, XrefRangeEnd = 42798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsnDecodeStatus Decode(Il2CppStructArray<byte> extension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extension);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509EnhancedKeyUsageExtension.NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00032034 File Offset: 0x00030234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42800, XrefRangeEnd = 42832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(bool multiLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref multiLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509EnhancedKeyUsageExtension.NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00005BAE File Offset: 0x00003DAE
		public X509EnhancedKeyUsageExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x00032078 File Offset: 0x00030278
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x00005BB7 File Offset: 0x00003DB7
		public unsafe OidCollection _enhKeyUsage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509EnhancedKeyUsageExtension.NativeFieldInfoPtr__enhKeyUsage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OidCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509EnhancedKeyUsageExtension.NativeFieldInfoPtr__enhKeyUsage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x000320A8 File Offset: 0x000302A8
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x00005BD6 File Offset: 0x00003DD6
		public unsafe AsnDecodeStatus _status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509EnhancedKeyUsageExtension.NativeFieldInfoPtr__status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509EnhancedKeyUsageExtension.NativeFieldInfoPtr__status)) = value;
			}
		}

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeFieldInfoPtr__enhKeyUsage;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeFieldInfoPtr__status;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AsnEncodedData_Boolean_0;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Internal_AsnDecodeStatus_Il2CppStructArray_1_Byte_0;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Virtual_String_Boolean_0;
	}
}
