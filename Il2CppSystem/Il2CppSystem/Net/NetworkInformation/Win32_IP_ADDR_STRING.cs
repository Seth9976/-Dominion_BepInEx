using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x02000144 RID: 324
	public sealed class Win32_IP_ADDR_STRING : ValueType
	{
		// Token: 0x0600151C RID: 5404 RVA: 0x0005FCF0 File Offset: 0x0005DEF0
		// Note: this type is marked as 'beforefieldinit'.
		static Win32_IP_ADDR_STRING()
		{
			Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32_IP_ADDR_STRING");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr);
			Win32_IP_ADDR_STRING.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, "Next");
			Win32_IP_ADDR_STRING.NativeFieldInfoPtr_IpAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, "IpAddress");
			Win32_IP_ADDR_STRING.NativeFieldInfoPtr_IpMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, "IpMask");
			Win32_IP_ADDR_STRING.NativeFieldInfoPtr_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, "Context");
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x0000AA3B File Offset: 0x00008C3B
		public Win32_IP_ADDR_STRING(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x0000AA44 File Offset: 0x00008C44
		public Win32_IP_ADDR_STRING()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr))
		{
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x0600151F RID: 5407 RVA: 0x0005FD70 File Offset: 0x0005DF70
		// (set) Token: 0x06001520 RID: 5408 RVA: 0x0000AA56 File Offset: 0x00008C56
		public unsafe IntPtr Next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_IP_ADDR_STRING.NativeFieldInfoPtr_Next);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_IP_ADDR_STRING.NativeFieldInfoPtr_Next)) = value;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x0005FD98 File Offset: 0x0005DF98
		// (set) Token: 0x06001522 RID: 5410 RVA: 0x0000AA71 File Offset: 0x00008C71
		public unsafe string IpAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_IP_ADDR_STRING.NativeFieldInfoPtr_IpAddress);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_IP_ADDR_STRING.NativeFieldInfoPtr_IpAddress), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06001523 RID: 5411 RVA: 0x0005FDC0 File Offset: 0x0005DFC0
		// (set) Token: 0x06001524 RID: 5412 RVA: 0x0000AA90 File Offset: 0x00008C90
		public unsafe string IpMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_IP_ADDR_STRING.NativeFieldInfoPtr_IpMask);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_IP_ADDR_STRING.NativeFieldInfoPtr_IpMask), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06001525 RID: 5413 RVA: 0x0005FDE8 File Offset: 0x0005DFE8
		// (set) Token: 0x06001526 RID: 5414 RVA: 0x0000AAAF File Offset: 0x00008CAF
		public unsafe uint Context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_IP_ADDR_STRING.NativeFieldInfoPtr_Context);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_IP_ADDR_STRING.NativeFieldInfoPtr_Context)) = value;
			}
		}

		// Token: 0x04001102 RID: 4354
		private static readonly IntPtr NativeFieldInfoPtr_Next;

		// Token: 0x04001103 RID: 4355
		private static readonly IntPtr NativeFieldInfoPtr_IpAddress;

		// Token: 0x04001104 RID: 4356
		private static readonly IntPtr NativeFieldInfoPtr_IpMask;

		// Token: 0x04001105 RID: 4357
		private static readonly IntPtr NativeFieldInfoPtr_Context;
	}
}
