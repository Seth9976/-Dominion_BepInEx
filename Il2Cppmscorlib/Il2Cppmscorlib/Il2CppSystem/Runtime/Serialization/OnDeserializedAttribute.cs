using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000342 RID: 834
	public sealed class OnDeserializedAttribute : Attribute
	{
		// Token: 0x06003593 RID: 13715 RVA: 0x00013390 File Offset: 0x00011590
		// Note: this type is marked as 'beforefieldinit'.
		static OnDeserializedAttribute()
		{
			Il2CppClassPointerStore<OnDeserializedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "OnDeserializedAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDeserializedAttribute>.NativeClassPtr);
			OnDeserializedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDeserializedAttribute>.NativeClassPtr, 100671568);
		}

		// Token: 0x06003594 RID: 13716 RVA: 0x00104FB0 File Offset: 0x001031B0
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnDeserializedAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnDeserializedAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDeserializedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003595 RID: 13717 RVA: 0x000133C9 File Offset: 0x000115C9
		public OnDeserializedAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002D3D RID: 11581
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
