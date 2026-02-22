using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000A3 RID: 163
	public sealed class ExecuteInEditMode : Attribute
	{
		// Token: 0x06000FE3 RID: 4067 RVA: 0x00009E4D File Offset: 0x0000804D
		// Note: this type is marked as 'beforefieldinit'.
		static ExecuteInEditMode()
		{
			Il2CppClassPointerStore<ExecuteInEditMode>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExecuteInEditMode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecuteInEditMode>.NativeClassPtr);
			ExecuteInEditMode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteInEditMode>.NativeClassPtr, 100664326);
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x00041A18 File Offset: 0x0003FC18
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecuteInEditMode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteInEditMode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteInEditMode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00009E86 File Offset: 0x00008086
		public ExecuteInEditMode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
