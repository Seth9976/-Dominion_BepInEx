using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200034A RID: 842
	public sealed class SerializationInfoEnumerator : Object
	{
		// Token: 0x06003622 RID: 13858 RVA: 0x001074C8 File Offset: 0x001056C8
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationInfoEnumerator()
		{
			Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SerializationInfoEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr);
			SerializationInfoEnumerator.NativeFieldInfoPtr_m_members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, "m_members");
			SerializationInfoEnumerator.NativeFieldInfoPtr_m_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, "m_data");
			SerializationInfoEnumerator.NativeFieldInfoPtr_m_types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, "m_types");
			SerializationInfoEnumerator.NativeFieldInfoPtr_m_numItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, "m_numItems");
			SerializationInfoEnumerator.NativeFieldInfoPtr_m_currItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, "m_currItem");
			SerializationInfoEnumerator.NativeFieldInfoPtr_m_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, "m_current");
			SerializationInfoEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStringArray_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, 100671644);
			SerializationInfoEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, 100671645);
			SerializationInfoEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, 100671646);
			SerializationInfoEnumerator.NativeMethodInfoPtr_get_Current_Public_get_SerializationEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, 100671647);
			SerializationInfoEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, 100671648);
			SerializationInfoEnumerator.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, 100671649);
			SerializationInfoEnumerator.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, 100671650);
			SerializationInfoEnumerator.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, 100671651);
		}

		// Token: 0x06003623 RID: 13859 RVA: 0x00107610 File Offset: 0x00105810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344727, XrefRangeEnd = 344728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationInfoEnumerator(Il2CppStringArray members, Il2CppReferenceArray<Object> info, Il2CppReferenceArray<Type> types, int numItems)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(members);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numItems;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfoEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStringArray_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Type_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003624 RID: 13860 RVA: 0x00107690 File Offset: 0x00105890
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 344728, RefRangeEnd = 344742, XrefRangeStart = 344728, XrefRangeEnd = 344728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfoEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06003625 RID: 13861 RVA: 0x001076CC File Offset: 0x001058CC
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344742, XrefRangeEnd = 344745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfoEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06003626 RID: 13862 RVA: 0x0010770C File Offset: 0x0010590C
		public unsafe SerializationEntry Current
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 344745, RefRangeEnd = 344749, XrefRangeStart = 344745, XrefRangeEnd = 344745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfoEnumerator.NativeMethodInfoPtr_get_Current_Public_get_SerializationEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SerializationEntry(intPtr);
			}
		}

		// Token: 0x06003627 RID: 13863 RVA: 0x00107744 File Offset: 0x00105944
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfoEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06003628 RID: 13864 RVA: 0x00107778 File Offset: 0x00105978
		public unsafe string Name
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 344749, RefRangeEnd = 344763, XrefRangeStart = 344749, XrefRangeEnd = 344749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfoEnumerator.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06003629 RID: 13865 RVA: 0x001077B0 File Offset: 0x001059B0
		public unsafe Object Value
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 344763, RefRangeEnd = 344779, XrefRangeStart = 344763, XrefRangeEnd = 344763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfoEnumerator.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x0600362A RID: 13866 RVA: 0x001077F0 File Offset: 0x001059F0
		public unsafe Type ObjectType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 344779, RefRangeEnd = 344780, XrefRangeStart = 344779, XrefRangeEnd = 344779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfoEnumerator.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600362B RID: 13867 RVA: 0x000136F4 File Offset: 0x000118F4
		public SerializationInfoEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x0600362C RID: 13868 RVA: 0x00107830 File Offset: 0x00105A30
		// (set) Token: 0x0600362D RID: 13869 RVA: 0x000136FD File Offset: 0x000118FD
		public unsafe Il2CppStringArray m_members
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr_m_members);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr_m_members), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x0600362E RID: 13870 RVA: 0x00107860 File Offset: 0x00105A60
		// (set) Token: 0x0600362F RID: 13871 RVA: 0x0001371C File Offset: 0x0001191C
		public unsafe Il2CppReferenceArray<Object> m_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr_m_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr_m_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x06003630 RID: 13872 RVA: 0x00107890 File Offset: 0x00105A90
		// (set) Token: 0x06003631 RID: 13873 RVA: 0x0001373B File Offset: 0x0001193B
		public unsafe Il2CppReferenceArray<Type> m_types
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr_m_types);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr_m_types), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06003632 RID: 13874 RVA: 0x001078C0 File Offset: 0x00105AC0
		// (set) Token: 0x06003633 RID: 13875 RVA: 0x0001375A File Offset: 0x0001195A
		public unsafe int m_numItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr_m_numItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr_m_numItems)) = value;
			}
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06003634 RID: 13876 RVA: 0x001078E8 File Offset: 0x00105AE8
		// (set) Token: 0x06003635 RID: 13877 RVA: 0x00013775 File Offset: 0x00011975
		public unsafe int m_currItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr_m_currItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr_m_currItem)) = value;
			}
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06003636 RID: 13878 RVA: 0x00107910 File Offset: 0x00105B10
		// (set) Token: 0x06003637 RID: 13879 RVA: 0x00013790 File Offset: 0x00011990
		public unsafe bool m_current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr_m_current);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr_m_current)) = value;
			}
		}

		// Token: 0x04002DA1 RID: 11681
		private static readonly IntPtr NativeFieldInfoPtr_m_members;

		// Token: 0x04002DA2 RID: 11682
		private static readonly IntPtr NativeFieldInfoPtr_m_data;

		// Token: 0x04002DA3 RID: 11683
		private static readonly IntPtr NativeFieldInfoPtr_m_types;

		// Token: 0x04002DA4 RID: 11684
		private static readonly IntPtr NativeFieldInfoPtr_m_numItems;

		// Token: 0x04002DA5 RID: 11685
		private static readonly IntPtr NativeFieldInfoPtr_m_currItem;

		// Token: 0x04002DA6 RID: 11686
		private static readonly IntPtr NativeFieldInfoPtr_m_current;

		// Token: 0x04002DA7 RID: 11687
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStringArray_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Type_Int32_0;

		// Token: 0x04002DA8 RID: 11688
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04002DA9 RID: 11689
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04002DAA RID: 11690
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_SerializationEntry_0;

		// Token: 0x04002DAB RID: 11691
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002DAC RID: 11692
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04002DAD RID: 11693
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;

		// Token: 0x04002DAE RID: 11694
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0;
	}
}
