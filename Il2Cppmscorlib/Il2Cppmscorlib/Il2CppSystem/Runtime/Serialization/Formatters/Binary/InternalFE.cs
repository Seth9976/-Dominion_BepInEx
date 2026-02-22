using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000387 RID: 903
	public sealed class InternalFE : Object
	{
		// Token: 0x06003AD0 RID: 15056 RVA: 0x00116BFC File Offset: 0x00114DFC
		// Note: this type is marked as 'beforefieldinit'.
		static InternalFE()
		{
			Il2CppClassPointerStore<InternalFE>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "InternalFE");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalFE>.NativeClassPtr);
			InternalFE.NativeFieldInfoPtr_FEtypeFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalFE>.NativeClassPtr, "FEtypeFormat");
			InternalFE.NativeFieldInfoPtr_FEassemblyFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalFE>.NativeClassPtr, "FEassemblyFormat");
			InternalFE.NativeFieldInfoPtr_FEsecurityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalFE>.NativeClassPtr, "FEsecurityLevel");
			InternalFE.NativeFieldInfoPtr_FEserializerTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalFE>.NativeClassPtr, "FEserializerTypeEnum");
			InternalFE.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalFE>.NativeClassPtr, 100672033);
		}

		// Token: 0x06003AD1 RID: 15057 RVA: 0x00116C90 File Offset: 0x00114E90
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalFE()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalFE>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalFE.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AD2 RID: 15058 RVA: 0x0001606B File Offset: 0x0001426B
		public InternalFE(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06003AD3 RID: 15059 RVA: 0x00116CCC File Offset: 0x00114ECC
		// (set) Token: 0x06003AD4 RID: 15060 RVA: 0x00016074 File Offset: 0x00014274
		public unsafe FormatterTypeStyle FEtypeFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalFE.NativeFieldInfoPtr_FEtypeFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalFE.NativeFieldInfoPtr_FEtypeFormat)) = value;
			}
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06003AD5 RID: 15061 RVA: 0x00116CF4 File Offset: 0x00114EF4
		// (set) Token: 0x06003AD6 RID: 15062 RVA: 0x0001608F File Offset: 0x0001428F
		public unsafe FormatterAssemblyStyle FEassemblyFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalFE.NativeFieldInfoPtr_FEassemblyFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalFE.NativeFieldInfoPtr_FEassemblyFormat)) = value;
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06003AD7 RID: 15063 RVA: 0x00116D1C File Offset: 0x00114F1C
		// (set) Token: 0x06003AD8 RID: 15064 RVA: 0x000160AA File Offset: 0x000142AA
		public unsafe TypeFilterLevel FEsecurityLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalFE.NativeFieldInfoPtr_FEsecurityLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalFE.NativeFieldInfoPtr_FEsecurityLevel)) = value;
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06003AD9 RID: 15065 RVA: 0x00116D44 File Offset: 0x00114F44
		// (set) Token: 0x06003ADA RID: 15066 RVA: 0x000160C5 File Offset: 0x000142C5
		public unsafe InternalSerializerTypeE FEserializerTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalFE.NativeFieldInfoPtr_FEserializerTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalFE.NativeFieldInfoPtr_FEserializerTypeEnum)) = value;
			}
		}

		// Token: 0x04003119 RID: 12569
		private static readonly IntPtr NativeFieldInfoPtr_FEtypeFormat;

		// Token: 0x0400311A RID: 12570
		private static readonly IntPtr NativeFieldInfoPtr_FEassemblyFormat;

		// Token: 0x0400311B RID: 12571
		private static readonly IntPtr NativeFieldInfoPtr_FEsecurityLevel;

		// Token: 0x0400311C RID: 12572
		private static readonly IntPtr NativeFieldInfoPtr_FEserializerTypeEnum;

		// Token: 0x0400311D RID: 12573
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
