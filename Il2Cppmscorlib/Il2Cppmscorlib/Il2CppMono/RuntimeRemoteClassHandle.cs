using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono
{
	// Token: 0x02000007 RID: 7
	[StructLayout(2)]
	public struct RuntimeRemoteClassHandle
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00023174 File Offset: 0x00021374
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeRemoteClassHandle()
		{
			Il2CppClassPointerStore<RuntimeRemoteClassHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "RuntimeRemoteClassHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeRemoteClassHandle>.NativeClassPtr);
			RuntimeRemoteClassHandle.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeRemoteClassHandle>.NativeClassPtr, "value");
			RuntimeRemoteClassHandle.NativeMethodInfoPtr_get_ProxyClass_Internal_get_RuntimeClassHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeRemoteClassHandle>.NativeClassPtr, 100663319);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000231CC File Offset: 0x000213CC
		public unsafe RuntimeClassHandle ProxyClass
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 11669, RefRangeEnd = 11672, XrefRangeStart = 11669, XrefRangeEnd = 11672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeRemoteClassHandle.NativeMethodInfoPtr_get_ProxyClass_Internal_get_RuntimeClassHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002094 File Offset: 0x00000294
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeRemoteClassHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_get_ProxyClass_Internal_get_RuntimeClassHandle_0;

		// Token: 0x0400001B RID: 27
		[FieldOffset(0)]
		public IntPtr value;
	}
}
