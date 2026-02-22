using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000364 RID: 868
	public sealed class ObjectNull : Object
	{
		// Token: 0x0600374F RID: 14159 RVA: 0x0010B090 File Offset: 0x00109290
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectNull()
		{
			Il2CppClassPointerStore<ObjectNull>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ObjectNull");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectNull>.NativeClassPtr);
			ObjectNull.NativeFieldInfoPtr_nullCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectNull>.NativeClassPtr, "nullCount");
			ObjectNull.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNull>.NativeClassPtr, 100671745);
			ObjectNull.NativeMethodInfoPtr_SetNullCount_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNull>.NativeClassPtr, 100671746);
			ObjectNull.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNull>.NativeClassPtr, 100671747);
			ObjectNull.NativeMethodInfoPtr_Read_Public_Void___BinaryParser_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNull>.NativeClassPtr, 100671748);
			ObjectNull.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNull>.NativeClassPtr, 100671749);
		}

		// Token: 0x06003750 RID: 14160 RVA: 0x0010B138 File Offset: 0x00109338
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectNull()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectNull>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectNull.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003751 RID: 14161 RVA: 0x0010B174 File Offset: 0x00109374
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 21534, RefRangeEnd = 21538, XrefRangeStart = 21534, XrefRangeEnd = 21538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNullCount(int nullCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nullCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectNull.NativeMethodInfoPtr_SetNullCount_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003752 RID: 14162 RVA: 0x0010B1B4 File Offset: 0x001093B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 345134, RefRangeEnd = 345136, XrefRangeStart = 345128, XrefRangeEnd = 345134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectNull.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003753 RID: 14163 RVA: 0x0010B1F8 File Offset: 0x001093F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345137, RefRangeEnd = 345138, XrefRangeStart = 345136, XrefRangeEnd = 345137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input, BinaryHeaderEnum binaryHeaderEnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref binaryHeaderEnum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectNull.NativeMethodInfoPtr_Read_Public_Void___BinaryParser_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003754 RID: 14164 RVA: 0x0010B248 File Offset: 0x00109448
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectNull.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003755 RID: 14165 RVA: 0x00014098 File Offset: 0x00012298
		public ObjectNull(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06003756 RID: 14166 RVA: 0x0010B27C File Offset: 0x0010947C
		// (set) Token: 0x06003757 RID: 14167 RVA: 0x000140A1 File Offset: 0x000122A1
		public unsafe int nullCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectNull.NativeFieldInfoPtr_nullCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectNull.NativeFieldInfoPtr_nullCount)) = value;
			}
		}

		// Token: 0x04002E67 RID: 11879
		private static readonly IntPtr NativeFieldInfoPtr_nullCount;

		// Token: 0x04002E68 RID: 11880
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002E69 RID: 11881
		private static readonly IntPtr NativeMethodInfoPtr_SetNullCount_Internal_Void_Int32_0;

		// Token: 0x04002E6A RID: 11882
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002E6B RID: 11883
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void___BinaryParser_BinaryHeaderEnum_0;

		// Token: 0x04002E6C RID: 11884
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
