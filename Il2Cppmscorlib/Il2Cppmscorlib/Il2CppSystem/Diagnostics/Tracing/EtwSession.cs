using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x0200051D RID: 1309
	public class EtwSession : Object
	{
		// Token: 0x06004BBA RID: 19386 RVA: 0x00159B94 File Offset: 0x00157D94
		// Note: this type is marked as 'beforefieldinit'.
		static EtwSession()
		{
			Il2CppClassPointerStore<EtwSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EtwSession");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EtwSession>.NativeClassPtr);
			EtwSession.NativeFieldInfoPtr_m_etwSessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EtwSession>.NativeClassPtr, "m_etwSessionId");
			EtwSession.NativeFieldInfoPtr_m_activityFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EtwSession>.NativeClassPtr, "m_activityFilter");
			EtwSession.NativeFieldInfoPtr_s_etwSessions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EtwSession>.NativeClassPtr, "s_etwSessions");
			EtwSession.NativeMethodInfoPtr_GetEtwSession_Public_Static_EtwSession_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EtwSession>.NativeClassPtr, 100674492);
			EtwSession.NativeMethodInfoPtr_RemoveEtwSession_Public_Static_Void_EtwSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EtwSession>.NativeClassPtr, 100674493);
			EtwSession.NativeMethodInfoPtr_TrimGlobalList_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EtwSession>.NativeClassPtr, 100674494);
			EtwSession.NativeMethodInfoPtr__ctor_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EtwSession>.NativeClassPtr, 100674495);
		}

		// Token: 0x06004BBB RID: 19387 RVA: 0x00159C50 File Offset: 0x00157E50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373823, RefRangeEnd = 373824, XrefRangeStart = 373767, XrefRangeEnd = 373823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EtwSession GetEtwSession(int etwSessionId, bool bCreateIfNeeded = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref etwSessionId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCreateIfNeeded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EtwSession.NativeMethodInfoPtr_GetEtwSession_Public_Static_EtwSession_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EtwSession>(intPtr3) : null;
		}

		// Token: 0x06004BBC RID: 19388 RVA: 0x00159CA0 File Offset: 0x00157EA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373849, RefRangeEnd = 373850, XrefRangeStart = 373824, XrefRangeEnd = 373849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveEtwSession(EtwSession etwSession)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(etwSession);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EtwSession.NativeMethodInfoPtr_RemoveEtwSession_Public_Static_Void_EtwSession_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004BBD RID: 19389 RVA: 0x00159CD8 File Offset: 0x00157ED8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 373874, RefRangeEnd = 373876, XrefRangeStart = 373850, XrefRangeEnd = 373874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TrimGlobalList()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EtwSession.NativeMethodInfoPtr_TrimGlobalList_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BBE RID: 19390 RVA: 0x00159D00 File Offset: 0x00157F00
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EtwSession(int etwSessionId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EtwSession>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref etwSessionId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EtwSession.NativeMethodInfoPtr__ctor_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004BBF RID: 19391 RVA: 0x0001C857 File Offset: 0x0001AA57
		public EtwSession(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x06004BC0 RID: 19392 RVA: 0x00159D48 File Offset: 0x00157F48
		// (set) Token: 0x06004BC1 RID: 19393 RVA: 0x0001C860 File Offset: 0x0001AA60
		public unsafe int m_etwSessionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EtwSession.NativeFieldInfoPtr_m_etwSessionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EtwSession.NativeFieldInfoPtr_m_etwSessionId)) = value;
			}
		}

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x06004BC2 RID: 19394 RVA: 0x00159D70 File Offset: 0x00157F70
		// (set) Token: 0x06004BC3 RID: 19395 RVA: 0x0001C87B File Offset: 0x0001AA7B
		public unsafe ActivityFilter m_activityFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EtwSession.NativeFieldInfoPtr_m_activityFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EtwSession.NativeFieldInfoPtr_m_activityFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x06004BC4 RID: 19396 RVA: 0x00159DA0 File Offset: 0x00157FA0
		// (set) Token: 0x06004BC5 RID: 19397 RVA: 0x0001C89A File Offset: 0x0001AA9A
		public unsafe static List<WeakReference<EtwSession>> s_etwSessions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EtwSession.NativeFieldInfoPtr_s_etwSessions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WeakReference<EtwSession>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EtwSession.NativeFieldInfoPtr_s_etwSessions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D1B RID: 15643
		private static readonly IntPtr NativeFieldInfoPtr_m_etwSessionId;

		// Token: 0x04003D1C RID: 15644
		private static readonly IntPtr NativeFieldInfoPtr_m_activityFilter;

		// Token: 0x04003D1D RID: 15645
		private static readonly IntPtr NativeFieldInfoPtr_s_etwSessions;

		// Token: 0x04003D1E RID: 15646
		private static readonly IntPtr NativeMethodInfoPtr_GetEtwSession_Public_Static_EtwSession_Int32_Boolean_0;

		// Token: 0x04003D1F RID: 15647
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEtwSession_Public_Static_Void_EtwSession_0;

		// Token: 0x04003D20 RID: 15648
		private static readonly IntPtr NativeMethodInfoPtr_TrimGlobalList_Private_Static_Void_0;

		// Token: 0x04003D21 RID: 15649
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_0;

		// Token: 0x02000684 RID: 1668
		[ObfuscatedName("System.Diagnostics.Tracing.EtwSession+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06005740 RID: 22336 RVA: 0x0017FE08 File Offset: 0x0017E008
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<EtwSession.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EtwSession>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EtwSession.__c__DisplayClass1_0>.NativeClassPtr);
				EtwSession.__c__DisplayClass1_0.NativeFieldInfoPtr_etwSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EtwSession.__c__DisplayClass1_0>.NativeClassPtr, "etwSession");
				EtwSession.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EtwSession.__c__DisplayClass1_0>.NativeClassPtr, 100674497);
				EtwSession.__c__DisplayClass1_0.NativeMethodInfoPtr__RemoveEtwSession_b__0_Internal_Boolean_WeakReference_1_EtwSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EtwSession.__c__DisplayClass1_0>.NativeClassPtr, 100674498);
			}

			// Token: 0x06005741 RID: 22337 RVA: 0x0017FE70 File Offset: 0x0017E070
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EtwSession.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EtwSession.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005742 RID: 22338 RVA: 0x0017FEAC File Offset: 0x0017E0AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373761, XrefRangeEnd = 373764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveEtwSession_b__0(WeakReference<EtwSession> wrEtwSession)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(wrEtwSession);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EtwSession.__c__DisplayClass1_0.NativeMethodInfoPtr__RemoveEtwSession_b__0_Internal_Boolean_WeakReference_1_EtwSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005743 RID: 22339 RVA: 0x00021D03 File Offset: 0x0001FF03
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001675 RID: 5749
			// (get) Token: 0x06005744 RID: 22340 RVA: 0x0017FEFC File Offset: 0x0017E0FC
			// (set) Token: 0x06005745 RID: 22341 RVA: 0x00021D0C File Offset: 0x0001FF0C
			public unsafe EtwSession etwSession
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EtwSession.__c__DisplayClass1_0.NativeFieldInfoPtr_etwSession);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EtwSession>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EtwSession.__c__DisplayClass1_0.NativeFieldInfoPtr_etwSession), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040045D8 RID: 17880
			private static readonly IntPtr NativeFieldInfoPtr_etwSession;

			// Token: 0x040045D9 RID: 17881
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040045DA RID: 17882
			private static readonly IntPtr NativeMethodInfoPtr__RemoveEtwSession_b__0_Internal_Boolean_WeakReference_1_EtwSession_0;
		}

		// Token: 0x02000685 RID: 1669
		[ObfuscatedName("System.Diagnostics.Tracing.EtwSession+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005746 RID: 22342 RVA: 0x0017FF2C File Offset: 0x0017E12C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EtwSession.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EtwSession>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EtwSession.__c>.NativeClassPtr);
				EtwSession.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EtwSession.__c>.NativeClassPtr, "<>9");
				EtwSession.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EtwSession.__c>.NativeClassPtr, "<>9__2_0");
				EtwSession.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EtwSession.__c>.NativeClassPtr, 100674500);
				EtwSession.__c.NativeMethodInfoPtr__TrimGlobalList_b__2_0_Internal_Boolean_WeakReference_1_EtwSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EtwSession.__c>.NativeClassPtr, 100674501);
			}

			// Token: 0x06005747 RID: 22343 RVA: 0x0017FFA8 File Offset: 0x0017E1A8
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EtwSession.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EtwSession.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005748 RID: 22344 RVA: 0x0017FFE4 File Offset: 0x0017E1E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373764, XrefRangeEnd = 373767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TrimGlobalList_b__2_0(WeakReference<EtwSession> wrEtwSession)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(wrEtwSession);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EtwSession.__c.NativeMethodInfoPtr__TrimGlobalList_b__2_0_Internal_Boolean_WeakReference_1_EtwSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005749 RID: 22345 RVA: 0x00021D2B File Offset: 0x0001FF2B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001676 RID: 5750
			// (get) Token: 0x0600574A RID: 22346 RVA: 0x00180034 File Offset: 0x0017E234
			// (set) Token: 0x0600574B RID: 22347 RVA: 0x00021D34 File Offset: 0x0001FF34
			public unsafe static EtwSession.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EtwSession.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EtwSession.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EtwSession.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001677 RID: 5751
			// (get) Token: 0x0600574C RID: 22348 RVA: 0x0018005C File Offset: 0x0017E25C
			// (set) Token: 0x0600574D RID: 22349 RVA: 0x00021D46 File Offset: 0x0001FF46
			public unsafe static Predicate<WeakReference<EtwSession>> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EtwSession.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<WeakReference<EtwSession>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EtwSession.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040045DB RID: 17883
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040045DC RID: 17884
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x040045DD RID: 17885
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040045DE RID: 17886
			private static readonly IntPtr NativeMethodInfoPtr__TrimGlobalList_b__2_0_Internal_Boolean_WeakReference_1_EtwSession_0;
		}
	}
}
