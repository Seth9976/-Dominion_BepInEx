using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Sockets;

namespace Il2CppSystem.Net
{
	// Token: 0x020000C8 RID: 200
	[Serializable]
	public class IPAddress : Object
	{
		// Token: 0x06000B8A RID: 2954 RVA: 0x0003C0F4 File Offset: 0x0003A2F4
		// Note: this type is marked as 'beforefieldinit'.
		static IPAddress()
		{
			Il2CppClassPointerStore<IPAddress>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "IPAddress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPAddress>.NativeClassPtr);
			IPAddress.NativeFieldInfoPtr_Any = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "Any");
			IPAddress.NativeFieldInfoPtr_Loopback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "Loopback");
			IPAddress.NativeFieldInfoPtr_Broadcast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "Broadcast");
			IPAddress.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "None");
			IPAddress.NativeFieldInfoPtr_LoopbackMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "LoopbackMask");
			IPAddress.NativeFieldInfoPtr_m_Address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "m_Address");
			IPAddress.NativeFieldInfoPtr_m_ToString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "m_ToString");
			IPAddress.NativeFieldInfoPtr_IPv6Any = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "IPv6Any");
			IPAddress.NativeFieldInfoPtr_IPv6Loopback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "IPv6Loopback");
			IPAddress.NativeFieldInfoPtr_IPv6None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "IPv6None");
			IPAddress.NativeFieldInfoPtr_m_Family = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "m_Family");
			IPAddress.NativeFieldInfoPtr_m_Numbers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "m_Numbers");
			IPAddress.NativeFieldInfoPtr_m_ScopeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "m_ScopeId");
			IPAddress.NativeFieldInfoPtr_m_HashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "m_HashCode");
			IPAddress.NativeFieldInfoPtr_IPv4AddressBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "IPv4AddressBytes");
			IPAddress.NativeFieldInfoPtr_IPv6AddressBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "IPv6AddressBytes");
			IPAddress.NativeFieldInfoPtr_NumberOfLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, "NumberOfLabels");
			IPAddress.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100664942);
			IPAddress.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100664943);
			IPAddress.NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_UInt16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100664944);
			IPAddress.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100664945);
			IPAddress.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100664946);
			IPAddress.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100664947);
			IPAddress.NativeMethodInfoPtr_Parse_Public_Static_IPAddress_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100664948);
			IPAddress.NativeMethodInfoPtr_InternalParse_Private_Static_IPAddress_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100664949);
			IPAddress.NativeMethodInfoPtr_GetAddressBytes_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100664950);
			IPAddress.NativeMethodInfoPtr_get_AddressFamily_Public_get_AddressFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100664951);
			IPAddress.NativeMethodInfoPtr_get_ScopeId_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100664952);
			IPAddress.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100664953);
			IPAddress.NativeMethodInfoPtr_IsLoopback_Public_Static_Boolean_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100664954);
			IPAddress.NativeMethodInfoPtr_Equals_Internal_Boolean_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100664955);
			IPAddress.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100664956);
			IPAddress.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100664957);
			IPAddress.NativeMethodInfoPtr_MapToIPv6_Public_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddress>.NativeClassPtr, 100664958);
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x0003C3CC File Offset: 0x0003A5CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 45861, RefRangeEnd = 45864, XrefRangeStart = 45857, XrefRangeEnd = 45861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPAddress(long newAddress)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPAddress>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newAddress;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0003C414 File Offset: 0x0003A614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45864, XrefRangeEnd = 45868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPAddress(Il2CppStructArray<byte> address, long scopeid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPAddress>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scopeid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0003C470 File Offset: 0x0003A670
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45872, RefRangeEnd = 45873, XrefRangeStart = 45868, XrefRangeEnd = 45872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPAddress(Il2CppStructArray<ushort> address, uint scopeid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPAddress>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scopeid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_UInt16_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0003C4CC File Offset: 0x0003A6CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45877, RefRangeEnd = 45878, XrefRangeStart = 45873, XrefRangeEnd = 45877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPAddress(Il2CppStructArray<byte> address)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPAddress>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0003C518 File Offset: 0x0003A718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45878, XrefRangeEnd = 45882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPAddress(int newAddress)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPAddress>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newAddress;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x0003C560 File Offset: 0x0003A760
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 45886, RefRangeEnd = 45889, XrefRangeStart = 45882, XrefRangeEnd = 45886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string ipString, out IPAddress address)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ipString);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_IPAddress_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			address = ((intPtr4 == 0) ? null : new IPAddress(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0003C5C4 File Offset: 0x0003A7C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 45893, RefRangeEnd = 45896, XrefRangeStart = 45889, XrefRangeEnd = 45893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPAddress Parse(string ipString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ipString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_Parse_Public_Static_IPAddress_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr3) : null;
			}
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x0003C608 File Offset: 0x0003A808
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 45905, RefRangeEnd = 45907, XrefRangeStart = 45896, XrefRangeEnd = 45905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPAddress InternalParse(string ipString, bool tryParse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ipString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryParse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_InternalParse_Private_Static_IPAddress_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr3) : null;
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x0003C65C File Offset: 0x0003A85C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 45910, RefRangeEnd = 45913, XrefRangeStart = 45907, XrefRangeEnd = 45910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetAddressBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_GetAddressBytes_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x0003C69C File Offset: 0x0003A89C
		public unsafe AddressFamily AddressFamily
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_get_AddressFamily_Public_get_AddressFamily_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x0003C6D8 File Offset: 0x0003A8D8
		public unsafe long ScopeId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_get_ScopeId_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0003C714 File Offset: 0x0003A914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45913, XrefRangeEnd = 45917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPAddress.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x0003C758 File Offset: 0x0003A958
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45921, RefRangeEnd = 45922, XrefRangeStart = 45917, XrefRangeEnd = 45921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLoopback(IPAddress address)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_IsLoopback_Public_Static_Boolean_IPAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x0003C79C File Offset: 0x0003A99C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45924, RefRangeEnd = 45925, XrefRangeStart = 45922, XrefRangeEnd = 45924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Object comparandObj, bool compareScopeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparandObj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compareScopeId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_Equals_Internal_Boolean_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x0003C7F8 File Offset: 0x0003A9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45925, XrefRangeEnd = 45927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object comparand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparand);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPAddress.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x0003C850 File Offset: 0x0003AA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45927, XrefRangeEnd = 45928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPAddress.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0003C898 File Offset: 0x0003AA98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45935, RefRangeEnd = 45936, XrefRangeStart = 45928, XrefRangeEnd = 45935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPAddress MapToIPv6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPAddress.NativeMethodInfoPtr_MapToIPv6_Public_IPAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr3) : null;
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x0000686A File Offset: 0x00004A6A
		public IPAddress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000B9D RID: 2973 RVA: 0x0003C8D8 File Offset: 0x0003AAD8
		// (set) Token: 0x06000B9E RID: 2974 RVA: 0x00006873 File Offset: 0x00004A73
		public unsafe static IPAddress Any
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_Any, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_Any, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x0003C900 File Offset: 0x0003AB00
		// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x00006885 File Offset: 0x00004A85
		public unsafe static IPAddress Loopback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_Loopback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_Loopback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000BA1 RID: 2977 RVA: 0x0003C928 File Offset: 0x0003AB28
		// (set) Token: 0x06000BA2 RID: 2978 RVA: 0x00006897 File Offset: 0x00004A97
		public unsafe static IPAddress Broadcast
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_Broadcast, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_Broadcast, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x0003C950 File Offset: 0x0003AB50
		// (set) Token: 0x06000BA4 RID: 2980 RVA: 0x000068A9 File Offset: 0x00004AA9
		public unsafe static IPAddress None
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_None, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_None, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x0003C978 File Offset: 0x0003AB78
		// (set) Token: 0x06000BA6 RID: 2982 RVA: 0x000068BB File Offset: 0x00004ABB
		public unsafe static long LoopbackMask
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_LoopbackMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_LoopbackMask, (void*)(&value));
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x0003C994 File Offset: 0x0003AB94
		// (set) Token: 0x06000BA8 RID: 2984 RVA: 0x000068C9 File Offset: 0x00004AC9
		public unsafe long m_Address
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr_m_Address);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr_m_Address)) = value;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x0003C9BC File Offset: 0x0003ABBC
		// (set) Token: 0x06000BAA RID: 2986 RVA: 0x000068E4 File Offset: 0x00004AE4
		public unsafe string m_ToString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr_m_ToString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr_m_ToString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000BAB RID: 2987 RVA: 0x0003C9E4 File Offset: 0x0003ABE4
		// (set) Token: 0x06000BAC RID: 2988 RVA: 0x00006903 File Offset: 0x00004B03
		public unsafe static IPAddress IPv6Any
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_IPv6Any, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_IPv6Any, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000BAD RID: 2989 RVA: 0x0003CA0C File Offset: 0x0003AC0C
		// (set) Token: 0x06000BAE RID: 2990 RVA: 0x00006915 File Offset: 0x00004B15
		public unsafe static IPAddress IPv6Loopback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_IPv6Loopback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_IPv6Loopback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000BAF RID: 2991 RVA: 0x0003CA34 File Offset: 0x0003AC34
		// (set) Token: 0x06000BB0 RID: 2992 RVA: 0x00006927 File Offset: 0x00004B27
		public unsafe static IPAddress IPv6None
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_IPv6None, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_IPv6None, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x0003CA5C File Offset: 0x0003AC5C
		// (set) Token: 0x06000BB2 RID: 2994 RVA: 0x00006939 File Offset: 0x00004B39
		public unsafe AddressFamily m_Family
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr_m_Family);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr_m_Family)) = value;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x0003CA84 File Offset: 0x0003AC84
		// (set) Token: 0x06000BB4 RID: 2996 RVA: 0x00006954 File Offset: 0x00004B54
		public unsafe Il2CppStructArray<ushort> m_Numbers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr_m_Numbers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr_m_Numbers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x0003CAB4 File Offset: 0x0003ACB4
		// (set) Token: 0x06000BB6 RID: 2998 RVA: 0x00006973 File Offset: 0x00004B73
		public unsafe long m_ScopeId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr_m_ScopeId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr_m_ScopeId)) = value;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x0003CADC File Offset: 0x0003ACDC
		// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x0000698E File Offset: 0x00004B8E
		public unsafe int m_HashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr_m_HashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPAddress.NativeFieldInfoPtr_m_HashCode)) = value;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x0003CB04 File Offset: 0x0003AD04
		// (set) Token: 0x06000BBA RID: 3002 RVA: 0x000069A9 File Offset: 0x00004BA9
		public unsafe static int IPv4AddressBytes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_IPv4AddressBytes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_IPv4AddressBytes, (void*)(&value));
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x0003CB20 File Offset: 0x0003AD20
		// (set) Token: 0x06000BBC RID: 3004 RVA: 0x000069B7 File Offset: 0x00004BB7
		public unsafe static int IPv6AddressBytes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_IPv6AddressBytes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_IPv6AddressBytes, (void*)(&value));
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x0003CB3C File Offset: 0x0003AD3C
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x000069C5 File Offset: 0x00004BC5
		public unsafe static int NumberOfLabels
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(IPAddress.NativeFieldInfoPtr_NumberOfLabels, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPAddress.NativeFieldInfoPtr_NumberOfLabels, (void*)(&value));
			}
		}

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeFieldInfoPtr_Any;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeFieldInfoPtr_Loopback;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeFieldInfoPtr_Broadcast;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeFieldInfoPtr_None;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeFieldInfoPtr_LoopbackMask;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeFieldInfoPtr_m_Address;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeFieldInfoPtr_m_ToString;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeFieldInfoPtr_IPv6Any;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeFieldInfoPtr_IPv6Loopback;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeFieldInfoPtr_IPv6None;

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeFieldInfoPtr_m_Family;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeFieldInfoPtr_m_Numbers;

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeFieldInfoPtr_m_ScopeId;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeFieldInfoPtr_m_HashCode;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeFieldInfoPtr_IPv4AddressBytes;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeFieldInfoPtr_IPv6AddressBytes;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeFieldInfoPtr_NumberOfLabels;

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int64_0;

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_UInt16_UInt32_0;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x04000946 RID: 2374
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_IPAddress_0;

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_IPAddress_String_0;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeMethodInfoPtr_InternalParse_Private_Static_IPAddress_String_Boolean_0;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeMethodInfoPtr_GetAddressBytes_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeMethodInfoPtr_get_AddressFamily_Public_get_AddressFamily_0;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeMethodInfoPtr_get_ScopeId_Public_get_Int64_0;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeMethodInfoPtr_IsLoopback_Public_Static_Boolean_IPAddress_0;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Internal_Boolean_Object_Boolean_0;

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeMethodInfoPtr_MapToIPv6_Public_IPAddress_0;
	}
}
