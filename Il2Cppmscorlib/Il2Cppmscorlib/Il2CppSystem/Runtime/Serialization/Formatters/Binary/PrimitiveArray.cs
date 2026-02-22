using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000389 RID: 905
	public sealed class PrimitiveArray : Object
	{
		// Token: 0x06003AFC RID: 15100 RVA: 0x0011723C File Offset: 0x0011543C
		// Note: this type is marked as 'beforefieldinit'.
		static PrimitiveArray()
		{
			Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "PrimitiveArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr);
			PrimitiveArray.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "code");
			PrimitiveArray.NativeFieldInfoPtr_booleanA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "booleanA");
			PrimitiveArray.NativeFieldInfoPtr_charA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "charA");
			PrimitiveArray.NativeFieldInfoPtr_doubleA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "doubleA");
			PrimitiveArray.NativeFieldInfoPtr_int16A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "int16A");
			PrimitiveArray.NativeFieldInfoPtr_int32A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "int32A");
			PrimitiveArray.NativeFieldInfoPtr_int64A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "int64A");
			PrimitiveArray.NativeFieldInfoPtr_sbyteA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "sbyteA");
			PrimitiveArray.NativeFieldInfoPtr_singleA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "singleA");
			PrimitiveArray.NativeFieldInfoPtr_uint16A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "uint16A");
			PrimitiveArray.NativeFieldInfoPtr_uint32A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "uint32A");
			PrimitiveArray.NativeFieldInfoPtr_uint64A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, "uint64A");
			PrimitiveArray.NativeMethodInfoPtr__ctor_Internal_Void_InternalPrimitiveTypeE_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, 100672039);
			PrimitiveArray.NativeMethodInfoPtr_Init_Internal_Void_InternalPrimitiveTypeE_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, 100672040);
			PrimitiveArray.NativeMethodInfoPtr_SetValue_Internal_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr, 100672041);
		}

		// Token: 0x06003AFD RID: 15101 RVA: 0x00117398 File Offset: 0x00115598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348708, XrefRangeEnd = 348710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrimitiveArray(InternalPrimitiveTypeE code, Array array)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrimitiveArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimitiveArray.NativeMethodInfoPtr__ctor_Internal_Void_InternalPrimitiveTypeE_Array_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AFE RID: 15102 RVA: 0x001173F4 File Offset: 0x001155F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 348724, RefRangeEnd = 348725, XrefRangeStart = 348710, XrefRangeEnd = 348724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(InternalPrimitiveTypeE code, Array array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimitiveArray.NativeMethodInfoPtr_Init_Internal_Void_InternalPrimitiveTypeE_Array_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AFF RID: 15103 RVA: 0x00117444 File Offset: 0x00115644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 348733, RefRangeEnd = 348734, XrefRangeStart = 348725, XrefRangeEnd = 348733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(string value, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimitiveArray.NativeMethodInfoPtr_SetValue_Internal_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B00 RID: 15104 RVA: 0x00016250 File Offset: 0x00014450
		public PrimitiveArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x06003B01 RID: 15105 RVA: 0x00117494 File Offset: 0x00115694
		// (set) Token: 0x06003B02 RID: 15106 RVA: 0x00016259 File Offset: 0x00014459
		public unsafe InternalPrimitiveTypeE code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_code);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_code)) = value;
			}
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x06003B03 RID: 15107 RVA: 0x001174BC File Offset: 0x001156BC
		// (set) Token: 0x06003B04 RID: 15108 RVA: 0x00016274 File Offset: 0x00014474
		public unsafe Il2CppStructArray<bool> booleanA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_booleanA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_booleanA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06003B05 RID: 15109 RVA: 0x001174EC File Offset: 0x001156EC
		// (set) Token: 0x06003B06 RID: 15110 RVA: 0x00016293 File Offset: 0x00014493
		public unsafe Il2CppStructArray<char> charA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_charA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_charA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x06003B07 RID: 15111 RVA: 0x0011751C File Offset: 0x0011571C
		// (set) Token: 0x06003B08 RID: 15112 RVA: 0x000162B2 File Offset: 0x000144B2
		public unsafe Il2CppStructArray<double> doubleA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_doubleA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<double>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_doubleA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x06003B09 RID: 15113 RVA: 0x0011754C File Offset: 0x0011574C
		// (set) Token: 0x06003B0A RID: 15114 RVA: 0x000162D1 File Offset: 0x000144D1
		public unsafe Il2CppStructArray<short> int16A
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_int16A);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_int16A), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06003B0B RID: 15115 RVA: 0x0011757C File Offset: 0x0011577C
		// (set) Token: 0x06003B0C RID: 15116 RVA: 0x000162F0 File Offset: 0x000144F0
		public unsafe Il2CppStructArray<int> int32A
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_int32A);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_int32A), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06003B0D RID: 15117 RVA: 0x001175AC File Offset: 0x001157AC
		// (set) Token: 0x06003B0E RID: 15118 RVA: 0x0001630F File Offset: 0x0001450F
		public unsafe Il2CppStructArray<long> int64A
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_int64A);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_int64A), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06003B0F RID: 15119 RVA: 0x001175DC File Offset: 0x001157DC
		// (set) Token: 0x06003B10 RID: 15120 RVA: 0x0001632E File Offset: 0x0001452E
		public unsafe Il2CppStructArray<sbyte> sbyteA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_sbyteA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_sbyteA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06003B11 RID: 15121 RVA: 0x0011760C File Offset: 0x0011580C
		// (set) Token: 0x06003B12 RID: 15122 RVA: 0x0001634D File Offset: 0x0001454D
		public unsafe Il2CppStructArray<float> singleA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_singleA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_singleA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06003B13 RID: 15123 RVA: 0x0011763C File Offset: 0x0011583C
		// (set) Token: 0x06003B14 RID: 15124 RVA: 0x0001636C File Offset: 0x0001456C
		public unsafe Il2CppStructArray<ushort> uint16A
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_uint16A);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_uint16A), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x06003B15 RID: 15125 RVA: 0x0011766C File Offset: 0x0011586C
		// (set) Token: 0x06003B16 RID: 15126 RVA: 0x0001638B File Offset: 0x0001458B
		public unsafe Il2CppStructArray<uint> uint32A
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_uint32A);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_uint32A), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x06003B17 RID: 15127 RVA: 0x0011769C File Offset: 0x0011589C
		// (set) Token: 0x06003B18 RID: 15128 RVA: 0x000163AA File Offset: 0x000145AA
		public unsafe Il2CppStructArray<ulong> uint64A
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_uint64A);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrimitiveArray.NativeFieldInfoPtr_uint64A), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003130 RID: 12592
		private static readonly IntPtr NativeFieldInfoPtr_code;

		// Token: 0x04003131 RID: 12593
		private static readonly IntPtr NativeFieldInfoPtr_booleanA;

		// Token: 0x04003132 RID: 12594
		private static readonly IntPtr NativeFieldInfoPtr_charA;

		// Token: 0x04003133 RID: 12595
		private static readonly IntPtr NativeFieldInfoPtr_doubleA;

		// Token: 0x04003134 RID: 12596
		private static readonly IntPtr NativeFieldInfoPtr_int16A;

		// Token: 0x04003135 RID: 12597
		private static readonly IntPtr NativeFieldInfoPtr_int32A;

		// Token: 0x04003136 RID: 12598
		private static readonly IntPtr NativeFieldInfoPtr_int64A;

		// Token: 0x04003137 RID: 12599
		private static readonly IntPtr NativeFieldInfoPtr_sbyteA;

		// Token: 0x04003138 RID: 12600
		private static readonly IntPtr NativeFieldInfoPtr_singleA;

		// Token: 0x04003139 RID: 12601
		private static readonly IntPtr NativeFieldInfoPtr_uint16A;

		// Token: 0x0400313A RID: 12602
		private static readonly IntPtr NativeFieldInfoPtr_uint32A;

		// Token: 0x0400313B RID: 12603
		private static readonly IntPtr NativeFieldInfoPtr_uint64A;

		// Token: 0x0400313C RID: 12604
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_InternalPrimitiveTypeE_Array_0;

		// Token: 0x0400313D RID: 12605
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_InternalPrimitiveTypeE_Array_0;

		// Token: 0x0400313E RID: 12606
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Internal_Void_String_Int32_0;
	}
}
