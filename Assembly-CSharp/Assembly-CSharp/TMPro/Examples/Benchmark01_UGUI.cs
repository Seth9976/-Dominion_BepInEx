using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro.Examples
{
	// Token: 0x020000FE RID: 254
	public class Benchmark01_UGUI : MonoBehaviour
	{
		// Token: 0x06001E5C RID: 7772 RVA: 0x00077348 File Offset: 0x00075548
		// Note: this type is marked as 'beforefieldinit'.
		static Benchmark01_UGUI()
		{
			Il2CppClassPointerStore<Benchmark01_UGUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "Benchmark01_UGUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Benchmark01_UGUI>.NativeClassPtr);
			Benchmark01_UGUI.NativeFieldInfoPtr_BenchmarkType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01_UGUI>.NativeClassPtr, "BenchmarkType");
			Benchmark01_UGUI.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01_UGUI>.NativeClassPtr, "canvas");
			Benchmark01_UGUI.NativeFieldInfoPtr_TMProFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01_UGUI>.NativeClassPtr, "TMProFont");
			Benchmark01_UGUI.NativeFieldInfoPtr_TextMeshFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01_UGUI>.NativeClassPtr, "TextMeshFont");
			Benchmark01_UGUI.NativeFieldInfoPtr_m_textMeshPro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01_UGUI>.NativeClassPtr, "m_textMeshPro");
			Benchmark01_UGUI.NativeFieldInfoPtr_m_textMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01_UGUI>.NativeClassPtr, "m_textMesh");
			Benchmark01_UGUI.NativeFieldInfoPtr_label01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01_UGUI>.NativeClassPtr, "label01");
			Benchmark01_UGUI.NativeFieldInfoPtr_label02 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01_UGUI>.NativeClassPtr, "label02");
			Benchmark01_UGUI.NativeFieldInfoPtr_m_material01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01_UGUI>.NativeClassPtr, "m_material01");
			Benchmark01_UGUI.NativeFieldInfoPtr_m_material02 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01_UGUI>.NativeClassPtr, "m_material02");
			Benchmark01_UGUI.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benchmark01_UGUI>.NativeClassPtr, 100665809);
			Benchmark01_UGUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benchmark01_UGUI>.NativeClassPtr, 100665810);
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x00077468 File Offset: 0x00075668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255674, XrefRangeEnd = 255678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benchmark01_UGUI.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x000774A8 File Offset: 0x000756A8
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Benchmark01_UGUI()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Benchmark01_UGUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benchmark01_UGUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x00012EB0 File Offset: 0x000110B0
		public Benchmark01_UGUI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06001E60 RID: 7776 RVA: 0x000774E4 File Offset: 0x000756E4
		// (set) Token: 0x06001E61 RID: 7777 RVA: 0x00012EB9 File Offset: 0x000110B9
		public unsafe int BenchmarkType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01_UGUI.NativeFieldInfoPtr_BenchmarkType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01_UGUI.NativeFieldInfoPtr_BenchmarkType)) = value;
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06001E62 RID: 7778 RVA: 0x0007750C File Offset: 0x0007570C
		// (set) Token: 0x06001E63 RID: 7779 RVA: 0x00012ED4 File Offset: 0x000110D4
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01_UGUI.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01_UGUI.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06001E64 RID: 7780 RVA: 0x0007753C File Offset: 0x0007573C
		// (set) Token: 0x06001E65 RID: 7781 RVA: 0x00012EF3 File Offset: 0x000110F3
		public unsafe TMP_FontAsset TMProFont
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01_UGUI.NativeFieldInfoPtr_TMProFont);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01_UGUI.NativeFieldInfoPtr_TMProFont), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x0007756C File Offset: 0x0007576C
		// (set) Token: 0x06001E67 RID: 7783 RVA: 0x00012F12 File Offset: 0x00011112
		public unsafe Font TextMeshFont
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01_UGUI.NativeFieldInfoPtr_TextMeshFont);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01_UGUI.NativeFieldInfoPtr_TextMeshFont), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x0007759C File Offset: 0x0007579C
		// (set) Token: 0x06001E69 RID: 7785 RVA: 0x00012F31 File Offset: 0x00011131
		public unsafe TextMeshProUGUI m_textMeshPro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01_UGUI.NativeFieldInfoPtr_m_textMeshPro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01_UGUI.NativeFieldInfoPtr_m_textMeshPro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06001E6A RID: 7786 RVA: 0x000775CC File Offset: 0x000757CC
		// (set) Token: 0x06001E6B RID: 7787 RVA: 0x00012F50 File Offset: 0x00011150
		public unsafe Text m_textMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01_UGUI.NativeFieldInfoPtr_m_textMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01_UGUI.NativeFieldInfoPtr_m_textMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06001E6C RID: 7788 RVA: 0x000775FC File Offset: 0x000757FC
		// (set) Token: 0x06001E6D RID: 7789 RVA: 0x00012F6F File Offset: 0x0001116F
		public unsafe static string label01
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Benchmark01_UGUI.NativeFieldInfoPtr_label01, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Benchmark01_UGUI.NativeFieldInfoPtr_label01, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06001E6E RID: 7790 RVA: 0x0007761C File Offset: 0x0007581C
		// (set) Token: 0x06001E6F RID: 7791 RVA: 0x00012F81 File Offset: 0x00011181
		public unsafe static string label02
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Benchmark01_UGUI.NativeFieldInfoPtr_label02, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Benchmark01_UGUI.NativeFieldInfoPtr_label02, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06001E70 RID: 7792 RVA: 0x0007763C File Offset: 0x0007583C
		// (set) Token: 0x06001E71 RID: 7793 RVA: 0x00012F93 File Offset: 0x00011193
		public unsafe Material m_material01
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01_UGUI.NativeFieldInfoPtr_m_material01);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01_UGUI.NativeFieldInfoPtr_m_material01), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06001E72 RID: 7794 RVA: 0x0007766C File Offset: 0x0007586C
		// (set) Token: 0x06001E73 RID: 7795 RVA: 0x00012FB2 File Offset: 0x000111B2
		public unsafe Material m_material02
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01_UGUI.NativeFieldInfoPtr_m_material02);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01_UGUI.NativeFieldInfoPtr_m_material02), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400149B RID: 5275
		private static readonly IntPtr NativeFieldInfoPtr_BenchmarkType;

		// Token: 0x0400149C RID: 5276
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x0400149D RID: 5277
		private static readonly IntPtr NativeFieldInfoPtr_TMProFont;

		// Token: 0x0400149E RID: 5278
		private static readonly IntPtr NativeFieldInfoPtr_TextMeshFont;

		// Token: 0x0400149F RID: 5279
		private static readonly IntPtr NativeFieldInfoPtr_m_textMeshPro;

		// Token: 0x040014A0 RID: 5280
		private static readonly IntPtr NativeFieldInfoPtr_m_textMesh;

		// Token: 0x040014A1 RID: 5281
		private static readonly IntPtr NativeFieldInfoPtr_label01;

		// Token: 0x040014A2 RID: 5282
		private static readonly IntPtr NativeFieldInfoPtr_label02;

		// Token: 0x040014A3 RID: 5283
		private static readonly IntPtr NativeFieldInfoPtr_m_material01;

		// Token: 0x040014A4 RID: 5284
		private static readonly IntPtr NativeFieldInfoPtr_m_material02;

		// Token: 0x040014A5 RID: 5285
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x040014A6 RID: 5286
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000223 RID: 547
		[ObfuscatedName("TMPro.Examples.Benchmark01_UGUI+<Start>d__10")]
		public sealed class _Start_d__10 : global::Il2CppSystem.Object
		{
			// Token: 0x06002A6F RID: 10863 RVA: 0x000981C4 File Offset: 0x000963C4
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__10()
			{
				Il2CppClassPointerStore<Benchmark01_UGUI._Start_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Benchmark01_UGUI>.NativeClassPtr, "<Start>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Benchmark01_UGUI._Start_d__10>.NativeClassPtr);
				Benchmark01_UGUI._Start_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01_UGUI._Start_d__10>.NativeClassPtr, "<>1__state");
				Benchmark01_UGUI._Start_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01_UGUI._Start_d__10>.NativeClassPtr, "<>2__current");
				Benchmark01_UGUI._Start_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01_UGUI._Start_d__10>.NativeClassPtr, "<>4__this");
				Benchmark01_UGUI._Start_d__10.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark01_UGUI._Start_d__10>.NativeClassPtr, "<i>5__2");
				Benchmark01_UGUI._Start_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benchmark01_UGUI._Start_d__10>.NativeClassPtr, 100666641);
				Benchmark01_UGUI._Start_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benchmark01_UGUI._Start_d__10>.NativeClassPtr, 100666642);
				Benchmark01_UGUI._Start_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benchmark01_UGUI._Start_d__10>.NativeClassPtr, 100666643);
				Benchmark01_UGUI._Start_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benchmark01_UGUI._Start_d__10>.NativeClassPtr, 100666644);
				Benchmark01_UGUI._Start_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benchmark01_UGUI._Start_d__10>.NativeClassPtr, 100666645);
				Benchmark01_UGUI._Start_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benchmark01_UGUI._Start_d__10>.NativeClassPtr, 100666646);
			}

			// Token: 0x06002A70 RID: 10864 RVA: 0x000982B8 File Offset: 0x000964B8
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Benchmark01_UGUI._Start_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benchmark01_UGUI._Start_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A71 RID: 10865 RVA: 0x00098300 File Offset: 0x00096500
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benchmark01_UGUI._Start_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A72 RID: 10866 RVA: 0x00098334 File Offset: 0x00096534
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255660, XrefRangeEnd = 255669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benchmark01_UGUI._Start_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D5D RID: 3421
			// (get) Token: 0x06002A73 RID: 10867 RVA: 0x00098370 File Offset: 0x00096570
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benchmark01_UGUI._Start_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A74 RID: 10868 RVA: 0x000983B0 File Offset: 0x000965B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255669, XrefRangeEnd = 255674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benchmark01_UGUI._Start_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D5E RID: 3422
			// (get) Token: 0x06002A75 RID: 10869 RVA: 0x000983E4 File Offset: 0x000965E4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benchmark01_UGUI._Start_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A76 RID: 10870 RVA: 0x0001A117 File Offset: 0x00018317
			public _Start_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D59 RID: 3417
			// (get) Token: 0x06002A77 RID: 10871 RVA: 0x00098424 File Offset: 0x00096624
			// (set) Token: 0x06002A78 RID: 10872 RVA: 0x0001A120 File Offset: 0x00018320
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01_UGUI._Start_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01_UGUI._Start_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D5A RID: 3418
			// (get) Token: 0x06002A79 RID: 10873 RVA: 0x0009844C File Offset: 0x0009664C
			// (set) Token: 0x06002A7A RID: 10874 RVA: 0x0001A13B File Offset: 0x0001833B
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01_UGUI._Start_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01_UGUI._Start_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D5B RID: 3419
			// (get) Token: 0x06002A7B RID: 10875 RVA: 0x0009847C File Offset: 0x0009667C
			// (set) Token: 0x06002A7C RID: 10876 RVA: 0x0001A15A File Offset: 0x0001835A
			public unsafe Benchmark01_UGUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01_UGUI._Start_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Benchmark01_UGUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01_UGUI._Start_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D5C RID: 3420
			// (get) Token: 0x06002A7D RID: 10877 RVA: 0x000984AC File Offset: 0x000966AC
			// (set) Token: 0x06002A7E RID: 10878 RVA: 0x0001A179 File Offset: 0x00018379
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01_UGUI._Start_d__10.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark01_UGUI._Start_d__10.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04001CFF RID: 7423
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D00 RID: 7424
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D01 RID: 7425
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001D02 RID: 7426
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04001D03 RID: 7427
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001D04 RID: 7428
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D05 RID: 7429
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001D06 RID: 7430
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001D07 RID: 7431
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D08 RID: 7432
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
