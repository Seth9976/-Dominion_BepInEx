using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing.Default
{
	// Token: 0x02000002 RID: 2
	public class Factory : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		// Note: this type is marked as 'beforefieldinit'.
		static Factory()
		{
			Il2CppClassPointerStore<Factory>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.WinRTStub.dll", "UnityEngine.Purchasing.Default", "Factory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Factory>.NativeClassPtr);
			Factory.NativeMethodInfoPtr_Create_Public_Static_IWindowsIAP_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Factory>.NativeClassPtr, 100663297);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002094 File Offset: 0x00000294
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131449, RefRangeEnd = 131451, XrefRangeStart = 131444, XrefRangeEnd = 131449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IWindowsIAP Create(bool mocked)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mocked;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Factory.NativeMethodInfoPtr_Create_Public_Static_IWindowsIAP_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWindowsIAP>(intPtr3) : null;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002089 File Offset: 0x00000289
		public Factory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_IWindowsIAP_Boolean_0;
	}
}
