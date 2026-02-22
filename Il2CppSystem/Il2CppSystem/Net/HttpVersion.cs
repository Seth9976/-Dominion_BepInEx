using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000C4 RID: 196
	public class HttpVersion : Object
	{
		// Token: 0x06000B79 RID: 2937 RVA: 0x0003BDB8 File Offset: 0x00039FB8
		// Note: this type is marked as 'beforefieldinit'.
		static HttpVersion()
		{
			Il2CppClassPointerStore<HttpVersion>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpVersion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpVersion>.NativeClassPtr);
			HttpVersion.NativeFieldInfoPtr_Version10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpVersion>.NativeClassPtr, "Version10");
			HttpVersion.NativeFieldInfoPtr_Version11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpVersion>.NativeClassPtr, "Version11");
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x000067C4 File Offset: 0x000049C4
		public HttpVersion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x0003BE10 File Offset: 0x0003A010
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x000067CD File Offset: 0x000049CD
		public unsafe static Version Version10
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpVersion.NativeFieldInfoPtr_Version10, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpVersion.NativeFieldInfoPtr_Version10, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x0003BE38 File Offset: 0x0003A038
		// (set) Token: 0x06000B7E RID: 2942 RVA: 0x000067DF File Offset: 0x000049DF
		public unsafe static Version Version11
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpVersion.NativeFieldInfoPtr_Version11, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpVersion.NativeFieldInfoPtr_Version11, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeFieldInfoPtr_Version10;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeFieldInfoPtr_Version11;
	}
}
