using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000106 RID: 262
	public class SkewTextExample : MonoBehaviour
	{
		// Token: 0x06001F02 RID: 7938 RVA: 0x00078B0C File Offset: 0x00076D0C
		// Note: this type is marked as 'beforefieldinit'.
		static SkewTextExample()
		{
			Il2CppClassPointerStore<SkewTextExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "SkewTextExample");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkewTextExample>.NativeClassPtr);
			SkewTextExample.NativeFieldInfoPtr_m_TextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewTextExample>.NativeClassPtr, "m_TextComponent");
			SkewTextExample.NativeFieldInfoPtr_VertexCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewTextExample>.NativeClassPtr, "VertexCurve");
			SkewTextExample.NativeFieldInfoPtr_CurveScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewTextExample>.NativeClassPtr, "CurveScale");
			SkewTextExample.NativeFieldInfoPtr_ShearAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewTextExample>.NativeClassPtr, "ShearAmount");
			SkewTextExample.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewTextExample>.NativeClassPtr, 100665833);
			SkewTextExample.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewTextExample>.NativeClassPtr, 100665834);
			SkewTextExample.NativeMethodInfoPtr_CopyAnimationCurve_Private_AnimationCurve_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewTextExample>.NativeClassPtr, 100665835);
			SkewTextExample.NativeMethodInfoPtr_WarpText_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewTextExample>.NativeClassPtr, 100665836);
			SkewTextExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewTextExample>.NativeClassPtr, 100665837);
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x00078BF0 File Offset: 0x00076DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256050, XrefRangeEnd = 256054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewTextExample.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x00078C24 File Offset: 0x00076E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256054, XrefRangeEnd = 256060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewTextExample.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x00078C58 File Offset: 0x00076E58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 256066, RefRangeEnd = 256068, XrefRangeStart = 256060, XrefRangeEnd = 256066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(curve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewTextExample.NativeMethodInfoPtr_CopyAnimationCurve_Private_AnimationCurve_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr3) : null;
			}
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x00078CA8 File Offset: 0x00076EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256068, XrefRangeEnd = 256072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WarpText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewTextExample.NativeMethodInfoPtr_WarpText_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x00078CE8 File Offset: 0x00076EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256072, XrefRangeEnd = 256085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkewTextExample()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkewTextExample>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewTextExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x000135B8 File Offset: 0x000117B8
		public SkewTextExample(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06001F09 RID: 7945 RVA: 0x00078D24 File Offset: 0x00076F24
		// (set) Token: 0x06001F0A RID: 7946 RVA: 0x000135C1 File Offset: 0x000117C1
		public unsafe TMP_Text m_TextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewTextExample.NativeFieldInfoPtr_m_TextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewTextExample.NativeFieldInfoPtr_m_TextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06001F0B RID: 7947 RVA: 0x00078D54 File Offset: 0x00076F54
		// (set) Token: 0x06001F0C RID: 7948 RVA: 0x000135E0 File Offset: 0x000117E0
		public unsafe AnimationCurve VertexCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewTextExample.NativeFieldInfoPtr_VertexCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewTextExample.NativeFieldInfoPtr_VertexCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06001F0D RID: 7949 RVA: 0x00078D84 File Offset: 0x00076F84
		// (set) Token: 0x06001F0E RID: 7950 RVA: 0x000135FF File Offset: 0x000117FF
		public unsafe float CurveScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewTextExample.NativeFieldInfoPtr_CurveScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewTextExample.NativeFieldInfoPtr_CurveScale)) = value;
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06001F0F RID: 7951 RVA: 0x00078DAC File Offset: 0x00076FAC
		// (set) Token: 0x06001F10 RID: 7952 RVA: 0x0001361A File Offset: 0x0001181A
		public unsafe float ShearAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewTextExample.NativeFieldInfoPtr_ShearAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewTextExample.NativeFieldInfoPtr_ShearAmount)) = value;
			}
		}

		// Token: 0x040014F2 RID: 5362
		private static readonly IntPtr NativeFieldInfoPtr_m_TextComponent;

		// Token: 0x040014F3 RID: 5363
		private static readonly IntPtr NativeFieldInfoPtr_VertexCurve;

		// Token: 0x040014F4 RID: 5364
		private static readonly IntPtr NativeFieldInfoPtr_CurveScale;

		// Token: 0x040014F5 RID: 5365
		private static readonly IntPtr NativeFieldInfoPtr_ShearAmount;

		// Token: 0x040014F6 RID: 5366
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040014F7 RID: 5367
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040014F8 RID: 5368
		private static readonly IntPtr NativeMethodInfoPtr_CopyAnimationCurve_Private_AnimationCurve_AnimationCurve_0;

		// Token: 0x040014F9 RID: 5369
		private static readonly IntPtr NativeMethodInfoPtr_WarpText_Private_IEnumerator_0;

		// Token: 0x040014FA RID: 5370
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000227 RID: 551
		[ObfuscatedName("TMPro.Examples.SkewTextExample+<WarpText>d__7")]
		public sealed class _WarpText_d__7 : global::Il2CppSystem.Object
		{
			// Token: 0x06002A8D RID: 10893 RVA: 0x000987A8 File Offset: 0x000969A8
			// Note: this type is marked as 'beforefieldinit'.
			static _WarpText_d__7()
			{
				Il2CppClassPointerStore<SkewTextExample._WarpText_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SkewTextExample>.NativeClassPtr, "<WarpText>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkewTextExample._WarpText_d__7>.NativeClassPtr);
				SkewTextExample._WarpText_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewTextExample._WarpText_d__7>.NativeClassPtr, "<>1__state");
				SkewTextExample._WarpText_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewTextExample._WarpText_d__7>.NativeClassPtr, "<>2__current");
				SkewTextExample._WarpText_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewTextExample._WarpText_d__7>.NativeClassPtr, "<>4__this");
				SkewTextExample._WarpText_d__7.NativeFieldInfoPtr__old_CurveScale_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewTextExample._WarpText_d__7>.NativeClassPtr, "<old_CurveScale>5__2");
				SkewTextExample._WarpText_d__7.NativeFieldInfoPtr__old_ShearValue_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewTextExample._WarpText_d__7>.NativeClassPtr, "<old_ShearValue>5__3");
				SkewTextExample._WarpText_d__7.NativeFieldInfoPtr__old_curve_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewTextExample._WarpText_d__7>.NativeClassPtr, "<old_curve>5__4");
				SkewTextExample._WarpText_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewTextExample._WarpText_d__7>.NativeClassPtr, 100666653);
				SkewTextExample._WarpText_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewTextExample._WarpText_d__7>.NativeClassPtr, 100666654);
				SkewTextExample._WarpText_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewTextExample._WarpText_d__7>.NativeClassPtr, 100666655);
				SkewTextExample._WarpText_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewTextExample._WarpText_d__7>.NativeClassPtr, 100666656);
				SkewTextExample._WarpText_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewTextExample._WarpText_d__7>.NativeClassPtr, 100666657);
				SkewTextExample._WarpText_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewTextExample._WarpText_d__7>.NativeClassPtr, 100666658);
			}

			// Token: 0x06002A8E RID: 10894 RVA: 0x000988C4 File Offset: 0x00096AC4
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WarpText_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkewTextExample._WarpText_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewTextExample._WarpText_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A8F RID: 10895 RVA: 0x0009890C File Offset: 0x00096B0C
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewTextExample._WarpText_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A90 RID: 10896 RVA: 0x00098940 File Offset: 0x00096B40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256019, XrefRangeEnd = 256045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewTextExample._WarpText_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D6A RID: 3434
			// (get) Token: 0x06002A91 RID: 10897 RVA: 0x0009897C File Offset: 0x00096B7C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewTextExample._WarpText_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A92 RID: 10898 RVA: 0x000989BC File Offset: 0x00096BBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256045, XrefRangeEnd = 256050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewTextExample._WarpText_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D6B RID: 3435
			// (get) Token: 0x06002A93 RID: 10899 RVA: 0x000989F0 File Offset: 0x00096BF0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewTextExample._WarpText_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A94 RID: 10900 RVA: 0x0001A1F6 File Offset: 0x000183F6
			public _WarpText_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D64 RID: 3428
			// (get) Token: 0x06002A95 RID: 10901 RVA: 0x00098A30 File Offset: 0x00096C30
			// (set) Token: 0x06002A96 RID: 10902 RVA: 0x0001A1FF File Offset: 0x000183FF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewTextExample._WarpText_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewTextExample._WarpText_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D65 RID: 3429
			// (get) Token: 0x06002A97 RID: 10903 RVA: 0x00098A58 File Offset: 0x00096C58
			// (set) Token: 0x06002A98 RID: 10904 RVA: 0x0001A21A File Offset: 0x0001841A
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewTextExample._WarpText_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewTextExample._WarpText_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D66 RID: 3430
			// (get) Token: 0x06002A99 RID: 10905 RVA: 0x00098A88 File Offset: 0x00096C88
			// (set) Token: 0x06002A9A RID: 10906 RVA: 0x0001A239 File Offset: 0x00018439
			public unsafe SkewTextExample __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewTextExample._WarpText_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkewTextExample>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewTextExample._WarpText_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D67 RID: 3431
			// (get) Token: 0x06002A9B RID: 10907 RVA: 0x00098AB8 File Offset: 0x00096CB8
			// (set) Token: 0x06002A9C RID: 10908 RVA: 0x0001A258 File Offset: 0x00018458
			public unsafe float _old_CurveScale_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewTextExample._WarpText_d__7.NativeFieldInfoPtr__old_CurveScale_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewTextExample._WarpText_d__7.NativeFieldInfoPtr__old_CurveScale_5__2)) = value;
				}
			}

			// Token: 0x17000D68 RID: 3432
			// (get) Token: 0x06002A9D RID: 10909 RVA: 0x00098AE0 File Offset: 0x00096CE0
			// (set) Token: 0x06002A9E RID: 10910 RVA: 0x0001A273 File Offset: 0x00018473
			public unsafe float _old_ShearValue_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewTextExample._WarpText_d__7.NativeFieldInfoPtr__old_ShearValue_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewTextExample._WarpText_d__7.NativeFieldInfoPtr__old_ShearValue_5__3)) = value;
				}
			}

			// Token: 0x17000D69 RID: 3433
			// (get) Token: 0x06002A9F RID: 10911 RVA: 0x00098B08 File Offset: 0x00096D08
			// (set) Token: 0x06002AA0 RID: 10912 RVA: 0x0001A28E File Offset: 0x0001848E
			public unsafe AnimationCurve _old_curve_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewTextExample._WarpText_d__7.NativeFieldInfoPtr__old_curve_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewTextExample._WarpText_d__7.NativeFieldInfoPtr__old_curve_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D1A RID: 7450
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D1B RID: 7451
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D1C RID: 7452
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001D1D RID: 7453
			private static readonly IntPtr NativeFieldInfoPtr__old_CurveScale_5__2;

			// Token: 0x04001D1E RID: 7454
			private static readonly IntPtr NativeFieldInfoPtr__old_ShearValue_5__3;

			// Token: 0x04001D1F RID: 7455
			private static readonly IntPtr NativeFieldInfoPtr__old_curve_5__4;

			// Token: 0x04001D20 RID: 7456
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001D21 RID: 7457
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D22 RID: 7458
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001D23 RID: 7459
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001D24 RID: 7460
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D25 RID: 7461
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
