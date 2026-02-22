using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x02000143 RID: 323
	public sealed class Win32_FIXED_INFO : ValueType
	{
		// Token: 0x06001507 RID: 5383 RVA: 0x0005FA9C File Offset: 0x0005DC9C
		// Note: this type is marked as 'beforefieldinit'.
		static Win32_FIXED_INFO()
		{
			Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32_FIXED_INFO");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr);
			Win32_FIXED_INFO.NativeFieldInfoPtr_HostName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "HostName");
			Win32_FIXED_INFO.NativeFieldInfoPtr_DomainName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "DomainName");
			Win32_FIXED_INFO.NativeFieldInfoPtr_CurrentDnsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "CurrentDnsServer");
			Win32_FIXED_INFO.NativeFieldInfoPtr_DnsServerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "DnsServerList");
			Win32_FIXED_INFO.NativeFieldInfoPtr_NodeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "NodeType");
			Win32_FIXED_INFO.NativeFieldInfoPtr_ScopeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "ScopeId");
			Win32_FIXED_INFO.NativeFieldInfoPtr_EnableRouting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "EnableRouting");
			Win32_FIXED_INFO.NativeFieldInfoPtr_EnableProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "EnableProxy");
			Win32_FIXED_INFO.NativeFieldInfoPtr_EnableDns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, "EnableDns");
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x0000A90E File Offset: 0x00008B0E
		public Win32_FIXED_INFO(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x0000A917 File Offset: 0x00008B17
		public Win32_FIXED_INFO()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr))
		{
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x0005FB80 File Offset: 0x0005DD80
		// (set) Token: 0x0600150B RID: 5387 RVA: 0x0000A929 File Offset: 0x00008B29
		public unsafe string HostName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_HostName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_HostName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x0600150C RID: 5388 RVA: 0x0005FBA8 File Offset: 0x0005DDA8
		// (set) Token: 0x0600150D RID: 5389 RVA: 0x0000A948 File Offset: 0x00008B48
		public unsafe string DomainName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_DomainName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_DomainName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x0600150E RID: 5390 RVA: 0x0005FBD0 File Offset: 0x0005DDD0
		// (set) Token: 0x0600150F RID: 5391 RVA: 0x0000A967 File Offset: 0x00008B67
		public unsafe IntPtr CurrentDnsServer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_CurrentDnsServer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_CurrentDnsServer)) = value;
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06001510 RID: 5392 RVA: 0x0005FBF8 File Offset: 0x0005DDF8
		// (set) Token: 0x06001511 RID: 5393 RVA: 0x0000A982 File Offset: 0x00008B82
		public Win32_IP_ADDR_STRING DnsServerList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_DnsServerList);
				return new Win32_IP_ADDR_STRING(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_DnsServerList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x0005FC28 File Offset: 0x0005DE28
		// (set) Token: 0x06001513 RID: 5395 RVA: 0x0000A9B0 File Offset: 0x00008BB0
		public unsafe NetBiosNodeType NodeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_NodeType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_NodeType)) = value;
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06001514 RID: 5396 RVA: 0x0005FC50 File Offset: 0x0005DE50
		// (set) Token: 0x06001515 RID: 5397 RVA: 0x0000A9CB File Offset: 0x00008BCB
		public unsafe string ScopeId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_ScopeId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_ScopeId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x0005FC78 File Offset: 0x0005DE78
		// (set) Token: 0x06001517 RID: 5399 RVA: 0x0000A9EA File Offset: 0x00008BEA
		public unsafe uint EnableRouting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_EnableRouting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_EnableRouting)) = value;
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06001518 RID: 5400 RVA: 0x0005FCA0 File Offset: 0x0005DEA0
		// (set) Token: 0x06001519 RID: 5401 RVA: 0x0000AA05 File Offset: 0x00008C05
		public unsafe uint EnableProxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_EnableProxy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_EnableProxy)) = value;
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x0600151A RID: 5402 RVA: 0x0005FCC8 File Offset: 0x0005DEC8
		// (set) Token: 0x0600151B RID: 5403 RVA: 0x0000AA20 File Offset: 0x00008C20
		public unsafe uint EnableDns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_EnableDns);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_FIXED_INFO.NativeFieldInfoPtr_EnableDns)) = value;
			}
		}

		// Token: 0x040010F9 RID: 4345
		private static readonly IntPtr NativeFieldInfoPtr_HostName;

		// Token: 0x040010FA RID: 4346
		private static readonly IntPtr NativeFieldInfoPtr_DomainName;

		// Token: 0x040010FB RID: 4347
		private static readonly IntPtr NativeFieldInfoPtr_CurrentDnsServer;

		// Token: 0x040010FC RID: 4348
		private static readonly IntPtr NativeFieldInfoPtr_DnsServerList;

		// Token: 0x040010FD RID: 4349
		private static readonly IntPtr NativeFieldInfoPtr_NodeType;

		// Token: 0x040010FE RID: 4350
		private static readonly IntPtr NativeFieldInfoPtr_ScopeId;

		// Token: 0x040010FF RID: 4351
		private static readonly IntPtr NativeFieldInfoPtr_EnableRouting;

		// Token: 0x04001100 RID: 4352
		private static readonly IntPtr NativeFieldInfoPtr_EnableProxy;

		// Token: 0x04001101 RID: 4353
		private static readonly IntPtr NativeFieldInfoPtr_EnableDns;
	}
}
