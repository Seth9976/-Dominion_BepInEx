using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Sockets;

namespace Il2CppSystem.Net
{
	// Token: 0x020000D4 RID: 212
	public class SocketAddress : Object
	{
		// Token: 0x06000C32 RID: 3122 RVA: 0x0003E358 File Offset: 0x0003C558
		// Note: this type is marked as 'beforefieldinit'.
		static SocketAddress()
		{
			Il2CppClassPointerStore<SocketAddress>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "SocketAddress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr);
			SocketAddress.NativeFieldInfoPtr_m_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, "m_Size");
			SocketAddress.NativeFieldInfoPtr_m_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, "m_Buffer");
			SocketAddress.NativeFieldInfoPtr_m_changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, "m_changed");
			SocketAddress.NativeFieldInfoPtr_m_hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, "m_hash");
			SocketAddress.NativeMethodInfoPtr_get_Family_Public_get_AddressFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, 100665012);
			SocketAddress.NativeMethodInfoPtr_get_Size_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, 100665013);
			SocketAddress.NativeMethodInfoPtr_get_Item_Public_get_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, 100665014);
			SocketAddress.NativeMethodInfoPtr__ctor_Public_Void_AddressFamily_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, 100665015);
			SocketAddress.NativeMethodInfoPtr__ctor_Internal_Void_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, 100665016);
			SocketAddress.NativeMethodInfoPtr__ctor_Internal_Void_IPAddress_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, 100665017);
			SocketAddress.NativeMethodInfoPtr_GetIPAddress_Internal_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, 100665018);
			SocketAddress.NativeMethodInfoPtr_GetIPEndPoint_Internal_IPEndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, 100665019);
			SocketAddress.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, 100665020);
			SocketAddress.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, 100665021);
			SocketAddress.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr, 100665022);
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x0003E4B4 File Offset: 0x0003C6B4
		public unsafe AddressFamily Family
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 46387, RefRangeEnd = 46388, XrefRangeStart = 46387, XrefRangeEnd = 46387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAddress.NativeMethodInfoPtr_get_Family_Public_get_AddressFamily_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x0003E4F0 File Offset: 0x0003C6F0
		public unsafe int Size
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAddress.NativeMethodInfoPtr_get_Size_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003A4 RID: 932
		public unsafe byte this[int offset]
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 46388, RefRangeEnd = 46390, XrefRangeStart = 46388, XrefRangeEnd = 46388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref offset;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAddress.NativeMethodInfoPtr_get_Item_Public_get_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x0003E578 File Offset: 0x0003C778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46390, XrefRangeEnd = 46396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketAddress(AddressFamily family, int size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref family;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAddress.NativeMethodInfoPtr__ctor_Public_Void_AddressFamily_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x0003E5D0 File Offset: 0x0003C7D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46402, RefRangeEnd = 46403, XrefRangeStart = 46396, XrefRangeEnd = 46402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketAddress(IPAddress ipAddress)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ipAddress);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAddress.NativeMethodInfoPtr__ctor_Internal_Void_IPAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x0003E61C File Offset: 0x0003C81C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46404, RefRangeEnd = 46405, XrefRangeStart = 46403, XrefRangeEnd = 46404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketAddress(IPAddress ipaddress, int port)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketAddress>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ipaddress);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAddress.NativeMethodInfoPtr__ctor_Internal_Void_IPAddress_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0003E678 File Offset: 0x0003C878
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46410, RefRangeEnd = 46411, XrefRangeStart = 46405, XrefRangeEnd = 46410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPAddress GetIPAddress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAddress.NativeMethodInfoPtr_GetIPAddress_Internal_IPAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr3) : null;
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0003E6B8 File Offset: 0x0003C8B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46416, RefRangeEnd = 46417, XrefRangeStart = 46411, XrefRangeEnd = 46416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPEndPoint GetIPEndPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAddress.NativeMethodInfoPtr_GetIPEndPoint_Internal_IPEndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr3) : null;
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0003E6F8 File Offset: 0x0003C8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46417, XrefRangeEnd = 46421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object comparand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparand);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SocketAddress.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x0003E750 File Offset: 0x0003C950
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SocketAddress.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x0003E798 File Offset: 0x0003C998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46421, XrefRangeEnd = 46457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SocketAddress.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00006CC1 File Offset: 0x00004EC1
		public SocketAddress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x0003E7DC File Offset: 0x0003C9DC
		// (set) Token: 0x06000C40 RID: 3136 RVA: 0x00006CCA File Offset: 0x00004ECA
		public unsafe int m_Size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAddress.NativeFieldInfoPtr_m_Size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAddress.NativeFieldInfoPtr_m_Size)) = value;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x0003E804 File Offset: 0x0003CA04
		// (set) Token: 0x06000C42 RID: 3138 RVA: 0x00006CE5 File Offset: 0x00004EE5
		public unsafe Il2CppStructArray<byte> m_Buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAddress.NativeFieldInfoPtr_m_Buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAddress.NativeFieldInfoPtr_m_Buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x0003E834 File Offset: 0x0003CA34
		// (set) Token: 0x06000C44 RID: 3140 RVA: 0x00006D04 File Offset: 0x00004F04
		public unsafe bool m_changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAddress.NativeFieldInfoPtr_m_changed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAddress.NativeFieldInfoPtr_m_changed)) = value;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x0003E85C File Offset: 0x0003CA5C
		// (set) Token: 0x06000C46 RID: 3142 RVA: 0x00006D1F File Offset: 0x00004F1F
		public unsafe int m_hash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAddress.NativeFieldInfoPtr_m_hash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAddress.NativeFieldInfoPtr_m_hash)) = value;
			}
		}

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeFieldInfoPtr_m_Size;

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeFieldInfoPtr_m_Buffer;

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeFieldInfoPtr_m_changed;

		// Token: 0x0400099B RID: 2459
		private static readonly IntPtr NativeFieldInfoPtr_m_hash;

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeMethodInfoPtr_get_Family_Public_get_AddressFamily_0;

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeMethodInfoPtr_get_Size_Public_get_Int32_0;

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Byte_Int32_0;

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AddressFamily_Int32_0;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IPAddress_0;

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IPAddress_Int32_0;

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeMethodInfoPtr_GetIPAddress_Internal_IPAddress_0;

		// Token: 0x040009A3 RID: 2467
		private static readonly IntPtr NativeMethodInfoPtr_GetIPEndPoint_Internal_IPEndPoint_0;

		// Token: 0x040009A4 RID: 2468
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040009A5 RID: 2469
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
