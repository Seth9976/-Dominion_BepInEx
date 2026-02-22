using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200034C RID: 844
	[Serializable]
	public sealed class StreamingContext : ValueType
	{
		// Token: 0x06003644 RID: 13892 RVA: 0x00107B90 File Offset: 0x00105D90
		// Note: this type is marked as 'beforefieldinit'.
		static StreamingContext()
		{
			Il2CppClassPointerStore<StreamingContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "StreamingContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr);
			StreamingContext.NativeFieldInfoPtr_m_additionalContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, "m_additionalContext");
			StreamingContext.NativeFieldInfoPtr_m_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, "m_state");
			StreamingContext.NativeMethodInfoPtr__ctor_Public_Void_StreamingContextStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, 100671656);
			StreamingContext.NativeMethodInfoPtr__ctor_Public_Void_StreamingContextStates_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, 100671657);
			StreamingContext.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, 100671658);
			StreamingContext.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, 100671659);
			StreamingContext.NativeMethodInfoPtr_get_State_Public_get_StreamingContextStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, 100671660);
		}

		// Token: 0x06003645 RID: 13893 RVA: 0x00107C4C File Offset: 0x00105E4C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 344813, RefRangeEnd = 344818, XrefRangeStart = 344813, XrefRangeEnd = 344813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamingContext(StreamingContextStates state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamingContext.NativeMethodInfoPtr__ctor_Public_Void_StreamingContextStates_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x00107C98 File Offset: 0x00105E98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 316164, RefRangeEnd = 316167, XrefRangeStart = 316164, XrefRangeEnd = 316167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamingContext(StreamingContextStates state, Object additional)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additional);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamingContext.NativeMethodInfoPtr__ctor_Public_Void_StreamingContextStates_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003647 RID: 13895 RVA: 0x00107CF8 File Offset: 0x00105EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344818, XrefRangeEnd = 344823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamingContext.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003648 RID: 13896 RVA: 0x00107D4C File Offset: 0x00105F4C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamingContext.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x06003649 RID: 13897 RVA: 0x00107D90 File Offset: 0x00105F90
		public unsafe StreamingContextStates State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamingContext.NativeMethodInfoPtr_get_State_Public_get_StreamingContextStates_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600364A RID: 13898 RVA: 0x00013820 File Offset: 0x00011A20
		public StreamingContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600364B RID: 13899 RVA: 0x00013829 File Offset: 0x00011A29
		public StreamingContext()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr))
		{
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x0600364C RID: 13900 RVA: 0x00107DD4 File Offset: 0x00105FD4
		// (set) Token: 0x0600364D RID: 13901 RVA: 0x0001383B File Offset: 0x00011A3B
		public unsafe Object m_additionalContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamingContext.NativeFieldInfoPtr_m_additionalContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamingContext.NativeFieldInfoPtr_m_additionalContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x0600364E RID: 13902 RVA: 0x00107E04 File Offset: 0x00106004
		// (set) Token: 0x0600364F RID: 13903 RVA: 0x0001385A File Offset: 0x00011A5A
		public unsafe StreamingContextStates m_state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamingContext.NativeFieldInfoPtr_m_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamingContext.NativeFieldInfoPtr_m_state)) = value;
			}
		}

		// Token: 0x04002DB6 RID: 11702
		private static readonly IntPtr NativeFieldInfoPtr_m_additionalContext;

		// Token: 0x04002DB7 RID: 11703
		private static readonly IntPtr NativeFieldInfoPtr_m_state;

		// Token: 0x04002DB8 RID: 11704
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StreamingContextStates_0;

		// Token: 0x04002DB9 RID: 11705
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StreamingContextStates_Object_0;

		// Token: 0x04002DBA RID: 11706
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002DBB RID: 11707
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002DBC RID: 11708
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_StreamingContextStates_0;
	}
}
