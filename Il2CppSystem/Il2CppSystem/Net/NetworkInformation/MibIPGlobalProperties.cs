using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x02000140 RID: 320
	public class MibIPGlobalProperties : UnixIPGlobalProperties
	{
		// Token: 0x060014EA RID: 5354 RVA: 0x0005F640 File Offset: 0x0005D840
		// Note: this type is marked as 'beforefieldinit'.
		static MibIPGlobalProperties()
		{
			Il2CppClassPointerStore<MibIPGlobalProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "MibIPGlobalProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MibIPGlobalProperties>.NativeClassPtr);
			MibIPGlobalProperties.NativeFieldInfoPtr_StatisticsFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MibIPGlobalProperties>.NativeClassPtr, "StatisticsFile");
			MibIPGlobalProperties.NativeFieldInfoPtr_StatisticsFileIPv6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MibIPGlobalProperties>.NativeClassPtr, "StatisticsFileIPv6");
			MibIPGlobalProperties.NativeFieldInfoPtr_TcpFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MibIPGlobalProperties>.NativeClassPtr, "TcpFile");
			MibIPGlobalProperties.NativeFieldInfoPtr_Tcp6File = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MibIPGlobalProperties>.NativeClassPtr, "Tcp6File");
			MibIPGlobalProperties.NativeFieldInfoPtr_UdpFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MibIPGlobalProperties>.NativeClassPtr, "UdpFile");
			MibIPGlobalProperties.NativeFieldInfoPtr_Udp6File = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MibIPGlobalProperties>.NativeClassPtr, "Udp6File");
			MibIPGlobalProperties.NativeFieldInfoPtr_wsChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MibIPGlobalProperties>.NativeClassPtr, "wsChars");
			MibIPGlobalProperties.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MibIPGlobalProperties>.NativeClassPtr, 100666236);
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x0005F710 File Offset: 0x0005D910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57490, XrefRangeEnd = 57512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MibIPGlobalProperties(string procDir)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MibIPGlobalProperties>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(procDir);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MibIPGlobalProperties.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x0000A802 File Offset: 0x00008A02
		public MibIPGlobalProperties(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x0005F75C File Offset: 0x0005D95C
		// (set) Token: 0x060014EE RID: 5358 RVA: 0x0000A80B File Offset: 0x00008A0B
		public unsafe string StatisticsFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MibIPGlobalProperties.NativeFieldInfoPtr_StatisticsFile);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MibIPGlobalProperties.NativeFieldInfoPtr_StatisticsFile), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x0005F784 File Offset: 0x0005D984
		// (set) Token: 0x060014F0 RID: 5360 RVA: 0x0000A82A File Offset: 0x00008A2A
		public unsafe string StatisticsFileIPv6
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MibIPGlobalProperties.NativeFieldInfoPtr_StatisticsFileIPv6);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MibIPGlobalProperties.NativeFieldInfoPtr_StatisticsFileIPv6), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060014F1 RID: 5361 RVA: 0x0005F7AC File Offset: 0x0005D9AC
		// (set) Token: 0x060014F2 RID: 5362 RVA: 0x0000A849 File Offset: 0x00008A49
		public unsafe string TcpFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MibIPGlobalProperties.NativeFieldInfoPtr_TcpFile);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MibIPGlobalProperties.NativeFieldInfoPtr_TcpFile), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060014F3 RID: 5363 RVA: 0x0005F7D4 File Offset: 0x0005D9D4
		// (set) Token: 0x060014F4 RID: 5364 RVA: 0x0000A868 File Offset: 0x00008A68
		public unsafe string Tcp6File
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MibIPGlobalProperties.NativeFieldInfoPtr_Tcp6File);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MibIPGlobalProperties.NativeFieldInfoPtr_Tcp6File), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x0005F7FC File Offset: 0x0005D9FC
		// (set) Token: 0x060014F6 RID: 5366 RVA: 0x0000A887 File Offset: 0x00008A87
		public unsafe string UdpFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MibIPGlobalProperties.NativeFieldInfoPtr_UdpFile);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MibIPGlobalProperties.NativeFieldInfoPtr_UdpFile), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060014F7 RID: 5367 RVA: 0x0005F824 File Offset: 0x0005DA24
		// (set) Token: 0x060014F8 RID: 5368 RVA: 0x0000A8A6 File Offset: 0x00008AA6
		public unsafe string Udp6File
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MibIPGlobalProperties.NativeFieldInfoPtr_Udp6File);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MibIPGlobalProperties.NativeFieldInfoPtr_Udp6File), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x0005F84C File Offset: 0x0005DA4C
		// (set) Token: 0x060014FA RID: 5370 RVA: 0x0000A8C5 File Offset: 0x00008AC5
		public unsafe static Il2CppStructArray<char> wsChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MibIPGlobalProperties.NativeFieldInfoPtr_wsChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MibIPGlobalProperties.NativeFieldInfoPtr_wsChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010EB RID: 4331
		private static readonly IntPtr NativeFieldInfoPtr_StatisticsFile;

		// Token: 0x040010EC RID: 4332
		private static readonly IntPtr NativeFieldInfoPtr_StatisticsFileIPv6;

		// Token: 0x040010ED RID: 4333
		private static readonly IntPtr NativeFieldInfoPtr_TcpFile;

		// Token: 0x040010EE RID: 4334
		private static readonly IntPtr NativeFieldInfoPtr_Tcp6File;

		// Token: 0x040010EF RID: 4335
		private static readonly IntPtr NativeFieldInfoPtr_UdpFile;

		// Token: 0x040010F0 RID: 4336
		private static readonly IntPtr NativeFieldInfoPtr_Udp6File;

		// Token: 0x040010F1 RID: 4337
		private static readonly IntPtr NativeFieldInfoPtr_wsChars;

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
