using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200013A RID: 314
	[Serializable]
	public class CurrentSystemTimeZone : TimeZone
	{
		// Token: 0x06001691 RID: 5777 RVA: 0x00087B94 File Offset: 0x00085D94
		// Note: this type is marked as 'beforefieldinit'.
		static CurrentSystemTimeZone()
		{
			Il2CppClassPointerStore<CurrentSystemTimeZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "CurrentSystemTimeZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurrentSystemTimeZone>.NativeClassPtr);
			CurrentSystemTimeZone.NativeFieldInfoPtr_LocalTimeZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentSystemTimeZone>.NativeClassPtr, "LocalTimeZone");
			CurrentSystemTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurrentSystemTimeZone>.NativeClassPtr, 100667090);
			CurrentSystemTimeZone.NativeMethodInfoPtr_GetTimeZoneData_Public_Static_Boolean_Int32_byref_Il2CppStructArray_1_Int64_byref_Il2CppStringArray_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurrentSystemTimeZone>.NativeClassPtr, 100667091);
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x00087C00 File Offset: 0x00085E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309130, XrefRangeEnd = 309135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CurrentSystemTimeZone()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurrentSystemTimeZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurrentSystemTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x00087C3C File Offset: 0x00085E3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 309136, RefRangeEnd = 309140, XrefRangeStart = 309135, XrefRangeEnd = 309136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetTimeZoneData(int year, out Il2CppStructArray<long> data, out Il2CppStringArray names, out bool daylight_inverted)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &daylight_inverted;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(CurrentSystemTimeZone.NativeMethodInfoPtr_GetTimeZoneData_Public_Static_Boolean_Int32_byref_Il2CppStructArray_1_Int64_byref_Il2CppStringArray_byref_Boolean_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			data = ((intPtr5 == 0) ? null : new Il2CppStructArray<long>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			names = ((intPtr6 == 0) ? null : new Il2CppStringArray(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x00007EB5 File Offset: 0x000060B5
		public CurrentSystemTimeZone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06001695 RID: 5781 RVA: 0x00087CD0 File Offset: 0x00085ED0
		// (set) Token: 0x06001696 RID: 5782 RVA: 0x00007EBE File Offset: 0x000060BE
		public unsafe TimeZoneInfo LocalTimeZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurrentSystemTimeZone.NativeFieldInfoPtr_LocalTimeZone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurrentSystemTimeZone.NativeFieldInfoPtr_LocalTimeZone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014B5 RID: 5301
		private static readonly IntPtr NativeFieldInfoPtr_LocalTimeZone;

		// Token: 0x040014B6 RID: 5302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040014B7 RID: 5303
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeZoneData_Public_Static_Boolean_Int32_byref_Il2CppStructArray_1_Int64_byref_Il2CppStringArray_byref_Boolean_0;
	}
}
