using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000115 RID: 277
	public class VertexShakeA : MonoBehaviour
	{
		// Token: 0x0600201D RID: 8221 RVA: 0x0007BB3C File Offset: 0x00079D3C
		// Note: this type is marked as 'beforefieldinit'.
		static VertexShakeA()
		{
			Il2CppClassPointerStore<VertexShakeA>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "VertexShakeA");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VertexShakeA>.NativeClassPtr);
			VertexShakeA.NativeFieldInfoPtr_AngleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexShakeA>.NativeClassPtr, "AngleMultiplier");
			VertexShakeA.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexShakeA>.NativeClassPtr, "SpeedMultiplier");
			VertexShakeA.NativeFieldInfoPtr_ScaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexShakeA>.NativeClassPtr, "ScaleMultiplier");
			VertexShakeA.NativeFieldInfoPtr_RotationMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexShakeA>.NativeClassPtr, "RotationMultiplier");
			VertexShakeA.NativeFieldInfoPtr_m_TextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexShakeA>.NativeClassPtr, "m_TextComponent");
			VertexShakeA.NativeFieldInfoPtr_hasTextChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexShakeA>.NativeClassPtr, "hasTextChanged");
			VertexShakeA.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeA>.NativeClassPtr, 100665908);
			VertexShakeA.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeA>.NativeClassPtr, 100665909);
			VertexShakeA.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeA>.NativeClassPtr, 100665910);
			VertexShakeA.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeA>.NativeClassPtr, 100665911);
			VertexShakeA.NativeMethodInfoPtr_ON_TEXT_CHANGED_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeA>.NativeClassPtr, 100665912);
			VertexShakeA.NativeMethodInfoPtr_AnimateVertexColors_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeA>.NativeClassPtr, 100665913);
			VertexShakeA.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeA>.NativeClassPtr, 100665914);
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x0007BC70 File Offset: 0x00079E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257128, XrefRangeEnd = 257131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeA.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x0007BCA4 File Offset: 0x00079EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257131, XrefRangeEnd = 257147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeA.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x0007BCD8 File Offset: 0x00079ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257147, XrefRangeEnd = 257163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeA.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x0007BD0C File Offset: 0x00079F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257163, XrefRangeEnd = 257169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeA.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x0007BD40 File Offset: 0x00079F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257169, XrefRangeEnd = 257173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ON_TEXT_CHANGED(global::UnityEngine.Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeA.NativeMethodInfoPtr_ON_TEXT_CHANGED_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x0007BD84 File Offset: 0x00079F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257173, XrefRangeEnd = 257177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator AnimateVertexColors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeA.NativeMethodInfoPtr_AnimateVertexColors_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x0007BDC4 File Offset: 0x00079FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257177, XrefRangeEnd = 257178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VertexShakeA()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VertexShakeA>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeA.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x00014014 File Offset: 0x00012214
		public VertexShakeA(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06002026 RID: 8230 RVA: 0x0007BE00 File Offset: 0x0007A000
		// (set) Token: 0x06002027 RID: 8231 RVA: 0x0001401D File Offset: 0x0001221D
		public unsafe float AngleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeA.NativeFieldInfoPtr_AngleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeA.NativeFieldInfoPtr_AngleMultiplier)) = value;
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06002028 RID: 8232 RVA: 0x0007BE28 File Offset: 0x0007A028
		// (set) Token: 0x06002029 RID: 8233 RVA: 0x00014038 File Offset: 0x00012238
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeA.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeA.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x0600202A RID: 8234 RVA: 0x0007BE50 File Offset: 0x0007A050
		// (set) Token: 0x0600202B RID: 8235 RVA: 0x00014053 File Offset: 0x00012253
		public unsafe float ScaleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeA.NativeFieldInfoPtr_ScaleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeA.NativeFieldInfoPtr_ScaleMultiplier)) = value;
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x0600202C RID: 8236 RVA: 0x0007BE78 File Offset: 0x0007A078
		// (set) Token: 0x0600202D RID: 8237 RVA: 0x0001406E File Offset: 0x0001226E
		public unsafe float RotationMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeA.NativeFieldInfoPtr_RotationMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeA.NativeFieldInfoPtr_RotationMultiplier)) = value;
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x0600202E RID: 8238 RVA: 0x0007BEA0 File Offset: 0x0007A0A0
		// (set) Token: 0x0600202F RID: 8239 RVA: 0x00014089 File Offset: 0x00012289
		public unsafe TMP_Text m_TextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeA.NativeFieldInfoPtr_m_TextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeA.NativeFieldInfoPtr_m_TextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06002030 RID: 8240 RVA: 0x0007BED0 File Offset: 0x0007A0D0
		// (set) Token: 0x06002031 RID: 8241 RVA: 0x000140A8 File Offset: 0x000122A8
		public unsafe bool hasTextChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeA.NativeFieldInfoPtr_hasTextChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeA.NativeFieldInfoPtr_hasTextChanged)) = value;
			}
		}

		// Token: 0x04001596 RID: 5526
		private static readonly IntPtr NativeFieldInfoPtr_AngleMultiplier;

		// Token: 0x04001597 RID: 5527
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x04001598 RID: 5528
		private static readonly IntPtr NativeFieldInfoPtr_ScaleMultiplier;

		// Token: 0x04001599 RID: 5529
		private static readonly IntPtr NativeFieldInfoPtr_RotationMultiplier;

		// Token: 0x0400159A RID: 5530
		private static readonly IntPtr NativeFieldInfoPtr_m_TextComponent;

		// Token: 0x0400159B RID: 5531
		private static readonly IntPtr NativeFieldInfoPtr_hasTextChanged;

		// Token: 0x0400159C RID: 5532
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400159D RID: 5533
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400159E RID: 5534
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400159F RID: 5535
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040015A0 RID: 5536
		private static readonly IntPtr NativeMethodInfoPtr_ON_TEXT_CHANGED_Private_Void_Object_0;

		// Token: 0x040015A1 RID: 5537
		private static readonly IntPtr NativeMethodInfoPtr_AnimateVertexColors_Private_IEnumerator_0;

		// Token: 0x040015A2 RID: 5538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000234 RID: 564
		[ObfuscatedName("TMPro.Examples.VertexShakeA+<AnimateVertexColors>d__11")]
		public sealed class _AnimateVertexColors_d__11 : global::Il2CppSystem.Object
		{
			// Token: 0x06002B41 RID: 11073 RVA: 0x0009A6A4 File Offset: 0x000988A4
			// Note: this type is marked as 'beforefieldinit'.
			static _AnimateVertexColors_d__11()
			{
				Il2CppClassPointerStore<VertexShakeA._AnimateVertexColors_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VertexShakeA>.NativeClassPtr, "<AnimateVertexColors>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VertexShakeA._AnimateVertexColors_d__11>.NativeClassPtr);
				VertexShakeA._AnimateVertexColors_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexShakeA._AnimateVertexColors_d__11>.NativeClassPtr, "<>1__state");
				VertexShakeA._AnimateVertexColors_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexShakeA._AnimateVertexColors_d__11>.NativeClassPtr, "<>2__current");
				VertexShakeA._AnimateVertexColors_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexShakeA._AnimateVertexColors_d__11>.NativeClassPtr, "<>4__this");
				VertexShakeA._AnimateVertexColors_d__11.NativeFieldInfoPtr__textInfo_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexShakeA._AnimateVertexColors_d__11>.NativeClassPtr, "<textInfo>5__2");
				VertexShakeA._AnimateVertexColors_d__11.NativeFieldInfoPtr__copyOfVertices_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexShakeA._AnimateVertexColors_d__11>.NativeClassPtr, "<copyOfVertices>5__3");
				VertexShakeA._AnimateVertexColors_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeA._AnimateVertexColors_d__11>.NativeClassPtr, 100666701);
				VertexShakeA._AnimateVertexColors_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeA._AnimateVertexColors_d__11>.NativeClassPtr, 100666702);
				VertexShakeA._AnimateVertexColors_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeA._AnimateVertexColors_d__11>.NativeClassPtr, 100666703);
				VertexShakeA._AnimateVertexColors_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeA._AnimateVertexColors_d__11>.NativeClassPtr, 100666704);
				VertexShakeA._AnimateVertexColors_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeA._AnimateVertexColors_d__11>.NativeClassPtr, 100666705);
				VertexShakeA._AnimateVertexColors_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeA._AnimateVertexColors_d__11>.NativeClassPtr, 100666706);
			}

			// Token: 0x06002B42 RID: 11074 RVA: 0x0009A7AC File Offset: 0x000989AC
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AnimateVertexColors_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VertexShakeA._AnimateVertexColors_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeA._AnimateVertexColors_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B43 RID: 11075 RVA: 0x0009A7F4 File Offset: 0x000989F4
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeA._AnimateVertexColors_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B44 RID: 11076 RVA: 0x0009A828 File Offset: 0x00098A28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257095, XrefRangeEnd = 257123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeA._AnimateVertexColors_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000DB2 RID: 3506
			// (get) Token: 0x06002B45 RID: 11077 RVA: 0x0009A864 File Offset: 0x00098A64
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeA._AnimateVertexColors_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B46 RID: 11078 RVA: 0x0009A8A4 File Offset: 0x00098AA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257123, XrefRangeEnd = 257128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeA._AnimateVertexColors_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DB3 RID: 3507
			// (get) Token: 0x06002B47 RID: 11079 RVA: 0x0009A8D8 File Offset: 0x00098AD8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeA._AnimateVertexColors_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B48 RID: 11080 RVA: 0x0001A8AF File Offset: 0x00018AAF
			public _AnimateVertexColors_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DAD RID: 3501
			// (get) Token: 0x06002B49 RID: 11081 RVA: 0x0009A918 File Offset: 0x00098B18
			// (set) Token: 0x06002B4A RID: 11082 RVA: 0x0001A8B8 File Offset: 0x00018AB8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeA._AnimateVertexColors_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeA._AnimateVertexColors_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000DAE RID: 3502
			// (get) Token: 0x06002B4B RID: 11083 RVA: 0x0009A940 File Offset: 0x00098B40
			// (set) Token: 0x06002B4C RID: 11084 RVA: 0x0001A8D3 File Offset: 0x00018AD3
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeA._AnimateVertexColors_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeA._AnimateVertexColors_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DAF RID: 3503
			// (get) Token: 0x06002B4D RID: 11085 RVA: 0x0009A970 File Offset: 0x00098B70
			// (set) Token: 0x06002B4E RID: 11086 RVA: 0x0001A8F2 File Offset: 0x00018AF2
			public unsafe VertexShakeA __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeA._AnimateVertexColors_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VertexShakeA>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeA._AnimateVertexColors_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DB0 RID: 3504
			// (get) Token: 0x06002B4F RID: 11087 RVA: 0x0009A9A0 File Offset: 0x00098BA0
			// (set) Token: 0x06002B50 RID: 11088 RVA: 0x0001A911 File Offset: 0x00018B11
			public unsafe TMP_TextInfo _textInfo_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeA._AnimateVertexColors_d__11.NativeFieldInfoPtr__textInfo_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_TextInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeA._AnimateVertexColors_d__11.NativeFieldInfoPtr__textInfo_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DB1 RID: 3505
			// (get) Token: 0x06002B51 RID: 11089 RVA: 0x0009A9D0 File Offset: 0x00098BD0
			// (set) Token: 0x06002B52 RID: 11090 RVA: 0x0001A930 File Offset: 0x00018B30
			public unsafe Il2CppReferenceArray<Il2CppStructArray<Vector3>> _copyOfVertices_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeA._AnimateVertexColors_d__11.NativeFieldInfoPtr__copyOfVertices_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<Vector3>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeA._AnimateVertexColors_d__11.NativeFieldInfoPtr__copyOfVertices_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D9B RID: 7579
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D9C RID: 7580
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D9D RID: 7581
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001D9E RID: 7582
			private static readonly IntPtr NativeFieldInfoPtr__textInfo_5__2;

			// Token: 0x04001D9F RID: 7583
			private static readonly IntPtr NativeFieldInfoPtr__copyOfVertices_5__3;

			// Token: 0x04001DA0 RID: 7584
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001DA1 RID: 7585
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DA2 RID: 7586
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001DA3 RID: 7587
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001DA4 RID: 7588
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DA5 RID: 7589
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
