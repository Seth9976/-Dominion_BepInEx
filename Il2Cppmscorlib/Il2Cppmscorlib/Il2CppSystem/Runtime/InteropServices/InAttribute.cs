using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000447 RID: 1095
	public sealed class InAttribute : Attribute
	{
		// Token: 0x060042B6 RID: 17078 RVA: 0x000198DA File Offset: 0x00017ADA
		// Note: this type is marked as 'beforefieldinit'.
		static InAttribute()
		{
			Il2CppClassPointerStore<InAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "InAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InAttribute>.NativeClassPtr);
			InAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAttribute>.NativeClassPtr, 100672970);
		}

		// Token: 0x060042B7 RID: 17079 RVA: 0x00132858 File Offset: 0x00130A58
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042B8 RID: 17080 RVA: 0x00019913 File Offset: 0x00017B13
		public InAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400367F RID: 13951
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
