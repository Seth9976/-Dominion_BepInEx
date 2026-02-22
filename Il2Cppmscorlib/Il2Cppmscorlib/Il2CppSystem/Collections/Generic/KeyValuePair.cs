using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x0200048B RID: 1163
	public static class KeyValuePair : Object
	{
		// Token: 0x060045B9 RID: 17849 RVA: 0x0001A911 File Offset: 0x00018B11
		// Note: this type is marked as 'beforefieldinit'.
		static KeyValuePair()
		{
			Il2CppClassPointerStore<KeyValuePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "KeyValuePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyValuePair>.NativeClassPtr);
			KeyValuePair.NativeMethodInfoPtr_PairToString_Internal_Static_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePair>.NativeClassPtr, 100673578);
		}

		// Token: 0x060045BA RID: 17850 RVA: 0x0013F34C File Offset: 0x0013D54C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 361555, RefRangeEnd = 361557, XrefRangeStart = 361545, XrefRangeEnd = 361555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string PairToString(Object key, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValuePair.NativeMethodInfoPtr_PairToString_Internal_Static_String_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060045BB RID: 17851 RVA: 0x0001A94A File Offset: 0x00018B4A
		public KeyValuePair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040038B2 RID: 14514
		private static readonly IntPtr NativeMethodInfoPtr_PairToString_Internal_Static_String_Object_Object_0;
	}
}
