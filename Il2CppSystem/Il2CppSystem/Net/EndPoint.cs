using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Sockets;

namespace Il2CppSystem.Net
{
	// Token: 0x020000BF RID: 191
	[Serializable]
	public class EndPoint : Object
	{
		// Token: 0x06000B6F RID: 2927 RVA: 0x0003BB4C File Offset: 0x00039D4C
		// Note: this type is marked as 'beforefieldinit'.
		static EndPoint()
		{
			Il2CppClassPointerStore<EndPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "EndPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndPoint>.NativeClassPtr);
			EndPoint.NativeMethodInfoPtr_get_AddressFamily_Public_Virtual_New_get_AddressFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPoint>.NativeClassPtr, 100664930);
			EndPoint.NativeMethodInfoPtr_Serialize_Public_Virtual_New_SocketAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPoint>.NativeClassPtr, 100664931);
			EndPoint.NativeMethodInfoPtr_Create_Public_Virtual_New_EndPoint_SocketAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPoint>.NativeClassPtr, 100664932);
			EndPoint.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPoint>.NativeClassPtr, 100664933);
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x0003BBCC File Offset: 0x00039DCC
		public unsafe virtual AddressFamily AddressFamily
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45838, XrefRangeEnd = 45841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EndPoint.NativeMethodInfoPtr_get_AddressFamily_Public_Virtual_New_get_AddressFamily_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0003BC14 File Offset: 0x00039E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45841, XrefRangeEnd = 45844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SocketAddress Serialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EndPoint.NativeMethodInfoPtr_Serialize_Public_Virtual_New_SocketAddress_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SocketAddress>(intPtr3) : null;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0003BC60 File Offset: 0x00039E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45844, XrefRangeEnd = 45847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EndPoint Create(SocketAddress socketAddress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(socketAddress);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EndPoint.NativeMethodInfoPtr_Create_Public_Virtual_New_EndPoint_SocketAddress_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EndPoint>(intPtr3) : null;
			}
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0003BCBC File Offset: 0x00039EBC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EndPoint()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndPoint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndPoint.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x000067B2 File Offset: 0x000049B2
		public EndPoint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr_get_AddressFamily_Public_Virtual_New_get_AddressFamily_0;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_New_SocketAddress_0;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_New_EndPoint_SocketAddress_0;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
