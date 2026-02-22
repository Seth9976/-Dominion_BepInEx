using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000A4 RID: 164
	public sealed class ExecuteAlways : Attribute
	{
		// Token: 0x06000FE6 RID: 4070 RVA: 0x00009E8F File Offset: 0x0000808F
		// Note: this type is marked as 'beforefieldinit'.
		static ExecuteAlways()
		{
			Il2CppClassPointerStore<ExecuteAlways>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExecuteAlways");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecuteAlways>.NativeClassPtr);
			ExecuteAlways.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteAlways>.NativeClassPtr, 100664327);
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x00041A54 File Offset: 0x0003FC54
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecuteAlways()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteAlways>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteAlways.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00009EC8 File Offset: 0x000080C8
		public ExecuteAlways(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
