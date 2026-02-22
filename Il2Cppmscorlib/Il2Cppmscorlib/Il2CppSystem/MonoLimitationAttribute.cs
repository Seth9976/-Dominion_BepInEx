using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200005C RID: 92
	public class MonoLimitationAttribute : MonoTODOAttribute
	{
		// Token: 0x06000637 RID: 1591 RVA: 0x00003F7A File Offset: 0x0000217A
		// Note: this type is marked as 'beforefieldinit'.
		static MonoLimitationAttribute()
		{
			Il2CppClassPointerStore<MonoLimitationAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MonoLimitationAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoLimitationAttribute>.NativeClassPtr);
			MonoLimitationAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoLimitationAttribute>.NativeClassPtr, 100664303);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0003E5C0 File Offset: 0x0003C7C0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoLimitationAttribute(string comment)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoLimitationAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(comment);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoLimitationAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00003FB3 File Offset: 0x000021B3
		public MonoLimitationAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
