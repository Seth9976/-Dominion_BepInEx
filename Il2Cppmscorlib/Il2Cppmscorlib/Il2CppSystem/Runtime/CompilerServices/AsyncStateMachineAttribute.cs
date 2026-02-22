using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000419 RID: 1049
	[Serializable]
	public sealed class AsyncStateMachineAttribute : StateMachineAttribute
	{
		// Token: 0x060041CA RID: 16842 RVA: 0x0001909F File Offset: 0x0001729F
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncStateMachineAttribute()
		{
			Il2CppClassPointerStore<AsyncStateMachineAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "AsyncStateMachineAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncStateMachineAttribute>.NativeClassPtr);
			AsyncStateMachineAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncStateMachineAttribute>.NativeClassPtr, 100672875);
		}

		// Token: 0x060041CB RID: 16843 RVA: 0x0012FC60 File Offset: 0x0012DE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356821, XrefRangeEnd = 356822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncStateMachineAttribute(Type stateMachineType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncStateMachineAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachineType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncStateMachineAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041CC RID: 16844 RVA: 0x000190D8 File Offset: 0x000172D8
		public AsyncStateMachineAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040035A8 RID: 13736
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
