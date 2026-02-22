using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000341 RID: 833
	public sealed class OnDeserializingAttribute : Attribute
	{
		// Token: 0x06003590 RID: 13712 RVA: 0x0001334E File Offset: 0x0001154E
		// Note: this type is marked as 'beforefieldinit'.
		static OnDeserializingAttribute()
		{
			Il2CppClassPointerStore<OnDeserializingAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "OnDeserializingAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDeserializingAttribute>.NativeClassPtr);
			OnDeserializingAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeserializingAttribute>.NativeClassPtr, 100671567);
		}

		// Token: 0x06003591 RID: 13713 RVA: 0x00104F74 File Offset: 0x00103174
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnDeserializingAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnDeserializingAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDeserializingAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x00013387 File Offset: 0x00011587
		public OnDeserializingAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002D3C RID: 11580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
