using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Util
{
	// Token: 0x02000003 RID: 3
	public sealed class MonoPInvokeCallbackAttribute : Attribute
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002076 File Offset: 0x00000276
		// Note: this type is marked as 'beforefieldinit'.
		static MonoPInvokeCallbackAttribute()
		{
			Il2CppClassPointerStore<MonoPInvokeCallbackAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Util", "MonoPInvokeCallbackAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoPInvokeCallbackAttribute>.NativeClassPtr);
			MonoPInvokeCallbackAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoPInvokeCallbackAttribute>.NativeClassPtr, 100663302);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00010A24 File Offset: 0x0000EC24
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoPInvokeCallbackAttribute(Type t)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoPInvokeCallbackAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoPInvokeCallbackAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020AF File Offset: 0x000002AF
		public MonoPInvokeCallbackAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
