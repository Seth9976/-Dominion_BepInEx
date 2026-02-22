using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.ComponentModel;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x0200011E RID: 286
	[Serializable]
	public class SocketException : Win32Exception
	{
		// Token: 0x0600133B RID: 4923 RVA: 0x000584A8 File Offset: 0x000566A8
		// Note: this type is marked as 'beforefieldinit'.
		static SocketException()
		{
			Il2CppClassPointerStore<SocketException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "SocketException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketException>.NativeClassPtr);
			SocketException.NativeFieldInfoPtr_m_EndPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketException>.NativeClassPtr, "m_EndPoint");
			SocketException.NativeMethodInfoPtr_WSAGetLastError_internal_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketException>.NativeClassPtr, 100665984);
			SocketException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketException>.NativeClassPtr, 100665985);
			SocketException.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketException>.NativeClassPtr, 100665986);
			SocketException.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketException>.NativeClassPtr, 100665987);
			SocketException.NativeMethodInfoPtr__ctor_Internal_Void_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketException>.NativeClassPtr, 100665988);
			SocketException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketException>.NativeClassPtr, 100665989);
			SocketException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketException>.NativeClassPtr, 100665990);
			SocketException.NativeMethodInfoPtr_get_SocketErrorCode_Public_get_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketException>.NativeClassPtr, 100665991);
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x0005858C File Offset: 0x0005678C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55641, XrefRangeEnd = 55642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WSAGetLastError_internal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketException.NativeMethodInfoPtr_WSAGetLastError_internal_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x000585BC File Offset: 0x000567BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55642, XrefRangeEnd = 55647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x000585F8 File Offset: 0x000567F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 55651, RefRangeEnd = 55652, XrefRangeStart = 55647, XrefRangeEnd = 55651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketException(int error, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketException.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x00058654 File Offset: 0x00056854
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 55656, RefRangeEnd = 55659, XrefRangeStart = 55652, XrefRangeEnd = 55656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketException(int errorCode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketException.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x0005869C File Offset: 0x0005689C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55659, XrefRangeEnd = 55663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketException(SocketError socketError)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socketError;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketException.NativeMethodInfoPtr__ctor_Internal_Void_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x000586E4 File Offset: 0x000568E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55663, XrefRangeEnd = 55667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001342 RID: 4930 RVA: 0x00058748 File Offset: 0x00056948
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55667, XrefRangeEnd = 55673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SocketException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001343 RID: 4931 RVA: 0x0005878C File Offset: 0x0005698C
		public unsafe SocketError SocketErrorCode
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 41028, RefRangeEnd = 41035, XrefRangeStart = 41028, XrefRangeEnd = 41035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketException.NativeMethodInfoPtr_get_SocketErrorCode_Public_get_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x00009E2E File Offset: 0x0000802E
		public SocketException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001345 RID: 4933 RVA: 0x000587C8 File Offset: 0x000569C8
		// (set) Token: 0x06001346 RID: 4934 RVA: 0x00009E37 File Offset: 0x00008037
		public unsafe EndPoint m_EndPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketException.NativeFieldInfoPtr_m_EndPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EndPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketException.NativeFieldInfoPtr_m_EndPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EBA RID: 3770
		private static readonly IntPtr NativeFieldInfoPtr_m_EndPoint;

		// Token: 0x04000EBB RID: 3771
		private static readonly IntPtr NativeMethodInfoPtr_WSAGetLastError_internal_Private_Static_Int32_0;

		// Token: 0x04000EBC RID: 3772
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000EBD RID: 3773
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_0;

		// Token: 0x04000EBE RID: 3774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000EBF RID: 3775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SocketError_0;

		// Token: 0x04000EC0 RID: 3776
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000EC1 RID: 3777
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x04000EC2 RID: 3778
		private static readonly IntPtr NativeMethodInfoPtr_get_SocketErrorCode_Public_get_SocketError_0;
	}
}
