using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000357 RID: 855
	public sealed class BinaryCrossAppDomainAssembly : Object
	{
		// Token: 0x06003692 RID: 13970 RVA: 0x00108D60 File Offset: 0x00106F60
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryCrossAppDomainAssembly()
		{
			Il2CppClassPointerStore<BinaryCrossAppDomainAssembly>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryCrossAppDomainAssembly");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryCrossAppDomainAssembly>.NativeClassPtr);
			BinaryCrossAppDomainAssembly.NativeFieldInfoPtr_assemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryCrossAppDomainAssembly>.NativeClassPtr, "assemId");
			BinaryCrossAppDomainAssembly.NativeFieldInfoPtr_assemblyIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryCrossAppDomainAssembly>.NativeClassPtr, "assemblyIndex");
			BinaryCrossAppDomainAssembly.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainAssembly>.NativeClassPtr, 100671687);
			BinaryCrossAppDomainAssembly.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainAssembly>.NativeClassPtr, 100671688);
			BinaryCrossAppDomainAssembly.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainAssembly>.NativeClassPtr, 100671689);
		}

		// Token: 0x06003693 RID: 13971 RVA: 0x00108DF4 File Offset: 0x00106FF4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryCrossAppDomainAssembly()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryCrossAppDomainAssembly>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainAssembly.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003694 RID: 13972 RVA: 0x00108E30 File Offset: 0x00107030
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 344976, RefRangeEnd = 344979, XrefRangeStart = 344974, XrefRangeEnd = 344976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainAssembly.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003695 RID: 13973 RVA: 0x00108E74 File Offset: 0x00107074
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainAssembly.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003696 RID: 13974 RVA: 0x00013A39 File Offset: 0x00011C39
		public BinaryCrossAppDomainAssembly(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06003697 RID: 13975 RVA: 0x00108EA8 File Offset: 0x001070A8
		// (set) Token: 0x06003698 RID: 13976 RVA: 0x00013A42 File Offset: 0x00011C42
		public unsafe int assemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainAssembly.NativeFieldInfoPtr_assemId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainAssembly.NativeFieldInfoPtr_assemId)) = value;
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x06003699 RID: 13977 RVA: 0x00108ED0 File Offset: 0x001070D0
		// (set) Token: 0x0600369A RID: 13978 RVA: 0x00013A5D File Offset: 0x00011C5D
		public unsafe int assemblyIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainAssembly.NativeFieldInfoPtr_assemblyIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainAssembly.NativeFieldInfoPtr_assemblyIndex)) = value;
			}
		}

		// Token: 0x04002DF9 RID: 11769
		private static readonly IntPtr NativeFieldInfoPtr_assemId;

		// Token: 0x04002DFA RID: 11770
		private static readonly IntPtr NativeFieldInfoPtr_assemblyIndex;

		// Token: 0x04002DFB RID: 11771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002DFC RID: 11772
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002DFD RID: 11773
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
