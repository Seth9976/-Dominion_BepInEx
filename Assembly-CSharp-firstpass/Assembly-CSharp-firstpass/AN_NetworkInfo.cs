using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x020000E1 RID: 225
public class AN_NetworkInfo : Object
{
	// Token: 0x06001012 RID: 4114 RVA: 0x0004FC94 File Offset: 0x0004DE94
	// Note: this type is marked as 'beforefieldinit'.
	static AN_NetworkInfo()
	{
		Il2CppClassPointerStore<AN_NetworkInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_NetworkInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_NetworkInfo>.NativeClassPtr);
		AN_NetworkInfo.NativeFieldInfoPtr_IpAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_NetworkInfo>.NativeClassPtr, "IpAddress");
		AN_NetworkInfo.NativeFieldInfoPtr_MacAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_NetworkInfo>.NativeClassPtr, "MacAddress");
		AN_NetworkInfo.NativeFieldInfoPtr_SubnetMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_NetworkInfo>.NativeClassPtr, "SubnetMask");
		AN_NetworkInfo.NativeFieldInfoPtr_SSID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_NetworkInfo>.NativeClassPtr, "SSID");
		AN_NetworkInfo.NativeFieldInfoPtr_BSSID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_NetworkInfo>.NativeClassPtr, "BSSID");
		AN_NetworkInfo.NativeFieldInfoPtr_LinkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_NetworkInfo>.NativeClassPtr, "LinkSpeed");
		AN_NetworkInfo.NativeFieldInfoPtr_NetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_NetworkInfo>.NativeClassPtr, "NetworkId");
		AN_NetworkInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_NetworkInfo>.NativeClassPtr, 100665301);
	}

	// Token: 0x06001013 RID: 4115 RVA: 0x0004FD64 File Offset: 0x0004DF64
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_NetworkInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_NetworkInfo>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_NetworkInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001014 RID: 4116 RVA: 0x00008039 File Offset: 0x00006239
	public AN_NetworkInfo(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004A9 RID: 1193
	// (get) Token: 0x06001015 RID: 4117 RVA: 0x0004FDA0 File Offset: 0x0004DFA0
	// (set) Token: 0x06001016 RID: 4118 RVA: 0x00008042 File Offset: 0x00006242
	public unsafe string IpAddress
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_NetworkInfo.NativeFieldInfoPtr_IpAddress);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_NetworkInfo.NativeFieldInfoPtr_IpAddress), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004AA RID: 1194
	// (get) Token: 0x06001017 RID: 4119 RVA: 0x0004FDC8 File Offset: 0x0004DFC8
	// (set) Token: 0x06001018 RID: 4120 RVA: 0x00008061 File Offset: 0x00006261
	public unsafe string MacAddress
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_NetworkInfo.NativeFieldInfoPtr_MacAddress);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_NetworkInfo.NativeFieldInfoPtr_MacAddress), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004AB RID: 1195
	// (get) Token: 0x06001019 RID: 4121 RVA: 0x0004FDF0 File Offset: 0x0004DFF0
	// (set) Token: 0x0600101A RID: 4122 RVA: 0x00008080 File Offset: 0x00006280
	public unsafe string SubnetMask
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_NetworkInfo.NativeFieldInfoPtr_SubnetMask);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_NetworkInfo.NativeFieldInfoPtr_SubnetMask), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004AC RID: 1196
	// (get) Token: 0x0600101B RID: 4123 RVA: 0x0004FE18 File Offset: 0x0004E018
	// (set) Token: 0x0600101C RID: 4124 RVA: 0x0000809F File Offset: 0x0000629F
	public unsafe string SSID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_NetworkInfo.NativeFieldInfoPtr_SSID);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_NetworkInfo.NativeFieldInfoPtr_SSID), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004AD RID: 1197
	// (get) Token: 0x0600101D RID: 4125 RVA: 0x0004FE40 File Offset: 0x0004E040
	// (set) Token: 0x0600101E RID: 4126 RVA: 0x000080BE File Offset: 0x000062BE
	public unsafe string BSSID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_NetworkInfo.NativeFieldInfoPtr_BSSID);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_NetworkInfo.NativeFieldInfoPtr_BSSID), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004AE RID: 1198
	// (get) Token: 0x0600101F RID: 4127 RVA: 0x0004FE68 File Offset: 0x0004E068
	// (set) Token: 0x06001020 RID: 4128 RVA: 0x000080DD File Offset: 0x000062DD
	public unsafe int LinkSpeed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_NetworkInfo.NativeFieldInfoPtr_LinkSpeed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_NetworkInfo.NativeFieldInfoPtr_LinkSpeed)) = value;
		}
	}

	// Token: 0x170004AF RID: 1199
	// (get) Token: 0x06001021 RID: 4129 RVA: 0x0004FE90 File Offset: 0x0004E090
	// (set) Token: 0x06001022 RID: 4130 RVA: 0x000080F8 File Offset: 0x000062F8
	public unsafe int NetworkId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_NetworkInfo.NativeFieldInfoPtr_NetworkId);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_NetworkInfo.NativeFieldInfoPtr_NetworkId)) = value;
		}
	}

	// Token: 0x04000CB3 RID: 3251
	private static readonly IntPtr NativeFieldInfoPtr_IpAddress;

	// Token: 0x04000CB4 RID: 3252
	private static readonly IntPtr NativeFieldInfoPtr_MacAddress;

	// Token: 0x04000CB5 RID: 3253
	private static readonly IntPtr NativeFieldInfoPtr_SubnetMask;

	// Token: 0x04000CB6 RID: 3254
	private static readonly IntPtr NativeFieldInfoPtr_SSID;

	// Token: 0x04000CB7 RID: 3255
	private static readonly IntPtr NativeFieldInfoPtr_BSSID;

	// Token: 0x04000CB8 RID: 3256
	private static readonly IntPtr NativeFieldInfoPtr_LinkSpeed;

	// Token: 0x04000CB9 RID: 3257
	private static readonly IntPtr NativeFieldInfoPtr_NetworkId;

	// Token: 0x04000CBA RID: 3258
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
