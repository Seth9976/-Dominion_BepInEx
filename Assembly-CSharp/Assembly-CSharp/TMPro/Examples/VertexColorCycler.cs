using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000113 RID: 275
	public class VertexColorCycler : MonoBehaviour
	{
		// Token: 0x06002002 RID: 8194 RVA: 0x0007B614 File Offset: 0x00079814
		// Note: this type is marked as 'beforefieldinit'.
		static VertexColorCycler()
		{
			Il2CppClassPointerStore<VertexColorCycler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "VertexColorCycler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VertexColorCycler>.NativeClassPtr);
			VertexColorCycler.NativeFieldInfoPtr_m_TextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexColorCycler>.NativeClassPtr, "m_TextComponent");
			VertexColorCycler.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexColorCycler>.NativeClassPtr, 100665897);
			VertexColorCycler.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexColorCycler>.NativeClassPtr, 100665898);
			VertexColorCycler.NativeMethodInfoPtr_AnimateVertexColors_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexColorCycler>.NativeClassPtr, 100665899);
			VertexColorCycler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexColorCycler>.NativeClassPtr, 100665900);
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x0007B6A8 File Offset: 0x000798A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256999, XrefRangeEnd = 257002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexColorCycler.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x0007B6DC File Offset: 0x000798DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257002, XrefRangeEnd = 257008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexColorCycler.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x0007B710 File Offset: 0x00079910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257008, XrefRangeEnd = 257012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator AnimateVertexColors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexColorCycler.NativeMethodInfoPtr_AnimateVertexColors_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x0007B750 File Offset: 0x00079950
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VertexColorCycler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VertexColorCycler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexColorCycler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x00013F58 File Offset: 0x00012158
		public VertexColorCycler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06002008 RID: 8200 RVA: 0x0007B78C File Offset: 0x0007998C
		// (set) Token: 0x06002009 RID: 8201 RVA: 0x00013F61 File Offset: 0x00012161
		public unsafe TMP_Text m_TextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexColorCycler.NativeFieldInfoPtr_m_TextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexColorCycler.NativeFieldInfoPtr_m_TextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001585 RID: 5509
		private static readonly IntPtr NativeFieldInfoPtr_m_TextComponent;

		// Token: 0x04001586 RID: 5510
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001587 RID: 5511
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001588 RID: 5512
		private static readonly IntPtr NativeMethodInfoPtr_AnimateVertexColors_Private_IEnumerator_0;

		// Token: 0x04001589 RID: 5513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000231 RID: 561
		[ObfuscatedName("TMPro.Examples.VertexColorCycler+<AnimateVertexColors>d__3")]
		public sealed class _AnimateVertexColors_d__3 : global::Il2CppSystem.Object
		{
			// Token: 0x06002B17 RID: 11031 RVA: 0x00099F0C File Offset: 0x0009810C
			// Note: this type is marked as 'beforefieldinit'.
			static _AnimateVertexColors_d__3()
			{
				Il2CppClassPointerStore<VertexColorCycler._AnimateVertexColors_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VertexColorCycler>.NativeClassPtr, "<AnimateVertexColors>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VertexColorCycler._AnimateVertexColors_d__3>.NativeClassPtr);
				VertexColorCycler._AnimateVertexColors_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexColorCycler._AnimateVertexColors_d__3>.NativeClassPtr, "<>1__state");
				VertexColorCycler._AnimateVertexColors_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexColorCycler._AnimateVertexColors_d__3>.NativeClassPtr, "<>2__current");
				VertexColorCycler._AnimateVertexColors_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexColorCycler._AnimateVertexColors_d__3>.NativeClassPtr, "<>4__this");
				VertexColorCycler._AnimateVertexColors_d__3.NativeFieldInfoPtr__textInfo_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexColorCycler._AnimateVertexColors_d__3>.NativeClassPtr, "<textInfo>5__2");
				VertexColorCycler._AnimateVertexColors_d__3.NativeFieldInfoPtr__currentCharacter_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexColorCycler._AnimateVertexColors_d__3>.NativeClassPtr, "<currentCharacter>5__3");
				VertexColorCycler._AnimateVertexColors_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexColorCycler._AnimateVertexColors_d__3>.NativeClassPtr, 100666689);
				VertexColorCycler._AnimateVertexColors_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexColorCycler._AnimateVertexColors_d__3>.NativeClassPtr, 100666690);
				VertexColorCycler._AnimateVertexColors_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexColorCycler._AnimateVertexColors_d__3>.NativeClassPtr, 100666691);
				VertexColorCycler._AnimateVertexColors_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexColorCycler._AnimateVertexColors_d__3>.NativeClassPtr, 100666692);
				VertexColorCycler._AnimateVertexColors_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexColorCycler._AnimateVertexColors_d__3>.NativeClassPtr, 100666693);
				VertexColorCycler._AnimateVertexColors_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexColorCycler._AnimateVertexColors_d__3>.NativeClassPtr, 100666694);
			}

			// Token: 0x06002B18 RID: 11032 RVA: 0x0009A014 File Offset: 0x00098214
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AnimateVertexColors_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VertexColorCycler._AnimateVertexColors_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexColorCycler._AnimateVertexColors_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B19 RID: 11033 RVA: 0x0009A05C File Offset: 0x0009825C
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexColorCycler._AnimateVertexColors_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B1A RID: 11034 RVA: 0x0009A090 File Offset: 0x00098290
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256983, XrefRangeEnd = 256994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexColorCycler._AnimateVertexColors_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000DA2 RID: 3490
			// (get) Token: 0x06002B1B RID: 11035 RVA: 0x0009A0CC File Offset: 0x000982CC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexColorCycler._AnimateVertexColors_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B1C RID: 11036 RVA: 0x0009A10C File Offset: 0x0009830C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256994, XrefRangeEnd = 256999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexColorCycler._AnimateVertexColors_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DA3 RID: 3491
			// (get) Token: 0x06002B1D RID: 11037 RVA: 0x0009A140 File Offset: 0x00098340
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexColorCycler._AnimateVertexColors_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B1E RID: 11038 RVA: 0x0001A727 File Offset: 0x00018927
			public _AnimateVertexColors_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D9D RID: 3485
			// (get) Token: 0x06002B1F RID: 11039 RVA: 0x0009A180 File Offset: 0x00098380
			// (set) Token: 0x06002B20 RID: 11040 RVA: 0x0001A730 File Offset: 0x00018930
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexColorCycler._AnimateVertexColors_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexColorCycler._AnimateVertexColors_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D9E RID: 3486
			// (get) Token: 0x06002B21 RID: 11041 RVA: 0x0009A1A8 File Offset: 0x000983A8
			// (set) Token: 0x06002B22 RID: 11042 RVA: 0x0001A74B File Offset: 0x0001894B
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexColorCycler._AnimateVertexColors_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexColorCycler._AnimateVertexColors_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D9F RID: 3487
			// (get) Token: 0x06002B23 RID: 11043 RVA: 0x0009A1D8 File Offset: 0x000983D8
			// (set) Token: 0x06002B24 RID: 11044 RVA: 0x0001A76A File Offset: 0x0001896A
			public unsafe VertexColorCycler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexColorCycler._AnimateVertexColors_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VertexColorCycler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexColorCycler._AnimateVertexColors_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DA0 RID: 3488
			// (get) Token: 0x06002B25 RID: 11045 RVA: 0x0009A208 File Offset: 0x00098408
			// (set) Token: 0x06002B26 RID: 11046 RVA: 0x0001A789 File Offset: 0x00018989
			public unsafe TMP_TextInfo _textInfo_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexColorCycler._AnimateVertexColors_d__3.NativeFieldInfoPtr__textInfo_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_TextInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexColorCycler._AnimateVertexColors_d__3.NativeFieldInfoPtr__textInfo_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DA1 RID: 3489
			// (get) Token: 0x06002B27 RID: 11047 RVA: 0x0009A238 File Offset: 0x00098438
			// (set) Token: 0x06002B28 RID: 11048 RVA: 0x0001A7A8 File Offset: 0x000189A8
			public unsafe int _currentCharacter_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexColorCycler._AnimateVertexColors_d__3.NativeFieldInfoPtr__currentCharacter_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexColorCycler._AnimateVertexColors_d__3.NativeFieldInfoPtr__currentCharacter_5__3)) = value;
				}
			}

			// Token: 0x04001D7D RID: 7549
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D7E RID: 7550
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D7F RID: 7551
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001D80 RID: 7552
			private static readonly IntPtr NativeFieldInfoPtr__textInfo_5__2;

			// Token: 0x04001D81 RID: 7553
			private static readonly IntPtr NativeFieldInfoPtr__currentCharacter_5__3;

			// Token: 0x04001D82 RID: 7554
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001D83 RID: 7555
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D84 RID: 7556
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001D85 RID: 7557
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001D86 RID: 7558
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D87 RID: 7559
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
