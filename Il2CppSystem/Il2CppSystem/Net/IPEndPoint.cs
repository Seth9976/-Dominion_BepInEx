using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Sockets;

namespace Il2CppSystem.Net
{
	// Token: 0x020000C9 RID: 201
	[Serializable]
	public class IPEndPoint : EndPoint
	{
		// Token: 0x06000BBF RID: 3007 RVA: 0x0003CB58 File Offset: 0x0003AD58
		// Note: this type is marked as 'beforefieldinit'.
		static IPEndPoint()
		{
			Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "IPEndPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr);
			IPEndPoint.NativeFieldInfoPtr_m_Address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, "m_Address");
			IPEndPoint.NativeFieldInfoPtr_m_Port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, "m_Port");
			IPEndPoint.NativeFieldInfoPtr_Any = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, "Any");
			IPEndPoint.NativeFieldInfoPtr_IPv6Any = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, "IPv6Any");
			IPEndPoint.NativeMethodInfoPtr_get_AddressFamily_Public_Virtual_get_AddressFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100664960);
			IPEndPoint.NativeMethodInfoPtr__ctor_Public_Void_IPAddress_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100664961);
			IPEndPoint.NativeMethodInfoPtr_get_Address_Public_get_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100664962);
			IPEndPoint.NativeMethodInfoPtr_get_Port_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100664963);
			IPEndPoint.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100664964);
			IPEndPoint.NativeMethodInfoPtr_Serialize_Public_Virtual_SocketAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100664965);
			IPEndPoint.NativeMethodInfoPtr_Create_Public_Virtual_EndPoint_SocketAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100664966);
			IPEndPoint.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100664967);
			IPEndPoint.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr, 100664968);
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x0003CC8C File Offset: 0x0003AE8C
		public unsafe override AddressFamily AddressFamily
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPEndPoint.NativeMethodInfoPtr_get_AddressFamily_Public_Virtual_get_AddressFamily_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x0003CCD4 File Offset: 0x0003AED4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 45941, RefRangeEnd = 45947, XrefRangeStart = 45936, XrefRangeEnd = 45941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPEndPoint(IPAddress address, int port)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPEndPoint>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPEndPoint.NativeMethodInfoPtr__ctor_Public_Void_IPAddress_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x0003CD30 File Offset: 0x0003AF30
		public unsafe IPAddress Address
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPEndPoint.NativeMethodInfoPtr_get_Address_Public_get_IPAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr3) : null;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x0003CD70 File Offset: 0x0003AF70
		public unsafe int Port
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPEndPoint.NativeMethodInfoPtr_get_Port_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x0003CDAC File Offset: 0x0003AFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45947, XrefRangeEnd = 45954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPEndPoint.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0003CDF0 File Offset: 0x0003AFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45954, XrefRangeEnd = 45958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SocketAddress Serialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPEndPoint.NativeMethodInfoPtr_Serialize_Public_Virtual_SocketAddress_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SocketAddress>(intPtr3) : null;
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0003CE3C File Offset: 0x0003B03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45958, XrefRangeEnd = 45960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EndPoint Create(SocketAddress socketAddress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(socketAddress);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPEndPoint.NativeMethodInfoPtr_Create_Public_Virtual_EndPoint_SocketAddress_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EndPoint>(intPtr3) : null;
			}
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0003CE98 File Offset: 0x0003B098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45960, XrefRangeEnd = 45963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object comparand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparand);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPEndPoint.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x0003CEF0 File Offset: 0x0003B0F0
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPEndPoint.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x000069D3 File Offset: 0x00004BD3
		public IPEndPoint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x0003CF38 File Offset: 0x0003B138
		// (set) Token: 0x06000BCB RID: 3019 RVA: 0x000069DC File Offset: 0x00004BDC
		public unsafe IPAddress m_Address
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPEndPoint.NativeFieldInfoPtr_m_Address);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPEndPoint.NativeFieldInfoPtr_m_Address), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x0003CF68 File Offset: 0x0003B168
		// (set) Token: 0x06000BCD RID: 3021 RVA: 0x000069FB File Offset: 0x00004BFB
		public unsafe int m_Port
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPEndPoint.NativeFieldInfoPtr_m_Port);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPEndPoint.NativeFieldInfoPtr_m_Port)) = value;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x0003CF90 File Offset: 0x0003B190
		// (set) Token: 0x06000BCF RID: 3023 RVA: 0x00006A16 File Offset: 0x00004C16
		public unsafe static IPEndPoint Any
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPEndPoint.NativeFieldInfoPtr_Any, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPEndPoint.NativeFieldInfoPtr_Any, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x0003CFB8 File Offset: 0x0003B1B8
		// (set) Token: 0x06000BD1 RID: 3025 RVA: 0x00006A28 File Offset: 0x00004C28
		public unsafe static IPEndPoint IPv6Any
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IPEndPoint.NativeFieldInfoPtr_IPv6Any, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPEndPoint.NativeFieldInfoPtr_IPv6Any, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeFieldInfoPtr_m_Address;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeFieldInfoPtr_m_Port;

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeFieldInfoPtr_Any;

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeFieldInfoPtr_IPv6Any;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeMethodInfoPtr_get_AddressFamily_Public_Virtual_get_AddressFamily_0;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IPAddress_Int32_0;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeMethodInfoPtr_get_Address_Public_get_IPAddress_0;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeMethodInfoPtr_get_Port_Public_get_Int32_0;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_SocketAddress_0;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_EndPoint_SocketAddress_0;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
