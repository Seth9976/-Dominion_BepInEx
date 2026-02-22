using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000CB RID: 203
	public class IWebRequestCreate : Il2CppObjectBase
	{
		// Token: 0x06000BE2 RID: 3042 RVA: 0x00006ABB File Offset: 0x00004CBB
		// Note: this type is marked as 'beforefieldinit'.
		static IWebRequestCreate()
		{
			Il2CppClassPointerStore<IWebRequestCreate>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "IWebRequestCreate");
			IWebRequestCreate.NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_WebRequest_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWebRequestCreate>.NativeClassPtr, 100664976);
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x0003D308 File Offset: 0x0003B508
		[CallerCount(0)]
		public unsafe virtual WebRequest Create(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWebRequestCreate.NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_WebRequest_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x00006AEA File Offset: 0x00004CEA
		public IWebRequestCreate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_WebRequest_Uri_0;
	}
}
