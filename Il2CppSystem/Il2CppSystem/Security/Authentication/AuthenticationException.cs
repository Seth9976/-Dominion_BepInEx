using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Security.Authentication
{
	// Token: 0x02000077 RID: 119
	[Serializable]
	public class AuthenticationException : SystemException
	{
		// Token: 0x060007D1 RID: 2001 RVA: 0x0002D0F8 File Offset: 0x0002B2F8
		// Note: this type is marked as 'beforefieldinit'.
		static AuthenticationException()
		{
			Il2CppClassPointerStore<AuthenticationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Authentication", "AuthenticationException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthenticationException>.NativeClassPtr);
			AuthenticationException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticationException>.NativeClassPtr, 100664306);
			AuthenticationException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticationException>.NativeClassPtr, 100664307);
			AuthenticationException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticationException>.NativeClassPtr, 100664308);
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x0002D164 File Offset: 0x0002B364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41347, XrefRangeEnd = 41351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthenticationException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthenticationException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticationException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x0002D1A0 File Offset: 0x0002B3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41351, XrefRangeEnd = 41352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthenticationException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthenticationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticationException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x0002D200 File Offset: 0x0002B400
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41352, XrefRangeEnd = 41353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthenticationException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthenticationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticationException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00005341 File Offset: 0x00003541
		public AuthenticationException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
