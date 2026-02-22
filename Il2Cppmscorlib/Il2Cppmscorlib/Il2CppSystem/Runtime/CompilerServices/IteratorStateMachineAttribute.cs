using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200041D RID: 1053
	[Serializable]
	public sealed class IteratorStateMachineAttribute : StateMachineAttribute
	{
		// Token: 0x060041D7 RID: 16855 RVA: 0x0001915A File Offset: 0x0001735A
		// Note: this type is marked as 'beforefieldinit'.
		static IteratorStateMachineAttribute()
		{
			Il2CppClassPointerStore<IteratorStateMachineAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "IteratorStateMachineAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IteratorStateMachineAttribute>.NativeClassPtr);
			IteratorStateMachineAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IteratorStateMachineAttribute>.NativeClassPtr, 100672880);
		}

		// Token: 0x060041D8 RID: 16856 RVA: 0x0012FE28 File Offset: 0x0012E028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IteratorStateMachineAttribute(Type stateMachineType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IteratorStateMachineAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachineType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IteratorStateMachineAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041D9 RID: 16857 RVA: 0x00019193 File Offset: 0x00017393
		public IteratorStateMachineAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040035AD RID: 13741
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
