using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001A4 RID: 420
	public static class IntrospectionExtensions : Object
	{
		// Token: 0x06001BAF RID: 7087 RVA: 0x000098DD File Offset: 0x00007ADD
		// Note: this type is marked as 'beforefieldinit'.
		static IntrospectionExtensions()
		{
			Il2CppClassPointerStore<IntrospectionExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "IntrospectionExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntrospectionExtensions>.NativeClassPtr);
			IntrospectionExtensions.NativeMethodInfoPtr_GetTypeInfo_Public_Static_TypeInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntrospectionExtensions>.NativeClassPtr, 100667922);
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x0009E904 File Offset: 0x0009CB04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316829, RefRangeEnd = 316830, XrefRangeStart = 316823, XrefRangeEnd = 316829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeInfo GetTypeInfo(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntrospectionExtensions.NativeMethodInfoPtr_GetTypeInfo_Public_Static_TypeInfo_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x00009916 File Offset: 0x00007B16
		public IntrospectionExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001932 RID: 6450
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeInfo_Public_Static_TypeInfo_Type_0;
	}
}
