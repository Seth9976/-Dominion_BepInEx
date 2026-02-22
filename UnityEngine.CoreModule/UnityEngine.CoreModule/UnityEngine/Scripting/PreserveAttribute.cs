using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Scripting
{
	// Token: 0x02000112 RID: 274
	public class PreserveAttribute : Attribute
	{
		// Token: 0x06001662 RID: 5730 RVA: 0x0000C9DC File Offset: 0x0000ABDC
		// Note: this type is marked as 'beforefieldinit'.
		static PreserveAttribute()
		{
			Il2CppClassPointerStore<PreserveAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Scripting", "PreserveAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreserveAttribute>.NativeClassPtr);
			PreserveAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreserveAttribute>.NativeClassPtr, 100664971);
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x000554D8 File Offset: 0x000536D8
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreserveAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreserveAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreserveAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x0000CA15 File Offset: 0x0000AC15
		public PreserveAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400106D RID: 4205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
