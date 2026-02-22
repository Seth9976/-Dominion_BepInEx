using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000111 RID: 273
	[StructLayout(2)]
	public struct XsdDuration
	{
		// Token: 0x06001147 RID: 4423 RVA: 0x00051224 File Offset: 0x0004F424
		// Note: this type is marked as 'beforefieldinit'.
		static XsdDuration()
		{
			Il2CppClassPointerStore<XsdDuration>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XsdDuration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr);
			XsdDuration.NativeFieldInfoPtr_years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "years");
			XsdDuration.NativeFieldInfoPtr_months = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "months");
			XsdDuration.NativeFieldInfoPtr_days = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "days");
			XsdDuration.NativeFieldInfoPtr_hours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "hours");
			XsdDuration.NativeFieldInfoPtr_minutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "minutes");
			XsdDuration.NativeFieldInfoPtr_seconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "seconds");
			XsdDuration.NativeFieldInfoPtr_nanoseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, "nanoseconds");
			XsdDuration.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100665864);
			XsdDuration.NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_DurationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100665865);
			XsdDuration.NativeMethodInfoPtr__ctor_Public_Void_String_DurationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100665866);
			XsdDuration.NativeMethodInfoPtr_get_IsNegative_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100665867);
			XsdDuration.NativeMethodInfoPtr_get_Years_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100665868);
			XsdDuration.NativeMethodInfoPtr_get_Months_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100665869);
			XsdDuration.NativeMethodInfoPtr_get_Days_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100665870);
			XsdDuration.NativeMethodInfoPtr_get_Hours_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100665871);
			XsdDuration.NativeMethodInfoPtr_get_Minutes_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100665872);
			XsdDuration.NativeMethodInfoPtr_get_Seconds_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100665873);
			XsdDuration.NativeMethodInfoPtr_get_Nanoseconds_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100665874);
			XsdDuration.NativeMethodInfoPtr_ToTimeSpan_Public_TimeSpan_DurationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100665875);
			XsdDuration.NativeMethodInfoPtr_TryToTimeSpan_Internal_Exception_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100665876);
			XsdDuration.NativeMethodInfoPtr_TryToTimeSpan_Internal_Exception_DurationType_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100665877);
			XsdDuration.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100665878);
			XsdDuration.NativeMethodInfoPtr_ToString_Internal_String_DurationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100665879);
			XsdDuration.NativeMethodInfoPtr_TryParse_Internal_Static_Exception_String_byref_XsdDuration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100665880);
			XsdDuration.NativeMethodInfoPtr_TryParse_Internal_Static_Exception_String_DurationType_byref_XsdDuration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100665881);
			XsdDuration.NativeMethodInfoPtr_TryParseDigits_Private_Static_String_String_byref_Int32_Boolean_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, 100665882);
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x0005145C File Offset: 0x0004F65C
		[CallerCount(0)]
		public unsafe XsdDuration(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isNegative;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref years;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref months;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref days;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hours;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutes;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seconds;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nanoseconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x000514F0 File Offset: 0x0004F6F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 31374, RefRangeEnd = 31377, XrefRangeStart = 31374, XrefRangeEnd = 31374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdDuration(TimeSpan timeSpan, XsdDuration.DurationType durationType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeSpan;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_DurationType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x00051530 File Offset: 0x0004F730
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 31378, RefRangeEnd = 31381, XrefRangeStart = 31377, XrefRangeEnd = 31378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdDuration(string s, XsdDuration.DurationType durationType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr__ctor_Public_Void_String_DurationType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x00051574 File Offset: 0x0004F774
		public unsafe bool IsNegative
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_get_IsNegative_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x000515A4 File Offset: 0x0004F7A4
		public unsafe int Years
		{
			[CallerCount(64)]
			[CachedScanResults(RefRangeStart = 31381, RefRangeEnd = 31445, XrefRangeStart = 31381, XrefRangeEnd = 31381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_get_Years_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x000515D4 File Offset: 0x0004F7D4
		public unsafe int Months
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_get_Months_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x00051604 File Offset: 0x0004F804
		public unsafe int Days
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_get_Days_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x00051634 File Offset: 0x0004F834
		public unsafe int Hours
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_get_Hours_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x00051664 File Offset: 0x0004F864
		public unsafe int Minutes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_get_Minutes_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x00051694 File Offset: 0x0004F894
		public unsafe int Seconds
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_get_Seconds_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001152 RID: 4434 RVA: 0x000516C4 File Offset: 0x0004F8C4
		public unsafe int Nanoseconds
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_get_Nanoseconds_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x000516F4 File Offset: 0x0004F8F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 31446, RefRangeEnd = 31449, XrefRangeStart = 31445, XrefRangeEnd = 31446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan ToTimeSpan(XsdDuration.DurationType durationType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref durationType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_ToTimeSpan_Public_TimeSpan_DurationType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00051734 File Offset: 0x0004F934
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31450, RefRangeEnd = 31451, XrefRangeStart = 31449, XrefRangeEnd = 31450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception TryToTimeSpan(out TimeSpan result)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_TryToTimeSpan_Internal_Exception_byref_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x00051774 File Offset: 0x0004F974
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 31456, RefRangeEnd = 31460, XrefRangeStart = 31451, XrefRangeEnd = 31456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception TryToTimeSpan(XsdDuration.DurationType durationType, out TimeSpan result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref durationType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_TryToTimeSpan_Internal_Exception_DurationType_byref_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x000517C4 File Offset: 0x0004F9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31460, XrefRangeEnd = 31461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x000517F0 File Offset: 0x0004F9F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 31517, RefRangeEnd = 31521, XrefRangeStart = 31461, XrefRangeEnd = 31517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(XsdDuration.DurationType durationType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref durationType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_ToString_Internal_String_DurationType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x00051828 File Offset: 0x0004FA28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31522, RefRangeEnd = 31523, XrefRangeStart = 31521, XrefRangeEnd = 31522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryParse(string s, out XsdDuration result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_TryParse_Internal_Static_Exception_String_byref_XsdDuration_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x0005187C File Offset: 0x0004FA7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 31590, RefRangeEnd = 31594, XrefRangeStart = 31523, XrefRangeEnd = 31590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryParse(string s, XsdDuration.DurationType durationType, out XsdDuration result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_TryParse_Internal_Static_Exception_String_DurationType_byref_XsdDuration_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x000518DC File Offset: 0x0004FADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31594, XrefRangeEnd = 31598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TryParseDigits(string s, ref int offset, bool eatDigits, out int result, out int numDigits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eatDigits;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &numDigits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdDuration.NativeMethodInfoPtr_TryParseDigits_Private_Static_String_String_byref_Int32_Boolean_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x00007945 File Offset: 0x00005B45
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XsdDuration>.NativeClassPtr, ref this));
		}

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeFieldInfoPtr_years;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeFieldInfoPtr_months;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeFieldInfoPtr_days;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeFieldInfoPtr_hours;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeFieldInfoPtr_minutes;

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeFieldInfoPtr_seconds;

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeFieldInfoPtr_nanoseconds;

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_DurationType_0;

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_DurationType_0;

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNegative_Public_get_Boolean_0;

		// Token: 0x04000D3E RID: 3390
		private static readonly IntPtr NativeMethodInfoPtr_get_Years_Public_get_Int32_0;

		// Token: 0x04000D3F RID: 3391
		private static readonly IntPtr NativeMethodInfoPtr_get_Months_Public_get_Int32_0;

		// Token: 0x04000D40 RID: 3392
		private static readonly IntPtr NativeMethodInfoPtr_get_Days_Public_get_Int32_0;

		// Token: 0x04000D41 RID: 3393
		private static readonly IntPtr NativeMethodInfoPtr_get_Hours_Public_get_Int32_0;

		// Token: 0x04000D42 RID: 3394
		private static readonly IntPtr NativeMethodInfoPtr_get_Minutes_Public_get_Int32_0;

		// Token: 0x04000D43 RID: 3395
		private static readonly IntPtr NativeMethodInfoPtr_get_Seconds_Public_get_Int32_0;

		// Token: 0x04000D44 RID: 3396
		private static readonly IntPtr NativeMethodInfoPtr_get_Nanoseconds_Public_get_Int32_0;

		// Token: 0x04000D45 RID: 3397
		private static readonly IntPtr NativeMethodInfoPtr_ToTimeSpan_Public_TimeSpan_DurationType_0;

		// Token: 0x04000D46 RID: 3398
		private static readonly IntPtr NativeMethodInfoPtr_TryToTimeSpan_Internal_Exception_byref_TimeSpan_0;

		// Token: 0x04000D47 RID: 3399
		private static readonly IntPtr NativeMethodInfoPtr_TryToTimeSpan_Internal_Exception_DurationType_byref_TimeSpan_0;

		// Token: 0x04000D48 RID: 3400
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000D49 RID: 3401
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_String_DurationType_0;

		// Token: 0x04000D4A RID: 3402
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Internal_Static_Exception_String_byref_XsdDuration_0;

		// Token: 0x04000D4B RID: 3403
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Internal_Static_Exception_String_DurationType_byref_XsdDuration_0;

		// Token: 0x04000D4C RID: 3404
		private static readonly IntPtr NativeMethodInfoPtr_TryParseDigits_Private_Static_String_String_byref_Int32_Boolean_byref_Int32_byref_Int32_0;

		// Token: 0x04000D4D RID: 3405
		[FieldOffset(0)]
		public int years;

		// Token: 0x04000D4E RID: 3406
		[FieldOffset(4)]
		public int months;

		// Token: 0x04000D4F RID: 3407
		[FieldOffset(8)]
		public int days;

		// Token: 0x04000D50 RID: 3408
		[FieldOffset(12)]
		public int hours;

		// Token: 0x04000D51 RID: 3409
		[FieldOffset(16)]
		public int minutes;

		// Token: 0x04000D52 RID: 3410
		[FieldOffset(20)]
		public int seconds;

		// Token: 0x04000D53 RID: 3411
		[FieldOffset(24)]
		public uint nanoseconds;

		// Token: 0x0200013C RID: 316
		public enum Parts
		{
			// Token: 0x04000F07 RID: 3847
			HasNone,
			// Token: 0x04000F08 RID: 3848
			HasYears,
			// Token: 0x04000F09 RID: 3849
			HasMonths,
			// Token: 0x04000F0A RID: 3850
			HasDays = 4,
			// Token: 0x04000F0B RID: 3851
			HasHours = 8,
			// Token: 0x04000F0C RID: 3852
			HasMinutes = 16,
			// Token: 0x04000F0D RID: 3853
			HasSeconds = 32
		}

		// Token: 0x0200013D RID: 317
		public enum DurationType
		{
			// Token: 0x04000F0F RID: 3855
			Duration,
			// Token: 0x04000F10 RID: 3856
			YearMonthDuration,
			// Token: 0x04000F11 RID: 3857
			DayTimeDuration
		}
	}
}
