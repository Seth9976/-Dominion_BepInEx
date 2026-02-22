using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000118 RID: 280
	public class WarpTextExample : MonoBehaviour
	{
		// Token: 0x06002058 RID: 8280 RVA: 0x0007C5F8 File Offset: 0x0007A7F8
		// Note: this type is marked as 'beforefieldinit'.
		static WarpTextExample()
		{
			Il2CppClassPointerStore<WarpTextExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "WarpTextExample");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarpTextExample>.NativeClassPtr);
			WarpTextExample.NativeFieldInfoPtr_m_TextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarpTextExample>.NativeClassPtr, "m_TextComponent");
			WarpTextExample.NativeFieldInfoPtr_VertexCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarpTextExample>.NativeClassPtr, "VertexCurve");
			WarpTextExample.NativeFieldInfoPtr_AngleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarpTextExample>.NativeClassPtr, "AngleMultiplier");
			WarpTextExample.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarpTextExample>.NativeClassPtr, "SpeedMultiplier");
			WarpTextExample.NativeFieldInfoPtr_CurveScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarpTextExample>.NativeClassPtr, "CurveScale");
			WarpTextExample.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarpTextExample>.NativeClassPtr, 100665929);
			WarpTextExample.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarpTextExample>.NativeClassPtr, 100665930);
			WarpTextExample.NativeMethodInfoPtr_CopyAnimationCurve_Private_AnimationCurve_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarpTextExample>.NativeClassPtr, 100665931);
			WarpTextExample.NativeMethodInfoPtr_WarpText_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarpTextExample>.NativeClassPtr, 100665932);
			WarpTextExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarpTextExample>.NativeClassPtr, 100665933);
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x0007C6F0 File Offset: 0x0007A8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257423, XrefRangeEnd = 257427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarpTextExample.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x0007C724 File Offset: 0x0007A924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257427, XrefRangeEnd = 257433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarpTextExample.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x0007C758 File Offset: 0x0007A958
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 257439, RefRangeEnd = 257441, XrefRangeStart = 257433, XrefRangeEnd = 257439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(curve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarpTextExample.NativeMethodInfoPtr_CopyAnimationCurve_Private_AnimationCurve_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr3) : null;
			}
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x0007C7A8 File Offset: 0x0007A9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257441, XrefRangeEnd = 257445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WarpText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarpTextExample.NativeMethodInfoPtr_WarpText_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x0007C7E8 File Offset: 0x0007A9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257445, XrefRangeEnd = 257458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WarpTextExample()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarpTextExample>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarpTextExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x000141EB File Offset: 0x000123EB
		public WarpTextExample(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x0600205F RID: 8287 RVA: 0x0007C824 File Offset: 0x0007AA24
		// (set) Token: 0x06002060 RID: 8288 RVA: 0x000141F4 File Offset: 0x000123F4
		public unsafe TMP_Text m_TextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpTextExample.NativeFieldInfoPtr_m_TextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpTextExample.NativeFieldInfoPtr_m_TextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06002061 RID: 8289 RVA: 0x0007C854 File Offset: 0x0007AA54
		// (set) Token: 0x06002062 RID: 8290 RVA: 0x00014213 File Offset: 0x00012413
		public unsafe AnimationCurve VertexCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpTextExample.NativeFieldInfoPtr_VertexCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpTextExample.NativeFieldInfoPtr_VertexCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06002063 RID: 8291 RVA: 0x0007C884 File Offset: 0x0007AA84
		// (set) Token: 0x06002064 RID: 8292 RVA: 0x00014232 File Offset: 0x00012432
		public unsafe float AngleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpTextExample.NativeFieldInfoPtr_AngleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpTextExample.NativeFieldInfoPtr_AngleMultiplier)) = value;
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06002065 RID: 8293 RVA: 0x0007C8AC File Offset: 0x0007AAAC
		// (set) Token: 0x06002066 RID: 8294 RVA: 0x0001424D File Offset: 0x0001244D
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpTextExample.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpTextExample.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06002067 RID: 8295 RVA: 0x0007C8D4 File Offset: 0x0007AAD4
		// (set) Token: 0x06002068 RID: 8296 RVA: 0x00014268 File Offset: 0x00012468
		public unsafe float CurveScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpTextExample.NativeFieldInfoPtr_CurveScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpTextExample.NativeFieldInfoPtr_CurveScale)) = value;
			}
		}

		// Token: 0x040015BB RID: 5563
		private static readonly IntPtr NativeFieldInfoPtr_m_TextComponent;

		// Token: 0x040015BC RID: 5564
		private static readonly IntPtr NativeFieldInfoPtr_VertexCurve;

		// Token: 0x040015BD RID: 5565
		private static readonly IntPtr NativeFieldInfoPtr_AngleMultiplier;

		// Token: 0x040015BE RID: 5566
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x040015BF RID: 5567
		private static readonly IntPtr NativeFieldInfoPtr_CurveScale;

		// Token: 0x040015C0 RID: 5568
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040015C1 RID: 5569
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040015C2 RID: 5570
		private static readonly IntPtr NativeMethodInfoPtr_CopyAnimationCurve_Private_AnimationCurve_AnimationCurve_0;

		// Token: 0x040015C3 RID: 5571
		private static readonly IntPtr NativeMethodInfoPtr_WarpText_Private_IEnumerator_0;

		// Token: 0x040015C4 RID: 5572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000238 RID: 568
		[ObfuscatedName("TMPro.Examples.WarpTextExample+<WarpText>d__8")]
		public sealed class _WarpText_d__8 : global::Il2CppSystem.Object
		{
			// Token: 0x06002B83 RID: 11139 RVA: 0x0009B2B0 File Offset: 0x000994B0
			// Note: this type is marked as 'beforefieldinit'.
			static _WarpText_d__8()
			{
				Il2CppClassPointerStore<WarpTextExample._WarpText_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarpTextExample>.NativeClassPtr, "<WarpText>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarpTextExample._WarpText_d__8>.NativeClassPtr);
				WarpTextExample._WarpText_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarpTextExample._WarpText_d__8>.NativeClassPtr, "<>1__state");
				WarpTextExample._WarpText_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarpTextExample._WarpText_d__8>.NativeClassPtr, "<>2__current");
				WarpTextExample._WarpText_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarpTextExample._WarpText_d__8>.NativeClassPtr, "<>4__this");
				WarpTextExample._WarpText_d__8.NativeFieldInfoPtr__old_CurveScale_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarpTextExample._WarpText_d__8>.NativeClassPtr, "<old_CurveScale>5__2");
				WarpTextExample._WarpText_d__8.NativeFieldInfoPtr__old_curve_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarpTextExample._WarpText_d__8>.NativeClassPtr, "<old_curve>5__3");
				WarpTextExample._WarpText_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarpTextExample._WarpText_d__8>.NativeClassPtr, 100666721);
				WarpTextExample._WarpText_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarpTextExample._WarpText_d__8>.NativeClassPtr, 100666722);
				WarpTextExample._WarpText_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarpTextExample._WarpText_d__8>.NativeClassPtr, 100666723);
				WarpTextExample._WarpText_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarpTextExample._WarpText_d__8>.NativeClassPtr, 100666724);
				WarpTextExample._WarpText_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarpTextExample._WarpText_d__8>.NativeClassPtr, 100666725);
				WarpTextExample._WarpText_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarpTextExample._WarpText_d__8>.NativeClassPtr, 100666726);
			}

			// Token: 0x06002B84 RID: 11140 RVA: 0x0009B3B8 File Offset: 0x000995B8
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WarpText_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarpTextExample._WarpText_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarpTextExample._WarpText_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B85 RID: 11141 RVA: 0x0009B400 File Offset: 0x00099600
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarpTextExample._WarpText_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B86 RID: 11142 RVA: 0x0009B434 File Offset: 0x00099634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257388, XrefRangeEnd = 257418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarpTextExample._WarpText_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000DCB RID: 3531
			// (get) Token: 0x06002B87 RID: 11143 RVA: 0x0009B470 File Offset: 0x00099670
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarpTextExample._WarpText_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B88 RID: 11144 RVA: 0x0009B4B0 File Offset: 0x000996B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257418, XrefRangeEnd = 257423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarpTextExample._WarpText_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DCC RID: 3532
			// (get) Token: 0x06002B89 RID: 11145 RVA: 0x0009B4E4 File Offset: 0x000996E4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarpTextExample._WarpText_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B8A RID: 11146 RVA: 0x0001AB14 File Offset: 0x00018D14
			public _WarpText_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DC6 RID: 3526
			// (get) Token: 0x06002B8B RID: 11147 RVA: 0x0009B524 File Offset: 0x00099724
			// (set) Token: 0x06002B8C RID: 11148 RVA: 0x0001AB1D File Offset: 0x00018D1D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpTextExample._WarpText_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpTextExample._WarpText_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000DC7 RID: 3527
			// (get) Token: 0x06002B8D RID: 11149 RVA: 0x0009B54C File Offset: 0x0009974C
			// (set) Token: 0x06002B8E RID: 11150 RVA: 0x0001AB38 File Offset: 0x00018D38
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpTextExample._WarpText_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpTextExample._WarpText_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DC8 RID: 3528
			// (get) Token: 0x06002B8F RID: 11151 RVA: 0x0009B57C File Offset: 0x0009977C
			// (set) Token: 0x06002B90 RID: 11152 RVA: 0x0001AB57 File Offset: 0x00018D57
			public unsafe WarpTextExample __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpTextExample._WarpText_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WarpTextExample>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpTextExample._WarpText_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DC9 RID: 3529
			// (get) Token: 0x06002B91 RID: 11153 RVA: 0x0009B5AC File Offset: 0x000997AC
			// (set) Token: 0x06002B92 RID: 11154 RVA: 0x0001AB76 File Offset: 0x00018D76
			public unsafe float _old_CurveScale_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpTextExample._WarpText_d__8.NativeFieldInfoPtr__old_CurveScale_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpTextExample._WarpText_d__8.NativeFieldInfoPtr__old_CurveScale_5__2)) = value;
				}
			}

			// Token: 0x17000DCA RID: 3530
			// (get) Token: 0x06002B93 RID: 11155 RVA: 0x0009B5D4 File Offset: 0x000997D4
			// (set) Token: 0x06002B94 RID: 11156 RVA: 0x0001AB91 File Offset: 0x00018D91
			public unsafe AnimationCurve _old_curve_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpTextExample._WarpText_d__8.NativeFieldInfoPtr__old_curve_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpTextExample._WarpText_d__8.NativeFieldInfoPtr__old_curve_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001DC2 RID: 7618
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001DC3 RID: 7619
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001DC4 RID: 7620
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001DC5 RID: 7621
			private static readonly IntPtr NativeFieldInfoPtr__old_CurveScale_5__2;

			// Token: 0x04001DC6 RID: 7622
			private static readonly IntPtr NativeFieldInfoPtr__old_curve_5__3;

			// Token: 0x04001DC7 RID: 7623
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001DC8 RID: 7624
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DC9 RID: 7625
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001DCA RID: 7626
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001DCB RID: 7627
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DCC RID: 7628
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
