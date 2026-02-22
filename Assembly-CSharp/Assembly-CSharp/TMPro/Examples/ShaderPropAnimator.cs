using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000104 RID: 260
	public class ShaderPropAnimator : MonoBehaviour
	{
		// Token: 0x06001EE9 RID: 7913 RVA: 0x000786DC File Offset: 0x000768DC
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderPropAnimator()
		{
			Il2CppClassPointerStore<ShaderPropAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "ShaderPropAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderPropAnimator>.NativeClassPtr);
			ShaderPropAnimator.NativeFieldInfoPtr_m_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropAnimator>.NativeClassPtr, "m_Renderer");
			ShaderPropAnimator.NativeFieldInfoPtr_m_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropAnimator>.NativeClassPtr, "m_Material");
			ShaderPropAnimator.NativeFieldInfoPtr_GlowCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropAnimator>.NativeClassPtr, "GlowCurve");
			ShaderPropAnimator.NativeFieldInfoPtr_m_frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropAnimator>.NativeClassPtr, "m_frame");
			ShaderPropAnimator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPropAnimator>.NativeClassPtr, 100665826);
			ShaderPropAnimator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPropAnimator>.NativeClassPtr, 100665827);
			ShaderPropAnimator.NativeMethodInfoPtr_AnimateProperties_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPropAnimator>.NativeClassPtr, 100665828);
			ShaderPropAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPropAnimator>.NativeClassPtr, 100665829);
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x000787AC File Offset: 0x000769AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255992, XrefRangeEnd = 255996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderPropAnimator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x000787E0 File Offset: 0x000769E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255996, XrefRangeEnd = 256002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderPropAnimator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x00078814 File Offset: 0x00076A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256002, XrefRangeEnd = 256006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator AnimateProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderPropAnimator.NativeMethodInfoPtr_AnimateProperties_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x00078854 File Offset: 0x00076A54
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShaderPropAnimator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderPropAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderPropAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x000134E2 File Offset: 0x000116E2
		public ShaderPropAnimator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06001EEF RID: 7919 RVA: 0x00078890 File Offset: 0x00076A90
		// (set) Token: 0x06001EF0 RID: 7920 RVA: 0x000134EB File Offset: 0x000116EB
		public unsafe Renderer m_Renderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPropAnimator.NativeFieldInfoPtr_m_Renderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPropAnimator.NativeFieldInfoPtr_m_Renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06001EF1 RID: 7921 RVA: 0x000788C0 File Offset: 0x00076AC0
		// (set) Token: 0x06001EF2 RID: 7922 RVA: 0x0001350A File Offset: 0x0001170A
		public unsafe Material m_Material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPropAnimator.NativeFieldInfoPtr_m_Material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPropAnimator.NativeFieldInfoPtr_m_Material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x000788F0 File Offset: 0x00076AF0
		// (set) Token: 0x06001EF4 RID: 7924 RVA: 0x00013529 File Offset: 0x00011729
		public unsafe AnimationCurve GlowCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPropAnimator.NativeFieldInfoPtr_GlowCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPropAnimator.NativeFieldInfoPtr_GlowCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x00078920 File Offset: 0x00076B20
		// (set) Token: 0x06001EF6 RID: 7926 RVA: 0x00013548 File Offset: 0x00011748
		public unsafe float m_frame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPropAnimator.NativeFieldInfoPtr_m_frame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPropAnimator.NativeFieldInfoPtr_m_frame)) = value;
			}
		}

		// Token: 0x040014E4 RID: 5348
		private static readonly IntPtr NativeFieldInfoPtr_m_Renderer;

		// Token: 0x040014E5 RID: 5349
		private static readonly IntPtr NativeFieldInfoPtr_m_Material;

		// Token: 0x040014E6 RID: 5350
		private static readonly IntPtr NativeFieldInfoPtr_GlowCurve;

		// Token: 0x040014E7 RID: 5351
		private static readonly IntPtr NativeFieldInfoPtr_m_frame;

		// Token: 0x040014E8 RID: 5352
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040014E9 RID: 5353
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040014EA RID: 5354
		private static readonly IntPtr NativeMethodInfoPtr_AnimateProperties_Private_IEnumerator_0;

		// Token: 0x040014EB RID: 5355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000226 RID: 550
		[ObfuscatedName("TMPro.Examples.ShaderPropAnimator+<AnimateProperties>d__6")]
		public sealed class _AnimateProperties_d__6 : global::Il2CppSystem.Object
		{
			// Token: 0x06002A7F RID: 10879 RVA: 0x000984D4 File Offset: 0x000966D4
			// Note: this type is marked as 'beforefieldinit'.
			static _AnimateProperties_d__6()
			{
				Il2CppClassPointerStore<ShaderPropAnimator._AnimateProperties_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderPropAnimator>.NativeClassPtr, "<AnimateProperties>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderPropAnimator._AnimateProperties_d__6>.NativeClassPtr);
				ShaderPropAnimator._AnimateProperties_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropAnimator._AnimateProperties_d__6>.NativeClassPtr, "<>1__state");
				ShaderPropAnimator._AnimateProperties_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropAnimator._AnimateProperties_d__6>.NativeClassPtr, "<>2__current");
				ShaderPropAnimator._AnimateProperties_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropAnimator._AnimateProperties_d__6>.NativeClassPtr, "<>4__this");
				ShaderPropAnimator._AnimateProperties_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPropAnimator._AnimateProperties_d__6>.NativeClassPtr, 100666647);
				ShaderPropAnimator._AnimateProperties_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPropAnimator._AnimateProperties_d__6>.NativeClassPtr, 100666648);
				ShaderPropAnimator._AnimateProperties_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPropAnimator._AnimateProperties_d__6>.NativeClassPtr, 100666649);
				ShaderPropAnimator._AnimateProperties_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPropAnimator._AnimateProperties_d__6>.NativeClassPtr, 100666650);
				ShaderPropAnimator._AnimateProperties_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPropAnimator._AnimateProperties_d__6>.NativeClassPtr, 100666651);
				ShaderPropAnimator._AnimateProperties_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderPropAnimator._AnimateProperties_d__6>.NativeClassPtr, 100666652);
			}

			// Token: 0x06002A80 RID: 10880 RVA: 0x000985B4 File Offset: 0x000967B4
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AnimateProperties_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderPropAnimator._AnimateProperties_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderPropAnimator._AnimateProperties_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A81 RID: 10881 RVA: 0x000985FC File Offset: 0x000967FC
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderPropAnimator._AnimateProperties_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A82 RID: 10882 RVA: 0x00098630 File Offset: 0x00096830
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255972, XrefRangeEnd = 255987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderPropAnimator._AnimateProperties_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D62 RID: 3426
			// (get) Token: 0x06002A83 RID: 10883 RVA: 0x0009866C File Offset: 0x0009686C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderPropAnimator._AnimateProperties_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A84 RID: 10884 RVA: 0x000986AC File Offset: 0x000968AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255987, XrefRangeEnd = 255992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderPropAnimator._AnimateProperties_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D63 RID: 3427
			// (get) Token: 0x06002A85 RID: 10885 RVA: 0x000986E0 File Offset: 0x000968E0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderPropAnimator._AnimateProperties_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A86 RID: 10886 RVA: 0x0001A194 File Offset: 0x00018394
			public _AnimateProperties_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D5F RID: 3423
			// (get) Token: 0x06002A87 RID: 10887 RVA: 0x00098720 File Offset: 0x00096920
			// (set) Token: 0x06002A88 RID: 10888 RVA: 0x0001A19D File Offset: 0x0001839D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPropAnimator._AnimateProperties_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPropAnimator._AnimateProperties_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D60 RID: 3424
			// (get) Token: 0x06002A89 RID: 10889 RVA: 0x00098748 File Offset: 0x00096948
			// (set) Token: 0x06002A8A RID: 10890 RVA: 0x0001A1B8 File Offset: 0x000183B8
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPropAnimator._AnimateProperties_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPropAnimator._AnimateProperties_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D61 RID: 3425
			// (get) Token: 0x06002A8B RID: 10891 RVA: 0x00098778 File Offset: 0x00096978
			// (set) Token: 0x06002A8C RID: 10892 RVA: 0x0001A1D7 File Offset: 0x000183D7
			public unsafe ShaderPropAnimator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPropAnimator._AnimateProperties_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShaderPropAnimator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderPropAnimator._AnimateProperties_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D11 RID: 7441
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D12 RID: 7442
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D13 RID: 7443
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001D14 RID: 7444
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001D15 RID: 7445
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D16 RID: 7446
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001D17 RID: 7447
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001D18 RID: 7448
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D19 RID: 7449
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
