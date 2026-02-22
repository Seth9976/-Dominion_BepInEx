using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x020000FD RID: 253
	public class Benchmark01 : MonoBehaviour
	{
		// Token: 0x06001E44 RID: 7748 RVA: 0x00076FF4 File Offset: 0x000751F4
		// Note: this type is marked as 'beforefieldinit'.
		static Benchmark01()
		{
			Il2CppClassPointerStore<Benchmark01>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "Benchmark01");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Benchmark01>.NativeClassPtr);
			Benchmark01.NativeFieldInfoPtr_BenchmarkType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01>.NativeClassPtr, "BenchmarkType");
			Benchmark01.NativeFieldInfoPtr_TMProFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01>.NativeClassPtr, "TMProFont");
			Benchmark01.NativeFieldInfoPtr_TextMeshFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01>.NativeClassPtr, "TextMeshFont");
			Benchmark01.NativeFieldInfoPtr_m_textMeshPro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01>.NativeClassPtr, "m_textMeshPro");
			Benchmark01.NativeFieldInfoPtr_m_textContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01>.NativeClassPtr, "m_textContainer");
			Benchmark01.NativeFieldInfoPtr_m_textMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01>.NativeClassPtr, "m_textMesh");
			Benchmark01.NativeFieldInfoPtr_label01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01>.NativeClassPtr, "label01");
			Benchmark01.NativeFieldInfoPtr_label02 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01>.NativeClassPtr, "label02");
			Benchmark01.NativeFieldInfoPtr_m_material01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01>.NativeClassPtr, "m_material01");
			Benchmark01.NativeFieldInfoPtr_m_material02 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01>.NativeClassPtr, "m_material02");
			Benchmark01.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benchmark01>.NativeClassPtr, 100665807);
			Benchmark01.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benchmark01>.NativeClassPtr, 100665808);
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x00077114 File Offset: 0x00075314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255656, XrefRangeEnd = 255660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benchmark01.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x00077154 File Offset: 0x00075354
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Benchmark01()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Benchmark01>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benchmark01.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x00012D8F File Offset: 0x00010F8F
		public Benchmark01(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06001E48 RID: 7752 RVA: 0x00077190 File Offset: 0x00075390
		// (set) Token: 0x06001E49 RID: 7753 RVA: 0x00012D98 File Offset: 0x00010F98
		public unsafe int BenchmarkType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01.NativeFieldInfoPtr_BenchmarkType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01.NativeFieldInfoPtr_BenchmarkType)) = value;
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06001E4A RID: 7754 RVA: 0x000771B8 File Offset: 0x000753B8
		// (set) Token: 0x06001E4B RID: 7755 RVA: 0x00012DB3 File Offset: 0x00010FB3
		public unsafe TMP_FontAsset TMProFont
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01.NativeFieldInfoPtr_TMProFont);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01.NativeFieldInfoPtr_TMProFont), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06001E4C RID: 7756 RVA: 0x000771E8 File Offset: 0x000753E8
		// (set) Token: 0x06001E4D RID: 7757 RVA: 0x00012DD2 File Offset: 0x00010FD2
		public unsafe Font TextMeshFont
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01.NativeFieldInfoPtr_TextMeshFont);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01.NativeFieldInfoPtr_TextMeshFont), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06001E4E RID: 7758 RVA: 0x00077218 File Offset: 0x00075418
		// (set) Token: 0x06001E4F RID: 7759 RVA: 0x00012DF1 File Offset: 0x00010FF1
		public unsafe TextMeshPro m_textMeshPro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01.NativeFieldInfoPtr_m_textMeshPro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01.NativeFieldInfoPtr_m_textMeshPro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06001E50 RID: 7760 RVA: 0x00077248 File Offset: 0x00075448
		// (set) Token: 0x06001E51 RID: 7761 RVA: 0x00012E10 File Offset: 0x00011010
		public unsafe TextContainer m_textContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01.NativeFieldInfoPtr_m_textContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01.NativeFieldInfoPtr_m_textContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06001E52 RID: 7762 RVA: 0x00077278 File Offset: 0x00075478
		// (set) Token: 0x06001E53 RID: 7763 RVA: 0x00012E2F File Offset: 0x0001102F
		public unsafe TextMesh m_textMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01.NativeFieldInfoPtr_m_textMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01.NativeFieldInfoPtr_m_textMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06001E54 RID: 7764 RVA: 0x000772A8 File Offset: 0x000754A8
		// (set) Token: 0x06001E55 RID: 7765 RVA: 0x00012E4E File Offset: 0x0001104E
		public unsafe static string label01
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Benchmark01.NativeFieldInfoPtr_label01, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Benchmark01.NativeFieldInfoPtr_label01, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06001E56 RID: 7766 RVA: 0x000772C8 File Offset: 0x000754C8
		// (set) Token: 0x06001E57 RID: 7767 RVA: 0x00012E60 File Offset: 0x00011060
		public unsafe static string label02
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Benchmark01.NativeFieldInfoPtr_label02, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Benchmark01.NativeFieldInfoPtr_label02, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06001E58 RID: 7768 RVA: 0x000772E8 File Offset: 0x000754E8
		// (set) Token: 0x06001E59 RID: 7769 RVA: 0x00012E72 File Offset: 0x00011072
		public unsafe Material m_material01
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01.NativeFieldInfoPtr_m_material01);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01.NativeFieldInfoPtr_m_material01), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x00077318 File Offset: 0x00075518
		// (set) Token: 0x06001E5B RID: 7771 RVA: 0x00012E91 File Offset: 0x00011091
		public unsafe Material m_material02
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01.NativeFieldInfoPtr_m_material02);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01.NativeFieldInfoPtr_m_material02), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400148F RID: 5263
		private static readonly IntPtr NativeFieldInfoPtr_BenchmarkType;

		// Token: 0x04001490 RID: 5264
		private static readonly IntPtr NativeFieldInfoPtr_TMProFont;

		// Token: 0x04001491 RID: 5265
		private static readonly IntPtr NativeFieldInfoPtr_TextMeshFont;

		// Token: 0x04001492 RID: 5266
		private static readonly IntPtr NativeFieldInfoPtr_m_textMeshPro;

		// Token: 0x04001493 RID: 5267
		private static readonly IntPtr NativeFieldInfoPtr_m_textContainer;

		// Token: 0x04001494 RID: 5268
		private static readonly IntPtr NativeFieldInfoPtr_m_textMesh;

		// Token: 0x04001495 RID: 5269
		private static readonly IntPtr NativeFieldInfoPtr_label01;

		// Token: 0x04001496 RID: 5270
		private static readonly IntPtr NativeFieldInfoPtr_label02;

		// Token: 0x04001497 RID: 5271
		private static readonly IntPtr NativeFieldInfoPtr_m_material01;

		// Token: 0x04001498 RID: 5272
		private static readonly IntPtr NativeFieldInfoPtr_m_material02;

		// Token: 0x04001499 RID: 5273
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x0400149A RID: 5274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000222 RID: 546
		[ObfuscatedName("TMPro.Examples.Benchmark01+<Start>d__10")]
		public sealed class _Start_d__10 : global::Il2CppSystem.Object
		{
			// Token: 0x06002A5F RID: 10847 RVA: 0x00097EB4 File Offset: 0x000960B4
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__10()
			{
				Il2CppClassPointerStore<Benchmark01._Start_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Benchmark01>.NativeClassPtr, "<Start>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Benchmark01._Start_d__10>.NativeClassPtr);
				Benchmark01._Start_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01._Start_d__10>.NativeClassPtr, "<>1__state");
				Benchmark01._Start_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01._Start_d__10>.NativeClassPtr, "<>2__current");
				Benchmark01._Start_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01._Start_d__10>.NativeClassPtr, "<>4__this");
				Benchmark01._Start_d__10.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01._Start_d__10>.NativeClassPtr, "<i>5__2");
				Benchmark01._Start_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benchmark01._Start_d__10>.NativeClassPtr, 100666635);
				Benchmark01._Start_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benchmark01._Start_d__10>.NativeClassPtr, 100666636);
				Benchmark01._Start_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benchmark01._Start_d__10>.NativeClassPtr, 100666637);
				Benchmark01._Start_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benchmark01._Start_d__10>.NativeClassPtr, 100666638);
				Benchmark01._Start_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benchmark01._Start_d__10>.NativeClassPtr, 100666639);
				Benchmark01._Start_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benchmark01._Start_d__10>.NativeClassPtr, 100666640);
			}

			// Token: 0x06002A60 RID: 10848 RVA: 0x00097FA8 File Offset: 0x000961A8
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Benchmark01._Start_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benchmark01._Start_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A61 RID: 10849 RVA: 0x00097FF0 File Offset: 0x000961F0
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benchmark01._Start_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A62 RID: 10850 RVA: 0x00098024 File Offset: 0x00096224
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255636, XrefRangeEnd = 255651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benchmark01._Start_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D57 RID: 3415
			// (get) Token: 0x06002A63 RID: 10851 RVA: 0x00098060 File Offset: 0x00096260
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benchmark01._Start_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A64 RID: 10852 RVA: 0x000980A0 File Offset: 0x000962A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255651, XrefRangeEnd = 255656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benchmark01._Start_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D58 RID: 3416
			// (get) Token: 0x06002A65 RID: 10853 RVA: 0x000980D4 File Offset: 0x000962D4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benchmark01._Start_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A66 RID: 10854 RVA: 0x0001A09A File Offset: 0x0001829A
			public _Start_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D53 RID: 3411
			// (get) Token: 0x06002A67 RID: 10855 RVA: 0x00098114 File Offset: 0x00096314
			// (set) Token: 0x06002A68 RID: 10856 RVA: 0x0001A0A3 File Offset: 0x000182A3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01._Start_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01._Start_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D54 RID: 3412
			// (get) Token: 0x06002A69 RID: 10857 RVA: 0x0009813C File Offset: 0x0009633C
			// (set) Token: 0x06002A6A RID: 10858 RVA: 0x0001A0BE File Offset: 0x000182BE
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01._Start_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01._Start_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D55 RID: 3413
			// (get) Token: 0x06002A6B RID: 10859 RVA: 0x0009816C File Offset: 0x0009636C
			// (set) Token: 0x06002A6C RID: 10860 RVA: 0x0001A0DD File Offset: 0x000182DD
			public unsafe Benchmark01 __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01._Start_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Benchmark01>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01._Start_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D56 RID: 3414
			// (get) Token: 0x06002A6D RID: 10861 RVA: 0x0009819C File Offset: 0x0009639C
			// (set) Token: 0x06002A6E RID: 10862 RVA: 0x0001A0FC File Offset: 0x000182FC
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01._Start_d__10.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01._Start_d__10.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04001CF5 RID: 7413
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001CF6 RID: 7414
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001CF7 RID: 7415
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001CF8 RID: 7416
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04001CF9 RID: 7417
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001CFA RID: 7418
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CFB RID: 7419
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001CFC RID: 7420
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001CFD RID: 7421
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CFE RID: 7422
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
