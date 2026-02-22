using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200035D RID: 861
	public sealed class BinaryCrossAppDomainMap : Object
	{
		// Token: 0x060036E2 RID: 14050 RVA: 0x00109B30 File Offset: 0x00107D30
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryCrossAppDomainMap()
		{
			Il2CppClassPointerStore<BinaryCrossAppDomainMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryCrossAppDomainMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryCrossAppDomainMap>.NativeClassPtr);
			BinaryCrossAppDomainMap.NativeFieldInfoPtr_crossAppDomainArrayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryCrossAppDomainMap>.NativeClassPtr, "crossAppDomainArrayIndex");
			BinaryCrossAppDomainMap.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainMap>.NativeClassPtr, 100671710);
			BinaryCrossAppDomainMap.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainMap>.NativeClassPtr, 100671711);
			BinaryCrossAppDomainMap.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainMap>.NativeClassPtr, 100671712);
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x00109BB0 File Offset: 0x00107DB0
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryCrossAppDomainMap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryCrossAppDomainMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainMap.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x00109BEC File Offset: 0x00107DEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 345020, RefRangeEnd = 345022, XrefRangeStart = 345019, XrefRangeEnd = 345020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainMap.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036E5 RID: 14053 RVA: 0x00109C30 File Offset: 0x00107E30
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainMap.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E6 RID: 14054 RVA: 0x00013CFF File Offset: 0x00011EFF
		public BinaryCrossAppDomainMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x060036E7 RID: 14055 RVA: 0x00109C64 File Offset: 0x00107E64
		// (set) Token: 0x060036E8 RID: 14056 RVA: 0x00013D08 File Offset: 0x00011F08
		public unsafe int crossAppDomainArrayIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainMap.NativeFieldInfoPtr_crossAppDomainArrayIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainMap.NativeFieldInfoPtr_crossAppDomainArrayIndex)) = value;
			}
		}

		// Token: 0x04002E26 RID: 11814
		private static readonly IntPtr NativeFieldInfoPtr_crossAppDomainArrayIndex;

		// Token: 0x04002E27 RID: 11815
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002E28 RID: 11816
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002E29 RID: 11817
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
