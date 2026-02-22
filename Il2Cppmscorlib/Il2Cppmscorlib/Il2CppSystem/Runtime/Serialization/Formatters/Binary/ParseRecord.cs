using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000381 RID: 897
	public sealed class ParseRecord : Object
	{
		// Token: 0x06003A34 RID: 14900 RVA: 0x001152A8 File Offset: 0x001134A8
		// Note: this type is marked as 'beforefieldinit'.
		static ParseRecord()
		{
			Il2CppClassPointerStore<ParseRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ParseRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr);
			ParseRecord.NativeFieldInfoPtr_parseRecordIdCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "parseRecordIdCount");
			ParseRecord.NativeFieldInfoPtr_PRparseTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRparseTypeEnum");
			ParseRecord.NativeFieldInfoPtr_PRobjectTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRobjectTypeEnum");
			ParseRecord.NativeFieldInfoPtr_PRarrayTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRarrayTypeEnum");
			ParseRecord.NativeFieldInfoPtr_PRmemberTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRmemberTypeEnum");
			ParseRecord.NativeFieldInfoPtr_PRmemberValueEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRmemberValueEnum");
			ParseRecord.NativeFieldInfoPtr_PRobjectPositionEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRobjectPositionEnum");
			ParseRecord.NativeFieldInfoPtr_PRname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRname");
			ParseRecord.NativeFieldInfoPtr_PRvalue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRvalue");
			ParseRecord.NativeFieldInfoPtr_PRvarValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRvarValue");
			ParseRecord.NativeFieldInfoPtr_PRkeyDt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRkeyDt");
			ParseRecord.NativeFieldInfoPtr_PRdtType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRdtType");
			ParseRecord.NativeFieldInfoPtr_PRdtTypeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRdtTypeCode");
			ParseRecord.NativeFieldInfoPtr_PRisEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRisEnum");
			ParseRecord.NativeFieldInfoPtr_PRobjectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRobjectId");
			ParseRecord.NativeFieldInfoPtr_PRidRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRidRef");
			ParseRecord.NativeFieldInfoPtr_PRarrayElementTypeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRarrayElementTypeString");
			ParseRecord.NativeFieldInfoPtr_PRarrayElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRarrayElementType");
			ParseRecord.NativeFieldInfoPtr_PRisArrayVariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRisArrayVariant");
			ParseRecord.NativeFieldInfoPtr_PRarrayElementTypeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRarrayElementTypeCode");
			ParseRecord.NativeFieldInfoPtr_PRrank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRrank");
			ParseRecord.NativeFieldInfoPtr_PRlengthA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRlengthA");
			ParseRecord.NativeFieldInfoPtr_PRpositionA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRpositionA");
			ParseRecord.NativeFieldInfoPtr_PRlowerBoundA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRlowerBoundA");
			ParseRecord.NativeFieldInfoPtr_PRupperBoundA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRupperBoundA");
			ParseRecord.NativeFieldInfoPtr_PRindexMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRindexMap");
			ParseRecord.NativeFieldInfoPtr_PRmemberIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRmemberIndex");
			ParseRecord.NativeFieldInfoPtr_PRlinearlength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRlinearlength");
			ParseRecord.NativeFieldInfoPtr_PRrectangularMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRrectangularMap");
			ParseRecord.NativeFieldInfoPtr_PRisLowerBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRisLowerBound");
			ParseRecord.NativeFieldInfoPtr_PRtopId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRtopId");
			ParseRecord.NativeFieldInfoPtr_PRheaderId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRheaderId");
			ParseRecord.NativeFieldInfoPtr_PRobjectInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRobjectInfo");
			ParseRecord.NativeFieldInfoPtr_PRisValueTypeFixup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRisValueTypeFixup");
			ParseRecord.NativeFieldInfoPtr_PRnewObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRnewObj");
			ParseRecord.NativeFieldInfoPtr_PRobjectA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRobjectA");
			ParseRecord.NativeFieldInfoPtr_PRprimitiveArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRprimitiveArray");
			ParseRecord.NativeFieldInfoPtr_PRisRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRisRegistered");
			ParseRecord.NativeFieldInfoPtr_PRmemberData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRmemberData");
			ParseRecord.NativeFieldInfoPtr_PRsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRsi");
			ParseRecord.NativeFieldInfoPtr_PRnullCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRnullCount");
			ParseRecord.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, 100672003);
			ParseRecord.NativeMethodInfoPtr_Init_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, 100672004);
		}

		// Token: 0x06003A35 RID: 14901 RVA: 0x00115634 File Offset: 0x00113834
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParseRecord()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseRecord.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A36 RID: 14902 RVA: 0x00115670 File Offset: 0x00113870
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 348468, RefRangeEnd = 348475, XrefRangeStart = 348468, XrefRangeEnd = 348468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseRecord.NativeMethodInfoPtr_Init_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A37 RID: 14903 RVA: 0x000159B6 File Offset: 0x00013BB6
		public ParseRecord(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x06003A38 RID: 14904 RVA: 0x001156A4 File Offset: 0x001138A4
		// (set) Token: 0x06003A39 RID: 14905 RVA: 0x000159BF File Offset: 0x00013BBF
		public unsafe static int parseRecordIdCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ParseRecord.NativeFieldInfoPtr_parseRecordIdCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ParseRecord.NativeFieldInfoPtr_parseRecordIdCount, (void*)(&value));
			}
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06003A3A RID: 14906 RVA: 0x001156C0 File Offset: 0x001138C0
		// (set) Token: 0x06003A3B RID: 14907 RVA: 0x000159CD File Offset: 0x00013BCD
		public unsafe InternalParseTypeE PRparseTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRparseTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRparseTypeEnum)) = value;
			}
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x06003A3C RID: 14908 RVA: 0x001156E8 File Offset: 0x001138E8
		// (set) Token: 0x06003A3D RID: 14909 RVA: 0x000159E8 File Offset: 0x00013BE8
		public unsafe InternalObjectTypeE PRobjectTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectTypeEnum)) = value;
			}
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06003A3E RID: 14910 RVA: 0x00115710 File Offset: 0x00113910
		// (set) Token: 0x06003A3F RID: 14911 RVA: 0x00015A03 File Offset: 0x00013C03
		public unsafe InternalArrayTypeE PRarrayTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRarrayTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRarrayTypeEnum)) = value;
			}
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x06003A40 RID: 14912 RVA: 0x00115738 File Offset: 0x00113938
		// (set) Token: 0x06003A41 RID: 14913 RVA: 0x00015A1E File Offset: 0x00013C1E
		public unsafe InternalMemberTypeE PRmemberTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRmemberTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRmemberTypeEnum)) = value;
			}
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06003A42 RID: 14914 RVA: 0x00115760 File Offset: 0x00113960
		// (set) Token: 0x06003A43 RID: 14915 RVA: 0x00015A39 File Offset: 0x00013C39
		public unsafe InternalMemberValueE PRmemberValueEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRmemberValueEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRmemberValueEnum)) = value;
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06003A44 RID: 14916 RVA: 0x00115788 File Offset: 0x00113988
		// (set) Token: 0x06003A45 RID: 14917 RVA: 0x00015A54 File Offset: 0x00013C54
		public unsafe InternalObjectPositionE PRobjectPositionEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectPositionEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectPositionEnum)) = value;
			}
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06003A46 RID: 14918 RVA: 0x001157B0 File Offset: 0x001139B0
		// (set) Token: 0x06003A47 RID: 14919 RVA: 0x00015A6F File Offset: 0x00013C6F
		public unsafe string PRname
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRname);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRname), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06003A48 RID: 14920 RVA: 0x001157D8 File Offset: 0x001139D8
		// (set) Token: 0x06003A49 RID: 14921 RVA: 0x00015A8E File Offset: 0x00013C8E
		public unsafe string PRvalue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRvalue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRvalue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06003A4A RID: 14922 RVA: 0x00115800 File Offset: 0x00113A00
		// (set) Token: 0x06003A4B RID: 14923 RVA: 0x00015AAD File Offset: 0x00013CAD
		public unsafe Object PRvarValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRvarValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRvarValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06003A4C RID: 14924 RVA: 0x00115830 File Offset: 0x00113A30
		// (set) Token: 0x06003A4D RID: 14925 RVA: 0x00015ACC File Offset: 0x00013CCC
		public unsafe string PRkeyDt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRkeyDt);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRkeyDt), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06003A4E RID: 14926 RVA: 0x00115858 File Offset: 0x00113A58
		// (set) Token: 0x06003A4F RID: 14927 RVA: 0x00015AEB File Offset: 0x00013CEB
		public unsafe Type PRdtType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRdtType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRdtType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06003A50 RID: 14928 RVA: 0x00115888 File Offset: 0x00113A88
		// (set) Token: 0x06003A51 RID: 14929 RVA: 0x00015B0A File Offset: 0x00013D0A
		public unsafe InternalPrimitiveTypeE PRdtTypeCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRdtTypeCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRdtTypeCode)) = value;
			}
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06003A52 RID: 14930 RVA: 0x001158B0 File Offset: 0x00113AB0
		// (set) Token: 0x06003A53 RID: 14931 RVA: 0x00015B25 File Offset: 0x00013D25
		public unsafe bool PRisEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisEnum)) = value;
			}
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06003A54 RID: 14932 RVA: 0x001158D8 File Offset: 0x00113AD8
		// (set) Token: 0x06003A55 RID: 14933 RVA: 0x00015B40 File Offset: 0x00013D40
		public unsafe long PRobjectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectId)) = value;
			}
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x06003A56 RID: 14934 RVA: 0x00115900 File Offset: 0x00113B00
		// (set) Token: 0x06003A57 RID: 14935 RVA: 0x00015B5B File Offset: 0x00013D5B
		public unsafe long PRidRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRidRef);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRidRef)) = value;
			}
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06003A58 RID: 14936 RVA: 0x00115928 File Offset: 0x00113B28
		// (set) Token: 0x06003A59 RID: 14937 RVA: 0x00015B76 File Offset: 0x00013D76
		public unsafe string PRarrayElementTypeString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRarrayElementTypeString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRarrayElementTypeString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06003A5A RID: 14938 RVA: 0x00115950 File Offset: 0x00113B50
		// (set) Token: 0x06003A5B RID: 14939 RVA: 0x00015B95 File Offset: 0x00013D95
		public unsafe Type PRarrayElementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRarrayElementType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRarrayElementType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06003A5C RID: 14940 RVA: 0x00115980 File Offset: 0x00113B80
		// (set) Token: 0x06003A5D RID: 14941 RVA: 0x00015BB4 File Offset: 0x00013DB4
		public unsafe bool PRisArrayVariant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisArrayVariant);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisArrayVariant)) = value;
			}
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06003A5E RID: 14942 RVA: 0x001159A8 File Offset: 0x00113BA8
		// (set) Token: 0x06003A5F RID: 14943 RVA: 0x00015BCF File Offset: 0x00013DCF
		public unsafe InternalPrimitiveTypeE PRarrayElementTypeCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRarrayElementTypeCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRarrayElementTypeCode)) = value;
			}
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x06003A60 RID: 14944 RVA: 0x001159D0 File Offset: 0x00113BD0
		// (set) Token: 0x06003A61 RID: 14945 RVA: 0x00015BEA File Offset: 0x00013DEA
		public unsafe int PRrank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRrank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRrank)) = value;
			}
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06003A62 RID: 14946 RVA: 0x001159F8 File Offset: 0x00113BF8
		// (set) Token: 0x06003A63 RID: 14947 RVA: 0x00015C05 File Offset: 0x00013E05
		public unsafe Il2CppStructArray<int> PRlengthA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRlengthA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRlengthA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06003A64 RID: 14948 RVA: 0x00115A28 File Offset: 0x00113C28
		// (set) Token: 0x06003A65 RID: 14949 RVA: 0x00015C24 File Offset: 0x00013E24
		public unsafe Il2CppStructArray<int> PRpositionA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRpositionA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRpositionA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x06003A66 RID: 14950 RVA: 0x00115A58 File Offset: 0x00113C58
		// (set) Token: 0x06003A67 RID: 14951 RVA: 0x00015C43 File Offset: 0x00013E43
		public unsafe Il2CppStructArray<int> PRlowerBoundA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRlowerBoundA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRlowerBoundA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06003A68 RID: 14952 RVA: 0x00115A88 File Offset: 0x00113C88
		// (set) Token: 0x06003A69 RID: 14953 RVA: 0x00015C62 File Offset: 0x00013E62
		public unsafe Il2CppStructArray<int> PRupperBoundA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRupperBoundA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRupperBoundA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x06003A6A RID: 14954 RVA: 0x00115AB8 File Offset: 0x00113CB8
		// (set) Token: 0x06003A6B RID: 14955 RVA: 0x00015C81 File Offset: 0x00013E81
		public unsafe Il2CppStructArray<int> PRindexMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRindexMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRindexMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x06003A6C RID: 14956 RVA: 0x00115AE8 File Offset: 0x00113CE8
		// (set) Token: 0x06003A6D RID: 14957 RVA: 0x00015CA0 File Offset: 0x00013EA0
		public unsafe int PRmemberIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRmemberIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRmemberIndex)) = value;
			}
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x06003A6E RID: 14958 RVA: 0x00115B10 File Offset: 0x00113D10
		// (set) Token: 0x06003A6F RID: 14959 RVA: 0x00015CBB File Offset: 0x00013EBB
		public unsafe int PRlinearlength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRlinearlength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRlinearlength)) = value;
			}
		}

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x06003A70 RID: 14960 RVA: 0x00115B38 File Offset: 0x00113D38
		// (set) Token: 0x06003A71 RID: 14961 RVA: 0x00015CD6 File Offset: 0x00013ED6
		public unsafe Il2CppStructArray<int> PRrectangularMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRrectangularMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRrectangularMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x06003A72 RID: 14962 RVA: 0x00115B68 File Offset: 0x00113D68
		// (set) Token: 0x06003A73 RID: 14963 RVA: 0x00015CF5 File Offset: 0x00013EF5
		public unsafe bool PRisLowerBound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisLowerBound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisLowerBound)) = value;
			}
		}

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x06003A74 RID: 14964 RVA: 0x00115B90 File Offset: 0x00113D90
		// (set) Token: 0x06003A75 RID: 14965 RVA: 0x00015D10 File Offset: 0x00013F10
		public unsafe long PRtopId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRtopId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRtopId)) = value;
			}
		}

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x06003A76 RID: 14966 RVA: 0x00115BB8 File Offset: 0x00113DB8
		// (set) Token: 0x06003A77 RID: 14967 RVA: 0x00015D2B File Offset: 0x00013F2B
		public unsafe long PRheaderId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRheaderId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRheaderId)) = value;
			}
		}

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06003A78 RID: 14968 RVA: 0x00115BE0 File Offset: 0x00113DE0
		// (set) Token: 0x06003A79 RID: 14969 RVA: 0x00015D46 File Offset: 0x00013F46
		public unsafe ReadObjectInfo PRobjectInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06003A7A RID: 14970 RVA: 0x00115C10 File Offset: 0x00113E10
		// (set) Token: 0x06003A7B RID: 14971 RVA: 0x00015D65 File Offset: 0x00013F65
		public unsafe bool PRisValueTypeFixup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisValueTypeFixup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisValueTypeFixup)) = value;
			}
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06003A7C RID: 14972 RVA: 0x00115C38 File Offset: 0x00113E38
		// (set) Token: 0x06003A7D RID: 14973 RVA: 0x00015D80 File Offset: 0x00013F80
		public unsafe Object PRnewObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRnewObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRnewObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x06003A7E RID: 14974 RVA: 0x00115C68 File Offset: 0x00113E68
		// (set) Token: 0x06003A7F RID: 14975 RVA: 0x00015D9F File Offset: 0x00013F9F
		public unsafe Il2CppReferenceArray<Object> PRobjectA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06003A80 RID: 14976 RVA: 0x00115C98 File Offset: 0x00113E98
		// (set) Token: 0x06003A81 RID: 14977 RVA: 0x00015DBE File Offset: 0x00013FBE
		public unsafe PrimitiveArray PRprimitiveArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRprimitiveArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrimitiveArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRprimitiveArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06003A82 RID: 14978 RVA: 0x00115CC8 File Offset: 0x00113EC8
		// (set) Token: 0x06003A83 RID: 14979 RVA: 0x00015DDD File Offset: 0x00013FDD
		public unsafe bool PRisRegistered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisRegistered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisRegistered)) = value;
			}
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06003A84 RID: 14980 RVA: 0x00115CF0 File Offset: 0x00113EF0
		// (set) Token: 0x06003A85 RID: 14981 RVA: 0x00015DF8 File Offset: 0x00013FF8
		public unsafe Il2CppReferenceArray<Object> PRmemberData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRmemberData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRmemberData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06003A86 RID: 14982 RVA: 0x00115D20 File Offset: 0x00113F20
		// (set) Token: 0x06003A87 RID: 14983 RVA: 0x00015E17 File Offset: 0x00014017
		public unsafe SerializationInfo PRsi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRsi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRsi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06003A88 RID: 14984 RVA: 0x00115D50 File Offset: 0x00113F50
		// (set) Token: 0x06003A89 RID: 14985 RVA: 0x00015E36 File Offset: 0x00014036
		public unsafe int PRnullCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRnullCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRnullCount)) = value;
			}
		}

		// Token: 0x040030C3 RID: 12483
		private static readonly IntPtr NativeFieldInfoPtr_parseRecordIdCount;

		// Token: 0x040030C4 RID: 12484
		private static readonly IntPtr NativeFieldInfoPtr_PRparseTypeEnum;

		// Token: 0x040030C5 RID: 12485
		private static readonly IntPtr NativeFieldInfoPtr_PRobjectTypeEnum;

		// Token: 0x040030C6 RID: 12486
		private static readonly IntPtr NativeFieldInfoPtr_PRarrayTypeEnum;

		// Token: 0x040030C7 RID: 12487
		private static readonly IntPtr NativeFieldInfoPtr_PRmemberTypeEnum;

		// Token: 0x040030C8 RID: 12488
		private static readonly IntPtr NativeFieldInfoPtr_PRmemberValueEnum;

		// Token: 0x040030C9 RID: 12489
		private static readonly IntPtr NativeFieldInfoPtr_PRobjectPositionEnum;

		// Token: 0x040030CA RID: 12490
		private static readonly IntPtr NativeFieldInfoPtr_PRname;

		// Token: 0x040030CB RID: 12491
		private static readonly IntPtr NativeFieldInfoPtr_PRvalue;

		// Token: 0x040030CC RID: 12492
		private static readonly IntPtr NativeFieldInfoPtr_PRvarValue;

		// Token: 0x040030CD RID: 12493
		private static readonly IntPtr NativeFieldInfoPtr_PRkeyDt;

		// Token: 0x040030CE RID: 12494
		private static readonly IntPtr NativeFieldInfoPtr_PRdtType;

		// Token: 0x040030CF RID: 12495
		private static readonly IntPtr NativeFieldInfoPtr_PRdtTypeCode;

		// Token: 0x040030D0 RID: 12496
		private static readonly IntPtr NativeFieldInfoPtr_PRisEnum;

		// Token: 0x040030D1 RID: 12497
		private static readonly IntPtr NativeFieldInfoPtr_PRobjectId;

		// Token: 0x040030D2 RID: 12498
		private static readonly IntPtr NativeFieldInfoPtr_PRidRef;

		// Token: 0x040030D3 RID: 12499
		private static readonly IntPtr NativeFieldInfoPtr_PRarrayElementTypeString;

		// Token: 0x040030D4 RID: 12500
		private static readonly IntPtr NativeFieldInfoPtr_PRarrayElementType;

		// Token: 0x040030D5 RID: 12501
		private static readonly IntPtr NativeFieldInfoPtr_PRisArrayVariant;

		// Token: 0x040030D6 RID: 12502
		private static readonly IntPtr NativeFieldInfoPtr_PRarrayElementTypeCode;

		// Token: 0x040030D7 RID: 12503
		private static readonly IntPtr NativeFieldInfoPtr_PRrank;

		// Token: 0x040030D8 RID: 12504
		private static readonly IntPtr NativeFieldInfoPtr_PRlengthA;

		// Token: 0x040030D9 RID: 12505
		private static readonly IntPtr NativeFieldInfoPtr_PRpositionA;

		// Token: 0x040030DA RID: 12506
		private static readonly IntPtr NativeFieldInfoPtr_PRlowerBoundA;

		// Token: 0x040030DB RID: 12507
		private static readonly IntPtr NativeFieldInfoPtr_PRupperBoundA;

		// Token: 0x040030DC RID: 12508
		private static readonly IntPtr NativeFieldInfoPtr_PRindexMap;

		// Token: 0x040030DD RID: 12509
		private static readonly IntPtr NativeFieldInfoPtr_PRmemberIndex;

		// Token: 0x040030DE RID: 12510
		private static readonly IntPtr NativeFieldInfoPtr_PRlinearlength;

		// Token: 0x040030DF RID: 12511
		private static readonly IntPtr NativeFieldInfoPtr_PRrectangularMap;

		// Token: 0x040030E0 RID: 12512
		private static readonly IntPtr NativeFieldInfoPtr_PRisLowerBound;

		// Token: 0x040030E1 RID: 12513
		private static readonly IntPtr NativeFieldInfoPtr_PRtopId;

		// Token: 0x040030E2 RID: 12514
		private static readonly IntPtr NativeFieldInfoPtr_PRheaderId;

		// Token: 0x040030E3 RID: 12515
		private static readonly IntPtr NativeFieldInfoPtr_PRobjectInfo;

		// Token: 0x040030E4 RID: 12516
		private static readonly IntPtr NativeFieldInfoPtr_PRisValueTypeFixup;

		// Token: 0x040030E5 RID: 12517
		private static readonly IntPtr NativeFieldInfoPtr_PRnewObj;

		// Token: 0x040030E6 RID: 12518
		private static readonly IntPtr NativeFieldInfoPtr_PRobjectA;

		// Token: 0x040030E7 RID: 12519
		private static readonly IntPtr NativeFieldInfoPtr_PRprimitiveArray;

		// Token: 0x040030E8 RID: 12520
		private static readonly IntPtr NativeFieldInfoPtr_PRisRegistered;

		// Token: 0x040030E9 RID: 12521
		private static readonly IntPtr NativeFieldInfoPtr_PRmemberData;

		// Token: 0x040030EA RID: 12522
		private static readonly IntPtr NativeFieldInfoPtr_PRsi;

		// Token: 0x040030EB RID: 12523
		private static readonly IntPtr NativeFieldInfoPtr_PRnullCount;

		// Token: 0x040030EC RID: 12524
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040030ED RID: 12525
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_0;
	}
}
