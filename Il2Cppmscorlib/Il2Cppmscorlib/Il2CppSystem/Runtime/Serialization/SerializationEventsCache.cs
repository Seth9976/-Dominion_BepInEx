using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000345 RID: 837
	public static class SerializationEventsCache : Object
	{
		// Token: 0x060035AD RID: 13741 RVA: 0x00105630 File Offset: 0x00103830
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationEventsCache()
		{
			Il2CppClassPointerStore<SerializationEventsCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SerializationEventsCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationEventsCache>.NativeClassPtr);
			SerializationEventsCache.NativeFieldInfoPtr_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEventsCache>.NativeClassPtr, "cache");
			SerializationEventsCache.NativeMethodInfoPtr_GetSerializationEventsForType_Internal_Static_SerializationEvents_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEventsCache>.NativeClassPtr, 100671580);
		}

		// Token: 0x060035AE RID: 13742 RVA: 0x00105688 File Offset: 0x00103888
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 343768, RefRangeEnd = 343776, XrefRangeStart = 343726, XrefRangeEnd = 343768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SerializationEvents GetSerializationEventsForType(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEventsCache.NativeMethodInfoPtr_GetSerializationEventsForType_Internal_Static_SerializationEvents_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationEvents>(intPtr3) : null;
			}
		}

		// Token: 0x060035AF RID: 13743 RVA: 0x00013460 File Offset: 0x00011660
		public SerializationEventsCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x060035B0 RID: 13744 RVA: 0x001056CC File Offset: 0x001038CC
		// (set) Token: 0x060035B1 RID: 13745 RVA: 0x00013469 File Offset: 0x00011669
		public unsafe static Hashtable cache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SerializationEventsCache.NativeFieldInfoPtr_cache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializationEventsCache.NativeFieldInfoPtr_cache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002D4D RID: 11597
		private static readonly IntPtr NativeFieldInfoPtr_cache;

		// Token: 0x04002D4E RID: 11598
		private static readonly IntPtr NativeMethodInfoPtr_GetSerializationEventsForType_Internal_Static_SerializationEvents_Type_0;
	}
}
