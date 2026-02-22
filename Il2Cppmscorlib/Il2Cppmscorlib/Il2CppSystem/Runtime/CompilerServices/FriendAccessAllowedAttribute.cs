using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000431 RID: 1073
	public sealed class FriendAccessAllowedAttribute : Attribute
	{
		// Token: 0x06004250 RID: 16976 RVA: 0x000194FD File Offset: 0x000176FD
		// Note: this type is marked as 'beforefieldinit'.
		static FriendAccessAllowedAttribute()
		{
			Il2CppClassPointerStore<FriendAccessAllowedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "FriendAccessAllowedAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendAccessAllowedAttribute>.NativeClassPtr);
			FriendAccessAllowedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendAccessAllowedAttribute>.NativeClassPtr, 100672937);
		}

		// Token: 0x06004251 RID: 16977 RVA: 0x001315E8 File Offset: 0x0012F7E8
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendAccessAllowedAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendAccessAllowedAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendAccessAllowedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004252 RID: 16978 RVA: 0x00019536 File Offset: 0x00017736
		public FriendAccessAllowedAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040035F2 RID: 13810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
