using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200035E RID: 862
	public sealed class MemberPrimitiveTyped : Object
	{
		// Token: 0x060036E9 RID: 14057 RVA: 0x00109C8C File Offset: 0x00107E8C
		// Note: this type is marked as 'beforefieldinit'.
		static MemberPrimitiveTyped()
		{
			Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "MemberPrimitiveTyped");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr);
			MemberPrimitiveTyped.NativeFieldInfoPtr_primitiveTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr, "primitiveTypeEnum");
			MemberPrimitiveTyped.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr, "value");
			MemberPrimitiveTyped.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr, 100671713);
			MemberPrimitiveTyped.NativeMethodInfoPtr_Set_Internal_Void_InternalPrimitiveTypeE_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr, 100671714);
			MemberPrimitiveTyped.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr, 100671715);
			MemberPrimitiveTyped.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr, 100671716);
			MemberPrimitiveTyped.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr, 100671717);
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x00109D48 File Offset: 0x00107F48
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberPrimitiveTyped()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveTyped.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x00109D84 File Offset: 0x00107F84
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 344957, RefRangeEnd = 344962, XrefRangeStart = 344957, XrefRangeEnd = 344962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(InternalPrimitiveTypeE primitiveTypeEnum, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref primitiveTypeEnum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveTyped.NativeMethodInfoPtr_Set_Internal_Void_InternalPrimitiveTypeE_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036EC RID: 14060 RVA: 0x00109DD4 File Offset: 0x00107FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345022, XrefRangeEnd = 345026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveTyped.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036ED RID: 14061 RVA: 0x00109E18 File Offset: 0x00108018
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345028, RefRangeEnd = 345029, XrefRangeStart = 345026, XrefRangeEnd = 345028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveTyped.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x00109E5C File Offset: 0x0010805C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveTyped.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036EF RID: 14063 RVA: 0x00013D23 File Offset: 0x00011F23
		public MemberPrimitiveTyped(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x060036F0 RID: 14064 RVA: 0x00109E90 File Offset: 0x00108090
		// (set) Token: 0x060036F1 RID: 14065 RVA: 0x00013D2C File Offset: 0x00011F2C
		public unsafe InternalPrimitiveTypeE primitiveTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberPrimitiveTyped.NativeFieldInfoPtr_primitiveTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberPrimitiveTyped.NativeFieldInfoPtr_primitiveTypeEnum)) = value;
			}
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x060036F2 RID: 14066 RVA: 0x00109EB8 File Offset: 0x001080B8
		// (set) Token: 0x060036F3 RID: 14067 RVA: 0x00013D47 File Offset: 0x00011F47
		public unsafe Object value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberPrimitiveTyped.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberPrimitiveTyped.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002E2A RID: 11818
		private static readonly IntPtr NativeFieldInfoPtr_primitiveTypeEnum;

		// Token: 0x04002E2B RID: 11819
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04002E2C RID: 11820
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002E2D RID: 11821
		private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_InternalPrimitiveTypeE_Object_0;

		// Token: 0x04002E2E RID: 11822
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002E2F RID: 11823
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002E30 RID: 11824
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
