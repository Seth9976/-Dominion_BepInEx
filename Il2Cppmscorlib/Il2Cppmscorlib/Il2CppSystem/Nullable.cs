using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000126 RID: 294
	public static class Nullable : Object
	{
		// Token: 0x060014D0 RID: 5328 RVA: 0x00007453 File Offset: 0x00005653
		// Note: this type is marked as 'beforefieldinit'.
		static Nullable()
		{
			Il2CppClassPointerStore<Nullable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Nullable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Nullable>.NativeClassPtr);
			Nullable.NativeMethodInfoPtr_GetUnderlyingType_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Nullable>.NativeClassPtr, 100666845);
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x00080D9C File Offset: 0x0007EF9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 306357, RefRangeEnd = 306359, XrefRangeStart = 306347, XrefRangeEnd = 306357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetUnderlyingType(Type nullableType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullableType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Nullable.NativeMethodInfoPtr_GetUnderlyingType_Public_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x0000748C File Offset: 0x0000568C
		public Nullable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040011B7 RID: 4535
		private static readonly IntPtr NativeMethodInfoPtr_GetUnderlyingType_Public_Static_Type_Type_0;
	}
}
