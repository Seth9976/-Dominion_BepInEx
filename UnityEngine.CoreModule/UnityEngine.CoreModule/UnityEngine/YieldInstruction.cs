using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000CB RID: 203
	public class YieldInstruction : Object
	{
		// Token: 0x06001195 RID: 4501 RVA: 0x0000A81F File Offset: 0x00008A1F
		// Note: this type is marked as 'beforefieldinit'.
		static YieldInstruction()
		{
			Il2CppClassPointerStore<YieldInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "YieldInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YieldInstruction>.NativeClassPtr);
			YieldInstruction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldInstruction>.NativeClassPtr, 100664537);
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x000475EC File Offset: 0x000457EC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe YieldInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YieldInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YieldInstruction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x0000A858 File Offset: 0x00008A58
		public YieldInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
