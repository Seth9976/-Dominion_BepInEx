using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x02000056 RID: 86
	[Serializable]
	public class TMP_Style : Object
	{
		// Token: 0x060009BC RID: 2492 RVA: 0x00029940 File Offset: 0x00027B40
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Style()
		{
			Il2CppClassPointerStore<TMP_Style>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Style");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr);
			TMP_Style.NativeFieldInfoPtr_k_NormalStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, "k_NormalStyle");
			TMP_Style.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, "m_Name");
			TMP_Style.NativeFieldInfoPtr_m_HashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, "m_HashCode");
			TMP_Style.NativeFieldInfoPtr_m_OpeningDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, "m_OpeningDefinition");
			TMP_Style.NativeFieldInfoPtr_m_ClosingDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, "m_ClosingDefinition");
			TMP_Style.NativeFieldInfoPtr_m_OpeningTagArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, "m_OpeningTagArray");
			TMP_Style.NativeFieldInfoPtr_m_ClosingTagArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, "m_ClosingTagArray");
			TMP_Style.NativeFieldInfoPtr_m_OpeningTagUnicodeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, "m_OpeningTagUnicodeArray");
			TMP_Style.NativeFieldInfoPtr_m_ClosingTagUnicodeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, "m_ClosingTagUnicodeArray");
			TMP_Style.NativeMethodInfoPtr_get_NormalStyle_Public_Static_get_TMP_Style_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, 100664264);
			TMP_Style.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, 100664265);
			TMP_Style.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, 100664266);
			TMP_Style.NativeMethodInfoPtr_get_hashCode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, 100664267);
			TMP_Style.NativeMethodInfoPtr_set_hashCode_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, 100664268);
			TMP_Style.NativeMethodInfoPtr_get_styleOpeningDefinition_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, 100664269);
			TMP_Style.NativeMethodInfoPtr_get_styleClosingDefinition_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, 100664270);
			TMP_Style.NativeMethodInfoPtr_get_styleOpeningTagArray_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, 100664271);
			TMP_Style.NativeMethodInfoPtr_get_styleClosingTagArray_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, 100664272);
			TMP_Style.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, 100664273);
			TMP_Style.NativeMethodInfoPtr_RefreshStyle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr, 100664274);
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x00029B00 File Offset: 0x00027D00
		public unsafe static TMP_Style NormalStyle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145445, XrefRangeEnd = 145455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Style.NativeMethodInfoPtr_get_NormalStyle_Public_Static_get_TMP_Style_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Style>(intPtr3) : null;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x00029B34 File Offset: 0x00027D34
		// (set) Token: 0x060009BF RID: 2495 RVA: 0x00029B6C File Offset: 0x00027D6C
		public unsafe string name
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Style.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145455, XrefRangeEnd = 145456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Style.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x00029BB0 File Offset: 0x00027DB0
		// (set) Token: 0x060009C1 RID: 2497 RVA: 0x00029BEC File Offset: 0x00027DEC
		public unsafe int hashCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Style.NativeMethodInfoPtr_get_hashCode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Style.NativeMethodInfoPtr_set_hashCode_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x00029C2C File Offset: 0x00027E2C
		public unsafe string styleOpeningDefinition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Style.NativeMethodInfoPtr_get_styleOpeningDefinition_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x00029C64 File Offset: 0x00027E64
		public unsafe string styleClosingDefinition
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Style.NativeMethodInfoPtr_get_styleClosingDefinition_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x00029C9C File Offset: 0x00027E9C
		public unsafe Il2CppStructArray<int> styleOpeningTagArray
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Style.NativeMethodInfoPtr_get_styleOpeningTagArray_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x00029CDC File Offset: 0x00027EDC
		public unsafe Il2CppStructArray<int> styleClosingTagArray
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Style.NativeMethodInfoPtr_get_styleClosingTagArray_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00029D1C File Offset: 0x00027F1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 145462, RefRangeEnd = 145464, XrefRangeStart = 145456, XrefRangeEnd = 145462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Style(string styleName, string styleOpeningDefinition, string styleClosingDefinition)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Style>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(styleName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(styleOpeningDefinition);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(styleClosingDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Style.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00029D8C File Offset: 0x00027F8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 145482, RefRangeEnd = 145485, XrefRangeStart = 145464, XrefRangeEnd = 145482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshStyle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Style.NativeMethodInfoPtr_RefreshStyle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00006844 File Offset: 0x00004A44
		public TMP_Style(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x00029DC0 File Offset: 0x00027FC0
		// (set) Token: 0x060009CA RID: 2506 RVA: 0x0000684D File Offset: 0x00004A4D
		public unsafe static TMP_Style k_NormalStyle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Style.NativeFieldInfoPtr_k_NormalStyle, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Style>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Style.NativeFieldInfoPtr_k_NormalStyle, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x00029DE8 File Offset: 0x00027FE8
		// (set) Token: 0x060009CC RID: 2508 RVA: 0x0000685F File Offset: 0x00004A5F
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x00029E10 File Offset: 0x00028010
		// (set) Token: 0x060009CE RID: 2510 RVA: 0x0000687E File Offset: 0x00004A7E
		public unsafe int m_HashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_HashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_HashCode)) = value;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x00029E38 File Offset: 0x00028038
		// (set) Token: 0x060009D0 RID: 2512 RVA: 0x00006899 File Offset: 0x00004A99
		public unsafe string m_OpeningDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_OpeningDefinition);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_OpeningDefinition), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x00029E60 File Offset: 0x00028060
		// (set) Token: 0x060009D2 RID: 2514 RVA: 0x000068B8 File Offset: 0x00004AB8
		public unsafe string m_ClosingDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_ClosingDefinition);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_ClosingDefinition), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x00029E88 File Offset: 0x00028088
		// (set) Token: 0x060009D4 RID: 2516 RVA: 0x000068D7 File Offset: 0x00004AD7
		public unsafe Il2CppStructArray<int> m_OpeningTagArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_OpeningTagArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_OpeningTagArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x00029EB8 File Offset: 0x000280B8
		// (set) Token: 0x060009D6 RID: 2518 RVA: 0x000068F6 File Offset: 0x00004AF6
		public unsafe Il2CppStructArray<int> m_ClosingTagArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_ClosingTagArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_ClosingTagArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x00029EE8 File Offset: 0x000280E8
		// (set) Token: 0x060009D8 RID: 2520 RVA: 0x00006915 File Offset: 0x00004B15
		public unsafe Il2CppStructArray<uint> m_OpeningTagUnicodeArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_OpeningTagUnicodeArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_OpeningTagUnicodeArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x00029F18 File Offset: 0x00028118
		// (set) Token: 0x060009DA RID: 2522 RVA: 0x00006934 File Offset: 0x00004B34
		public unsafe Il2CppStructArray<uint> m_ClosingTagUnicodeArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_ClosingTagUnicodeArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Style.NativeFieldInfoPtr_m_ClosingTagUnicodeArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeFieldInfoPtr_k_NormalStyle;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeFieldInfoPtr_m_HashCode;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeFieldInfoPtr_m_OpeningDefinition;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeFieldInfoPtr_m_ClosingDefinition;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeFieldInfoPtr_m_OpeningTagArray;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeFieldInfoPtr_m_ClosingTagArray;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeFieldInfoPtr_m_OpeningTagUnicodeArray;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeFieldInfoPtr_m_ClosingTagUnicodeArray;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalStyle_Public_Static_get_TMP_Style_0;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeMethodInfoPtr_get_hashCode_Public_get_Int32_0;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeMethodInfoPtr_set_hashCode_Public_set_Void_Int32_0;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeMethodInfoPtr_get_styleOpeningDefinition_Public_get_String_0;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeMethodInfoPtr_get_styleClosingDefinition_Public_get_String_0;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeMethodInfoPtr_get_styleOpeningTagArray_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeMethodInfoPtr_get_styleClosingTagArray_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_0;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr_RefreshStyle_Public_Void_0;
	}
}
