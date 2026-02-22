using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200035F RID: 863
	public sealed class BinaryObjectWithMap : Object
	{
		// Token: 0x060036F4 RID: 14068 RVA: 0x00109EE8 File Offset: 0x001080E8
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryObjectWithMap()
		{
			Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryObjectWithMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr);
			BinaryObjectWithMap.NativeFieldInfoPtr_binaryHeaderEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr, "binaryHeaderEnum");
			BinaryObjectWithMap.NativeFieldInfoPtr_objectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr, "objectId");
			BinaryObjectWithMap.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr, "name");
			BinaryObjectWithMap.NativeFieldInfoPtr_numMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr, "numMembers");
			BinaryObjectWithMap.NativeFieldInfoPtr_memberNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr, "memberNames");
			BinaryObjectWithMap.NativeFieldInfoPtr_assemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr, "assemId");
			BinaryObjectWithMap.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr, 100671718);
			BinaryObjectWithMap.NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr, 100671719);
			BinaryObjectWithMap.NativeMethodInfoPtr_Set_Internal_Void_Int32_String_Int32_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr, 100671720);
			BinaryObjectWithMap.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr, 100671721);
			BinaryObjectWithMap.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr, 100671722);
			BinaryObjectWithMap.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr, 100671723);
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x0010A008 File Offset: 0x00108208
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryObjectWithMap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMap.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036F6 RID: 14070 RVA: 0x0010A044 File Offset: 0x00108244
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryObjectWithMap(BinaryHeaderEnum binaryHeaderEnum)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryObjectWithMap>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMap.NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036F7 RID: 14071 RVA: 0x0010A08C File Offset: 0x0010828C
		[CallerCount(0)]
		public unsafe void Set(int objectId, string name, int numMembers, Il2CppStringArray memberNames, int assemId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numMembers;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assemId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMap.NativeMethodInfoPtr_Set_Internal_Void_Int32_String_Int32_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036F8 RID: 14072 RVA: 0x0010A10C File Offset: 0x0010830C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345029, XrefRangeEnd = 345035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMap.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x0010A150 File Offset: 0x00108350
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345044, RefRangeEnd = 345045, XrefRangeStart = 345035, XrefRangeEnd = 345044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMap.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036FA RID: 14074 RVA: 0x0010A194 File Offset: 0x00108394
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMap.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036FB RID: 14075 RVA: 0x00013D66 File Offset: 0x00011F66
		public BinaryObjectWithMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x060036FC RID: 14076 RVA: 0x0010A1C8 File Offset: 0x001083C8
		// (set) Token: 0x060036FD RID: 14077 RVA: 0x00013D6F File Offset: 0x00011F6F
		public unsafe BinaryHeaderEnum binaryHeaderEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMap.NativeFieldInfoPtr_binaryHeaderEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMap.NativeFieldInfoPtr_binaryHeaderEnum)) = value;
			}
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x060036FE RID: 14078 RVA: 0x0010A1F0 File Offset: 0x001083F0
		// (set) Token: 0x060036FF RID: 14079 RVA: 0x00013D8A File Offset: 0x00011F8A
		public unsafe int objectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMap.NativeFieldInfoPtr_objectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMap.NativeFieldInfoPtr_objectId)) = value;
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06003700 RID: 14080 RVA: 0x0010A218 File Offset: 0x00108418
		// (set) Token: 0x06003701 RID: 14081 RVA: 0x00013DA5 File Offset: 0x00011FA5
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMap.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMap.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x06003702 RID: 14082 RVA: 0x0010A240 File Offset: 0x00108440
		// (set) Token: 0x06003703 RID: 14083 RVA: 0x00013DC4 File Offset: 0x00011FC4
		public unsafe int numMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMap.NativeFieldInfoPtr_numMembers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMap.NativeFieldInfoPtr_numMembers)) = value;
			}
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x06003704 RID: 14084 RVA: 0x0010A268 File Offset: 0x00108468
		// (set) Token: 0x06003705 RID: 14085 RVA: 0x00013DDF File Offset: 0x00011FDF
		public unsafe Il2CppStringArray memberNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMap.NativeFieldInfoPtr_memberNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMap.NativeFieldInfoPtr_memberNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x06003706 RID: 14086 RVA: 0x0010A298 File Offset: 0x00108498
		// (set) Token: 0x06003707 RID: 14087 RVA: 0x00013DFE File Offset: 0x00011FFE
		public unsafe int assemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMap.NativeFieldInfoPtr_assemId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMap.NativeFieldInfoPtr_assemId)) = value;
			}
		}

		// Token: 0x04002E31 RID: 11825
		private static readonly IntPtr NativeFieldInfoPtr_binaryHeaderEnum;

		// Token: 0x04002E32 RID: 11826
		private static readonly IntPtr NativeFieldInfoPtr_objectId;

		// Token: 0x04002E33 RID: 11827
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04002E34 RID: 11828
		private static readonly IntPtr NativeFieldInfoPtr_numMembers;

		// Token: 0x04002E35 RID: 11829
		private static readonly IntPtr NativeFieldInfoPtr_memberNames;

		// Token: 0x04002E36 RID: 11830
		private static readonly IntPtr NativeFieldInfoPtr_assemId;

		// Token: 0x04002E37 RID: 11831
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002E38 RID: 11832
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_0;

		// Token: 0x04002E39 RID: 11833
		private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_Int32_String_Int32_Il2CppStringArray_Int32_0;

		// Token: 0x04002E3A RID: 11834
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002E3B RID: 11835
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002E3C RID: 11836
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
