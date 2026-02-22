using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001DB RID: 475
	public class RuntimeParameterInfo : ParameterInfo
	{
		// Token: 0x06001E9E RID: 7838 RVA: 0x0000A7D2 File Offset: 0x000089D2
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeParameterInfo()
		{
			Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "RuntimeParameterInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr);
			RuntimeParameterInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr, 100668369);
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x000AB37C File Offset: 0x000A957C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeParameterInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeParameterInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x0000A80B File Offset: 0x00008A0B
		public RuntimeParameterInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001BDA RID: 7130
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
