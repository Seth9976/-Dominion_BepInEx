using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000095 RID: 149
	[Serializable]
	[StructLayout(2)]
	public struct DateTimeOffset
	{
		// Token: 0x06000A15 RID: 2581 RVA: 0x0004F508 File Offset: 0x0004D708
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeOffset()
		{
			Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DateTimeOffset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr);
			DateTimeOffset.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, "MinValue");
			DateTimeOffset.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, "MaxValue");
			DateTimeOffset.NativeFieldInfoPtr_m_dateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, "m_dateTime");
			DateTimeOffset.NativeFieldInfoPtr_m_offsetMinutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, "m_offsetMinutes");
			DateTimeOffset.NativeMethodInfoPtr__ctor_Public_Void_Int64_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664955);
			DateTimeOffset.NativeMethodInfoPtr__ctor_Public_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664956);
			DateTimeOffset.NativeMethodInfoPtr__ctor_Public_Void_DateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664957);
			DateTimeOffset.NativeMethodInfoPtr_get_DateTime_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664958);
			DateTimeOffset.NativeMethodInfoPtr_get_UtcDateTime_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664959);
			DateTimeOffset.NativeMethodInfoPtr_get_LocalDateTime_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664960);
			DateTimeOffset.NativeMethodInfoPtr_get_ClockDateTime_Private_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664961);
			DateTimeOffset.NativeMethodInfoPtr_get_Offset_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664962);
			DateTimeOffset.NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664963);
			DateTimeOffset.NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664964);
			DateTimeOffset.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664965);
			DateTimeOffset.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664966);
			DateTimeOffset.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664967);
			DateTimeOffset.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664968);
			DateTimeOffset.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664969);
			DateTimeOffset.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664970);
			DateTimeOffset.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664971);
			DateTimeOffset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664972);
			DateTimeOffset.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664973);
			DateTimeOffset.NativeMethodInfoPtr_ValidateOffset_Private_Static_Int16_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664974);
			DateTimeOffset.NativeMethodInfoPtr_ValidateDate_Private_Static_DateTime_DateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664975);
			DateTimeOffset.NativeMethodInfoPtr_op_Implicit_Public_Static_DateTimeOffset_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, 100664976);
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x0004F740 File Offset: 0x0004D940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280651, XrefRangeEnd = 280656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeOffset(long ticks, TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr__ctor_Public_Void_Int64_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x0004F780 File Offset: 0x0004D980
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280663, RefRangeEnd = 280665, XrefRangeStart = 280656, XrefRangeEnd = 280663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeOffset(DateTime dateTime)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr__ctor_Public_Void_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0004F7B4 File Offset: 0x0004D9B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280680, RefRangeEnd = 280681, XrefRangeStart = 280665, XrefRangeEnd = 280680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeOffset(DateTime dateTime, TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr__ctor_Public_Void_DateTime_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x0004F7F4 File Offset: 0x0004D9F4
		public unsafe DateTime DateTime
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 280682, RefRangeEnd = 280683, XrefRangeStart = 280681, XrefRangeEnd = 280682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_DateTime_Public_get_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x0004F824 File Offset: 0x0004DA24
		public unsafe DateTime UtcDateTime
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 280687, RefRangeEnd = 280695, XrefRangeStart = 280683, XrefRangeEnd = 280687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_UtcDateTime_Public_get_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x0004F854 File Offset: 0x0004DA54
		public unsafe DateTime LocalDateTime
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 280696, RefRangeEnd = 280697, XrefRangeStart = 280695, XrefRangeEnd = 280696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_LocalDateTime_Public_get_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x0004F884 File Offset: 0x0004DA84
		public unsafe DateTime ClockDateTime
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 280702, RefRangeEnd = 280708, XrefRangeStart = 280697, XrefRangeEnd = 280702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_ClockDateTime_Private_get_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x0004F8B4 File Offset: 0x0004DAB4
		public unsafe TimeSpan Offset
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 280709, RefRangeEnd = 280710, XrefRangeStart = 280708, XrefRangeEnd = 280709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_Offset_Public_get_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x0004F8E4 File Offset: 0x0004DAE4
		public unsafe long Ticks
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280710, XrefRangeEnd = 280711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x0004F914 File Offset: 0x0004DB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280711, XrefRangeEnd = 280724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_IComparable_CompareTo(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0004F958 File Offset: 0x0004DB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280724, XrefRangeEnd = 280731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(DateTimeOffset other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DateTimeOffset_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x0004F998 File Offset: 0x0004DB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280731, XrefRangeEnd = 280740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x0004F9DC File Offset: 0x0004DBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280740, XrefRangeEnd = 280742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(DateTimeOffset other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DateTimeOffset_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x0004FA1C File Offset: 0x0004DC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280742, XrefRangeEnd = 280750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x0004FA54 File Offset: 0x0004DC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280750, XrefRangeEnd = 280762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x0004FAA4 File Offset: 0x0004DCA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280762, XrefRangeEnd = 280783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeOffset(SerializationInfo info, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x0004FAF4 File Offset: 0x0004DCF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280783, XrefRangeEnd = 280784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x0004FB24 File Offset: 0x0004DD24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280784, XrefRangeEnd = 280794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0004FB50 File Offset: 0x0004DD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280794, XrefRangeEnd = 280804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0004FBA0 File Offset: 0x0004DDA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 280804, RefRangeEnd = 280808, XrefRangeStart = 280804, XrefRangeEnd = 280804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ValidateOffset(TimeSpan offset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_ValidateOffset_Private_Static_Int16_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x0004FBE0 File Offset: 0x0004DDE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 280809, RefRangeEnd = 280813, XrefRangeStart = 280808, XrefRangeEnd = 280809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ValidateDate(DateTime dateTime, TimeSpan offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_ValidateDate_Private_Static_DateTime_DateTime_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x0004FC2C File Offset: 0x0004DE2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280814, RefRangeEnd = 280815, XrefRangeStart = 280813, XrefRangeEnd = 280814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator DateTimeOffset(DateTime dateTime)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeOffset.NativeMethodInfoPtr_op_Implicit_Public_Static_DateTimeOffset_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00004C22 File Offset: 0x00002E22
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DateTimeOffset>.NativeClassPtr, ref this));
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x0004FC6C File Offset: 0x0004DE6C
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x00004C34 File Offset: 0x00002E34
		public unsafe static DateTimeOffset MinValue
		{
			get
			{
				DateTimeOffset dateTimeOffset;
				IL2CPP.il2cpp_field_static_get_value(DateTimeOffset.NativeFieldInfoPtr_MinValue, (void*)(&dateTimeOffset));
				return dateTimeOffset;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeOffset.NativeFieldInfoPtr_MinValue, (void*)(&value));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x0004FC88 File Offset: 0x0004DE88
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x00004C42 File Offset: 0x00002E42
		public unsafe static DateTimeOffset MaxValue
		{
			get
			{
				DateTimeOffset dateTimeOffset;
				IL2CPP.il2cpp_field_static_get_value(DateTimeOffset.NativeFieldInfoPtr_MaxValue, (void*)(&dateTimeOffset));
				return dateTimeOffset;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTimeOffset.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeFieldInfoPtr_m_dateTime;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeFieldInfoPtr_m_offsetMinutes;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_TimeSpan_0;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTime_0;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTime_TimeSpan_0;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTime_Public_get_DateTime_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_get_UtcDateTime_Public_get_DateTime_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalDateTime_Public_get_DateTime_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_get_ClockDateTime_Private_get_DateTime_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_get_Offset_Public_get_TimeSpan_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DateTimeOffset_0;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DateTimeOffset_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeMethodInfoPtr_ValidateOffset_Private_Static_Int16_TimeSpan_0;

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeMethodInfoPtr_ValidateDate_Private_Static_DateTime_DateTime_TimeSpan_0;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_DateTimeOffset_DateTime_0;

		// Token: 0x04000870 RID: 2160
		[FieldOffset(0)]
		public DateTime m_dateTime;

		// Token: 0x04000871 RID: 2161
		[FieldOffset(8)]
		public short m_offsetMinutes;
	}
}
