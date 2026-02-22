using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000114 RID: 276
	public class VertexJitter : MonoBehaviour
	{
		// Token: 0x0600200A RID: 8202 RVA: 0x0007B7BC File Offset: 0x000799BC
		// Note: this type is marked as 'beforefieldinit'.
		static VertexJitter()
		{
			Il2CppClassPointerStore<VertexJitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "VertexJitter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VertexJitter>.NativeClassPtr);
			VertexJitter.NativeFieldInfoPtr_AngleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexJitter>.NativeClassPtr, "AngleMultiplier");
			VertexJitter.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexJitter>.NativeClassPtr, "SpeedMultiplier");
			VertexJitter.NativeFieldInfoPtr_CurveScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexJitter>.NativeClassPtr, "CurveScale");
			VertexJitter.NativeFieldInfoPtr_m_TextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexJitter>.NativeClassPtr, "m_TextComponent");
			VertexJitter.NativeFieldInfoPtr_hasTextChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexJitter>.NativeClassPtr, "hasTextChanged");
			VertexJitter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexJitter>.NativeClassPtr, 100665901);
			VertexJitter.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexJitter>.NativeClassPtr, 100665902);
			VertexJitter.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexJitter>.NativeClassPtr, 100665903);
			VertexJitter.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexJitter>.NativeClassPtr, 100665904);
			VertexJitter.NativeMethodInfoPtr_ON_TEXT_CHANGED_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexJitter>.NativeClassPtr, 100665905);
			VertexJitter.NativeMethodInfoPtr_AnimateVertexColors_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexJitter>.NativeClassPtr, 100665906);
			VertexJitter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexJitter>.NativeClassPtr, 100665907);
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x0007B8DC File Offset: 0x00079ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257045, XrefRangeEnd = 257048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexJitter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x0007B910 File Offset: 0x00079B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257048, XrefRangeEnd = 257064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexJitter.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x0007B944 File Offset: 0x00079B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257064, XrefRangeEnd = 257080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexJitter.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x0007B978 File Offset: 0x00079B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257080, XrefRangeEnd = 257086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexJitter.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x0007B9AC File Offset: 0x00079BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257086, XrefRangeEnd = 257090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ON_TEXT_CHANGED(global::UnityEngine.Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexJitter.NativeMethodInfoPtr_ON_TEXT_CHANGED_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x0007B9F0 File Offset: 0x00079BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257090, XrefRangeEnd = 257094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator AnimateVertexColors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexJitter.NativeMethodInfoPtr_AnimateVertexColors_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x0007BA30 File Offset: 0x00079C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257094, XrefRangeEnd = 257095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VertexJitter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VertexJitter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexJitter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x00013F80 File Offset: 0x00012180
		public VertexJitter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06002013 RID: 8211 RVA: 0x0007BA6C File Offset: 0x00079C6C
		// (set) Token: 0x06002014 RID: 8212 RVA: 0x00013F89 File Offset: 0x00012189
		public unsafe float AngleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexJitter.NativeFieldInfoPtr_AngleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexJitter.NativeFieldInfoPtr_AngleMultiplier)) = value;
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06002015 RID: 8213 RVA: 0x0007BA94 File Offset: 0x00079C94
		// (set) Token: 0x06002016 RID: 8214 RVA: 0x00013FA4 File Offset: 0x000121A4
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexJitter.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexJitter.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06002017 RID: 8215 RVA: 0x0007BABC File Offset: 0x00079CBC
		// (set) Token: 0x06002018 RID: 8216 RVA: 0x00013FBF File Offset: 0x000121BF
		public unsafe float CurveScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexJitter.NativeFieldInfoPtr_CurveScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexJitter.NativeFieldInfoPtr_CurveScale)) = value;
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06002019 RID: 8217 RVA: 0x0007BAE4 File Offset: 0x00079CE4
		// (set) Token: 0x0600201A RID: 8218 RVA: 0x00013FDA File Offset: 0x000121DA
		public unsafe TMP_Text m_TextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexJitter.NativeFieldInfoPtr_m_TextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexJitter.NativeFieldInfoPtr_m_TextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x0600201B RID: 8219 RVA: 0x0007BB14 File Offset: 0x00079D14
		// (set) Token: 0x0600201C RID: 8220 RVA: 0x00013FF9 File Offset: 0x000121F9
		public unsafe bool hasTextChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexJitter.NativeFieldInfoPtr_hasTextChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexJitter.NativeFieldInfoPtr_hasTextChanged)) = value;
			}
		}

		// Token: 0x0400158A RID: 5514
		private static readonly IntPtr NativeFieldInfoPtr_AngleMultiplier;

		// Token: 0x0400158B RID: 5515
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x0400158C RID: 5516
		private static readonly IntPtr NativeFieldInfoPtr_CurveScale;

		// Token: 0x0400158D RID: 5517
		private static readonly IntPtr NativeFieldInfoPtr_m_TextComponent;

		// Token: 0x0400158E RID: 5518
		private static readonly IntPtr NativeFieldInfoPtr_hasTextChanged;

		// Token: 0x0400158F RID: 5519
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001590 RID: 5520
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001591 RID: 5521
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04001592 RID: 5522
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001593 RID: 5523
		private static readonly IntPtr NativeMethodInfoPtr_ON_TEXT_CHANGED_Private_Void_Object_0;

		// Token: 0x04001594 RID: 5524
		private static readonly IntPtr NativeMethodInfoPtr_AnimateVertexColors_Private_IEnumerator_0;

		// Token: 0x04001595 RID: 5525
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000232 RID: 562
		[StructLayout(2)]
		public struct VertexAnim
		{
			// Token: 0x06002B29 RID: 11049 RVA: 0x0009A260 File Offset: 0x00098460
			// Note: this type is marked as 'beforefieldinit'.
			static VertexAnim()
			{
				Il2CppClassPointerStore<VertexJitter.VertexAnim>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VertexJitter>.NativeClassPtr, "VertexAnim");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VertexJitter.VertexAnim>.NativeClassPtr);
				VertexJitter.VertexAnim.NativeFieldInfoPtr_angleRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexJitter.VertexAnim>.NativeClassPtr, "angleRange");
				VertexJitter.VertexAnim.NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexJitter.VertexAnim>.NativeClassPtr, "angle");
				VertexJitter.VertexAnim.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexJitter.VertexAnim>.NativeClassPtr, "speed");
			}

			// Token: 0x06002B2A RID: 11050 RVA: 0x0001A7C3 File Offset: 0x000189C3
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VertexJitter.VertexAnim>.NativeClassPtr, ref this));
			}

			// Token: 0x04001D88 RID: 7560
			private static readonly IntPtr NativeFieldInfoPtr_angleRange;

			// Token: 0x04001D89 RID: 7561
			private static readonly IntPtr NativeFieldInfoPtr_angle;

			// Token: 0x04001D8A RID: 7562
			private static readonly IntPtr NativeFieldInfoPtr_speed;

			// Token: 0x04001D8B RID: 7563
			[FieldOffset(0)]
			public float angleRange;

			// Token: 0x04001D8C RID: 7564
			[FieldOffset(4)]
			public float angle;

			// Token: 0x04001D8D RID: 7565
			[FieldOffset(8)]
			public float speed;
		}

		// Token: 0x02000233 RID: 563
		[ObfuscatedName("TMPro.Examples.VertexJitter+<AnimateVertexColors>d__11")]
		public sealed class _AnimateVertexColors_d__11 : global::Il2CppSystem.Object
		{
			// Token: 0x06002B2B RID: 11051 RVA: 0x0009A2C8 File Offset: 0x000984C8
			// Note: this type is marked as 'beforefieldinit'.
			static _AnimateVertexColors_d__11()
			{
				Il2CppClassPointerStore<VertexJitter._AnimateVertexColors_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VertexJitter>.NativeClassPtr, "<AnimateVertexColors>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VertexJitter._AnimateVertexColors_d__11>.NativeClassPtr);
				VertexJitter._AnimateVertexColors_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexJitter._AnimateVertexColors_d__11>.NativeClassPtr, "<>1__state");
				VertexJitter._AnimateVertexColors_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexJitter._AnimateVertexColors_d__11>.NativeClassPtr, "<>2__current");
				VertexJitter._AnimateVertexColors_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexJitter._AnimateVertexColors_d__11>.NativeClassPtr, "<>4__this");
				VertexJitter._AnimateVertexColors_d__11.NativeFieldInfoPtr__textInfo_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexJitter._AnimateVertexColors_d__11>.NativeClassPtr, "<textInfo>5__2");
				VertexJitter._AnimateVertexColors_d__11.NativeFieldInfoPtr__loopCount_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexJitter._AnimateVertexColors_d__11>.NativeClassPtr, "<loopCount>5__3");
				VertexJitter._AnimateVertexColors_d__11.NativeFieldInfoPtr__vertexAnim_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexJitter._AnimateVertexColors_d__11>.NativeClassPtr, "<vertexAnim>5__4");
				VertexJitter._AnimateVertexColors_d__11.NativeFieldInfoPtr__cachedMeshInfo_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexJitter._AnimateVertexColors_d__11>.NativeClassPtr, "<cachedMeshInfo>5__5");
				VertexJitter._AnimateVertexColors_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexJitter._AnimateVertexColors_d__11>.NativeClassPtr, 100666695);
				VertexJitter._AnimateVertexColors_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexJitter._AnimateVertexColors_d__11>.NativeClassPtr, 100666696);
				VertexJitter._AnimateVertexColors_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexJitter._AnimateVertexColors_d__11>.NativeClassPtr, 100666697);
				VertexJitter._AnimateVertexColors_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexJitter._AnimateVertexColors_d__11>.NativeClassPtr, 100666698);
				VertexJitter._AnimateVertexColors_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexJitter._AnimateVertexColors_d__11>.NativeClassPtr, 100666699);
				VertexJitter._AnimateVertexColors_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexJitter._AnimateVertexColors_d__11>.NativeClassPtr, 100666700);
			}

			// Token: 0x06002B2C RID: 11052 RVA: 0x0009A3F8 File Offset: 0x000985F8
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AnimateVertexColors_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VertexJitter._AnimateVertexColors_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexJitter._AnimateVertexColors_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B2D RID: 11053 RVA: 0x0009A440 File Offset: 0x00098640
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexJitter._AnimateVertexColors_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B2E RID: 11054 RVA: 0x0009A474 File Offset: 0x00098674
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257012, XrefRangeEnd = 257040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexJitter._AnimateVertexColors_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000DAB RID: 3499
			// (get) Token: 0x06002B2F RID: 11055 RVA: 0x0009A4B0 File Offset: 0x000986B0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexJitter._AnimateVertexColors_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B30 RID: 11056 RVA: 0x0009A4F0 File Offset: 0x000986F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257040, XrefRangeEnd = 257045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexJitter._AnimateVertexColors_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DAC RID: 3500
			// (get) Token: 0x06002B31 RID: 11057 RVA: 0x0009A524 File Offset: 0x00098724
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexJitter._AnimateVertexColors_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B32 RID: 11058 RVA: 0x0001A7D5 File Offset: 0x000189D5
			public _AnimateVertexColors_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DA4 RID: 3492
			// (get) Token: 0x06002B33 RID: 11059 RVA: 0x0009A564 File Offset: 0x00098764
			// (set) Token: 0x06002B34 RID: 11060 RVA: 0x0001A7DE File Offset: 0x000189DE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexJitter._AnimateVertexColors_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexJitter._AnimateVertexColors_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000DA5 RID: 3493
			// (get) Token: 0x06002B35 RID: 11061 RVA: 0x0009A58C File Offset: 0x0009878C
			// (set) Token: 0x06002B36 RID: 11062 RVA: 0x0001A7F9 File Offset: 0x000189F9
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexJitter._AnimateVertexColors_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexJitter._AnimateVertexColors_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DA6 RID: 3494
			// (get) Token: 0x06002B37 RID: 11063 RVA: 0x0009A5BC File Offset: 0x000987BC
			// (set) Token: 0x06002B38 RID: 11064 RVA: 0x0001A818 File Offset: 0x00018A18
			public unsafe VertexJitter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexJitter._AnimateVertexColors_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VertexJitter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexJitter._AnimateVertexColors_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DA7 RID: 3495
			// (get) Token: 0x06002B39 RID: 11065 RVA: 0x0009A5EC File Offset: 0x000987EC
			// (set) Token: 0x06002B3A RID: 11066 RVA: 0x0001A837 File Offset: 0x00018A37
			public unsafe TMP_TextInfo _textInfo_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexJitter._AnimateVertexColors_d__11.NativeFieldInfoPtr__textInfo_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_TextInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexJitter._AnimateVertexColors_d__11.NativeFieldInfoPtr__textInfo_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DA8 RID: 3496
			// (get) Token: 0x06002B3B RID: 11067 RVA: 0x0009A61C File Offset: 0x0009881C
			// (set) Token: 0x06002B3C RID: 11068 RVA: 0x0001A856 File Offset: 0x00018A56
			public unsafe int _loopCount_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexJitter._AnimateVertexColors_d__11.NativeFieldInfoPtr__loopCount_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexJitter._AnimateVertexColors_d__11.NativeFieldInfoPtr__loopCount_5__3)) = value;
				}
			}

			// Token: 0x17000DA9 RID: 3497
			// (get) Token: 0x06002B3D RID: 11069 RVA: 0x0009A644 File Offset: 0x00098844
			// (set) Token: 0x06002B3E RID: 11070 RVA: 0x0001A871 File Offset: 0x00018A71
			public unsafe Il2CppStructArray<VertexJitter.VertexAnim> _vertexAnim_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexJitter._AnimateVertexColors_d__11.NativeFieldInfoPtr__vertexAnim_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<VertexJitter.VertexAnim>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexJitter._AnimateVertexColors_d__11.NativeFieldInfoPtr__vertexAnim_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DAA RID: 3498
			// (get) Token: 0x06002B3F RID: 11071 RVA: 0x0009A674 File Offset: 0x00098874
			// (set) Token: 0x06002B40 RID: 11072 RVA: 0x0001A890 File Offset: 0x00018A90
			public unsafe Il2CppReferenceArray<TMP_MeshInfo> _cachedMeshInfo_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexJitter._AnimateVertexColors_d__11.NativeFieldInfoPtr__cachedMeshInfo_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_MeshInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexJitter._AnimateVertexColors_d__11.NativeFieldInfoPtr__cachedMeshInfo_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D8E RID: 7566
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D8F RID: 7567
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D90 RID: 7568
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001D91 RID: 7569
			private static readonly IntPtr NativeFieldInfoPtr__textInfo_5__2;

			// Token: 0x04001D92 RID: 7570
			private static readonly IntPtr NativeFieldInfoPtr__loopCount_5__3;

			// Token: 0x04001D93 RID: 7571
			private static readonly IntPtr NativeFieldInfoPtr__vertexAnim_5__4;

			// Token: 0x04001D94 RID: 7572
			private static readonly IntPtr NativeFieldInfoPtr__cachedMeshInfo_5__5;

			// Token: 0x04001D95 RID: 7573
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001D96 RID: 7574
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D97 RID: 7575
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001D98 RID: 7576
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001D99 RID: 7577
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D9A RID: 7578
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
