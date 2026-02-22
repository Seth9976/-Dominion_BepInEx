using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000269 RID: 617
	public sealed class AutoResetEvent : EventWaitHandle
	{
		// Token: 0x06002AA0 RID: 10912 RVA: 0x0000EDCE File Offset: 0x0000CFCE
		// Note: this type is marked as 'beforefieldinit'.
		static AutoResetEvent()
		{
			Il2CppClassPointerStore<AutoResetEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "AutoResetEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoResetEvent>.NativeClassPtr);
			AutoResetEvent.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoResetEvent>.NativeClassPtr, 100670070);
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x000DBEC8 File Offset: 0x000DA0C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 331246, RefRangeEnd = 331248, XrefRangeStart = 331245, XrefRangeEnd = 331246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AutoResetEvent(bool initialState)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoResetEvent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoResetEvent.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x0000EE07 File Offset: 0x0000D007
		public AutoResetEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002552 RID: 9554
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
	}
}
