using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000270 RID: 624
	public sealed class ManualResetEvent : EventWaitHandle
	{
		// Token: 0x06002AF7 RID: 10999 RVA: 0x0000EFE4 File Offset: 0x0000D1E4
		// Note: this type is marked as 'beforefieldinit'.
		static ManualResetEvent()
		{
			Il2CppClassPointerStore<ManualResetEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ManualResetEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManualResetEvent>.NativeClassPtr);
			ManualResetEvent.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualResetEvent>.NativeClassPtr, 100670128);
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x000DD378 File Offset: 0x000DB578
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 331610, RefRangeEnd = 331624, XrefRangeStart = 331609, XrefRangeEnd = 331610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManualResetEvent(bool initialState)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManualResetEvent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualResetEvent.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x0000F01D File Offset: 0x0000D21D
		public ManualResetEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002590 RID: 9616
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
	}
}
