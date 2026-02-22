using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Resources
{
	// Token: 0x02000182 RID: 386
	public class ResourceFallbackManager : Object
	{
		// Token: 0x06001A8D RID: 6797 RVA: 0x0009A964 File Offset: 0x00098B64
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceFallbackManager()
		{
			Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "ResourceFallbackManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr);
			ResourceFallbackManager.NativeFieldInfoPtr_m_startingCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr, "m_startingCulture");
			ResourceFallbackManager.NativeFieldInfoPtr_m_neutralResourcesCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr, "m_neutralResourcesCulture");
			ResourceFallbackManager.NativeFieldInfoPtr_m_useParents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr, "m_useParents");
			ResourceFallbackManager.NativeMethodInfoPtr__ctor_Internal_Void_CultureInfo_CultureInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr, 100667781);
			ResourceFallbackManager.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr, 100667782);
			ResourceFallbackManager.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr, 100667783);
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x0009AA0C File Offset: 0x00098C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315817, XrefRangeEnd = 315822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceFallbackManager(CultureInfo startingCulture, CultureInfo neutralResourcesCulture, bool useParents)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(startingCulture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(neutralResourcesCulture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useParents;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager.NativeMethodInfoPtr__ctor_Internal_Void_CultureInfo_CultureInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x0009AA78 File Offset: 0x00098C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315822, XrefRangeEnd = 315826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x0009AAB8 File Offset: 0x00098CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<CultureInfo> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<CultureInfo>>(intPtr3) : null;
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x000090A9 File Offset: 0x000072A9
		public ResourceFallbackManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001A92 RID: 6802 RVA: 0x0009AAF8 File Offset: 0x00098CF8
		// (set) Token: 0x06001A93 RID: 6803 RVA: 0x000090B2 File Offset: 0x000072B2
		public unsafe CultureInfo m_startingCulture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager.NativeFieldInfoPtr_m_startingCulture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager.NativeFieldInfoPtr_m_startingCulture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001A94 RID: 6804 RVA: 0x0009AB28 File Offset: 0x00098D28
		// (set) Token: 0x06001A95 RID: 6805 RVA: 0x000090D1 File Offset: 0x000072D1
		public unsafe CultureInfo m_neutralResourcesCulture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager.NativeFieldInfoPtr_m_neutralResourcesCulture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager.NativeFieldInfoPtr_m_neutralResourcesCulture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001A96 RID: 6806 RVA: 0x0009AB58 File Offset: 0x00098D58
		// (set) Token: 0x06001A97 RID: 6807 RVA: 0x000090F0 File Offset: 0x000072F0
		public unsafe bool m_useParents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager.NativeFieldInfoPtr_m_useParents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager.NativeFieldInfoPtr_m_useParents)) = value;
			}
		}

		// Token: 0x0400181D RID: 6173
		private static readonly IntPtr NativeFieldInfoPtr_m_startingCulture;

		// Token: 0x0400181E RID: 6174
		private static readonly IntPtr NativeFieldInfoPtr_m_neutralResourcesCulture;

		// Token: 0x0400181F RID: 6175
		private static readonly IntPtr NativeFieldInfoPtr_m_useParents;

		// Token: 0x04001820 RID: 6176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CultureInfo_CultureInfo_Boolean_0;

		// Token: 0x04001821 RID: 6177
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04001822 RID: 6178
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_CultureInfo_0;

		// Token: 0x020005BE RID: 1470
		[ObfuscatedName("System.Resources.ResourceFallbackManager+<GetEnumerator>d__5")]
		public sealed class _GetEnumerator_d__5 : Object
		{
			// Token: 0x060050C7 RID: 20679 RVA: 0x00169DAC File Offset: 0x00167FAC
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumerator_d__5()
			{
				Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr, "<GetEnumerator>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr);
				ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, "<>1__state");
				ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, "<>2__current");
				ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, "<>4__this");
				ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr__currentCulture_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, "<currentCulture>5__1");
				ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr__reachedNeutralResourcesCulture_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, "<reachedNeutralResourcesCulture>5__2");
				ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, 100667784);
				ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, 100667785);
				ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, 100667786);
				ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Globalization_CultureInfo__get_Current_Private_Virtual_Final_New_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, 100667787);
				ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, 100667788);
				ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, 100667789);
			}

			// Token: 0x060050C8 RID: 20680 RVA: 0x00169EB4 File Offset: 0x001680B4
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEnumerator_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050C9 RID: 20681 RVA: 0x00169EFC File Offset: 0x001680FC
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050CA RID: 20682 RVA: 0x00169F30 File Offset: 0x00168130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315811, XrefRangeEnd = 315812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170014A3 RID: 5283
			// (get) Token: 0x060050CB RID: 20683 RVA: 0x00169F6C File Offset: 0x0016816C
			public unsafe CultureInfo System.Collections.Generic.IEnumerator<System.Globalization.CultureInfo>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Globalization_CultureInfo__get_Current_Private_Virtual_Final_New_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
				}
			}

			// Token: 0x060050CC RID: 20684 RVA: 0x00169FAC File Offset: 0x001681AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315812, XrefRangeEnd = 315817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170014A4 RID: 5284
			// (get) Token: 0x060050CD RID: 20685 RVA: 0x00169FE0 File Offset: 0x001681E0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060050CE RID: 20686 RVA: 0x0001EC10 File Offset: 0x0001CE10
			public _GetEnumerator_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700149E RID: 5278
			// (get) Token: 0x060050CF RID: 20687 RVA: 0x0016A020 File Offset: 0x00168220
			// (set) Token: 0x060050D0 RID: 20688 RVA: 0x0001EC19 File Offset: 0x0001CE19
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700149F RID: 5279
			// (get) Token: 0x060050D1 RID: 20689 RVA: 0x0016A048 File Offset: 0x00168248
			// (set) Token: 0x060050D2 RID: 20690 RVA: 0x0001EC34 File Offset: 0x0001CE34
			public unsafe CultureInfo __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014A0 RID: 5280
			// (get) Token: 0x060050D3 RID: 20691 RVA: 0x0016A078 File Offset: 0x00168278
			// (set) Token: 0x060050D4 RID: 20692 RVA: 0x0001EC53 File Offset: 0x0001CE53
			public unsafe ResourceFallbackManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceFallbackManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014A1 RID: 5281
			// (get) Token: 0x060050D5 RID: 20693 RVA: 0x0016A0A8 File Offset: 0x001682A8
			// (set) Token: 0x060050D6 RID: 20694 RVA: 0x0001EC72 File Offset: 0x0001CE72
			public unsafe CultureInfo _currentCulture_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr__currentCulture_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr__currentCulture_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014A2 RID: 5282
			// (get) Token: 0x060050D7 RID: 20695 RVA: 0x0016A0D8 File Offset: 0x001682D8
			// (set) Token: 0x060050D8 RID: 20696 RVA: 0x0001EC91 File Offset: 0x0001CE91
			public unsafe bool _reachedNeutralResourcesCulture_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr__reachedNeutralResourcesCulture_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr__reachedNeutralResourcesCulture_5__2)) = value;
				}
			}

			// Token: 0x04004194 RID: 16788
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004195 RID: 16789
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004196 RID: 16790
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004197 RID: 16791
			private static readonly IntPtr NativeFieldInfoPtr__currentCulture_5__1;

			// Token: 0x04004198 RID: 16792
			private static readonly IntPtr NativeFieldInfoPtr__reachedNeutralResourcesCulture_5__2;

			// Token: 0x04004199 RID: 16793
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400419A RID: 16794
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400419B RID: 16795
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400419C RID: 16796
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Globalization_CultureInfo__get_Current_Private_Virtual_Final_New_get_CultureInfo_0;

			// Token: 0x0400419D RID: 16797
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400419E RID: 16798
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
