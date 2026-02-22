using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000CA RID: 202
	public class IPHostEntry : Object
	{
		// Token: 0x06000BD2 RID: 3026 RVA: 0x0003CFE0 File Offset: 0x0003B1E0
		// Note: this type is marked as 'beforefieldinit'.
		static IPHostEntry()
		{
			Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "IPHostEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr);
			IPHostEntry.NativeFieldInfoPtr_hostName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, "hostName");
			IPHostEntry.NativeFieldInfoPtr_aliases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, "aliases");
			IPHostEntry.NativeFieldInfoPtr_addressList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, "addressList");
			IPHostEntry.NativeFieldInfoPtr_isTrustedHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, "isTrustedHost");
			IPHostEntry.NativeMethodInfoPtr_get_HostName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, 100664970);
			IPHostEntry.NativeMethodInfoPtr_set_HostName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, 100664971);
			IPHostEntry.NativeMethodInfoPtr_set_Aliases_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, 100664972);
			IPHostEntry.NativeMethodInfoPtr_get_AddressList_Public_get_Il2CppReferenceArray_1_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, 100664973);
			IPHostEntry.NativeMethodInfoPtr_set_AddressList_Public_set_Void_Il2CppReferenceArray_1_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, 100664974);
			IPHostEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr, 100664975);
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x0003D0D8 File Offset: 0x0003B2D8
		// (set) Token: 0x06000BD4 RID: 3028 RVA: 0x0003D110 File Offset: 0x0003B310
		public unsafe string HostName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPHostEntry.NativeMethodInfoPtr_get_HostName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPHostEntry.NativeMethodInfoPtr_set_HostName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000386 RID: 902
		// (set) Token: 0x06000BD5 RID: 3029 RVA: 0x0003D154 File Offset: 0x0003B354
		public unsafe Il2CppStringArray Aliases
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPHostEntry.NativeMethodInfoPtr_set_Aliases_Public_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x0003D198 File Offset: 0x0003B398
		// (set) Token: 0x06000BD7 RID: 3031 RVA: 0x0003D1D8 File Offset: 0x0003B3D8
		public unsafe Il2CppReferenceArray<IPAddress> AddressList
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPHostEntry.NativeMethodInfoPtr_get_AddressList_Public_get_Il2CppReferenceArray_1_IPAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPHostEntry.NativeMethodInfoPtr_set_AddressList_Public_set_Void_Il2CppReferenceArray_1_IPAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x0003D21C File Offset: 0x0003B41C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 45964, RefRangeEnd = 45966, XrefRangeStart = 45963, XrefRangeEnd = 45964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPHostEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPHostEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPHostEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00006A3A File Offset: 0x00004C3A
		public IPHostEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x0003D258 File Offset: 0x0003B458
		// (set) Token: 0x06000BDB RID: 3035 RVA: 0x00006A43 File Offset: 0x00004C43
		public unsafe string hostName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPHostEntry.NativeFieldInfoPtr_hostName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPHostEntry.NativeFieldInfoPtr_hostName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x0003D280 File Offset: 0x0003B480
		// (set) Token: 0x06000BDD RID: 3037 RVA: 0x00006A62 File Offset: 0x00004C62
		public unsafe Il2CppStringArray aliases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPHostEntry.NativeFieldInfoPtr_aliases);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPHostEntry.NativeFieldInfoPtr_aliases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x0003D2B0 File Offset: 0x0003B4B0
		// (set) Token: 0x06000BDF RID: 3039 RVA: 0x00006A81 File Offset: 0x00004C81
		public unsafe Il2CppReferenceArray<IPAddress> addressList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPHostEntry.NativeFieldInfoPtr_addressList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPHostEntry.NativeFieldInfoPtr_addressList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x0003D2E0 File Offset: 0x0003B4E0
		// (set) Token: 0x06000BE1 RID: 3041 RVA: 0x00006AA0 File Offset: 0x00004CA0
		public unsafe bool isTrustedHost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPHostEntry.NativeFieldInfoPtr_isTrustedHost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPHostEntry.NativeFieldInfoPtr_isTrustedHost)) = value;
			}
		}

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeFieldInfoPtr_hostName;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeFieldInfoPtr_aliases;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeFieldInfoPtr_addressList;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeFieldInfoPtr_isTrustedHost;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeMethodInfoPtr_get_HostName_Public_get_String_0;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeMethodInfoPtr_set_HostName_Public_set_Void_String_0;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeMethodInfoPtr_set_Aliases_Public_set_Void_Il2CppStringArray_0;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeMethodInfoPtr_get_AddressList_Public_get_Il2CppReferenceArray_1_IPAddress_0;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeMethodInfoPtr_set_AddressList_Public_set_Void_Il2CppReferenceArray_1_IPAddress_0;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
