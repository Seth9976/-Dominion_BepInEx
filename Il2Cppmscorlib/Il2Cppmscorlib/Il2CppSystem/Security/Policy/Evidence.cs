using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Security.Policy
{
	// Token: 0x020002C2 RID: 706
	[Serializable]
	public sealed class Evidence : Object
	{
		// Token: 0x06002F39 RID: 12089 RVA: 0x000EDFF4 File Offset: 0x000EC1F4
		// Note: this type is marked as 'beforefieldinit'.
		static Evidence()
		{
			Il2CppClassPointerStore<Evidence>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Policy", "Evidence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Evidence>.NativeClassPtr);
			Evidence.NativeFieldInfoPtr__locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Evidence>.NativeClassPtr, "_locked");
			Evidence.NativeFieldInfoPtr_hostEvidenceList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Evidence>.NativeClassPtr, "hostEvidenceList");
			Evidence.NativeFieldInfoPtr_assemblyEvidenceList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Evidence>.NativeClassPtr, "assemblyEvidenceList");
			Evidence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence>.NativeClassPtr, 100670786);
			Evidence.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence>.NativeClassPtr, 100670787);
			Evidence.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence>.NativeClassPtr, 100670788);
			Evidence.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence>.NativeClassPtr, 100670789);
		}

		// Token: 0x06002F3A RID: 12090 RVA: 0x000EE0B0 File Offset: 0x000EC2B0
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Evidence()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Evidence>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06002F3B RID: 12091 RVA: 0x000EE0EC File Offset: 0x000EC2EC
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F3C RID: 12092 RVA: 0x000EE128 File Offset: 0x000EC328
		[CallerCount(0)]
		public unsafe void CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x000EE178 File Offset: 0x000EC378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337866, XrefRangeEnd = 337870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x00010789 File Offset: 0x0000E989
		public Evidence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06002F3F RID: 12095 RVA: 0x000EE1B8 File Offset: 0x000EC3B8
		// (set) Token: 0x06002F40 RID: 12096 RVA: 0x00010792 File Offset: 0x0000E992
		public unsafe bool _locked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.NativeFieldInfoPtr__locked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.NativeFieldInfoPtr__locked)) = value;
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06002F41 RID: 12097 RVA: 0x000EE1E0 File Offset: 0x000EC3E0
		// (set) Token: 0x06002F42 RID: 12098 RVA: 0x000107AD File Offset: 0x0000E9AD
		public unsafe ArrayList hostEvidenceList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.NativeFieldInfoPtr_hostEvidenceList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.NativeFieldInfoPtr_hostEvidenceList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06002F43 RID: 12099 RVA: 0x000EE210 File Offset: 0x000EC410
		// (set) Token: 0x06002F44 RID: 12100 RVA: 0x000107CC File Offset: 0x0000E9CC
		public unsafe ArrayList assemblyEvidenceList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.NativeFieldInfoPtr_assemblyEvidenceList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.NativeFieldInfoPtr_assemblyEvidenceList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040028D0 RID: 10448
		private static readonly IntPtr NativeFieldInfoPtr__locked;

		// Token: 0x040028D1 RID: 10449
		private static readonly IntPtr NativeFieldInfoPtr_hostEvidenceList;

		// Token: 0x040028D2 RID: 10450
		private static readonly IntPtr NativeFieldInfoPtr_assemblyEvidenceList;

		// Token: 0x040028D3 RID: 10451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040028D4 RID: 10452
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040028D5 RID: 10453
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x040028D6 RID: 10454
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0200061D RID: 1565
		public class EvidenceEnumerator : Object
		{
			// Token: 0x0600538B RID: 21387 RVA: 0x00173338 File Offset: 0x00171538
			// Note: this type is marked as 'beforefieldinit'.
			static EvidenceEnumerator()
			{
				Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Evidence>.NativeClassPtr, "EvidenceEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr);
				Evidence.EvidenceEnumerator.NativeFieldInfoPtr_currentEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr, "currentEnum");
				Evidence.EvidenceEnumerator.NativeFieldInfoPtr_hostEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr, "hostEnum");
				Evidence.EvidenceEnumerator.NativeFieldInfoPtr_assemblyEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr, "assemblyEnum");
				Evidence.EvidenceEnumerator.NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr, 100670790);
				Evidence.EvidenceEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr, 100670791);
				Evidence.EvidenceEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr, 100670792);
				Evidence.EvidenceEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr, 100670793);
			}

			// Token: 0x0600538C RID: 21388 RVA: 0x001733F0 File Offset: 0x001715F0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 337850, RefRangeEnd = 337851, XrefRangeStart = 337849, XrefRangeEnd = 337850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EvidenceEnumerator(IEnumerator hostenum, IEnumerator assemblyenum)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(hostenum);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assemblyenum);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.EvidenceEnumerator.NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600538D RID: 21389 RVA: 0x00173450 File Offset: 0x00171650
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337851, XrefRangeEnd = 337856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.EvidenceEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600538E RID: 21390 RVA: 0x0017348C File Offset: 0x0017168C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337856, XrefRangeEnd = 337862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.EvidenceEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700155B RID: 5467
			// (get) Token: 0x0600538F RID: 21391 RVA: 0x001734C0 File Offset: 0x001716C0
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337862, XrefRangeEnd = 337866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.EvidenceEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005390 RID: 21392 RVA: 0x00020032 File Offset: 0x0001E232
			public EvidenceEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001558 RID: 5464
			// (get) Token: 0x06005391 RID: 21393 RVA: 0x00173500 File Offset: 0x00171700
			// (set) Token: 0x06005392 RID: 21394 RVA: 0x0002003B File Offset: 0x0001E23B
			public unsafe IEnumerator currentEnum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.EvidenceEnumerator.NativeFieldInfoPtr_currentEnum);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.EvidenceEnumerator.NativeFieldInfoPtr_currentEnum), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001559 RID: 5465
			// (get) Token: 0x06005393 RID: 21395 RVA: 0x00173530 File Offset: 0x00171730
			// (set) Token: 0x06005394 RID: 21396 RVA: 0x0002005A File Offset: 0x0001E25A
			public unsafe IEnumerator hostEnum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.EvidenceEnumerator.NativeFieldInfoPtr_hostEnum);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.EvidenceEnumerator.NativeFieldInfoPtr_hostEnum), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700155A RID: 5466
			// (get) Token: 0x06005395 RID: 21397 RVA: 0x00173560 File Offset: 0x00171760
			// (set) Token: 0x06005396 RID: 21398 RVA: 0x00020079 File Offset: 0x0001E279
			public unsafe IEnumerator assemblyEnum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.EvidenceEnumerator.NativeFieldInfoPtr_assemblyEnum);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.EvidenceEnumerator.NativeFieldInfoPtr_assemblyEnum), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004379 RID: 17273
			private static readonly IntPtr NativeFieldInfoPtr_currentEnum;

			// Token: 0x0400437A RID: 17274
			private static readonly IntPtr NativeFieldInfoPtr_hostEnum;

			// Token: 0x0400437B RID: 17275
			private static readonly IntPtr NativeFieldInfoPtr_assemblyEnum;

			// Token: 0x0400437C RID: 17276
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_IEnumerator_0;

			// Token: 0x0400437D RID: 17277
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x0400437E RID: 17278
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

			// Token: 0x0400437F RID: 17279
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;
		}
	}
}
