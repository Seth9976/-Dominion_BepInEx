using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000356 RID: 854
	public sealed class BinaryAssembly : Object
	{
		// Token: 0x06003687 RID: 13959 RVA: 0x00108B0C File Offset: 0x00106D0C
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryAssembly()
		{
			Il2CppClassPointerStore<BinaryAssembly>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryAssembly");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryAssembly>.NativeClassPtr);
			BinaryAssembly.NativeFieldInfoPtr_assemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryAssembly>.NativeClassPtr, "assemId");
			BinaryAssembly.NativeFieldInfoPtr_assemblyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryAssembly>.NativeClassPtr, "assemblyString");
			BinaryAssembly.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryAssembly>.NativeClassPtr, 100671682);
			BinaryAssembly.NativeMethodInfoPtr_Set_Internal_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryAssembly>.NativeClassPtr, 100671683);
			BinaryAssembly.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryAssembly>.NativeClassPtr, 100671684);
			BinaryAssembly.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryAssembly>.NativeClassPtr, 100671685);
			BinaryAssembly.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryAssembly>.NativeClassPtr, 100671686);
		}

		// Token: 0x06003688 RID: 13960 RVA: 0x00108BC8 File Offset: 0x00106DC8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryAssembly()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryAssembly>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryAssembly.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003689 RID: 13961 RVA: 0x00108C04 File Offset: 0x00106E04
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 344957, RefRangeEnd = 344962, XrefRangeStart = 344957, XrefRangeEnd = 344957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(int assemId, string assemblyString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref assemId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryAssembly.NativeMethodInfoPtr_Set_Internal_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600368A RID: 13962 RVA: 0x00108C54 File Offset: 0x00106E54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 344969, RefRangeEnd = 344970, XrefRangeStart = 344962, XrefRangeEnd = 344969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryAssembly.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600368B RID: 13963 RVA: 0x00108C98 File Offset: 0x00106E98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 344972, RefRangeEnd = 344974, XrefRangeStart = 344970, XrefRangeEnd = 344972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryAssembly.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600368C RID: 13964 RVA: 0x00108CDC File Offset: 0x00106EDC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryAssembly.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x000139F6 File Offset: 0x00011BF6
		public BinaryAssembly(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x0600368E RID: 13966 RVA: 0x00108D10 File Offset: 0x00106F10
		// (set) Token: 0x0600368F RID: 13967 RVA: 0x000139FF File Offset: 0x00011BFF
		public unsafe int assemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryAssembly.NativeFieldInfoPtr_assemId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryAssembly.NativeFieldInfoPtr_assemId)) = value;
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06003690 RID: 13968 RVA: 0x00108D38 File Offset: 0x00106F38
		// (set) Token: 0x06003691 RID: 13969 RVA: 0x00013A1A File Offset: 0x00011C1A
		public unsafe string assemblyString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryAssembly.NativeFieldInfoPtr_assemblyString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryAssembly.NativeFieldInfoPtr_assemblyString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002DF2 RID: 11762
		private static readonly IntPtr NativeFieldInfoPtr_assemId;

		// Token: 0x04002DF3 RID: 11763
		private static readonly IntPtr NativeFieldInfoPtr_assemblyString;

		// Token: 0x04002DF4 RID: 11764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002DF5 RID: 11765
		private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_Int32_String_0;

		// Token: 0x04002DF6 RID: 11766
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002DF7 RID: 11767
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002DF8 RID: 11768
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
