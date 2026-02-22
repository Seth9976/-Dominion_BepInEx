using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000D1 RID: 209
	public sealed class HttpContinueDelegate : MulticastDelegate
	{
		// Token: 0x06000C10 RID: 3088 RVA: 0x0003DAF0 File Offset: 0x0003BCF0
		// Note: this type is marked as 'beforefieldinit'.
		static HttpContinueDelegate()
		{
			Il2CppClassPointerStore<HttpContinueDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpContinueDelegate");
			HttpContinueDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContinueDelegate>.NativeClassPtr, 100664993);
			HttpContinueDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContinueDelegate>.NativeClassPtr, 100664994);
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x0003DB40 File Offset: 0x0003BD40
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpContinueDelegate(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpContinueDelegate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContinueDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x0003DB9C File Offset: 0x0003BD9C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 46351, RefRangeEnd = 46356, XrefRangeStart = 46347, XrefRangeEnd = 46351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(int StatusCode, WebHeaderCollection httpHeaders)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref StatusCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(httpHeaders);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContinueDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00006C22 File Offset: 0x00004E22
		public HttpContinueDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x00006C2B File Offset: 0x00004E2B
		public static implicit operator HttpContinueDelegate(Action<int, WebHeaderCollection> A_0)
		{
			return DelegateSupport.ConvertDelegate<HttpContinueDelegate>(A_0);
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00006C33 File Offset: 0x00004E33
		public static HttpContinueDelegate operator +(HttpContinueDelegate A_0, HttpContinueDelegate A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<HttpContinueDelegate>();
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x00006C41 File Offset: 0x00004E41
		public static HttpContinueDelegate operator -(HttpContinueDelegate A_0, HttpContinueDelegate A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<HttpContinueDelegate>();
			}
			return delegate2;
		}

		// Token: 0x04000982 RID: 2434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000983 RID: 2435
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_WebHeaderCollection_0;
	}
}
