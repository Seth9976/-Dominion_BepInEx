using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000117 RID: 279
	public class VertexZoom : MonoBehaviour
	{
		// Token: 0x06002045 RID: 8261 RVA: 0x0007C278 File Offset: 0x0007A478
		// Note: this type is marked as 'beforefieldinit'.
		static VertexZoom()
		{
			Il2CppClassPointerStore<VertexZoom>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "VertexZoom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VertexZoom>.NativeClassPtr);
			VertexZoom.NativeFieldInfoPtr_AngleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexZoom>.NativeClassPtr, "AngleMultiplier");
			VertexZoom.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexZoom>.NativeClassPtr, "SpeedMultiplier");
			VertexZoom.NativeFieldInfoPtr_CurveScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexZoom>.NativeClassPtr, "CurveScale");
			VertexZoom.NativeFieldInfoPtr_m_TextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexZoom>.NativeClassPtr, "m_TextComponent");
			VertexZoom.NativeFieldInfoPtr_hasTextChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexZoom>.NativeClassPtr, "hasTextChanged");
			VertexZoom.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexZoom>.NativeClassPtr, 100665922);
			VertexZoom.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexZoom>.NativeClassPtr, 100665923);
			VertexZoom.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexZoom>.NativeClassPtr, 100665924);
			VertexZoom.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexZoom>.NativeClassPtr, 100665925);
			VertexZoom.NativeMethodInfoPtr_ON_TEXT_CHANGED_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexZoom>.NativeClassPtr, 100665926);
			VertexZoom.NativeMethodInfoPtr_AnimateVertexColors_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexZoom>.NativeClassPtr, 100665927);
			VertexZoom.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexZoom>.NativeClassPtr, 100665928);
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x0007C398 File Offset: 0x0007A598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257339, XrefRangeEnd = 257342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexZoom.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x0007C3CC File Offset: 0x0007A5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257342, XrefRangeEnd = 257358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexZoom.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x0007C400 File Offset: 0x0007A600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257358, XrefRangeEnd = 257374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexZoom.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x0007C434 File Offset: 0x0007A634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257374, XrefRangeEnd = 257380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexZoom.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x0007C468 File Offset: 0x0007A668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257380, XrefRangeEnd = 257384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ON_TEXT_CHANGED(global::UnityEngine.Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexZoom.NativeMethodInfoPtr_ON_TEXT_CHANGED_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x0007C4AC File Offset: 0x0007A6AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257384, XrefRangeEnd = 257388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator AnimateVertexColors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexZoom.NativeMethodInfoPtr_AnimateVertexColors_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x0007C4EC File Offset: 0x0007A6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VertexZoom()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VertexZoom>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexZoom.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x00014157 File Offset: 0x00012357
		public VertexZoom(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x0600204E RID: 8270 RVA: 0x0007C528 File Offset: 0x0007A728
		// (set) Token: 0x0600204F RID: 8271 RVA: 0x00014160 File Offset: 0x00012360
		public unsafe float AngleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom.NativeFieldInfoPtr_AngleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom.NativeFieldInfoPtr_AngleMultiplier)) = value;
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06002050 RID: 8272 RVA: 0x0007C550 File Offset: 0x0007A750
		// (set) Token: 0x06002051 RID: 8273 RVA: 0x0001417B File Offset: 0x0001237B
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06002052 RID: 8274 RVA: 0x0007C578 File Offset: 0x0007A778
		// (set) Token: 0x06002053 RID: 8275 RVA: 0x00014196 File Offset: 0x00012396
		public unsafe float CurveScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom.NativeFieldInfoPtr_CurveScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom.NativeFieldInfoPtr_CurveScale)) = value;
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06002054 RID: 8276 RVA: 0x0007C5A0 File Offset: 0x0007A7A0
		// (set) Token: 0x06002055 RID: 8277 RVA: 0x000141B1 File Offset: 0x000123B1
		public unsafe TMP_Text m_TextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom.NativeFieldInfoPtr_m_TextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom.NativeFieldInfoPtr_m_TextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06002056 RID: 8278 RVA: 0x0007C5D0 File Offset: 0x0007A7D0
		// (set) Token: 0x06002057 RID: 8279 RVA: 0x000141D0 File Offset: 0x000123D0
		public unsafe bool hasTextChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom.NativeFieldInfoPtr_hasTextChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom.NativeFieldInfoPtr_hasTextChanged)) = value;
			}
		}

		// Token: 0x040015AF RID: 5551
		private static readonly IntPtr NativeFieldInfoPtr_AngleMultiplier;

		// Token: 0x040015B0 RID: 5552
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x040015B1 RID: 5553
		private static readonly IntPtr NativeFieldInfoPtr_CurveScale;

		// Token: 0x040015B2 RID: 5554
		private static readonly IntPtr NativeFieldInfoPtr_m_TextComponent;

		// Token: 0x040015B3 RID: 5555
		private static readonly IntPtr NativeFieldInfoPtr_hasTextChanged;

		// Token: 0x040015B4 RID: 5556
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040015B5 RID: 5557
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040015B6 RID: 5558
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040015B7 RID: 5559
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040015B8 RID: 5560
		private static readonly IntPtr NativeMethodInfoPtr_ON_TEXT_CHANGED_Private_Void_Object_0;

		// Token: 0x040015B9 RID: 5561
		private static readonly IntPtr NativeMethodInfoPtr_AnimateVertexColors_Private_IEnumerator_0;

		// Token: 0x040015BA RID: 5562
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000236 RID: 566
		[ObfuscatedName("TMPro.Examples.VertexZoom+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002B65 RID: 11109 RVA: 0x0009AD5C File Offset: 0x00098F5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<VertexZoom.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VertexZoom>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VertexZoom.__c__DisplayClass10_0>.NativeClassPtr);
				VertexZoom.__c__DisplayClass10_0.NativeFieldInfoPtr_modifiedCharScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexZoom.__c__DisplayClass10_0>.NativeClassPtr, "modifiedCharScale");
				VertexZoom.__c__DisplayClass10_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexZoom.__c__DisplayClass10_0>.NativeClassPtr, "<>9__0");
				VertexZoom.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexZoom.__c__DisplayClass10_0>.NativeClassPtr, 100666713);
				VertexZoom.__c__DisplayClass10_0.NativeMethodInfoPtr__AnimateVertexColors_b__0_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexZoom.__c__DisplayClass10_0>.NativeClassPtr, 100666714);
			}

			// Token: 0x06002B66 RID: 11110 RVA: 0x0009ADD8 File Offset: 0x00098FD8
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VertexZoom.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexZoom.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B67 RID: 11111 RVA: 0x0009AE14 File Offset: 0x00099014
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257268, XrefRangeEnd = 257272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AnimateVertexColors_b__0(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexZoom.__c__DisplayClass10_0.NativeMethodInfoPtr__AnimateVertexColors_b__0_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002B68 RID: 11112 RVA: 0x0001A9EF File Offset: 0x00018BEF
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DBB RID: 3515
			// (get) Token: 0x06002B69 RID: 11113 RVA: 0x0009AE6C File Offset: 0x0009906C
			// (set) Token: 0x06002B6A RID: 11114 RVA: 0x0001A9F8 File Offset: 0x00018BF8
			public unsafe List<float> modifiedCharScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom.__c__DisplayClass10_0.NativeFieldInfoPtr_modifiedCharScale);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom.__c__DisplayClass10_0.NativeFieldInfoPtr_modifiedCharScale), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DBC RID: 3516
			// (get) Token: 0x06002B6B RID: 11115 RVA: 0x0009AE9C File Offset: 0x0009909C
			// (set) Token: 0x06002B6C RID: 11116 RVA: 0x0001AA17 File Offset: 0x00018C17
			public unsafe Comparison<int> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom.__c__DisplayClass10_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom.__c__DisplayClass10_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001DB1 RID: 7601
			private static readonly IntPtr NativeFieldInfoPtr_modifiedCharScale;

			// Token: 0x04001DB2 RID: 7602
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04001DB3 RID: 7603
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001DB4 RID: 7604
			private static readonly IntPtr NativeMethodInfoPtr__AnimateVertexColors_b__0_Internal_Int32_Int32_Int32_0;
		}

		// Token: 0x02000237 RID: 567
		[ObfuscatedName("TMPro.Examples.VertexZoom+<AnimateVertexColors>d__10")]
		public sealed class _AnimateVertexColors_d__10 : global::Il2CppSystem.Object
		{
			// Token: 0x06002B6D RID: 11117 RVA: 0x0009AECC File Offset: 0x000990CC
			// Note: this type is marked as 'beforefieldinit'.
			static _AnimateVertexColors_d__10()
			{
				Il2CppClassPointerStore<VertexZoom._AnimateVertexColors_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VertexZoom>.NativeClassPtr, "<AnimateVertexColors>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VertexZoom._AnimateVertexColors_d__10>.NativeClassPtr);
				VertexZoom._AnimateVertexColors_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexZoom._AnimateVertexColors_d__10>.NativeClassPtr, "<>1__state");
				VertexZoom._AnimateVertexColors_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexZoom._AnimateVertexColors_d__10>.NativeClassPtr, "<>2__current");
				VertexZoom._AnimateVertexColors_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexZoom._AnimateVertexColors_d__10>.NativeClassPtr, "<>4__this");
				VertexZoom._AnimateVertexColors_d__10.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexZoom._AnimateVertexColors_d__10>.NativeClassPtr, "<>8__1");
				VertexZoom._AnimateVertexColors_d__10.NativeFieldInfoPtr__textInfo_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexZoom._AnimateVertexColors_d__10>.NativeClassPtr, "<textInfo>5__2");
				VertexZoom._AnimateVertexColors_d__10.NativeFieldInfoPtr__cachedMeshInfoVertexData_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexZoom._AnimateVertexColors_d__10>.NativeClassPtr, "<cachedMeshInfoVertexData>5__3");
				VertexZoom._AnimateVertexColors_d__10.NativeFieldInfoPtr__scaleSortingOrder_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexZoom._AnimateVertexColors_d__10>.NativeClassPtr, "<scaleSortingOrder>5__4");
				VertexZoom._AnimateVertexColors_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexZoom._AnimateVertexColors_d__10>.NativeClassPtr, 100666715);
				VertexZoom._AnimateVertexColors_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexZoom._AnimateVertexColors_d__10>.NativeClassPtr, 100666716);
				VertexZoom._AnimateVertexColors_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexZoom._AnimateVertexColors_d__10>.NativeClassPtr, 100666717);
				VertexZoom._AnimateVertexColors_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexZoom._AnimateVertexColors_d__10>.NativeClassPtr, 100666718);
				VertexZoom._AnimateVertexColors_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexZoom._AnimateVertexColors_d__10>.NativeClassPtr, 100666719);
				VertexZoom._AnimateVertexColors_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexZoom._AnimateVertexColors_d__10>.NativeClassPtr, 100666720);
			}

			// Token: 0x06002B6E RID: 11118 RVA: 0x0009AFFC File Offset: 0x000991FC
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AnimateVertexColors_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VertexZoom._AnimateVertexColors_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexZoom._AnimateVertexColors_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B6F RID: 11119 RVA: 0x0009B044 File Offset: 0x00099244
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexZoom._AnimateVertexColors_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B70 RID: 11120 RVA: 0x0009B078 File Offset: 0x00099278
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257272, XrefRangeEnd = 257334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexZoom._AnimateVertexColors_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000DC4 RID: 3524
			// (get) Token: 0x06002B71 RID: 11121 RVA: 0x0009B0B4 File Offset: 0x000992B4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexZoom._AnimateVertexColors_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B72 RID: 11122 RVA: 0x0009B0F4 File Offset: 0x000992F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257334, XrefRangeEnd = 257339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexZoom._AnimateVertexColors_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DC5 RID: 3525
			// (get) Token: 0x06002B73 RID: 11123 RVA: 0x0009B128 File Offset: 0x00099328
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexZoom._AnimateVertexColors_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B74 RID: 11124 RVA: 0x0001AA36 File Offset: 0x00018C36
			public _AnimateVertexColors_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DBD RID: 3517
			// (get) Token: 0x06002B75 RID: 11125 RVA: 0x0009B168 File Offset: 0x00099368
			// (set) Token: 0x06002B76 RID: 11126 RVA: 0x0001AA3F File Offset: 0x00018C3F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom._AnimateVertexColors_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom._AnimateVertexColors_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000DBE RID: 3518
			// (get) Token: 0x06002B77 RID: 11127 RVA: 0x0009B190 File Offset: 0x00099390
			// (set) Token: 0x06002B78 RID: 11128 RVA: 0x0001AA5A File Offset: 0x00018C5A
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom._AnimateVertexColors_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom._AnimateVertexColors_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DBF RID: 3519
			// (get) Token: 0x06002B79 RID: 11129 RVA: 0x0009B1C0 File Offset: 0x000993C0
			// (set) Token: 0x06002B7A RID: 11130 RVA: 0x0001AA79 File Offset: 0x00018C79
			public unsafe VertexZoom __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom._AnimateVertexColors_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VertexZoom>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom._AnimateVertexColors_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DC0 RID: 3520
			// (get) Token: 0x06002B7B RID: 11131 RVA: 0x0009B1F0 File Offset: 0x000993F0
			// (set) Token: 0x06002B7C RID: 11132 RVA: 0x0001AA98 File Offset: 0x00018C98
			public unsafe VertexZoom.__c__DisplayClass10_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom._AnimateVertexColors_d__10.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VertexZoom.__c__DisplayClass10_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom._AnimateVertexColors_d__10.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DC1 RID: 3521
			// (get) Token: 0x06002B7D RID: 11133 RVA: 0x0009B220 File Offset: 0x00099420
			// (set) Token: 0x06002B7E RID: 11134 RVA: 0x0001AAB7 File Offset: 0x00018CB7
			public unsafe TMP_TextInfo _textInfo_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom._AnimateVertexColors_d__10.NativeFieldInfoPtr__textInfo_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_TextInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom._AnimateVertexColors_d__10.NativeFieldInfoPtr__textInfo_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DC2 RID: 3522
			// (get) Token: 0x06002B7F RID: 11135 RVA: 0x0009B250 File Offset: 0x00099450
			// (set) Token: 0x06002B80 RID: 11136 RVA: 0x0001AAD6 File Offset: 0x00018CD6
			public unsafe Il2CppReferenceArray<TMP_MeshInfo> _cachedMeshInfoVertexData_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom._AnimateVertexColors_d__10.NativeFieldInfoPtr__cachedMeshInfoVertexData_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_MeshInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom._AnimateVertexColors_d__10.NativeFieldInfoPtr__cachedMeshInfoVertexData_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DC3 RID: 3523
			// (get) Token: 0x06002B81 RID: 11137 RVA: 0x0009B280 File Offset: 0x00099480
			// (set) Token: 0x06002B82 RID: 11138 RVA: 0x0001AAF5 File Offset: 0x00018CF5
			public unsafe List<int> _scaleSortingOrder_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom._AnimateVertexColors_d__10.NativeFieldInfoPtr__scaleSortingOrder_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexZoom._AnimateVertexColors_d__10.NativeFieldInfoPtr__scaleSortingOrder_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001DB5 RID: 7605
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001DB6 RID: 7606
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001DB7 RID: 7607
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001DB8 RID: 7608
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04001DB9 RID: 7609
			private static readonly IntPtr NativeFieldInfoPtr__textInfo_5__2;

			// Token: 0x04001DBA RID: 7610
			private static readonly IntPtr NativeFieldInfoPtr__cachedMeshInfoVertexData_5__3;

			// Token: 0x04001DBB RID: 7611
			private static readonly IntPtr NativeFieldInfoPtr__scaleSortingOrder_5__4;

			// Token: 0x04001DBC RID: 7612
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001DBD RID: 7613
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DBE RID: 7614
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001DBF RID: 7615
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001DC0 RID: 7616
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DC1 RID: 7617
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
