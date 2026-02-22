using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000355 RID: 853
	public sealed class SerializationHeaderRecord : Object
	{
		// Token: 0x06003671 RID: 13937 RVA: 0x001086F8 File Offset: 0x001068F8
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationHeaderRecord()
		{
			Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "SerializationHeaderRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr);
			SerializationHeaderRecord.NativeFieldInfoPtr_binaryFormatterMajorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, "binaryFormatterMajorVersion");
			SerializationHeaderRecord.NativeFieldInfoPtr_binaryFormatterMinorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, "binaryFormatterMinorVersion");
			SerializationHeaderRecord.NativeFieldInfoPtr_binaryHeaderEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, "binaryHeaderEnum");
			SerializationHeaderRecord.NativeFieldInfoPtr_topId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, "topId");
			SerializationHeaderRecord.NativeFieldInfoPtr_headerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, "headerId");
			SerializationHeaderRecord.NativeFieldInfoPtr_majorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, "majorVersion");
			SerializationHeaderRecord.NativeFieldInfoPtr_minorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, "minorVersion");
			SerializationHeaderRecord.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, 100671676);
			SerializationHeaderRecord.NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, 100671677);
			SerializationHeaderRecord.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, 100671678);
			SerializationHeaderRecord.NativeMethodInfoPtr_GetInt32_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, 100671679);
			SerializationHeaderRecord.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, 100671680);
			SerializationHeaderRecord.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, 100671681);
		}

		// Token: 0x06003672 RID: 13938 RVA: 0x0010882C File Offset: 0x00106A2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 344942, RefRangeEnd = 344944, XrefRangeStart = 344941, XrefRangeEnd = 344942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationHeaderRecord()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationHeaderRecord.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003673 RID: 13939 RVA: 0x00108868 File Offset: 0x00106A68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 344945, RefRangeEnd = 344946, XrefRangeStart = 344944, XrefRangeEnd = 344945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationHeaderRecord(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headerId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref majorVersion;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minorVersion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationHeaderRecord.NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003674 RID: 13940 RVA: 0x001088E8 File Offset: 0x00106AE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 344952, RefRangeEnd = 344953, XrefRangeStart = 344946, XrefRangeEnd = 344952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationHeaderRecord.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003675 RID: 13941 RVA: 0x0010892C File Offset: 0x00106B2C
		[CallerCount(0)]
		public unsafe static int GetInt32(Il2CppStructArray<byte> buffer, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationHeaderRecord.NativeMethodInfoPtr_GetInt32_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003676 RID: 13942 RVA: 0x0010897C File Offset: 0x00106B7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 344955, RefRangeEnd = 344957, XrefRangeStart = 344953, XrefRangeEnd = 344955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationHeaderRecord.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003677 RID: 13943 RVA: 0x001089C0 File Offset: 0x00106BC0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationHeaderRecord.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003678 RID: 13944 RVA: 0x00013930 File Offset: 0x00011B30
		public SerializationHeaderRecord(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x06003679 RID: 13945 RVA: 0x001089F4 File Offset: 0x00106BF4
		// (set) Token: 0x0600367A RID: 13946 RVA: 0x00013939 File Offset: 0x00011B39
		public unsafe int binaryFormatterMajorVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_binaryFormatterMajorVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_binaryFormatterMajorVersion)) = value;
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x0600367B RID: 13947 RVA: 0x00108A1C File Offset: 0x00106C1C
		// (set) Token: 0x0600367C RID: 13948 RVA: 0x00013954 File Offset: 0x00011B54
		public unsafe int binaryFormatterMinorVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_binaryFormatterMinorVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_binaryFormatterMinorVersion)) = value;
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x0600367D RID: 13949 RVA: 0x00108A44 File Offset: 0x00106C44
		// (set) Token: 0x0600367E RID: 13950 RVA: 0x0001396F File Offset: 0x00011B6F
		public unsafe BinaryHeaderEnum binaryHeaderEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_binaryHeaderEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_binaryHeaderEnum)) = value;
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x0600367F RID: 13951 RVA: 0x00108A6C File Offset: 0x00106C6C
		// (set) Token: 0x06003680 RID: 13952 RVA: 0x0001398A File Offset: 0x00011B8A
		public unsafe int topId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_topId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_topId)) = value;
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x06003681 RID: 13953 RVA: 0x00108A94 File Offset: 0x00106C94
		// (set) Token: 0x06003682 RID: 13954 RVA: 0x000139A5 File Offset: 0x00011BA5
		public unsafe int headerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_headerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_headerId)) = value;
			}
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x06003683 RID: 13955 RVA: 0x00108ABC File Offset: 0x00106CBC
		// (set) Token: 0x06003684 RID: 13956 RVA: 0x000139C0 File Offset: 0x00011BC0
		public unsafe int majorVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_majorVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_majorVersion)) = value;
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x06003685 RID: 13957 RVA: 0x00108AE4 File Offset: 0x00106CE4
		// (set) Token: 0x06003686 RID: 13958 RVA: 0x000139DB File Offset: 0x00011BDB
		public unsafe int minorVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_minorVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_minorVersion)) = value;
			}
		}

		// Token: 0x04002DE5 RID: 11749
		private static readonly IntPtr NativeFieldInfoPtr_binaryFormatterMajorVersion;

		// Token: 0x04002DE6 RID: 11750
		private static readonly IntPtr NativeFieldInfoPtr_binaryFormatterMinorVersion;

		// Token: 0x04002DE7 RID: 11751
		private static readonly IntPtr NativeFieldInfoPtr_binaryHeaderEnum;

		// Token: 0x04002DE8 RID: 11752
		private static readonly IntPtr NativeFieldInfoPtr_topId;

		// Token: 0x04002DE9 RID: 11753
		private static readonly IntPtr NativeFieldInfoPtr_headerId;

		// Token: 0x04002DEA RID: 11754
		private static readonly IntPtr NativeFieldInfoPtr_majorVersion;

		// Token: 0x04002DEB RID: 11755
		private static readonly IntPtr NativeFieldInfoPtr_minorVersion;

		// Token: 0x04002DEC RID: 11756
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002DED RID: 11757
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002DEE RID: 11758
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002DEF RID: 11759
		private static readonly IntPtr NativeMethodInfoPtr_GetInt32_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04002DF0 RID: 11760
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002DF1 RID: 11761
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
