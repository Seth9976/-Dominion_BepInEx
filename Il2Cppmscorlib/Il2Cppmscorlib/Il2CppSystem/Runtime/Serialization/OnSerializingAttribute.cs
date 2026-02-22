using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200033F RID: 831
	public sealed class OnSerializingAttribute : Attribute
	{
		// Token: 0x0600358B RID: 13707 RVA: 0x000132DE File Offset: 0x000114DE
		// Note: this type is marked as 'beforefieldinit'.
		static OnSerializingAttribute()
		{
			Il2CppClassPointerStore<OnSerializingAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "OnSerializingAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnSerializingAttribute>.NativeClassPtr);
			OnSerializingAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnSerializingAttribute>.NativeClassPtr, 100671566);
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x00104F38 File Offset: 0x00103138
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnSerializingAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnSerializingAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnSerializingAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600358D RID: 13709 RVA: 0x00013317 File Offset: 0x00011517
		public OnSerializingAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002D3B RID: 11579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
