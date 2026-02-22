using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000CD RID: 205
	public static class NclUtilities : Object
	{
		// Token: 0x06000BE8 RID: 3048 RVA: 0x0003D3A0 File Offset: 0x0003B5A0
		// Note: this type is marked as 'beforefieldinit'.
		static NclUtilities()
		{
			Il2CppClassPointerStore<NclUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "NclUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr);
			NclUtilities.NativeFieldInfoPtr__LocalAddresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, "_LocalAddresses");
			NclUtilities.NativeFieldInfoPtr__LocalAddressesLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, "_LocalAddressesLock");
			NclUtilities.NativeFieldInfoPtr__LocalDomainName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, "_LocalDomainName");
			NclUtilities.NativeMethodInfoPtr_IsAddressLocal_Internal_Static_Boolean_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, 100664978);
			NclUtilities.NativeMethodInfoPtr_GetLocalHost_Private_Static_IPHostEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, 100664979);
			NclUtilities.NativeMethodInfoPtr_get_LocalAddresses_Internal_Static_get_Il2CppReferenceArray_1_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, 100664980);
			NclUtilities.NativeMethodInfoPtr_get_LocalAddressesLock_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NclUtilities>.NativeClassPtr, 100664981);
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x0003D45C File Offset: 0x0003B65C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45971, RefRangeEnd = 45972, XrefRangeStart = 45968, XrefRangeEnd = 45971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAddressLocal(IPAddress ipAddress)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ipAddress);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NclUtilities.NativeMethodInfoPtr_IsAddressLocal_Internal_Static_Boolean_IPAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x0003D4A0 File Offset: 0x0003B6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45972, XrefRangeEnd = 45974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPHostEntry GetLocalHost()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NclUtilities.NativeMethodInfoPtr_GetLocalHost_Private_Static_IPHostEntry_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr3) : null;
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000BEB RID: 3051 RVA: 0x0003D4D4 File Offset: 0x0003B6D4
		public unsafe static Il2CppReferenceArray<IPAddress> LocalAddresses
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 46027, RefRangeEnd = 46028, XrefRangeStart = 45974, XrefRangeEnd = 46027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NclUtilities.NativeMethodInfoPtr_get_LocalAddresses_Internal_Static_get_Il2CppReferenceArray_1_IPAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr3) : null;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x0003D508 File Offset: 0x0003B708
		public unsafe static Object LocalAddressesLock
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46028, XrefRangeEnd = 46037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NclUtilities.NativeMethodInfoPtr_get_LocalAddressesLock_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x00006B35 File Offset: 0x00004D35
		public NclUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x0003D53C File Offset: 0x0003B73C
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x00006B3E File Offset: 0x00004D3E
		public unsafe static Il2CppReferenceArray<IPAddress> _LocalAddresses
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NclUtilities.NativeFieldInfoPtr__LocalAddresses, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NclUtilities.NativeFieldInfoPtr__LocalAddresses, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x0003D564 File Offset: 0x0003B764
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x00006B50 File Offset: 0x00004D50
		public unsafe static Object _LocalAddressesLock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NclUtilities.NativeFieldInfoPtr__LocalAddressesLock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NclUtilities.NativeFieldInfoPtr__LocalAddressesLock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x0003D58C File Offset: 0x0003B78C
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x00006B62 File Offset: 0x00004D62
		public unsafe static string _LocalDomainName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NclUtilities.NativeFieldInfoPtr__LocalDomainName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NclUtilities.NativeFieldInfoPtr__LocalDomainName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeFieldInfoPtr__LocalAddresses;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeFieldInfoPtr__LocalAddressesLock;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeFieldInfoPtr__LocalDomainName;

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeMethodInfoPtr_IsAddressLocal_Internal_Static_Boolean_IPAddress_0;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalHost_Private_Static_IPHostEntry_0;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalAddresses_Internal_Static_get_Il2CppReferenceArray_1_IPAddress_0;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalAddressesLock_Private_Static_get_Object_0;
	}
}
