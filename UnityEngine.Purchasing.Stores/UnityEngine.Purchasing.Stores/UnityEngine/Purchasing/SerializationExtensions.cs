using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000035 RID: 53
	public static class SerializationExtensions : Object
	{
		// Token: 0x060001BE RID: 446 RVA: 0x00002DBA File Offset: 0x00000FBA
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationExtensions()
		{
			Il2CppClassPointerStore<SerializationExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "SerializationExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationExtensions>.NativeClassPtr);
			SerializationExtensions.NativeMethodInfoPtr_TryGetString_Public_Static_String_Dictionary_2_String_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationExtensions>.NativeClassPtr, 100663508);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000BAC0 File Offset: 0x00009CC0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 151803, RefRangeEnd = 151807, XrefRangeStart = 151795, XrefRangeEnd = 151803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TryGetString(this Dictionary<string, Object> dic, string key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dic);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationExtensions.NativeMethodInfoPtr_TryGetString_Public_Static_String_Dictionary_2_String_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002DF3 File Offset: 0x00000FF3
		public SerializationExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_TryGetString_Public_Static_String_Dictionary_2_String_Object_String_0;
	}
}
