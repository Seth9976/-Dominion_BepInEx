using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000362 RID: 866
	public sealed class MemberPrimitiveUnTyped : Object
	{
		// Token: 0x0600373A RID: 14138 RVA: 0x0010ABD8 File Offset: 0x00108DD8
		// Note: this type is marked as 'beforefieldinit'.
		static MemberPrimitiveUnTyped()
		{
			Il2CppClassPointerStore<MemberPrimitiveUnTyped>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "MemberPrimitiveUnTyped");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberPrimitiveUnTyped>.NativeClassPtr);
			MemberPrimitiveUnTyped.NativeFieldInfoPtr_typeInformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberPrimitiveUnTyped>.NativeClassPtr, "typeInformation");
			MemberPrimitiveUnTyped.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberPrimitiveUnTyped>.NativeClassPtr, "value");
			MemberPrimitiveUnTyped.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveUnTyped>.NativeClassPtr, 100671734);
			MemberPrimitiveUnTyped.NativeMethodInfoPtr_Set_Internal_Void_InternalPrimitiveTypeE_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveUnTyped>.NativeClassPtr, 100671735);
			MemberPrimitiveUnTyped.NativeMethodInfoPtr_Set_Internal_Void_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveUnTyped>.NativeClassPtr, 100671736);
			MemberPrimitiveUnTyped.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveUnTyped>.NativeClassPtr, 100671737);
			MemberPrimitiveUnTyped.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveUnTyped>.NativeClassPtr, 100671738);
			MemberPrimitiveUnTyped.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveUnTyped>.NativeClassPtr, 100671739);
		}

		// Token: 0x0600373B RID: 14139 RVA: 0x0010ACA8 File Offset: 0x00108EA8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberPrimitiveUnTyped()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberPrimitiveUnTyped>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveUnTyped.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600373C RID: 14140 RVA: 0x0010ACE4 File Offset: 0x00108EE4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 344957, RefRangeEnd = 344962, XrefRangeStart = 344957, XrefRangeEnd = 344962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(InternalPrimitiveTypeE typeInformation, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeInformation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveUnTyped.NativeMethodInfoPtr_Set_Internal_Void_InternalPrimitiveTypeE_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600373D RID: 14141 RVA: 0x0010AD34 File Offset: 0x00108F34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 21534, RefRangeEnd = 21538, XrefRangeStart = 21534, XrefRangeEnd = 21538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(InternalPrimitiveTypeE typeInformation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeInformation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveUnTyped.NativeMethodInfoPtr_Set_Internal_Void_InternalPrimitiveTypeE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600373E RID: 14142 RVA: 0x0010AD74 File Offset: 0x00108F74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 345119, RefRangeEnd = 345121, XrefRangeStart = 345117, XrefRangeEnd = 345119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveUnTyped.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600373F RID: 14143 RVA: 0x0010ADB8 File Offset: 0x00108FB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345122, RefRangeEnd = 345123, XrefRangeStart = 345121, XrefRangeEnd = 345122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveUnTyped.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003740 RID: 14144 RVA: 0x0010ADFC File Offset: 0x00108FFC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveUnTyped.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003741 RID: 14145 RVA: 0x00014031 File Offset: 0x00012231
		public MemberPrimitiveUnTyped(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x06003742 RID: 14146 RVA: 0x0010AE30 File Offset: 0x00109030
		// (set) Token: 0x06003743 RID: 14147 RVA: 0x0001403A File Offset: 0x0001223A
		public unsafe InternalPrimitiveTypeE typeInformation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberPrimitiveUnTyped.NativeFieldInfoPtr_typeInformation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberPrimitiveUnTyped.NativeFieldInfoPtr_typeInformation)) = value;
			}
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x06003744 RID: 14148 RVA: 0x0010AE58 File Offset: 0x00109058
		// (set) Token: 0x06003745 RID: 14149 RVA: 0x00014055 File Offset: 0x00012255
		public unsafe Object value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberPrimitiveUnTyped.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberPrimitiveUnTyped.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002E59 RID: 11865
		private static readonly IntPtr NativeFieldInfoPtr_typeInformation;

		// Token: 0x04002E5A RID: 11866
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04002E5B RID: 11867
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002E5C RID: 11868
		private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_InternalPrimitiveTypeE_Object_0;

		// Token: 0x04002E5D RID: 11869
		private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_InternalPrimitiveTypeE_0;

		// Token: 0x04002E5E RID: 11870
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002E5F RID: 11871
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002E60 RID: 11872
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
