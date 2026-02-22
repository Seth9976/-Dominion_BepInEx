using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200035B RID: 859
	public sealed class BinaryObjectString : Object
	{
		// Token: 0x060036CE RID: 14030 RVA: 0x00109744 File Offset: 0x00107944
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryObjectString()
		{
			Il2CppClassPointerStore<BinaryObjectString>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryObjectString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryObjectString>.NativeClassPtr);
			BinaryObjectString.NativeFieldInfoPtr_objectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectString>.NativeClassPtr, "objectId");
			BinaryObjectString.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectString>.NativeClassPtr, "value");
			BinaryObjectString.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectString>.NativeClassPtr, 100671702);
			BinaryObjectString.NativeMethodInfoPtr_Set_Internal_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectString>.NativeClassPtr, 100671703);
			BinaryObjectString.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectString>.NativeClassPtr, 100671704);
			BinaryObjectString.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectString>.NativeClassPtr, 100671705);
			BinaryObjectString.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectString>.NativeClassPtr, 100671706);
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x00109800 File Offset: 0x00107A00
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryObjectString()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryObjectString>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectString.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x0010983C File Offset: 0x00107A3C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 344957, RefRangeEnd = 344962, XrefRangeStart = 344957, XrefRangeEnd = 344962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(int objectId, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectString.NativeMethodInfoPtr_Set_Internal_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x0010988C File Offset: 0x00107A8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 345017, RefRangeEnd = 345019, XrefRangeStart = 345013, XrefRangeEnd = 345017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectString.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x001098D0 File Offset: 0x00107AD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 344972, RefRangeEnd = 344974, XrefRangeStart = 344972, XrefRangeEnd = 344974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectString.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x00109914 File Offset: 0x00107B14
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectString.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x00013C7D File Offset: 0x00011E7D
		public BinaryObjectString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x060036D5 RID: 14037 RVA: 0x00109948 File Offset: 0x00107B48
		// (set) Token: 0x060036D6 RID: 14038 RVA: 0x00013C86 File Offset: 0x00011E86
		public unsafe int objectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectString.NativeFieldInfoPtr_objectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectString.NativeFieldInfoPtr_objectId)) = value;
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x060036D7 RID: 14039 RVA: 0x00109970 File Offset: 0x00107B70
		// (set) Token: 0x060036D8 RID: 14040 RVA: 0x00013CA1 File Offset: 0x00011EA1
		public unsafe string value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectString.NativeFieldInfoPtr_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectString.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002E1A RID: 11802
		private static readonly IntPtr NativeFieldInfoPtr_objectId;

		// Token: 0x04002E1B RID: 11803
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04002E1C RID: 11804
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002E1D RID: 11805
		private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_Int32_String_0;

		// Token: 0x04002E1E RID: 11806
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002E1F RID: 11807
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002E20 RID: 11808
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
