using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000B1 RID: 177
	public class ExcludeFromObjectFactoryAttribute : Attribute
	{
		// Token: 0x06001053 RID: 4179 RVA: 0x0000A1C0 File Offset: 0x000083C0
		// Note: this type is marked as 'beforefieldinit'.
		static ExcludeFromObjectFactoryAttribute()
		{
			Il2CppClassPointerStore<ExcludeFromObjectFactoryAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExcludeFromObjectFactoryAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExcludeFromObjectFactoryAttribute>.NativeClassPtr);
			ExcludeFromObjectFactoryAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExcludeFromObjectFactoryAttribute>.NativeClassPtr, 100664368);
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x00042DB4 File Offset: 0x00040FB4
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExcludeFromObjectFactoryAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExcludeFromObjectFactoryAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExcludeFromObjectFactoryAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x0000A1F9 File Offset: 0x000083F9
		public ExcludeFromObjectFactoryAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C51 RID: 3153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
