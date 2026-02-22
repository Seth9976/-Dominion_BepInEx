using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x0200010C RID: 268
	public class HttpRequestCreator : Object
	{
		// Token: 0x0600103F RID: 4159 RVA: 0x0004D758 File Offset: 0x0004B958
		// Note: this type is marked as 'beforefieldinit'.
		static HttpRequestCreator()
		{
			Il2CppClassPointerStore<HttpRequestCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpRequestCreator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpRequestCreator>.NativeClassPtr);
			HttpRequestCreator.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestCreator>.NativeClassPtr, 100665558);
			HttpRequestCreator.NativeMethodInfoPtr_Create_Public_Virtual_Final_New_WebRequest_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpRequestCreator>.NativeClassPtr, 100665559);
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x0004D7B0 File Offset: 0x0004B9B0
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpRequestCreator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpRequestCreator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestCreator.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x0004D7EC File Offset: 0x0004B9EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51440, XrefRangeEnd = 51467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WebRequest Create(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpRequestCreator.NativeMethodInfoPtr_Create_Public_Virtual_Final_New_WebRequest_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x00008731 File Offset: 0x00006931
		public HttpRequestCreator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Final_New_WebRequest_Uri_0;
	}
}
