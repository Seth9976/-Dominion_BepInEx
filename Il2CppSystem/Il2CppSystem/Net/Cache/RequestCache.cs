using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Cache
{
	// Token: 0x02000147 RID: 327
	public class RequestCache : Object
	{
		// Token: 0x0600153E RID: 5438 RVA: 0x0000AB55 File Offset: 0x00008D55
		// Note: this type is marked as 'beforefieldinit'.
		static RequestCache()
		{
			Il2CppClassPointerStore<RequestCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Cache", "RequestCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestCache>.NativeClassPtr);
			RequestCache.NativeFieldInfoPtr_LineSplits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestCache>.NativeClassPtr, "LineSplits");
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x0000AB8E File Offset: 0x00008D8E
		public RequestCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x00060250 File Offset: 0x0005E450
		// (set) Token: 0x06001541 RID: 5441 RVA: 0x0000AB97 File Offset: 0x00008D97
		public unsafe static Il2CppStructArray<char> LineSplits
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RequestCache.NativeFieldInfoPtr_LineSplits, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestCache.NativeFieldInfoPtr_LineSplits, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001114 RID: 4372
		private static readonly IntPtr NativeFieldInfoPtr_LineSplits;
	}
}
