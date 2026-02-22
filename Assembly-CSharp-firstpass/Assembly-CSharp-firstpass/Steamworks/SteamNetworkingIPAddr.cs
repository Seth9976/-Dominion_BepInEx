using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002F3 RID: 755
	[Serializable]
	public sealed class SteamNetworkingIPAddr : ValueType
	{
		// Token: 0x06002B90 RID: 11152 RVA: 0x000BAAC8 File Offset: 0x000B8CC8
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetworkingIPAddr()
		{
			Il2CppClassPointerStore<SteamNetworkingIPAddr>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamNetworkingIPAddr");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworkingIPAddr>.NativeClassPtr);
			SteamNetworkingIPAddr.NativeFieldInfoPtr_m_ipv6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingIPAddr>.NativeClassPtr, "m_ipv6");
			SteamNetworkingIPAddr.NativeFieldInfoPtr_m_port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingIPAddr>.NativeClassPtr, "m_port");
			SteamNetworkingIPAddr.NativeFieldInfoPtr_k_cchMaxString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingIPAddr>.NativeClassPtr, "k_cchMaxString");
			SteamNetworkingIPAddr.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIPAddr>.NativeClassPtr, 100668934);
			SteamNetworkingIPAddr.NativeMethodInfoPtr_IsIPv6AllZeros_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIPAddr>.NativeClassPtr, 100668935);
			SteamNetworkingIPAddr.NativeMethodInfoPtr_SetIPv6_Public_Void_Il2CppStructArray_1_Byte_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIPAddr>.NativeClassPtr, 100668936);
			SteamNetworkingIPAddr.NativeMethodInfoPtr_SetIPv4_Public_Void_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIPAddr>.NativeClassPtr, 100668937);
			SteamNetworkingIPAddr.NativeMethodInfoPtr_IsIPv4_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIPAddr>.NativeClassPtr, 100668938);
			SteamNetworkingIPAddr.NativeMethodInfoPtr_GetIPv4_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIPAddr>.NativeClassPtr, 100668939);
			SteamNetworkingIPAddr.NativeMethodInfoPtr_SetIPv6LocalHost_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIPAddr>.NativeClassPtr, 100668940);
			SteamNetworkingIPAddr.NativeMethodInfoPtr_IsLocalHost_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIPAddr>.NativeClassPtr, 100668941);
			SteamNetworkingIPAddr.NativeMethodInfoPtr_ToString_Public_Void_byref_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIPAddr>.NativeClassPtr, 100668942);
			SteamNetworkingIPAddr.NativeMethodInfoPtr_ParseString_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIPAddr>.NativeClassPtr, 100668943);
			SteamNetworkingIPAddr.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamNetworkingIPAddr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingIPAddr>.NativeClassPtr, 100668944);
		}

		// Token: 0x06002B91 RID: 11153 RVA: 0x000BAC10 File Offset: 0x000B8E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210971, XrefRangeEnd = 210972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIPAddr.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B92 RID: 11154 RVA: 0x000BAC48 File Offset: 0x000B8E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210972, XrefRangeEnd = 210973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsIPv6AllZeros()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIPAddr.NativeMethodInfoPtr_IsIPv6AllZeros_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B93 RID: 11155 RVA: 0x000BAC8C File Offset: 0x000B8E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210973, XrefRangeEnd = 210974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIPv6(Il2CppStructArray<byte> ipv6, ushort nPort)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ipv6);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIPAddr.NativeMethodInfoPtr_SetIPv6_Public_Void_Il2CppStructArray_1_Byte_UInt16_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x000BACE4 File Offset: 0x000B8EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210974, XrefRangeEnd = 210975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIPv4(uint nIP, ushort nPort)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nIP;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIPAddr.NativeMethodInfoPtr_SetIPv4_Public_Void_UInt32_UInt16_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x000BAD38 File Offset: 0x000B8F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210975, XrefRangeEnd = 210976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsIPv4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIPAddr.NativeMethodInfoPtr_IsIPv4_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x000BAD7C File Offset: 0x000B8F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210976, XrefRangeEnd = 210977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetIPv4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIPAddr.NativeMethodInfoPtr_GetIPv4_Public_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B97 RID: 11159 RVA: 0x000BADC0 File Offset: 0x000B8FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210977, XrefRangeEnd = 210978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIPv6LocalHost(ushort nPort = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nPort;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIPAddr.NativeMethodInfoPtr_SetIPv6LocalHost_Public_Void_UInt16_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B98 RID: 11160 RVA: 0x000BAE04 File Offset: 0x000B9004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210978, XrefRangeEnd = 210979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLocalHost()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIPAddr.NativeMethodInfoPtr_IsLocalHost_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B99 RID: 11161 RVA: 0x000BAE48 File Offset: 0x000B9048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210979, XrefRangeEnd = 210986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToString(out string buf, bool bWithPort)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bWithPort;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIPAddr.NativeMethodInfoPtr_ToString_Public_Void_byref_String_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			buf = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x000BAEA4 File Offset: 0x000B90A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210986, XrefRangeEnd = 210995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseString(string pszStr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszStr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIPAddr.NativeMethodInfoPtr_ParseString_Public_Boolean_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x000BAEF8 File Offset: 0x000B90F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210995, XrefRangeEnd = 210996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(SteamNetworkingIPAddr x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingIPAddr.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamNetworkingIPAddr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x000112D8 File Offset: 0x0000F4D8
		public SteamNetworkingIPAddr(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x000112E1 File Offset: 0x0000F4E1
		public SteamNetworkingIPAddr()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamNetworkingIPAddr>.NativeClassPtr))
		{
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06002B9E RID: 11166 RVA: 0x000BAF50 File Offset: 0x000B9150
		// (set) Token: 0x06002B9F RID: 11167 RVA: 0x000112F3 File Offset: 0x0000F4F3
		public unsafe Il2CppStructArray<byte> m_ipv6
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingIPAddr.NativeFieldInfoPtr_m_ipv6);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingIPAddr.NativeFieldInfoPtr_m_ipv6), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06002BA0 RID: 11168 RVA: 0x000BAF80 File Offset: 0x000B9180
		// (set) Token: 0x06002BA1 RID: 11169 RVA: 0x00011312 File Offset: 0x0000F512
		public unsafe ushort m_port
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingIPAddr.NativeFieldInfoPtr_m_port);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingIPAddr.NativeFieldInfoPtr_m_port)) = value;
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06002BA2 RID: 11170 RVA: 0x000BAFA8 File Offset: 0x000B91A8
		// (set) Token: 0x06002BA3 RID: 11171 RVA: 0x0001132D File Offset: 0x0000F52D
		public unsafe static int k_cchMaxString
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamNetworkingIPAddr.NativeFieldInfoPtr_k_cchMaxString, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamNetworkingIPAddr.NativeFieldInfoPtr_k_cchMaxString, (void*)(&value));
			}
		}

		// Token: 0x040029D6 RID: 10710
		private static readonly IntPtr NativeFieldInfoPtr_m_ipv6;

		// Token: 0x040029D7 RID: 10711
		private static readonly IntPtr NativeFieldInfoPtr_m_port;

		// Token: 0x040029D8 RID: 10712
		private static readonly IntPtr NativeFieldInfoPtr_k_cchMaxString;

		// Token: 0x040029D9 RID: 10713
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040029DA RID: 10714
		private static readonly IntPtr NativeMethodInfoPtr_IsIPv6AllZeros_Public_Boolean_0;

		// Token: 0x040029DB RID: 10715
		private static readonly IntPtr NativeMethodInfoPtr_SetIPv6_Public_Void_Il2CppStructArray_1_Byte_UInt16_0;

		// Token: 0x040029DC RID: 10716
		private static readonly IntPtr NativeMethodInfoPtr_SetIPv4_Public_Void_UInt32_UInt16_0;

		// Token: 0x040029DD RID: 10717
		private static readonly IntPtr NativeMethodInfoPtr_IsIPv4_Public_Boolean_0;

		// Token: 0x040029DE RID: 10718
		private static readonly IntPtr NativeMethodInfoPtr_GetIPv4_Public_UInt32_0;

		// Token: 0x040029DF RID: 10719
		private static readonly IntPtr NativeMethodInfoPtr_SetIPv6LocalHost_Public_Void_UInt16_0;

		// Token: 0x040029E0 RID: 10720
		private static readonly IntPtr NativeMethodInfoPtr_IsLocalHost_Public_Boolean_0;

		// Token: 0x040029E1 RID: 10721
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Void_byref_String_Boolean_0;

		// Token: 0x040029E2 RID: 10722
		private static readonly IntPtr NativeMethodInfoPtr_ParseString_Public_Boolean_String_0;

		// Token: 0x040029E3 RID: 10723
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamNetworkingIPAddr_0;
	}
}
