using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200001F RID: 31
	public sealed class NativeContainerAttribute : Attribute
	{
		// Token: 0x060000F5 RID: 245 RVA: 0x00002A21 File Offset: 0x00000C21
		// Note: this type is marked as 'beforefieldinit'.
		static NativeContainerAttribute()
		{
			Il2CppClassPointerStore<NativeContainerAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeContainerAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeContainerAttribute>.NativeClassPtr);
			NativeContainerAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeContainerAttribute>.NativeClassPtr, 100663339);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00019658 File Offset: 0x00017858
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeContainerAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeContainerAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeContainerAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002A5A File Offset: 0x00000C5A
		public NativeContainerAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
