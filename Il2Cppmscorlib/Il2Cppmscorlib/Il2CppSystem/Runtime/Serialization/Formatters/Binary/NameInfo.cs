using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000388 RID: 904
	public sealed class NameInfo : Object
	{
		// Token: 0x06003ADB RID: 15067 RVA: 0x00116D6C File Offset: 0x00114F6C
		// Note: this type is marked as 'beforefieldinit'.
		static NameInfo()
		{
			Il2CppClassPointerStore<NameInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "NameInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameInfo>.NativeClassPtr);
			NameInfo.NativeFieldInfoPtr_NIFullName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIFullName");
			NameInfo.NativeFieldInfoPtr_NIobjectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIobjectId");
			NameInfo.NativeFieldInfoPtr_NIassemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIassemId");
			NameInfo.NativeFieldInfoPtr_NIprimitiveTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIprimitiveTypeEnum");
			NameInfo.NativeFieldInfoPtr_NItype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NItype");
			NameInfo.NativeFieldInfoPtr_NIisSealed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIisSealed");
			NameInfo.NativeFieldInfoPtr_NIisArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIisArray");
			NameInfo.NativeFieldInfoPtr_NIisArrayItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIisArrayItem");
			NameInfo.NativeFieldInfoPtr_NItransmitTypeOnObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NItransmitTypeOnObject");
			NameInfo.NativeFieldInfoPtr_NItransmitTypeOnMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NItransmitTypeOnMember");
			NameInfo.NativeFieldInfoPtr_NIisParentTypeOnObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIisParentTypeOnObject");
			NameInfo.NativeFieldInfoPtr_NIarrayEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIarrayEnum");
			NameInfo.NativeFieldInfoPtr_NIsealedStatusChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, "NIsealedStatusChecked");
			NameInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100672034);
			NameInfo.NativeMethodInfoPtr_Init_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100672035);
			NameInfo.NativeMethodInfoPtr_get_IsSealed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100672036);
			NameInfo.NativeMethodInfoPtr_get_NIname_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100672037);
			NameInfo.NativeMethodInfoPtr_set_NIname_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameInfo>.NativeClassPtr, 100672038);
		}

		// Token: 0x06003ADC RID: 15068 RVA: 0x00116F04 File Offset: 0x00115104
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ADD RID: 15069 RVA: 0x00116F40 File Offset: 0x00115140
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 348698, RefRangeEnd = 348703, XrefRangeStart = 348698, XrefRangeEnd = 348698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameInfo.NativeMethodInfoPtr_Init_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06003ADE RID: 15070 RVA: 0x00116F74 File Offset: 0x00115174
		public unsafe bool IsSealed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348703, XrefRangeEnd = 348704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameInfo.NativeMethodInfoPtr_get_IsSealed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06003ADF RID: 15071 RVA: 0x00116FB0 File Offset: 0x001151B0
		// (set) Token: 0x06003AE0 RID: 15072 RVA: 0x00116FE8 File Offset: 0x001151E8
		public unsafe string NIname
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 348704, RefRangeEnd = 348708, XrefRangeStart = 348704, XrefRangeEnd = 348704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameInfo.NativeMethodInfoPtr_get_NIname_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameInfo.NativeMethodInfoPtr_set_NIname_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003AE1 RID: 15073 RVA: 0x000160E0 File Offset: 0x000142E0
		public NameInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06003AE2 RID: 15074 RVA: 0x0011702C File Offset: 0x0011522C
		// (set) Token: 0x06003AE3 RID: 15075 RVA: 0x000160E9 File Offset: 0x000142E9
		public unsafe string NIFullName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIFullName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIFullName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06003AE4 RID: 15076 RVA: 0x00117054 File Offset: 0x00115254
		// (set) Token: 0x06003AE5 RID: 15077 RVA: 0x00016108 File Offset: 0x00014308
		public unsafe long NIobjectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIobjectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIobjectId)) = value;
			}
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06003AE6 RID: 15078 RVA: 0x0011707C File Offset: 0x0011527C
		// (set) Token: 0x06003AE7 RID: 15079 RVA: 0x00016123 File Offset: 0x00014323
		public unsafe long NIassemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIassemId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIassemId)) = value;
			}
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06003AE8 RID: 15080 RVA: 0x001170A4 File Offset: 0x001152A4
		// (set) Token: 0x06003AE9 RID: 15081 RVA: 0x0001613E File Offset: 0x0001433E
		public unsafe InternalPrimitiveTypeE NIprimitiveTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIprimitiveTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIprimitiveTypeEnum)) = value;
			}
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06003AEA RID: 15082 RVA: 0x001170CC File Offset: 0x001152CC
		// (set) Token: 0x06003AEB RID: 15083 RVA: 0x00016159 File Offset: 0x00014359
		public unsafe Type NItype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NItype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NItype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06003AEC RID: 15084 RVA: 0x001170FC File Offset: 0x001152FC
		// (set) Token: 0x06003AED RID: 15085 RVA: 0x00016178 File Offset: 0x00014378
		public unsafe bool NIisSealed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIisSealed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIisSealed)) = value;
			}
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x06003AEE RID: 15086 RVA: 0x00117124 File Offset: 0x00115324
		// (set) Token: 0x06003AEF RID: 15087 RVA: 0x00016193 File Offset: 0x00014393
		public unsafe bool NIisArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIisArray);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIisArray)) = value;
			}
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06003AF0 RID: 15088 RVA: 0x0011714C File Offset: 0x0011534C
		// (set) Token: 0x06003AF1 RID: 15089 RVA: 0x000161AE File Offset: 0x000143AE
		public unsafe bool NIisArrayItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIisArrayItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIisArrayItem)) = value;
			}
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06003AF2 RID: 15090 RVA: 0x00117174 File Offset: 0x00115374
		// (set) Token: 0x06003AF3 RID: 15091 RVA: 0x000161C9 File Offset: 0x000143C9
		public unsafe bool NItransmitTypeOnObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NItransmitTypeOnObject);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NItransmitTypeOnObject)) = value;
			}
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06003AF4 RID: 15092 RVA: 0x0011719C File Offset: 0x0011539C
		// (set) Token: 0x06003AF5 RID: 15093 RVA: 0x000161E4 File Offset: 0x000143E4
		public unsafe bool NItransmitTypeOnMember
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NItransmitTypeOnMember);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NItransmitTypeOnMember)) = value;
			}
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06003AF6 RID: 15094 RVA: 0x001171C4 File Offset: 0x001153C4
		// (set) Token: 0x06003AF7 RID: 15095 RVA: 0x000161FF File Offset: 0x000143FF
		public unsafe bool NIisParentTypeOnObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIisParentTypeOnObject);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIisParentTypeOnObject)) = value;
			}
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06003AF8 RID: 15096 RVA: 0x001171EC File Offset: 0x001153EC
		// (set) Token: 0x06003AF9 RID: 15097 RVA: 0x0001621A File Offset: 0x0001441A
		public unsafe InternalArrayTypeE NIarrayEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIarrayEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIarrayEnum)) = value;
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06003AFA RID: 15098 RVA: 0x00117214 File Offset: 0x00115414
		// (set) Token: 0x06003AFB RID: 15099 RVA: 0x00016235 File Offset: 0x00014435
		public unsafe bool NIsealedStatusChecked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIsealedStatusChecked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameInfo.NativeFieldInfoPtr_NIsealedStatusChecked)) = value;
			}
		}

		// Token: 0x0400311E RID: 12574
		private static readonly IntPtr NativeFieldInfoPtr_NIFullName;

		// Token: 0x0400311F RID: 12575
		private static readonly IntPtr NativeFieldInfoPtr_NIobjectId;

		// Token: 0x04003120 RID: 12576
		private static readonly IntPtr NativeFieldInfoPtr_NIassemId;

		// Token: 0x04003121 RID: 12577
		private static readonly IntPtr NativeFieldInfoPtr_NIprimitiveTypeEnum;

		// Token: 0x04003122 RID: 12578
		private static readonly IntPtr NativeFieldInfoPtr_NItype;

		// Token: 0x04003123 RID: 12579
		private static readonly IntPtr NativeFieldInfoPtr_NIisSealed;

		// Token: 0x04003124 RID: 12580
		private static readonly IntPtr NativeFieldInfoPtr_NIisArray;

		// Token: 0x04003125 RID: 12581
		private static readonly IntPtr NativeFieldInfoPtr_NIisArrayItem;

		// Token: 0x04003126 RID: 12582
		private static readonly IntPtr NativeFieldInfoPtr_NItransmitTypeOnObject;

		// Token: 0x04003127 RID: 12583
		private static readonly IntPtr NativeFieldInfoPtr_NItransmitTypeOnMember;

		// Token: 0x04003128 RID: 12584
		private static readonly IntPtr NativeFieldInfoPtr_NIisParentTypeOnObject;

		// Token: 0x04003129 RID: 12585
		private static readonly IntPtr NativeFieldInfoPtr_NIarrayEnum;

		// Token: 0x0400312A RID: 12586
		private static readonly IntPtr NativeFieldInfoPtr_NIsealedStatusChecked;

		// Token: 0x0400312B RID: 12587
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400312C RID: 12588
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_0;

		// Token: 0x0400312D RID: 12589
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSealed_Public_get_Boolean_0;

		// Token: 0x0400312E RID: 12590
		private static readonly IntPtr NativeMethodInfoPtr_get_NIname_Public_get_String_0;

		// Token: 0x0400312F RID: 12591
		private static readonly IntPtr NativeMethodInfoPtr_set_NIname_Public_set_Void_String_0;
	}
}
