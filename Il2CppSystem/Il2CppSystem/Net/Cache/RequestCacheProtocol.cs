using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.Cache
{
	// Token: 0x0200014C RID: 332
	public class RequestCacheProtocol : Object
	{
		// Token: 0x06001552 RID: 5458 RVA: 0x0000AC56 File Offset: 0x00008E56
		// Note: this type is marked as 'beforefieldinit'.
		static RequestCacheProtocol()
		{
			Il2CppClassPointerStore<RequestCacheProtocol>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Cache", "RequestCacheProtocol");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestCacheProtocol>.NativeClassPtr);
			RequestCacheProtocol.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCacheProtocol>.NativeClassPtr, 100666257);
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x000604D4 File Offset: 0x0005E6D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 57604, RefRangeEnd = 57606, XrefRangeStart = 57598, XrefRangeEnd = 57604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequestCacheProtocol(Object arg1, Object arg2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestCacheProtocol>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestCacheProtocol.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x0000AC8F File Offset: 0x00008E8F
		public RequestCacheProtocol(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001124 RID: 4388
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0;
	}
}
