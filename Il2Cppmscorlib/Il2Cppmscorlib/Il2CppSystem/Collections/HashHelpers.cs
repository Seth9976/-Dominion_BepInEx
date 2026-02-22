using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections
{
	// Token: 0x02000475 RID: 1141
	public static class HashHelpers : Object
	{
		// Token: 0x06004482 RID: 17538 RVA: 0x00139374 File Offset: 0x00137574
		// Note: this type is marked as 'beforefieldinit'.
		static HashHelpers()
		{
			Il2CppClassPointerStore<HashHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "HashHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr);
			HashHelpers.NativeFieldInfoPtr_primes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, "primes");
			HashHelpers.NativeFieldInfoPtr_s_SerializationInfoTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, "s_SerializationInfoTable");
			HashHelpers.NativeMethodInfoPtr_get_SerializationInfoTable_Internal_Static_get_ConditionalWeakTable_2_Object_SerializationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, 100673277);
			HashHelpers.NativeMethodInfoPtr_IsPrime_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, 100673278);
			HashHelpers.NativeMethodInfoPtr_GetPrime_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, 100673279);
			HashHelpers.NativeMethodInfoPtr_ExpandPrime_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, 100673280);
		}

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x06004483 RID: 17539 RVA: 0x0013941C File Offset: 0x0013761C
		public unsafe static ConditionalWeakTable<Object, SerializationInfo> SerializationInfoTable
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 360362, RefRangeEnd = 360365, XrefRangeStart = 360345, XrefRangeEnd = 360362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashHelpers.NativeMethodInfoPtr_get_SerializationInfoTable_Internal_Static_get_ConditionalWeakTable_2_Object_SerializationInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<Object, SerializationInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06004484 RID: 17540 RVA: 0x00139450 File Offset: 0x00137650
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 360366, RefRangeEnd = 360367, XrefRangeStart = 360365, XrefRangeEnd = 360366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPrime(int candidate)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref candidate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashHelpers.NativeMethodInfoPtr_IsPrime_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004485 RID: 17541 RVA: 0x00139490 File Offset: 0x00137690
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 360378, RefRangeEnd = 360385, XrefRangeStart = 360367, XrefRangeEnd = 360378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPrime(int min)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashHelpers.NativeMethodInfoPtr_GetPrime_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004486 RID: 17542 RVA: 0x001394D0 File Offset: 0x001376D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 360386, RefRangeEnd = 360389, XrefRangeStart = 360385, XrefRangeEnd = 360386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ExpandPrime(int oldSize)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashHelpers.NativeMethodInfoPtr_ExpandPrime_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004487 RID: 17543 RVA: 0x0001A41A File Offset: 0x0001861A
		public HashHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x06004488 RID: 17544 RVA: 0x00139510 File Offset: 0x00137710
		// (set) Token: 0x06004489 RID: 17545 RVA: 0x0001A423 File Offset: 0x00018623
		public unsafe static Il2CppStructArray<int> primes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HashHelpers.NativeFieldInfoPtr_primes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashHelpers.NativeFieldInfoPtr_primes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x0600448A RID: 17546 RVA: 0x00139538 File Offset: 0x00137738
		// (set) Token: 0x0600448B RID: 17547 RVA: 0x0001A435 File Offset: 0x00018635
		public unsafe static ConditionalWeakTable<Object, SerializationInfo> s_SerializationInfoTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HashHelpers.NativeFieldInfoPtr_s_SerializationInfoTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<Object, SerializationInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashHelpers.NativeFieldInfoPtr_s_SerializationInfoTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040037C8 RID: 14280
		private static readonly IntPtr NativeFieldInfoPtr_primes;

		// Token: 0x040037C9 RID: 14281
		private static readonly IntPtr NativeFieldInfoPtr_s_SerializationInfoTable;

		// Token: 0x040037CA RID: 14282
		private static readonly IntPtr NativeMethodInfoPtr_get_SerializationInfoTable_Internal_Static_get_ConditionalWeakTable_2_Object_SerializationInfo_0;

		// Token: 0x040037CB RID: 14283
		private static readonly IntPtr NativeMethodInfoPtr_IsPrime_Public_Static_Boolean_Int32_0;

		// Token: 0x040037CC RID: 14284
		private static readonly IntPtr NativeMethodInfoPtr_GetPrime_Public_Static_Int32_Int32_0;

		// Token: 0x040037CD RID: 14285
		private static readonly IntPtr NativeMethodInfoPtr_ExpandPrime_Public_Static_Int32_Int32_0;
	}
}
