using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000060 RID: 96
	public class RegexRunnerFactory : Object
	{
		// Token: 0x06000726 RID: 1830 RVA: 0x00004C59 File Offset: 0x00002E59
		// Note: this type is marked as 'beforefieldinit'.
		static RegexRunnerFactory()
		{
			Il2CppClassPointerStore<RegexRunnerFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexRunnerFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexRunnerFactory>.NativeClassPtr);
			RegexRunnerFactory.NativeMethodInfoPtr_CreateInstance_FamOrAssem_Abstract_Virtual_New_RegexRunner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunnerFactory>.NativeClassPtr, 100664244);
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0002B348 File Offset: 0x00029548
		[CallerCount(0)]
		public unsafe virtual RegexRunner CreateInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegexRunnerFactory.NativeMethodInfoPtr_CreateInstance_FamOrAssem_Abstract_Virtual_New_RegexRunner_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexRunner>(intPtr3) : null;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00004C92 File Offset: 0x00002E92
		public RegexRunnerFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_FamOrAssem_Abstract_Virtual_New_RegexRunner_0;
	}
}
