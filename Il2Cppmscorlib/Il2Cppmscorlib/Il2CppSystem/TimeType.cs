using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200013B RID: 315
	public class TimeType : Object
	{
		// Token: 0x06001697 RID: 5783 RVA: 0x00087D00 File Offset: 0x00085F00
		// Note: this type is marked as 'beforefieldinit'.
		static TimeType()
		{
			Il2CppClassPointerStore<TimeType>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TimeType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeType>.NativeClassPtr);
			TimeType.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeType>.NativeClassPtr, "Offset");
			TimeType.NativeFieldInfoPtr_IsDst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeType>.NativeClassPtr, "IsDst");
			TimeType.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeType>.NativeClassPtr, "Name");
			TimeType.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeType>.NativeClassPtr, 100667092);
			TimeType.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeType>.NativeClassPtr, 100667093);
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x00087D94 File Offset: 0x00085F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309140, XrefRangeEnd = 309141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeType(int offset, bool is_dst, string abbrev)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeType>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref is_dst;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(abbrev);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeType.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00087DFC File Offset: 0x00085FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309141, XrefRangeEnd = 309164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimeType.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x00007EDD File Offset: 0x000060DD
		public TimeType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x0600169B RID: 5787 RVA: 0x00087E40 File Offset: 0x00086040
		// (set) Token: 0x0600169C RID: 5788 RVA: 0x00007EE6 File Offset: 0x000060E6
		public unsafe int Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeType.NativeFieldInfoPtr_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeType.NativeFieldInfoPtr_Offset)) = value;
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x0600169D RID: 5789 RVA: 0x00087E68 File Offset: 0x00086068
		// (set) Token: 0x0600169E RID: 5790 RVA: 0x00007F01 File Offset: 0x00006101
		public unsafe bool IsDst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeType.NativeFieldInfoPtr_IsDst);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeType.NativeFieldInfoPtr_IsDst)) = value;
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x0600169F RID: 5791 RVA: 0x00087E90 File Offset: 0x00086090
		// (set) Token: 0x060016A0 RID: 5792 RVA: 0x00007F1C File Offset: 0x0000611C
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeType.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeType.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040014B8 RID: 5304
		private static readonly IntPtr NativeFieldInfoPtr_Offset;

		// Token: 0x040014B9 RID: 5305
		private static readonly IntPtr NativeFieldInfoPtr_IsDst;

		// Token: 0x040014BA RID: 5306
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040014BB RID: 5307
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_String_0;

		// Token: 0x040014BC RID: 5308
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
