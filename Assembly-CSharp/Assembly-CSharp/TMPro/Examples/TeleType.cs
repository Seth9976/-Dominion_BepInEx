using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000107 RID: 263
	public class TeleType : MonoBehaviour
	{
		// Token: 0x06001F11 RID: 7953 RVA: 0x00078DD4 File Offset: 0x00076FD4
		// Note: this type is marked as 'beforefieldinit'.
		static TeleType()
		{
			Il2CppClassPointerStore<TeleType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "TeleType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeleType>.NativeClassPtr);
			TeleType.NativeFieldInfoPtr_label01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleType>.NativeClassPtr, "label01");
			TeleType.NativeFieldInfoPtr_label02 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleType>.NativeClassPtr, "label02");
			TeleType.NativeFieldInfoPtr_m_textMeshPro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleType>.NativeClassPtr, "m_textMeshPro");
			TeleType.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleType>.NativeClassPtr, 100665838);
			TeleType.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleType>.NativeClassPtr, 100665839);
			TeleType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleType>.NativeClassPtr, 100665840);
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x00078E7C File Offset: 0x0007707C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256091, XrefRangeEnd = 256097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TeleType.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x00078EB0 File Offset: 0x000770B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256097, XrefRangeEnd = 256101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TeleType.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x00078EF0 File Offset: 0x000770F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256101, XrefRangeEnd = 256106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TeleType()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TeleType>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TeleType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x00013635 File Offset: 0x00011835
		public TeleType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06001F16 RID: 7958 RVA: 0x00078F2C File Offset: 0x0007712C
		// (set) Token: 0x06001F17 RID: 7959 RVA: 0x0001363E File Offset: 0x0001183E
		public unsafe string label01
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TeleType.NativeFieldInfoPtr_label01);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TeleType.NativeFieldInfoPtr_label01), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06001F18 RID: 7960 RVA: 0x00078F54 File Offset: 0x00077154
		// (set) Token: 0x06001F19 RID: 7961 RVA: 0x0001365D File Offset: 0x0001185D
		public unsafe string label02
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TeleType.NativeFieldInfoPtr_label02);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TeleType.NativeFieldInfoPtr_label02), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06001F1A RID: 7962 RVA: 0x00078F7C File Offset: 0x0007717C
		// (set) Token: 0x06001F1B RID: 7963 RVA: 0x0001367C File Offset: 0x0001187C
		public unsafe TMP_Text m_textMeshPro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TeleType.NativeFieldInfoPtr_m_textMeshPro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TeleType.NativeFieldInfoPtr_m_textMeshPro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014FB RID: 5371
		private static readonly IntPtr NativeFieldInfoPtr_label01;

		// Token: 0x040014FC RID: 5372
		private static readonly IntPtr NativeFieldInfoPtr_label02;

		// Token: 0x040014FD RID: 5373
		private static readonly IntPtr NativeFieldInfoPtr_m_textMeshPro;

		// Token: 0x040014FE RID: 5374
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040014FF RID: 5375
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04001500 RID: 5376
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000228 RID: 552
		[ObfuscatedName("TMPro.Examples.TeleType+<Start>d__4")]
		public sealed class _Start_d__4 : global::Il2CppSystem.Object
		{
			// Token: 0x06002AA1 RID: 10913 RVA: 0x00098B38 File Offset: 0x00096D38
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__4()
			{
				Il2CppClassPointerStore<TeleType._Start_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleType>.NativeClassPtr, "<Start>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeleType._Start_d__4>.NativeClassPtr);
				TeleType._Start_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleType._Start_d__4>.NativeClassPtr, "<>1__state");
				TeleType._Start_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleType._Start_d__4>.NativeClassPtr, "<>2__current");
				TeleType._Start_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleType._Start_d__4>.NativeClassPtr, "<>4__this");
				TeleType._Start_d__4.NativeFieldInfoPtr__totalVisibleCharacters_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleType._Start_d__4>.NativeClassPtr, "<totalVisibleCharacters>5__2");
				TeleType._Start_d__4.NativeFieldInfoPtr__counter_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleType._Start_d__4>.NativeClassPtr, "<counter>5__3");
				TeleType._Start_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleType._Start_d__4>.NativeClassPtr, 100666659);
				TeleType._Start_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleType._Start_d__4>.NativeClassPtr, 100666660);
				TeleType._Start_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleType._Start_d__4>.NativeClassPtr, 100666661);
				TeleType._Start_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleType._Start_d__4>.NativeClassPtr, 100666662);
				TeleType._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleType._Start_d__4>.NativeClassPtr, 100666663);
				TeleType._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleType._Start_d__4>.NativeClassPtr, 100666664);
			}

			// Token: 0x06002AA2 RID: 10914 RVA: 0x00098C40 File Offset: 0x00096E40
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TeleType._Start_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TeleType._Start_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002AA3 RID: 10915 RVA: 0x00098C88 File Offset: 0x00096E88
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TeleType._Start_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AA4 RID: 10916 RVA: 0x00098CBC File Offset: 0x00096EBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256085, XrefRangeEnd = 256086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TeleType._Start_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D71 RID: 3441
			// (get) Token: 0x06002AA5 RID: 10917 RVA: 0x00098CF8 File Offset: 0x00096EF8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TeleType._Start_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002AA6 RID: 10918 RVA: 0x00098D38 File Offset: 0x00096F38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256086, XrefRangeEnd = 256091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TeleType._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D72 RID: 3442
			// (get) Token: 0x06002AA7 RID: 10919 RVA: 0x00098D6C File Offset: 0x00096F6C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TeleType._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002AA8 RID: 10920 RVA: 0x0001A2AD File Offset: 0x000184AD
			public _Start_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D6C RID: 3436
			// (get) Token: 0x06002AA9 RID: 10921 RVA: 0x00098DAC File Offset: 0x00096FAC
			// (set) Token: 0x06002AAA RID: 10922 RVA: 0x0001A2B6 File Offset: 0x000184B6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TeleType._Start_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TeleType._Start_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D6D RID: 3437
			// (get) Token: 0x06002AAB RID: 10923 RVA: 0x00098DD4 File Offset: 0x00096FD4
			// (set) Token: 0x06002AAC RID: 10924 RVA: 0x0001A2D1 File Offset: 0x000184D1
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TeleType._Start_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TeleType._Start_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D6E RID: 3438
			// (get) Token: 0x06002AAD RID: 10925 RVA: 0x00098E04 File Offset: 0x00097004
			// (set) Token: 0x06002AAE RID: 10926 RVA: 0x0001A2F0 File Offset: 0x000184F0
			public unsafe TeleType __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TeleType._Start_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TeleType>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TeleType._Start_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D6F RID: 3439
			// (get) Token: 0x06002AAF RID: 10927 RVA: 0x00098E34 File Offset: 0x00097034
			// (set) Token: 0x06002AB0 RID: 10928 RVA: 0x0001A30F File Offset: 0x0001850F
			public unsafe int _totalVisibleCharacters_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TeleType._Start_d__4.NativeFieldInfoPtr__totalVisibleCharacters_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TeleType._Start_d__4.NativeFieldInfoPtr__totalVisibleCharacters_5__2)) = value;
				}
			}

			// Token: 0x17000D70 RID: 3440
			// (get) Token: 0x06002AB1 RID: 10929 RVA: 0x00098E5C File Offset: 0x0009705C
			// (set) Token: 0x06002AB2 RID: 10930 RVA: 0x0001A32A File Offset: 0x0001852A
			public unsafe int _counter_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TeleType._Start_d__4.NativeFieldInfoPtr__counter_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TeleType._Start_d__4.NativeFieldInfoPtr__counter_5__3)) = value;
				}
			}

			// Token: 0x04001D26 RID: 7462
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D27 RID: 7463
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D28 RID: 7464
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001D29 RID: 7465
			private static readonly IntPtr NativeFieldInfoPtr__totalVisibleCharacters_5__2;

			// Token: 0x04001D2A RID: 7466
			private static readonly IntPtr NativeFieldInfoPtr__counter_5__3;

			// Token: 0x04001D2B RID: 7467
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001D2C RID: 7468
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D2D RID: 7469
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001D2E RID: 7470
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001D2F RID: 7471
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D30 RID: 7472
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
