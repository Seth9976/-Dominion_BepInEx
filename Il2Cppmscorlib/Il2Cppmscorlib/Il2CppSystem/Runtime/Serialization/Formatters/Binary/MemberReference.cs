using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000363 RID: 867
	public sealed class MemberReference : Object
	{
		// Token: 0x06003746 RID: 14150 RVA: 0x0010AE88 File Offset: 0x00109088
		// Note: this type is marked as 'beforefieldinit'.
		static MemberReference()
		{
			Il2CppClassPointerStore<MemberReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "MemberReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberReference>.NativeClassPtr);
			MemberReference.NativeFieldInfoPtr_idRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberReference>.NativeClassPtr, "idRef");
			MemberReference.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberReference>.NativeClassPtr, 100671740);
			MemberReference.NativeMethodInfoPtr_Set_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberReference>.NativeClassPtr, 100671741);
			MemberReference.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberReference>.NativeClassPtr, 100671742);
			MemberReference.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberReference>.NativeClassPtr, 100671743);
			MemberReference.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberReference>.NativeClassPtr, 100671744);
		}

		// Token: 0x06003747 RID: 14151 RVA: 0x0010AF30 File Offset: 0x00109130
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberReference()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberReference>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberReference.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003748 RID: 14152 RVA: 0x0010AF6C File Offset: 0x0010916C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 21534, RefRangeEnd = 21538, XrefRangeStart = 21534, XrefRangeEnd = 21538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(int idRef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idRef;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberReference.NativeMethodInfoPtr_Set_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003749 RID: 14153 RVA: 0x0010AFAC File Offset: 0x001091AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 345126, RefRangeEnd = 345128, XrefRangeStart = 345123, XrefRangeEnd = 345126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberReference.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600374A RID: 14154 RVA: 0x0010AFF0 File Offset: 0x001091F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 345020, RefRangeEnd = 345022, XrefRangeStart = 345020, XrefRangeEnd = 345022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberReference.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600374B RID: 14155 RVA: 0x0010B034 File Offset: 0x00109234
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberReference.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600374C RID: 14156 RVA: 0x00014074 File Offset: 0x00012274
		public MemberReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x0600374D RID: 14157 RVA: 0x0010B068 File Offset: 0x00109268
		// (set) Token: 0x0600374E RID: 14158 RVA: 0x0001407D File Offset: 0x0001227D
		public unsafe int idRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberReference.NativeFieldInfoPtr_idRef);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberReference.NativeFieldInfoPtr_idRef)) = value;
			}
		}

		// Token: 0x04002E61 RID: 11873
		private static readonly IntPtr NativeFieldInfoPtr_idRef;

		// Token: 0x04002E62 RID: 11874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002E63 RID: 11875
		private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_Int32_0;

		// Token: 0x04002E64 RID: 11876
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002E65 RID: 11877
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002E66 RID: 11878
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
