using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Internal
{
	// Token: 0x0200012D RID: 301
	[Serializable]
	public class ExcludeFromDocsAttribute : Attribute
	{
		// Token: 0x0600178A RID: 6026 RVA: 0x0000D307 File Offset: 0x0000B507
		// Note: this type is marked as 'beforefieldinit'.
		static ExcludeFromDocsAttribute()
		{
			Il2CppClassPointerStore<ExcludeFromDocsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Internal", "ExcludeFromDocsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExcludeFromDocsAttribute>.NativeClassPtr);
			ExcludeFromDocsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExcludeFromDocsAttribute>.NativeClassPtr, 100665083);
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x000587BC File Offset: 0x000569BC
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExcludeFromDocsAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExcludeFromDocsAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExcludeFromDocsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x0000D340 File Offset: 0x0000B540
		public ExcludeFromDocsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001112 RID: 4370
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
