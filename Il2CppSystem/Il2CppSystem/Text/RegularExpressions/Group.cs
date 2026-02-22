using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000054 RID: 84
	[Serializable]
	public class Group : Capture
	{
		// Token: 0x060005A7 RID: 1447 RVA: 0x00025710 File Offset: 0x00023910
		// Note: this type is marked as 'beforefieldinit'.
		static Group()
		{
			Il2CppClassPointerStore<Group>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "Group");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Group>.NativeClassPtr);
			Group.NativeFieldInfoPtr__emptygroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Group>.NativeClassPtr, "_emptygroup");
			Group.NativeFieldInfoPtr__caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Group>.NativeClassPtr, "_caps");
			Group.NativeFieldInfoPtr__capcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Group>.NativeClassPtr, "_capcount");
			Group.NativeFieldInfoPtr__capcoll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Group>.NativeClassPtr, "_capcoll");
			Group.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Group>.NativeClassPtr, "_name");
			Group.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStructArray_1_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Group>.NativeClassPtr, 100664044);
			Group.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Group>.NativeClassPtr, 100664045);
			Group.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Group>.NativeClassPtr, 100664047);
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x000257E0 File Offset: 0x000239E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39193, RefRangeEnd = 39194, XrefRangeStart = 39191, XrefRangeEnd = 39193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Group(string text, Il2CppStructArray<int> caps, int capcount, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Group>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caps);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capcount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Group.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStructArray_1_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x00025860 File Offset: 0x00023A60
		public unsafe bool Success
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 39194, RefRangeEnd = 39204, XrefRangeStart = 39194, XrefRangeEnd = 39194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Group.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0002589C File Offset: 0x00023A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39204, XrefRangeEnd = 39207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Group()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Group>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Group.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x000042D4 File Offset: 0x000024D4
		public Group(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x000258D8 File Offset: 0x00023AD8
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x000042DD File Offset: 0x000024DD
		public unsafe static Group _emptygroup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Group.NativeFieldInfoPtr__emptygroup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Group>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Group.NativeFieldInfoPtr__emptygroup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x00025900 File Offset: 0x00023B00
		// (set) Token: 0x060005AF RID: 1455 RVA: 0x000042EF File Offset: 0x000024EF
		public unsafe Il2CppStructArray<int> _caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Group.NativeFieldInfoPtr__caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Group.NativeFieldInfoPtr__caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x00025930 File Offset: 0x00023B30
		// (set) Token: 0x060005B1 RID: 1457 RVA: 0x0000430E File Offset: 0x0000250E
		public unsafe int _capcount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Group.NativeFieldInfoPtr__capcount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Group.NativeFieldInfoPtr__capcount)) = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x00025958 File Offset: 0x00023B58
		// (set) Token: 0x060005B3 RID: 1459 RVA: 0x00004329 File Offset: 0x00002529
		public unsafe CaptureCollection _capcoll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Group.NativeFieldInfoPtr__capcoll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CaptureCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Group.NativeFieldInfoPtr__capcoll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x00025988 File Offset: 0x00023B88
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x00004348 File Offset: 0x00002548
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Group.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Group.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeFieldInfoPtr__emptygroup;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeFieldInfoPtr__caps;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeFieldInfoPtr__capcount;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeFieldInfoPtr__capcoll;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStructArray_1_Int32_Int32_String_0;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeMethodInfoPtr_get_Success_Public_get_Boolean_0;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
